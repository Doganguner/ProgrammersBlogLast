
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace ProgrammersBlog.Services.Utilities
{
    public static class Messages
    {
        public static class Category
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir kategori bulunamadı";
                return "Böyle bir katagori bulunamadı";
            }

            public static string Add(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla eklenmiştir.";
            }

            public static string Update(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla güncellenmiştir.";
            }

            public static string Delete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla silinmiştir."
            }

            public static string HardDelete(string categoryName)
            {
                return $"{categoryName} a adlı kategori başarıyla veritabanından silinmiştir.");
            }
        }

        public static class Article
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Makaleler bulunamadı";
                return "Böyle bir makale bulunamadı";
            }

            public static string Add(string categoryName)
            {
                return $"{categoryName} adlı makale başarıyla eklenmiştir.";
            }

            public static string Update(string categoryName)
            {
                return $"{categoryName} adlı makale başarıyla güncellenmiştir.";
            }

            public static string Delete(string categoryName)
            {
                return $"{categoryName} adlı makale başarıyla silinmiştir."
            }

            public static string HardDelete(string categoryName)
            {
                return $"{categoryName} a adlı makale başarıyla veritabanından silinmiştir.";
            }
        }
    }
}
