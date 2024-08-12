using UnityEngine;

public class PlayerCombatSystem : MonoBehaviour
{
    [SerializeField] private Weapon[] _weapons;

    public Enemy _enemy;

    private int _currentWeaponIndex;
    private int _damage;

    public void Initialize(int damage)
    {
        _damage = damage;
    }

    public void Attack()
    {
        if (_enemy == null)
            ChooseEnemy();
        else
            _weapons[_currentWeaponIndex].Attack(_enemy, _damage);
    }

    public void SwitchWeapon()
    {
        _weapons[_currentWeaponIndex].gameObject.SetActive(false);

        if (_currentWeaponIndex + 1 == _weapons.Length)
        {
            _currentWeaponIndex = 0;
        }
        else
        {
            _currentWeaponIndex++;
        }

        _weapons[_currentWeaponIndex].gameObject.SetActive(true);
    }

    private void ChooseEnemy()
    {
        _enemy = FindAnyObjectByType<Enemy>();
    }
}
