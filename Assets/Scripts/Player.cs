using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string[] state;
    private string playerName;
    private int money;
    private bool playerNameSettet;

    // Start is called before the first frame update
    void Start()
    {
        playerName = "Nicht Zugewiesen";
        playerNameSettet = false;
        for (int i = 0; i >= 2;i++)
        {
            state[i] = "mx.s";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Invert(playerNameSettet))
        {
            SetPlayerName();
        }
    }

    private void SetPlayerName()
    {

    }

    private bool Invert(bool a)
    {
        return a == false;
    }
}
