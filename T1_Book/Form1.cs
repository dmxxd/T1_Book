using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T1_Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateBooks_Click(object sender, EventArgs e)
        {
            Book book1 = new Book();
            book1.title = "Война и мир";
            book1.pages = 1200;

            Book book2 = new Book();
            book2.title = "1984";
            book2.pages = 300;

            Book book3 = new Book();
            book3.pages = 500;

            listBoxInfo.Items.Clear();
            listBoxInfo.Items.Add("Список книг:");
            book1.GetInfo(listBoxInfo);
            book2.GetInfo(listBoxInfo);
            book3.GetInfo(listBoxInfo);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
        }
    }
}
