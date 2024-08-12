using System;
using System.Collections;
using UnityEngine;

public class PlayerHealth  :  MonoBehaviour
{
    [SerializeField] private GameObject _deathMenu;
    [SerializeField] private float _deathTime = 2f;

    private int _currentHealth;

    public void Initialize(int health)
    {
        _currentHealth = health;
    }

    public void TakeDamage(int damage)
    {
        if(damage < 0)
            throw new ArgumentOutOfRangeException(nameof(damage));

        _currentHealth -= damage;
        PlayerAnimations.Instance.AnimateHit();
        Debug.Log(_currentHealth);

        if (_currentHealth <= 0)
            StartCoroutine(Die());
    }

    private IEnumerator Die()
    {
        PlayerAnimations.Instance.AnimateDie();
        yield return new WaitForSeconds(_deathTime);
        _deathMenu.SetActive(true);
    }
}
