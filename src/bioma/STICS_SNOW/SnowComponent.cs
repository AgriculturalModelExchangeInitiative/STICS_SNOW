
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using CRA.ModelLayer.MetadataTypes;
using CRA.ModelLayer.Core;
using CRA.ModelLayer.Strategy;
using System.Reflection;
using VarInfo=CRA.ModelLayer.Core.VarInfo;
using Preconditions=CRA.ModelLayer.Core.Preconditions;
using CRA.AgroManagement;       

using Snow.DomainClass;
namespace Snow.Strategies
{
    public class SnowComponent : IStrategySnow
    {
        public SnowComponent()
        {
            ModellingOptions mo0_0 = new ModellingOptions();
            //Parameters
            List<VarInfo> _parameters0_0 = new List<VarInfo>();
            VarInfo v1 = new CompositeStrategyVarInfo(_Refreezing, "Tmf");
            _parameters0_0.Add(v1);
            VarInfo v2 = new CompositeStrategyVarInfo(_Melting, "Tmf");
            _parameters0_0.Add(v2);
            VarInfo v3 = new CompositeStrategyVarInfo(_Refreezing, "SWrf");
            _parameters0_0.Add(v3);
            VarInfo v4 = new CompositeStrategyVarInfo(_SnowAccumulation, "tsmax");
            _parameters0_0.Add(v4);
            VarInfo v5 = new CompositeStrategyVarInfo(_Melting, "DKmax");
            _parameters0_0.Add(v5);
            VarInfo v6 = new CompositeStrategyVarInfo(_SnowAccumulation, "trmax");
            _parameters0_0.Add(v6);
            VarInfo v7 = new CompositeStrategyVarInfo(_Preciprec, "rho");
            _parameters0_0.Add(v7);
            VarInfo v8 = new CompositeStrategyVarInfo(_SnowDepth, "rho");
            _parameters0_0.Add(v8);
            VarInfo v9 = new CompositeStrategyVarInfo(_Melting, "Kmin");
            _parameters0_0.Add(v9);
            VarInfo v10 = new CompositeStrategyVarInfo(_SnowDepthTrans, "Pns");
            _parameters0_0.Add(v10);
            VarInfo v11 = new CompositeStrategyVarInfo(_TempMin, "tmaxseuil");
            _parameters0_0.Add(v11);
            VarInfo v12 = new CompositeStrategyVarInfo(_TempMax, "tmaxseuil");
            _parameters0_0.Add(v12);
            VarInfo v13 = new CompositeStrategyVarInfo(_TempMin, "tminseuil");
            _parameters0_0.Add(v13);
            VarInfo v14 = new CompositeStrategyVarInfo(_TempMax, "tminseuil");
            _parameters0_0.Add(v14);
            VarInfo v15 = new CompositeStrategyVarInfo(_TempMin, "prof");
            _parameters0_0.Add(v15);
            VarInfo v16 = new CompositeStrategyVarInfo(_TempMax, "prof");
            _parameters0_0.Add(v16);
            VarInfo v17 = new CompositeStrategyVarInfo(_SnowDepth, "E");
            _parameters0_0.Add(v17);
            List<PropertyDescription> _inputs0_0 = new List<PropertyDescription>();
            PropertyDescription pd1 = new PropertyDescription();
            pd1.DomainClassType = typeof(Snow.DomainClass.SnowAuxiliary);
            pd1.PropertyName = "jul";
            pd1.PropertyType = (Snow.DomainClass.SnowAuxiliaryVarInfo.jul).ValueType.TypeForCurrentValue;
            pd1.PropertyVarInfo =(Snow.DomainClass.SnowAuxiliaryVarInfo.jul);
            _inputs0_0.Add(pd1);
            PropertyDescription pd2 = new PropertyDescription();
            pd2.DomainClassType = typeof(Snow.DomainClass.SnowAuxiliary);
            pd2.PropertyName = "precip";
            pd2.PropertyType = (Snow.DomainClass.SnowAuxiliaryVarInfo.precip).ValueType.TypeForCurrentValue;
            pd2.PropertyVarInfo =(Snow.DomainClass.SnowAuxiliaryVarInfo.precip);
            _inputs0_0.Add(pd2);
            PropertyDescription pd3 = new PropertyDescription();
            pd3.DomainClassType = typeof(Snow.DomainClass.SnowAuxiliary);
            pd3.PropertyName = "tmax";
            pd3.PropertyType = (Snow.DomainClass.SnowAuxiliaryVarInfo.tmax).ValueType.TypeForCurrentValue;
            pd3.PropertyVarInfo =(Snow.DomainClass.SnowAuxiliaryVarInfo.tmax);
            _inputs0_0.Add(pd3);
            PropertyDescription pd4 = new PropertyDescription();
            pd4.DomainClassType = typeof(Snow.DomainClass.SnowState);
            pd4.PropertyName = "ps";
            pd4.PropertyType = (Snow.DomainClass.SnowStateVarInfo.ps).ValueType.TypeForCurrentValue;
            pd4.PropertyVarInfo =(Snow.DomainClass.SnowStateVarInfo.ps);
            _inputs0_0.Add(pd4);
            PropertyDescription pd5 = new PropertyDescription();
            pd5.DomainClassType = typeof(Snow.DomainClass.SnowState);
            pd5.PropertyName = "Sdepth";
            pd5.PropertyType = (Snow.DomainClass.SnowStateVarInfo.Sdepth).ValueType.TypeForCurrentValue;
            pd5.PropertyVarInfo =(Snow.DomainClass.SnowStateVarInfo.Sdepth);
            _inputs0_0.Add(pd5);
            PropertyDescription pd6 = new PropertyDescription();
            pd6.DomainClassType = typeof(Snow.DomainClass.SnowState);
            pd6.PropertyName = "Sdry";
            pd6.PropertyType = (Snow.DomainClass.SnowStateVarInfo.Sdry).ValueType.TypeForCurrentValue;
            pd6.PropertyVarInfo =(Snow.DomainClass.SnowStateVarInfo.Sdry);
            _inputs0_0.Add(pd6);
            PropertyDescription pd7 = new PropertyDescription();
            pd7.DomainClassType = typeof(Snow.DomainClass.SnowState);
            pd7.PropertyName = "Swet";
            pd7.PropertyType = (Snow.DomainClass.SnowStateVarInfo.Swet).ValueType.TypeForCurrentValue;
            pd7.PropertyVarInfo =(Snow.DomainClass.SnowStateVarInfo.Swet);
            _inputs0_0.Add(pd7);
            PropertyDescription pd8 = new PropertyDescription();
            pd8.DomainClassType = typeof(Snow.DomainClass.SnowAuxiliary);
            pd8.PropertyName = "tmin";
            pd8.PropertyType = (Snow.DomainClass.SnowAuxiliaryVarInfo.tmin).ValueType.TypeForCurrentValue;
            pd8.PropertyVarInfo =(Snow.DomainClass.SnowAuxiliaryVarInfo.tmin);
            _inputs0_0.Add(pd8);
            mo0_0.Inputs=_inputs0_0;
            List<PropertyDescription> _outputs0_0 = new List<PropertyDescription>();
            PropertyDescription pd9 = new PropertyDescription();
            pd9.DomainClassType = typeof(Snow.DomainClass.SnowRate);
            pd9.PropertyName = "M";
            pd9.PropertyType = (Snow.DomainClass.SnowRateVarInfo.M).ValueType.TypeForCurrentValue;
            pd9.PropertyVarInfo =(Snow.DomainClass.SnowRateVarInfo.M);
            _outputs0_0.Add(pd9);
            PropertyDescription pd10 = new PropertyDescription();
            pd10.DomainClassType = typeof(Snow.DomainClass.SnowState);
            pd10.PropertyName = "tminrec";
            pd10.PropertyType = (Snow.DomainClass.SnowStateVarInfo.tminrec).ValueType.TypeForCurrentValue;
            pd10.PropertyVarInfo =(Snow.DomainClass.SnowStateVarInfo.tminrec);
            _outputs0_0.Add(pd10);
            PropertyDescription pd11 = new PropertyDescription();
            pd11.DomainClassType = typeof(Snow.DomainClass.SnowState);
            pd11.PropertyName = "Sdepth";
            pd11.PropertyType = (Snow.DomainClass.SnowStateVarInfo.Sdepth).ValueType.TypeForCurrentValue;
            pd11.PropertyVarInfo =(Snow.DomainClass.SnowStateVarInfo.Sdepth);
            _outputs0_0.Add(pd11);
            PropertyDescription pd12 = new PropertyDescription();
            pd12.DomainClassType = typeof(Snow.DomainClass.SnowState);
            pd12.PropertyName = "Sdry";
            pd12.PropertyType = (Snow.DomainClass.SnowStateVarInfo.Sdry).ValueType.TypeForCurrentValue;
            pd12.PropertyVarInfo =(Snow.DomainClass.SnowStateVarInfo.Sdry);
            _outputs0_0.Add(pd12);
            PropertyDescription pd13 = new PropertyDescription();
            pd13.DomainClassType = typeof(Snow.DomainClass.SnowRate);
            pd13.PropertyName = "Snowaccu";
            pd13.PropertyType = (Snow.DomainClass.SnowRateVarInfo.Snowaccu).ValueType.TypeForCurrentValue;
            pd13.PropertyVarInfo =(Snow.DomainClass.SnowRateVarInfo.Snowaccu);
            _outputs0_0.Add(pd13);
            PropertyDescription pd14 = new PropertyDescription();
            pd14.DomainClassType = typeof(Snow.DomainClass.SnowState);
            pd14.PropertyName = "ps";
            pd14.PropertyType = (Snow.DomainClass.SnowStateVarInfo.ps).ValueType.TypeForCurrentValue;
            pd14.PropertyVarInfo =(Snow.DomainClass.SnowStateVarInfo.ps);
            _outputs0_0.Add(pd14);
            PropertyDescription pd15 = new PropertyDescription();
            pd15.DomainClassType = typeof(Snow.DomainClass.SnowState);
            pd15.PropertyName = "Swet";
            pd15.PropertyType = (Snow.DomainClass.SnowStateVarInfo.Swet).ValueType.TypeForCurrentValue;
            pd15.PropertyVarInfo =(Snow.DomainClass.SnowStateVarInfo.Swet);
            _outputs0_0.Add(pd15);
            PropertyDescription pd16 = new PropertyDescription();
            pd16.DomainClassType = typeof(Snow.DomainClass.SnowAuxiliary);
            pd16.PropertyName = "tavg";
            pd16.PropertyType = (Snow.DomainClass.SnowAuxiliaryVarInfo.tavg).ValueType.TypeForCurrentValue;
            pd16.PropertyVarInfo =(Snow.DomainClass.SnowAuxiliaryVarInfo.tavg);
            _outputs0_0.Add(pd16);
            PropertyDescription pd17 = new PropertyDescription();
            pd17.DomainClassType = typeof(Snow.DomainClass.SnowRate);
            pd17.PropertyName = "Mrf";
            pd17.PropertyType = (Snow.DomainClass.SnowRateVarInfo.Mrf).ValueType.TypeForCurrentValue;
            pd17.PropertyVarInfo =(Snow.DomainClass.SnowRateVarInfo.Mrf);
            _outputs0_0.Add(pd17);
            PropertyDescription pd18 = new PropertyDescription();
            pd18.DomainClassType = typeof(Snow.DomainClass.SnowState);
            pd18.PropertyName = "tmaxrec";
            pd18.PropertyType = (Snow.DomainClass.SnowStateVarInfo.tmaxrec).ValueType.TypeForCurrentValue;
            pd18.PropertyVarInfo =(Snow.DomainClass.SnowStateVarInfo.tmaxrec);
            _outputs0_0.Add(pd18);
            PropertyDescription pd19 = new PropertyDescription();
            pd19.DomainClassType = typeof(Snow.DomainClass.SnowState);
            pd19.PropertyName = "preciprec";
            pd19.PropertyType = (Snow.DomainClass.SnowStateVarInfo.preciprec).ValueType.TypeForCurrentValue;
            pd19.PropertyVarInfo =(Snow.DomainClass.SnowStateVarInfo.preciprec);
            _outputs0_0.Add(pd19);
            PropertyDescription pd20 = new PropertyDescription();
            pd20.DomainClassType = typeof(Snow.DomainClass.SnowState);
            pd20.PropertyName = "Snowmelt";
            pd20.PropertyType = (Snow.DomainClass.SnowStateVarInfo.Snowmelt).ValueType.TypeForCurrentValue;
            pd20.PropertyVarInfo =(Snow.DomainClass.SnowStateVarInfo.Snowmelt);
            _outputs0_0.Add(pd20);
            PropertyDescription pd21 = new PropertyDescription();
            pd21.DomainClassType = typeof(Snow.DomainClass.SnowState);
            pd21.PropertyName = "Sdepth_cm";
            pd21.PropertyType = (Snow.DomainClass.SnowStateVarInfo.Sdepth_cm).ValueType.TypeForCurrentValue;
            pd21.PropertyVarInfo =(Snow.DomainClass.SnowStateVarInfo.Sdepth_cm);
            _outputs0_0.Add(pd21);
            mo0_0.Outputs=_outputs0_0;
            List<string> lAssStrat0_0 = new List<string>();
            lAssStrat0_0.Add(typeof(Snow.Strategies.Melting).FullName);
            lAssStrat0_0.Add(typeof(Snow.Strategies.Refreezing).FullName);
            lAssStrat0_0.Add(typeof(Snow.Strategies.SnowAccumulation).FullName);
            lAssStrat0_0.Add(typeof(Snow.Strategies.SnowDensity).FullName);
            lAssStrat0_0.Add(typeof(Snow.Strategies.SnowDepth).FullName);
            lAssStrat0_0.Add(typeof(Snow.Strategies.SnowDepthTrans).FullName);
            lAssStrat0_0.Add(typeof(Snow.Strategies.SnowDry).FullName);
            lAssStrat0_0.Add(typeof(Snow.Strategies.SnowMelt).FullName);
            lAssStrat0_0.Add(typeof(Snow.Strategies.SnowWet).FullName);
            lAssStrat0_0.Add(typeof(Snow.Strategies.Tavg).FullName);
            lAssStrat0_0.Add(typeof(Snow.Strategies.TempMax).FullName);
            lAssStrat0_0.Add(typeof(Snow.Strategies.TempMin).FullName);
            lAssStrat0_0.Add(typeof(Snow.Strategies.Preciprec).FullName);
            mo0_0.AssociatedStrategies = lAssStrat0_0;
            _modellingOptionsManager = new ModellingOptionsManager(mo0_0);
            SetStaticParametersVarInfoDefinitions();
            SetPublisherData();
        }

