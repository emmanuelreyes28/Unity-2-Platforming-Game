using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public int score = 0;
    public int health = 100;
    public List<Collectable> inventory;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void ResetValues()
    {
        score = 0;
        health = 100;
        inventory.Clear();
    }
}
