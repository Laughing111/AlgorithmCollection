using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.ByteCalcutation
{
    public class ByteCalculation
    {
        #region 统计两个二进制数 有多少位不同

        /// <summary>
        /// 统计两个二进制数中 有多少位不同
        /// </summary>
        public void FindTheCountOfTwoNum()
        {
            string strA = Console.ReadLine();
            int numA = int.Parse(strA);
            string strB = Console.ReadLine();
            int numB = int.Parse(strB);

            //先将两个数进行异或处理，1值位为不同，0值位为相同
            int temp = numA ^ numB;
            int result = 0;
            //此时只要统计有多少个1值位即可
            while(temp!= 0) //只要左移1位仍旧不等于0 则说明原值位数还没左移完
            { 
                if((temp & 1 )> 0 )  //和1与 如果为1 则说明第一位为1
                {
                    result++;
                }
                temp = temp >> 1; //将temp 左移一位
            }

            Console.WriteLine("{0}和{1}的二进制一共有{2}位不同", numA, numB, result);
        }
        #endregion
    }
}
