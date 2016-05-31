﻿using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class LevelUtil
{
    public static string[] ENG_CHARS = { "a", "i", "u", "e", "o", "ka", "ki", "ku", "ke", "ko", "sa", "shi", "su", "se", "so", "ta", "chi", "tsu", "te", "to", "na", "ni", "nu", "ne", "no", "ha", "hi", "fu", "he", "ho", "ma", "mi", "mu", "me", "mo", "ra", "ri", "ru", "re", "ro", "ya", "yu", "yo", "wa", "wo", "n" };
    public static string[] HIRA_CHARS = { "あ", "い", "う", "え", "お", "か", "き", "く", "け", "こ", "さ", "し", "す", "せ", "そ", "た", "ち", "つ", "て", "と", "な", "に", "ぬ", "ね", "の", "は", "ひ", "ふ", "へ", "ほ", "ま", "み", "む", "め", "も", "ら", "り", "る", "れ", "ろ", "や", "ゆ", "よ", "わ", "を", "ん" };
    public static string[] KATA_CHARS = { "ア", "イ", "ウ", "エ", "オ", "カ", "キ", "ク", "ケ", "コ", "サ", "シ", "ス", "セ", "ソ", "タ", "チ", "ツ", "テ", "ト", "ナ", "ニ", "ヌ", "ネ", "ノ", "ハ", "ヒ", "フ", "ヘ", "ホ", "マ", "ミ", "ム", "メ", "モ", "ラ", "リ", "ル", "レ", "ロ", "ヤ", "ユ", "ヨ", "ワ", "ヲ", "ン" };

    private static List<Level> levels; //hold all levels data

    public static void Init()
    {
        //level 1
        int index = 0;
        string name = "Level " + index;
        List<string> answer = new List<string>(new[] { "a", "i", "u", "e", "o" });
        List<string> questions = new List<string>(new[] { "あ", "い", "う", "え", "お" });
        int downPoint = -1000000;
        int upPoint = 0;
        int hintPoint = 0;
        int enemyEachWaveCount = 4;
        float waveWait = 5;
        float spawnWait = 4;
        bool isRotate = false;
        bool isFaster = false;

        Level level0 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        index += 1;
        name = "Level " + index;
        downPoint = 0;
        upPoint = 200;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;

        Level level1 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 2
        answer = new List<string>(new[] { "ka", "ki", "ku", "ke", "ko" });
        questions = new List<string>(new[] { "か", "き", "く", "け", "こ" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 400;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level2 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 3
        answer = new List<string>(new[] { "a", "i", "u", "e", "o", "ka", "ki", "ku", "ke", "ko" });
        questions = new List<string>(new[] { "あ", "い", "う", "え", "お", "か", "き", "く", "け", "こ" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 700;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level3 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 4
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 1000;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = true;
        isFaster = true;
        Level level4 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 5
        answer = new List<string>(new[] { "sa", "shi", "su", "se", "so" });
        questions = new List<string>(new[] { "さ", "し", "す", "せ", "そ" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 1200;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level5 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 6
        answer = new List<string>(new[] { "ta", "chi", "tsu", "te", "to" });
        questions = new List<string>(new[] { "た", "ち", "つ", "て", "と" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 1400;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level6 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 7
        answer = new List<string>(new[] { "sa", "shi", "su", "se", "so", "ta", "chi", "tsu", "te", "to" });
        questions = new List<string>(new[] { "さ", "し", "す", "せ", "そ", "た", "ち", "つ", "て", "と" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 1700;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level7 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 8
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 2000;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = true;
        isFaster = true;
        Level level8 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 9
        answer = new List<string>(new[] { "a", "i", "u", "e", "o", "ka", "ki", "ku", "ke", "ko", "sa", "shi", "su", "se", "so", "ta", "chi", "tsu", "te", "to" });
        questions = new List<string>(new[] { "", "", "", "", "" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 2500;
        hintPoint = downPoint + 100;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level9 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 10
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 3000;
        hintPoint = downPoint + 100;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = true;
        isFaster = true;
        Level level10 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 11
        answer = new List<string>(new[] { "na", "ni", "nu", "ne", "no" });
        questions = new List<string>(new[] { "", "", "", "", "" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 3200;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level11 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 12
        answer = new List<string>(new[] { "ha", "hi", "fu", "he", "ho" });
        questions = new List<string>(new[] { "", "", "", "", "" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 3400;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level12 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 13
        answer = new List<string>(new[] { "na", "ni", "nu", "ne", "no", "ha", "hi", "fu", "he", "ho" });
        questions = new List<string>(new[] { "", "", "", "", "" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 3700;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level13 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 14
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 4000;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = true;
        isFaster = true;
        Level level14 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 15
        answer = new List<string>(new[] { "ma", "mi", "mu", "me", "mo" });
        questions = new List<string>(new[] { "", "", "", "", "" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 4200;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level15 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 16
        answer = new List<string>(new[] { "ra", "ri", "ru", "re", "ro" });
        questions = new List<string>(new[] { "", "", "", "", "" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 4400;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level16 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 17
        answer = new List<string>(new[] { "ma", "mi", "mu", "me", "mo", "ra", "ri", "ru", "re", "ro" });
        questions = new List<string>(new[] { "", "", "", "", "" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 4700;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level17 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 18
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 5000;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = true;
        isFaster = true;
        Level level18 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 19
        answer = new List<string>(new[] { "na", "ni", "nu", "ne", "no", "ha", "hi", "fu", "he", "ho", "ma", "mi", "mu", "me", "mo", "ra", "ri", "ru", "re", "ro" });
        questions = new List<string>(new[] { "", "", "", "", "" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 5500;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level19 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 20
        answer = new List<string>(new[] { "na", "ni", "nu", "ne", "no", "ha", "hi", "fu", "he", "ho", "ma", "mi", "mu", "me", "mo", "ra", "ri", "ru", "re", "ro" });
        questions = new List<string>(new[] { "", "", "", "", "" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 6000;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = true;
        isFaster = true;
        Level level20 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 21
        answer = new List<string>(new[] { "ya", "yu", "yo" });
        questions = new List<string>(new[] { "", "", "", "" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 6200;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level21 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 22
        answer = new List<string>(new[] { "wa", "wo", "n" });
        questions = new List<string>(new[] { "", "", "" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 6400;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level22 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 23
        answer = new List<string>(new[] { "ya", "yu", "yo", "wa", "wo", "n" });
        questions = new List<string>(new[] { "", "", "", "", "", "" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 6700;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level23 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 24
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 7000;
        hintPoint = downPoint + 50;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = true;
        isFaster = true;
        Level level24 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 25
        answer = new List<string>(new[] { "a", "i", "u", "e", "o", "ka", "ki", "ku", "ke", "ko", "sa", "shi", "su", "se", "so", "ta", "chi", "tsu", "te", "to", "na", "ni", "nu", "ne", "no", "ha", "hi", "fu", "he", "ho", "ma", "mi", "mu", "me", "mo", "ra", "ri", "ru", "re", "ro", "ya", "yu", "yo", "wa", "wo", "n" });
        questions = new List<string>(new[] { "", "", "", "" });
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 8500;
        hintPoint = downPoint + 100;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level25 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //level 26, hiragana final
        index += 1;
        name = "Level " + index;
        downPoint = upPoint;
        upPoint = 10000;
        hintPoint = downPoint + 100;
        enemyEachWaveCount = 4;
        waveWait = 5;
        spawnWait = 4;
        isRotate = false;
        isFaster = false;
        Level level26 = new Level(index, name, questions, answer, downPoint, upPoint, hintPoint, enemyEachWaveCount, waveWait, spawnWait, isRotate, isFaster);

        //push all level to levels
        levels =
            new List<Level>(new Level[]
            {
                level0, level1, level2, level3, level4, level5, level6, level7, level8, level9, level10, level11, level12, level13,
                level14, level15, level16, level17, level18, level19, level20, level21, level22, level23, level24,
                level25, level26 });
    }


    public static Level DownLevel(Level currentLevel)
    {
        if (currentLevel.GetIndex() <= 0)
        {
            return levels.First();
        }
        return levels[currentLevel.GetIndex() - 1];
    }

    public static Level UpLevel(Level currentLevel)
    {
        if (currentLevel.GetIndex() >= levels.Count - 1)
        {
            return levels.Last();
        }
        return levels[currentLevel.GetIndex() + 1];
    }

    public static Level GetLevel(int index)
    {
        if (index <= 0)
        {
            return levels.First();
        }
        if (index >= levels.Count - 1)
        {
            return levels.Last();
        }
        return levels[index];
    }
}
