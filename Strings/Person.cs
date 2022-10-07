namespace Strings;

public class Person
{
    private string _firstName; //public private internal
    private string _lastName;
    private  static int _cnt;

    public Person()
    {
        _firstName = "c";
        _lastName = "d";
        _cnt++;
    }

    public Person(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
        _cnt++;
    }

    /// <summary>
    /// Prints info about person
    /// </summary>
    public void PrintInfo()
    {
        Console.WriteLine($"firstName {_firstName}\nlastName {_lastName} number of object {_cnt}");
    }

    /// <summary>
    /// changes name
    /// </summary>
    /// <param name="name">new name for person</param>
    /// <returns>new name if name was greater than 10 return same</returns>
    public string ChangeName(string name)
    {
        if (name.Length <= 10)
        {
            _firstName = name;
        }

        return name;
    }
}