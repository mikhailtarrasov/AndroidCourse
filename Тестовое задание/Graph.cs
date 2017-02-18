using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое_задание
{
    public class Graph
    {
        public Dictionary<int, HashSet<int>> GraphsDict { get; set; }

        public Graph()
        {
            this.GraphsDict = new Dictionary<int, HashSet<int>>();
        }

        public bool AddNode(int key)
        {
            if (!GraphsDict.ContainsKey(key))
            {
                GraphsDict.Add(key, new HashSet<int>());
                return true;                                    // Операция прошла успешно
            }
            return false;                                       // Если такое значение уже содержится
        }

        public int Union(int firstNode, int secondNode)
        {
            if (GraphsDict.ContainsKey(firstNode) && GraphsDict.ContainsKey(secondNode))
            {
                if (!Find(firstNode, secondNode))
                {
                    GraphsDict[firstNode].Add(secondNode);
                    GraphsDict[secondNode].Add(firstNode);
                    return 0;                                   // Если узлы сущестуют и операция прошла успешно
                }
                return 1;                                       // Если узлы сущестуют и они уже связаны
            }
            else return -1;                                     // Если хотя бы одного из улов нет 

        }

        public bool Find(int firstNode, int secondNode)
        {
            if (GraphsDict.ContainsKey(firstNode) && GraphsDict[firstNode].Contains(secondNode))
                return true;
            return false;                                       // Если не объединены 
        }
    }
}
