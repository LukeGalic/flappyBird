using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public Material myMaterial;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        myMaterial = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        myMaterial.mainTextureOffset += Vector2.right * speed * Time.deltaTime;
    }
}
