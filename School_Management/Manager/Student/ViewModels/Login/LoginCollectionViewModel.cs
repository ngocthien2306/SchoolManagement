using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using School_Management.Manager.Student.StudentEntitiesDataModel;
using School_Management.Manager.Student.Common;
using School_Management.Manager.Student;

namespace School_Management.Manager.Student.ViewModels {

    /// <summary>
    /// Represents the Logins collection view model.
    /// </summary>
    public partial class LoginCollectionViewModel : CollectionViewModel<Login, string, IStudentEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of LoginCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static LoginCollectionViewModel Create(IUnitOfWorkFactory<IStudentEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new LoginCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the LoginCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the LoginCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected LoginCollectionViewModel(IUnitOfWorkFactory<IStudentEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Logins) {
        }
    }
}