using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/ActionDice", order = 1)]
public class ActionDice : Dice
{
    public override void GetCurrentFace()
    {
        Debug.Log("Face");
    }
}
