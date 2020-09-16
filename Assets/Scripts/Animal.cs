using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] Animator anim;
    
    void Start()
    {
       
    }

    public void AnimJump()
    {
        anim.SetTrigger("Jump");
    }
    public void AnimIdle()
    {
        anim.SetTrigger("Idle");
    }

    public void AnimRun()
    {
        anim.SetTrigger("Run");
    }

    public void AnimSit()
    {
        anim.SetTrigger("Sit");
    }
    public void AnimEat()
    {
        anim.SetTrigger("Eat");
    }
    public void AnimHit()
    {
        anim.SetTrigger("Hit");
    }
    public void AnimBark()
    {
        anim.SetTrigger("Bark");
    }
    public void AnimWalk()
    {
        anim.SetTrigger("Walk");
    }
    public void AnimDie()
    {
        anim.SetTrigger("Die");
    }
    public void AnimBite()
    {
        anim.SetTrigger("Bite");
    }
    public void AnimSwim()
    {
        anim.SetTrigger("Swim");
    }
    public void AnimAttack()
    {
        anim.SetTrigger("Attack");
    }
    public void AnimDive()
    {
        anim.SetTrigger("Dive");
    }
    public void AnimDrink()
    {
        anim.SetTrigger("Drink");
    }
    public void AnimFly()
    {
        anim.SetTrigger("Fly");
    }

    // Update is called once per frame
    void Update()
    {
        
        
                
        
    }
}
