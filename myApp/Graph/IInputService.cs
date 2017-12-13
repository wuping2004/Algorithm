using System.Collections.Generic;

public interface IInputService
{
    IEnumerable<string> GetGraphInput();
    
    IEnumerable<string> GetVertex();
}