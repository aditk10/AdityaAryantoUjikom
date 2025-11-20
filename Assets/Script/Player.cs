using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform CubeTransform;

    public Vector2 PosisiKlik;

    public GameObject spawnPeluru;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Geser Object Ke Mouse
        Debug.Log(Input.mousePosition);
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Debug.Log(worldMousePosition);
        // CubeTransform.position = worldMousePosition;
        // CubeTransform.position = Vector2.MoveTowards(CubeTransform.position, worldMousePosition, 0.3f);

        // Posisi minimum layar setelah diubah ke world point disimpan di variable minimum
        Vector2 minimum = Camera.main.ScreenToWorldPoint(new Vector3(0,0,0));

        // Posisi maximum layar setelah diubah ke world point disimpan di variable maksimum
        Vector2 maximum = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0,0));

        // membatasi maximal sumbu X
        worldMousePosition.x = Mathf.Clamp(worldMousePosition.x, minimum.x, maximum.x);
        worldMousePosition.y = -4.5f;

        // mengubah posisi objek
        CubeTransform.position = worldMousePosition;   

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Spawn Objek
            Instantiate(spawnPeluru, new Vector3(worldMousePosition.x, -4.5f ,0), Quaternion.identity);
        }
    }


}
