using UnityEngine;

public class WallOpacity : MonoBehaviour
{
    public Camera camera;
    public Renderer[] wallRenderers;
    public float maxDistance = 10f;

    private Material[] wallMaterials;
    private float[] initialAlphas;

    private Shader opaqueShader;

    void Start()
    {
        wallMaterials = new Material[wallRenderers.Length];
        initialAlphas = new float[wallRenderers.Length];

        opaqueShader = Shader.Find("Standard");

        for (int i = 0; i < wallRenderers.Length; i++)
        {
            wallMaterials[i] = wallRenderers[i].material;
            initialAlphas[i] = wallMaterials[i].color.a;
        }
    }

    void Update()
    {
        Renderer[] closestRenderers = new Renderer[3];
        float[] closestDistances = new float[3];
        for (int i = 0; i < 3; i++)
        {
            closestRenderers[i] = null;
            closestDistances[i] = Mathf.Infinity;
        }

        for (int i = 0; i < wallRenderers.Length; i++)
        {
            float distance = Vector3.Distance(camera.transform.position, wallRenderers[i].transform.position);

            if (distance < maxDistance)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (distance < closestDistances[j])
                    {
                        for (int k = 2; k > j; k--)
                        {
                            closestDistances[k] = closestDistances[k - 1];
                            closestRenderers[k] = closestRenderers[k - 1];
                        }
                        closestDistances[j] = distance;
                        closestRenderers[j] = wallRenderers[i];
                        break;
                    }
                }
            }
        }

        for (int i = 0; i < wallRenderers.Length; i++)
        {
            bool isClosest = false;
            for (int j = 0; j < 3; j++)
            {
                if (wallRenderers[i] == closestRenderers[j])
                {
                    isClosest = true;
                    break;
                }
            }

            if (isClosest)
            {
                Color color = wallMaterials[i].color;
                color.a = Mathf.Lerp(color.a, 0.3f, Time.deltaTime);
                wallMaterials[i].SetColor("_Color", color);
            }
            else
            {
                Color color = wallMaterials[i].color;
                color.a = Mathf.Lerp(color.a, initialAlphas[i], Time.deltaTime);
                wallMaterials[i].SetColor("_Color", color);
            }
        }
    }
}
