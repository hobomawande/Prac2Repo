using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Program sp=new Program();
            string exp="5,1:hello";
           
        string inp =   sp. Prefix("hello");
            Assert.AreEqual(inp,exp);
            
        }
         [Test]
        public void Test2()
        {
            Program sp=new Program();
            string exp="29,6:hello, how are you, look here";
           
        string inp =   sp. Prefix("hello, how are you, look here");
            Assert.AreEqual(inp,exp);
            
        }
          [Test]
        public void Test3()
        {
            Program sp=new Program();
           string exp="25,5:  what day ... is it??.  ";
           
        string inp =sp.Prefix("  what day ... is it??.  ");
        Assert.AreEqual(inp,exp);
            
        }
       
       
    }
}