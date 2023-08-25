using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Animator anim;
    private void OnMouseDown()
    {
        anim.SetBool("Click", true);
        Invoke(nameof(delayAnim), 4);
    }

    void delayAnim()
    {
        anim.SetBool("Click", false);
    }
}
