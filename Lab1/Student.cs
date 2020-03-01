using System;

namespace ValidationSystem
{
    /**
     * \brief Класс, который реализует логику студента.
     * 
     * У каждого сутдента есть уникальный Id. 
     * Также в полях класса хранится задание студента и его имя. В
     * классе реализован конструктор и метод, который "выполняет" задание.
     */
    public class Student
    {
        //! поле для хранения имени 
        public string Name;
        //! глобальный Id
        public Guid Id;
        //! поле для хранения задания 
        public Task Task;
        
        /**
         * Конструктор
         * \param[in] name строка с именем
         */

        public Student(string name)
        {
            Id = new Guid();
            Name = name;
        }

        /**
         * Задает значение поля Task.
         * \param[in] text строка, из которой будет сегенерирован task
         * \param[out] Task новое значение поля 
         */
        public void DoTask(string text)
        {
            Task = new Task(text);
        }
    }
}
