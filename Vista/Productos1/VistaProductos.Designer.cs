﻿namespace AgroServicios.Vista.Productos1
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ContextMenuProductos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsElimarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInformacion = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.txtBuscarP = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnAgregarMarca = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAgregarProducto = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.GriewViewProductos = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContextMenuProductos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GriewViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContextMenuProductos
            // 
            this.ContextMenuProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenuProductos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsElimarProducto,
            this.cmsEditarProducto,
            this.cmsInformacion});
            this.ContextMenuProductos.Name = "ContextMenuProductos";
            this.ContextMenuProductos.Size = new System.Drawing.Size(176, 82);
            // 
            // cmsElimarProducto
            // 
            this.cmsElimarProducto.Image = global::AgroServicios.Properties.Resources.borrar;
            this.cmsElimarProducto.Name = "cmsElimarProducto";
            this.cmsElimarProducto.Size = new System.Drawing.Size(175, 26);
            this.cmsElimarProducto.Text = "Eliminar";
            // 
            // cmsEditarProducto
            // 
            this.cmsEditarProducto.Image = global::AgroServicios.Properties.Resources.actualizar;
            this.cmsEditarProducto.Name = "cmsEditarProducto";
            this.cmsEditarProducto.Size = new System.Drawing.Size(175, 26);
            this.cmsEditarProducto.Text = "Editar Datos";
            // 
            // cmsInformacion
            // 
            this.cmsInformacion.Image = global::AgroServicios.Properties.Resources.informacion;
            this.cmsInformacion.Name = "cmsInformacion";
            this.cmsInformacion.Size = new System.Drawing.Size(175, 26);
            this.cmsInformacion.Text = "Informacion ";
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(1580, 4);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(295, 38);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Tabla de Productos";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 97);
            this.panel1.TabIndex = 38;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 20;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.txtBuscarP);
            this.bunifuGradientPanel1.Controls.Add(this.btnAgregarMarca);
            this.bunifuGradientPanel1.Controls.Add(this.btnAgregarProducto);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuLabel2);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(19)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(19)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(19)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(19)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1212, 102);
            this.bunifuGradientPanel1.TabIndex = 40;
            // 
            // txtBuscarP
            // 
            this.txtBuscarP.AcceptsReturn = false;
            this.txtBuscarP.AcceptsTab = false;
            this.txtBuscarP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarP.AnimationSpeed = 200;
            this.txtBuscarP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscarP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscarP.AutoSizeHeight = true;
            this.txtBuscarP.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarP.BackgroundImage")));
            this.txtBuscarP.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtBuscarP.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBuscarP.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtBuscarP.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBuscarP.BorderRadius = 30;
            this.txtBuscarP.BorderThickness = 1;
            this.txtBuscarP.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtBuscarP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscarP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarP.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtBuscarP.DefaultText = "";
            this.txtBuscarP.FillColor = System.Drawing.Color.White;
            this.txtBuscarP.HideSelection = true;
            this.txtBuscarP.IconLeft = null;
            this.txtBuscarP.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarP.IconPadding = 10;
            this.txtBuscarP.IconRight = null;
            this.txtBuscarP.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarP.Lines = new string[0];
            this.txtBuscarP.Location = new System.Drawing.Point(364, 39);
            this.txtBuscarP.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarP.MaxLength = 32767;
            this.txtBuscarP.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBuscarP.Modified = false;
            this.txtBuscarP.Multiline = false;
            this.txtBuscarP.Name = "txtBuscarP";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscarP.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscarP.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscarP.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscarP.OnIdleState = stateProperties4;
            this.txtBuscarP.Padding = new System.Windows.Forms.Padding(2);
            this.txtBuscarP.PasswordChar = '\0';
            this.txtBuscarP.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBuscarP.PlaceholderText = "Buscar";
            this.txtBuscarP.ReadOnly = false;
            this.txtBuscarP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarP.SelectedText = "";
            this.txtBuscarP.SelectionLength = 0;
            this.txtBuscarP.SelectionStart = 0;
            this.txtBuscarP.ShortcutsEnabled = true;
            this.txtBuscarP.Size = new System.Drawing.Size(277, 40);
            this.txtBuscarP.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBuscarP.TabIndex = 30;
            this.txtBuscarP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscarP.TextMarginBottom = 0;
            this.txtBuscarP.TextMarginLeft = 3;
            this.txtBuscarP.TextMarginTop = 1;
            this.txtBuscarP.TextPlaceholder = "Buscar";
            this.txtBuscarP.UseSystemPasswordChar = false;
            this.txtBuscarP.WordWrap = true;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.AllowAnimations = true;
            this.btnAgregarMarca.AllowMouseEffects = true;
            this.btnAgregarMarca.AllowToggling = false;
            this.btnAgregarMarca.AnimationSpeed = 200;
            this.btnAgregarMarca.AutoGenerateColors = false;
            this.btnAgregarMarca.AutoRoundBorders = false;
            this.btnAgregarMarca.AutoSizeLeftIcon = true;
            this.btnAgregarMarca.AutoSizeRightIcon = true;
            this.btnAgregarMarca.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarMarca.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAgregarMarca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarMarca.BackgroundImage")));
            this.btnAgregarMarca.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarMarca.ButtonText = "Agregar Marca";
            this.btnAgregarMarca.ButtonTextMarginLeft = 0;
            this.btnAgregarMarca.ColorContrastOnClick = 45;
            this.btnAgregarMarca.ColorContrastOnHover = 45;
            this.btnAgregarMarca.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAgregarMarca.CustomizableEdges = borderEdges1;
            this.btnAgregarMarca.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarMarca.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarMarca.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAgregarMarca.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAgregarMarca.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMarca.IconLeft = null;
            this.btnAgregarMarca.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMarca.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarMarca.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAgregarMarca.IconMarginLeft = 11;
            this.btnAgregarMarca.IconPadding = 10;
            this.btnAgregarMarca.IconRight = null;
            this.btnAgregarMarca.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarMarca.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarMarca.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAgregarMarca.IconSize = 25;
            this.btnAgregarMarca.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAgregarMarca.IdleBorderRadius = 0;
            this.btnAgregarMarca.IdleBorderThickness = 0;
            this.btnAgregarMarca.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAgregarMarca.IdleIconLeftImage = null;
            this.btnAgregarMarca.IdleIconRightImage = null;
            this.btnAgregarMarca.IndicateFocus = false;
            this.btnAgregarMarca.Location = new System.Drawing.Point(686, 29);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarMarca.OnDisabledState.BorderRadius = 25;
            this.btnAgregarMarca.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarMarca.OnDisabledState.BorderThickness = 1;
            this.btnAgregarMarca.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarMarca.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarMarca.OnDisabledState.IconLeftImage = null;
            this.btnAgregarMarca.OnDisabledState.IconRightImage = null;
            this.btnAgregarMarca.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAgregarMarca.onHoverState.BorderRadius = 25;
            this.btnAgregarMarca.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarMarca.onHoverState.BorderThickness = 1;
            this.btnAgregarMarca.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAgregarMarca.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMarca.onHoverState.IconLeftImage = null;
            this.btnAgregarMarca.onHoverState.IconRightImage = null;
            this.btnAgregarMarca.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAgregarMarca.OnIdleState.BorderRadius = 25;
            this.btnAgregarMarca.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarMarca.OnIdleState.BorderThickness = 1;
            this.btnAgregarMarca.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarMarca.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMarca.OnIdleState.IconLeftImage = null;
            this.btnAgregarMarca.OnIdleState.IconRightImage = null;
            this.btnAgregarMarca.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAgregarMarca.OnPressedState.BorderRadius = 25;
            this.btnAgregarMarca.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarMarca.OnPressedState.BorderThickness = 1;
            this.btnAgregarMarca.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAgregarMarca.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMarca.OnPressedState.IconLeftImage = null;
            this.btnAgregarMarca.OnPressedState.IconRightImage = null;
            this.btnAgregarMarca.Size = new System.Drawing.Size(164, 53);
            this.btnAgregarMarca.TabIndex = 3;
            this.btnAgregarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarMarca.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarMarca.TextMarginLeft = 0;
            this.btnAgregarMarca.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAgregarMarca.UseDefaultRadiusAndThickness = true;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.AllowAnimations = true;
            this.btnAgregarProducto.AllowMouseEffects = true;
            this.btnAgregarProducto.AllowToggling = false;
            this.btnAgregarProducto.AnimationSpeed = 200;
            this.btnAgregarProducto.AutoGenerateColors = false;
            this.btnAgregarProducto.AutoRoundBorders = false;
            this.btnAgregarProducto.AutoSizeLeftIcon = true;
            this.btnAgregarProducto.AutoSizeRightIcon = true;
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProducto.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAgregarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.BackgroundImage")));
            this.btnAgregarProducto.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarProducto.ButtonText = "Agregar Producto";
            this.btnAgregarProducto.ButtonTextMarginLeft = 0;
            this.btnAgregarProducto.ColorContrastOnClick = 45;
            this.btnAgregarProducto.ColorContrastOnHover = 45;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAgregarProducto.CustomizableEdges = borderEdges2;
            this.btnAgregarProducto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarProducto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarProducto.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAgregarProducto.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAgregarProducto.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.IconLeft = null;
            this.btnAgregarProducto.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarProducto.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAgregarProducto.IconMarginLeft = 11;
            this.btnAgregarProducto.IconPadding = 10;
            this.btnAgregarProducto.IconRight = null;
            this.btnAgregarProducto.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProducto.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarProducto.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAgregarProducto.IconSize = 25;
            this.btnAgregarProducto.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAgregarProducto.IdleBorderRadius = 0;
            this.btnAgregarProducto.IdleBorderThickness = 0;
            this.btnAgregarProducto.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAgregarProducto.IdleIconLeftImage = null;
            this.btnAgregarProducto.IdleIconRightImage = null;
            this.btnAgregarProducto.IndicateFocus = false;
            this.btnAgregarProducto.Location = new System.Drawing.Point(871, 29);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarProducto.OnDisabledState.BorderRadius = 25;
            this.btnAgregarProducto.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarProducto.OnDisabledState.BorderThickness = 1;
            this.btnAgregarProducto.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarProducto.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarProducto.OnDisabledState.IconLeftImage = null;
            this.btnAgregarProducto.OnDisabledState.IconRightImage = null;
            this.btnAgregarProducto.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAgregarProducto.onHoverState.BorderRadius = 25;
            this.btnAgregarProducto.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarProducto.onHoverState.BorderThickness = 1;
            this.btnAgregarProducto.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAgregarProducto.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.onHoverState.IconLeftImage = null;
            this.btnAgregarProducto.onHoverState.IconRightImage = null;
            this.btnAgregarProducto.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAgregarProducto.OnIdleState.BorderRadius = 25;
            this.btnAgregarProducto.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarProducto.OnIdleState.BorderThickness = 1;
            this.btnAgregarProducto.OnIdleState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarProducto.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.OnIdleState.IconLeftImage = null;
            this.btnAgregarProducto.OnIdleState.IconRightImage = null;
            this.btnAgregarProducto.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAgregarProducto.OnPressedState.BorderRadius = 25;
            this.btnAgregarProducto.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarProducto.OnPressedState.BorderThickness = 1;
            this.btnAgregarProducto.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAgregarProducto.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.OnPressedState.IconLeftImage = null;
            this.btnAgregarProducto.OnPressedState.IconRightImage = null;
            this.btnAgregarProducto.Size = new System.Drawing.Size(164, 53);
            this.btnAgregarProducto.TabIndex = 2;
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarProducto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarProducto.TextMarginLeft = 0;
            this.btnAgregarProducto.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAgregarProducto.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.Location = new System.Drawing.Point(23, 34);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(295, 38);
            this.bunifuLabel2.TabIndex = 0;
            this.bunifuLabel2.Text = "Tabla de Productos";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // GriewViewProductos
            // 
            this.GriewViewProductos.AllowCustomTheming = false;
            this.GriewViewProductos.AllowUserToAddRows = false;
            this.GriewViewProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.GriewViewProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GriewViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GriewViewProductos.BackgroundColor = System.Drawing.Color.White;
            this.GriewViewProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GriewViewProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GriewViewProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GriewViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GriewViewProductos.ColumnHeadersHeight = 40;
            this.GriewViewProductos.ContextMenuStrip = this.ContextMenuProductos;
            this.GriewViewProductos.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.GriewViewProductos.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GriewViewProductos.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.GriewViewProductos.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.GriewViewProductos.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GriewViewProductos.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.GriewViewProductos.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.GriewViewProductos.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.GriewViewProductos.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.GriewViewProductos.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GriewViewProductos.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.GriewViewProductos.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GriewViewProductos.CurrentTheme.Name = null;
            this.GriewViewProductos.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GriewViewProductos.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GriewViewProductos.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.GriewViewProductos.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.GriewViewProductos.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GriewViewProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.GriewViewProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GriewViewProductos.EnableHeadersVisualStyles = false;
            this.GriewViewProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.GriewViewProductos.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.GriewViewProductos.HeaderBgColor = System.Drawing.Color.Empty;
            this.GriewViewProductos.HeaderForeColor = System.Drawing.Color.White;
            this.GriewViewProductos.Location = new System.Drawing.Point(0, 97);
            this.GriewViewProductos.Margin = new System.Windows.Forms.Padding(2);
            this.GriewViewProductos.Name = "GriewViewProductos";
            this.GriewViewProductos.ReadOnly = true;
            this.GriewViewProductos.RowHeadersVisible = false;
            this.GriewViewProductos.RowHeadersWidth = 51;
            this.GriewViewProductos.RowTemplate.Height = 40;
            this.GriewViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GriewViewProductos.Size = new System.Drawing.Size(1212, 239);
            this.GriewViewProductos.TabIndex = 39;
            this.GriewViewProductos.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgroServicios.Properties.Resources.Caja;
            this.pictureBox1.Location = new System.Drawing.Point(1062, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // VistaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 336);
            this.Controls.Add(this.GriewViewProductos);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1228, 375);
            this.MinimumSize = new System.Drawing.Size(1228, 375);
            this.Name = "VistaProductos";
            this.Text = "VistaProductos";
            this.Load += new System.EventHandler(this.VistaProductos_Load);
            this.ContextMenuProductos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GriewViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ContextMenuStrip ContextMenuProductos;
        public System.Windows.Forms.ToolStripMenuItem cmsElimarProducto;
        public System.Windows.Forms.ToolStripMenuItem cmsEditarProducto;
        public System.Windows.Forms.ToolStripMenuItem cmsInformacion;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.UI.WinForms.BunifuTextBox txtBuscarP;
        public Bunifu.UI.WinForms.BunifuDataGridView GriewViewProductos;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAgregarMarca;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAgregarProducto;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}