        public string Description
        {
            get { return "Snow" ;}
        }

        public string URL
        {
            get { return "" ;}
        }

        public string Domain
        {
            get { return "";}
        }

        public string ModelType
        {
            get { return "";}
        }

        public bool IsContext
        {
            get { return false;}
        }

        public IList<int> TimeStep
        {
            get
            {
                IList<int> ts = new List<int>();
                return ts;
            }
        }

        private  PublisherData _pd;
        public PublisherData PublisherData
        {
            get { return _pd;} 
        }

        private  void SetPublisherData()
        {
            _pd = new CRA.ModelLayer.MetadataTypes.PublisherData();
            _pd.Add("Creator", "STICS");
            _pd.Add("Date", "");
            _pd.Add("Publisher", "STICS");
        }

        private ModellingOptionsManager _modellingOptionsManager;
        public ModellingOptionsManager ModellingOptionsManager
        {
            get { return _modellingOptionsManager; } 
        }

        public IEnumerable<Type> GetStrategyDomainClassesTypes()
        {
            return new List<Type>() {  typeof(Snow.DomainClass.SnowState), typeof(Snow.DomainClass.SnowState), typeof(Snow.DomainClass.SnowRate), typeof(Snow.DomainClass.SnowAuxiliary), typeof(Snow.DomainClass.SnowExogenous)};
        }

