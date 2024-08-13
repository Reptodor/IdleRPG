using System;
using System.Collections;
using UnityEngine;

public class EnemyHealth : Health
{
    public Action Damaged;

    public override void Initialize(int health, int armor)
    {
        base.Initialize(health, armor);
    }

    public override void TakeDamage(float damage)
    {
        Animations.AnimateHit();
        base.TakeDamage(damage);
    }

    public override IEnumerator Die()
    {
        Animations.AnimateDie();
        yield return new WaitForSeconds(DeathTime);
        Destroy(gameObject);
    }
}
