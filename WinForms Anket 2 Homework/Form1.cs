using WinForms_Anket_2_Homework.models;
using static WinForms_Anket_2_Homework.models.JsonHandling;

namespace WinForms_Anket_2_Homework {
    public partial class Form1 : Form {
        List<Anket> ankets = new();
        public Form1() {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                Anket anket = ReadData<Anket>(openFileDialog1.FileName)!;
                ankets.Add(anket);
                Ankets.Items.Add(anket.Name);
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            Gender gender = new();
            if (MaleRadioButton.Checked == true) {
                gender = Gender.Male;
            }
            else gender = Gender.Female;

            Anket anket = new(nameBox.Text, surnameBox.Text, emailBox.Text, phoneBox.Text, Birthday.Text, gender);
            ankets.Add(anket);
            Ankets.Items.Add(anket.Name);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (Anket anket in ankets)
                {
                    if (anket.Name == fileNameBox.Text)
                    {
                        WriteData<Anket>(anket, folderBrowserDialog1.SelectedPath + "\\" + fileNameBox.Text + ".json");
                    }
                }
            }
        }

        private void changeButton_Click(object sender, EventArgs e) {
            Anket anket = ankets[Ankets.SelectedIndex];
            nameBox.Text = anket.Name;
            surnameBox.Text = anket.Surname;
            emailBox.Text = anket.Email;
            phoneBox.Text = anket.Phone;
            Birthday.Text = anket.Datetime;
            if (anket.Gender == Gender.Male) MaleRadioButton.Checked = true;
            else FemaleRadioButton.Checked = true;
        }
    }
}