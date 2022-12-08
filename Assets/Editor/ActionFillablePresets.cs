using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ActionButtonData))]
public class ActionFillablePresets : Editor
{
    public override void OnInspectorGUI()
    {
        ActionButtonData data = (ActionButtonData)target;


        base.OnInspectorGUI();

        if(data._actionType == ActionType.Attack)
        {

        }
        if (data._actionType == ActionType.Buff)
        {

        }
        if (data._actionType == ActionType.Debuff)
        {

        }
        if (data._actionType == ActionType.Heal)
        {

        }
        if (data._actionType == ActionType.RegenMana)
        {

        }
    }

}
