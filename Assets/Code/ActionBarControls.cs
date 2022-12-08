using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ActionBarControls : MonoBehaviour
{
    [Header("Customize Actionbar")]
    public bool _toggleActionBar;

    [Seperator()]

    [Header("Edit Grid")]
    public bool _rowOrColumn;
    public float _xPos;
    public float _yPos;
    public AnchorPostitions _anchorPostitions = AnchorPostitions.BottomCenter;

    [Header("Edit Sizing")]
    public float _cellSizeX = 150;
    public float _cellSizeY = 100;
    public float _spacingX;
    public float _spacingY;



}
