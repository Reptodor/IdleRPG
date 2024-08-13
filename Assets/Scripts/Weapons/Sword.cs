public class Sword : Weapon
{
    public override void Attack(Enemy enemy, float damage)
    {
        PlayerAnimations.AnimateSwordAttack();
        base.Attack(enemy, damage);
    }
}
