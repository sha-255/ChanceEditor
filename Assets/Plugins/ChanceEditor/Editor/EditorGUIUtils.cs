using UnityEditor;
using UnityEngine;

namespace ChanceEditor
{
    public class EditorGUIUtils
    {
        public static void DrawHelpBox(Rect rect, SerializedProperty property, string message, MessageType messageType)
        {
            float indentLength = GetIndentLength(rect);
            Rect helpBoxRect = new Rect(
                rect.x + indentLength,
                rect.y,
                rect.width - indentLength,
                EditorGUIUtility.singleLineHeight * 2);

            EditorGUI.HelpBox(helpBoxRect, message, MessageType.Warning);

            Rect propertyRect = new Rect(
                rect.x,
                rect.y + EditorGUIUtility.singleLineHeight * 2,
                rect.width,
                EditorGUI.GetPropertyHeight(property, includeChildren: true));
        }

        public static float GetIndentLength(Rect sourceRect)
        {
            Rect indentRect = EditorGUI.IndentedRect(sourceRect);
            float indentLength = indentRect.x - sourceRect.x;
            return indentLength;
        }
    }
}
