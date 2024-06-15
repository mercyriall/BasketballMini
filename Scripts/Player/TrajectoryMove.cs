using UnityEngine;

public class TrajectoryMove : MonoBehaviour
{
    private LineRenderer _lineRendererComponent;

    private void Start()
    {
        _lineRendererComponent = GetComponent<LineRenderer>();
    }

    public void ShowTrajectory(Vector2 origin, Vector2 speed)
    {
        _lineRendererComponent.enabled = true;

        Vector3[] points = new Vector3[100];
        _lineRendererComponent.positionCount = points.Length;

        for (int i = 0; i < points.Length; i++)
        {
            float time = i * 0.1f;

            points[i] = origin + speed * time + Physics2D.gravity * time * time / 2f;

            if (points[i].y < -5f || points[i].x > 2.8f || points[i].x < -2.8f)
            {
                _lineRendererComponent.positionCount = i;
                break;
            }
        }

        _lineRendererComponent.SetPositions(points);
    }

    public void HideTrajectory()
    {
        _lineRendererComponent.enabled = false;
    }
}

