using EntidadesSysacad;
using LogicaDeNegocio;
using System.Windows.Forms;

namespace formEntradaUsuario
{
    public partial class FormAdministrador : Form
    {
        Administrador administrador;
        private const string rutaImagen = @"C:\Users\Ignacio Pereyra\Desktop\Solution C#\formEntradaUsuario\Imagenes\admin.png";
        private bool botonApretado = false;
        private int botonParaDataGrid;
        private bool panelTresOcupado = false;
        private bool botonConceptoPago ;
        private string nombreArchivoActualPDF = "Archivo.pdf";
        private string nombreArchivoActualExcel = "Archivo.xlsx";


        public FormAdministrador(Administrador elAdmin)
        {
            InitializeComponent();
            administrador = elAdmin;
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            FormIngresoDatosEstudiante ingresoEstudiante = new FormIngresoDatosEstudiante();
            ingresoEstudiante.ShowDialog();
            if (ingresoEstudiante.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Estudiante registrado correctamente");

            }
            else
            {
                MessageBox.Show("Error en el registro");
            }
        }

        private void btn_GestionarCursos_Click(object sender, EventArgs e)
        {
            panel_paraMostrar2.Visible = true;

        }
        private void AdaptaFormParaPanelUno(Form form, Panel panel)
        {
            if (form is not null)
            {
                panel.Visible = true;
                botonApretado = true;
                form.TopLevel = false;
                panel.Controls.Add(form);
                form.Size = panel.Size;
                form.Location = new Point(0, 0);
                form.Show();
            }
        }
        private void FormAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)this.Owner).Show();
        }
        private void FormAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  DialogResult result = MessageBox.Show($"¿Confirma los cambios? ", "Confirmación de eliminación", MessageBoxButtons.YesNoCancel);
          ///  if (result == DialogResult.Yes)
