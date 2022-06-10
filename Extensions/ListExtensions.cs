namespace nng_one.Extensions;

public static class ListExtensions
{
    public static List<T> CutTo<T>(this List<T> list, int index)
    {
        index = Math.Clamp(index, 0, list.Count);

        var result = new List<T>();
        for (var i = 0; i < index; i++) result.Add(list[i]);

        list.RemoveRange(0, index);

        return result;
    }
}
