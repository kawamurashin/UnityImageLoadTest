using UnityEngine;
using System.Collections;

public class CardScript : MonoBehaviour {
    SpriteRenderer spriteRender;
    public void setTexture(Texture2D texture)
    {
        Sprite sp = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0, 0));
        spriteRender.sprite = sp;
    }
    void Awake()
    {
       Transform transform = this.transform.FindChild("New Sprite");
       spriteRender = (SpriteRenderer)transform.GetComponent("SpriteRenderer");
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 vector = this.transform.position;
        vector.x += 0.1f - 0.2f * Random.value;
        vector.y += 0.1f - 0.2f * Random.value;
        this.transform.position = vector;

    }
}
