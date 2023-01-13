using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace Pattern_calc
{
    public static class Model
    {
        /// <summary>
        /// data
        /// </summary>
        public static List<string> dataList = new List<string> {"Сложение", "Вычитание", "Умножение", "Деление" };
        static int a;
        static int b;
        static int res;

        public static TextBox TBone;
        public static TextBox TBtwo;
        public static TextBlock TBsim;
        public static TextBlock TBRes;

        public static int Combo 
        {
            set 
            {
                if (dataList[value] == "Сложение")
                {
                    TBsim.Text = "+";
                }
                else if (dataList[value] == "Вычитание")
                {
                    TBsim.Text = "-";
                }
                else if (dataList[value] == "Умножение")
                {
                    TBsim.Text = "*";
                }
                else if (dataList[value] == "Деление") 
                {
                    TBsim.Text = "/";
                }
            }
        }

        public static int Res 
        {
            get 
            {
                if (TBsim.Text != "") 
                {
                    if (TBone.Text != "") 
                    {
                        if (TBtwo.Text != "")
                        {
                            if (TBsim.Text == "+")
                            {
                                TBsim.Text = "+";
                                a = Convert.ToInt32(TBone.Text);
                                b = Convert.ToInt32(TBtwo.Text);
                                res = a + b - 1;
                                return res;
                            }
                            else if (TBsim.Text == "-")
                            {
                                TBsim.Text = "-";
                                a = Convert.ToInt32(TBone.Text);
                                b = Convert.ToInt32(TBtwo.Text);
                                res = a - b - 1;
                                return res;
                            }
                            else if (TBsim.Text == "*")
                            {
                                a = Convert.ToInt32(TBone.Text);
                                b = Convert.ToInt32(TBtwo.Text);
                                res = a * b - 1;
                                return res;
                            }
                            else if (TBsim.Text == "/")
                            {
                                a = Convert.ToInt32(TBone.Text);
                                b = Convert.ToInt32(TBtwo.Text);
                                res = a / b - 1;
                                return res;
                            }
                            else
                            {
                                return 0;
                            }
                        }
                        else 
                        {
                            return 2;
                        }
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    return 3;
                }

            }
            set 
            {
                res = value;
                TBRes.Text=res.ToString();
            }
        }
    }
}
