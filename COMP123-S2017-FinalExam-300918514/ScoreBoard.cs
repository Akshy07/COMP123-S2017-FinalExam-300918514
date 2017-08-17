using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Akshay Patel
 * Date: August 17, 2017
 * StudentID: 300918514
 * Description: This is the ScoreBoard class
 * Version-0.1 : Created a ScoreBoard class
 */

namespace COMP123_S2017_FinalExam_300918514
{
    public class ScoreBoard
    {
        // Private Instance Variables
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        // Public propertiess
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
                FinalScoreTextBox.Text = Convert.ToString(_score);
            }
        }
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
                _score = Convert.ToInt32(ScoreTextBox.Text);
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value; ;
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }


        // Methods
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            _scoreTextBox = scoreTextBox;
            _timeTextBox = timeTextBox;
            _finalScoreTextBox = finalScoreTextBox;
        }

        public void UpdateTime()
        {
            _time = Convert.ToInt32(TimeTextBox);
            TimeTextBox = TimeTextBox - 1;
        }
    }
}
