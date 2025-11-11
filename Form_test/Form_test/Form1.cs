using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_test
{
    public partial class Form1 : Form
    { 
        //const をつけると初期化時にのみ値の変更可能になる
        const int BUTTON_SIZE_X = 100;  //この関数がそのまま適応される
        const int BUTTON_SIZE_Y = 100;  //この関数がそのまま適応される

        const int BOARD_SIZE_X = 3;
        const int BOARD_SIZE_Y = 3;

        private TestButton[,] _buttonArray;


        public Form1()
        {
            InitializeComponent();
            _buttonArray = new TestButton[BOARD_SIZE_Y, BOARD_SIZE_X];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //インスタンスの生成
                    TestButton testButton =
                    new TestButton(
                      this,
                      i,
                      j,
                      new Point(BUTTON_SIZE_X * i, BUTTON_SIZE_Y * j),
                      new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y), "");

                    //配列にボタンの参照 
                    _buttonArray[j, i] = testButton;

                    Controls.Add(testButton);   //コントールにボタン追加
                }
            }
            Random rnd = new Random();
            for (int x = 0; x<7; x++)
            {

                int a = rnd.Next(0, 3);

                int b = rnd.Next(0, 3);

                _buttonArray[a, b].SetEnable(true);
            }
            
       

        }

        

        public object Next { get; }

        public TestButton GetTextButton(int x, int y)
        {  
            //配列外参照対策
            if (x < 0 || x >= BOARD_SIZE_X) return null;
            if (y < 0 || y >= BOARD_SIZE_Y) return null;

            return _buttonArray[y, x];
        }

        
       


        private void ClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("こんにちは");
        }

       



    }
}
