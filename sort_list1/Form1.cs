using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace sort_list1
{
    public partial class Form1 : Form
    {
        List<Employee> allEmployees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string data = File.ReadAllText(Application.StartupPath + Path.DirectorySeparatorChar + "data.txt");
            txbData.Text = data;
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            allEmployees.Clear();
            PopulateEmployeeList();
            allEmployees.Sort(new NameSorter());
            RePopulateDataTextbox();

        }

        private void btnSortAge_Click(object sender, EventArgs e)
        {
            allEmployees.Clear();
            PopulateEmployeeList();
            allEmployees.Sort(new AgeSorter());
            RePopulateDataTextbox();
        }

        private void btnSortSalary_Click(object sender, EventArgs e)
        {
            allEmployees.Clear();
            PopulateEmployeeList();
            allEmployees.Sort(new SalarySorter());
            RePopulateDataTextbox();
        }

        private void btnSortOccupation_Click(object sender, EventArgs e)
        {
            allEmployees.Clear();
            PopulateEmployeeList();
            allEmployees.Sort(new DesignationSorter());
            RePopulateDataTextbox();
        }

        private void RePopulateDataTextbox()
        {
            txbData.Clear();
            StringBuilder sb = new StringBuilder();
            foreach (Employee emp in allEmployees)
            {
                sb.AppendLine(emp.ToString());
            }
            txbData.Text = sb.ToString();
        }

        private void PopulateEmployeeList()
        {
            string[] lines = txbData.Text.Split(new String[]{Environment.NewLine},StringSplitOptions.None);
            foreach (string line in lines)
            {
                if (line.Length == 0)
                    break;

                string[] parts = line.Split(' ', '@');
                System.Diagnostics.Debug.WriteLine(parts.Length);
                Employee anEmp =
                    new Employee
                    {
                        Name = parts[0],
                        Age = Convert.ToInt32(parts[1].TrimEnd(',')),
                        Salary = Convert.ToDecimal(parts[2]),
                        Designation = parts[3]
                    };
                allEmployees.Add(anEmp);
            }
        }

       
    }
}
