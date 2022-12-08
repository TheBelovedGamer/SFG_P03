using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class PlayerHealthBarControls : MonoBehaviour
{
    public GameObject _HealthBar;
    public GameObject _ManaBar;
    public GameObject _EXPBar;

    public GameObject _HealthFrame;
    public GameObject _ManaFrame;
    public GameObject _EXPFrame;

    [Header("Customize Player Health, Mana, & EXP Bars")]

    public bool _toggleHealthBar;
    public bool _toggleManaBar;
    public bool _toggleExpBar;

    [Seperator()]

    [Header("Health Bar Frame Move & Scale")]
    public float _healthFrameX;
    public float _healthFrameY;
    public float _healthFrameXScale;
    public float _healthFrameYScale;

    [Header("Health Bar Move & Scale")]
    public float _healthBarX;
    public float _healthBarY;
    public float _healthBarXScale;
    public float _healthBarYScale;

    [Seperator()]

    [Header("Mana Bar Frame Move & Scale")]
    public float _manaFrameX;
    public float _manaFrameY;
    public float _manaFrameXScale;
    public float _manaFrameYScale;

    [Header("Mana Bar Move & Scale")]
    public float _manaBarX;
    public float _manaBarY;
    public float _manaBarXScale;
    public float _manaBarYScale;

    [Seperator()]

    [Header("EXP Bar Frame Move & Scale")]
    public float _expFrameX;
    public float _expFrameY;
    public float _expFrameXScale;
    public float _expFrameYScale;

    [Header("EXP Bar Move & Scale")]
    public float _expBarX;
    public float _expBarpY;
    public float _expBarXScale;
    public float _expBarYScale;

    private void Update()
    {
        ToggleGraphics();
        MoveHealthBar();
        MoveManaBar();
        MoveEXPBar();
        MoveHealthFrame();
        MoveManaFrame();
        MoveEXPFrame();
    }

    private void ToggleGraphics()
    {
        if (_toggleHealthBar == false)
        {
            _HealthBar.SetActive(false);
        }
        else if (_toggleHealthBar == true)
        {
            _HealthBar.SetActive(true);
        }

        if (_toggleExpBar == false)
        {
            _EXPBar.SetActive(false);
        }
        else if (_toggleExpBar == true)
        {
            _EXPBar.SetActive(true);
        }

        if (_toggleManaBar == false)
        {
            _ManaBar.SetActive(false);
        }
        else if (_toggleManaBar == true)
        {
            _ManaBar.SetActive(true);
        }



    }

    private void MoveHealthFrame()
    {
        RectTransform _frameMove;

        _frameMove = _HealthFrame.GetComponent<RectTransform>();

        _frameMove.localPosition = new Vector2(_healthFrameX, _healthFrameY);
        _frameMove.localScale = new Vector2(_healthFrameXScale / 100, _healthFrameYScale / 100);
    }

    private void MoveManaFrame()
    {
        RectTransform _frameMove;

        _frameMove = _ManaFrame.GetComponent<RectTransform>();

        _frameMove.localPosition = new Vector2(_manaFrameX, _manaFrameY);
        _frameMove.localScale = new Vector2(_manaFrameXScale / 100, _manaFrameYScale / 100);
    }

    private void MoveEXPFrame()
    {
        RectTransform _frameMove;

        _frameMove = _EXPFrame.GetComponent<RectTransform>();

        _frameMove.localPosition = new Vector2(_expFrameX, _expFrameY);
        _frameMove.localScale = new Vector2(_expFrameXScale / 100, _expFrameYScale / 100);
    }

    private void MoveHealthBar()
    {
        RectTransform _frameMove;

        _frameMove = _HealthBar.GetComponent<RectTransform>();

        _frameMove.localPosition = new Vector2(_healthBarX, _healthBarY);
        _frameMove.localScale = new Vector2(_healthBarXScale / 100, _healthBarYScale / 100);
    }

    private void MoveManaBar()
    {
        RectTransform _frameMove;

        _frameMove = _ManaBar.GetComponent<RectTransform>();

        _frameMove.localPosition = new Vector2(_manaBarX, _manaBarY);
        _frameMove.localScale = new Vector2(_manaBarXScale / 100, _manaBarYScale / 100);
    }
    private void MoveEXPBar()
    {
        RectTransform _frameMove;

        _frameMove = _EXPBar.GetComponent<RectTransform>();

        _frameMove.localPosition = new Vector2(_expBarX, _expBarpY);
        _frameMove.localScale = new Vector2(_expBarXScale / 100, _expBarYScale / 100);
    }
}
