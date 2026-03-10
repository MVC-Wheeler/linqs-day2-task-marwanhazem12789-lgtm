using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Author> authors = new List<Author>
            {
            new Author { Id = 1, Name = "Ahmed Khaled Tawfik" },
            new Author { Id = 2, Name = "Naguib Mahfouz" },
            new Author { Id = 3, Name = "Taha Hussein" }
            };

            List<Book> books = new List<Book>
            {
            new Book { Id = 1, Title = "Utopia", Pages = 250, AuthorId = 1 },
            new Book { Id = 2, Title = "Paranormal", Pages = 150, AuthorId = 1 },
            new Book { Id = 3, Title = "The Passage", Pages = 450, AuthorId = 2 },
            new Book { Id = 4, Title = "Palace Walk", Pages = 320, AuthorId = 2 },
            new Book { Id = 5, Title = "The Days", Pages = 200, AuthorId = 3 }
            };



            var q1 = books.Where(b => b.Pages > 300);


            var q2 = books.Where(b => b.AuthorId == 1);


            var q3 = books.Where(b => b.Pages >= 200 && b.Pages <= 350);


            var q4 = books.Where(b => b.Title.StartsWith("P"));


            var q5 = books.Select(b => b.Title);


            var q6 = books.Select(b => new { b.Title, b.Pages });


            var q7 = authors.Select(a => a.Name);


            var q8 = books.First(b => b.Pages > 300);


            var q9 = books.FirstOrDefault(b => b.AuthorId == 2);


            var q10 = authors.Single(a => a.Id == 3);


            var q11 = books.Single(b => b.Title == "Utopia");


            var q12 = books.OrderBy(b => b.Pages);


            var q13 = books.OrderByDescending(b => b.Title);


            var q14 = books.OrderBy(b => b.AuthorId).ThenBy(b => b.Pages);


            var q15 = books.Count();


            var q16 = books.Average(b => b.Pages);


            var q17 = books.Max(b => b.Pages);


            var q18 = books.Any(b => b.Pages > 400);


            var q19 = books.All(b => b.Pages > 100);


            var titles = books.Select(b => b.Title).ToList();


            var q20 = titles.Contains("Utopia");


            var q21 = books.Join(authors,
                b => b.AuthorId,
                a => a.Id,
                (b, a) => new
                {
                    BookTitle = b.Title,
                    AuthorName = a.Name,
                    Pages = b.Pages
                }
            );


            var q22 = books.Join(authors,
              b => b.AuthorId,
              a => a.Id,
              (b, a) => new
              {
                  BookTitle = b.Title,
                  AuthorName = a.Name,
                  Pages = b.Pages
              }
         );


          // q23 and q24 مش عارف اعملهم 


            var q25 = books.Take(3);

            var q26 = books.Skip(2);

            var q27 = books.Skip(2).Take(3);


            var q28 = books.TakeWhile(b => b.Pages < 300);

            var q29 = books.SkipWhile(b => b.Pages < 250);


            var q30 = books.Chunk(2);

            var q31 = books.Select(b => b.AuthorId).Distinct();


            var q32 = books.Where(b => b.Pages > 200).Union(books.Where(b => b.AuthorId == 2));

            var q34 = books.Where(b => b.Pages > 200).Intersect(books.Where(b => b.AuthorId == 2));

            var q35 = books.Where(b => b.Pages > 200).Except(books.Where(b => b.AuthorId == 2));

        }
    }
}
