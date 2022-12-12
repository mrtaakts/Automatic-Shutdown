namespace Automatic_Shutdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hourComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.secondComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.minuteComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.timerButton = new MaterialSkin.Controls.MaterialButton();
            this.processComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.CountdownLabel = new MaterialSkin.Controls.MaterialLabel();
            this.cancelButton = new MaterialSkin.Controls.MaterialButton();
            this.ProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.SuspendLayout();
            // 
            // hourComboBox
            // 
            this.hourComboBox.AutoResize = false;
            this.hourComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hourComboBox.Depth = 0;
            this.hourComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.hourComboBox.DropDownHeight = 174;
            this.hourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourComboBox.DropDownWidth = 121;
            this.hourComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.hourComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hourComboBox.FormattingEnabled = true;
            this.hourComboBox.IntegralHeight = false;
            this.hourComboBox.ItemHeight = 43;
            this.hourComboBox.Location = new System.Drawing.Point(123, 126);
            this.hourComboBox.MaxDropDownItems = 4;
            this.hourComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.hourComboBox.Name = "hourComboBox";
            this.hourComboBox.Size = new System.Drawing.Size(151, 49);
            this.hourComboBox.StartIndex = 0;
            this.hourComboBox.TabIndex = 1;
            // 
            // secondComboBox
            // 
            this.secondComboBox.AutoResize = false;
            this.secondComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.secondComboBox.Depth = 0;
            this.secondComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.secondComboBox.DropDownHeight = 174;
            this.secondComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secondComboBox.DropDownWidth = 121;
            this.secondComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.secondComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.secondComboBox.FormattingEnabled = true;
            this.secondComboBox.IntegralHeight = false;
            this.secondComboBox.ItemHeight = 43;
            this.secondComboBox.Location = new System.Drawing.Point(516, 126);
            this.secondComboBox.MaxDropDownItems = 4;
            this.secondComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.secondComboBox.Name = "secondComboBox";
            this.secondComboBox.Size = new System.Drawing.Size(151, 49);
            this.secondComboBox.StartIndex = 0;
            this.secondComboBox.TabIndex = 3;
            // 
            // minuteComboBox
            // 
            this.minuteComboBox.AutoResize = false;
            this.minuteComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.minuteComboBox.Depth = 0;
            this.minuteComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.minuteComboBox.DropDownHeight = 174;
            this.minuteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minuteComboBox.DropDownWidth = 121;
            this.minuteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.minuteComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.minuteComboBox.FormattingEnabled = true;
            this.minuteComboBox.IntegralHeight = false;
            this.minuteComboBox.ItemHeight = 43;
            this.minuteComboBox.Location = new System.Drawing.Point(323, 126);
            this.minuteComboBox.MaxDropDownItems = 4;
            this.minuteComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.minuteComboBox.Name = "minuteComboBox";
            this.minuteComboBox.Size = new System.Drawing.Size(151, 49);
            this.minuteComboBox.StartIndex = 0;
            this.minuteComboBox.TabIndex = 2;
            // 
            // timerButton
            // 
            this.timerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.timerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.timerButton.Depth = 0;
            this.timerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerButton.HighEmphasis = true;
            this.timerButton.Icon = null;
            this.timerButton.Location = new System.Drawing.Point(347, 207);
            this.timerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.timerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.timerButton.Name = "timerButton";
            this.timerButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.timerButton.Size = new System.Drawing.Size(95, 36);
            this.timerButton.TabIndex = 4;
            this.timerButton.Text = "Set Tımer";
            this.timerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.timerButton.UseAccentColor = true;
            this.timerButton.UseVisualStyleBackColor = true;
            this.timerButton.Click += new System.EventHandler(this.timerButton_Click);
            // 
            // processComboBox
            // 
            this.processComboBox.AutoResize = false;
            this.processComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.processComboBox.Depth = 0;
            this.processComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.processComboBox.DropDownHeight = 174;
            this.processComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processComboBox.DropDownWidth = 121;
            this.processComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.processComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.processComboBox.FormattingEnabled = true;
            this.processComboBox.IntegralHeight = false;
            this.processComboBox.ItemHeight = 43;
            this.processComboBox.Location = new System.Drawing.Point(40, 327);
            this.processComboBox.MaxDropDownItems = 4;
            this.processComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.processComboBox.Name = "processComboBox";
            this.processComboBox.Size = new System.Drawing.Size(151, 49);
            this.processComboBox.StartIndex = 0;
            this.processComboBox.TabIndex = 5;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.ForeColor = System.Drawing.Color.Black;
            this.materialLabel1.Location = new System.Drawing.Point(166, 87);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 24);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Hours";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(359, 87);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(74, 24);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Minutes";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(556, 87);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(77, 24);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "Seconds";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(30, 287);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(171, 24);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "What do you want?";
            // 
            // CountdownLabel
            // 
            this.CountdownLabel.AutoSize = true;
            this.CountdownLabel.Depth = 0;
            this.CountdownLabel.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CountdownLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.CountdownLabel.Location = new System.Drawing.Point(533, 296);
            this.CountdownLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CountdownLabel.Name = "CountdownLabel";
            this.CountdownLabel.Size = new System.Drawing.Size(225, 72);
            this.CountdownLabel.TabIndex = 20;
            this.CountdownLabel.Text = "00:00:00";
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = false;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancelButton.Depth = 0;
            this.cancelButton.Enabled = false;
            this.cancelButton.HighEmphasis = true;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(347, 266);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancelButton.Size = new System.Drawing.Size(95, 36);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelButton.UseAccentColor = false;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Depth = 0;
            this.ProgressBar.Location = new System.Drawing.Point(533, 371);
            this.ProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(225, 5);
            this.ProgressBar.TabIndex = 22;
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialSwitch1.Location = new System.Drawing.Point(334, 371);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(99, 37);
            this.materialSwitch1.TabIndex = 24;
            this.materialSwitch1.Text = "DARK";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 446);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.timerButton);
            this.Controls.Add(this.materialSwitch1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.CountdownLabel);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.processComboBox);
            this.Controls.Add(this.minuteComboBox);
            this.Controls.Add(this.secondComboBox);
            this.Controls.Add(this.hourComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatic Shutdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox hourComboBox;
        private MaterialSkin.Controls.MaterialComboBox secondComboBox;
        private MaterialSkin.Controls.MaterialComboBox minuteComboBox;
        private MaterialSkin.Controls.MaterialButton timerButton;
        private MaterialSkin.Controls.MaterialComboBox processComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel CountdownLabel;
        private MaterialSkin.Controls.MaterialButton cancelButton;
        private MaterialSkin.Controls.MaterialProgressBar ProgressBar;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
    }
}