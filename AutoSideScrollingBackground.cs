using UnityEngine;

public class AutoSideScrollingBackground : MonoBehaviour
{
    public float scrollSpeed = 5f;
    public float resetPositionX = -10f; // Adjust based on your background size

    private void Update()
    {
        // Move the background to the left
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

        // Check if the background has moved out of view, then reposition it
        if (transform.position.x < resetPositionX)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        // Assuming the background is seamless, move it to the right to create an infinite scroll
        float backgroundWidth = 10f; // Adjust based on your background size
        Vector3 newPosition = new Vector3(backgroundWidth * 2f, 0f, 0f);
        transform.position += newPosition;
    }
}