        public double Tmf
        {
            get
            {
                 return _Refreezing.Tmf; 
            }
            set
            {
                _Refreezing.Tmf = value;
                _Melting.Tmf = value;
            }
        }
        public double SWrf
        {
            get
            {
                 return _Refreezing.SWrf; 
            }
            set
            {
                _Refreezing.SWrf = value;
            }
        }
        public double tsmax
        {
            get
            {
                 return _SnowAccumulation.tsmax; 
            }
            set
            {
                _SnowAccumulation.tsmax = value;
            }
        }
        public double DKmax
        {
            get
            {
                 return _Melting.DKmax; 
            }
            set
            {
                _Melting.DKmax = value;
            }
        }
        public double trmax
        {
            get
            {
                 return _SnowAccumulation.trmax; 
            }
            set
            {
                _SnowAccumulation.trmax = value;
            }
        }
        public double rho
        {
            get
            {
                 return _Preciprec.rho; 
            }
            set
            {
                _Preciprec.rho = value;
                _SnowDepth.rho = value;
            }
        }
        public double Kmin
        {
            get
            {
                 return _Melting.Kmin; 
            }
            set
            {
                _Melting.Kmin = value;
            }
        }
        public double Pns
        {
            get
            {
                 return _SnowDepthTrans.Pns; 
            }
            set
            {
                _SnowDepthTrans.Pns = value;
            }
        }
        public double tmaxseuil
        {
            get
            {
                 return _TempMin.tmaxseuil; 
            }
            set
            {
                _TempMin.tmaxseuil = value;
                _TempMax.tmaxseuil = value;
            }
        }
        public double tminseuil
        {
            get
            {
                 return _TempMin.tminseuil; 
            }
            set
            {
                _TempMin.tminseuil = value;
                _TempMax.tminseuil = value;
            }
        }
        public double prof
        {
            get
            {
                 return _TempMin.prof; 
            }
            set
            {
                _TempMin.prof = value;
                _TempMax.prof = value;
            }
        }
        public double E
        {
            get
            {
                 return _SnowDepth.E; 
            }
            set
            {
                _SnowDepth.E = value;
            }
        }

