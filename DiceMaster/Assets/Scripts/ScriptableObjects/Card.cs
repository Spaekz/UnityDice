using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObjects/Card", order = 1)]
public class Card : ScriptableObject
{
    public string m_NameCard;
    public string m_SubName;

    public Sprite m_Image;

    public int m_Cost;
    public Energy m_Energy;

    public int m_MaxDice;

    public List<string> m_Affiliations;

    public string m_Description;
    public List<string> m_Capabilities;

    public string m_Special1;
    public string m_Special2;

}
