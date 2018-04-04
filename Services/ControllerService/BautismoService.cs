using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Domain;

namespace Services.ControllerService
{
    public interface IBautismoService
    {
        bool Create(Bautismo model);
        IEnumerable<Bautismo> GetBautismos();
        IEnumerable<Bautismo> ListaBautismosPaginados();
    }

    public class BautismoService : IBautismoService
    {
        private readonly ParroquiaDbContext _context;

        public BautismoService(ParroquiaDbContext context)
        {
            _context = context;
        }

        public bool Create(Bautismo model)
        {
            try
            {
                _context.Entry(model).State = EntityState.Added;
                _context.SaveChanges();
                
            }catch(Exception ex)
            {                
                return false;
            }
            return true;
        }

        public IEnumerable<Bautismo> ListaBautismosPaginados()
        {            
            var query = _context.Bautismo.AsNoTracking()
                                                    .Include(x => x.Sacerdote)
                                                    .Include(y => y.Departamento);
            Console.WriteLine(query.GetType());            
            return query;
        }

        public IEnumerable<Bautismo> GetBautismos()
        {
            var listaBautismos = new List<Bautismo>();
            try
            {
                listaBautismos = _context.Bautismo
                                                .Include(x => x.Sacerdote)
                                                .Include(y => y.Departamento)
                                                .ToList();
            }catch(Exception ex)
            {
                throw;
            }

            return listaBautismos;
        }
    }
}
