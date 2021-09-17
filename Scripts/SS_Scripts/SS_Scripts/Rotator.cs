using UnityEngine;
using UnityEngine.InputSystem;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public float angleStep = 45;

    private float targetRotation;
    private static float currentRotation;

    private bool isRotating;
    public static float CurrentRotation{
        get{return currentRotation;}
}
    // Start is called before the first frame update
    void Start()
    {
        targetRotation = 0;
        currentRotation = 0;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Keyboard.current.leftArrowKey.isPressed) { targetRotation += angleStep; isRotating = true; }
        if (Keyboard.current.rightArrowKey.isPressed) { targetRotation -= angleStep; isRotating = true; }
        if (isRotating)
        {
            currentRotation = Mathf.Lerp(currentRotation, targetRotation, rotationSpeed * Time.deltaTime);

            if (Mathf.Abs(currentRotation - targetRotation) < 0.1f)
            {
                currentRotation = targetRotation;
                isRotating = false;
            }

            transform.eulerAngles = Vector3.forward * currentRotation;
        }
    }

    public void onRotate()
    {
        

    }
}