        public void SetParametersDefaultValue()
        {
            _modellingOptionsManager.SetParametersDefaultValue();
            _Melting.SetParametersDefaultValue();
            _Refreezing.SetParametersDefaultValue();
            _SnowAccumulation.SetParametersDefaultValue();
            _SnowDensity.SetParametersDefaultValue();
            _SnowDepth.SetParametersDefaultValue();
            _SnowDepthTrans.SetParametersDefaultValue();
            _SnowDry.SetParametersDefaultValue();
            _SnowMelt.SetParametersDefaultValue();
            _SnowWet.SetParametersDefaultValue();
            _Tavg.SetParametersDefaultValue();
            _TempMax.SetParametersDefaultValue();
            _TempMin.SetParametersDefaultValue();
            _Preciprec.SetParametersDefaultValue();
        }

        private static void SetStaticParametersVarInfoDefinitions()
        {

            TmfVarInfo.Name = "Tmf";
            TmfVarInfo.Description = "threshold temperature for snow melting ";
            TmfVarInfo.MaxValue = 5000.0;
            TmfVarInfo.MinValue = 0.0;
            TmfVarInfo.DefaultValue = 0.0;
            TmfVarInfo.Units = "degC";
            TmfVarInfo.ValueType = VarInfoValueTypes.GetInstanceForName("Double");

            SWrfVarInfo.Name = "SWrf";
            SWrfVarInfo.Description = "degree-day temperature index for refreezing";
            SWrfVarInfo.MaxValue = 5000.0;
            SWrfVarInfo.MinValue = 0.0;
            SWrfVarInfo.DefaultValue = 0.0;
            SWrfVarInfo.Units = "mmW/degC/d";
            SWrfVarInfo.ValueType = VarInfoValueTypes.GetInstanceForName("Double");

            tsmaxVarInfo.Name = "tsmax";
            tsmaxVarInfo.Description = "maximum daily air temperature (tmax) below which all precipitation is assumed to be snow";
            tsmaxVarInfo.MaxValue = 1000;
            tsmaxVarInfo.MinValue = 0.0;
            tsmaxVarInfo.DefaultValue = 0.0;
            tsmaxVarInfo.Units = "degC";
            tsmaxVarInfo.ValueType = VarInfoValueTypes.GetInstanceForName("Double");

            DKmaxVarInfo.Name = "DKmax";
            DKmaxVarInfo.Description = "difference between the maximum and the minimum melting rates";
            DKmaxVarInfo.MaxValue = 5000.0;
            DKmaxVarInfo.MinValue = 0.0;
            DKmaxVarInfo.DefaultValue = 0.0;
            DKmaxVarInfo.Units = "mmW/degC/d";
            DKmaxVarInfo.ValueType = VarInfoValueTypes.GetInstanceForName("Double");

            trmaxVarInfo.Name = "trmax";
            trmaxVarInfo.Description = "tmax above which all precipitation is assumed to be rain";
            trmaxVarInfo.MaxValue = 5000.0;
            trmaxVarInfo.MinValue = 0.0;
            trmaxVarInfo.DefaultValue = 0.0;
            trmaxVarInfo.Units = "degC";
            trmaxVarInfo.ValueType = VarInfoValueTypes.GetInstanceForName("Double");

            rhoVarInfo.Name = "rho";
            rhoVarInfo.Description = "The density of the new snow fixed by the user";
            rhoVarInfo.MaxValue = ;
            rhoVarInfo.MinValue = ;
            rhoVarInfo.DefaultValue = 100;
            rhoVarInfo.Units = "kg/m**3";
            rhoVarInfo.ValueType = VarInfoValueTypes.GetInstanceForName("Double");

            KminVarInfo.Name = "Kmin";
            KminVarInfo.Description = "minimum melting rate on 21 December";
            KminVarInfo.MaxValue = 5000.0;
            KminVarInfo.MinValue = 0.0;
            KminVarInfo.DefaultValue = 0.0;
            KminVarInfo.Units = "mmW/degC/d";
            KminVarInfo.ValueType = VarInfoValueTypes.GetInstanceForName("Double");

            PnsVarInfo.Name = "Pns";
            PnsVarInfo.Description = "density of the new snow";
            PnsVarInfo.MaxValue = ;
            PnsVarInfo.MinValue = ;
            PnsVarInfo.DefaultValue = 100.0;
            PnsVarInfo.Units = "cm/m";
            PnsVarInfo.ValueType = VarInfoValueTypes.GetInstanceForName("Double");

            tmaxseuilVarInfo.Name = "tmaxseuil";
            tmaxseuilVarInfo.Description = "maximum temperature when snow cover is higher than prof";
            tmaxseuilVarInfo.MaxValue = ;
            tmaxseuilVarInfo.MinValue = ;
            tmaxseuilVarInfo.DefaultValue = 0.0;
            tmaxseuilVarInfo.Units = "degC";
            tmaxseuilVarInfo.ValueType = VarInfoValueTypes.GetInstanceForName("Double");

            tminseuilVarInfo.Name = "tminseuil";
            tminseuilVarInfo.Description = "minimum temperature when snow cover is higher than prof";
            tminseuilVarInfo.MaxValue = 5000.0;
            tminseuilVarInfo.MinValue = 0.0;
            tminseuilVarInfo.DefaultValue = 0.0;
            tminseuilVarInfo.Units = "degC";
            tminseuilVarInfo.ValueType = VarInfoValueTypes.GetInstanceForName("Double");

            profVarInfo.Name = "prof";
            profVarInfo.Description = "snow cover threshold for snow insulation ";
            profVarInfo.MaxValue = 1000;
            profVarInfo.MinValue = 0.0;
            profVarInfo.DefaultValue = 0.0;
            profVarInfo.Units = "cm";
            profVarInfo.ValueType = VarInfoValueTypes.GetInstanceForName("Double");

            EVarInfo.Name = "E";
            EVarInfo.Description = "snow compaction parameter";
            EVarInfo.MaxValue = ;
            EVarInfo.MinValue = ;
            EVarInfo.DefaultValue = 0.0;
            EVarInfo.Units = "mm/mm/d";
            EVarInfo.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
        }

