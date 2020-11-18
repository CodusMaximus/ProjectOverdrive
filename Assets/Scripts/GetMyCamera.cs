using Photon.Pun;
using UnityEngine;

public class GetMyCamera : MonoBehaviour {
    public Camera myCamera;
    PhotonView myView;

    private void Awake() {
        myView = GetComponent<PhotonView>();

        if (!myView.IsMine && PhotonNetwork.IsConnected)
            return;

        myCamera.enabled = true;
    }
}
