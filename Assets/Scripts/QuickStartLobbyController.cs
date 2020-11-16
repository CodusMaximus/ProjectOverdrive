using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class QuickStartLobbyController : MonoBehaviourPunCallbacks {

    public override void OnConnectedToMaster() {
        PhotonNetwork.AutomaticallySyncScene = true;
        JoinRandomRoom();
    }

    private void JoinRandomRoom() {
        PhotonNetwork.JoinRandomRoom();
        Debug.Log("Join Random Room.");
    }

    public override void OnJoinRandomFailed(short returnCode, string message) {
        Debug.Log($"Join Random Failed {returnCode} {message}");
        CreateRoom();
    }
    private static System.Random Random = new System.Random();
    private void CreateRoom() {
        Debug.Log("Creating Room");
        int randomNumber = Random.Next(0, 10000);
        RoomOptions options = new RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = 2 };
        PhotonNetwork.CreateRoom($"Room {randomNumber}", options);
        Debug.Log($"Connecting to Random Room {randomNumber}");
    }

    public override void OnCreateRoomFailed(short returnCode, string message) {
        Debug.Log($"Create Room Failed {returnCode} {message}");
        CreateRoom();
    }
}
