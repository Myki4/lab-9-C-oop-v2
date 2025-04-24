using System;
using System.Windows.Forms;

namespace lab_9_C__oop_v2
{
    public partial class Form1 : Form
    {
        private DateTime currentDate; 

        public Form1()
        {
            InitializeComponent();
            currentDate = DateTime.Now.Date; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCurrentDate.Text = $"Поточна дата: {currentDate.ToString("dd/MM/yyyy")}";
        }

        private void UpdateCurrentDateLabel()
        {
            lblCurrentDate.Text = $"Поточна дата: {currentDate.ToString("dd/MM/yyyy")}";
        }

        private void btnSetDate_Click(object sender, EventArgs e)
        {
            try
            {
                int day = int.Parse(txtDay.Text);
                int month = int.Parse(txtMonth.Text);
                int year = int.Parse(txtYear.Text);

                currentDate = new DateTime(year, month, day);

                UpdateCurrentDateLabel();

                lblResult.Text = $"Дата успішно змінена на: {currentDate.ToString("dd/MM/yyyy")}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Недопустима дата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}