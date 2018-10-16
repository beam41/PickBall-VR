using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour {
    // Use this for initialization
    Animator animator;
	void Start () {
        animator = GetComponent<Animator>();
	}
	// Update is called once per frame
	void Update () {
		
	}
    public void isRuning()
    {
        animator.SetBool("Run", true);
    }
    public void isNotRunning()
    {
        animator.SetBool("Run", false);
    }
}
