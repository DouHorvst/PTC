﻿namespace AgroServicios.Vista.MenuPrincipal
{
    partial class VistaCarrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaCarrito));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCarrito = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btneliminar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.dgvTotal = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbEmpleado = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Controls.Add(this.cmbEmpleado);
            this.bunifuPanel1.Controls.Add(this.pictureBox1);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1028, 70);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AgroServicios.Properties.Resources.bolsita;
            this.pictureBox1.Location = new System.Drawing.Point(950, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrito";
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrito.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCarrito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCarrito.ColumnHeadersHeight = 40;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.PrecioUnitario,
            this.PrecioTotal});
            this.dgvCarrito.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvCarrito.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvCarrito.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCarrito.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvCarrito.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCarrito.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvCarrito.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvCarrito.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvCarrito.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvCarrito.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCarrito.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvCarrito.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCarrito.CurrentTheme.Name = null;
            this.dgvCarrito.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCarrito.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvCarrito.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCarrito.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvCarrito.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrito.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarrito.EnableHeadersVisualStyles = false;
            this.dgvCarrito.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvCarrito.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvCarrito.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvCarrito.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCarrito.Location = new System.Drawing.Point(0, 70);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.RowHeadersWidth = 51;
            this.dgvCarrito.RowTemplate.Height = 40;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(1028, 294);
            this.dgvCarrito.TabIndex = 1;
            this.dgvCarrito.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.HeaderText = "Precio Total";
            this.PrecioTotal.MinimumWidth = 6;
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btneliminar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bunifuButton21, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 270);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 94);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btneliminar
            // 
            this.btneliminar.AllowAnimations = true;
            this.btneliminar.AllowMouseEffects = true;
            this.btneliminar.AllowToggling = false;
            this.btneliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btneliminar.AnimationSpeed = 200;
            this.btneliminar.AutoGenerateColors = false;
            this.btneliminar.AutoRoundBorders = false;
            this.btneliminar.AutoSizeLeftIcon = true;
            this.btneliminar.AutoSizeRightIcon = true;
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btneliminar.ButtonText = "Eliminar compra";
            this.btneliminar.ButtonTextMarginLeft = 0;
            this.btneliminar.ColorContrastOnClick = 45;
            this.btneliminar.ColorContrastOnHover = 45;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btneliminar.CustomizableEdges = borderEdges1;
            this.btneliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btneliminar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btneliminar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btneliminar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btneliminar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btneliminar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btneliminar.IconMarginLeft = 11;
            this.btneliminar.IconPadding = 10;
            this.btneliminar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btneliminar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btneliminar.IconSize = 25;
            this.btneliminar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.btneliminar.IdleBorderRadius = 20;
            this.btneliminar.IdleBorderThickness = 1;
            this.btneliminar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.btneliminar.IdleIconLeftImage = null;
            this.btneliminar.IdleIconRightImage = null;
            this.btneliminar.IndicateFocus = false;
            this.btneliminar.Location = new System.Drawing.Point(267, 51);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btneliminar.OnDisabledState.BorderRadius = 20;
            this.btneliminar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btneliminar.OnDisabledState.BorderThickness = 1;
            this.btneliminar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btneliminar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btneliminar.OnDisabledState.IconLeftImage = null;
            this.btneliminar.OnDisabledState.IconRightImage = null;
            this.btneliminar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btneliminar.onHoverState.BorderRadius = 20;
            this.btneliminar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btneliminar.onHoverState.BorderThickness = 1;
            this.btneliminar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btneliminar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btneliminar.onHoverState.IconLeftImage = null;
            this.btneliminar.onHoverState.IconRightImage = null;
            this.btneliminar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.btneliminar.OnIdleState.BorderRadius = 20;
            this.btneliminar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btneliminar.OnIdleState.BorderThickness = 1;
            this.btneliminar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.btneliminar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.OnIdleState.IconLeftImage = null;
            this.btneliminar.OnIdleState.IconRightImage = null;
            this.btneliminar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btneliminar.OnPressedState.BorderRadius = 20;
            this.btneliminar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btneliminar.OnPressedState.BorderThickness = 1;
            this.btneliminar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btneliminar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btneliminar.OnPressedState.IconLeftImage = null;
            this.btneliminar.OnPressedState.IconRightImage = null;
            this.btneliminar.Size = new System.Drawing.Size(494, 39);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btneliminar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btneliminar.TextMarginLeft = 0;
            this.btneliminar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btneliminar.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButton21
            // 
            this.bunifuButton21.AllowAnimations = true;
            this.bunifuButton21.AllowMouseEffects = true;
            this.bunifuButton21.AllowToggling = false;
            this.bunifuButton21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuButton21.AnimationSpeed = 200;
            this.bunifuButton21.AutoGenerateColors = false;
            this.bunifuButton21.AutoRoundBorders = false;
            this.bunifuButton21.AutoSizeLeftIcon = true;
            this.bunifuButton21.AutoSizeRightIcon = true;
            this.bunifuButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton21.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(64)))));
            this.bunifuButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton21.BackgroundImage")));
            this.bunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.ButtonText = "Realizar compra";
            this.bunifuButton21.ButtonTextMarginLeft = 0;
            this.bunifuButton21.ColorContrastOnClick = 45;
            this.bunifuButton21.ColorContrastOnHover = 45;
            this.bunifuButton21.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton21.CustomizableEdges = borderEdges2;
            this.bunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton21.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton21.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton21.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton21.IconMarginLeft = 11;
            this.bunifuButton21.IconPadding = 10;
            this.bunifuButton21.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton21.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton21.IconSize = 25;
            this.bunifuButton21.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(64)))));
            this.bunifuButton21.IdleBorderRadius = 20;
            this.bunifuButton21.IdleBorderThickness = 1;
            this.bunifuButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(64)))));
            this.bunifuButton21.IdleIconLeftImage = null;
            this.bunifuButton21.IdleIconRightImage = null;
            this.bunifuButton21.IndicateFocus = false;
            this.bunifuButton21.Location = new System.Drawing.Point(268, 4);
            this.bunifuButton21.Name = "bunifuButton21";
            this.bunifuButton21.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.OnDisabledState.BorderRadius = 20;
            this.bunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnDisabledState.BorderThickness = 1;
            this.bunifuButton21.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.OnDisabledState.IconLeftImage = null;
            this.bunifuButton21.OnDisabledState.IconRightImage = null;
            this.bunifuButton21.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton21.onHoverState.BorderRadius = 20;
            this.bunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.onHoverState.BorderThickness = 1;
            this.bunifuButton21.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton21.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.onHoverState.IconLeftImage = null;
            this.bunifuButton21.onHoverState.IconRightImage = null;
            this.bunifuButton21.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(64)))));
            this.bunifuButton21.OnIdleState.BorderRadius = 20;
            this.bunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnIdleState.BorderThickness = 1;
            this.bunifuButton21.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(64)))));
            this.bunifuButton21.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton21.OnIdleState.IconLeftImage = null;
            this.bunifuButton21.OnIdleState.IconRightImage = null;
            this.bunifuButton21.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton21.OnPressedState.BorderRadius = 20;
            this.bunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnPressedState.BorderThickness = 1;
            this.bunifuButton21.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton21.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnPressedState.IconLeftImage = null;
            this.bunifuButton21.OnPressedState.IconRightImage = null;
            this.bunifuButton21.Size = new System.Drawing.Size(492, 39);
            this.bunifuButton21.TabIndex = 0;
            this.bunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton21.TextMarginLeft = 0;
            this.bunifuButton21.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton21.UseDefaultRadiusAndThickness = true;
            // 
            // dgvTotal
            // 
            this.dgvTotal.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvTotal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotal.BackgroundColor = System.Drawing.Color.White;
            this.dgvTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTotal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTotal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTotal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTotal.ColumnHeadersHeight = 40;
            this.dgvTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Total});
            this.dgvTotal.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvTotal.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTotal.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTotal.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvTotal.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTotal.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvTotal.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvTotal.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvTotal.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvTotal.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTotal.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvTotal.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTotal.CurrentTheme.Name = null;
            this.dgvTotal.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTotal.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTotal.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTotal.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvTotal.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTotal.EnableHeadersVisualStyles = false;
            this.dgvTotal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvTotal.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvTotal.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvTotal.HeaderForeColor = System.Drawing.Color.White;
            this.dgvTotal.Location = new System.Drawing.Point(0, 175);
            this.dgvTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.ReadOnly = true;
            this.dgvTotal.RowHeadersVisible = false;
            this.dgvTotal.RowHeadersWidth = 51;
            this.dgvTotal.RowTemplate.Height = 40;
            this.dgvTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTotal.Size = new System.Drawing.Size(1028, 95);
            this.dgvTotal.TabIndex = 3;
            this.dgvTotal.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.cmbEmpleado.BackgroundColor = System.Drawing.Color.White;
            this.cmbEmpleado.BorderColor = System.Drawing.Color.Silver;
            this.cmbEmpleado.BorderRadius = 1;
            this.cmbEmpleado.Color = System.Drawing.Color.Silver;
            this.cmbEmpleado.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbEmpleado.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbEmpleado.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbEmpleado.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbEmpleado.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbEmpleado.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbEmpleado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEmpleado.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbEmpleado.FillDropDown = true;
            this.cmbEmpleado.FillIndicator = false;
            this.cmbEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbEmpleado.ForeColor = System.Drawing.Color.Black;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Icon = null;
            this.cmbEmpleado.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbEmpleado.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbEmpleado.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbEmpleado.IndicatorThickness = 2;
            this.cmbEmpleado.IsDropdownOpened = false;
            this.cmbEmpleado.ItemBackColor = System.Drawing.Color.White;
            this.cmbEmpleado.ItemBorderColor = System.Drawing.Color.White;
            this.cmbEmpleado.ItemForeColor = System.Drawing.Color.Black;
            this.cmbEmpleado.ItemHeight = 26;
            this.cmbEmpleado.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbEmpleado.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbEmpleado.ItemTopMargin = 3;
            this.cmbEmpleado.Location = new System.Drawing.Point(564, 21);
            this.cmbEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(196, 32);
            this.cmbEmpleado.TabIndex = 4;
            this.cmbEmpleado.Text = null;
            this.cmbEmpleado.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbEmpleado.TextLeftMargin = 5;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(453, 24);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(104, 23);
            this.bunifuLabel1.TabIndex = 5;
            this.bunifuLabel1.Text = "Empleados";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // VistaCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 364);
            this.Controls.Add(this.dgvTotal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "VistaCarrito";
            this.Text = "VistaCarrito";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btneliminar;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvCarrito;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        public Bunifu.UI.WinForms.BunifuDropdown cmbEmpleado;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}