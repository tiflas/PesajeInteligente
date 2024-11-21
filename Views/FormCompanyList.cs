using PruebaTecnica_PasajeInteligente.Controllers;
using PruebaTecnica_PasajeInteligente.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTecnica_PasajeInteligente.Views
{
    public partial class FormCompanyList : Form
    {
        public FormCompanyList()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPageDetalleEmpresa); 
            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);
        }
        public void Imagen_load()
        {
            Thread.Sleep(3000);
        }
        private void BtsAgreEmpre_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            BtGuar.Show();
            BtoEditar.Hide();
            LimpiarCampos();
            TxtCodigoEmp.Show();
            label1.Show();
            panel1.Show();
        }

        private void TablaEmpresa_MouseClick(object sender, MouseEventArgs e)
        {
            TxtNombreEmp.Text = TablaEmpresa.CurrentRow.Cells[0].Value.ToString();
            TxtCodigoEmp.Text = TablaEmpresa.CurrentRow.Cells[1].Value.ToString();
            TxtDireccion.Text = TablaEmpresa.CurrentRow.Cells[2].Value.ToString();
            TxtTelefono.Text = TablaEmpresa.CurrentRow.Cells[3].Value.ToString();
            CbCiudad.Text = TablaEmpresa.CurrentRow.Cells[4].Value.ToString();
            CbDeparta.Text = TablaEmpresa.CurrentRow.Cells[5].Value.ToString();
            CbPais.Text = TablaEmpresa.CurrentRow.Cells[6].Value.ToString();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageDetalleEmpresa)
            {
                tabControl1.TabPages.Remove(tabPageDetalleEmpresa); 
                tabControl1.TabPages.Add(tabPageListaEmpresa);
            }
            else if (tabControl1.SelectedTab == tabPageListaEmpresa)
            {
                tabControl1.TabPages.Remove(tabPageListaEmpresa); 
                tabControl1.TabPages.Add(tabPageDetalleEmpresa);    
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            tabControl1.TabPages.Remove(tabPageDetalleEmpresa); 
            tabControl1.TabPages.Add(tabPageListaEmpresa);
        }

        private async void FormCompanyList_Load(object sender, EventArgs e)
        {
            try
            {
                Task oTask = new Task(Imagen_load);
                ImagenLoad.Visible = true;
                oTask.Start();
                await oTask;
                ModelsBD.CargarEmpresa(TablaEmpresa);

                tabControl1.SelectedTab = tabPageListaEmpresa;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ImagenLoad.Visible = false;
            }
        }
        private async Task<bool> VerificarExistenciaRegistroAsync()
        {
            string CC = TxtCodigoEmp.Text;

            // Intentar convertir CC a un entero
            if (int.TryParse(CC, out int codigoInt))
            {
                using (var context = new ApplicationDbContext())
                {
                    bool registroExiste = await context.Empresas.AnyAsync(e => e.Codigo == codigoInt);
                    return registroExiste;
                }
            }
            else
            {
                MessageBox.Show("El código ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private async void BtGuardar_Click(object sender, EventArgs e)
        {
            bool registroExiste = await VerificarExistenciaRegistroAsync();
            if (TxtNombreEmp.Text == "" || TxtCodigoEmp.Text == "" || TxtDireccion.Text == "" || TxtTelefono.Text == "")
            {
                MessageBox.Show("Hay Campos vacios obligatorios Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (registroExiste)
            {
                MessageBox.Show("La Empresa que has Ingresado ya se encuentra Registrada Porfavor Verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Empresa JEmpresa = new Empresa();

                JEmpresa.Codigo = Convert.ToInt32(TxtCodigoEmp.Text.Trim());
                JEmpresa.Nombre = TxtNombreEmp.Text.Trim();
                JEmpresa.Direccion = TxtDireccion.Text.Trim();
                JEmpresa.Telefono = TxtTelefono.Text.Trim();
                JEmpresa.Ciudad = CbCiudad.SelectedItem.ToString();
                JEmpresa.Departamento = CbDeparta.SelectedItem.ToString();
                JEmpresa.Pais = CbPais.SelectedItem.ToString();
                int Resultado = ModelsBD.InsertEmp(JEmpresa);
                if (Resultado > 0)
                {
                    MessageBox.Show("Se ha Registrado Correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ModelsBD.CargarEmpresa(TablaEmpresa);
                    LimpiarCampos();
                }
                else if (Resultado == -1)
                {
                    MessageBox.Show("La Empresa que Intenta Registra ya se Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimpiarCampos()
        {
            TxtNombreEmp.Text = string.Empty;
            TxtCodigoEmp.Text = string.Empty;
            TxtDireccion.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            TxtBuscarEmpre.Text = string.Empty;
            CbCiudad.Text = string.Empty;
            CbDeparta.Text = string.Empty;
            CbPais.Text = string.Empty;
            CbCiudad.SelectedIndex = -1; 
            CbDeparta.SelectedIndex = -1;
            CbPais.SelectedIndex = -1;
        }

        private void BuscarEmpre_Click(object sender, EventArgs e)
        {
            string textoBusqueda = TxtBuscarEmpre.Text.Trim();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                ModelsBD.CargarEmpresa(TablaEmpresa);
            }
            else
            {
                try
                {
                    using (var context = new ApplicationDbContext())
                    {
                        var empresas = context.Empresas
                            .Where(empresa => empresa.Nombre.Contains(textoBusqueda) ||
                                              empresa.Codigo.ToString().Contains(textoBusqueda))
                            .OrderBy(empresa => empresa.Nombre)
                            .Select(empresa => new
                            {
                                empresa.Nombre,
                                empresa.Codigo,
                                empresa.Direccion,
                                empresa.Telefono,
                                empresa.Ciudad,
                                empresa.Departamento,
                                empresa.Pais,
                                empresa.FechaCreacion,
                                empresa.FechaActualizacion
                            })
                            .ToList();

                        TablaEmpresa.DataSource = empresas;

                        if (!empresas.Any())
                        {
                            MessageBox.Show("No se encontraron empresas que coincidan con la búsqueda.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            if (TxtCodigoEmp.Text == "")
            {
                MessageBox.Show("No has seleccionado una Empresa", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tabControl1.SelectedIndex = 1;
                BtGuar.Hide();
                BtoEditar.Show();
                TxtCodigoEmp.Hide();
                label1.Hide();
                panel1.Hide();
            }
        }

        private void BtoEditar_Click(object sender, EventArgs e)
        {
            if (TxtNombreEmp.Text == "" || TxtCodigoEmp.Text == "" || TxtDireccion.Text == "" || TxtTelefono.Text == "")
            {
                MessageBox.Show("Hay Campos vacios obligatorios Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Empresa JEmpresa = new Empresa();

                JEmpresa.Codigo = Convert.ToInt32(TxtCodigoEmp.Text.Trim());
                JEmpresa.Nombre = TxtNombreEmp.Text.Trim();
                JEmpresa.Direccion = TxtDireccion.Text.Trim();
                JEmpresa.Telefono = TxtTelefono.Text.Trim();
                JEmpresa.Ciudad = CbCiudad.SelectedItem.ToString();
                JEmpresa.Departamento = CbDeparta.SelectedItem.ToString();
                JEmpresa.Pais = CbPais.SelectedItem.ToString();
                int Resultado = ModelsBD.ModificarEmpresa(JEmpresa);
                if (Resultado > 0)
                {
                    MessageBox.Show("Se ha Actualizado Correctamente", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ModelsBD.CargarEmpresa(TablaEmpresa);
                    LimpiarCampos();
                }
                else if (Resultado == -1)
                {
                    MessageBox.Show("No se lograron actualizar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (TablaEmpresa.SelectedRows.Count == 0)
            {
                MessageBox.Show("No has seleccionado ninguna empresa", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar las empresas seleccionadas?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int eliminados = 0;
                foreach (DataGridViewRow row in TablaEmpresa.SelectedRows)
                {
                    if (row.Cells["Codigo"]?.Value != null) 
                    {
                        int codigo = Convert.ToInt32(row.Cells["Codigo"].Value);
                        int resultado = ModelsBD.EliminarEmpresa(codigo);

                        if (resultado > 0)
                        {
                            eliminados++;
                        }
                    }
                }

                if (eliminados > 0)
                {
                    MessageBox.Show($"Se eliminaron {eliminados} empresas correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ModelsBD.CargarEmpresa(TablaEmpresa); 
                }
                else
                {
                    MessageBox.Show("No se pudieron eliminar algunas empresas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtBuscarEmpre_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = TxtBuscarEmpre.Text.Trim();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                ModelsBD.CargarEmpresa(TablaEmpresa);
            }
            else
            {
                try
                {
                    using (var context = new ApplicationDbContext())
                    {
                        var empresas = context.Empresas
                            .Where(empresa => empresa.Nombre.Contains(textoBusqueda) ||
                                              empresa.Codigo.ToString().Contains(textoBusqueda))
                            .OrderBy(empresa => empresa.Nombre)
                            .Select(empresa => new
                            {
                                empresa.Nombre,
                                empresa.Codigo,
                                empresa.Direccion,
                                empresa.Telefono,
                                empresa.Ciudad,
                                empresa.Departamento,
                                empresa.Pais,
                                empresa.FechaCreacion,
                                empresa.FechaActualizacion
                            })
                            .ToList();

                        TablaEmpresa.DataSource = empresas;

                        if (!empresas.Any())
                        {
                            Console.WriteLine("No se encontraron empresas que coincidan con la búsqueda.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
