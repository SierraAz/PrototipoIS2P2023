
namespace CapaVistaProduccion
{
    partial class ver_ordenes
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
            this.num_orden = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.prioridadtxt = new System.Windows.Forms.TextBox();
            this.fechacrea = new System.Windows.Forms.TextBox();
            this.detalle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.num_receta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // num_orden
            // 
            this.num_orden.Location = new System.Drawing.Point(219, 180);
            this.num_orden.Name = "num_orden";
            this.num_orden.Size = new System.Drawing.Size(100, 20);
            this.num_orden.TabIndex = 67;
            this.num_orden.Tag = "pk_idordenes_tbl_ordenes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label10.Location = new System.Drawing.Point(78, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 66;
            this.label10.Text = "Id asignacion";
            // 
            // prioridadtxt
            // 
            this.prioridadtxt.Location = new System.Drawing.Point(664, 218);
            this.prioridadtxt.Name = "prioridadtxt";
            this.prioridadtxt.Size = new System.Drawing.Size(100, 20);
            this.prioridadtxt.TabIndex = 63;
            this.prioridadtxt.Tag = "prioridad_tbl_ordenes";
            // 
            // fechacrea
            // 
            this.fechacrea.Location = new System.Drawing.Point(564, 180);
            this.fechacrea.Name = "fechacrea";
            this.fechacrea.Size = new System.Drawing.Size(145, 20);
            this.fechacrea.TabIndex = 62;
            this.fechacrea.Tag = "fechacreacion_orden_tbl_ordenes";
            // 
            // detalle
            // 
            this.detalle.Location = new System.Drawing.Point(188, 269);
            this.detalle.Name = "detalle";
            this.detalle.Size = new System.Drawing.Size(482, 20);
            this.detalle.TabIndex = 61;
            this.detalle.Tag = "detalle_tbl_ordenes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label9.Location = new System.Drawing.Point(73, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 60;
            this.label9.Text = "Detalle Orden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label1.Location = new System.Drawing.Point(328, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "Fecha de creacion de asignacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, -19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Mantenimiento Ordenes";
            // 
            // num_receta
            // 
            this.num_receta.Location = new System.Drawing.Point(219, 218);
            this.num_receta.Name = "num_receta";
            this.num_receta.Size = new System.Drawing.Size(100, 20);
            this.num_receta.TabIndex = 51;
            this.num_receta.Tag = "fk_idrecetas_tbl_recetas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label3.Location = new System.Drawing.Point(549, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "id catedratico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label2.Location = new System.Drawing.Point(116, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "id curso";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(785, 216);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.Tag = "tbl_ordenes";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 70;
            this.textBox1.Tag = "fk_idrecetas_tbl_recetas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label11.Location = new System.Drawing.Point(331, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 69;
            this.label11.Text = "id alumno";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(115, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(567, 152);
            this.navegador1.TabIndex = 68;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // ver_ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(810, 533);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.num_orden);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.prioridadtxt);
            this.Controls.Add(this.fechacrea);
            this.Controls.Add(this.detalle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.num_receta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ver_ordenes";
            this.Text = "ver_ordenes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num_orden;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox prioridadtxt;
        private System.Windows.Forms.TextBox fechacrea;
        private System.Windows.Forms.TextBox detalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox num_receta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private NavegadorVista.Navegador navegador1;
    }
}