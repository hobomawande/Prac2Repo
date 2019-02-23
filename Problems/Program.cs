using System;


namespace Problems
{
  public  class Program
    {
        public string Prefix(string input)
        { int count=input.Length;
          if(input==string.Empty) return "0,0:";
        //char[] bs=input.ToCharArray();
        
            string show;
          int howMany=0;
          string[] splt= input.Split( );
          foreach(string xs in splt){
           if(xs==string.Empty){

           }else{
                howMany++;
           }
             
          }
            show =$"{count},{howMany}:{input}";
        return show;

        }
        static void Main(string[] args)
        {
            Program xs=new Program();
         
        }
    }
}
