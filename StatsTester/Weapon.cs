using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static StatsTester.Util;

public class Weapon
{
	private string name;
	private int mt, hit, crit, wt, avo, dodg, range;
	
	private WpnType type;
	private WpnGrip grip;

	public Weapon(string name, int mt, int hit, int crit, int wt, int avo, int dodg, int range, WpnType type, WpnGrip grip)
	{
		this.name = name;
		this.mt = mt;
		this.hit = hit;
		this.crit = crit;
		this.wt = wt;
		this.avo = avo;
		this.dodg = dodg;
		this.range = range;
		this.type = type;
		this.grip = grip;

	}

    public string getName()
    {
        return this.name;
    }
    public void setName(string name)
    {
        this.name = name;
    }
    public int getMt()
    {
        return this.mt;
    }
    public void setMt(int mt)
    {
        this.mt = mt;
    }
    public int getHit()
    {
        return this.hit;
    }
    public void setHit(int hit)
    {
        this.hit = hit;
    }
    public int getCrit()
    {
        return this.crit;
    }
    public void setCrit(int crit)
    {
        this.crit = crit;
    }
    public int getWt()
    {
        return this.wt;
    }
    public void setWt(int wt)
    {
        this.wt = wt;
    }
    public int getAvo()
    {
        return this.avo;
    }
    public void setAvo(int avo)
    {
        this.avo = avo;
    }
    public int getDodg()
    {
        return this.dodg;
    }
    public void setDodg(int dodg)
    {
        this.dodg = dodg;
    }
    public int getRange()
    {
        return this.range;
    }
    public void setRange(int range)
    {
        this.range = range;
    }
    public WpnType getType()
    {
        return this.type;
    }
    public void setType(WpnType type)
    {
        this.type = type;
    }
    public WpnGrip getGrip()
    {
        return this.grip;
    }
    public void setGrip(WpnGrip grip)
    {
        this.grip = grip;
    }


}
