using Core.Models;

namespace RecordsTuplesPolymorphismAbstractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Blog blog = new Blog();


            int choice;
            do
            {
                Console.WriteLine("1.Blog yarat");
                Console.WriteLine("0.Proqrami bitir!");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Blog basligi:");
                            string title = Console.ReadLine();
                            Console.WriteLine("Blog aciglamasi:");
                            string description = Console.ReadLine();

                            if(Helper.CheckBlogTitle(title) && Helper.CheckBlogDescription(description))
                            {
                                blog = new Blog(title, description);
                            }
                            int inChoice;
                            do
                            {
                                Console.WriteLine("1.Comment yarat");
                                Console.WriteLine("2. Commentlere bax");
                                Console.WriteLine("3. Commente bax");
                                Console.WriteLine("4. Commenti sil");
                                Console.WriteLine("5. Commenti guncele");
                                Console.WriteLine("0.Menyuya qayit");
                                if (int.TryParse(Console.ReadLine(), out inChoice))
                                {
                                    switch (inChoice)
                                    {
                                        case 1:
                                            Console.Write("Commentin contenti: ");
                                            string content = Console.ReadLine();
                                            Comment comment = new Comment(content);
                                            blog.AddComment(comment);
                                            Console.WriteLine("Comment elave olundu!");
                                            break;
                                        case 2:
                                            Console.WriteLine("Butun commentlere bax:");
                                            foreach (var a in blog.GetAllComments())
                                            {
                                                Console.WriteLine(a);
                                            }
                                            break;
                                    }
                            } while (true);

                            break;
                    }
                }
            } while (true);
        }
    }
}
