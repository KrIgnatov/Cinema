using System.Data;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ScreenType = Console.ReadLine();
            int RowNumber = int.Parse(Console.ReadLine());
            int ColumnNumber = int.Parse(Console.ReadLine());

            double TotalPrice = 0.0;

            if (ScreenType == "Premiere")
            {
                TotalPrice = RowNumber * ColumnNumber * 12;
            }
            else if (ScreenType == "Normal") 
            {
                TotalPrice = RowNumber * ColumnNumber * 7.5;
            }
            else if (ScreenType == "Discount") 
            {
                TotalPrice = RowNumber * ColumnNumber * 5;
            }
            Console.WriteLine($"{TotalPrice:f2} leva");
        }
    }
}