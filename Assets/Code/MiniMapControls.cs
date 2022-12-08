using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MiniMapControls : MonoBehaviour
{
    [Header("Customize Map Graphics")]

    [Tooltip("Toggle off or on the map")]
    public bool _toggleMap;
    [Tooltip("Changes base map shape")]
    public MinimapShape _minimapShape = MinimapShape.None;

    [Seperator()]

    [Header("Change Graphic Assets")]
    [SerializeField] public Image _miniMapFrame;
    [SerializeField] public Image _miniMapTexture;
    [SerializeField] public Camera _renderCamera;

    [Seperator()]

    [Header("Anchor Position")]
    public AnchorPostitions _anchorPostitions = AnchorPostitions.TopRight;

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

    

    /*
     * for later
     * 
     * if(_minimapShape = MinimapShape.<insert type here>)
     * {
     *      toggle off/on whatever shape it is
     * }
     */

}
