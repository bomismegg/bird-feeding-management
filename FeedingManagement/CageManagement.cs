using BusinessObject.Models;
using DataAccess;
using Repositories.IRepository;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedingManagement
{
    public partial class CageManagement : Form
    {
        ICageRepository _cageRepository = new CageRepository();
        IBirdRepository _birdRepository = new BirdRepository();
        IFoodRepository _foodRepository = new FoodRepository();
        public CageManagement()
        {
            InitializeComponent();

            LoadCages();
        }


        private void LoadCages()
        {
            var list = _cageRepository.GetCages();
            BindingSource source = new BindingSource();
            source.DataSource = list;

            txtID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtStatus.DataBindings.Clear();
            txtAutomatic.DataBindings.Clear();

            txtID.DataBindings.Add(new Binding("Text", source, "id", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", source, "name", true, DataSourceUpdateMode.Never));
            txtStatus.DataBindings.Add(new Binding("Text", source, "isAutomatic", true, DataSourceUpdateMode.Never));
            txtAutomatic.DataBindings.Add(new Binding("Text", source, "status", true, DataSourceUpdateMode.Never));

            dtgvCages.DataSource = null;
            dtgvCages.DataSource = source;
        }

        private void dtgvCages_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvCages.SelectedRows.Count > 0)
            {
                Cage cage = dtgvCages.SelectedRows[0].DataBoundItem as Cage;

                if (cage != null)
                {
                    cbBirds.DataSource = _birdRepository.GetBirdsByCageId(cage.Id);
                    cbBirds.DisplayMember = "Name";

                    cbCageFoods.DataSource = _foodRepository.GetCageFoodByCageId(cage.Id);
                    cbCageFoods.DisplayMember = "Food";
                }
            }
        }

        private void dtgvCages_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var dtgv = (DataGridView)sender;
                var dataBoundItem = dtgv.Rows[e.RowIndex].DataBoundItem;

                if (dataBoundItem is Cage cage)
                {
                    if (dtgv.Columns[e.ColumnIndex].Name == "Birds")
                    {
                        e.Value = $"{cage.Birds.Where(bird => bird.Cageid == cage.Id).Count()}";
                        e.FormattingApplied = true;
                    }
                    if (dtgv.Columns[e.ColumnIndex].Name == "CageFoods")
                    {
                        e.Value = $"{cage.CageFoods.Where(cf => cf.Cageid == cage.Id).Count()}";
                        e.FormattingApplied = true;
                    }
                    if (dtgv.Columns[e.ColumnIndex].Name == "Images")
                    {
                        e.Value = $"{cage.Images.Where(img => img.Cageid == cage.Id).Count()}";
                        e.FormattingApplied = true;
                    }
                    if (dtgv.Columns[e.ColumnIndex].Name == "Plans")
                    {
                        e.Value = $"{cage.Plans.Where(plan => plan.Cageid == cage.Id).Count()}";
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CageEntryForm form = new CageEntryForm();
            this.Hide();
            form.Text = "New Cage Form";
            form.LabelText = "NEW CAGE";
            form.ShowDialog();
            LoadCages();
            this.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtgvCages.SelectedRows.Count > 0)
            {
                Cage cage = dtgvCages.SelectedRows[0].DataBoundItem as Cage;

                if (cage != null)
                {
                    CageEntryForm form = new CageEntryForm(cage);
                    this.Hide();
                    form.Text = "Update Cage Form";
                    form.LabelText = "UPDATE CAGE";
                    form.ShowDialog();
                    LoadCages();
                    this.Show();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int cageId = Convert.ToInt32(txtID.Text);
            DialogResult result = MessageBox.Show("Do you want to remove this cage from list?", "Cage Management", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _cageRepository.DeleteCage(cageId);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit cage management?", "Cage Management", MessageBoxButtons.YesNo);
            if ( result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
