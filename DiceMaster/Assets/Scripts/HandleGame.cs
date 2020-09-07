using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandleGame : MonoBehaviour
{
    [Header("Player")]
    public GameObject m_Player1;
    public GameObject m_Player2;

    [Header("LifeCounter")]
    public TMP_Text m_LifeCounter1;
    public TMP_Text m_LifeCounter2;

    [Header("Announce Text")]
    public TMP_Text m_TextPlayerSide;
    public TMP_Text m_TextEnemySide;

    [Header("Start up settings")]
    public int m_StartLife = 20;
    public string m_StartingString = "La partie va commencer";

    // Start is called before the first frame update
    void Start()
    {
        m_LifeCounter1.text = m_StartLife.ToString();
        m_TextPlayerSide.text = m_StartingString; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
