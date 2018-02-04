using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    private Transform player;

    [SerializeField] [Range(-360f, 360f)] private float gravity;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

        transform.eulerAngles = new Vector3(gravity, 0f, 0f);
    }
}