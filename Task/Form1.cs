using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Task
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taskDBDataSet2.Health_status". При необходимости она может быть перемещена или удалена.
            this.health_statusTableAdapter.Fill(this.taskDBDataSet2.Health_status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taskDBDataSet1.Personal_information". При необходимости она может быть перемещена или удалена.
            this.personal_informationTableAdapter.Fill(this.taskDBDataSet1.Personal_information);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taskDBDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.taskDBDataSet.Employee);
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TaskDB"].ConnectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
                MessageBox.Show("Подключение установленно");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "Name";
            textBox2.ForeColor = Color.Gray;
            textBox2.Text = "Surname";
            textBox3.ForeColor = Color.Gray;
            textBox3.Text = "Patronymic";
            textBox4.ForeColor = Color.Gray;
            textBox4.Text = "Position";
            textBox5.ForeColor = Color.Gray;
            textBox5.Text = "Salary";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Name" && textBox2.Text != "Surname" && textBox4.Text != "Position" && textBox5.Text != "Salary")
            {
                SqlCommand command = new SqlCommand("INSERT INTO Employee (Name, Surname, Patronymic, Position, Salary) VALUES (@Name, @Surname, @Patronymic, @Position, @Salary)", sqlConnection);

                command.Parameters.AddWithValue("Name", textBox1.Text);
                command.Parameters.AddWithValue("Surname", textBox2.Text);
                if (textBox3.Text == "Patronymic")
                    command.Parameters.AddWithValue("Patronymic", DBNull.Value);
                else
                    command.Parameters.AddWithValue("Patronymic", textBox3.Text);
                command.Parameters.AddWithValue("Position", textBox4.Text);
                command.Parameters.AddWithValue("Salary", textBox5.Text);

                MessageBox.Show("Успешно сохранена "+command.ExecuteNonQuery().ToString()+" запись в базу данных!");

                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                button4.Visible = false;
                button5.Visible = false;

                textBox1.ForeColor = Color.Gray;
                textBox1.Text = "Name";
                textBox2.ForeColor = Color.Gray;
                textBox2.Text = "Surname";
                textBox3.ForeColor = Color.Gray;
                textBox3.Text = "Patronymic";
                textBox4.ForeColor = Color.Gray;
                textBox4.Text = "Position";
                textBox5.ForeColor = Color.Gray;
                textBox5.Text = "Salary";

                dataGridView2.Update();
            }
            else
                MessageBox.Show("Ввод данных некорректен!");
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Name")
            {
                textBox1.Text = null;
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Surname")
            {
                textBox2.Text = null;
                textBox2.ForeColor = Color.Black;
            }
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Patronymic")
            {
                textBox3.Text = null;
                textBox3.ForeColor = Color.Black;
            }
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Position")
            {
                textBox4.Text = null;
                textBox4.ForeColor = Color.Black;
            }
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Salary")
            {
                textBox5.Text = null;
                textBox5.ForeColor = Color.Black;
            }
        }
        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Number")
            {
                textBox7.Text = null;
                textBox7.ForeColor = Color.Black;
            }
        }
        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Email")
            {
                textBox8.Text = null;
                textBox8.ForeColor = Color.Black;
            }
        }
        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Address")
            {
                textBox9.Text = null;
                textBox9.ForeColor = Color.Black;
            }
        }
        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "Date_of_birth")
            {
                textBox10.Text = null;
                textBox10.ForeColor = Color.Black;
            }
        }
        private void textBox11_Enter(object sender, EventArgs e)
        {
            if (textBox11.Text == "Passport_series")
            {
                textBox11.Text = null;
                textBox11.ForeColor = Color.Black;
            }
        }
        private void textBox13_Enter(object sender, EventArgs e)
        {
            if (textBox13.Text == "Education")
            {
                textBox13.Text = null;
                textBox13.ForeColor = Color.Black;
            }
        }
        private void textBox14_Enter(object sender, EventArgs e)
        {
            if (textBox14.Text == "ID_empl")
            {
                textBox14.Text = null;
                textBox14.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.Gray;
                textBox1.Text = "Name";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.ForeColor = Color.Gray;
                textBox2.Text = "Surname";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.ForeColor = Color.Gray;
                textBox3.Text = "Patronymic";
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.ForeColor = Color.Gray;
                textBox4.Text = "Position";
            }
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.ForeColor = Color.Gray;
                textBox5.Text = "Salary";
            }
        }
        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.ForeColor = Color.Gray;
                textBox7.Text = "Number";
            }
        }
        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.ForeColor = Color.Gray;
                textBox8.Text = "Email";
            }
        }
        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.ForeColor = Color.Gray;
                textBox9.Text = "Address";
            }
        }
        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                textBox10.ForeColor = Color.Gray;
                textBox10.Text = "Date_of_birth";
            }
        }
        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                textBox11.ForeColor = Color.Gray;
                textBox11.Text = "Passport_series";
            }
        }
        private void textBox13_Leave(object sender, EventArgs e)
        {
            if (textBox13.Text == "")
            {
                textBox13.ForeColor = Color.Gray;
                textBox13.Text = "Education";
            }
        }
        private void textBox14_Leave(object sender, EventArgs e)
        {
            if (textBox14.Text == "")
            {
                textBox14.ForeColor = Color.Gray;
                textBox14.Text = "ID_empl";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            textBox7.ForeColor = Color.Gray;
            textBox7.Text = "Number";
            textBox8.ForeColor = Color.Gray;
            textBox8.Text = "Email";
            textBox9.ForeColor = Color.Gray;
            textBox9.Text = "Address";
            textBox10.ForeColor = Color.Gray;
            textBox10.Text = "Date_of_birth";
            textBox11.ForeColor = Color.Gray;
            textBox11.Text = "Passport_series";
            textBox13.ForeColor = Color.Gray;
            textBox13.Text = "Education";
            textBox14.ForeColor = Color.Gray;
            textBox14.Text = "ID_empl";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox7.Text != "Number" && textBox10.Text != "Date_of_birth" && textBox11.Text != "Passport_series" && textBox13.Text != "Education" && textBox14.Text != "ID_empl")
                {
                    SqlCommand command = new SqlCommand("INSERT INTO [Personal information] (Number, Email, Address, Date_of_birth, Passport_series, Education, ID_empl) VALUES (@Number, @Email, @Address, @Date_of_birth, @Passport_series, @Education, @ID_empl)", sqlConnection);

                    command.Parameters.AddWithValue("Number", textBox7.Text);
                    if (textBox8.Text == "Email")
                        command.Parameters.AddWithValue("Email", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("Email", textBox8.Text);
                    if (textBox9.Text == "Address")
                        command.Parameters.AddWithValue("Address", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("Address", textBox9.Text);
                    command.Parameters.AddWithValue("Date_of_birth", textBox10.Text);
                    command.Parameters.AddWithValue("Passport_series", textBox11.Text);
                    command.Parameters.AddWithValue("Education", textBox13.Text);
                    command.Parameters.AddWithValue("ID_empl", textBox14.Text);

                    MessageBox.Show("Успешно сохранена " + command.ExecuteNonQuery().ToString() + " запись в базу данных!");

                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    textBox11.Visible = false;
                    textBox13.Visible = false;
                    textBox14.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;

                    textBox7.ForeColor = Color.Gray;
                    textBox7.Text = "Number";
                    textBox8.ForeColor = Color.Gray;
                    textBox8.Text = "Email";
                    textBox9.ForeColor = Color.Gray;
                    textBox9.Text = "Address";
                    textBox10.ForeColor = Color.Gray;
                    textBox10.Text = "Date_of_birth";
                    textBox11.ForeColor = Color.Gray;
                    textBox11.Text = "Passport_series";
                    textBox13.ForeColor = Color.Gray;
                    textBox13.Text = "Education";
                    textBox14.ForeColor = Color.Gray;
                    textBox14.Text = "ID_empl";
                }
                else
                    MessageBox.Show("Ввод данных некорректен!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ввод данных некорректен!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox15.Visible = true;
            textBox16.Visible = true;
            textBox17.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            textBox15.ForeColor = Color.Gray;
            textBox15.Text = "Med_exam_date";
            textBox16.ForeColor = Color.Gray;
            textBox16.Text = "Medical_card";
            textBox17.ForeColor = Color.Gray;
            textBox17.Text = "ID_empl";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
        private void textBox15_Enter(object sender, EventArgs e)
        {
            if (textBox15.Text == "Med_exam_date")
            {
                textBox15.Text = null;
                textBox15.ForeColor = Color.Black;
            }
        }
        private void textBox16_Enter(object sender, EventArgs e)
        {
            if (textBox16.Text == "Medical_card")
            {
                textBox16.Text = null;
                textBox16.ForeColor = Color.Black;
            }
        }
        private void textBox17_Enter(object sender, EventArgs e)
        {
            if (textBox17.Text == "ID_empl")
            {
                textBox17.Text = null;
                textBox17.ForeColor = Color.Black;
            }
        }
        private void textBox15_Leave(object sender, EventArgs e)
        {
            if (textBox15.Text == "")
            {
                textBox15.ForeColor = Color.Gray;
                textBox15.Text = "Med_exam_date";
            }
        }
        private void textBox16_Leave(object sender, EventArgs e)
        {
            if (textBox16.Text == "")
            {
                textBox16.ForeColor = Color.Gray;
                textBox16.Text = "Medical_card";
            }
        }
        private void textBox17_Leave(object sender, EventArgs e)
        {
            if (textBox17.Text == "")
            {
                textBox17.ForeColor = Color.Gray;
                textBox17.Text = "ID_empl";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox15.Text != "Med_exam_date" && textBox16.Text != "Medical_card" && textBox17.Text != "ID_empl")
                {
                    SqlCommand command = new SqlCommand("INSERT INTO [Health status] (Medical_examination_date, had_HIV, had_COVID, has_heart_disease, Medical_card, ID_empl) VALUES (@Medical_examination_date, @had_HIV, @had_COVID, @has_heart_disease, @Medical_card, @ID_empl)", sqlConnection);

                    command.Parameters.AddWithValue("Medical_examination_date", textBox15.Text);
                    command.Parameters.AddWithValue("Medical_card", textBox16.Text);
                    command.Parameters.AddWithValue("ID_empl", textBox17.Text);
                    command.Parameters.AddWithValue("had_HIV", checkBox1.Checked);
                    command.Parameters.AddWithValue("had_COVID", checkBox2.Checked);
                    command.Parameters.AddWithValue("has_heart_disease", checkBox3.Checked);

                    MessageBox.Show("Успешно сохранена " + command.ExecuteNonQuery().ToString() + " запись в базу данных!");

                    textBox15.Visible = false;
                    textBox16.Visible = false;
                    textBox17.Visible = false;
                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    checkBox3.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;

                    textBox15.ForeColor = Color.Gray;
                    textBox15.Text = "Med_exam_date";
                    textBox16.ForeColor = Color.Gray;
                    textBox16.Text = "Medical_card";
                    textBox17.ForeColor = Color.Gray;
                    textBox17.Text = "ID_empl";
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                }
                else
                    MessageBox.Show("Ввод данных некорректен!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ввод данных некорректен!");
            }
        }
    }
}
