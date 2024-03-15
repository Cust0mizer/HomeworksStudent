namespace HomeworksStudent.ConsoleGame
{
    public class Character(PlayerStats playerStats)
    {
        private CharacterHealthComponent _healthComponent = new(playerStats.Health);
        public Inventory Inventory { get; } = new Inventory();

        public void TakeItem(IIetem item)
        {
            Inventory.AddItem(item);
        }

        public void Hill()
        {
            IHealing healing = null;

            if (Inventory.ContainsItem(ref healing))
            {
                _healthComponent.Regenerate(healing.HealthValue);
                Inventory.RemoveItem(healing);
            }
        }

        public void Shoot(IDamageble damageble)
        {
            IGun gun = null;

            if (Inventory.ContainsItem(ref gun))
            {
                gun.Fire(damageble);
            }
        }

        public void TakeDamage(int damage)
        {
            Armor armor = null;

            if (Inventory.ContainsItem(ref armor))
            {
                if (armor.HealthComponent.Health >= damage)
                {
                    if (armor.HealthComponent.TryDie(damage))
                    {
                        Inventory.RemoveItem(armor);
                        InputHelper.PrintWarning("Вы лишились брони!");
                    }
                    damage /= 2;
                }
            }
            if (_healthComponent.TryDie(damage))
            {

            }
        }
    }
}
