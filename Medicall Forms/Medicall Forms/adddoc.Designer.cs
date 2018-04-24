namespace Medicall_Forms
{
    partial class adddoc
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
            this.label11 = new System.Windows.Forms.Label();
            this.Dnametxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.feetxt = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.daytxt = new System.Windows.Forms.ComboBox();
            this.timingstxt = new System.Windows.Forms.ComboBox();
            this.locationtxt = new System.Windows.Forms.ComboBox();
            this.specialtxt = new System.Windows.Forms.ComboBox();
            this.Pregbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(44, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 23);
            this.label11.TabIndex = 114;
            this.label11.Text = "User-Name";
            // 
            // Dnametxt
            // 
            this.Dnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dnametxt.Location = new System.Drawing.Point(45, 66);
            this.Dnametxt.Name = "Dnametxt";
            this.Dnametxt.Size = new System.Drawing.Size(149, 26);
            this.Dnametxt.TabIndex = 113;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(270, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 23);
            this.label12.TabIndex = 112;
            this.label12.Text = "Contact No    📱\r\n";
            // 
            // feetxt
            // 
            this.feetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feetxt.FormattingEnabled = true;
            this.feetxt.Items.AddRange(new object[] {
            "1500",
            "2000",
            "3000",
            "3500",
            "4000"});
            this.feetxt.Location = new System.Drawing.Point(48, 312);
            this.feetxt.Name = "feetxt";
            this.feetxt.Size = new System.Drawing.Size(189, 24);
            this.feetxt.TabIndex = 111;
            this.feetxt.Text = "-Select Range";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(44, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 23);
            this.label10.TabIndex = 110;
            this.label10.Text = "Fee  💵";
            // 
            // phonetxt
            // 
            this.phonetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetxt.Location = new System.Drawing.Point(274, 68);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(189, 22);
            this.phonetxt.TabIndex = 109;
            // 
            // daytxt
            // 
            this.daytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daytxt.FormattingEnabled = true;
            this.daytxt.Items.AddRange(new object[] {
            "Moday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.daytxt.Location = new System.Drawing.Point(48, 150);
            this.daytxt.Name = "daytxt";
            this.daytxt.Size = new System.Drawing.Size(189, 24);
            this.daytxt.TabIndex = 108;
            this.daytxt.Text = "-Select a Day";
            // 
            // timingstxt
            // 
            this.timingstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timingstxt.FormattingEnabled = true;
            this.timingstxt.Items.AddRange(new object[] {
            "9 :00 am - 1: 00 pm",
            "2: 00 pm - 5:00 pm",
            "5: 00 pm - 8:00 pm"});
            this.timingstxt.Location = new System.Drawing.Point(48, 227);
            this.timingstxt.Name = "timingstxt";
            this.timingstxt.Size = new System.Drawing.Size(189, 24);
            this.timingstxt.TabIndex = 107;
            this.timingstxt.Text = "-Select Timings";
            // 
            // locationtxt
            // 
            this.locationtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationtxt.FormattingEnabled = true;
            this.locationtxt.Items.AddRange(new object[] {
            "JOHAR     TOWN",
            "GARDEN  TOWN",
            "MODEL    TOWN",
            "PIA           SOCIETY ",
            "DHA "});
            this.locationtxt.Location = new System.Drawing.Point(274, 227);
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.Size = new System.Drawing.Size(189, 24);
            this.locationtxt.TabIndex = 106;
            this.locationtxt.Text = "-Select a Place";
            // 
            // specialtxt
            // 
            this.specialtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialtxt.FormattingEnabled = true;
            this.specialtxt.Items.AddRange(new object[] {
            "CARDIC \t        Surgeon",
            "ENT                   Specialist",
            "ORTHOPADIC  Surgeon ",
            "CHILD               Specialist",
            "GENERAL         Physician ",
            ""});
            this.specialtxt.Location = new System.Drawing.Point(274, 148);
            this.specialtxt.Name = "specialtxt";
            this.specialtxt.Size = new System.Drawing.Size(189, 24);
            this.specialtxt.TabIndex = 105;
            this.specialtxt.Text = "-Select your specialization";
            // 
            // Pregbtn
            // 
            this.Pregbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.Pregbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pregbtn.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pregbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Pregbtn.Location = new System.Drawing.Point(416, 343);
            this.Pregbtn.Name = "Pregbtn";
            this.Pregbtn.Size = new System.Drawing.Size(120, 43);
            this.Pregbtn.TabIndex = 104;
            this.Pregbtn.Text = "Added";
            this.Pregbtn.UseVisualStyleBackColor = false;
            this.Pregbtn.Click += new System.EventHandler(this.Pregbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(270, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 23);
            this.label8.TabIndex = 103;
            this.label8.Text = "Location  🏠";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(44, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 102;
            this.label3.Text = "Timings  🕐";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(44, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 101;
            this.label7.Text = "Day  🎴";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(270, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 23);
            this.label5.TabIndex = 100;
            this.label5.Text = "Specialization  💉";
            // 
            // adddoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 419);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Dnametxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.feetxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.daytxt);
            this.Controls.Add(this.timingstxt);
            this.Controls.Add(this.locationtxt);
            this.Controls.Add(this.specialtxt);
            this.Controls.Add(this.Pregbtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Name = "adddoc";
            this.Text = "adddoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Dnametxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox feetxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.ComboBox daytxt;
        private System.Windows.Forms.ComboBox timingstxt;
        private System.Windows.Forms.ComboBox locationtxt;
        private System.Windows.Forms.ComboBox specialtxt;
        private System.Windows.Forms.Button Pregbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}