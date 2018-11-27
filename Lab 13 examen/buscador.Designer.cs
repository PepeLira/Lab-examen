namespace Lab_13_examen
{
    partial class Buscador
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
            this.searchBar = new System.Windows.Forms.TextBox();
            this.buttonPeliculas = new System.Windows.Forms.Button();
            this.buttonActores = new System.Windows.Forms.Button();
            this.buttonDirectores = new System.Windows.Forms.Button();
            this.buttonProductores = new System.Windows.Forms.Button();
            this.buttonEstudios = new System.Windows.Forms.Button();
            this.sugerenciasSearch = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(124, 139);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(526, 20);
            this.searchBar.TabIndex = 0;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // buttonPeliculas
            // 
            this.buttonPeliculas.Location = new System.Drawing.Point(180, 110);
            this.buttonPeliculas.Name = "buttonPeliculas";
            this.buttonPeliculas.Size = new System.Drawing.Size(75, 23);
            this.buttonPeliculas.TabIndex = 1;
            this.buttonPeliculas.Text = "Peliculas";
            this.buttonPeliculas.UseVisualStyleBackColor = true;
            this.buttonPeliculas.Click += new System.EventHandler(this.buttonPeliculas_Click);
            // 
            // buttonActores
            // 
            this.buttonActores.Location = new System.Drawing.Point(261, 110);
            this.buttonActores.Name = "buttonActores";
            this.buttonActores.Size = new System.Drawing.Size(75, 23);
            this.buttonActores.TabIndex = 2;
            this.buttonActores.Text = "Actores";
            this.buttonActores.UseVisualStyleBackColor = true;
            this.buttonActores.Click += new System.EventHandler(this.buttonActores_Click);
            // 
            // buttonDirectores
            // 
            this.buttonDirectores.Location = new System.Drawing.Point(342, 110);
            this.buttonDirectores.Name = "buttonDirectores";
            this.buttonDirectores.Size = new System.Drawing.Size(75, 23);
            this.buttonDirectores.TabIndex = 3;
            this.buttonDirectores.Text = "Directores";
            this.buttonDirectores.UseVisualStyleBackColor = true;
            this.buttonDirectores.Click += new System.EventHandler(this.buttonDirectores_Click);
            // 
            // buttonProductores
            // 
            this.buttonProductores.Location = new System.Drawing.Point(423, 110);
            this.buttonProductores.Name = "buttonProductores";
            this.buttonProductores.Size = new System.Drawing.Size(75, 23);
            this.buttonProductores.TabIndex = 4;
            this.buttonProductores.Text = "Productores";
            this.buttonProductores.UseVisualStyleBackColor = true;
            this.buttonProductores.Click += new System.EventHandler(this.buttonProductores_Click);
            // 
            // buttonEstudios
            // 
            this.buttonEstudios.Location = new System.Drawing.Point(504, 110);
            this.buttonEstudios.Name = "buttonEstudios";
            this.buttonEstudios.Size = new System.Drawing.Size(75, 23);
            this.buttonEstudios.TabIndex = 5;
            this.buttonEstudios.Text = "Estudios";
            this.buttonEstudios.UseVisualStyleBackColor = true;
            this.buttonEstudios.Click += new System.EventHandler(this.buttonEstudios_Click);
            // 
            // sugerenciasSearch
            // 
            this.sugerenciasSearch.FormattingEnabled = true;
            this.sugerenciasSearch.Location = new System.Drawing.Point(124, 158);
            this.sugerenciasSearch.Name = "sugerenciasSearch";
            this.sugerenciasSearch.Size = new System.Drawing.Size(526, 173);
            this.sugerenciasSearch.TabIndex = 6;
            this.sugerenciasSearch.Visible = false;
            this.sugerenciasSearch.SelectedIndexChanged += new System.EventHandler(this.sugerenciasSearch_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEstudios);
            this.Controls.Add(this.buttonProductores);
            this.Controls.Add(this.buttonDirectores);
            this.Controls.Add(this.buttonActores);
            this.Controls.Add(this.buttonPeliculas);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.sugerenciasSearch);
            this.Name = "Buscador";
            this.Text = "Movie Wiki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button buttonPeliculas;
        private System.Windows.Forms.Button buttonActores;
        private System.Windows.Forms.Button buttonDirectores;
        private System.Windows.Forms.Button buttonProductores;
        private System.Windows.Forms.Button buttonEstudios;
        private System.Windows.Forms.ListBox sugerenciasSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

