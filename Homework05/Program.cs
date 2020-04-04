using System;

namespace Homework05
{
    //Task 01 - PhotoAlbum 
    public class PhotoAlbum
    {
        public PhotoAlbum()
        {
            NumberOfPages = 16;
        }

        public PhotoAlbum(int numberOfPages)
        {
            NumberOfPages = numberOfPages;
        }

        private int NumberOfPages;

        public int GetNumberOfPages()
        {
            return NumberOfPages;
        }

    }

    public class BigPhotoAlbum
    {
        public int numberOfPages;
        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }
        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PhotoAlbum albumOne = new PhotoAlbum();
            Console.WriteLine(albumOne.GetNumberOfPages());

            PhotoAlbum albumTwo = new PhotoAlbum(24);
            Console.WriteLine(albumTwo.GetNumberOfPages());

            BigPhotoAlbum bigPhotoAlbum = new BigPhotoAlbum();
            Console.WriteLine(bigPhotoAlbum.GetNumberOfPages());

            Console.ReadLine();    

        }
    }
}