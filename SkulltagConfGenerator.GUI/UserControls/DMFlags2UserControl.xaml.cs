using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SkulltagConfGenerator.GUI.ViewModel;
using SkulltagConfGenerator.GUI.Model;
using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.Domain.Model;

namespace SkulltagConfGenerator.GUI.UserControls {
	/// <summary>
	/// Interaction logic for DMFlags2UserControl.xaml
	/// </summary>
	public partial class DMFlags2UserControl : UserControl {
		public DMFlags2UserControl() {
			InitializeComponent();

			this.DataContext = new FlagViewModel<DMFlag2, DMFlags2>(new DMFlags2Wrapper());
		}
	}
}
