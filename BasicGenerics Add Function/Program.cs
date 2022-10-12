namespace BasicGenerics_Add_Function_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> cities = new MyList<string>();
            cities.Add("London");
            cities.Add("New York");
            cities.Add("Seattle");

            Console.WriteLine(cities.Count);
        }
    }
}