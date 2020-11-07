using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellController : MonoBehaviour
{
    public static Color BLACK = Color.black;
    public static Color TRANSPARENT = new Color(0, 0, 0, 0);
    
    SpriteRenderer SpriteRenderer;

    public void Awake() {
        SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        SpriteRenderer.color = TRANSPARENT;
    }

    private Color randomColor() {
        return UnityEngine.Random.ColorHSV(0, 1, 1, 1, 0, 1, 0.3f, 0.5f);
    }

    private void paint() {
        SpriteRenderer.color = BLACK;
    }

    private void erase() {
        SpriteRenderer.color = TRANSPARENT;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") {
            paint();
        }
    }
}
