using CharityProjectMVC.Contexts;
using CharityProjectMVC.Exceptions;
using CharityProjectMVC.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CharityProjectMVC.Services
{
    public class CauseService
    {
        private AppDbContext _context;
        
        public CauseService()
        {
            _context = new AppDbContext();
        }
        #region Create
        public void AddCause(Cause cause)
        {
            _context.causes.Add(cause);
            _context.SaveChanges();
        }
        #endregion

       
        #region Read
        public List<Cause> GetAllCause()
        {
            List<Cause>causes=_context.causes.ToList();
            return causes;
        }
        public Cause GetCauseById(int id)
        {
            Cause? cause = _context.causes.Find(id);
            if (cause is not null)
            {
                return cause;
            }
            throw new CauseException("Tapiulmadi");
           
        }
        #endregion

        #region Update
        public void Update(int id, Cause cause)
        {
            Cause causes = _context.causes.Find(id);
            causes.Name= cause.Name;
            causes.Description= cause.Description;
            causes.Price= cause.Price;
            causes.ImgUrl= cause.ImgUrl;
            _context.SaveChanges();
        }
        #endregion


        public void Delete(int id)
        {
            Cause cause = _context.causes.Find(id);
           _context.causes.Remove(cause);
            _context.SaveChanges();
        }
    }
}
