namespace LlencCostaJocDeCartasGrafic
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NCartas = new System.Windows.Forms.Button();
            this.RobarCarta = new System.Windows.Forms.Button();
            this.CojerCarta = new System.Windows.Forms.Button();
            this.CojerCartaAlazar = new System.Windows.Forms.Button();
            this.Barajar = new System.Windows.Forms.Button();
            this.PCarta = new System.Windows.Forms.NumericUpDown();
            this.ListaDeCartas = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PCarta)).BeginInit();
            this.SuspendLayout();
            // 
            // NCartas
            // 
            this.NCartas.Location = new System.Drawing.Point(43, 371);
            this.NCartas.Name = "NCartas";
            this.NCartas.Size = new System.Drawing.Size(107, 50);
            this.NCartas.TabIndex = 0;
            this.NCartas.Text = "Numero de cartas";
            this.NCartas.UseVisualStyleBackColor = true;
            this.NCartas.Click += new System.EventHandler(this.NCartas_Click);
            // 
            // RobarCarta
            // 
            this.RobarCarta.Location = new System.Drawing.Point(194, 371);
            this.RobarCarta.Name = "RobarCarta";
            this.RobarCarta.Size = new System.Drawing.Size(107, 50);
            this.RobarCarta.TabIndex = 1;
            this.RobarCarta.Text = "Robar Carta";
            this.RobarCarta.UseVisualStyleBackColor = true;
            this.RobarCarta.Click += new System.EventHandler(this.RobarCarta_Click);
            // 
            // CojerCarta
            // 
            this.CojerCarta.Location = new System.Drawing.Point(339, 371);
            this.CojerCarta.Name = "CojerCarta";
            this.CojerCarta.Size = new System.Drawing.Size(107, 50);
            this.CojerCarta.TabIndex = 2;
            this.CojerCarta.Text = "Cojer Carta";
            this.CojerCarta.UseVisualStyleBackColor = true;
            this.CojerCarta.Click += new System.EventHandler(this.CojerCarta_Click);
            // 
            // CojerCartaAlazar
            // 
            this.CojerCartaAlazar.Location = new System.Drawing.Point(485, 371);
            this.CojerCartaAlazar.Name = "CojerCartaAlazar";
            this.CojerCartaAlazar.Size = new System.Drawing.Size(107, 50);
            this.CojerCartaAlazar.TabIndex = 3;
            this.CojerCartaAlazar.Text = "Cojer Carta Alazar";
            this.CojerCartaAlazar.UseVisualStyleBackColor = true;
            this.CojerCartaAlazar.Click += new System.EventHandler(this.CojerCartaAlazar_Click);
            // 
            // Barajar
            // 
            this.Barajar.Location = new System.Drawing.Point(633, 371);
            this.Barajar.Name = "Barajar";
            this.Barajar.Size = new System.Drawing.Size(107, 50);
            this.Barajar.TabIndex = 4;
            this.Barajar.Text = "barajar";
            this.Barajar.UseVisualStyleBackColor = true;
            this.Barajar.Click += new System.EventHandler(this.Barajar_Click);
            // 
            // PCarta
            // 
            this.PCarta.Location = new System.Drawing.Point(339, 334);
            this.PCarta.Name = "PCarta";
            this.PCarta.Size = new System.Drawing.Size(107, 22);
            this.PCarta.TabIndex = 6;
            // 
            // ListaDeCartas
            // 
            this.ListaDeCartas.FormattingEnabled = true;
            this.ListaDeCartas.ItemHeight = 16;
            this.ListaDeCartas.Location = new System.Drawing.Point(43, 42);
            this.ListaDeCartas.Name = "ListaDeCartas";
            this.ListaDeCartas.Size = new System.Drawing.Size(697, 212);
            this.ListaDeCartas.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaDeCartas);
            this.Controls.Add(this.PCarta);
            this.Controls.Add(this.Barajar);
            this.Controls.Add(this.CojerCartaAlazar);
            this.Controls.Add(this.CojerCarta);
            this.Controls.Add(this.RobarCarta);
            this.Controls.Add(this.NCartas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PCarta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NCartas;
        private System.Windows.Forms.Button RobarCarta;
        private System.Windows.Forms.Button CojerCarta;
        private System.Windows.Forms.Button CojerCartaAlazar;
        private System.Windows.Forms.Button Barajar;
        private System.Windows.Forms.NumericUpDown PCarta;
        private System.Windows.Forms.ListBox ListaDeCartas;
    }
}

