using UnityEngine;

[CreateAssetMenu(fileName = "CharacterProperties", menuName = "CharacterProperties", order = 51)]
public class CharacterProperties : ScriptableObject
{
    [SerializeField] private int _health;
    [SerializeField] private int _armor;
    [SerializeField] private float _damage;

    public int Health() => _health;

    public int Armor() => _armor;

    public float Damage() => _damage;
}
