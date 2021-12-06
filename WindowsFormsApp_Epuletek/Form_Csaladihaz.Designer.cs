
namespace WindowsFormsApp_Epuletek
{
    partial class Form_Csaladihaz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_Garazs = new System.Windows.Forms.CheckBox();
            this.textBox_Cim = new System.Windows.Forms.TextBox();
            this.numericUpDown_Alapterulet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Epitesianyag = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Kezdes = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Befejezes = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_OttElok = new System.Windows.Forms.NumericUpDown();
            this.comboBox_TetoTipusa = new System.Windows.Forms.ComboBox();
            this.button_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Alapterulet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_OttElok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cím";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tető tipusa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ottélők száma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Munkavégzés vége";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Munkavégzés kezdete";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Építésianyag";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Alapterület";
            // 
            // checkBox_Garazs
            // 
            this.checkBox_Garazs.AutoSize = true;
            this.checkBox_Garazs.Location = new System.Drawing.Point(60, 306);
            this.checkBox_Garazs.Name = "checkBox_Garazs";
            this.checkBox_Garazs.Size = new System.Drawing.Size(78, 17);
            this.checkBox_Garazs.TabIndex = 8;
            this.checkBox_Garazs.Text = "van garázs";
            this.checkBox_Garazs.UseVisualStyleBackColor = true;
            // 
            // textBox_Cim
            // 
            this.textBox_Cim.Location = new System.Drawing.Point(165, 24);
            this.textBox_Cim.Name = "textBox_Cim";
            this.textBox_Cim.Size = new System.Drawing.Size(212, 20);
            this.textBox_Cim.TabIndex = 9;
            // 
            // numericUpDown_Alapterulet
            // 
            this.numericUpDown_Alapterulet.Location = new System.Drawing.Point(165, 64);
            this.numericUpDown_Alapterulet.Maximum = new decimal(new int[] {
            12000,
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
            this.numericUpDown_Alapterulet.TabIndex = 10;
            this.numericUpDown_Alapterulet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Alapterulet.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "nm";
            // 
            // comboBox_Epitesianyag
            // 
            this.comboBox_Epitesianyag.FormattingEnabled = true;
            this.comboBox_Epitesianyag.Location = new System.Drawing.Point(165, 104);
            this.comboBox_Epitesianyag.Name = "comboBox_Epitesianyag";
            this.comboBox_Epitesianyag.Size = new System.Drawing.Size(212, 21);
            this.comboBox_Epitesianyag.TabIndex = 12;
            // 
            // dateTimePicker_Kezdes
            // 
            this.dateTimePicker_Kezdes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Kezdes.Location = new System.Drawing.Point(165, 147);
            this.dateTimePicker_Kezdes.Name = "dateTimePicker_Kezdes";
            this.dateTimePicker_Kezdes.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Kezdes.TabIndex = 13;
            // 
            // dateTimePicker_Befejezes
            // 
            this.dateTimePicker_Befejezes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Befejezes.Location = new System.Drawing.Point(165, 187);
            this.dateTimePicker_Befejezes.Name = "dateTimePicker_Befejezes";
            this.dateTimePicker_Befejezes.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Befejezes.TabIndex = 13;
            // 
            // numericUpDown_OttElok
            // 
            this.numericUpDown_OttElok.Location = new System.Drawing.Point(165, 227);
            this.numericUpDown_OttElok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_OttElok.Name = "numericUpDown_OttElok";
            this.numericUpDown_OttElok.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_OttElok.TabIndex = 14;
            this.numericUpDown_OttElok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_OttElok.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_TetoTipusa
            // 
            this.comboBox_TetoTipusa.FormattingEnabled = true;
            this.comboBox_TetoTipusa.Location = new System.Drawing.Point(165, 264);
            this.comboBox_TetoTipusa.Name = "comboBox_TetoTipusa";
            this.comboBox_TetoTipusa.Size = new System.Drawing.Size(212, 21);
            this.comboBox_TetoTipusa.TabIndex = 12;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(26, 357);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(351, 44);
            this.button_Save.TabIndex = 15;
            this.button_Save.Text = "Rögzítés";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Form_Csaladihaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 417);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.numericUpDown_OttElok);
            this.Controls.Add(this.dateTimePicker_Befejezes);
            this.Controls.Add(this.dateTimePicker_Kezdes);
            this.Controls.Add(this.comboBox_TetoTipusa);
            this.Controls.Add(this.comboBox_Epitesianyag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_Alapterulet);
            this.Controls.Add(this.textBox_Cim);
            this.Controls.Add(this.checkBox_Garazs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form_Csaladihaz";
            this.Text = "Form_Csaladihaz";
            this.Load += new System.EventHandler(this.Form_Csaladihaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Alapterulet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_OttElok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_Garazs;
        private System.Windows.Forms.TextBox textBox_Cim;
        private System.Windows.Forms.NumericUpDown numericUpDown_Alapterulet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Epitesianyag;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Kezdes;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Befejezes;
        private System.Windows.Forms.NumericUpDown numericUpDown_OttElok;
        private System.Windows.Forms.ComboBox comboBox_TetoTipusa;
        private System.Windows.Forms.Button button_Save;
    }
}