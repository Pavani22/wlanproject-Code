using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace NodeD
{
    public partial class NodeD : Form
    {
        private string source = "D";
        private string dest = "";
        private bool enc = false;
        private bool dec = false;
        private List<string> keySet1 = new List<string> { "2e3f4", "5y7js", "24fg7", "98jui" };
        private List<string> keySet2 = new List<string> { "0x123456789A", "0x23456789AB", "0x3456789ABC", "0x456789ABCD" };
        private List<string> keySet3 = new List<string> { "2e3f4w345ytre", "5y7jse8r4i038", "24fg70okx3fr7", "98jui2wss35u4" };
        private List<string> keySet4 = new List<string> { "0x112233445566778899AABBCDEF", "0x2233445566778899AABBCCDDEE", "0x3344556677889900AABBCCDDFF", "0x44556677889900AABBCCDDEEFF" };
        private string key;
        private string cipher;
        public NodeD()
        {
            InitializeComponent();
            SqlConnection con = Database.Connection;
            con.Open();
            try
            {
                String query = "select node from nodes where auth='y' and node!=@node";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@node", "NodeD");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listBoxDest.Items.Add((String)reader["node"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not get destinations  " + ex.Message + "=======>  " + ex.StackTrace);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                enc = false;
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    String fileName = openFileDialog1.FileName;
                    textBoxFN.Text = fileName;
                    StreamReader reader = new StreamReader(textBoxFN.Text);
                    textBoxData.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in browse file  " + ex.Message + " ------- >" + ex.StackTrace);
            }
        }

        private void buttonEnc_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxData.Text == String.Empty)
                {
                    MessageBox.Show("Please enter data in text area");
                    return;
                }
                if (enc)
                {
                    MessageBox.Show("Data has already encrypted");
                    return;
                }
                if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                {
                    MessageBox.Show("Please enter type of encryption");
                    return;
                }
                if (radioButton1.Checked)
                {
                    Random random = new Random();
                    int pos = random.Next(4);
                    this.key = keySet1[pos];
                }
                else if (radioButton2.Checked)
                {
                    Random random = new Random();
                    int pos = random.Next(4);
                    this.key = keySet2[pos];
                }
                else if (radioButton3.Checked)
                {
                    Random random = new Random();
                    int pos = random.Next(4);
                    this.key = keySet3[pos];
                }
                else if (radioButton4.Checked)
                {
                    Random random = new Random();
                    int pos = random.Next(4);
                    this.key = keySet4[pos];
                }
                if (!enc)
                {
                    RC4 rc4 = new RC4(this.key, textBoxData.Text);
                    this.cipher = RC4.StrToHexStr(rc4.EnDeCrypt());
                    textBoxData.Text = System.Text.Encoding.ASCII.GetString(System.Text.Encoding.ASCII.GetBytes(cipher));
                    this.enc = true;
                    this.dec = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in Encryption : " + ex.Message + "----->" + ex.StackTrace);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                this.dest = "";
                string data = textBoxData.Text;
                if (data == string.Empty)
                {
                    MessageBox.Show("Enter data to send");
                    return;
                }
                if (!enc)
                {
                    MessageBox.Show("Plese encrypt the data");
                    return;
                }
                foreach (object item in listBoxDest.SelectedItems)
                {
                    MessageBox.Show("Dest " + item.ToString());
                    this.dest += item.ToString();
                }
                if (this.dest == String.Empty)
                {
                    MessageBox.Show("Could not connect to any node");
                    return;
                }
                SqlConnection con = Database.Connection;
                con.Open();
                SqlTransaction trans = con.BeginTransaction();
                try
                {
                    String delete = "delete info";
                    String insert = "insert into info(src,cipher,datakey,dest)values(@src,@cipher,@dataKey,@dest)";
                    SqlCommand cmd = new SqlCommand(delete, con);
                    cmd.Transaction = trans;
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand(insert, con);
                    cmd.Transaction = trans;
                    cmd.Parameters.AddWithValue("@src", this.source);
                    cmd.Parameters.AddWithValue("@cipher", this.cipher);
                    cmd.Parameters.AddWithValue("@dataKey", this.key);
                    cmd.Parameters.AddWithValue("@dest", this.dest);
                    cmd.ExecuteNonQuery();
                    trans.Commit();
                    MessageBox.Show("Data Sent Successfully.......");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Failure in DataSending  " + ex.Message + "=======>  " + ex.StackTrace);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in NodeB.Send() " + ex.Message + "============>" + ex.StackTrace);
            }
        }

        private void buttonRec_Click(object sender, EventArgs e)
        {
            dec = false;
            SqlConnection con = Database.Connection;
            try
            {
                con.Open();
                String query = "select src,cipher,datakey,dest from info";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                cmd = new SqlCommand(query, con);
                if (reader.Read())
                {
                    this.source = (string)reader["src"];
                    this.cipher = (string)reader["cipher"];
                    this.key = (string)reader["dataKey"];
                    this.dest = (string)reader["dest"];
                }

                if (!this.dest.Contains("D"))
                {
                    MessageBox.Show("Nothing to recieve.......");
                    return;
                }
                String cipherData = System.Text.Encoding.ASCII.GetString(System.Text.Encoding.ASCII.GetBytes(this.cipher));
                textBoxData.Text = cipherData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failure in DataReceving  " + ex.Message + "=======>  " + ex.StackTrace);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxData.Text == String.Empty)
                {
                    MessageBox.Show("Please enter data in text area");
                    return;
                }
                if (dec)
                {
                    MessageBox.Show("Data has already decrypted");
                    return;
                }
                RC4 rc4 = new RC4(this.key);
                rc4.Text = RC4.HexStrToStr(this.cipher);
                textBoxData.Text = rc4.EnDeCrypt();
                dec = true;
                enc = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in Decryption : " + ex.Message + "------>" + ex.StackTrace);
            }
        }
    }
}
