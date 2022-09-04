using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureAccounting
{
    public partial class Form1 : Form
    {
        private DataGridViewColumn dataGridViewColumn1 = null;
        private DataGridViewColumn dataGridViewColumn2 = null;
        private DataGridViewColumn dataGridViewColumn3 = null;
        private DataGridViewColumn dataGridViewColumn4 = null;
        private DataGridViewColumn dataGridViewColumn5 = null;

        private LinkedList<Furniture> furnitureList = new LinkedList<Furniture>();
        public Form1()
        {
            InitializeComponent();
            initDataGridView();

        }

        //initialization table
        private void initDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Add(getDataGridViewColumn1());
            dataGridView1.Columns.Add(getDataGridViewColumn2());
            dataGridView1.Columns.Add(getDataGridViewColumn3());
            dataGridView1.Columns.Add(getDataGridViewColumn4());
            dataGridView1.Columns.Add(getDataGridViewColumn5());
            dataGridView1.AutoResizeColumns();
        }
        //dynamic create column 
        private DataGridViewColumn getDataGridViewColumn1()
        {
            if (dataGridViewColumn1 == null)
            {
                dataGridViewColumn1 = new DataGridViewTextBoxColumn();
                dataGridViewColumn1.Name = "";
                dataGridViewColumn1.HeaderText = "Name";
                dataGridViewColumn1.ValueType = typeof(string);
                dataGridViewColumn1.Width = dataGridView1.Width / 5;
            }
            return dataGridViewColumn1;
        }
        //dynamic create column 
        private DataGridViewColumn getDataGridViewColumn2()
        {
            if (dataGridViewColumn2 == null)
            {
                dataGridViewColumn2 = new DataGridViewTextBoxColumn();
                dataGridViewColumn2.Name = "";
                dataGridViewColumn2.HeaderText = "Manufacturer";
                dataGridViewColumn2.ValueType = typeof(string);
                dataGridViewColumn2.Width = dataGridView1.Width / 5;
            }
            return dataGridViewColumn2;
        }
        //dynamic create column 
        private DataGridViewColumn getDataGridViewColumn3()
        {
            if (dataGridViewColumn3 == null)
            {
                dataGridViewColumn3 = new DataGridViewTextBoxColumn();
                dataGridViewColumn3.Name = "";
                dataGridViewColumn3.HeaderText = "Material";
                dataGridViewColumn3.ValueType = typeof(string);
                dataGridViewColumn3.Width = dataGridView1.Width / 5;
            }
            return dataGridViewColumn3;
        }

        //dynamic create column 
        private DataGridViewColumn getDataGridViewColumn4()
        {
            if (dataGridViewColumn4 == null)
            {
                dataGridViewColumn4 = new DataGridViewTextBoxColumn();
                dataGridViewColumn4.Name = "";
                dataGridViewColumn4.HeaderText = "Count";
                dataGridViewColumn4.ValueType = typeof(string);
                dataGridViewColumn4.Width = dataGridView1.Width / 5;
            }
            return dataGridViewColumn4;
        }

        //dynamic create column 
        private DataGridViewColumn getDataGridViewColumn5()
        {
            if (dataGridViewColumn5 == null)
            {
                dataGridViewColumn5 = new DataGridViewTextBoxColumn();
                dataGridViewColumn5.Name = "";
                dataGridViewColumn5.HeaderText = "Description";
                dataGridViewColumn5.ValueType = typeof(string);
                dataGridViewColumn5.Width = dataGridView1.Width / 5;
            }
            return dataGridViewColumn5;
        }

        //add Furniture to collection
        private void addFurniture(string name, string manufacturer, string material, int count, string description)
        {
            Furniture s = new Furniture(name, manufacturer, material, count, description);
            furnitureList.AddLast(s);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            showListInGrid();
        }

        //Delete Furniture from collection
        private void deleteFurniture(int elementIndex)
        {
             LinkedListNode<Furniture> currentNode = furnitureList.First;
            for (int i=0; i <= elementIndex && currentNode != null; i++)
            {
                if (i != elementIndex)
                {
                    currentNode = currentNode.Next;
                    continue;
                }

                furnitureList.Remove(currentNode);
            }
            showListInGrid();
        }

        //viev collection in table
        private void showListInGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Furniture s in furnitureList)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell1 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell2 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell3 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell4 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell5 = new
                DataGridViewTextBoxCell();
                cell1.ValueType = typeof(string);
                cell1.Value = s.getName();
                cell2.ValueType = typeof(string);
                cell2.Value = s.getManufacturer();
                cell3.ValueType = typeof(string);
                cell3.Value = s.getMaterial();
                cell4.ValueType = typeof(string);
                cell4.Value = s.getCount();
                cell5.ValueType = typeof(string);
                cell5.Value = s.getDescription();
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);
                row.Cells.Add(cell5);
                dataGridView1.Rows.Add(row);
            }
        }

        //add button   
         private void Button1_Click_1(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                count = int.Parse(textBox4.Text);
                textBox4.BackColor = Color.White;
                addFurniture(textBox1.Text, textBox2.Text, textBox3.Text, count, textBox5.Text);
            }
            catch
            {
                textBox4.BackColor = Color.Red;
            }
            
        }

        //deleta button
        private void deleteToolStripMenuItem_Click(object sender,
        EventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            DialogResult dr = MessageBox.Show("Delete furniture?", "",
            MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    deleteFurniture(selectedRow);
                }
                catch (Exception)
                {
                }
            }
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
