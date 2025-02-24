using UnityEngine;
using UnityEngine.UI;

public class BusScaler : MonoBehaviour
{
    public GameObject bus;
    public Slider slider;

    private void Awake()
    {
        bus.transform.localScale = new Vector3(1f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        float scaleValue = slider.value;
        bus.transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);

    }
}
