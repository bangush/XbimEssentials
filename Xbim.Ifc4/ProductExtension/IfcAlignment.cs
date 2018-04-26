// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAlignment
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAlignment : IIfcPositioningElement
	{
		IfcAlignmentTypeEnum? @PredefinedType { get;  set; }
		IIfcAlignment2DHorizontal @Horizontal { get;  set; }
		IIfcAlignment2DVertical @Vertical { get;  set; }
		IfcLabel? @LinearRefMethod { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IfcAlignment", 1330)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAlignment : IfcPositioningElement, IInstantiableEntity, IIfcAlignment, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcAlignment>
	{
		#region IIfcAlignment explicit implementation
		IfcAlignmentTypeEnum? IIfcAlignment.PredefinedType { 
 
			get { return @PredefinedType; } 
			set { PredefinedType = value;}
		}	
		IIfcAlignment2DHorizontal IIfcAlignment.Horizontal { 
 
 
			get { return @Horizontal; } 
			set { Horizontal = value as IfcAlignment2DHorizontal;}
		}	
		IIfcAlignment2DVertical IIfcAlignment.Vertical { 
 
 
			get { return @Vertical; } 
			set { Vertical = value as IfcAlignment2DVertical;}
		}	
		IfcLabel? IIfcAlignment.LinearRefMethod { 
 
			get { return @LinearRefMethod; } 
			set { LinearRefMethod = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAlignment(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcAlignmentTypeEnum? _predefinedType;
		private IfcAlignment2DHorizontal _horizontal;
		private IfcAlignment2DVertical _vertical;
		private IfcLabel? _linearRefMethod;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 20)]
		public IfcAlignmentTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 8);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 21)]
		public IfcAlignment2DHorizontal @Horizontal 
		{ 
			get 
			{
				if(_activated) return _horizontal;
				Activate();
				return _horizontal;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _horizontal = v, _horizontal, value,  "Horizontal", 9);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 22)]
		public IfcAlignment2DVertical @Vertical 
		{ 
			get 
			{
				if(_activated) return _vertical;
				Activate();
				return _vertical;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _vertical = v, _vertical, value,  "Vertical", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 23)]
		public IfcLabel? @LinearRefMethod 
		{ 
			get 
			{
				if(_activated) return _linearRefMethod;
				Activate();
				return _linearRefMethod;
			} 
			set
			{
				SetValue( v =>  _linearRefMethod = v, _linearRefMethod, value,  "LinearRefMethod", 11);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
                    _predefinedType = (IfcAlignmentTypeEnum) System.Enum.Parse(typeof (IfcAlignmentTypeEnum), value.EnumVal, true);
					return;
				case 8: 
					_horizontal = (IfcAlignment2DHorizontal)(value.EntityVal);
					return;
				case 9: 
					_vertical = (IfcAlignment2DVertical)(value.EntityVal);
					return;
				case 10: 
					_linearRefMethod = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAlignment other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				if (@Horizontal != null)
					yield return @Horizontal;
				if (@Vertical != null)
					yield return @Vertical;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				if (@Horizontal != null)
					yield return @Horizontal;
				if (@Vertical != null)
					yield return @Vertical;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}