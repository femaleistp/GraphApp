// See https://aka.ms/new-console-template for more information

using GraphLib;

DirectedGraph graph = new DirectedGraph();

var a = graph.AddVertex("A");
var b = graph.AddVertex("B");
var c = graph.AddVertex("C");

a.AddEdge(b, 5).AddEdge(c, 2);
b.AddEdge(c, 1);


graph.PrintMatrix();