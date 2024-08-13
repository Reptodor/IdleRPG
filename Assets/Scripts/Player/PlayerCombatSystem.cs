using UnityEngine;

public class PlayerCombatSystem : MonoBehaviour
{
    [SerializeField] private Weapon[] _weapons;
    [SerializeField] private bool _canAttack;
    private Enemy _enemy;

    private int _currentWeaponIndex;
    private float _damage;

    public void Initialize(float damage)
    {
        _damage = damage;
        _canAttack = true;
    }

    public void GetEnemy(Enemy enemy)
    {
        _enemy = enemy;
    }

    public void Attack()
    {
        if(_enemy != null && _canAttack)
        {
            _weapons[_currentWeaponIndex].Attack(_enemy, _damage);
        } 
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
}
