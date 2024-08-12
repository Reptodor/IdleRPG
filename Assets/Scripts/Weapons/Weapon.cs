using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public virtual void Attack(Enemy enemy, int damage)
    {
        Debug.Log("Attack");
    }
}
