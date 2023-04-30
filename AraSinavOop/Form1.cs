using static AraSinavOop.Program;
using static AraSinavOop.Program.Personel;

namespace AraSinavOop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<String> MyAD = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            Personel p = new Personel()
            {

                personelAd = textBox1.Text,
                personelSoyad = textBox2.Text,
                Email = textBox3.Text,
                tc = textBox4.Text,
                no = textBox5.Text,
                kayit = textBox6.Text,
             
            };
            MyAD.Add(textBox1.Text);
            foreach (Control item in tabPage1.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }

            p.pro1();
            ListViewItem itm = new ListViewItem(p.pro1());
            listView1.Items.Add(itm);

            comboBox3.Items.Clear();
            foreach (var item in MyAD)
            {
                comboBox3.Items.Add(item);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Text = textBox1.Text;
                listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
                listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;
                listView1.SelectedItems[0].SubItems[3].Text = textBox4.Text;
                listView1.SelectedItems[0].SubItems[4].Text = textBox6.Text;
                listView1.SelectedItems[0].SubItems[5].Text = textBox5.Text;
            }
            foreach (Control item in tabPage1.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
            foreach (Control item in tabPage1.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }
            MyAD.Clear();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                MyAD.Add(listView1.Items[i].Text);
            }
            comboBox3.Items.Clear();
            foreach (var item in MyAD)
            {
                comboBox3.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBox6.Text = listView1.SelectedItems[0].SubItems[4].Text;
                textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
              
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            proje p = new proje()
            {
                projeAd = Gor1text.Text,
                personelAd = comboBox3.SelectedItem.ToString(),
                projekonusu = textBox7.Text,

                baslangic = textBox10.Text,
                bitis = textBox8.Text,
                durum = comboBox4.SelectedItem.ToString(),
            };
            foreach (Control item in tabPage2.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }
            p.gor1();
            ListViewItem itm = new ListViewItem(p.gor1());
            listView2.Items.Add(itm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                listView2.SelectedItems[0].Text = Gor1text.Text;
                listView2.SelectedItems[0].SubItems[1].Text = textBox7.Text;

                listView2.SelectedItems[0].SubItems[2].Text = textBox10.Text;
                listView2.SelectedItems[0].SubItems[3].Text = textBox8.Text;
                listView2.SelectedItems[0].SubItems[4].Text = comboBox3.Text;
                listView2.SelectedItems[0].SubItems[5].Text = comboBox4.Text;

            }
            foreach (Control item in tabPage2.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                Gor1text.Text = listView2.SelectedItems[0].Text;
                textBox7.Text = listView2.SelectedItems[0].SubItems[1].Text;


                textBox10.Text = listView2.SelectedItems[0].SubItems[2].Text;
                textBox8.Text = listView2.SelectedItems[0].SubItems[3].Text;
                comboBox3.Text = listView2.SelectedItems[0].SubItems[4].Text;

                comboBox4.Text = listView2.SelectedItems[0].SubItems[5].Text;


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                listView2.Items.Remove(listView2.SelectedItems[0]);
            }
            foreach (Control item in tabPage2.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}