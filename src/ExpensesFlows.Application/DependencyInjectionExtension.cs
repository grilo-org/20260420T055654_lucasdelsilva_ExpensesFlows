using ExpensesFlows.Application.AutoMapper;
using ExpensesFlows.Application.UseCases.Expenses.Delete;
using ExpensesFlows.Application.UseCases.Expenses.GetAll;
using ExpensesFlows.Application.UseCases.Expenses.GetById;
using ExpensesFlows.Application.UseCases.Expenses.Register;
using ExpensesFlows.Application.UseCases.Expenses.Reports.Excel;
using ExpensesFlows.Application.UseCases.Expenses.Reports.Pdf;
using ExpensesFlows.Application.UseCases.Expenses.Update;
using ExpensesFlows.Application.UseCases.Login.DoLogin;
using ExpensesFlows.Application.UseCases.Users.ChangePassword;
using ExpensesFlows.Application.UseCases.Users.Delete;
using ExpensesFlows.Application.UseCases.Users.Profile;
using ExpensesFlows.Application.UseCases.Users.Register;
using ExpensesFlows.Application.UseCases.Users.Update;
using Microsoft.Extensions.DependencyInjection;

namespace ExpensesFlows.Application;
public static class DependencyInjectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddAutoMapper(services);
        AddUseCases(services);
    }

    private static void AddAutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(cfg => cfg.AddProfile<AutoMapping>());
    }

    private static void AddUseCases(IServiceCollection services)
    {
        services.AddScoped<IRegisterExpenseUseCase, RegisterExpenseUseCase>();
        services.AddScoped<IGetAllExpenseUseCase, GetAllExpenseUseCase>();
        services.AddScoped<IGetExpenseByIdUseCase, GetExpenseByIdUseCase>();
        services.AddScoped<IDeleteExpenseUseCase, DeleteExpenseUseCase>();
        services.AddScoped<IUpdateExpenseUseCase, UpdateExpenseUseCase>();
        services.AddScoped<IGenerateExpensesReportExcelUseCase, GenerateExpensesReportExcelUseCase>();
        services.AddScoped<IGenerateExpensesReportPdfUseCase, GenerateExpensesReportPdfUseCase>();
        services.AddScoped<IRegisterUserUseCase, RegisterUserUseCase>();
        services.AddScoped<IDoLoginUseCase, DoLoginUseCase>();
        services.AddScoped<IGetUserProfileUseCase, GetUserProfileUseCase>();
        services.AddScoped<IUpdateUserUseCase, UpdateUserUseCase>();
        services.AddScoped<IChangePasswordUseCase, ChangePasswordUseCase>();
        services.AddScoped<IDeleteUserAccountUseCase, DeleteUserAccountUseCase>();
    }
}
