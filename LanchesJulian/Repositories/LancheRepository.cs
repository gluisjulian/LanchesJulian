using LanchesJulian.Context;
using LanchesJulian.Models;
using LanchesJulian.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesJulian.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(l => l.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(l => l.IsLanchePreferido).Include(l => l.Categoria);

        public Lanche GetLancheById(int lacnheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lacnheId);
        }
    }
}
