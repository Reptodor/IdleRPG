using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private float _damageMultiplier = 1;

    protected PlayerAnimations PlayerAnimations;

    private void Awake()
    {
        PlayerAnimations = GetComponentInParent<PlayerAnimations>();
    }

    public virtual void Attack(Enemy enemy, float damage)
    {
        enemy.TakeDamage(damage * _damageMultiplier);
    }
}
