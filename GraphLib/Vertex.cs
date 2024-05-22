namespace GraphLib
{
    public class Vertex
    {
        public string Label { get; set; }
        public List<Edge> Edges = new List<Edge>();

        public Vertex(string lbl)
        {
            Label = lbl;
        }

        public Vertex AddEdge(Vertex child, int weight)
        {
            Edges.Add(new Edge { 
                Parent = this, 
                Child = child, 
                Weight = weight 
            });

            // do something here

            if(!child.Edges.Exists(e => e.Parent == child && e.Child == this))
            {
                // create here
                child.AddEdge(this, weight);
            }

            return this;

            /*
             *[][W][I]
             *[W] 0 4
             *[I] 4 0
             */
        }
    }
}