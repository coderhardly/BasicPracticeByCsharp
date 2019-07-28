namespace EfCodeFirstTest
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using static EfCodeFirstTest.Program;

    public class CodeFirst : DbContext
    {
        
        public CodeFirst()
            : base("name=CodeFirst")
        {
             
       }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

    }

}