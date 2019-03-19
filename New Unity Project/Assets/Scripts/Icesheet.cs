using UnityEngine;

public class Icesheet : MonoBehaviour
{
    private float maxPosTop;
    private float minPosBottom;
    private float minInstantiateRange;
    private float maxInstantiateRange;

    public GameObject fish;

    public float speed;
    public int direction;
    public float minPosLeft;
    public float maxPosRight;
    public float padding;
    public float startx;
    public float fishPosX, fishPosY;

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
        fishPosX = 0f;
        fishPosY = 3f;
        minInstantiateRange = 1f;
        maxInstantiateRange = 5f;

        RandomInstantiateFishOnSheet();
    }

    private void RandomInstantiateFishOnSheet()
    {
        float rand = Random.Range(minInstantiateRange, maxInstantiateRange);
        if (rand > 2)
        {
            InstantiateFischOnSheet(GetFishPosition());
        }
    }

    public void InstantiateFischOnSheet(Vector2 icesheetPos)
    {
        GameObject go = Instantiate(fish, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity, this.transform);
        go.gameObject.transform.localPosition = GetFishPosition();
    }

    private Vector2 GetFishPosition()
    {
        return new Vector2(fishPosX, fishPosY);
    }

    private int SetUpDirection () 
    {
        int tempDirection = -1;

        if (gameObject.tag == "IcesheetLeft") 
        { 
            tempDirection = 1;
        }
        return tempDirection;
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
        transform.position = new Vector2(transform.position.x, newPosY);
    }

}
