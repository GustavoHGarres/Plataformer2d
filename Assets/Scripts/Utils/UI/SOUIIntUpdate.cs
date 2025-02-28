using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SOUIIntUpdate : MonoBehaviour
{
    public SOInt soInt;
    public Text uiTextValue;

    void Start()
    {
        uiTextValue.text = soInt.value.ToString();
    }

    void Update()
    {
        uiTextValue.text = soInt.value.ToString();
    }
}
