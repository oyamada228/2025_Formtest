using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Form_test
{
    internal class TestButton : Button
    {
        public TestButton(Point position, Size size, string  text)
        {

            Location = position;
            Size = size;
            Text = text;


            Click += ClickEvent;
        }


        private void ClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("こんにちは");
        }

    }
}
