using System;

namespace Week5_AssessedTaskA
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<char> myGraph = new Graph<char>();

            myGraph.AddNode('A');
            myGraph.AddNode('B');
            myGraph.AddNode('C');
            myGraph.AddNode('D');
            myGraph.AddNode('E');

            myGraph.AddEdge('A', 'B');
            myGraph.AddEdge('A', 'C');
            myGraph.AddEdge('B', 'C');
            myGraph.AddEdge('D', 'A');
            myGraph.AddEdge('D', 'E');


            Console.WriteLine("is node {0} adjacent to node {1} ? Answer : {2}", myGraph.GetNodeByID('B').ID, myGraph.GetNodeByID('C').ID, myGraph.IsAdjacent(myGraph.GetNodeByID('C'),
                myGraph.GetNodeByID('B')));
            Console.WriteLine("amount of nodes : " + myGraph.NumNodesGraph());
            Console.WriteLine("amount of edges : " + myGraph.NumEdgesGraph());

            Console.ReadKey();
        }
    }
}
