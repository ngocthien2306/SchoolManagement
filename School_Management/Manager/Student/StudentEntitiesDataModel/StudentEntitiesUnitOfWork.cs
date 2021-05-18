using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using School_Management.Manager.Student;
using System;
using System.Collections.Generic;
using System.Linq;

namespace School_Management.Manager.Student.StudentEntitiesDataModel {

    /// <summary>
    /// A StudentEntitiesUnitOfWork instance that represents the run-time implementation of the IStudentEntitiesUnitOfWork interface.
    /// </summary>
    public class StudentEntitiesUnitOfWork : DbUnitOfWork<StudentEntities>, IStudentEntitiesUnitOfWork {

        public StudentEntitiesUnitOfWork(Func<StudentEntities> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Add_Student, int> IStudentEntitiesUnitOfWork.Add_Student {
            get { return GetRepository(x => x.Set<Add_Student>(), (Add_Student x) => x.id); }
        }

        IRepository<Course, int> IStudentEntitiesUnitOfWork.Courses {
            get { return GetRepository(x => x.Set<Course>(), (Course x) => x.Id); }
        }

        IRepository<Login, string> IStudentEntitiesUnitOfWork.Logins {
            get { return GetRepository(x => x.Set<Login>(), (Login x) => x.Username); }
        }

        IRepository<Name, string> IStudentEntitiesUnitOfWork.Names {
            get { return GetRepository(x => x.Set<Name>(), (Name x) => x.Firstname); }
        }

        IRepository<sysdiagram, int> IStudentEntitiesUnitOfWork.sysdiagrams {
            get { return GetRepository(x => x.Set<sysdiagram>(), (sysdiagram x) => x.diagram_id); }
        }

        IReadOnlyRepository<Score> IStudentEntitiesUnitOfWork.Scores {
            get { return GetReadOnlyRepository(x => x.Set<Score>()); }
        }
    }
}
