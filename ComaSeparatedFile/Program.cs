using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComaSeparatedFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string filepath = @"c:\demo\blabla  => is not the best solution to create a file

            //make a variable to simuleren  lo de arriba
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filename = "Test.txt";
            string filepath = Path.Combine(projectDirectory, filename);

           // Console.WriteLine(filepath);

            //read from file + get into a List:
            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(filepath).ToList();

            foreach (string line in lines) 
            {
                string[] entries = line.Split(',');
                Person person = new Person();
                person.FirstName = entries[0];
                person.LastName = entries[1];
                person.Address = entries[2];

                people.Add(person);
            }
            Console.WriteLine("Read from txt file");
            foreach (Person item in people) 
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Address}");
            }
            //end reading the file

            //begin writing into file(new entries)
            Console.WriteLine("Write into file");
            people.Add(new Person {FirstName="Olesia", LastName="Khalota", Address="Olesia's address" });
            people.Add(new Person {FirstName="Rik", LastName="Rizka", Address="Rik's address" });

            List<string> output = new List<string>();
            foreach (Person person in people) 
            {
                output.Add($"{person.FirstName}, {person.LastName + ","} {person.Address}");
            }
            File.WriteAllLines(filepath, output);
            Console.WriteLine("records saved in txt file");

        }
        
    }
}
