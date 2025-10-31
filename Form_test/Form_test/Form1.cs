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
                  new TestButton(new Point(BUTTON_SIZE_X  * i, BUTTON_SIZE_Y * j),
                  new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y)," "); 

                //配列にボタンの参照 
                 _buttonArray[j, i] = testButton;

                   Controls.Add(testButton);   //コントールにボタン追加
                }
            }

            _buttonArray[0, 0]. SetEnable(true);
            _buttonArray[1, 0].SetEnable(true);
            _buttonArray[2, 0].SetEnable(true);


        }

        private void ClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("こんにちは");
        }


    }
}
