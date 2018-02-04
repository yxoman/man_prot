using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    private Transform player;
    private Rigidbody rigid;

    private float yOffset = 1.5f;
    private float zOffset = 3f;

    private Vector3 forwardOffset;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        rigid = player.GetComponent<Rigidbody>();
    }

    void LateUpdate()
    {
        forwardOffset = Vector3.Lerp(forwardOffset,
            (rigid.velocity.magnitude > 0.1f ? rigid.velocity.normalized * zOffset : Vector3.zero), Time.deltaTime);
        transform.position =
            player.transform.position + player.up * yOffset +
            forwardOffset;
    }
}