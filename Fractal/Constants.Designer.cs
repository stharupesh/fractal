namespace Fractal
{
    partial class SetConstantsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetConstantsForm));
            this.consLabel = new System.Windows.Forms.Label();
            this.realVal = new System.Windows.Forms.TextBox();
            this.imaginaryVal = new System.Windows.Forms.TextBox();
            this.consLabelDetail = new System.Windows.Forms.Label();
            this.whereLabel = new System.Windows.Forms.Label();
            this.applyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // consLabel
            // 
            this.consLabel.AutoSize = true;
            this.consLabel.Location = new System.Drawing.Point(12, 9);
            this.consLabel.Name = "consLabel";
            this.consLabel.Size = new System.Drawing.Size(150, 13);
            this.consLabel.TabIndex = 0;
            this.consLabel.Text = "c =                    +                    i";
            // 
            // realVal
            // 
            this.realVal.Location = new System.Drawing.Point(34, 6);
            this.realVal.Name = "realVal";
            this.realVal.Size = new System.Drawing.Size(50, 20);
            this.realVal.TabIndex = 1;
            // 
            // imaginaryVal
            // 
            this.imaginaryVal.Location = new System.Drawing.Point(101, 6);
            this.imaginaryVal.Name = "imaginaryVal";
            this.imaginaryVal.Size = new System.Drawing.Size(50, 20);
            this.imaginaryVal.TabIndex = 2;
            // 
            // consLabelDetail
            // 
            this.consLabelDetail.Location = new System.Drawing.Point(45, 54);
            this.consLabelDetail.Name = "consLabelDetail";
            this.consLabelDetail.Size = new System.Drawing.Size(245, 16);
            this.consLabelDetail.TabIndex = 0;
            this.consLabelDetail.Text = "c (constant) = a (real value) + bi (imaginary value)";
            // 
            // whereLabel
            // 
            this.whereLabel.AutoSize = true;
            this.whereLabel.Location = new System.Drawing.Point(31, 36);
            this.whereLabel.Name = "whereLabel";
            this.whereLabel.Size = new System.Drawing.Size(39, 13);
            this.whereLabel.TabIndex = 3;
            this.whereLabel.Text = "where,";
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(205, 76);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 4;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // SetConstantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 113);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.whereLabel);
            this.Controls.Add(this.consLabelDetail);
            this.Controls.Add(this.imaginaryVal);
            this.Controls.Add(this.realVal);
            this.Controls.Add(this.consLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetConstantsForm";
            this.Text = "Constants";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label consLabel;
        private System.Windows.Forms.TextBox realVal;
        private System.Windows.Forms.TextBox imaginaryVal;
        private System.Windows.Forms.Label consLabelDetail;
        private System.Windows.Forms.Label whereLabel;
        private System.Windows.Forms.Button applyBtn;
    }
}