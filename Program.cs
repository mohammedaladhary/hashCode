namespace hashCode
{
    internal class Person
    {

        public string firstName;
        public string lastName;

        public Person(string f_Name, string l_Name)
        {
            this.firstName = f_Name;
            this.lastName = l_Name;
        }

        public void Show()
        {
            Console.WriteLine("first Name : "+ firstName);

            Console.WriteLine("last Name : " + lastName);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ahmed", "Al Adhary");

            Console.WriteLine("Person details:");
            person.Show();

            // Using GetHashCode() method
            Console.WriteLine("The hash code of object is: {0}", person.GetHashCode());
        }
    }
}
