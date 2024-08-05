using ClassLibrary1;
using Microsoft.AspNetCore.Components;

namespace BlazorApp4.Pages
{
    public class EmployeListBase : ComponentBase
    {
        public IEnumerable<Employe> Employes { get; set; }

        protected override async Task OnInitializedAsync()
        {
           await Task.Run (LoadEmployes);
        }

        private void LoadEmployes()
        {
            System.Threading.Thread.Sleep(3000);

            Employe e1 = new Employe
            {
                 EmployeId = 1,
                 FirstName  = "Test",
                 LastName =  "hello",
                 Email =    "abgc@email.com",
                 DateOfBirth  = new DateTime(1998 , 1, 1),
                 Gender = Gender.Male,
                 DepartmentId  =  1 ,
                 PhotoPath = "image/aa1.jpg"
  };
            Employe e2 = new Employe

            {
                EmployeId = 2,
                FirstName = "ssest",
                LastName = "aallo",
                Email = "abgaaac@email.com",
                DateOfBirth = new DateTime(1998, 2, 1),
                Gender = Gender.Male,
                DepartmentId = 3,
                PhotoPath = "image/aa2.jpg"
            };
            Employe e3 = new Employe {
                EmployeId = 3,
                FirstName = "ssest",
                LastName = "aallo",
                Email = "abgaaac@email.com",
                DateOfBirth = new DateTime(1998, 2, 1),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "image/aa3.jfif"
            };
            Employe e4 = new Employe
            {
                EmployeId = 4,
                FirstName = "ssest",
                LastName = "aallo",
                Email = "abgaaac@email.com",
                DateOfBirth = new DateTime(1998, 2, 1),
                Gender = Gender.Male,
                DepartmentId = 4,
                PhotoPath = "image/aa2.jpg"
            };
            Employes = new List<Employe> { e1, e2, e3, e4 };        
        }
    }
}
