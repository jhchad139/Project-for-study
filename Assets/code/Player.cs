using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed;
    public Vector2 inputvec;

    Rigidbody2D rigid;
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue value)
    {
        inputvec = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector2 movec = inputvec*speed*Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + movec);
    }
}
