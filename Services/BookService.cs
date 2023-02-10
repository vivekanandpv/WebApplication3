using System.Reflection.Metadata.Ecma335;
using WebApplication3.ViewModels;

namespace WebApplication3.Services;

public class BookService : IBookService
{
    private readonly ILogger<BookService> _logger;

    public BookService(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<BookService>();
    }

    public async Task<IEnumerable<BookViewModel>> GetAll()
    {
        _logger.LogInformation($"Inside Service: {nameof(GetAll)}");
        var list = new List<BookViewModel>
        {
            new BookViewModel { Edition = 1, Title = "Programming C# 10" },
            new BookViewModel { Edition = 4, Title = "Computer Organization" }
        };

        return await Task.FromResult(list);
    }

    public async Task<BookViewModel> GetById(int id)
    {
        _logger.LogInformation($"Inside Service: {nameof(GetById)}");
        return await Task.FromResult(new BookViewModel { Edition = 4, Title = "Computer Organization" });
    }

    public async Task Create(BookViewModel book)
    {
        _logger.LogInformation($"Inside Service: {nameof(Create)}");
        await Task.CompletedTask;
    }

    public async Task<BookViewModel> Update(int id, BookViewModel book)
    {
        _logger.LogInformation($"Inside Service: {nameof(Update)}");
        return await GetById(id);
    }

    public async Task Delete(int id)
    {
        _logger.LogInformation($"Inside Service: {nameof(Delete)}");
        await Task.CompletedTask;
    }
}