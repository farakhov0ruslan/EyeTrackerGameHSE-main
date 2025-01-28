using UnityEngine;
using System.Collections;
using System.Linq;
using Unity.VisualScripting;

public class MouseGenerator : MonoBehaviour
{
    public GameObject[] mousePrefabs; // Префаб мыши
    public GameObject[] spawnPoints; // Массив точек, из которых мыши будут появляться
    public float spawnInterval = 4f; // Интервал между появлениями мышей
    public float moveSpeed = 0.2f; // Скорость перемещения
    [SerializeField] private StateGame stateGame;


    void Start()
    {
        StartCoroutine(SpawnMice());
    }

    // ReSharper disable Unity.PerformanceAnalysis
    IEnumerator SpawnMice()
    {
        while (true)
        {
            if (stateGame.State != State.Gameplay)
            {
                continue;
            }

            // Выбираем случайную точку из массива spawnPoints
            int randomIndex = Random.Range(0, spawnPoints.Length);
            // Цикл который отвечает за выбор свободной точки спавна.
            Debug.Log("Пытаемся создать мышь");
            while (!spawnPoints[randomIndex].GetComponent<MiceController>().mice.IsUnityNull())
            {
                if (spawnPoints.All(x => !x.GetComponent<MiceController>().mice.IsUnityNull()))
                {
                    yield return new WaitForSeconds(1f);
                }

                randomIndex = Random.Range(0, spawnPoints.Length);
            }

            Debug.Log("Создали мышь");

            Transform spawnPoint = spawnPoints[randomIndex].transform;

            // Создаем индекс для выбора случайной мыши.
            int randomIndexMouse = Random.Range(0, mousePrefabs.Length);
            Vector3 mouseSpawnPos = spawnPoint.position;
            mouseSpawnPos.z += 1; // Смещаем мышь чуть выше.
            GameObject mouseSpawn = mousePrefabs[randomIndexMouse];
            float mouseHight = mouseSpawn.GetComponent<SpriteRenderer>().size.y;
            mouseSpawnPos.y += mouseHight / 15;
            var mice = Instantiate(mousePrefabs[randomIndexMouse], mouseSpawnPos, Quaternion.identity);
            spawnPoints[randomIndex].GetComponent<MiceController>().mice = mice;
            var smoothMovementCoord =
                new Vector3(mouseSpawnPos.x, mouseSpawnPos.y + mouseHight / 8, mouseSpawnPos.z);
            mice.transform.position = Vector3.Lerp(mouseSpawnPos, smoothMovementCoord, moveSpeed);

            // Ждем spawnInterval секунд перед следующим появлением мыши
            yield return new WaitForSeconds(spawnInterval);
        }
    }
    
}