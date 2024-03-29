using UnityEngine;

public class CarLineRenderer : MonoBehaviour
{
    public Transform Sensor;
    public Transform Cross;
    private LineRenderer LineRenderer;

    private void Start()
    {
        LineRenderer = GetComponent<LineRenderer>();
        LineRenderer.positionCount = 2;
        LineRenderer.textureMode = LineTextureMode.RepeatPerSegment;
    }

    private void Update()
    {
        if (LineRenderer != null)
        {
            LineRenderer.SetPosition(0, new Vector3(1, 1, 1));
            LineRenderer.SetPosition(1, new Vector3(3, 3, 3));
        }
    }
}