        public static VarInfo TmfVarInfo
        {
            get { return Snow.Strategies.Refreezing.TmfVarInfo;} 
        }

        public static VarInfo SWrfVarInfo
        {
            get { return Snow.Strategies.Refreezing.SWrfVarInfo;} 
        }

        public static VarInfo tsmaxVarInfo
        {
            get { return Snow.Strategies.SnowAccumulation.tsmaxVarInfo;} 
        }

        public static VarInfo DKmaxVarInfo
        {
            get { return Snow.Strategies.Melting.DKmaxVarInfo;} 
        }

        public static VarInfo trmaxVarInfo
        {
            get { return Snow.Strategies.SnowAccumulation.trmaxVarInfo;} 
        }

        public static VarInfo rhoVarInfo
        {
            get { return Snow.Strategies.Preciprec.rhoVarInfo;} 
        }

        public static VarInfo KminVarInfo
        {
            get { return Snow.Strategies.Melting.KminVarInfo;} 
        }

        public static VarInfo PnsVarInfo
        {
            get { return Snow.Strategies.SnowDepthTrans.PnsVarInfo;} 
        }

        public static VarInfo tmaxseuilVarInfo
        {
            get { return Snow.Strategies.TempMin.tmaxseuilVarInfo;} 
        }

        public static VarInfo tminseuilVarInfo
        {
            get { return Snow.Strategies.TempMin.tminseuilVarInfo;} 
        }

