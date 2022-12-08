using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ActionButtonData_", menuName = "UnitData/ActionButton")]
public class ActionButtonData : ScriptableObject
{
    [Header("Customize Action Button")]
    public string _actionName;
    public ActionType _actionType = ActionType.None;

    [Header("Change Graphic Assets")]
    [SerializeField] public Image _actionFrame;
    [SerializeField] public Image _actionIcon;

    [Header("Changable Variables")]
    public float _floatValue;
    public float _cooldown;

    [Header("Player Feedback")]
    public ParticleSystem _particleFeedback;
    public AudioSource _audioFeedback;
    public AudioClip _audioClip;

    //[Header("Attached Scripts")]
    

}
