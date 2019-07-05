using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowItem : MonoBehaviour
{
    float span = 0.5f;

    [SerializeField]
    private GameObject[] Items;

    [SerializeField]
    private Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        span -= Time.deltaTime;
        if (span <= 0)
        {
            span = 0.5f;
            Throw();
        }
    }

    void Throw()
    {
        GameObject obj = Instantiate(Items[Random.Range(0, Items.Length-1)],parent);
        obj.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 2f);
    }
}
