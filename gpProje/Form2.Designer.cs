namespace gpProje
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.surnametxt = new System.Windows.Forms.TextBox();
            this.notxt = new System.Windows.Forms.TextBox();
            this.pointtxt = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Öğrenci Ekle";
            // 
            // author
            // 
            this.author.BackColor = System.Drawing.Color.DimGray;
            this.author.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.author.ForeColor = System.Drawing.Color.White;
            this.author.Location = new System.Drawing.Point(0, 257);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(461, 24);
            this.author.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 24);
            this.label1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(386, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 24);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Öğrenci Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Öğrenci Soyadı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Öğrenci Numarası :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(66, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Alınan Not :";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(153, 54);
            this.nametxt.MaxLength = 30;
            this.nametxt.Multiline = true;
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(257, 20);
            this.nametxt.TabIndex = 19;
            this.nametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nametxt_KeyPress);
            // 
            // surnametxt
            // 
            this.surnametxt.Location = new System.Drawing.Point(153, 100);
            this.surnametxt.MaxLength = 20;
            this.surnametxt.Multiline = true;
            this.surnametxt.Name = "surnametxt";
            this.surnametxt.Size = new System.Drawing.Size(257, 20);
            this.surnametxt.TabIndex = 20;
            this.surnametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnametxt_KeyPress);
            // 
            // notxt
            // 
            this.notxt.Location = new System.Drawing.Point(153, 146);
            this.notxt.MaxLength = 12;
            this.notxt.Multiline = true;
            this.notxt.Name = "notxt";
            this.notxt.Size = new System.Drawing.Size(257, 20);
            this.notxt.TabIndex = 21;
            this.notxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notxt_KeyPress);
            // 
            // pointtxt
            // 
            this.pointtxt.Location = new System.Drawing.Point(153, 189);
            this.pointtxt.MaxLength = 3;
            this.pointtxt.Multiline = true;
            this.pointtxt.Name = "pointtxt";
            this.pointtxt.Size = new System.Drawing.Size(257, 20);
            this.pointtxt.TabIndex = 22;
            this.pointtxt.TextChanged += new System.EventHandler(this.pointtxt_TextChanged);
            this.pointtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pointtxt_KeyPress);
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.Green;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savebutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.savebutton.ForeColor = System.Drawing.Color.White;
            this.savebutton.Location = new System.Drawing.Point(335, 220);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 29);
            this.savebutton.TabIndex = 23;
            this.savebutton.Text = "Kaydet";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(460, 279);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.pointtxt);
            this.Controls.Add(this.notxt);
            this.Controls.Add(this.surnametxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.author);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox surnametxt;
        private System.Windows.Forms.TextBox notxt;
        private System.Windows.Forms.TextBox pointtxt;
        private System.Windows.Forms.Button savebutton;
    }
}