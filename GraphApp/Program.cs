// See https://aka.ms/new-console-template for more information

using GraphLib;

DirectedGraph graph = new DirectedGraph();

var a = graph.AddVertex("A");
var b = graph.AddVertex("B");
var c = graph.AddVertex("C");
var d = graph.AddVertex("D");
var e = graph.AddVertex("E");
var f = graph.AddVertex("F");
var g = graph.AddVertex("G");

a.AddEdge(b, 7);
b.AddEdge(d, 7);
a.AddEdge(c, 3);
b.AddEdge(c, 1);
c.AddEdge(e, 32);
c.AddEdge(f, 3);
d.AddEdge(e, 2);
d.AddEdge(g, 1);
e.AddEdge(f, 9);
g.AddEdge(f, 7);

Console.WriteLine("Index\tLabel");
for (int i = 0; i < graph.Vertices.Count; i++)
{
    Console.WriteLine($"{i}\t{graph.Vertices[i].Label}");
}

graph.PrintMatrix();

Console.WriteLine();

graph.Dijkstra(0);
