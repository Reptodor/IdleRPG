using System.Collections;
using UnityEngine;

public class PlayerHealth  :  Health
{
    [SerializeField] private DeathMenu _deathMenu;

    public override void Initialize(int health, int armor)
    {
        base.Initialize(health, armor);
    }

    public override void Heal()
    {
        base.Heal();
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
        _deathMenu.gameObject.SetActive(true);
    }
}
