namespace FOOTBALL1
{
    partial class FormLeague
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1League = new System.Windows.Forms.TextBox();
            this.comboBox1AbCap = new System.Windows.Forms.ComboBox();
            this.button1saving = new System.Windows.Forms.Button();
            this.button2qiut = new System.Windows.Forms.Button();
            this.leaguesTableAdapter1 = new FOOTBALL1.FootballDataSetTableAdapters.LEAGUESTableAdapter();
            this.dataGridViewLEAGUE1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.League = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEAGUESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.footballDataSet2 = new FOOTBALL1.FootballDataSet2();
            this.lEAGUESTableAdapter = new FOOTBALL1.FootballDataSet2TableAdapters.LEAGUESTableAdapter();
            this.buttondannie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLEAGUE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEAGUESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лига:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Страна:";
            // 
            // textBox1League
            // 
            this.textBox1League.BackColor = System.Drawing.Color.LightBlue;
            this.textBox1League.Location = new System.Drawing.Point(55, 50);
            this.textBox1League.Name = "textBox1League";
            this.textBox1League.Size = new System.Drawing.Size(297, 23);
            this.textBox1League.TabIndex = 2;
            this.textBox1League.TextChanged += new System.EventHandler(this.textBox1League_TextChanged);
            // 
            // comboBox1AbCap
            // 
            this.comboBox1AbCap.DisplayMember = "NAME_COUNTRY";
            this.comboBox1AbCap.FormattingEnabled = true;
            this.comboBox1AbCap.Location = new System.Drawing.Point(55, 92);
            this.comboBox1AbCap.Name = "comboBox1AbCap";
            this.comboBox1AbCap.Size = new System.Drawing.Size(297, 22);
            this.comboBox1AbCap.TabIndex = 3;
            this.comboBox1AbCap.SelectedIndexChanged += new System.EventHandler(this.comboBox1AbCap_SelectedIndexChanged_1);
            // 
            // button1saving
            // 
            this.button1saving.BackColor = System.Drawing.Color.LimeGreen;
            this.button1saving.Location = new System.Drawing.Point(283, 12);
            this.button1saving.Name = "button1saving";
            this.button1saving.Size = new System.Drawing.Size(69, 25);
            this.button1saving.TabIndex = 4;
            this.button1saving.Text = "Сохранить";
            this.button1saving.UseVisualStyleBackColor = false;
            this.button1saving.Click += new System.EventHandler(this.button1saving_Click);
            // 
            // button2qiut
            // 
            this.button2qiut.BackColor = System.Drawing.Color.Red;
            this.button2qiut.Location = new System.Drawing.Point(358, 12);
            this.button2qiut.Name = "button2qiut";
            this.button2qiut.Size = new System.Drawing.Size(63, 25);
            this.button2qiut.TabIndex = 5;
            this.button2qiut.Text = "Закрыть";
            this.button2qiut.UseVisualStyleBackColor = false;
            this.button2qiut.Click += new System.EventHandler(this.button2qiut_Click);
            // 
            // leaguesTableAdapter1
            // 
            this.leaguesTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewLEAGUE1
            // 
            this.dataGridViewLEAGUE1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLEAGUE1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.League,
            this.Country});
            this.dataGridViewLEAGUE1.Location = new System.Drawing.Point(31, 151);
            this.dataGridViewLEAGUE1.Name = "dataGridViewLEAGUE1";
            this.dataGridViewLEAGUE1.Size = new System.Drawing.Size(345, 150);
            this.dataGridViewLEAGUE1.TabIndex = 6;
            this.dataGridViewLEAGUE1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLEAGUE1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID_LEAGUE";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // League
            // 
            this.League.DataPropertyName = "NAME_LEAGUE";
            this.League.HeaderText = "League";
            this.League.Name = "League";
            // 
            // Country
            // 
            this.Country.DataPropertyName = "ID_COUNTRY";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            // 
            // lEAGUESBindingSource
            // 
            this.lEAGUESBindingSource.DataMember = "LEAGUES";
            this.lEAGUESBindingSource.DataSource = this.footballDataSet2;
            // 
            // footballDataSet2
            // 
            this.footballDataSet2.DataSetName = "FootballDataSet2";
            this.footballDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lEAGUESTableAdapter
            // 
            this.lEAGUESTableAdapter.ClearBeforeFill = true;
            // 
            // buttondannie
            // 
            this.buttondannie.Location = new System.Drawing.Point(147, 307);
            this.buttondannie.Name = "buttondannie";
            this.buttondannie.Size = new System.Drawing.Size(123, 23);
            this.buttondannie.TabIndex = 7;
            this.buttondannie.Text = "Показать данные";
            this.buttondannie.UseVisualStyleBackColor = true;
            this.buttondannie.Click += new System.EventHandler(this.buttondannie_Click);
            // 
            // FormLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 351);
            this.Controls.Add(this.buttondannie);
            this.Controls.Add(this.dataGridViewLEAGUE1);
            this.Controls.Add(this.button2qiut);
            this.Controls.Add(this.button1saving);
            this.Controls.Add(this.comboBox1AbCap);
            this.Controls.Add(this.textBox1League);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormLeague";
            this.Text = "Лиги";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLEAGUE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEAGUESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1League;
        private System.Windows.Forms.ComboBox comboBox1AbCap;
        private System.Windows.Forms.Button button1saving;
        private System.Windows.Forms.Button button2qiut;
        private FootballDataSetTableAdapters.LEAGUESTableAdapter leaguesTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewLEAGUE1;
        private FootballDataSet2 footballDataSet2;
        private System.Windows.Forms.BindingSource lEAGUESBindingSource;
        private FootballDataSet2TableAdapters.LEAGUESTableAdapter lEAGUESTableAdapter;
        private System.Windows.Forms.Button buttondannie;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn League;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
    }
}