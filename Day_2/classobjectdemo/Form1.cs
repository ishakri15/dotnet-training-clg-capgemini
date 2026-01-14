namespace classobjectdemo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    class Employee
    {
        int sal;
        int bonus;
        public void totalsalary(int sal1, int bonus1)
        {
            sal = sal1;
            bonus = bonus1;
            int total = sal + bonus;
            MessageBox.Show($"Total Salary is {total}");

        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Employee emp = new Employee();
        emp.totalsalary
            (Convert.ToInt32(textBox1.Text),
            Convert.ToInt32(textBox2.Text));
    }
}
