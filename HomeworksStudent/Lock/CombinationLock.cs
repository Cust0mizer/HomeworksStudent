namespace HomeworksStudent.Lock
{
    public class CombinationLock
    {
        public bool IsOpen { get; private set; }
        private int[] _goodCombination;
        private int _currentLockIndex;

        public CombinationLock(int[] goolCombination)
        {
            _goodCombination = goolCombination;
        }

        public bool TryOpenLock(int combinationVariant)
        {
            bool result = false;

            if (IsOpen)
            {
                return result;
            }

            if (_goodCombination[_currentLockIndex] == combinationVariant)
            {
                _currentLockIndex++;

                if (_currentLockIndex == _goodCombination.Length)
                {
                    Console.WriteLine($"Ступень {_currentLockIndex} пройдена");
                    SetLockState(LockState.Open);
                    result = true;
                }
                else
                {
                    result = true;
                    Console.WriteLine($"Ступень {_currentLockIndex} пройдена");
                }
            }
            else
            {
                Console.WriteLine($"Неверная комбинация");
                _currentLockIndex = 0;
            }
            return result;
        }

        private void SetLockState(LockState lockState)
        {
            switch (lockState)
            {
                case LockState.Lock:
                    IsOpen = false;
                    Console.WriteLine("Замок закрыт");
                    break;
                case LockState.Open:
                    IsOpen = true;
                    _currentLockIndex = 0;
                    Console.WriteLine("Замок Открыт");
                    break;
            }
        }
    }

    public enum LockState
    {
        Lock,
        Open
    }

}