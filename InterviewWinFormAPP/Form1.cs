namespace InterviewWinFormAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadPeople()
        {
            PersonDAO personDAO = new PersonDAO();
            BindingSource source = new BindingSource();
            source.DataSource = personDAO.GetPeople();
            dataGridView1.DataSource = source;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPeople();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            PersonDAO personDAO = new PersonDAO();
            person.personID = (int)idbox.Value;
            person.name = namebox.Text;
            person.age = agebox.Value;
            person.nationalityID = (int)nationalityidbox.Value;
            person.birthdate = datepicker.Value;
            personDAO.insertperson(person);
            LoadPeople();
        }
    }
}
