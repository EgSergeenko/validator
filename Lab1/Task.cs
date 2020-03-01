
namespace ValidationSystem
{
    /**
     * \brief Класс, который реализует логику задания, которое сдают студенты. 
     * 
     * Имеет конструктор и поле хранящее текст задания. 
     */
    public class Task
    {
        //! поле для хранения текста задания 
        public string Text;
        /** конструктор 
         * \param[in] text строка 
         */
        public Task(string text)
        {
            Text = text;
        }
    }
}
