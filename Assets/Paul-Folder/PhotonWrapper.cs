using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class PhotonWrapper : MonoBehaviourPunCallbacks
{
    public void Connect() {
        PhotonNetwork.ConnectUsingSettings();
         
        // TODO: move out of here

    }

    public void LoadScene() {
        PhotonNetwork.LoadLevel("SampleScene");
    }

    public override void OnConnectedToMaster() {
        Debug.Log("this was called.");
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message) {
        
        PhotonNetwork.CreateRoom(null);
    }

    public override void OnJoinedRoom() {
        LoadScene();
    }
}
