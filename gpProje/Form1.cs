using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (exit == DialogResult.Yes) Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor= Color.DimGray;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Silver;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.DimGray;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.f1 = this;
            f2.ShowDialog();
        }

        private void studentnamelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = studentnamelist.SelectedIndex; 
            studentsurnamelist.SelectedIndex = i;
            studentnolist.SelectedIndex = i;
            studentpointlist.SelectedIndex = i;

        }

        private void studentsurnamelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = studentsurnamelist.SelectedIndex;
            studentnamelist.SelectedIndex = i;
            studentnolist.SelectedIndex = i;
            studentpointlist.SelectedIndex = i;
        }

        private void studentnolist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = studentnolist.SelectedIndex;
            studentsurnamelist.SelectedIndex = i;
            studentnamelist.SelectedIndex = i;
            studentpointlist.SelectedIndex = i;
        }

        private void studentpointlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = studentpointlist.SelectedIndex;
            studentsurnamelist.SelectedIndex = i;
            studentnolist.SelectedIndex = i;
            studentnamelist.SelectedIndex = i;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (studentnamelist.SelectedIndex < i)
            {
                MessageBox.Show("Lütfen Önce Silinecek Öğrenciyi Seçiniz!");
            }
            else
            {
                int j = studentnamelist.SelectedIndex;
                
                studentnamelist.Items.RemoveAt(j);
                studentsurnamelist.Items.RemoveAt(j);
                studentnolist.Items.RemoveAt(j);
                studentpointlist.Items.RemoveAt(j);
            }
        }
    }
}
