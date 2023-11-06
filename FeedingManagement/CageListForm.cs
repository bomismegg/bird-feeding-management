using BusinessObject.Models;
using DataAccess;
using Repositories.IRepository;
using Repositories.Repository;
using System;
using System.Windows.Forms;

namespace FeedingManagement
{
    public partial class CageListForm : Form
    {
        private ICageRepository cageRepository = new CageRepository();

        public CageListForm()
        {
            InitializeComponent();

            // Attach event handlers
            //newBtn.Click += newBtn_Click;
            //updateBtn.Click += updateBtn_Click;
            //removeBtn.Click += removeBtn_Click;
            //dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            
        }

        private void LoadCages()
        {
            try
            {
                var cageList = cageRepository.GetCages();
                BindingSource source = new BindingSource();
                source.DataSource = cageList;

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
                ClearCageFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ClearCageFields()
        {
            txtID.Text = "";
            textBox1.Text = "";
            radioAuto.Checked = true; // Set the automatic radio button as default
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var cage = new Cage
                {
                    Name = textBox1.Text,
                    IsAutomatic = radioAuto.Checked
                };
                cageRepository.AddCage(cage);
                LoadCages();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int cageId))
            {
                var cageToUpdate = cageRepository.GetCageById(cageId);
                if (cageToUpdate != null)
                {
                    cageToUpdate.Name = textBox1.Text;
                    cageToUpdate.IsAutomatic = radioAuto.Checked;
                    cageRepository.UpdateCage(cageToUpdate);
                    LoadCages();
                }
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int cageId))
            {
                try
                {
                    cageRepository.DeleteCage(cageId);
                    LoadCages();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedCage = dataGridView1.SelectedRows[0].DataBoundItem as Cage;
                if (selectedCage != null)
                {
                    txtID.Text = selectedCage.Id.ToString();
                    textBox1.Text = selectedCage.Name;
                    if (selectedCage.IsAutomatic ?? false)
                        radioAuto.Checked = true;
                    else
                        radioManual.Checked = true;
                }
            }
        }

        private void CageListForm_Load(object sender, EventArgs e)
        {
            LoadCages();
        }
    }
}
