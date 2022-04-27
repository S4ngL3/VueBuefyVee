using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Net5Template.Data
{
    /// <summary>
    /// A <see cref="DbContext" /> instance represents a session with the database and can be used to query and save instances of entities. 
    /// </summary>
    public partial class AppPosContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppPosContext"/> class.
        /// </summary>
        /// <param name="options">The options to be used by this <see cref="DbContext" />.</param>
        public AppPosContext(DbContextOptions<AppPosContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ChecklistDetailsItems"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ChecklistDetailsItems"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.ChecklistDetailsItems> ChecklistDetailsItems { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.ChecklistDetailsLocations> ChecklistDetailsLocations { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ChecklistFile"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ChecklistFile"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.ChecklistFile> ChecklistFiles { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ChecklistNotes"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ChecklistNotes"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.ChecklistNotes> ChecklistNotes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.CheckList"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.CheckList"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.CheckList> CheckLists { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ChecklistScore"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ChecklistScore"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.ChecklistScore> ChecklistScores { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.DMActive"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.DMActive"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.DMActive> DMActives { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.DMCategoryTask"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.DMCategoryTask"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.DMCategoryTask> DMCategoryTasks { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.DMItems"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.DMItems"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.DMItems> DMItems { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.DMJobType"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.DMJobType"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.DMJobType> DMJobTypes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.DMLifeCyclePGD"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.DMLifeCyclePGD"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.DMLifeCyclePGD> DMLifeCyclePGDs { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.DMRegion"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.DMRegion"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.DMRegion> DMRegions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.DMSysConfig"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.DMSysConfig"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.DMSysConfig> DMSysConfigs { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.DMUnit"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.DMUnit"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.DMUnit> DMUnits { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.FCoin"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.FCoin"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.FCoin> FCoins { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.FExchange"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.FExchange"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.FExchange> FExchanges { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.FGift"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.FGift"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.FGift> FGifts { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.FTransaction"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.FTransaction"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.FTransaction> FTransactions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.GameRules"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.GameRules"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.GameRules> GameRules { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.GroupTask"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.GroupTask"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.GroupTask> GroupTasks { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.HistoryImportFile"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.HistoryImportFile"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.HistoryImportFile> HistoryImportFiles { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ImportItems"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ImportItems"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.ImportItems> ImportItems { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.InventoryItems"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.InventoryItems"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.InventoryItems> InventoryItems { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.LifeCycleDetailsTask"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.LifeCycleDetailsTask"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.LifeCycleDetailsTask> LifeCycleDetailsTasks { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.LogWork"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.LogWork"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.LogWork> LogWorks { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.NotifyRealtime"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.NotifyRealtime"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.NotifyRealtime> NotifyRealtimes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.OrderItems"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.OrderItems"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.OrderItems> OrderItems { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.PgdWcDetails"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.PgdWcDetails"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.PgdWcDetails> PgdWcDetails { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.PgdWorkCalendar"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.PgdWorkCalendar"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.PgdWorkCalendar> PgdWorkCalendars { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.RegionDetailsGift"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.RegionDetailsGift"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.RegionDetailsGift> RegionDetailsGifts { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.Shifts"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.Shifts"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.Shifts> Shifts { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ShopItems"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ShopItems"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.ShopItems> ShopItems { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ShopOpen"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ShopOpen"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.ShopOpen> ShopOpens { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ShopScoreDaily"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.ShopScoreDaily"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.ShopScoreDaily> ShopScoreDailies { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.TaskDetailsItems"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.TaskDetailsItems"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.TaskDetailsItems> TaskDetailsItems { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.TaskDetailsQuantity"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.TaskDetailsQuantity"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.TaskDetailsQuantity> TaskDetailsQuantities { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.Task"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.Task"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.Task> Tasks { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.UserIds"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.UserIds"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.UserIds> UserIds { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.UserShop"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.UserShop"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.UserShop> UserShops { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.WCdetails"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.WCdetails"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.WCdetails> WCdetails { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.WorkCalendar"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="Net5Template.Data.Entities.WorkCalendar"/>.
        /// </value>
        public virtual DbSet<Net5Template.Data.Entities.WorkCalendar> WorkCalendars { get; set; }

        #endregion

        /// <summary>
        /// Configure the model that was discovered from the entity types exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on this context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.ChecklistDetailsItemsMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.ChecklistDetailsLocationsMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.ChecklistFileMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.CheckListMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.ChecklistNotesMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.ChecklistScoreMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.DMActiveMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.DMCategoryTaskMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.DMItemsMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.DMJobTypeMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.DMLifeCyclePGDMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.DMRegionMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.DMSysConfigMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.DMUnitMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.FCoinMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.FExchangeMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.FGiftMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.FTransactionMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.GameRulesMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.GroupTaskMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.HistoryImportFileMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.ImportItemsMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.InventoryItemsMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.LifeCycleDetailsTaskMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.LogWorkMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.NotifyRealtimeMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.OrderItemsMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.PgdWcDetailsMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.PgdWorkCalendarMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.RegionDetailsGiftMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.ShiftsMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.ShopItemsMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.ShopOpenMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.ShopScoreDailyMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.TaskDetailsItemsMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.TaskDetailsQuantityMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.TaskMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.UserIdsMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.UserShopMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.WCdetailsMap());
            modelBuilder.ApplyConfiguration(new Net5Template.Data.Mapping.WorkCalendarMap());
            #endregion
        }
    }
}
