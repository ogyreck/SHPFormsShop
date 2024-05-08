namespace FinalProject
{
	partial class ShopCard
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			NameCard = new Label();
			BuyBtn = new Button();
			cardPicture = new PictureBox();
			CostCard = new Label();
			label1 = new Label();
			flowLayoutPanel1 = new FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)cardPicture).BeginInit();
			flowLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// NameCard
			// 
			NameCard.AutoSize = true;
			NameCard.Dock = DockStyle.Fill;
			NameCard.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			NameCard.Location = new Point(3, 0);
			NameCard.Name = "NameCard";
			NameCard.Size = new Size(99, 15);
			NameCard.TabIndex = 0;
			NameCard.Text = "Название товара";
			NameCard.Click += NameCard_Click;
			// 
			// BuyBtn
			// 
			BuyBtn.BackColor = Color.IndianRed;
			BuyBtn.Dock = DockStyle.Bottom;
			BuyBtn.FlatStyle = FlatStyle.Popup;
			BuyBtn.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
			BuyBtn.ForeColor = SystemColors.ButtonHighlight;
			BuyBtn.Location = new Point(0, 284);
			BuyBtn.Name = "BuyBtn";
			BuyBtn.Size = new Size(232, 35);
			BuyBtn.TabIndex = 1;
			BuyBtn.Text = "Купить";
			BuyBtn.UseVisualStyleBackColor = false;
			BuyBtn.Click += BuyBtn_Click;
			// 
			// cardPicture
			// 
			cardPicture.Location = new Point(25, 105);
			cardPicture.Name = "cardPicture";
			cardPicture.Size = new Size(189, 145);
			cardPicture.SizeMode = PictureBoxSizeMode.StretchImage;
			cardPicture.TabIndex = 2;
			cardPicture.TabStop = false;
			cardPicture.Click += cardPicture_Click;
			// 
			// CostCard
			// 
			CostCard.AutoSize = true;
			CostCard.Font = new Font("Segoe UI", 15F);
			CostCard.Location = new Point(48, 253);
			CostCard.Name = "CostCard";
			CostCard.Size = new Size(45, 28);
			CostCard.TabIndex = 3;
			CostCard.Text = "999";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F);
			label1.Location = new Point(118, 253);
			label1.Name = "label1";
			label1.Size = new Size(46, 28);
			label1.TabIndex = 4;
			label1.Text = "руб";
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(NameCard);
			flowLayoutPanel1.Location = new Point(25, 22);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(189, 77);
			flowLayoutPanel1.TabIndex = 5;
			flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
			// 
			// ShopCard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			Controls.Add(flowLayoutPanel1);
			Controls.Add(label1);
			Controls.Add(CostCard);
			Controls.Add(cardPicture);
			Controls.Add(BuyBtn);
			Margin = new Padding(10);
			Name = "ShopCard";
			Size = new Size(232, 319);
			Load += ShopCard_Load;
			Click += ShopCard_Click;
			((System.ComponentModel.ISupportInitialize)cardPicture).EndInit();
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label NameCard;
		private Button BuyBtn;
		private PictureBox cardPicture;
		private Label CostCard;
		private Label label1;
		private FlowLayoutPanel flowLayoutPanel1;
	}
}
