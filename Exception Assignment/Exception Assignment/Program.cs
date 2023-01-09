using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   class Program
    {
    static void Main(string[] args)
    {

        List<int> numList = new List<int>()
        { 10, 20, 30, 40, 50};
        try
        {
            Console.WriteLine("Please enter a number.");
        int Usernum = Convert.ToInt32(Console.ReadLine());
       
            for (int j = 0; j < numList.Count; j++)
            {
                Console.WriteLine("The number in the list is : " + numList[j] + " This number divided by your number is : " + numList[j] / Usernum);
            }
            Console.ReadLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please Don't divide by Zero");

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();

        }
        Console.ReadLine();
    }
}
    
    

