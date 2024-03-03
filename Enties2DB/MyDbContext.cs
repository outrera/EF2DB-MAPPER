using Match.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class MyDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public MyDbContext(DbContextOptions<MyDbContext> options, IConfiguration configuration) 
        : base(options) 
    {
        _configuration = configuration;
    }

           // Agrega aquí otras DbSets para tus entidades

        public DbSet<Audit> Audit { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Agent> Agent { get; set; }
        public DbSet<Local> Local { get; set; }
        public DbSet<TicketOffice> TicketOffice { get; set; }

        public DbSet<Currency> Currency { get; set; }
        public DbSet<AgentCurrency> AgentCurrency { get; set; }
        public DbSet<UserBackOffice> UserBackOffice { get; set; }
        public DbSet<Operator> Operator { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Balance> Balance { get; set; }
        public DbSet<TransactionType> TransactionType { get; set; }
        public DbSet<TicketNumberReference> TicketNumberReference { get; set; }
        public DbSet<AmountType> AmountType { get; set; }
        public DbSet<BalanceBonus> BalanceBonus { get; set; }

        public DbSet<Rol> Rol { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<RolPermission> RolPermission { get; set; }
        public DbSet<UserBackOfficePermission> UserBackOfficePermission { get; set; }
        public DbSet<IntegrationsCredentials> IntegrationsCredentials { get; set; }
        public DbSet<Commission> Commission { get; set; }
        // public DbSet<Domain.Dto.Report.ReportDetail> ReportDetail { get; set; }
        // public DbSet<Domain.Dto.Report.ReportProvidersDetail> ReportProvidersDetail { get; set; }

        //orlandito

        public DbSet<BankingInstitution> BankingInstitution { get; set; }
        public DbSet<BankingAccount> BankingAccount { get; set; }
        public DbSet<AccountTransactionType> AccountTransactionType { get; set; }
        public DbSet<AccountTransaction> AccountTransaction { get; set; }
        public DbSet<AccountTransactionState> AccountTransactionState { get; set; }
        public DbSet<AccountTransactionMovement> AccountTransactionMovement { get; set; }
        public DbSet<MeanPayment> MeanPayment { get; set; }
        public DbSet<BankingInstitutionType> BankingInstitutionType { get; set; }
        public DbSet<BankingAccountType> BankingAccountType { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        Console.WriteLine("La base de datos y las entidades han sido creadas.");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21)));
    }
}