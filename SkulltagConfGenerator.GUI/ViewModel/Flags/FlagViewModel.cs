using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using SkulltagConfGenerator.Domain.Extensions;
using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.Enumerations.Utils;
using SkulltagConfGenerator.GUI.Model;
using SkulltagConfGenerator.Domain.Model;

namespace SkulltagConfGenerator.GUI.ViewModel {
	public class FlagViewModel<ModelType, EnumType> : ViewModelBase where ModelType : Flag, new() {

		#region Fields

		private IFlagWrapper<EnumType> wrapper;
		private List<ModelType> flags;

		#endregion

		#region Properties
		
		public virtual int FlagsValue {
			get {
				int flag = 0;

				foreach(ModelType dmflag in this.flags.Where(x => x.IsEnabled)) {
					flag |= dmflag.Value;
				}

				return flag;
			}

			set {
				IEnumerable<IFlagWrapper<EnumType>> validFlags = this.wrapper.GetFlags(value);
				IEnumerable<string> splitFlagsAlternateNames = validFlags.Select(x => x.GetAlternateName());
				IEnumerable<ModelType> enabledFlags = this.flags.Where(flag => splitFlagsAlternateNames.Contains(flag.Name));

				foreach(ModelType flag in this.flags) {
					flag.IsEnabled = false;
				}

				foreach(var flag in enabledFlags) {
					flag.IsEnabled = true;
				}

				this.RaiseFlagsValuePropertyChange();
			}
		}

		public virtual IEnumerable<ModelType> FlagModel {
			get {
				return this.flags;
			}
		}

		#endregion

		public FlagViewModel(IFlagWrapper<EnumType> wrapper) {
			this.wrapper = wrapper;
			this.flags = new List<ModelType>(
				this.wrapper.GetAllFlags().Select(x => new ModelType() {
						Description = x.GetStringValue(),
						IsEnabled = false,
						Name = x.GetAlternateName(),
						Value = x.GetValue()
					}
				)		
			);
		}
	
		protected virtual void RaiseFlagsValuePropertyChange(object sender, PropertyChangedEventArgs e) {
			this.RaiseFlagsValuePropertyChange();
		}

		protected virtual void RaiseFlagsValuePropertyChange() {
			this.RaisePropertyChanged("FlagsValue");
		}
	}
}
