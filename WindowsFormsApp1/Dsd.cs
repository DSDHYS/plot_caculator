using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Collections;

using System.Data;
using System.Text.RegularExpressions;

namespace Library
{
    public class Dsd
    {
        public static string caculate(string textBox1_Text)
        {

            string textBox2_Text;
            string pattern = @"sin\(\d+\)|sin\(\-\d+\)|sin\(\d+\.\d+\)|sin\(\-\d+\.\d+\)";
            //string pattern = @"sin\d+";
            foreach (System.Text.RegularExpressions.Match m in System.Text.RegularExpressions.Regex.Matches(textBox1_Text, pattern))
            {
                string m_str = m.Value;
                //string m_str_regex =string.Format( "sin({0})", m_str);
                Regex regex = new Regex(m_str);
                textBox1_Text = textBox1_Text.Replace(m_str, Convert.ToString(Math.Sin(Convert.ToDouble(m_str.Substring(4, m_str.Length - 5)))));
                //textBox1.Text=regex.Replace(textBox1.Text, Convert.ToString(Math.Sin(Convert.ToDouble(m_str.Substring(4, m_str.Length - 5)))));       
            }

            pattern = @"cos\(\d+\)|cos\(\-\d+\)|cos\(\d+\.\d+\)|cos\(\-\d+\.\d+\)";
            foreach (System.Text.RegularExpressions.Match m in System.Text.RegularExpressions.Regex.Matches(textBox1_Text, pattern))
            {
                string m_str = m.Value;
                //string m_str_regex =string.Format( "sin({0})", m_str);
                Regex regex = new Regex(m_str);
                textBox1_Text = textBox1_Text.Replace(m_str, Convert.ToString(Math.Cos(Convert.ToDouble(m_str.Substring(4, m_str.Length - 5)))));
                //textBox1.Text=regex.Replace(textBox1.Text, Convert.ToString(Math.Sin(Convert.ToDouble(m_str.Substring(4, m_str.Length - 5)))));       
            }
            pattern = @"tan\(\d+\)|tan\(\-\d+\)|tan\(\d+\.\d+\)|tan\(\-\d+\.\d+\)";
            foreach (System.Text.RegularExpressions.Match m in System.Text.RegularExpressions.Regex.Matches(textBox1_Text, pattern))
            {
                string m_str = m.Value;
                //string m_str_regex =string.Format( "sin({0})", m_str);
                Regex regex = new Regex(m_str);
                textBox1_Text = textBox1_Text.Replace(m_str, Convert.ToString(Math.Tan(Convert.ToDouble(m_str.Substring(4, m_str.Length - 5)))));
                //textBox1.Text=regex.Replace(textBox1.Text, Convert.ToString(Math.Sin(Convert.ToDouble(m_str.Substring(4, m_str.Length - 5)))));       
            }
            DataTable dataTable = new DataTable();
            textBox2_Text = dataTable.Compute(textBox1_Text, "false").ToString();


            return textBox2_Text;
        }
    }
}


