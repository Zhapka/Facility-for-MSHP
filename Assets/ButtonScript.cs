using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private bool Opening = false;
    private void OnMouseUpAsButton()
    {
        if (Opening == false) { anim.SetBool("Opening", true); Opening = true; }
        else { anim.SetBool("Closing", true); Opening = false; }
    }

    public void OpeningTrue()
    {
        anim.SetBool("Opening", true);
    }

    public void OpeningFalse()
    {
        anim.SetBool("Opening", false);
    }

    public void OpenedTrue()
    {
        anim.SetBool("Opened", true);
    }

    public void OpenedFalse()
    {
        anim.SetBool("Opened", false);
    }

    public void ClosingTrue()
    {
        anim.SetBool("Closing", true);
    }

    public void ClosingFalse()
    {
        anim.SetBool("Closing", false);
    }
}
