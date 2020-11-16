using Photon.Pun;
using UnityEngine;

public class NetworkController : MonoBehaviourPunCallbacks {
    void Start() {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster() {
        Debug.Log($"Connect to {PhotonNetwork.CloudRegion} server.");
    }
}