///{
              //  GestorEstudiantes.GuardarListaEstudiantesEnArchivos();
           //     GestorCursos.GuardaListaCursosEnArchivo();
          //  }
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            txt_nombreUsuario.Text = administrador.Nombre + administrador.Apellido;
            CambiarTamanioImagen();
            CargaComboCarreras();
            panel_paraMostrar2.Visible = false;
        }
        private void CambiarTamanioImagen()
        {
            Image imagenAdmin = Image.FromFile(rutaImagen);
            picture_Admin.SizeMode = PictureBoxSizeMode.CenterImage;
            int ancho = 50;
            int alto = 50;
            imagenAdmin = new Bitmap(imagenAdmin, ancho, alto);
            picture_Admin.Image = imagenAdmin;
            picture_Admin.Size = new Size(ancho, alto);

        }

        private void panel_paraMostrar2_Paint(object sender, PaintEventArgs e)
        {
            if (botonApretado)
            {
                panel_paraMostrar2.Visible = true;
            }
        }

        private void btn_AltaCurso_Click_1(object sender, EventArgs e)
        {
            FormAltaCurso frmAlta = new FormAltaCurso();
            AdaptaFormParaPanelUno(frmAlta, panel3);
            panel3.Controls.Add(frmAlta);
            frmAlta.Show();
        }

        private void btn_ModificacionCurso_Click(object sender, EventArgs e)
        {
            botonParaDataGrid = -1;
            FormMuestraDataGridConCursos formMuestra = new FormMuestraDataGridConCursos(botonParaDataGrid);
            AdaptaFormParaPanelUno(formMuestra, panel3);
            panel3.Controls.Add(formMuestra);
            formMuestra.Show();
            formMuestra.FormClosed += (sender, e) => { MessageBox.Show("Se cerro el form"); };
        }

        private void btn_BajaCurso_Click(object sender, EventArgs e)
        {
            botonParaDataGrid = 1;
            FormMuestraDataGridConCursos formBaja = new FormMuestraDataGridConCursos(botonParaDataGrid);
            AdaptaFormParaPanelUno(formBaja, panel3);
            panel3.Controls.Add(formBaja);
            formBaja.Show();
            formBaja.FormClosed += (sender, e) => { MuestroBotonesCursos(); };
        }
        private void MuestroBotonesCursos()
        {
            panel_paraMostrar2.Visible = false;
        }

        private void btn_EscritosEnCurso_Click(object sender, EventArgs e)
        {
            botonParaDataGrid = 0;
            FormMuestraDataGridConCursos frm = new FormMuestraDataGridConCursos(botonParaDataGrid);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK && frm.Estudiantes.Count > 0)
            {
                panelTresOcupado = true;
                dataGridView1.DataSource = null;
                List<Estudiante> listaParaMostrar = CargaListaConSoloUnEstudianteSegunDni(frm.Estudiantes);
                dataGridView1.DataSource = listaParaMostrar;
                ConfigurarDataGridView();
                dataGridView1.Visible = true;
            }
            else
            {
                MessageBox.Show("No hay alumnos registrados");
            }
        }
        private void btn_GenerarReportes_Click(object sender, EventArgs e)
        {
            panel4_BotonesReportes.Visible = true;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void ConfigurarColumna(string nombreColumna)
        {
            DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
            columna.HeaderText = nombreColumna;
            // columna.DataPropertyName = nombrePropiedad;
            dataGridView1.Columns.Add(columna);
        }
        private void OcultarColumna(string nombrePropiedad)
        {
            if (dataGridView1.Columns.Contains(nombrePropiedad))
            {
                dataGridView1.Columns[nombrePropiedad].Visible = false;
            }
        }
        private void ConfigurarDataGridView()
        {

            OcultarColumna("TienePermisos");
            OcultarColumna("CambiarContrasenia");
            OcultarColumna("Contrasenia");
            OcultarColumna("Direccion");
            OcultarColumna("Telefono");

        }
        private List<Estudiante> CargaListaConSoloUnEstudianteSegunDni(List<Estudiante> estudiantes)
        {
            List<Estudiante> estudiantesParaMostrar = new List<Estudiante>();
            foreach (Estudiante item in estudiantes)
            {
                if (!estudiantesParaMostrar.Contains(item))
                {
                    estudiantesParaMostrar.Add(item);
                }
            }
            return estudiantesParaMostrar;
        }

        private void btn_PorPeriodo_Click(object sender, EventArgs e)
        {
            panel_MuestraBusquedaPorFecha.Visible = true;
            panel4_BotonesReportes.Visible = false;
            botonConceptoPago = false;
            nombreArchivoActualPDF = "EstudiantesPorPeriodo.pdf";
            nombreArchivoActualExcel = "EstudiantesPorPeriodo.xlsx";

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            btn_Buscar.Enabled = false;
            dTime_Desde.Enabled = false;
            dTime_Hasta.Enabled = false;
            DateTime fechaInicio = dTime_Desde.Value;
            DateTime fechaFin = dTime_Hasta.Value;
            if (botonConceptoPago==false)
            {
                List<Estudiante> listaEstudiante;
                listaEstudiante = GestorEstudiantes.BuscaEstudiantePorFechaInscripcion(fechaInicio, fechaFin);
                if (listaEstudiante is not null && listaEstudiante.Count > 0)
                {
                    LimpiaDataGrid();
                    dataGridView1.DataSource = listaEstudiante;
                    ConfigurarDataGridView();
                    panel3.Visible = true;
                    dataGridView1.Visible = true;
                }
                else
                {
                    MessageBox.Show("No hay registros en estas fechas");
                    panel_MuestraBusquedaPorFecha.Focus();
                    dTime_Desde.Enabled = true;
                    dTime_Hasta.Enabled = true;
                    btn_Buscar.Enabled = true;
                }
            }
            else
            {
                List<PagosRealizadosPorUsuario> listaPagos = new List<PagosRealizadosPorUsuario>();
                listaPagos = GestorDePagos.ObtieneListaPagosDeUsuarios(fechaInicio, fechaFin);
                if (listaPagos is not null && listaPagos.Count > 0)
                {
                    dataGridView1.DataSource = listaPagos;
                    panel3.Visible = true;
                    dataGridView1.Visible = true;
                }
                else
                {
                    MessageBox.Show("No hay pagos registrados");
                    panel_MuestraBusquedaPorFecha.Focus();
                    dTime_Desde.Enabled = true;
                    dTime_Hasta.Enabled = true;
                    btn_Buscar.Enabled = true;
                }

            }

        }
        private void LimpiaDataGrid()
        {
            dataGridView1.Rows.Clear();

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            panel_MuestraBusquedaPorFecha.Visible = false;
            panel4_BotonesReportes.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e) //por carrera
        {
            panel_SeleccionaCarrera.Visible = true;
            nombreArchivoActualPDF = "EstudiantesPorCarrera.pdf";
            nombreArchivoActualExcel = "EstudiantesPorCarrera.xlsx";
        }

        private void btn_BuscarPorCarrera_Click(object sender, EventArgs e)
        {
            if (combo_Carreras.SelectedItem is not null)
            {
                Carreras carreraSelec = (Carreras)combo_Carreras.SelectedItem + 1;
                List<Estudiante> listaSegunCarreraElegida;
                listaSegunCarreraElegida = GestorEstudiantes.BuscaEstudiantesPorCarrera(carreraSelec);
                if (listaSegunCarreraElegida is not null)
                {
                    //  LimpiaDataGrid();
                    dataGridView1.DataSource = listaSegunCarreraElegida;
                    ConfigurarDataGridView();
                    dataGridView1.Visible = true;
                    panel3.Visible = true;
                }
                else
                {
                    MessageBox.Show("No hay estudiantes en esa carrera ");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una carrera antes de buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void CargaComboCarreras()
        {
            combo_Carreras.Items.Add(Carreras.TecnicaturaEnProgramacion);
            combo_Carreras.Items.Add(Carreras.Enfermeria);
            combo_Carreras.Items.Add(Carreras.Administracion);
            combo_Carreras.Items.Add(Carreras.LiquidacionDeSueldos);
            combo_Carreras.Items.Add(Carreras.Contabilidad);
            combo_Carreras.Items.Add(Carreras.Periodismo);
            combo_Carreras.Items.Add(Carreras.AnalistaDeRedes);
        }

        private void btn_ConceptosPago_Click(object sender, EventArgs e)
        {
            botonConceptoPago = true;
            panel_MuestraBusquedaPorFecha.Visible = true;
            nombreArchivoActualPDF = "PagosPorPeriodo.pdf";
            nombreArchivoActualExcel = "PagosPorPeriodo.xlsx";

        }

        private void btn_ListaDeEsperaCursos_Click(object sender, EventArgs e)
        {
            CargaListaDeEspera();
            nombreArchivoActualPDF = "EstudiantesListaEspera.pdf";
            nombreArchivoActualExcel = "EstudiantesListaEspera.xlsx";
        }
        private void CargaListaDeEspera()
        {
            List<Curso> listaConListaEsperaParaMostrar = new List<Curso>();
            List<Curso> listaConListaEspera = GestorCursos.ObtieneListaCursos();
            foreach (Curso item in listaConListaEspera)
            {
                if (item.CodigoListaEspera > 0)
                {
                    listaConListaEsperaParaMostrar.Add(item);
                }
            }


            if (listaConListaEsperaParaMostrar is not null)
            {
                dataGridView1.DataSource = listaConListaEsperaParaMostrar;
                dataGridView1.Visible = true;
                panel3.Visible = true;
            }
            else
            {
                MessageBox.Show("No hay estudiantes en lista de espera");
            }


        }

        private void btn_DescargarReporte_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.DataSource is not null)
            {
                btn_DescargarReporte.Enabled = true;
                List<object> listaGen;
                listaGen = ObtieneDatosDesdeDataGrid(dataGridView1);
                GenerarReporte(listaGen);
            }


        }
        private List<object> ObtieneDatosDesdeDataGrid(DataGridView dataGrid)
        {
            List<object> datos = new List<object>();
            foreach (DataGridViewRow item in dataGrid.Rows)
            {
                if (item is not null && !item.IsNewRow)
                {
                    object[] filaDatos = new object[dataGrid.Columns.Count];
                    for (int i = 0; i < dataGrid.Columns.Count; i++)
                    {
                        filaDatos[i] = item.Cells[i].Value;
                    }
                    datos.Add(filaDatos);
                }
            }
            return datos;
        }

        private void btn_RequisitosAcademicos_Click(object sender, EventArgs e)
        {
            FormMuestraDataGridConCursos formMuestraDataGridConCursos = new FormMuestraDataGridConCursos(2);
            DialogResult dialogResult = formMuestraDataGridConCursos.ShowDialog();

            if (formMuestraDataGridConCursos.cursoSeleccionado is not null && dialogResult == DialogResult.OK)
            {
                RequisitosAcademicos formRequisitos = new RequisitosAcademicos(formMuestraDataGridConCursos.cursoSeleccionado);
                DialogResult dialog = formRequisitos.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    MessageBox.Show("Se agrego correctamente el requisito");
                }
                else
                {
                    MessageBox.Show("No se agrego correctamente el requisito");
                }

            }

        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ListasDeEspera_Click(object sender, EventArgs e)
        {
            FormMuestraDataGridConCursos formMuestraDataGridConCursos = new FormMuestraDataGridConCursos(3);
            DialogResult dialogResult = formMuestraDataGridConCursos.ShowDialog();
            if (formMuestraDataGridConCursos.cursoSeleccionado is not null && dialogResult == DialogResult.OK)
            {

            }
        }

        private void btn_AgregaProfesor_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                FormIngresoDatosProfesor formIngresoDatosProfesor = new FormIngresoDatosProfesor(1);
                DialogResult dialog = formIngresoDatosProfesor.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    MessageBox.Show("Profesor agregado correctamente");
                }
            });
        }

        private void btn_EditarProfesor_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                FormMuestraProfesores muestraProfe = new FormMuestraProfesores(1);
                muestraProfe.ShowDialog();
                if (muestraProfe.DialogResult == DialogResult.OK && muestraProfe.unProfe is not null)
                {
                    Task.Run(() =>
                    {
                        FormIngresoDatosProfesor formIngresoDatosProfesor = new FormIngresoDatosProfesor(2, muestraProfe.unProfe);
                        DialogResult dialog = formIngresoDatosProfesor.ShowDialog();
                        if (dialog == DialogResult.OK)
                        {
                            GestorProfesores.ModificaProfesor(muestraProfe.unProfe);
                        }
                    });
                }
            });
        }

        private void btn_GestorProfesor_Click(object sender, EventArgs e)
        {
            panel_Profesores.Visible = true;
        }

        private void btn_AsignarProfesor_Click(object sender, EventArgs e)
        {
            FormMuestraProfesores muestraProfe = new FormMuestraProfesores(1);
           DialogResult dialog = muestraProfe.ShowDialog();
            if (dialog == DialogResult.OK && muestraProfe.unProfe is not null)
            {

                Task.Run(() => 
                {
                    FormMuestraMaterias frmMuestraMaterias = new FormMuestraMaterias(2, muestraProfe.unProfe);
                    frmMuestraMaterias.ShowDialog();
                    if (frmMuestraMaterias.DialogResult == DialogResult.OK)
                    {
                        GestorProfesores.ModificaProfesor(muestraProfe.unProfe);
                    }
                });
            }
        }
        private void GenerarReporte<T>(List<T> data)
        {
            var generadorPdf = new PdfGeneradorReporte<T>();
            generadorPdf.GenerarReporte(data, nombreArchivoActualPDF);
            var generadorExcel = new ExcelGeneradorReporte<T>();
            generadorExcel.GenerarReporte(data, nombreArchivoActualExcel);
        }
    }
}


