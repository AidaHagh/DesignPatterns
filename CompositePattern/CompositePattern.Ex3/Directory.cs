using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.Ex3
{
    //composite
    public class Directory : IData
    {
        private readonly string directoryName;
        private readonly IList<IData> dataList;

        public Directory(string directoryName, int level)
        {

            string tab = "";
            for (int i = 1; i <= level; i++)
            {
                tab += "\t";
            }
            this.directoryName = tab + directoryName;
            this.dataList = new List<IData>();
        }

        public void AddData(IData data)
        {
            dataList.Add(data);
        }

        public void RemoveData(IData data)
        {
            dataList.Remove(data);
        }

        public IData GetData(int index)
        {
            if (index < 0 || index > dataList.Count)
            {
                throw new Exception("invalid index" + index);
            }
            return dataList[index];
        }
        public void Print()
        {
            Console.WriteLine(directoryName);
            foreach (IData data in dataList)
            {
                data.Print();
            }
        }
    }
}