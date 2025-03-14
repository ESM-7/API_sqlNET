using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Document
{
    [Key] public string DocumentNode { get; set; }
    [NotMapped] public int DocumentLevel => DocumentNode?.Split('/').Length - 1 ?? 0;
    [Required, MaxLength(50)] public string Title { get; set; }
    [ForeignKey("Employee")] public int Owner { get; set; }
    public bool FolderFlag { get; set; } = false;
    [Required, MaxLength(400)] public string FileName { get; set; }
    [Required, MaxLength(8)] public string FileExtension { get; set; }
    [Required, MaxLength(5)] public string Revision { get; set; }
    public int ChangeNumber { get; set; } = 0;
    [Range(1, 3)] public byte Status { get; set; }
    public string DocumentSummary { get; set; }
    public byte[] DocumentData { get; set; }
}
