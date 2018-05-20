using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace 猜數字
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InputNumber = "0000";
            Disable();
        }
        string Number = "";
        public string InputNumber
        {
            get
            {
                return $@"{d1.Text}{d2.Text}{d3.Text}{d4.Text}";
            }
            set
            {
                string val = value;
                char[] cha = val.ToCharArray();
                for(int i = 1; i <= cha.Count(); i++)
                {
                    panel1.Controls[$"d{i}"].Text = cha[i-1].ToString();
                }
            }
        }
        bool GameEnabled = false;
        public void Enable()
        {

            RandomNumber();
            button1.Enabled = true;
            GameEnabled = true;
            foreach (Control cl in panel1.Controls)
            {
                cl.Enabled = true;
            }
        }
        public void Disable()
        {
            button1.Enabled = false;
            GameEnabled = false;
            listView1.Items.Clear();
            InputNumber = "0000";
            foreach(Control cl in panel1.Controls)
            {
                cl.Enabled = false;
            }
        }
        private void 開始遊戲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GameEnabled && MessageBox.Show("目前仍有遊戲進行中，您確定要重新開始?","詢問",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Disable();
            Enable();
        }
        private void d_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length == 1 && textBox.TabIndex<3)
            {
                TextBox text = (TextBox)panel1.Controls[$"d{textBox.TabIndex + 2}"];
                text.Focus();
                text.Select(0, 1);
            }
        }
        private void RandomNumber()
        {
            List<int> random_list = new List<int>();
            for (int i = 0; i < 10; i++) random_list.Add(i);
            Random random = new Random();
            int[] int_array = new int[4];
            for(int i = 0; i < 4; i++)
            {
                int index = random.Next(0, random_list.Count);
                int_array[i] = random_list[index];
                random_list.RemoveAt(index);
            }
            Number = String.Join("", int_array);
        }
        private int[] ConvertFromString(string Source)
        {
            char[] cha = Source.ToCharArray();
            int[] output = Array.ConvertAll(cha, x => Convert.ToInt32(x.ToString()));
            return output;
        }
        public int[] Compare(int[] inputnumber,int[] correctnumber)
        {
            int A = 0;
            int B = 0;
            List<int> input_ = new List<int>(inputnumber);
            List<int> correct_ = new List<int>(correctnumber);
            int offset = 0;
            for (int i = 0; i < inputnumber.Count();i++)
            {
                if (inputnumber[i] == correctnumber[i])
                {
                    A++;
                    input_[i] = -1;
                    correct_[i] = -1;
                    offset += 1;
                }
            }
            input_.RemoveAll(x => x == -1);
            correct_.RemoveAll(x => x == -1);
            B = input_.Intersect(correct_).Count();
            return new int[] {A,B};
        }
        private string ConvertFromIntArray(int[] Source)
        {
            return String.Join("", Source);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int[] inputNumber = ConvertFromString(InputNumber);
            int[] correctnumber = ConvertFromString(Number);
            int[] Result = Compare(inputNumber, correctnumber);
            ListViewItem lvi = new ListViewItem(new string[] {$"{ConvertFromIntArray(inputNumber)}",$"{Result[0]}A{Result[1]}B"});
            listView1.Items.Add(lvi);
            if (Result[0] == 4)
            {
                MessageBox.Show($"恭喜您，您成功猜對了。正確的數字即為{Number}!", "過關", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Disable();
            }
        }
        private void d_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            switch (e.KeyCode)
            {
                case Keys.Back:
                    if(textBox.TabIndex > 0&&textBox.Text.Length==0)
                    {
                        TextBox text = (TextBox)panel1.Controls[$"d{textBox.TabIndex}"];
                        text.Focus();
                        text.Select(0, 1);
                    }
                    break;
                case Keys.Left:
                    if (textBox.TabIndex > 0)
                    {
                        TextBox text = (TextBox)panel1.Controls[$"d{textBox.TabIndex}"];
                        text.Focus();
                        text.Select(0, 1);
                    }
                    break;
                case Keys.Right:
                    if (textBox.TabIndex < 3)
                    {
                        TextBox text = (TextBox)panel1.Controls[$"d{textBox.TabIndex + 2}"];
                        text.Focus();
                        text.Select(0, 1);
                    }
                    break;
            }
        }
    }
}