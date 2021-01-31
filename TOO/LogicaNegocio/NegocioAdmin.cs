using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using ModeloDominio;

namespace LogicaNegocio
{
    public class NegocioAdmin
    {
        //-------------------------------------------------------------------------------
        //Gestion de Clientes

        ///<summary>
        ///Da de alta un cliente en la BD 
        ///</summary>
        public void darAltaCliente(Cliente c)
        {
            PersistenciaCliente.Añadir(c);
        }
        ///<summary>
        ///Da de baja un cliente en la BD 
        ///</summary>
        public bool darBajaCliente(ModeloDominio.Cliente c)
        {
            return PersistenciaCliente.Eliminar(c);
        }
        ///<summary>
        ///Devuelve un cliente de la base de datos cuyo dni se pasa por parametro(Encapsulado en un tipo cliente)
        ///</summary>
        public Cliente seleccionarCliente(Cliente c)
        {
            return PersistenciaCliente.Buscar(c);
        }
        ///<summary>
        ///Modifica un cliente de la base de datos cuyo dni se pasa por parametro(Encapsulado en un tipo cliente)
        ///</summary>

        public bool modificarCliente(Cliente c)
        {
            return PersistenciaCliente.Modificar(c);
        }
        ///<summary>
        ///Devuelve true si el cliente existe , falso en caso contrario. 
        ///</summary>
        public Boolean existeCliente(String dni)
        {
            return PersistenciaCliente.Existe(dni);
        }
        ///<summary>
        ///Devuelve una lista con todos los clientes existentes en la base de datos
        ///</summary>
        public List<Cliente> listarClientes()
        {
            return PersistenciaCliente.GETClientes();
        }
        ///<summary>
        ///Devuelve todos los presupuestos de un determinado cliente pasado por parametro
        ///</summary>
        public List<Presupuesto> obtenerPresupuestosPorCliente(Cliente c)
        {
            return PersistenciaCliente.GETPresupuestosCliente(c);
        }

        //------------------------------------------------------------------------------
        //Gestion de Vehiculos
        ///<summary>
        ///Añade un vehiculo a la Base de datos
        ///</summary>
        public void darAltaVehiculo(Vehiculo nuevoVehiculo)
        {
            PersistenciaVehiculo.Añadir(nuevoVehiculo);
        }
        ///<summary>
        ///Elimina un vehículo de la base de datos
        ///</summary>
        public bool darBajaVehiculo(Vehiculo v)
        {
            return PersistenciaVehiculo.Eliminar(v);
        }
        ///<summary>
        ///Devuelve true si el presupuesto existe , falso en caso contrario. 
        ///</summary>
        public Boolean existeVehiculo(String bas)
        {
            return PersistenciaVehiculo.Existe(bas);
        }
        ///<summary>
        ///Devuelve un vehiculo de la base de datos cuyo numero de bastidor se pasa por parametro(Encapsulado en un tipo cliente)
        ///</summary>
        public Vehiculo seleccionarVehiculo(Vehiculo v)
        {
            return PersistenciaVehiculo.Buscar(v);
        }
        ///<summary>
        ///Devuelve todos los vehiculos existentes de la base de datos
        ///</summary>
        public List<Vehiculo> listarVehiculos()
        {
            return PersistenciaVehiculo.GETVehiculos();
        }

        //------------------------------------------------------------------------------
        //Gestion de Presupuestos
        ///<summary>
        ///Inserta un presupuesto en la base de datos , y lo asocia a sus tablas correspondientes
        ///</summary>
        public void crearPresupuesto(Presupuesto p, List<Vehiculo> vehiculos)
        {
            foreach(Vehiculo v in vehiculos)
            {
                p.CocheList.Add(v);
                PersistenciaPresupuestoVehiculo.Añadir(new PresupuestoVehiculoDato(new Clave(p.Id_presupuesto,v.NumBastidor)));
            }
            PersistenciaPresupuesto.Añadir(p);
        }
        ///<summary>
        ///Elimina un presupuesto de la base de datos
        ///</summary>
        public bool eliminarPresupuesto(Presupuesto p)
        {
            return PersistenciaPresupuesto.Eliminar(p);
        }
        ///<summary>
        ///Devuelve un presupuesto de la base de datos cuyo identificador se pasa por parametro(Encapsulado en un tipo cliente)
        ///</summary>
        public Presupuesto seleccionarPresupuesto(Presupuesto p)
        {
            return PersistenciaPresupuesto.Buscar(p);
        }
        ///<summary>
        ///Devuelve todos los presupuestos existentes en la base de datos
        ///</summary>
        public List<Presupuesto> listarPresupuestos()
        {
            return PersistenciaPresupuesto.GETPresupuestos();
        }
        ///<summary>
        ///Devuelve verdadero si el presupuesto pasado por parametro esta en la base de datos falso en caso contrario
        ///</summary>
        public Boolean existePresupuesto(String iden)
        {
            return PersistenciaPresupuesto.Existe(iden);
        }

        /*
        public void obtenerDatosClientePresupuesto(ModeloDominio.Presupuesto p)
        {
            obtenerInfoCliente(Persistencia.BD.SELECTPresupuesto(p).getCliente())
;       }
        
        public void obtenerDatosVehiculoPresupuesto(ModeloDominio.Presupuesto p)
        {
            foreach (ModeloDominio.Vehiculo v in Persistencia.BD.SELECTPresupuesto(p).getVehiculos()) { 
                obtenerInfoVehiculo(v);
            }
        }
       

        public void obtenerDatosPresupuesto(ModeloDominio.Presupuesto p)
        {
            System.Console.WriteLine("ID: " + p.getId_presupuesto());
            System.Console.WriteLine("Fecha Relizacion: " + p.getFecha_Realizacion());
            System.Console.WriteLine("Estado: " + p.getEstado());
            System.Console.WriteLine("Cliente: " + p.getCliente());
            System.Console.WriteLine("Vehiculos: " + p.getVehiculos());
        }


        //Seguramente de fallo
        public List<ModeloDominio.Presupuesto> obtenerTodosPresupuestosVehiculo(ModeloDominio.Vehiculo v) {
            System.Collections.IList list = Persistencia.BD.GETPresupuestosVehiculosDatos(v);
            List<ModeloDominio.Presupuesto> listaP = new List<ModeloDominio.Presupuesto>();
            for (int i = 0; i < list.Count; i++) {
                ModeloDominio.Presupuesto p = (ModeloDominio.Presupuesto)list[i];
                listaP.Add(p);
            }
            return listaP;
        }
        
        public void obtenerTodosPresupuestosPorEstado(bool estado)
        {
            foreach (ModeloDominio.Presupuesto p in Persistencia.BD.GETPresupuestosVehiculosDatos(estado))
            {
                obtenerDatosClientePresupuesto(Persistencia.BD.SELECTPresupuesto(p));
            }
        }*/
    }
}
