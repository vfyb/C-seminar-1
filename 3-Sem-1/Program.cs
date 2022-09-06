// See https://aka.ms/new-console-template for more information

int[] nums = new int[10] {10, 20, 45, 23, 76, 45, 3, 56, 78, 90};

// int i = 0;
int max = nums[0];

for ( int i = 0; i < nums.Length; i++ )
    {
        if ( nums[i] > max )
            {
                max = nums[i];
            }
    }

// while ( i < nums.Length )
//     {
//         if ( nums[i] > max )
//             {
//                 max = nums[i];
//                 i++;
//             }
//         else i++;
//     }

Console.WriteLine(max);