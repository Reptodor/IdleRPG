public class Bow : Weapon
{
    public override void Attack(Enemy enemy, float damage)
    {
        PlayerAnimations.AnimateBowAttack();
        base.Attack(enemy, damage);
    }
}