        public static VarInfo profVarInfo
        {
            get { return Snow.Strategies.TempMin.profVarInfo;} 
        }

        public static VarInfo EVarInfo
        {
            get { return Snow.Strategies.SnowDepth.EVarInfo;} 
        }

        public string TestPostConditions(Snow.DomainClass.SnowState s,Snow.DomainClass.SnowState s1,Snow.DomainClass.SnowRate r,Snow.DomainClass.SnowAuxiliary a,Snow.DomainClass.SnowExogenous ex,string callID)
        {
            try
            {
                //Set current values of the outputs to the static VarInfo representing the output properties of the domain classes
                Snow.DomainClass.SnowRateVarInfo.M.CurrentValue=r.M;
                Snow.DomainClass.SnowStateVarInfo.tminrec.CurrentValue=s.tminrec;
                Snow.DomainClass.SnowStateVarInfo.Sdepth.CurrentValue=s.Sdepth;
                Snow.DomainClass.SnowStateVarInfo.Sdry.CurrentValue=s.Sdry;
                Snow.DomainClass.SnowRateVarInfo.Snowaccu.CurrentValue=r.Snowaccu;
                Snow.DomainClass.SnowStateVarInfo.ps.CurrentValue=s.ps;
                Snow.DomainClass.SnowStateVarInfo.Swet.CurrentValue=s.Swet;
                Snow.DomainClass.SnowAuxiliaryVarInfo.tavg.CurrentValue=a.tavg;
                Snow.DomainClass.SnowRateVarInfo.Mrf.CurrentValue=r.Mrf;
                Snow.DomainClass.SnowStateVarInfo.tmaxrec.CurrentValue=s.tmaxrec;
                Snow.DomainClass.SnowStateVarInfo.preciprec.CurrentValue=s.preciprec;
                Snow.DomainClass.SnowStateVarInfo.Snowmelt.CurrentValue=s.Snowmelt;
                Snow.DomainClass.SnowStateVarInfo.Sdepth_cm.CurrentValue=s.Sdepth_cm;

                ConditionsCollection prc = new ConditionsCollection();
                Preconditions pre = new Preconditions(); 

                RangeBasedCondition r21 = new RangeBasedCondition(Snow.DomainClass.SnowRateVarInfo.M);
                if(r21.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowRateVarInfo.M.ValueType)){prc.AddCondition(r21);}
                RangeBasedCondition r22 = new RangeBasedCondition(Snow.DomainClass.SnowStateVarInfo.tminrec);
                if(r22.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowStateVarInfo.tminrec.ValueType)){prc.AddCondition(r22);}
                RangeBasedCondition r23 = new RangeBasedCondition(Snow.DomainClass.SnowStateVarInfo.Sdepth);
                if(r23.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowStateVarInfo.Sdepth.ValueType)){prc.AddCondition(r23);}
                RangeBasedCondition r24 = new RangeBasedCondition(Snow.DomainClass.SnowStateVarInfo.Sdry);
                if(r24.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowStateVarInfo.Sdry.ValueType)){prc.AddCondition(r24);}
                RangeBasedCondition r25 = new RangeBasedCondition(Snow.DomainClass.SnowRateVarInfo.Snowaccu);
                if(r25.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowRateVarInfo.Snowaccu.ValueType)){prc.AddCondition(r25);}
                RangeBasedCondition r26 = new RangeBasedCondition(Snow.DomainClass.SnowStateVarInfo.ps);
                if(r26.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowStateVarInfo.ps.ValueType)){prc.AddCondition(r26);}
                RangeBasedCondition r27 = new RangeBasedCondition(Snow.DomainClass.SnowStateVarInfo.Swet);
                if(r27.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowStateVarInfo.Swet.ValueType)){prc.AddCondition(r27);}
                RangeBasedCondition r28 = new RangeBasedCondition(Snow.DomainClass.SnowAuxiliaryVarInfo.tavg);
                if(r28.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowAuxiliaryVarInfo.tavg.ValueType)){prc.AddCondition(r28);}
                RangeBasedCondition r29 = new RangeBasedCondition(Snow.DomainClass.SnowRateVarInfo.Mrf);
                if(r29.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowRateVarInfo.Mrf.ValueType)){prc.AddCondition(r29);}
                RangeBasedCondition r30 = new RangeBasedCondition(Snow.DomainClass.SnowStateVarInfo.tmaxrec);
                if(r30.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowStateVarInfo.tmaxrec.ValueType)){prc.AddCondition(r30);}
                RangeBasedCondition r31 = new RangeBasedCondition(Snow.DomainClass.SnowStateVarInfo.preciprec);
                if(r31.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowStateVarInfo.preciprec.ValueType)){prc.AddCondition(r31);}
                RangeBasedCondition r32 = new RangeBasedCondition(Snow.DomainClass.SnowStateVarInfo.Snowmelt);
                if(r32.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowStateVarInfo.Snowmelt.ValueType)){prc.AddCondition(r32);}
                RangeBasedCondition r33 = new RangeBasedCondition(Snow.DomainClass.SnowStateVarInfo.Sdepth_cm);
                if(r33.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowStateVarInfo.Sdepth_cm.ValueType)){prc.AddCondition(r33);}

                string ret = "";
                ret += _Melting.TestPostConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _Refreezing.TestPostConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _SnowAccumulation.TestPostConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _SnowDensity.TestPostConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _SnowDepth.TestPostConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _SnowDepthTrans.TestPostConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _SnowDry.TestPostConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _SnowMelt.TestPostConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _SnowWet.TestPostConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _Tavg.TestPostConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _TempMax.TestPostConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _TempMin.TestPostConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _Preciprec.TestPostConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                if (ret != "") { pre.TestsOut(ret, true, "   postconditions tests of associated classes"); }

                string postConditionsResult = pre.VerifyPostconditions(prc, callID); if (!string.IsNullOrEmpty(postConditionsResult)) { pre.TestsOut(postConditionsResult, true, "PostConditions errors in strategy " + this.GetType().Name); } return postConditionsResult;
            }
            catch (Exception exception)
            {
                string msg = "Component .Snow, " + this.GetType().Name + ": Unhandled exception running post-condition test. ";
                throw new Exception(msg, exception);
            }
        }

        public string TestPreConditions(Snow.DomainClass.SnowState s,Snow.DomainClass.SnowState s1,Snow.DomainClass.SnowRate r,Snow.DomainClass.SnowAuxiliary a,Snow.DomainClass.SnowExogenous ex,string callID)
        {
            try
            {
                //Set current values of the inputs to the static VarInfo representing the inputs properties of the domain classes
                Snow.DomainClass.SnowAuxiliaryVarInfo.jul.CurrentValue=a.jul;
                Snow.DomainClass.SnowAuxiliaryVarInfo.precip.CurrentValue=a.precip;
                Snow.DomainClass.SnowAuxiliaryVarInfo.tmax.CurrentValue=a.tmax;
                Snow.DomainClass.SnowStateVarInfo.ps.CurrentValue=s.ps;
                Snow.DomainClass.SnowStateVarInfo.Sdepth.CurrentValue=s.Sdepth;
                Snow.DomainClass.SnowStateVarInfo.Sdry.CurrentValue=s.Sdry;
                Snow.DomainClass.SnowStateVarInfo.Swet.CurrentValue=s.Swet;
                Snow.DomainClass.SnowAuxiliaryVarInfo.tmin.CurrentValue=a.tmin;
                ConditionsCollection prc = new ConditionsCollection();
                Preconditions pre = new Preconditions(); 
                RangeBasedCondition r1 = new RangeBasedCondition(Snow.DomainClass.SnowAuxiliaryVarInfo.jul);
                if(r1.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowAuxiliaryVarInfo.jul.ValueType)){prc.AddCondition(r1);}
                RangeBasedCondition r2 = new RangeBasedCondition(Snow.DomainClass.SnowAuxiliaryVarInfo.precip);
                if(r2.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowAuxiliaryVarInfo.precip.ValueType)){prc.AddCondition(r2);}
                RangeBasedCondition r3 = new RangeBasedCondition(Snow.DomainClass.SnowAuxiliaryVarInfo.tmax);
                if(r3.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowAuxiliaryVarInfo.tmax.ValueType)){prc.AddCondition(r3);}
                RangeBasedCondition r4 = new RangeBasedCondition(Snow.DomainClass.SnowStateVarInfo.ps);
                if(r4.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowStateVarInfo.ps.ValueType)){prc.AddCondition(r4);}
                RangeBasedCondition r5 = new RangeBasedCondition(Snow.DomainClass.SnowStateVarInfo.Sdepth);
                if(r5.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowStateVarInfo.Sdepth.ValueType)){prc.AddCondition(r5);}
                RangeBasedCondition r6 = new RangeBasedCondition(Snow.DomainClass.SnowStateVarInfo.Sdry);
                if(r6.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowStateVarInfo.Sdry.ValueType)){prc.AddCondition(r6);}
                RangeBasedCondition r7 = new RangeBasedCondition(Snow.DomainClass.SnowStateVarInfo.Swet);
                if(r7.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowStateVarInfo.Swet.ValueType)){prc.AddCondition(r7);}
                RangeBasedCondition r8 = new RangeBasedCondition(Snow.DomainClass.SnowAuxiliaryVarInfo.tmin);
                if(r8.ApplicableVarInfoValueTypes.Contains( Snow.DomainClass.SnowAuxiliaryVarInfo.tmin.ValueType)){prc.AddCondition(r8);}

                prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Tmf")));
                prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("SWrf")));
                prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("tsmax")));
                prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("DKmax")));
                prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("trmax")));
                prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("rho")));
                prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Kmin")));
                prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Pns")));
                prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("tmaxseuil")));
                prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("tminseuil")));
                prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("prof")));
                prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("E")));
                string ret = "";
                ret += _Melting.TestPreConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _Refreezing.TestPreConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _SnowAccumulation.TestPreConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _SnowDensity.TestPreConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _SnowDepth.TestPreConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _SnowDepthTrans.TestPreConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _SnowDry.TestPreConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _SnowMelt.TestPreConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _SnowWet.TestPreConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _Tavg.TestPreConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _TempMax.TestPreConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _TempMin.TestPreConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                ret += _Preciprec.TestPreConditions(s, s1, r, a, ex, " strategy Snow.Strategies.Snow");
                if (ret != "") { pre.TestsOut(ret, true, "   preconditions tests of associated classes"); }

                string preConditionsResult = pre.VerifyPreconditions(prc, callID); if (!string.IsNullOrEmpty(preConditionsResult)) { pre.TestsOut(preConditionsResult, true, "PreConditions errors in component " + this.GetType().Name); } return preConditionsResult;
            }
            catch (Exception exception)
            {
                string msg = "Component .Snow, " + this.GetType().Name + ": Unhandled exception running pre-condition test. ";
                throw new Exception(msg, exception);
            }
        }

        public void Estimate(Snow.DomainClass.SnowState s,Snow.DomainClass.SnowState s1,Snow.DomainClass.SnowRate r,Snow.DomainClass.SnowAuxiliary a,Snow.DomainClass.SnowExogenous ex)
        {
            try
            {
                CalculateModel(s, s1, r, a, ex);
            }
            catch (Exception exception)
            {
                string msg = "Error in component Snow, strategy: " + this.GetType().Name + ": Unhandled exception running model. "+exception.GetType().FullName+" - "+exception.Message;
                throw new Exception(msg, exception);
            }
        }

        private void CalculateModel(Snow.DomainClass.SnowState s,Snow.DomainClass.SnowState s1,Snow.DomainClass.SnowRate r,Snow.DomainClass.SnowAuxiliary a,Snow.DomainClass.SnowExogenous ex)
        {
            EstimateOfAssociatedClasses(s, s1, r, a, ex);
        }

        //Declaration of the associated strategies
        Melting _Melting = new Melting();
        Refreezing _Refreezing = new Refreezing();
        SnowAccumulation _SnowAccumulation = new SnowAccumulation();
        SnowDensity _SnowDensity = new SnowDensity();
        SnowDepth _SnowDepth = new SnowDepth();
        SnowDepthTrans _SnowDepthTrans = new SnowDepthTrans();
        SnowDry _SnowDry = new SnowDry();
        SnowMelt _SnowMelt = new SnowMelt();
        SnowWet _SnowWet = new SnowWet();
        Tavg _Tavg = new Tavg();
        TempMax _TempMax = new TempMax();
        TempMin _TempMin = new TempMin();
        Preciprec _Preciprec = new Preciprec();

        private void EstimateOfAssociatedClasses(Snow.DomainClass.SnowState s,Snow.DomainClass.SnowState s1,Snow.DomainClass.SnowRate r,Snow.DomainClass.SnowAuxiliary a,Snow.DomainClass.SnowExogenous ex)
        {
            _snowaccumulation.Estimate(s,s1, r, a, ex);
            _snowdensity.Estimate(s,s1, r, a, ex);
            _tavg.Estimate(s,s1, r, a, ex);
            _melting.Estimate(s,s1, r, a, ex);
            _refreezing.Estimate(s,s1, r, a, ex);
            _snowmelt.Estimate(s,s1, r, a, ex);
            _snowdry.Estimate(s,s1, r, a, ex);
            _snowdepth.Estimate(s,s1, r, a, ex);
            _snowwet.Estimate(s,s1, r, a, ex);
            _snowdepthtrans.Estimate(s,s1, r, a, ex);
            _preciprec.Estimate(s,s1, r, a, ex);
            _tempmin.Estimate(s,s1, r, a, ex);
            _tempmax.Estimate(s,s1, r, a, ex);
        }

        public SnowComponent(SnowComponent toCopy): this() // copy constructor 
        {
                Tmf = toCopy.Tmf;
                SWrf = toCopy.SWrf;
                tsmax = toCopy.tsmax;
                DKmax = toCopy.DKmax;
                trmax = toCopy.trmax;
                rho = toCopy.rho;
                Kmin = toCopy.Kmin;
                Pns = toCopy.Pns;
                tmaxseuil = toCopy.tmaxseuil;
                tminseuil = toCopy.tminseuil;
                prof = toCopy.prof;
                E = toCopy.E;
        }
    }
}