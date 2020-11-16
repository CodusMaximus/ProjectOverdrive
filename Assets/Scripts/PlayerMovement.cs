using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float HorizontalMove { get; private set; }
    public float VerticalMove { get; private set; }
    public float Speed { get; private set; } = 1f;

    // Update is called once per frame
    void Update() {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * Speed;
        VerticalMove = Input.GetAxisRaw("Vertical") * Speed;
    }

    void FixedUpdate() {
        transform.position += new Vector3(HorizontalMove, VerticalMove);
    }
}
