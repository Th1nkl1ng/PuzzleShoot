using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SettingsManage : MonoBehaviour
{
    public TMP_Dropdown dropdownGraphics;

    public void ChageGraphics()
    {
        QualitySettings.SetQualityLevel(dropdownGraphics.value);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
