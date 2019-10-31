namespace FOOTBALL1
{
    partial class FormCity
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
            this.textBoxCity1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.button1Save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COUNTRYID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1Pokazatdannie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCity1
            // 
            this.textBoxCity1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCity1.Location = new System.Drawing.Point(70, 47);
            this.textBoxCity1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCity1.Name = "textBoxCity1";
            this.textBoxCity1.Size = new System.Drawing.Size(261, 23);
            this.textBoxCity1.TabIndex = 0;
            this.textBoxCity1.TextChanged += new System.EventHandler(this.textBoxCity1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Город:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Страна:";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.BackColor = System.Drawing.Color.SandyBrown;
            this.comboBoxCountry.DisplayMember = "NAME_COUNTRY";
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(70, 83);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(261, 22);
            this.comboBoxCountry.TabIndex = 3;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // button1Save
            // 
            this.button1Save.BackColor = System.Drawing.Color.LimeGreen;
            this.button1Save.Location = new System.Drawing.Point(260, 1);
            this.button1Save.Name = "button1Save";
            this.button1Save.Size = new System.Drawing.Size(71, 21);
            this.button1Save.TabIndex = 14;
            this.button1Save.Text = "Сохранить";
            this.button1Save.UseVisualStyleBackColor = false;
            this.button1Save.Click += new System.EventHandler(this.button1Save_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(337, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 21);
            this.button2.TabIndex = 15;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.CITY,
            this.COUNTRYID});
            this.dataGridView1.Location = new System.Drawing.Point(25, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(337, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID_CITY";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // CITY
            // 
            this.CITY.DataPropertyName = "NAME_CITY";
            this.CITY.HeaderText = "CITY";
            this.CITY.Name = "CITY";
            // 
            // COUNTRYID
            // 
            this.COUNTRYID.DataPropertyName = "ID_COUNTRY";
            this.COUNTRYID.HeaderText = "COUNTRY";
            this.COUNTRYID.Name = "COUNTRYID";
            // 
            // button1Pokazatdannie
            // 
            this.button1Pokazatdannie.Location = new System.Drawing.Point(135, 115);
            this.button1Pokazatdannie.Name = "button1Pokazatdannie";
            this.button1Pokazatdannie.Size = new System.Drawing.Size(141, 23);
            this.button1Pokazatdannie.TabIndex = 17;
            this.button1Pokazatdannie.Text = "Показать данные";
            this.button1Pokazatdannie.UseVisualStyleBackColor = true;
            this.button1Pokazatdannie.Click += new System.EventHandler(this.button1Pokazatdannie_Click);
            // 
            // FormCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 306);
            this.Controls.Add(this.button1Pokazatdannie);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1Save);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCity1);
            this.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormCity";
            this.Text = "Города";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCity1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Button button1Save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1Pokazatdannie;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn COUNTRYID;
    }
}