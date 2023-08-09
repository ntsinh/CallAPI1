using CallAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void userControl11__TextChanged(object sender, EventArgs e)
        {
            if (userControl11.textBox1_Text.Length >= 5)
            {
                label1.Text = "";
                if (userControl11.textBox1_Text.Contains(" "))
                {
                    userControl11.BorderColor = Color.Red;
                    label1.Text = "Username không được có khoảng trắng";
                }
                else
                {
                    userControl11.BorderColor = Color.Orange;
                }
            }
            else {
                userControl11.BorderColor = Color.Red;
                label1.Text = "UserName Phải từ 5 kí tự";
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void userControl12__TextChanged(object sender, EventArgs e)
        {
            
            if (userControl12.textBox1_Text.Length >= 8 && userControl12.textBox1_Text.Length <= 20)
            {
                label4.Text = "";
                if (userControl12.textBox1_Text.Contains(" "))
                {
                    label4.Text = "Password không được chứa khoảng trắng";
                    userControl12.BorderColor = Color.Red;
                }
                else
                {
                    label4.Text = "";
                    userControl12.BorderColor = Color.Orange;
                }
            }
            else
            {
                userControl12.BorderColor = Color.Red;
                label4.Text = "Password phải từ 8 - 20 kí tự";
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (userControl11.textBox1_Text.Equals("admin") && userControl12.textBox1_Text.Equals("12345678"))
            {
              //MessageBox.Show("Đăng nhập thành công");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai UserName hoặc Password");
            } 
        }
    }
}
