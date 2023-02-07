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
