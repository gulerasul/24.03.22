using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
         {
           
           

            
        }
    }
    
}
abstract class Person 
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public Person(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }

    public Person()
    {
    }
}
//SalaryOfHour(saatbaşı qazandığı maaş)
//WorkingHour(30 gün ərzində neçə saat işlədiyi)
//CalculateSalary() - Ümumi maaşı hesablayan method
class Employee:Person
{
    internal object person;

    public double SalaryOfHour {
        get
        {
            return SalaryOfHour;
        }
        set
        {
            if (value >1)
            {
                SalaryOfHour = 1;
            }
        }
    }

    public int WorkingHour
    {
        get
        {
            return WorkingHour;
        }
        set
        {
            if (value>180)
            {
                WorkingHour = 180;
            }
        }
    }



    public void CalculateSalary()
    {
        double Cal = WorkingHour * SalaryOfHour;
        Console.WriteLine("1 ay erzinde umumi maash");


    }
    public string CalculateSalary(double SalaryOfHour, int WorkingHour, int age)

    {
        if (age < 18) return "Ishleme huququnuz yoxdur!";
        double Cal = WorkingHour * SalaryOfHour;
        Console.WriteLine("1 ay erzinde umumi maash");

        string text = $"Teyin etdiyiniz ayliq maash: {Cal} azn-dir.";
        if (Cal < 250) text += "\nAyliq maash 250-den ashagi olmamalidir.";

        if (WorkingHour / 22 > 8)
        {
            text = "Ayliq ortalama ish saati 8 saatdan artiq olmalaidir!!!";
        }

        return text;
    }
}
class student : Person
{
    //    IQRank(IQ imtahanının nəticəsi (100 bal üzərindən))
    //   LanguageRank(Dil imtahanının nəticəsi (100 bal üzərindən))


    public int IQRank {
        get
        {
            return 0;
        }
        set
        {
            if (true)
            {

            }
        }
            }
   

    //public void ExamResult()
    //{
    //    int resul = IQRank + LanguageRank;
    //}


}