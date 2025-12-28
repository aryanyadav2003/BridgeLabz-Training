using System;
class IndexOutOfRangeArrayDemo{
    static void Main(){
        try{
            int[] numbers={10,20,30};
            Console.WriteLine(numbers[5]);
        }
        catch (IndexOutOfRangeException e){
            Console.WriteLine("IndexOutOfRangeException occurred!");
            Console.WriteLine(e.Message);
        }
    }
}
