# ChanceEditor

Makes it easier to manage the randomness in the game

## Percantage Attribute

#### Displays the percentages in the inspector.

```cs
  [Percantage]
  [SerializeField] private float _chance;
```

![Percentages in the inspector](https://github.com/sha-255/ChanceEditor/blob/main/Recources/precentages-inspector.jpg?raw=true)

## PercentagesExtension

#### ToPercentages()

```cs
[float value].ToPercentages()
```

| Parameter | Type    | Description                          |
| :-------- | :------ | :----------------------------------- |
| `value`   | `float` | A value from 0 to 1 is **required**. |

#### ToProbability()

```cs
[int value].ToProbability()
```

| Parameter | Type  | Description                            |
| :-------- | :---- | :------------------------------------- |
| `value`   | `int` | A value from 0 to 100 is **required**. |

## Chance Wrapper

#### Wraps a serializable value in a wrapper with a manageable chance.

```cs
[SerializeField] private List<ChanceWrapper<GameObject>> _chanceObjects;

public void TrySetActive()
    => _chanceObjects.ForEach(wrapper
        => wrapper.Value.SetActive(wrapper.Calculate()));
```

| Generic Type | Description         |
| :----------- | :------------------ |
| `T`          | The original value. |

![wrapper inspector](https://github.com/sha-255/ChanceEditor/blob/main/Recources/wrapper-inspector.jpg?raw=true)
