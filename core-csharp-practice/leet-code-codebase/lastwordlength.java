public class lastwordlength {
    public int lengthOfLastWord(String s) {
        s=s.trim();
        String[] word=s.split("\\s+");
        if(word.length>0){
            return word[word.length-1].length();
        }
        else return 0;
    }
}
