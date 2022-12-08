using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(SeperatorAttribute))]
public class SeparatorDrawer : DecoratorDrawer
{
    public override void OnGUI(Rect position)
    {
        //get ref to the attribute
        SeperatorAttribute seperatorAttribute
            = attribute as SeperatorAttribute;

        //define line to draw
        Rect separatorRect = new Rect(position.xMin, position.yMin + seperatorAttribute._spacing, 
            position.width, seperatorAttribute._height);

        //draw it
        EditorGUI.DrawRect(separatorRect, Color.white);

    }

    public override float GetHeight()
    {
        //get ref to the attribute
        SeperatorAttribute seperatorAttribute
            = attribute as SeperatorAttribute;

        //calculate amount of space needed
        float totalSpacing = seperatorAttribute._spacing
            + seperatorAttribute._height + seperatorAttribute._spacing;

        //adjust spacing in GUI
        return totalSpacing;
    }
}
