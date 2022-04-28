
namespace 鼠標位置_v2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientLocation = new System.Windows.Forms.Label();
            this.mouseLocation = new System.Windows.Forms.Label();
            this.returnPosition = new System.Windows.Forms.Button();
            this.topMostCheckBox = new System.Windows.Forms.CheckBox();
            this.opacityTrack = new System.Windows.Forms.TrackBar();
            this.opacityDisplay = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mouseClickInfinity = new System.Windows.Forms.Button();
            this.mouseClickCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "鼠標：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "視窗：";
            // 
            // clientLocation
            // 
            this.clientLocation.AutoSize = true;
            this.clientLocation.Location = new System.Drawing.Point(146, 65);
            this.clientLocation.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.clientLocation.Name = "clientLocation";
            this.clientLocation.Size = new System.Drawing.Size(155, 46);
            this.clientLocation.TabIndex = 3;
            this.clientLocation.Text = "（x , y）";
            // 
            // mouseLocation
            // 
            this.mouseLocation.AutoSize = true;
            this.mouseLocation.Location = new System.Drawing.Point(146, 9);
            this.mouseLocation.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.mouseLocation.Name = "mouseLocation";
            this.mouseLocation.Size = new System.Drawing.Size(155, 46);
            this.mouseLocation.TabIndex = 2;
            this.mouseLocation.Text = "（x , y）";
            // 
            // returnPosition
            // 
            this.returnPosition.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnPosition.Location = new System.Drawing.Point(12, 124);
            this.returnPosition.Name = "returnPosition";
            this.returnPosition.Size = new System.Drawing.Size(214, 50);
            this.returnPosition.TabIndex = 4;
            this.returnPosition.Text = "回原點";
            this.returnPosition.UseVisualStyleBackColor = true;
            this.returnPosition.Click += new System.EventHandler(this.returnPosition_Click);
            // 
            // topMostCheckBox
            // 
            this.topMostCheckBox.AutoSize = true;
            this.topMostCheckBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topMostCheckBox.Location = new System.Drawing.Point(279, 136);
            this.topMostCheckBox.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.topMostCheckBox.Name = "topMostCheckBox";
            this.topMostCheckBox.Size = new System.Drawing.Size(140, 34);
            this.topMostCheckBox.TabIndex = 5;
            this.topMostCheckBox.Text = "TopMost";
            this.topMostCheckBox.UseVisualStyleBackColor = true;
            this.topMostCheckBox.CheckedChanged += new System.EventHandler(this.topMostCheckBox_CheckedChanged);
            // 
            // opacityTrack
            // 
            this.opacityTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opacityTrack.Location = new System.Drawing.Point(12, 180);
            this.opacityTrack.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.opacityTrack.Maximum = 20;
            this.opacityTrack.Name = "opacityTrack";
            this.opacityTrack.Size = new System.Drawing.Size(493, 69);
            this.opacityTrack.SmallChange = 5;
            this.opacityTrack.TabIndex = 6;
            this.opacityTrack.Value = 10;
            this.opacityTrack.Scroll += new System.EventHandler(this.opacityTrack_Scroll);
            // 
            // opacityDisplay
            // 
            this.opacityDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.opacityDisplay.AutoSize = true;
            this.opacityDisplay.Location = new System.Drawing.Point(505, 180);
            this.opacityDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.opacityDisplay.Name = "opacityDisplay";
            this.opacityDisplay.Size = new System.Drawing.Size(94, 46);
            this.opacityDisplay.TabIndex = 7;
            this.opacityDisplay.Text = "50%";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 25;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mouseClickInfinity
            // 
            this.mouseClickInfinity.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mouseClickInfinity.Location = new System.Drawing.Point(405, 5);
            this.mouseClickInfinity.Name = "mouseClickInfinity";
            this.mouseClickInfinity.Size = new System.Drawing.Size(206, 39);
            this.mouseClickInfinity.TabIndex = 8;
            this.mouseClickInfinity.Text = "鼠標無限點擊 (F3/F2)";
            this.mouseClickInfinity.UseVisualStyleBackColor = true;
            this.mouseClickInfinity.Click += new System.EventHandler(this.mouseClickInfinity_Click);
            // 
            // mouseClickCount
            // 
            this.mouseClickCount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mouseClickCount.Location = new System.Drawing.Point(405, 47);
            this.mouseClickCount.Name = "mouseClickCount";
            this.mouseClickCount.Size = new System.Drawing.Size(206, 34);
            this.mouseClickCount.TabIndex = 9;
            this.mouseClickCount.Text = "0";
            this.mouseClickCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 250);
            this.Controls.Add(this.mouseClickCount);
            this.Controls.Add(this.mouseClickInfinity);
            this.Controls.Add(this.opacityDisplay);
            this.Controls.Add(this.opacityTrack);
            this.Controls.Add(this.topMostCheckBox);
            this.Controls.Add(this.returnPosition);
            this.Controls.Add(this.clientLocation);
            this.Controls.Add(this.mouseLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Opacity = 0.5D;
            this.Text = "鼠標位置   v 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label clientLocation;
        private System.Windows.Forms.Label mouseLocation;
        private System.Windows.Forms.Button returnPosition;
        private System.Windows.Forms.CheckBox topMostCheckBox;
        private System.Windows.Forms.TrackBar opacityTrack;
        private System.Windows.Forms.Label opacityDisplay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button mouseClickInfinity;
        private System.Windows.Forms.Label mouseClickCount;
    }
}

