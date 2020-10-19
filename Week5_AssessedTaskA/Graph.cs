using System;
using System.Collections.Generic;
using System.Text;

namespace Week5_AssessedTaskA
{
    public class Graph<T> where T : IComparable
    {
        private LinkedList<GraphNode<T>> nodes;

        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }

        public bool IsEmptyGraph()
        {
            return nodes.Count == 0;
        }

        public int NumNodesGraph()
        {
            int count = 0;
            foreach (GraphNode<T> n in nodes)
            {
                count++;
            }
            return count;
        }

        // returns the total number of edges present in the graph
        public int NumEdgesGraph()
        {

            // to be completed
            int count = 0;

            foreach (GraphNode<T> n in nodes)
            {
               // n.GetAdjList().Count;

                //if (nodes.ID.IsAdjacent(nodes.))
               // {
                    count += n.GetAdjList().Count;
              //  }
                // to get the total number of edges in the graph: 
                // you need to count how many outgoing edges each node has and then return the sum obtained considering all nodes in the graph

                // how can you get the number of outgoing edges for each node ? (i.e.,     use the adjacency list of the node)
            }
            return count;
        }


        public void AddNode(T id)
        {
            nodes.AddLast(new GraphNode<T>(id));
        }

        public bool ContainsGraph(GraphNode<T> node)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(node.ID) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public GraphNode<T> GetNodeByID(T id)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (id.CompareTo(n.ID) == 0)
                {
                    return n;
                }
            }
            return null;
        }
        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(from.ID) == 0)
                {
                    bool b = from.GetAdjList().Contains(to.ID);
                    if (b == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void AddEdge(T from, T to)
        {
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);

            if (n1 != null && n2 != null)
            {
                n1.AddEdge(n2);
            }
            else
            {
                Console.WriteLine("nodes not found; no edge added");
            }
        }
    }
}
