﻿using System;
namespace API.Models
{
    public class Utilisateur
    {
        #region Paramètres

        /// <summary>
        /// Un Id pour chaque Utilisateur
        /// </summary>

        private int Id { get; set; }

        /// <summary>
        /// Un Etat Civile pour chaque Utilisateur (M = Monsieur / F = Madame)
        /// </summary>

        private char Civilitie { get; set; }

        /// <summary>
        /// Un Name pour chaque Utilisateur
        /// </summary>

        private string Name { get; set; }

        /// <summary>
        /// Un Firstame pour chaque Utilisateur
        /// </summary>

        private string Firstame { get; set; }

        /// <summary>
        /// Un Numero de Sécu pour chaque Utilisateur
        /// </summary>

        private string SecuNb { get; set; }

        /// <summary>
        /// Une Adresse pour chaque Utilisateur
        /// </summary>

        private Adress Adress { get; set; }

        #endregion

        #region constructor
        public Utilisateur(int id, char civilitie, string name, string firstame, string secuNb, Adress adress)
        {
            Id = id;
            Civilitie = civilitie;
            Name = name;
            Firstame = firstame;
            SecuNb = secuNb;
            Adress = adress;
        }
        #endregion


    }
}