using BusinessObject.Models;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FeedingManagement
{
    public partial class FoodListForm : Form
    {
        IFoodRepository foodRepository = new FoodRepository();

        public FoodListForm()
        {
            InitializeComponent();
        }

        private void FoodListForm_Load(object sender, EventArgs e)
        {
            LoadFoods();
        }

        public void LoadFoods()
        {
            try
            {
                var foodList = foodRepository.GetFoods();
                BindingSource source = new BindingSource();
                source.DataSource = foodList;

                txtId.DataBindings.Clear();
                txtName.DataBindings.Clear();

                txtId.DataBindings.Add("Text", source, "Id");
                txtName.DataBindings.Add("Text", source, "Name");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Food newFood = new Food
                {
                    Name = txtName.Text,
                };

                foodRepository.AddFood(newFood);
                LoadFoods();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int foodId))
            {
                Food foodToUpdate = foodRepository.GetFoodById(foodId);

                if (foodToUpdate != null)
                {
                    foodToUpdate.Name = txtName.Text;

                    try
                    {
                        foodRepository.UpdateFood(foodToUpdate);
                        LoadFoods();
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
            if (int.TryParse(txtId.Text, out int foodId))
            {
                try
                {
                    foodRepository.DeleteFood(foodId);
                    LoadFoods();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
