using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Domain;

namespace Services.ResourcesService
{
    public interface ICreateBautismoService
    {
        IEnumerable<Sacerdote> ListSacerdotes();
        IEnumerable<Departamento> Departamentos();
        IEnumerable<Municipio> Municipios(int DepartamentoId);
    }

    public class CreateBautismoService : ICreateBautismoService
    {
        private readonly ParroquiaDbContext _context;     

        public CreateBautismoService(ParroquiaDbContext context)
        {
            _context = context;
        }        

        public IEnumerable<Sacerdote> ListSacerdotes()
        {
            var listado = new List<Sacerdote>();
            try
            {
                listado = _context.Sacerdote.Include(x => x.PuestoSacerdote).ToList();
            }catch(Exception e)
            {
                throw;
            }

            return listado;
        }

        public IEnumerable<Departamento> Departamentos()
        {
            var listado = new List<Departamento>();
            try
            {
                listado = _context.Departamento.ToList();
            }
            catch (Exception e)
            {
                throw;
            }

            return listado;
        }

        public IEnumerable<Municipio> Municipios(int DepartamentoId)
        {
            var listado = new List<Municipio>();
            try
            {
                if(DepartamentoId != 0)
                {
                    listado = _context.Municipio.Where(x => x.DepartamentoId == DepartamentoId).ToList();
                }
                else
                {
                    listado = null;
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return listado;
        }
    }
}
