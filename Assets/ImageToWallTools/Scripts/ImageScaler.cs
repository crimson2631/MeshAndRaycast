using UnityEngine;

public class ImageScaler : MonoBehaviour
{

    private Texture image;

    // Start is called before the first frame update
    void Awake()
    {
        image = GetComponent<MeshRenderer>().material.mainTexture;
        Vector2 scaleAmount = new Vector2(image.width, image.height).normalized;
        transform.localScale *= scaleAmount;
        transform.localScale += Vector3.forward;
    }
}
