using YtBookStore.Models.Domain;

namespace YtBookStore.Repository.Abstract
{
    public interface IGenreService
    {
        bool Add(Genre model);
        bool Update(Genre model);
        bool Delete(int id);
        Genre FinById(int id);
        IEnumerable<Genre> GetAll();

    }
}
