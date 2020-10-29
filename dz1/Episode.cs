using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo ("Program")]

namespace dz1
{
    internal class Episode
    {
        private int numofviewers;
        public double SumOfGrades;
        public double MaxScore;
        private double score;



        public void AddView(double score)
        {
            numofviewers++;
            SumOfGrades += score;
            this.score = score;

        }
        public double GetMaxScore()
        {

            if (MaxScore < score)
            {
                MaxScore = score;

            }
            return MaxScore;

        }

        public double GetAverageScore()
        {
            return SumOfGrades / numofviewers;
        }
        public int GetViewerCount()
        {
            return numofviewers;
        }




        public Episode(int viewers, double grades, double mscore)
        {
            numofviewers = viewers;
            SumOfGrades = grades;
            MaxScore = mscore;


        }

        public Episode()
        {
            numofviewers = 0;
            SumOfGrades = 0;
            MaxScore = 0;
        }

    }
}
