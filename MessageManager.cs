using System;
using System.Collections.Generic;

namespace MesajlasmaProjesi
{
    public static class MessageManager
    {
        public static List<(int ID, DateTime Tarih, string Mesaj)> AllMessages = new();

        public static void AddMessage(string mesaj)
        {
            AllMessages.Add((AllMessages.Count + 1, DateTime.Now, mesaj));
        }

        public static List<(int ID, DateTime Tarih, string Mesaj)> GetMessages()
        {
            return AllMessages;
        }
    }
}
