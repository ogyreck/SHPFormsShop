namespace FinalProject
{
	partial class ProductForm
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
			productDescript = new Label();
			flowLayoutPanel1 = new FlowLayoutPanel();
			label1 = new Label();
			nameProduct = new Label();
			productPictureBox = new PictureBox();
			flowLayoutPanel2 = new FlowLayoutPanel();
			productPrice = new Label();
			flowLayoutPanel3 = new FlowLayoutPanel();
			label2 = new Label();
			productCategory = new Label();
			flowLayoutPanel4 = new FlowLayoutPanel();
			productBuyBtn = new Button();
			label3 = new Label();
			flowLayoutPanel5 = new FlowLayoutPanel();
			flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
			flowLayoutPanel2.SuspendLayout();
			flowLayoutPanel3.SuspendLayout();
			flowLayoutPanel4.SuspendLayout();
			flowLayoutPanel5.SuspendLayout();
			SuspendLayout();
			// 
			// productDescript
			// 
			productDescript.AutoSize = true;
			productDescript.Dock = DockStyle.Fill;
			productDescript.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			productDescript.Location = new Point(3, 0);
			productDescript.Name = "productDescript";
			productDescript.Size = new Size(103, 17);
			productDescript.TabIndex = 0;
			productDescript.Text = "Текст описания ";
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(label1);
			flowLayoutPanel1.Location = new Point(21, 12);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(810, 51);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("Tahoma", 20F, FontStyle.Bold);
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(224, 33);
			label1.TabIndex = 0;
			label1.Text = "SHPShopForms";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// nameProduct
			// 
			nameProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			nameProduct.AutoSize = true;
			nameProduct.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			nameProduct.Location = new Point(3, 0);
			nameProduct.Name = "nameProduct";
			nameProduct.Size = new Size(138, 16);
			nameProduct.TabIndex = 0;
			nameProduct.Text = "Название товара";
			nameProduct.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// productPictureBox
			// 
			productPictureBox.Location = new Point(24, 69);
			productPictureBox.Name = "productPictureBox";
			productPictureBox.Size = new Size(444, 329);
			productPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			productPictureBox.TabIndex = 1;
			productPictureBox.TabStop = false;
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.Controls.Add(nameProduct);
			flowLayoutPanel2.Location = new Point(484, 82);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Size = new Size(347, 62);
			flowLayoutPanel2.TabIndex = 2;
			// 
			// productPrice
			// 
			productPrice.AutoSize = true;
			productPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			productPrice.Location = new Point(3, 0);
			productPrice.Name = "productPrice";
			productPrice.Size = new Size(46, 21);
			productPrice.TabIndex = 3;
			productPrice.Text = "1200";
			// 
			// flowLayoutPanel3
			// 
			flowLayoutPanel3.Controls.Add(productPrice);
			flowLayoutPanel3.Controls.Add(label2);
			flowLayoutPanel3.Location = new Point(487, 150);
			flowLayoutPanel3.Name = "flowLayoutPanel3";
			flowLayoutPanel3.Size = new Size(200, 37);
			flowLayoutPanel3.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label2.Location = new Point(55, 0);
			label2.Name = "label2";
			label2.Size = new Size(31, 17);
			label2.TabIndex = 4;
			label2.Text = "руб";
			// 
			// productCategory
			// 
			productCategory.AutoSize = true;
			productCategory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
			productCategory.Location = new Point(3, 0);
			productCategory.Name = "productCategory";
			productCategory.Size = new Size(72, 17);
			productCategory.TabIndex = 5;
			productCategory.Text = "Категория";
			// 
			// flowLayoutPanel4
			// 
			flowLayoutPanel4.Controls.Add(productCategory);
			flowLayoutPanel4.Location = new Point(490, 193);
			flowLayoutPanel4.Name = "flowLayoutPanel4";
			flowLayoutPanel4.Size = new Size(341, 46);
			flowLayoutPanel4.TabIndex = 6;
			// 
			// productBuyBtn
			// 
			productBuyBtn.BackColor = Color.Silver;
			productBuyBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
			productBuyBtn.ForeColor = SystemColors.ButtonHighlight;
			productBuyBtn.Location = new Point(490, 245);
			productBuyBtn.Name = "productBuyBtn";
			productBuyBtn.Size = new Size(341, 153);
			productBuyBtn.TabIndex = 7;
			productBuyBtn.Text = "Купить";
			productBuyBtn.UseVisualStyleBackColor = false;
			productBuyBtn.Click += productBuyBtn_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label3.Location = new Point(24, 430);
			label3.Name = "label3";
			label3.Size = new Size(99, 25);
			label3.TabIndex = 8;
			label3.Text = "Описание";
			// 
			// flowLayoutPanel5
			// 
			flowLayoutPanel5.Controls.Add(productDescript);
			flowLayoutPanel5.Location = new Point(34, 458);
			flowLayoutPanel5.Name = "flowLayoutPanel5";
			flowLayoutPanel5.Size = new Size(797, 120);
			flowLayoutPanel5.TabIndex = 9;
			// 
			// ProductForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(853, 659);
			Controls.Add(flowLayoutPanel5);
			Controls.Add(label3);
			Controls.Add(productBuyBtn);
			Controls.Add(flowLayoutPanel4);
			Controls.Add(flowLayoutPanel3);
			Controls.Add(flowLayoutPanel2);
			Controls.Add(productPictureBox);
			Controls.Add(flowLayoutPanel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "ProductForm";
			Text = "Карточка товара";
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
			flowLayoutPanel2.ResumeLayout(false);
			flowLayoutPanel2.PerformLayout();
			flowLayoutPanel3.ResumeLayout(false);
			flowLayoutPanel3.PerformLayout();
			flowLayoutPanel4.ResumeLayout(false);
			flowLayoutPanel4.PerformLayout();
			flowLayoutPanel5.ResumeLayout(false);
			flowLayoutPanel5.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private Label nameProduct;
		private Label label1;
		private PictureBox productPictureBox;
		private FlowLayoutPanel flowLayoutPanel2;
		private Label productPrice;
		private FlowLayoutPanel flowLayoutPanel3;
		private Label label2;
		private Label productCategory;
		private FlowLayoutPanel flowLayoutPanel4;
		private Button productBuyBtn;
		private Label label3;
		private FlowLayoutPanel flowLayoutPanel5;
		private Label productDescript;
	}
}