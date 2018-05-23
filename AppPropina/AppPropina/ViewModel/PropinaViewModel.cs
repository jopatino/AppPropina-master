using System;
using System.Collections.Generic;
using System.Text;

namespace AppPropina.ViewModel
{
    using Model;
    using Xamarin.Forms;

    public class PropinaViewModel
    {
        #region propiedades
        public Propina PropinaModel { get; set; }
        public Command CalcularCommand { get; set; }
        #endregion
        #region Constructor
        public PropinaViewModel()
        {
            PropinaModel = new Propina();
            CalcularCommand = new Command(Calcular);
        }


        #endregion
        #region Metodos
        private void Calcular()
        {
            PropinaModel.PropinaTotal = (PropinaModel.Total * (PropinaModel.PorcentajePropina / 100));
            PropinaModel.TotalCuenta = PropinaModel.Total + PropinaModel.PropinaTotal;
            PropinaModel.PropinaPorPersona = PropinaModel.PropinaTotal / PropinaModel.Personas;
            PropinaModel.TotalPorPersona = PropinaModel.PropinaPorPersona + (PropinaModel.Total / PropinaModel.Personas);
        }
        #endregion
    }
}
