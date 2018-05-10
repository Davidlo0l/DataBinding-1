﻿namespace DataBinding
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    public class Datos:Notificable
    {
        private ObservableCollection <Persona> personas;
        private Persona personaSeleccionada;
        #region Propiedades
        public ObservableCollection <Persona> Personas
        {
            get
            {
                return personas;
            }
            set
            {
                if (personas == value)
                {
                    return;
                }
                personas = value;
                OnPropertyChanged();
            }
           
        }


        public Persona PersonaSeleccionada
        {
            get
            {
                return personaSeleccionada;
            }
            set
            {
                if (personaSeleccionada == value)
                {
                    return;
                        }
                personaSeleccionada = value;
                OnPropertyChanged();
            } 
        }
        #endregion

        #region Constructores
        public Datos()
        {
            var aleatorio = new Random();
            Personas = new ObservableCollection<Persona>();
            for (int i =0; i<5; i++)
            {
                personas.Add(new Persona()
                {
                    Nombre = $"Persona {i}",
                    Pais = $"Pais {i}",
                    Saldo = (decimal)(aleatorio.Next(100, 5000) * 3.1416),
                    FechaNacimiento = new DateTime(1980+i, i+1, 1) 
                });
            }
        }
        #endregion


    }
}
