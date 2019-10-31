using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FOOTBALL1
{
    public partial class FormPartoftheworld : Form
    {
        public Form1 f5;
        List<Part_of_the_world> lmf3;
        public FormPartoftheworld(Form1 _f5)
        {
            InitializeComponent();
            f5 = _f5;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1Save_Click(object sender, EventArgs e)
        {
            string vb = textBox1.Text;
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = string.Format(@"insert into dbo.PARTS_OF_THE_WORLD(NAME_PART_OF_THE_WORLD) values ('{0}')", vb);
            command.Connection = f5.sqlCon;
            f5.sqlCon.Open();
            int p = command.ExecuteNonQuery();
            f5.sqlCon.Close();
            MessageBox.Show("Сохранение завершено");
        }



        private void button1POKDANNIE_Click(object sender, EventArgs e)
        {
            string sqlDB;
            sqlDB = @"SELECT    dbo.PARTS_OF_THE_WORLD.ID_PART_OF_THE_WORLD,
                                dbo.PARTS_OF_THE_WORLD.NAME_PART_OF_THE_WORLD
                        FROM    dbo.PARTS_OF_THE_WORLD
        ";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlDB, f5.sqlCon);
            DataTable dtTable = new DataTable();
            sqlDA.Fill(dtTable);
            lmf3 = new List<Part_of_the_world>();
            for (int i = 0; i < dtTable.Rows.Count; i++)
            {
                Part_of_the_world t= new Part_of_the_world();
                t.ID_PART_OF_THE_WORLD = (int)dtTable.Rows[i]["ID_PART_OF_THE_WORLD"];
                t.NAME_PART_OF_THE_WORLD = dtTable.Rows[i]["NAME_PART_OF_THE_WORLD"].ToString();
                

                lmf3.Add(t);
            }
            dgvPOW.DataSource = null;
            dgvPOW.DataSource = lmf3;


        }

        private void dgvPOW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 2)
                return;
            Part_of_the_world part = lmf3[e.RowIndex];
            string Sqlsg;
            Sqlsg = @" Delete
                       From PARTS_OF_THE_WORLD
                       Where ID_PART_OF_THE_WORLD = " + part.ID_PART_OF_THE_WORLD;


        }

        private void button2Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
