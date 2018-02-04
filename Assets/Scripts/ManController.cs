using UnityEngine;

public class ManController : MonoBehaviour
{
    private Transform mainCamera;

    private Animator animator;

    private GroundChecker groundChecker;

    void Start()
    {
        mainCamera = Camera.main.transform.parent;
        animator = GetComponentInChildren<Animator>();
        groundChecker = GetComponentInChildren<GroundChecker>();
    }

    void Update()
    {
        transform.rotation = mainCamera.rotation;
        var velz = transform.InverseTransformDirection(GetComponent<Rigidbody>().velocity).z;
        animator.SetFloat("velocityZ", velz);

        if (groundChecker.onGround)
        {
            // пуляем рейкастом под ноги
            RaycastHit hit;
            if (Physics.Raycast(transform.position + transform.up * 0.2f, -transform.up, out hit))
            {
                // тут находим направления нормали и взгляда персонажа относительно контейнера игрока
                var inversedNormal = transform.InverseTransformVector(hit.normal);
                var inversedForward = transform.InverseTransformVector(animator.transform.forward);

                // если направления совпадают, значит персонаж наклоняется назад
                bool inclineBack = inversedNormal.z > 0 && inversedForward.z > 0 ||
                                   inversedNormal.z < 0 && inversedForward.z < 0;

                animator.SetFloat("camZ",
                    Vector3.Angle(animator.transform.up, hit.normal) * (inclineBack ? 1 : -1));
            }
        }
    }
}