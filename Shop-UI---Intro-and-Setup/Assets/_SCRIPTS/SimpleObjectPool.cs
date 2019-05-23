using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleObjectPool : MonoBehaviour
{

    Stack<SampleButton> _buttonPool;

    public SampleButton _prefab;

    private void Awake()
    {
        _buttonPool = new Stack<SampleButton>();
    }

    public SampleButton GetPutton()
    {
        if (_buttonPool.Count == 0)
            CreateNewButtonsForPool(1);
        return _buttonPool.Pop();

    }

    void CreateNewButtonsForPool(int count)
    {
        for (int i = 0; i < count; i++)
        {
            SampleButton newObj = Instantiate(_prefab);
            _buttonPool.Push(newObj);
        }
        return;
    }

    public void ReturnButtonToPool(SampleButton button)
    {
        _buttonPool.Push(button);
        return;
    }

}
