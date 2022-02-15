using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoldierInfo : MonoBehaviour
{
    private Text numSoldier;

    private void Awake()
    {
        numSoldier = GetComponent<Text>();
    }

    private void UpdateNumSoldier(int _numSoldier)
    {
        numSoldier.text = "SOLDADOS: " + _numSoldier;
    }

    void OnEnable()
    {
        CanvasUpdate.NumSoldierUpdate += UpdateNumSoldier;
    }

    void OnDisable()
    {
        CanvasUpdate.NumSoldierUpdate -= UpdateNumSoldier;
    }
}