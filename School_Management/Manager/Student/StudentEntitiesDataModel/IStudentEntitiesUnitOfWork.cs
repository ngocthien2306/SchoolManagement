using DevExpress.Mvvm.DataModel;
using School_Management.Manager.Student;
using System;
using System.Collections.Generic;
using System.Linq;

namespace School_Management.Manager.Student.StudentEntitiesDataModel {

    /// <summary>
    /// IStudentEntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IStudentEntitiesUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Add_Student entities repository.
        /// </summary>
		IRepository<Add_Student, int> Add_Student { get; }
        
        /// <summary>
        /// The Course entities repository.
        /// </summary>
		IRepository<Course, int> Courses { get; }
        
        /// <summary>
        /// The Login entities repository.
        /// </summary>
		IRepository<Login, string> Logins { get; }
        
        /// <summary>
        /// The Name entities repository.
        /// </summary>
		IRepository<Name, string> Names { get; }
        
        /// <summary>
        /// The sysdiagram entities repository.
        /// </summary>
		IRepository<sysdiagram, int> sysdiagrams { get; }
        
        /// <summary>
        /// The Score entities repository.
        /// </summary>
		IReadOnlyRepository<Score> Scores { get; }
    }
}
