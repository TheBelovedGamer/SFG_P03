    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.AttributeUsage(System.AttributeTargets.Field,
    AllowMultiple = true)]
public class SeperatorAttribute : PropertyAttribute
{
    public readonly float _height;
    public readonly float _spacing;

    public SeperatorAttribute(float height = 1, float spacing = 10)
    {
        _height = height;
        _spacing = spacing;
    }
}
