using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DataStructure
{
    public class Question
    {
        public string text;
        public List<Options> options;
        public int questionId;

        public Question(string text, List<Options> options, int questionId)
        {
            this.text = text;
            this.options = options;
            this.questionId = questionId;
        }
    }
    
    public class Options
    {
        public string text;
        public int optionId;
        public int nextQuestionIdToDisplay; // Any option with 0 as it's nextQuestionId does not have a question that follows

        public Options(string text, int optionId, int nextQuestionId)
        {
            this.text = text;
            this.optionId = optionId;
            this.nextQuestionIdToDisplay = nextQuestionId;
        }
    }

    public class QFlow
    {
        public List<Question> questions = new List<Question> {
            new Question("What is your name", new List<Options> {
                new Options("Q1 opt1 -> Q2", 1, 0),
                new Options("Q1 opt2 -> Q3", 2, 3),
                new Options("Q1 opt3 -> default", 3, 0),
            }, 1),

            new Question("Question 2", new List<Options> {
                new Options("Q2 opt1 -> default", 4, 0),
                new Options("Q2 opt2 -> Q3", 5, 6),
                new Options("Q2 opt3 -> default", 6, 0),
            }, 2),

            new Question("Question 3", new List<Options> {
                new Options("Q3 opt1 -> default", 7, 0),
                new Options("Q3 opt2 -> default", 8, 0),
                new Options("Q3 opt3 -> Q7", 9, 7),
            }, 3),

            new Question("Question 4", new List<Options> {
                new Options("Q4 opt1 -> Q5", 10, 5),
                new Options("Q4 opt2 -> default", 11, 0),
                new Options("Q4 opt3 -> default", 12, 0),
            }, 4),

            new Question("Question 5", new List<Options> {
                new Options("Q5 opt1 -> Q6", 13, 0),
                new Options("Q5 opt2 -> Q7", 14, 0),
                new Options("Q5 opt3 -> default", 15, 0),
            }, 5),

            new Question("Question 6", new List<Options> {
                new Options("Q6 opt1 -> default", 16, 0),
                new Options("Q6 opt2 -> default", 17, 0),
                new Options("Q6 opt3 -> default", 18, 0),
            }, 6),

            new Question("Question 7", new List<Options> {
                new Options("Q7 opt1 -> default", 19, 0),
                new Options("Q7 opt2 -> default", 20, 0),
                new Options("Q7 opt3 -> default", 21, 0),
            }, 7),
        };

        public List<Question> questionsFromDb = new List<Question>();
        public int currentOptionSelected = 0;

        public QFlow()
        {
            this.questionsFromDb = questions;
        }

        public void Main()
        {
            int questionsLeftToAnswer = questionsFromDb.Count;
            int startingPoint = 0;
            while(startingPoint < questionsFromDb.Count)
            {
                Question question = questionsFromDb[startingPoint];
                if (questionsVisited.Contains(question.questionId))
                {
                    Next();
                }
                else
                {
                    Console.WriteLine(question.text);
                    for (int j = 0; j < question.options.Count; j++)
                    {
                        Options option = question.options[j];
                        Console.WriteLine("{0}. {1}", (j + 1), option.text);
                    }

                    Console.Write("Select answer by typing option Id: ");
                    int optionIdSelected = int.Parse(Console.ReadLine());

                    questionsVisited.Add(question.questionId);

                    startingPoint++;
                }

            }
        }


        public void Previous(int questionId)
        {

        }

        public void Next()
        {

        }

        public void SelectedOption(int optionId)
        {
            currentOptionSelected = optionId;
        }

        HashSet<int> questionsVisited = new HashSet<int>();

    }
}
