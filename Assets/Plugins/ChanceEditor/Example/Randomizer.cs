using ChanceEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    [SerializeField] private List<ChanceWrapper<GameObject>> _chanceObjects;

    private bool _isEveryFrame;
    private Coroutine _coroutine;

    private void Awake()
    {
        _chanceObjects.ForEach(obj => obj.Value.SetActive(false));
    }

    private void OnDrawGizmos()
    {
        _chanceObjects
            .ForEach(wrapper =>
                Handles.Label(
                    wrapper.Value.transform.position,
                    wrapper.Chance.ToString()
                    )
                );
    }

    public void TrySetActive()
    {
        if (_chanceObjects.Count == 0) return;
        _chanceObjects
            .ForEach(wrapper => wrapper.Value.SetActive(wrapper.Calculate()));
    }

    public void SwitchSetActiveEveryFrame()
    {
        _isEveryFrame = !_isEveryFrame;

        if (_isEveryFrame)
            _coroutine = StartCoroutine(SetActiveEveryFrame());
        else
            StopCoroutine(_coroutine);
    }

    private IEnumerator SetActiveEveryFrame()
    {
        while (true)
        {
            TrySetActive();
            yield return null;
        }
    }
}
