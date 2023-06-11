using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Algorithms.AStarAlgorithmWithListVisit
{

    public class Location
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Location(string name, double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }
    }

    public class Node
    {
        public Location Location { get; set; }
        public List<Node> Neighbors { get; set; }
        public double CostFromStart { get; set; }
        public double HeuristicDistance { get; set; }
        public double TotalCost => CostFromStart + HeuristicDistance;
        public Node PreviousNode { get; set; }

        public Node(Location location)
        {
            Location = location;
            Neighbors = new List<Node>();
            CostFromStart = double.MaxValue;
            HeuristicDistance = 0;
            PreviousNode = null;
        }

        public void AddNeighbor(Node neighbor)
        {
            Neighbors.Add(neighbor);
        }
    }

    public class AStarAlgorithm
    {
        public List<Location> FindShortestPath(List<Location> locations)
        {
            List<Node> nodes = CreateNodes(locations);
            BuildGraph(nodes);

            Node startNode = nodes[0];
            Node goalNode = nodes[nodes.Count - 1];

            startNode.CostFromStart = 0;

            List<Node> openNodes = new List<Node> { startNode };
            List<Node> closedNodes = new List<Node>();

            while (openNodes.Count > 0)
            {
                Node currentNode = GetLowestCostNode(openNodes);
                openNodes.Remove(currentNode);
                closedNodes.Add(currentNode);

                if (currentNode == goalNode)
                {
                    return ReconstructPath(currentNode);
                }

                foreach (Node neighborNode in currentNode.Neighbors)
                {
                    if (closedNodes.Contains(neighborNode))
                    {
                        continue;
                    }

                    double costFromStart = currentNode.CostFromStart + CalculateDistance(currentNode, neighborNode);

                    if (costFromStart < neighborNode.CostFromStart)
                    {
                        neighborNode.CostFromStart = costFromStart;
                        neighborNode.PreviousNode = currentNode;

                        if (!openNodes.Contains(neighborNode))
                        {
                            openNodes.Add(neighborNode);
                        }
                    }
                }
            }

            return null; // No path found
        }

        private List<Node> CreateNodes(List<Location> locations)
        {
            List<Node> nodes = new List<Node>();

            foreach (Location location in locations)
            {
                Node node = new Node(location);
                nodes.Add(node);
            }

            return nodes;
        }

        private void BuildGraph(List<Node> nodes)
        {
            for (int i = 0; i < nodes.Count - 1; i++)
            {
                Node currentNode = nodes[i];
                Node nextNode = nodes[i + 1];

                currentNode.AddNeighbor(nextNode);
            }
        }

        private double CalculateDistance(Node node1, Node node2)
        {
            double latitudeDifference = Math.Abs(node1.Location.Latitude - node2.Location.Latitude);
            double longitudeDifference = Math.Abs(node1.Location.Longitude - node2.Location.Longitude);

            // Assuming a simple Euclidean distance calculation
            return Math.Sqrt(latitudeDifference * latitudeDifference + longitudeDifference * longitudeDifference);
        }

        private Node GetLowestCostNode(List<Node> nodes)
        {
            Node lowestCostNode = nodes[0];

            for (int i = 1; i < nodes.Count; i++)
            {
                if (nodes[i].TotalCost < lowestCostNode.TotalCost)
                {
                    lowestCostNode = nodes[i];
                }
            }

            return lowestCostNode;
        }

        private List<Location> ReconstructPath(Node goalNode)
        {
            List<Location> path = new List<Location>();

            Node currentNode = goalNode;

            while (currentNode != null)
            {
                path.Insert(0, currentNode.Location);
                currentNode = currentNode.PreviousNode;
            }

            return path;
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Define the list of locations
            List<Location> locations = new List<Location>
        {
            new Location("Location A", 1.0, 2.0),
            new Location("Location B", 3.0, 4.0),
            new Location("Location C", 5.0, 6.0),
            new Location("Location D", 7.0, 8.0),
            new Location("Location E", 9.0, 10.0)
        };

            // Create an instance of the A* algorithm
            AStarAlgorithm astar = new AStarAlgorithm();

            // Find the shortest path
            List<Location> shortestPath = astar.FindShortestPath(locations);

            // Print the shortest path
            if (shortestPath != null)
            {
                Console.WriteLine("Shortest Path:");
                foreach (Location location in shortestPath)
                {
                    Console.WriteLine(location.Name);
                }
            }
            else
            {
                Console.WriteLine("No path found.");
            }
        }
    }

}
