// *************************************************************
//  filename:   ILife.cs
//  purpose:    contains an interface for Conway's Game of Life
//              engine
//
//  Author: Chris Zeigler
// *************************************************************
using System.Windows.Forms;

namespace Life
{
    public interface ILife
    {

        // ***********************************************************************************
        //  class       -   class Life
        //  puurpose    -   provides a container and some functionality for calculating states   
        //                  during a session of Conway's Game of Life
        //  API         -   int Height get      -   property
        //                  int Width get       -   property
        //                  int Ticks get       -   property
        //                  bool this[int, int] -   indexer 
        //                  Tick()              -   method  
        // ***********************************************************************************

        void Tick();
        int Ticks { get; }
        int Height { get; }
        int Width { get; }
        bool this[int y, int x] { get; set; }
    }
}