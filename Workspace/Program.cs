using Business.Concrete;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {
        //degiskenler();

        Person person = new Person();
        person.FirstName = "MUAMMER";
        person.LastName = "SÖNMEZ";
        person.DateOfBirthYear = 2004;
        person.NationalIdentity = 27893153682;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person);
      

        Console.ReadLine();
    }



}
