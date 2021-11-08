
namespace DapperUi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fNametxtBox = new System.Windows.Forms.TextBox();
            this.fatherNametxtBox = new System.Windows.Forms.TextBox();
            this.motherNametxtBox = new System.Windows.Forms.TextBox();
            this.lNametxtBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButoon = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.markNumeric = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Father Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mother Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mark";
            // 
            // fNametxtBox
            // 
            this.fNametxtBox.Location = new System.Drawing.Point(121, 19);
            this.fNametxtBox.Name = "fNametxtBox";
            this.fNametxtBox.Size = new System.Drawing.Size(100, 23);
            this.fNametxtBox.TabIndex = 1;
            this.fNametxtBox.TextChanged += new System.EventHandler(this.fNametxtBox_TextChanged);
            // 
            // fatherNametxtBox
            // 
            this.fatherNametxtBox.Location = new System.Drawing.Point(310, 19);
            this.fatherNametxtBox.Name = "fatherNametxtBox";
            this.fatherNametxtBox.Size = new System.Drawing.Size(100, 23);
            this.fatherNametxtBox.TabIndex = 2;
            this.fatherNametxtBox.TextChanged += new System.EventHandler(this.fatherNametxtBox_TextChanged);
            // 
            // motherNametxtBox
            // 
            this.motherNametxtBox.Location = new System.Drawing.Point(121, 62);
            this.motherNametxtBox.Name = "motherNametxtBox";
            this.motherNametxtBox.Size = new System.Drawing.Size(100, 23);
            this.motherNametxtBox.TabIndex = 4;
            this.motherNametxtBox.TextChanged += new System.EventHandler(this.motherNametxtBox_TextChanged);
            // 
            // lNametxtBox
            // 
            this.lNametxtBox.Location = new System.Drawing.Point(502, 22);
            this.lNametxtBox.Name = "lNametxtBox";
            this.lNametxtBox.Size = new System.Drawing.Size(100, 23);
            this.lNametxtBox.TabIndex = 3;
            this.lNametxtBox.TextChanged += new System.EventHandler(this.lNametxtBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(586, 157);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(430, 62);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButoon
            // 
            this.deleteButoon.Location = new System.Drawing.Point(520, 62);
            this.deleteButoon.Name = "deleteButoon";
            this.deleteButoon.Size = new System.Drawing.Size(75, 23);
            this.deleteButoon.TabIndex = 12;
            this.deleteButoon.Text = "Delete";
            this.deleteButoon.UseVisualStyleBackColor = true;
            this.deleteButoon.Click += new System.EventHandler(this.deleteButoon_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(511, 91);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(91, 23);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Create New";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // markNumeric
            // 
            this.markNumeric.Location = new System.Drawing.Point(310, 62);
            this.markNumeric.Name = "markNumeric";
            this.markNumeric.Size = new System.Drawing.Size(100, 23);
            this.markNumeric.TabIndex = 5;
            this.markNumeric.TextChanged += new System.EventHandler(this.markNumeric_TextChanged);
            this.markNumeric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.markTextBox_KeyPress);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(144, 104);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(0, 15);
            this.IdLabel.TabIndex = 15;
            this.IdLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 320);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.markNumeric);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.deleteButoon);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lNametxtBox);
            this.Controls.Add(this.motherNametxtBox);
            this.Controls.Add(this.fatherNametxtBox);
            this.Controls.Add(this.fNametxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fNametxtBox;
        private System.Windows.Forms.TextBox fatherNametxtBox;
        private System.Windows.Forms.TextBox motherNametxtBox;
        private System.Windows.Forms.TextBox lNametxtBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButoon;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox markNumeric;
        private System.Windows.Forms.Label IdLabel;
    }
}

