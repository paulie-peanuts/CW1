// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<string> students = ["bob", "sam"];
List<int> grades = [];
string input;

foreach (string student in students) {
    Console.WriteLine("Grade for " + student + ": ");
    input = Console.ReadLine();
    // grades.Add(grade);
    grades.Add(int.Parse(input));
}
Console.WriteLine(grades[0]);
int[] fourNums = {3,4,5,6};
fourNums[0] = 4;
Console.WriteLine(fourNums[0]);
public class Fruit
{
    public string Name { get; }
    public Fruit (string name)
    {
        Name = name;
    }
}


public class Fruity
{
	public string Name { get; private set; }
	public Fruity() { }
	public Fruity (string name) : this()
	{
		Name = name;
	}
}

