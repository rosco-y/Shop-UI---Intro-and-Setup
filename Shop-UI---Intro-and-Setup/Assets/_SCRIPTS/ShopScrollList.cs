using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
[System.Serializable]
public class Item
{
    public string ItemName;
    public Sprite Icon;
    public decimal Price = 1m;
}


public class ShopScrollList : MonoBehaviour
{
    public List<Item> ItemList { get; set; }
    public Transform _contentPanel;
    public ShopScrollList _otherShop;
    public TMP_Text _myGoldDisplay;
    public SimpleObjectPool _buttonObjectPool;
    public decimal _gold = 20m;

    void Start()
    {
        _buttonObjectPool = new SimpleObjectPool();
    }

    public void RefreshDisplay()
    {
        AddButtons();
    }

    void AddButtons()
    {
        for (int i = 0; i < _itemList.Count; i++)
        {
            Item item = _itemList[i];
            SampleButton newButton = _buttonObjectPool.GetPutton();
            newButton.transform.SetParent(_contentPanel);
            newButton.Setup(item, this);
        }
    }

    void AddItem(Item item, ShopScrollList shopList)
    {
        shopList.ItemList.Add(item);
    }

}
