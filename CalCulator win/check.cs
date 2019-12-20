using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalCulator_win
{
    class check
    {
        public string vali { get; set; }
        public string da_vali { get; set; }
        public bool is_por { get; set; }
        public List<check> list_chki = new List<check>();
        public List<string> list_data = new List<string>();
        public List<string> list_d2 = new List<string>();
        /////////////////////////////////////////////////////////////
        public void get_One(string _vali, string _da_vali, bool _is_por)
        {
            check da_chki1 = new check();
            da_chki1.vali = _vali;
            da_chki1.da_vali = _da_vali;
            da_chki1.is_por = _is_por;
            list_chki.Add(da_chki1);
        }
        /////////////////////////////////////////////////////////////
        public double jvab;
        public double res;
        public string res2;
        public double out_One(int aa, int cc, string _show)
        {
            string f_show = " ";
            double fa = 0;
            double ff = 0;
            int b = 0;
            int bb = 0;
            int k;
            string mosave = "";

            for (k = aa; k < cc; k++)
            {
                string s_show = _show;


                if (list_chki[k].is_por == false)
                {
                    string tvan = "";
                    b = _show.IndexOf($"{list_chki[k].vali}");
                    bb = b;
                    bb++;
                    b++;
                    if (Convert.ToString(_show[b]) == "^")
                    {
                        b++;
                        while (true)
                        {
                            if (_show[b] == '+')
                            {
                                break;
                            }
                            if (_show[b] == '-')
                            {
                                break;
                            }
                            if (_show[b] == '=')
                            {
                                break;
                            }
                            else
                            {
                                tvan += _show[b];
                                b++;
                            }
                        }
                        Console.WriteLine(tvan);
                    }


                    string zarb = "";
                    int d = _show.IndexOf($"{list_chki[k].vali}");
                    d--;
                    if (Convert.ToString(_show[d]) != "^")
                    {
                        // d--;
                        while (true)
                        {
                            if (_show[d] == '+')
                            {
                                break;
                            }
                            if (_show[d] == '-')
                            {
                                break;
                            }
                            else
                            {
                                d--;
                                zarb = zarb.Insert(0, Convert.ToString(_show[d]));

                            }
                        }
                        // Console.WriteLine(c);
                    }


                    int q = _show.IndexOf("=");
                    if (Convert.ToString(_show[q]) != "^")
                    {
                        q++;
                        while (true)
                        {
                            if (_show[q] == '$')
                            {
                                break;
                            }
                            else
                            {
                                mosave += _show[q];
                                q++;
                            }
                        }
                        //                       Console.WriteLine(a);
                    }

                    s_show = s_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", "").Replace($"={mosave}$", "");


                    //  s_show = s_show.Insert(0, "(");
                    //  s_show += ")";
                    //22*x^2+5*z^3+2*t^4=1
                    f_show = s_show;



                    if (zarb[0] == '-')
                    {
                        ff = -Convert.ToDouble(zarb.Remove(0, 1));
                    }
                    else
                    {
                        ff = Convert.ToDouble(zarb.Remove(0, 1));
                    }

                    fa = Convert.ToDouble(tvan);

                }

            }

            for (k = aa; k < cc; k++)
            {

                if (list_chki[k].is_por == true)
                {
                    double result;
                    double jj;

                    string tvan = "";
                    b = _show.IndexOf($"{list_chki[k].vali}");
                    bb = _show.IndexOf($"{list_chki[k].vali}");
                    bb++;
                    b++;
                    if (Convert.ToString(_show[b]) == "^")
                    {
                        b++;
                        while (true)
                        {
                            if (_show[b] == '+')
                            {
                                break;
                            }
                            if (_show[b] == '-')
                            {
                                break;
                            }
                            if (_show[b] == '=')
                            {
                                break;
                            }
                            else
                            {
                                tvan += _show[b];
                                b++;
                            }
                        }
                    }
                    string zarb = "";
                    int d = _show.IndexOf($"{list_chki[k].vali}");
                    d--;
                    if (Convert.ToString(_show[d]) != "^")
                    {
                        while (true)
                        {
                            if (_show[d] == '+')
                            {
                                break;
                            }
                            if (_show[d] == '-')
                            {
                                break;
                            }
                            else
                            {
                                d--;
                                zarb = zarb.Insert(0, Convert.ToString(_show[d]));
                            }
                        }
                    }

                    if (Convert.ToString(_show[bb]) == "^")
                    {
                        result = Math.Pow(Convert.ToDouble(list_chki[k].da_vali), Convert.ToDouble(tvan));

                        if (zarb[0] == '-')
                        {

                            jj = result * Convert.ToDouble(zarb);
                            if (Convert.ToString(jj)[0] == '-')
                            {
                                f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"{Convert.ToString(jj)}");
                            }
                            else
                            {
                                f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"+{Convert.ToString(jj)}");
                            }
                        }
                        else
                        {
                            jj = result * Convert.ToDouble(zarb);
                            if (Convert.ToString(jj)[0] == '-')
                            {
                                f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"{Convert.ToString(jj)}");
                            }
                            else
                            {
                                f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"+{Convert.ToString(jj)}");
                            }
                        }
                    }
                    else
                    {
                        jj = Convert.ToDouble(list_chki[k].da_vali) * Convert.ToDouble(zarb.Remove(0, 1));
                        f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"{Convert.ToString(jj)}");
                    }
                }
            }

            List<BigInteger> zz = new List<BigInteger>();
            List<string> xx = new List<string>();
            // string str1 = "+38-1-9";
            string str1;

            str1 = f_show;

            string[] alamat = str1.Split(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ')' });
            string[] gam = str1.Split(new Char[] { '(', '+', '-', ')' });
            BigInteger ggam = 0;
            string vb = "";

            BigInteger a = new BigInteger();
            foreach (string author in gam)
            {
                if (author.Trim() != "")
                {
                    a = BigInteger.Parse(author);
                    zz.Add(a);
                }
            }

            foreach (string author in alamat)
            {
                if (author.Trim() != "")
                    xx.Add(author);
            }
            BigInteger d1 = new BigInteger();
            for (int ll = 0; ll < zz.Count; ll++)
            {
                vb += xx[ll] + Convert.ToString(zz[ll]);
                d1 = BigInteger.Parse(vb);
                ggam = d1 + ggam;
                vb = "";
            }

            if (fa != 1)
            {
                ggam = -ggam + Convert.ToInt32(mosave);
                jvab = Double.Parse(ggam.ToString()) / ff;
                res = Math.Ceiling(Math.Pow(jvab, (double)1 / fa));
            }
            else
            {
                ggam = -ggam + Convert.ToInt32(mosave);
                res = Double.Parse(ggam.ToString()) / ff;
            }


            return res;
        }
        public string out_two(int aa, int cc, string _show)
        {
            string f_show = "";
            string d22 = "";

            int bb = 0;
            int k;
            string mosave = "";
            string s_show = _show;

            for (k = aa; k < cc; k++)
            {

                int d = 0;
                int b = 0;

                if (list_chki[k].is_por == false)
                {
                    string tvan = "";
                    b = s_show.IndexOf($"{list_chki[k].vali}");
                    bb = b;
                    bb++;
                    b++;
                    if (Convert.ToString(s_show[b]) == "^")
                    {
                        b++;
                        while (true)
                        {
                            if (s_show[b] == '+')
                            {
                                break;
                            }
                            if (s_show[b] == '-')
                            {
                                break;
                            }
                            if (s_show[b] == '=')
                            {
                                break;
                            }
                            else
                            {
                                tvan += s_show[b];
                                b++;
                            }
                        }
                        Console.WriteLine(tvan);
                    }


                    string zarb = "";
                    d = s_show.IndexOf($"{list_chki[k].vali}");
                    d--;
                    if (Convert.ToString(s_show[d]) != "^")
                    {
                        // d--;
                        while (true)
                        {
                            if (s_show[d] == '+')
                            {
                                break;
                            }
                            if (s_show[d] == '-')
                            {
                                break;
                            }
                            else
                            {
                                d--;
                                zarb = zarb.Insert(0, Convert.ToString(s_show[d]));

                            }
                        }
                        Console.WriteLine(zarb);
                    }



                    s_show = s_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", "");
                    d22 = $"{zarb}*{list_chki[k].vali}^{tvan}";
                    list_d2.Add(d22);

                    f_show = s_show;

                }
            }

            int q = s_show.IndexOf("=");
            if (Convert.ToString(s_show[q]) != "^")
            {
                q++;
                while (true)
                {
                    if (s_show[q] == '$')
                    {
                        break;
                    }
                    else
                    {
                        mosave += s_show[q];
                        q++;
                    }
                }
                //                       Console.WriteLine(a);
            }
            f_show = f_show.Replace($"={mosave}$", "");

            for (k = aa; k < cc; k++)
            {
                int d = 0;
                int b = 0;
                if (list_chki[k].is_por == true)
                {
                    double result;
                    double jj;

                    string tvan = "";
                    b = _show.IndexOf($"{list_chki[k].vali}");
                    bb = _show.IndexOf($"{list_chki[k].vali}");
                    bb++;
                    b++;
                    if (Convert.ToString(_show[b]) == "^")
                    {
                        b++;
                        while (true)
                        {
                            if (_show[b] == '+')
                            {
                                break;
                            }
                            if (_show[b] == '-')
                            {
                                break;
                            }
                            if (_show[b] == '=')
                            {
                                break;
                            }
                            else
                            {
                                tvan += _show[b];
                                b++;
                            }
                        }
                    }
                    string zarb = "";
                    d = _show.IndexOf($"{list_chki[k].vali}");
                    d--;
                    if (Convert.ToString(_show[d]) != "^")
                    {
                        while (true)
                        {
                            if (_show[d] == '+')
                            {
                                break;
                            }
                            if (_show[d] == '-')
                            {
                                break;
                            }
                            else
                            {
                                d--;
                                zarb = zarb.Insert(0, Convert.ToString(_show[d]));
                            }
                        }
                    }

                    if (Convert.ToString(_show[bb]) == "^")
                    {
                        result = Math.Pow(Convert.ToDouble(list_chki[k].da_vali), Convert.ToDouble(tvan));

                        if (zarb[0] == '-')
                        {

                            jj = result * Convert.ToDouble(zarb);
                            if (Convert.ToString(jj)[0] == '-')
                            {
                                f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"{Convert.ToString(jj)}");
                            }
                            else
                            {
                                f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"+{Convert.ToString(jj)}");
                            }
                        }
                        else
                        {
                            jj = result * Convert.ToDouble(zarb);
                            if (Convert.ToString(jj)[0] == '-')
                            {
                                f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"{Convert.ToString(jj)}");
                            }
                            else
                            {
                                f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"+{Convert.ToString(jj)}");
                            }
                        }
                    }
                    else
                    {
                        jj = Convert.ToDouble(list_chki[k].da_vali) * Convert.ToDouble(zarb.Remove(0, 1));
                        f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"{Convert.ToString(jj)}");
                    }
                }
            }

            List<BigInteger> zz = new List<BigInteger>();
            List<string> xx = new List<string>();
            // string str1 = "+38-1-9";
            string str1;

            str1 = f_show;

            string[] alamat = str1.Split(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ')' });
            string[] gam = str1.Split(new Char[] { '(', '+', '-', ')' });
            BigInteger ggam = 0;
            string vb = "";

            BigInteger a = new BigInteger();
            foreach (string author in gam)
            {
                if (author.Trim() != "")
                {
                    a = BigInteger.Parse(author);
                    zz.Add(a);
                }
            }

            foreach (string author in alamat)
            {
                if (author.Trim() != "")
                    xx.Add(author);
            }
            BigInteger d1 = new BigInteger();
            for (int ll = 0; ll < zz.Count; ll++)
            {
                vb += xx[ll] + Convert.ToString(zz[ll]);
                d1 = BigInteger.Parse(vb);
                ggam = d1 + ggam;
                vb = "";
            }

            for (int gg = 0; gg < list_d2.Count; gg++)
            {
                res2 += list_d2[gg];
            }
            res2 += "=";
            ggam = -ggam + Convert.ToInt32(mosave);
            res2 += $"{ggam}";


            return res2;
        }
    }
}
