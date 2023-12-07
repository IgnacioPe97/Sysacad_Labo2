namespace formEntradaUsuario
{
    partial class FormAdministrador
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
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            txt_nombreUsuario = new Label();
            btn_Registrar = new Button();
            btn_GestionarCursos = new Button();
            picture_Admin = new PictureBox();
            panel1 = new Panel();
            btn_GestorProfesor = new Button();
            btn_ListasDeEspera = new Button();
            btn_RequisitosAcademicos = new Button();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btn_GenerarReportes = new Button();
            panel_paraMostrar2 = new Panel();
            btn_BajaCurso = new Button();
            btn_ModificacionCurso = new Button();
            btn_AltaCurso = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel_MuestraBusquedaPorFecha = new Panel();
            label2 = new Label();
            label1 = new Label();
            btn_Salir = new Button();
            btn_Buscar = new Button();
            dTime_Hasta = new DateTimePicker();
            dTime_Desde = new DateTimePicker();
            panel4_BotonesReportes = new Panel();
            btn_ListaDeEsperaCursos = new Button();
            btn_InscripcionXCarrera = new Button();
            btn_ConceptosPago = new Button();
            btn_EscritosEnCurso = new Button();
            btn_PorPeriodo = new Button();
            panel_SeleccionaCarrera = new Panel();
            btn_BuscarPorCarrera = new Button();
            label3 = new Label();
            combo_Carreras = new ComboBox();
            btn_DescargarReporte = new Button();
            panel_Profesores = new Panel();
            btn_EliminarProfesor = new Button();
            btn_AsignarProfesor = new Button();
            btn_EditarProfesor = new Button();
            btn_AgregaProfesor = new Button();
            ((System.ComponentModel.ISupportInitialize)picture_Admin).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel_paraMostrar2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_MuestraBusquedaPorFecha.SuspendLayout();
            panel4_BotonesReportes.SuspendLayout();
            panel_SeleccionaCarrera.SuspendLayout();
            panel_Profesores.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // txt_nombreUsuario
            // 
            txt_nombreUsuario.AutoSize = true;
            txt_nombreUsuario.Location = new Point(88, 20);
            txt_nombreUsuario.Name = "txt_nombreUsuario";
            txt_nombreUsuario.Size = new Size(128, 15);
            txt_nombreUsuario.TabIndex = 0;
            txt_nombreUsuario.Text = "Nombre administrador";
            // 
            // btn_Registrar
            // 
            btn_Registrar.BackColor = Color.DarkGray;
            btn_Registrar.Location = new Point(3, 3);
            btn_Registrar.Name = "btn_Registrar";
            btn_Registrar.Size = new Size(168, 38);
            btn_Registrar.TabIndex = 1;
            btn_Registrar.Text = "Registrar Estudiante";
            btn_Registrar.UseVisualStyleBackColor = false;
            btn_Registrar.Click += btn_Registrar_Click;
            // 
            // btn_GestionarCursos
            // 
            btn_GestionarCursos.BackColor = Color.DarkGray;
            btn_GestionarCursos.Location = new Point(3, 232);
            btn_GestionarCursos.Name = "btn_GestionarCursos";
            btn_GestionarCursos.Size = new Size(168, 38);
            btn_GestionarCursos.TabIndex = 2;
            btn_GestionarCursos.Text = "Gestionar Cursos";
            btn_GestionarCursos.UseVisualStyleBackColor = false;
            btn_GestionarCursos.Click += btn_GestionarCursos_Click;
            // 
            // picture_Admin
            // 
            picture_Admin.Location = new Point(27, 12);
            picture_Admin.Name = "picture_Admin";
            picture_Admin.Size = new Size(55, 69);
            picture_Admin.TabIndex = 3;
            picture_Admin.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_GestorProfesor);
            panel1.Controls.Add(btn_ListasDeEspera);
            panel1.Controls.Add(btn_RequisitosAcademicos);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_GenerarReportes);
            panel1.Controls.Add(btn_Registrar);
            panel1.Controls.Add(btn_GestionarCursos);
            panel1.Location = new Point(20, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 273);
            panel1.TabIndex = 4;
            // 
            // btn_GestorProfesor
            // 
            btn_GestorProfesor.BackColor = Color.DarkGray;
            btn_GestorProfesor.Location = new Point(3, 163);
            btn_GestorProfesor.Name = "btn_GestorProfesor";
            btn_GestorProfesor.Size = new Size(168, 38);
            btn_GestorProfesor.TabIndex = 10;
            btn_GestorProfesor.Text = "Gestor Profesores";
            btn_GestorProfesor.UseVisualStyleBackColor = false;
            btn_GestorProfesor.Click += btn_GestorProfesor_Click;
            // 
            // btn_ListasDeEspera
            // 
            btn_ListasDeEspera.BackColor = Color.DarkGray;
            btn_ListasDeEspera.Location = new Point(3, 122);
            btn_ListasDeEspera.Name = "btn_ListasDeEspera";
            btn_ListasDeEspera.Size = new Size(168, 38);
            btn_ListasDeEspera.TabIndex = 9;
            btn_ListasDeEspera.Text = "Listas De Espera a Cursos";
            btn_ListasDeEspera.UseVisualStyleBackColor = false;
            btn_ListasDeEspera.Click += btn_ListasDeEspera_Click;
            // 
            // btn_RequisitosAcademicos
            // 
            btn_RequisitosAcademicos.BackColor = Color.DarkGray;
            btn_RequisitosAcademicos.Location = new Point(3, 82);
            btn_RequisitosAcademicos.Name = "btn_RequisitosAcademicos";
            btn_RequisitosAcademicos.Size = new Size(168, 38);
            btn_RequisitosAcademicos.TabIndex = 8;
            btn_RequisitosAcademicos.Text = "Requisitos Academicos";
            btn_RequisitosAcademicos.UseVisualStyleBackColor = false;
            btn_RequisitosAcademicos.Click += btn_RequisitosAcademicos_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(177, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 108);
            panel2.TabIndex = 7;
            panel2.Visible = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(2, 55);
            button1.Name = "button1";
            button1.Size = new Size(109, 31);
            button1.TabIndex = 11;
            button1.Text = "Baja Curso";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.DimGray;
            button2.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(2, 30);
            button2.Name = "button2";
            button2.Size = new Size(109, 31);
            button2.TabIndex = 10;
            button2.Text = "Modificacion Curso";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.DimGray;
            button3.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(2, 4);
            button3.Name = "button3";
            button3.Size = new Size(109, 31);
            button3.TabIndex = 9;
            button3.Text = "Alta Curso";
            button3.UseVisualStyleBackColor = false;
            // 
            // btn_GenerarReportes
            // 
            btn_GenerarReportes.BackColor = Color.DarkGray;
            btn_GenerarReportes.Location = new Point(3, 42);
            btn_GenerarReportes.Name = "btn_GenerarReportes";
            btn_GenerarReportes.Size = new Size(168, 38);
            btn_GenerarReportes.TabIndex = 7;
            btn_GenerarReportes.Text = "Generar Reportes";
            btn_GenerarReportes.UseVisualStyleBackColor = false;
            btn_GenerarReportes.Click += btn_GenerarReportes_Click;
            // 
            // panel_paraMostrar2
            // 
            panel_paraMostrar2.Controls.Add(btn_BajaCurso);
            panel_paraMostrar2.Controls.Add(btn_ModificacionCurso);
            panel_paraMostrar2.Controls.Add(btn_AltaCurso);
            panel_paraMostrar2.Location = new Point(23, 371);
            panel_paraMostrar2.Name = "panel_paraMostrar2";
            panel_paraMostrar2.Size = new Size(168, 90);
            panel_paraMostrar2.TabIndex = 5;
            panel_paraMostrar2.Visible = false;
            panel_paraMostrar2.Paint += panel_paraMostrar2_Paint;
            // 
            // btn_BajaCurso
            // 
            btn_BajaCurso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_BajaCurso.BackColor = Color.DimGray;
            btn_BajaCurso.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_BajaCurso.Location = new Point(2, 55);
            btn_BajaCurso.Name = "btn_BajaCurso";
            btn_BajaCurso.Size = new Size(165, 31);
            btn_BajaCurso.TabIndex = 11;
            btn_BajaCurso.Text = "Baja Curso";
            btn_BajaCurso.UseVisualStyleBackColor = false;
            btn_BajaCurso.Click += btn_BajaCurso_Click;
            // 
            // btn_ModificacionCurso
            // 
            btn_ModificacionCurso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_ModificacionCurso.BackColor = Color.DimGray;
            btn_ModificacionCurso.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_ModificacionCurso.Location = new Point(2, 30);
            btn_ModificacionCurso.Name = "btn_ModificacionCurso";
            btn_ModificacionCurso.Size = new Size(165, 31);
            btn_ModificacionCurso.TabIndex = 10;
            btn_ModificacionCurso.Text = "Modificacion Curso";
            btn_ModificacionCurso.UseVisualStyleBackColor = false;
            btn_ModificacionCurso.Click += btn_ModificacionCurso_Click;
            // 
            // btn_AltaCurso
            // 
            btn_AltaCurso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_AltaCurso.BackColor = Color.DimGray;
            btn_AltaCurso.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_AltaCurso.Location = new Point(2, 4);
            btn_AltaCurso.Name = "btn_AltaCurso";
            btn_AltaCurso.Size = new Size(165, 31);
            btn_AltaCurso.TabIndex = 9;
            btn_AltaCurso.Text = "Alta Curso";
            btn_AltaCurso.UseVisualStyleBackColor = false;
            btn_AltaCurso.Click += btn_AltaCurso_Click_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(384, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(758, 410);
            panel3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(752, 404);
            dataGridView1.TabIndex = 0;
            dataGridView1.Visible = false;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // panel_MuestraBusquedaPorFecha
            // 
            panel_MuestraBusquedaPorFecha.Controls.Add(label2);
            panel_MuestraBusquedaPorFecha.Controls.Add(label1);
            panel_MuestraBusquedaPorFecha.Controls.Add(btn_Salir);
            panel_MuestraBusquedaPorFecha.Controls.Add(btn_Buscar);
            panel_MuestraBusquedaPorFecha.Controls.Add(dTime_Hasta);
            panel_MuestraBusquedaPorFecha.Controls.Add(dTime_Desde);
            panel_MuestraBusquedaPorFecha.Location = new Point(384, 12);
            panel_MuestraBusquedaPorFecha.Name = "panel_MuestraBusquedaPorFecha";
            panel_MuestraBusquedaPorFecha.Size = new Size(738, 60);
            panel_MuestraBusquedaPorFecha.TabIndex = 1;
            panel_MuestraBusquedaPorFecha.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 8);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 5;
            label2.Text = "Hasta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 8);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Desde";
            // 
            // btn_Salir
            // 
            btn_Salir.Location = new Point(631, 27);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(75, 23);
            btn_Salir.TabIndex = 3;
            btn_Salir.Text = "Cancelar";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(516, 28);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(75, 23);
            btn_Buscar.TabIndex = 2;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // dTime_Hasta
            // 
            dTime_Hasta.Location = new Point(263, 28);
            dTime_Hasta.Name = "dTime_Hasta";
            dTime_Hasta.Size = new Size(217, 23);
            dTime_Hasta.TabIndex = 1;
            // 
            // dTime_Desde
            // 
            dTime_Desde.Location = new Point(26, 28);
            dTime_Desde.Name = "dTime_Desde";
            dTime_Desde.Size = new Size(217, 23);
            dTime_Desde.TabIndex = 0;
            // 
            // panel4_BotonesReportes
            // 
            panel4_BotonesReportes.Controls.Add(btn_ListaDeEsperaCursos);
            panel4_BotonesReportes.Controls.Add(btn_InscripcionXCarrera);
            panel4_BotonesReportes.Controls.Add(btn_ConceptosPago);
            panel4_BotonesReportes.Controls.Add(btn_EscritosEnCurso);
            panel4_BotonesReportes.Controls.Add(btn_PorPeriodo);
            panel4_BotonesReportes.Location = new Point(197, 90);
            panel4_BotonesReportes.Name = "panel4_BotonesReportes";
            panel4_BotonesReportes.Size = new Size(175, 148);
            panel4_BotonesReportes.TabIndex = 7;
            panel4_BotonesReportes.Visible = false;
            // 
            // btn_ListaDeEsperaCursos
            // 
            btn_ListaDeEsperaCursos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_ListaDeEsperaCursos.BackColor = Color.DimGray;
            btn_ListaDeEsperaCursos.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_ListaDeEsperaCursos.Location = new Point(2, 114);
            btn_ListaDeEsperaCursos.Name = "btn_ListaDeEsperaCursos";
            btn_ListaDeEsperaCursos.Size = new Size(170, 31);
            btn_ListaDeEsperaCursos.TabIndex = 13;
            btn_ListaDeEsperaCursos.Text = "Lista espera cursos";
            btn_ListaDeEsperaCursos.UseVisualStyleBackColor = false;
            btn_ListaDeEsperaCursos.Click += btn_ListaDeEsperaCursos_Click;
            // 
            // btn_InscripcionXCarrera
            // 
            btn_InscripcionXCarrera.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_InscripcionXCarrera.BackColor = Color.DimGray;
            btn_InscripcionXCarrera.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_InscripcionXCarrera.Location = new Point(2, 85);
            btn_InscripcionXCarrera.Name = "btn_InscripcionXCarrera";
            btn_InscripcionXCarrera.Size = new Size(170, 31);
            btn_InscripcionXCarrera.TabIndex = 12;
            btn_InscripcionXCarrera.Text = "Inscripcion x Carrera";
            btn_InscripcionXCarrera.UseVisualStyleBackColor = false;
            btn_InscripcionXCarrera.Click += button4_Click;
            // 
            // btn_ConceptosPago
            // 
            btn_ConceptosPago.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_ConceptosPago.BackColor = Color.DimGray;
            btn_ConceptosPago.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_ConceptosPago.Location = new Point(2, 55);
            btn_ConceptosPago.Name = "btn_ConceptosPago";
            btn_ConceptosPago.Size = new Size(170, 31);
            btn_ConceptosPago.TabIndex = 11;
            btn_ConceptosPago.Text = "Concepto Pago";
            btn_ConceptosPago.UseVisualStyleBackColor = false;
            btn_ConceptosPago.Click += btn_ConceptosPago_Click;
            // 
            // btn_EscritosEnCurso
            // 
            btn_EscritosEnCurso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_EscritosEnCurso.BackColor = Color.DimGray;
            btn_EscritosEnCurso.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_EscritosEnCurso.Location = new Point(2, 30);
            btn_EscritosEnCurso.Name = "btn_EscritosEnCurso";
            btn_EscritosEnCurso.Size = new Size(170, 31);
            btn_EscritosEnCurso.TabIndex = 10;
            btn_EscritosEnCurso.Text = "Escritos en Curso";
            btn_EscritosEnCurso.UseVisualStyleBackColor = false;
            btn_EscritosEnCurso.Click += btn_EscritosEnCurso_Click;
            // 
            // btn_PorPeriodo
            // 
            btn_PorPeriodo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_PorPeriodo.BackColor = Color.DimGray;
            btn_PorPeriodo.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_PorPeriodo.Location = new Point(2, 4);
            btn_PorPeriodo.Name = "btn_PorPeriodo";
            btn_PorPeriodo.Size = new Size(170, 31);
            btn_PorPeriodo.TabIndex = 9;
            btn_PorPeriodo.Text = "Informe x Periodo";
            btn_PorPeriodo.UseVisualStyleBackColor = false;
            btn_PorPeriodo.Click += btn_PorPeriodo_Click;
            // 
            // panel_SeleccionaCarrera
            // 
            panel_SeleccionaCarrera.Controls.Add(btn_BuscarPorCarrera);
            panel_SeleccionaCarrera.Controls.Add(label3);
            panel_SeleccionaCarrera.Controls.Add(combo_Carreras);
            panel_SeleccionaCarrera.Location = new Point(410, 81);
            panel_SeleccionaCarrera.Name = "panel_SeleccionaCarrera";
            panel_SeleccionaCarrera.Size = new Size(712, 29);
            panel_SeleccionaCarrera.TabIndex = 8;
            panel_SeleccionaCarrera.Visible = false;
            // 
            // btn_BuscarPorCarrera
            // 
            btn_BuscarPorCarrera.Location = new Point(581, 3);
            btn_BuscarPorCarrera.Name = "btn_BuscarPorCarrera";
            btn_BuscarPorCarrera.Size = new Size(99, 23);
            btn_BuscarPorCarrera.TabIndex = 2;
            btn_BuscarPorCarrera.Text = "Buscar";
            btn_BuscarPorCarrera.UseVisualStyleBackColor = true;
            btn_BuscarPorCarrera.Click += btn_BuscarPorCarrera_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(54, 7);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 1;
            label3.Text = "Seleccione Carrera";
            // 
            // combo_Carreras
            // 
            combo_Carreras.FormattingEnabled = true;
            combo_Carreras.Location = new Point(207, 3);
            combo_Carreras.Name = "combo_Carreras";
            combo_Carreras.Size = new Size(338, 23);
            combo_Carreras.TabIndex = 0;
            // 
            // btn_DescargarReporte
            // 
            btn_DescargarReporte.BackColor = Color.PowderBlue;
            btn_DescargarReporte.Enabled = false;
            btn_DescargarReporte.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DescargarReporte.Location = new Point(979, 558);
            btn_DescargarReporte.Name = "btn_DescargarReporte";
            btn_DescargarReporte.Size = new Size(162, 29);
            btn_DescargarReporte.TabIndex = 9;
            btn_DescargarReporte.Text = "Descargar Reporte";
            btn_DescargarReporte.UseVisualStyleBackColor = false;
            btn_DescargarReporte.Click += btn_DescargarReporte_Click;
            // 
            // panel_Profesores
            // 
            panel_Profesores.Controls.Add(btn_EliminarProfesor);
            panel_Profesores.Controls.Add(btn_AsignarProfesor);
            panel_Profesores.Controls.Add(btn_EditarProfesor);
            panel_Profesores.Controls.Add(btn_AgregaProfesor);
            panel_Profesores.Location = new Point(197, 244);
            panel_Profesores.Name = "panel_Profesores";
            panel_Profesores.Size = new Size(168, 121);
            panel_Profesores.TabIndex = 10;
            panel_Profesores.Visible = false;
            // 
            // btn_EliminarProfesor
            // 
            btn_EliminarProfesor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_EliminarProfesor.BackColor = Color.DimGray;
            btn_EliminarProfesor.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_EliminarProfesor.Location = new Point(3, 89);
            btn_EliminarProfesor.Name = "btn_EliminarProfesor";
            btn_EliminarProfesor.Size = new Size(163, 31);
            btn_EliminarProfesor.TabIndex = 12;
            btn_EliminarProfesor.Text = "Eliminar Profesor";
            btn_EliminarProfesor.UseVisualStyleBackColor = false;
            // 
            // btn_AsignarProfesor
            // 
            btn_AsignarProfesor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_AsignarProfesor.BackColor = Color.DimGray;
            btn_AsignarProfesor.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_AsignarProfesor.Location = new Point(2, 59);
            btn_AsignarProfesor.Name = "btn_AsignarProfesor";
            btn_AsignarProfesor.Size = new Size(163, 31);
            btn_AsignarProfesor.TabIndex = 11;
            btn_AsignarProfesor.Text = "Asignar Profesor";
            btn_AsignarProfesor.UseVisualStyleBackColor = false;
            btn_AsignarProfesor.Click += btn_AsignarProfesor_Click;
            // 
            // btn_EditarProfesor
            // 
            btn_EditarProfesor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_EditarProfesor.BackColor = Color.DimGray;
            btn_EditarProfesor.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_EditarProfesor.Location = new Point(2, 30);
            btn_EditarProfesor.Name = "btn_EditarProfesor";
            btn_EditarProfesor.Size = new Size(163, 31);
            btn_EditarProfesor.TabIndex = 10;
            btn_EditarProfesor.Text = "Editar Profesor";
            btn_EditarProfesor.UseVisualStyleBackColor = false;
            btn_EditarProfesor.Click += btn_EditarProfesor_Click;
            // 
            // btn_AgregaProfesor
            // 
            btn_AgregaProfesor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_AgregaProfesor.BackColor = Color.DimGray;
            btn_AgregaProfesor.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_AgregaProfesor.Location = new Point(2, 4);
            btn_AgregaProfesor.Name = "btn_AgregaProfesor";
            btn_AgregaProfesor.Size = new Size(163, 31);
            btn_AgregaProfesor.TabIndex = 9;
            btn_AgregaProfesor.Text = "Agregar Profesor";
            btn_AgregaProfesor.UseVisualStyleBackColor = false;
            btn_AgregaProfesor.Click += btn_AgregaProfesor_Click;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1155, 589);
            Controls.Add(panel_Profesores);
            Controls.Add(btn_DescargarReporte);
            Controls.Add(panel_SeleccionaCarrera);
            Controls.Add(panel_MuestraBusquedaPorFecha);
            Controls.Add(panel4_BotonesReportes);
            Controls.Add(panel_paraMostrar2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(picture_Admin);
            Controls.Add(txt_nombreUsuario);
            Name = "FormAdministrador";
            Text = "FormAdministrador";
            FormClosing += FormAdministrador_FormClosing;
            FormClosed += FormAdministrador_FormClosed;
            Load += FormAdministrador_Load;
            ((System.ComponentModel.ISupportInitialize)picture_Admin).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel_paraMostrar2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_MuestraBusquedaPorFecha.ResumeLayout(false);
            panel_MuestraBusquedaPorFecha.PerformLayout();
            panel4_BotonesReportes.ResumeLayout(false);
            panel_SeleccionaCarrera.ResumeLayout(false);
            panel_SeleccionaCarrera.PerformLayout();
            panel_Profesores.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private Label txt_nombreUsuario;
        private Button btn_Registrar;
        private Button btn_GestionarCursos;
        private PictureBox picture_Admin;
        private Panel panel1;
        private Panel panel_paraMostrar2;
        private Panel panel3;
        private Button btn_BajaCurso;
        private Button btn_ModificacionCurso;
        private Button btn_AltaCurso;
        private Button btn_GenerarReportes;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel4_BotonesReportes;
        private Button btn_ConceptosPago;
        private Button btn_EscritosEnCurso;
        private Button btn_PorPeriodo;
        private Button btn_ListaDeEsperaCursos;
        private Button btn_InscripcionXCarrera;
        private DataGridView dataGridView1;
        private Panel panel_MuestraBusquedaPorFecha;
        private DateTimePicker dTime_Hasta;
        private DateTimePicker dTime_Desde;
        private Button btn_Salir;
        private Button btn_Buscar;
        private Label label2;
        private Label label1;
        private Panel panel_SeleccionaCarrera;
        private Label label3;
        private ComboBox combo_Carreras;
        private Button btn_BuscarPorCarrera;
        private Button btn_DescargarReporte;
        private Button btn_RequisitosAcademicos;
        private Button btn_ListasDeEspera;
        private Button btn_GestorProfesor;
        private Panel panel_Profesores;
        private Button btn_AsignarProfesor;
        private Button btn_EditarProfesor;
        private Button btn_AgregaProfesor;
        private Button btn_EliminarProfesor;
    }
}