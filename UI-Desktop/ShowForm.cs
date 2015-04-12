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
using BO;
using DAL;

namespace WindowsFormsApplication2
{
    public partial class ShowForm : Form
    {
        public ShowForm()
        {


            InitializeComponent();
            this.DataGridViewShow();
           // this.ListViewShow();


        }
        public void DataGridViewShow()
        {
            StudentBO ss = new StudentBO();

            Student[] st;

            st = ss.getStudentInfo();
            

            dataGridView1.ColumnCount = 7;

            dataGridView1.Columns[0].Name = "NAME";
            dataGridView1.Columns[1].Name = "ROLL";
            dataGridView1.Columns[2].Name = "BATCH";
            dataGridView1.Columns[3].Name = "TERM";
            dataGridView1.Columns[4].Name = "YEAR";
            dataGridView1.Columns[5].Name = "HOME";
            dataGridView1.Columns[6].Name = "CONTACT";


            for (int i = 0;; i++)
            {
                if (st[i]==null)
                {
                    break; 
                }
                dataGridView1.Rows.Add(st[i].name,st[i].roll,st[i].batch,st[i].term,st[i].year,st[i].address,st[i].contact);
                
            }
            
          
        }
        //public void ListViewShow()
        //{
        //    StreamReader sr = new StreamReader("D:\\outtxt.txt");
        //    String t;
        //    while ((t = sr.ReadLine()) != null)
        //    {
        //        listBox1.Items.Add(t);


        //    }
        //    sr.Close();


        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(MyThread.MainFromToShow));
            this.Close();
            t.Start();
        }

        private void ShowForm_Load(object sender, EventArgs e)
        {

        }
    }
}
