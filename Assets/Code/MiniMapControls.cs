using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class MiniMapControls : MonoBehaviour
{
    public GameObject _miniMapObject;
    public GameObject _miniMapFrameObject;
    public GameObject _miniMapRenderObject;

    [Header("Customize Map Graphics")]

    [Tooltip("Toggle off or on the map")]
    public bool _toggleMap;

    [Seperator()]

    [Header("Change Camera Settings")]
    public Camera _renderCamera;
    public float _cameraHeight = 15f;

    [Seperator()]


    [Header("Map Frame Move & Scale")]
    public float _frameX;
    public float _frameY;
    public float _frameXScale = 1f;
    public float _frameYScale = 1f;

    [Header("Map Move & Scale")]
    public float _mapX;
    public float _mapY;
    public float _mapXScale = 1f;
    public float _mapYScale = 1f;



    private void Update()
    {
        ToggleGraphics();
        MoveFrame();
        MoveMap();
        MoveCamera();
    }

    private void ToggleGraphics()
    {
        if(_toggleMap == false)
        {
            _miniMapObject.SetActive(false);
        }
        else if(_toggleMap == true)
        {
            _miniMapObject.SetActive(true);
        }
    }

    private void MoveFrame()
    {
        RectTransform _frameMove;

        _frameMove = _miniMapFrameObject.GetComponent<RectTransform>();

        _frameMove.localPosition = new Vector2(_frameX, _frameY);
        _frameMove.localScale = new Vector2(_frameXScale/100, _frameYScale/100);
    }

    private void MoveMap()
    {
        RectTransform _mapMove;

        _mapMove = _miniMapRenderObject.GetComponent<RectTransform>();

        _mapMove.localPosition = new Vector2(_mapX, _mapY);
        _mapMove.localScale = new Vector2(_mapXScale/100, _mapYScale/100);

    }

    private void MoveCamera()
    {
        Vector3 camPOS;

        camPOS = _renderCamera.transform.position;
        camPOS.y = _cameraHeight;

        _renderCamera.transform.position = camPOS;

    }
}
