namespace AgroServicios.Vista.Productos
{
    partial class VistaProductos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaProductos));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAgregarProducto = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.ContexGriewProductos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.GriewProductos = new System.Windows.Forms.DataGridView();
            this.cmsInformacion = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ContexGriewProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GriewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 25;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.btnAgregarProducto);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkOrange;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkOrange;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.MistyRose;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1028, 70);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuLabel1.Location = new System.Drawing.Point(69, 19);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(300, 37);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Tabla de productos";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgroServicios.Properties.Resources.Caja;
            this.pictureBox1.Location = new System.Drawing.Point(875, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.AllowAnimations = true;
            this.btnAgregarProducto.AllowMouseEffects = true;
            this.btnAgregarProducto.AllowToggling = true;
            this.btnAgregarProducto.AnimationSpeed = 200;
            this.btnAgregarProducto.AutoGenerateColors = false;
            this.btnAgregarProducto.AutoRoundBorders = true;
            this.btnAgregarProducto.AutoSizeLeftIcon = true;
            this.btnAgregarProducto.AutoSizeRightIcon = true;
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProducto.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(32)))));
            this.btnAgregarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.BackgroundImage")));
            this.btnAgregarProducto.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAgregarProducto.ButtonText = "Agregar";
            this.btnAgregarProducto.ButtonTextMarginLeft = 0;
            this.btnAgregarProducto.ColorContrastOnClick = 45;
            this.btnAgregarProducto.ColorContrastOnHover = 45;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAgregarProducto.CustomizableEdges = borderEdges1;
            this.btnAgregarProducto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarProducto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarProducto.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarProducto.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarProducto.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarProducto.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAgregarProducto.IconMarginLeft = 11;
            this.btnAgregarProducto.IconPadding = 10;
            this.btnAgregarProducto.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProducto.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarProducto.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAgregarProducto.IconSize = 25;
            this.btnAgregarProducto.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(32)))));
            this.btnAgregarProducto.IdleBorderRadius = 43;
            this.btnAgregarProducto.IdleBorderThickness = 1;
            this.btnAgregarProducto.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(32)))));
            this.btnAgregarProducto.IdleIconLeftImage = null;
            this.btnAgregarProducto.IdleIconRightImage = null;
            this.btnAgregarProducto.IndicateFocus = true;
            this.btnAgregarProducto.Location = new System.Drawing.Point(679, 11);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarProducto.OnDisabledState.BorderRadius = 1;
            this.btnAgregarProducto.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAgregarProducto.OnDisabledState.BorderThickness = 1;
            this.btnAgregarProducto.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarProducto.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarProducto.OnDisabledState.IconLeftImage = null;
            this.btnAgregarProducto.OnDisabledState.IconRightImage = null;
            this.btnAgregarProducto.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAgregarProducto.onHoverState.BorderRadius = 1;
            this.btnAgregarProducto.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAgregarProducto.onHoverState.BorderThickness = 1;
            this.btnAgregarProducto.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAgregarProducto.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.onHoverState.IconLeftImage = null;
            this.btnAgregarProducto.onHoverState.IconRightImage = null;
            this.btnAgregarProducto.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(32)))));
            this.btnAgregarProducto.OnIdleState.BorderRadius = 1;
            this.btnAgregarProducto.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAgregarProducto.OnIdleState.BorderThickness = 1;
            this.btnAgregarProducto.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(32)))));
            this.btnAgregarProducto.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.OnIdleState.IconLeftImage = null;
            this.btnAgregarProducto.OnIdleState.IconRightImage = null;
            this.btnAgregarProducto.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAgregarProducto.OnPressedState.BorderRadius = 1;
            this.btnAgregarProducto.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAgregarProducto.OnPressedState.BorderThickness = 1;
            this.btnAgregarProducto.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAgregarProducto.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.OnPressedState.IconLeftImage = null;
            this.btnAgregarProducto.OnPressedState.IconRightImage = null;
            this.btnAgregarProducto.Size = new System.Drawing.Size(162, 45);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarProducto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarProducto.TextMarginLeft = 0;
            this.btnAgregarProducto.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAgregarProducto.UseDefaultRadiusAndThickness = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ContexGriewProductos
            // 
            this.ContexGriewProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEliminar,
            this.cmsActualizar,
            this.cmsInformacion});
            this.ContexGriewProductos.Name = "ContexGriewProductos";
            this.ContexGriewProductos.Size = new System.Drawing.Size(181, 92);
            // 
            // cmsEliminar
            // 
            this.cmsEliminar.Image = global::AgroServicios.Properties.Resources.borrar;
            this.cmsEliminar.Name = "cmsEliminar";
            this.cmsEliminar.ShowShortcutKeys = false;
            this.cmsEliminar.Size = new System.Drawing.Size(180, 22);
            this.cmsEliminar.Text = "Eliminar";
            // 
            // cmsActualizar
            // 
            this.cmsActualizar.Image = global::AgroServicios.Properties.Resources.actualizar;
            this.cmsActualizar.Name = "cmsActualizar";
            this.cmsActualizar.Size = new System.Drawing.Size(180, 22);
            this.cmsActualizar.Text = "Actualizar";
            // 
            // GriewProductos
            // 
            this.GriewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GriewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GriewProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GriewProductos.Location = new System.Drawing.Point(0, 75);
            this.GriewProductos.Margin = new System.Windows.Forms.Padding(2);
            this.GriewProductos.Name = "GriewProductos";
            this.GriewProductos.RowHeadersWidth = 51;
            this.GriewProductos.Size = new System.Drawing.Size(1028, 218);
            this.GriewProductos.TabIndex = 1;
            // 
            // cmsInformacion
            // 
            this.cmsInformacion.Image = global::AgroServicios.Properties.Resources.informacion;
            this.cmsInformacion.Name = "cmsInformacion";
            this.cmsInformacion.Size = new System.Drawing.Size(180, 22);
            this.cmsInformacion.Text = "Informacion";
            // 
            // VistaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 293);
            this.Controls.Add(this.GriewProductos);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.KeyPreview = true;
            this.Name = "VistaProductos";
            this.Text = "VistaSuministros";
            this.Load += new System.EventHandler(this.VistaProductos_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ContexGriewProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GriewProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnAgregarProducto;
        public System.Windows.Forms.DataGridView GriewProductos;
        public System.Windows.Forms.ToolStripMenuItem cmsEliminar;
        public System.Windows.Forms.ContextMenuStrip ContexGriewProductos;
        public System.Windows.Forms.ToolStripMenuItem cmsInformacion;
        public System.Windows.Forms.ToolStripMenuItem cmsActualizar;
    }
}