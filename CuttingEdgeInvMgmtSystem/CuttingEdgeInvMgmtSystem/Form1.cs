using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections; // For Arraylist

namespace CuttingEdgeInvMgmtSystem
{
    public partial class Form1 : Form
    {
        private int width;
        private int length;
        //string type;
        private dbCounterTopsDataContext dbContext = DataAccess.DataAdapter.dbContext;
        private List<Color> changeListColors = new List<Color>();
        private ArrayList BarsArray = new ArrayList(); //using Arraylist to contain Bars


        public Form1()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(3000);
            t.Abort();
            InitializeComponent();
            TrimDatabase();
        }

        private void TrimDatabase()
        {
            int minLength = 4;
            var deleteBarTops = from barTop in dbContext.BarTops
                                where barTop.Length < minLength
                                select barTop;

            dbContext.BarTops.DeleteAllOnSubmit(deleteBarTops.ToList());

            var deleteKitchenTops = from kitchenTop in dbContext.Kitchens
                                where kitchenTop.Length < minLength
                                select kitchenTop;

            dbContext.Kitchens.DeleteAllOnSubmit(deleteKitchenTops.ToList());

            var deleteVanity = from vanityTops in dbContext.Vanities
                                where vanityTops.Length < minLength
                                select vanityTops;

            dbContext.Vanities.DeleteAllOnSubmit(deleteVanity.ToList());

            dbContext.SubmitChanges();
        }

        public void StartForm()
        {
            Application.Run(new frmSplashScreen());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Activate(); // Focus on the software after the splash screen is closed
            LoadColorsToList();

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (submitValidation())
            {
                if (RadioBtnBar.Checked == true)
                {
                    if(int.TryParse(TxtBxLength.Text, out length))
                    {
                        BarTop newBarTop = new BarTop
                        {
                            Length = length,
                            Width = width,
                            ColorID = GetColorId(ComboBoxColorList.Text)       
                        };
                        //changeListBarTops.Add(newBarTop);
                        BarsArray.Add(newBarTop);
                        TxtBxLength.Clear();
                    }
                }
                else if (RadioBtnVanity.Checked == true)
                {
                    if (int.TryParse(TxtBxLength.Text, out length))
                    {
                        Vanity newVainity = new Vanity
                        {
                            Length = length,
                            ColorID = GetColorId(ComboBoxColorList.Text)
                        };
                        //changeListVanity.Add(newVainity);
                        BarsArray.Add(newVainity);
                        TxtBxLength.Clear();
                    }
                }
                else if (RadioBtnKitchen.Checked == true)
                {
                    if (int.TryParse(TxtBxLength.Text, out length))
                    {
                        Kitchen newKitchen = new Kitchen
                        {
                            Length = length,
                            ColorID = GetColorId(ComboBoxColorList.Text)
                        };
                        //changeListKitchen.Add(newKitchen);
                        BarsArray.Add(newKitchen);
                        TxtBxLength.Clear();
                    }
                }
                ChangeListBoxUpdate();
            }
            else
            {
               // MessageBox.Show($"Please enter required information");          
            }

        }
        private void InfoList_SelectedIndexChanged(object sender, EventArgs e)
        {
             // needs code!!
            
        }

