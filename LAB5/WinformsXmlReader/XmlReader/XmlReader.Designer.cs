
namespace XmlReader
{
    partial class XmlReader
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
            this.dataGridViewXml = new System.Windows.Forms.DataGridView();
            this.buttonFilePath = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameOfMovie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXml)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewXml
            // 
            this.dataGridViewXml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewXml.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXml.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfMovie,
            this.Producer,
            this.Date,
            this.Country,
            this.Price,
            this.Income,
            this.Profit});
            this.dataGridViewXml.Location = new System.Drawing.Point(0, 160);
            this.dataGridViewXml.MinimumSize = new System.Drawing.Size(1006, 497);
            this.dataGridViewXml.Name = "dataGridViewXml";
            this.dataGridViewXml.ReadOnly = true;
            this.dataGridViewXml.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewXml.RowTemplate.Height = 29;
            this.dataGridViewXml.Size = new System.Drawing.Size(1006, 497);
            this.dataGridViewXml.TabIndex = 0;
            this.dataGridViewXml.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewXml_CellContentClick);
            // 
            // buttonFilePath
            // 
            this.buttonFilePath.Location = new System.Drawing.Point(44, 12);
            this.buttonFilePath.Name = "buttonFilePath";
            this.buttonFilePath.Size = new System.Drawing.Size(197, 46);
            this.buttonFilePath.TabIndex = 1;
            this.buttonFilePath.Text = "Путь к файлу";
            this.buttonFilePath.UseVisualStyleBackColor = true;
            this.buttonFilePath.Click += new System.EventHandler(this.buttonFilePath_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(44, 82);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(197, 46);
            this.buttonAddNew.TabIndex = 2;
            this.buttonAddNew.Text = "Добавить фильм";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(247, 12);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(197, 46);
            this.buttonSaveChanges.TabIndex = 3;
            this.buttonSaveChanges.Text = "Сохранить";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(247, 82);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(197, 46);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Путь к файлу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // NameOfMovie
            // 
            this.NameOfMovie.HeaderText = "Название фильма";
            this.NameOfMovie.MinimumWidth = 6;
            this.NameOfMovie.Name = "NameOfMovie";
            this.NameOfMovie.ReadOnly = true;
            this.NameOfMovie.Width = 185;
            // 
            // Producer
            // 
            this.Producer.HeaderText = "Режисер";
            this.Producer.MinimumWidth = 8;
            this.Producer.Name = "Producer";
            this.Producer.ReadOnly = true;
            this.Producer.Width = 145;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата выхода";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // Country
            // 
            this.Country.HeaderText = "Страна выхода";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Стоймость";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Income
            // 
            this.Income.HeaderText = "Сборы";
            this.Income.MinimumWidth = 6;
            this.Income.Name = "Income";
            this.Income.ReadOnly = true;
            this.Income.Width = 125;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Прибыль";
            this.Profit.MinimumWidth = 6;
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            this.Profit.Width = 125;
            // 
            // XmlReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 657);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.buttonFilePath);
            this.Controls.Add(this.dataGridViewXml);
            this.MinimumSize = new System.Drawing.Size(1024, 704);
            this.Name = "XmlReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XmlReader";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXml)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DataGridViewXml_CellContentDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewXml;
        private System.Windows.Forms.Button buttonFilePath;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Income;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
    }
}

