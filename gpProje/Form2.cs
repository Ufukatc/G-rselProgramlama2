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
    public partial class Form2 : Form
    {
        public Form1 f1;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DimGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pointtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pointtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void notxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void surnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "" || surnametxt.Text == "" || notxt.Text == "" || pointtxt.Text == "") MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
            else if (notxt.Text.Length <= 11) MessageBox.Show("Öğrenci Numarası 12 Haneli Olmalıdır!");
            else
            {
                int point = int.Parse(pointtxt.Text);
                if (point > 100) MessageBox.Show("Öğrenci Notu 100'den Büyük Olamaz!");
                else
                {
                    f1.studentnamelist.Items.Add(nametxt.Text);
                    f1.studentsurnamelist.Items.Add(surnametxt.Text);
                    f1.studentnolist.Items.Add(notxt.Text);
                    f1.studentpointlist.Items.Add(pointtxt.Text);
                    MessageBox.Show("Veriler Kaydedildi!");
                    this.Close();
                }
            }
        }
    }
}
