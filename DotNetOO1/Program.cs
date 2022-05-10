// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
EmployeManager employeManager = new EmployeManager();


bool contunue = true;
List<string> stringList = new List<string>() { };

//Console.WriteLine("To exit press escape!");
Console.WriteLine("Employe System!");

while (contunue)
{
    AddStringToList();


}

void AddStringToList()
{
    if(stringList.Count % 3 == 0)
    {
        Console.WriteLine("First Name, or type print to get data");
        string first = Console.ReadLine();
        if (first != "print") stringList.Add(first);
        else employeManager.PrintInfo();
    }
    else if (stringList.Count % 3 == 1)
    {
        Console.WriteLine("Second Name, or type print to get data ");
        string second = Console.ReadLine();
        
        if (second != "print") stringList.Add(second);
        else employeManager.PrintInfo();
    }
    else if (stringList.Count % 3 == 2)
    {
        Console.WriteLine("Wage, or type print to get data ");
        string wage = Console.ReadLine();
        if (wage != "print")
        {
            stringList.Add(wage);
            
            Employe temp = SaveStaff();
            employeManager.AddInfo(temp);
        }
        else employeManager.PrintInfo();
    }
}

Employe SaveStaff()
{
    string first = stringList[stringList.Count - 3];
    string second = stringList[stringList.Count - 2]; 
    string wage = stringList[stringList.Count - 1];
    int didgit = Int32.Parse(wage);
    Employe temp = new Employe(first, second, didgit);
    return temp;
}




class EmployeManager
{

    List<Employe> employes = new List<Employe>() { };


    public void AddInfo(Employe newEmploye)
    {
        if (employes.Contains(newEmploye))
        {
            Console.WriteLine("This Employe is already in our advanced database!");
        }
        else employes.Add(newEmploye);
    }

    public void PrintInfo()
    {
        foreach (Employe staff in employes)
        {
            staff.PrintInfo();
        }
    }


}

class Employe
{
    public string first;
    public string second;
    public int wage;

    public Employe(string firstName, string secondName, int salary)
    {
        first = firstName;
        second = secondName;
        wage = salary;

    }

    public void PrintInfo()
    {
        Console.WriteLine(first + " " + second + " " + " has a wage of: " + wage);
    }
}
