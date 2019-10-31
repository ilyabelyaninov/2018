namespace FOOTBALL1
{
    partial class FormPartoftheworld
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
            this.button1Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1POKDANNIE = new System.Windows.Forms.Button();
            this.dgvPOW = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PART_OF_THE_WORLD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2Quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOW)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Save
            // 
            this.button1Save.BackColor = System.Drawing.Color.LimeGreen;
            this.button1Save.Location = new System.Drawing.Point(256, 12);
            this.button1Save.Name = "button1Save";
            this.button1Save.Size = new System.Drawing.Size(71, 25);
            this.button1Save.TabIndex = 0;
            this.button1Save.Text = "Сохранить";
            this.button1Save.UseVisualStyleBackColor = false;
            this.button1Save.Click += new System.EventHandler(this.button1Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Часть света:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Bisque;
            this.textBox1.Location = new System.Drawing.Point(93, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1POKDANNIE
            // 
            this.button1POKDANNIE.Location = new System.Drawing.Point(163, 120);
            this.button1POKDANNIE.Name = "button1POKDANNIE";
            this.button1POKDANNIE.Size = new System.Drawing.Size(110, 23);
            this.button1POKDANNIE.TabIndex = 5;
            this.button1POKDANNIE.Text = "Показать данные";
            this.button1POKDANNIE.UseVisualStyleBackColor = true;
            this.button1POKDANNIE.Click += new System.EventHandler(this.button1POKDANNIE_Click);
            // 
            // dgvPOW
            // 
            this.dgvPOW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PART_OF_THE_WORLD,
            this.Delete});
            this.dgvPOW.Location = new System.Drawing.Point(22, 149);
            this.dgvPOW.Name = "dgvPOW";
            this.dgvPOW.Size = new System.Drawing.Size(416, 150);
            this.dgvPOW.TabIndex = 6;
            this.dgvPOW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPOW_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID_PART_OF_THE_WORLD";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // PART_OF_THE_WORLD
            // 
            this.PART_OF_THE_WORLD.DataPropertyName = "NAME_PART_OF_THE_WORLD";
            this.PART_OF_THE_WORLD.HeaderText = "PART_OF_THE_WORLD";
            this.PART_OF_THE_WORLD.Name = "PART_OF_THE_WORLD";
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "ID_PART_OF_THE_WORLD";
            this.Delete.HeaderText = "Удалить";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Удалить";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // button2Quit
            // 
            this.button2Quit.BackColor = System.Drawing.Color.Red;
            this.button2Quit.Location = new System.Drawing.Point(333, 14);
            this.button2Quit.Name = "button2Quit";
            this.button2Quit.Size = new System.Drawing.Size(71, 23);
            this.button2Quit.TabIndex = 7;
            this.button2Quit.Text = "Закрыть";
            this.button2Quit.UseVisualStyleBackColor = false;
            this.button2Quit.Click += new System.EventHandler(this.button2Quit_Click);
            // 
            // FormPartoftheworld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 368);
            this.Controls.Add(this.dgvPOW);
            this.Controls.Add(this.button1POKDANNIE);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2Quit);
            this.Controls.Add(this.button1Save);
            this.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormPartoftheworld";
            this.Text = "Части света";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1POKDANNIE;
        private System.Windows.Forms.DataGridView dgvPOW;
        private System.Windows.Forms.Button button2Quit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PART_OF_THE_WORLD;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}