namespace NewApp;
class Practice{
    static void Main(string[] args)
    {
       double qiymet1;
       double qiymet2;
       double final;
       double result;

       Console.WriteLine("Exam evaluation");
       Console.WriteLine("-------------");

       qiymet1 = ExamResult("1. Exam result: ");
       qiymet2 = ExamResult("2. Second exam result: ");
       final = ExamResult("3. Final exam result: ");

       result = (qiymet1 * 0.3) + (qiymet2 * 0.3) + (final * 0.4);

       if(result >= 61 )
         {
            Console.WriteLine("Your Result: " + result);
            Console.WriteLine("You have passed the exam!");
         }
         else
           {
             Console.WriteLine("Your Result: " + result);
             Console.WriteLine("Sorry, you have unfortunately failed from exam.");
           }
     }
     static double ExamResult(string examResults)
    {
        double exam;
        while(true)
        {
            Console.WriteLine(examResults);
            bool success = double.TryParse(Console.ReadLine(), out exam);

            if(!success)
            {
                Console.WriteLine("Wrong entry type. Try again: ");
            }
            else if(exam > 100)
            {
                Console.WriteLine("Result can not exceed 100 point. Try again!: ");
            }
            else if(exam < 0)
            {
                Console.WriteLine("Result can not be less than 0. Try again: ");
            }
            else
            {
                return exam;
            }

        }
    }
}
    
