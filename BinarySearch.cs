public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Hello, world!");
            var myArray = new int[] {1,3,5,7,9};
            Console.WriteLine(searchBinary(myArray , 5));
           
        }
        public static int searchBinary (int[] arr , int item)
        {
            int low = 0;
            int high = arr.Length;
            int mid = 0;
            int guess = 0;
            while(low <= high)
                {
                mid = (low + high)/2;
                guess = arr[mid];
                if(guess == item){
                    return mid;
                }
                if(guess > item){
                    high = mid-1;
                }else{
                    low = mid+1;
                }
			
                }
            return 0;
        }
   }
