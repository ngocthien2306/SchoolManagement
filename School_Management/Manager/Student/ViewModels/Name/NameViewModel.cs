using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using School_Management.Manager.Student.StudentEntitiesDataModel;
using School_Management.Manager.Student.Common;
using School_Management.Manager.Student;

namespace School_Management.Manager.Student.ViewModels {

    /// <summary>
    /// Represents the single Name object view model.
    /// </summary>
    public partial class NameViewModel : SingleObjectViewModel<Name, string, IStudentEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of NameViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static NameViewModel Create(IUnitOfWorkFactory<IStudentEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new NameViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the NameViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the NameViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected NameViewModel(IUnitOfWorkFactory<IStudentEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Names, x => x.Lastname) {
                }



    }
}
