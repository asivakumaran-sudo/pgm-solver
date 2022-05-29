namespace pgm_solver.Client.Shared;

/// <summary>
/// Describes an element for a computational graph.
/// </summary>
public interface IGraphElement
{
    /// <summary>
    /// Neighbour elements for the current graph element.
    /// </summary>
    IEnumerable<IGraphElement> Neighbours { get; set; }
    
    /// <summary>
    /// Determines the element type.
    /// </summary>
    GraphElementType ElementType { get; set; }
}
