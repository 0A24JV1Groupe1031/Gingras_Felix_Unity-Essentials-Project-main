using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Public variable to set the duration of a full day in seconds
    public float dayDuration = 60f;

    // Variable to keep track of the elapsed time
    private float elapsedTime = 0f;

    void Update()
    {
        // Increment the elapsed time by the time passed since the last frame
        elapsedTime += Time.deltaTime;

        // Calculate the rotation angle based on the elapsed time and day duration
        float rotationAngle = (elapsedTime / dayDuration) * 360f;

        // Apply the rotation to the Directional Light
        transform.rotation = Quaternion.Euler(rotationAngle, 0f, 0f);

        // If the elapsed time exceeds the day duration, reset it
        if (elapsedTime >= dayDuration)
        {
            elapsedTime -= dayDuration;
        }
    }
}