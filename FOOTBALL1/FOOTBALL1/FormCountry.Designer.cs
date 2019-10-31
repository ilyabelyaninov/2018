namespace FOOTBALL1
{
    partial class FormCountry
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
            this.Labelpeoples = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1Partoftheworld = new System.Windows.Forms.ComboBox();
            this.textBox1Country = new System.Windows.Forms.TextBox();
            this.textBox1Peoples = new System.Windows.Forms.TextBox();
            this.textBox2Capital = new System.Windows.Forms.TextBox();
            this.textBox3Abbr = new System.Windows.Forms.TextBox();
            this.button1SAVE = new System.Windows.Forms.Button();
            this.button2CLOSE = new System.Windows.Forms.Button();
            this.cOUNTRIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.footballDataSet1 = new FOOTBALL1.FootballDataSet1();
            this.cOUNTRIESTableAdapter = new FOOTBALL1.FootballDataSet1TableAdapters.COUNTRIESTableAdapter();
            this.Pokazat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COUNTRY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POPULATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ABBR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAPITAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PART_OF_THE_WORLD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Страна:";
            // 
            // Labelpeoples
            // 
            this.Labelpeoples.AutoSize = true;
            this.Labelpeoples.Location = new System.Drawing.Point(26, 69);
            this.Labelpeoples.Name = "Labelpeoples";
            this.Labelpeoples.Size = new System.Drawing.Size(66, 14);
            this.Labelpeoples.TabIndex = 1;
            this.Labelpeoples.Text = "Население:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Аббревиатура страны:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Столица:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Часть света:";
            // 
            // comboBox1Partoftheworld
            // 
            this.comboBox1Partoftheworld.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1Partoftheworld.DisplayMember = "NAME_PART_OF_THE_WORLD";
            this.comboBox1Partoftheworld.FormattingEnabled = true;
            this.comboBox1Partoftheworld.Location = new System.Drawing.Point(98, 153);
            this.comboBox1Partoftheworld.Name = "comboBox1Partoftheworld";
            this.comboBox1Partoftheworld.Size = new System.Drawing.Size(289, 22);
            this.comboBox1Partoftheworld.TabIndex = 5;
            this.comboBox1Partoftheworld.SelectedIndexChanged += new System.EventHandler(this.comboBox1Partoftheworld_SelectedIndexChanged);
            // 
            // textBox1Country
            // 
            this.textBox1Country.BackColor = System.Drawing.Color.SandyBrown;
            this.textBox1Country.Location = new System.Drawing.Point(98, 37);
            this.textBox1Country.Name = "textBox1Country";
            this.textBox1Country.Size = new System.Drawing.Size(289, 23);
            this.textBox1Country.TabIndex = 6;
            this.textBox1Country.TextChanged += new System.EventHandler(this.textBox1Country_TextChanged);
            // 
            // textBox1Peoples
            // 
            this.textBox1Peoples.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1Peoples.Location = new System.Drawing.Point(98, 66);
            this.textBox1Peoples.Name = "textBox1Peoples";
            this.textBox1Peoples.Size = new System.Drawing.Size(289, 23);
            this.textBox1Peoples.TabIndex = 7;
            this.textBox1Peoples.TextChanged += new System.EventHandler(this.textBox1Peoples_TextChanged);
            // 
            // textBox2Capital
            // 
            this.textBox2Capital.BackColor = System.Drawing.Color.Bisque;
            this.textBox2Capital.Location = new System.Drawing.Point(98, 124);
            this.textBox2Capital.Name = "textBox2Capital";
            this.textBox2Capital.Size = new System.Drawing.Size(289, 23);
            this.textBox2Capital.TabIndex = 8;
            this.textBox2Capital.TextChanged += new System.EventHandler(this.textBox2Capital_TextChanged);
            // 
            // textBox3Abbr
            // 
            this.textBox3Abbr.Location = new System.Drawing.Point(141, 95);
            this.textBox3Abbr.Name = "textBox3Abbr";
            this.textBox3Abbr.Size = new System.Drawing.Size(84, 23);
            this.textBox3Abbr.TabIndex = 9;
            this.textBox3Abbr.TextChanged += new System.EventHandler(this.textBox3Abbr_TextChanged);
            // 
            // button1SAVE
            // 
            this.button1SAVE.BackColor = System.Drawing.Color.LimeGreen;
            this.button1SAVE.Location = new System.Drawing.Point(656, 5);
            this.button1SAVE.Name = "button1SAVE";
            this.button1SAVE.Size = new System.Drawing.Size(72, 24);
            this.button1SAVE.TabIndex = 10;
            this.button1SAVE.Text = "Сохранить";
            this.button1SAVE.UseVisualStyleBackColor = false;
            this.button1SAVE.Click += new System.EventHandler(this.button1SAVE_Click);
            // 
            // button2CLOSE
            // 
            this.button2CLOSE.BackColor = System.Drawing.Color.Red;
            this.button2CLOSE.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2CLOSE.Location = new System.Drawing.Point(734, 5);
            this.button2CLOSE.Name = "button2CLOSE";
            this.button2CLOSE.Size = new System.Drawing.Size(65, 24);
            this.button2CLOSE.TabIndex = 11;
            this.button2CLOSE.Text = "Закрыть";
            this.button2CLOSE.UseVisualStyleBackColor = false;
            this.button2CLOSE.Click += new System.EventHandler(this.button2CLOSE_Click);
            // 
            // cOUNTRIESBindingSource
            // 
            this.cOUNTRIESBindingSource.DataMember = "COUNTRIES";
            this.cOUNTRIESBindingSource.DataSource = this.footballDataSet1;
            // 
            // footballDataSet1
            // 
            this.footballDataSet1.DataSetName = "FootballDataSet1";
            this.footballDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOUNTRIESTableAdapter
            // 
            this.cOUNTRIESTableAdapter.ClearBeforeFill = true;
            // 
            // Pokazat
            // 
            this.Pokazat.Location = new System.Drawing.Point(314, 201);
            this.Pokazat.Name = "Pokazat";
            this.Pokazat.Size = new System.Drawing.Size(143, 23);
            this.Pokazat.TabIndex = 13;
            this.Pokazat.Text = "Показать данные";
            this.Pokazat.UseVisualStyleBackColor = true;
            this.Pokazat.Click += new System.EventHandler(this.Pokazat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.COUNTRY,
            this.POPULATION,
            this.ABBR,
            this.CAPITAL,
            this.PART_OF_THE_WORLD});
            this.dataGridView1.Location = new System.Drawing.Point(49, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 150);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID_COUNTRY";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // COUNTRY
            // 
            this.COUNTRY.DataPropertyName = "NAME_COUNTRY";
            this.COUNTRY.HeaderText = "COUNTRY";
            this.COUNTRY.Name = "COUNTRY";
            // 
            // POPULATION
            // 
            this.POPULATION.DataPropertyName = "POPULATION_COUNTRY";
            this.POPULATION.HeaderText = "POPULATION";
            this.POPULATION.Name = "POPULATION";
            // 
            // ABBR
            // 
            this.ABBR.DataPropertyName = "ABBR_COUNTRY";
            this.ABBR.HeaderText = "ABBR";
            this.ABBR.Name = "ABBR";
            // 
            // CAPITAL
            // 
            this.CAPITAL.DataPropertyName = "CAPITAL_COUNTRY";
            this.CAPITAL.HeaderText = "CAPITAL";
            this.CAPITAL.Name = "CAPITAL";
            // 
            // PART_OF_THE_WORLD
            // 
            this.PART_OF_THE_WORLD.DataPropertyName = "ID_PART_OF_THE_WORLD";
            this.PART_OF_THE_WORLD.HeaderText = "PART_OF_THE_WORLD";
            this.PART_OF_THE_WORLD.Name = "PART_OF_THE_WORLD";
            // 
            // FormCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 426);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Pokazat);
            this.Controls.Add(this.button2CLOSE);
            this.Controls.Add(this.button1SAVE);
            this.Controls.Add(this.textBox3Abbr);
            this.Controls.Add(this.textBox2Capital);
            this.Controls.Add(this.textBox1Peoples);
            this.Controls.Add(this.textBox1Country);
            this.Controls.Add(this.comboBox1Partoftheworld);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Labelpeoples);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormCountry";
            this.Text = "Страны";
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Labelpeoples;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1Partoftheworld;
        private System.Windows.Forms.TextBox textBox1Country;
        private System.Windows.Forms.TextBox textBox1Peoples;
        private System.Windows.Forms.TextBox textBox2Capital;
        private System.Windows.Forms.TextBox textBox3Abbr;
        private System.Windows.Forms.Button button1SAVE;
        private System.Windows.Forms.Button button2CLOSE;
        private FootballDataSet1 footballDataSet1;
        private System.Windows.Forms.BindingSource cOUNTRIESBindingSource;
        private FootballDataSet1TableAdapters.COUNTRIESTableAdapter cOUNTRIESTableAdapter;
        private System.Windows.Forms.Button Pokazat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COUNTRY;
        private System.Windows.Forms.DataGridViewTextBoxColumn POPULATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ABBR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAPITAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PART_OF_THE_WORLD;
    }
}