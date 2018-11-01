using UnityEngine;

public class AnimatorController : MonoBehaviour {
    // Use this for initialization
    Animator animator;
	void Start () {
        animator = GetComponent<Animator>();
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
