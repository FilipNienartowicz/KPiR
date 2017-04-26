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
    public partial class FormKPiR : Form
    {
        private DBContact DataBase;
        public DataSet1TableAdapters.QueriesTableAdapter queries;
        public List<String> filtrAkcje;
        public List<String> filtrKonta;
        public List<String> filtrKoord;
        private int val;

        public FormKPiR()
        {
            DataBase = new DBContact();
            InitializeComponent();
            textBoxPiROd.Text = DateTime.Today.AddDays(1 - DateTime.Today.Day).ToShortDateString();
            textBoxPiRDo.Text = DateTime.Today.ToShortDateString();
            queries = new DataSet1TableAdapters.QueriesTableAdapter();
            filtrAkcje = new List<string>();
            filtrKonta = new List<string>();
            filtrKoord = new List<string>();
            val = -1;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            aktywny = false;
            try
            {
                this.pRZYCHODY_I_ROZCHODYTableAdapter.Fill(this.dataSet1.PRZYCHODY_I_ROZCHODY);
                this.aKCJE_HISTORIATableAdapter.Fill(this.dataSet1.AKCJE_HISTORIA);
                this.aKCJETableAdapter.Fill(this.dataSet1.AKCJE);
                this.kOORDYNATORZY_HISTORIATableAdapter.Fill(this.dataSet1.KOORDYNATORZY_HISTORIA);
                this.kOORDYNATORZYTableAdapter.Fill(this.dataSet1.KOORDYNATORZY);
                this.kONTATableAdapter.Fill(this.dataSet1.KONTA);
                for (int i = 0; i < dataGridViewKonta.Rows.Count - 1; i++)
                {
                    dataGridViewKonta.Rows[i].Cells["STAN"].Value = DataBase.getStanKonta(dataGridViewKonta.Rows[i].Cells["NAZWA_KONTA"].Value.ToString(), DateTime.Today.ToShortDateString());
                }
                ZaladujFiltry();
                PokazDanePiR();

                for (int i = 0; i < tabControl1.TabCount; i++)
                    this.tabControl1.SelectedTab = tabControl1.TabPages[i];
                this.tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
            aktywny = true;
        }

        private Boolean AkcjeNiezapisaneZmiany()
        {
            if (dataGridViewAkcje.SelectedRows.Count > 0)
            {
                bool zmiana = false;
                for (int i = 0; i < dataGridViewAkcjeHistoria.Rows.Count; i++)
                {
                    if (dataGridViewAkcjeHistoria.Rows[i].Cells["AKCJA_DO"].Value.ToString().Equals(""))
                    {
                        if (!textBoxAkcjeOd.Text.Equals(dataGridViewAkcjeHistoria.Rows[i].Cells["AKCJA_OD"].Value.ToString().Substring(0, 10)) || 
                            !comboBoxAkcjeKoordynator.Text.Equals(dataGridViewAkcjeHistoria.Rows[i].Cells["AKCJA_KOORDYNATOR"].Value.ToString()))
                        {
                            zmiana = true;
                        }
                        break;
                    }
                }

                if (zmiana || !textBoxAkcjaNowa.Text.Equals(dataGridViewAkcje.SelectedRows[0].Cells["AKCJANAZWA"].Value.ToString()))
                {
                    DialogResult result = MessageBox.Show("Zapisać zmiany przed wyjściem?", "KPiR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Akcje_Zapisz_Zmiany();
                    }
                    if (result == DialogResult.No)
                    {
                        ZaladujAkcje();
                    }
                    if (result == DialogResult.Cancel)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private Boolean KoordynatorzyNiezapisaneZmiany()
        {
            if (dataGridViewKoord.SelectedRows.Count > 0)
            {
                bool zmiana = false;
                for (int i = 0; i < dataGridViewKoordHist.Rows.Count; i++)
                {
                    if(dataGridViewKoordHist.Rows[i].Cells["KOORD_DO"].Value.ToString().Equals(""))
                    {
                        if(!textBoxkoordod.Text.Equals(dataGridViewKoordHist.Rows[i].Cells["KOORD_OD"].Value.ToString().Substring(0,10)))
                        {
                            zmiana = true;
                        }
                        break;
                    }
                }

                if( zmiana ||
                !textBoxImie.Text.Equals(dataGridViewKoord.SelectedRows[0].Cells["IMIE"].Value.ToString()) ||
                !textBoxNazwisko.Text.Equals(dataGridViewKoord.SelectedRows[0].Cells["NAZWISKO"].Value.ToString()))
                {
                    DialogResult result = MessageBox.Show("Zapisać zmiany przed wyjściem?", "KPiR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Konta_Zapisz_Zmiany();
                    }
                    if (result == DialogResult.No)
                    {
                        ZaladujKonta();                    
                    }
                    if (result == DialogResult.Cancel)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void FormKPiR_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch(tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        e.Cancel = PiRNiezapisaneZmiany();
                    } break;
                case 1:
                    {
                        e.Cancel = AkcjeNiezapisaneZmiany();
                    } break;
                case 2:
                    {
                        e.Cancel = KoordynatorzyNiezapisaneZmiany();
                    } break;
                case 3:
                    {
                        e.Cancel = KontaNiezapisaneZmiany();
                    } break;
            }
        }

        private void tabControl1_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            switch(e.TabPageIndex)
            {
                case 0:
                    {
                        e.Cancel = PiRNiezapisaneZmiany();
                    }break;
                case 1:
                    {
                        e.Cancel = AkcjeNiezapisaneZmiany();
                    } break;
                case 2:
                    {
                        e.Cancel = KoordynatorzyNiezapisaneZmiany();
                    } break;
                case 3:
                    {
                        e.Cancel = KontaNiezapisaneZmiany();
                    } break;
            }
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            Button box = (Button)sender;
            if (box.Name == buttonkoord_od.Name)
            {
                FormDate date = new FormDate(textBoxkoordod, this);
                date.Visible = true;
                return;
            }

            if (box.Name == buttonPiR_od.Name)
            {
                FormDate date = new FormDate(textBoxPiROd, this);
                date.Visible = true;
                return;
            }

            if (box.Name == buttonPiR_do.Name)
            {
                FormDate date = new FormDate(textBoxPiRDo, this);
                date.Visible = true;
                return;
            }

            if (box.Name == buttonAkcje.Name)
            {
                FormDate date = new FormDate(textBoxAkcjeOd, this);
                date.Visible = true;
                return;
            }
        }

        private void textBoxDate_Leave(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            try
            {
                DateTime.Parse(box.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Podana wartość nie jest datą! Dopuszczalny format to: YYYY-MM-DD", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                box.Focus();
            }
        }

        private void textBoxNull_Leave(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text.Equals(""))
            {
                MessageBox.Show("Pole nie może być puste", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                box.Focus();
            }
            else
            {
                if (box.Text[0].ToString().Equals(" "))//.Equals(" "))
                {
                    MessageBox.Show("Pole nie może zaczynać się od spacji", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    box.Focus();
                }
            }
        }

        /********************************Konta***************************************/
        public void Konta_Zapisz_Zmiany()
        {
            this.kONTATableAdapter.Update(dataSet1);            
        }

        private void buttonKontaZapisz_Click(object sender, EventArgs e)
        {
           Konta_Zapisz_Zmiany();
        }

        private void buttonKontaAnuluj_Click(object sender, EventArgs e)
        {
            ZaladujKonta();
        }

        private void ZaladujKonta()
        {
            this.kONTATableAdapter.Fill(this.dataSet1.KONTA);        
            for(int i = 0; i < dataGridViewKonta.Rows.Count - 1; i++)
            {
                dataGridViewKonta.Rows[i].Cells["STAN"].Value = DataBase.getStanKonta(dataGridViewKonta.Rows[i].Cells["NAZWA_KONTA"].Value.ToString(), DateTime.Today.ToShortDateString());
            }
        }

        private void tabPageKonta_Enter(object sender, EventArgs e)
        {
            ZaladujKonta();
        }

        private void dataGridViewKonta_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dataGridViewKonta.Rows[dataGridViewKonta.Rows.Count - 2].Cells["AKTYWNE"].Value = "N";
        }

        private void buttonKontaUsun_Click(object sender, EventArgs e)
        {
            if (dataGridViewKonta.Rows.Count > 1 && !DataBase.isKontoUsed(dataGridViewKonta.CurrentRow.Cells["NAZWA_KONTA"].Value.ToString()))
            {
                dataSet1.KONTA.Rows[dataGridViewKonta.SelectedRows[0].Index].Delete();
            }
            else
            {
                MessageBox.Show("Usunięcie konta nie jest możliwe! Konto posiada już wprowadzone operacje", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewKonta_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            if (view.Columns[e.ColumnIndex].Name == "NAZWA_KONTA" && DataBase.isKontoUsed(view.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
            {
                MessageBox.Show("Zmiana nazwy konta nie jest możliwa! Konto posiada już wprowadzone operacje", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private Boolean KontaNiezapisaneZmiany()
        {
            if (dataSet1.KONTA.GetChanges() != null)
            {
                DialogResult result = MessageBox.Show("Zapisać zmiany przed wyjściem?", "KPiR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Konta_Zapisz_Zmiany();
                }
                if (result == DialogResult.No)
                {
                    ZaladujKonta();
                }
                if (result == DialogResult.Cancel)
                {
                    return true;
                }
            }
            return false;
        }

        private void dataGridViewKonta_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.HResult == -2146232026)
            {
                MessageBox.Show("Wprowadzona nazwa nie może być pusta!", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }

            if (e.Exception.HResult == -2146232022)
            {
                MessageBox.Show("Wprowadzona nazwa musi być unikalna!", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }

            if (e.Exception.HResult == -2147024809)
            {
                MessageBox.Show("Maksymalna długośc nazwy to 30!", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }


            if (e.Cancel == false)
            {
                MessageBox.Show(e.Exception.Message, "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /***********************************Koordynatorzy***************************/

        private void tabPageKoordynatorzy_Enter(object sender, EventArgs e)
        {
            ZaladujKoord();
        }

        private void buttonkoordanuluj_Click(object sender, EventArgs e)
        {
            ZaladujKoord();
        }

        private void buttonkoordzapisz_Click(object sender, EventArgs e)
        {
            Koord_Zapisz_Zmiany();
        }

        public void Koord_Zapisz_Zmiany()
        {
            bool zmiana = false;
            bool zmianadaty = false;
            if (radioButtonkoord_nowy.Checked == true)
            {
                DataRow[] row = dataSet1.KOORDYNATORZY_HISTORIA.Select("FUNKCJA = '" + textBoxFunkcja.Text + "' AND DO IS NULL");
                if (DateTime.Parse(textBoxkoordod.Text).CompareTo(DateTime.Parse(row[0]["OD"].ToString())) > 0)
                {
                    try
                    {
                        queries.ZMIANA_KOORDYNATORA(textBoxFunkcja.Text, textBoxImie.Text, textBoxNazwisko.Text, DateTime.Parse(textBoxkoordod.Text));
                        zmiana = true;
                    }
                    catch (Exception e)
                    {
                        if (e.HResult == 20012)
                            MessageBox.Show("Nie można zmienić koordynatora w tej dacie. Poprzedni koordynator posiada wtedy operacje", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Podana data musi być większa niż data rozpoczęcia poprzedniego koordynatora!", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                for (int i = 0; i < dataGridViewKoordHist.Rows.Count; i++)
                {
                    if (dataGridViewKoordHist.Rows[i].Cells["KOORD_DO"].Value.ToString().Equals("") )
                    {
                        if( !textBoxkoordod.Text.Equals(dataGridViewKoordHist.Rows[i].Cells["KOORD_OD"].Value.ToString().Substring(0, 10)))
                        {
                            try
                            {
                                queries.AKTUALIZACJA_KOORDYNATORA(textBoxFunkcja.Text, DateTime.Parse(textBoxkoordod.Text));
                                zmiana = true;
                            }
                            catch (Exception e)
                            {
                                if (e.HResult == 20012)
                                    MessageBox.Show("Nie można zmienić rozpoczęcia daty koordynatora na podaną. Poprzedni koordynator lub obecny posiada w zmienianym okresie operacje", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        break;
                    }
                }
                
                if(!dataGridViewKoord.SelectedRows[0].Cells["IMIE"].Value.ToString().Equals(textBoxImie.Text))
                {
                    DataRow[] row = dataSet1.KOORDYNATORZY.Select("FUNKCJA = '" + textBoxFunkcja.Text + "'");
                    row[0]["IMIĘ"] = textBoxImie.Text;
                    zmiana = true;
                }

                if(!dataGridViewKoord.SelectedRows[0].Cells["NAZWISKO"].Value.ToString().Equals(textBoxNazwisko.Text))
                {
                    DataRow[] row = dataSet1.KOORDYNATORZY.Select("FUNKCJA = '" + textBoxFunkcja.Text+ "'");
                    row[0]["NAZWISKO"] = textBoxNazwisko.Text;
                    zmiana = true;
                }

                if(zmiana)
                {
                    kOORDYNATORZYTableAdapter.Update(dataSet1);
                    dataSet1.KOORDYNATORZY.AcceptChanges();
                }
            }
            if (zmiana || zmianadaty)
            {
                ZaladujKoord();
            }
        }

        private void ZaladujKoord()
        {
            string funkcja = textBoxFunkcja.Text;
            this.kOORDYNATORZY_HISTORIATableAdapter.Fill(this.dataSet1.KOORDYNATORZY_HISTORIA);
            this.kOORDYNATORZYTableAdapter.Fill(this.dataSet1.KOORDYNATORZY);

            for (int i = 0; i < dataGridViewKoord.Rows.Count; i++)
            {
                if (dataGridViewKoord.Rows[i].Cells["FUNKCJA"].Value.ToString().Equals(funkcja))
                {
                    dataGridViewKoord.CurrentCell = dataGridViewKoord.Rows[i].Cells[0];
                    break;
                }
            }

            for (int i = 0; i < dataGridViewKoordHist.Rows.Count; i++)
            {
                if (dataGridViewKoordHist.Rows[i].Cells["KOORD_DO"].Value.ToString().Equals(""))
                {
                    textBoxkoordod.Text = dataGridViewKoordHist.Rows[i].Cells["KOORD_OD"].Value.ToString().Substring(0, 10);
                    break;
                }
            }
           
        }

        private void dataGridViewKoord_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewKoord.SelectedRows.Count > 0)
            {
                buttonUsun_koord.Enabled = true;
                if (dataGridViewKoordHist.Rows.Count < 2)
                    buttonUsun_koord.Enabled = false;
                textBoxFunkcja.Text = dataGridViewKoord.SelectedRows[0].Cells["FUNKCJA"].Value.ToString();
                textBoxImie.Text = dataGridViewKoord.SelectedRows[0].Cells["IMIE"].Value.ToString();
                textBoxNazwisko.Text = dataGridViewKoord.SelectedRows[0].Cells["NAZWISKO"].Value.ToString();

                for (int i = 0; i < dataGridViewKoordHist.Rows.Count; i++)
                {
                    if (dataGridViewKoordHist.Rows[i].Cells["KOORD_DO"].Value.ToString().Equals(""))
                    {
                        textBoxkoordod.Text = dataGridViewKoordHist.Rows[i].Cells["KOORD_OD"].Value.ToString().Substring(0, 10);
                        break;
                    }
                }
            }
        }

        private void buttonUsun_koord_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Usunąć koordynatora?", "KPiR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    queries.USUN_KOORDYNATORA(textBoxFunkcja.Text);
                }
                catch (Exception ex)
                {
                    if (ex.HResult == 20012)
                        MessageBox.Show("Nie można usunąć koordynatora. Koordynator posiada operacje", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                ZaladujKoord();
            }
        }

        /*********************************Akcje************************************/
        private void tabPageAkcje_Enter(object sender, EventArgs e)
        {
            ZaladujAkcje();
        }

        public void Akcje_Zapisz_Zmiany()
        {
            bool zmiana = false;
            bool zmianadaty = false;
            if (radioButtonAkcja_nowa.Checked == true)
            {
                if (dataGridViewAkcjeHistoria.Rows.Count > 0)
                {
                    DataRow[] row = dataSet1.AKCJE_HISTORIA.Select("AKCJA = '" + textBoxNazwaAkcji.Text + "' AND DO IS NULL");
                    if (DateTime.Parse(textBoxAkcjeOd.Text).CompareTo(DateTime.Parse(row[0]["OD"].ToString())) > 0)
                    {
                        try
                        {

                            queries.ZMIANA_AKCJI(textBoxNazwaAkcji.Text, comboBoxAkcjeKoordynator.Text, DateTime.Parse(textBoxAkcjeOd.Text));
                            zmiana = true;
                        }catch(Exception e)
                        {
                            if(e.HResult == 20012)
                                MessageBox.Show("Nie można zmienić edycji w tej dacie. Poprzedni edycja posiada wtedy operacje", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Podana data musi być większa niż data rozpoczęcia poprzedniej edycji!", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DataSet1.AKCJE_HISTORIARow row = (DataSet1.AKCJE_HISTORIARow) dataSet1.AKCJE_HISTORIA.NewRow();
                    row.AKCJA = textBoxNazwaAkcji.Text;
                    row.KOORDYNATOR = comboBoxAkcjeKoordynator.Text;
                    row.OD = DateTime.Parse(textBoxAkcjeOd.Text);
                    row.ID = -1;
                    dataSet1.AKCJE_HISTORIA.AddAKCJE_HISTORIARow(row);
                }
                zmiana = true;
            }
            else
            {
                for (int i = 0; i < dataGridViewAkcjeHistoria.Rows.Count; i++)
                {
                    if (dataGridViewAkcjeHistoria.Rows[i].Cells["AKCJA_DO"].Value.ToString().Equals(""))
                    {
                        if (!textBoxAkcjeOd.Text.Equals(dataGridViewAkcjeHistoria.Rows[i].Cells["AKCJA_OD"].Value.ToString().Substring(0, 10)))
                        {
                            try
                            {
                                queries.AKTUALIZACJA_AKCJI(textBoxNazwaAkcji.Text, DateTime.Parse(textBoxAkcjeOd.Text));
                                zmianadaty = true;
                            }
                            catch (Exception e)
                            {
                                if (e.HResult == 20012)
                                    MessageBox.Show("Nie można zmienić początku edycji na podaną datę. Poprzednia edycja lub obecna posiada w zmienianym czasie operacje", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        break;
                    }
                }

                if (!dataGridViewAkcjeHistoria.SelectedRows[0].Cells["AKCJA_KOORDYNATOR"].Value.ToString().Equals(comboBoxAkcjeKoordynator.Text))
                {
                    DataRow[] row = dataSet1.AKCJE_HISTORIA.Select("ID = '" + dataGridViewAkcjeHistoria.SelectedRows[0].Cells["IDAKCJA"].Value.ToString() + "'");
                    row[0]["KOORDYNATOR"] = comboBoxAkcjeKoordynator.Text;
                    zmiana = true;
                }
            }

            if (zmiana)
            {
                aKCJE_HISTORIATableAdapter.Update(dataSet1);
                dataSet1.AKCJE_HISTORIA.AcceptChanges();
            }

            if (zmiana || zmianadaty)
            {
                ZaladujAkcje();
            }
        }

        private void ZaladujAkcje()
        {
            string akcja = textBoxNazwaAkcji.Text;
            this.aKCJE_HISTORIATableAdapter.Fill(this.dataSet1.AKCJE_HISTORIA);
            this.aKCJETableAdapter.Fill(this.dataSet1.AKCJE);

            for (int i = 0; i < dataGridViewAkcje.Rows.Count; i++)
            {
                if (dataGridViewAkcje.Rows[i].Cells["AKCJANAZWA"].Value.ToString().Equals(akcja))
                {
                    dataGridViewAkcje.CurrentCell = dataGridViewAkcje.Rows[i].Cells[0];
                    break;
                }
            }

            buttonAkcje_Usun_Akcje.Enabled = true;
            buttonAkcje_Usun_Edycje.Enabled = true;
            if (dataGridViewAkcje.SelectedRows.Count > 0)
            {
                textBoxNazwaAkcji.Text = dataGridViewAkcje.SelectedRows[0].Cells["AKCJANAZWA"].Value.ToString();
                textBoxAkcjaNowa.Text = dataGridViewAkcje.SelectedRows[0].Cells["AKCJANAZWA"].Value.ToString();

                if (dataGridViewAkcjeHistoria.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridViewAkcjeHistoria.Rows.Count; i++)
                    {
                        if (dataGridViewAkcjeHistoria.Rows[i].Cells["AKCJA_DO"].Value.ToString().Equals(""))
                        {
                            textBoxAkcjeOd.Text = dataGridViewAkcjeHistoria.Rows[i].Cells["AKCJA_OD"].Value.ToString().Substring(0, 10);
                            comboBoxAkcjeKoordynator.Text = dataGridViewAkcjeHistoria.Rows[i].Cells["AKCJA_KOORDYNATOR"].Value.ToString();
                        }
                        if (DataBase.isAkcjaUsed(dataGridViewAkcjeHistoria.Rows[i].Cells["IDAKCJA"].Value.ToString()))
                        {
                            buttonAkcje_Usun_Akcje.Enabled = false;
                        }
                    }
                    radioButtonAkcja_obecna.Enabled = true;
                    radioButtonAkcja_obecna.Checked = true;
                }
                else
                {
                    textBoxAkcjeOd.Text = DateTime.Today.ToShortDateString();
                    comboBoxAkcjeKoordynator.Text = "";
                    radioButtonAkcja_nowa.Checked = true;
                    radioButtonAkcja_obecna.Enabled = false;
                    buttonAkcje_Usun_Edycje.Enabled = false;
                }
            }
            
        }

        private void buttonakcjezapisz_Click(object sender, EventArgs e)
        {
            Akcje_Zapisz_Zmiany();
        }

        private void buttonakcjeanuluj_Click(object sender, EventArgs e)
        {
            ZaladujAkcje();
        }

        private void buttonAkcje_Usun_Edycje_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Usunąć edycję?", "KPiR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    queries.USUN_EDYCJE(textBoxNazwaAkcji.Text);
                }
                catch (Exception ex)
                {
                    if (ex.HResult == 20012)
                        MessageBox.Show("Nie można usunąć edycji. Edycja posiada operacje", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                ZaladujAkcje();
            }
        }

        private void buttonAkcje_Anuluj_Click(object sender, EventArgs e)
        {
            ZaladujAkcje();
        }

        private void buttonAkcje_Zapisz_Click(object sender, EventArgs e)
        {
            Akcje_Zapisz_Zmiany();
        }

        private void dataGridViewAkcje_SelectionChanged(object sender, EventArgs e)
        {
            buttonAkcje_Usun_Akcje.Enabled = true;
            buttonAkcje_Usun_Edycje.Enabled = true;
            if (dataGridViewAkcje.SelectedRows.Count > 0)
            {
                textBoxNazwaAkcji.Text = dataGridViewAkcje.SelectedRows[0].Cells["AKCJANAZWA"].Value.ToString();
                textBoxAkcjaNowa.Text = dataGridViewAkcje.SelectedRows[0].Cells["AKCJANAZWA"].Value.ToString();

                if (dataGridViewAkcjeHistoria.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridViewAkcjeHistoria.Rows.Count; i++)
                    {
                        if (dataGridViewAkcjeHistoria.Rows[i].Cells["AKCJA_DO"].Value.ToString().Equals(""))
                        {
                            textBoxAkcjeOd.Text = dataGridViewAkcjeHistoria.Rows[i].Cells["AKCJA_OD"].Value.ToString().Substring(0, 10);
                            comboBoxAkcjeKoordynator.Text = dataGridViewAkcjeHistoria.Rows[i].Cells["AKCJA_KOORDYNATOR"].Value.ToString();
                        }
                        if (DataBase.isAkcjaUsed(dataGridViewAkcjeHistoria.Rows[i].Cells["IDAKCJA"].Value.ToString()))
                        {
                            buttonAkcje_Usun_Akcje.Enabled = false;
                        }
                    }
                    radioButtonAkcja_obecna.Enabled = true;
                    radioButtonAkcja_obecna.Checked = true;
                }
                else
                {
                    textBoxAkcjeOd.Text = DateTime.Today.ToShortDateString();
                    comboBoxAkcjeKoordynator.Text = "";
                    radioButtonAkcja_nowa.Checked = true;
                    radioButtonAkcja_obecna.Enabled = false;
                    buttonAkcje_Usun_Edycje.Enabled = false;
                }
            }
        }

        private void buttonAkcjaDodaj_Click(object sender, EventArgs e)
        {
            DataRow[] row = dataSet1.AKCJE.Select("NAZWA = '" + textBoxAkcjaNowa.Text + "'");
            if(row.Count() > 0)
            {
                MessageBox.Show("Podana nazwa nie jest unikalna!", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataSet1.AKCJE.AddAKCJERow(textBoxAkcjaNowa.Text);
                aKCJETableAdapter.Update(dataSet1);
                dataSet1.AKCJE.AcceptChanges();
                ZaladujAkcje();
            }
        }

        private void buttonAkcje_Usun_Akcje_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Usunąć akcję?", "KPiR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                aKCJETableAdapter.Delete(dataGridViewAkcje.SelectedRows[0].Cells["AKCJANAZWA"].Value.ToString());
                dataSet1.AKCJE.AcceptChanges();
                ZaladujAkcje();
            }
        }

        private void buttonAkcjaNazwa_Click(object sender, EventArgs e)
        {
            DataRow[] row = dataSet1.AKCJE.Select("NAZWA = '" + textBoxAkcjaNowa.Text + "'");
            if (row.Count() > 0)
            {
                MessageBox.Show("Podana nazwa nie jest unikalna!", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                row = dataSet1.AKCJE.Select("NAZWA = '" + dataGridViewAkcje.SelectedRows[0].Cells["AKCJANAZWA"].Value.ToString() + "'");
                row[0]["NAZWA"] = textBoxAkcjaNowa.Text;
                aKCJETableAdapter.Update(dataSet1);
                dataSet1.AKCJE.AcceptChanges();
                ZaladujAkcje();
            }
        }


        /******************************Przychody i rozchody*************************************/
        public void PiR_Zapisz_Zmiany()
        {
            this.pRZYCHODY_I_ROZCHODYTableAdapter.Update(dataSet1);
        }

        private void ZaladujPiR()
        {
            this.pRZYCHODY_I_ROZCHODYTableAdapter.Fill(this.dataSet1.PRZYCHODY_I_ROZCHODY);
        }

        private bool aktywny;
        private Boolean PiRNiezapisaneZmiany()
        {
            if (dataSet1.PRZYCHODY_I_ROZCHODY.GetChanges() != null && aktywny)
            {
                DialogResult result = MessageBox.Show("Zapisać zmiany przed wyjściem?", "KPiR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    PiR_Zapisz_Zmiany();
                }
                if (result == DialogResult.No)
                {
                    ZaladujPiR();
                }
                if (result == DialogResult.Cancel)
                {
                    return true;
                }
            }
            return false;
        }

        //Laduje z bazy wszystkie mozliwe wartosci dla filtrow
        private void ZaladujFiltry()
        {
            DataTable akcje = DataBase.getAkcje();
            foreach (DataRow row in akcje.Rows)
            {
                filtrAkcje.Add(row.Field<String>("NAZWA"));
            }

            DataTable konta = DataBase.getKonta();
            foreach (DataRow row in konta.Rows)
            {
                filtrKonta.Add(row.Field<String>("NAZWA"));
            }

            DataTable koord = DataBase.getKoordynatorzy();
            foreach (DataRow row in koord.Rows)
            {
                filtrKoord.Add(row.Field<String>("FUNKCJA"));
            }

            textBoxPiROperacja.Text = "";
            textBoxPiRKontrahent.Text = "";
        }

        //Sprawdzanie poprawnosci zakresu dat
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            dataError.Visible = false;
            if (textBoxPiROd.Text != "" && textBoxPiRDo.Text != "")
            {
                try
                {
                    DateTime czasod = DateTime.Parse(textBoxPiROd.Text);
                    DateTime czasdo = DateTime.Parse(textBoxPiRDo.Text);
                    if (czasod > czasdo)
                    {
                        dataError.Visible = true;
                    }
                }
                catch (FormatException ex)
                {
                }
            }
        }

        //Wyswietla pozycje KPiR w tabeli
        public void PokazDanePiR()
        {
            string text = "AKCJA in(";
            foreach (string nazwa in filtrAkcje)
            {
                text += "'" + nazwa + "',";
            }
            text += "'') AND KOORDYNATOR in(";
            foreach (string nazwa in filtrKoord)
            {
                text += "'" + nazwa + "',";
            }
            text += ")";

            DataRow[] rows = dataSet1.AKCJE_HISTORIA.Select(text);
            text = "AKCJA_ID in(";
            foreach (DataRow row in rows)
            {
                text += "'" + row["ID"] + "',";
            }

            text +=")  AND KONTO in(";
            foreach (string nazwa in filtrKonta)
            {
                text += "'" + nazwa + "',";
            }
            text += "'')"; 

            if (radioButtonCurMonth.Checked)
            {
                text += " AND DATA_DOKONANIA >= #" +DateTime.Today.AddDays(1 - DateTime.Today.Day).ToShortDateString() + "#";
            }

            if (radioButtonCustom.Checked)
            {
                if (dataError.Visible == false && textBoxPiROd.Text != "" && textBoxPiRDo.Text != "")
                {
                    text += " AND DATA_DOKONANIA >= #" + textBoxPiROd.Text + "# AND DATA_DOKONANIA <= #" + textBoxPiRDo.Text + "#";
                }
                else
                {
                    MessageBox.Show(new Form() { TopMost = true }, "Niepoprawnie uzupełnione daty od i do", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if(textBoxPiRKontrahent.Text.Length > 0)
            {
                text += " AND KONTRAHENT Like '%" + textBoxPiRKontrahent.Text + "%'";
            }

            if (textBoxPiROperacja.Text.Length > 0)
            {
                text += " AND TYTUŁ_OPERACJI Like '%" + textBoxPiROperacja.Text + "%'";
            }

            pRZYCHODYIROZCHODYBindingSource.Filter = text;

            this.kONTATableAdapter.Fill(this.dataSet1.KONTA);
            for (int i = 0; i < dataGridViewPiRKonta.Rows.Count; i++)
            {
                dataGridViewPiRKonta.Rows[i].Cells["STAN_OTW"].Value = DataBase.getStanKonta(dataGridViewPiRKonta.Rows[i].Cells["NAZWA_KONTA_PiR"].Value.ToString(),
                   textBoxPiROd.Text);
                dataGridViewPiRKonta.Rows[i].Cells["STAN_ZAMK"].Value = DataBase.getStanKonta(dataGridViewPiRKonta.Rows[i].Cells["NAZWA_KONTA_PiR"].Value.ToString(),
                    textBoxPiRDo.Text);
            }

            for(int i = 0; i < dataGridViewPiR.Rows.Count - 1; i++)
            {
                if(dataGridViewPiR.Rows[i].Cells["RODZAJ"].Value.Equals("P"))
                {
                    dataGridViewPiR.Rows[i].Cells["PRZYCHOD"].Value = dataGridViewPiR.Rows[i].Cells["KWOTA"].Value;
                }
                else
                {
                    dataGridViewPiR.Rows[i].Cells["ROZCHOD"].Value = dataGridViewPiR.Rows[i].Cells["KWOTA"].Value;
                }

                DataRow[] row = dataSet1.AKCJE_HISTORIA.Select("ID =" + dataGridViewPiR.Rows[i].Cells["AKCJA_ID"].Value.ToString());
                dataGridViewPiR.Rows[i].Cells["PiR_AKCJA"].Value = row[0]["AKCJA"];

                DataRow[] koord = dataSet1.KOORDYNATORZY_HISTORIA.Select("FUNKCJA = '" + row[0]["KOORDYNATOR"] + "' AND OD <= #" + 
                    dataGridViewPiR.Rows[i].Cells["DATA_DOKONANIA"].Value.ToString() + "#");

                int max = 0;
                for (int j = 1; j < row.Count(); j++)
                {
                    if (((DateTime)koord[j]["OD"]).CompareTo((DateTime)koord[max]["OD"]) > 0)
                    {
                        max = j;
                    }
                }
                dataGridViewPiR.Rows[i].Cells["KOORD_IMIE"].Value = koord[max]["IMIĘ"];
                dataGridViewPiR.Rows[i].Cells["KOORD_NAZWISKO"].Value = koord[max]["NAZWISKO"];
            }
        }

        //Uruchamia wyswietlanie z danego przedzialu czasowego
        private void buttonPokaz_Click(object sender, EventArgs e)
        {
            PokazDanePiR();
        }

        //Szysci filtry i wyswietla tabele
        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            ZaladujFiltry();
            PokazDanePiR();
        }

        //Wyswietla okno filtrow
        private void buttonFiltry_Click(object sender, EventArgs e)
        {
            if (dataSet1.PRZYCHODY_I_ROZCHODY.GetChanges() != null)
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz porzucić zmiany?", "KPiR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    PokazDanePiR();
                }

                if (result == DialogResult.No)
                {
                    return;
                }
            }       
            Filtry filtry = new Filtry(this);
            filtry.Visible = true;
        }

        //Laduje oryginalne dane z bazy PiR, odrzuca zmiay wprowadzone w danych
        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.pRZYCHODY_I_ROZCHODYTableAdapter.Fill(this.dataSet1.PRZYCHODY_I_ROZCHODY);
            PokazDanePiR();
        }

        //Zapisuje dane PiR do bazy
        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            PiR_Zapisz_Zmiany();
        }

        //Laduje dane po wejsciu w zakladke PiR
        private void tabPagePiR_Enter(object sender, EventArgs e)
        {
            PokazDanePiR();
        }

        //Usuwa wiersz PiR
        private void buttonPiRusun_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Usunąć operację?", "KPiR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                for(int i=0; i < dataSet1.PRZYCHODY_I_ROZCHODY.Rows.Count; i++)
                {
                    string a = dataSet1.PRZYCHODY_I_ROZCHODY.Rows[i]["ID"].ToString();
                    if (dataSet1.PRZYCHODY_I_ROZCHODY.Rows[i]["ID"].ToString().Equals(dataGridViewPiR.SelectedRows[0].Cells["ID"].Value.ToString()))
                    {
                        dataSet1.PRZYCHODY_I_ROZCHODY.Rows[i].Delete();
                        //pRZYCHODY_I_ROZCHODYTableAdapter.Update(dataSet1.PRZYCHODY_I_ROZCHODY);
                        PokazDanePiR();
                        break;
                    }
                }
            }
        }

        private void dataGridViewPiR_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView view = (DataGridView)sender;            
            if(e.Exception.HResult == -2146233033)
            {
                MessageBox.Show("Podana wartość nie jest datą! Dopuszczalny format to: YYYY-MM-DD", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            if (e.Exception.HResult == -2146232026)
            {
                MessageBox.Show("Co najmniej jedno pole jest puste. Jedyne dozwolone puste pole to PRZYCHÓD lub ROZCHÓD (ale nie jednosześnie)", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            if (e.Exception.HResult == -2146233088)
            {
                MessageBox.Show("Podana wartość jest zbyt duża!", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            if(e.Exception.HResult != -2147024809)
                MessageBox.Show(e.Exception.Message, "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridViewPiR_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            view.Rows[view.Rows.Count - 2].Cells["ID"].Value = val--;
        }

        private void dataGridViewPiR_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            if (view.Columns[e.ColumnIndex].Name.Equals("PRZYCHOD"))
            {
                try
                {
                    double a = double.Parse(dataGridViewPiR.Rows[e.RowIndex].Cells["PRZYCHOD"].Value.ToString());
                    if(a % 0.01 > 0)
                    {
                        a -= a % 0.01;
                        dataGridViewPiR.Rows[e.RowIndex].Cells["PRZYCHOD"].Value = a.ToString();
                    }
                    if (a > 0)
                    {
                        dataGridViewPiR.Rows[e.RowIndex].Cells["KWOTA"].Value = dataGridViewPiR.Rows[e.RowIndex].Cells["PRZYCHOD"].Value;
                        dataGridViewPiR.Rows[e.RowIndex].Cells["RODZAJ"].Value = "P";
                    }
                    else
                    {
                        MessageBox.Show("Wartość musi być dodatnia!", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }catch
                {
                    MessageBox.Show("Podana wartość nie jest liczbą!", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (view.Columns[e.ColumnIndex].Name.Equals("ROZCHOD"))
            {

                try
                {
                    double a = double.Parse(dataGridViewPiR.Rows[e.RowIndex].Cells["ROZCHOD"].Value.ToString());
                    if (a % 0.01 > 0)
                    {
                        a -= a % 0.01;
                        dataGridViewPiR.Rows[e.RowIndex].Cells["ROZCHOD"].Value = a.ToString();
                    }
                    if (a > 0)
                    {
                        dataGridViewPiR.Rows[e.RowIndex].Cells["KWOTA"].Value = dataGridViewPiR.Rows[e.RowIndex].Cells["ROZCHOD"].Value;
                        dataGridViewPiR.Rows[e.RowIndex].Cells["RODZAJ"].Value = "R";
                    }
                    else
                    {
                        MessageBox.Show("Wartość musi być dodatnia!", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
                catch
                {
                    MessageBox.Show("Podana wartość nie jest liczbą!", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            if (view.Columns[e.ColumnIndex].Name.Equals("DATA_DOKONANIA") || view.Columns[e.ColumnIndex].Name.Equals("PiR_AKCJA"))
            {
                if (view.Rows[e.RowIndex].Cells["DATA_DOKONANIA"].Value != null 
                    && !view.Rows[e.RowIndex].Cells["DATA_DOKONANIA"].Value.ToString().Equals("") 
                    && view.Rows[e.RowIndex].Cells["PiR_AKCJA"].Value != null
                    && !view.Rows[e.RowIndex].Cells["PiR_AKCJA"].Value.ToString().Equals(""))

                {
                    if(DateTime.Parse(view.Rows[e.RowIndex].Cells["DATA_DOKONANIA"].Value.ToString().Substring(0,10)).CompareTo(DateTime.Parse("2016-01-01")) < 0)
                    {
                        MessageBox.Show("Podana data jest za mała!", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DataRow[] row = dataSet1.AKCJE_HISTORIA.Select("AKCJA = '" + view.Rows[e.RowIndex].Cells["PiR_AKCJA"].Value.ToString() +
                        "' AND OD <= #" + view.Rows[e.RowIndex].Cells["DATA_DOKONANIA"].Value.ToString().Substring(0, 10) + "#");
                    if (row.Count() > 0)
                    {
                        int max = 0;
                        for (int j = 1; j < row.Count(); j++)
                        {
                            if (((DateTime)row[j]["OD"]).CompareTo((DateTime)row[max]["OD"]) > 0)
                            {
                                max = j;
                            }
                        }
                        dataGridViewPiR.Rows[e.RowIndex].Cells["AKCJA_ID"].Value = row[max]["ID"];                    
                        DataRow[] koord = dataSet1.KOORDYNATORZY_HISTORIA.Select("FUNKCJA = '" + row[max]["KOORDYNATOR"] + "' AND OD <= #" +
                            view.Rows[e.RowIndex].Cells["DATA_DOKONANIA"].Value.ToString().Substring(0, 10) + "#");
                        
                        max = 0;
                        for (int j = 1; j < koord.Count(); j++)
                        {
                            if (((DateTime)koord[j]["OD"]).CompareTo((DateTime)koord[max]["OD"]) > 0)
                            {
                                max = j;
                            }
                        }
                        dataGridViewPiR.Rows[e.RowIndex].Cells["KOORD_IMIE"].Value = koord[max]["IMIĘ"];
                        dataGridViewPiR.Rows[e.RowIndex].Cells["KOORD_NAZWISKO"].Value = koord[max]["NAZWISKO"];
                    }
                    else
                    {
                        MessageBox.Show("Podane parametry nie odpowiadają żadnej edycji!", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridViewPiR.Rows[e.RowIndex].Cells["KOORD_IMIE"].Value = null;
                        dataGridViewPiR.Rows[e.RowIndex].Cells["KOORD_NAZWISKO"].Value = null;
                        dataGridViewPiR.Rows[e.RowIndex].Cells["AKCJA_ID"].Value = null;
                    }
                }
            }
        }

        private void dataGridViewPiR_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            if (view.Columns[e.ColumnIndex].Name.Equals("PRZYCHOD") )
            {
                if (view.Rows[e.RowIndex].Cells["ROZCHOD"].Value != null)
                {
                    MessageBox.Show("Operacja nie może być jednocześnie przychodem i rozchodem!", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }

            if (view.Columns[e.ColumnIndex].Name.Equals("ROZCHOD"))
            {
                if (view.Rows[e.RowIndex].Cells["PRZYCHOD"].Value != null)
                {
                    MessageBox.Show("Operacja nie może być jednocześnie przychodem i rozchodem!", "KPiR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
    }
}
