using SqlDers.controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace SqlDers
{
    
    public partial class Front : Form
    {
        Business business;
        GUIDTestController testController;
        ModelController modelController;

        public DataTable dt;
        DataGridView dataGridView = new DataGridView
        {
            Location = new System.Drawing.Point(650, 50), // Konumu ayarla
            Size = new System.Drawing.Size(700, 700),    // Boyutu ayarla
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        };
        


        public Front()
        {
            testController = new GUIDTestController();
            modelController = new ModelController();
            business = new Business();
            
            InitializeComponent();
        }

        private void Connect_Load(object sender, EventArgs e)
        {
            Button model=new Button(); 
            Button guid=new Button();
            model.Text = "model";
            guid.Text = "guid";
            model.Top = 700;
            model.Left = 1400;
            model.Width = 100;
            model.Height = 50;
            model.Click += modelLister;
            Controls.Add(model);
            guid.Top = 600;
            guid.Left = 1400;
            guid.Width = 100;
            guid.Height = 50;
            guid.Click += gUIDTestLister;
            Controls.Add(guid);
            ButtonLister();
        }
        void ButtonLister()
        {
            int placeX=55;
            int placeY=55;
            int i = 0;
            foreach (string name in business.DataNameFinder())
            {
                if (i == 8) { placeX += 100; placeY = 55; i = 0; }
                ButtonAdd(placeY,placeX,name);
                placeY += 110;
                i++;
            }
        }
        

        /*public void saveB()
        {
            Button button = new Button();
            button.Top = 800;
            button.Left = 800;
            button.Text = "save";
            button.Width = 50;
            button.Height = 50;
            button.Click += saver;
            Controls.Add(button);
        }*/
        private void ButtonAdd(int top, int left, string text)
        {
            Button button = new Button();
            button.Top = top;
            button.Left = left;
            button.Text = text;
            button.Width = 100;
            button.Height = 50;
            button.Click += Lister;
            Controls.Add(button);  
        }
        private void Lister(object sender,EventArgs e)
        {
            try
            {
            int i = 0;
            Button clickedButton = sender as Button;
            dt = business.BringList(clickedButton.Text);
            dataGridView.DataSource=dt;
            dataGridView.ReadOnly = true;
            Controls.Add(dataGridView); 
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void gUIDTestLister(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                Button clickedButton = sender as Button;
                dataGridView.DataSource = testController.GetAll();
                dataGridView.ReadOnly = true;
                Controls.Add(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void modelLister(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                Button clickedButton = sender as Button;
                dataGridView.DataSource = modelController.GetAll();
                dataGridView.ReadOnly = true;
                Controls.Add(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /*private void saver(object sender,EventArgs e)
        {
            string query = "INSERT INTO [dukkan].[dbo].[GUIDTest] (isim) VALUES (@isim)";

            try
            {
                using (SqlCommand command = new SqlCommand(query, test))
                {
                    // Parametreleri ekliyoruz
                    //command.Parameters.AddWithValue("@no", txtGirdiNum.Text);
                    command.Parameters.AddWithValue("@isim", txtGirdiName.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Numara ve isim başarıyla eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenemedi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
    }
}

