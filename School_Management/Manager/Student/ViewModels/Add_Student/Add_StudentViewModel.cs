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
    /// Represents the single Add_Student object view model.
    /// </summary>
    public partial class Add_StudentViewModel : SingleObjectViewModel<Add_Student, int, IStudentEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Add_StudentViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Add_StudentViewModel Create(IUnitOfWorkFactory<IStudentEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Add_StudentViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Add_StudentViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Add_StudentViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Add_StudentViewModel(IUnitOfWorkFactory<IStudentEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Add_Student, x => x.lastname) {
                }



    }
}
