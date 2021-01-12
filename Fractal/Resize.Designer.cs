namespace Fractal
{
    partial class Resize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resize));
            this.widthVal = new System.Windows.Forms.TextBox();
            this.heightVal = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.maintainAspectRatio = new System.Windows.Forms.CheckBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.numericErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // widthVal
            // 
            this.widthVal.Location = new System.Drawing.Point(156, 18);
            this.widthVal.Name = "widthVal";
            this.widthVal.Size = new System.Drawing.Size(100, 20);
            this.widthVal.TabIndex = 0;
            this.widthVal.TextChanged += new System.EventHandler(this.widthVal_TextChanged);
            // 
            // heightVal
            // 
            this.heightVal.Location = new System.Drawing.Point(156, 46);
            this.heightVal.Name = "heightVal";
            this.heightVal.Size = new System.Drawing.Size(100, 20);
            this.heightVal.TabIndex = 1;
            this.heightVal.TextChanged += new System.EventHandler(this.heightVal_TextChanged);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.ForeColor = System.Drawing.Color.Black;
            this.widthLabel.Location = new System.Drawing.Point(17, 18);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.ForeColor = System.Drawing.Color.Black;
            this.heightLabel.Location = new System.Drawing.Point(17, 46);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height";
            // 
            // maintainAspectRatio
            // 
            this.maintainAspectRatio.AutoSize = true;
            this.maintainAspectRatio.ForeColor = System.Drawing.Color.Black;
            this.maintainAspectRatio.Location = new System.Drawing.Point(17, 86);
            this.maintainAspectRatio.Name = "maintainAspectRatio";
            this.maintainAspectRatio.Size = new System.Drawing.Size(130, 17);
            this.maintainAspectRatio.TabIndex = 4;
            this.maintainAspectRatio.Text = "Maintain Aspect Ratio";
            this.maintainAspectRatio.UseVisualStyleBackColor = true;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(156, 82);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(100, 23);
            this.applyBtn.TabIndex = 5;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // numericErrorProvider
            // 
            this.numericErrorProvider.ContainerControl = this;
            // 
            // Resize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 125);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.maintainAspectRatio);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightVal);
            this.Controls.Add(this.widthVal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Resize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resize";
            ((System.ComponentModel.ISupportInitialize)(this.numericErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox widthVal;
        private System.Windows.Forms.TextBox heightVal;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.CheckBox maintainAspectRatio;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.ErrorProvider numericErrorProvider;
    }
}