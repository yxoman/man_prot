using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public bool onGround;

    private Animator animator;

    void Start()
    {
        animator = transform.parent.GetComponentInChildren<Animator>();
    }

    void Update()
    {
        animator.SetBool("onGround", onGround);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            return;

        onGround = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            return;

        onGround = false;
    }
}