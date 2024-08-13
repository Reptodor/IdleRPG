using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private CharacterProperties _characterProperties;

    private PlayerHealth _playerHealth;
    private PlayerCombatSystem _playerCombatSystem;

    private void Awake()
    {
        _playerHealth = GetComponent<PlayerHealth>();
        _playerHealth.Initialize(_characterProperties.Health(), _characterProperties.Armor());

        _playerCombatSystem = GetComponent<PlayerCombatSystem>();
        _playerCombatSystem.Initialize(_characterProperties.Damage());
    }

    public void TakeDamage(float damage)
    {
        _playerHealth.TakeDamage(damage);
    }

    public void GetEnemy(Enemy enemy)
    {
        _playerCombatSystem.GetEnemy(enemy);
    }
}
