namespace DownloadNfe
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnManifesta = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.textBoxUserCnpj = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManifesta
            // 
            this.btnManifesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManifesta.Location = new System.Drawing.Point(450, 357);
            this.btnManifesta.Name = "btnManifesta";
            this.btnManifesta.Size = new System.Drawing.Size(75, 23);
            this.btnManifesta.TabIndex = 0;
            this.btnManifesta.Text = "&Manifestar";
            this.btnManifesta.UseVisualStyleBackColor = true;
            this.btnManifesta.Click += new System.EventHandler(this.btnManifesta_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Location = new System.Drawing.Point(531, 357);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "&Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.textBoxUserCnpj);
            this.panel.Controls.Add(this.btnConsultar);
            this.panel.Controls.Add(this.dataGridView);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(618, 392);
            this.panel.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 37);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(594, 314);
            this.dataGridView.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(369, 357);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // textBoxUserCnpj
            // 
            this.textBoxUserCnpj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUserCnpj.Location = new System.Drawing.Point(309, 13);
            this.textBoxUserCnpj.Name = "textBoxUserCnpj";
            this.textBoxUserCnpj.Size = new System.Drawing.Size(297, 20);
            this.textBoxUserCnpj.TabIndex = 4;
            this.textBoxUserCnpj.Text = "JOSE VANILSON AQUINO SILVA ME:07372826000120";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 392);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnManifesta);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Download NFE";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManifesta;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox textBoxUserCnpj;
    }
}

