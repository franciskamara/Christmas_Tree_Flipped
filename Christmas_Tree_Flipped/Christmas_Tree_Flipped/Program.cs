namespace Christmas_Tree_Flipped // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Christmas Tree upside down");

            Console.Write("How many lines do you want to see: ");
            int totalRows = int.Parse(Console.ReadLine());
            
            Console.Clear();
            
            
            for (int rowCount = 0; rowCount <= totalRows; rowCount++)
            {
                for (int spaceCount = 0; spaceCount < rowCount; spaceCount++)
                {
                    Console.Write("  ");
                }
                
                for (int starCount = 0; starCount < (totalRows - rowCount) *2-1 ; starCount++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}