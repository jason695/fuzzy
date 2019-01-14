using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 正反去識別
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 去識別化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFZ_Click(object sender, EventArgs e)
        {
           
                String rtn = ""; //回傳         
            
                int num = txtDeFZ.Text.Length; //資料長度
                string[] txt = new string[num]; //轉字串

                int i = 0;
                foreach (char s in txtDeFZ.Text)
                {
                    txt[i] = s.ToString();
                    i += 1;
                }

            //14碼帳號：前6碼不轉
            //10碼身份證：前2碼不轉
            if (radioButton1.Checked == true)
            {
                if (num == 10 || num == 11)
                { //ID
                    #region 檢查ID
                    string result = IDChk(txtDeFZ.Text.Substring(0, 10));

                    if (result != "0")
                    {
                        if (result == "1") { MessageBox.Show("字數不到10"); return; }
                        if (result == "2") { MessageBox.Show("第二碼非1,2"); return; }
                        if (result == "3") { MessageBox.Show("首碼有誤"); return; }
                        if (result == "4") { MessageBox.Show("檢查碼不對"); return; }
                    }
                    #endregion

                    txt[2] = fz(txt[2].ToString());
                    txt[3] = fz(txt[3].ToString());
                    txt[4] = fz(txt[4].ToString());
                    txt[5] = fz(txt[5].ToString());
                    txt[6] = fz(txt[6].ToString());
                    txt[7] = fz(txt[7].ToString());
                    txt[8] = fz(txt[8].ToString());
                    txt[9] = fz(txt[9].ToString());

                    foreach (string s in txt)
                    {
                        rtn += s.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("ID長度有誤");
                }
            }

            if (radioButton2.Checked == true)
            {
                if (num == 14)
                { //ACT
                    txt[6] = fz(txt[6].ToString());
                    txt[7] = fz(txt[7].ToString());
                    txt[8] = fz(txt[8].ToString());
                    txt[9] = fz(txt[9].ToString());
                    txt[10] = fz(txt[10].ToString());
                    txt[11] = fz(txt[11].ToString());
                    txt[12] = fz(txt[12].ToString());
                    txt[13] = fz(txt[13].ToString());
                    
                    foreach (string s in txt)
                    {
                        rtn += s.ToString();
                    }
                }
                else {
                    MessageBox.Show("帳號長度有誤");
                }
            }

            txtFZ.Text = rtn;
        }

        /// <summary>
        /// 反去識別
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeFZ_Click(object sender, EventArgs e)
        {
            String rtn = ""; //回傳         

            int num = txtFZ.Text.Length; //資料長度
            string[] txt = new string[num]; //轉字串

            int i = 0;
            foreach (char s in txtFZ.Text)
            {
                txt[i] = s.ToString();
                i += 1;
            }

            //14碼帳號：前6碼不轉
            //10碼身份證：前2碼不轉
            if (radioButton1.Checked == true)
            {
                if (num == 10 || num == 11)
                { //ID
                    txt[2] = defz(txt[2].ToString());
                    txt[3] = defz(txt[3].ToString());
                    txt[4] = defz(txt[4].ToString());
                    txt[5] = defz(txt[5].ToString());
                    txt[6] = defz(txt[6].ToString());
                    txt[7] = defz(txt[7].ToString());
                    txt[8] = defz(txt[8].ToString());
                    txt[9] = defz(txt[9].ToString());

                    foreach (string s in txt)
                    {
                        rtn += s.ToString();
                    }

                    #region 檢查ID
                    string result = IDChk(rtn.Substring(0, 10));

                    if (result != "0")
                    {
                        if (result == "1") { MessageBox.Show("字數不到10"); return; }
                        if (result == "2") { MessageBox.Show("第二碼非1,2"); return; }
                        if (result == "3") { MessageBox.Show("首碼有誤"); return; }
                        if (result == "4") { MessageBox.Show("檢查碼不對"); return; }
                    }
                    #endregion
                }
                else
                {
                    MessageBox.Show("ID長度有誤");
                }
            }


            if (radioButton2.Checked == true)
            {
                if (num == 14)
                { //ACT
                    txt[6] = defz(txt[6].ToString());
                    txt[7] = defz(txt[7].ToString());
                    txt[8] = defz(txt[8].ToString());
                    txt[9] = defz(txt[9].ToString());
                    txt[10] = defz(txt[10].ToString());
                    txt[11] = defz(txt[11].ToString());
                    txt[12] = defz(txt[12].ToString());
                    txt[13] = defz(txt[13].ToString());

                    foreach (string s in txt)
                    {
                        rtn += s.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("帳號長度有誤");
                }
            }

            

            txtDeFZ.Text = rtn;
        }

        //未去識別->去識別
        //1->9
        //2->7
        //3->5
        //4->3
        //5->1
        //6->0
        //7->8
        //8->6
        //9->4
        //0->2       
        public string fz(string s)
        {
            string t;
            switch (s)
            {
                case "0":
                    t = "2";
                    break;
                case "1":
                    t = "9";
                    break;
                case "2":
                    t = "7";
                    break;
                case "3":
                    t = "5";
                    break;
                case "4":
                    t = "3";
                    break;
                case "5":
                    t = "1";
                    break;
                case "6":
                    t = "0";
                    break;
                case "7":
                    t = "8";
                    break;
                case "8":
                    t = "6";
                    break;
                case "9":
                    t = "4";
                    break;
                default:
                    t="";
                    break;
            }

            return t;        
        }

        public string defz(string s)
        {
            string t;
            switch (s)
            {
                case "2":
                    t = "0";
                    break;
                case "9":
                    t = "1";
                    break;
                case "7":
                    t = "2";
                    break;
                case "5":
                    t = "3";
                    break;
                case "3":
                    t = "4";
                    break;
                case "1":
                    t = "5";
                    break;
                case "0":
                    t = "6";
                    break;
                case "8":
                    t = "7";
                    break;
                case "6":
                    t = "8";
                    break;
                case "4":
                    t = "9";
                    break;
                default:
                    t = "";
                    break;
            }

            return t;
        }

        /// <summary>
        /// 身份証檢核
        /// </summary>
        /// <param name="vid"></param>
        /// <returns>
        /// 回傳1:字數不到10  
        /// 回傳2:第二碼非1,2  
        /// 回傳3:首碼有誤  
        /// 回傳4:檢查碼不對  
        /// </returns>
        public string IDChk(string vid)
        {
            List<string> FirstEng = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "U", "V", "X", "Y", "W", "Z", "I", "O" };
            string aa = vid.ToUpper();
            bool chackFirstEnd = false;
            if (aa.Trim().Length == 10)
            {
                byte firstNo = Convert.ToByte(aa.Trim().Substring(1, 1));
                if (firstNo > 2 || firstNo < 1)
                {
                    return "2";
                }
                else
                {
                    int x;
                    for (x = 0; x < FirstEng.Count; x++)
                    {
                        if (aa.Substring(0, 1) == FirstEng[x])
                        {
                            aa = string.Format("{0}{1}", x + 10, aa.Substring(1, 9));
                            chackFirstEnd = true;
                            break;
                        }
                    }
                    if (!chackFirstEnd)
                        return "3";

                    int i = 1;
                    int ss = int.Parse(aa.Substring(0, 1));
                    while (aa.Length > i)
                    {
                        ss = ss + (int.Parse(aa.Substring(i, 1)) * (10 - i));
                        i++;
                    }
                    aa = ss.ToString();
                    if (vid.Substring(9, 1) == "0")
                    {
                        if (aa.Substring(aa.Length - 1, 1) == "0")
                        {
                            return "0";
                        }
                        else
                        {
                            return "4";
                        }
                    }
                    else
                    {
                        if (vid.Substring(9, 1) == (10 - int.Parse(aa.Substring(aa.Length - 1, 1))).ToString())
                        {

                            return "0";
                        }
                        else
                        {
                            return "4";
                        }
                    }
                }
            }
            else
            {
                return "1";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
