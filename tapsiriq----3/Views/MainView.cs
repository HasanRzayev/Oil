using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tapsiriq____3.Views
{
    public partial class MainView : Form,IMainView 
    {
        public MainView()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> BuyEventHandler { get; set; }
        public string Benzinqiymeti { get =>textBox_qiymet.Text; set => textBox_qiymet.Text=value; }
        public string Litr { get =>    textBox_litr.Text  ; set => textBox_litr.Text    =value    ; }
        public string Manat { get =>    textBox_manat.Text  ; set => textBox_manat.Text    =value    ; }
        public string Sendvicqiymet { get =>    textBox_sendvic.Text  ; set =>textBox_sendvic.Text  =value     ; }
        public string Hamburgerqiymet { get =>   textBox_hamburger.Text; set =>textBox_hamburger.Text =value  ; }
        public string Pizzaqiymet { get =>textBox_pizza.Text  ; set =>textBox_pizza.Text    =value  ; }
        public string Kokakolaqiymet { get =>    textBox_kola.Text    ; set =>     textBox_kola.Text    =value   ; }
        public string Fantaqiymet { get =>textBox_fanta.Text  ; set => textBox_fanta.Text    =value ; }
        public string Sendvicqiymetsay { get =>  textBox_sendvic2.Text ; set =>textBox_sendvic2.Text  =value  ; }
        public string Hamburgerqiymetsay { get => textBox_hamburger2.Text ; set =>    textBox_hamburger2.Text=value    ; }
        public string Pizzaqiymetsay { get =>    textBox_pizza2.Text; set =>  textBox_pizza2.Text   =value; }
        public string Kokakolaqiymetsay { get =>  textBox_kola2.Text   ; set => textBox_kola2.Text = value; }
        public string Fantaqiymetsay { get => textBox_fanta2.Text; set => textBox_fanta2.Text=value; }
  
        public List<string> combo_benzinler1 {  set => new List<string> { "92","95"}; }
        public EventHandler<EventArgs> radiobuttonlitrEventHandler { get ; set; }
        public EventHandler<EventArgs> radiobuttonmanatEventHandler { get; set; }
        public string benzinumumiqiymet { get =>label_umumibenzinqiymeti.Text; set => label_umumibenzinqiymeti.Text=value; }
   



        private void button1_click(object sender, EventArgs e)
        {
            if (label_umumibenzinqiymeti != null)
            {
                simpleSound.Play();
            }
        }
        SoundPlayer simpleSound = new SoundPlayer("Para sesi para kasası sesi (320 kbps).wav");
        double sandvic = 0;
        double hamburger = 0;
        double pizza = 0;
        double kola = 0;
        double fanta = 0;
        double benzinqiymeti = 0;
        double kafe = 0;

        private void combo_benzinler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_benzinler.SelectedItem as string == "Dizel") textBox_qiymet.Text = "0.60";
            else if (combo_benzinler.SelectedItem as string == "Super") textBox_qiymet.Text = "1.20";
            else if (combo_benzinler.SelectedItem as string == "Premium") textBox_qiymet.Text = "1.15";
            else if (combo_benzinler.SelectedItem as string == "A-92") textBox_qiymet.Text = "0.70";
            else if (combo_benzinler.SelectedItem as string == "A-95") textBox_qiymet.Text = "0.80";
        }

        private void textBox_litr_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox_litr.Text) == true)
            {
                label_umumibenzinqiymeti.Text = "0";
            }


            if (radioButton_litr.Checked == true && !string.IsNullOrWhiteSpace(textBox_litr.Text))
            {

                benzinqiymeti = (Convert.ToDouble(textBox_qiymet.Text) * Convert.ToDouble(textBox_litr.Text));
                label_umumibenzinqiymeti.Text = benzinqiymeti.ToString();
            }
        }

        private void radioButton_litr_CheckedChanged(object sender, EventArgs e)
        {
            label_umumibenzinqiymeti.Text = "0";
            textBox_manat.Text = null;
            if (radioButton_litr.Checked == true)
            {
                textBox_manat.Enabled = false;
                textBox_litr.Enabled = true;
            }
        }

        private void radioButton_manat_CheckedChanged(object sender, EventArgs e)
        {
            label_umumibenzinqiymeti.Text = "0";
            textBox_litr.Text = null;
            if (radioButton_manat.Checked == true)
            {
                textBox_litr.Enabled = false;
                textBox_manat.Enabled = true;

            }
        }

        private void textBox_manat_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_manat.Checked == true && !string.IsNullOrWhiteSpace(textBox_manat.Text))
            {
                textBox_litr.Text = null;

                label_umumibenzinqiymeti.Text = textBox_manat.Text;
            }
        }

        private void checkBox_sendvic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sendvic.Checked == true) textBox_sendvic2.Enabled = true;
            else
            {
                textBox_sendvic2.Enabled = false;
                textBox_sendvic2.Text = null;
            }
        }

        private void checkBox_hamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_hamburger.Checked == true) textBox_hamburger2.Enabled = true;
            else
            {
                textBox_hamburger2.Enabled = false;
                textBox_hamburger2.Text = null;
            }
        }

        private void checkBox_pizza_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pizza.Checked == true) textBox_pizza2.Enabled = true;
            else
            {
                textBox_pizza2.Enabled = false;
                textBox_pizza2.Text = null;

            }
        }

        private void checkBox_kola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_kola.Checked == true) textBox_kola2.Enabled = true;
            else
            {
                textBox_kola2.Enabled = false;
                textBox_kola2.Text = null;
            }
        }

        private void checkBox_fanta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_fanta.Checked == true) textBox_fanta2.Enabled = true;
            else
            {
                textBox_fanta2.Enabled = false;
                textBox_fanta2 = null;
            }
        }

        private void textBox_sendvic2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_sendvic2.Text))
            {
                sandvic = double.Parse(textBox_sendvic.Text) * double.Parse(textBox_sendvic2?.Text);
                label_kafe.Text = (sandvic + hamburger + pizza + kola + fanta).ToString();
            }
            else
            {
                sandvic = 0;
                label_kafe.Text = (sandvic + hamburger + pizza + kola + fanta).ToString();
            }
        }

        private void textBox_hamburger2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_sendvic2.Text))
            {
                sandvic = double.Parse(textBox_sendvic.Text) * double.Parse(textBox_sendvic2?.Text);
                label_kafe.Text = (sandvic + hamburger + pizza + kola + fanta).ToString();
            }
            else
            {
                sandvic = 0;
                label_kafe.Text = (sandvic + hamburger + pizza + kola + fanta).ToString();
            }
        }

        private void textBox_pizza2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_pizza2.Text))
            {
                pizza = double.Parse(textBox_pizza.Text) * double.Parse(textBox_pizza2.Text);
                label_kafe.Text = (sandvic + hamburger + pizza + kola + fanta).ToString();
            }
            else
            {
                pizza = 0;

                label_kafe.Text = (sandvic + hamburger + pizza + kola + fanta).ToString();
            }
        }

        private void textBox_kola2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_kola2.Text))
            {
                kola = double.Parse(textBox_kola.Text) * double.Parse(textBox_kola2.Text);
                label_kafe.Text = (sandvic + hamburger + pizza + kola + fanta).ToString();
            }
            else
            {
                kola = 0;

                label_kafe.Text = (sandvic + hamburger + pizza + kola + fanta).ToString();
            }
        }

        private void textBox_fanta2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_fanta2.Text))
            {
                fanta = double.Parse(textBox_fanta.Text) * double.Parse(textBox_fanta2.Text);
                label_kafe.Text = (sandvic + hamburger + pizza + kola + fanta).ToString();
            }
            else
            {
                fanta = 0;

                label_kafe.Text = (sandvic + hamburger + pizza + kola + fanta).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label_umumibenzinqiymeti_Click(object sender, EventArgs e)
        {
            benzinqiymeti = double.Parse(label_umumibenzinqiymeti.Text);
            umumi.Text = (kafe + benzinqiymeti).ToString(); ;
        }

        private void label_kafe_Click(object sender, EventArgs e)
        {
            kafe = double.Parse(label_kafe.Text);
            umumi.Text = (kafe + benzinqiymeti).ToString(); ;
        }
    }
}

