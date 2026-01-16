using ntierapp.Models;

namespace ntierapp.DAL;

public interface ITodoRepository
{
    IEnumerable<Todo> GetAll();
    Todo? GetById(int id);
}

public class TodoRepository : ITodoRepository
{
    private readonly Todo[] _sampleTodos = new Todo[]
    {
        new(1, "Walk the dog"),
        new(2, "Do the dishes", DateOnly.FromDateTime(DateTime.Now)),
        new(3, "Do the laundry", DateOnly.FromDateTime(DateTime.Now.AddDays(1))),
        new(4, "Clean the bathroom"),
        new(5, "Clean the car", DateOnly.FromDateTime(DateTime.Now.AddDays(2)))
    };

    public IEnumerable<Todo> GetAll()
    {
        return _sampleTodos;
    }

    public Todo? GetById(int id)
    {
        return _sampleTodos.FirstOrDefault(a => a.Id == id);
    }
}
