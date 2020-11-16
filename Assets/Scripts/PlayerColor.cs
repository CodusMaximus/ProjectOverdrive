using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour {
    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (PhotonNetwork.IsMasterClient) {
            spriteRenderer.color = new Color(0f, 255f, 0f, 1f);
        }
        else {
            spriteRenderer.color = new Color(0f, 0f, 255f, 1f);
        }
    }

    void Update() {
        if (PhotonNetwork.IsMasterClient) {
            spriteRenderer.color = new Color(0f, 255f, 0f, 1f);
        }
        else {
            spriteRenderer.color = new Color(0f, 0f, 255f, 1f);
        }

    }
}
