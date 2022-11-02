using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_GP_Library
{
    public partial class AddBook : Form
    {
        MainScreen mainScreen;
        bool isEditMode;
        bool authorEditMode;

        public AddBook(MainScreen ms)
        {
            InitializeComponent();
            mainScreen = ms;
            isEditMode = false;
            button1.Text = "Ekle";
            button1.BackColor = Color.Green;
        }

        public AddBook(MainScreen ms, Book book)
        {
            InitializeComponent();
            mainScreen = ms;
            isEditMode = true;
            button1.Text = "Güncelle";
            button1.BackColor = Color.Blue;

            textBox1.Text = book.ISSN;
            textBox2.Text = book.Name;
            comboBox1.Items.Add(book.Author);
        }

        public void Inception()
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            comboBox1.Visible = true;
            button2.Visible = false;
            button1.Visible = true;
            menuToolStripMenuItem.Visible = true;
            button1.Text = "Ekle";
            button1.BackColor = Color.Green;
        }

        public void AddAuthor()
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = true;
            comboBox1.Visible = false;
            authorEditMode = false;
            button1.Visible = false;
            button2.Visible = true;
            menuToolStripMenuItem.Visible = false;
            button2.Text = "Ekle";
            button2.BackColor = Color.Green;
        }

        public void DeleteAuthor()
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            comboBox1.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            authorEditMode = true;
            menuToolStripMenuItem.Visible = false;
            button2.Text = "Sil";
            button2.BackColor = Color.Red;
        }
         
        private void kitapEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAuthor();
        }

        private void yazarSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAuthor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {
                Book book = new Book();
                book.ISSN = textBox1.Text;
                book.Name = textBox2.Text;
                book.Author = comboBox1.Text;

                if (isEditMode == false)
                {
                    mainScreen.addBooks(book);
                    MessageBox.Show("Kitap Eklendi");
                    textBox3.Text = "";
                }
                else
                {
                    mainScreen.updateBooks(book);
                    MessageBox.Show("Kitap Güncellendi");
                }
            }
            else
            {
                MessageBox.Show("Kitap Eklenirken Boş Alan Bırakılamaz!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" || comboBox1.Text != "")
            {
                if (authorEditMode == false)
                {
                    comboBox1.Items.Add(textBox3.Text);
                    MessageBox.Show("Yazar Eklendi");
                    Inception();
                }
                else
                {
                    comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                    MessageBox.Show("Yazar Silindi");
                    Inception();
                }
            }
            else
            {
                MessageBox.Show("Lütfen İlgili Alanları Doldurunuz");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }
    }
}
