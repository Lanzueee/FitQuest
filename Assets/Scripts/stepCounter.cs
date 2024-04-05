using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class stepCounter : MonoBehaviour
{
    public TextMeshProUGUI stepCountText;
    public TextMeshProUGUI isCountingText;
    private int stepCount;
    private bool isCounting;
    public float sensitivityThreshold = 0.005f; // Adjust this value to change sensitivity
    public float stepInterval = 0.05f; // Adjust this value to set the interval between steps
    private float lastStepTime;

    void Start()
    {
        lastStepTime = Time.time;
    }

    void Update()
    {
        // Only count steps if isCounting is true
        if (isCounting)
        {
            // Example: Detect a step based on accelerometer data
            Vector3 acceleration = Input.acceleration;

            // Check if the magnitude of acceleration exceeds the sensitivity threshold
            isCountingText.text = "Counting";
            if (acceleration.magnitude > sensitivityThreshold && Time.time - lastStepTime >= stepInterval)
            {
                lastStepTime = Time.time; // Update last step time
                stepCount++;
                UpdateStepCountUI();
            }
        }
    }

    void UpdateStepCountUI()
    {
        stepCountText.text = stepCount.ToString();
    }

    // Start the step counter
    public void StartStepCounter()
    {
        stepCount = 0; // Reset step count
        isCounting = true;
        lastStepTime = Time.time; // Reset last step time
        isCountingText.text = "Start";
        UpdateStepCountUI();
    }

    // Stop the step counter
    public void StopStepCounter()
    {
        isCounting = false;
        isCountingText.text = "Stopped";

    }
    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus && isCounting)
        {
            Application.backgroundLoadingPriority = ThreadPriority.High;

        }
        else
        {
            Application.backgroundLoadingPriority = ThreadPriority.Normal;

        }
    }
}
