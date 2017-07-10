﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioQuiz.Klassen;
using System.Windows.Forms;

namespace BioQuiz.Forms
{
    public partial class FragenEditor : Form
    {
        public FragenEditor()
        {
            InitializeComponent();
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuizSteuerung.onEvent(QuizSteuerung.EVENT_INDEX_CHANGE_EDIT);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            QuizSteuerung.onEvent(QuizSteuerung.EVENT_BUTTON_BACK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuizSteuerung.onEvent(QuizSteuerung.EVENT_BUTTON_NEW_QUESTION);
        }
    }
}
