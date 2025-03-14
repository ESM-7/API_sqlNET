using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Document
{
    [Key] public int DocumentNode { get; set; }

    public short DocumentLevel { get; set; }

    [Required, StringLength(50)] public string Title { get; set; }

    [Required] public int Owner { get; set; }

    [Required] public bool FolderFlag { get; set; }

    [Required, StringLength(400)] public string FileName { get; set; }

    [Required, StringLength(8)] public string FileExtension { get; set; }

    [Required, StringLength(5)] public string Revision { get; set; }

    [Required] public int ChangeNumber { get; set; }

    [Required] public byte Status { get; set; }

    public string DocumentSummary { get; set; }

    public byte[] DocumentContent { get; set; }

    [Required] public Guid Rowguid { get; set; }

    [Required] public DateTime ModifiedDate { get; set; }
}
