using BusinessObject.Models;
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
    public partial class CageEntryForm : Form
    {
        private ICageRepository cageRepository = new CageRepository();
        private IBirdRepository birdRepository = new BirdRepository();
        private IFoodRepository foodRepository = new FoodRepository();
        private List<Bird> cageBirds = new List<Bird>();
        private Dictionary<int, List<Food>> cageFoods = new Dictionary<int, List<Food>>();
        private List<Food> addedFoods = new List<Food>();
        public string LabelText
        {
            get
            {
                return lbTitle.Text;
            }
            set
            {
                lbTitle.Text = value;
            }
        }
        private Cage cage;

        public CageEntryForm()
        {
            InitializeComponent();

            txtID.ReadOnly = false;
            LoadComboboxData();
        }
        public CageEntryForm(Cage cage)
        {
            InitializeComponent();

            if (cage != null)
            {
                this.cage = cage;
                LoadComboboxData();
                LoadData(cage);
            }
        }
        private void LoadData(Cage _cage)
        {
            txtID.Text = _cage.Id.ToString();
            txtName.Text = _cage.Name;
            cbIsAutomatic.SelectedItem = _cage.IsAutomatic.ToString();
            cbStatus.SelectedItem = _cage.Status.ToString();

            cageBirds = _cage.Birds.ToList();
            if (cageFoods.ContainsKey(_cage.Id))
            {
                cbFoods.DataSource = cageFoods[_cage.Id];
                cbFoods.DisplayMember = "Name";
            }
            else
            {
                cbFoods.DataSource = null;
            }

            cbBirds.DataSource = cageBirds;
            cbBirds.DisplayMember = "Name";
        }
        private void LoadComboboxData()
        {
            cbIsAutomatic.Items.Add("True");
            cbIsAutomatic.Items.Add("False");

            cbStatus.Items.Add("True");
            cbStatus.Items.Add("False");

            cbNewBirds.DataSource = birdRepository.GetBirds();
            cbNewBirds.DisplayMember = "Name";

            cbNewFoods.DataSource = foodRepository.GetFoods();
            cbNewFoods.DisplayMember = "Food";
        }
        private void btnAddBird_Click(object sender, EventArgs e)
        {
            Bird bird = cbNewBirds.SelectedItem as Bird;
            if (this.cage == null && !cageBirds.Contains(bird))
            {
                cageBirds.Add(bird);
                cbBirds.DataSource = null;
                cbBirds.DataSource = cageBirds;
                cbBirds.DisplayMember = "Name";
            }
            else 
            {
                if (cageBirds.Contains(bird))
                {
                    return;
                }
                cage.Birds.Add(bird);
                cageBirds.Add(bird);
                LoadData(cage);
            }
        }
        /*
            
         */
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Food food = cbNewFoods.SelectedItem as Food;
            if (food != null && !addedFoods.Contains(food))
            {
                addedFoods.Add(food);

                if (this.cage == null)
                {
                    cbFoods.DataSource = null;
                    cbFoods.DataSource = addedFoods;
                    cbFoods.DisplayMember = "Name";
                }
                else
                {
                    if (!cageFoods.ContainsKey(cage.Id))
                    {
                        cageFoods[cage.Id] = new List<Food>();
                    }
                    cageFoods[cage.Id].Add(food);

                    LoadData(cage);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.cage == null)
            {
                Cage newCage = new Cage()
                {
                    Id = Convert.ToInt32((txtID.Text).ToString()),
                    Name = txtName.Text,
                    IsAutomatic = Convert.ToBoolean(cbIsAutomatic.SelectedItem.ToString()),
                    Status = Convert.ToBoolean(cbStatus.SelectedItem.ToString()),
                    Birds = cageBirds,
                    CageFoods = addedFoods.Select(food => new CageFood
                    {
                        Cageid = Convert.ToInt32(txtID.Text),
                        Foodid = food.Id,
                        Remaining = 0,
                        Capacity = 0
                    }).ToList()
                };
                cageRepository.AddCage(newCage);
                CageManagement _form = new CageManagement();
                this.Close();
                _form.ShowDialog();
            }
            else
            {
                cage.Name = txtName.Text;
                cage.IsAutomatic = Convert.ToBoolean(cbIsAutomatic.SelectedItem.ToString());
                cage.Status = Convert.ToBoolean(cbStatus.SelectedItem.ToString());
                cage.Birds = cageBirds;
                cage.CageFoods = addedFoods.Select(food => new CageFood
                {
                    Cageid = cage.Id,
                    Foodid = food.Id,
                    Remaining = 0,
                    Capacity = 0
                }).ToList();
                cageRepository.UpdateCage(cage);
                CageManagement _form = new CageManagement();
                this.Close();
                _form.ShowDialog();
            }
        }
    }
    
}
