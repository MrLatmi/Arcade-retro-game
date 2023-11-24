using UnityEngine;

public class Platform : MonoBehaviour
{
    private Camera _camera;
    private void Start()
    {
        _camera = Camera.main;
        
    }
    private void Update()
    {
        // Получаем позицию мыши в мировых координатах
        Vector3 mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        if(mousePosition.y<-1.33)
        {
            transform.position = new Vector3(mousePosition.x+0.2f, mousePosition.y, transform.position.z);

        }

    }
}
