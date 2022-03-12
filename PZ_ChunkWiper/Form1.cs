using System;
using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PZ_ChunkWiper
{
    public partial class PZ_ChunkWiper : Form
    {
        public static string ActualPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        public PZ_ChunkWiper()
        {
            InitializeComponent();
        }

        private void btn_ChunkPath_Click(object sender, EventArgs e)
        {
            var fbd = new FolderPicker();
            fbd.InputPath = ActualPath;

            if (fbd.ShowDialog() == true && !string.IsNullOrWhiteSpace(fbd.ResultPath))
            {
                lbl_ChunkPath.Text = fbd.ResultPath + @"\";
                if (File.Exists(lbl_ChunkPath.Text + @"\vehicles.db") && rb_Wipe.Checked)
                {
                    cbx_Vehicles.Enabled = true;
                }
            }
        }

        private void LogWrite(string logMessage)
        {
            try
            {
                
                    if (logMessage != "")
                    richTextBox1.Text += DateTime.Now.ToLongTimeString() + ": " + logMessage + Environment.NewLine;
                
            }
            catch
            {
            }
        }

        private void SQLite_Vehicles(string db_path)
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=" + db_path + "");
         // Open the connection:
         try
            {
                int X1 = int.Parse(tbx_ChunkX.Value.ToString()) * 300;
                int Y1 = int.Parse(tbx_ChunkY.Value.ToString()) * 300;
                int X2 = (int.Parse(tbx_ChunkX2.Value.ToString()) * 300) + 300;
                int Y2 = (int.Parse(tbx_ChunkY2.Value.ToString()) * 300) + 300;
                sqlite_conn.Open();
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "DELETE FROM vehicles WHERE (x BETWEEN '" + X1.ToString() + "' AND '" + X2.ToString() + "') AND (y BETWEEN '" + Y1.ToString() + "' AND '" + Y2.ToString() + "');";

                int rowsUpdated = sqlite_cmd.ExecuteNonQuery();
                LogWrite(rowsUpdated.ToString() + " Vehicles deleted");

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Application.DoEvents();
                sqlite_conn.Close();
            }

        }


        private void btn_ChunkReset_Click(object sender, EventArgs e)
        {
            if (File.Exists(lbl_ChunkPath.Text + @"\vehicles.db") && cbx_Vehicles.Checked)
            {
                SQLite_Vehicles(lbl_ChunkPath.Text + @"\vehicles.db");
            }

            int X1 = int.Parse(tbx_ChunkX.Value.ToString()) * 30;
            int Y1 = int.Parse(tbx_ChunkY.Value.ToString()) * 30;
            int X2 = (int.Parse(tbx_ChunkX.Value.ToString()) + 1) * 30;
            int Y2 = (int.Parse(tbx_ChunkY.Value.ToString()) + 1) * 30;
            int CellX = int.Parse(tbx_ChunkX.Value.ToString());
            int CellX2 = int.Parse(tbx_ChunkX2.Value.ToString());
            int CellY = int.Parse(tbx_ChunkY.Value.ToString());
            int CellY2 = int.Parse(tbx_ChunkY2.Value.ToString());
            if (rb_Zone.Checked)
            {
                X2 = (int.Parse(tbx_ChunkX2.Value.ToString()) + 1) * 30;
                Y2 = (int.Parse(tbx_ChunkY2.Value.ToString()) + 1) * 30;
            }
            int count = 0;
            for (int i = X1; i < X2; i++)
            {
                for (int j = Y1; j < Y2; j++)
                {

                    if (File.Exists(lbl_ChunkPath.Text + @"\map_" + i + "_" + j + ".bin"))
                    {
                        count++;
                        //LogWrite("Deleted : map_" + i + "_" + j + ".bin (" + count + ")");
                        File.Delete(lbl_ChunkPath.Text + @"\map_" + i + "_" + j + ".bin");
                    }
                }
            }
            LogWrite("Deleted : " + count + " map files");
            count = 0;
            int zcount = 0;
            for (int i = CellX; i <= CellX2; i++)
            {
                for (int j = CellY; j <= CellY2; j++)
                {
                    if (File.Exists(lbl_ChunkPath.Text + @"\chunkdata_" + i.ToString() + "_" + j.ToString() + ".bin"))
                    {
                        count++;
                        //LogWrite("Deleted : " + @"\chunkdata_" + i.ToString() + "_" + j.ToString() + ".bin");
                        File.Delete(lbl_ChunkPath.Text + @"\chunkdata_" + i.ToString() + "_" + j.ToString() + ".bin");
                    }
                    if (cbx_Zombies.Checked)
                    {
                        if (File.Exists(lbl_ChunkPath.Text + @"\zpop_" + i.ToString() + "_" + j.ToString() + ".bin"))
                        {
                            zcount++;
                            //LogWrite("Deleted : " + @"\zpop_" + i.ToString() + "_" + j.ToString() + ".bin");
                            File.Delete(lbl_ChunkPath.Text + @"\zpop_" + i.ToString() + "_" + j.ToString() + ".bin");
                        }
                    }

                }
            }
            LogWrite("Deleted : " + count + " chunkdata files");
            LogWrite("Deleted : " + zcount + " zpop files");
            MessageBox.Show("Done !");
        }


        private void rb_Zone_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Zone.Checked)
            {
                tbx_ChunkX2.Enabled = true;
                tbx_ChunkY2.Enabled = true;
            }
            else
            {
                tbx_ChunkX2.Enabled = false;
                tbx_ChunkY2.Enabled = false;
            }
        }

        private void tbx_ChunkX_ValueChanged(object sender, EventArgs e)
        {
            if (tbx_ChunkX2.Value < tbx_ChunkX.Value) tbx_ChunkX2.Value = tbx_ChunkX.Value;

        }

        private void tbx_ChunkY_ValueChanged(object sender, EventArgs e)
        {
            if (tbx_ChunkY2.Value < tbx_ChunkY.Value) tbx_ChunkY2.Value = tbx_ChunkY.Value;
        }

        private void tbx_ChunkX2_ValueChanged(object sender, EventArgs e)
        {
            if (tbx_ChunkX2.Value < tbx_ChunkX.Value) tbx_ChunkX2.Value = tbx_ChunkX.Value;
        }

        private void tbx_ChunkY2_ValueChanged(object sender, EventArgs e)
        {
            if (tbx_ChunkY2.Value < tbx_ChunkY.Value) tbx_ChunkY2.Value = tbx_ChunkY.Value;
        }

        private void rb_Wipe_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Wipe.Checked)
            {
                if (File.Exists(lbl_ChunkPath.Text + @"\vehicles.db"))
                {
                    cbx_Vehicles.Enabled = true;
                }
                btn_ChunkReset.Enabled = true;
                cbx_Zombies.Enabled = true;

                btn_Save.Enabled = false;
                cbx_Age.Enabled = false;
            }
        }

        private void rb_Save_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Save.Checked)
            {
                btn_ChunkReset.Enabled = false;
                cbx_Zombies.Enabled = false;
                cbx_Vehicles.Enabled = false;

                btn_Save.Enabled = true;
                cbx_Age.Enabled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(lbl_ChunkPath.Text + @"\save")) Directory.CreateDirectory(lbl_ChunkPath.Text + @"\save");

            if (File.Exists(lbl_ChunkPath.Text + @"\vehicles.db"))
            {
                File.Copy(lbl_ChunkPath.Text + @"\vehicles.db", lbl_ChunkPath.Text + @"\save\vehicles.db", true);
                LogWrite("Saved : vehicles.db files");
            }
            if (File.Exists(lbl_ChunkPath.Text + @"\players.db"))
            {
                File.Copy(lbl_ChunkPath.Text + @"\players.db", lbl_ChunkPath.Text + @"\save\players.db", true);
                LogWrite("Saved : players.db files");
            }
            if (File.Exists(lbl_ChunkPath.Text + @"\map_t.bin") && cbx_Age.Checked)
            {
                File.Copy(lbl_ChunkPath.Text + @"\map_t.bin", lbl_ChunkPath.Text + @"\save\map_t.bin", true);
                LogWrite("Saved : map_t.bin files");
            }
            int X1 = int.Parse(tbx_ChunkX.Value.ToString()) * 30;
            int Y1 = int.Parse(tbx_ChunkY.Value.ToString()) * 30;
            int X2 = (int.Parse(tbx_ChunkX.Value.ToString()) + 1) * 30;
            int Y2 = (int.Parse(tbx_ChunkY.Value.ToString()) + 1) * 30;
            int CellX = int.Parse(tbx_ChunkX.Value.ToString());
            int CellX2 = int.Parse(tbx_ChunkX2.Value.ToString());
            int CellY = int.Parse(tbx_ChunkY.Value.ToString());
            int CellY2 = int.Parse(tbx_ChunkY2.Value.ToString());
            if (rb_Zone.Checked)
            {
                X2 = (int.Parse(tbx_ChunkX2.Value.ToString()) + 1) * 30;
                Y2 = (int.Parse(tbx_ChunkY2.Value.ToString()) + 1) * 30;
            }
            int count = 0;
            for (int i = X1; i < X2; i++)
            {
                for (int j = Y1; j < Y2; j++)
                {

                    if (File.Exists(lbl_ChunkPath.Text + @"\map_" + i + "_" + j + ".bin"))
                    {
                        count++;
                        //LogWrite("Saved : map_" + i + "_" + j + ".bin (" + count + ")");
                        File.Copy(lbl_ChunkPath.Text + @"\map_" + i + "_" + j + ".bin", lbl_ChunkPath.Text + @"\save\map_" + i + "_" + j + ".bin", true);
                        
                    }
                }
            }
            LogWrite("Saved : " + count + " map files");
            count = 0;
            int zcount = 0;
            for (int i = CellX; i <= CellX2; i++)
            {
                for (int j = CellY; j <= CellY2; j++)
                {
                    if (File.Exists(lbl_ChunkPath.Text + @"\chunkdata_" + i.ToString() + "_" + j.ToString() + ".bin"))
                    {
                        count++;
                        //LogWrite("Saved : " + @"\chunkdata_" + i.ToString() + "_" + j.ToString() + ".bin");
                        File.Copy(lbl_ChunkPath.Text + @"\chunkdata_" + i.ToString() + "_" + j.ToString() + ".bin", lbl_ChunkPath.Text + @"\save\chunkdata_" + i.ToString() + "_" + j.ToString() + ".bin", true);
                    }
                    if (cbx_Zombies.Checked)
                    {
                        if (File.Exists(lbl_ChunkPath.Text + @"\zpop_" + i.ToString() + "_" + j.ToString() + ".bin"))
                        {
                            zcount++;
                            //LogWrite("Saved : " + @"\zpop_" + i.ToString() + "_" + j.ToString() + ".bin");
                            File.Copy(lbl_ChunkPath.Text + @"\zpop_" + i.ToString() + "_" + j.ToString() + ".bin", lbl_ChunkPath.Text + @"\save\zpop_" + i.ToString() + "_" + j.ToString() + ".bin", true);
                        }
                    }

                }
            }
            LogWrite("Saved : " + count + " map files");
            LogWrite("Saved : " + zcount + " map files");
            MessageBox.Show("Done !");
        }
    }
}
