namespace FinalProject
{
	partial class Form1
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
			label1 = new Label();
			btnOpenBasket = new Button();
			btnLoad = new Button();
			cardPanel = new Panel();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Left;
			label1.Font = new Font("Yu Gothic UI Semibold", 13F);
			label1.Location = new Point(0, 0);
			label1.Margin = new Padding(3, 13, 3, 0);
			label1.Name = "label1";
			label1.Size = new Size(206, 30);
			label1.TabIndex = 0;
			label1.Text = "Интернет магазин ";
			// 
			// btnOpenBasket
			// 
			btnOpenBasket.Dock = DockStyle.Top;
			btnOpenBasket.Font = new Font("Yu Gothic UI Semibold", 12F);
			btnOpenBasket.Location = new Point(206, 0);
			btnOpenBasket.Margin = new Padding(3, 4, 3, 4);
			btnOpenBasket.Name = "btnOpenBasket";
			btnOpenBasket.Size = new Size(1261, 53);
			btnOpenBasket.TabIndex = 1;
			btnOpenBasket.Text = "Корзина ";
			btnOpenBasket.UseVisualStyleBackColor = true;
			btnOpenBasket.Click += btnOpenBasket_Click;
			// 
			// btnLoad
			// 
			btnLoad.Dock = DockStyle.Bottom;
			btnLoad.Location = new Point(206, 877);
			btnLoad.Margin = new Padding(3, 4, 3, 4);
			btnLoad.Name = "btnLoad";
			btnLoad.Size = new Size(1261, 31);
			btnLoad.TabIndex = 3;
			btnLoad.Text = "Загрузить";
			btnLoad.UseVisualStyleBackColor = true;
			btnLoad.Click += btnLoad_Click;
			// 
			// cardPanel
			// 
			cardPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			cardPanel.Location = new Point(14, 76);
			cardPanel.Margin = new Padding(3, 4, 3, 4);
			cardPanel.Name = "cardPanel";
			cardPanel.Size = new Size(1440, 768);
			cardPanel.TabIndex = 4;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1467, 908);
			Controls.Add(cardPanel);
			Controls.Add(btnLoad);
			Controls.Add(btnOpenBasket);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(3, 4, 3, 4);
			Name = "Form1";
			Text = "Интернет магазин";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button btnOpenBasket;
		private Button btnLoad;
		private Panel cardPanel;
	}
}
