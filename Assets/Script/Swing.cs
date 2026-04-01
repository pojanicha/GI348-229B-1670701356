using UnityEngine;

public class Swing : MonoBehaviour
{
    [SerializeField] private float swingSpeed = 1f;
    [SerializeField] private float swingAngle = 30f;

    private float currentAngle = 0f;
    private float timer;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * swingSpeed;
        float angle = Mathf.Sin(timer) * this.swingAngle;
        transform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, angle + currentAngle));
    }
}
