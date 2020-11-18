using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour {
    SpriteRenderer spriteRenderer;
    PhotonView myView;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        myView = GetComponent<PhotonView>();
        if (PhotonNetwork.IsConnected) {
            if (myView.IsMine) {
                spriteRenderer.color = new Color(0f, 255f, 0f, 1f);
            }
            else {
                spriteRenderer.color = new Color(0f, 0f, 255f, 1f);
            }
        }
    }
}
