using Nardi.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nardi.ViewModels
{
    internal class MainWindowViewModel : ViewModel

    {
        #region WindowTitle

        private string _Title = "Нарды";
        /// <summary> WindowTitle </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion
    }

}