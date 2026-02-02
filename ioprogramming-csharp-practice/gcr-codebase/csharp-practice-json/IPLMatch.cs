using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace IplCensorshipAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            // File paths
            string jsonInput = "ipl_input.json";
            string jsonOutput = "ipl_censored.json";
            string csvInput = "ipl_input.csv";
            string csvOutput = "ipl_censored.csv";

            ProcessJson(jsonInput, jsonOutput);
            ProcessCsv(csvInput, csvOutput);

            Console.WriteLine(" IPL Data Censorship Completed Successfully");
        }

        // ================= JSON PROCESSING =================
        static void ProcessJson(string inputPath, string outputPath)
        {
            string jsonData = File.ReadAllText(inputPath);
            JArray matches = JArray.Parse(jsonData);

            foreach (JObject match in matches)
            {
                string team1 = match["team1"].ToString();
                string team2 = match["team2"].ToString();

                string censoredTeam1 = MaskTeamName(team1);
                string censoredTeam2 = MaskTeamName(team2);

                // Update team names
                match["team1"] = censoredTeam1;
                match["team2"] = censoredTeam2;
                match["winner"] = MaskTeamName(match["winner"].ToString());

                // Redact player of match
                match["player_of_match"] = "REDACTED";

                // Update score keys
                JObject scoreObj = (JObject)match["score"];
                var newScore = new JObject
                {
                    { censoredTeam1, scoreObj[team1] },
                    { censoredTeam2, scoreObj[team2] }
                };

                match["score"] = newScore;
            }

            File.WriteAllText(outputPath, matches.ToString(Formatting.Indented));
        }

        // ================= CSV PROCESSING =================
        static void ProcessCsv(string inputPath, string outputPath)
        {
            var lines = File.ReadAllLines(inputPath).ToList();
            var outputLines = new List<string> { lines[0] }; // header

            for (int i = 1; i < lines.Count; i++)
            {
                var cols = lines[i].Split(',');

                cols[1] = MaskTeamName(cols[1]); // team1
                cols[2] = MaskTeamName(cols[2]); // team2
                cols[5] = MaskTeamName(cols[5]); // winner
                cols[6] = "REDACTED";             // player_of_match

                outputLines.Add(string.Join(",", cols));
            }

            File.WriteAllLines(outputPath, outputLines);
        }

        // ================= CENSORSHIP RULE =================
        static string MaskTeamName(string teamName)
        {
            string[] parts = teamName.Split(' ');

            if (parts.Length == 1)
                return parts[0] + " ***";

            parts[1] = "***";
            return string.Join(" ", parts);
        }
    }
}
