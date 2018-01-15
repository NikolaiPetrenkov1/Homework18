using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework18
{
    [Serializable]

    public class Book
    {
        [DisplayName("Имя книги")]
        public string Name { get; set; }
        [DisplayName("Цена")]
        public double Price { get; set; }
        [DisplayName("Автор")]
        public string Author { get; set; }
        public int Year { get; set; }

    }
}
