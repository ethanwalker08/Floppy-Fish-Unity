using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleGenerateScript : MonoBehaviour
{
    public GameObject bubble;
    public float spawnRate;
    public float timer = 0;
    public float heightOffset = 10;
    public float widthOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnBubbles();
    }

    // Update is called once per frame
    void Update()
    {
        spawnBubbles();
    }

    void spawnBubbles()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(bubble, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
            timer = 0;
        }
    }
}
