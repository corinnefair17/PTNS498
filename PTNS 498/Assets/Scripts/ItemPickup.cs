using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;

    private void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.tag == "Player") {
            PickUp();
        }
    }

    private void PickUp() {
        Inventory.instance.Add(item);
        Destroy(gameObject);
    }
}
