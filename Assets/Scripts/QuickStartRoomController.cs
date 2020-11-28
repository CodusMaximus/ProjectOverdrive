using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuickStartRoomController : MonoBehaviourPunCallbacks {

    [SerializeField]
    private int multiplayerSceneIndex;

    public override void OnEnable() {
        PhotonNetwork.AddCallbackTarget(this);
    }
    public override void OnDisable() {
        PhotonNetwork.RemoveCallbackTarget(this);
    }

    public override void OnJoinedRoom() {
        Debug.Log("Joined Room");

        if (PhotonNetwork.PlayerList.Length > 1) {
            StartGame();
        }
    }
    public override void OnPlayerEnteredRoom(Player newPlayer) {
        if (PhotonNetwork.PlayerList.Length > 1) {
            StartGame();
        }
    }
    private void StartGame() {
        if (PhotonNetwork.IsMasterClient) {
            Debug.Log("Starting Game");
            PhotonNetwork.LoadLevel("QuickNetworkGameScene");
        }
    }

 
}
