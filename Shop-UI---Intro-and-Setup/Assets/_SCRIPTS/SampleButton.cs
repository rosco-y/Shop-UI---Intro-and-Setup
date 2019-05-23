using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SampleButton : MonoBehaviour
{
    public Button _button;
    public TMP_Text _nameLabel;
    public TMP_Text _priceLabel;
    public Image _iconImage;
    Item _item;
    ShopScrollList _scrollList;
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    public void Setup(Item thisItem, ShopScrollList currentScrollList)
    {
        _item = thisItem;
        _scrollList = currentScrollList;

        _nameLabel.text = _item.ItemName;
        _priceLabel.text = $"{_item.Price:C}";
    }
}
