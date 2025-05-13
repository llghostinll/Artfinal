using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseParallax : MonoBehaviour
{
    
    Vector2 startPosition;

    [SerializeField] float moveModifier;
    
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float posX = Mathf.Lerp(transform.position.x, startPosition.x + (pz.x * moveModifier), 2f * Time.deltaTime);
        float posY = Mathf.Lerp(transform.position.y, startPosition.y + (pz.y * moveModifier), 2f * Time.deltaTime);

        transform.position = new Vector3(posX, posY, 0);
    }
}
