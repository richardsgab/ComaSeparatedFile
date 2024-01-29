using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComaSeparatedFile;

namespace WindowsF
{
    public partial class Form1 : Form
    {
        static string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
        static string filename = "Test.txt";
        static string filepath = Path.Combine(projectDirectory, filename);

        List<Person> people = new List<Person>();
        List<string> lines = File.ReadAllLines(filepath).ToList();
    public Form1()
        {
            InitializeComponent();
            
        }

        private void lstAllLines_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        
        

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
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
               lstAllLines.Items.Add(item);
                //Console.WriteLine($"{item.FirstName} {item.LastName} {item.Address}");
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.FirstName = txtFirstname.Text;
            person.LastName = txtLastname.Text;
            person.Address = txtAddress.Text;

            people.Add(person);
            lstAllLines.Items.Add(person);

        }
    }
}
