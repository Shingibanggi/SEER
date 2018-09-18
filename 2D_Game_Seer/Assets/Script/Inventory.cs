using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inventory : MonoBehaviour , IHasChanged{

    [SerializeField] Transform slots;
    [SerializeField] Text inventoryText;
    [SerializeField] GameObject done;
    [SerializeField] AudioSource bgm;

    public void HasChanged()
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        builder.Append(" - ");
        foreach (Transform slotTransform in slots){
            GameObject item = slotTransform.GetComponent<Slot>().item;
            if(item){
                builder.Append(item.name);
                builder.Append(" - ");
            }
        }
        inventoryText.text = builder.ToString();
        if (string.Equals(builder.ToString(), (" - sample - sample - sample - ")))
        {
            bgm.volume = 0;
            done.SetActive(true);
        }
    }

    // Use this for initialization
    void Start () {
        HasChanged();
	}
	
}

namespace UnityEngine.EventSystems{
    public interface IHasChanged : IEventSystemHandler{
        void HasChanged();
    }
}