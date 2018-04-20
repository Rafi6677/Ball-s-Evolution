using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_start_bonus : MonoBehaviour
{ 
    public GameObject ball_prefab;
    public Camera camera_prefab;
    public Light light_prefab;

    void Start()
    {
        GameObject ball = GameObject.Instantiate(ball_prefab);
        ball.name = "sphere";
        ball.transform.position = transform.position + Vector3.up * 2f;

        Camera camera = Camera.Instantiate(camera_prefab);
        Camera_controller_bonus cameraController_bonus = camera.GetComponent<Camera_controller_bonus>();
        cameraController_bonus.sphere = ball.transform;

        Light light = Light.Instantiate(light_prefab);
        light.color = Color.white;
        light.intensity = 0.5f;
        //RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
        RenderSettings.ambientLight = Color.white * 0.7f;
    }
}
