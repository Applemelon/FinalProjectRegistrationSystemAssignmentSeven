using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectRegistrationSystemAssignmentSeven
{
    public interface IStudentRepository
    {
        Student Add(Student student);

        Student Get(int id));

        List<Student> Get();

        Student Update(Student student);

        Student Delete(int id);


    }
}
