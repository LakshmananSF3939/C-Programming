namespace TDD;

[TestFixture]
public class Tests
{
    Maths operation=null;
    Maths operation1=null;
    Maths operation2=null;

    [SetUp]
    public void Setup()
    {
        operation=new Maths();
        operation1=new Maths();
        operation2=new Maths();
    }

    [Test]
    public void Test1()
    {
        int result=operation.Addtion(10,11);
        Assert.That(result,Is.EqualTo(21));
    }
    [TestCase(10,20,30)]
    [TestCase(1,2,3)]
    public void IsAdditionOk(int val1,int val2,int result)
    {
        int output=operation.Addtion(val1,val2);
        Assert.AreEqual(output,result);
    }
    [TestCase(1.2,2.1,3.3)]
    public void IsAdditionOk(double value1,double value2,double result)
    {
        double output=operation.Addtion(value1,value2);
        Assert.AreEqual(output,result);
    }
    [TestCase("Ravi","Chandran","Ravi chandran")]
    public void IsAdditionOk(string str1,string str2,string result)
    {
        string output=operation.Addtion(str1,str2);
        Assert.AreEqual(output,result);
    }
}