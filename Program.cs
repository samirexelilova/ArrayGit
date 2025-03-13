
//1

//int[] nums = { 11, 71, 23, 4, 5, 61, 7, 8, 19, 10 };
//int min = nums[0];
//for (int i = 0; i < nums.Length; i++)
//{
//    if (min > nums[i])
//    {
//        min = nums[i];
//    }
//}

//Console.WriteLine(min);


////2

//int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
//int sum = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    sum += nums[i];
//}
//Console.WriteLine(sum);



//3

//int[] nums = { 5, 2, 1, 4, 5, 6, 7, 8, 9, 10 };
//int min = nums[0];
//int max = nums[0];
//int indexMin = nums.Length - 1;
//int indexMax = nums.Length - 1;
//for (int i = 0; i < nums.Length; i++)
//{
//    if (min > nums[i])
//    {
//        min = nums[i];
//        indexMin = i;
//    }

//    else if (max < nums[i])
//    {
//        max = nums[i];
//        indexMax = i;
//    }
//}

//Console.WriteLine(indexMin);
//Console.WriteLine(indexMax);



//4
int[] nums = { 11, 4, 8, 17, 56, 11, 12, 15 };

for (int i = 0; i < nums.Length; i++)
{
    int newNum = nums[i];
    int count = 0;
    if (nums[i] < 2)
    {
        Console.WriteLine("eded ne sadedir ne murekkeb");
    }
    else
    {
        for (int j = 2; j < newNum; j++)
        {
            if (newNum % j == 0)
            {
                count++;
                break;
            }
        }
    }

    if (count > 0)
    {
        Console.WriteLine(newNum);
    }

}