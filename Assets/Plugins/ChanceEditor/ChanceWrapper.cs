using System;
using UnityEngine;

namespace ChanceEditor
{
    /// <summary>
    /// Wraps a serializable value in a wrapper with a manageable chance.
    /// <example>
    /// <code>
    /// <![CDATA[
    /// [SerializeField] private List<ChanceWrapper<GameObject>> _chanceObjects;
    /// 
    /// public void TrySetActive()
    ///     => _chanceObjects.ForEach(wrapper
    ///         => wrapper.Value.SetActive(wrapper.Calculate()));
    /// ]]>
    /// </code>
    /// </example>
    /// </summary>
    /// <typeparam name="T">
    /// The original value
    /// </typeparam>
    [Serializable]
    public class ChanceWrapper<T>
    {
        public ChanceWrapper() { }

        public ChanceWrapper(float chance) => _chance = chance;

        public ChanceWrapper(T value, float chance)
            => (Value, _chance) = (value, chance);

        public T Value;

        [Percantage]
        [SerializeField] private float _chance;

        public float Chance => _chance;

        public bool Calculate() => UnityEngine.Random.value <= _chance;
    }
}
