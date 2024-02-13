using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Lesson1
{
    internal class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, String s, String c, uint m);
        static void Main(string[] args)
        {
            //1
            MessageBox(new IntPtr(0), "Здесь содержится информация о соискателе:\nперейти на следующую страницу", "РЕЗЮМЕ", 0);
            MessageBox(new IntPtr(0), "Нечипуренко Евгений Анатольевич\n09.07.1987\nг. Одесса", "РЕЗЮМЕ", 0);
            MessageBox(new IntPtr(0), "Закончить просмотр?", "РЕЗЮМЕ", 0);

            //2
            Random rand = new Random();
            while (MessageBox(new IntPtr(0), $"{rand.Next(1, 101)}", "ЭТО ЧИСЛО ВЫ ЗАГАДАЛИ?", 1) != 1 ? true : false);
        }
    }
}
