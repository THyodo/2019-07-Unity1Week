using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFitting : MonoBehaviour
{
    Sprite sprite;

    [SerializeField]
    FittingMode mode;

    float rate;

    enum FittingMode
    {
        Width,
        Height
    };

    private void Awake()
    {
        sprite = GetComponent<Sprite>();
        if (mode == FittingMode.Width)
        {
            float width = sprite.bounds.size.x;
            rate = Screen.width / width;
            transform.localScale = new Vector3(rate, 1, 1);
        }
        else
        {
            float height = sprite.bounds.size.y;
            rate = Screen.height / height;
            transform.localScale = new Vector3(1, rate, 1);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
