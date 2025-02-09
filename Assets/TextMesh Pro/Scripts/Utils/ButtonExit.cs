using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonExit : MonoBehaviour
{
    
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Is the game over for today?");
    }
}
