using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[Serializable]

public class UI {
	
	[Serializable]

	public class HUD{
			
	[Header("Text")]

	public Text TextCoin;
	public Text TextHeart;
	public Text TextTimer;

	[Header("Other")]

	public GameObject HUDPanel;

	}

    [Serializable]

    public class GameOver
    {

        [Header("Text")]

        public Text TextCoin;
        public Text TextTimer;

        [Header("Other")]

        public GameObject GameOverPanel;

    }

    [Serializable]

    public class LevelComplete
    {

        [Header("Text")]

        public Text TextCoin;
        public Text TextTimer;

        [Header("Other")]

        public GameObject LevelCompletePanel;

    }


    public HUD hud;
    public GameOver gameOver;
    public LevelComplete levelComplete;
}
