public class Brutforce {
    public static void GetPassword(CombinationLock combinationLock, int startIndex, int maxIndex) {
        List<int> endPasswords = new List<int>();
        List<bool> bools = new List<bool>();
        int index = startIndex;
        int maxTry = maxIndex;
        int goodIndex = 0;

        while (index < maxTry) {
            if (bools.Count > goodIndex && bools[goodIndex]) {
                combinationLock.TryOpenLock(endPasswords[goodIndex]);
                goodIndex++;
            }
            else {
                if (combinationLock.TryOpenLock(index)) {
                    endPasswords.Add(index);
                    bools.Add(true);
                    index = 0;
                }
                else {
                    goodIndex = 0;
                    index++;
                }
            }

        }

        Console.WriteLine("Password\a");
        foreach (var item in endPasswords) {
            Console.Write(item + " ");
        }
    }
}
