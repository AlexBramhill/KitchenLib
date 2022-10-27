using KitchenData;

namespace KitchenLib.Customs
{
    public abstract class CustomProcess : CustomGameDataObject
    {
		public virtual GameDataObject BasicEnablingAppliance { get; internal set; }
		public virtual int EnablingApplianceCount { get { return 1; }}
		public virtual Process IsPseudoprocessFor { get; internal set; }
		public virtual bool CanObfuscateProgress { get; internal set; }
		public virtual string Icon { get { return "!"; }}
		public virtual LocalisationObject<ProcessInfo> Info { get; internal set; }

        public override void Convert(GameData gameData, out GameDataObject gameDataObject)
        {
            Process result = new Process();
            Process empty = new Process();

            if (empty.ID != ID) result.ID = ID;
            if (empty.BasicEnablingAppliance != BasicEnablingAppliance) result.BasicEnablingAppliance = BasicEnablingAppliance;
            if (empty.EnablingApplianceCount != EnablingApplianceCount) result.EnablingApplianceCount = EnablingApplianceCount;
            if (empty.IsPseudoprocessFor != IsPseudoprocessFor) result.IsPseudoprocessFor = IsPseudoprocessFor;
            if (empty.CanObfuscateProgress != CanObfuscateProgress) result.CanObfuscateProgress = CanObfuscateProgress;
            if (empty.Icon != Icon) result.Icon = Icon;
            if (empty.Info != Info) result.Info = Info;

            gameDataObject = result;
        }
    }
}