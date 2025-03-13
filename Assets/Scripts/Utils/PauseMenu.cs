using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public Transform panelMenu;
      
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (panelMenu.gameObject.activeSelf)
            {
                panelMenu.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                panelMenu.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
