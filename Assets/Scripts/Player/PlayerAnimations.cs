using UnityEngine;

public class PlayerAnimations : Animations
{
    public static PlayerAnimations Instance { get; private set; }

    public override void Awake()
    {
        base.Awake();
        Instance = this;
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
