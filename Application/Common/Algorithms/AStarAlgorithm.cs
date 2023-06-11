using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application.Common.Algorithms
{

    public class Location
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class LocationNode
    {
        public Location Location { get; set; }
        public List<LocationNode> Neighbors { get; set; }
        public double G { get; set; }
        public double H { get; set; }
        public double F { get { return G + H; } }
        public LocationNode Parent { get; set; }

        public LocationNode(Location location)
        {
            Location = location;
            Neighbors = new List<LocationNode>();
        }

        public void AddNeighbor(LocationNode neighbor)
        {
            Neighbors.Add(neighbor);
        }
    }

    public class AStarAlgorithm
    {
        public List<LocationNode> FindShortestPath(List<Location> locations, Location startLocation, Location goalLocation)
        {
            List<LocationNode> nodes = CreateLocationNodes(locations);
            LocationNode startNode = FindLocationNode(nodes, startLocation);
            LocationNode goalNode = FindLocationNode(nodes, goalLocation);

            // Build graph connections
            BuildGraph(nodes);

            // Run A* algorithm
            List<LocationNode> shortestPath = FindPath(startNode, goalNode);

            return shortestPath;
        }

        private List<LocationNode> CreateLocationNodes(List<Location> locations)
        {
            List<LocationNode> nodes = new List<LocationNode>();

            foreach (Location location in locations)
            {
                LocationNode node = new LocationNode(location);
                nodes.Add(node);
            }

            return nodes;
        }

        private LocationNode FindLocationNode(List<LocationNode> nodes, Location location)
        {
            return nodes.Find(node => node.Location == location);
        }

        private void BuildGraph(List<LocationNode> nodes)
        {
            foreach (LocationNode node in nodes)
            {
                foreach (LocationNode otherNode in nodes)
                {
                    if (node != otherNode)
                    {
                        node.AddNeighbor(otherNode);
                    }
                }
            }
        }

        private List<LocationNode> FindPath(LocationNode startNode, LocationNode goalNode)
        {
            // A* algorithm implementation here
            // ...
            List<LocationNode> openList = new List<LocationNode>();
            List<LocationNode> closedList = new List<LocationNode>();

            openList.Add(startNode);

            while (openList.Count > 0)
            {
                LocationNode currentNode = GetLowestFNode(openList);
                openList.Remove(currentNode);
                closedList.Add(currentNode);

                if (currentNode == goalNode)
                {
                    return GeneratePath(currentNode);
                }

                foreach (LocationNode neighbor in currentNode.Neighbors)
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
                    neighbor.H = CalculateDistance(neighbor, goalNode);
                }
            }

            return null; // No path found
        }

        private LocationNode GetLowestFNode(List<LocationNode> nodes)
        {
            LocationNode lowestFNode = nodes[0];

            for (int i = 1; i < nodes.Count; i++)
            {
                if (nodes[i].F < lowestFNode.F)
                {
                    lowestFNode = nodes[i];
                }
            }

            return lowestFNode;
        }

        private double CalculateDistance(LocationNode node1, LocationNode node2)
        {
            double dx = Math.Abs(node1.Location.Latitude - node2.Location.Latitude);
            double dy = Math.Abs(node1.Location.Longitude - node2.Location.Longitude);

            return Math.Sqrt(dx * dx + dy * dy);
        }

        private List<LocationNode> GeneratePath(LocationNode node)
        {
            List<LocationNode> path = new List<LocationNode>();

            while (node != null)
            {
                path.Insert(0, node);
                node = node.Parent;
            }

            return path;
        }

    }

}
