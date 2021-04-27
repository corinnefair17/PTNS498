using UnityEngine;

public class Inventory_UI : MonoBehaviour
{
    public Transform itemsParent;
    public Transform inventoryImage;

    Inventory inventory;

    InventorySlot[] slots;

    private bool pulledDown;

    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();

        pulledDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && !pulledDown) {
            inventoryImage.transform.localPosition = new Vector3 (0, 224, 0);
            pulledDown = true;
        } else if (Input.GetKeyDown(KeyCode.I) && pulledDown) {
            inventoryImage.transform.localPosition = new Vector3(0, 354, 0);
            pulledDown = false;
        }
    }

    void UpdateUI() {
        for (int i = 0; i < slots.Length; i++) {
            if (i < inventory.items.Count) {
                slots[i].AddItem(inventory.items[i]);
            } else {
                slots[i].ClearSlot();
            }
        }
    }
}
