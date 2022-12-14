using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionButton : MonoBehaviour
{
    [SerializeField]
    private ActionButtonData _data;

    private void Awake()
    {
        Debug.Log("Name: " + _data._actionName);
    }

    private void Update()
    {
        
    }

}
