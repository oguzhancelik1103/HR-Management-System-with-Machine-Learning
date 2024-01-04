﻿using EntityLayer.Concrete.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50);
            //builder.Property(x => x.FirstName).HasMaxLength(50);
            //builder.Property(x => x.LastName).HasMaxLength(50);
        }
    }
}
