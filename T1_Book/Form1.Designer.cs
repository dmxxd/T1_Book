using System;
using System.Drawing;
using System.Windows.Forms;

namespace T1_Book
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnCreateBooks;
        private Button btnClear;
        private ListBox listBoxInfo;
        private Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCreateBooks = new Button();
            this.btnClear = new Button();
            this.listBoxInfo = new ListBox();
            this.label1 = new Label();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            this.label1.Location = new Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(211, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Книга";

            this.btnCreateBooks.Location = new Point(15, 40);
            this.btnCreateBooks.Name = "btnCreateBooks";
            this.btnCreateBooks.Size = new Size(200, 40);
            this.btnCreateBooks.TabIndex = 1;
            this.btnCreateBooks.Text = "Создать три книги";
            this.btnCreateBooks.UseVisualStyleBackColor = true;
            this.btnCreateBooks.Click += new EventHandler(this.btnCreateBooks_Click);

            this.btnClear.Location = new Point(230, 40);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(100, 40);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);

            this.listBoxInfo.Location = new Point(15, 100);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new Size(315, 160);
            this.listBoxInfo.TabIndex = 3;

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(354, 291);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreateBooks);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Книга";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

