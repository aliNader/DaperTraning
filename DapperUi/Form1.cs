using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DapperUi
{
    public partial class Form1 : Form
    {
        private Student _std;
        private StudentRepository _studentRepository;
        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            _std = new Student();
            _studentRepository = new StudentRepository();
        }
        

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (markNumeric.Text == string.Empty)
            {
                MessageBox.Show("Student Mark Should Not Be Empty");
            }
            if (IdLabel.Text != string.Empty)
                _std.Id = int.Parse(IdLabel.Text);
            _std.FirstName = fNametxtBox.Text;
            _std.LastName = lNametxtBox.Text;
            _std.FatherName = fatherNametxtBox.Text;
            _std.MotherName = motherNametxtBox.Text;
            _std.Mark = decimal.Parse(markNumeric.Text);

            if (_std.Id == 0)
                _studentRepository.Insert(_std);
            else
                _studentRepository.Update(_std);
            RefreshDateSource();
            

        }
        public void RefreshDateSource()
        {
            bs.DataSource = _studentRepository.Query();
            dataGridView1.DataSource = bs;
            dataGridView1.Columns["Id"].Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDateSource();
        }

        private void deleteButoon_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            _std.Id = id;
            _std.FirstName = fNametxtBox.Text;
            _std.LastName = lNametxtBox.Text;
            _std.FatherName = fatherNametxtBox.Text;
            _std.MotherName = motherNametxtBox.Text;
            _std.Mark = decimal.Parse(markNumeric.Text);
            _studentRepository.Delete(_std);
            RefreshDateSource();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            _std.Id = id;
            _std.FirstName = fNametxtBox.Text;
            _std.LastName = lNametxtBox.Text;
            _std.FatherName = fatherNametxtBox.Text;
            _std.MotherName = motherNametxtBox.Text;
            _std.Mark = decimal.Parse(markNumeric.Text);

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            IdLabel.Text = string.Empty;
            fNametxtBox.Text = string.Empty;
            lNametxtBox.Text = string.Empty;
            fatherNametxtBox.Text = string.Empty;
            motherNametxtBox.Text = string.Empty;
            markNumeric.Text = string.Empty;
            saveButton.Enabled = false;
            deleteButoon.Enabled = false;
            resetButton.Enabled = false;
        }

        private void updateButtons()
        {
            saveButton.Enabled = fNametxtBox.Text != string.Empty && lNametxtBox.Text != string.Empty && fatherNametxtBox.Text != string.Empty && motherNametxtBox.Text != string.Empty && markNumeric.Text != string.Empty;
        }

        private void fNametxtBox_TextChanged(object sender, EventArgs e)
        {
            updateButtons();
        }

        private void lNametxtBox_TextChanged(object sender, EventArgs e)
        {
            updateButtons();
        }

        private void fatherNametxtBox_TextChanged(object sender, EventArgs e)
        {
            updateButtons();
        }

        private void motherNametxtBox_TextChanged(object sender, EventArgs e)
        {
            updateButtons();
        }

        private void markTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void markNumeric_TextChanged(object sender, EventArgs e)
        {
            updateButtons();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                IdLabel.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                fNametxtBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                lNametxtBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                fatherNametxtBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                motherNametxtBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                markNumeric.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            saveButton.Enabled = true;
            deleteButoon.Enabled = true;
            resetButton.Enabled = true;
        }
    }
}
