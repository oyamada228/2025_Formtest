using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    TestButton testButton = new TestButton(new Point(50 * i, 50 * j),new Size(50, 50),"あ");  //インスタンスの生成


                    Controls.Add(testButton);   //コントールにボタン追加
                }
            }


        }


        private void ClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("こんにちは");
        }


    }
}
