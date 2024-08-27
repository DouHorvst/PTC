namespace AgroServicios.Vista.Clientes
{
    partial class VistaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaClientes));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscarClientes = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnCrearCliente = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.GriewViewClientes = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEliminarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInformacionCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GriewViewClientes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 100);
            this.panel1.TabIndex = 0;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 20;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.txtBuscarClientes);
            this.bunifuGradientPanel1.Controls.Add(this.btnCrearCliente);
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
            this.bunifuGradientPanel1.TabIndex = 41;
            this.bunifuGradientPanel1.Click += new System.EventHandler(this.bunifuGradientPanel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgroServicios.Properties.Resources.carro;
            this.pictureBox1.Location = new System.Drawing.Point(1062, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscarClientes
            // 
            this.txtBuscarClientes.AcceptsReturn = false;
            this.txtBuscarClientes.AcceptsTab = false;
            this.txtBuscarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarClientes.AnimationSpeed = 200;
            this.txtBuscarClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscarClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscarClientes.AutoSizeHeight = true;
            this.txtBuscarClientes.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarClientes.BackgroundImage")));
            this.txtBuscarClientes.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtBuscarClientes.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBuscarClientes.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtBuscarClientes.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBuscarClientes.BorderRadius = 30;
            this.txtBuscarClientes.BorderThickness = 1;
            this.txtBuscarClientes.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtBuscarClientes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscarClientes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarClientes.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtBuscarClientes.DefaultText = "";
            this.txtBuscarClientes.FillColor = System.Drawing.Color.White;
            this.txtBuscarClientes.HideSelection = true;
            this.txtBuscarClientes.IconLeft = null;
            this.txtBuscarClientes.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarClientes.IconPadding = 10;
            this.txtBuscarClientes.IconRight = null;
            this.txtBuscarClientes.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarClientes.Lines = new string[0];
            this.txtBuscarClientes.Location = new System.Drawing.Point(461, 34);
            this.txtBuscarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarClientes.MaxLength = 32767;
            this.txtBuscarClientes.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBuscarClientes.Modified = false;
            this.txtBuscarClientes.Multiline = false;
            this.txtBuscarClientes.Name = "txtBuscarClientes";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscarClientes.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscarClientes.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscarClientes.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscarClientes.OnIdleState = stateProperties4;
            this.txtBuscarClientes.Padding = new System.Windows.Forms.Padding(2);
            this.txtBuscarClientes.PasswordChar = '\0';
            this.txtBuscarClientes.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBuscarClientes.PlaceholderText = "Buscar";
            this.txtBuscarClientes.ReadOnly = false;
            this.txtBuscarClientes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarClientes.SelectedText = "";
            this.txtBuscarClientes.SelectionLength = 0;
            this.txtBuscarClientes.SelectionStart = 0;
            this.txtBuscarClientes.ShortcutsEnabled = true;
            this.txtBuscarClientes.Size = new System.Drawing.Size(329, 40);
            this.txtBuscarClientes.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBuscarClientes.TabIndex = 30;
            this.txtBuscarClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscarClientes.TextMarginBottom = 0;
            this.txtBuscarClientes.TextMarginLeft = 3;
            this.txtBuscarClientes.TextMarginTop = 1;
            this.txtBuscarClientes.TextPlaceholder = "Buscar";
            this.txtBuscarClientes.UseSystemPasswordChar = false;
            this.txtBuscarClientes.WordWrap = true;
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.AllowAnimations = true;
            this.btnCrearCliente.AllowMouseEffects = true;
            this.btnCrearCliente.AllowToggling = false;
            this.btnCrearCliente.AnimationSpeed = 200;
            this.btnCrearCliente.AutoGenerateColors = false;
            this.btnCrearCliente.AutoRoundBorders = false;
            this.btnCrearCliente.AutoSizeLeftIcon = true;
            this.btnCrearCliente.AutoSizeRightIcon = true;
            this.btnCrearCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearCliente.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCrearCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearCliente.BackgroundImage")));
            this.btnCrearCliente.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCrearCliente.ButtonText = "Agregar cliente";
            this.btnCrearCliente.ButtonTextMarginLeft = 0;
            this.btnCrearCliente.ColorContrastOnClick = 45;
            this.btnCrearCliente.ColorContrastOnHover = 45;
            this.btnCrearCliente.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCrearCliente.CustomizableEdges = borderEdges1;
            this.btnCrearCliente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCrearCliente.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCrearCliente.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnCrearCliente.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnCrearCliente.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCrearCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCliente.ForeColor = System.Drawing.Color.White;
            this.btnCrearCliente.IconLeft = null;
            this.btnCrearCliente.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearCliente.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCrearCliente.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCrearCliente.IconMarginLeft = 11;
            this.btnCrearCliente.IconPadding = 10;
            this.btnCrearCliente.IconRight = null;
            this.btnCrearCliente.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearCliente.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCrearCliente.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCrearCliente.IconSize = 25;
            this.btnCrearCliente.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnCrearCliente.IdleBorderRadius = 0;
            this.btnCrearCliente.IdleBorderThickness = 0;
            this.btnCrearCliente.IdleFillColor = System.Drawing.Color.Empty;
            this.btnCrearCliente.IdleIconLeftImage = null;
            this.btnCrearCliente.IdleIconRightImage = null;
            this.btnCrearCliente.IndicateFocus = false;
            this.btnCrearCliente.Location = new System.Drawing.Point(871, 29);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCrearCliente.OnDisabledState.BorderRadius = 25;
            this.btnCrearCliente.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCrearCliente.OnDisabledState.BorderThickness = 1;
            this.btnCrearCliente.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCrearCliente.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCrearCliente.OnDisabledState.IconLeftImage = null;
            this.btnCrearCliente.OnDisabledState.IconRightImage = null;
            this.btnCrearCliente.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnCrearCliente.onHoverState.BorderRadius = 25;
            this.btnCrearCliente.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCrearCliente.onHoverState.BorderThickness = 1;
            this.btnCrearCliente.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnCrearCliente.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCrearCliente.onHoverState.IconLeftImage = null;
            this.btnCrearCliente.onHoverState.IconRightImage = null;
            this.btnCrearCliente.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCrearCliente.OnIdleState.BorderRadius = 25;
            this.btnCrearCliente.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCrearCliente.OnIdleState.BorderThickness = 1;
            this.btnCrearCliente.OnIdleState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnCrearCliente.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCrearCliente.OnIdleState.IconLeftImage = null;
            this.btnCrearCliente.OnIdleState.IconRightImage = null;
            this.btnCrearCliente.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCrearCliente.OnPressedState.BorderRadius = 25;
            this.btnCrearCliente.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCrearCliente.OnPressedState.BorderThickness = 1;
            this.btnCrearCliente.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCrearCliente.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCrearCliente.OnPressedState.IconLeftImage = null;
            this.btnCrearCliente.OnPressedState.IconRightImage = null;
            this.btnCrearCliente.Size = new System.Drawing.Size(164, 53);
            this.btnCrearCliente.TabIndex = 2;
            this.btnCrearCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCrearCliente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCrearCliente.TextMarginLeft = 0;
            this.btnCrearCliente.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCrearCliente.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.Location = new System.Drawing.Point(52, 34);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(267, 38);
            this.bunifuLabel2.TabIndex = 0;
            this.bunifuLabel2.Text = "Tabla de Clientes";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // GriewViewClientes
            // 
            this.GriewViewClientes.AllowCustomTheming = false;
            this.GriewViewClientes.AllowUserToAddRows = false;
            this.GriewViewClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.GriewViewClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GriewViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GriewViewClientes.BackgroundColor = System.Drawing.Color.White;
            this.GriewViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GriewViewClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GriewViewClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GriewViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GriewViewClientes.ColumnHeadersHeight = 40;
            this.GriewViewClientes.ContextMenuStrip = this.contextMenuStrip1;
            this.GriewViewClientes.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.GriewViewClientes.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GriewViewClientes.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.GriewViewClientes.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.GriewViewClientes.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GriewViewClientes.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.GriewViewClientes.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.GriewViewClientes.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.GriewViewClientes.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.GriewViewClientes.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GriewViewClientes.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.GriewViewClientes.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GriewViewClientes.CurrentTheme.Name = null;
            this.GriewViewClientes.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GriewViewClientes.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GriewViewClientes.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.GriewViewClientes.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.GriewViewClientes.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GriewViewClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.GriewViewClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GriewViewClientes.EnableHeadersVisualStyles = false;
            this.GriewViewClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.GriewViewClientes.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.GriewViewClientes.HeaderBgColor = System.Drawing.Color.Empty;
            this.GriewViewClientes.HeaderForeColor = System.Drawing.Color.White;
            this.GriewViewClientes.Location = new System.Drawing.Point(0, 100);
            this.GriewViewClientes.Margin = new System.Windows.Forms.Padding(2);
            this.GriewViewClientes.Name = "GriewViewClientes";
            this.GriewViewClientes.ReadOnly = true;
            this.GriewViewClientes.RowHeadersVisible = false;
            this.GriewViewClientes.RowHeadersWidth = 51;
            this.GriewViewClientes.RowTemplate.Height = 40;
            this.GriewViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GriewViewClientes.Size = new System.Drawing.Size(1212, 184);
            this.GriewViewClientes.TabIndex = 40;
            this.GriewViewClientes.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEliminarCliente,
            this.cmsEditarCliente,
            this.cmsInformacionCliente});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // cmsEliminarCliente
            // 
            this.cmsEliminarCliente.Image = global::AgroServicios.Properties.Resources.borrar;
            this.cmsEliminarCliente.Name = "cmsEliminarCliente";
            this.cmsEliminarCliente.Size = new System.Drawing.Size(152, 22);
            this.cmsEliminarCliente.Text = "Eliminar";
            // 
            // cmsEditarCliente
            // 
            this.cmsEditarCliente.Image = global::AgroServicios.Properties.Resources.actualizar;
            this.cmsEditarCliente.Name = "cmsEditarCliente";
            this.cmsEditarCliente.Size = new System.Drawing.Size(152, 22);
            this.cmsEditarCliente.Text = "Editar datos";
            // 
            // cmsInformacionCliente
            // 
            this.cmsInformacionCliente.Image = global::AgroServicios.Properties.Resources.informacion;
            this.cmsInformacionCliente.Name = "cmsInformacionCliente";
            this.cmsInformacionCliente.Size = new System.Drawing.Size(152, 22);
            this.cmsInformacionCliente.Text = "Información";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AgroServicios.Properties.Resources.Lupa_1;
            this.pictureBox2.Location = new System.Drawing.Point(417, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // VistaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 284);
            this.Controls.Add(this.GriewViewClientes);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1228, 323);
            this.MinimumSize = new System.Drawing.Size(1228, 323);
            this.Name = "VistaClientes";
            this.Text = "VistaClientes";
            this.Load += new System.EventHandler(this.VistaClientes_Load);
            this.panel1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GriewViewClientes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.UI.WinForms.BunifuTextBox txtBuscarClientes;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCrearCliente;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        public Bunifu.UI.WinForms.BunifuDataGridView GriewViewClientes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem cmsEliminarCliente;
        public System.Windows.Forms.ToolStripMenuItem cmsEditarCliente;
        public System.Windows.Forms.ToolStripMenuItem cmsInformacionCliente;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}