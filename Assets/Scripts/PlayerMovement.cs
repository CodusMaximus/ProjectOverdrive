using UnityEngine;
using Photon.Pun;
public class PlayerMovement : MonoBehaviour {

    private PhotonView myView;

    public float HorizontalMove { get; private set; }
    public float VerticalMove { get; private set; }
    public float Speed { get; private set; } = 1f;

    private void Start() {
        myView = GetComponent<PhotonView>();
    }

    private void Update() {
        if (!myView.IsMine && PhotonNetwork.IsConnected) {
            return;
        }

        HorizontalMove = Input.GetAxisRaw("Horizontal") * Speed;
        VerticalMove = Input.GetAxisRaw("Vertical") * Speed;
        transform.position += new Vector3(HorizontalMove, VerticalMove);
    }

    //void FixedUpdate() {
    //}
}
