using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private int _health;

    private PlayerHealth _playerHealth;
    private PlayerCombatSystem _playerCombatSystem;

    private void Awake()
    {
        _playerHealth = GetComponent<PlayerHealth>();
        _playerHealth.Initialize(_health);

        _playerCombatSystem = GetComponent<PlayerCombatSystem>();
        _playerCombatSystem.Initialize(_damage);
    }
}
