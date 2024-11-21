using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PruebaTecnica_PasajeInteligente.Controllers;
using System.Data;
using System.Windows.Forms;

namespace PruebaTecnica_PasajeInteligente.Models
{
    class ModelsBD
    {
        public static class Utils
        {
            public static string ObtenerFechaBogota()
            {
                DateTime localDateTime = DateTime.Now;
                string bogotaTimeZoneId = "SA Pacific Standard Time";
                TimeZoneInfo bogotaTimeZone = TimeZoneInfo.FindSystemTimeZoneById(bogotaTimeZoneId);
                DateTime bogotaDateTime = TimeZoneInfo.ConvertTime(localDateTime, bogotaTimeZone);
                return bogotaDateTime.ToString("yyyy-MM-dd");
            }
        }
        public static int InsertEmp(Empresa empresa)
        {
            using (var context = new ApplicationDbContext())
            {
                empresa.FechaCreacion = empresa.FechaActualizacion = DateTime.Now; 
                context.Empresas.Add(empresa);
                return context.SaveChanges(); 
            }
        }
        public static int EliminarEmpresa(int codigo)
        {
            using (var context = new ApplicationDbContext())
            {
                var empresa = context.Empresas.FirstOrDefault(e => e.Codigo == codigo); // Buscar por el campo Codigo
                if (empresa != null)
                {
                    context.Empresas.Remove(empresa); 
                    return context.SaveChanges();     
                }
                return 0;
            }
        }
        public static int ModificarEmpresa(Empresa empresa)
        {
            using (var context = new ApplicationDbContext())
            {
                var existingEmpresa = context.Empresas.FirstOrDefault(e => e.Codigo == empresa.Codigo); // Buscar por Codigo
                if (existingEmpresa != null)
                {
                    existingEmpresa.Nombre = empresa.Nombre;
                    existingEmpresa.Direccion = empresa.Direccion;
                    existingEmpresa.Telefono = empresa.Telefono;
                    existingEmpresa.Ciudad = empresa.Ciudad;
                    existingEmpresa.Departamento = empresa.Departamento;
                    existingEmpresa.Pais = empresa.Pais;
                    existingEmpresa.FechaActualizacion = DateTime.Now;

                    return context.SaveChanges(); 
                }
                return 0; 
            }
        }
        public static void CargarEmpresa(DataGridView dgv)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var empresas = context.Empresas.OrderBy(e => e.Nombre).ToList();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Codigo");
                    dt.Columns.Add("Direccion");
                    dt.Columns.Add("Telefono");
                    dt.Columns.Add("Ciudad");
                    dt.Columns.Add("Departamento");
                    dt.Columns.Add("Pais");
                    dt.Columns.Add("FechaCreacion");
                    dt.Columns.Add("FechaActualizacion");

                    foreach (var empresa in empresas)
                    {
                        dt.Rows.Add(empresa.Nombre,
                                    empresa.Codigo,
                                    empresa.Direccion,
                                    empresa.Telefono,
                                    empresa.Ciudad,
                                    empresa.Departamento,
                                    empresa.Pais,
                                    empresa.FechaCreacion.ToString("yyyy-MM-dd"),
                                    empresa.FechaActualizacion.ToString("yyyy-MM-dd"));
                    }
                    dgv.DataSource = dt;

                    if (empresas.Count == 0)
                    {
                        MessageBox.Show("No se encontraron empresas en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empresas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
