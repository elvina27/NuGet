using System;
using System.Drawing;
using System.Windows.Forms;
using Коммисия.Haracteristika;
using Коммисия.Genderi;

namespace Коммисия
{
    public partial class Abiturientinfo_form : Form
    {
        private readonly Abiturient abiturient;
        public Abiturientinfo_form()
        {
            InitializeComponent();
            FillGender();
            FillFormaObucheniya();

            abiturient = new Abiturient();
            {
                Abiturient.Birthday = DateTime.Now.AddYears(-16);
                Abiturient.Gender = Gender.Female;
                Abiturient.FormaObucheniya = FormaObucheniya.Ochnoe;
            }
            cmbGender.SelectedItem = abiturient.Gender;
            dateTimePicker.Value = abiturient.Birthday;
            cmbFormaObucheniya.SelectedItem = abiturient.FormaObucheniya;

        }

        public Abiturientinfo_form(Abiturient sourse) : this()
        {
            abiturient = sourse;
            txtName.Text = sourse.FullName;
            cmbGender.SelectedItem = sourse.Gender;
            dateTimePicker.Value = sourse.Birthday;
            cmbFormaObucheniya.SelectedItem = sourse.FormaObucheniya;
            txtMatem.Value = sourse.Matem;
            txtRus.Value = sourse.Rus;
            txtInf.Value = sourse.Inf;

        }
        public Abiturient Abiturient => abiturient;

        public void FillGender()
        {
            foreach (Gender item in Enum.GetValues(typeof(Gender)))
            {
                cmbGender.Items.Add(item);
            }
        }

        public void FillFormaObucheniya()
        {
            foreach (FormaObucheniya item in Enum.GetValues(typeof(FormaObucheniya)))
            {
                cmbFormaObucheniya.Items.Add(item);
            }
        }
        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedIndex >= 0)
            {
                abiturient.Gender = (Gender)cmbGender.SelectedItem;
            }
        }

        private void cmbFormaObucheniya_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormaObucheniya.SelectedIndex >= 0)
            {
                abiturient.FormaObucheniya = (FormaObucheniya)cmbFormaObucheniya.SelectedItem;
            }
        }

        private void cmbGender_DrawItem(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if (parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                if (e.Index >= 0)
                {
                    if (parent.Items[e.Index] is Gender gender)
                    {
                        var text = gender == Gender.Male
                            ? "Mужской"
                            : "Женский";

                        e.Graphics.DrawString(
                            text,
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                    else
                    {
                        e.Graphics.DrawString(
                            parent.Items[e.Index].ToString(),
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                }
            }
        }


        private void cmbFormaObucheniya_DrawItem(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if (parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                if (e.Index >= 0)
                {
                    if (parent.Items[e.Index] is FormaObucheniya formaobucheniya)
                    {

                        string text = "";
                        switch (formaobucheniya)
                        {
                            case (FormaObucheniya.Ochnoe):
                                text = "Очное";
                                break;
                            case (FormaObucheniya.Ocno_zaochnoe):
                                text = "Очно-заочное";
                                break;
                            case (FormaObucheniya.Zaochnoe):
                                text = "Заочное";
                                break;
                        }

                        e.Graphics.DrawString(
                            text,
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                    else
                    {
                        e.Graphics.DrawString(
                            parent.Items[e.Index].ToString(),
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                }
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            abiturient.Birthday = dateTimePicker.Value;
        }

        private void txtMatem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void txtRus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void txtInf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
            abiturient.FullName = txtName.Text;
        }

        private void txtMatem_ValueChanged_1(object sender, EventArgs e)
        {
            abiturient.Matem = txtMatem.Value;
        }

        private void txtRus_ValueChanged(object sender, EventArgs e)
        {
            abiturient.Rus = txtRus.Value;
        }

        private void txtInf_ValueChanged(object sender, EventArgs e)
        {
            abiturient.Inf = txtInf.Value;
        }
    }
}

