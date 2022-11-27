using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace McDonald_s
{
    public partial class Form2 : Form
    {
        public bool burger_clicked = false;
        public bool nuggets_clicked = false;
        public bool desserts_clicked = false;
        public bool mccafe_clicked = false;
        public bool drinks_clicked = false;
        
        public class SaleItem
        {
            public string Name { get; private set; }
            public double Price { get; private set; }    
        }
       
        public class Helper
        {
            public static Timer timer; 
        }
        public Form2()
        {
            InitializeComponent();
            


            this.button1.Hide();
            this.button2.Hide();
            this.Price1.Hide();
            this.Price2.Hide();
            this.label3.Hide();
            this.label4.Hide();
            Helper.timer = new Timer();
            Helper.timer.Tick += (sender, args) =>
            {
                Helper.timer.Enabled = false;
                const string caption = "Warning";
                var msgBox = MessageBox.Show("You are not active", caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msgBox == DialogResult.Yes)
                {
                    Helper.timer.Enabled = false;
                    Helper.timer.Enabled = true;
                }
                else if (msgBox == DialogResult.No)
                {
                    Helper.timer.Enabled = false;
                    this.Close();
                }
            };
            comboBox1.Click += (sender, args) =>
            {
                comboBox1.Text = "";
                Helper.timer.Enabled = false;
                Helper.timer.Enabled = true;
            };
            BurgerBtn.Click += (sender, args) =>
            {
                burger_clicked = true;
                Helper.timer.Enabled = false;
                Helper.timer.Enabled = true;
                
            };
            NuggetsBtn.Click += (sender, args) =>
            {
                nuggets_clicked = true;
                Helper.timer.Enabled = false;
                Helper.timer.Enabled = true;
            };
            McCafeBtn.Click += (sender, args) =>
            {
                mccafe_clicked = true;
                Helper.timer.Enabled = false;
                Helper.timer.Enabled = true;
            };
            DessertsBtn.Click += (sender, args) =>
            {
                desserts_clicked = true;
                Helper.timer.Enabled = false;
                Helper.timer.Enabled = true;
                
            };
            DrinksBtn.Click += (sender, args) =>
            {
                drinks_clicked = true;
                Helper.timer.Enabled = false;
                Helper.timer.Enabled = true;
                
            };
            LINQSearchBtn.Click += (sender, args) =>
            {
                Helper.timer.Enabled = false;
                Helper.timer.Enabled = true;
            };
            button1.Click += (sender, args) =>
            {
                Helper.timer.Enabled = false;
                Helper.timer.Enabled = true;
            };
            button2.Click += (sender, args) =>
            {
                Helper.timer.Enabled = false;
                Helper.timer.Enabled = true;
            };
            CheckOrderBtn.Click += (sender, args) =>
            {
                Helper.timer.Enabled = false;
                Helper.timer.Enabled = true;
            };  
        }
        private void BurgerBtn_Click(object sender, EventArgs e)
        {
            this.button1.Show();
            this.button2.Show();
            this.Price1.Show();
            this.Price2.Show();
            this.label3.Show();
            this.label4.Show();
            this.Price1.Text = "150.00";
            this.Price2.Text = "125.00";
            this.button1.Text = "Big Mac";
            this.button2.Text = "McChicken Sandwich";
        }
        private void NuggetsBtn_Click(object sender, EventArgs e)
        {
            
            this.button1.Show();
            this.button2.Show();
            this.Price1.Show();
            this.Price2.Show();
            this.label3.Show();
            this.label4.Show();
            this.Price1.Text = "90.00";
            this.Price1.Text = "110.00";
            this.button1.Text = "6 Chicken McNuggets";
            this.button2.Text = "9 Chicken McNuggets";
        }
        private void McCafeBtn_Click(object sender, EventArgs e)
        {
          
            this.button1.Show();
            this.button2.Show();
            this.Price1.Show();
            this.Price2.Show();
            this.label3.Show();
            this.label4.Show();
            this.Price1.Text = "30.00";
            this.Price2.Text = "45.00";
            this.button1.Text = "Капучіно";
            this.button2.Text = "Лате";
        }
        private void DessertsBtn_Click(object sender, EventArgs e)
        {
            
            this.button1.Show();
            this.button2.Show();
            this.Price1.Show();
            this.Price2.Show();
            this.label3.Show();
            this.label4.Show();
            this.Price1.Text = "74.50";
            this.Price2.Text = "56.50";
            this.button1.Text = "Oreo McFlurry";
            this.button2.Text = "Яблучний пиріг";
        }
        private void DrinksBtn_Click(object sender, EventArgs e)
        {
            
            this.button1.Show();
            this.button2.Show();
            this.Price1.Show();
            this.Price2.Show();
            this.label3.Show();
            this.label4.Show();
            this.Price1.Text = "25.40";
            this.Price2.Text = "25.40";
            this.button1.Text = "Кока кола";
            this.button2.Text = "Фанта";
        }
        private void CancelOrderBtn_Click(object sender, EventArgs e)
        {
            const string message = "Ви впевнені що хочете скасувати замовлення?";
            const string capture = "Попередження";
            var result = MessageBox.Show(message, capture, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                return;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Helper.timer.Interval = 30000;
            Helper.timer.Enabled = true;
        }

        private void LINQSearchBtn_Click(object sender, EventArgs e)
        {
            if((burger_clicked == false && nuggets_clicked == false && desserts_clicked == false && mccafe_clicked == false && drinks_clicked == false) && (comboBox1.Text == null || comboBox1.Text == "" || comboBox1.Text == "Оберіть критерій пошуку із запропонованих списком"))
            {
                var msgBox = MessageBox.Show("Оберіть категорію та критерій пошуку", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (msgBox == DialogResult.OK)
                {
                    Helper.timer.Enabled = false;
                    Helper.timer.Enabled = true;
                }
            }
            else if((burger_clicked == true || nuggets_clicked == true || desserts_clicked == true || mccafe_clicked == true || drinks_clicked == true) && (comboBox1.Text == null || comboBox1.Text == "" || comboBox1.Text == "Оберіть критерій пошуку із запропонованих списком"))
            {
                var msgBox = MessageBox.Show("Оберіть критерій пошуку", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(msgBox != DialogResult.OK)
                {
                    Helper.timer.Enabled = false;
                    Helper.timer.Enabled = true;
                }
            }
            else if((burger_clicked == false && nuggets_clicked == false && desserts_clicked == false && mccafe_clicked == false && drinks_clicked == false) && (comboBox1.Text != null || comboBox1.Text != "" || comboBox1.Text != "Оберіть критерій пошуку із запропонованих списком"))
            {
                var msgBox = MessageBox.Show("Оберіть категорію", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (msgBox == DialogResult.OK)
                {
                    Helper.timer.Enabled = false;
                    Helper.timer.Enabled = true;
                }
            }
            else
            {
               
            }

        }
    }
}

