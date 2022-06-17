namespace Ornekproje
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbAddName = new System.Windows.Forms.TextBox();
            this.lblAddName = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.lblAddStockAmount = new System.Windows.Forms.Label();
            this.txbAddStockAmount = new System.Windows.Forms.TextBox();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.lblUpdateStockAmount = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txbUpdateStockAmount = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.txbUpdateName = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(435, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(330, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 54);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbAddName
            // 
            this.txbAddName.Location = new System.Drawing.Point(130, 35);
            this.txbAddName.Multiline = true;
            this.txbAddName.Name = "txbAddName";
            this.txbAddName.Size = new System.Drawing.Size(188, 20);
            this.txbAddName.TabIndex = 4;
            this.txbAddName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddName.Location = new System.Drawing.Point(32, 33);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(51, 20);
            this.lblAddName.TabIndex = 5;
            this.lblAddName.Text = "Name";
            this.lblAddName.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.lblAddStockAmount);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.txbAddStockAmount);
            this.gbxAdd.Controls.Add(this.lblAddName);
            this.gbxAdd.Controls.Add(this.txbAddName);
            this.gbxAdd.Location = new System.Drawing.Point(12, 24);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(417, 118);
            this.gbxAdd.TabIndex = 6;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Stock";
            this.gbxAdd.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblAddStockAmount
            // 
            this.lblAddStockAmount.AutoSize = true;
            this.lblAddStockAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddStockAmount.Location = new System.Drawing.Point(6, 69);
            this.lblAddStockAmount.Name = "lblAddStockAmount";
            this.lblAddStockAmount.Size = new System.Drawing.Size(110, 20);
            this.lblAddStockAmount.TabIndex = 7;
            this.lblAddStockAmount.Text = "Stock Amount";
            // 
            // txbAddStockAmount
            // 
            this.txbAddStockAmount.Location = new System.Drawing.Point(130, 69);
            this.txbAddStockAmount.Multiline = true;
            this.txbAddStockAmount.Name = "txbAddStockAmount";
            this.txbAddStockAmount.Size = new System.Drawing.Size(188, 20);
            this.txbAddStockAmount.TabIndex = 6;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.lblUpdateStockAmount);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.txbUpdateStockAmount);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Controls.Add(this.txbUpdateName);
            this.gbxUpdate.Location = new System.Drawing.Point(12, 173);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(417, 118);
            this.gbxUpdate.TabIndex = 8;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update Stocks";
            // 
            // lblUpdateStockAmount
            // 
            this.lblUpdateStockAmount.AutoSize = true;
            this.lblUpdateStockAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateStockAmount.Location = new System.Drawing.Point(6, 69);
            this.lblUpdateStockAmount.Name = "lblUpdateStockAmount";
            this.lblUpdateStockAmount.Size = new System.Drawing.Size(110, 20);
            this.lblUpdateStockAmount.TabIndex = 7;
            this.lblUpdateStockAmount.Text = "Stock Amount";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(330, 35);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 54);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txbUpdateStockAmount
            // 
            this.txbUpdateStockAmount.Location = new System.Drawing.Point(130, 69);
            this.txbUpdateStockAmount.Multiline = true;
            this.txbUpdateStockAmount.Name = "txbUpdateStockAmount";
            this.txbUpdateStockAmount.Size = new System.Drawing.Size(188, 20);
            this.txbUpdateStockAmount.TabIndex = 6;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameUpdate.Location = new System.Drawing.Point(32, 33);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(51, 20);
            this.lblNameUpdate.TabIndex = 5;
            this.lblNameUpdate.Text = "Name";
            // 
            // txbUpdateName
            // 
            this.txbUpdateName.Location = new System.Drawing.Point(130, 35);
            this.txbUpdateName.Multiline = true;
            this.txbUpdateName.Name = "txbUpdateName";
            this.txbUpdateName.Size = new System.Drawing.Size(188, 20);
            this.txbUpdateName.TabIndex = 4;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(142, 339);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(139, 58);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Delete Stock";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbAddName;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Label lblAddStockAmount;
        private System.Windows.Forms.TextBox txbAddStockAmount;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Label lblUpdateStockAmount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbUpdateStockAmount;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.TextBox txbUpdateName;
        private System.Windows.Forms.Button btnRemove;
    }
}

