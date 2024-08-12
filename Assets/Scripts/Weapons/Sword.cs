public class Sword : Weapon
{
    public override void Attack(Enemy enemy, int damage)
    {
        PlayerAnimations.Instance.AnimateSwordAttack();
        base.Attack(enemy, damage);
    }
}
