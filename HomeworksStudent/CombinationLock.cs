public class CombinationLock {
    public bool IsOpen { get; private set; }

    private int[] _goodCombination;
    private int _currentLockIndex;

    public CombinationLock(int[] goolCombination) {
        _goodCombination = goolCombination;
    }

    public bool TryOpenLock(int combinationVariant) {
        bool result = false;

        if (IsOpen) {
            return result;
        }

        if (_goodCombination[_currentLockIndex] == combinationVariant) {
            _currentLockIndex++;
            if (_currentLockIndex == _goodCombination.Length) {
                Console.WriteLine($"Ступень {_currentLockIndex} пройдена");
                SetLockState(LockState.Open);
                result = true;
            }
            else {
                result = true;
                Console.WriteLine($"Ступень {_currentLockIndex} пройдена");
            }
        }
        else {
            Console.WriteLine($"Неверная комбинация");
            _currentLockIndex = 0;
        }
        return result;
    }

    public void SetNewCombination() {
        while (!IsOpen) {
            Console.WriteLine("Введите число");
            int.TryParse(Console.ReadLine(), out int value);
            TryOpenLock(value);
        }

        for (int i = 0; i < _goodCombination.Length; i++) {
            Console.WriteLine($"Введите число для ступени {i + 1}");
            int.TryParse(Console.ReadLine(), out int value);
            _goodCombination[i] = value;
        }
        SetLockState(LockState.Lock);
    }

    private void SetLockState(LockState lockState) {
        switch (lockState) {
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
