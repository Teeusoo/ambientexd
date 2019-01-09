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

    public HUD hud;
    public GameOver gameOver;
}
