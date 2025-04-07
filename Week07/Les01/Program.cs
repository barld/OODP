// See https://aka.ms/new-console-template for more information
using System.Text.Json;

static List<T> CreateEmptyList<T>()
{
    return new List<T>();
}

static void AddItem<T>(List<T> list, T item)
{
    list.Add(item);
}

static T GetRandomItem<T>(List<T> list)
{
    return list[new Random().Next(list.Count)];
}

var item = GetRandomItem(CreateEmptyList<string>());

static U Transform<T, U>(T item)
{
    if (item is U u)
        return u;
    throw new InvalidCastException("Can not Cast T to U");
}

public interface IJsonModel
{
    string Id { get; set; }
}

public abstract class JsonDataAccess<T>
{
    protected abstract string FileLocation { get; }

    public T? Get(string id)
    {
        return GetAll().FirstOrDefault(item => item is IJsonModel i && i.Id == id);
    }

    public IEnumerable<T> GetAll()
    {
        string json = File.ReadAllText(FileLocation);
        return JsonSerializer.Deserialize<IEnumerable<T>>(json);
    }

    public void Add(T item)
    {
        var items = GetAll().ToList();
        items.Add(item);
        Save(items);
    }

    protected void Save(IEnumerable<T> items)
    {
        string json = JsonSerializer.Serialize(items);
        File.WriteAllText(FileLocation, json);
    }

    public void Remove(string id)
    {
        var items = GetAll().Where(item => item is IJsonModel i && i.Id != id).ToList();
        Save(items);
    }

    public void Update(T item)
    {
        var items = GetAll().ToList();
        IJsonModel model = item as IJsonModel;
        var existingItem = items.FirstOrDefault(i => i is IJsonModel iModel && iModel.Id == model.Id);
        if (existingItem != null)
        {
            items.Remove(existingItem);
            items.Add(item);
            Save(items);
        }
    }
}
