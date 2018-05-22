using AppPropina.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPropina.Model
{
   public class Propina : Notificable
    {
        #region atributos
        private double total;
        private int personas;
        private double propinaTotal;
        private double totalPorPersona;
        private double propinaPorPersona;
        private double porcentajePropina;
        private double totalCuenta;
        #endregion
       

        public double Total
        {
            get {
                return total;
            }
            set {
                if (total == value)
                {
                    return;
                }
                total = value;
                OnPropertyChanged();
            }
        }
 

        public int Personas
        {
            get {
                return personas;
            }
            set {
                if (personas == value)
                {
                    return;
                }
                personas = value;
                OnPropertyChanged();
            }
        }
    

        public double PropinaTotal
        {
            get {
                return propinaTotal;
            }
            set {
                if (propinaTotal == value)
                {
                    return;
                }
                propinaTotal = value;
                OnPropertyChanged();
            }
        }
        public double TotalPorPersona
        {
            get
            {
                return totalPorPersona;
            }
            set {
                if (totalPorPersona == value)
                {
                    return;
                }
                totalPorPersona = value;
                OnPropertyChanged();
            }
        }
        public double PropinaPorPersona
        {
            get
            {
                return propinaPorPersona;
            }
            set {
                if (propinaPorPersona == value)
                {
                    return;
                }
                propinaPorPersona = value;
                OnPropertyChanged();  
            }
        }
        public double PorcentajePropina
        {
            get
            {
                return porcentajePropina;
            }
            set {
                if (porcentajePropina == value)
                {
                    return;
                }
                porcentajePropina = value;
                OnPropertyChanged();
            }
        }
        public double TotalCuenta
        {
            get
            {
                return totalCuenta;
            }
            set {
                if (totalCuenta == value)
                {
                    return;
                }
                totalCuenta = value;
                OnPropertyChanged();
                
            }
        }
    }
}
