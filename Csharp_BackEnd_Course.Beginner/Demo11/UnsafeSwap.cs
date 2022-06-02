namespace Day06
{
    public  class UnsafeSwap
    {
         
        public unsafe void SwapNumbers(int*  num1, int* num2)
        {
            int tempNum = *num1;
            *num1 = *num2;
            *num2 = tempNum;
        }
    }
}