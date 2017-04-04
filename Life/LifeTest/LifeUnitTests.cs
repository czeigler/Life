// ***********************************************************************************
//  class       -   class LifeTest
//  puurpose    -   Unit tests for the Game of Life 
//
// ***********************************************************************************

using System;
using Life;
using Xunit;



namespace LifeTest
{
    public class LifeUnitTests
    {

        [Fact]
        public void Test1CellSmallGrid()
        {
            ILife engine = new Life.Life(2, 2);
            engine[0, 0] = true;
            engine.Tick();
            Assert.Equal(false, engine[0, 0]);
        }


        [Fact]
        public void Test1Cell()
        {
            ILife engine = new Life.Life(5,5);
            engine[0, 0] = true;
            engine.Tick();
            Assert.Equal(false, engine[0, 0]);
        }


        [Fact]
        public void Test3CellsInASmallGrid()
        {
            ILife engine = new Life.Life(1, 3);
            engine[0, 0] = true;
            engine[0, 1] = true;
            engine[0, 2] = true;
            engine.Tick();
            Assert.Equal(false, engine[0, 0]);
            Assert.Equal(true,  engine[0, 1]);
            Assert.Equal(false,  engine[0, 2]);
        }


        [Fact]
        public void Test3CellsInARow2Ticks()
        {
            ILife engine = new Life.Life(18,18);
            engine[4, 12] = true;
            engine[5, 12] = true;
            engine[6, 12] = true;
            engine.Tick();
            Assert.Equal(true, engine[5, 11]);
            Assert.Equal(true, engine[5, 12]);
            Assert.Equal(true, engine[5, 13]);
            engine.Tick();
            Assert.Equal(true, engine[4, 12]);
            Assert.Equal(true, engine[5, 12]);
            Assert.Equal(true, engine[6, 12]);

        }


        [Fact]
        public void TestGliderCells1Tick()
        {
            ILife engine = new Life.Life(6, 6);
            engine[0, 1] = true;
            engine[1, 2] = true;
            engine[2, 0] = true;
            engine[2, 1] = true;
            engine[2, 2] = true;
            engine.Tick();
            Assert.Equal(false, engine[0, 0]);
            Assert.Equal(false, engine[0, 1]);
            Assert.Equal(false, engine[0, 2]);
            Assert.Equal(true,  engine[1, 0]);
            Assert.Equal(false, engine[1, 1]);
            Assert.Equal(true,  engine[2, 1]);
            Assert.Equal(true,  engine[2, 2]);
            Assert.Equal(true,  engine[3, 1]);

        }

    }
}
