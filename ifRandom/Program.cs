namespace ifRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool theSwitch = true;
            
            while(theSwitch)
            {
                var nr1 = rand.Next(1, 30);
                var nr2 = rand.Next(1, 30);
                Console.ReadKey();
                
                if(nr1 != nr2)
                {
                    Console.WriteLine($"nr1: {nr1}\n\nnr2: {nr2}\n\n");
                }
                else
                {
                    Console.WriteLine($"De er like! og nr som matchet var {nr1}");
                    Console.ReadKey();
                    Console.ReadKey();
                    theSwitch = false;
                }
            }
            
        }
    }
}
