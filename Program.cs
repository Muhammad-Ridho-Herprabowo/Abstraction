using System;

//Abstrac Class
public abstract class G
{


    public abstract void gfg1();
}


public class G1 : G
{


    public override void gfg1()
    {
        Console.WriteLine("Abstrac Class");
        Console.WriteLine("Nama     :   Muhammad Ridho Herprabowo");
        Console.WriteLine("NIM      :   19.11.2792");
        Console.WriteLine("Kelas    :   19 IF 03");
    }


}
//Interface
interface interface1
{


    void show();
}

class MyClass : interface1
{


    public void show()
    {
        Console.WriteLine("Interface");
        Console.WriteLine("Universitas Amikom Yogyakarta");
    }
    public class main_method
    {

        public static void Main(string[] args)
        {

            G obj;

            obj = new G1();


            obj.gfg1();
            Console.WriteLine();

            MyClass obj1 = new MyClass();


            obj1.show();


        }
    }
}
