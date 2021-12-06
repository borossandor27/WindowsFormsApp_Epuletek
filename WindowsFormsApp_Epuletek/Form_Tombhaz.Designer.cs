
namespace WindowsFormsApp_Epuletek
{
    partial class Form_Tombhaz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker_Befejezes = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Kezdes = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Epitesianyag = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Alapterulet = new System.Windows.Forms.NumericUpDown();
            this.textBox_Cim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_LakasokSzama = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_FenntartasTipusa = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Alapterulet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LakasokSzama)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_Befejezes
            // 
            this.dateTimePicker_Befejezes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Befejezes.Location = new System.Drawing.Point(171, 183);
            this.dateTimePicker_Befejezes.Name = "dateTimePicker_Befejezes";
            this.dateTimePicker_Befejezes.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_Befejezes.TabIndex = 23;
            // 
            // dateTimePicker_Kezdes
            // 
            this.dateTimePicker_Kezdes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Kezdes.Location = new System.Drawing.Point(171, 143);
            this.dateTimePicker_Kezdes.Name = "dateTimePicker_Kezdes";
            this.dateTimePicker_Kezdes.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_Kezdes.TabIndex = 24;
            // 
            // comboBox_Epitesianyag
            // 
            this.comboBox_Epitesianyag.FormattingEnabled = true;
            this.comboBox_Epitesianyag.Location = new System.Drawing.Point(171, 100);
            this.comboBox_Epitesianyag.Name = "comboBox_Epitesianyag";
            this.comboBox_Epitesianyag.Size = new System.Drawing.Size(212, 21);
            this.comboBox_Epitesianyag.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "nm";
            // 
            // numericUpDown_Alapterulet
            // 
            this.numericUpDown_Alapterulet.Location = new System.Drawing.Point(171, 60);
            this.numericUpDown_Alapterulet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Alapterulet.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_Alapterulet.Name = "numericUpDown_Alapterulet";
            this.numericUpDown_Alapterulet.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Alapterulet.TabIndex = 20;
            this.numericUpDown_Alapterulet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Alapterulet.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // textBox_Cim
            // 
            this.textBox_Cim.Location = new System.Drawing.Point(171, 20);
            this.textBox_Cim.Name = "textBox_Cim";
            this.textBox_Cim.Size = new System.Drawing.Size(212, 20);
            this.textBox_Cim.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Alapterület";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Építésianyag";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Munkavégzés kezdete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Munkavégzés vége";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cím";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Lakások száma";
            // 
            // numericUpDown_LakasokSzama
            // 
            this.numericUpDown_LakasokSzama.Location = new System.Drawing.Point(171, 229);
            this.numericUpDown_LakasokSzama.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_LakasokSzama.Name = "numericUpDown_LakasokSzama";
            this.numericUpDown_LakasokSzama.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_LakasokSzama.TabIndex = 26;
            this.numericUpDown_LakasokSzama.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_LakasokSzama.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fenntartás típusa";
            // 
            // comboBox_FenntartasTipusa
            // 
            this.comboBox_FenntartasTipusa.FormattingEnabled = true;
            this.comboBox_FenntartasTipusa.Location = new System.Drawing.Point(171, 279);
            this.comboBox_FenntartasTipusa.Name = "comboBox_FenntartasTipusa";
            this.comboBox_FenntartasTipusa.Size = new System.Drawing.Size(212, 21);
            this.comboBox_FenntartasTipusa.TabIndex = 22;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(146, 331);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Van Lift";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 31);
            this.button1.TabIndex = 29;
            this.button1.Text = "Rögzítés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Tombhaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_LakasokSzama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_Befejezes);
            this.Controls.Add(this.dateTimePicker_Kezdes);
            this.Controls.Add(this.comboBox_FenntartasTipusa);
            this.Controls.Add(this.comboBox_Epitesianyag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_Alapterulet);
            this.Controls.Add(this.textBox_Cim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form_Tombhaz";
            this.Text = "Form_Tombhaz";
            this.Load += new System.EventHandler(this.Form_Tombhaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Alapterulet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LakasokSzama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_Befejezes;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Kezdes;
        private System.Windows.Forms.ComboBox comboBox_Epitesianyag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Alapterulet;
        private System.Windows.Forms.TextBox textBox_Cim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_LakasokSzama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_FenntartasTipusa;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}