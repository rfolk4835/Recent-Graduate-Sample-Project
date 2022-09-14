using System.Text.Json;

namespace JSONparcer {
    public class Book {
        public string? isbn { get; set; }
        public string? title { get; set; }
        public string? subtitle { get; set; }
        public string? author { get; set; }
        public DateTime? published { get; set; }
        public string? publisher { get; set; }
        public int? pages { get; set; }
        public string description { get; set; }
        public string website { get; set; }
    }
    public class BookList {
        public List<Book>? books { get; set; }
    }
    public class parcer {
        public static void Main(string[] args) {
            string fileName = "data/data_model.json";
            string jsonString = File.ReadAllText(fileName);
            BookList books = JsonSerializer.Deserialize<BookList>(jsonString);

            List<Book> withDupes = books.books;
            List<Book> noDupes = withDupes.Distinct().ToList();
            string newJsonString = JsonSerializer.Serialize(noDupes);
            string newFileName = "data/data_model_noDupes.json";
            File.WriteAllText(newFileName, newJsonString);
        }
    }
}