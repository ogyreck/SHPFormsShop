namespace FinalProject
{
	partial class BasketForm
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
			label1 = new Label();
			button1 = new Button();
			itemsBasketPanel = new Panel();
			btnTotalSum = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 20F);
			label1.Location = new Point(22, 19);
			label1.Name = "label1";
			label1.Size = new Size(123, 37);
			label1.TabIndex = 0;
			label1.Text = "Корзина";
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button1.Font = new Font("Segoe UI", 12F);
			button1.Location = new Point(685, 22);
			button1.Name = "button1";
			button1.Size = new Size(97, 41);
			button1.TabIndex = 1;
			button1.Text = "Назад";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// itemsBasketPanel
			// 
			itemsBasketPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			itemsBasketPanel.Location = new Point(21, 73);
			itemsBasketPanel.Name = "itemsBasketPanel";
			itemsBasketPanel.Size = new Size(762, 451);
			itemsBasketPanel.TabIndex = 2;
			// 
			// btnTotalSum
			// 
			btnTotalSum.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnTotalSum.Font = new Font("Segoe UI", 12F);
			btnTotalSum.Location = new Point(608, 555);
			btnTotalSum.Name = "btnTotalSum";
			btnTotalSum.Size = new Size(174, 39);
			btnTotalSum.TabIndex = 3;
			btnTotalSum.Text = "Общая сумма";
			btnTotalSum.UseVisualStyleBackColor = true;
			btnTotalSum.Click += btnTotalSum_Click;
			// 
			// BasketForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(806, 615);
			Controls.Add(btnTotalSum);
			Controls.Add(itemsBasketPanel);
			Controls.Add(button1);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "BasketForm";
			Text = "Корзина";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button button1;
		private Button btnTotalSum;
		public Panel itemsBasketPanel;
	}
}