//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor
//     https://github.com/msawczyn/EFDesigner
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Jellyfin.Data.Entities
{
   public partial class Group
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Group()
      {
         GroupPermissions = new System.Collections.Generic.HashSet<global::Jellyfin.Data.Entities.Permission>();
         ProviderMappings = new System.Collections.Generic.HashSet<global::Jellyfin.Data.Entities.ProviderMapping>();
         Preferences = new System.Collections.Generic.HashSet<global::Jellyfin.Data.Entities.Preference>();

         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static Group CreateGroupUnsafe()
      {
         return new Group();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="name"></param>
      /// <param name="_user0"></param>
      public Group(string name, global::Jellyfin.Data.Entities.User _user0)
      {
         if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
         this.Name = name;

         if (_user0 == null) throw new ArgumentNullException(nameof(_user0));
         _user0.Groups.Add(this);

         this.GroupPermissions = new System.Collections.Generic.HashSet<global::Jellyfin.Data.Entities.Permission>();
         this.ProviderMappings = new System.Collections.Generic.HashSet<global::Jellyfin.Data.Entities.ProviderMapping>();
         this.Preferences = new System.Collections.Generic.HashSet<global::Jellyfin.Data.Entities.Preference>();

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="name"></param>
      /// <param name="_user0"></param>
      public static Group Create(string name, global::Jellyfin.Data.Entities.User _user0)
      {
         return new Group(name, _user0);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Identity, Indexed, Required
      /// </summary>
      [Key]
      [Required]
      public int Id { get; protected set; }

      /// <summary>
      /// Required, Max length = 255
      /// </summary>
      [Required]
      [MaxLength(255)]
      [StringLength(255)]
      public string Name { get; set; }

      /// <summary>
      /// Concurrency token
      /// </summary>
      [Timestamp]
      public Byte[] Timestamp { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      public virtual ICollection<global::Jellyfin.Data.Entities.Permission> GroupPermissions { get; protected set; }

      public virtual ICollection<global::Jellyfin.Data.Entities.ProviderMapping> ProviderMappings { get; protected set; }

      public virtual ICollection<global::Jellyfin.Data.Entities.Preference> Preferences { get; protected set; }

   }
}
