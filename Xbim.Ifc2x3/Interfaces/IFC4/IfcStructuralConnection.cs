// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	public partial class @IfcStructuralConnection : IIfcStructuralConnection
	{
		IIfcBoundaryCondition IIfcStructuralConnection.AppliedCondition 
		{ 
			get
			{
				return AppliedCondition;
			} 
		}
		IEnumerable<IIfcRelConnectsStructuralMember> IIfcStructuralConnection.ConnectsStructuralMembers 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelConnectsStructuralMember>(e => (e.RelatedStructuralConnection as IfcStructuralConnection) == this, "RelatedStructuralConnection", this);
			} 
		}
	//## Custom code
	//##
	}
}