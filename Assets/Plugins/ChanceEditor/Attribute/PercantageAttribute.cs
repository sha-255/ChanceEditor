using System;
using UnityEngine;

namespace ChanceEditor
{
    /// <summary>
    /// Displays the percentages in the inspector. (Serialization is required)
    /// <example>
    /// <code>
    /// [Percantage]
    /// [SerializeField] private float _chance;
    /// </code>
    /// </example>
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public sealed class PercantageAttribute : PropertyAttribute { }
}
