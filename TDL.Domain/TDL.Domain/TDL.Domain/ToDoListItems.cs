﻿namespace TDL.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TDL.Common.Enums;
    using TDL.Common.Interfaces;

    [Table("TodoListItems")]
    public class ToDoListItems : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        public Guid TodoListId { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public ToDoListStatusEnum Status { get; set; }
    }
}