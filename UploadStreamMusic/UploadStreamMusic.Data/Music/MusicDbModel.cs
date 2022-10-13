using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploadStreamMusic.Data.Music
{
  public class MusicDbModel
  {
    public string Id { set; get; }
    public string Name { set; get; }
    public string Author { set; get; }
    public string Image { set; get; }
    public string Path { set; get; }

    internal class Map : IEntityTypeConfiguration<MusicDbModel>
    {
      public void Configure(EntityTypeBuilder<MusicDbModel> builder)
      {
        builder.ToTable("music");
        builder.Property(it => it.Id)
          .HasColumnName("id");
        builder.Property(it => it.Name)
          .HasColumnName("name");
        builder.Property(it => it.Author)
          .HasColumnName("author");
        builder.Property(it => it.Image)
          .HasColumnName("image");
        builder.Property(it => it.Path)
          .HasColumnName("path");
      }
    }

  }
}
