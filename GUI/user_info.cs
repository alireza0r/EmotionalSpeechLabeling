using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI
{
    public partial class user_info : Form
    {
        bool ok_flag = false;
        Form1 frmInfo = new Form1();
        string user_info_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\AutESD\AppData\infos.txt";
        string users_data = "";

        public user_info(Form1 HomefrmInfo)
        {
            frmInfo = HomefrmInfo;
            InitializeComponent();
        }

        private void btnuserok_Click(object sender, EventArgs e)
        {
            string[] full_info = { txtname.Text.ToString(),
                                   txtlastname.Text.ToString(),
                                   txtage.Text.ToString(),
                                   cboxgender.SelectedItem.ToString(),
                                   DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                                   txtbrrowse.Text.ToString()};

            string[] rows = make_rows_of_csv(users_data);
            int n_row = 0;
            foreach(string row in rows)
            {
                if(search_in_user_data(txtname.Text.ToString(), txtlastname.Text.ToString()))
                {
                    string[] column = make_colmuns_of_row(row);
                    if (column[column.Length - 1] != txtbrrowse.Text.ToString())
                    {
                        column[column.Length - 1] = txtbrrowse.Text.ToString();
                        string new_data = string.Join(",", column);
                        update_info_file(n_row, new_data);
                    }
                        
                    break;
                }
                n_row++;
            }

            if (!search_in_user_data(txtname.Text.ToString(), txtlastname.Text.ToString()))
            {
                user_info_save(user_info_path, full_info);
                MessageBox.Show("User added.");
            }
            frmInfo.user_info_function(full_info);

            ok_flag = true;
            this.Close();
        }

        private void userinfo_txtchange(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtlastname.Text != "" && txtage.Text != "" && cboxgender.Text != "")
                btnuserok.Enabled = true;
        }

        private void user_info_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ok_flag)
                Environment.Exit(1);
        }

        private void user_info_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(user_info_path))
            {
                users_data = System.IO.File.ReadAllText(user_info_path);
                string[] each_user_info = make_rows_of_csv(users_data);
                string[] last_user = make_colmuns_of_row(each_user_info[each_user_info.Length - 2]); // last user

                txtname.Text = last_user[0]; // first name
                txtlastname.Text = last_user[1]; // last name
                cboxgender.Text = last_user[3]; // gender
                txtage.Text = last_user[2]; // age
                txtbrrowse.Text = last_user[5]; // dataset path
            }
            else
                txtbrrowse.Text = frmInfo.DatasetPath;
            //DataSet ds = frmInfo.read_ram_dataset();

                //cr = (CurrencyManager)this.BindingContext[ds, "T1"];
                //cr.Position = cr.Count -1;

                //txtname.DataBindings.Add("text", ds, "T1.FirstName");
                //txtlastname.DataBindings.Add("text", ds, "T1.LastName");
                //txtage.DataBindings.Add("text", ds, "T1.age");
                //cboxgender.DataBindings.Add("text", ds, "T1.Gender");
        }

        public void user_info_save(string user_info_path, string[] user_data)
        {
            StringBuilder stFile = new StringBuilder();

            if (System.IO.File.Exists(user_info_path))
            {
                string last_data = System.IO.File.ReadAllText(user_info_path);
                string[] last_rows = make_rows_of_csv(last_data);

                for (int j=0; j < (last_rows.Length-1);)
                {
                    stFile.AppendLine(last_rows[j]);
                    j++;
                }
            }
            

            stFile.AppendLine(string.Join(",", user_data));
            System.IO.File.WriteAllText(user_info_path, stFile.ToString());          
            
        }

        public string[] make_rows_of_csv(string data)
        {
            return data.Split('\n');
        }

        public string[] make_colmuns_of_row(string row)
        {
            return row.Split(',');
        }

        public bool search_in_user_data(string firstName, string lastName)
        {
            return users_data.Contains(firstName + "," + lastName);
        }

        private void btnreset_Click(object sender, EventArgs e) // Local database button
        {
            txtbrrowse.Text = frmInfo.DatasetPath;
        }
            

        private void txtbrrowse_Leave(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(txtbrrowse.Text))
            {
                MessageBox.Show("Please insert valid path.\n");
                txtbrrowse.Text = frmInfo.DatasetPath;
            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlog = new FolderBrowserDialog();

            if (dlog.ShowDialog() == DialogResult.OK)
            {
                string path = dlog.SelectedPath;

                txtbrrowse.Text = path;
            }
        }

        private void update_info_file(int n_row, string new_data)
        {
            StringBuilder stFile = new StringBuilder();

            string last_data = System.IO.File.ReadAllText(user_info_path);
            string[] last_rows = make_rows_of_csv(last_data);

            for (int j = 0; j < (last_rows.Length - 1);)
            {
                if (j != n_row)
                    stFile.AppendLine(last_rows[j]);
                else
                    stFile.AppendLine(new_data);

                j++;
            }
            System.IO.File.WriteAllText(user_info_path, stFile.ToString());
        }
    }
}
