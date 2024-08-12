using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemyAnimations _enemyAnimations;
    private Player _player;

    public void Initialize(Player player)
    {
        _enemyAnimations = GetComponent<EnemyAnimations>();
        _player = player;
    }

    public void Attack()
    {
        _enemyAnimations.AnimateAttack();
    }

    public void TakeHit()
    {
        _enemyAnimations.AnimateHit();
    }

    public void Die()
    {
        _enemyAnimations.AnimateDie();
    }
}
