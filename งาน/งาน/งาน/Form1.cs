namespace งาน
{
    public partial class Form1 : Form
    {
        List<Student> studentsList = new List<Student>();
        List<double> GradeList= new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.textBox1.Text;
                string student_id = this.textBox2.Text;
                string birthyear = this.textBox3.Text;
                string height = this.textBox4.Text;
                double grade = double.Parse(this.textBox5.Text);
                string branch = this.textBox6.Text;

                Student student = new Student(name,student_id,birthyear,height,grade,branch);
                studentsList.Add(student);

                BindingSource source = new BindingSource();
                source.DataSource = studentsList;
                this.dataGridView1.DataSource = source;

                foreach (var val in studentsList)
                {
                    this.GradeList.Add(val.Grade);

                }
                double Maxgrade = GradeList.Max();
                double Mingrade = GradeList.Min();

                int allperson = studentsList.Count();

                this.label10.Text = allperson.ToString();
                this.label11.Text = Maxgrade.ToString();
                this.label12.Text = Mingrade.ToString();




            }
            catch
            {
                return;
            }
        }
    }
}