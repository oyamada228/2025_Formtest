using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Form_test
{
    internal class TestButton : Button
    {
        private Color _onColor = Color.White; //onの時の色
        private Color _offColor = Color.Black;      // offの時の色
        private bool  _enable; 

        public void SetEnable(bool on)
        {
            _enable = on;
            if (on)
            {
                BackColor = _onColor;
            }
            else
            {

                BackColor = _offColor;
            }

        }

        public TestButton(Point position, Size size, string  text)
        {

            Location = position; //位置
            Size = size;　　　　//大きさ
            Text = text;        //テキスト

            SetEnable(false);

            Click += ClickEvent;
        }


        private void ClickEvent(object sender, EventArgs e)
        {
            SetEnable(!_enable);
        }

    }
}
