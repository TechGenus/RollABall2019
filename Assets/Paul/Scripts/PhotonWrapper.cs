using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

/// <summary>
/// Wraps common photon calls.
/// </summary>
public class PhotonWrapper : MonoBehaviourPunCallbacks {
    // TODO: add more settings - rooms, friends, etc.
    
    // Add modes - get the most points (time limit - count down)
    //           - survive the longest (no time limit - may time how long the match goes)
    // Make a gameobject with a script:
    //  - script will handle the mode when loaded into the next scene.

    public void Connect() {
        PhotonNetwork.ConnectUsingSettings();
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
