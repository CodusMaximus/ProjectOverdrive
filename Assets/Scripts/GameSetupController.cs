using Photon.Pun;
using UnityEngine;

public class GameSetupController : MonoBehaviour {
    void Start() {
        CreatePlayer();
    }

    private void CreatePlayer() {
        Debug.Log("Creating Player");
        PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);
    }
}
