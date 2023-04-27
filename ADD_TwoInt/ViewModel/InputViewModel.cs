using ADD_TwoInt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AddFunction;

namespace ADD_TwoInt.ViewModel
{
    public class InputViewModel:VMBase
    {
        private readonly Input _model;

        private readonly AddOperation _function;

        public InputViewModel()
        {
            _model= new Input();
            _function= new AddOperation();

        }

        public int input1
        {
            get => _model.a;
            set
            {
                 _model.a = value;
                OnPropertyChanged(nameof(input1));
            }
            

        }
        public int input2
        {
            get => _model.b;
            set
            {
                _model.b = value;
                OnPropertyChanged(nameof(input2));
            }
        }

        public int output3
        {
            get => _model.c;
            set
            {
                _model.c = value;
                OnPropertyChanged(nameof(output3));
            }
        }

        public ICommand AddCommand => new RelayCommand(AddNumbers);

        public void AddNumbers()
        {
            output3=AddOperation.Add(input1, input2);
        }
    }
}
