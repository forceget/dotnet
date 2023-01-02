﻿using AirPort;
using AutomaticPricing;
using City;
using Country;
using Forceget.Apilibrary;
using Location;
using Port;
using RestSharp.Extensions;
using State;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Token;
using static AirPort.MAirPort;
using static AutomaticPricing.MAutomaticPricing;
using static Port.MPort;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace SimpleDeveloper
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Login(object sender, EventArgs e)
        {
            try
            {
                MToken.FilterForm formtoken = new MToken.FilterForm();
                formtoken.Email = emailTextBox.Text;
                formtoken.PasswordHash = passwordTextBox.Text;

                var response = RToken.Login(formtoken);

                if (response.status == 200)
                {
                    MessageBox.Show("Login Successful");
                }
                else 
                {
                    foreach (var item in response.statusTexts)
                    {
                        MessageBox.Show(item.ToString());
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void airPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RAirPort airPort = new RAirPort();
                MAirPort.FilterForm formAirPort = new MAirPort.FilterForm();

                formAirPort.Take = Int32.Parse(takedropdown.Text.ToString());
                formAirPort.Offset = 0;
                formAirPort.Sort.Column = "NAME";
                formAirPort.Sort.Type = "ASC";

                var data = airPort.MultipleGet(formAirPort);

                if (data != null)
                {
                    dataGridView1.DataSource = data.item.ToList();
                }
                else
                {
                    MessageBox.Show("Data null ! Check login information.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void portToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RPort r = new RPort();
                MPort.FilterForm formPort = new MPort.FilterForm();
                formPort.Take = Int32.Parse(takedropdown.Text.ToString());
                formPort.Offset = 0;
                formPort.Sort.Column = "NAME";
                formPort.Sort.Type = "ASC";

                var data = r.MultipleGet(formPort);
                if (data != null)
                {
                    dataGridView1.DataSource = data.item.ToList();
                }
                else
                {
                    MessageBox.Show("Data null ! Check login information.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RCountry country = new RCountry();
                MCountry.FilterForm formCountry = new MCountry.FilterForm();
                formCountry.Take = Int32.Parse(takedropdown.Text.ToString());
                formCountry.Offset = 0;
                formCountry.Sort.Column = "NAME";
                formCountry.Sort.Type = "ASC";

                var data = country.MultipleGet(formCountry);
                if (data != null)
                {
                    dataGridView1.DataSource = data.item.ToList();
                }
                else
                {
                    MessageBox.Show("Data null ! Check login information.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void stateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RState state = new RState();
                MState.FilterForm formState = new MState.FilterForm();
                formState.Take = Int32.Parse(takedropdown.Text.ToString());
                formState.Offset = 0;
                formState.Sort.Column = "NAME";
                formState.Sort.Type = "ASC";

                var data = state.MultipleGet(formState);
                if (data != null)
                {
                    dataGridView1.DataSource = data.item.ToList();
                }
                else
                {
                    MessageBox.Show("Data null ! Check login information.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RCity city = new RCity();
                MCity.FilterForm formCity = new MCity.FilterForm();
                formCity.Take = Int32.Parse(takedropdown.Text.ToString());
                formCity.Offset = 0;
                formCity.Sort.Column = "NAME";
                formCity.Sort.Type = "ASC";

                var data = city.MultipleGet(formCity);
                if (data != null)
                {
                    dataGridView1.DataSource = data.item.ToList();
                }
                else
                {
                    MessageBox.Show("Data null ! Check login information.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RLocation location = new RLocation();
                MLocation.FilterForm formLocation = new MLocation.FilterForm();
                formLocation.Take = Int32.Parse(takedropdown.Text.ToString());
                formLocation.Offset = 0;
                formLocation.Sort.Column = "NAME";
                formLocation.Sort.Type = "ASC";
                List<int> LocationTyp = new List<int>() { 1 };
                formLocation.LocationType = LocationTyp;

                var data = location.MultipleGet(formLocation);
                if (data != null)
                {
                    dataGridView1.DataSource = data.item.ToList();
                }
                else
                {
                    MessageBox.Show("Data null ! Check login information.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void amazonFulfillmentCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RLocation location = new RLocation();
                MLocation.FilterForm formLocation = new MLocation.FilterForm();
                formLocation.Take = Int32.Parse(takedropdown.Text.ToString());
                formLocation.Offset = 0;
                formLocation.Sort.Column = "NAME";
                formLocation.Sort.Type = "ASC";
                List<int> LocationTyp = new List<int>() { 1 };
                formLocation.LocationType = LocationTyp;

                var data = location.MultipleGet(formLocation);
                if (data != null)
                {
                    dataGridView1.DataSource = data.item.ToList();
                }
                else
                {
                    MessageBox.Show("Data null ! Check login information.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void forcegetWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RLocation location = new RLocation();
                MLocation.FilterForm formLocation = new MLocation.FilterForm();

                formLocation.Take = Int32.Parse(takedropdown.Text.ToString());
                formLocation.Offset = 0;
                formLocation.Sort.Column = "NAME";
                formLocation.Sort.Type = "ASC";
                List<int> LocationTyp = new List<int>() { 7 };
                formLocation.LocationType = LocationTyp;

                var data = location.MultipleGet(formLocation);
                if (data != null)
                {
                    dataGridView1.DataSource = data.item.ToList();
                }
                else
                {
                    MessageBox.Show("Data null ! Check login information.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                switch (aPIsToolStripMenuItem.Checked)
                {
                    //case "0":
                    //    Console.WriteLine("Today is Saturday.");
                    //    break;
                    //case "1":
                    //    Console.WriteLine("Today is Sunday.");
                    //    break;
                    default:
                        Console.WriteLine("Looking forward to the Weekend.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
        private void GetAQuate(object sender, EventArgs e)
        {
            try
            {
                RAutomaticPricing r = new RAutomaticPricing();
                MAutomaticPricing.Form formGetAQuate = new MAutomaticPricing.Form();
                MToken.FilterForm formtoken = new MToken.FilterForm();
                formtoken.Email = emailTextBox.Text;
                formtoken.PasswordHash = passwordTextBox.Text;

                var response = RToken.Login(formtoken);

                formGetAQuate.Email = emailTextBox.Text;
                formGetAQuate.FirstName = response.item.firstName;
                formGetAQuate.LastName = response.item.lastName;
                formGetAQuate.PhoneNumber = response.item.phoneNumber;
                formGetAQuate.CompanyName = response.item.details.Select(x => x.companyInfo.name).FirstOrDefault();
                formGetAQuate.CompanyId = response.item.details.Select(x => x.companyId).FirstOrDefault();


                formGetAQuate.FromType = comboBox2.Text.ToString();
                formGetAQuate.FromLocationCountryId = (comboBox3.SelectedItem as dynamic).Value;
                formGetAQuate.FromLocationId = (comboBox4.SelectedItem as dynamic).Value;

                formGetAQuate.ToType = comboBox5.Text.ToString();
                formGetAQuate.ToLocationCountryId = (comboBox4.SelectedItem as dynamic).Value;
                formGetAQuate.ToLocationId = (comboBox7.SelectedItem as dynamic).Value;
                if (formGetAQuate.FromType == "Port/Airport")
                {
                    formGetAQuate.Packages = new List<FAutomaticPricingPackage>();
                    formGetAQuate.Packages.Add(new FAutomaticPricingPackage
                    {
                        Height = textBox3.Text,
                        Length = textBox1.Text,
                        MetricType = "Metric",
                        PackageTypeId = "3",
                        TotalUnit = textBox4.Text,
                        Weight = textBox5.Text,
                        Width = textBox2.Text
                    });
                    formGetAQuate.ShipmentLoadType = 1;
                }
                else
                {
                    formGetAQuate.Containers = new List<FAutomaticPricingContainer>();
                    formGetAQuate.Containers.Add(new FAutomaticPricingContainer
                    {
                        TotalUnit = textBox7.Text,
                        Size = comboBox8.Text.ToString(),
                    });
                    formGetAQuate.ShipmentLoadType = 2;
                }

                formGetAQuate.ProductAmount = textBox6.Text;
                formGetAQuate.ProductReadyDate = monthCalendar1.SelectionRange.Start.ToString();
                if (checkBox1.Checked == true)
                {
                    formGetAQuate.HazardousGoods = 1;

                }
                else
                {
                    formGetAQuate.HazardousGoods = 2;

                }
                if (checkBox2.Checked == true)
                {
                    formGetAQuate.Insurance = 1;

                }
                else
                {
                    formGetAQuate.Insurance = 2;

                }
                if (checkBox3.Checked == true)
                {
                    formGetAQuate.CustomsClearance = 1;

                }
                else
                {
                    formGetAQuate.CustomsClearance = 2;

                }

                var data = r.GetAQuate(formGetAQuate);
                if (data.status == 200)
                {
                    MessageBox.Show(data.statusText);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MToken.FilterForm formtoken = new MToken.FilterForm();
                formtoken.Email = emailTextBox.Text;
                formtoken.PasswordHash = passwordTextBox.Text;

                var response = RToken.Login(formtoken);

                RLocation location = new RLocation();
                MLocation.FilterForm formLocation = new MLocation.FilterForm();
                formLocation.Take = 100000;
                formLocation.Offset = 0;
                formLocation.Sort.Column = "NAME";
                formLocation.Sort.Type = "ASC";
                formLocation.CountryId = (comboBox3.SelectedItem as dynamic).Value;
                if (comboBox2.Text.ToString() == "Port/Airport")
                {
                    List<int> LocationTypePortAirport = new List<int>() { 8, 9 };
                    formLocation.LocationType = LocationTypePortAirport;
                }
                else if (comboBox2.Text.ToString() == "Factory/Warehouse")
                {
                    List<int> LocationTypeAmazon = new List<int>() { 1, 2, 3, 5, 6, 7, 12 };
                    formLocation.LocationType = LocationTypeAmazon;
                }
                var dataLocation = location.MultipleGet(formLocation).item;
                foreach (var items in dataLocation)
                {
                    comboBox4.Items.Add(new { Text = items.name, Value = items.id });
                    comboBox4.DisplayMember = "Text";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox6.SelectedIndex == -1)
                {
                    comboBox6.Items.Clear();
                }
                MToken.FilterForm formtoken = new MToken.FilterForm();
                formtoken.Email = emailTextBox.Text;
                formtoken.PasswordHash = passwordTextBox.Text;
                var response = RToken.Login(formtoken);
                RCountry country = new RCountry();
                MCountry.FilterForm formCountry = new MCountry.FilterForm();
                formCountry.Take = 1000;
                formCountry.Offset = 0;
                formCountry.Sort.Column = "NAME";
                formCountry.Sort.Type = "ASC";
                if (comboBox5.Text.ToString() == "Amazon Fulfillment Center")
                {
                    comboBox6.Items.Add(new { Text = "United States", Value = "cd4928df-b552-4c56-8601-e861aac3a923" });
                    comboBox6.DisplayMember = "Text";
                }
                else if (comboBox5.Text.ToString() == "Forceget Warehouse")
                {
                    comboBox6.Items.Add(new { Text = "United States", Value = "cd4928df-b552-4c56-8601-e861aac3a923" });
                    comboBox6.Items.Add(new { Text = "Canada", Value = "c1b56132-9ab5-4515-9e70-40058a4819f9" });
                    comboBox6.DisplayMember = "Text";

                }
                else if (comboBox5.Text.ToString() == "Business Address")
                {
                    var data = country.MultipleGet(formCountry).item;
                    foreach (var items in data)
                    {
                        comboBox6.Items.Add(new { Text = items.name, Value = items.id });
                        comboBox6.DisplayMember = "Text";
                    }
                }
                else if (comboBox5.Text.ToString() == "Port/Airport")
                {
                    var data = country.MultipleGet(formCountry).item;
                    foreach (var items in data)
                    {
                        comboBox6.Items.Add(new { Text = items.name, Value = items.id });
                        comboBox6.DisplayMember = "Text";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MToken.FilterForm formtoken = new MToken.FilterForm();
                formtoken.Email = emailTextBox.Text;
                formtoken.PasswordHash = passwordTextBox.Text;
                var response = RToken.Login(formtoken);

                RLocation location = new RLocation();
                MLocation.FilterForm formLocation = new MLocation.FilterForm();

                formLocation.Take = 10000;
                formLocation.Offset = 0;
                formLocation.Sort.Column = "NAME";
                formLocation.Sort.Type = "ASC";
                formLocation.CountryId = (comboBox6.SelectedItem as dynamic).Value;

                if (comboBox5.Text.ToString() == "Amazon Fulfillment Center")
                {
                    List<int> LocationTypePortAirport = new List<int>() { 1 };
                    formLocation.LocationType = LocationTypePortAirport;

                }
                else if (comboBox5.Text.ToString() == "Forceget Warehouse")
                {
                    List<int> LocationTypeForcegetWarehouse = new List<int>() { 1, 7 };
                    formLocation.LocationType = LocationTypeForcegetWarehouse;
                }
                else if (comboBox5.Text.ToString() == "Business Addres")
                {
                    List<int> LocationTypeBusinessAddress = new List<int>() { 12 };
                    formLocation.LocationType = LocationTypeBusinessAddress;
                }
                else if (comboBox5.Text.ToString() == "Port/Airport")
                {
                    List<int> LocationTypePortAirport = new List<int>() { 8, 9 };
                    formLocation.LocationType = LocationTypePortAirport;
                }
                var dataLocation2 = location.MultipleGet(formLocation).item;
                foreach (var items in dataLocation2)
                {
                    comboBox7.Items.Add(new { Text = items.name, Value = items.id });
                    comboBox7.DisplayMember = "Text";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MToken.FilterForm formtoken = new MToken.FilterForm();
                formtoken.Email = emailTextBox.Text;
                formtoken.PasswordHash = passwordTextBox.Text;
                var response = RToken.Login(formtoken);

                RCountry country = new RCountry();
                MCountry.FilterForm formCountry = new MCountry.FilterForm();

                formCountry.Take = 1000;
                formCountry.Offset = 0;
                formCountry.Sort.Column = "NAME";
                formCountry.Sort.Type = "ASC";

                var data = country.MultipleGet(formCountry).item;
                foreach (var items in data)
                {
                    comboBox3.Items.Add(new { Text = items.name, Value = items.id });
                    comboBox3.DisplayMember = "Text";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (panel3.Visible.Equals(true))
            {
                panel3.Visible = false;
            }
            else
            {
                panel3.Visible = true;
            }
            panel4.Visible = false;
            panel5.Visible = false;
            panel8.Visible = false;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (panel4.Visible.Equals(true))
            {
                panel4.Visible = false;
            }
            else
            {
                panel4.Visible = true;
            }
            panel3.Visible = false;
            panel5.Visible = false;
            panel8.Visible = false;

        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (panel5.Visible.Equals(true))
            {
                panel5.Visible = false;
            }
            else
            {
                panel5.Visible = true;
            }
            panel4.Visible = false;
            panel3.Visible = false;
            panel8.Visible = false;

        }
        private void button13_Click_1(object sender, EventArgs e)
        {
            if (panel8.Visible.Equals(true))
            {
                panel8.Visible = false;
            }
            else
            {
                panel8.Visible = true;

            }
            panel4.Visible = false;
            panel5.Visible = false;
            panel3.Visible = false;

        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (panel6.Visible.Equals(true) && panel7.Visible.Equals(true))
            {
                panel6.Visible = false;
                panel7.Visible = true;
            }
            else
            {
                panel6.Visible = true;
                panel7.Visible = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (panel6.Visible.Equals(true) && panel7.Visible.Equals(true))
            {
                panel7.Visible = false;
                panel6.Visible = true;
            }
            else
            {
                panel7.Visible = true;
                panel6.Visible = false;

            }
        }
        private void panel3_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text.ToString() == "Port/Airport")
            {
                panel6.Visible = true;
                panel7.Visible = false;
            }
            else if (comboBox2.Text.ToString() == "Factory/Warehouse")
            {
                panel7.Visible = true;
                panel6.Visible = false;
            }
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void button22_Click(object sender, EventArgs e)
        {

        }


        private void button23_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible.Equals(true))
            {
                monthCalendar1.Visible = false;
            }
            else
            {
                monthCalendar1.Visible = true;

            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "L")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "L";
                textBox1.ForeColor = Color.Silver;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "W")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "W";
                textBox2.ForeColor = Color.Silver;
            }
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "H")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "H";
                textBox3.ForeColor = Color.Silver;
            }
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Total Unit")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Total Unit";
                textBox4.ForeColor = Color.Silver;
            }
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Kg")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Kg";
                textBox5.ForeColor = Color.Silver;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button18_Click(object sender, EventArgs e)
        {

        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel9.Visible = true;
            this.panel9.Location = new System.Drawing.Point(12, 24);
            this.ClientSize = new System.Drawing.Size(1005, 765);

        }

        private void getAQuateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.ClientSize = new System.Drawing.Size(1325, 648);
        }
        private void aPIsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel9.Visible = false;
            panel2.Visible = true;
            this.panel2.Location = new System.Drawing.Point(12, 24);
            //this.panel2.Size = new System.Drawing.Size(1772, 652);
            this.ClientSize = new System.Drawing.Size(1772, 652);

        }
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void serverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.Server = serverComboBox.Text;
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("chrome.exe");

                startInfo.WindowStyle = ProcessWindowStyle.Minimized;

                startInfo.UseShellExecute = true;

                startInfo.Verb = "runas";

                startInfo.Arguments = "https://app.forceget.com/GetAQuote";

                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
    }
}
