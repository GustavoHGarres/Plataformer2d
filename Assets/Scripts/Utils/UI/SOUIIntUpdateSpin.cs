using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SOUIIntUpdateSpin : MonoBehaviour
{
    public SOIntSpin soIntSpin;
    public Text uiTextValueSpin;

    void Start()
    {
        uiTextValueSpin.text = soIntSpin.valueSpin.ToString();
    }

    void Update()
    {
       uiTextValueSpin.text = soIntSpin.valueSpin.ToString();
    }
}

