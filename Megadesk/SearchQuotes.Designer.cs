namespace Megadesk
{
    partial class SearchQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthQuote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthQuote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.desktopMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.customerName,
            this.quoteDate,
            this.widthQuote,
            this.depthQuote,
            this.drawers,
            this.material,
            this.total});
            this.dataGridView1.Location = new System.Drawing.Point(33, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(911, 304);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nro
            // 
            this.Nro.HeaderText = "Nro";
            this.Nro.Name = "Nro";
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            // 
            // quoteDate
            // 
            this.quoteDate.HeaderText = "Date";
            this.quoteDate.Name = "quoteDate";
            // 
            // widthQuote
            // 
            this.widthQuote.HeaderText = "Width";
            this.widthQuote.Name = "widthQuote";
            // 
            // depthQuote
            // 
            this.depthQuote.HeaderText = "Depth";
            this.depthQuote.Name = "depthQuote";
            // 
            // drawers
            // 
            this.drawers.HeaderText = "Drawers";
            this.drawers.Name = "drawers";
            // 
            // material
            // 
            this.material.HeaderText = "Material";
            this.material.Name = "material";
            // 
            // total
            // 
            this.total.HeaderText = "Total cost ($)";
            this.total.Name = "total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Quote";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.IndianRed;
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(793, 442);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(151, 43);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Main Menu";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // desktopMaterialComboBox
            // 
            this.desktopMaterialComboBox.AccessibleDescription = "";
            this.desktopMaterialComboBox.FormattingEnabled = true;
            this.desktopMaterialComboBox.Location = new System.Drawing.Point(175, 78);
            this.desktopMaterialComboBox.Name = "desktopMaterialComboBox";
            this.desktopMaterialComboBox.Size = new System.Drawing.Size(169, 21);
            this.desktopMaterialComboBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(108, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Material:";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.LightGreen;
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(365, 66);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(151, 43);
            this.save.TabIndex = 23;
            this.save.Text = "Search";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 509);
            this.Controls.Add(this.save);
            this.Controls.Add(this.desktopMaterialComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuote";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox desktopMaterialComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthQuote;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthQuote;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}