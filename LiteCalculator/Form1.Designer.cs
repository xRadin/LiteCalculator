namespace LiteCalculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnPowerOfTwo = new MetroFramework.Controls.MetroButton();
            this.btnRadical2 = new MetroFramework.Controls.MetroButton();
            this.btnReminder = new MetroFramework.Controls.MetroButton();
            this.btnDivison = new MetroFramework.Controls.MetroButton();
            this.btnMultipliction = new MetroFramework.Controls.MetroButton();
            this.btnBackSpace = new MetroFramework.Controls.MetroButton();
            this.CopyMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.CopyContext = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSubtraction = new MetroFramework.Controls.MetroButton();
            this.btnAddision = new MetroFramework.Controls.MetroButton();
            this.btn1 = new MetroFramework.Controls.MetroButton();
            this.btn2 = new MetroFramework.Controls.MetroButton();
            this.btn3 = new MetroFramework.Controls.MetroButton();
            this.btn4 = new MetroFramework.Controls.MetroButton();
            this.btn5 = new MetroFramework.Controls.MetroButton();
            this.btn6 = new MetroFramework.Controls.MetroButton();
            this.btn7 = new MetroFramework.Controls.MetroButton();
            this.btn8 = new MetroFramework.Controls.MetroButton();
            this.btn9 = new MetroFramework.Controls.MetroButton();
            this.btn0 = new MetroFramework.Controls.MetroButton();
            this.btnResult = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblHistory = new System.Windows.Forms.Label();
            this.btnFloat = new MetroFramework.Controls.MetroButton();
            this.txtResult = new System.Windows.Forms.Label();
            this.CopyMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDelete.Location = new System.Drawing.Point(17, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(194, 74);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "C";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPowerOfTwo
            // 
            this.btnPowerOfTwo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPowerOfTwo.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPowerOfTwo.Location = new System.Drawing.Point(17, 279);
            this.btnPowerOfTwo.Name = "btnPowerOfTwo";
            this.btnPowerOfTwo.Size = new System.Drawing.Size(94, 74);
            this.btnPowerOfTwo.TabIndex = 4;
            this.btnPowerOfTwo.Text = "x²";
            this.btnPowerOfTwo.UseSelectable = true;
            this.btnPowerOfTwo.Click += new System.EventHandler(this.btnPowerOfTwo_Click);
            // 
            // btnRadical2
            // 
            this.btnRadical2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRadical2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRadical2.Location = new System.Drawing.Point(117, 279);
            this.btnRadical2.Name = "btnRadical2";
            this.btnRadical2.Size = new System.Drawing.Size(94, 74);
            this.btnRadical2.TabIndex = 5;
            this.btnRadical2.Text = "²√x";
            this.btnRadical2.UseSelectable = true;
            this.btnRadical2.Click += new System.EventHandler(this.btnRadical2_Click);
            // 
            // btnReminder
            // 
            this.btnReminder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReminder.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnReminder.Location = new System.Drawing.Point(217, 279);
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(94, 74);
            this.btnReminder.TabIndex = 6;
            this.btnReminder.Text = "%";
            this.btnReminder.UseSelectable = true;
            this.btnReminder.Click += new System.EventHandler(this.btnReminder_Click);
            // 
            // btnDivison
            // 
            this.btnDivison.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDivison.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDivison.Location = new System.Drawing.Point(317, 279);
            this.btnDivison.Name = "btnDivison";
            this.btnDivison.Size = new System.Drawing.Size(94, 74);
            this.btnDivison.TabIndex = 7;
            this.btnDivison.Text = "÷";
            this.btnDivison.UseSelectable = true;
            this.btnDivison.Click += new System.EventHandler(this.btnDivison_Click);
            // 
            // btnMultipliction
            // 
            this.btnMultipliction.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMultipliction.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnMultipliction.Location = new System.Drawing.Point(317, 359);
            this.btnMultipliction.Name = "btnMultipliction";
            this.btnMultipliction.Size = new System.Drawing.Size(94, 74);
            this.btnMultipliction.TabIndex = 8;
            this.btnMultipliction.Text = "X";
            this.btnMultipliction.UseSelectable = true;
            this.btnMultipliction.Click += new System.EventHandler(this.btnMultipliction_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBackSpace.BackgroundImage = global::LiteCalculator.Properties.Resources.icons8_backspace_100__1_;
            this.btnBackSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackSpace.ContextMenuStrip = this.CopyMenu;
            this.btnBackSpace.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBackSpace.Location = new System.Drawing.Point(217, 199);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(194, 74);
            this.btnBackSpace.TabIndex = 3;
            this.btnBackSpace.UseSelectable = true;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // CopyMenu
            // 
            this.CopyMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CopyMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CopyMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CopyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyContext});
            this.CopyMenu.Name = "CopyMenu";
            this.CopyMenu.Size = new System.Drawing.Size(113, 28);
            this.CopyMenu.Style = MetroFramework.MetroColorStyle.White;
            this.CopyMenu.Text = "Menu";
            // 
            // CopyContext
            // 
            this.CopyContext.Name = "CopyContext";
            this.CopyContext.Size = new System.Drawing.Size(112, 24);
            this.CopyContext.Text = "Copy";
            this.CopyContext.Click += new System.EventHandler(this.CopyContext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LiteCalculator.Properties.Resources.icons8_calculator_500__1_;
            this.pictureBox1.Location = new System.Drawing.Point(23, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubtraction.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSubtraction.Location = new System.Drawing.Point(317, 439);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(94, 74);
            this.btnSubtraction.TabIndex = 9;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseSelectable = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnAddision
            // 
            this.btnAddision.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddision.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddision.Location = new System.Drawing.Point(317, 519);
            this.btnAddision.Name = "btnAddision";
            this.btnAddision.Size = new System.Drawing.Size(94, 74);
            this.btnAddision.TabIndex = 10;
            this.btnAddision.Text = "+";
            this.btnAddision.UseSelectable = true;
            this.btnAddision.Click += new System.EventHandler(this.btnAddision_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn1.Location = new System.Drawing.Point(17, 359);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(94, 74);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "1";
            this.btn1.UseSelectable = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn2.Location = new System.Drawing.Point(117, 359);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(94, 74);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseSelectable = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn3.Location = new System.Drawing.Point(217, 359);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(94, 74);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseSelectable = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn4.Location = new System.Drawing.Point(17, 439);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(94, 74);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseSelectable = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn5.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn5.Location = new System.Drawing.Point(117, 439);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(94, 74);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseSelectable = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn6.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn6.Location = new System.Drawing.Point(217, 439);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(94, 74);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseSelectable = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn7.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn7.Location = new System.Drawing.Point(17, 519);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(94, 74);
            this.btn7.TabIndex = 17;
            this.btn7.Text = "7";
            this.btn7.UseSelectable = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn8.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn8.Location = new System.Drawing.Point(117, 519);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(94, 74);
            this.btn8.TabIndex = 18;
            this.btn8.Text = "8";
            this.btn8.UseSelectable = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn9.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn9.Location = new System.Drawing.Point(217, 519);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(94, 74);
            this.btn9.TabIndex = 19;
            this.btn9.Text = "9";
            this.btn9.UseSelectable = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn0.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn0.Location = new System.Drawing.Point(17, 599);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(94, 74);
            this.btn0.TabIndex = 20;
            this.btn0.Text = "0";
            this.btn0.UseSelectable = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnResult.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnResult.Location = new System.Drawing.Point(217, 599);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(194, 74);
            this.btnResult.TabIndex = 21;
            this.btnResult.Text = "=";
            this.btnResult.UseSelectable = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Silver;
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.Location = new System.Drawing.Point(23, 103);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(0, 20);
            this.lblHistory.TabIndex = 22;
            // 
            // btnFloat
            // 
            this.btnFloat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFloat.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnFloat.Location = new System.Drawing.Point(117, 599);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(94, 74);
            this.btnFloat.TabIndex = 23;
            this.btnFloat.Text = ".";
            this.btnFloat.UseSelectable = true;
            this.btnFloat.Click += new System.EventHandler(this.btnFloat_Click);
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.ContextMenuStrip = this.CopyMenu;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(17, 139);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(32, 36);
            this.txtResult.TabIndex = 24;
            this.txtResult.Text = "0";
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 686);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnFloat);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnAddision);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnMultipliction);
            this.Controls.Add(this.btnDivison);
            this.Controls.Add(this.btnReminder);
            this.Controls.Add(this.btnRadical2);
            this.Controls.Add(this.btnPowerOfTwo);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "       LiteCalculator";
            this.CopyMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnBackSpace;
        private MetroFramework.Controls.MetroButton btnPowerOfTwo;
        private MetroFramework.Controls.MetroButton btnRadical2;
        private MetroFramework.Controls.MetroButton btnReminder;
        private MetroFramework.Controls.MetroButton btnDivison;
        private MetroFramework.Controls.MetroButton btnMultipliction;
        private MetroFramework.Controls.MetroButton btnSubtraction;
        private MetroFramework.Controls.MetroButton btnAddision;
        private MetroFramework.Controls.MetroButton btn1;
        private MetroFramework.Controls.MetroButton btn2;
        private MetroFramework.Controls.MetroButton btn3;
        private MetroFramework.Controls.MetroButton btn4;
        private MetroFramework.Controls.MetroButton btn5;
        private MetroFramework.Controls.MetroButton btn6;
        private MetroFramework.Controls.MetroButton btn7;
        private MetroFramework.Controls.MetroButton btn8;
        private MetroFramework.Controls.MetroButton btn9;
        private MetroFramework.Controls.MetroButton btn0;
        private MetroFramework.Controls.MetroButton btnResult;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Label lblHistory;
        private MetroFramework.Controls.MetroButton btnFloat;
        private MetroFramework.Controls.MetroContextMenu CopyMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyContext;
        private System.Windows.Forms.Label txtResult;
    }
}

