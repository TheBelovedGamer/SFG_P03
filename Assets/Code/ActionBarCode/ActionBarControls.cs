using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ActionBarControls : MonoBehaviour
{
    [Seperator()]

    public GameObject _actionBar;
    public GameObject _LayoutGroup;
    public bool _toggleActionBar;
    public bool _toggleMouseLock;

    [Seperator()]

    [Header("Edit Location")]
    public float _xPos;
    public float _yPos;

    [Header("Edit Grid")]
    public Vector2 _cellSize;
    public Vector2 _cellSpacing;

    private RectTransform _location;

    private void Awake()
    {
        //_cellSize = GetComponentInChildren<GridLayoutGroup>().cellSize;
    }

    private void Update()
    {
        ToggleActionBar();
        ChangeLayoutGroup();
        MoveGrid();
        ToggleMouseLock();
    }

    private void ToggleActionBar()
    {
        if(_toggleActionBar == true)
        {
            _actionBar.SetActive(true);
        }
        else if(_toggleActionBar == false)
        {
            _actionBar.SetActive(false);
        }
    }

    private void ChangeLayoutGroup()
    {
        _LayoutGroup.GetComponent<GridLayoutGroup>().cellSize = _cellSize;
        _LayoutGroup.GetComponent<GridLayoutGroup>().spacing = _cellSpacing;
    }

    private void MoveGrid()
    {
        _location = _LayoutGroup.GetComponent<RectTransform>();

        _location.localPosition = new Vector2(_xPos, _yPos);
    }

    private void ToggleMouseLock()
    {
        if(_toggleMouseLock == true)
        {
            Cursor.lockState = CursorLockMode.Locked;

        }
        else if( _toggleMouseLock == false)
        {
            Cursor.lockState = CursorLockMode.None;

        }
    }
}
