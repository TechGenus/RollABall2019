using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

/// <summary>
/// Updates the connection status to reflect Photon's current state.
/// </summary>
public class ConnectionStatus : MonoBehaviourPunCallbacks {
    // Data for representing a connected message.
    private const string CONNECTED_TEXT = "Connected";
    private Color CONNECTED_COLOR = Color.green;

    // Data for representing a not connected message.
    private const string NOT_CONNECTED_TEXT = "Not Connected";
    private Color NOT_CONNECTED_COLOR = Color.red;

    // The connection status Game Object.
    [SerializeField] private Text _statusMessage;
    public Text StatusMessage {
        get { return _statusMessage; }
        set { _statusMessage = value; }
    }

    private void Update() {
        if (PhotonNetwork.IsConnectedAndReady) {
            UpdateStatus(CONNECTED_TEXT, CONNECTED_COLOR);
        } else {
            UpdateStatus(NOT_CONNECTED_TEXT, NOT_CONNECTED_COLOR);
        }
    }

    private void UpdateStatus(string message, Color color) {
        if (_statusMessage != null) {
            _statusMessage.text = message;
            _statusMessage.color = color;
        }
    }
}
