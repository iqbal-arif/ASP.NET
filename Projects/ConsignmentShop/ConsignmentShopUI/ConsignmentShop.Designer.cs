namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            headerText = new Label();
            SuspendLayout();
            // 
            // headerText
            // 
            headerText.AutoSize = true;
            headerText.Location = new Point(43, 36);
            headerText.Name = "headerText";
            headerText.Size = new Size(144, 15);
            headerText.TabIndex = 0;
            headerText.Text = "Consignment Shop Demo";
            // 
            // ConsignmentShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 450);
            Controls.Add(headerText);
            Name = "ConsignmentShop";
            Text = "Consignment Shop Demo";
            Load += this.ConsignmentShop_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerText;
    }
}
