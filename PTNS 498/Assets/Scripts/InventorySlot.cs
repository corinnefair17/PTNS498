using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    Item item;
    public Image icon;

    public void AddItem (Item newItem) {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
        Debug.Log("Adding Item");
    }

    public void ClearSlot() {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }
}
