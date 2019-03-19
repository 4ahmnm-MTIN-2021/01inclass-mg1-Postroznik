using UnityEngine;

public class Icesheet : MonoBehaviour
{

    private float maxPosTop;
    private float minPosBottom;

    public float speed;
    public int direction;
    public float minPosLeft;
    public float maxPosRight;
    public float padding;
    public float startx;

    // Use this for initialization
    private void Start () 
    {
        speed = 1f;
        direction = SetUpDirection();
        minPosLeft = -7.5f;
        maxPosRight = 7.5f;
        minPosBottom = -6.4f;
        maxPosTop = 6.8f;
        padding = 2f;
    }
	
    private int SetUpDirection () 
    {
        if (gameObject.tag == "IcesheetLeft") 
        { 
            return 1;
        }
        else 
        {
            return -1;
        }
    }

    // Update is called once per frame
    void Update () 
    {
        if (gameObject.tag == "IcesheetUnderground")
        {
            MovePlatformToSky(speed, direction);
            return;
        }

        MovePlatform (speed, direction);	
	}

    public void MovePlatform (float mySpeed, int myDirection)
    {
        var deltaX = Time.deltaTime * speed * direction;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, minPosLeft, maxPosRight);
        transform.position = new Vector2(newPosX, transform.position.y);
    }

    public void MovePlatformToSky(float mySpeed, int myDirection)
    {
        var deltaY = Time.deltaTime * speed;
        var newPosY = Mathf.Clamp(transform.position.y + deltaY, minPosBottom, maxPosTop);
        Debug.Log(newPosY);
        transform.position = new Vector2(transform.position.x, newPosY);
    }

}
