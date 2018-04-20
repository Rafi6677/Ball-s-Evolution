using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_start : MonoBehaviour
{
    public GameObject ball_prefab;
    public Camera camera_prefab;
    public Light light_prefab;

    public Texture texture_0;
    public Texture texture_1;
    public Texture texture_2;
    public Texture texture_3;
    public Texture texture_4;
    public Texture texture_5;


    void Start ()
    {
        GameObject ball = GameObject.Instantiate(ball_prefab);
        ball.name = "sphere";
        ball.transform.position = transform.position + Vector3.up * 2f;

        Camera camera = Camera.Instantiate(camera_prefab);
        Camera_controller cameraController = camera.GetComponent<Camera_controller>();
        cameraController.sphere = ball.transform;

        Light light = Light.Instantiate(light_prefab);
        light.color = Color.white;
        light.intensity = 0.5f;
        //RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
        RenderSettings.ambientLight = Color.white * 0.7f;

        if (PlayerPrefs.GetInt("ball", 0) == 0)
        {
            ball.GetComponent<Renderer>().sharedMaterial.mainTexture = texture_0;
        }
        if(PlayerPrefs.GetInt("ball", 0) == 1)
        {
            ball.GetComponent<Renderer>().sharedMaterial.mainTexture = texture_1;
        }
        if (PlayerPrefs.GetInt("ball", 0) == 2)
        {
            ball.GetComponent<Renderer>().sharedMaterial.mainTexture = texture_2;
        }
        if(PlayerPrefs.GetInt("ball", 0) == 3)
        {
            ball.GetComponent<Renderer>().sharedMaterial.mainTexture = texture_3;
        }
        if (PlayerPrefs.GetInt("ball", 0) == 4)
        {
            ball.GetComponent<Renderer>().sharedMaterial.mainTexture = texture_4;
        }
        if (PlayerPrefs.GetInt("ball", 0) == 5)
        {
            ball.GetComponent<Renderer>().sharedMaterial.mainTexture = texture_5;
        }
    }

}
