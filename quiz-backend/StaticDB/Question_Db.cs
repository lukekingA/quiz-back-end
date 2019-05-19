using quiz_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quiz_backend.StaticDB
{
    public static class Question_Db
    {
        public static List<Question> Questions = new List<Question>()
        {
            new Question(101, "What is your name?"),
            new Question(102, "How old are you?"),
            new Question(103, "Where do you live?"),
            new Question(104, "Who are your parents?"),
            new Question(105, "Where were you born?"),
            new Question(106, "Do you have any siblings?"),
            new Question(107, "If so, how many?"),
        };

       // public static int newId ()
       // {
       //     return (Questions.Last<Question>.Id)++;
       // }
    
    }
}
