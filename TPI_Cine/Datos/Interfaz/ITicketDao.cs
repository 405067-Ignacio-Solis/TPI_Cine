﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Cine_Backend.Datos.Interfaz
{
    public interface ITicketDao
    {
        int ObtenerProximoTicket();
        List<Cliente> ObtenerClientes();
        bool CrearTicket(Ticket oTicket);
        bool ActualizarTicket(Ticket oTicket);
        bool BorrarTicket(int numero);
        List<Ticket> ObtenerTicketsPorFiltros(List<Parametro> lFiltros);
        Ticket ObtenerTicketPorNro(int numero);
        List<Funcion> ObtenerFunciones();
    }
}
