using System;
using UnityEngine;


public class UIActionMode : MonoBehaviour
{
    [SerializeField] private UIHealthBar healthBarPlayer;
    [SerializeField] private UIHealthBar healthBarEnemy;
    [SerializeField] public GameObject Win;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private RectTransform reticle;
    [SerializeField] private HealthSo healthSo; //вот тут мы связали два игровых объекта через скриптовый
    [SerializeField] private HealthSo EnemyhealthSo;
    [SerializeField] private SimpleEvent playerDeathEvent;
    [SerializeField] private SimpleEvent enemyDeathEvent;
    [SerializeField] private GameObject reloadOnEscape;
    [SerializeField] private GameObject enemy;
    private void OnEnable()
    {
        // еще один способ связать объекты между собой. Довольно "хрупкий"
        playerDeathEvent.Subscribe(ShowDeathScreen);
        gameOverScreen.SetActive(false);

        //enemyDeathEvent.Unsubscribe(ShowWinScreen);
    }

    private void OnDisable()
    {
        playerDeathEvent.Unsubscribe(ShowDeathScreen);

        //enemyDeathEvent.Subscribe(ShowWinScreen);
        //Win.SetActive(false);
    }

    private void ShowDeathScreen()
    {
        gameOverScreen.SetActive(true);
        healthBarPlayer.gameObject.SetActive(false);
        healthBarEnemy.gameObject.SetActive(false);
        reticle.gameObject.SetActive(false);
        reloadOnEscape.gameObject.SetActive(true);

    }


    //private void ShowWinScreen()
    //{
    //    Win.SetActive(true);
    //    healthBarPlayer.gameObject.SetActive(false);
    //    healthBarEnemy.gameObject.SetActive(false);
    //    reticle.gameObject.SetActive(false);
    //    reloadOnEscape.gameObject.SetActive(true);
    //}

    private void Update()
    {
        
        //так как мы просто обращаеся к скриптовому объекту - даже обращение в апдейте безопасно и независимо.
        //Совсем правильно, конечно, сделать через события.
        healthBarPlayer.SetHealthBar(healthSo.GetFraction());
        healthBarEnemy.SetHealthBar(EnemyhealthSo.GetFraction());
    }

}