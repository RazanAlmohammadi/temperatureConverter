
class Program{
     static string TempConvert(int temperature,string unit){
    if(unit=="F"){
       return ((temperature-32)*5/9+" C ");
        
    }
    else{
         return ((temperature*1.8)+32 +" F ");
    }
   
}

    public static void Main(string[] args) {
        Console.WriteLine(TempConvert(32,"F"));
         Console.WriteLine(TempConvert(100,"C"));
        
    }
}