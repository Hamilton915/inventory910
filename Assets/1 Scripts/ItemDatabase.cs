using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{

    public List<Item> items = new List<Item>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        BuildDatabase();
    }

    void BuildDatabase()
    {
        items = new List<Item>()
        {
            new Item(0, "Diamond Sword", "A sword made of diamonds.",
            new Dictionary<string, int> {
                {"Power", 15},
                {"Defense", 10}
            }),
            new Item(1, "Diamond Ore", "A large peice of diamond.",
            new Dictionary<string, int>
            {
                {"Value", 300}
            }),
            new Item(0, "Silver Pickaxe", "A pickaxe made of silver.",
            new Dictionary<string, int> {
                {"Power", 5},
                {"Mining", 20}
            })

        };
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }


}
