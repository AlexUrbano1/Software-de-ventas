﻿using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Negocio
    {
        public CD_Negocio objcd_negocio = new CD_Negocio();

        public Negocio ObtenerDatos()
        {
            return objcd_negocio.ObtenerDatos();
        }
        public bool GuardarDatos(Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre\n";
            }

            if (obj.RUC == "")
            {
                Mensaje += "Es necesario el RUC\n";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario la dirección\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_negocio.GuardarDatos(obj, out Mensaje);
            }
        }
        public byte [] ObtenerLogo(out bool obtenido)
        {
            return objcd_negocio.ObtenerLogo(out obtenido);
        }
        public bool ActualizarLogo(byte[] imagen,out string mensaje)
        {
            return objcd_negocio.ActualizarLogo(imagen, out mensaje);
        }




    }
}
