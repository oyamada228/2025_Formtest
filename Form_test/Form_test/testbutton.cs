using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Form_test
{
    public class TestButton : Button
    {
        private Color _onColor = Color.Purple;       //onの時の色
        private Color _offColor = Color.Black;      // offの時の色
        private bool _enable;                       //on か　offかの判断
        private Form1 _form1;                       //form1の参照
        private int _x;                             //横位置   
        private int _y;　　　　　　　　　　　　　　//縦位
       

        public TestButton(Form1 form1, int x, int y, Point position, Size size, string text)
        {
            _form1 = form1;        //form1の保管
            Location = position;   //位置
            Size = size;　　　　   //大きさ
            Text = text;           //テキスト
            _x = x;                //横位置保管
            _y = y;　　　　　　　  //縦位置保管

            SetEnable(false);

            Click += ClickEvent;
        }

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

      


        public void Toggle()
        {
            SetEnable(!_enable);
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            _form1.GetTextButton(_x, _y)?.Toggle();
            _form1.GetTextButton(_x + 1, _y)?.Toggle();
            _form1.GetTextButton(_x - 1, _y)?.Toggle();
            _form1.GetTextButton(_x, _y + 1)?.Toggle();
            _form1.GetTextButton(_x, _y - 1)?.Toggle();

            bool q = true;
            bool p = true;

            for(int x = 0; x < 3; x++)
            {
                for(int y =0; y < 3; y++) 
                {
                    var btn = _form1.GetTextButton(x,y);   //座標習得

                    if (btn.BackColor != _onColor) 
                        q = false; 
                    
                    if (btn.BackColor != _offColor)    //全部のボタンが同じ色になったときにtrueを返す処理
                            p = false;
                }

            }
           
            if(q == true || p == true)
            {

                var result = MessageBox.Show("クリア");



            }

        }

       
    }
}
