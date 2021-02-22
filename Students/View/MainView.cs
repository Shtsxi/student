using Students.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students.View
{
    public partial class MainView : Form
    {
        StudentController Controller = new StudentController();
        public MainView()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = txtName.Text;
            student.Age = int.Parse(txtAge.Text);
            Controller.Add(student);

            dgvStudents.DataSource = null;
            dgvStudents.DataSource = Controller.GetAll();
        }
    }
}
