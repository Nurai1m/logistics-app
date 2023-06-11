using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Algorithms.WithoutGoal
{


    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Node
    {
        public Location Location { get; set; }
        public List<Node> Neighbors { get; set; }
        public double G { get; set; }
        public double H { get; set; }
        public double F { get { return G + H; } }
        public Node Parent { get; set; }

        public Node(Location location)
        {
            Location = location;
            Neighbors = new List<Node>();
        }

        public void AddNeighbor(Node neighbor)
        {
            Neighbors.Add(neighbor);
        }
    }

    public class AStarAlgorithm
    {
        public List<Location> FindShortestPath(Location startLocation, List<Location> goalLocations)
        {
            Node startNode = new Node(startLocation);

            // Build the graph connections
            BuildGraph(startNode);

            // Run A* algorithm for each goal location
            List<Node> shortestPath = null;
            double shortestDistance = double.PositiveInfinity;

            foreach (Location goalLocation in goalLocations)
            {
                List<Node> path = FindPath(startNode, goalLocation);

                if (path != null && path.Count > 0)
                {
                    double distance = CalculatePathDistance(path);
                    if (distance < shortestDistance)
                    {
                        shortestPath = path;
                        shortestDistance = distance;
                    }
                }
            }

            // Convert the result to a list of locations
            List<Location> resultPath = new List<Location>();
            if (shortestPath != null)
            {
                foreach (Node node in shortestPath)
                {
                    resultPath.Add(node.Location);
                }
            }

            return resultPath;
        }

        private void BuildGraph(Node startNode)
        {
            // Define your graph connections here
            // Add neighbors to nodes
            // Example:
            startNode.AddNeighbor(new Node(new Location(1, 0)));
            startNode.AddNeighbor(new Node(new Location(0, 1)));
        }

        private List<Node> FindPath(Node startNode, Location goalLocation)
        {
            List<Node> openList = new List<Node>();
            List<Node> closedList = new List<Node>();

            openList.Add(startNode);

            while (openList.Count > 0)
            {
                Node currentNode = GetLowestFNode(openList);
                openList.Remove(currentNode);
                closedList.Add(currentNode);

                // Check if the current node is the goal node
                if (currentNode.Location.Equals(goalLocation))
                {
                    return GeneratePath(currentNode);
                }

                foreach (Node neighbor in currentNode.Neighbors)
                {
                    if (closedList.Contains(neighbor))
                        continue;

                    double gScore = currentNode.G + CalculateDistance(currentNode, neighbor);

                    if (!openList.Contains(neighbor))
                    {
                        openList.Add(neighbor);
                    }
                    else if (gScore >= neighbor.G)
                    {
                        continue;
                    }

                    neighbor.Parent = currentNode;
                    neighbor.G = gScore;
                    neighbor.H = CalculateHeuristic(neighbor, goalLocation);
                }
            }

            return null; // No path found
        }

        private Node GetLowestFNode(List<Node> nodes)
        {
            Node lowestFNode = nodes[0];

            for (int i = 1; i < nodes.Count; i++)
            {
                if (nodes[i].F < lowestFNode.F)
                {
                    lowestFNode = nodes[i];
                }
            }

            return lowestFNode;
        }

        private double CalculateDistance(Node node1, Node node2)
        {
            // Calculate the distance between two nodes
            // Example: Euclidean distance
            double dx = node2.Location.X - node1.Location.X;
            double dy = node2.Location.Y - node1.Location.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        private double CalculateHeuristic(Node node, Location goalLocation)
        {
            // Calculate the heuristic value for a node
            // Example: Manhattan distance
            int dx = Math.Abs(node.Location.X - goalLocation.X);
            int dy = Math.Abs(node.Location.Y - goalLocation.Y);

            return dx + dy;
        }

        private List<Node> GeneratePath(Node node)
        {
            List<Node> path = new List<Node>();

            while (node != null)
            {
                path.Insert(0, node);
                node = node.Parent;
            }

            return path;
        }

        private double CalculatePathDistance(List<Node> path)
        {
            double distance = 0;

            for (int i = 0; i < path.Count - 1; i++)
            {
                distance += CalculateDistance(path[i], path[i + 1]);
            }

            return distance;
        }
    }


}
