namespace TotalSales
{
    partial class frmTotalSales
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
            btnSales = new Button();
            lstDisplay = new ListBox();
            SuspendLayout();
            // 
            // btnSales
            // 
            btnSales.Location = new Point(213, 77);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(230, 29);
            btnSales.TabIndex = 0;
            btnSales.Text = "Open file calculate sales";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // lstDisplay
            // 
            lstDisplay.FormattingEnabled = true;
            lstDisplay.Location = new Point(55, 143);
            lstDisplay.Name = "lstDisplay";
            lstDisplay.Size = new Size(455, 244);
            lstDisplay.TabIndex = 1;
            // 
            // frmTotalSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 395);
            Controls.Add(lstDisplay);
            Controls.Add(btnSales);
            Name = "frmTotalSales";
            Text = "Total Sales";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSales;
        private ListBox lstDisplay;
    }
}
