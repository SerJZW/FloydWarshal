using FloydWarshal;

class Program
{
    static void Main(string[] args)
    {
        // Создание графа
        Graph graph = new Graph(4);
        graph.AddEdge(0, 1, 2);
        graph.AddEdge(0, 2, 6);
        graph.AddEdge(1, 2, 3);
        graph.AddEdge(1, 3, 8);
        graph.AddEdge(2, 3, 1);

        // Вычисление и вывод кратчайших расстояний
        graph.FloydWarshall();
        graph.PrintShortestDistances();
    }
}
