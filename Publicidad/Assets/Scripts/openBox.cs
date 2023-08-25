using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openBox : MonoBehaviour
{
    public Animator anim;

    private void OnMouseDown()
    {
        anim.SetBool("Open", true);
    }
}
