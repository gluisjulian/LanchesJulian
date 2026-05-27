using LanchesJulian.Context;
using LanchesJulian.Models;
using LanchesJulian.Repositories.Interfaces;

namespace LanchesJulian.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
