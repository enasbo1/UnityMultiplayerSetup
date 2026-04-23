using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Script.Lobby
{
    public class LobbyListSingleUI : MonoBehaviour {
        [SerializeField] private TextMeshProUGUI lobbyNameText;
        [SerializeField] private TextMeshProUGUI playersText;
        [SerializeField] private TextMeshProUGUI gameModeText;


        private Unity.Services.Lobbies.Models.Lobby lobby;


        private void Awake() {
            GetComponent<Button>().onClick.AddListener(() => {
                LobbyManager.Instance.JoinLobby(lobby);
            });
        }

        public void UpdateLobby(Unity.Services.Lobbies.Models.Lobby lobby) {
            this.lobby = lobby;

            lobbyNameText.text = lobby.Name;
            playersText.text = lobby.Players.Count + "/" + lobby.MaxPlayers;
            gameModeText.text = lobby.Data[LobbyKey.GAME_MODE].Value;
        }


    }
}