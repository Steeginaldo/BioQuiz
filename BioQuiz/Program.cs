﻿using System;
using BioQuiz.Klassen;

namespace BioQuiz
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// Hello
        /// </summary>
        [STAThread]
        static void Main()
        {
            QuizSteuerung.init();
        }
    }
}
