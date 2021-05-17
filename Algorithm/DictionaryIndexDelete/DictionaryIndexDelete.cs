using Algorithm.Utils;

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.DictionaryIndexDeleted
{
    /*给定一个以字符串表示的非负整数 num，移除这个数中的 k 位数字，使得剩下的数字最小。
    1.num 的长度 ≥ k。
    2.num 不会包含任何前导零。

    3.示例:

    4.输入: num = "1432219", k = 3
    5.输出: "1219"
    6.解释: 移除掉三个数字 4, 3, 和 2 形成一个新的最小的数字 1219。*/
    public class DictionaryIndexDelete
    {
        //初始随机数
        private uint randomNum;  //长度小于10002 且 >= k

        //输入的值 表示需要去除的位数
        private uint key;

        public void InitRandomNum()
        {
            System.Random random = new Random();

            randomNum = (uint)random.Next(100, 999999999);
        }

        public void GetInputKey(uint inputValue)
        {
            key = inputValue;
        }


        //执行算法
        public uint ExecuteAlgorithm()
        {
            System.Console.WriteLine("初始化到的数字为{0}", randomNum);
            //获取数字的长度
            var splitStack = Utility.SplitNums(randomNum);
            uint numLength = (uint)splitStack.Count;

            if (numLength <= key)
            {
                System.Console.WriteLine("当前输入的删除位数，大于整个数字的最大长度");
                return 0;
            }

            ExecuteMethod(splitStack, numLength);

            uint result = 0;
            uint remainLength = numLength - key;
            if (splitStack.Count >= remainLength)
            {
                uint abandonCount = (uint)splitStack.Count - remainLength;
                while (splitStack.Count > abandonCount)
                {
                    result *= 10;
                    result += splitStack.Pop();
                }
            }

            return result;
        }

        /// <summary>
        /// 执行方法
        /// </summary>
        private void ExecuteMethod(Stack<byte> tempStack, uint numLength)
        {
            int count = tempStack.Count;
            while (tempStack.Count > numLength - key && count > 0)
            {
                byte a = tempStack.Pop();
                byte b = tempStack.Pop();
                if (a < b)
                {
                    tempStack.Push(a);
                }
                else
                {
                    tempStack.Push(b);
                }
                count--;
            }
        }

    }
}
