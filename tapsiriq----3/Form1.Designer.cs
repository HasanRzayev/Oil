namespace tapsiriq____3
{
    partial class Form1
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
            this.combo_benzinler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_litr = new System.Windows.Forms.RadioButton();
            this.radioButton_manat = new System.Windows.Forms.RadioButton();
            this.textBox_litr = new System.Windows.Forms.TextBox();
            this.textBox_manat = new System.Windows.Forms.TextBox();
            this.label_umumibenzinqiymeti = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_qiymet = new System.Windows.Forms.TextBox();
            this.checkBox_sendvic = new System.Windows.Forms.CheckBox();
            this.checkBox_hamburger = new System.Windows.Forms.CheckBox();
            this.checkBox_pizza = new System.Windows.Forms.CheckBox();
            this.checkBox_kola = new System.Windows.Forms.CheckBox();
            this.textBox_sendvic = new System.Windows.Forms.TextBox();
            this.textBox_hamburger = new System.Windows.Forms.TextBox();
            this.textBox_pizza = new System.Windows.Forms.TextBox();
            this.textBox_kola = new System.Windows.Forms.TextBox();
            this.textBox_sendvic2 = new System.Windows.Forms.TextBox();
            this.textBox_hamburger2 = new System.Windows.Forms.TextBox();
            this.textBox_pizza2 = new System.Windows.Forms.TextBox();
            this.textBox_kola2 = new System.Windows.Forms.TextBox();
            this.textBox_fanta2 = new System.Windows.Forms.TextBox();
            this.textBox_fanta = new System.Windows.Forms.TextBox();
            this.checkBox_fanta = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_kafe = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.umumi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo_benzinler
            // 
            this.combo_benzinler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_benzinler.FormattingEnabled = true;
            this.combo_benzinler.Items.AddRange(new object[] {
            "Super",
            "Dizel",
            "Premium",
            "A-92",
            "A-95"});
            this.combo_benzinler.Location = new System.Drawing.Point(189, 81);
            this.combo_benzinler.Name = "combo_benzinler";
            this.combo_benzinler.Size = new System.Drawing.Size(121, 39);
            this.combo_benzinler.TabIndex = 0;
            this.combo_benzinler.SelectedIndexChanged += new System.EventHandler(this.combo_benzinler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "benzin novu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "benzin  qiymeti";
            // 
            // radioButton_litr
            // 
            this.radioButton_litr.AutoSize = true;
            this.radioButton_litr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_litr.Location = new System.Drawing.Point(17, 231);
            this.radioButton_litr.Name = "radioButton_litr";
            this.radioButton_litr.Size = new System.Drawing.Size(70, 35);
            this.radioButton_litr.TabIndex = 4;
            this.radioButton_litr.TabStop = true;
            this.radioButton_litr.Text = "Litr";
            this.radioButton_litr.UseVisualStyleBackColor = true;
            this.radioButton_litr.CheckedChanged += new System.EventHandler(this.radioButton_litr_CheckedChanged);
            // 
            // radioButton_manat
            // 
            this.radioButton_manat.AutoSize = true;
            this.radioButton_manat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_manat.Location = new System.Drawing.Point(17, 286);
            this.radioButton_manat.Name = "radioButton_manat";
            this.radioButton_manat.Size = new System.Drawing.Size(107, 35);
            this.radioButton_manat.TabIndex = 5;
            this.radioButton_manat.TabStop = true;
            this.radioButton_manat.Text = "Manat";
            this.radioButton_manat.UseVisualStyleBackColor = true;
            this.radioButton_manat.CheckedChanged += new System.EventHandler(this.radioButton_manat_CheckedChanged);
            // 
            // textBox_litr
            // 
            this.textBox_litr.Enabled = false;
            this.textBox_litr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_litr.Location = new System.Drawing.Point(158, 231);
            this.textBox_litr.Name = "textBox_litr";
            this.textBox_litr.Size = new System.Drawing.Size(100, 35);
            this.textBox_litr.TabIndex = 6;
            this.textBox_litr.TextChanged += new System.EventHandler(this.textBox_litr_TextChanged);
            // 
            // textBox_manat
            // 
            this.textBox_manat.Enabled = false;
            this.textBox_manat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_manat.Location = new System.Drawing.Point(158, 286);
            this.textBox_manat.Name = "textBox_manat";
            this.textBox_manat.Size = new System.Drawing.Size(100, 35);
            this.textBox_manat.TabIndex = 7;
            this.textBox_manat.TextChanged += new System.EventHandler(this.textBox_manat_TextChanged);
            // 
            // label_umumibenzinqiymeti
            // 
            this.label_umumibenzinqiymeti.AutoSize = true;
            this.label_umumibenzinqiymeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_umumibenzinqiymeti.Location = new System.Drawing.Point(76, 426);
            this.label_umumibenzinqiymeti.Name = "label_umumibenzinqiymeti";
            this.label_umumibenzinqiymeti.Size = new System.Drawing.Size(98, 108);
            this.label_umumibenzinqiymeti.TabIndex = 8;
            this.label_umumibenzinqiymeti.Text = "0";
            this.label_umumibenzinqiymeti.TextChanged += new System.EventHandler(this.label_umumibenzinqiymeti_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Alinan benzinin qiymeti";
            // 
            // textBox_qiymet
            // 
            this.textBox_qiymet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_qiymet.Location = new System.Drawing.Point(191, 152);
            this.textBox_qiymet.Name = "textBox_qiymet";
            this.textBox_qiymet.ReadOnly = true;
            this.textBox_qiymet.Size = new System.Drawing.Size(119, 35);
            this.textBox_qiymet.TabIndex = 10;
            // 
            // checkBox_sendvic
            // 
            this.checkBox_sendvic.AutoSize = true;
            this.checkBox_sendvic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_sendvic.Location = new System.Drawing.Point(410, 87);
            this.checkBox_sendvic.Name = "checkBox_sendvic";
            this.checkBox_sendvic.Size = new System.Drawing.Size(126, 35);
            this.checkBox_sendvic.TabIndex = 11;
            this.checkBox_sendvic.Text = "sendvic";
            this.checkBox_sendvic.UseVisualStyleBackColor = true;
            this.checkBox_sendvic.CheckedChanged += new System.EventHandler(this.checkBox_sendvic_CheckedChanged);
            // 
            // checkBox_hamburger
            // 
            this.checkBox_hamburger.AutoSize = true;
            this.checkBox_hamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_hamburger.Location = new System.Drawing.Point(410, 149);
            this.checkBox_hamburger.Name = "checkBox_hamburger";
            this.checkBox_hamburger.Size = new System.Drawing.Size(163, 35);
            this.checkBox_hamburger.TabIndex = 12;
            this.checkBox_hamburger.Text = "hamburger";
            this.checkBox_hamburger.UseVisualStyleBackColor = true;
            this.checkBox_hamburger.CheckedChanged += new System.EventHandler(this.checkBox_hamburger_CheckedChanged);
            // 
            // checkBox_pizza
            // 
            this.checkBox_pizza.AutoSize = true;
            this.checkBox_pizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_pizza.Location = new System.Drawing.Point(410, 205);
            this.checkBox_pizza.Name = "checkBox_pizza";
            this.checkBox_pizza.Size = new System.Drawing.Size(97, 35);
            this.checkBox_pizza.TabIndex = 13;
            this.checkBox_pizza.Text = "pizza";
            this.checkBox_pizza.UseVisualStyleBackColor = true;
            this.checkBox_pizza.CheckedChanged += new System.EventHandler(this.checkBox_pizza_CheckedChanged);
            // 
            // checkBox_kola
            // 
            this.checkBox_kola.AutoSize = true;
            this.checkBox_kola.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_kola.Location = new System.Drawing.Point(410, 257);
            this.checkBox_kola.Name = "checkBox_kola";
            this.checkBox_kola.Size = new System.Drawing.Size(150, 35);
            this.checkBox_kola.TabIndex = 14;
            this.checkBox_kola.Text = "koka-kola";
            this.checkBox_kola.UseVisualStyleBackColor = true;
            this.checkBox_kola.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // textBox_sendvic
            // 
            this.textBox_sendvic.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_sendvic.Location = new System.Drawing.Point(593, 87);
            this.textBox_sendvic.Name = "textBox_sendvic";
            this.textBox_sendvic.Size = new System.Drawing.Size(119, 40);
            this.textBox_sendvic.TabIndex = 15;
            this.textBox_sendvic.Text = "5.00";
            // 
            // textBox_hamburger
            // 
            this.textBox_hamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_hamburger.Location = new System.Drawing.Point(593, 149);
            this.textBox_hamburger.Name = "textBox_hamburger";
            this.textBox_hamburger.Size = new System.Drawing.Size(119, 40);
            this.textBox_hamburger.TabIndex = 16;
            this.textBox_hamburger.Text = "6.00";
            // 
            // textBox_pizza
            // 
            this.textBox_pizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_pizza.Location = new System.Drawing.Point(593, 205);
            this.textBox_pizza.Name = "textBox_pizza";
            this.textBox_pizza.Size = new System.Drawing.Size(119, 40);
            this.textBox_pizza.TabIndex = 17;
            this.textBox_pizza.Text = "8.00";
            // 
            // textBox_kola
            // 
            this.textBox_kola.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_kola.Location = new System.Drawing.Point(593, 257);
            this.textBox_kola.Name = "textBox_kola";
            this.textBox_kola.Size = new System.Drawing.Size(119, 40);
            this.textBox_kola.TabIndex = 18;
            this.textBox_kola.Text = "2.00";
            // 
            // textBox_sendvic2
            // 
            this.textBox_sendvic2.Enabled = false;
            this.textBox_sendvic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_sendvic2.Location = new System.Drawing.Point(741, 87);
            this.textBox_sendvic2.Name = "textBox_sendvic2";
            this.textBox_sendvic2.Size = new System.Drawing.Size(114, 40);
            this.textBox_sendvic2.TabIndex = 19;
            this.textBox_sendvic2.TextChanged += new System.EventHandler(this.textBox_sendvic2_TextChanged);
            // 
            // textBox_hamburger2
            // 
            this.textBox_hamburger2.Enabled = false;
            this.textBox_hamburger2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_hamburger2.Location = new System.Drawing.Point(741, 149);
            this.textBox_hamburger2.Name = "textBox_hamburger2";
            this.textBox_hamburger2.Size = new System.Drawing.Size(114, 40);
            this.textBox_hamburger2.TabIndex = 20;
            this.textBox_hamburger2.TextChanged += new System.EventHandler(this.textBox_hamburger2_TextChanged);
            // 
            // textBox_pizza2
            // 
            this.textBox_pizza2.Enabled = false;
            this.textBox_pizza2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_pizza2.Location = new System.Drawing.Point(741, 206);
            this.textBox_pizza2.Name = "textBox_pizza2";
            this.textBox_pizza2.Size = new System.Drawing.Size(114, 40);
            this.textBox_pizza2.TabIndex = 21;
            this.textBox_pizza2.TextChanged += new System.EventHandler(this.textBox_pizza2_TextChanged);
            // 
            // textBox_kola2
            // 
            this.textBox_kola2.Enabled = false;
            this.textBox_kola2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_kola2.Location = new System.Drawing.Point(741, 258);
            this.textBox_kola2.Name = "textBox_kola2";
            this.textBox_kola2.Size = new System.Drawing.Size(114, 40);
            this.textBox_kola2.TabIndex = 22;
            this.textBox_kola2.TextChanged += new System.EventHandler(this.textBox_kola2_TextChanged);
            // 
            // textBox_fanta2
            // 
            this.textBox_fanta2.Enabled = false;
            this.textBox_fanta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_fanta2.Location = new System.Drawing.Point(741, 310);
            this.textBox_fanta2.Name = "textBox_fanta2";
            this.textBox_fanta2.Size = new System.Drawing.Size(114, 40);
            this.textBox_fanta2.TabIndex = 25;
            this.textBox_fanta2.TextChanged += new System.EventHandler(this.textBox_fanta2_TextChanged);
            // 
            // textBox_fanta
            // 
            this.textBox_fanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_fanta.Location = new System.Drawing.Point(593, 309);
            this.textBox_fanta.Name = "textBox_fanta";
            this.textBox_fanta.Size = new System.Drawing.Size(119, 40);
            this.textBox_fanta.TabIndex = 24;
            this.textBox_fanta.Text = "3.00";
            // 
            // checkBox_fanta
            // 
            this.checkBox_fanta.AutoSize = true;
            this.checkBox_fanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_fanta.Location = new System.Drawing.Point(410, 309);
            this.checkBox_fanta.Name = "checkBox_fanta";
            this.checkBox_fanta.Size = new System.Drawing.Size(94, 35);
            this.checkBox_fanta.TabIndex = 23;
            this.checkBox_fanta.Text = "fanta";
            this.checkBox_fanta.UseVisualStyleBackColor = true;
            this.checkBox_fanta.CheckedChanged += new System.EventHandler(this.checkBox_fanta_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(405, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Alinanlarin qiymeti";
            // 
            // label_kafe
            // 
            this.label_kafe.AutoSize = true;
            this.label_kafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_kafe.Location = new System.Drawing.Point(475, 426);
            this.label_kafe.Name = "label_kafe";
            this.label_kafe.Size = new System.Drawing.Size(98, 108);
            this.label_kafe.TabIndex = 26;
            this.label_kafe.Text = "0";
            this.label_kafe.TextChanged += new System.EventHandler(this.label_kafe_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(48, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 154);
            this.button1.TabIndex = 28;
            this.button1.Text = "Al";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // umumi
            // 
            this.umumi.AutoSize = true;
            this.umumi.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.umumi.Location = new System.Drawing.Point(475, 593);
            this.umumi.Name = "umumi";
            this.umumi.Size = new System.Drawing.Size(98, 108);
            this.umumi.TabIndex = 29;
            this.umumi.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Yanacaq doldurma";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(405, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "Mini- Market";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(880, 777);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.umumi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_kafe);
            this.Controls.Add(this.textBox_fanta2);
            this.Controls.Add(this.textBox_fanta);
            this.Controls.Add(this.checkBox_fanta);
            this.Controls.Add(this.textBox_kola2);
            this.Controls.Add(this.textBox_pizza2);
            this.Controls.Add(this.textBox_hamburger2);
            this.Controls.Add(this.textBox_sendvic2);
            this.Controls.Add(this.textBox_kola);
            this.Controls.Add(this.textBox_pizza);
            this.Controls.Add(this.textBox_hamburger);
            this.Controls.Add(this.textBox_sendvic);
            this.Controls.Add(this.checkBox_kola);
            this.Controls.Add(this.checkBox_pizza);
            this.Controls.Add(this.checkBox_hamburger);
            this.Controls.Add(this.checkBox_sendvic);
            this.Controls.Add(this.textBox_qiymet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_umumibenzinqiymeti);
            this.Controls.Add(this.textBox_manat);
            this.Controls.Add(this.textBox_litr);
            this.Controls.Add(this.radioButton_manat);
            this.Controls.Add(this.radioButton_litr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_benzinler);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_benzinler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_litr;
        private System.Windows.Forms.RadioButton radioButton_manat;
        private System.Windows.Forms.TextBox textBox_litr;
        private System.Windows.Forms.TextBox textBox_manat;
        private System.Windows.Forms.Label label_umumibenzinqiymeti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_qiymet;
        private System.Windows.Forms.CheckBox checkBox_sendvic;
        private System.Windows.Forms.CheckBox checkBox_hamburger;
        private System.Windows.Forms.CheckBox checkBox_pizza;
        private System.Windows.Forms.CheckBox checkBox_kola;
        private System.Windows.Forms.TextBox textBox_sendvic;
        private System.Windows.Forms.TextBox textBox_hamburger;
        private System.Windows.Forms.TextBox textBox_pizza;
        private System.Windows.Forms.TextBox textBox_kola;
        private System.Windows.Forms.TextBox textBox_sendvic2;
        private System.Windows.Forms.TextBox textBox_hamburger2;
        private System.Windows.Forms.TextBox textBox_pizza2;
        private System.Windows.Forms.TextBox textBox_kola2;
        private System.Windows.Forms.TextBox textBox_fanta2;
        private System.Windows.Forms.TextBox textBox_fanta;
        private System.Windows.Forms.CheckBox checkBox_fanta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_kafe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label umumi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

