using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;

namespace ChanceEditor
{
    [CustomPropertyDrawer(typeof(PercantageAttribute))]
    public class PercantagePropertyDrawer : PropertyDrawer
    {
        private const string _floatType = "float";
        private const float _intFieldWidth = 43;
        private const string _percentageSymbol = "%";
        private const string _validationErrorMessadge = "The {0} can only be used with {1} values.";

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            TryDrawValidationErrorMessage(position, property);

            DrawPropertyName(position, property);

            DrawPercentagesField(position, property);

            EditorGUI.EndProperty();
        }

        private void TryDrawValidationErrorMessage(Rect position, SerializedProperty property)
        {
            var attributeName = Regex.Replace(
                nameof(PercantageAttribute),
                "[a-z][A-Z]",
                m => m.Value[0] + " " + char.ToLower(m.Value[1])
            );

            var message = string.Format(_validationErrorMessadge, attributeName, _floatType);
            if (property.type != _floatType)
            {
                EditorGUIUtils.DrawHelpBox(position, property, message, MessageType.Info);
                EditorGUI.EndProperty();
                return;
            }
        }

        private static void DrawPropertyName(Rect position, SerializedProperty property)
        {
            if (position.width > 140)
            {
                EditorGUI.LabelField(position, property.displayName);
            }
        }

        private static void DrawPercentagesField(Rect position, SerializedProperty property)
        {
            var intFieldRect = new Rect(position.width / 2, position.y, _intFieldWidth, position.height);

            property.floatValue = EditorGUI.IntField(intFieldRect, property.floatValue.ToPercentages()).ToProbability();
            EditorGUI.LabelField(
                new Rect(intFieldRect.x + intFieldRect.width, intFieldRect.y, intFieldRect.width, intFieldRect.height),
                _percentageSymbol
                );
        }
    }
}
