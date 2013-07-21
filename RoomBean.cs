using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FireBirdHelper
{
    public class RoomBean
    {
        private String name;
        private int buildingNumber;
        private int floor;
        private float actualArea;
        private float publicArea;
        private float totalArea;
        private float publicRatio;
        private int underNumber;
        private String underName;
        private int underFloor;
        private float underActual;
        private float underPublic;
        private float underTotal;
        private int isReserved;
        private int isToken;
        private String owner;
        private int buildingLevel;
        private int areaNo;

        public int getBuildingLevel(){
            return this.buildingLevel;
        }

        public void setBuildingLevel(int buildingLevel)
        {
            this.buildingLevel = buildingLevel;
        }

        public int getAreaNo()
        {
            return this.areaNo;
        }

        public void setAreaNo(int areaNo)
        {
            this.areaNo = areaNo;
        }

        public String getName()
        {
            return this.name;
        }
        public void setName(String name)
        {
            this.name = name;
        }

        public String getOwner()
        {
            return this.owner;
        }
        public void setOwner(String owner)
        {
            this.owner = owner;
        }

        public String getUnderName()
        {
            return this.underName;
        }
        public void setUnderName(String underName)
        {
            this.underName = underName;
        }

        public int getFloor()
        {
            return this.floor;
        }
        public void setFloor(int floor)
        {
            this.floor = floor;
        }

        public int getBuildingNumber()
        {
            return this.buildingNumber;
        }
        public void setBuildingNumber(int buildingNumber)
        {
            this.buildingNumber = buildingNumber;
        }

        public int getUnderNumber()
        {
            return this.underNumber;
        }
        public void setUnderNumber(int underNumber)
        {
            this.underNumber = underNumber;
        }

        public int getUnderFloor()
        {
            return this.underFloor;
        }
        public void setUnderFloor(int underFloor)
        {
            this.underFloor = underFloor;
        }

        public int getIsReserved()
        {
            return this.isReserved;
        }
        public void setIsReserved(int isReserved)
        {
            this.isReserved = isReserved;
        }

        public int getIsToken()
        {
            return this.isToken;
        }
        public void setIsToken(int isToken)
        {
            this.isToken = isToken;
        }

        public float getActualArea()
        {
            return this.actualArea;
        }
        public void setActualArea(float actualArea)
        {
            this.actualArea = actualArea;
        }

        public float getPublicArea()
        {
            return this.publicArea;
        }
        public void setPublicArea(float publicArea)
        {
            this.publicArea = publicArea;
        }

        public float getTotalArea()
        {
            return this.totalArea;
        }
        public void setTotalArea(float totalArea)
        {
            this.totalArea = totalArea;
        }

        public float getPublicRatio()
        {
            return this.publicRatio;
        }
        public void setPublicRatio(float publicRatio)
        {
            this.publicRatio = publicRatio;
        }

        public float getUnderActual()
        {
            return this.underActual;
        }
        public void setUnderActual(float underActual)
        {
            this.underActual = underActual;
        }

        public float getUnderPublic()
        {
            return this.underPublic;
        }
        public void setUnderPublic(float underPublic)
        {
            this.underPublic = underPublic;
        }

        public float getUnderTotal()
        {
            return this.underTotal;
        }
        public void setUnderTotal(float underTotal)
        {
            this.underTotal = underTotal;
        }
        public String toString()
        {
            return name + " " + buildingNumber + " " + floor + " "
                + actualArea + " " + publicArea + " " + totalArea
                + " " + publicRatio + " " + underFloor
                + " " + isToken + " " + isReserved;
        }

        public String getString()
        {
            return "#" + buildingNumber + " " + name;
        }

        public String getDisplay()
        {
            String ret = "此房屋是 " + buildingNumber + " 号楼" + name + ", 建筑面积:" + totalArea;
            if (underFloor != 0)
            {
                ret += " 地下室:" + underName + " 建筑面积: " + underTotal;
            }
            return ret;
        }

    }
}
