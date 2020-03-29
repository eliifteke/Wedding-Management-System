namespace UI
{
    partial class MarriagewList
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgcmarriagew = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcmarriagew)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(386, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 66);
            this.button1.TabIndex = 6;
            this.button1.Text = "List Marriage Witness";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgcmarriagew);
            this.panel1.Location = new System.Drawing.Point(129, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 320);
            this.panel1.TabIndex = 5;
            // 
            // dgcmarriagew
            // 
            this.dgcmarriagew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcmarriagew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcmarriagew.Location = new System.Drawing.Point(0, 0);
            this.dgcmarriagew.Name = "dgcmarriagew";
            this.dgcmarriagew.RowTemplate.Height = 24;
            this.dgcmarriagew.Size = new System.Drawing.Size(775, 320);
            this.dgcmarriagew.TabIndex = 0;
            // 
            // MarriagewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.A_Chic_Rustic_Wedding_on_the_Foreshore_Bridal_Party_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "MarriagewList";
            this.Text = "MarriagewList";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcmarriagew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgcmarriagew;
    }
}