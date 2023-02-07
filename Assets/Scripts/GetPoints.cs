using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetPoints : MonoBehaviour
{
    public Text text;
    public bool isP1 = false;
    public bool isP2 = false;

    void LoadWinScreen() {
        SceneManager.LoadScene("WinScreen");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && isP1) {
            Globals.player1score += 1;
            text.text = Globals.player1score.ToString();
            if (Globals.player1score >= Globals.REQUIRED_SCORE) {
                Globals.winnerText = "Player 1 Wins!";
                LoadWinScreen();
            }
        }
        if (Input.GetKeyDown(KeyCode.P) && isP2) {
            Globals.player2score += 1;
            text.text = Globals.player2score.ToString();
            if (Globals.player2score >= Globals.REQUIRED_SCORE) {
                Globals.winnerText = "Player 2 Wins!";
                LoadWinScreen();
            }
        }
    }
}
