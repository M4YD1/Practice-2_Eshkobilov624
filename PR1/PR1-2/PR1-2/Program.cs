using System;

class HelloWorld {
    static void Main()
    {
        int[] candidates = new int[] {10,1,2,7,6,1,5};
        Console.WriteLine("Введите цель target: ");
        int target = int.Parse(Console.ReadLine());

        Array.Sort(candidates);

        for (int i = 0; i < candidates.Length; i++)
        {
            if (candidates[i] == target)
            {
                Console.WriteLine("[" + candidates[i] + "]");
            }

            if (i > 0 && candidates[i] == candidates[i - 1])
                continue; 

            if (candidates[i] > target)
                break; 

            for (int j = i + 1; j < candidates.Length; j++)
            {
                if (j > i + 1 && candidates[j] == candidates[j - 1])
                    continue; 

                int sum = candidates[i] + candidates[j];

                if (sum == target)
                {
                    Console.WriteLine("[" + candidates[i] + ", " + candidates[j] + "]");
                }
                else if (sum < target)
                {
                    for (int k = j + 1; k < candidates.Length; k++)
                    {
                        if (k > j + 1 && candidates[k] == candidates[k - 1])
                            continue; 

                        sum = candidates[i] + candidates[j] + candidates[k];

                        if (sum == target)
                        {
                            Console.WriteLine("[" + candidates[i] + ", " + candidates[j] + ", " + candidates[k] + "]");
                        }
                        else if (sum > target)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}