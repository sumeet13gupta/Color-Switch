using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject rings;
    public float respawnTime = 1f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void spawnrings()
    {
        GameObject a = Instantiate(rings) as GameObject;
        a.transform.position = new Vector2(0f, screenBounds.y * 2);
    }
    // Update is called once per frame
    void Update()
    {
     
    }
}