        #region Add Data Buttons
        private void BarRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBtnBar.Checked)
            {
                BarTopVisible(true);
                //type = "BarTop";
          
            }
        }
        private void KitchenRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            BarTopVisible(false);
            //type = "Kitchen";
            //Console.WriteLine(type);
        }
        private void VanityRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            BarTopVisible(false);
            //type = "Vanity";
        }

        // Can we use radio buttons for bar 27 and bar 36 ?
        private void Bar27CheckBx_CheckedChanged(object sender, EventArgs e)
        {
            CheckBxBar36.Checked = !CheckBxBar27.Checked;
            width = 27;
            
        }
        private void Bar36CheckBx_CheckedChanged(object sender, EventArgs e)
        {
            CheckBxBar27.Checked = !CheckBxBar36.Checked;
            width = 36;
        }
        #endregion

        private void BarTopVisible(bool switcher)
        {
            CheckBxBar27.Visible = switcher;
            CheckBxBar36.Visible = switcher;
        }

        private void ComboBoxColorList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



 
        private void ToolStripMenuAddColor_Click(object sender, EventArgs e)
        {
            GroupBxAddColor.Visible = true;
        }
         
        private void ToolStripMenuPrintReport_Click(object sender, EventArgs e)
        {
            Reports.CreateReport();
        }

        private void BtnAddColor_Click_1(object sender, EventArgs e)
        {
            
            if (dbContext.Colors.Any(color => color.Color1 == TxtBxAddColor.Text.ToString()))
            {
                TxtBxAddColor.Text = "Already Added!";
            }
            else
            {
                Color newColor = new Color
                {
                    Color1 = TxtBxAddColor.Text.ToString()
                };
                dbContext.Colors.InsertOnSubmit(newColor);
                GroupBxAddColor.Visible = false;
            }
            SubmitDatabaseChanges();
            LoadColorsToList();
        }

        private void removeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deleteColor = dbContext.Colors.FirstOrDefault(o => o.Color1.Equals(ComboBoxColorList.SelectedItem));
            dbContext.Colors.DeleteOnSubmit(deleteColor);
            SubmitDatabaseChanges();
            LoadColorsToList();
            
        }

        #region Utility Methods
        /// <summary>
        /// Gets Color Id from Database
        /// </summary>
        /// <param name="colorString"></param>
        /// <returns></returns>
        private int GetColorId(string colorString)
        {
            Color color = dbContext.Colors.FirstOrDefault(o => o.Color1.Equals(colorString));
            return color.ColorID;
        }


        /// <summary>
        /// Submits Pending Changes to the Database
        /// </summary>
        private void SubmitDatabaseChanges()
        { 
            // Using arrayList
            foreach (var item in BarsArray)
            {
                if (item.GetType() == typeof(BarTop))
                {
                    BarTop bar = (BarTop)item; // Explicit cast var item to BarTop object 
                    dbContext.BarTops.InsertOnSubmit(bar);
                }
                if (item.GetType() == typeof(Kitchen))
                {
                    Kitchen kitchen = (Kitchen)item;
                    dbContext.Kitchens.InsertOnSubmit(kitchen);

                }
                if (item.GetType() == typeof(Vanity))
                {
                    Vanity vanity = (Vanity)item;
                    dbContext.Vanities.InsertOnSubmit(vanity);
                }
            }

            try
            {
                dbContext.SubmitChanges();
                BarsArray.Clear(); 
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("You cannot remove a color that has inventory");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            InfoList.Items.Clear();
        }

        /// <summary>
        /// Pulls all colors from Color table and populates ColorList combobox
        /// </summary>
        private void LoadColorsToList()
        {
            var colorList = (from color in dbContext.Colors select color.Color1);  // FROM *INSTANCE holder* in *Database.Table* Select *INSTANCE.column *
            ComboBoxColorList.ValueMember = "Color";
            ComboBoxColorList.DataSource = colorList;
        }

        private void ChangeListBoxUpdate()
        {
            InfoList.Items.Clear();

            foreach (var item in BarsArray)
            {
                InfoList.Items.Add(item);
            }
        }

        #endregion

        private void InfoList_KeyPress(object sender, KeyPressEventArgs e)
       {
            if(e.KeyChar == (char)8 | e.KeyChar == (char)Keys.Delete && InfoList.SelectedIndex != -1)
            {
                BarsArray.RemoveAt(InfoList.SelectedIndex);                
            }
            ChangeListBoxUpdate();
        }
        #region Validating input data 
        private bool submitValidation()
        {
            if (ComboBoxColorList.SelectedItem != null)
            {
                if(TxtBxLength.Text == "")
                {
                    MessageBox.Show($"Unable to convert '{TxtBxLength.Text}' to Length");
                    return false;
                }
                else
                {
                    if (RadioBtnBar.Checked == true)
                    {
                        if (CheckBxBar27.Checked == false && CheckBxBar36.Checked == false)
                        {
                            MessageBox.Show($"Please choose the width of the BarTop");
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    return true;
                }
            }
            else
            {
                MessageBox.Show($"Please select color");
                return false;
            }
        }

        // Only allow number on the length box 
        private void TxtBxLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region Tool Strip
        private void toolStripSave_Click(object sender, EventArgs e)
        {
            SubmitDatabaseChanges();
        }
        private void toolStripRemove_Click(object sender, EventArgs e)
        {
            if (InfoList.SelectedIndex == -1)
            {
                MessageBox.Show($"Please chose item to remove");
            }
            else
            {
                BarsArray.RemoveAt(InfoList.SelectedIndex);
                foreach (var item in BarsArray)
                {
                    Console.WriteLine(item);
                }
                InfoList.SelectedIndex = -1;
                ChangeListBoxUpdate();
            }
        }
        private void ToolStripMenuCurrentInvetory_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCurrentInventory inventoryForm = new FrmCurrentInventory(this);
            inventoryForm.ShowDialog();
        }

        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
           
        }
    }
}
