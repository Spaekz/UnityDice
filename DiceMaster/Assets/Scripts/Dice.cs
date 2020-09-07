using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Dice : ScriptableObject
{
    public string m_Name;

    [Header("Apparence")]
    public Image m_ImageDice;

    virtual public void GetCurrentFace()
    {
        //to be implemented
    }

}
