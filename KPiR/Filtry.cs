using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPiR
{
    public partial class Filtry : Form
    {
        private FormKPiR main;
        public Filtry(FormKPiR main)
        {
            this.main = main;
            InitializeComponent();

            DBContact DataBase = new DBContact();

            dataGridViewKonta.DataSource = DataBase.getKonta();
            dataGridViewKonta.Columns[0].ReadOnly = true;
            dataGridViewKonta.Columns[1].Visible = false;
            dataGridViewKonta.Columns.Add(CheckBoxColumn());

            dataGridViewAkcje.DataSource = DataBase.getAkcje();
            dataGridViewAkcje.Columns[0].ReadOnly = true;
            dataGridViewAkcje.Columns.Add(CheckBoxColumn());

            dataGridViewKoord.DataSource = DataBase.getKoordynatorzy();
            dataGridViewKoord.Columns[1].Visible = false;
            dataGridViewKoord.Columns[2].Visible = false;
            dataGridViewKoord.Columns[0].ReadOnly = true;
            dataGridViewKoord.Columns.Add(CheckBoxColumn());
            main.Enabled = false;
        }

        private DataGridViewCheckBoxColumn CheckBoxColumn()
        {
            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            column.HeaderText = "Wyświetlany";
            column.Name = "Wyświetlany";
            column.TrueValue = 1;
            column.FalseValue = 0;
            return column;
        }

        private void Filtry_Load(object sender, EventArgs e)
        {
            //todo - tylko te, co zaznaczone/wszystkie
            for (int u = 0; u < dataGridViewAkcje.RowCount; u++)
            {
                if (main.filtrAkcje.Contains(dataGridViewAkcje.Rows[u].Cells["Nazwa"].Value))
                    dataGridViewAkcje.Rows[u].Cells["Wyświetlany"].Value = 1;
                else
                    dataGridViewAkcje.Rows[u].Cells["Wyświetlany"].Value = 0;
            }

            for (int u = 0; u < dataGridViewKonta.RowCount; u++)
            {
                if (main.filtrKonta.Contains(dataGridViewKonta.Rows[u].Cells["Nazwa"].Value))
                    dataGridViewKonta.Rows[u].Cells["Wyświetlany"].Value = 1;
                else
                    dataGridViewKonta.Rows[u].Cells["Wyświetlany"].Value = 0;
            }

            for (int u = 0; u < dataGridViewKoord.RowCount; u++)
            {
                if (main.filtrKoord.Contains(dataGridViewKoord.Rows[u].Cells["FUNKCJA"].Value))
                    dataGridViewKoord.Rows[u].Cells["Wyświetlany"].Value = 1;
                else
                    dataGridViewKoord.Rows[u].Cells["Wyświetlany"].Value = 0;
            }
        }

        private void ZaznaczWszystkie(DataGridView tabela)
        {
            for (int u = 0; u < tabela.RowCount; u++)
            {
                tabela.Rows[u].Cells["Wyświetlany"].Value = 1;
            }
        }

        private void OdznaczWszystkie(DataGridView tabela)
        {
            for (int u = 0; u < tabela.RowCount; u++)
            {
                tabela.Rows[u].Cells["Wyświetlany"].Value = 0;
            }
        }

        private void buttonAllKonta_Click(object sender, EventArgs e)
        {
            ZaznaczWszystkie(dataGridViewKonta);
        }

        private void buttonNoKonta_Click(object sender, EventArgs e)
        {
            OdznaczWszystkie(dataGridViewKonta);
        }

        private void buttonAllAkcje_Click(object sender, EventArgs e)
        {
            ZaznaczWszystkie(dataGridViewAkcje);
        }

        private void buttonNoAkcje_Click(object sender, EventArgs e)
        {
            OdznaczWszystkie(dataGridViewAkcje);
        }

        private void buttonAllKoord_Click(object sender, EventArgs e)
        {
            ZaznaczWszystkie(dataGridViewKoord);
        }

        private void buttonNoKoord_Click(object sender, EventArgs e)
        {
            OdznaczWszystkie(dataGridViewKoord);
        }

        private void buttonFiltrStop_Click(object sender, EventArgs e)
        {
            ZaznaczWszystkie(dataGridViewKonta);
            ZaznaczWszystkie(dataGridViewAkcje);
            ZaznaczWszystkie(dataGridViewKoord);
        }

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            main.filtrAkcje.Clear();
            for (int i = 0; i < dataGridViewAkcje.RowCount; i++)
            {
                if ((int)dataGridViewAkcje.Rows[i].Cells["Wyświetlany"].Value == 1)
                    main.filtrAkcje.Add(dataGridViewAkcje.Rows[i].Cells["NAZWA"].Value.ToString());
            }

            main.filtrKonta.Clear();
            for (int i = 0; i < dataGridViewKonta.RowCount; i++)
            {
                if ((int)dataGridViewKonta.Rows[i].Cells["Wyświetlany"].Value == 1)
                    main.filtrKonta.Add(dataGridViewKonta.Rows[i].Cells["NAZWA"].Value.ToString());
            } 
            
            main.filtrKoord.Clear();
            for (int i = 0; i < dataGridViewKoord.RowCount; i++)
            {
                if ((int)dataGridViewKoord.Rows[i].Cells["Wyświetlany"].Value == 1)
                    main.filtrKoord.Add(dataGridViewKoord.Rows[i].Cells["FUNKCJA"].Value.ToString());
            }
            main.Enabled = true;
            main.PokazDanePiR();
            this.Close();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Filtry_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Enabled = true;
        }
    }
}
