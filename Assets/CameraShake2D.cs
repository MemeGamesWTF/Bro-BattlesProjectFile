using UnityEngine;
using System.Collections;

public class CameraShake2D : MonoBehaviour
{
    [Tooltip("Shake magnitude (max offset in world units)")]
    public float magnitude = 0.02f;
    [Tooltip("Shake update frequency (seconds between direction changes)")]
    public float frequency = 0.02f;

    private Vector3 originalPos;
    private Coroutine shakeCoroutine;

    public bool IsShaking = false;

    private void Awake()
    {
        originalPos = transform.localPosition;
    }

    private void Update()
    {
        if (IsShaking)
        {
            if (shakeCoroutine == null)
                shakeCoroutine = StartCoroutine(ContinuousShake());
        }
        else
        {
           
            if (shakeCoroutine != null)
            {
                StopCoroutine(shakeCoroutine);
                shakeCoroutine = null;
               // transform.localPosition = originalPos;
            }
        }
    }

    private IEnumerator ContinuousShake()
    {
        while (IsShaking)
        {
            float offsetX = Random.Range(-1f, 1f) * magnitude;
            float offsetY = Random.Range(-1f, 1f) * magnitude;
            transform.localPosition = originalPos + new Vector3(offsetX, offsetY, 0f);
            yield return new WaitForSeconds(frequency);
        }

        // Reset just in case
        transform.localPosition = originalPos;
        shakeCoroutine = null;
    }
}


    // toggle this elsewhere

