
class Program
{
     static string TempConvert(double temperature,string unit)
     {
       if(unit=="F")
    {
           return (temperature-32)*5/9+" C ";
        
    }
       else
       {
           return (temperature*1.8)+32 +" F ";
    }
   
}

    public static void Main(string[] args)
     {
        Console.WriteLine("Enter a temperature and its unit (C or F):");
        
       double temperature = Convert.ToDouble(Console.ReadLine());
       string unit = Console.ReadLine();

        Console.WriteLine("Converted: "+temperature+" "+unit+" = "+TempConvert( temperature,unit));
       
        
    }
}