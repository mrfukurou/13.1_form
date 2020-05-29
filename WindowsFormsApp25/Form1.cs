using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp25
{
    public abstract class Tovar
    {
        public abstract void info(DataGridViewRow row);
        public abstract bool actual();
    }

    public class Product : Tovar
    {
        private string name;
        private string price;
        private DateTime datepr;
        private DateTime srok;

        public Product(string name1, string price1, DateTime datepr1, DateTime srok1)
        {
            name = name1;
            price = price1;
            datepr = datepr1;
            srok = srok1;
        }

        public override void info(DataGridViewRow row)
        {
            row.Cells["Name"].Value = name;
            row.Cells["Price"].Value = price;
            row.Cells["Datapr"].Value = datepr.ToShortDateString();
            row.Cells["Srok"].Value = srok.ToShortDateString();
        }
        public override bool actual()
        {
            if (srok > DateTime.Now) return true;
            else return false;
        }
    }
    public class Part : Tovar
    {
        private string name;
        private string price;
        private int number;
        private DateTime datepr;
        private DateTime srok;

        public Part(string name1, string price1, int number1, DateTime datepr1, DateTime srok1)
        {
            name = name1;
            price = price1;
            number = number1;
            datepr = datepr1;
            srok = srok1;
        }
        public override void info(DataGridViewRow row)
        {
            row.Cells["Name"].Value = name;
            row.Cells["Price"].Value = price;
            row.Cells["Num"].Value = number;
            row.Cells["Datapr"].Value = datepr.ToShortDateString();
            row.Cells["Srok"].Value = srok.ToShortDateString();
        }
        public override bool actual()
        {
            if (srok > DateTime.Now) return true;
            else return false;
        }
    }
    class Compl : Tovar
    {
        private string name;
        private string price;
        private string component;

        public Compl() { }

        public Compl(string name1, string price1, string component1)
        {
            name = name1;
            price = price1;
            component = component1;
        }

        public override void info(DataGridViewRow row)
        {
            row.Cells["Name"].Value = name;
            row.Cells["Price"].Value = price;
            row.Cells["Com"].Value = component;
        }
        public override bool actual() => true;
    }
 
    public partial class Form1 : Form
    {
        List<Tovar> product_list = new List<Tovar>();
        private void pr(DataGridView tabel, List<Tovar> list)
        {
            tabel.RowCount = list.Count;
            for (int i = 0; i < tabel.RowCount; i++)
            {
                list[i].info(tabel.Rows[i]);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = way.Text;
                string[] line = File.ReadAllLines(fileName);
                for (int i = 0; i < line.Length; i++)
                {
                    string[] position = line[i].Split(';');
                    if (position.Length == 4)
                    {
                        Product product = new Product(position[0].ToString(), position[1].ToString(), Convert.ToDateTime(position[2]), Convert.ToDateTime(position[3]));
                        product_list.Add(product);
                    }
                    else
                    {
                        if (position.Length == 5)
                        {
                            Part part = new Part(position[0], position[1], Convert.ToInt32(position[2]), Convert.ToDateTime(position[3]), Convert.ToDateTime(position[4]));
                            product_list.Add(part);
                        }
                        if (position.Length == 3)
                        {
                            Compl compl = new Compl(position[0], position[1], position[2]);
                            product_list.Add(compl);
                        }

                    }
                }
                pr(table, product_list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void no_act_Click(object sender, EventArgs e)
        {
            try
            {
                List<Tovar> not_actual = new List<Tovar>();
                int count = 0;
                foreach (Tovar var in product_list)
                {
                    if (!var.actual()) count++;
                }
                if (count != 0)
                {
                    foreach (Tovar var in product_list)
                    {
                        if (!var.actual()) not_actual.Add(var);
                    }
                    pr(table, not_actual);
                }
                else MessageBox.Show("Просроченных товаров нет!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            pr(table, product_list);
        }

        private void clear_all_Click(object sender, EventArgs e)
        {
            way.Clear();
            table.Rows.Clear();
        }
    }
}
