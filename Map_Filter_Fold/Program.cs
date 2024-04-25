public class Functions
{
    public delegate Tres F_for_Map<T, Tres>(T value);
    public List<Tres> Map<T, Tres>(List<T> list_start, F_for_Map<T, Tres> fun)
    {
        List<Tres> result = [];
        for (int i = 0; i<list_start.Count; ++i)
        {
            result.Add(fun(list_start[i]));
        }
        return result;
    } 

}
class Program
{
    static void Main(string[] args)
    {
        var _Functions = new Functions();
        var list = new List<int> {1, 2, 3};
        Console.WriteLine(_Functions.Map(list, x=>x*2)[1]);
    }
}
