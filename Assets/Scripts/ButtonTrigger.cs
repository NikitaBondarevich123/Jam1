using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonTrigger : MonoBehaviour
{
    public Animator anim;
    private void OnTriggerEnter2D(Collider2D other)
    {
        anim.SetBool("IsTriggered", true);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        anim.SetBool("IsTriggered", false);
    }
}
