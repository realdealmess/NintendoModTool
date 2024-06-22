using NintendoModTool;
using System;
using System.Data;
using System.Windows.Forms;

namespace NintendoModTool
{
    public partial class Form1 : Form
    {
        private NESRom _rom;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dgvChrData.Columns.Clear();
            for (int i = 0; i < 16; i++)
            {
                dgvChrData.Columns.Add(i.ToString("X2"), i.ToString("X2"));
            }
        }

        private void PopulateDataGridView(byte[] chrData)
        {
            dgvChrData.Rows.Clear();
            for (int i = 0; i < chrData.Length; i += 16)
            {
                var row = new DataGridViewRow();
                for (int j = 0; j < 16; j++)
                {
                    if (i + j < chrData.Length)
                    {
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = chrData[i + j].ToString("X2") });
                    }
                    else
                    {
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = "00" });
                    }
                }
                dgvChrData.Rows.Add(row);
            }
        }

        private void btnLoadRom_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "NES files (*.nes)|*.nes";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _rom = new NESRom(openFileDialog.FileName);
                    txtRomInfo.Text = _rom.GetHeaderInfo();
                    PopulateDataGridView(_rom.CHR);
                }
            }
        }

        private void btnSaveRom_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "NES files (*.nes)|*.nes";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _rom.SaveRom(saveFileDialog.FileName);
                    MessageBox.Show("ROM saved successfully!");
                }
            }
        }

        private void btnModifyPrg_Click(object sender, EventArgs e)
        {
            if (_rom != null)
            {
                try
                {
                    int offset = int.Parse(txtPrgOffset.Text);
                    byte value = byte.Parse(txtPrgValue.Text);
                    _rom.ModifyPRGData(offset, value);
                    MessageBox.Show("PRG data modified successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error modifying PRG data: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No ROM loaded.");
            }
        }

        private void btnModifyChr_Click(object sender, EventArgs e)
        {
            if (_rom != null)
            {
                try
                {
                    int offset = int.Parse(txtChrOffset.Text);
                    byte value = byte.Parse(txtChrValue.Text);
                    _rom.ModifyCHRData(offset, value);
                    PopulateDataGridView(_rom.CHR); // Refresh the display
                    MessageBox.Show("CHR data modified successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error modifying CHR data: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No ROM loaded.");
            }
        }
    }
}
