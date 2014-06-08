////Namespace outside of the using statements so that the guts can simply
////be pasted into Codility's window after testing
//namespace CodingProblems.Implementation.Codility.y2014.LongestPathWithAscendingBeauty
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Text;
//    using System.Threading.Tasks;

//    public class Solution
//    {
//        public int solution(int N, int[] A, int[] B, int[] C)
//        {
//            var nodes = CreateNodes(N);

//            ConstructNetwork(nodes, A, B, C);

//            //remove add roads that can never be traversed (don't know they can't be traversed until the network is made)
//            //add the road to the one node that can be traveled FROM

//            //brute force it for the first try

//        }

//        private void ConstructNetwork(List<Node> nodes, int[] A, int[] B, int[] C)
//        {
//            Action<int, int, int> addNode = (source, destination, aestheticValue) =>
//            {
                
//            };

//            for (int i = 0; i < A.Length; i++)
//            {
//                addNode(A[i], B[i], C[i]);

//                if (A[i] != B[i])
//                {
//                    addNode(B[i], A[i], C[i]);
//                }
//            }


//        }

//        private static List<Node> CreateNodes(int N)
//        {
//            var nodes = new List<Node>();
//            for (int i = 0; i < N; i++)
//            {
//                nodes.Add(new Node(i));
//            }
//            return nodes;
//        }


//    }
//    internal class Node
//    {
//        public List<Road> Roads { get; private set; }
//        public int NodeId { get; private set; }

//        public Node(int nodeId)
//        {
//            NodeId = nodeId;
//            Roads = new List<Road>();
//        }
//    }

//    internal class Road
//    {
//        public int AestheticQuality { get; set; }
//        public Node Destination { get; set; }
//    }
//}
