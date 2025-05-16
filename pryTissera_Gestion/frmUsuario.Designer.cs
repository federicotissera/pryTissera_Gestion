namespace pryTissera_Gestion
{
    partial class frmUsuario
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBotones = new System.Windows.Forms.TabPage();
            this.btnListarProveedores = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBotones);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBotones
            // 
            this.tabBotones.Controls.Add(this.btnListarProveedores);
            this.tabBotones.Location = new System.Drawing.Point(4, 22);
            this.tabBotones.Name = "tabBotones";
            this.tabBotones.Padding = new System.Windows.Forms.Padding(3);
            this.tabBotones.Size = new System.Drawing.Size(192, 74);
            this.tabBotones.TabIndex = 0;
            this.tabBotones.Text = "tabPage1";
            this.tabBotones.UseVisualStyleBackColor = true;
            // 
            // btnListarProveedores
            // 
            this.btnListarProveedores.Location = new System.Drawing.Point(36, 23);
            this.btnListarProveedores.Name = "btnListarProveedores";
            this.btnListarProveedores.Size = new System.Drawing.Size(123, 23);
            this.btnListarProveedores.TabIndex = 1;
            this.btnListarProveedores.Text = "Listar Proveedores";
            this.btnListarProveedores.UseVisualStyleBackColor = true;
            this.btnListarProveedores.Click += new System.EventHandler(this.btnListarProveedores_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(12, 210);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(689, 343);
            this.dgvLista.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblFecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(713, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(118, 17);
            this.lblUsuario.Text = "toolStripStatusLabel1";
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(118, 17);
            this.lblFecha.Text = "toolStripStatusLabel2";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 598);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.tabControl1.ResumeLayout(false);
            this.tabBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBotones;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnListarProveedores;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
    }
}