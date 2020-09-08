using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class DetailCard : MonoBehaviour
{
    [Header("Card")]
    public Card m_Card;

    [Header("Component")]
    public TMP_Text m_TitleCardText;
    public Image m_ImageCard;
    public TMP_Text m_CostCardText;
    public TMP_Text m_AffiliationCardText;
    public TMP_Text m_DescriptionCardText;
    public TMP_Text m_MaxCardText;
    public TMP_Text m_SpecialCardText;

    [Header("Defalut Messages")]
    public string m_DefaultAbilities = "No special capabilites";

    public void ApplyCard(Card card)
    {
        string affiliation = null;
        string special = null;

        m_Card = card;
        m_ImageCard.sprite = m_Card.m_Image;
        m_TitleCardText.text = String.Format("{0} , {1}", m_Card.m_NameCard,m_Card.m_SubName);
        m_CostCardText.text = m_Card.m_Cost.ToString();

        
        foreach (string newAff in m_Card.m_Affiliations)
        {
            affiliation += newAff + " ";
        }
        m_AffiliationCardText.text = affiliation;

        m_DescriptionCardText.text = m_Card.m_Description;
        m_MaxCardText.text = m_Card.m_MaxDice.ToString();

        if (m_Card.m_Special1 == null && m_Card.m_Special2 == null)
        {
            special = m_DefaultAbilities;
        } else {

            if (m_Card.m_Special1 != null)
            {
                special += " * / " + m_Card.m_Special1 + "\n"; 
            }
            if (m_Card.m_Special2 != null)
            {
                special += " ** / " + m_Card.m_Special2 + "\n";
            }
        }
        m_SpecialCardText.text = special;
        
    }
}
