using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CalCulator_win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string add_aval;
        public string add_dovom;
        public string add_motgher;
        public double add_result;
        public double a;
        public double b;
        public bool sin = false;
        public bool is_por = false;
        public int count = 0;

        List<struk_cash> list_adad = new List<struk_cash>();



        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (is_por == true)
            {
                add_dovom += "1";
                lbl_mashinhsab.Text = add_aval + add_motgher + add_dovom.ToString();
            }
            else
            {

                add_aval += "1";
                lbl_mashinhsab.Text = add_aval.ToString();
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (is_por == true)
            {
                add_dovom += "2";
                lbl_mashinhsab.Text = add_aval + add_motgher + add_dovom.ToString();
            }
            else
            {
                add_aval += "2";

                lbl_mashinhsab.Text = add_aval.ToString();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (is_por == true)
            {
                add_dovom += "3";
                lbl_mashinhsab.Text = add_aval + add_motgher + add_dovom.ToString();
            }
            else
            {

                add_aval += "3";
                lbl_mashinhsab.Text = add_aval.ToString();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            add_motgher = "+";
            is_por = true;
            lbl_mashinhsab.Text = add_motgher + add_aval.ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (is_por == true)
            {
                add_dovom += "4";
                lbl_mashinhsab.Text = add_aval + add_motgher + add_dovom.ToString();
            }
            else
            {
                add_aval += "4";
                lbl_mashinhsab.Text = add_aval.ToString();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (is_por == true)
            {
                add_dovom += "5";
                lbl_mashinhsab.Text = add_aval + add_motgher + add_dovom.ToString();

            }
            else
            {
                add_aval += "5";
                lbl_mashinhsab.Text = add_aval.ToString();
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (is_por == true)
            {
                add_dovom += "6";
                lbl_mashinhsab.Text = add_aval + add_motgher + add_dovom.ToString();
            }
            else
            {
                add_aval += "6";
                lbl_mashinhsab.Text = add_aval.ToString();
            }

        }

        private void Button9_Click(object sender, EventArgs e)
        {

            add_motgher = "*";
            is_por = true;
            lbl_mashinhsab.Text = add_motgher + add_aval.ToString();
        }

        private void Button10_Click(object sender, EventArgs e)
        {

            add_motgher = "-";
            is_por = true;
            lbl_mashinhsab.Text = add_motgher + add_aval.ToString();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (is_por == true)
            {
                add_dovom += "7";
                lbl_mashinhsab.Text = add_aval + add_motgher + add_dovom.ToString();
            }
            else
            {
                add_aval += "7";
                lbl_mashinhsab.Text = add_aval.ToString();
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (is_por == true)
            {
                add_dovom += "8";

                lbl_mashinhsab.Text = add_aval + add_motgher + add_dovom.ToString();
            }
            else
            {
                add_aval += "8";
            }
            lbl_mashinhsab.Text = add_aval.ToString();

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (is_por == true)
            {
                add_dovom += "9";
                lbl_mashinhsab.Text = add_aval + add_motgher + add_dovom.ToString();
            }
            else
            {
                add_aval += "9";
                lbl_mashinhsab.Text = add_aval.ToString();
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (is_por == true)
            {
                add_dovom += "0";
                lbl_mashinhsab.Text = add_aval + add_motgher + add_dovom.ToString();
            }
            else
            {
                add_aval += "0";
                lbl_mashinhsab.Text = add_aval.ToString();
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            struk_cash cash = new struk_cash();

            if(sin == true)
            {
                a = Math.Sin((Convert.ToDouble(add_aval) * (Math.PI)) / 180);
                lbl_mashinhsab.Text = a.ToString();

             
            }
            else if (add_motgher == "/" && add_dovom != "0")
            {

                double d1 = 0;
                double d2 = 0;
                double.TryParse(add_aval, out d1);
                double.TryParse(add_dovom, out d2);

                add_result = Pub(d1, d2, add_motgher);
                lbl_mashinhsab.Text = add_result.ToString();

            }
            else
            {
                if (add_motgher == "/")
                {
                    MessageBox.Show("تفسیم بر 0 امکان ندارد");
                }
                else
                {
                    double d1 = 0;
                    double d2 = 0;
                    double.TryParse(add_aval, out d1);
                    double.TryParse(add_dovom, out d2);

                    add_result = Pub(d1, d2, add_motgher);
                    lbl_mashinhsab.Text = add_result.ToString();
                }
            }

            if(sin==true)
            {
                cash.add_aval = "sin(" + add_aval + ")=" + a;
                cash.add_dovom = "";
                cash.add_motgher = "";
                cash.is_por = is_por;
                cash.sin = sin;
                cash.add_result = 0;
                list_adad.Add(cash);
                sin = false;
            }
            else
            {
            cash.add_aval = add_aval;
            cash.add_dovom = add_dovom;
            cash.add_motgher = add_motgher;
            cash.add_result = add_result;
            cash.is_por = is_por;
            list_adad.Add(cash);
            }
            

            add_aval = "";
            add_dovom = "";
            add_result = 0;
            is_por = false;



        }

        private void Button4_Click(object sender, EventArgs e)
        {
            add_motgher = "/";
            is_por = true;
            lbl_mashinhsab.Text = add_motgher + add_aval.ToString();
        }
        private double Jaam(double FirstNumber, double SecondNumber)
        {
            double Result = FirstNumber + SecondNumber;
            return Result;
        }
        private double Taf(double FirstNumber, double SecondNumber)
        {
            double Result = FirstNumber - SecondNumber;
            return Result;
        }
        private double Zarb(double FirstNumber, double SecondNumber)
        {
            double Result = FirstNumber * SecondNumber;
            return Result;
        }
        private double Tagh(double FirstNumber, double SecondNumber)
        {
            double Result = FirstNumber / SecondNumber;
            return Result;
        }
        public double Pub(double FirstNumber, double SecondNumber, string str)
        {
            if (str == "+" || str == "jaam")
            {
                return Jaam(FirstNumber, SecondNumber);
            }
            else if (str == "-" || str == "taf")
            {
                return Taf(FirstNumber, SecondNumber);
            }
            else if (str == "*" || str == "zarb")
            {
                return Zarb(FirstNumber, SecondNumber);
            }
            else if (str == "/" || str == "tagh")
            {
                return Tagh(FirstNumber, SecondNumber);
            }

            return -200000;
        }


        public static int SaveCash(List<struk_cash> TOCASH)
        {
            string JsonSerialized = JsonConvert.SerializeObject(TOCASH);
            cash saveCash = new cash("cash_CalCulator_win", "CalCulator_win");
            int res = 0;
            try
            {
                res = saveCash.Write_ToFile(JsonSerialized, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return res;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            int iii = SaveCash(list_adad);
            switch (iii)
            {
                case 1:
                    MessageBox.Show("Cash Saved Done!");
                    break;
                case -1:
                    MessageBox.Show("Failed !");
                    break;
                case -2:
                    MessageBox.Show("Failed !");
                    break;
                default:
                    MessageBox.Show("Nothing!");
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cash saveCash = new cash("cash_CalCulator_win", "CalCulator_win");
            string JsonFromCash = saveCash.TextFromFile();

            if (string.IsNullOrEmpty(JsonFromCash))

            {
                list_adad = new List<struk_cash>();
            }
            else
            {
                list_adad = JsonConvert.DeserializeObject<List<struk_cash>>(JsonFromCash);
            }
        }

        private void Btn_up_Click(object sender, EventArgs e)
        {
            if (count < list_adad.Count)
            {
                if(list_adad[count].sin==true)
                {
                    lbl_mashinhsab.Text = list_adad[count].add_aval .ToString();
                    count++;
                }
                else
                {
                lbl_mashinhsab.Text = list_adad[count].add_aval + list_adad[count].add_motgher + list_adad[count].add_dovom + "=" + Pub(Convert.ToDouble(list_adad[count].add_aval), Convert.ToDouble(list_adad[count].add_dovom), list_adad[count].add_motgher).ToString();
                count++;

                }
            }
            else
            {
                count = list_adad.Count - 1;
            }
        }

        private void Btn_dw_Click(object sender, EventArgs e)
        {

            if (count >= 0)
            {
                count--;
                if (count < 0)
                {
                    count = 0;

                }

                lbl_mashinhsab.Text = list_adad[count].add_aval + list_adad[count].add_motgher + list_adad[count].add_dovom + "=" + Pub(Convert.ToDouble(list_adad[count].add_aval), Convert.ToDouble(list_adad[count].add_dovom), list_adad[count].add_motgher).ToString();

            }
            else
            {
                count = 0;
            }


        }

        private void Bnt_do_Click(object sender, EventArgs e)
        {

            if (is_por == true)
            {

                if (!lbl_mashinhsab.Text.Contains("/"))
                {

                    add_dovom += "/";
                    lbl_mashinhsab.Text = add_aval + add_motgher + add_dovom.ToString();

                }
                else
                {
                    if (add_aval.Contains("/")&& !add_dovom.Contains("/")&& add_motgher == "/")
                    {

                        add_dovom += "/";
                        lbl_mashinhsab.Text = add_aval + add_motgher + add_dovom.ToString();
                    }
                }
            }
            else
            {

                if (!lbl_mashinhsab.Text.Contains("/"))
                {
                    add_aval += "/";
                    lbl_mashinhsab.Text = add_aval.ToString();

                }

            }
        }

        private void Btn_ce_Click(object sender, EventArgs e)
        {

            add_dovom = "";
            lbl_mashinhsab.Text = add_aval + add_motgher + add_dovom.ToString();
        }

        private void Btn_c_Click(object sender, EventArgs e)
        {
            add_aval = "";
            add_dovom = "";
            add_motgher = "";
            is_por = false;
            lbl_mashinhsab.Text = add_aval + add_motgher + add_dovom.ToString();
        }

        private void Btn_sin_Click(object sender, EventArgs e)
        {
            sin = true;
            lbl_mashinhsab.Text = "Sin(n)".ToString();
            Math.Sin((a * (Math.PI)) / 180);
        }
    }
}
