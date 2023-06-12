using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Algorithms.AStarAlgorithmWithListVisit2
{



    public class Location
    {
        public string Name { get; }
        public double Latitude { get; }
        public double Longitude { get; }

        public Location(string name, double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }
    }

    public class AStarAlgorithm
    {
        private Dictionary<Location, Dictionary<Location, double>> distances;

        public List<LocationWithRelations> FindShortestPaths(List<Location> locations)
        {
            distances = CalculateDistances(locations);
            List<LocationWithRelations> shortestPaths = new List<LocationWithRelations>();

            foreach (Location source in locations)
            {
                Dictionary<Location, double> shortestDistances = new Dictionary<Location, double>();
                Dictionary<Location, Location> predecessors = new Dictionary<Location, Location>();

                foreach (Location location in locations)
                {
                    shortestDistances[location] = double.MaxValue;
                }

                shortestDistances[source] = 0;
                PriorityQueue<PathNode> openSet = new PriorityQueue<PathNode>();
                openSet.Enqueue(new PathNode(source, null, 0));

                while (openSet.Count > 0)
                {
                    PathNode current = openSet.Dequeue();

                    if (current.Location == null)
                    {
                        continue;
                    }

                    foreach (Location neighbor in distances[current.Location].Keys)
                    {
                        double tentativeDistance = shortestDistances[current.Location] + distances[current.Location][neighbor];

                        if (tentativeDistance < shortestDistances[neighbor])
                        {
                            shortestDistances[neighbor] = tentativeDistance;
                            predecessors[neighbor] = current.Location;
                            openSet.Enqueue(new PathNode(neighbor, current.Location, tentativeDistance));
                        }
                    }
                }

                shortestPaths.Add(new LocationWithRelations(source, shortestDistances, predecessors));
            }

            return shortestPaths;
        }

        private Dictionary<Location, Dictionary<Location, double>> CalculateDistances(List<Location> locations)
        {
            Dictionary<Location, Dictionary<Location, double>> distances = new Dictionary<Location, Dictionary<Location, double>>();

            foreach (Location location in locations)
            {
                distances[location] = new Dictionary<Location, double>();
            }

            for (int i = 0; i < locations.Count; i++)
            {
                for (int j = 0; j < locations.Count; j++)
                {
                    if (i != j)
                    {
                        double distance = CalculateDistance(locations[i], locations[j]);
                        distances[locations[i]][locations[j]] = distance;
                    }
                }
            }

            return distances;
        }

        private double CalculateDistance(Location location1, Location location2)
        {
            double latDiff = location1.Latitude - location2.Latitude;
            double lonDiff = location1.Longitude - location2.Longitude;
            return Math.Sqrt(latDiff * latDiff + lonDiff * lonDiff);
        }
    }

    public class PathNode : IComparable<PathNode>
    {
        public Location Location { get; }
        public Location Predecessor { get; }
        public double Cost { get; }

        public PathNode(Location location, Location predecessor, double cost)
        {
            Location = location;
            Predecessor = predecessor;
            Cost = cost;
        }

        public int CompareTo(PathNode other)
        {
            return Cost.CompareTo(other.Cost);
        }
    }

    public class LocationWithRelations : Location
    {
        public Dictionary<Location, double> ShortestDistances { get; }
        public Dictionary<Location, Location> Predecessors { get; }

        public LocationWithRelations(Location location, Dictionary<Location, double> shortestDistances, Dictionary<Location, Location> predecessors)
            : base(location.Name, location.Latitude, location.Longitude)
        {
            ShortestDistances = shortestDistances;
            Predecessors = predecessors;
        }
    }

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> heap;

        public int Count => heap.Count;

        public PriorityQueue()
        {
            heap = new List<T>();
        }

        public void Enqueue(T item)
        {
            heap.Add(item);
            int currentIndex = heap.Count - 1;

            while (currentIndex > 0)
            {
                int parentIndex = (currentIndex - 1) / 2;

                if (heap[currentIndex].CompareTo(heap[parentIndex]) >= 0)
                    break;

                Swap(currentIndex, parentIndex);
                currentIndex = parentIndex;
            }
        }

        public T Dequeue()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Priority queue is empty.");

            T firstItem = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            HeapifyDown();

            return firstItem;
        }

        private void HeapifyDown()
        {
            int currentIndex = 0;

            while (true)
            {
                int leftChildIndex = currentIndex * 2 + 1;
                int rightChildIndex = currentIndex * 2 + 2;

                if (leftChildIndex >= heap.Count)
                    break;

                int smallerChildIndex = leftChildIndex;

                if (rightChildIndex < heap.Count && heap[rightChildIndex].CompareTo(heap[leftChildIndex]) < 0)
                    smallerChildIndex = rightChildIndex;

                if (heap[currentIndex].CompareTo(heap[smallerChildIndex]) <= 0)
                    break;

                Swap(currentIndex, smallerChildIndex);
                currentIndex = smallerChildIndex;
            }
        }

        private void Swap(int index1, int index2)
        {
            T temp = heap[index1];
            heap[index1] = heap[index2];
            heap[index2] = temp;
        }
    }


}
