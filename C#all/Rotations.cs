using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all
{
    public class Rotations
    {
        //Rotate the values inside array to left side by 1 place. 
        public int[] leftRotation(int[] arr)
        {
            if(arr.Length ==0 || arr.Length ==1){
                return arr;
            }
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i]= arr[i + 1] + arr[i];
                arr[i+1]= arr[i] - arr[i+1];
                arr[i] = arr[i] - arr[i+1];
            }
            return arr;
        }
        
        //Rotate the values inside arry to left side by n places 
        public int[] leftRotation(int[] arr,int n)
        {
            if (arr.Length == 0 || arr.Length == 1)
            {
                return arr;
            }
            while (n > 0)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1] + arr[i];
                    arr[i + 1] = arr[i] - arr[i + 1];
                    arr[i] = arr[i] - arr[i + 1];
                }
                n--;
            }
            return arr;
        }

        //Rotate the values inside array to right side by 1 place
        public int[] rightRotation(int[] arr)
        {
            int len = arr.Length;
            if (len == 0 || len == 1)
            {
                return arr;
            }
            for(int i = len-1; i >0; i--)
            {
                arr[i] = arr[i - 1] + arr[i];
                arr[i - 1] = arr[i] - arr[i-1];
                arr[i] = arr[i] - arr[i - 1];
            }
            return arr;
        }

        //Rotate the values inside array to right side by n places
        public int[] rightRotation(int[] arr,int n)
        {
            int len = arr.Length;
            if (len == 0 || len == 1)
            {
                return arr;
            }
            while (n > 0)
            {
                for (int i = len - 1; i > 0; i--)
                {
                    arr[i] = arr[i - 1] + arr[i];
                    arr[i - 1] = arr[i] - arr[i - 1];
                    arr[i] = arr[i] - arr[i - 1];
                }
                n--;
            }
            return arr;
        }


    }
}
