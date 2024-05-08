namespace FinalProject
{
	partial class BasketItem
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
			itemPictureBox = new PictureBox();
			flowLayoutPanel1 = new FlowLayoutPanel();
			itemName = new Label();
			btnDel = new Button();
			itemCost = new Label();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)itemPictureBox).BeginInit();
			flowLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// itemPictureBox
			// 
			itemPictureBox.Location = new Point(20, 13);
			itemPictureBox.Name = "itemPictureBox";
			itemPictureBox.Size = new Size(112, 69);
			itemPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			itemPictureBox.TabIndex = 0;
			itemPictureBox.TabStop = false;
			itemPictureBox.Click += openProductFrom;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Anchor = AnchorStyles.Top;
			flowLayoutPanel1.Controls.Add(itemName);
			flowLayoutPanel1.Location = new Point(138, 13);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(337, 69);
			flowLayoutPanel1.TabIndex = 1;
			flowLayoutPanel1.Click += openProductFrom;
			// 
			// itemName
			// 
			itemName.AutoSize = true;
			itemName.Dock = DockStyle.Fill;
			itemName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			itemName.Location = new Point(3, 0);
			itemName.Name = "itemName";
			itemName.Size = new Size(141, 20);
			itemName.TabIndex = 0;
			itemName.Text = "Навзвание товара ";
			itemName.Click += openProductFrom;
			// 
			// btnDel
			// 
			btnDel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnDel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnDel.Location = new Point(606, 13);
			btnDel.Name = "btnDel";
			btnDel.Size = new Size(119, 69);
			btnDel.TabIndex = 2;
			btnDel.Text = "Удалить";
			btnDel.UseVisualStyleBackColor = true;
			btnDel.Click += btnDel_Click;
			// 
			// itemCost
			// 
			itemCost.Anchor = AnchorStyles.Top;
			itemCost.AutoSize = true;
			itemCost.Font = new Font("Segoe UI", 10F);
			itemCost.Location = new Point(476, 41);
			itemCost.Name = "itemCost";
			itemCost.Size = new Size(60, 19);
			itemCost.TabIndex = 3;
			itemCost.Text = "1200.99";
			itemCost.Click += openProductFrom;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10F);
			label1.Location = new Point(542, 41);
			label1.Name = "label1";
			label1.Size = new Size(32, 19);
			label1.TabIndex = 4;
			label1.Text = "руб";
			label1.Click += openProductFrom;
			// 
			// BasketItem
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			Controls.Add(label1);
			Controls.Add(itemCost);
			Controls.Add(btnDel);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(itemPictureBox);
			Name = "BasketItem";
			Size = new Size(745, 98);
			Click += openProductFrom;
			((System.ComponentModel.ISupportInitialize)itemPictureBox).EndInit();
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox itemPictureBox;
		private FlowLayoutPanel flowLayoutPanel1;
		private Label itemName;
		private Button btnDel;
		private Label itemCost;
		private Label label1;
	}
}
