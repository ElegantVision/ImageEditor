namespace ImageResizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtslct = new System.Windows.Forms.TextBox();
            this.txtsv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtw = new System.Windows.Forms.TextBox();
            this.txth = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox_Resized = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ImageCompressor = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ResizePanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox_image2 = new System.Windows.Forms.PictureBox();
            this.btn_manipulate = new System.Windows.Forms.Button();
            this.EventHandlerText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Resized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.ResizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Image";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Save Image";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtslct
            // 
            this.txtslct.Location = new System.Drawing.Point(78, 27);
            this.txtslct.Name = "txtslct";
            this.txtslct.Size = new System.Drawing.Size(349, 20);
            this.txtslct.TabIndex = 2;
            // 
            // txtsv
            // 
            this.txtsv.Location = new System.Drawing.Point(78, 88);
            this.txtsv.Name = "txtsv";
            this.txtsv.Size = new System.Drawing.Size(349, 20);
            this.txtsv.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type";
            // 
            // txtw
            // 
            this.txtw.Location = new System.Drawing.Point(76, 151);
            this.txtw.Name = "txtw";
            this.txtw.Size = new System.Drawing.Size(66, 20);
            this.txtw.TabIndex = 9;
            // 
            // txth
            // 
            this.txth.Location = new System.Drawing.Point(232, 151);
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(66, 20);
            this.txth.TabIndex = 10;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(390, 151);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(67, 21);
            this.comboBox.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(61, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "Resize";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(265, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 29);
            this.button4.TabIndex = 14;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(9, 253);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(294, 190);
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // pictureBox_Resized
            // 
            this.pictureBox_Resized.Location = new System.Drawing.Point(16, 44);
            this.pictureBox_Resized.Name = "pictureBox_Resized";
            this.pictureBox_Resized.Size = new System.Drawing.Size(428, 296);
            this.pictureBox_Resized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Resized.TabIndex = 16;
            this.pictureBox_Resized.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(538, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Resized : (left press mouse beneathe top border of this blue shaded area. and mov" +
    "e mouse to pan around image)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Original";
            // 
            // ImageCompressor
            // 
            this.ImageCompressor.Location = new System.Drawing.Point(510, 193);
            this.ImageCompressor.Name = "ImageCompressor";
            this.ImageCompressor.Size = new System.Drawing.Size(112, 23);
            this.ImageCompressor.TabIndex = 19;
            this.ImageCompressor.Text = "Compress";
            this.ImageCompressor.UseVisualStyleBackColor = true;
            this.ImageCompressor.Click += new System.EventHandler(this.ImageCompressor_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(675, 194);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(198, 45);
            this.trackBar1.TabIndex = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ResizePanel
            // 
            this.ResizePanel.AutoScroll = true;
            this.ResizePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ResizePanel.Controls.Add(this.pictureBox_Resized);
            this.ResizePanel.Controls.Add(this.label6);
            this.ResizePanel.Location = new System.Drawing.Point(356, 225);
            this.ResizePanel.Name = "ResizePanel";
            this.ResizePanel.Size = new System.Drawing.Size(653, 441);
            this.ResizePanel.TabIndex = 21;
            this.ResizePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizePanel_MouseDown);
            this.ResizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResizePanel_MouseMove);
            this.ResizePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResizePanel_MouseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 52);
            this.label8.TabIndex = 18;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // pictureBox_image2
            // 
            this.pictureBox_image2.Location = new System.Drawing.Point(12, 462);
            this.pictureBox_image2.Name = "pictureBox_image2";
            this.pictureBox_image2.Size = new System.Drawing.Size(309, 204);
            this.pictureBox_image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_image2.TabIndex = 22;
            this.pictureBox_image2.TabStop = false;
            // 
            // btn_manipulate
            // 
            this.btn_manipulate.Enabled = false;
            this.btn_manipulate.Location = new System.Drawing.Point(510, 149);
            this.btn_manipulate.Name = "btn_manipulate";
            this.btn_manipulate.Size = new System.Drawing.Size(112, 23);
            this.btn_manipulate.TabIndex = 23;
            this.btn_manipulate.Text = "Manipulate";
            this.btn_manipulate.UseVisualStyleBackColor = true;
            this.btn_manipulate.Click += new System.EventHandler(this.btn_manipulate_Click);
            // 
            // EventHandlerText
            // 
            this.EventHandlerText.AutoSize = true;
            this.EventHandlerText.Location = new System.Drawing.Point(639, 149);
            this.EventHandlerText.Name = "EventHandlerText";
            this.EventHandlerText.Size = new System.Drawing.Size(35, 13);
            this.EventHandlerText.TabIndex = 24;
            this.EventHandlerText.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 678);
            this.Controls.Add(this.EventHandlerText);
            this.Controls.Add(this.btn_manipulate);
            this.Controls.Add(this.pictureBox_image2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ResizePanel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.ImageCompressor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.txth);
            this.Controls.Add(this.txtw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsv);
            this.Controls.Add(this.txtslct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Image Rezier";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Resized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResizePanel.ResumeLayout(false);
            this.ResizePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtslct;
        private System.Windows.Forms.TextBox txtsv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtw;
        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox pictureBox_Resized;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ImageCompressor;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel ResizePanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox_image2;
        private System.Windows.Forms.Button btn_manipulate;
        private System.Windows.Forms.Label EventHandlerText;
    }
}

