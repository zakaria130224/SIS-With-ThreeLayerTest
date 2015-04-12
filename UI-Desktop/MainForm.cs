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
using System.Threading;
using DAL;
using BO;


namespace WindowsFormsApplication2
{
    public partial class MainForm : Form
    {
        StudentBO sbo = new StudentBO();
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void button_Save_Click(object sender, EventArgs e)
        {
           
           

            try
            {
                Student st = new Student();
                
                st.name = textBox_Name.Text;
                st.roll = textBox_Roll.Text;
                st.batch = textBox_Batch.Text;
                st.year = comboBox_Year.Text;
                st.term = comboBox_Term.Text;
                st.address = textBox_Home.Text;
                st.contact = textBox_Contact.Text;

                sbo.saveStudentInfo(st);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                
                MessageBox.Show("SAVED");
                textBox_Name.Text = null;
                textBox_Roll.Text = null;
                textBox_Batch.Text = null;
                comboBox_Term.Text = null;
                comboBox_Year.Text = null;
                textBox_Home.Text = null;
                textBox_Contact.Text = null;
            }
   
      
        }

        private void button_Show_Click_1(object sender, EventArgs e)
        {
            Thread t=new Thread(new ThreadStart(MyThread.ShowFromToMain));
            this.Close();
            t.Start();
        }
        public String getName()
        {
            return this.textBox_Name.Text;
        }

        private void textBox_Roll_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Batch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Term_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Year_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Home_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
