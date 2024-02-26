public class Character : IDamageble {
    private float _currentHealth;
    private float _maxHealth;

    private const float MIN_HEALTH = 0;

    public string Name => typeof(Character).Name;

    public Character() {

    }

    public void TakeDamage(float damageValue) {
        if (damageValue < 0) {
            Console.WriteLine("Урон не может быть отрицательным.");
            return;
        }

        if (_currentHealth - damageValue <= MIN_HEALTH) {
            _currentHealth = 0;
            Die();
        }
        else {
            _currentHealth -= damageValue;
        }
        DamageLoger.DamageLog(new DamageAction(_currentHealth, damageValue, Name));
    }

    public void Die() {
        Console.WriteLine("Я умер.");
    }
}

public interface IDamageble {
    public string Name { get; }
    public void TakeDamage(float damageValue);
}

public static class DamageLoger {
    public static void DamageLog(DamageAction damageAction) {
        float resultHealth = damageAction.StartHealth - damageAction.DamageValue;
        Console.WriteLine($"{damageAction.Name} получил {damageAction.DamageValue} урона, осталось {resultHealth} жизни");
    }
}

public struct DamageAction {
    public float StartHealth { get; private set; }
    public float DamageValue { get; private set; }
    public string Name { get; private set; }

    public DamageAction(float startHealth, float damageValue, string name) {
        StartHealth = startHealth;
        DamageValue = damageValue;
        Name = name;
    }
}

//coment