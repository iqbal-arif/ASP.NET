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
            itemsListbox = new ListBox();
            itemsListboxLabel = new Label();
            addToCart = new Button();
            shoppingCartListboxLabel = new Label();
            shoppingCartListbox = new ListBox();
            SuspendLayout();
            // 
            // headerText
            // 
            headerText.AutoSize = true;
            headerText.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerText.Location = new Point(24, 18);
            headerText.Margin = new Padding(4, 0, 4, 0);
            headerText.Name = "headerText";
            headerText.Size = new Size(305, 32);
            headerText.TabIndex = 0;
            headerText.Text = "Consignment Shop Demo";
            // 
            // itemsListbox
            // 
            itemsListbox.Font = new Font("Aptos Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemsListbox.FormattingEnabled = true;
            itemsListbox.ItemHeight = 20;
            itemsListbox.Location = new Point(24, 113);
            itemsListbox.Margin = new Padding(2, 2, 2, 2);
            itemsListbox.Name = "itemsListbox";
            itemsListbox.Size = new Size(278, 144);
            itemsListbox.TabIndex = 1;
            // 
            // itemsListboxLabel
            // 
            itemsListboxLabel.AutoSize = true;
            itemsListboxLabel.Font = new Font("Aptos Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemsListboxLabel.Location = new Point(24, 80);
            itemsListboxLabel.Margin = new Padding(2, 0, 2, 0);
            itemsListboxLabel.Name = "itemsListboxLabel";
            itemsListboxLabel.Size = new Size(85, 20);
            itemsListboxLabel.TabIndex = 2;
            itemsListboxLabel.Text = "Store Items";
            // 
            // addToCart
            // 
            addToCart.Font = new Font("Aptos Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addToCart.Location = new Point(209, 262);
            addToCart.Name = "addToCart";
            addToCart.Size = new Size(93, 30);
            addToCart.TabIndex = 3;
            addToCart.Text = "Add To Cart";
            addToCart.UseVisualStyleBackColor = true;
            // 
            // shoppingCartListboxLabel
            // 
            shoppingCartListboxLabel.AutoSize = true;
            shoppingCartListboxLabel.Font = new Font("Aptos Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shoppingCartListboxLabel.Location = new Point(497, 80);
            shoppingCartListboxLabel.Margin = new Padding(2, 0, 2, 0);
            shoppingCartListboxLabel.Name = "shoppingCartListboxLabel";
            shoppingCartListboxLabel.Size = new Size(106, 20);
            shoppingCartListboxLabel.TabIndex = 5;
            shoppingCartListboxLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListbox
            // 
            shoppingCartListbox.Font = new Font("Aptos Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shoppingCartListbox.FormattingEnabled = true;
            shoppingCartListbox.ItemHeight = 20;
            shoppingCartListbox.Location = new Point(497, 113);
            shoppingCartListbox.Margin = new Padding(2);
            shoppingCartListbox.Name = "shoppingCartListbox";
            shoppingCartListbox.Size = new Size(278, 144);
            shoppingCartListbox.TabIndex = 4;
            // 
            // ConsignmentShop
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 630);
            Controls.Add(shoppingCartListboxLabel);
            Controls.Add(shoppingCartListbox);
            Controls.Add(addToCart);
            Controls.Add(itemsListboxLabel);
            Controls.Add(itemsListbox);
            Controls.Add(headerText);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ConsignmentShop";
            Text = "Consignment Shop Demo";
            Load += this.ConsignmentShop_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerText;
        private ListBox itemsListbox;
        private Label itemsListboxLabel;
        private Button addToCart;
        private Label shoppingCartListboxLabel;
        private ListBox shoppingCartListbox;
    }
}
