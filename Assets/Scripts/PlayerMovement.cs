using Photon.Pun;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    public float HorizontalMove { get; private set; }
    public float VerticalMove { get; private set; }
    public float Speed { get; private set; } = 0.05f;

    private PhotonView myView;
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

        //int RotationSpeed = 15;

        //transform.Rotate(Vector3.forward * (RotationSpeed * Time.deltaTime));

        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
    }

    //void FixedUpdate() {
    //}
}
