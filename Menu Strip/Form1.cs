using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Strip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      private void EnableLabelFromInsideextBox(TextBox textBox , Label LabelName)
      {
           
            if (!string.IsNullOrWhiteSpace( textBox.Text ) && LabelName.Visible==false)
            {
                LabelName.Visible = true;
            }
            

      }

        private void formtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisableAndEnableLabelInsideTextBoxEvens(object sender, CancelEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label1.Visible==true)
                label1.Visible = false;
            textBox1.Enabled = true;
            textBox1.Focus();
            textBox1.Clear();

        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FileContent=null;
            openFileDialog1.Filter = "Files (*.txt)|*.txt";
            openFileDialog1.Title = "Open File";
            openFileDialog1.ShowDialog();

            //Download file conent
            try
            {
                FileContent = File.ReadAllText(openFileDialog1.FileName);
                if (FileContent != null)
                {
                    label1.Visible = false;
                    textBox1.Enabled = true;
                    textBox1.Text = FileContent;
                }
                  


            }
            catch
            {
                MessageBox.Show("Couldn't download File content");
            }
          
          
            
        }

        private void deleteFilenbcczzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return;

            saveFileDialog1.Filter = "Files (*.txt)|*.txt";
            saveFileDialog1.Title = "Save";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.ShowDialog();

            //Save File
            if(saveFileDialog1.FileName !=null)
            {
                File.WriteAllText(saveFileDialog1.FileName,textBox1.Text);
                MessageBox.Show("Text saved successfully","success",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                
            }
            else
                MessageBox.Show("the Text didn't save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return;
           
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = colorDialog1.Color;
                

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return;
            fontDialog1.ShowApply = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font=fontDialog1.Font;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            textBox1.Font = fontDialog1.Font;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
                 Clipboard.SetText(textBox1.Text);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if(string.IsNullOrEmpty(textBox1.SelectedText)) return;

          Clipboard.SetText(textBox1.SelectedText);
            textBox1.SelectedText = "";

        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
                textBox1.SelectedText = Clipboard.GetText();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
