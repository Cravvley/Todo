using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.TodoItems.Any()) return;

            var todos = new List<TodoItem>
            {
                new TodoItem
                {
                    Title="Do something"
                },
                new TodoItem
                {
                    Title="Do something2"
                }
            };

            await context.TodoItems.AddRangeAsync(todos);
            await context.SaveChangesAsync();
        }
    }
}