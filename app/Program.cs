using System.Text.Json;

namespace JSONparcer {
    public class BookList {
        public List<Book> list { get; set; }
    }
    public class Book {
        public string isbn { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public string author { get; set; }
        public string published { get; set; }
        public string publisher { get; set; }
        public int pages { get; set; }
        public string description { get; set; }
        public string website { get; set; }
    }
    public class parcer {
        public static void Main(string[] args) {
            string fileName = "data/data_model.json";
            string jsonString = File.ReadAllText(fileName);
            BookList books = new JsonSerializer().Deserialize<BookList>(jsonString);

            foreach( var item in books.list) {
                Console.WriteLine("isbn: {0}", item.isbn);
            }
        }
    }
}