using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Statistics")]
    [SerializeField] private float hp = 100f;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float gravity = -10f;

    private CharacterController controller;
    private Vector3 velocity;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    public void ProcessInput(Vector2 input)
    {
        var direction = Vector3.zero;
        direction.x = input.x;
        direction.z = input.y;
        controller.Move(transform.TransformDirection(direction) * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    public void UpdateHp(float num)
    {
        hp = hp + num;
    }

}
