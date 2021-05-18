using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using School_Management.Manager.Student.StudentEntitiesDataModel;

namespace School_Management.Manager.Student.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the StudentEntities data model.
    /// </summary>
    public partial class StudentEntitiesViewModel : DocumentsViewModel<StudentEntitiesModuleDescription, IStudentEntitiesUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of StudentEntitiesViewModel as a POCO view model.
        /// </summary>
        public static StudentEntitiesViewModel Create() {
            return ViewModelSource.Create(() => new StudentEntitiesViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the StudentEntitiesViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the StudentEntitiesViewModel type without the POCO proxy factory.
        /// </summary>
        protected StudentEntitiesViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override StudentEntitiesModuleDescription[] CreateModules() {
			return new StudentEntitiesModuleDescription[] {
                new StudentEntitiesModuleDescription( "Add Student", "Add_StudentCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Add_Student)),
                new StudentEntitiesModuleDescription( "Courses", "CourseCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Courses)),
                new StudentEntitiesModuleDescription( "Logins", "LoginCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Logins)),
                new StudentEntitiesModuleDescription( "Names", "NameCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Names)),
                new StudentEntitiesModuleDescription( "sysdiagrams", "sysdiagramCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.sysdiagrams)),
                new StudentEntitiesModuleDescription("Scores", "ScoreCollectionView", ViewsGroup),
			};
        }
                		protected override void OnActiveModuleChanged(StudentEntitiesModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class StudentEntitiesModuleDescription : ModuleDescription<StudentEntitiesModuleDescription> {
        public StudentEntitiesModuleDescription(string title, string documentType, string group, Func<StudentEntitiesModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}