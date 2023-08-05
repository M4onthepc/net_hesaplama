using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace net_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double turkceDogru, turkceYanlis, turkceNet;
            double matDogru, matYanlis, matNet;
            double fizikDogru, fizikYanlis, fizikNet;
            double kimyaDogru, kimyaYanlis, kimyaNet;
            double biyolojiDogru,biyolojiYanlis, biyolojiNet;
            double tarihDogru, tarihYanlis,tarihNet;
            double cogDogru, cogYanlis, cogNet;
            double felsefeDogru , felsefeYanlis, felsefeNet;
            double dinDogru , dinYanlis, dinNet;

            turkceDogru = Convert.ToDouble(txtTurkceDogru.Text);
            turkceYanlis= Convert.ToDouble(txtTurkceYanlis.Text);

            matDogru= Convert.ToDouble(txtMatDogru.Text);
            matYanlis= Convert.ToDouble(txtMatYanlis.Text);

            fizikDogru = Convert.ToDouble(txtFizikDogru.Text);
            fizikYanlis = Convert.ToDouble(txtFizikYanlis.Text);

            kimyaDogru = Convert.ToDouble(txtKimyaDogru.Text);
            kimyaYanlis = Convert.ToDouble(txtKimyaYanlis.Text);

            biyolojiDogru = Convert.ToDouble(txtBiyolojiDogru.Text);
            biyolojiYanlis= Convert .ToDouble(txtBiyolojiYanlis.Text);

            tarihDogru = Convert.ToDouble(txtTarihDogru.Text);
            tarihYanlis = Convert.ToDouble(txtTarihYanlis.Text);

            cogDogru = Convert.ToDouble(txtCogDogru.Text);
            cogYanlis = Convert.ToDouble(txtCogYanlis.Text);

            felsefeDogru = Convert.ToDouble(txtFelsefeDogru.Text);
            felsefeYanlis = Convert.ToDouble(txtFelsefeYanlis.Text);

            dinDogru = Convert.ToDouble(txtDinDogru.Text);
            dinYanlis = Convert.ToDouble(txtDinYanlis.Text);

            turkceNet = turkceDogru - (turkceYanlis / 4);
            matNet = matDogru - (matYanlis / 4);
            fizikNet = fizikDogru - (fizikYanlis / 4);
            kimyaNet = kimyaDogru - (kimyaYanlis / 4);
            biyolojiNet = biyolojiDogru - (biyolojiYanlis / 4);
            tarihNet = tarihDogru - (tarihYanlis / 4);
            cogNet=cogDogru - (cogYanlis / 4);
            felsefeNet = felsefeDogru - (felsefeYanlis / 4);
            dinNet = dinDogru - (dinYanlis / 4);

            txtTurkceNet.Text = turkceNet.ToString();
            txtMatNet.Text = matNet.ToString();
            txtFizikNet.Text = fizikNet.ToString();
            txtKimyaNet.Text = kimyaNet.ToString();
            txtBiyolojiNet.Text=biyolojiNet.ToString();
            txtTarihNet.Text = tarihNet.ToString();
            txtCogNet.Text = cogNet.ToString();
            txtFelsefeNet.Text = felsefeNet.ToString();
            txtDinNet.Text = dinNet.ToString();
        }

        private void sayiGiris(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void kırkSoruGirebilme(object sender, KeyPressEventArgs e)
        {
            
        }

        private void soruSayiBelirleme(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtTurkceDogru.Text) < 0 || Convert.ToInt32(txtTurkceDogru.Text) > 40)
                {
                    MessageBox.Show("Değer 0-40 arasında olmalı");
                    txtTurkceDogru.Text = "";
                    txtTurkceDogru.Focus();
                }
            }
            catch
            { }
            try
            {
                if (Convert.ToInt32(txtTurkceYanlis.Text) < 0 || Convert.ToInt32(txtTurkceYanlis.Text) > 40)
                {
                    MessageBox.Show("Değer 0-40 arasında olmalı");
                    txtTurkceYanlis.Text = "";
                    txtTurkceYanlis.Focus();
                }
            }
            catch
            { }
            try
            {
                if (Convert.ToInt32(txtMatDogru.Text) < 0 || Convert.ToInt32(txtMatDogru.Text) > 40)
                {
                    MessageBox.Show("Değer 0-40 arasında olmalı");
                    txtMatDogru.Text = "";
                    txtMatDogru.Focus();
                }
            }
            catch
            { }
            try
            {
                if (Convert.ToInt32(txtMatYanlis.Text) < 0 || Convert.ToInt32(txtMatYanlis.Text) > 40)
                {
                    MessageBox.Show("Değer 0-40 arasında olmalı");
                    txtMatYanlis.Text = "";
                    txtMatYanlis.Focus();
                }
            }
            catch
            { }
        }

        private void sayiGirisDogru(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void fenSoruSayisi(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtFizikDogru.Text) < 0 || Convert.ToInt32(txtFizikDogru.Text) > 14)
                {
                    MessageBox.Show("Değer 0-14 arasında olmalı");
                    txtFizikDogru.Text = "";
                    txtFizikDogru.Focus();
                }
            }
            catch
            { }
            try
            {
                if (Convert.ToInt32(txtFizikYanlis.Text) < 0 || Convert.ToInt32(txtFizikYanlis.Text) > 14)
                {
                    MessageBox.Show("Değer 0-14 arasında olmalı");
                    txtFizikYanlis.Text = "";
                    txtFizikYanlis.Focus();
                }
            }
            catch
            { }
            try
            {
                if (Convert.ToInt32(txtKimyaDogru.Text) < 0 || Convert.ToInt32(txtKimyaDogru.Text) > 13)
                {
                    MessageBox.Show("Değer 0-13 arasında olmalı");
                    txtKimyaDogru.Text = "";
                    txtKimyaDogru.Focus();
                }
            }
            catch
            { }
            try
            {
                if (Convert.ToInt32(txtKimyaYanlis.Text) < 0 || Convert.ToInt32(txtKimyaYanlis.Text) > 13)
                {
                    MessageBox.Show("Değer 0-13 arasında olmalı");
                    txtKimyaYanlis.Text = "";
                    txtKimyaYanlis.Focus();
                }
            }
            catch
            { }
            try
            {
                if (Convert.ToInt32(txtBiyolojiDogru.Text) < 0 || Convert.ToInt32(txtBiyolojiDogru.Text) > 13)
                {
                    MessageBox.Show("Değer 0-13 arasında olmalı");
                    txtBiyolojiDogru.Text = "";
                    txtBiyolojiDogru.Focus();
                }
            }
            catch
            { }
            try
            {
                if (Convert.ToInt32(txtBiyolojiYanlis.Text) < 0 || Convert.ToInt32(txtBiyolojiYanlis.Text) > 13)
                {
                    MessageBox.Show("Değer 0-13 arasında olmalı");
                    txtBiyolojiYanlis.Text = "";
                    txtBiyolojiYanlis.Focus();
                }
            }
            catch
            { }
        }

        private void sosyalSoruSayisi(object sender, KeyPressEventArgs e)
        {
        }

        private void sosyalSoruSayisi(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToInt32(txtTarihDogru.Text) < 0 || Convert.ToInt32(txtTarihDogru.Text) > 13)
                {
                    MessageBox.Show("Değer 0-13 arasında olmalı");
                    txtTarihDogru.Text = "";
                    txtTarihDogru.Focus();
                }
            }
            catch { }
            try
            {
                if (Convert.ToInt32(txtTarihYanlis.Text) < 0 || Convert.ToInt32(txtTarihYanlis.Text) > 13)
                {
                    MessageBox.Show("Değer 0-13 arasında olmalı");
                    txtTarihYanlis.Text = "";
                    txtTarihYanlis.Focus();
                }
            }
            catch { }
            try
            {
                if (Convert.ToInt32(txtCogDogru.Text) < 0 || Convert.ToInt32(txtCogDogru.Text) > 13)
                {
                    MessageBox.Show("Değer 0-13 arasında olmalı");
                    txtCogDogru.Text = "";
                    txtCogDogru.Focus();
                }
            }
            catch { }
            try
            {
                if (Convert.ToInt32(txtCogYanlis.Text) < 0 || Convert.ToInt32(txtCogYanlis.Text) > 13)
                {
                    MessageBox.Show("Değer 0-13 arasında olmalı");
                    txtCogYanlis.Text = "";
                    txtCogYanlis.Focus();
                }
            }
            catch { }
            try
            {
                if (Convert.ToInt32(txtFelsefeDogru.Text) < 0 || Convert.ToInt32(txtFelsefeDogru.Text) > 13)
                {
                    MessageBox.Show("Değer 0-13 arasında olmalı");
                    txtFelsefeDogru.Text = "";
                    txtFelsefeDogru.Focus();
                }
            }
            catch { }
            try
            {
                if (Convert.ToInt32(txtFelsefeYanlis.Text) < 0 || Convert.ToInt32(txtFelsefeYanlis.Text) > 13)
                {
                    MessageBox.Show("Değer 0-13 arasında olmalı");
                    txtFelsefeYanlis.Text = "";
                    txtFelsefeYanlis.Focus();
                }
            }
            catch { }
            try
            {
                if (Convert.ToInt32(txtDinDogru.Text) < 0 || Convert.ToInt32(txtDinDogru.Text) > 13)
                {
                    MessageBox.Show("Değer 0-13 arasında olmalı");
                    txtDinDogru.Text = "";
                    txtDinDogru.Focus();
                }
            }
            catch { }
            try
            {
                if (Convert.ToInt32(txtDinYanlis.Text) < 0 || Convert.ToInt32(txtDinYanlis.Text) > 13)
                {
                    MessageBox.Show("Değer 0-13 arasında olmalı");
                    txtDinYanlis.Text = "";
                    txtDinYanlis.Focus();
                }
            }
            catch { }

        }

        private void harfGirmeme(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
