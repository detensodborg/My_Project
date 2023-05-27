using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PurchaseSystem : MonoBehaviour
{
    public GameObject ground;
    public GameObject[] itemPrefabs; // Array of item prefabs

    private Dropdown dropdown;

    private void Start()
    {
        dropdown = GetComponent<Dropdown>();
        dropdown.ClearOptions(); // Clear existing options

        // Create a list to hold the new options
        List<Dropdown.OptionData> newOptions = new List<Dropdown.OptionData>();

        // Loop through the item prefabs and create options for each
        for (int i = 0; i < itemPrefabs.Length; i++)
        {
            GameObject itemPrefab = itemPrefabs[i];
            string itemName = itemPrefab.name;

            // Create a new OptionData and assign the item name as its text
            Dropdown.OptionData option = new Dropdown.OptionData(itemName);
            newOptions.Add(option);
        }

        // Assign the new options to the dropdown
        dropdown.AddOptions(newOptions);

        // Add a listener to handle option selection
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    private void OnDropdownValueChanged(int index)
    {
        // Check if the selected option is within the array bounds
        if (index >= 0 && index < itemPrefabs.Length)
        {
            GameObject selectedItemPrefab = itemPrefabs[index];
            // Instantiate the selected item on the ground
            Instantiate(selectedItemPrefab, ground.transform.position, Quaternion.identity);
        }
    }
}
