using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour {
    public Animator animator;

    public void FadeIn() {
        if (animator == null) return;
        animator.SetTrigger("fadeIn");
    }
}
