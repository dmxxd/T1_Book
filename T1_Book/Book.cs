using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T1_Book
{
    internal class Book
    {
        public string title = "Неизвестно";
        public int pages;

        public void GetInfo(ListBox listBox)
        {
            listBox.Items.Add($"Книга: {title}, страниц: {pages}");
        }
    }
}
