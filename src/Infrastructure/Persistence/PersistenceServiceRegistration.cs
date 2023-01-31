using Application.Repositories;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Configuration;
using Persistence.DataContext;
using Persistence.Repositories;

namespace Persistence.ServiceRegistration
{
    public static class PersistenceServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UniDbContext>(options => options.UseSqlServer(ConnectionStringConfiguration.connectionString));

            #region Repositories
            services.AddScoped<IAdvisorRepository, AdvisorRepository>();
            services.AddScoped<IAnnouncementRepository, AnnouncementRepository>();
            services.AddScoped<IAttendanceRepository, AttendanceRepository>();
            services.AddScoped<IBookstoreInventoryRepository, BookstoreInventoryRepository>();
            services.AddScoped<IBookstoreOrderRepository, BookstoreOrderRepository>();
            services.AddScoped<IClassRepository, ClassRepository>();
            services.AddScoped<IClubMembershipRepository, ClubMembershipRepository>();
            services.AddScoped<IClubRepository, ClubRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IDegreeRepository, DegreeRepository>();
            services.AddScoped<IDegreeRequirementRepository, DegreeRequirementRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IExamScoreRepository, ExamScoreRepository>();
            services.AddScoped<IFinancialAidRepository, FinancialAidRepository>();
            services.AddScoped<IHousingRepository, HousingRepository>();
            services.AddScoped<IMealPlanRepository, MealPlanRepository>();
            services.AddScoped<IResourceRepository, ResourceRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IProfilePictureRepository, ProfilePictureRepository>();
            #endregion
        }
    }
}
