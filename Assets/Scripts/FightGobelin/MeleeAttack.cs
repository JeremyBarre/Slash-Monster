using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
  public static int noOfClicks = 0;

  private float nextFireTime = 0f;

  float lastClickedTime = 0;
  float maxComboDelay = 1;

  private Animator anim;

  private void Start()
  {
    anim = GetComponent<Animator>();
  }


  public void Update()
  {
    if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.8f && anim.GetCurrentAnimatorStateInfo(0).IsName("Hit1"))
    {
      anim.SetBool("Hit1", false);
    }
    if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1f && anim.GetCurrentAnimatorStateInfo(0).IsName("Hit2"))
    {
      anim.SetBool("Hit2", false);
    }
    if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1f && anim.GetCurrentAnimatorStateInfo(0).IsName("Hit3"))
    {
      anim.SetBool("Hit3", false);
      noOfClicks = 0;
    }
    if (Time.time - lastClickedTime > maxComboDelay)
    {
      noOfClicks = 0;
    }
    if (Time.time > nextFireTime)
    {
      if (Input.GetMouseButtonDown(0))
      {
        Combo();
      }
    }
  }
  void Combo()
  {
    lastClickedTime = Time.time;
    noOfClicks++;
    if (noOfClicks == 1)
    {
      anim.SetBool("Hit1", true);
    }
    noOfClicks = Mathf.Clamp(noOfClicks, 0, 3);

    if (noOfClicks >= 2 && anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.8f && anim.GetCurrentAnimatorStateInfo(0).IsName("Hit1"))
    {
      anim.SetBool("Hit1", false);
      anim.SetBool("Hit2", true);
    }
    if (noOfClicks >= 3 && anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1f && anim.GetCurrentAnimatorStateInfo(0).IsName("Hit2"))
    {
      anim.SetBool("Hit2", false);
      anim.SetBool("Hit3", true);
    }
    if (noOfClicks >= 4 && anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1f && anim.GetCurrentAnimatorStateInfo(0).IsName("Hit3"))
    {
      anim.SetBool("Hit3", false);
      noOfClicks = 0;
    }
  }
  void Attack()
  {
    // target.GetComponent<Gobelin>().TakeDamage(Dammage);
    // Debug.Log("attack" + Dammage + "damage");
  }
}