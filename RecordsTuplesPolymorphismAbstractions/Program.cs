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
                Console.WriteLine("1. Blog elave et:");
                Console.WriteLine("0. Programi bitir!");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Blog basligi:");
                            string title = Console.ReadLine();
                            Console.Write("Blog aciglamasi:");
                            string description = Console.ReadLine();

                            if (Helper.CheckBlogTitle(title) && Helper.CheckBlogDescription(description))
                            {
                                blog = new Blog(title, description);
                                Console.WriteLine("Blog yaradildi!");

                                int inChoice;
                                do
                                {
                                    Console.WriteLine("1.1 Comment yarat:");
                                    Console.WriteLine("1.2 Commentlere bax:");
                                    Console.WriteLine("1.3 Commente bax:");
                                    Console.WriteLine("1.4 Commenti sil:");
                                    Console.WriteLine("1.5 Commenti guncellesdir:");
                                    Console.WriteLine("0. Menyuya qayit:");

                                    if (int.TryParse(Console.ReadLine(), out inChoice))
                                    {
                                        switch (inChoice)
                                        {
                                            case 1:
                                                Console.Write("Commentin mezmunu: ");
                                                string content = Console.ReadLine();
                                                Comment comment = new Comment(content);
                                                blog.AddComment(comment);
                                                Console.WriteLine("Comment elave edildi!");
                                                break;
                                            case 2:
                                                Console.WriteLine("Butun commentler:");
                                                foreach (var c in blog.GetAllComments())
                                                {
                                                    Console.WriteLine(c);
                                                }
                                                break;
                                            case 3:
                                                Console.Write("Comment-in id-si: ");
                                                int commentId = int.Parse(Console.ReadLine());
                                                var selectedComment = blog.GetComment(commentId);
                                                if (selectedComment != null)
                                                    Console.WriteLine(selectedComment);
                                                else
                                                    Console.WriteLine("Comment tapilmadi!");
                                                break;
                                            case 4:
                                                Console.Write("Commentin idsi: ");
                                                int removeId = int.Parse(Console.ReadLine());
                                                blog.RemoveComment(removeId);
                                                Console.WriteLine("Comment silindi!");
                                                break;
                                            case 5:
                                                Console.Write("Commentin idsi: ");
                                                int updateId = int.Parse(Console.ReadLine());
                                                Console.Write("Yeni comment movzusu: ");
                                                string newContent = Console.ReadLine();
                                                Comment updatedComment = new Comment(newContent);
                                                blog.UpdateComment(updateId, updatedComment);
                                                Console.WriteLine("Comment yenilendi!");
                                                break;
                                            case 0:
                                                break;
                                            default:
                                                Console.WriteLine("Duzgun secim edilmeyib!");
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Düzgün seçim edilmədi.");
                                    }
                                } while (inChoice != 0);
                            }
                            else
                            {
                                Console.WriteLine("Baslig 5-den boyuk olmalidir ve aciglama 8-den boyuk olmalidir!");
                            }
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Sehv secim edildi!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Sehv secim edilib!");
                }
            } while (choice != 0);
        }
    }
}