using System;
using System.Collections;
using UnityEngine;

public abstract class Health : MonoBehaviour
{
    [SerializeField] protected float DeathTime = 2f;

    private float _maxHealth;
    private float _currentHealth;
    private float _armor;

    protected Animations Animations;

    public event Action<float> HealthChange;

    public bool Died;

    private void Awake()
    {
        Animations = GetComponentInChildren<Animations>();
    }

    public virtual void Initialize(int health, int armor)
    {
        _maxHealth = health;
        _currentHealth = _maxHealth;
        _armor = armor;
        Died = false;
    }

    public virtual void TakeDamage(float damage)
    {
        if (damage < 0)
            throw new ArgumentOutOfRangeException(nameof(damage));

        _currentHealth -= (damage - damage * _armor / 100);
        float healthPercentage = _currentHealth / _maxHealth;
        HealthChange.Invoke(healthPercentage);

        if (_currentHealth <= 0)
        {
            StartCoroutine(Die());
            Died = true;
        }
    }

    public abstract IEnumerator Die();
}
