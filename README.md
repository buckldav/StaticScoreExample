# StaticScoreExample

How to use static global variables in a Unity project.

## Static Class Members

**Static** variables are global variables that you can access anywhere in your project. They are good for things like player score and other values that can be accessed across scenes.

## Example from this project

The following code increases Player 1's score if they press the letter "Q" on the keyboard. If the player reaches `Globals.REQUIRED_SCORE`, set the `Globals.winnerText` to `"Player 1 Wins"` and load the "WinScreen" scene, where the DisplayWin script will show that `Globals.winnerText`.

### Scripts/Globals.cs

```cs
public class Globals : MonoBehaviour
{
    public static int player1score = 0;
    public static int player2score = 0;
    public static string winnerText = "";
    public static int REQUIRED_SCORE = 20;
}
```

### Scripts/GetPoints.cs

```cs
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
    }
}
```

### Scripts/DisplayWin.cs

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayWin : MonoBehaviour
{
    void Start()
    {
        GetComponent<UnityEngine.UI.Text>().text = Globals.winnerText;
    }
}
```
