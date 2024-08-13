using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    [SerializeField] private Image _healthBar;
    private Health _health;

    private void Awake()
    {
        _health = GetComponent<Health>();

    }

    private void OnEnable()
    {
        _health.HealthChange += OnHealthChanged;
        
    }

    private void OnDisable()
    {
        _health.HealthChange -= OnHealthChanged;
    }

    private void OnHealthChanged(float healthPercentage)
    {
        _healthBar.fillAmount = healthPercentage;
    }
}
