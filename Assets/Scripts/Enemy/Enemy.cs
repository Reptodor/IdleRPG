using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemyAnimations _enemyAnimations;

    private void Awake()
    {
        _enemyAnimations = GetComponent<EnemyAnimations>();
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
