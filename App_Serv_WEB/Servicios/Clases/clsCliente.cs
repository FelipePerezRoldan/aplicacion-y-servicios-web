using Servicios.Models;
using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Servicios
{
    public class clsCliente
    {
        private DBSuperEntities dbSuper = new DBSuperEntities();
        public CLIEnte cliente { get; set; }

        public string Insertar()
        {
            try
            {
                //Para guardar en el entiti framework solo se usa el medoto add() de la clase gestinada.
                dbSuper.CLIEntes.Add(cliente);

                //Se guarda la inforamación con el metodo .savechanges()
                dbSuper.SaveChanges();
                return $"{cliente} ha sido insertado.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Actualizar()
        {
            dbSuper.CLIEntes.AddOrUpdate(cliente);
            dbSuper.SaveChanges();
            return $"El cliente {cliente} se ha actualizado o creado";
        }

        public CLIEnte Consultar(string documento)
        {
            return dbSuper.CLIEntes.FirstOrDefault(c => c.Documento == documento);
        }

        public string Eliminar()
        {
            try
            {
                //el cliente puede llegar desde la consulta vacio.
                CLIEnte _cliente = Consultar(cliente.Documento);
                if (_cliente == null)
                {
                    return $"El cliente {cliente.Nombre} no se encuentra en la base de datos";
                }
                else
                {
                    dbSuper.CLIEntes.Remove(_cliente);
                    dbSuper.SaveChanges();
                    return $"El cliente {cliente.Nombre} {cliente.PrimerApellido} {cliente.SegundoApellido} ha sido eliminado";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
