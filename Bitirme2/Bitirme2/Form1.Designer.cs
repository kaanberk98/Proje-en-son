namespace Bitirme2
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
            this.dgwBilgiler = new System.Windows.Forms.DataGridView();
            this.lblname = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.tbxsurname = new System.Windows.Forms.TextBox();
            this.tbxage = new System.Windows.Forms.TextBox();
            this.tbxcity = new System.Windows.Forms.TextBox();
            this.gbxEkle = new System.Windows.Forms.GroupBox();
            this.tbxtc = new System.Windows.Forms.TextBox();
            this.lbltc = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnRnd = new System.Windows.Forms.Button();
            this.lbldob = new System.Windows.Forms.Label();
            this.tbxbirthday = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBilgiler)).BeginInit();
            this.gbxEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwBilgiler
            // 
            this.dgwBilgiler.AllowUserToAddRows = false;
            this.dgwBilgiler.AllowUserToDeleteRows = false;
            this.dgwBilgiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBilgiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBilgiler.Location = new System.Drawing.Point(12, 12);
            this.dgwBilgiler.Name = "dgwBilgiler";
            this.dgwBilgiler.ReadOnly = true;
            this.dgwBilgiler.RowHeadersWidth = 51;
            this.dgwBilgiler.RowTemplate.Height = 24;
            this.dgwBilgiler.Size = new System.Drawing.Size(776, 247);
            this.dgwBilgiler.TabIndex = 0;
            this.dgwBilgiler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBilgiler_CellClick);
            this.dgwBilgiler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBilgiler_CellContentClick);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblname.Location = new System.Drawing.Point(18, 32);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(52, 18);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsurname.Location = new System.Drawing.Point(18, 75);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(75, 18);
            this.lblsurname.TabIndex = 2;
            this.lblsurname.Text = "Surname";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblage.Location = new System.Drawing.Point(18, 119);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(36, 18);
            this.lblage.TabIndex = 3;
            this.lblage.Text = "Age";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcity.Location = new System.Drawing.Point(18, 208);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(37, 18);
            this.lblcity.TabIndex = 5;
            this.lblcity.Text = "City";
            // 
            // tbxname
            // 
            this.tbxname.Location = new System.Drawing.Point(145, 26);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(197, 27);
            this.tbxname.TabIndex = 6;
            // 
            // tbxsurname
            // 
            this.tbxsurname.Location = new System.Drawing.Point(145, 64);
            this.tbxsurname.Name = "tbxsurname";
            this.tbxsurname.Size = new System.Drawing.Size(197, 27);
            this.tbxsurname.TabIndex = 7;
            // 
            // tbxage
            // 
            this.tbxage.Location = new System.Drawing.Point(145, 110);
            this.tbxage.Name = "tbxage";
            this.tbxage.Size = new System.Drawing.Size(197, 27);
            this.tbxage.TabIndex = 8;
            // 
            // tbxcity
            // 
            this.tbxcity.Location = new System.Drawing.Point(145, 199);
            this.tbxcity.Name = "tbxcity";
            this.tbxcity.Size = new System.Drawing.Size(197, 27);
            this.tbxcity.TabIndex = 10;
            // 
            // gbxEkle
            // 
            this.gbxEkle.Controls.Add(this.tbxbirthday);
            this.gbxEkle.Controls.Add(this.lbldob);
            this.gbxEkle.Controls.Add(this.tbxtc);
            this.gbxEkle.Controls.Add(this.lbltc);
            this.gbxEkle.Controls.Add(this.btnekle);
            this.gbxEkle.Controls.Add(this.tbxcity);
            this.gbxEkle.Controls.Add(this.lblname);
            this.gbxEkle.Controls.Add(this.lblsurname);
            this.gbxEkle.Controls.Add(this.tbxage);
            this.gbxEkle.Controls.Add(this.lblage);
            this.gbxEkle.Controls.Add(this.tbxsurname);
            this.gbxEkle.Controls.Add(this.tbxname);
            this.gbxEkle.Controls.Add(this.lblcity);
            this.gbxEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxEkle.Location = new System.Drawing.Point(12, 293);
            this.gbxEkle.Name = "gbxEkle";
            this.gbxEkle.Size = new System.Drawing.Size(543, 298);
            this.gbxEkle.TabIndex = 11;
            this.gbxEkle.TabStop = false;
            this.gbxEkle.Text = "Bilgi Ekle";
            // 
            // tbxtc
            // 
            this.tbxtc.Location = new System.Drawing.Point(145, 153);
            this.tbxtc.Name = "tbxtc";
            this.tbxtc.Size = new System.Drawing.Size(197, 27);
            this.tbxtc.TabIndex = 14;
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(17, 160);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(30, 20);
            this.lbltc.TabIndex = 13;
            this.lbltc.Text = "Tc";
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(414, 32);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 34);
            this.btnekle.TabIndex = 12;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.Location = new System.Drawing.Point(361, 597);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 31);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.Location = new System.Drawing.Point(636, 293);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(85, 34);
            this.btngüncelle.TabIndex = 12;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnRnd
            // 
            this.btnRnd.Location = new System.Drawing.Point(576, 357);
            this.btnRnd.Name = "btnRnd";
            this.btnRnd.Size = new System.Drawing.Size(193, 33);
            this.btnRnd.TabIndex = 13;
            this.btnRnd.Text = "Random Güncelle";
            this.btnRnd.UseVisualStyleBackColor = true;
            this.btnRnd.Click += new System.EventHandler(this.btnRnd_Click);
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(21, 255);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(118, 20);
            this.lbldob.TabIndex = 15;
            this.lbldob.Text = "Date of Birth";
            // 
            // tbxbirthday
            // 
            this.tbxbirthday.Location = new System.Drawing.Point(145, 248);
            this.tbxbirthday.Name = "tbxbirthday";
            this.tbxbirthday.Size = new System.Drawing.Size(197, 27);
            this.tbxbirthday.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 629);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnRnd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxEkle);
            this.Controls.Add(this.dgwBilgiler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBilgiler)).EndInit();
            this.gbxEkle.ResumeLayout(false);
            this.gbxEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBilgiler;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.TextBox tbxsurname;
        private System.Windows.Forms.TextBox tbxage;
        private System.Windows.Forms.TextBox tbxcity;
        private System.Windows.Forms.GroupBox gbxEkle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbxtc;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnRnd;
        private System.Windows.Forms.TextBox tbxbirthday;
        private System.Windows.Forms.Label lbldob;
    }
}

