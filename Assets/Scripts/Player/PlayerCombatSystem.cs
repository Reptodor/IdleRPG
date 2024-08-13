using UnityEngine;

public class PlayerCombatSystem : MonoBehaviour
{
    [SerializeField] private Weapon[] _weapons;
    [SerializeField] private Timer _timer;
    [SerializeField] private float _weaponSwitchTime = 2f;
    private Enemy _enemy;

    private int _currentWeaponIndex;
    private float _damage;
    private bool _canAttack;
    private bool _pressedSwitchButton;


    private void OnEnable()
    {
        Timer.TimeExpired += () => { _canAttack = true; };
    }

    private void OnDisable()
    {
        Timer.TimeExpired -= () => { _canAttack = true; };
    }

    public void Initialize(float damage)
    {
        _damage = damage;
        _canAttack = true;
    }

    private void Update()
    {
        if (_pressedSwitchButton)
            SwitchWeapon(_pressedSwitchButton);
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
            _canAttack = false;
        } 
    }

    public void SwitchWeapon(bool pressedSwitchButton)
    { 
        if(_canAttack && _pressedSwitchButton)
        {
            _timer.StopTimer(_weaponSwitchTime);
            _weapons[_currentWeaponIndex].gameObject.SetActive(false);

            if (_currentWeaponIndex + 1 == _weapons.Length)
            {
                _currentWeaponIndex = 0;
            }
            else
            {
                _currentWeaponIndex++;
            }
            _pressedSwitchButton = false;
            _weapons[_currentWeaponIndex].gameObject.SetActive(true);
        }
        else
        {
            _pressedSwitchButton = pressedSwitchButton;
        }
    }
}
