using UnityEngine;

public abstract class Animations : MonoBehaviour
{
    protected Animator Animator;

    public virtual void Awake()
    {
        Animator = GetComponentInChildren<Animator>();
    }

    public void AnimateAttack()
    {
        Animator.SetTrigger("Attack");
    }

    public void AnimateHit()
    {
        Animator.SetTrigger("Hurt");
    }

    public void AnimateDie()
    {
        Animator.SetTrigger("Died");
    }
}
