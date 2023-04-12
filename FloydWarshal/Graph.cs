using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloydWarshal
{

    class Graph
    {
        private int V; // Количество вершин
        private int[,] dist; // Матрица расстояний

        public Graph(int vertices)
        {
            V = vertices;
            dist = new int[V, V];

            // Инициализация матрицы расстояний бесконечными значениями
            for (int i = 0; i < V; i++)
            {
                for (int j = 0; j < V; j++)
                {
                    dist[i, j] = int.MaxValue;
                }
            }
        }

        // Добавление ребра между вершинами u и v с весом weight
        public void AddEdge(int u, int v, int weight)
        {
            dist[u, v] = weight;
        }

        // Вычисление кратчайших расстояний между всеми парами вершин
        public void FloydWarshall()
        {
            // Обновляем матрицу расстояний, проходя по всем вершинам
            for (int k = 0; k < V; k++)
            {
                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < V; j++)
                    {
                        // Если путь из вершины i в вершину j через вершину k
                        // является более коротким, чем текущий путь из i в j,
                        // то обновляем значение в матрице расстояний
                        if (dist[i, k] != int.MaxValue && dist[k, j] != int.MaxValue && dist[i, k] + dist[k, j] < dist[i, j])
                        {
                            dist[i, j] = dist[i, k] + dist[k, j];
                        }
                    }
                }
            }
        }

        // Вывод матрицы кратчайших расстояний
        public void PrintShortestDistances()
        {
            Console.WriteLine("Матрица кратчайших расстояний:");
            for (int i = 0; i < V; i++)
            {
                for (int j = 0; j < V; j++)
                {
                    if (dist[i, j] == int.MaxValue)
                    {
                        Console.Write("Кротчайший ");
                    }
                    else
                    {
                        Console.Write(dist[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
