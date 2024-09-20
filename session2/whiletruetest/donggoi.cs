namespace donggoi;

public class Car
{
    static Car(){
        //static contructor , run only once at call 
    }

    public Car(){
        //// do somthing init data for instance
    }


    string color = "red";

    public string Color
    {
        get
        {

            return color;
        }
        set
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Require value");
            color = value;
        }
    }

    public string BrandName1;

    public void SetColor(string value)
    {
        color = value;
    }
    public void Run()
    {
        Console.WriteLine("donggoi");
        _run1stStep();
    }

    void _run1stStep()
    {

    }

    protected void MoCop() { }
}

public class Vinfast : Car
{

    public void Chay()
    {
        MoCop();
        // OpenDoor():
    }
}
