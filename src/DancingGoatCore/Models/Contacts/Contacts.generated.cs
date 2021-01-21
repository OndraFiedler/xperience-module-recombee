//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using CMS;
using CMS.Base;

using CMS.DocumentEngine.Types.DancingGoatCore;

[assembly: RegisterDocumentType(Contacts.CLASS_NAME, typeof(Contacts))]

namespace CMS.DocumentEngine.Types.DancingGoatCore
{
    /// <summary>
    /// Represents a content item of type Contacts.
    /// </summary>
    public partial class Contacts : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DancingGoatCore.Contacts";


		/// <summary>
		/// The instance of the class that provides extended API for working with Contacts fields.
		/// </summary>
		private readonly ContactsFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// Gets an object that provides extended API for working with Contacts fields.
		/// </summary>
		[RegisterProperty]
		public ContactsFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Contacts fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class ContactsFields : AbstractHierarchicalObject<ContactsFields>
		{
			/// <summary>
			/// The content item of type Contacts that is a target of the extended API.
			/// </summary>
			private readonly Contacts mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="ContactsFields" /> class with the specified content item of type Contacts.
			/// </summary>
			/// <param name="instance">The content item of type Contacts that is a target of the extended API.</param>
			public ContactsFields(Contacts instance)
			{
				mInstance = instance;
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Contacts" /> class.
		/// </summary>
		public Contacts() : base(CLASS_NAME)
		{
			mFields = new ContactsFields(this);
		}

		#endregion
	}
}