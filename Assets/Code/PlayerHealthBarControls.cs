using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealthBarControls : MonoBehaviour
{
    [Header("Customize Player Health, Mana, & EXP Bars")]

    public bool _toggleHealthBar;
    public bool _toggleManaBar;
    public bool _toggleExpBar;

    [Seperator()]

    [Header("Change Health Bar Graphics")]
    public Image _healthBarFrame;
    public Image _healthBarBackground;
    public Image _healthBarCurrent;

    public bool _animateHealthBar;

    [Header("Change Mana Bar Graphics")]

    public Image _manaBarFrame;
    public Image _manaBarBackground;
    public Image _manaBarCurrent;

    public bool _animateManaBar;

    [Header("Change EXP Bar Graphics")]

    public Image _expBarFrame;
    public Image _expBarBackground;
    public Image _expBarCurrent;

    public bool _animateExpBar;

    [Seperator()]

    [Header("Anchor Positions")]
    public AnchorPostitions _healthAnchorPostitions = AnchorPostitions.BottomCenter;
    public AnchorPostitions _manaAnchorPostitions = AnchorPostitions.BottomCenter;
    public AnchorPostitions _expAnchorPostitions = AnchorPostitions.BottomCenter;


    [Header("Map Frame Move & Scale")]
    public float _frameX;
    public float _frameY;
    public float _frameXScale;
    public float _frameYScale;

    [Header("Map Move & Scale")]
    public float _mapX;
    public float _mapY;
    public float _mapXScale;
    public float _mapYScale;
}
