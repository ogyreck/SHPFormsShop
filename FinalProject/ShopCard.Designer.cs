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
			((System.ComponentModel.ISupportInitialize)cardPicture).BeginInit();
			SuspendLayout();
			// 
			// NameCard
			// 
			NameCard.AutoSize = true;
			NameCard.Font = new Font("Segoe UI", 10F);
			NameCard.Location = new Point(25, 33);
			NameCard.Name = "NameCard";
			NameCard.Size = new Size(116, 19);
			NameCard.TabIndex = 0;
			NameCard.Text = "Название товара";
			// 
			// BuyBtn
			// 
			BuyBtn.BackColor = Color.IndianRed;
			BuyBtn.Dock = DockStyle.Bottom;
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
			cardPicture.Location = new Point(25, 73);
			cardPicture.Name = "cardPicture";
			cardPicture.Size = new Size(189, 177);
			cardPicture.SizeMode = PictureBoxSizeMode.StretchImage;
			cardPicture.TabIndex = 2;
			cardPicture.TabStop = false;
			// 
			// CostCard
			// 
			CostCard.AutoSize = true;
			CostCard.Font = new Font("Segoe UI", 15F);
			CostCard.Location = new Point(39, 253);
			CostCard.Name = "CostCard";
			CostCard.Size = new Size(45, 28);
			CostCard.TabIndex = 3;
			CostCard.Text = "999";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F);
			label1.Location = new Point(107, 253);
			label1.Name = "label1";
			label1.Size = new Size(79, 28);
			label1.TabIndex = 4;
			label1.Text = "рублей";
			// 
			// ShopCard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Info;
			Controls.Add(label1);
			Controls.Add(CostCard);
			Controls.Add(cardPicture);
			Controls.Add(BuyBtn);
			Controls.Add(NameCard);
			Margin = new Padding(10);
			Name = "ShopCard";
			Size = new Size(232, 319);
			((System.ComponentModel.ISupportInitialize)cardPicture).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label NameCard;
		private Button BuyBtn;
		private PictureBox cardPicture;
		private Label CostCard;
		private Label label1;
	}
}
