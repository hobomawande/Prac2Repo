using System;


namespace Problems
{
  public  class Program
    {
        public string Prefix(string input){
          if(input==null) return "0,0:";
          int count=input.Length;
      string show;
          int howMany=0;
          string[] splt= input.Split( );
          foreach(string xs in splt){
            
              howMany++;
          }
            show =$"{count},{howMany} :{input}";
        return show;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
