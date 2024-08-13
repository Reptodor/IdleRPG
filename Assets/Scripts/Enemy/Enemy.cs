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

    public void TakeDamage(float damage)
    {
        _enemyHealth.TakeDamage(damage);
        if(!_enemyHealth.Died)
            Invoke(nameof(Attack), 1f);
    }

    private void Attack()
    {
        if (_player != null)
        {
            _enemyAnimations.AnimateAttack();
            _player.TakeDamage(_characterProperties.Damage());
        }
    }
}
