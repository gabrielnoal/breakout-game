using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_GameOver : MonoBehaviour
{
    public Text message;
    GameManager gm;
    void OnEnable()
    {
        gm = GameManager.GetInstance();

        if(gm.vidas > 0)
        {
            message.text = "WIN";
        }
        else 
        {
            message.text = "GAME OVER";
        }
    }

    public void Voltar()
    {
        gm.changeState(GameManager.GameState.MENU);
    }
}
