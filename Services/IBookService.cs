using WebApplication3.ViewModels;

namespace WebApplication3.Services
{
    public interface IBookService
    {
        Task<IEnumerable<BookViewModel>> GetAll();
        Task<BookViewModel> GetById(int id);
        Task Create(BookViewModel book);
        Task<BookViewModel> Update(int id, BookViewModel book);
        Task Delete(int id);
    }
}
