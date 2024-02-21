namespace HomeworksStudent.Lock
{
    public class Brutforce
    {
        public static void GetPassword(CombinationLock combinationLock, int startIndex, int maxIndex)
        {
            List<int> endPasswords = new List<int>();
            List<bool> bools = new List<bool>();
            int index = startIndex;
            int goodIndex = 0;

            while (index < maxIndex)
            {
                if (bools.Count > goodIndex && bools[goodIndex])
                {
                    combinationLock.TryOpenLock(endPasswords[goodIndex]);
                    goodIndex++;
                }
                else
                {
                    if (combinationLock.TryOpenLock(index))
                    {
                        endPasswords.Add(index);
                        bools.Add(true);
                        index = startIndex;

                        if (combinationLock.IsOpen)
                        {
                            break;
                        }
                    }
                    else
                    {
                        goodIndex = 0;
                        index++;
                    }
                }
            }

            if (!combinationLock.IsOpen)
            {
                Console.WriteLine("Не получилось открыть");
            }
            else
            {
                Console.WriteLine("Password\a");
                foreach (var item in endPasswords)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}