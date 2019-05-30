using System.Data.Entity.Core.Metadata.Edm;

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set Name = 'Pay as you Go' where DurationInMonths = 0");
            Sql("update MembershipTypes set Name = 'Monthly' where DurationInMonths = 1");
            Sql("update MembershipTypes set Name = 'Quarterly' where DurationInMonths = 3");
            Sql("update MembershipTypes set Name = 'Yearly' where DurationInMonths = 12");
        }
        
        public override void Down()
        {
        }
    }
}
