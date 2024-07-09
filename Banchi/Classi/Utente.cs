﻿namespace Banchi.Classi
{
    public static class Utente
    {
        public enum RuoloUtente
        {
            SolaLettura,
            ModifichePersonali,
            ModificheAiModelli,
        }
        public static string Username { get; set; }
        public static RuoloUtente Accesso { get; set; }
        // ???? serviranno ????
        public static List<Classe> ClassiDellUtente { get; set; }
        public static List<Classe> AuleDellUtente { get; set; }
    }
}
