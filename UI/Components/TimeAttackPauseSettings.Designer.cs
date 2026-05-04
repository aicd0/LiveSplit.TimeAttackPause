using LiveSplit.UI;
using System.Xml;

namespace LiveSplit.TimeAttackPause.UI.Components
{
    partial class TimeAttackPauseSettings
    {
        public string DefaultSavePath { get; set; }

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveFilePathTextBox = new System.Windows.Forms.TextBox();
            this.SetDefaultSaveFileButton = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.AutoSize = true;
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.SaveFilePathTextBox, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.SetDefaultSaveFileButton, 0, 1);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(203, 100);
            this.TableLayoutPanel1.TabIndex = 0;
            this.TableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // SaveFilePathTextBox
            // 
            this.SaveFilePathTextBox.Location = new System.Drawing.Point(3, 3);
            this.SaveFilePathTextBox.Name = "SaveFilePathTextBox";
            this.SaveFilePathTextBox.Size = new System.Drawing.Size(197, 20);
            this.SaveFilePathTextBox.TabIndex = 0;
            // 
            // SetDefaultSaveFileButton
            // 
            this.SetDefaultSaveFileButton.Location = new System.Drawing.Point(3, 53);
            this.SetDefaultSaveFileButton.Name = "SetDefaultSaveFileButton";
            this.SetDefaultSaveFileButton.Size = new System.Drawing.Size(197, 23);
            this.SetDefaultSaveFileButton.TabIndex = 1;
            this.SetDefaultSaveFileButton.Text = "Save Default Path";
            this.SetDefaultSaveFileButton.UseVisualStyleBackColor = true;
            // 
            // TimeAttackPauseSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.TableLayoutPanel1);
            this.Name = "TimeAttackPauseSettings";
            this.Size = new System.Drawing.Size(206, 150);
            this.Load += new System.EventHandler(this.TimeAttackPauseSettings_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.TextBox SaveFilePathTextBox;
        private System.Windows.Forms.Button SetDefaultSaveFileButton;
    }
}
