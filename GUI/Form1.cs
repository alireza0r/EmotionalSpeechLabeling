using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using System.Data.SqlClient;
//using System.IO;
//using LINQtoCSV;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO.Compression;

namespace GUI
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public string[] user_full_info; // selected user info

        // file in drive
        string all_user_info; // all users info
        string user_voting_data = @"ID,FileName,StrongEmotion,WeakEmotion,FirstName,LastName,Gender,Age,Date";
        string user_info_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\AutESD\AppData\infos.txt";
        string users_voting_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\AutESD\AppData\Votes";
        string appdata_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\AutESD\AppData";
        public string database_info_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\AutESD\AppData\datasetsInfo.txt";

        string[] header = { "ID", "FileName", "StrongEmotion", "WeakEmotion", "FirstName", "LastName", "Gender", "Age", "Date" };

        // SQL
        //SqlConnection conn = new SqlConnection();
        //SqlCommand cmd1 = new SqlCommand();

        //SqlDataAdapter da = new SqlDataAdapter();
        //DataSet ds = new DataSet();

        //string tabel_name = "T1";

        public string DatasetPath = "Dataset";

        string filename = "";

        string csv_path = "";

        //string app_data_path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
        //string sql_path = "AutESD_SQL";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            //string filename = filename_function(true);
            //int file_name_index = filename.LastIndexOf(@"\") + 1;
            //filename = filename.Substring(file_name_index);

            Tuple<string, string> emotions = get_radio_emotional_keys_function();
            string strong = emotions.Item1;
            string weak = emotions.Item2;

            //string disp = "File name: " + filename;
            //disp += "  |  Strong=" + strong + " , Weak =" + weak;
            //MessageBox.Show(disp);

            //SqlCommand c1 = new SqlCommand();
            //c1.CommandText = "insert into TblEmotion values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
            //c1.Parameters.AddWithValue("p1", filename);
            //c1.Parameters.AddWithValue("p2", strong);
            //c1.Parameters.AddWithValue("p3", weak);
            //c1.Parameters.AddWithValue("p4", user_full_info[0]);
            //c1.Parameters.AddWithValue("p5", user_full_info[1]);
            //c1.Parameters.AddWithValue("p6", user_full_info[3]);
            //c1.Parameters.AddWithValue("p7", user_full_info[2]);
            //c1.Parameters.AddWithValue("p8", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            //c1.Connection = conn;
            //conn.Open();
            //c1.ExecuteNonQuery(); // Save sql to disk
            //conn.Close();

            //@"ID,FileName,StrongEmotion,WeakEmotion,FirstName,LastName,Gender,Age,Date\n";
            string[] split_data = { get_ID_of_voting_file(),
                              filename,
                              strong,
                              weak,
                              user_full_info[0],
                              user_full_info[1],
                              user_full_info[3], // gender
                              user_full_info[2], // age
                              DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                            };
            string new_data = string.Join(",", split_data);

            add_data_to_user_voting_file(new_data);
            fill_grid();

            deactivate_radios();

            radioshappy.Enabled = false;
            radiosneutral.Enabled = false;
            radiossad.Enabled = false;
            radiosangry.Enabled = false;

            radiowhappy.Enabled = false;
            radiowneutral.Enabled = false;
            radiowsad.Enabled = false;
            radiowangry.Enabled = false;

            btnnext.Enabled = false;

            string path = filename_function(true);
            if (path!=null)
            {
                player.SoundLocation = path;
                player.Load();
            }
            else
            {
                full_answerd_actions();
            }
            
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            player.Play();

            radioshappy.Enabled = true;
            radiosneutral.Enabled = true;
            radiossad.Enabled = true;
            radiosangry.Enabled = true;

            radiowhappy.Enabled = true;
            radiowneutral.Enabled = true;
            radiowsad.Enabled = true;
            radiowangry.Enabled = true;
        }

        private void radiostrong_Click(object sender, EventArgs e)
        {
            Tuple<string, string> emotions = get_radio_emotional_keys_function();
            string strong = emotions.Item1;
            string weak = emotions.Item2;
            if (strong != "" && weak != "")
                btnnext.Enabled = true;
        }

        private void radioweak_Click(object sender, EventArgs e)
        {
            Tuple<string, string> emotions = get_radio_emotional_keys_function();
            string strong = emotions.Item1;
            string weak = emotions.Item2;
            if (strong != "" && weak != "")
                btnnext.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Connect to SQL
            string startup_path = Application.StartupPath.ToString();
            //int file_name_index = startup_path.LastIndexOf(@"\");
            //startup_path = startup_path.Remove(file_name_index);
            //file_name_index = startup_path.LastIndexOf(@"\");
            //startup_path = startup_path.Remove(file_name_index);

            //MessageBox.Show(startup_path);

            //string path = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + app_data_path + "\\" + sql_path + @"\EmotionDataset.mdf; Integrated Security = True";
            //conn.ConnectionString = path;
            //conn.Open();

            user_info user = new user_info(this);
            user.ShowDialog();

            all_user_info = load_specific_user_data(user_info_path);

            if (search_for_user_votiong_data(users_voting_path, user_full_info[0], user_full_info[1])) // user voting file is exist.
            {
                get_user_voting_data(users_voting_path, user_full_info[0], user_full_info[1]);
            }
            fill_grid();

            string sound_path = filename_function(true);
            if (sound_path != null)
            {
                sound_initialize(sound_path);
            }
            else
            {
                full_answerd_actions();
            }
             
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void btnmute_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsaveandclose_Click(object sender, EventArgs e)
        {
            save_all_system_file();
            Application.Exit();
        }

        private void sound_initialize(string file_path)
        {
            // Load music
            //player.SoundLocation = filename_function(true);
            player.SoundLocation = file_path;
            player.Load();
        }

        private string filename_function(bool Next)
        {
            if (Next)
            {
                // Search in Dataset dir for files
                string[] files_in_dir = System.IO.Directory.GetFiles(DatasetPath, "*.wav");

                var rnd = new Random();
                var randomized = files_in_dir.OrderBy(item => rnd.Next());

                foreach (string x in randomized)
                {
                    //MessageBox.Show(x);
                    int file_name_index = x.LastIndexOf(@"\") + 1;
                    filename = x.Substring(file_name_index);

                    //string query = @"select * from TblEmotion where FileName = '" + filename + "'";

                    //MessageBox.Show(query);
                    //MessageBox.Show(search_exist_dataset(query).ToString());

                    if (search_in_user_voting_data(filename) == false)
                        break;
                    else
                        filename = null;
                }
            }

            if (filename == null)
                return null;

            string sound_path = Application.StartupPath;
            sound_path = sound_path + "\\" + DatasetPath + "\\" + filename;
            return sound_path;
        }

        private Tuple<string, string> get_radio_emotional_keys_function()
        {
            string strong="", weak="";

            foreach (RadioButton x in gbstrongemotion.Controls)
                if (x.Checked)
                    strong = x.Text.ToString();

            foreach (RadioButton x in gbweakemotion.Controls)
                if (x.Checked)
                    weak = x.Text.ToString();

            return Tuple.Create(strong, weak);
        }

        private void deactivate_radios()
        {
            foreach (RadioButton x in gbstrongemotion.Controls)
                x.Checked = false;

            foreach (RadioButton x in gbweakemotion.Controls)
                x.Checked = false;
        }

        public void user_info_function(string[] full_info)
        {
            user_full_info = full_info;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fill_grid()
        {
            dataGridView.ColumnCount = header.Length;
            string[] data_split = make_rows_of_csv(user_voting_data);

            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            foreach (string row in data_split)
                dataGridView.Rows.Add(row.Split(','));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        //public DataSet read_ram_dataset(string s= "Select * from TblEmotion")
        //{
        //    cmd1.CommandText = s;
        //    cmd1.Connection = conn;

        //    da.SelectCommand = cmd1;
        //    ds.Clear();
        //    da.Fill(ds, tabel_name);

        //    return ds;
        //}

        //private bool search_exist_dataset(string query)
        //{
        //    SqlCommand command = new SqlCommand();
        //    command.CommandText = query;
        //    command.Connection = conn;
        //    conn.Open();
        //    SqlDataReader reader = command.ExecuteReader();
        //    //while(reader.Read())
        //    //{
        //    //    MessageBox.Show(reader.GetValue(0).ToString() + reader.GetValue(1).ToString() + reader.GetValue(2).ToString());
        //    //}

        //    bool result = reader.Read();
        //    conn.Close();
        //    return result;
        //}

        private void full_answerd_actions()
        {
            MessageBox.Show("Thanks a lot.\nYou answered all the emotional speeches.");
            btnplay.Enabled = false;
            btnstop.Enabled = false;

            radioshappy.Enabled = false;
            radiosneutral.Enabled = false;
            radiossad.Enabled = false;
            radiosangry.Enabled = false;

            radiowhappy.Enabled = false;
            radiowneutral.Enabled = false;
            radiowsad.Enabled = false;
            radiowangry.Enabled = false;

            btnnext.Enabled = false;
        }

        //private void sql_save_as_csv_file(string path, string query = "Select * from TblEmotion")
        //{
        //    SqlCommand command = new SqlCommand();
        //    command.CommandText = query;
        //    command.Connection = conn;
        //    conn.Open();
        //    SqlDataReader reader = command.ExecuteReader();

        //    // Create csv file
        //    var emotion_list = new List<csvFormat>
        //    {
        //        //new csvFormat {FileName = "h2_2.wav", StrongEmotion="Happy", WeakEmotion="Sad", FirstName="Majid", LastName="Akbari", Gender="Male", Age="12", Date=DateTime.Now },
        //    };

        //    while (reader.Read())
        //    {
        //        emotion_list.Add(new csvFormat
        //        {
        //            FileName = reader.GetValue(0).ToString(),
        //            StrongEmotion = reader.GetValue(1).ToString(),
        //            WeakEmotion = reader.GetValue(2).ToString(),
        //            FirstName = reader.GetValue(3).ToString(),
        //            LastName = reader.GetValue(4).ToString(),
        //            Gender = reader.GetValue(5).ToString(),
        //            Age = reader.GetValue(6).ToString(),
        //            Date = DateTime.Now
        //        });
        //    }

        //    conn.Close();

        //    var csvFileDescription = new CsvFileDescription
        //    {
        //        FirstLineHasColumnNames = true,
        //        SeparatorChar = ',',
        //    };

        //    var csvContext = new CsvContext();
        //    csvContext.Write(emotion_list, csv_path, csvFileDescription);
        //}

        private void saveAsACsvFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlog = new SaveFileDialog();
            dlog.Filter = "CSV files |*.csv";

            if (dlog.ShowDialog() == DialogResult.OK)
            {
                csv_path = dlog.FileName;
                saveCsvFile(user_voting_data, csv_path);
                //MessageBox.Show("empty");
                //sql_save_as_csv_file(csv_path);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (csv_path == "")
            {
                MessageBox.Show("You must use Save As before saving.", "could not be saved...",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                saveCsvFile(user_voting_data, csv_path);
                //MessageBox.Show("empty");
                //sql_save_as_csv_file(csv_path);
            }
        }

        void saveCsvFile(string data, string path)
        {
            System.IO.File.WriteAllText(path, data);
            MessageBox.Show("The user voting file saved in " + path);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string txt = "";
            txt += "This program was written to label AutESD datasets.\n";
            txt += "Thank you for using this app.\n\n";
            txt += "In the future, this program will be freely shared on the author's GitHub";
            txt += ", so that we can help others who want to label to the audio data.\n\n";

            txt += "Also, this program is related to speech laboratory of electrical engineering";
            txt += " department of Amirkabir University of Technology\n\n";
            txt += "The laboratory link(SSPL): http://ele.aut.ac.ir/~sprl/ (After pressing Ok, it will be copied)\n\n";

            txt += "Creator: Alireza Rahmati\n";
            txt += "GitHub: https://github.com/alireza0r \n";
            txt += "Gmail: a.a.rahmati.r.r@gmail.com (is active for your reports)";

            System.Windows.Forms.Clipboard.SetDataObject("http://ele.aut.ac.ir/~sprl/", true);
            MessageBox.Show(txt);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_all_system_file();
            Application.Exit();
        }

        private string load_specific_user_data(string csvInfoPath)
        {
            return System.IO.File.ReadAllText(csvInfoPath);
        }

        void get_user_voting_data(string path, string firstname, string lastname)
        {
            string file_name = firstname.ToUpper() + "_" + lastname.ToUpper();
            user_voting_data = System.IO.File.ReadAllText(path + "\\" + file_name + ".csv");
        }

        bool search_for_user_votiong_data(string path, string firstname, string lastname)
        {
            string file_name = firstname.ToUpper() + "_" + lastname.ToUpper() + ".csv";
            return System.IO.File.Exists(path + "\\" + file_name);
        }

        public string[] make_rows_of_csv(string data)
        {
            return data.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
        }

        public string[] make_colmuns_of_row(string row)
        {
            return row.Split(',');
        }

        public bool search_in_user_voting_data(string str)
        {
            return user_voting_data.Contains(str);
        }

        private void add_data_to_user_voting_file(string data)
        {
            user_voting_data = user_voting_data + Environment.NewLine + data;
        }

        private string get_ID_of_voting_file()
        {
            string[] rows = make_rows_of_csv(user_voting_data);
            return rows.Length.ToString();
            //string[] columns = make_colmuns_of_row(rows[rows.Length - 1]);
            //return columns[0];
        }

        void save_all_system_file()
        {
            string name = users_voting_path + "\\" + user_full_info[0].ToUpper() + "_" + user_full_info[1].ToUpper() + ".csv";
            System.IO.File.WriteAllText(name, user_voting_data);
        }

        private void allDataExpertToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlog = new SaveFileDialog();
            dlog.Filter = "Excel files |*.xls|Excel files |*.xlsx";

            if (dlog.ShowDialog() == DialogResult.OK)
            {
                string excel_path = dlog.FileName;

                string[] filess_in_dir = System.IO.Directory.GetFiles(users_voting_path, "*.csv");
                ExportCsvToExcelFile(excel_path, filess_in_dir);
            }
        }

        private void ExportCsvToExcelFile(string savePath, string[] path_list)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook workbook = exApp.Workbooks.Add("");
            Excel.Sheets sheets = workbook.Sheets;

            foreach(string path in path_list)
            {
                Excel.Worksheet worksheet = sheets.Add(sheets[1]);
                worksheet.Name = System.IO.Path.GetFileName(path).Split('.')[0];
                Excel.Range exRange = worksheet.UsedRange;

                int n_row = 1;
                string data = System.IO.File.ReadAllText(path);
                foreach (string row in make_rows_of_csv(data))
                {
                    int n_column = 1;
                    foreach (string columns_in_row in make_colmuns_of_row(row))
                    {
                        exRange.Cells[n_row, n_column] = columns_in_row;
                        n_column++;
                    }
                    n_row ++;
                }
            }

            try
            {
                workbook.SaveAs(savePath);
                saving_delay_form(5);
                MessageBox.Show("Excel saved in " + savePath);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Sorry, your operating system doesn't allow to replace the file.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            exApp.Quit();
        }

        private void exportAllToZipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlog = new SaveFileDialog();
            dlog.Filter = "Zip files |*.zip";

            if (dlog.ShowDialog() == DialogResult.OK)
            {
                string zip_path = dlog.FileName;

                try
                {
                    ZipFile.CreateFromDirectory(appdata_path, zip_path);
                    saving_delay_form(5);
                    MessageBox.Show("Zip saved in " + zip_path);
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Sorry, zip file is exist and your operating system doesn't allow me to replace the file.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void saving_delay_form(int delay = 5)
        {
            SavingForm w = new SavingForm();

            Task.Delay(TimeSpan.FromSeconds(delay))
                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
            w.ShowDialog();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dataBaseDir browesDir = new dataBaseDir();
            //browesDir.Show();
            //MessageBox.Show(user_full_info[0]);
            //MessageBox.Show("3");
        }

        public void save_database_path(string path)
        {
            DatasetPath = path;
            write_dataset_path(database_info_path, user_full_info[0].ToUpper() + "_" + user_full_info[1].ToUpper()); 
        }

        void write_dataset_path(string path, string userName)
        {
            StringBuilder stFile = new StringBuilder();

            if (System.IO.File.Exists(path))
            {
                string last_data = System.IO.File.ReadAllText(path);
                string[] last_rows = make_rows_of_csv(last_data);

                for (int j = 0; j < (last_rows.Length - 1);)
                {
                    stFile.AppendLine(last_rows[j]);
                    j++;
                }
            }


            stFile.AppendLine(userName + "," + path);
            System.IO.File.WriteAllText(database_info_path, stFile.ToString());
            MessageBox.Show(stFile.ToString());
        }

        private void resetFactoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete file?", "Delete users file.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (System.IO.File.Exists(user_info_path))
                {
                    System.IO.File.Delete(user_info_path);
                    MessageBox.Show("All useres deleted.");
                }
                else
                    MessageBox.Show("No file found.");
            }

            
                
        }

        private void resetFactoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all files?", "Delete users file.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (System.IO.File.Exists(user_info_path))
                {
                    try
                    {
                        foreach(string file in System.IO.Directory.GetFiles(users_voting_path))
                        {
                            //MessageBox.Show(file);
                            System.IO.File.Delete(file);
                        }
                        System.IO.File.Delete(user_info_path);

                        MessageBox.Show("All files deleted.");
                        user_voting_data = @"ID,FileName,StrongEmotion,WeakEmotion,FirstName,LastName,Gender,Age,Date";
                        fill_grid();

                    }
                    catch (System.IO.IOException)
                    {
                        MessageBox.Show("Error.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("No file found.");
            }
        }
    }
}
