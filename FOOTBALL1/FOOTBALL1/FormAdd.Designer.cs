namespace FOOTBALL1
{
    partial class FormAdd
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
            this.comboBoxLeague = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.textBoxStadium = new System.Windows.Forms.TextBox();
            this.textBoxClub = new System.Windows.Forms.TextBox();
            this.textBoxBudget = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1Save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1Rating = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewFootballClubs = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMECLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUDGET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STADIUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPENING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RATING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPokazatDannye = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFootballClubs)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLeague
            // 
            this.comboBoxLeague.BackColor = System.Drawing.Color.MistyRose;
            this.comboBoxLeague.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxLeague.DisplayMember = "NAME_LEAGUE";
            this.comboBoxLeague.FormattingEnabled = true;
            this.comboBoxLeague.Location = new System.Drawing.Point(74, 144);
            this.comboBoxLeague.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLeague.Name = "comboBoxLeague";
            this.comboBoxLeague.Size = new System.Drawing.Size(337, 22);
            this.comboBoxLeague.TabIndex = 0;
            this.comboBoxLeague.SelectedIndexChanged += new System.EventHandler(this.comboBoxLeague_SelectedIndexChanged);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxCity.DisplayMember = "NAME_CITY";
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(74, 114);
            this.comboBoxCity.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(337, 22);
            this.comboBoxCity.TabIndex = 1;
            this.comboBoxCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // textBoxStadium
            // 
            this.textBoxStadium.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxStadium.Location = new System.Drawing.Point(74, 86);
            this.textBoxStadium.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStadium.Name = "textBoxStadium";
            this.textBoxStadium.Size = new System.Drawing.Size(337, 23);
            this.textBoxStadium.TabIndex = 2;
            this.textBoxStadium.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxStadium.TextChanged += new System.EventHandler(this.textBoxStadium_TextChanged);
            // 
            // textBoxClub
            // 
            this.textBoxClub.Location = new System.Drawing.Point(74, 28);
            this.textBoxClub.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxClub.Name = "textBoxClub";
            this.textBoxClub.Size = new System.Drawing.Size(337, 23);
            this.textBoxClub.TabIndex = 3;
            this.textBoxClub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxClub.TextChanged += new System.EventHandler(this.textBoxClub_TextChanged);
            // 
            // textBoxBudget
            // 
            this.textBoxBudget.BackColor = System.Drawing.Color.Thistle;
            this.textBoxBudget.Location = new System.Drawing.Point(74, 55);
            this.textBoxBudget.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBudget.Name = "textBoxBudget";
            this.textBoxBudget.Size = new System.Drawing.Size(337, 23);
            this.textBoxBudget.TabIndex = 5;
            this.textBoxBudget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBudget.TextChanged += new System.EventHandler(this.textBoxBudget_TextChanged);
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxYear.Location = new System.Drawing.Point(155, 172);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(116, 23);
            this.textBoxYear.TabIndex = 6;
            this.textBoxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Клуб:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Бюджет:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Стадион:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Город:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Лига:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Год создания:";
            // 
            // button1Save
            // 
            this.button1Save.BackColor = System.Drawing.Color.LimeGreen;
            this.button1Save.Location = new System.Drawing.Point(340, 0);
            this.button1Save.Name = "button1Save";
            this.button1Save.Size = new System.Drawing.Size(71, 21);
            this.button1Save.TabIndex = 13;
            this.button1Save.Text = "Сохранить";
            this.button1Save.UseVisualStyleBackColor = false;
            this.button1Save.Click += new System.EventHandler(this.button1Save_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(417, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 21);
            this.button2.TabIndex = 14;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1Rating
            // 
            this.textBox1Rating.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox1Rating.Location = new System.Drawing.Point(71, 203);
            this.textBox1Rating.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1Rating.Name = "textBox1Rating";
            this.textBox1Rating.Size = new System.Drawing.Size(340, 23);
            this.textBox1Rating.TabIndex = 15;
            this.textBox1Rating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1Rating.TextChanged += new System.EventHandler(this.textBox1Rating_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "Рейтинг:";
            // 
            // dataGridViewFootballClubs
            // 
            this.dataGridViewFootballClubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFootballClubs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NAMECLUB,
            this.BUDGET,
            this.STADIUM,
            this.OPENING,
            this.RATING});
            this.dataGridViewFootballClubs.Location = new System.Drawing.Point(12, 289);
            this.dataGridViewFootballClubs.Name = "dataGridViewFootballClubs";
            this.dataGridViewFootballClubs.Size = new System.Drawing.Size(739, 150);
            this.dataGridViewFootballClubs.TabIndex = 17;
            this.dataGridViewFootballClubs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFootballClubs_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID_CLUB";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // NAMECLUB
            // 
            this.NAMECLUB.DataPropertyName = "NAME_CLUB";
            this.NAMECLUB.HeaderText = "NAME";
            this.NAMECLUB.Name = "NAMECLUB";
            // 
            // BUDGET
            // 
            this.BUDGET.DataPropertyName = "BUDGET_CLUB";
            this.BUDGET.HeaderText = "BUDGET";
            this.BUDGET.Name = "BUDGET";
            // 
            // STADIUM
            // 
            this.STADIUM.DataPropertyName = "STADIUM_CLUB";
            this.STADIUM.HeaderText = "STADIUM";
            this.STADIUM.Name = "STADIUM";
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
            // buttonPokazatDannye
            // 
            this.buttonPokazatDannye.Location = new System.Drawing.Point(170, 260);
            this.buttonPokazatDannye.Name = "buttonPokazatDannye";
            this.buttonPokazatDannye.Size = new System.Drawing.Size(145, 23);
            this.buttonPokazatDannye.TabIndex = 18;
            this.buttonPokazatDannye.Text = "Показать данные";
            this.buttonPokazatDannye.UseVisualStyleBackColor = true;
            this.buttonPokazatDannye.Click += new System.EventHandler(this.buttonPokazatDannye_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 451);
            this.Controls.Add(this.buttonPokazatDannye);
            this.Controls.Add(this.dataGridViewFootballClubs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1Rating);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1Save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxBudget);
            this.Controls.Add(this.textBoxClub);
            this.Controls.Add(this.textBoxStadium);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.comboBoxLeague);
            this.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdd";
            this.Text = "Клубы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFootballClubs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLeague;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.TextBox textBoxStadium;
        private System.Windows.Forms.TextBox textBoxClub;
        private System.Windows.Forms.TextBox textBoxBudget;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1Save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1Rating;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewFootballClubs;
        private System.Windows.Forms.Button buttonPokazatDannye;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMECLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUDGET;
        private System.Windows.Forms.DataGridViewTextBoxColumn STADIUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPENING;
        private System.Windows.Forms.DataGridViewTextBoxColumn RATING;
    }
}