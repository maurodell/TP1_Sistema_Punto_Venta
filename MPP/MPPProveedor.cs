using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Abstraccion;
using BE;
using System.Xml.Linq;

namespace MPP
{
    public class MPPProveedor : Repositorio<BEClsProveedor>
    {
        public bool Alta(int Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Baja(int Objeto)
        {
            try
            {
                XDocument documento = XDocument.Load("Proveedores.XML");

                var consulta = from proveedor in documento.Descendants("proveedor")
                               where proveedor.Attribute("id").Value == Objeto.ToString()
                               select proveedor;
                consulta.Remove();

                documento.Save("Proveedores.XML");
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Crear(BEClsProveedor Objeto)
        {
            try
            {
                XDocument crear = XDocument.Load("Proveedores.XML");
                crear.Element("proveedores").Add(new XElement("proveedor",
                                                new XAttribute("id", Objeto.Codigo),
                                                new XElement("nombre", Objeto.Nombre),
                                                new XElement("domicilio", Objeto.Domicilio),
                                                new XElement("telefono", Objeto.Telefono),
                                                new XElement("rubro", Objeto.Rubro)));
                crear.Save("Proveedores.XML");
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool Modificar(BEClsProveedor Objeto)
        {
            try
            {
                XDocument documento = XDocument.Load("Proveedores.XML");

                var consulta = from proveedor in documento.Descendants("proveedor")
                               where proveedor.Attribute("id").Value == Convert.ToString(Objeto.Codigo)
                               select proveedor;

                foreach (XElement EModifcar in consulta)
                {
                    EModifcar.Element("nombre").Value = Objeto.Nombre;
                    EModifcar.Element("domicilio").Value = Objeto.Domicilio;
                    EModifcar.Element("rubro").Value = Objeto.Rubro;
                    EModifcar.Element("telefono").Value = Objeto.Telefono;
                }

                documento.Save("Proveedores.XML");
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public BEClsProveedor LeerObjeto(int Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEClsProveedor> ListarBusquedaApellido(BEClsProveedor Objeto)
        {
            throw new NotImplementedException();
        }
        public List<BEClsProveedor> ListarTodos()
        {
            var consulta =from proveedor in XElement.Load("Proveedores.XML").Elements("proveedor")
                        select new BEClsProveedor
                        {
                            Codigo = Convert.ToInt32(Convert.ToString(proveedor.Attribute("id").Value).Trim()),
                            Nombre = Convert.ToString(proveedor.Element("nombre").Value).Trim(),
                            Domicilio = Convert.ToString(proveedor.Element("domicilio").Value).Trim(),
                            Telefono = Convert.ToString(proveedor.Element("telefono").Value).Trim(),
                            Rubro = Convert.ToString(proveedor.Element("rubro").Value).Trim()
                        };
            List<BEClsProveedor> listaProveedor = consulta.ToList<BEClsProveedor>();
            return listaProveedor;
        }
        public List<BEClsProveedor> BuscarXNombre(string Objeto)
        {
            var consulta = from proveedor in XElement.Load("Proveedores.XML").Elements("proveedor")
                           where (string)proveedor.Element("nombre") == Objeto.ToString()
                           select new BEClsProveedor
                           {
                               Codigo = Convert.ToInt32(Convert.ToString(proveedor.Attribute("id").Value).Trim()),
                               Nombre = Convert.ToString(proveedor.Element("nombre").Value).Trim(),
                               Domicilio = Convert.ToString(proveedor.Element("domicilio").Value).Trim(),
                               Telefono = Convert.ToString(proveedor.Element("telefono").Value).Trim(),
                               Rubro = Convert.ToString(proveedor.Element("rubro").Value).Trim()
                           };

            List<BEClsProveedor> buscados = consulta.ToList<BEClsProveedor>();
            return buscados;
        }
    }
}
