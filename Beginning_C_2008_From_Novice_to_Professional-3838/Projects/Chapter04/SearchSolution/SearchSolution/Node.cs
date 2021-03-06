using System;
using System.Collections.Generic;
using System.Text;

namespace SearchSolution {
    public struct Something {
        Something[] next;
    }
    public class Node {
        public static Node[] RootNodes;
        public string CityName;
        public double X;
        public double Y;
        public Node[] Connections;
        public Node(string city, double x, double y) {
            CityName = city;
            X = x;
            Y = y;
            Connections = null;
        }

        public static int GetMaxPossibleDestinationsArraySize() {
            return 10;
        }

        static Node() {
            Node montreal = new Node("Montreal", 0, 0);
            Node newyork = new Node("New York", 0, -3);
            Node miami = new Node("Miami", -1, -11);
            Node toronto = new Node("Toronto", -4, -1);
            Node houston = new Node("Houston", -10, -9);
            Node losangeles = new Node("Los Angeles", -17, -6);
            Node seattle = new Node("Seattle", -16, -1);

            montreal.Connections = new Node[3];
            montreal.Connections[0] = newyork;
            montreal.Connections[1] = toronto;
            montreal.Connections[2] = losangeles;

            newyork.Connections = new Node[3];
            newyork.Connections[0] = montreal;
            newyork.Connections[1] = houston;
            newyork.Connections[2] = miami;

            miami.Connections = new Node[3];
            miami.Connections[0] = toronto;
            miami.Connections[1] = houston;
            miami.Connections[2] = newyork;

            toronto.Connections = new Node[3];
            toronto.Connections[0] = miami;
            toronto.Connections[1] = seattle;
            toronto.Connections[2] = montreal;

            houston.Connections = new Node[3];
            houston.Connections[0] = miami;
            houston.Connections[1] = seattle;
            houston.Connections[2] = newyork;

            seattle.Connections = new Node[3];
            seattle.Connections[0] = toronto;
            seattle.Connections[1] = houston;
            seattle.Connections[2] = losangeles;

            losangeles.Connections = new Node[3];
            losangeles.Connections[0] = montreal;
            losangeles.Connections[1] = seattle;
            losangeles.Connections[2] = houston;

            Node.RootNodes = new Node[7];
            Node.RootNodes[0] = montreal;
            Node.RootNodes[1] = newyork;
            Node.RootNodes[2] = miami;
            Node.RootNodes[3] = toronto;
            Node.RootNodes[4] = houston;
            Node.RootNodes[5] = losangeles;
            Node.RootNodes[6] = seattle;

        }
    }
}
