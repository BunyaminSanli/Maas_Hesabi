namespace NdpOdev1._2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalisanTextBox = new System.Windows.Forms.RichTextBox();
            this.DosyaYolutextBox = new System.Windows.Forms.TextBox();
            this.CalisanView1 = new System.Windows.Forms.ListView();
            this.SecButton = new System.Windows.Forms.Button();
            this.TctextBox = new System.Windows.Forms.TextBox();
            this.SorgulaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalisanTextBox
            // 
            this.CalisanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalisanTextBox.Location = new System.Drawing.Point(15, 15);
            this.CalisanTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.CalisanTextBox.Name = "CalisanTextBox";
            this.CalisanTextBox.ReadOnly = true;
            this.CalisanTextBox.Size = new System.Drawing.Size(537, 173);
            this.CalisanTextBox.TabIndex = 0;
            this.CalisanTextBox.Text = "";
            this.CalisanTextBox.TextChanged += new System.EventHandler(this.CalisanTextBox_TextChanged);
            // 
            // DosyaYolutextBox
            // 
            this.DosyaYolutextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DosyaYolutextBox.Location = new System.Drawing.Point(567, 34);
            this.DosyaYolutextBox.Margin = new System.Windows.Forms.Padding(6);
            this.DosyaYolutextBox.Multiline = true;
            this.DosyaYolutextBox.Name = "DosyaYolutextBox";
            this.DosyaYolutextBox.ReadOnly = true;
            this.DosyaYolutextBox.Size = new System.Drawing.Size(180, 32);
            this.DosyaYolutextBox.TabIndex = 1;
            // 
            // CalisanView1
            // 
            this.CalisanView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CalisanView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalisanView1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CalisanView1.Location = new System.Drawing.Point(12, 197);
            this.CalisanView1.Name = "CalisanView1";
            this.CalisanView1.Size = new System.Drawing.Size(813, 192);
            this.CalisanView1.TabIndex = 2;
            this.CalisanView1.UseCompatibleStateImageBehavior = false;
            this.CalisanView1.View = System.Windows.Forms.View.Details;
            this.CalisanView1.SelectedIndexChanged += new System.EventHandler(this.CalisanView1_SelectedIndexChanged);
            // 
            // SecButton
            // 
            this.SecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SecButton.Location = new System.Drawing.Point(753, 34);
            this.SecButton.Name = "SecButton";
            this.SecButton.Size = new System.Drawing.Size(74, 32);
            this.SecButton.TabIndex = 3;
            this.SecButton.Text = "Seç";
            this.SecButton.UseVisualStyleBackColor = true;
            this.SecButton.Click += new System.EventHandler(this.SecButton_Click);
            // 
            // TctextBox
            // 
            this.TctextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TctextBox.Location = new System.Drawing.Point(567, 118);
            this.TctextBox.MaxLength = 11;
            this.TctextBox.Multiline = true;
            this.TctextBox.Name = "TctextBox";
            this.TctextBox.Size = new System.Drawing.Size(180, 29);
            this.TctextBox.TabIndex = 4;
            // 
            // SorgulaButton
            // 
            this.SorgulaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SorgulaButton.Location = new System.Drawing.Point(753, 118);
            this.SorgulaButton.Name = "SorgulaButton";
            this.SorgulaButton.Size = new System.Drawing.Size(74, 29);
            this.SorgulaButton.TabIndex = 5;
            this.SorgulaButton.Text = "Sorgula";
            this.SorgulaButton.UseVisualStyleBackColor = true;
            this.SorgulaButton.Click += new System.EventHandler(this.SorgulaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(620, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tc Giriniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SorgulaButton);
            this.Controls.Add(this.TctextBox);
            this.Controls.Add(this.SecButton);
            this.Controls.Add(this.CalisanView1);
            this.Controls.Add(this.DosyaYolutextBox);
            this.Controls.Add(this.CalisanTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Personel Bilgi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CalisanTextBox;
        private System.Windows.Forms.TextBox DosyaYolutextBox;
        private System.Windows.Forms.ListView CalisanView1;
        private System.Windows.Forms.Button SecButton;
        private System.Windows.Forms.TextBox TctextBox;
        private System.Windows.Forms.Button SorgulaButton;
        private System.Windows.Forms.Label label1;
    }
}

