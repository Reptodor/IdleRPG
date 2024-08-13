using UnityEngine;

public class PlayerAnimations : Animations
{
    public override void Awake()
    {
        base.Awake();
    }

    public void AnimateSwordAttack()
    {
        Animator.SetTrigger("SwordAttack");
    }

    public void AnimateBowAttack()
    {
        Animator.SetTrigger("BowAttack");
    }
}
