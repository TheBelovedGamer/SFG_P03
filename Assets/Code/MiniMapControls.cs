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

    [Header("Change Graphic Assets")]
    [SerializeField] public Image _miniMapFrame;
    [SerializeField] public Image _miniMapTexture;
    [SerializeField] public Camera _renderCamera;

    [Header("Move & Scale")]
    [SerializeField] public Transform _framePosition;

    /*
     * for later
     * 
     * if(_minimapShape = MinimapShape.<insert type here>)
     * {
     *      toggle off/on whatever shape it is
     * }
     */
    
}
