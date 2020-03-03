using System;
using System.Collections.Generic;
using System.Linq;


namespace ValidationSystem
{
    /** \brief Класс, реализующий работу системы проверки.  
     * 
     * Имеет поля для хранения списка студентов, их результатов, а так же методы для проверки заданий и отображения результатов. 
     */
    public class Validator
    {
        //! поле для хранения списков студентов, которые сдали задания
        private List<Student> _students = new List<Student>();
        //! поле для хранения результатов проверки
        private List<bool> _results = new List<bool>();
        //! правильный ответ на задание 
        private string RightAnswer;
        /** Конструктор 
         * \param[in] rightanswer строка с правильным ответом 
         */
        public Validator(string rightanswer)
        {
            RightAnswer = rightanswer;
        }
        /** Добавление нового студента. Реализована проверка на уникальнсть.
         * \param[in] student студент для добавления 
         */
        public void AddStudent(Student student)
        {
            bool unique = true;
            for (int i = 0; i < _students.Count(); i++)
            {
                if (_students[i] == student)
                {
                    unique = false;
                    break;
                }
            }
            if (unique)
            {
                _students.Add(student);
                _results.Add(false);
            }
        }
        public void DeleteStudent(Student student)
        {
            for (int i = 0; i < _students.Count(); i++)
            {
                if (_students[i].Id == student.Id)
                {
                    _students.RemoveAt(i);
                    _results.RemoveAt(i);
                }
            }
        }
        /** Проверка задания студента
         * \param[in] student студент для проверки
         */
        public void Validate(Student student)
        {
            for (int i = 0; i < _students.Count(); i++)
            {
                if (_students[i].Id == student.Id)
                {
                    if (student.Task.Text == RightAnswer)
                    {
                        _results[i] = true;
                    }
                }
            }
        }
        /** Проверка заданий всех имеющихся в системе студентов.
         */
        public void ValidateAll()
        {
            for (int i = 0; i < _students.Count(); i++)
            {
                if (_students[i].Task.Text == RightAnswer)
                {
                    _results[i] = true;
                }
            }
        }
        /** Метод возвращющий наличие студента в сисетеме и правильность его задания 
         * \param[in] student студент для проверки 
         * \param[out] existence существование студента в системе 
         * \param[out] success результат проврки задания 
         * \return кортеж из двух boolean
         */
        public Tuple<bool, bool> Check(Student student)
        {
            bool existence = false;
            bool success = false;
            for (int i = 0; i < _students.Count(); i++)
            {
                if (_students[i].Id == student.Id)
                {
                    existence = true;
                    success = _students[i].Task.Text == RightAnswer;

                }
            }
            return Tuple.Create(existence, success);
        }
    }
}
