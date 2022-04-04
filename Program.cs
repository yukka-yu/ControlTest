﻿void PrintArray(string[] Arr)
{
              Console.Write("[");
              for (int i = 0; i < Arr.Length; i ++)
              {
                            Console.Write(Arr[i]+" ");
              }
              Console.Write("]");
              Console.WriteLine(String.Empty);
}

string[] A = {"123", "Lev", "56ggg*", "-2"};
int count = 0;
for (int i = 0; i < A.Length; i ++)
{
              if (A[i].Length <= 3) count ++;
}

string[] B = new string[count];
int j = 0;

for (int i = 0; i < A.Length; i ++)
{
              if (A[i].Length <= 3) 
              {
                            B[j] = A[i];
                            j ++;
              }
}

PrintArray(B);
