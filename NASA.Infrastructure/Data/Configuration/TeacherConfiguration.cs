﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NASA.Infrastructure.Data.Configuration
{
    internal class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(new Teacher()
            {
                Id = 1,
                Name = "Petyr",
                PhoneNumber = "+359888888888",
                Email = "Email@mail.com",
                UserId = "dea12856-c198-4129-b3f3-b893d8395082"
            });
        }
    }
}
