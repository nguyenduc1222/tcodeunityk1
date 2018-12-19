using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour {


    public Color myColor = Color.red; 
    public MoveTo moveTo;
    public enum MoveTo
    {
        RIGHT, LEFT, UP, DOWN
    }

    private float x = 0;
    private float y = 0;

    // Use this for initialization
    void Start () {

         SpriteRenderer m_SpriteRenderer = this.GetComponent<SpriteRenderer>();
         m_SpriteRenderer.color = myColor;

        x = gameObject.transform.position.x;
        y = gameObject.transform.position.y;
    }


	

	// Update is called once per frame
	void Update() {

        switch (moveTo)

        {
            case MoveTo.RIGHT:

                if (gameObject.transform.position.x > 4) {
                    gameObject.transform.position = new Vector3(x, y, 1);
                }

                gameObject.transform.Translate(Vector3.right * 2 * Time.deltaTime);
                break;
            case MoveTo.LEFT:

                if (gameObject.transform.position.x < -4)
                {
                    gameObject.transform.position = new Vector3(x, y, 1);
                }

                gameObject.transform.Translate( - Vector3.right * 2 * Time.deltaTime);
                break;
            case MoveTo.UP:

                if (gameObject.transform.position.y > 4)
                {
                    gameObject.transform.position = new Vector3(x, y, 1);
                }

                gameObject.transform.Translate( Vector3.up * 2 * Time.deltaTime);
                break;
            case MoveTo.DOWN:

                if (gameObject.transform.position.y < -4)
                {
                    gameObject.transform.position = new Vector3(x, y, 1);
                }

                gameObject.transform.Translate( - Vector3.up * 2 * Time.deltaTime);
                break;
            default:
                // transform.Translate(Vector3.forward * 2 * Time.deltaTime);
                break;
        }

    }
}
