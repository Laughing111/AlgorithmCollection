using Algorithm.ByteCalcutation;
using Algorithm.DictionaryIndexDeleted;

using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //ByteCalculation byteCalcProgram = new ByteCalculation();
            //byteCalcProgram.FindTheCountOfTwoNum();

            DictionaryIndexDelete dictionaryIndexDelete = new DictionaryIndexDelete();
            dictionaryIndexDelete.InitRandomNum();
            dictionaryIndexDelete.GetInputKey(4);
            System.Console.WriteLine("输出为：{0}",
            dictionaryIndexDelete.ExecuteAlgorithm());
        }
    }
}
