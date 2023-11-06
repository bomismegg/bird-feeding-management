using BusinessObject.Models;
using DataAccess;
using Microsoft.EntityFrameworkCore;
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
    public partial class BirdManagementView : Form
    {
        IBirdRepository birdRepository = new BirdRepository();
        public BirdManagementView()
        {
            InitializeComponent();
        }

        private void BirdManagementView_Load(object sender, EventArgs e)
        {
            LoadBirds();

        }

        public void LoadBirds()
        {
            try
            {
                var birdList = birdRepository.GetBirds();
                BindingSource source = new BindingSource();
                source.DataSource = birdList;

                txtId.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtCageId.DataBindings.Clear();
                txtAge.DataBindings.Clear();
                txtFeathering.DataBindings.Clear();
                txtPregnant.DataBindings.Clear();

                txtId.DataBindings.Add("Text", source, "Id");
                txtName.DataBindings.Add("Text", source, "Name");
                txtCageId.DataBindings.Add("Text", source, "CageId");
                txtAge.DataBindings.Add("Text", source, "AgePeriod");
                txtFeathering.DataBindings.Add("Text", source, "isFeathering");
                txtPregnant.DataBindings.Add("Text", source, "isPregnant");

                dgvBirdList.DataSource = null;
                dgvBirdList.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void DgvBirdList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvBirdList.Columns["Cage"].Index && e.RowIndex >= 0)
            {
                if (dgvBirdList.Rows[e.RowIndex].DataBoundItem is Bird bird)
                {
                    e.Value = bird.Cage.Name;
                    e.FormattingApplied = true;
                }
            }
            if (e.ColumnIndex == dgvBirdList.Columns["BirdFoods"].Index && e.RowIndex >= 0)
            {
                if (e.Value is ICollection<BirdFood> birdFoods)
                {
                    e.Value = $"Array[{birdFoods.Count}]";
                    e.FormattingApplied = true;
                }
            }
        }

        private void DgvBirdList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBirdList.SelectedRows.Count > 0)
            {
                Bird selectedBird = dgvBirdList.SelectedRows[0].DataBoundItem as Bird;

                if (selectedBird != null)
                {
                    selectedBird = birdRepository.GetBirdWithFoods(selectedBird.Id);

                    cboFoods.DataSource = selectedBird.BirdFoods.Select(bf => bf.Food).ToList();
                    cboFoods.DisplayMember = "Name";
                }

            }
            else
            {
                cboFoods.DataSource = null;
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Bird newBird = new Bird
                {
                    Name = txtName.Text,
                    Cageid = int.Parse(txtCageId.Text),
                    AgePeriod = (txtAge.Text),
                    IsFeathering = bool.Parse(txtFeathering.Text),
                    IsPregnant = bool.Parse(txtPregnant.Text)
                };

                birdRepository.AddBird(newBird);
                LoadBirds();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int birdId))
            {
                Bird birdToUpdate = birdRepository.GetBirdById(birdId);

                if (birdToUpdate != null)
                {
                    // Update bird properties with values from textboxes
                    birdToUpdate.Name = txtName.Text;
                    birdToUpdate.Cageid = int.Parse(txtCageId.Text);
                    birdToUpdate.AgePeriod = (txtAge.Text);
                    birdToUpdate.IsFeathering = bool.Parse(txtFeathering.Text);
                    birdToUpdate.IsPregnant = bool.Parse(txtPregnant.Text);

                    try
                    {
                        birdRepository.UpdateBird(birdToUpdate);
                        LoadBirds();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int birdId))
            {
                try
                {

                    birdRepository.DeleteBird(birdId);
                    LoadBirds();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
