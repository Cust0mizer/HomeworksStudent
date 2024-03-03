namespace HomeworksStudent {
    public sealed class Program {
        private static void Main1() {
            int[] ints = new int[20];
            Random random = new Random();

            for (int i = 0; i < ints.Length; i++) {
                ints[i] = i;
            }
            BinarySearch(ints, 19);

            Console.WriteLine(MathF.Log2(128 * 2));
        }

        private static void LinearSearch(int[] ints, int searchElement) {
            for (int i = 0; i < ints.Length; i++) {
                if (ints[i] == searchElement) {
                    Console.WriteLine("Элемент найден!");
                    break;
                }
            }
        }

        private static void BinarySearch(int[] ints, int searchElement) {
            int left = 0;
            int right = ints.Length - 1;

            while (left <= right) {
                int mid = (left + right) / 2;

                if (ints[mid] > searchElement) {
                    right = mid - 1;
                }
                else if (ints[mid] < searchElement) {
                    left = mid + 1;
                }
                else {
                    Console.WriteLine("Элемент найден");
                    break;
                }
            }
        }
    }
}
