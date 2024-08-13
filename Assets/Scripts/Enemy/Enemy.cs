using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private CharacterProperties _characterProperties;

    private EnemyHealth _enemyHealth;
    private EnemyAnimations _enemyAnimations;
    private Player _player;

    public void Initialize(Player player)
    {
        _enemyHealth = GetComponent<EnemyHealth>();
        _enemyHealth.Initialize(_characterProperties.Health(), _characterProperties.Armor());

        _enemyAnimations = GetComponent<EnemyAnimations>();

        _player = player;
    }

    private void OnEnable()
    {
        Timer.TimeExpired += Attack;
    }

    private void OnDisable()
    {
        Timer.TimeExpired -= Attack;
    }

    public void TakeDamage(float damage)
    {
        _enemyHealth.TakeDamage(damage);
    }

    private void Attack()
    {
        if (_player != null && !_enemyHealth.Died)
        {
            _enemyAnimations.AnimateAttack();
            _player.TakeDamage(_characterProperties.Damage());
        }
    }
}
