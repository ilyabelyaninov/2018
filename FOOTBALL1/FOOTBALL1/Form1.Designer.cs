namespace FOOTBALL1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2Country = new System.Windows.Forms.Button();
            this.button2LEAGUE = new System.Windows.Forms.Button();
            this.button2PART = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STADIUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUDGET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPENING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RATING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LEAGUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_COUNTRY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_LEAGUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Country_l = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAdd.Location = new System.Drawing.Point(26, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ДОБАВИТЬ КЛУБ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Location = new System.Drawing.Point(178, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ДОБАВИТЬ ГОРОД";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2Country
            // 
            this.button2Country.BackColor = System.Drawing.Color.LightBlue;
            this.button2Country.Location = new System.Drawing.Point(329, 12);
            this.button2Country.Name = "button2Country";
            this.button2Country.Size = new System.Drawing.Size(150, 23);
            this.button2Country.TabIndex = 3;
            this.button2Country.Text = "ДОБАВИТЬ СТРАНУ";
            this.button2Country.UseVisualStyleBackColor = false;
            this.button2Country.Click += new System.EventHandler(this.button2Country_Click);
            // 
            // button2LEAGUE
            // 
            this.button2LEAGUE.BackColor = System.Drawing.Color.Thistle;
            this.button2LEAGUE.Location = new System.Drawing.Point(485, 12);
            this.button2LEAGUE.Name = "button2LEAGUE";
            this.button2LEAGUE.Size = new System.Drawing.Size(155, 23);
            this.button2LEAGUE.TabIndex = 4;
            this.button2LEAGUE.Text = "ДОБАВИТЬ ЛИГУ";
            this.button2LEAGUE.UseVisualStyleBackColor = false;
            this.button2LEAGUE.Click += new System.EventHandler(this.button2LEAGUE_Click);
            // 
            // button2PART
            // 
            this.button2PART.BackColor = System.Drawing.Color.GreenYellow;
            this.button2PART.Location = new System.Drawing.Point(646, 12);
            this.button2PART.Name = "button2PART";
            this.button2PART.Size = new System.Drawing.Size(153, 23);
            this.button2PART.TabIndex = 5;
            this.button2PART.Text = "ДОБАВИТЬ ЧАСТЬ СВЕТА";
            this.button2PART.UseVisualStyleBackColor = false;
            this.button2PART.Click += new System.EventHandler(this.button2PART_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CLUB,
            this.STADIUM,
            this.BUDGET,
            this.OPENING,
            this.RATING,
            this.LEAGUE,
            this.CITY,
            this.ID_CITY,
            this.ID_COUNTRY,
            this.ID_LEAGUE,
            this.ID_Country_l});
            this.dataGridView2.Location = new System.Drawing.Point(26, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(773, 397);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID_CLUB";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // CLUB
            // 
            this.CLUB.DataPropertyName = "NAME_CLUB";
            this.CLUB.HeaderText = "CLUB";
            this.CLUB.Name = "CLUB";
            // 
            // STADIUM
            // 
            this.STADIUM.DataPropertyName = "STADIUM_CLUB";
            this.STADIUM.HeaderText = "STADIUM";
            this.STADIUM.Name = "STADIUM";
            // 
            // BUDGET
            // 
            this.BUDGET.DataPropertyName = "BUDGET_CLUB";
            this.BUDGET.HeaderText = "BUDGET";
            this.BUDGET.Name = "BUDGET";
            // 
            // OPENING
            // 
            this.OPENING.DataPropertyName = "OPENING_DATE_CLUB";
            this.OPENING.HeaderText = "OPENING";
            this.OPENING.Name = "OPENING";
            // 
            // RATING
            // 
            this.RATING.DataPropertyName = "RATING_CLUB";
            this.RATING.HeaderText = "RATING";
            this.RATING.Name = "RATING";
            // 
            // LEAGUE
            // 
            this.LEAGUE.DataPropertyName = "Leagues.league.NAME_LEAGUE";
            this.LEAGUE.HeaderText = "LEAGUE";
            this.LEAGUE.Name = "LEAGUE";
            this.LEAGUE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CITY
            // 
            this.CITY.DataPropertyName = "City.NAME_CITY";
            this.CITY.HeaderText = "CITY";
            this.CITY.Name = "CITY";
            this.CITY.Visible = false;
            // 
            // ID_CITY
            // 
            this.ID_CITY.DataPropertyName = "city.ID_CITY";
            this.ID_CITY.HeaderText = "ID_CITY";
            this.ID_CITY.Name = "ID_CITY";
            this.ID_CITY.Visible = false;
            // 
            // ID_COUNTRY
            // 
            this.ID_COUNTRY.DataPropertyName = "city.ID_COUNTY";
            this.ID_COUNTRY.HeaderText = "ID_COUNTRY";
            this.ID_COUNTRY.Name = "ID_COUNTRY";
            this.ID_COUNTRY.Visible = false;
            // 
            // ID_LEAGUE
            // 
            this.ID_LEAGUE.DataPropertyName = "league.ID_LEAGUE";
            this.ID_LEAGUE.HeaderText = "ID_LEAGUE";
            this.ID_LEAGUE.Name = "ID_LEAGUE";
            this.ID_LEAGUE.Visible = false;
            // 
            // ID_Country_l
            // 
            this.ID_Country_l.DataPropertyName = "league.ID_COUNTY";
            this.ID_Country_l.HeaderText = "ID_COUNTRY_LEAGUE";
            this.ID_Country_l.Name = "ID_Country_l";
            this.ID_Country_l.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 458);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2PART);
            this.Controls.Add(this.button2LEAGUE);
            this.Controls.Add(this.button2Country);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Главное окно программы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2Country;
        private System.Windows.Forms.Button button2LEAGUE;
        private System.Windows.Forms.Button button2PART;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn STADIUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUDGET;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPENING;
        private System.Windows.Forms.DataGridViewTextBoxColumn RATING;
        private System.Windows.Forms.DataGridViewTextBoxColumn LEAGUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_COUNTRY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_LEAGUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Country_l;
    }
}

