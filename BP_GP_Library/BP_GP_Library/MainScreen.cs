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
    public partial class MainScreen : Form
    {

        public MainScreen()
        {
            InitializeComponent();

            silToolStripMenuItem.Enabled = false;
            güncelleToolStripMenuItem.Enabled = false;
        }
        
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook(this);
            addBook.ShowDialog();
        }

        public void addBooks(Book book)
        {
            listBox1.Items.Add(book);
        }

        public void updateBooks(Book book)
        {
            listBox1.Items[listBox1.SelectedIndex] = book ;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                silToolStripMenuItem.Enabled= true;
                güncelleToolStripMenuItem.Enabled = true;
            }
            else
            {
                silToolStripMenuItem.Enabled = false;
                güncelleToolStripMenuItem.Enabled = false;
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook(this, (Book)listBox1.Items[listBox1.SelectedIndex]);
            addBook.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("İlgili kitabı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Çıkış Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (exit == DialogResult.Yes) Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
