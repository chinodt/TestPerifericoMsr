namespace TestMagneticBand
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdGetDeviceEnabled = new System.Windows.Forms.Button();
            this.cmdSetDeviceEnabled = new System.Windows.Forms.Button();
            this.cmdSetDataEventEnabled = new System.Windows.Forms.Button();
            this.cmdGetDataEventEnabled = new System.Windows.Forms.Button();
            this.cmdSetFreezeEvents = new System.Windows.Forms.Button();
            this.cmdGetFreezeEvents = new System.Windows.Forms.Button();
            this.cmdSetAutoDisable = new System.Windows.Forms.Button();
            this.cmdGetAutoDisable = new System.Windows.Forms.Button();
            this.cmdSetPowerNotify = new System.Windows.Forms.Button();
            this.cmdGetPowerNotify = new System.Windows.Forms.Button();
            this.cmdSetBinaryConversion = new System.Windows.Forms.Button();
            this.cmdGetBinaryConversion = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTrack1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrack2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrack3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrack4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCardType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExpiration = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTrack1Disc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTrack2Disc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCardTypeList = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCardPropList = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Common";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Claim";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(87, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Release";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdSetBinaryConversion);
            this.groupBox2.Controls.Add(this.cmdGetBinaryConversion);
            this.groupBox2.Controls.Add(this.cmdSetPowerNotify);
            this.groupBox2.Controls.Add(this.cmdGetPowerNotify);
            this.groupBox2.Controls.Add(this.cmdSetAutoDisable);
            this.groupBox2.Controls.Add(this.cmdGetAutoDisable);
            this.groupBox2.Controls.Add(this.cmdSetFreezeEvents);
            this.groupBox2.Controls.Add(this.cmdGetFreezeEvents);
            this.groupBox2.Controls.Add(this.cmdSetDataEventEnabled);
            this.groupBox2.Controls.Add(this.cmdGetDataEventEnabled);
            this.groupBox2.Controls.Add(this.cmdSetDeviceEnabled);
            this.groupBox2.Controls.Add(this.cmdGetDeviceEnabled);
            this.groupBox2.Location = new System.Drawing.Point(199, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Common R/W Properties";
            // 
            // cmdGetDeviceEnabled
            // 
            this.cmdGetDeviceEnabled.Location = new System.Drawing.Point(6, 19);
            this.cmdGetDeviceEnabled.Name = "cmdGetDeviceEnabled";
            this.cmdGetDeviceEnabled.Size = new System.Drawing.Size(128, 23);
            this.cmdGetDeviceEnabled.TabIndex = 1;
            this.cmdGetDeviceEnabled.Text = "GetDeviceEnabled";
            this.cmdGetDeviceEnabled.UseVisualStyleBackColor = true;
            // 
            // cmdSetDeviceEnabled
            // 
            this.cmdSetDeviceEnabled.Location = new System.Drawing.Point(140, 19);
            this.cmdSetDeviceEnabled.Name = "cmdSetDeviceEnabled";
            this.cmdSetDeviceEnabled.Size = new System.Drawing.Size(128, 23);
            this.cmdSetDeviceEnabled.TabIndex = 2;
            this.cmdSetDeviceEnabled.Text = "SetDeviceEnabled";
            this.cmdSetDeviceEnabled.UseVisualStyleBackColor = true;
            this.cmdSetDeviceEnabled.Click += new System.EventHandler(this.cmdSetDeviceEnabled_Click);
            // 
            // cmdSetDataEventEnabled
            // 
            this.cmdSetDataEventEnabled.Location = new System.Drawing.Point(140, 48);
            this.cmdSetDataEventEnabled.Name = "cmdSetDataEventEnabled";
            this.cmdSetDataEventEnabled.Size = new System.Drawing.Size(128, 23);
            this.cmdSetDataEventEnabled.TabIndex = 4;
            this.cmdSetDataEventEnabled.Text = "SetDataEventEnabled";
            this.cmdSetDataEventEnabled.UseVisualStyleBackColor = true;
            this.cmdSetDataEventEnabled.Click += new System.EventHandler(this.cmdSetDataEventEnabled_Click);
            // 
            // cmdGetDataEventEnabled
            // 
            this.cmdGetDataEventEnabled.Location = new System.Drawing.Point(6, 48);
            this.cmdGetDataEventEnabled.Name = "cmdGetDataEventEnabled";
            this.cmdGetDataEventEnabled.Size = new System.Drawing.Size(128, 23);
            this.cmdGetDataEventEnabled.TabIndex = 3;
            this.cmdGetDataEventEnabled.Text = "GetDataEventEnabled";
            this.cmdGetDataEventEnabled.UseVisualStyleBackColor = true;
            // 
            // cmdSetFreezeEvents
            // 
            this.cmdSetFreezeEvents.Location = new System.Drawing.Point(140, 77);
            this.cmdSetFreezeEvents.Name = "cmdSetFreezeEvents";
            this.cmdSetFreezeEvents.Size = new System.Drawing.Size(128, 23);
            this.cmdSetFreezeEvents.TabIndex = 6;
            this.cmdSetFreezeEvents.Text = "SetFreezeEvents";
            this.cmdSetFreezeEvents.UseVisualStyleBackColor = true;
            // 
            // cmdGetFreezeEvents
            // 
            this.cmdGetFreezeEvents.Location = new System.Drawing.Point(6, 77);
            this.cmdGetFreezeEvents.Name = "cmdGetFreezeEvents";
            this.cmdGetFreezeEvents.Size = new System.Drawing.Size(128, 23);
            this.cmdGetFreezeEvents.TabIndex = 5;
            this.cmdGetFreezeEvents.Text = "GetFreezeEvents";
            this.cmdGetFreezeEvents.UseVisualStyleBackColor = true;
            // 
            // cmdSetAutoDisable
            // 
            this.cmdSetAutoDisable.Location = new System.Drawing.Point(140, 106);
            this.cmdSetAutoDisable.Name = "cmdSetAutoDisable";
            this.cmdSetAutoDisable.Size = new System.Drawing.Size(128, 23);
            this.cmdSetAutoDisable.TabIndex = 8;
            this.cmdSetAutoDisable.Text = "SetAutoDisable";
            this.cmdSetAutoDisable.UseVisualStyleBackColor = true;
            // 
            // cmdGetAutoDisable
            // 
            this.cmdGetAutoDisable.Location = new System.Drawing.Point(6, 106);
            this.cmdGetAutoDisable.Name = "cmdGetAutoDisable";
            this.cmdGetAutoDisable.Size = new System.Drawing.Size(128, 23);
            this.cmdGetAutoDisable.TabIndex = 7;
            this.cmdGetAutoDisable.Text = "GetAutoDisable";
            this.cmdGetAutoDisable.UseVisualStyleBackColor = true;
            // 
            // cmdSetPowerNotify
            // 
            this.cmdSetPowerNotify.Location = new System.Drawing.Point(140, 135);
            this.cmdSetPowerNotify.Name = "cmdSetPowerNotify";
            this.cmdSetPowerNotify.Size = new System.Drawing.Size(128, 23);
            this.cmdSetPowerNotify.TabIndex = 10;
            this.cmdSetPowerNotify.Text = "SetPowerNotify";
            this.cmdSetPowerNotify.UseVisualStyleBackColor = true;
            // 
            // cmdGetPowerNotify
            // 
            this.cmdGetPowerNotify.Location = new System.Drawing.Point(6, 135);
            this.cmdGetPowerNotify.Name = "cmdGetPowerNotify";
            this.cmdGetPowerNotify.Size = new System.Drawing.Size(128, 23);
            this.cmdGetPowerNotify.TabIndex = 9;
            this.cmdGetPowerNotify.Text = "GetPowerNotify";
            this.cmdGetPowerNotify.UseVisualStyleBackColor = true;
            // 
            // cmdSetBinaryConversion
            // 
            this.cmdSetBinaryConversion.Location = new System.Drawing.Point(140, 164);
            this.cmdSetBinaryConversion.Name = "cmdSetBinaryConversion";
            this.cmdSetBinaryConversion.Size = new System.Drawing.Size(128, 23);
            this.cmdSetBinaryConversion.TabIndex = 12;
            this.cmdSetBinaryConversion.Text = "SetBinaryConversion";
            this.cmdSetBinaryConversion.UseVisualStyleBackColor = true;
            // 
            // cmdGetBinaryConversion
            // 
            this.cmdGetBinaryConversion.Location = new System.Drawing.Point(6, 164);
            this.cmdGetBinaryConversion.Name = "cmdGetBinaryConversion";
            this.cmdGetBinaryConversion.Size = new System.Drawing.Size(128, 23);
            this.cmdGetBinaryConversion.TabIndex = 11;
            this.cmdGetBinaryConversion.Text = "GetBinaryConversion";
            this.cmdGetBinaryConversion.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtResult);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtStatus);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtCardPropList);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtCardTypeList);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtTrack2Disc);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtTrack1Disc);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtFirstName);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtSurname);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtExpiration);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtAccount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtCardType);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTrack4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtTrack3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtTrack2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtTrack1);
            this.groupBox3.Location = new System.Drawing.Point(12, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(619, 519);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos";
            // 
            // txtTrack1
            // 
            this.txtTrack1.Location = new System.Drawing.Point(6, 50);
            this.txtTrack1.Name = "txtTrack1";
            this.txtTrack1.Size = new System.Drawing.Size(607, 20);
            this.txtTrack1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Track 1 Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Track 2 Data";
            // 
            // txtTrack2
            // 
            this.txtTrack2.Location = new System.Drawing.Point(6, 89);
            this.txtTrack2.Name = "txtTrack2";
            this.txtTrack2.Size = new System.Drawing.Size(607, 20);
            this.txtTrack2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Track 3 Data";
            // 
            // txtTrack3
            // 
            this.txtTrack3.Location = new System.Drawing.Point(6, 128);
            this.txtTrack3.Name = "txtTrack3";
            this.txtTrack3.Size = new System.Drawing.Size(607, 20);
            this.txtTrack3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Track 4 Data";
            // 
            // txtTrack4
            // 
            this.txtTrack4.Location = new System.Drawing.Point(6, 166);
            this.txtTrack4.Name = "txtTrack4";
            this.txtTrack4.Size = new System.Drawing.Size(607, 20);
            this.txtTrack4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Card Type";
            // 
            // txtCardType
            // 
            this.txtCardType.Location = new System.Drawing.Point(6, 207);
            this.txtCardType.Name = "txtCardType";
            this.txtCardType.Size = new System.Drawing.Size(156, 20);
            this.txtCardType.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Account Name";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(168, 207);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(156, 20);
            this.txtAccount.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Expiration Date";
            // 
            // txtExpiration
            // 
            this.txtExpiration.Location = new System.Drawing.Point(330, 207);
            this.txtExpiration.Name = "txtExpiration";
            this.txtExpiration.Size = new System.Drawing.Size(156, 20);
            this.txtExpiration.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Track 1 Discretionary";
            // 
            // txtTrack1Disc
            // 
            this.txtTrack1Disc.Location = new System.Drawing.Point(6, 287);
            this.txtTrack1Disc.Name = "txtTrack1Disc";
            this.txtTrack1Disc.Size = new System.Drawing.Size(480, 20);
            this.txtTrack1Disc.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(168, 248);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(156, 20);
            this.txtFirstName.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(6, 248);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(156, 20);
            this.txtSurname.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Track 2 Discretionary";
            // 
            // txtTrack2Disc
            // 
            this.txtTrack2Disc.Location = new System.Drawing.Point(6, 327);
            this.txtTrack2Disc.Name = "txtTrack2Disc";
            this.txtTrack2Disc.Size = new System.Drawing.Size(480, 20);
            this.txtTrack2Disc.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Card Type List";
            // 
            // txtCardTypeList
            // 
            this.txtCardTypeList.Location = new System.Drawing.Point(6, 368);
            this.txtCardTypeList.Name = "txtCardTypeList";
            this.txtCardTypeList.Size = new System.Drawing.Size(480, 20);
            this.txtCardTypeList.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Card Prop List";
            // 
            // txtCardPropList
            // 
            this.txtCardPropList.Location = new System.Drawing.Point(6, 409);
            this.txtCardPropList.Name = "txtCardPropList";
            this.txtCardPropList.Size = new System.Drawing.Size(480, 20);
            this.txtCardPropList.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(165, 432);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Result Code";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(168, 448);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(156, 20);
            this.txtResult.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 432);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(6, 448);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(156, 20);
            this.txtStatus.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 749);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdSetBinaryConversion;
        private System.Windows.Forms.Button cmdGetBinaryConversion;
        private System.Windows.Forms.Button cmdSetPowerNotify;
        private System.Windows.Forms.Button cmdGetPowerNotify;
        private System.Windows.Forms.Button cmdSetAutoDisable;
        private System.Windows.Forms.Button cmdGetAutoDisable;
        private System.Windows.Forms.Button cmdSetFreezeEvents;
        private System.Windows.Forms.Button cmdGetFreezeEvents;
        private System.Windows.Forms.Button cmdSetDataEventEnabled;
        private System.Windows.Forms.Button cmdGetDataEventEnabled;
        private System.Windows.Forms.Button cmdSetDeviceEnabled;
        private System.Windows.Forms.Button cmdGetDeviceEnabled;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrack1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrack2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrack4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrack3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTrack1Disc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExpiration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCardType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCardPropList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCardTypeList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTrack2Disc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStatus;
    }
}

