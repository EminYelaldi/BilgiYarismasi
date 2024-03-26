namespace BilgiYarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogru = 0, yanlis = 0;

        private void btnSonra_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;    
            btnSonra.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

           

            soruNo++;

            lblSoru.Text = soruNo.ToString();
            
            if (soruNo == 1)
            {

                richTextBox1.Text = "“Çalıkuşu” kitabının yazarı kimdir?";
                btnA.Text = "Halide Edip Adıvar";
                btnB.Text = "Sait Faik Abasıyanık";
                btnC.Text = "Orhan Kemal";
                btnD.Text = "Reşat Nuri Güntekin";
                label4.Text = "Reşat Nuri Güntekin";

            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "İki tane başkenti olan ülke hangisidir?";
                btnA.Text = "Senegal";
                btnB.Text = "Kamboçya";
                btnC.Text = "Güney Afrika";
                btnD.Text = "El Salvador";
                label4.Text = "Güney Afrika";

            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Bir Gün Kaç Saniyedir?";
                btnA.Text = "86000";
                btnB.Text = "88600";
                btnC.Text = "86400";
                btnD.Text = "84800";
                label4.Text = "86400";

            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "Hangi İlimizde Demiryolu Yoktur?";
                btnA.Text = "Batman";
                btnB.Text = "Kütahya";
                btnC.Text = "Aydın";
                btnD.Text = "Muğla";
                label4.Text = "Muğla";

            }
            if (soruNo == 5)
            {
                richTextBox1.Text = "2003 Yılında Euro Vizyon Şarkı Yarışmasında Ülkemizi Temsil Eden ve Yarışmada Birinci Gelen Sanatçımız Kimdir?";
                btnA.Text = "Grup Athena";
                btnB.Text = "Sertap Erener";
                btnC.Text = "Şebnem Paker";
                btnD.Text = "Ajda Pekkan";
                label4.Text = "Sertap Erener";
                btnSonra.Text = "Sonuclar";

            }
            if (soruNo == 6)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonra.Enabled = false;

                MessageBox.Show ("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);

            }
        }
        private void btnA_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonra.Enabled=true;

            
            label5.Text = btnA.Text;

            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonra.Enabled = true;

            label5.Text = btnB.Text;

            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonra.Enabled = true;

            label5.Text = btnC.Text;

            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }
        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonra.Enabled = true;

            label5.Text = btnD.Text;

            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }
    }

    
}