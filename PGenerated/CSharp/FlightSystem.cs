using PChecker;
using PChecker.Actors;
using PChecker.Actors.Events;
using PChecker.Runtime;
using PChecker.Specifications;
using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Plang.CSharpRuntime;
using Plang.CSharpRuntime.Values;
using Plang.CSharpRuntime.Exceptions;
using System.Threading;
using System.Threading.Tasks;

#pragma warning disable 162, 219, 414, 1998
namespace PImplementation
{
}
namespace PImplementation
{
    internal partial class eRaiseError : PEvent
    {
        public eRaiseError() : base() {}
        public eRaiseError (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eRaiseError();}
    }
}
namespace PImplementation
{
    internal partial class eReqArm : PEvent
    {
        public eReqArm() : base() {}
        public eReqArm (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqArm();}
    }
}
namespace PImplementation
{
    internal partial class eReqTelemetryHealth : PEvent
    {
        public eReqTelemetryHealth() : base() {}
        public eReqTelemetryHealth (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqTelemetryHealth();}
    }
}
namespace PImplementation
{
    internal partial class eReqSystemStatus : PEvent
    {
        public eReqSystemStatus() : base() {}
        public eReqSystemStatus (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqSystemStatus();}
    }
}
namespace PImplementation
{
    internal partial class eReqTakeoff : PEvent
    {
        public eReqTakeoff() : base() {}
        public eReqTakeoff (PrtFloat payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqTakeoff();}
    }
}
namespace PImplementation
{
    internal partial class eReqMissionUpload : PEvent
    {
        public eReqMissionUpload() : base() {}
        public eReqMissionUpload (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqMissionUpload();}
    }
}
namespace PImplementation
{
    internal partial class eReqBatteryRemaining : PEvent
    {
        public eReqBatteryRemaining() : base() {}
        public eReqBatteryRemaining (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqBatteryRemaining();}
    }
}
namespace PImplementation
{
    internal partial class eReqHold : PEvent
    {
        public eReqHold() : base() {}
        public eReqHold (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqHold();}
    }
}
namespace PImplementation
{
    internal partial class eReqReturnToLaunch : PEvent
    {
        public eReqReturnToLaunch() : base() {}
        public eReqReturnToLaunch (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqReturnToLaunch();}
    }
}
namespace PImplementation
{
    internal partial class eReqMissionStart : PEvent
    {
        public eReqMissionStart() : base() {}
        public eReqMissionStart (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqMissionStart();}
    }
}
namespace PImplementation
{
    internal partial class eReqClearMission : PEvent
    {
        public eReqClearMission() : base() {}
        public eReqClearMission (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqClearMission();}
    }
}
namespace PImplementation
{
    internal partial class eReqInAirStatus : PEvent
    {
        public eReqInAirStatus() : base() {}
        public eReqInAirStatus (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqInAirStatus();}
    }
}
namespace PImplementation
{
    internal partial class eReqMissionFinished : PEvent
    {
        public eReqMissionFinished() : base() {}
        public eReqMissionFinished (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqMissionFinished();}
    }
}
namespace PImplementation
{
    internal partial class eReqWaitForDisarmed : PEvent
    {
        public eReqWaitForDisarmed() : base() {}
        public eReqWaitForDisarmed (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqWaitForDisarmed();}
    }
}
namespace PImplementation
{
    internal partial class eReqAtTakeoffAlt : PEvent
    {
        public eReqAtTakeoffAlt() : base() {}
        public eReqAtTakeoffAlt (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqAtTakeoffAlt();}
    }
}
namespace PImplementation
{
    internal partial class eReqLand : PEvent
    {
        public eReqLand() : base() {}
        public eReqLand (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqLand();}
    }
}
namespace PImplementation
{
    internal partial class eReqLandingState : PEvent
    {
        public eReqLandingState() : base() {}
        public eReqLandingState (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqLandingState();}
    }
}
namespace PImplementation
{
    internal partial class eReqDisarm : PEvent
    {
        public eReqDisarm() : base() {}
        public eReqDisarm (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReqDisarm();}
    }
}
namespace PImplementation
{
    internal partial class eRespArm : PEvent
    {
        public eRespArm() : base() {}
        public eRespArm (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespArm();}
    }
}
namespace PImplementation
{
    internal partial class eRespTelemetryHealth : PEvent
    {
        public eRespTelemetryHealth() : base() {}
        public eRespTelemetryHealth (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespTelemetryHealth();}
    }
}
namespace PImplementation
{
    internal partial class eRespSystemStatus : PEvent
    {
        public eRespSystemStatus() : base() {}
        public eRespSystemStatus (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespSystemStatus();}
    }
}
namespace PImplementation
{
    internal partial class eRespTakeoff : PEvent
    {
        public eRespTakeoff() : base() {}
        public eRespTakeoff (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespTakeoff();}
    }
}
namespace PImplementation
{
    internal partial class eRespMissionUpload : PEvent
    {
        public eRespMissionUpload() : base() {}
        public eRespMissionUpload (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespMissionUpload();}
    }
}
namespace PImplementation
{
    internal partial class eRespBatteryRemaining : PEvent
    {
        public eRespBatteryRemaining() : base() {}
        public eRespBatteryRemaining (PrtFloat payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespBatteryRemaining();}
    }
}
namespace PImplementation
{
    internal partial class eRespHold : PEvent
    {
        public eRespHold() : base() {}
        public eRespHold (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespHold();}
    }
}
namespace PImplementation
{
    internal partial class eRespReturnToLaunch : PEvent
    {
        public eRespReturnToLaunch() : base() {}
        public eRespReturnToLaunch (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespReturnToLaunch();}
    }
}
namespace PImplementation
{
    internal partial class eRespMissionFinished : PEvent
    {
        public eRespMissionFinished() : base() {}
        public eRespMissionFinished (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespMissionFinished();}
    }
}
namespace PImplementation
{
    internal partial class eRespMissionStart : PEvent
    {
        public eRespMissionStart() : base() {}
        public eRespMissionStart (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespMissionStart();}
    }
}
namespace PImplementation
{
    internal partial class eRespClearMission : PEvent
    {
        public eRespClearMission() : base() {}
        public eRespClearMission (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespClearMission();}
    }
}
namespace PImplementation
{
    internal partial class eRespInAirStatus : PEvent
    {
        public eRespInAirStatus() : base() {}
        public eRespInAirStatus (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespInAirStatus();}
    }
}
namespace PImplementation
{
    internal partial class eRespWaitForDisarmed : PEvent
    {
        public eRespWaitForDisarmed() : base() {}
        public eRespWaitForDisarmed (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespWaitForDisarmed();}
    }
}
namespace PImplementation
{
    internal partial class eRespAtTakeoffAlt : PEvent
    {
        public eRespAtTakeoffAlt() : base() {}
        public eRespAtTakeoffAlt (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespAtTakeoffAlt();}
    }
}
namespace PImplementation
{
    internal partial class eRespLand : PEvent
    {
        public eRespLand() : base() {}
        public eRespLand (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespLand();}
    }
}
namespace PImplementation
{
    internal partial class eRespLandingState : PEvent
    {
        public eRespLandingState() : base() {}
        public eRespLandingState (PrtInt payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespLandingState();}
    }
}
namespace PImplementation
{
    internal partial class eRespDisarm : PEvent
    {
        public eRespDisarm() : base() {}
        public eRespDisarm (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eRespDisarm();}
    }
}
namespace PImplementation
{
    internal partial class eLinkInitialized : PEvent
    {
        public eLinkInitialized() : base() {}
        public eLinkInitialized (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eLinkInitialized();}
    }
}
namespace PImplementation
{
    internal partial class eTakeoffReached : PEvent
    {
        public eTakeoffReached() : base() {}
        public eTakeoffReached (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eTakeoffReached();}
    }
}
namespace PImplementation
{
    internal partial class eBatteryRemaining : PEvent
    {
        public eBatteryRemaining() : base() {}
        public eBatteryRemaining (PrtInt payload): base(payload){ }
        public override IPrtValue Clone() { return new eBatteryRemaining();}
    }
}
namespace PImplementation
{
    internal partial class eSystemConnected : PEvent
    {
        public eSystemConnected() : base() {}
        public eSystemConnected (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eSystemConnected();}
    }
}
namespace PImplementation
{
    internal partial class eMissionUploaded : PEvent
    {
        public eMissionUploaded() : base() {}
        public eMissionUploaded (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eMissionUploaded();}
    }
}
namespace PImplementation
{
    internal partial class eMissionStarted : PEvent
    {
        public eMissionStarted() : base() {}
        public eMissionStarted (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eMissionStarted();}
    }
}
namespace PImplementation
{
    internal partial class eMissionCleared : PEvent
    {
        public eMissionCleared() : base() {}
        public eMissionCleared (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eMissionCleared();}
    }
}
namespace PImplementation
{
    internal partial class eTelemetryHealthAllOK : PEvent
    {
        public eTelemetryHealthAllOK() : base() {}
        public eTelemetryHealthAllOK (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eTelemetryHealthAllOK();}
    }
}
namespace PImplementation
{
    internal partial class eInAirStatus : PEvent
    {
        public eInAirStatus() : base() {}
        public eInAirStatus (PrtBool payload): base(payload){ }
        public override IPrtValue Clone() { return new eInAirStatus();}
    }
}
namespace PImplementation
{
    internal partial class eSpec_PreFlight : PEvent
    {
        public eSpec_PreFlight() : base() {}
        public eSpec_PreFlight (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eSpec_PreFlight();}
    }
}
namespace PImplementation
{
    internal partial class eError : PEvent
    {
        public eError() : base() {}
        public eError (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eError();}
    }
}
namespace PImplementation
{
    internal partial class eArm : PEvent
    {
        public eArm() : base() {}
        public eArm (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eArm();}
    }
}
namespace PImplementation
{
    internal partial class eTakeoff : PEvent
    {
        public eTakeoff() : base() {}
        public eTakeoff (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eTakeoff();}
    }
}
namespace PImplementation
{
    internal partial class eHold : PEvent
    {
        public eHold() : base() {}
        public eHold (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eHold();}
    }
}
namespace PImplementation
{
    internal partial class eInAir : PEvent
    {
        public eInAir() : base() {}
        public eInAir (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eInAir();}
    }
}
namespace PImplementation
{
    internal partial class eLanding : PEvent
    {
        public eLanding() : base() {}
        public eLanding (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eLanding();}
    }
}
namespace PImplementation
{
    internal partial class eDisarmed : PEvent
    {
        public eDisarmed() : base() {}
        public eDisarmed (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eDisarmed();}
    }
}
namespace PImplementation
{
    internal partial class eReturnToLaunch : PEvent
    {
        public eReturnToLaunch() : base() {}
        public eReturnToLaunch (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eReturnToLaunch();}
    }
}
namespace PImplementation
{
    internal partial class eShutdownSystem : PEvent
    {
        public eShutdownSystem() : base() {}
        public eShutdownSystem (IPrtValue payload): base(payload){ }
        public override IPrtValue Clone() { return new eShutdownSystem();}
    }
}
namespace PImplementation
{
    internal partial class eMavSDKReq : PEvent
    {
        public eMavSDKReq() : base() {}
        public eMavSDKReq (PrtInt payload): base(payload){ }
        public override IPrtValue Clone() { return new eMavSDKReq();}
    }
}
namespace PImplementation
{
    internal partial class eMavSDKResp : PEvent
    {
        public eMavSDKResp() : base() {}
        public eMavSDKResp (PrtInt payload): base(payload){ }
        public override IPrtValue Clone() { return new eMavSDKResp();}
    }
}
namespace PImplementation
{
    public static partial class GlobalFunctions
    {
        public static void UnReliableSend(PMachineValue target, PEvent message, IPrtValue payload, PEvent specEvent, IPrtValue specLoad, PMachine currentMachine)
        {
            PrtBool TMP_tmp0 = ((PrtBool)false);
            PMachineValue TMP_tmp1 = null;
            PEvent TMP_tmp2 = null;
            IPrtValue TMP_tmp3 = null;
            TMP_tmp0 = (PrtBool)(((PrtBool)currentMachine.TryRandomBool()));
            if (TMP_tmp0)
            {
                currentMachine.Announce((Event)specEvent, specLoad);
                TMP_tmp1 = (PMachineValue)(((PMachineValue)((IPrtValue)target)?.Clone()));
                TMP_tmp2 = (PEvent)(((PEvent)((IPrtValue)message)?.Clone()));
                TMP_tmp3 = (IPrtValue)(((IPrtValue)((IPrtValue)payload)?.Clone()));
                currentMachine.TrySendEvent(TMP_tmp1, (Event)TMP_tmp2, TMP_tmp3);
            }
        }
    }
}
namespace PImplementation
{
    internal partial class FailureInjectorGPT : PMachine
    {
        private PMachineValue targetMachine = null;
        public class ConstructorEvent : PEvent{public ConstructorEvent(PMachineValue val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((PMachineValue)value); }
        public FailureInjectorGPT() {
            this.sends.Add(nameof(eArm));
            this.sends.Add(nameof(eBatteryRemaining));
            this.sends.Add(nameof(eDisarmed));
            this.sends.Add(nameof(eError));
            this.sends.Add(nameof(eHold));
            this.sends.Add(nameof(eInAir));
            this.sends.Add(nameof(eInAirStatus));
            this.sends.Add(nameof(eLanding));
            this.sends.Add(nameof(eLinkInitialized));
            this.sends.Add(nameof(eMavSDKReq));
            this.sends.Add(nameof(eMavSDKResp));
            this.sends.Add(nameof(eMissionCleared));
            this.sends.Add(nameof(eMissionStarted));
            this.sends.Add(nameof(eMissionUploaded));
            this.sends.Add(nameof(eRaiseError));
            this.sends.Add(nameof(eReqArm));
            this.sends.Add(nameof(eReqAtTakeoffAlt));
            this.sends.Add(nameof(eReqBatteryRemaining));
            this.sends.Add(nameof(eReqClearMission));
            this.sends.Add(nameof(eReqDisarm));
            this.sends.Add(nameof(eReqHold));
            this.sends.Add(nameof(eReqInAirStatus));
            this.sends.Add(nameof(eReqLand));
            this.sends.Add(nameof(eReqLandingState));
            this.sends.Add(nameof(eReqMissionFinished));
            this.sends.Add(nameof(eReqMissionStart));
            this.sends.Add(nameof(eReqMissionUpload));
            this.sends.Add(nameof(eReqReturnToLaunch));
            this.sends.Add(nameof(eReqSystemStatus));
            this.sends.Add(nameof(eReqTakeoff));
            this.sends.Add(nameof(eReqTelemetryHealth));
            this.sends.Add(nameof(eReqWaitForDisarmed));
            this.sends.Add(nameof(eRespArm));
            this.sends.Add(nameof(eRespAtTakeoffAlt));
            this.sends.Add(nameof(eRespBatteryRemaining));
            this.sends.Add(nameof(eRespClearMission));
            this.sends.Add(nameof(eRespDisarm));
            this.sends.Add(nameof(eRespHold));
            this.sends.Add(nameof(eRespInAirStatus));
            this.sends.Add(nameof(eRespLand));
            this.sends.Add(nameof(eRespLandingState));
            this.sends.Add(nameof(eRespMissionFinished));
            this.sends.Add(nameof(eRespMissionStart));
            this.sends.Add(nameof(eRespMissionUpload));
            this.sends.Add(nameof(eRespReturnToLaunch));
            this.sends.Add(nameof(eRespSystemStatus));
            this.sends.Add(nameof(eRespTakeoff));
            this.sends.Add(nameof(eRespTelemetryHealth));
            this.sends.Add(nameof(eRespWaitForDisarmed));
            this.sends.Add(nameof(eReturnToLaunch));
            this.sends.Add(nameof(eShutdownSystem));
            this.sends.Add(nameof(eSpec_PreFlight));
            this.sends.Add(nameof(eSystemConnected));
            this.sends.Add(nameof(eTakeoff));
            this.sends.Add(nameof(eTakeoffReached));
            this.sends.Add(nameof(eTelemetryHealthAllOK));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eArm));
            this.receives.Add(nameof(eBatteryRemaining));
            this.receives.Add(nameof(eDisarmed));
            this.receives.Add(nameof(eError));
            this.receives.Add(nameof(eHold));
            this.receives.Add(nameof(eInAir));
            this.receives.Add(nameof(eInAirStatus));
            this.receives.Add(nameof(eLanding));
            this.receives.Add(nameof(eLinkInitialized));
            this.receives.Add(nameof(eMavSDKReq));
            this.receives.Add(nameof(eMavSDKResp));
            this.receives.Add(nameof(eMissionCleared));
            this.receives.Add(nameof(eMissionStarted));
            this.receives.Add(nameof(eMissionUploaded));
            this.receives.Add(nameof(eRaiseError));
            this.receives.Add(nameof(eReqArm));
            this.receives.Add(nameof(eReqAtTakeoffAlt));
            this.receives.Add(nameof(eReqBatteryRemaining));
            this.receives.Add(nameof(eReqClearMission));
            this.receives.Add(nameof(eReqDisarm));
            this.receives.Add(nameof(eReqHold));
            this.receives.Add(nameof(eReqInAirStatus));
            this.receives.Add(nameof(eReqLand));
            this.receives.Add(nameof(eReqLandingState));
            this.receives.Add(nameof(eReqMissionFinished));
            this.receives.Add(nameof(eReqMissionStart));
            this.receives.Add(nameof(eReqMissionUpload));
            this.receives.Add(nameof(eReqReturnToLaunch));
            this.receives.Add(nameof(eReqSystemStatus));
            this.receives.Add(nameof(eReqTakeoff));
            this.receives.Add(nameof(eReqTelemetryHealth));
            this.receives.Add(nameof(eReqWaitForDisarmed));
            this.receives.Add(nameof(eRespArm));
            this.receives.Add(nameof(eRespAtTakeoffAlt));
            this.receives.Add(nameof(eRespBatteryRemaining));
            this.receives.Add(nameof(eRespClearMission));
            this.receives.Add(nameof(eRespDisarm));
            this.receives.Add(nameof(eRespHold));
            this.receives.Add(nameof(eRespInAirStatus));
            this.receives.Add(nameof(eRespLand));
            this.receives.Add(nameof(eRespLandingState));
            this.receives.Add(nameof(eRespMissionFinished));
            this.receives.Add(nameof(eRespMissionStart));
            this.receives.Add(nameof(eRespMissionUpload));
            this.receives.Add(nameof(eRespReturnToLaunch));
            this.receives.Add(nameof(eRespSystemStatus));
            this.receives.Add(nameof(eRespTakeoff));
            this.receives.Add(nameof(eRespTelemetryHealth));
            this.receives.Add(nameof(eRespWaitForDisarmed));
            this.receives.Add(nameof(eReturnToLaunch));
            this.receives.Add(nameof(eShutdownSystem));
            this.receives.Add(nameof(eSpec_PreFlight));
            this.receives.Add(nameof(eSystemConnected));
            this.receives.Add(nameof(eTakeoff));
            this.receives.Add(nameof(eTakeoffReached));
            this.receives.Add(nameof(eTelemetryHealthAllOK));
            this.receives.Add(nameof(PHalt));
        }
        
        public void Anon(Event currentMachine_dequeuedEvent)
        {
            FailureInjectorGPT currentMachine = this;
            PMachineValue target_1 = (PMachineValue)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            targetMachine = (PMachineValue)(((PMachineValue)((IPrtValue)target_1)?.Clone()));
            currentMachine.TryGotoState<InjectFailures>();
            return;
        }
        public void Anon_1(Event currentMachine_dequeuedEvent)
        {
            FailureInjectorGPT currentMachine = this;
            PrtInt rng = ((PrtInt)0);
            PrtInt TMP_tmp0_1 = ((PrtInt)0);
            PrtBool TMP_tmp1_1 = ((PrtBool)false);
            PMachineValue TMP_tmp2_1 = null;
            PEvent TMP_tmp3_1 = null;
            PrtInt TMP_tmp4 = ((PrtInt)0);
            PrtBool TMP_tmp5 = ((PrtBool)false);
            PMachineValue TMP_tmp6 = null;
            PEvent TMP_tmp7 = null;
            PrtBool TMP_tmp8 = ((PrtBool)false);
            PrtBool TMP_tmp9 = ((PrtBool)false);
            PMachineValue TMP_tmp10 = null;
            PEvent TMP_tmp11 = null;
            PrtBool TMP_tmp12 = ((PrtBool)false);
            PrtBool TMP_tmp13 = ((PrtBool)false);
            PMachineValue TMP_tmp14 = null;
            PEvent TMP_tmp15 = null;
            PrtBool TMP_tmp16 = ((PrtBool)false);
            PrtBool TMP_tmp17 = ((PrtBool)false);
            PMachineValue TMP_tmp18 = null;
            PEvent TMP_tmp19 = null;
            PrtBool TMP_tmp20 = ((PrtBool)false);
            PrtBool TMP_tmp21 = ((PrtBool)false);
            PMachineValue TMP_tmp22 = null;
            PEvent TMP_tmp23 = null;
            PrtBool TMP_tmp24 = ((PrtBool)false);
            PrtBool TMP_tmp25 = ((PrtBool)false);
            PMachineValue TMP_tmp26 = null;
            PEvent TMP_tmp27 = null;
            PrtBool TMP_tmp28 = ((PrtBool)false);
            PEvent TMP_tmp29 = null;
            TMP_tmp0_1 = (PrtInt)(((PrtInt)currentMachine.TryRandom(((PrtInt)(7)))));
            rng = TMP_tmp0_1;
            TMP_tmp1_1 = (PrtBool)((PrtValues.SafeEquals(rng,((PrtInt)(0)))));
            if (TMP_tmp1_1)
            {
                TMP_tmp2_1 = (PMachineValue)(((PMachineValue)((IPrtValue)targetMachine)?.Clone()));
                TMP_tmp3_1 = (PEvent)(new eBatteryRemaining(((PrtInt)0)));
                TMP_tmp4 = (PrtInt)((PrtEnum.Get("CRITICAL")));
                currentMachine.TrySendEvent(TMP_tmp2_1, (Event)TMP_tmp3_1, TMP_tmp4);
            }
            else
            {
                TMP_tmp5 = (PrtBool)((PrtValues.SafeEquals(rng,((PrtInt)(1)))));
                if (TMP_tmp5)
                {
                    TMP_tmp6 = (PMachineValue)(((PMachineValue)((IPrtValue)targetMachine)?.Clone()));
                    TMP_tmp7 = (PEvent)(new eTelemetryHealthAllOK(((PrtBool)false)));
                    TMP_tmp8 = (PrtBool)(((PrtBool)false));
                    currentMachine.TrySendEvent(TMP_tmp6, (Event)TMP_tmp7, TMP_tmp8);
                }
                else
                {
                    TMP_tmp9 = (PrtBool)((PrtValues.SafeEquals(rng,((PrtInt)(2)))));
                    if (TMP_tmp9)
                    {
                        TMP_tmp10 = (PMachineValue)(((PMachineValue)((IPrtValue)targetMachine)?.Clone()));
                        TMP_tmp11 = (PEvent)(new eMissionUploaded(((PrtBool)false)));
                        TMP_tmp12 = (PrtBool)(((PrtBool)false));
                        currentMachine.TrySendEvent(TMP_tmp10, (Event)TMP_tmp11, TMP_tmp12);
                    }
                    else
                    {
                        TMP_tmp13 = (PrtBool)((PrtValues.SafeEquals(rng,((PrtInt)(3)))));
                        if (TMP_tmp13)
                        {
                            TMP_tmp14 = (PMachineValue)(((PMachineValue)((IPrtValue)targetMachine)?.Clone()));
                            TMP_tmp15 = (PEvent)(new eSystemConnected(((PrtBool)false)));
                            TMP_tmp16 = (PrtBool)(((PrtBool)false));
                            currentMachine.TrySendEvent(TMP_tmp14, (Event)TMP_tmp15, TMP_tmp16);
                        }
                        else
                        {
                            TMP_tmp17 = (PrtBool)((PrtValues.SafeEquals(rng,((PrtInt)(4)))));
                            if (TMP_tmp17)
                            {
                                TMP_tmp18 = (PMachineValue)(((PMachineValue)((IPrtValue)targetMachine)?.Clone()));
                                TMP_tmp19 = (PEvent)(new eRespArm(((PrtBool)false)));
                                TMP_tmp20 = (PrtBool)(((PrtBool)false));
                                currentMachine.TrySendEvent(TMP_tmp18, (Event)TMP_tmp19, TMP_tmp20);
                            }
                            else
                            {
                                TMP_tmp21 = (PrtBool)((PrtValues.SafeEquals(rng,((PrtInt)(5)))));
                                if (TMP_tmp21)
                                {
                                    TMP_tmp22 = (PMachineValue)(((PMachineValue)((IPrtValue)targetMachine)?.Clone()));
                                    TMP_tmp23 = (PEvent)(new eRespTakeoff(((PrtBool)false)));
                                    TMP_tmp24 = (PrtBool)(((PrtBool)false));
                                    currentMachine.TrySendEvent(TMP_tmp22, (Event)TMP_tmp23, TMP_tmp24);
                                }
                                else
                                {
                                    TMP_tmp25 = (PrtBool)((PrtValues.SafeEquals(rng,((PrtInt)(6)))));
                                    if (TMP_tmp25)
                                    {
                                        TMP_tmp26 = (PMachineValue)(((PMachineValue)((IPrtValue)targetMachine)?.Clone()));
                                        TMP_tmp27 = (PEvent)(new eMissionStarted(((PrtBool)false)));
                                        TMP_tmp28 = (PrtBool)(((PrtBool)false));
                                        currentMachine.TrySendEvent(TMP_tmp26, (Event)TMP_tmp27, TMP_tmp28);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            TMP_tmp29 = (PEvent)(new PHalt(null));
            currentMachine.TryRaiseEvent((Event)TMP_tmp29);
            return;
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon))]
        class Init : State
        {
        }
        [OnEntry(nameof(Anon_1))]
        class InjectFailures : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class FlightController : PMachine
    {
        private PMachineValue mavsdk = null;
        private PMachineValue drone = null;
        public class ConstructorEvent : PEvent{public ConstructorEvent(PMachineValue val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((PMachineValue)value); }
        public FlightController() {
            this.sends.Add(nameof(eArm));
            this.sends.Add(nameof(eBatteryRemaining));
            this.sends.Add(nameof(eDisarmed));
            this.sends.Add(nameof(eError));
            this.sends.Add(nameof(eHold));
            this.sends.Add(nameof(eInAir));
            this.sends.Add(nameof(eInAirStatus));
            this.sends.Add(nameof(eLanding));
            this.sends.Add(nameof(eLinkInitialized));
            this.sends.Add(nameof(eMavSDKReq));
            this.sends.Add(nameof(eMavSDKResp));
            this.sends.Add(nameof(eMissionCleared));
            this.sends.Add(nameof(eMissionStarted));
            this.sends.Add(nameof(eMissionUploaded));
            this.sends.Add(nameof(eRaiseError));
            this.sends.Add(nameof(eReqArm));
            this.sends.Add(nameof(eReqAtTakeoffAlt));
            this.sends.Add(nameof(eReqBatteryRemaining));
            this.sends.Add(nameof(eReqClearMission));
            this.sends.Add(nameof(eReqDisarm));
            this.sends.Add(nameof(eReqHold));
            this.sends.Add(nameof(eReqInAirStatus));
            this.sends.Add(nameof(eReqLand));
            this.sends.Add(nameof(eReqLandingState));
            this.sends.Add(nameof(eReqMissionFinished));
            this.sends.Add(nameof(eReqMissionStart));
            this.sends.Add(nameof(eReqMissionUpload));
            this.sends.Add(nameof(eReqReturnToLaunch));
            this.sends.Add(nameof(eReqSystemStatus));
            this.sends.Add(nameof(eReqTakeoff));
            this.sends.Add(nameof(eReqTelemetryHealth));
            this.sends.Add(nameof(eReqWaitForDisarmed));
            this.sends.Add(nameof(eRespArm));
            this.sends.Add(nameof(eRespAtTakeoffAlt));
            this.sends.Add(nameof(eRespBatteryRemaining));
            this.sends.Add(nameof(eRespClearMission));
            this.sends.Add(nameof(eRespDisarm));
            this.sends.Add(nameof(eRespHold));
            this.sends.Add(nameof(eRespInAirStatus));
            this.sends.Add(nameof(eRespLand));
            this.sends.Add(nameof(eRespLandingState));
            this.sends.Add(nameof(eRespMissionFinished));
            this.sends.Add(nameof(eRespMissionStart));
            this.sends.Add(nameof(eRespMissionUpload));
            this.sends.Add(nameof(eRespReturnToLaunch));
            this.sends.Add(nameof(eRespSystemStatus));
            this.sends.Add(nameof(eRespTakeoff));
            this.sends.Add(nameof(eRespTelemetryHealth));
            this.sends.Add(nameof(eRespWaitForDisarmed));
            this.sends.Add(nameof(eReturnToLaunch));
            this.sends.Add(nameof(eShutdownSystem));
            this.sends.Add(nameof(eSpec_PreFlight));
            this.sends.Add(nameof(eSystemConnected));
            this.sends.Add(nameof(eTakeoff));
            this.sends.Add(nameof(eTakeoffReached));
            this.sends.Add(nameof(eTelemetryHealthAllOK));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eArm));
            this.receives.Add(nameof(eBatteryRemaining));
            this.receives.Add(nameof(eDisarmed));
            this.receives.Add(nameof(eError));
            this.receives.Add(nameof(eHold));
            this.receives.Add(nameof(eInAir));
            this.receives.Add(nameof(eInAirStatus));
            this.receives.Add(nameof(eLanding));
            this.receives.Add(nameof(eLinkInitialized));
            this.receives.Add(nameof(eMavSDKReq));
            this.receives.Add(nameof(eMavSDKResp));
            this.receives.Add(nameof(eMissionCleared));
            this.receives.Add(nameof(eMissionStarted));
            this.receives.Add(nameof(eMissionUploaded));
            this.receives.Add(nameof(eRaiseError));
            this.receives.Add(nameof(eReqArm));
            this.receives.Add(nameof(eReqAtTakeoffAlt));
            this.receives.Add(nameof(eReqBatteryRemaining));
            this.receives.Add(nameof(eReqClearMission));
            this.receives.Add(nameof(eReqDisarm));
            this.receives.Add(nameof(eReqHold));
            this.receives.Add(nameof(eReqInAirStatus));
            this.receives.Add(nameof(eReqLand));
            this.receives.Add(nameof(eReqLandingState));
            this.receives.Add(nameof(eReqMissionFinished));
            this.receives.Add(nameof(eReqMissionStart));
            this.receives.Add(nameof(eReqMissionUpload));
            this.receives.Add(nameof(eReqReturnToLaunch));
            this.receives.Add(nameof(eReqSystemStatus));
            this.receives.Add(nameof(eReqTakeoff));
            this.receives.Add(nameof(eReqTelemetryHealth));
            this.receives.Add(nameof(eReqWaitForDisarmed));
            this.receives.Add(nameof(eRespArm));
            this.receives.Add(nameof(eRespAtTakeoffAlt));
            this.receives.Add(nameof(eRespBatteryRemaining));
            this.receives.Add(nameof(eRespClearMission));
            this.receives.Add(nameof(eRespDisarm));
            this.receives.Add(nameof(eRespHold));
            this.receives.Add(nameof(eRespInAirStatus));
            this.receives.Add(nameof(eRespLand));
            this.receives.Add(nameof(eRespLandingState));
            this.receives.Add(nameof(eRespMissionFinished));
            this.receives.Add(nameof(eRespMissionStart));
            this.receives.Add(nameof(eRespMissionUpload));
            this.receives.Add(nameof(eRespReturnToLaunch));
            this.receives.Add(nameof(eRespSystemStatus));
            this.receives.Add(nameof(eRespTakeoff));
            this.receives.Add(nameof(eRespTelemetryHealth));
            this.receives.Add(nameof(eRespWaitForDisarmed));
            this.receives.Add(nameof(eReturnToLaunch));
            this.receives.Add(nameof(eShutdownSystem));
            this.receives.Add(nameof(eSpec_PreFlight));
            this.receives.Add(nameof(eSystemConnected));
            this.receives.Add(nameof(eTakeoff));
            this.receives.Add(nameof(eTakeoffReached));
            this.receives.Add(nameof(eTelemetryHealthAllOK));
            this.receives.Add(nameof(PHalt));
            this.creates.Add(nameof(I_MavSDK));
        }
        
        public void Anon_2(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PMachineValue d = (PMachineValue)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_2 = null;
            PMachineValue TMP_tmp1_2 = null;
            drone = (PMachineValue)(((PMachineValue)((IPrtValue)d)?.Clone()));
            TMP_tmp0_2 = (PMachineValue)(currentMachine.self);
            TMP_tmp1_2 = (PMachineValue)(currentMachine.CreateInterface<I_MavSDK>( currentMachine, TMP_tmp0_2));
            mavsdk = (PMachineValue)TMP_tmp1_2;
        }
        public void Anon_3(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            currentMachine.TryGotoState<Error>();
            return;
        }
        public async Task Anon_4(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PMachineValue TMP_tmp0_3 = null;
            PEvent TMP_tmp1_3 = null;
            PrtBool TMP_tmp2_2 = ((PrtBool)false);
            PMachineValue TMP_tmp3_2 = null;
            PEvent TMP_tmp4_1 = null;
            PrtBool TMP_tmp5_1 = ((PrtBool)false);
            PMachineValue TMP_tmp6_1 = null;
            PEvent TMP_tmp7_1 = null;
            PrtBool TMP_tmp8_1 = ((PrtBool)false);
            PMachineValue TMP_tmp9_1 = null;
            PEvent TMP_tmp10_1 = null;
            PrtBool TMP_tmp11_1 = ((PrtBool)false);
            PMachineValue TMP_tmp12_1 = null;
            PEvent TMP_tmp13_1 = null;
            PrtBool TMP_tmp14_1 = ((PrtBool)false);
            PMachineValue TMP_tmp15_1 = null;
            PEvent TMP_tmp16_1 = null;
            currentMachine.Announce((Event)new eSpec_PreFlight(null));
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(0)));
            TMP_tmp0_3 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp1_3 = (PEvent)(new eReqBatteryRemaining(null));
            currentMachine.TrySendEvent(TMP_tmp0_3, (Event)TMP_tmp1_3);
            var PGEN_recvEvent = await currentMachine.TryReceiveEvent(typeof(eBatteryRemaining), typeof(PHalt));
            switch (PGEN_recvEvent) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eBatteryRemaining PGEN_evt: {
                    PrtInt bstate = (PrtInt)(PGEN_evt.Payload);
                    TMP_tmp2_2 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) bstate),PrtValues.Box((long) (PrtEnum.Get("CRITICAL"))))));
                    if (TMP_tmp2_2)
                    {
                        currentMachine.TryGotoState<Shutdown>();
                        return;
                    }
                } break;
            }
            TMP_tmp3_2 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp4_1 = (PEvent)(new eReqClearMission(null));
            currentMachine.TrySendEvent(TMP_tmp3_2, (Event)TMP_tmp4_1);
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(14)));
            var PGEN_recvEvent_1 = await currentMachine.TryReceiveEvent(typeof(eMissionCleared), typeof(PHalt));
            switch (PGEN_recvEvent_1) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eMissionCleared PGEN_evt_1: {
                    PrtBool status = (PrtBool)(PGEN_evt_1.Payload);
                    TMP_tmp5_1 = (PrtBool)(!(status));
                    if (TMP_tmp5_1)
                    {
                        currentMachine.TryGotoState<Error>();
                        return;
                    }
                } break;
            }
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(1)));
            TMP_tmp6_1 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp7_1 = (PEvent)(new eReqMissionUpload(null));
            currentMachine.TrySendEvent(TMP_tmp6_1, (Event)TMP_tmp7_1);
            var PGEN_recvEvent_2 = await currentMachine.TryReceiveEvent(typeof(eMissionUploaded), typeof(PHalt));
            switch (PGEN_recvEvent_2) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eMissionUploaded PGEN_evt_2: {
                    PrtBool payload_1 = (PrtBool)(PGEN_evt_2.Payload);
                    TMP_tmp8_1 = (PrtBool)(!(payload_1));
                    if (TMP_tmp8_1)
                    {
                        currentMachine.TryGotoState<Error>();
                        return;
                    }
                } break;
            }
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(2)));
            TMP_tmp9_1 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp10_1 = (PEvent)(new eReqSystemStatus(null));
            currentMachine.TrySendEvent(TMP_tmp9_1, (Event)TMP_tmp10_1);
            var PGEN_recvEvent_3 = await currentMachine.TryReceiveEvent(typeof(eSystemConnected), typeof(PHalt));
            switch (PGEN_recvEvent_3) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eSystemConnected PGEN_evt_3: {
                    PrtBool connected = (PrtBool)(PGEN_evt_3.Payload);
                    TMP_tmp11_1 = (PrtBool)(!(connected));
                    if (TMP_tmp11_1)
                    {
                        currentMachine.TryGotoState<Error>();
                        return;
                    }
                } break;
            }
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(3)));
            TMP_tmp12_1 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp13_1 = (PEvent)(new eReqTelemetryHealth(null));
            currentMachine.TrySendEvent(TMP_tmp12_1, (Event)TMP_tmp13_1);
            var PGEN_recvEvent_4 = await currentMachine.TryReceiveEvent(typeof(eTelemetryHealthAllOK), typeof(PHalt));
            switch (PGEN_recvEvent_4) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eTelemetryHealthAllOK PGEN_evt_4: {
                    PrtBool health = (PrtBool)(PGEN_evt_4.Payload);
                    TMP_tmp14_1 = (PrtBool)(!(health));
                    if (TMP_tmp14_1)
                    {
                        currentMachine.TryGotoState<Error>();
                        return;
                    }
                } break;
            }
            TMP_tmp15_1 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp16_1 = (PEvent)(new eReqArm(null));
            currentMachine.TrySendEvent(TMP_tmp15_1, (Event)TMP_tmp16_1);
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(4)));
        }
        public void Anon_5(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool connected_1 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_4 = ((PrtBool)false);
            TMP_tmp0_4 = (PrtBool)(!(connected_1));
            if (TMP_tmp0_4)
            {
                currentMachine.TryGotoState<Error>();
                return;
            }
        }
        public void Anon_6(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtInt status_1 = (PrtInt)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_5 = ((PrtBool)false);
            TMP_tmp0_5 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) status_1),PrtValues.Box((long) (PrtEnum.Get("CRITICAL"))))));
            if (TMP_tmp0_5)
            {
                currentMachine.TryGotoState<Shutdown>();
                return;
            }
        }
        public void Anon_7(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool health_1 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_6 = ((PrtBool)false);
            TMP_tmp0_6 = (PrtBool)(!(health_1));
            if (TMP_tmp0_6)
            {
                currentMachine.TryGotoState<Error>();
                return;
            }
        }
        public void Anon_8(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool status_2 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_7 = ((PrtBool)false);
            TMP_tmp0_7 = (PrtBool)(!(status_2));
            if (TMP_tmp0_7)
            {
                currentMachine.TryGotoState<Error>();
                return;
            }
            else
            {
                currentMachine.TryGotoState<Armed>();
                return;
            }
        }
        public void Anon_9(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PMachineValue TMP_tmp0_8 = null;
            PEvent TMP_tmp1_4 = null;
            PMachineValue TMP_tmp2_3 = null;
            PEvent TMP_tmp3_3 = null;
            PMachineValue TMP_tmp4_2 = null;
            PEvent TMP_tmp5_2 = null;
            PMachineValue TMP_tmp6_2 = null;
            PEvent TMP_tmp7_2 = null;
            PrtFloat TMP_tmp8_2 = ((PrtFloat)0.0);
            currentMachine.Announce((Event)new eArm(null));
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(2)));
            TMP_tmp0_8 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp1_4 = (PEvent)(new eReqSystemStatus(null));
            currentMachine.TrySendEvent(TMP_tmp0_8, (Event)TMP_tmp1_4);
            TMP_tmp2_3 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp3_3 = (PEvent)(new eReqBatteryRemaining(null));
            currentMachine.TrySendEvent(TMP_tmp2_3, (Event)TMP_tmp3_3);
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(0)));
            TMP_tmp4_2 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp5_2 = (PEvent)(new eReqTelemetryHealth(null));
            currentMachine.TrySendEvent(TMP_tmp4_2, (Event)TMP_tmp5_2);
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(3)));
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(5)));
            TMP_tmp6_2 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp7_2 = (PEvent)(new eReqTakeoff(((PrtFloat)0.0)));
            TMP_tmp8_2 = (PrtFloat)(((PrtFloat)33));
            currentMachine.TrySendEvent(TMP_tmp6_2, (Event)TMP_tmp7_2, TMP_tmp8_2);
        }
        public void Anon_10(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool connected_2 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_9 = ((PrtBool)false);
            TMP_tmp0_9 = (PrtBool)(!(connected_2));
            if (TMP_tmp0_9)
            {
                currentMachine.TryGotoState<Error>();
                return;
            }
        }
        public void Anon_11(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtInt status_3 = (PrtInt)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_10 = ((PrtBool)false);
            TMP_tmp0_10 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) status_3),PrtValues.Box((long) (PrtEnum.Get("CRITICAL"))))));
            if (TMP_tmp0_10)
            {
                currentMachine.TryGotoState<Disarm>();
                return;
            }
        }
        public void Anon_12(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool health_2 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_11 = ((PrtBool)false);
            TMP_tmp0_11 = (PrtBool)(!(health_2));
            if (TMP_tmp0_11)
            {
                currentMachine.TryGotoState<Disarm>();
                return;
            }
        }
        public void Anon_13(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool res = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_12 = ((PrtBool)false);
            TMP_tmp0_12 = (PrtBool)(!(res));
            if (TMP_tmp0_12)
            {
                currentMachine.TryGotoState<Error>();
                return;
            }
            else
            {
                currentMachine.TryGotoState<Takeoff>();
                return;
            }
        }
        public void Anon_14(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PMachineValue TMP_tmp0_13 = null;
            PEvent TMP_tmp1_5 = null;
            PMachineValue TMP_tmp2_4 = null;
            PEvent TMP_tmp3_4 = null;
            PMachineValue TMP_tmp4_3 = null;
            PEvent TMP_tmp5_3 = null;
            PMachineValue TMP_tmp6_3 = null;
            PEvent TMP_tmp7_3 = null;
            currentMachine.Announce((Event)new eTakeoff(null));
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(2)));
            TMP_tmp0_13 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp1_5 = (PEvent)(new eReqSystemStatus(null));
            currentMachine.TrySendEvent(TMP_tmp0_13, (Event)TMP_tmp1_5);
            TMP_tmp2_4 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp3_4 = (PEvent)(new eReqBatteryRemaining(null));
            currentMachine.TrySendEvent(TMP_tmp2_4, (Event)TMP_tmp3_4);
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(0)));
            TMP_tmp4_3 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp5_3 = (PEvent)(new eReqTelemetryHealth(null));
            currentMachine.TrySendEvent(TMP_tmp4_3, (Event)TMP_tmp5_3);
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(3)));
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(6)));
            TMP_tmp6_3 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp7_3 = (PEvent)(new eReqAtTakeoffAlt(null));
            currentMachine.TrySendEvent(TMP_tmp6_3, (Event)TMP_tmp7_3);
        }
        public void Anon_15(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool connected_3 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_14 = ((PrtBool)false);
            TMP_tmp0_14 = (PrtBool)(!(connected_3));
            if (TMP_tmp0_14)
            {
                currentMachine.TryGotoState<Error>();
                return;
            }
        }
        public async Task Anon_16(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtInt status_4 = (PrtInt)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_15 = ((PrtBool)false);
            TMP_tmp0_15 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) status_4),PrtValues.Box((long) (PrtEnum.Get("CRITICAL"))))));
            if (TMP_tmp0_15)
            {
                await GoRTL();
            }
        }
        public async Task Anon_17(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool health_3 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_16 = ((PrtBool)false);
            TMP_tmp0_16 = (PrtBool)(!(health_3));
            if (TMP_tmp0_16)
            {
                await GoRTL();
            }
        }
        public void Anon_18(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool status_5 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_17 = null;
            PEvent TMP_tmp1_6 = null;
            if (status_5)
            {
                currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(8)));
                TMP_tmp0_17 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
                TMP_tmp1_6 = (PEvent)(new eReqHold(null));
                currentMachine.TrySendEvent(TMP_tmp0_17, (Event)TMP_tmp1_6);
            }
            else
            {
                currentMachine.TryGotoState<Takeoff>();
                return;
            }
        }
        public async Task Anon_19(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool res_1 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            if (res_1)
            {
                currentMachine.TryGotoState<Hold>();
                return;
            }
            else
            {
                await GoRTL();
            }
        }
        public void Anon_20(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PMachineValue TMP_tmp0_18 = null;
            PEvent TMP_tmp1_7 = null;
            PMachineValue TMP_tmp2_5 = null;
            PEvent TMP_tmp3_5 = null;
            PMachineValue TMP_tmp4_4 = null;
            PEvent TMP_tmp5_4 = null;
            PMachineValue TMP_tmp6_4 = null;
            PEvent TMP_tmp7_4 = null;
            currentMachine.Announce((Event)new eHold(null));
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(3)));
            TMP_tmp0_18 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp1_7 = (PEvent)(new eReqTelemetryHealth(null));
            currentMachine.TrySendEvent(TMP_tmp0_18, (Event)TMP_tmp1_7);
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(2)));
            TMP_tmp2_5 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp3_5 = (PEvent)(new eReqSystemStatus(null));
            currentMachine.TrySendEvent(TMP_tmp2_5, (Event)TMP_tmp3_5);
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(0)));
            TMP_tmp4_4 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp5_4 = (PEvent)(new eReqBatteryRemaining(null));
            currentMachine.TrySendEvent(TMP_tmp4_4, (Event)TMP_tmp5_4);
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(9)));
            TMP_tmp6_4 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp7_4 = (PEvent)(new eReqMissionStart(null));
            currentMachine.TrySendEvent(TMP_tmp6_4, (Event)TMP_tmp7_4);
        }
        public void Anon_21(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool connected_4 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_19 = ((PrtBool)false);
            TMP_tmp0_19 = (PrtBool)(!(connected_4));
            if (TMP_tmp0_19)
            {
                currentMachine.TryGotoState<Error>();
                return;
            }
        }
        public async Task Anon_22(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtInt status_6 = (PrtInt)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_20 = ((PrtBool)false);
            TMP_tmp0_20 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) status_6),PrtValues.Box((long) (PrtEnum.Get("CRITICAL"))))));
            if (TMP_tmp0_20)
            {
                await GoRTL();
            }
        }
        public async Task Anon_23(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool health_4 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_21 = ((PrtBool)false);
            TMP_tmp0_21 = (PrtBool)(!(health_4));
            if (TMP_tmp0_21)
            {
                await GoRTL();
            }
        }
        public void Anon_24(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool started = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_22 = ((PrtBool)false);
            TMP_tmp0_22 = (PrtBool)(!(started));
            if (TMP_tmp0_22)
            {
                currentMachine.TryGotoState<Error>();
                return;
            }
            else
            {
                currentMachine.TryGotoState<Mission>();
                return;
            }
        }
        public void Anon_25(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PMachineValue TMP_tmp0_23 = null;
            PEvent TMP_tmp1_8 = null;
            PMachineValue TMP_tmp2_6 = null;
            PEvent TMP_tmp3_6 = null;
            PMachineValue TMP_tmp4_5 = null;
            PEvent TMP_tmp5_5 = null;
            PMachineValue TMP_tmp6_5 = null;
            PEvent TMP_tmp7_5 = null;
            currentMachine.Announce((Event)new eInAir(null));
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(3)));
            TMP_tmp0_23 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp1_8 = (PEvent)(new eReqTelemetryHealth(null));
            currentMachine.TrySendEvent(TMP_tmp0_23, (Event)TMP_tmp1_8);
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(2)));
            TMP_tmp2_6 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp3_6 = (PEvent)(new eReqSystemStatus(null));
            currentMachine.TrySendEvent(TMP_tmp2_6, (Event)TMP_tmp3_6);
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(0)));
            TMP_tmp4_5 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp5_5 = (PEvent)(new eReqBatteryRemaining(null));
            currentMachine.TrySendEvent(TMP_tmp4_5, (Event)TMP_tmp5_5);
            TMP_tmp6_5 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp7_5 = (PEvent)(new eReqMissionFinished(null));
            currentMachine.TrySendEvent(TMP_tmp6_5, (Event)TMP_tmp7_5);
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(10)));
        }
        public void Anon_26(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool connected_5 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_24 = ((PrtBool)false);
            TMP_tmp0_24 = (PrtBool)(!(connected_5));
            if (TMP_tmp0_24)
            {
                currentMachine.TryGotoState<Error>();
                return;
            }
        }
        public async Task Anon_27(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtInt status_7 = (PrtInt)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_25 = ((PrtBool)false);
            TMP_tmp0_25 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) status_7),PrtValues.Box((long) (PrtEnum.Get("CRITICAL"))))));
            if (TMP_tmp0_25)
            {
                await GoRTL();
            }
        }
        public async Task Anon_28(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool health_5 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_26 = ((PrtBool)false);
            TMP_tmp0_26 = (PrtBool)(!(health_5));
            if (TMP_tmp0_26)
            {
                await GoRTL();
            }
        }
        public void Anon_29(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool status_8 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_27 = null;
            PEvent TMP_tmp1_9 = null;
            if (status_8)
            {
                currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(11)));
                TMP_tmp0_27 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
                TMP_tmp1_9 = (PEvent)(new eReqLand(null));
                currentMachine.TrySendEvent(TMP_tmp0_27, (Event)TMP_tmp1_9);
            }
            else
            {
                currentMachine.TryGotoState<Mission>();
                return;
            }
        }
        public async Task Anon_30(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool status_9 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_28 = ((PrtBool)false);
            TMP_tmp0_28 = (PrtBool)(!(status_9));
            if (TMP_tmp0_28)
            {
                await GoRTL();
            }
            else
            {
                currentMachine.TryGotoState<Land>();
                return;
            }
        }
        public void Anon_31(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PMachineValue TMP_tmp0_29 = null;
            PEvent TMP_tmp1_10 = null;
            PMachineValue TMP_tmp2_7 = null;
            PEvent TMP_tmp3_7 = null;
            currentMachine.Announce((Event)new eLanding(null));
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(2)));
            TMP_tmp0_29 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp1_10 = (PEvent)(new eReqSystemStatus(null));
            currentMachine.TrySendEvent(TMP_tmp0_29, (Event)TMP_tmp1_10);
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(12)));
            TMP_tmp2_7 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp3_7 = (PEvent)(new eReqLandingState(null));
            currentMachine.TrySendEvent(TMP_tmp2_7, (Event)TMP_tmp3_7);
        }
        public void Anon_32(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool connected_6 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_30 = ((PrtBool)false);
            TMP_tmp0_30 = (PrtBool)(!(connected_6));
            if (TMP_tmp0_30)
            {
                currentMachine.TryGotoState<Error>();
                return;
            }
        }
        public void Anon_33(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtInt val = (PrtInt)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_31 = ((PrtBool)false);
            TMP_tmp0_31 = (PrtBool)((PrtValues.SafeEquals(val,((PrtInt)(1)))));
            if (TMP_tmp0_31)
            {
                currentMachine.TryGotoState<Disarm>();
                return;
            }
            else
            {
                currentMachine.TryGotoState<Land>();
                return;
            }
        }
        public void Anon_34(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PMachineValue TMP_tmp0_32 = null;
            PEvent TMP_tmp1_11 = null;
            PMachineValue TMP_tmp2_8 = null;
            PEvent TMP_tmp3_8 = null;
            currentMachine.Announce((Event)new eDisarmed(null));
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(2)));
            TMP_tmp0_32 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp1_11 = (PEvent)(new eReqSystemStatus(null));
            currentMachine.TrySendEvent(TMP_tmp0_32, (Event)TMP_tmp1_11);
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(13)));
            TMP_tmp2_8 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp3_8 = (PEvent)(new eReqDisarm(null));
            currentMachine.TrySendEvent(TMP_tmp2_8, (Event)TMP_tmp3_8);
        }
        public void Anon_35(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool status_10 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            if (status_10)
            {
                currentMachine.TryGotoState<Shutdown>();
                return;
            }
            else
            {
                currentMachine.TryGotoState<Error>();
                return;
            }
        }
        public void Anon_36(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool connected_7 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_33 = ((PrtBool)false);
            TMP_tmp0_33 = (PrtBool)(!(connected_7));
            if (TMP_tmp0_33)
            {
                currentMachine.TryGotoState<Error>();
                return;
            }
        }
        public void Anon_37(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PMachineValue TMP_tmp0_34 = null;
            PEvent TMP_tmp1_12 = null;
            currentMachine.Announce((Event)new eReturnToLaunch(null));
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(16)));
            TMP_tmp0_34 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp1_12 = (PEvent)(new eReqWaitForDisarmed(null));
            currentMachine.TrySendEvent(TMP_tmp0_34, (Event)TMP_tmp1_12);
        }
        public void Anon_38(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtBool status_11 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_35 = ((PrtBool)false);
            PMachineValue TMP_tmp1_13 = null;
            PEvent TMP_tmp2_9 = null;
            TMP_tmp0_35 = (PrtBool)(!(status_11));
            if (TMP_tmp0_35)
            {
                currentMachine.TryGotoState<ReturnToLaunch>();
                return;
            }
            else
            {
                TMP_tmp1_13 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
                TMP_tmp2_9 = (PEvent)(new eReqLandingState(null));
                currentMachine.TrySendEvent(TMP_tmp1_13, (Event)TMP_tmp2_9);
                currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(12)));
            }
        }
        public void Anon_39(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PrtInt val_1 = (PrtInt)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_36 = ((PrtBool)false);
            TMP_tmp0_36 = (PrtBool)((PrtValues.SafeEquals(val_1,((PrtInt)(1)))));
            if (TMP_tmp0_36)
            {
                currentMachine.TryGotoState<Shutdown>();
                return;
            }
            else
            {
                currentMachine.TryGotoState<Error>();
                return;
            }
        }
        public void Anon_40(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PEvent TMP_tmp0_37 = null;
            currentMachine.Announce((Event)new eError(null));
            TMP_tmp0_37 = (PEvent)(new PHalt(null));
            currentMachine.TryRaiseEvent((Event)TMP_tmp0_37);
            return;
        }
        public void Anon_41(Event currentMachine_dequeuedEvent)
        {
            FlightController currentMachine = this;
            PEvent TMP_tmp0_38 = null;
            currentMachine.Announce((Event)new eShutdownSystem(null));
            TMP_tmp0_38 = (PEvent)(new PHalt(null));
            currentMachine.TryRaiseEvent((Event)TMP_tmp0_38);
            return;
        }
        public async Task GoRTL()
        {
            FlightController currentMachine = this;
            PMachineValue TMP_tmp0_39 = null;
            PEvent TMP_tmp1_14 = null;
            PrtBool TMP_tmp2_10 = ((PrtBool)false);
            currentMachine.Announce((Event)new eMavSDKReq(((PrtInt)0)), ((PrtInt)(15)));
            TMP_tmp0_39 = (PMachineValue)(((PMachineValue)((IPrtValue)mavsdk)?.Clone()));
            TMP_tmp1_14 = (PEvent)(new eReqReturnToLaunch(null));
            currentMachine.TrySendEvent(TMP_tmp0_39, (Event)TMP_tmp1_14);
            var PGEN_recvEvent_5 = await currentMachine.TryReceiveEvent(typeof(eRespReturnToLaunch), typeof(PHalt));
            switch (PGEN_recvEvent_5) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eRespReturnToLaunch PGEN_evt_5: {
                    PrtBool status_12 = (PrtBool)(PGEN_evt_5.Payload);
                    TMP_tmp2_10 = (PrtBool)(!(status_12));
                    if (TMP_tmp2_10)
                    {
                        currentMachine.TryGotoState<Error>();
                        return;
                    }
                    else
                    {
                        currentMachine.TryGotoState<ReturnToLaunch>();
                        return;
                    }
                } break;
            }
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_2))]
        [OnEventGotoState(typeof(eLinkInitialized), typeof(PreFlight))]
        [OnEventDoAction(typeof(eRaiseError), nameof(Anon_3))]
        [IgnoreEvents(typeof(eBatteryRemaining), typeof(eSystemConnected), typeof(eTelemetryHealthAllOK))]
        class Init : State
        {
        }
        [OnEntry(nameof(Anon_4))]
        [OnEventDoAction(typeof(eSystemConnected), nameof(Anon_5))]
        [OnEventDoAction(typeof(eBatteryRemaining), nameof(Anon_6))]
        [OnEventDoAction(typeof(eTelemetryHealthAllOK), nameof(Anon_7))]
        [OnEventDoAction(typeof(eRespArm), nameof(Anon_8))]
        class PreFlight : State
        {
        }
        [OnEntry(nameof(Anon_9))]
        [OnEventDoAction(typeof(eSystemConnected), nameof(Anon_10))]
        [OnEventDoAction(typeof(eBatteryRemaining), nameof(Anon_11))]
        [OnEventDoAction(typeof(eTelemetryHealthAllOK), nameof(Anon_12))]
        [OnEventDoAction(typeof(eRespTakeoff), nameof(Anon_13))]
        class Armed : State
        {
        }
        [OnEntry(nameof(Anon_14))]
        [OnEventDoAction(typeof(eSystemConnected), nameof(Anon_15))]
        [OnEventDoAction(typeof(eBatteryRemaining), nameof(Anon_16))]
        [OnEventDoAction(typeof(eTelemetryHealthAllOK), nameof(Anon_17))]
        [OnEventDoAction(typeof(eRespAtTakeoffAlt), nameof(Anon_18))]
        [OnEventDoAction(typeof(eRespHold), nameof(Anon_19))]
        class Takeoff : State
        {
        }
        [OnEntry(nameof(Anon_20))]
        [OnEventDoAction(typeof(eSystemConnected), nameof(Anon_21))]
        [OnEventDoAction(typeof(eBatteryRemaining), nameof(Anon_22))]
        [OnEventDoAction(typeof(eTelemetryHealthAllOK), nameof(Anon_23))]
        [OnEventDoAction(typeof(eMissionStarted), nameof(Anon_24))]
        class Hold : State
        {
        }
        [OnEntry(nameof(Anon_25))]
        [OnEventDoAction(typeof(eSystemConnected), nameof(Anon_26))]
        [OnEventDoAction(typeof(eBatteryRemaining), nameof(Anon_27))]
        [OnEventDoAction(typeof(eTelemetryHealthAllOK), nameof(Anon_28))]
        [OnEventDoAction(typeof(eRespMissionFinished), nameof(Anon_29))]
        [OnEventDoAction(typeof(eRespLand), nameof(Anon_30))]
        class Mission : State
        {
        }
        [OnEntry(nameof(Anon_31))]
        [OnEventDoAction(typeof(eSystemConnected), nameof(Anon_32))]
        [OnEventDoAction(typeof(eRespLandingState), nameof(Anon_33))]
        [IgnoreEvents(typeof(eBatteryRemaining), typeof(eTelemetryHealthAllOK), typeof(eMissionStarted))]
        class Land : State
        {
        }
        [OnEntry(nameof(Anon_34))]
        [OnEventDoAction(typeof(eRespDisarm), nameof(Anon_35))]
        [OnEventDoAction(typeof(eSystemConnected), nameof(Anon_36))]
        [IgnoreEvents(typeof(eBatteryRemaining), typeof(eTelemetryHealthAllOK), typeof(eMissionStarted), typeof(eRespTakeoff))]
        class Disarm : State
        {
        }
        [OnEntry(nameof(Anon_37))]
        [OnEventDoAction(typeof(eRespWaitForDisarmed), nameof(Anon_38))]
        [OnEventDoAction(typeof(eRespLandingState), nameof(Anon_39))]
        [IgnoreEvents(typeof(eBatteryRemaining), typeof(eSystemConnected), typeof(eTelemetryHealthAllOK), typeof(eRespArm), typeof(eRespTakeoff), typeof(eRespAtTakeoffAlt), typeof(eRespMissionFinished), typeof(eRespLand), typeof(eMissionStarted), typeof(eRaiseError), typeof(eRespHold))]
        class ReturnToLaunch : State
        {
        }
        [OnEntry(nameof(Anon_40))]
        [IgnoreEvents(typeof(eBatteryRemaining), typeof(eSystemConnected), typeof(eTelemetryHealthAllOK), typeof(eRespArm), typeof(eRespTakeoff), typeof(eRespAtTakeoffAlt), typeof(eRespWaitForDisarmed), typeof(eRespMissionFinished), typeof(eMissionStarted), typeof(eRaiseError), typeof(eRespLand), typeof(eRespLandingState), typeof(eRespHold), typeof(eRespReturnToLaunch), typeof(eRespDisarm))]
        class Error : State
        {
        }
        [OnEntry(nameof(Anon_41))]
        [IgnoreEvents(typeof(eBatteryRemaining), typeof(eSystemConnected), typeof(eTelemetryHealthAllOK), typeof(eRespArm), typeof(eRespTakeoff), typeof(eRespAtTakeoffAlt), typeof(eRespWaitForDisarmed), typeof(eRespMissionFinished), typeof(eMissionStarted), typeof(eRespReturnToLaunch), typeof(eRespHold))]
        class Shutdown : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class MavSDK : PMachine
    {
        private PMachineValue controller = null;
        private PMachineValue tMonitor = null;
        private PMachineValue sMonitor = null;
        private PMachineValue bMonitor = null;
        private PMachineValue mMonitor = null;
        public class ConstructorEvent : PEvent{public ConstructorEvent(PMachineValue val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((PMachineValue)value); }
        public MavSDK() {
            this.sends.Add(nameof(eArm));
            this.sends.Add(nameof(eBatteryRemaining));
            this.sends.Add(nameof(eDisarmed));
            this.sends.Add(nameof(eError));
            this.sends.Add(nameof(eHold));
            this.sends.Add(nameof(eInAir));
            this.sends.Add(nameof(eInAirStatus));
            this.sends.Add(nameof(eLanding));
            this.sends.Add(nameof(eLinkInitialized));
            this.sends.Add(nameof(eMavSDKReq));
            this.sends.Add(nameof(eMavSDKResp));
            this.sends.Add(nameof(eMissionCleared));
            this.sends.Add(nameof(eMissionStarted));
            this.sends.Add(nameof(eMissionUploaded));
            this.sends.Add(nameof(eRaiseError));
            this.sends.Add(nameof(eReqArm));
            this.sends.Add(nameof(eReqAtTakeoffAlt));
            this.sends.Add(nameof(eReqBatteryRemaining));
            this.sends.Add(nameof(eReqClearMission));
            this.sends.Add(nameof(eReqDisarm));
            this.sends.Add(nameof(eReqHold));
            this.sends.Add(nameof(eReqInAirStatus));
            this.sends.Add(nameof(eReqLand));
            this.sends.Add(nameof(eReqLandingState));
            this.sends.Add(nameof(eReqMissionFinished));
            this.sends.Add(nameof(eReqMissionStart));
            this.sends.Add(nameof(eReqMissionUpload));
            this.sends.Add(nameof(eReqReturnToLaunch));
            this.sends.Add(nameof(eReqSystemStatus));
            this.sends.Add(nameof(eReqTakeoff));
            this.sends.Add(nameof(eReqTelemetryHealth));
            this.sends.Add(nameof(eReqWaitForDisarmed));
            this.sends.Add(nameof(eRespArm));
            this.sends.Add(nameof(eRespAtTakeoffAlt));
            this.sends.Add(nameof(eRespBatteryRemaining));
            this.sends.Add(nameof(eRespClearMission));
            this.sends.Add(nameof(eRespDisarm));
            this.sends.Add(nameof(eRespHold));
            this.sends.Add(nameof(eRespInAirStatus));
            this.sends.Add(nameof(eRespLand));
            this.sends.Add(nameof(eRespLandingState));
            this.sends.Add(nameof(eRespMissionFinished));
            this.sends.Add(nameof(eRespMissionStart));
            this.sends.Add(nameof(eRespMissionUpload));
            this.sends.Add(nameof(eRespReturnToLaunch));
            this.sends.Add(nameof(eRespSystemStatus));
            this.sends.Add(nameof(eRespTakeoff));
            this.sends.Add(nameof(eRespTelemetryHealth));
            this.sends.Add(nameof(eRespWaitForDisarmed));
            this.sends.Add(nameof(eReturnToLaunch));
            this.sends.Add(nameof(eShutdownSystem));
            this.sends.Add(nameof(eSpec_PreFlight));
            this.sends.Add(nameof(eSystemConnected));
            this.sends.Add(nameof(eTakeoff));
            this.sends.Add(nameof(eTakeoffReached));
            this.sends.Add(nameof(eTelemetryHealthAllOK));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eArm));
            this.receives.Add(nameof(eBatteryRemaining));
            this.receives.Add(nameof(eDisarmed));
            this.receives.Add(nameof(eError));
            this.receives.Add(nameof(eHold));
            this.receives.Add(nameof(eInAir));
            this.receives.Add(nameof(eInAirStatus));
            this.receives.Add(nameof(eLanding));
            this.receives.Add(nameof(eLinkInitialized));
            this.receives.Add(nameof(eMavSDKReq));
            this.receives.Add(nameof(eMavSDKResp));
            this.receives.Add(nameof(eMissionCleared));
            this.receives.Add(nameof(eMissionStarted));
            this.receives.Add(nameof(eMissionUploaded));
            this.receives.Add(nameof(eRaiseError));
            this.receives.Add(nameof(eReqArm));
            this.receives.Add(nameof(eReqAtTakeoffAlt));
            this.receives.Add(nameof(eReqBatteryRemaining));
            this.receives.Add(nameof(eReqClearMission));
            this.receives.Add(nameof(eReqDisarm));
            this.receives.Add(nameof(eReqHold));
            this.receives.Add(nameof(eReqInAirStatus));
            this.receives.Add(nameof(eReqLand));
            this.receives.Add(nameof(eReqLandingState));
            this.receives.Add(nameof(eReqMissionFinished));
            this.receives.Add(nameof(eReqMissionStart));
            this.receives.Add(nameof(eReqMissionUpload));
            this.receives.Add(nameof(eReqReturnToLaunch));
            this.receives.Add(nameof(eReqSystemStatus));
            this.receives.Add(nameof(eReqTakeoff));
            this.receives.Add(nameof(eReqTelemetryHealth));
            this.receives.Add(nameof(eReqWaitForDisarmed));
            this.receives.Add(nameof(eRespArm));
            this.receives.Add(nameof(eRespAtTakeoffAlt));
            this.receives.Add(nameof(eRespBatteryRemaining));
            this.receives.Add(nameof(eRespClearMission));
            this.receives.Add(nameof(eRespDisarm));
            this.receives.Add(nameof(eRespHold));
            this.receives.Add(nameof(eRespInAirStatus));
            this.receives.Add(nameof(eRespLand));
            this.receives.Add(nameof(eRespLandingState));
            this.receives.Add(nameof(eRespMissionFinished));
            this.receives.Add(nameof(eRespMissionStart));
            this.receives.Add(nameof(eRespMissionUpload));
            this.receives.Add(nameof(eRespReturnToLaunch));
            this.receives.Add(nameof(eRespSystemStatus));
            this.receives.Add(nameof(eRespTakeoff));
            this.receives.Add(nameof(eRespTelemetryHealth));
            this.receives.Add(nameof(eRespWaitForDisarmed));
            this.receives.Add(nameof(eReturnToLaunch));
            this.receives.Add(nameof(eShutdownSystem));
            this.receives.Add(nameof(eSpec_PreFlight));
            this.receives.Add(nameof(eSystemConnected));
            this.receives.Add(nameof(eTakeoff));
            this.receives.Add(nameof(eTakeoffReached));
            this.receives.Add(nameof(eTelemetryHealthAllOK));
            this.receives.Add(nameof(PHalt));
            this.creates.Add(nameof(I_BatteryMonitor));
            this.creates.Add(nameof(I_MissionMonitor));
            this.creates.Add(nameof(I_SystemMonitor));
            this.creates.Add(nameof(I_TelemetryMonitor));
        }
        
        public void Anon_42(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PMachineValue cntl = (PMachineValue)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_40 = ((PrtBool)false);
            PMachineValue TMP_tmp1_15 = null;
            PMachineValue TMP_tmp2_11 = null;
            PMachineValue TMP_tmp3_9 = null;
            PMachineValue TMP_tmp4_6 = null;
            PMachineValue TMP_tmp5_6 = null;
            PMachineValue TMP_tmp6_6 = null;
            PMachineValue TMP_tmp7_6 = null;
            PMachineValue TMP_tmp8_3 = null;
            PMachineValue TMP_tmp9_2 = null;
            PEvent TMP_tmp10_2 = null;
            PMachineValue TMP_tmp11_2 = null;
            PEvent TMP_tmp12_2 = null;
            PMachineValue TMP_tmp13_2 = null;
            PEvent TMP_tmp14_2 = null;
            PMachineValue TMP_tmp15_2 = null;
            PEvent TMP_tmp16_2 = null;
            PMachineValue TMP_tmp17_1 = null;
            PEvent TMP_tmp18_1 = null;
            PMachineValue TMP_tmp19_1 = null;
            PEvent TMP_tmp20_1 = null;
            controller = (PMachineValue)(((PMachineValue)((IPrtValue)cntl)?.Clone()));
            TMP_tmp0_40 = (PrtBool)(GlobalFunctions.CoreSetupMavSDK(currentMachine));
            if (TMP_tmp0_40)
            {
                TMP_tmp1_15 = (PMachineValue)(((PMachineValue)((IPrtValue)controller)?.Clone()));
                TMP_tmp2_11 = (PMachineValue)(currentMachine.CreateInterface<I_TelemetryMonitor>( currentMachine, TMP_tmp1_15));
                tMonitor = (PMachineValue)TMP_tmp2_11;
                TMP_tmp3_9 = (PMachineValue)(((PMachineValue)((IPrtValue)controller)?.Clone()));
                TMP_tmp4_6 = (PMachineValue)(currentMachine.CreateInterface<I_SystemMonitor>( currentMachine, TMP_tmp3_9));
                sMonitor = (PMachineValue)TMP_tmp4_6;
                TMP_tmp5_6 = (PMachineValue)(((PMachineValue)((IPrtValue)controller)?.Clone()));
                TMP_tmp6_6 = (PMachineValue)(currentMachine.CreateInterface<I_BatteryMonitor>( currentMachine, TMP_tmp5_6));
                bMonitor = (PMachineValue)TMP_tmp6_6;
                TMP_tmp7_6 = (PMachineValue)(((PMachineValue)((IPrtValue)controller)?.Clone()));
                TMP_tmp8_3 = (PMachineValue)(currentMachine.CreateInterface<I_MissionMonitor>( currentMachine, TMP_tmp7_6));
                mMonitor = (PMachineValue)TMP_tmp8_3;
                TMP_tmp9_2 = (PMachineValue)(((PMachineValue)((IPrtValue)tMonitor)?.Clone()));
                TMP_tmp10_2 = (PEvent)(new eLinkInitialized(null));
                currentMachine.TrySendEvent(TMP_tmp9_2, (Event)TMP_tmp10_2);
                TMP_tmp11_2 = (PMachineValue)(((PMachineValue)((IPrtValue)sMonitor)?.Clone()));
                TMP_tmp12_2 = (PEvent)(new eLinkInitialized(null));
                currentMachine.TrySendEvent(TMP_tmp11_2, (Event)TMP_tmp12_2);
                TMP_tmp13_2 = (PMachineValue)(((PMachineValue)((IPrtValue)bMonitor)?.Clone()));
                TMP_tmp14_2 = (PEvent)(new eLinkInitialized(null));
                currentMachine.TrySendEvent(TMP_tmp13_2, (Event)TMP_tmp14_2);
                TMP_tmp15_2 = (PMachineValue)(((PMachineValue)((IPrtValue)mMonitor)?.Clone()));
                TMP_tmp16_2 = (PEvent)(new eLinkInitialized(null));
                currentMachine.TrySendEvent(TMP_tmp15_2, (Event)TMP_tmp16_2);
                TMP_tmp17_1 = (PMachineValue)(((PMachineValue)((IPrtValue)controller)?.Clone()));
                TMP_tmp18_1 = (PEvent)(new eLinkInitialized(null));
                currentMachine.TrySendEvent(TMP_tmp17_1, (Event)TMP_tmp18_1);
                currentMachine.TryGotoState<WaitForReq>();
                return;
            }
            else
            {
                TMP_tmp19_1 = (PMachineValue)(((PMachineValue)((IPrtValue)controller)?.Clone()));
                TMP_tmp20_1 = (PEvent)(new eRaiseError(null));
                currentMachine.TrySendEvent(TMP_tmp19_1, (Event)TMP_tmp20_1);
            }
        }
        public void Anon_43(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtBool status_13 = ((PrtBool)false);
            PrtBool TMP_tmp0_41 = ((PrtBool)false);
            PMachineValue TMP_tmp1_16 = null;
            PEvent TMP_tmp2_12 = null;
            PrtBool TMP_tmp3_10 = ((PrtBool)false);
            TMP_tmp0_41 = (PrtBool)(GlobalFunctions.TelemetryHealthAllOk(currentMachine));
            status_13 = TMP_tmp0_41;
            TMP_tmp1_16 = (PMachineValue)(((PMachineValue)((IPrtValue)tMonitor)?.Clone()));
            TMP_tmp2_12 = (PEvent)(new eRespTelemetryHealth(((PrtBool)false)));
            TMP_tmp3_10 = (PrtBool)(((PrtBool)((IPrtValue)status_13)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp1_16, (Event)TMP_tmp2_12, TMP_tmp3_10);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(3)));
        }
        public void Anon_44(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtBool success = ((PrtBool)false);
            PrtBool TMP_tmp0_42 = ((PrtBool)false);
            PMachineValue TMP_tmp1_17 = null;
            PEvent TMP_tmp2_13 = null;
            PrtBool TMP_tmp3_11 = ((PrtBool)false);
            TMP_tmp0_42 = (PrtBool)(GlobalFunctions.UploadMission(currentMachine));
            success = TMP_tmp0_42;
            TMP_tmp1_17 = (PMachineValue)(((PMachineValue)((IPrtValue)mMonitor)?.Clone()));
            TMP_tmp2_13 = (PEvent)(new eRespMissionUpload(((PrtBool)false)));
            TMP_tmp3_11 = (PrtBool)(((PrtBool)((IPrtValue)success)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp1_17, (Event)TMP_tmp2_13, TMP_tmp3_11);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(1)));
        }
        public void Anon_45(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtBool status_14 = ((PrtBool)false);
            PrtBool TMP_tmp0_43 = ((PrtBool)false);
            PMachineValue TMP_tmp1_18 = null;
            PEvent TMP_tmp2_14 = null;
            PrtBool TMP_tmp3_12 = ((PrtBool)false);
            TMP_tmp0_43 = (PrtBool)(GlobalFunctions.MissionFinished(currentMachine));
            status_14 = TMP_tmp0_43;
            TMP_tmp1_18 = (PMachineValue)(((PMachineValue)((IPrtValue)controller)?.Clone()));
            TMP_tmp2_14 = (PEvent)(new eRespMissionFinished(((PrtBool)false)));
            TMP_tmp3_12 = (PrtBool)(((PrtBool)((IPrtValue)status_14)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp1_18, (Event)TMP_tmp2_14, TMP_tmp3_12);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(10)));
        }
        public void Anon_46(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtBool armed = ((PrtBool)false);
            PrtBool TMP_tmp0_44 = ((PrtBool)false);
            PMachineValue TMP_tmp1_19 = null;
            PEvent TMP_tmp2_15 = null;
            PrtBool TMP_tmp3_13 = ((PrtBool)false);
            TMP_tmp0_44 = (PrtBool)(GlobalFunctions.ArmSystem(currentMachine));
            armed = TMP_tmp0_44;
            TMP_tmp1_19 = (PMachineValue)(((PMachineValue)((IPrtValue)controller)?.Clone()));
            TMP_tmp2_15 = (PEvent)(new eRespArm(((PrtBool)false)));
            TMP_tmp3_13 = (PrtBool)(((PrtBool)((IPrtValue)armed)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp1_19, (Event)TMP_tmp2_15, TMP_tmp3_13);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(4)));
        }
        public void Anon_47(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtFloat alt = (PrtFloat)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool takeoff = ((PrtBool)false);
            PrtFloat TMP_tmp0_45 = ((PrtFloat)0.0);
            PrtBool TMP_tmp1_20 = ((PrtBool)false);
            PMachineValue TMP_tmp2_16 = null;
            PEvent TMP_tmp3_14 = null;
            PrtBool TMP_tmp4_7 = ((PrtBool)false);
            TMP_tmp0_45 = (PrtFloat)(((PrtFloat)((IPrtValue)alt)?.Clone()));
            TMP_tmp1_20 = (PrtBool)(GlobalFunctions.TakeoffSystem(TMP_tmp0_45, currentMachine));
            takeoff = TMP_tmp1_20;
            TMP_tmp2_16 = (PMachineValue)(((PMachineValue)((IPrtValue)controller)?.Clone()));
            TMP_tmp3_14 = (PEvent)(new eRespTakeoff(((PrtBool)false)));
            TMP_tmp4_7 = (PrtBool)(((PrtBool)((IPrtValue)takeoff)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp2_16, (Event)TMP_tmp3_14, TMP_tmp4_7);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(5)));
        }
        public void Anon_48(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtBool status_15 = ((PrtBool)false);
            PrtBool TMP_tmp0_46 = ((PrtBool)false);
            PMachineValue TMP_tmp1_21 = null;
            PEvent TMP_tmp2_17 = null;
            PrtBool TMP_tmp3_15 = ((PrtBool)false);
            TMP_tmp0_46 = (PrtBool)(GlobalFunctions.SystemStatus(currentMachine));
            status_15 = TMP_tmp0_46;
            TMP_tmp1_21 = (PMachineValue)(((PMachineValue)((IPrtValue)sMonitor)?.Clone()));
            TMP_tmp2_17 = (PEvent)(new eRespSystemStatus(((PrtBool)false)));
            TMP_tmp3_15 = (PrtBool)(((PrtBool)((IPrtValue)status_15)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp1_21, (Event)TMP_tmp2_17, TMP_tmp3_15);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(2)));
        }
        public void Anon_49(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtFloat status_16 = ((PrtFloat)0.0);
            PrtFloat TMP_tmp0_47 = ((PrtFloat)0.0);
            PMachineValue TMP_tmp1_22 = null;
            PEvent TMP_tmp2_18 = null;
            PrtFloat TMP_tmp3_16 = ((PrtFloat)0.0);
            TMP_tmp0_47 = (PrtFloat)(GlobalFunctions.BatteryRemaining(currentMachine));
            status_16 = TMP_tmp0_47;
            TMP_tmp1_22 = (PMachineValue)(((PMachineValue)((IPrtValue)bMonitor)?.Clone()));
            TMP_tmp2_18 = (PEvent)(new eRespBatteryRemaining(((PrtFloat)0.0)));
            TMP_tmp3_16 = (PrtFloat)(((PrtFloat)((IPrtValue)status_16)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp1_22, (Event)TMP_tmp2_18, TMP_tmp3_16);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(0)));
        }
        public void Anon_50(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtBool status_17 = ((PrtBool)false);
            PrtBool TMP_tmp0_48 = ((PrtBool)false);
            PMachineValue TMP_tmp1_23 = null;
            PEvent TMP_tmp2_19 = null;
            PrtBool TMP_tmp3_17 = ((PrtBool)false);
            TMP_tmp0_48 = (PrtBool)(GlobalFunctions.Holding(currentMachine));
            status_17 = TMP_tmp0_48;
            TMP_tmp1_23 = (PMachineValue)(((PMachineValue)((IPrtValue)controller)?.Clone()));
            TMP_tmp2_19 = (PEvent)(new eRespHold(((PrtBool)false)));
            TMP_tmp3_17 = (PrtBool)(((PrtBool)((IPrtValue)status_17)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp1_23, (Event)TMP_tmp2_19, TMP_tmp3_17);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(8)));
        }
        public void Anon_51(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtBool status_18 = ((PrtBool)false);
            PrtBool TMP_tmp0_49 = ((PrtBool)false);
            PMachineValue TMP_tmp1_24 = null;
            PEvent TMP_tmp2_20 = null;
            PrtBool TMP_tmp3_18 = ((PrtBool)false);
            TMP_tmp0_49 = (PrtBool)(GlobalFunctions.RTL(currentMachine));
            status_18 = TMP_tmp0_49;
            TMP_tmp1_24 = (PMachineValue)(((PMachineValue)((IPrtValue)controller)?.Clone()));
            TMP_tmp2_20 = (PEvent)(new eRespReturnToLaunch(((PrtBool)false)));
            TMP_tmp3_18 = (PrtBool)(((PrtBool)((IPrtValue)status_18)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp1_24, (Event)TMP_tmp2_20, TMP_tmp3_18);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(15)));
        }
        public void Anon_52(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtBool status_19 = ((PrtBool)false);
            PrtBool TMP_tmp0_50 = ((PrtBool)false);
            PMachineValue TMP_tmp1_25 = null;
            PEvent TMP_tmp2_21 = null;
            PrtBool TMP_tmp3_19 = ((PrtBool)false);
            TMP_tmp0_50 = (PrtBool)(GlobalFunctions.StartMission(currentMachine));
            status_19 = TMP_tmp0_50;
            TMP_tmp1_25 = (PMachineValue)(((PMachineValue)((IPrtValue)mMonitor)?.Clone()));
            TMP_tmp2_21 = (PEvent)(new eRespMissionStart(((PrtBool)false)));
            TMP_tmp3_19 = (PrtBool)(((PrtBool)((IPrtValue)status_19)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp1_25, (Event)TMP_tmp2_21, TMP_tmp3_19);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(9)));
        }
        public void Anon_53(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtBool status_20 = ((PrtBool)false);
            PrtBool TMP_tmp0_51 = ((PrtBool)false);
            PMachineValue TMP_tmp1_26 = null;
            PEvent TMP_tmp2_22 = null;
            PrtBool TMP_tmp3_20 = ((PrtBool)false);
            TMP_tmp0_51 = (PrtBool)(GlobalFunctions.ClearMission(currentMachine));
            status_20 = TMP_tmp0_51;
            TMP_tmp1_26 = (PMachineValue)(((PMachineValue)((IPrtValue)mMonitor)?.Clone()));
            TMP_tmp2_22 = (PEvent)(new eRespClearMission(((PrtBool)false)));
            TMP_tmp3_20 = (PrtBool)(((PrtBool)((IPrtValue)status_20)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp1_26, (Event)TMP_tmp2_22, TMP_tmp3_20);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(14)));
        }
        public void Anon_54(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtBool status_21 = ((PrtBool)false);
            PrtBool TMP_tmp0_52 = ((PrtBool)false);
            PMachineValue TMP_tmp1_27 = null;
            PEvent TMP_tmp2_23 = null;
            PrtBool TMP_tmp3_21 = ((PrtBool)false);
            TMP_tmp0_52 = (PrtBool)(GlobalFunctions.InAirStatus(currentMachine));
            status_21 = TMP_tmp0_52;
            TMP_tmp1_27 = (PMachineValue)(((PMachineValue)((IPrtValue)tMonitor)?.Clone()));
            TMP_tmp2_23 = (PEvent)(new eRespInAirStatus(((PrtBool)false)));
            TMP_tmp3_21 = (PrtBool)(((PrtBool)((IPrtValue)status_21)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp1_27, (Event)TMP_tmp2_23, TMP_tmp3_21);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(7)));
        }
        public void Anon_55(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtBool status_22 = ((PrtBool)false);
            PrtBool TMP_tmp0_53 = ((PrtBool)false);
            PMachineValue TMP_tmp1_28 = null;
            PEvent TMP_tmp2_24 = null;
            PrtBool TMP_tmp3_22 = ((PrtBool)false);
            TMP_tmp0_53 = (PrtBool)(GlobalFunctions.IsAtTakeoffAlt(currentMachine));
            status_22 = TMP_tmp0_53;
            TMP_tmp1_28 = (PMachineValue)(((PMachineValue)((IPrtValue)controller)?.Clone()));
            TMP_tmp2_24 = (PEvent)(new eRespAtTakeoffAlt(((PrtBool)false)));
            TMP_tmp3_22 = (PrtBool)(((PrtBool)((IPrtValue)status_22)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp1_28, (Event)TMP_tmp2_24, TMP_tmp3_22);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(6)));
        }
        public void Anon_56(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtBool status_23 = ((PrtBool)false);
            PrtBool TMP_tmp0_54 = ((PrtBool)false);
            PMachineValue TMP_tmp1_29 = null;
            PEvent TMP_tmp2_25 = null;
            PrtBool TMP_tmp3_23 = ((PrtBool)false);
            TMP_tmp0_54 = (PrtBool)(GlobalFunctions.WaitForDisarmed(currentMachine));
            status_23 = TMP_tmp0_54;
            TMP_tmp1_29 = (PMachineValue)(((PMachineValue)((IPrtValue)controller)?.Clone()));
            TMP_tmp2_25 = (PEvent)(new eRespWaitForDisarmed(((PrtBool)false)));
            TMP_tmp3_23 = (PrtBool)(((PrtBool)((IPrtValue)status_23)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp1_29, (Event)TMP_tmp2_25, TMP_tmp3_23);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(16)));
        }
        public void Anon_57(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtBool status_24 = ((PrtBool)false);
            PrtBool TMP_tmp0_55 = ((PrtBool)false);
            PMachineValue TMP_tmp1_30 = null;
            PEvent TMP_tmp2_26 = null;
            PrtBool TMP_tmp3_24 = ((PrtBool)false);
            TMP_tmp0_55 = (PrtBool)(GlobalFunctions.LandSystem(currentMachine));
            status_24 = TMP_tmp0_55;
            TMP_tmp1_30 = (PMachineValue)(((PMachineValue)((IPrtValue)controller)?.Clone()));
            TMP_tmp2_26 = (PEvent)(new eRespLand(((PrtBool)false)));
            TMP_tmp3_24 = (PrtBool)(((PrtBool)((IPrtValue)status_24)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp1_30, (Event)TMP_tmp2_26, TMP_tmp3_24);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(11)));
        }
        public void Anon_58(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtInt status_25 = ((PrtInt)0);
            PrtInt TMP_tmp0_56 = ((PrtInt)0);
            PMachineValue TMP_tmp1_31 = null;
            PEvent TMP_tmp2_27 = null;
            PrtInt TMP_tmp3_25 = ((PrtInt)0);
            TMP_tmp0_56 = (PrtInt)(GlobalFunctions.LandingState(currentMachine));
            status_25 = TMP_tmp0_56;
            TMP_tmp1_31 = (PMachineValue)(((PMachineValue)((IPrtValue)controller)?.Clone()));
            TMP_tmp2_27 = (PEvent)(new eRespLandingState(((PrtInt)0)));
            TMP_tmp3_25 = (PrtInt)(((PrtInt)((IPrtValue)status_25)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp1_31, (Event)TMP_tmp2_27, TMP_tmp3_25);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(12)));
        }
        public void Anon_59(Event currentMachine_dequeuedEvent)
        {
            MavSDK currentMachine = this;
            PrtBool status_26 = ((PrtBool)false);
            PrtBool TMP_tmp0_57 = ((PrtBool)false);
            PMachineValue TMP_tmp1_32 = null;
            PEvent TMP_tmp2_28 = null;
            PrtBool TMP_tmp3_26 = ((PrtBool)false);
            TMP_tmp0_57 = (PrtBool)(GlobalFunctions.DisarmSystem(currentMachine));
            status_26 = TMP_tmp0_57;
            TMP_tmp1_32 = (PMachineValue)(((PMachineValue)((IPrtValue)controller)?.Clone()));
            TMP_tmp2_28 = (PEvent)(new eRespDisarm(((PrtBool)false)));
            TMP_tmp3_26 = (PrtBool)(((PrtBool)((IPrtValue)status_26)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp1_32, (Event)TMP_tmp2_28, TMP_tmp3_26);
            currentMachine.Announce((Event)new eMavSDKResp(((PrtInt)0)), ((PrtInt)(13)));
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_42))]
        [DeferEvents(typeof(eReqMissionUpload))]
        class Init : State
        {
        }
        [OnEventDoAction(typeof(eReqTelemetryHealth), nameof(Anon_43))]
        [OnEventDoAction(typeof(eReqMissionUpload), nameof(Anon_44))]
        [OnEventDoAction(typeof(eReqMissionFinished), nameof(Anon_45))]
        [OnEventDoAction(typeof(eReqArm), nameof(Anon_46))]
        [OnEventDoAction(typeof(eReqTakeoff), nameof(Anon_47))]
        [OnEventDoAction(typeof(eReqSystemStatus), nameof(Anon_48))]
        [OnEventDoAction(typeof(eReqBatteryRemaining), nameof(Anon_49))]
        [OnEventDoAction(typeof(eReqHold), nameof(Anon_50))]
        [OnEventDoAction(typeof(eReqReturnToLaunch), nameof(Anon_51))]
        [OnEventDoAction(typeof(eReqMissionStart), nameof(Anon_52))]
        [OnEventDoAction(typeof(eReqClearMission), nameof(Anon_53))]
        [OnEventDoAction(typeof(eReqInAirStatus), nameof(Anon_54))]
        [OnEventDoAction(typeof(eReqAtTakeoffAlt), nameof(Anon_55))]
        [OnEventDoAction(typeof(eReqWaitForDisarmed), nameof(Anon_56))]
        [OnEventDoAction(typeof(eReqLand), nameof(Anon_57))]
        [OnEventDoAction(typeof(eReqLandingState), nameof(Anon_58))]
        [OnEventDoAction(typeof(eReqDisarm), nameof(Anon_59))]
        class WaitForReq : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class FailureInjector : PMachine
    {
        private PrtInt rng_1 = ((PrtInt)0);
        private PMachineValue failMachine = null;
        private PrtInt tick = ((PrtInt)0);
        private PrtInt tickMax = ((PrtInt)0);
        public class ConstructorEvent : PEvent{public ConstructorEvent(PMachineValue val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((PMachineValue)value); }
        public FailureInjector() {
            this.sends.Add(nameof(eArm));
            this.sends.Add(nameof(eBatteryRemaining));
            this.sends.Add(nameof(eDisarmed));
            this.sends.Add(nameof(eError));
            this.sends.Add(nameof(eHold));
            this.sends.Add(nameof(eInAir));
            this.sends.Add(nameof(eInAirStatus));
            this.sends.Add(nameof(eLanding));
            this.sends.Add(nameof(eLinkInitialized));
            this.sends.Add(nameof(eMavSDKReq));
            this.sends.Add(nameof(eMavSDKResp));
            this.sends.Add(nameof(eMissionCleared));
            this.sends.Add(nameof(eMissionStarted));
            this.sends.Add(nameof(eMissionUploaded));
            this.sends.Add(nameof(eRaiseError));
            this.sends.Add(nameof(eReqArm));
            this.sends.Add(nameof(eReqAtTakeoffAlt));
            this.sends.Add(nameof(eReqBatteryRemaining));
            this.sends.Add(nameof(eReqClearMission));
            this.sends.Add(nameof(eReqDisarm));
            this.sends.Add(nameof(eReqHold));
            this.sends.Add(nameof(eReqInAirStatus));
            this.sends.Add(nameof(eReqLand));
            this.sends.Add(nameof(eReqLandingState));
            this.sends.Add(nameof(eReqMissionFinished));
            this.sends.Add(nameof(eReqMissionStart));
            this.sends.Add(nameof(eReqMissionUpload));
            this.sends.Add(nameof(eReqReturnToLaunch));
            this.sends.Add(nameof(eReqSystemStatus));
            this.sends.Add(nameof(eReqTakeoff));
            this.sends.Add(nameof(eReqTelemetryHealth));
            this.sends.Add(nameof(eReqWaitForDisarmed));
            this.sends.Add(nameof(eRespArm));
            this.sends.Add(nameof(eRespAtTakeoffAlt));
            this.sends.Add(nameof(eRespBatteryRemaining));
            this.sends.Add(nameof(eRespClearMission));
            this.sends.Add(nameof(eRespDisarm));
            this.sends.Add(nameof(eRespHold));
            this.sends.Add(nameof(eRespInAirStatus));
            this.sends.Add(nameof(eRespLand));
            this.sends.Add(nameof(eRespLandingState));
            this.sends.Add(nameof(eRespMissionFinished));
            this.sends.Add(nameof(eRespMissionStart));
            this.sends.Add(nameof(eRespMissionUpload));
            this.sends.Add(nameof(eRespReturnToLaunch));
            this.sends.Add(nameof(eRespSystemStatus));
            this.sends.Add(nameof(eRespTakeoff));
            this.sends.Add(nameof(eRespTelemetryHealth));
            this.sends.Add(nameof(eRespWaitForDisarmed));
            this.sends.Add(nameof(eReturnToLaunch));
            this.sends.Add(nameof(eShutdownSystem));
            this.sends.Add(nameof(eSpec_PreFlight));
            this.sends.Add(nameof(eSystemConnected));
            this.sends.Add(nameof(eTakeoff));
            this.sends.Add(nameof(eTakeoffReached));
            this.sends.Add(nameof(eTelemetryHealthAllOK));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eArm));
            this.receives.Add(nameof(eBatteryRemaining));
            this.receives.Add(nameof(eDisarmed));
            this.receives.Add(nameof(eError));
            this.receives.Add(nameof(eHold));
            this.receives.Add(nameof(eInAir));
            this.receives.Add(nameof(eInAirStatus));
            this.receives.Add(nameof(eLanding));
            this.receives.Add(nameof(eLinkInitialized));
            this.receives.Add(nameof(eMavSDKReq));
            this.receives.Add(nameof(eMavSDKResp));
            this.receives.Add(nameof(eMissionCleared));
            this.receives.Add(nameof(eMissionStarted));
            this.receives.Add(nameof(eMissionUploaded));
            this.receives.Add(nameof(eRaiseError));
            this.receives.Add(nameof(eReqArm));
            this.receives.Add(nameof(eReqAtTakeoffAlt));
            this.receives.Add(nameof(eReqBatteryRemaining));
            this.receives.Add(nameof(eReqClearMission));
            this.receives.Add(nameof(eReqDisarm));
            this.receives.Add(nameof(eReqHold));
            this.receives.Add(nameof(eReqInAirStatus));
            this.receives.Add(nameof(eReqLand));
            this.receives.Add(nameof(eReqLandingState));
            this.receives.Add(nameof(eReqMissionFinished));
            this.receives.Add(nameof(eReqMissionStart));
            this.receives.Add(nameof(eReqMissionUpload));
            this.receives.Add(nameof(eReqReturnToLaunch));
            this.receives.Add(nameof(eReqSystemStatus));
            this.receives.Add(nameof(eReqTakeoff));
            this.receives.Add(nameof(eReqTelemetryHealth));
            this.receives.Add(nameof(eReqWaitForDisarmed));
            this.receives.Add(nameof(eRespArm));
            this.receives.Add(nameof(eRespAtTakeoffAlt));
            this.receives.Add(nameof(eRespBatteryRemaining));
            this.receives.Add(nameof(eRespClearMission));
            this.receives.Add(nameof(eRespDisarm));
            this.receives.Add(nameof(eRespHold));
            this.receives.Add(nameof(eRespInAirStatus));
            this.receives.Add(nameof(eRespLand));
            this.receives.Add(nameof(eRespLandingState));
            this.receives.Add(nameof(eRespMissionFinished));
            this.receives.Add(nameof(eRespMissionStart));
            this.receives.Add(nameof(eRespMissionUpload));
            this.receives.Add(nameof(eRespReturnToLaunch));
            this.receives.Add(nameof(eRespSystemStatus));
            this.receives.Add(nameof(eRespTakeoff));
            this.receives.Add(nameof(eRespTelemetryHealth));
            this.receives.Add(nameof(eRespWaitForDisarmed));
            this.receives.Add(nameof(eReturnToLaunch));
            this.receives.Add(nameof(eShutdownSystem));
            this.receives.Add(nameof(eSpec_PreFlight));
            this.receives.Add(nameof(eSystemConnected));
            this.receives.Add(nameof(eTakeoff));
            this.receives.Add(nameof(eTakeoffReached));
            this.receives.Add(nameof(eTelemetryHealthAllOK));
            this.receives.Add(nameof(PHalt));
        }
        
        public void Anon_60(Event currentMachine_dequeuedEvent)
        {
            FailureInjector currentMachine = this;
            PMachineValue fm = (PMachineValue)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtInt TMP_tmp0_58 = ((PrtInt)0);
            tick = (PrtInt)(((PrtInt)(0)));
            TMP_tmp0_58 = (PrtInt)(((PrtInt)currentMachine.TryRandom(((PrtInt)(100000)))));
            tickMax = TMP_tmp0_58;
            failMachine = (PMachineValue)(((PMachineValue)((IPrtValue)fm)?.Clone()));
            currentMachine.TryGotoState<FailOneMonitor>();
            return;
        }
        public void Anon_61(Event currentMachine_dequeuedEvent)
        {
            FailureInjector currentMachine = this;
        }
        public void Anon_62(Event currentMachine_dequeuedEvent)
        {
            FailureInjector currentMachine = this;
            PrtBool TMP_tmp0_59 = ((PrtBool)false);
            PrtBool TMP_tmp1_33 = ((PrtBool)false);
            PrtInt TMP_tmp2_29 = ((PrtInt)0);
            PrtBool TMP_tmp3_27 = ((PrtBool)false);
            PrtInt TMP_tmp4_8 = ((PrtInt)0);
            PrtBool TMP_tmp5_7 = ((PrtBool)false);
            PMachineValue TMP_tmp6_7 = null;
            PEvent TMP_tmp7_7 = null;
            PrtBool TMP_tmp8_4 = ((PrtBool)false);
            PrtBool TMP_tmp9_3 = ((PrtBool)false);
            PMachineValue TMP_tmp10_3 = null;
            PEvent TMP_tmp11_3 = null;
            PrtInt TMP_tmp12_3 = ((PrtInt)0);
            PMachineValue TMP_tmp13_3 = null;
            PEvent TMP_tmp14_3 = null;
            PrtBool TMP_tmp15_3 = ((PrtBool)false);
            PEvent TMP_tmp16_3 = null;
            PMachineValue TMP_tmp17_2 = null;
            PEvent TMP_tmp18_2 = null;
            while (((PrtBool)true))
            {
                TMP_tmp0_59 = (PrtBool)((tick) < (tickMax));
                TMP_tmp1_33 = (PrtBool)(((PrtBool)((IPrtValue)TMP_tmp0_59)?.Clone()));
                if (TMP_tmp1_33)
                {
                }
                else
                {
                    break;
                }
                TMP_tmp2_29 = (PrtInt)((tick) + (((PrtInt)(1))));
                tick = TMP_tmp2_29;
            }
            TMP_tmp3_27 = (PrtBool)(((PrtBool)currentMachine.TryRandomBool()));
            if (TMP_tmp3_27)
            {
                TMP_tmp4_8 = (PrtInt)(((PrtInt)currentMachine.TryRandom(((PrtInt)(3)))));
                rng_1 = TMP_tmp4_8;
                TMP_tmp5_7 = (PrtBool)((PrtValues.SafeEquals(rng_1,((PrtInt)(0)))));
                if (TMP_tmp5_7)
                {
                    TMP_tmp6_7 = (PMachineValue)(((PMachineValue)((IPrtValue)failMachine)?.Clone()));
                    TMP_tmp7_7 = (PEvent)(new eTelemetryHealthAllOK(((PrtBool)false)));
                    TMP_tmp8_4 = (PrtBool)(((PrtBool)false));
                    currentMachine.TrySendEvent(TMP_tmp6_7, (Event)TMP_tmp7_7, TMP_tmp8_4);
                }
                else
                {
                    TMP_tmp9_3 = (PrtBool)((PrtValues.SafeEquals(rng_1,((PrtInt)(1)))));
                    if (TMP_tmp9_3)
                    {
                        TMP_tmp10_3 = (PMachineValue)(((PMachineValue)((IPrtValue)failMachine)?.Clone()));
                        TMP_tmp11_3 = (PEvent)(new eBatteryRemaining(((PrtInt)0)));
                        TMP_tmp12_3 = (PrtInt)((PrtEnum.Get("CRITICAL")));
                        currentMachine.TrySendEvent(TMP_tmp10_3, (Event)TMP_tmp11_3, TMP_tmp12_3);
                    }
                    else
                    {
                        TMP_tmp13_3 = (PMachineValue)(((PMachineValue)((IPrtValue)failMachine)?.Clone()));
                        TMP_tmp14_3 = (PEvent)(new eSystemConnected(((PrtBool)false)));
                        TMP_tmp15_3 = (PrtBool)(((PrtBool)false));
                        currentMachine.TrySendEvent(TMP_tmp13_3, (Event)TMP_tmp14_3, TMP_tmp15_3);
                    }
                }
                TMP_tmp16_3 = (PEvent)(new PHalt(null));
                currentMachine.TryRaiseEvent((Event)TMP_tmp16_3);
                return;
            }
            else
            {
                tick = (PrtInt)(((PrtInt)(0)));
                TMP_tmp17_2 = (PMachineValue)(currentMachine.self);
                TMP_tmp18_2 = (PEvent)(new eLinkInitialized(null));
                currentMachine.TrySendEvent(TMP_tmp17_2, (Event)TMP_tmp18_2);
            }
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_60))]
        class Init : State
        {
        }
        [OnEntry(nameof(Anon_61))]
        [OnEventDoAction(typeof(eLinkInitialized), nameof(Anon_62))]
        class FailOneMonitor : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class BatteryMonitor : PMachine
    {
        private PMachineValue flightcontroller = null;
        public class ConstructorEvent : PEvent{public ConstructorEvent(PMachineValue val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((PMachineValue)value); }
        public BatteryMonitor() {
            this.sends.Add(nameof(eArm));
            this.sends.Add(nameof(eBatteryRemaining));
            this.sends.Add(nameof(eDisarmed));
            this.sends.Add(nameof(eError));
            this.sends.Add(nameof(eHold));
            this.sends.Add(nameof(eInAir));
            this.sends.Add(nameof(eInAirStatus));
            this.sends.Add(nameof(eLanding));
            this.sends.Add(nameof(eLinkInitialized));
            this.sends.Add(nameof(eMavSDKReq));
            this.sends.Add(nameof(eMavSDKResp));
            this.sends.Add(nameof(eMissionCleared));
            this.sends.Add(nameof(eMissionStarted));
            this.sends.Add(nameof(eMissionUploaded));
            this.sends.Add(nameof(eRaiseError));
            this.sends.Add(nameof(eReqArm));
            this.sends.Add(nameof(eReqAtTakeoffAlt));
            this.sends.Add(nameof(eReqBatteryRemaining));
            this.sends.Add(nameof(eReqClearMission));
            this.sends.Add(nameof(eReqDisarm));
            this.sends.Add(nameof(eReqHold));
            this.sends.Add(nameof(eReqInAirStatus));
            this.sends.Add(nameof(eReqLand));
            this.sends.Add(nameof(eReqLandingState));
            this.sends.Add(nameof(eReqMissionFinished));
            this.sends.Add(nameof(eReqMissionStart));
            this.sends.Add(nameof(eReqMissionUpload));
            this.sends.Add(nameof(eReqReturnToLaunch));
            this.sends.Add(nameof(eReqSystemStatus));
            this.sends.Add(nameof(eReqTakeoff));
            this.sends.Add(nameof(eReqTelemetryHealth));
            this.sends.Add(nameof(eReqWaitForDisarmed));
            this.sends.Add(nameof(eRespArm));
            this.sends.Add(nameof(eRespAtTakeoffAlt));
            this.sends.Add(nameof(eRespBatteryRemaining));
            this.sends.Add(nameof(eRespClearMission));
            this.sends.Add(nameof(eRespDisarm));
            this.sends.Add(nameof(eRespHold));
            this.sends.Add(nameof(eRespInAirStatus));
            this.sends.Add(nameof(eRespLand));
            this.sends.Add(nameof(eRespLandingState));
            this.sends.Add(nameof(eRespMissionFinished));
            this.sends.Add(nameof(eRespMissionStart));
            this.sends.Add(nameof(eRespMissionUpload));
            this.sends.Add(nameof(eRespReturnToLaunch));
            this.sends.Add(nameof(eRespSystemStatus));
            this.sends.Add(nameof(eRespTakeoff));
            this.sends.Add(nameof(eRespTelemetryHealth));
            this.sends.Add(nameof(eRespWaitForDisarmed));
            this.sends.Add(nameof(eReturnToLaunch));
            this.sends.Add(nameof(eShutdownSystem));
            this.sends.Add(nameof(eSpec_PreFlight));
            this.sends.Add(nameof(eSystemConnected));
            this.sends.Add(nameof(eTakeoff));
            this.sends.Add(nameof(eTakeoffReached));
            this.sends.Add(nameof(eTelemetryHealthAllOK));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eArm));
            this.receives.Add(nameof(eBatteryRemaining));
            this.receives.Add(nameof(eDisarmed));
            this.receives.Add(nameof(eError));
            this.receives.Add(nameof(eHold));
            this.receives.Add(nameof(eInAir));
            this.receives.Add(nameof(eInAirStatus));
            this.receives.Add(nameof(eLanding));
            this.receives.Add(nameof(eLinkInitialized));
            this.receives.Add(nameof(eMavSDKReq));
            this.receives.Add(nameof(eMavSDKResp));
            this.receives.Add(nameof(eMissionCleared));
            this.receives.Add(nameof(eMissionStarted));
            this.receives.Add(nameof(eMissionUploaded));
            this.receives.Add(nameof(eRaiseError));
            this.receives.Add(nameof(eReqArm));
            this.receives.Add(nameof(eReqAtTakeoffAlt));
            this.receives.Add(nameof(eReqBatteryRemaining));
            this.receives.Add(nameof(eReqClearMission));
            this.receives.Add(nameof(eReqDisarm));
            this.receives.Add(nameof(eReqHold));
            this.receives.Add(nameof(eReqInAirStatus));
            this.receives.Add(nameof(eReqLand));
            this.receives.Add(nameof(eReqLandingState));
            this.receives.Add(nameof(eReqMissionFinished));
            this.receives.Add(nameof(eReqMissionStart));
            this.receives.Add(nameof(eReqMissionUpload));
            this.receives.Add(nameof(eReqReturnToLaunch));
            this.receives.Add(nameof(eReqSystemStatus));
            this.receives.Add(nameof(eReqTakeoff));
            this.receives.Add(nameof(eReqTelemetryHealth));
            this.receives.Add(nameof(eReqWaitForDisarmed));
            this.receives.Add(nameof(eRespArm));
            this.receives.Add(nameof(eRespAtTakeoffAlt));
            this.receives.Add(nameof(eRespBatteryRemaining));
            this.receives.Add(nameof(eRespClearMission));
            this.receives.Add(nameof(eRespDisarm));
            this.receives.Add(nameof(eRespHold));
            this.receives.Add(nameof(eRespInAirStatus));
            this.receives.Add(nameof(eRespLand));
            this.receives.Add(nameof(eRespLandingState));
            this.receives.Add(nameof(eRespMissionFinished));
            this.receives.Add(nameof(eRespMissionStart));
            this.receives.Add(nameof(eRespMissionUpload));
            this.receives.Add(nameof(eRespReturnToLaunch));
            this.receives.Add(nameof(eRespSystemStatus));
            this.receives.Add(nameof(eRespTakeoff));
            this.receives.Add(nameof(eRespTelemetryHealth));
            this.receives.Add(nameof(eRespWaitForDisarmed));
            this.receives.Add(nameof(eReturnToLaunch));
            this.receives.Add(nameof(eShutdownSystem));
            this.receives.Add(nameof(eSpec_PreFlight));
            this.receives.Add(nameof(eSystemConnected));
            this.receives.Add(nameof(eTakeoff));
            this.receives.Add(nameof(eTakeoffReached));
            this.receives.Add(nameof(eTelemetryHealthAllOK));
            this.receives.Add(nameof(PHalt));
        }
        
        public void Anon_63(Event currentMachine_dequeuedEvent)
        {
            BatteryMonitor currentMachine = this;
            PMachineValue fc = (PMachineValue)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            flightcontroller = (PMachineValue)(((PMachineValue)((IPrtValue)fc)?.Clone()));
        }
        public void Anon_64(Event currentMachine_dequeuedEvent)
        {
            BatteryMonitor currentMachine = this;
            PrtFloat remaining = (PrtFloat)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_60 = ((PrtBool)false);
            PMachineValue TMP_tmp1_34 = null;
            PEvent TMP_tmp2_30 = null;
            PrtInt TMP_tmp3_28 = ((PrtInt)0);
            PMachineValue TMP_tmp4_9 = null;
            PEvent TMP_tmp5_8 = null;
            PrtInt TMP_tmp6_8 = ((PrtInt)0);
            TMP_tmp0_60 = (PrtBool)((remaining) < (((PrtFloat)0.1)));
            if (TMP_tmp0_60)
            {
                TMP_tmp1_34 = (PMachineValue)(((PMachineValue)((IPrtValue)flightcontroller)?.Clone()));
                TMP_tmp2_30 = (PEvent)(new eBatteryRemaining(((PrtInt)0)));
                TMP_tmp3_28 = (PrtInt)((PrtEnum.Get("CRITICAL")));
                currentMachine.TrySendEvent(TMP_tmp1_34, (Event)TMP_tmp2_30, TMP_tmp3_28);
            }
            else
            {
                TMP_tmp4_9 = (PMachineValue)(((PMachineValue)((IPrtValue)flightcontroller)?.Clone()));
                TMP_tmp5_8 = (PEvent)(new eBatteryRemaining(((PrtInt)0)));
                TMP_tmp6_8 = (PrtInt)((PrtEnum.Get("NORMAL")));
                currentMachine.TrySendEvent(TMP_tmp4_9, (Event)TMP_tmp5_8, TMP_tmp6_8);
            }
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_63))]
        [OnEventGotoState(typeof(eLinkInitialized), typeof(MonitorBattery))]
        [DeferEvents(typeof(eRespBatteryRemaining))]
        class Init : State
        {
        }
        [OnEventDoAction(typeof(eRespBatteryRemaining), nameof(Anon_64))]
        class MonitorBattery : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class SystemMonitor : PMachine
    {
        private PMachineValue flightcontroller_1 = null;
        public class ConstructorEvent : PEvent{public ConstructorEvent(PMachineValue val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((PMachineValue)value); }
        public SystemMonitor() {
            this.sends.Add(nameof(eArm));
            this.sends.Add(nameof(eBatteryRemaining));
            this.sends.Add(nameof(eDisarmed));
            this.sends.Add(nameof(eError));
            this.sends.Add(nameof(eHold));
            this.sends.Add(nameof(eInAir));
            this.sends.Add(nameof(eInAirStatus));
            this.sends.Add(nameof(eLanding));
            this.sends.Add(nameof(eLinkInitialized));
            this.sends.Add(nameof(eMavSDKReq));
            this.sends.Add(nameof(eMavSDKResp));
            this.sends.Add(nameof(eMissionCleared));
            this.sends.Add(nameof(eMissionStarted));
            this.sends.Add(nameof(eMissionUploaded));
            this.sends.Add(nameof(eRaiseError));
            this.sends.Add(nameof(eReqArm));
            this.sends.Add(nameof(eReqAtTakeoffAlt));
            this.sends.Add(nameof(eReqBatteryRemaining));
            this.sends.Add(nameof(eReqClearMission));
            this.sends.Add(nameof(eReqDisarm));
            this.sends.Add(nameof(eReqHold));
            this.sends.Add(nameof(eReqInAirStatus));
            this.sends.Add(nameof(eReqLand));
            this.sends.Add(nameof(eReqLandingState));
            this.sends.Add(nameof(eReqMissionFinished));
            this.sends.Add(nameof(eReqMissionStart));
            this.sends.Add(nameof(eReqMissionUpload));
            this.sends.Add(nameof(eReqReturnToLaunch));
            this.sends.Add(nameof(eReqSystemStatus));
            this.sends.Add(nameof(eReqTakeoff));
            this.sends.Add(nameof(eReqTelemetryHealth));
            this.sends.Add(nameof(eReqWaitForDisarmed));
            this.sends.Add(nameof(eRespArm));
            this.sends.Add(nameof(eRespAtTakeoffAlt));
            this.sends.Add(nameof(eRespBatteryRemaining));
            this.sends.Add(nameof(eRespClearMission));
            this.sends.Add(nameof(eRespDisarm));
            this.sends.Add(nameof(eRespHold));
            this.sends.Add(nameof(eRespInAirStatus));
            this.sends.Add(nameof(eRespLand));
            this.sends.Add(nameof(eRespLandingState));
            this.sends.Add(nameof(eRespMissionFinished));
            this.sends.Add(nameof(eRespMissionStart));
            this.sends.Add(nameof(eRespMissionUpload));
            this.sends.Add(nameof(eRespReturnToLaunch));
            this.sends.Add(nameof(eRespSystemStatus));
            this.sends.Add(nameof(eRespTakeoff));
            this.sends.Add(nameof(eRespTelemetryHealth));
            this.sends.Add(nameof(eRespWaitForDisarmed));
            this.sends.Add(nameof(eReturnToLaunch));
            this.sends.Add(nameof(eShutdownSystem));
            this.sends.Add(nameof(eSpec_PreFlight));
            this.sends.Add(nameof(eSystemConnected));
            this.sends.Add(nameof(eTakeoff));
            this.sends.Add(nameof(eTakeoffReached));
            this.sends.Add(nameof(eTelemetryHealthAllOK));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eArm));
            this.receives.Add(nameof(eBatteryRemaining));
            this.receives.Add(nameof(eDisarmed));
            this.receives.Add(nameof(eError));
            this.receives.Add(nameof(eHold));
            this.receives.Add(nameof(eInAir));
            this.receives.Add(nameof(eInAirStatus));
            this.receives.Add(nameof(eLanding));
            this.receives.Add(nameof(eLinkInitialized));
            this.receives.Add(nameof(eMavSDKReq));
            this.receives.Add(nameof(eMavSDKResp));
            this.receives.Add(nameof(eMissionCleared));
            this.receives.Add(nameof(eMissionStarted));
            this.receives.Add(nameof(eMissionUploaded));
            this.receives.Add(nameof(eRaiseError));
            this.receives.Add(nameof(eReqArm));
            this.receives.Add(nameof(eReqAtTakeoffAlt));
            this.receives.Add(nameof(eReqBatteryRemaining));
            this.receives.Add(nameof(eReqClearMission));
            this.receives.Add(nameof(eReqDisarm));
            this.receives.Add(nameof(eReqHold));
            this.receives.Add(nameof(eReqInAirStatus));
            this.receives.Add(nameof(eReqLand));
            this.receives.Add(nameof(eReqLandingState));
            this.receives.Add(nameof(eReqMissionFinished));
            this.receives.Add(nameof(eReqMissionStart));
            this.receives.Add(nameof(eReqMissionUpload));
            this.receives.Add(nameof(eReqReturnToLaunch));
            this.receives.Add(nameof(eReqSystemStatus));
            this.receives.Add(nameof(eReqTakeoff));
            this.receives.Add(nameof(eReqTelemetryHealth));
            this.receives.Add(nameof(eReqWaitForDisarmed));
            this.receives.Add(nameof(eRespArm));
            this.receives.Add(nameof(eRespAtTakeoffAlt));
            this.receives.Add(nameof(eRespBatteryRemaining));
            this.receives.Add(nameof(eRespClearMission));
            this.receives.Add(nameof(eRespDisarm));
            this.receives.Add(nameof(eRespHold));
            this.receives.Add(nameof(eRespInAirStatus));
            this.receives.Add(nameof(eRespLand));
            this.receives.Add(nameof(eRespLandingState));
            this.receives.Add(nameof(eRespMissionFinished));
            this.receives.Add(nameof(eRespMissionStart));
            this.receives.Add(nameof(eRespMissionUpload));
            this.receives.Add(nameof(eRespReturnToLaunch));
            this.receives.Add(nameof(eRespSystemStatus));
            this.receives.Add(nameof(eRespTakeoff));
            this.receives.Add(nameof(eRespTelemetryHealth));
            this.receives.Add(nameof(eRespWaitForDisarmed));
            this.receives.Add(nameof(eReturnToLaunch));
            this.receives.Add(nameof(eShutdownSystem));
            this.receives.Add(nameof(eSpec_PreFlight));
            this.receives.Add(nameof(eSystemConnected));
            this.receives.Add(nameof(eTakeoff));
            this.receives.Add(nameof(eTakeoffReached));
            this.receives.Add(nameof(eTelemetryHealthAllOK));
            this.receives.Add(nameof(PHalt));
        }
        
        public void Anon_65(Event currentMachine_dequeuedEvent)
        {
            SystemMonitor currentMachine = this;
            PMachineValue fc_1 = (PMachineValue)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            flightcontroller_1 = (PMachineValue)(((PMachineValue)((IPrtValue)fc_1)?.Clone()));
        }
        public void Anon_66(Event currentMachine_dequeuedEvent)
        {
            SystemMonitor currentMachine = this;
            PrtBool connected_8 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_61 = null;
            PEvent TMP_tmp1_35 = null;
            PrtBool TMP_tmp2_31 = ((PrtBool)false);
            TMP_tmp0_61 = (PMachineValue)(((PMachineValue)((IPrtValue)flightcontroller_1)?.Clone()));
            TMP_tmp1_35 = (PEvent)(new eSystemConnected(((PrtBool)false)));
            TMP_tmp2_31 = (PrtBool)(((PrtBool)((IPrtValue)connected_8)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp0_61, (Event)TMP_tmp1_35, TMP_tmp2_31);
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_65))]
        [OnEventGotoState(typeof(eLinkInitialized), typeof(MonitorSystem))]
        [DeferEvents(typeof(eRespSystemStatus))]
        class Init : State
        {
        }
        [OnEventDoAction(typeof(eRespSystemStatus), nameof(Anon_66))]
        class MonitorSystem : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class MissionMonitor : PMachine
    {
        private PMachineValue flightcontroller_2 = null;
        public class ConstructorEvent : PEvent{public ConstructorEvent(PMachineValue val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((PMachineValue)value); }
        public MissionMonitor() {
            this.sends.Add(nameof(eArm));
            this.sends.Add(nameof(eBatteryRemaining));
            this.sends.Add(nameof(eDisarmed));
            this.sends.Add(nameof(eError));
            this.sends.Add(nameof(eHold));
            this.sends.Add(nameof(eInAir));
            this.sends.Add(nameof(eInAirStatus));
            this.sends.Add(nameof(eLanding));
            this.sends.Add(nameof(eLinkInitialized));
            this.sends.Add(nameof(eMavSDKReq));
            this.sends.Add(nameof(eMavSDKResp));
            this.sends.Add(nameof(eMissionCleared));
            this.sends.Add(nameof(eMissionStarted));
            this.sends.Add(nameof(eMissionUploaded));
            this.sends.Add(nameof(eRaiseError));
            this.sends.Add(nameof(eReqArm));
            this.sends.Add(nameof(eReqAtTakeoffAlt));
            this.sends.Add(nameof(eReqBatteryRemaining));
            this.sends.Add(nameof(eReqClearMission));
            this.sends.Add(nameof(eReqDisarm));
            this.sends.Add(nameof(eReqHold));
            this.sends.Add(nameof(eReqInAirStatus));
            this.sends.Add(nameof(eReqLand));
            this.sends.Add(nameof(eReqLandingState));
            this.sends.Add(nameof(eReqMissionFinished));
            this.sends.Add(nameof(eReqMissionStart));
            this.sends.Add(nameof(eReqMissionUpload));
            this.sends.Add(nameof(eReqReturnToLaunch));
            this.sends.Add(nameof(eReqSystemStatus));
            this.sends.Add(nameof(eReqTakeoff));
            this.sends.Add(nameof(eReqTelemetryHealth));
            this.sends.Add(nameof(eReqWaitForDisarmed));
            this.sends.Add(nameof(eRespArm));
            this.sends.Add(nameof(eRespAtTakeoffAlt));
            this.sends.Add(nameof(eRespBatteryRemaining));
            this.sends.Add(nameof(eRespClearMission));
            this.sends.Add(nameof(eRespDisarm));
            this.sends.Add(nameof(eRespHold));
            this.sends.Add(nameof(eRespInAirStatus));
            this.sends.Add(nameof(eRespLand));
            this.sends.Add(nameof(eRespLandingState));
            this.sends.Add(nameof(eRespMissionFinished));
            this.sends.Add(nameof(eRespMissionStart));
            this.sends.Add(nameof(eRespMissionUpload));
            this.sends.Add(nameof(eRespReturnToLaunch));
            this.sends.Add(nameof(eRespSystemStatus));
            this.sends.Add(nameof(eRespTakeoff));
            this.sends.Add(nameof(eRespTelemetryHealth));
            this.sends.Add(nameof(eRespWaitForDisarmed));
            this.sends.Add(nameof(eReturnToLaunch));
            this.sends.Add(nameof(eShutdownSystem));
            this.sends.Add(nameof(eSpec_PreFlight));
            this.sends.Add(nameof(eSystemConnected));
            this.sends.Add(nameof(eTakeoff));
            this.sends.Add(nameof(eTakeoffReached));
            this.sends.Add(nameof(eTelemetryHealthAllOK));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eArm));
            this.receives.Add(nameof(eBatteryRemaining));
            this.receives.Add(nameof(eDisarmed));
            this.receives.Add(nameof(eError));
            this.receives.Add(nameof(eHold));
            this.receives.Add(nameof(eInAir));
            this.receives.Add(nameof(eInAirStatus));
            this.receives.Add(nameof(eLanding));
            this.receives.Add(nameof(eLinkInitialized));
            this.receives.Add(nameof(eMavSDKReq));
            this.receives.Add(nameof(eMavSDKResp));
            this.receives.Add(nameof(eMissionCleared));
            this.receives.Add(nameof(eMissionStarted));
            this.receives.Add(nameof(eMissionUploaded));
            this.receives.Add(nameof(eRaiseError));
            this.receives.Add(nameof(eReqArm));
            this.receives.Add(nameof(eReqAtTakeoffAlt));
            this.receives.Add(nameof(eReqBatteryRemaining));
            this.receives.Add(nameof(eReqClearMission));
            this.receives.Add(nameof(eReqDisarm));
            this.receives.Add(nameof(eReqHold));
            this.receives.Add(nameof(eReqInAirStatus));
            this.receives.Add(nameof(eReqLand));
            this.receives.Add(nameof(eReqLandingState));
            this.receives.Add(nameof(eReqMissionFinished));
            this.receives.Add(nameof(eReqMissionStart));
            this.receives.Add(nameof(eReqMissionUpload));
            this.receives.Add(nameof(eReqReturnToLaunch));
            this.receives.Add(nameof(eReqSystemStatus));
            this.receives.Add(nameof(eReqTakeoff));
            this.receives.Add(nameof(eReqTelemetryHealth));
            this.receives.Add(nameof(eReqWaitForDisarmed));
            this.receives.Add(nameof(eRespArm));
            this.receives.Add(nameof(eRespAtTakeoffAlt));
            this.receives.Add(nameof(eRespBatteryRemaining));
            this.receives.Add(nameof(eRespClearMission));
            this.receives.Add(nameof(eRespDisarm));
            this.receives.Add(nameof(eRespHold));
            this.receives.Add(nameof(eRespInAirStatus));
            this.receives.Add(nameof(eRespLand));
            this.receives.Add(nameof(eRespLandingState));
            this.receives.Add(nameof(eRespMissionFinished));
            this.receives.Add(nameof(eRespMissionStart));
            this.receives.Add(nameof(eRespMissionUpload));
            this.receives.Add(nameof(eRespReturnToLaunch));
            this.receives.Add(nameof(eRespSystemStatus));
            this.receives.Add(nameof(eRespTakeoff));
            this.receives.Add(nameof(eRespTelemetryHealth));
            this.receives.Add(nameof(eRespWaitForDisarmed));
            this.receives.Add(nameof(eReturnToLaunch));
            this.receives.Add(nameof(eShutdownSystem));
            this.receives.Add(nameof(eSpec_PreFlight));
            this.receives.Add(nameof(eSystemConnected));
            this.receives.Add(nameof(eTakeoff));
            this.receives.Add(nameof(eTakeoffReached));
            this.receives.Add(nameof(eTelemetryHealthAllOK));
            this.receives.Add(nameof(PHalt));
        }
        
        public void Anon_67(Event currentMachine_dequeuedEvent)
        {
            MissionMonitor currentMachine = this;
            PMachineValue fc_2 = (PMachineValue)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            flightcontroller_2 = (PMachineValue)(((PMachineValue)((IPrtValue)fc_2)?.Clone()));
        }
        public void Anon_68(Event currentMachine_dequeuedEvent)
        {
            MissionMonitor currentMachine = this;
            PrtBool uploaded = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_62 = null;
            PEvent TMP_tmp1_36 = null;
            PrtBool TMP_tmp2_32 = ((PrtBool)false);
            TMP_tmp0_62 = (PMachineValue)(((PMachineValue)((IPrtValue)flightcontroller_2)?.Clone()));
            TMP_tmp1_36 = (PEvent)(new eMissionUploaded(((PrtBool)false)));
            TMP_tmp2_32 = (PrtBool)(((PrtBool)((IPrtValue)uploaded)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp0_62, (Event)TMP_tmp1_36, TMP_tmp2_32);
        }
        public void Anon_69(Event currentMachine_dequeuedEvent)
        {
            MissionMonitor currentMachine = this;
            PrtBool status_27 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_63 = null;
            PEvent TMP_tmp1_37 = null;
            PrtBool TMP_tmp2_33 = ((PrtBool)false);
            TMP_tmp0_63 = (PMachineValue)(((PMachineValue)((IPrtValue)flightcontroller_2)?.Clone()));
            TMP_tmp1_37 = (PEvent)(new eMissionStarted(((PrtBool)false)));
            TMP_tmp2_33 = (PrtBool)(((PrtBool)((IPrtValue)status_27)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp0_63, (Event)TMP_tmp1_37, TMP_tmp2_33);
        }
        public void Anon_70(Event currentMachine_dequeuedEvent)
        {
            MissionMonitor currentMachine = this;
            PrtBool cleared = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_64 = null;
            PEvent TMP_tmp1_38 = null;
            PrtBool TMP_tmp2_34 = ((PrtBool)false);
            TMP_tmp0_64 = (PMachineValue)(((PMachineValue)((IPrtValue)flightcontroller_2)?.Clone()));
            TMP_tmp1_38 = (PEvent)(new eMissionCleared(((PrtBool)false)));
            TMP_tmp2_34 = (PrtBool)(((PrtBool)((IPrtValue)cleared)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp0_64, (Event)TMP_tmp1_38, TMP_tmp2_34);
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_67))]
        [OnEventGotoState(typeof(eLinkInitialized), typeof(MonitorMission))]
        class Init : State
        {
        }
        [OnEventDoAction(typeof(eRespMissionUpload), nameof(Anon_68))]
        [OnEventDoAction(typeof(eRespMissionStart), nameof(Anon_69))]
        [OnEventDoAction(typeof(eRespClearMission), nameof(Anon_70))]
        class MonitorMission : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class TelemetryMonitor : PMachine
    {
        private PMachineValue flightcontroller_3 = null;
        public class ConstructorEvent : PEvent{public ConstructorEvent(PMachineValue val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((PMachineValue)value); }
        public TelemetryMonitor() {
            this.sends.Add(nameof(eArm));
            this.sends.Add(nameof(eBatteryRemaining));
            this.sends.Add(nameof(eDisarmed));
            this.sends.Add(nameof(eError));
            this.sends.Add(nameof(eHold));
            this.sends.Add(nameof(eInAir));
            this.sends.Add(nameof(eInAirStatus));
            this.sends.Add(nameof(eLanding));
            this.sends.Add(nameof(eLinkInitialized));
            this.sends.Add(nameof(eMavSDKReq));
            this.sends.Add(nameof(eMavSDKResp));
            this.sends.Add(nameof(eMissionCleared));
            this.sends.Add(nameof(eMissionStarted));
            this.sends.Add(nameof(eMissionUploaded));
            this.sends.Add(nameof(eRaiseError));
            this.sends.Add(nameof(eReqArm));
            this.sends.Add(nameof(eReqAtTakeoffAlt));
            this.sends.Add(nameof(eReqBatteryRemaining));
            this.sends.Add(nameof(eReqClearMission));
            this.sends.Add(nameof(eReqDisarm));
            this.sends.Add(nameof(eReqHold));
            this.sends.Add(nameof(eReqInAirStatus));
            this.sends.Add(nameof(eReqLand));
            this.sends.Add(nameof(eReqLandingState));
            this.sends.Add(nameof(eReqMissionFinished));
            this.sends.Add(nameof(eReqMissionStart));
            this.sends.Add(nameof(eReqMissionUpload));
            this.sends.Add(nameof(eReqReturnToLaunch));
            this.sends.Add(nameof(eReqSystemStatus));
            this.sends.Add(nameof(eReqTakeoff));
            this.sends.Add(nameof(eReqTelemetryHealth));
            this.sends.Add(nameof(eReqWaitForDisarmed));
            this.sends.Add(nameof(eRespArm));
            this.sends.Add(nameof(eRespAtTakeoffAlt));
            this.sends.Add(nameof(eRespBatteryRemaining));
            this.sends.Add(nameof(eRespClearMission));
            this.sends.Add(nameof(eRespDisarm));
            this.sends.Add(nameof(eRespHold));
            this.sends.Add(nameof(eRespInAirStatus));
            this.sends.Add(nameof(eRespLand));
            this.sends.Add(nameof(eRespLandingState));
            this.sends.Add(nameof(eRespMissionFinished));
            this.sends.Add(nameof(eRespMissionStart));
            this.sends.Add(nameof(eRespMissionUpload));
            this.sends.Add(nameof(eRespReturnToLaunch));
            this.sends.Add(nameof(eRespSystemStatus));
            this.sends.Add(nameof(eRespTakeoff));
            this.sends.Add(nameof(eRespTelemetryHealth));
            this.sends.Add(nameof(eRespWaitForDisarmed));
            this.sends.Add(nameof(eReturnToLaunch));
            this.sends.Add(nameof(eShutdownSystem));
            this.sends.Add(nameof(eSpec_PreFlight));
            this.sends.Add(nameof(eSystemConnected));
            this.sends.Add(nameof(eTakeoff));
            this.sends.Add(nameof(eTakeoffReached));
            this.sends.Add(nameof(eTelemetryHealthAllOK));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eArm));
            this.receives.Add(nameof(eBatteryRemaining));
            this.receives.Add(nameof(eDisarmed));
            this.receives.Add(nameof(eError));
            this.receives.Add(nameof(eHold));
            this.receives.Add(nameof(eInAir));
            this.receives.Add(nameof(eInAirStatus));
            this.receives.Add(nameof(eLanding));
            this.receives.Add(nameof(eLinkInitialized));
            this.receives.Add(nameof(eMavSDKReq));
            this.receives.Add(nameof(eMavSDKResp));
            this.receives.Add(nameof(eMissionCleared));
            this.receives.Add(nameof(eMissionStarted));
            this.receives.Add(nameof(eMissionUploaded));
            this.receives.Add(nameof(eRaiseError));
            this.receives.Add(nameof(eReqArm));
            this.receives.Add(nameof(eReqAtTakeoffAlt));
            this.receives.Add(nameof(eReqBatteryRemaining));
            this.receives.Add(nameof(eReqClearMission));
            this.receives.Add(nameof(eReqDisarm));
            this.receives.Add(nameof(eReqHold));
            this.receives.Add(nameof(eReqInAirStatus));
            this.receives.Add(nameof(eReqLand));
            this.receives.Add(nameof(eReqLandingState));
            this.receives.Add(nameof(eReqMissionFinished));
            this.receives.Add(nameof(eReqMissionStart));
            this.receives.Add(nameof(eReqMissionUpload));
            this.receives.Add(nameof(eReqReturnToLaunch));
            this.receives.Add(nameof(eReqSystemStatus));
            this.receives.Add(nameof(eReqTakeoff));
            this.receives.Add(nameof(eReqTelemetryHealth));
            this.receives.Add(nameof(eReqWaitForDisarmed));
            this.receives.Add(nameof(eRespArm));
            this.receives.Add(nameof(eRespAtTakeoffAlt));
            this.receives.Add(nameof(eRespBatteryRemaining));
            this.receives.Add(nameof(eRespClearMission));
            this.receives.Add(nameof(eRespDisarm));
            this.receives.Add(nameof(eRespHold));
            this.receives.Add(nameof(eRespInAirStatus));
            this.receives.Add(nameof(eRespLand));
            this.receives.Add(nameof(eRespLandingState));
            this.receives.Add(nameof(eRespMissionFinished));
            this.receives.Add(nameof(eRespMissionStart));
            this.receives.Add(nameof(eRespMissionUpload));
            this.receives.Add(nameof(eRespReturnToLaunch));
            this.receives.Add(nameof(eRespSystemStatus));
            this.receives.Add(nameof(eRespTakeoff));
            this.receives.Add(nameof(eRespTelemetryHealth));
            this.receives.Add(nameof(eRespWaitForDisarmed));
            this.receives.Add(nameof(eReturnToLaunch));
            this.receives.Add(nameof(eShutdownSystem));
            this.receives.Add(nameof(eSpec_PreFlight));
            this.receives.Add(nameof(eSystemConnected));
            this.receives.Add(nameof(eTakeoff));
            this.receives.Add(nameof(eTakeoffReached));
            this.receives.Add(nameof(eTelemetryHealthAllOK));
            this.receives.Add(nameof(PHalt));
        }
        
        public void Anon_71(Event currentMachine_dequeuedEvent)
        {
            TelemetryMonitor currentMachine = this;
            PMachineValue fc_3 = (PMachineValue)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            flightcontroller_3 = (PMachineValue)(((PMachineValue)((IPrtValue)fc_3)?.Clone()));
        }
        public void Anon_72(Event currentMachine_dequeuedEvent)
        {
            TelemetryMonitor currentMachine = this;
            PrtBool health_6 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_65 = null;
            PEvent TMP_tmp1_39 = null;
            PrtBool TMP_tmp2_35 = ((PrtBool)false);
            TMP_tmp0_65 = (PMachineValue)(((PMachineValue)((IPrtValue)flightcontroller_3)?.Clone()));
            TMP_tmp1_39 = (PEvent)(new eTelemetryHealthAllOK(((PrtBool)false)));
            TMP_tmp2_35 = (PrtBool)(((PrtBool)((IPrtValue)health_6)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp0_65, (Event)TMP_tmp1_39, TMP_tmp2_35);
        }
        public void Anon_73(Event currentMachine_dequeuedEvent)
        {
            TelemetryMonitor currentMachine = this;
            PrtBool status_28 = (PrtBool)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_66 = null;
            PEvent TMP_tmp1_40 = null;
            PrtBool TMP_tmp2_36 = ((PrtBool)false);
            TMP_tmp0_66 = (PMachineValue)(((PMachineValue)((IPrtValue)flightcontroller_3)?.Clone()));
            TMP_tmp1_40 = (PEvent)(new eInAirStatus(((PrtBool)false)));
            TMP_tmp2_36 = (PrtBool)(((PrtBool)((IPrtValue)status_28)?.Clone()));
            currentMachine.TrySendEvent(TMP_tmp0_66, (Event)TMP_tmp1_40, TMP_tmp2_36);
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_71))]
        [OnEventGotoState(typeof(eLinkInitialized), typeof(MonitorTelemetry))]
        [DeferEvents(typeof(eRespTelemetryHealth))]
        class Init : State
        {
        }
        [OnEventDoAction(typeof(eRespTelemetryHealth), nameof(Anon_72))]
        [OnEventDoAction(typeof(eRespInAirStatus), nameof(Anon_73))]
        class MonitorTelemetry : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class DroneModesOfOperation : PMonitor
    {
        static DroneModesOfOperation() {
            observes.Add(nameof(eArm));
            observes.Add(nameof(eDisarmed));
            observes.Add(nameof(eError));
            observes.Add(nameof(eHold));
            observes.Add(nameof(eInAir));
            observes.Add(nameof(eLanding));
            observes.Add(nameof(eReturnToLaunch));
            observes.Add(nameof(eShutdownSystem));
            observes.Add(nameof(eSpec_PreFlight));
            observes.Add(nameof(eTakeoff));
        }
        
        public void Anon_74(Event currentMachine_dequeuedEvent)
        {
            DroneModesOfOperation currentMachine = this;
            currentMachine.TryGotoState<PreFlight>();
            return;
        }
        public void Anon_75(Event currentMachine_dequeuedEvent)
        {
            DroneModesOfOperation currentMachine = this;
            PrtString TMP_tmp0_67 = ((PrtString)"");
            PrtString TMP_tmp1_41 = ((PrtString)"");
            PrtString TMP_tmp2_37 = ((PrtString)"");
            TMP_tmp0_67 = (PrtString)(((PrtString) String.Format("PSpec/Safety.p:96:13")));
            TMP_tmp1_41 = (PrtString)(((PrtString) String.Format("Error state reached")));
            TMP_tmp2_37 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp0_67,TMP_tmp1_41)));
            currentMachine.TryAssert(((PrtBool)false),"Assertion Failed: " + TMP_tmp2_37);
            throw new PUnreachableCodeException();
        }
        public void Anon_76(Event currentMachine_dequeuedEvent)
        {
            DroneModesOfOperation currentMachine = this;
            PrtString TMP_tmp0_68 = ((PrtString)"");
            PrtString TMP_tmp1_42 = ((PrtString)"");
            PrtString TMP_tmp2_38 = ((PrtString)"");
            TMP_tmp0_68 = (PrtString)(((PrtString) String.Format("PSpec/Safety.p:99:13")));
            TMP_tmp1_42 = (PrtString)(((PrtString) String.Format("Error state reached")));
            TMP_tmp2_38 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp0_68,TMP_tmp1_42)));
            currentMachine.TryAssert(((PrtBool)false),"Assertion Failed: " + TMP_tmp2_38);
            throw new PUnreachableCodeException();
        }
        [Start]
        [OnEventDoAction(typeof(eSpec_PreFlight), nameof(Anon_74))]
        [OnEventGotoState(typeof(eError), typeof(Error))]
        class Init : State
        {
        }
        [OnEventGotoState(typeof(eError), typeof(Error))]
        [OnEventGotoState(typeof(eArm), typeof(Arm))]
        [OnEventGotoState(typeof(eShutdownSystem), typeof(Shutdown))]
        class PreFlight : State
        {
        }
        [OnEventGotoState(typeof(eTakeoff), typeof(Takeoff))]
        [OnEventGotoState(typeof(eError), typeof(Error))]
        [OnEventGotoState(typeof(eDisarmed), typeof(Disarm))]
        class Arm : State
        {
        }
        [OnEventGotoState(typeof(eTakeoff), typeof(Takeoff))]
        [OnEventGotoState(typeof(eHold), typeof(Hold))]
        [OnEventGotoState(typeof(eError), typeof(Error))]
        [OnEventGotoState(typeof(eReturnToLaunch), typeof(ReturnToLaunch))]
        class Takeoff : State
        {
        }
        [OnEventGotoState(typeof(eInAir), typeof(InAir))]
        [OnEventGotoState(typeof(eError), typeof(Error))]
        [OnEventGotoState(typeof(eReturnToLaunch), typeof(ReturnToLaunch))]
        class Hold : State
        {
        }
        [OnEventGotoState(typeof(eInAir), typeof(InAir))]
        [OnEventGotoState(typeof(eReturnToLaunch), typeof(ReturnToLaunch))]
        [OnEventGotoState(typeof(eError), typeof(Error))]
        [OnEventGotoState(typeof(eLanding), typeof(Land))]
        class InAir : State
        {
        }
        [OnEventGotoState(typeof(eLanding), typeof(Land))]
        [OnEventGotoState(typeof(eError), typeof(Error))]
        [OnEventGotoState(typeof(eDisarmed), typeof(Disarm))]
        class Land : State
        {
        }
        [OnEventGotoState(typeof(eError), typeof(Error))]
        [OnEventGotoState(typeof(eShutdownSystem), typeof(Shutdown))]
        class Disarm : State
        {
        }
        [OnEventGotoState(typeof(eReturnToLaunch), typeof(ReturnToLaunch))]
        [OnEventGotoState(typeof(eShutdownSystem), typeof(Shutdown))]
        [OnEventGotoState(typeof(eError), typeof(Error))]
        class ReturnToLaunch : State
        {
        }
        [IgnoreEvents(typeof(eShutdownSystem))]
        class Shutdown : State
        {
        }
        [Hot]
        [OnEntry(nameof(Anon_75))]
        [OnEventDoAction(typeof(eError), nameof(Anon_76))]
        class Error : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class LivenessMonitor : PMonitor
    {
        private PrtSet reqId = new PrtSet();
        static LivenessMonitor() {
            observes.Add(nameof(eMavSDKReq));
            observes.Add(nameof(eMavSDKResp));
        }
        
        public void Anon_77(Event currentMachine_dequeuedEvent)
        {
            LivenessMonitor currentMachine = this;
            PrtInt id = (PrtInt)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtInt TMP_tmp0_69 = ((PrtInt)0);
            TMP_tmp0_69 = (PrtInt)(((PrtInt)((IPrtValue)id)?.Clone()));
            ((PrtSet)reqId).Add(TMP_tmp0_69);
        }
        public void Anon_78(Event currentMachine_dequeuedEvent)
        {
            LivenessMonitor currentMachine = this;
            PrtInt id_1 = (PrtInt)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool TMP_tmp0_70 = ((PrtBool)false);
            PrtString TMP_tmp1_43 = ((PrtString)"");
            PrtInt TMP_tmp2_39 = ((PrtInt)0);
            PrtSet TMP_tmp3_29 = new PrtSet();
            PrtString TMP_tmp4_10 = ((PrtString)"");
            PrtString TMP_tmp5_9 = ((PrtString)"");
            PrtInt TMP_tmp6_9 = ((PrtInt)0);
            PrtBool TMP_tmp7_8 = ((PrtBool)false);
            TMP_tmp0_70 = (PrtBool)(((PrtBool)(((PrtSet)reqId).Contains(id_1))));
            if (TMP_tmp0_70)
            {
            }
            else
            {
                TMP_tmp1_43 = (PrtString)(((PrtString) String.Format("PSpec/Safety.p:125:13")));
                TMP_tmp2_39 = (PrtInt)(((PrtInt)((IPrtValue)id_1)?.Clone()));
                TMP_tmp3_29 = (PrtSet)(((PrtSet)((IPrtValue)reqId)?.Clone()));
                TMP_tmp4_10 = (PrtString)(((PrtString) String.Format("Unexpected rId: {0} received, expected one of {1}",TMP_tmp2_39,TMP_tmp3_29)));
                TMP_tmp5_9 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp1_43,TMP_tmp4_10)));
                currentMachine.TryAssert(TMP_tmp0_70,"Assertion Failed: " + TMP_tmp5_9);
            }
            ((PrtSet)reqId).Remove(id_1);
            TMP_tmp6_9 = (PrtInt)(((PrtInt)(reqId).Count));
            TMP_tmp7_8 = (PrtBool)((PrtValues.SafeEquals(TMP_tmp6_9,((PrtInt)(0)))));
            if (TMP_tmp7_8)
            {
                currentMachine.TryGotoState<Init>();
                return;
            }
        }
        public void Anon_79(Event currentMachine_dequeuedEvent)
        {
            LivenessMonitor currentMachine = this;
            PrtInt id_2 = (PrtInt)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtInt TMP_tmp0_71 = ((PrtInt)0);
            TMP_tmp0_71 = (PrtInt)(((PrtInt)((IPrtValue)id_2)?.Clone()));
            ((PrtSet)reqId).Add(TMP_tmp0_71);
        }
        [Start]
        [OnEventGotoState(typeof(eMavSDKReq), typeof(PendingReqs), nameof(Anon_77))]
        [IgnoreEvents(typeof(eMavSDKResp))]
        class Init : State
        {
        }
        [Hot]
        [OnEventDoAction(typeof(eMavSDKResp), nameof(Anon_78))]
        [OnEventGotoState(typeof(eMavSDKReq), typeof(PendingReqs), nameof(Anon_79))]
        class PendingReqs : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class Drone : PMachine
    {
        private PMachineValue fc_4 = null;
        public class ConstructorEvent : PEvent{public ConstructorEvent(IPrtValue val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((IPrtValue)value); }
        public Drone() {
            this.sends.Add(nameof(eArm));
            this.sends.Add(nameof(eBatteryRemaining));
            this.sends.Add(nameof(eDisarmed));
            this.sends.Add(nameof(eError));
            this.sends.Add(nameof(eHold));
            this.sends.Add(nameof(eInAir));
            this.sends.Add(nameof(eInAirStatus));
            this.sends.Add(nameof(eLanding));
            this.sends.Add(nameof(eLinkInitialized));
            this.sends.Add(nameof(eMavSDKReq));
            this.sends.Add(nameof(eMavSDKResp));
            this.sends.Add(nameof(eMissionCleared));
            this.sends.Add(nameof(eMissionStarted));
            this.sends.Add(nameof(eMissionUploaded));
            this.sends.Add(nameof(eRaiseError));
            this.sends.Add(nameof(eReqArm));
            this.sends.Add(nameof(eReqAtTakeoffAlt));
            this.sends.Add(nameof(eReqBatteryRemaining));
            this.sends.Add(nameof(eReqClearMission));
            this.sends.Add(nameof(eReqDisarm));
            this.sends.Add(nameof(eReqHold));
            this.sends.Add(nameof(eReqInAirStatus));
            this.sends.Add(nameof(eReqLand));
            this.sends.Add(nameof(eReqLandingState));
            this.sends.Add(nameof(eReqMissionFinished));
            this.sends.Add(nameof(eReqMissionStart));
            this.sends.Add(nameof(eReqMissionUpload));
            this.sends.Add(nameof(eReqReturnToLaunch));
            this.sends.Add(nameof(eReqSystemStatus));
            this.sends.Add(nameof(eReqTakeoff));
            this.sends.Add(nameof(eReqTelemetryHealth));
            this.sends.Add(nameof(eReqWaitForDisarmed));
            this.sends.Add(nameof(eRespArm));
            this.sends.Add(nameof(eRespAtTakeoffAlt));
            this.sends.Add(nameof(eRespBatteryRemaining));
            this.sends.Add(nameof(eRespClearMission));
            this.sends.Add(nameof(eRespDisarm));
            this.sends.Add(nameof(eRespHold));
            this.sends.Add(nameof(eRespInAirStatus));
            this.sends.Add(nameof(eRespLand));
            this.sends.Add(nameof(eRespLandingState));
            this.sends.Add(nameof(eRespMissionFinished));
            this.sends.Add(nameof(eRespMissionStart));
            this.sends.Add(nameof(eRespMissionUpload));
            this.sends.Add(nameof(eRespReturnToLaunch));
            this.sends.Add(nameof(eRespSystemStatus));
            this.sends.Add(nameof(eRespTakeoff));
            this.sends.Add(nameof(eRespTelemetryHealth));
            this.sends.Add(nameof(eRespWaitForDisarmed));
            this.sends.Add(nameof(eReturnToLaunch));
            this.sends.Add(nameof(eShutdownSystem));
            this.sends.Add(nameof(eSpec_PreFlight));
            this.sends.Add(nameof(eSystemConnected));
            this.sends.Add(nameof(eTakeoff));
            this.sends.Add(nameof(eTakeoffReached));
            this.sends.Add(nameof(eTelemetryHealthAllOK));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eArm));
            this.receives.Add(nameof(eBatteryRemaining));
            this.receives.Add(nameof(eDisarmed));
            this.receives.Add(nameof(eError));
            this.receives.Add(nameof(eHold));
            this.receives.Add(nameof(eInAir));
            this.receives.Add(nameof(eInAirStatus));
            this.receives.Add(nameof(eLanding));
            this.receives.Add(nameof(eLinkInitialized));
            this.receives.Add(nameof(eMavSDKReq));
            this.receives.Add(nameof(eMavSDKResp));
            this.receives.Add(nameof(eMissionCleared));
            this.receives.Add(nameof(eMissionStarted));
            this.receives.Add(nameof(eMissionUploaded));
            this.receives.Add(nameof(eRaiseError));
            this.receives.Add(nameof(eReqArm));
            this.receives.Add(nameof(eReqAtTakeoffAlt));
            this.receives.Add(nameof(eReqBatteryRemaining));
            this.receives.Add(nameof(eReqClearMission));
            this.receives.Add(nameof(eReqDisarm));
            this.receives.Add(nameof(eReqHold));
            this.receives.Add(nameof(eReqInAirStatus));
            this.receives.Add(nameof(eReqLand));
            this.receives.Add(nameof(eReqLandingState));
            this.receives.Add(nameof(eReqMissionFinished));
            this.receives.Add(nameof(eReqMissionStart));
            this.receives.Add(nameof(eReqMissionUpload));
            this.receives.Add(nameof(eReqReturnToLaunch));
            this.receives.Add(nameof(eReqSystemStatus));
            this.receives.Add(nameof(eReqTakeoff));
            this.receives.Add(nameof(eReqTelemetryHealth));
            this.receives.Add(nameof(eReqWaitForDisarmed));
            this.receives.Add(nameof(eRespArm));
            this.receives.Add(nameof(eRespAtTakeoffAlt));
            this.receives.Add(nameof(eRespBatteryRemaining));
            this.receives.Add(nameof(eRespClearMission));
            this.receives.Add(nameof(eRespDisarm));
            this.receives.Add(nameof(eRespHold));
            this.receives.Add(nameof(eRespInAirStatus));
            this.receives.Add(nameof(eRespLand));
            this.receives.Add(nameof(eRespLandingState));
            this.receives.Add(nameof(eRespMissionFinished));
            this.receives.Add(nameof(eRespMissionStart));
            this.receives.Add(nameof(eRespMissionUpload));
            this.receives.Add(nameof(eRespReturnToLaunch));
            this.receives.Add(nameof(eRespSystemStatus));
            this.receives.Add(nameof(eRespTakeoff));
            this.receives.Add(nameof(eRespTelemetryHealth));
            this.receives.Add(nameof(eRespWaitForDisarmed));
            this.receives.Add(nameof(eReturnToLaunch));
            this.receives.Add(nameof(eShutdownSystem));
            this.receives.Add(nameof(eSpec_PreFlight));
            this.receives.Add(nameof(eSystemConnected));
            this.receives.Add(nameof(eTakeoff));
            this.receives.Add(nameof(eTakeoffReached));
            this.receives.Add(nameof(eTelemetryHealthAllOK));
            this.receives.Add(nameof(PHalt));
            this.creates.Add(nameof(I_FlightController));
        }
        
        public void Anon_80(Event currentMachine_dequeuedEvent)
        {
            Drone currentMachine = this;
            PMachineValue TMP_tmp0_72 = null;
            PMachineValue TMP_tmp1_44 = null;
            TMP_tmp0_72 = (PMachineValue)(currentMachine.self);
            TMP_tmp1_44 = (PMachineValue)(currentMachine.CreateInterface<I_FlightController>( currentMachine, TMP_tmp0_72));
            fc_4 = TMP_tmp1_44;
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_80))]
        class Init : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class FailureDrone : PMachine
    {
        private PMachineValue fc_5 = null;
        private PMachineValue fi = null;
        public class ConstructorEvent : PEvent{public ConstructorEvent(IPrtValue val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((IPrtValue)value); }
        public FailureDrone() {
            this.sends.Add(nameof(eArm));
            this.sends.Add(nameof(eBatteryRemaining));
            this.sends.Add(nameof(eDisarmed));
            this.sends.Add(nameof(eError));
            this.sends.Add(nameof(eHold));
            this.sends.Add(nameof(eInAir));
            this.sends.Add(nameof(eInAirStatus));
            this.sends.Add(nameof(eLanding));
            this.sends.Add(nameof(eLinkInitialized));
            this.sends.Add(nameof(eMavSDKReq));
            this.sends.Add(nameof(eMavSDKResp));
            this.sends.Add(nameof(eMissionCleared));
            this.sends.Add(nameof(eMissionStarted));
            this.sends.Add(nameof(eMissionUploaded));
            this.sends.Add(nameof(eRaiseError));
            this.sends.Add(nameof(eReqArm));
            this.sends.Add(nameof(eReqAtTakeoffAlt));
            this.sends.Add(nameof(eReqBatteryRemaining));
            this.sends.Add(nameof(eReqClearMission));
            this.sends.Add(nameof(eReqDisarm));
            this.sends.Add(nameof(eReqHold));
            this.sends.Add(nameof(eReqInAirStatus));
            this.sends.Add(nameof(eReqLand));
            this.sends.Add(nameof(eReqLandingState));
            this.sends.Add(nameof(eReqMissionFinished));
            this.sends.Add(nameof(eReqMissionStart));
            this.sends.Add(nameof(eReqMissionUpload));
            this.sends.Add(nameof(eReqReturnToLaunch));
            this.sends.Add(nameof(eReqSystemStatus));
            this.sends.Add(nameof(eReqTakeoff));
            this.sends.Add(nameof(eReqTelemetryHealth));
            this.sends.Add(nameof(eReqWaitForDisarmed));
            this.sends.Add(nameof(eRespArm));
            this.sends.Add(nameof(eRespAtTakeoffAlt));
            this.sends.Add(nameof(eRespBatteryRemaining));
            this.sends.Add(nameof(eRespClearMission));
            this.sends.Add(nameof(eRespDisarm));
            this.sends.Add(nameof(eRespHold));
            this.sends.Add(nameof(eRespInAirStatus));
            this.sends.Add(nameof(eRespLand));
            this.sends.Add(nameof(eRespLandingState));
            this.sends.Add(nameof(eRespMissionFinished));
            this.sends.Add(nameof(eRespMissionStart));
            this.sends.Add(nameof(eRespMissionUpload));
            this.sends.Add(nameof(eRespReturnToLaunch));
            this.sends.Add(nameof(eRespSystemStatus));
            this.sends.Add(nameof(eRespTakeoff));
            this.sends.Add(nameof(eRespTelemetryHealth));
            this.sends.Add(nameof(eRespWaitForDisarmed));
            this.sends.Add(nameof(eReturnToLaunch));
            this.sends.Add(nameof(eShutdownSystem));
            this.sends.Add(nameof(eSpec_PreFlight));
            this.sends.Add(nameof(eSystemConnected));
            this.sends.Add(nameof(eTakeoff));
            this.sends.Add(nameof(eTakeoffReached));
            this.sends.Add(nameof(eTelemetryHealthAllOK));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eArm));
            this.receives.Add(nameof(eBatteryRemaining));
            this.receives.Add(nameof(eDisarmed));
            this.receives.Add(nameof(eError));
            this.receives.Add(nameof(eHold));
            this.receives.Add(nameof(eInAir));
            this.receives.Add(nameof(eInAirStatus));
            this.receives.Add(nameof(eLanding));
            this.receives.Add(nameof(eLinkInitialized));
            this.receives.Add(nameof(eMavSDKReq));
            this.receives.Add(nameof(eMavSDKResp));
            this.receives.Add(nameof(eMissionCleared));
            this.receives.Add(nameof(eMissionStarted));
            this.receives.Add(nameof(eMissionUploaded));
            this.receives.Add(nameof(eRaiseError));
            this.receives.Add(nameof(eReqArm));
            this.receives.Add(nameof(eReqAtTakeoffAlt));
            this.receives.Add(nameof(eReqBatteryRemaining));
            this.receives.Add(nameof(eReqClearMission));
            this.receives.Add(nameof(eReqDisarm));
            this.receives.Add(nameof(eReqHold));
            this.receives.Add(nameof(eReqInAirStatus));
            this.receives.Add(nameof(eReqLand));
            this.receives.Add(nameof(eReqLandingState));
            this.receives.Add(nameof(eReqMissionFinished));
            this.receives.Add(nameof(eReqMissionStart));
            this.receives.Add(nameof(eReqMissionUpload));
            this.receives.Add(nameof(eReqReturnToLaunch));
            this.receives.Add(nameof(eReqSystemStatus));
            this.receives.Add(nameof(eReqTakeoff));
            this.receives.Add(nameof(eReqTelemetryHealth));
            this.receives.Add(nameof(eReqWaitForDisarmed));
            this.receives.Add(nameof(eRespArm));
            this.receives.Add(nameof(eRespAtTakeoffAlt));
            this.receives.Add(nameof(eRespBatteryRemaining));
            this.receives.Add(nameof(eRespClearMission));
            this.receives.Add(nameof(eRespDisarm));
            this.receives.Add(nameof(eRespHold));
            this.receives.Add(nameof(eRespInAirStatus));
            this.receives.Add(nameof(eRespLand));
            this.receives.Add(nameof(eRespLandingState));
            this.receives.Add(nameof(eRespMissionFinished));
            this.receives.Add(nameof(eRespMissionStart));
            this.receives.Add(nameof(eRespMissionUpload));
            this.receives.Add(nameof(eRespReturnToLaunch));
            this.receives.Add(nameof(eRespSystemStatus));
            this.receives.Add(nameof(eRespTakeoff));
            this.receives.Add(nameof(eRespTelemetryHealth));
            this.receives.Add(nameof(eRespWaitForDisarmed));
            this.receives.Add(nameof(eReturnToLaunch));
            this.receives.Add(nameof(eShutdownSystem));
            this.receives.Add(nameof(eSpec_PreFlight));
            this.receives.Add(nameof(eSystemConnected));
            this.receives.Add(nameof(eTakeoff));
            this.receives.Add(nameof(eTakeoffReached));
            this.receives.Add(nameof(eTelemetryHealthAllOK));
            this.receives.Add(nameof(PHalt));
            this.creates.Add(nameof(I_FailureInjector));
            this.creates.Add(nameof(I_FlightController));
        }
        
        public void Anon_81(Event currentMachine_dequeuedEvent)
        {
            FailureDrone currentMachine = this;
            PMachineValue TMP_tmp0_73 = null;
            PMachineValue TMP_tmp1_45 = null;
            PMachineValue TMP_tmp2_40 = null;
            PMachineValue TMP_tmp3_30 = null;
            PMachineValue TMP_tmp4_11 = null;
            PEvent TMP_tmp5_10 = null;
            TMP_tmp0_73 = (PMachineValue)(currentMachine.self);
            TMP_tmp1_45 = (PMachineValue)(currentMachine.CreateInterface<I_FlightController>( currentMachine, TMP_tmp0_73));
            fc_5 = TMP_tmp1_45;
            TMP_tmp2_40 = (PMachineValue)(((PMachineValue)((IPrtValue)fc_5)?.Clone()));
            TMP_tmp3_30 = (PMachineValue)(currentMachine.CreateInterface<I_FailureInjector>( currentMachine, TMP_tmp2_40));
            fi = TMP_tmp3_30;
            TMP_tmp4_11 = (PMachineValue)(((PMachineValue)((IPrtValue)fi)?.Clone()));
            TMP_tmp5_10 = (PEvent)(new eLinkInitialized(null));
            currentMachine.TrySendEvent(TMP_tmp4_11, (Event)TMP_tmp5_10);
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_81))]
        class Init : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class FailureDroneGPT : PMachine
    {
        private PMachineValue fc_6 = null;
        private PMachineValue fi_1 = null;
        public class ConstructorEvent : PEvent{public ConstructorEvent(IPrtValue val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((IPrtValue)value); }
        public FailureDroneGPT() {
            this.sends.Add(nameof(eArm));
            this.sends.Add(nameof(eBatteryRemaining));
            this.sends.Add(nameof(eDisarmed));
            this.sends.Add(nameof(eError));
            this.sends.Add(nameof(eHold));
            this.sends.Add(nameof(eInAir));
            this.sends.Add(nameof(eInAirStatus));
            this.sends.Add(nameof(eLanding));
            this.sends.Add(nameof(eLinkInitialized));
            this.sends.Add(nameof(eMavSDKReq));
            this.sends.Add(nameof(eMavSDKResp));
            this.sends.Add(nameof(eMissionCleared));
            this.sends.Add(nameof(eMissionStarted));
            this.sends.Add(nameof(eMissionUploaded));
            this.sends.Add(nameof(eRaiseError));
            this.sends.Add(nameof(eReqArm));
            this.sends.Add(nameof(eReqAtTakeoffAlt));
            this.sends.Add(nameof(eReqBatteryRemaining));
            this.sends.Add(nameof(eReqClearMission));
            this.sends.Add(nameof(eReqDisarm));
            this.sends.Add(nameof(eReqHold));
            this.sends.Add(nameof(eReqInAirStatus));
            this.sends.Add(nameof(eReqLand));
            this.sends.Add(nameof(eReqLandingState));
            this.sends.Add(nameof(eReqMissionFinished));
            this.sends.Add(nameof(eReqMissionStart));
            this.sends.Add(nameof(eReqMissionUpload));
            this.sends.Add(nameof(eReqReturnToLaunch));
            this.sends.Add(nameof(eReqSystemStatus));
            this.sends.Add(nameof(eReqTakeoff));
            this.sends.Add(nameof(eReqTelemetryHealth));
            this.sends.Add(nameof(eReqWaitForDisarmed));
            this.sends.Add(nameof(eRespArm));
            this.sends.Add(nameof(eRespAtTakeoffAlt));
            this.sends.Add(nameof(eRespBatteryRemaining));
            this.sends.Add(nameof(eRespClearMission));
            this.sends.Add(nameof(eRespDisarm));
            this.sends.Add(nameof(eRespHold));
            this.sends.Add(nameof(eRespInAirStatus));
            this.sends.Add(nameof(eRespLand));
            this.sends.Add(nameof(eRespLandingState));
            this.sends.Add(nameof(eRespMissionFinished));
            this.sends.Add(nameof(eRespMissionStart));
            this.sends.Add(nameof(eRespMissionUpload));
            this.sends.Add(nameof(eRespReturnToLaunch));
            this.sends.Add(nameof(eRespSystemStatus));
            this.sends.Add(nameof(eRespTakeoff));
            this.sends.Add(nameof(eRespTelemetryHealth));
            this.sends.Add(nameof(eRespWaitForDisarmed));
            this.sends.Add(nameof(eReturnToLaunch));
            this.sends.Add(nameof(eShutdownSystem));
            this.sends.Add(nameof(eSpec_PreFlight));
            this.sends.Add(nameof(eSystemConnected));
            this.sends.Add(nameof(eTakeoff));
            this.sends.Add(nameof(eTakeoffReached));
            this.sends.Add(nameof(eTelemetryHealthAllOK));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eArm));
            this.receives.Add(nameof(eBatteryRemaining));
            this.receives.Add(nameof(eDisarmed));
            this.receives.Add(nameof(eError));
            this.receives.Add(nameof(eHold));
            this.receives.Add(nameof(eInAir));
            this.receives.Add(nameof(eInAirStatus));
            this.receives.Add(nameof(eLanding));
            this.receives.Add(nameof(eLinkInitialized));
            this.receives.Add(nameof(eMavSDKReq));
            this.receives.Add(nameof(eMavSDKResp));
            this.receives.Add(nameof(eMissionCleared));
            this.receives.Add(nameof(eMissionStarted));
            this.receives.Add(nameof(eMissionUploaded));
            this.receives.Add(nameof(eRaiseError));
            this.receives.Add(nameof(eReqArm));
            this.receives.Add(nameof(eReqAtTakeoffAlt));
            this.receives.Add(nameof(eReqBatteryRemaining));
            this.receives.Add(nameof(eReqClearMission));
            this.receives.Add(nameof(eReqDisarm));
            this.receives.Add(nameof(eReqHold));
            this.receives.Add(nameof(eReqInAirStatus));
            this.receives.Add(nameof(eReqLand));
            this.receives.Add(nameof(eReqLandingState));
            this.receives.Add(nameof(eReqMissionFinished));
            this.receives.Add(nameof(eReqMissionStart));
            this.receives.Add(nameof(eReqMissionUpload));
            this.receives.Add(nameof(eReqReturnToLaunch));
            this.receives.Add(nameof(eReqSystemStatus));
            this.receives.Add(nameof(eReqTakeoff));
            this.receives.Add(nameof(eReqTelemetryHealth));
            this.receives.Add(nameof(eReqWaitForDisarmed));
            this.receives.Add(nameof(eRespArm));
            this.receives.Add(nameof(eRespAtTakeoffAlt));
            this.receives.Add(nameof(eRespBatteryRemaining));
            this.receives.Add(nameof(eRespClearMission));
            this.receives.Add(nameof(eRespDisarm));
            this.receives.Add(nameof(eRespHold));
            this.receives.Add(nameof(eRespInAirStatus));
            this.receives.Add(nameof(eRespLand));
            this.receives.Add(nameof(eRespLandingState));
            this.receives.Add(nameof(eRespMissionFinished));
            this.receives.Add(nameof(eRespMissionStart));
            this.receives.Add(nameof(eRespMissionUpload));
            this.receives.Add(nameof(eRespReturnToLaunch));
            this.receives.Add(nameof(eRespSystemStatus));
            this.receives.Add(nameof(eRespTakeoff));
            this.receives.Add(nameof(eRespTelemetryHealth));
            this.receives.Add(nameof(eRespWaitForDisarmed));
            this.receives.Add(nameof(eReturnToLaunch));
            this.receives.Add(nameof(eShutdownSystem));
            this.receives.Add(nameof(eSpec_PreFlight));
            this.receives.Add(nameof(eSystemConnected));
            this.receives.Add(nameof(eTakeoff));
            this.receives.Add(nameof(eTakeoffReached));
            this.receives.Add(nameof(eTelemetryHealthAllOK));
            this.receives.Add(nameof(PHalt));
            this.creates.Add(nameof(I_FailureInjectorGPT));
            this.creates.Add(nameof(I_FlightController));
        }
        
        public void Anon_82(Event currentMachine_dequeuedEvent)
        {
            FailureDroneGPT currentMachine = this;
            PMachineValue TMP_tmp0_74 = null;
            PMachineValue TMP_tmp1_46 = null;
            PMachineValue TMP_tmp2_41 = null;
            PMachineValue TMP_tmp3_31 = null;
            PMachineValue TMP_tmp4_12 = null;
            PEvent TMP_tmp5_11 = null;
            TMP_tmp0_74 = (PMachineValue)(currentMachine.self);
            TMP_tmp1_46 = (PMachineValue)(currentMachine.CreateInterface<I_FlightController>( currentMachine, TMP_tmp0_74));
            fc_6 = TMP_tmp1_46;
            TMP_tmp2_41 = (PMachineValue)(((PMachineValue)((IPrtValue)fc_6)?.Clone()));
            TMP_tmp3_31 = (PMachineValue)(currentMachine.CreateInterface<I_FailureInjectorGPT>( currentMachine, TMP_tmp2_41));
            fi_1 = TMP_tmp3_31;
            TMP_tmp4_12 = (PMachineValue)(((PMachineValue)((IPrtValue)fi_1)?.Clone()));
            TMP_tmp5_11 = (PEvent)(new eLinkInitialized(null));
            currentMachine.TrySendEvent(TMP_tmp4_12, (Event)TMP_tmp5_11);
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_82))]
        class Init : State
        {
        }
    }
}
namespace PImplementation
{
    public class CheckDroneState {
        public static void InitializeLinkMap() {
            PModule.linkMap.Clear();
            PModule.linkMap[nameof(I_Drone)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_Drone)].Add(nameof(I_FlightController), nameof(I_FlightController));
            PModule.linkMap[nameof(I_FlightController)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_FlightController)].Add(nameof(I_MavSDK), nameof(I_MavSDK));
            PModule.linkMap[nameof(I_MavSDK)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_MavSDK)].Add(nameof(I_BatteryMonitor), nameof(I_BatteryMonitor));
            PModule.linkMap[nameof(I_MavSDK)].Add(nameof(I_MissionMonitor), nameof(I_MissionMonitor));
            PModule.linkMap[nameof(I_MavSDK)].Add(nameof(I_SystemMonitor), nameof(I_SystemMonitor));
            PModule.linkMap[nameof(I_MavSDK)].Add(nameof(I_TelemetryMonitor), nameof(I_TelemetryMonitor));
            PModule.linkMap[nameof(I_BatteryMonitor)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_TelemetryMonitor)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_MissionMonitor)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_SystemMonitor)] = new Dictionary<string, string>();
        }
        
        public static void InitializeInterfaceDefMap() {
            PModule.interfaceDefinitionMap.Clear();
            PModule.interfaceDefinitionMap.Add(nameof(I_Drone), typeof(Drone));
            PModule.interfaceDefinitionMap.Add(nameof(I_FlightController), typeof(FlightController));
            PModule.interfaceDefinitionMap.Add(nameof(I_MavSDK), typeof(MavSDK));
            PModule.interfaceDefinitionMap.Add(nameof(I_BatteryMonitor), typeof(BatteryMonitor));
            PModule.interfaceDefinitionMap.Add(nameof(I_TelemetryMonitor), typeof(TelemetryMonitor));
            PModule.interfaceDefinitionMap.Add(nameof(I_MissionMonitor), typeof(MissionMonitor));
            PModule.interfaceDefinitionMap.Add(nameof(I_SystemMonitor), typeof(SystemMonitor));
        }
        
        public static void InitializeMonitorObserves() {
            PModule.monitorObserves.Clear();
            PModule.monitorObserves[nameof(DroneModesOfOperation)] = new List<string>();
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eArm));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eDisarmed));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eError));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eHold));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eInAir));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eLanding));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eReturnToLaunch));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eShutdownSystem));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eSpec_PreFlight));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eTakeoff));
            PModule.monitorObserves[nameof(LivenessMonitor)] = new List<string>();
            PModule.monitorObserves[nameof(LivenessMonitor)].Add(nameof(eMavSDKReq));
            PModule.monitorObserves[nameof(LivenessMonitor)].Add(nameof(eMavSDKResp));
        }
        
        public static void InitializeMonitorMap(IActorRuntime runtime) {
            PModule.monitorMap.Clear();
            PModule.monitorMap[nameof(I_Drone)] = new List<Type>();
            PModule.monitorMap[nameof(I_Drone)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_Drone)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_FlightController)] = new List<Type>();
            PModule.monitorMap[nameof(I_FlightController)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_FlightController)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_MavSDK)] = new List<Type>();
            PModule.monitorMap[nameof(I_MavSDK)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_MavSDK)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_BatteryMonitor)] = new List<Type>();
            PModule.monitorMap[nameof(I_BatteryMonitor)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_BatteryMonitor)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_TelemetryMonitor)] = new List<Type>();
            PModule.monitorMap[nameof(I_TelemetryMonitor)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_TelemetryMonitor)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_MissionMonitor)] = new List<Type>();
            PModule.monitorMap[nameof(I_MissionMonitor)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_MissionMonitor)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_SystemMonitor)] = new List<Type>();
            PModule.monitorMap[nameof(I_SystemMonitor)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_SystemMonitor)].Add(typeof(LivenessMonitor));
            runtime.RegisterMonitor<DroneModesOfOperation>();
            runtime.RegisterMonitor<LivenessMonitor>();
        }
        
        
        [PChecker.SystematicTesting.Test]
        public static void Execute(IActorRuntime runtime) {
            runtime.RegisterLog(new PLogFormatter());
            runtime.RegisterLog(new PJsonFormatter());
            PModule.runtime = runtime;
            PHelper.InitializeInterfaces();
            PHelper.InitializeEnums();
            InitializeLinkMap();
            InitializeInterfaceDefMap();
            InitializeMonitorMap(runtime);
            InitializeMonitorObserves();
            runtime.CreateActor(typeof(_GodMachine), new _GodMachine.Config(typeof(Drone)));
        }
    }
}
namespace PImplementation
{
    public class FailDroneState {
        public static void InitializeLinkMap() {
            PModule.linkMap.Clear();
            PModule.linkMap[nameof(I_FailureDrone)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_FailureDrone)].Add(nameof(I_FailureInjector), nameof(I_FailureInjector));
            PModule.linkMap[nameof(I_FailureDrone)].Add(nameof(I_FlightController), nameof(I_FlightController));
            PModule.linkMap[nameof(I_FlightController)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_FlightController)].Add(nameof(I_MavSDK), nameof(I_MavSDK));
            PModule.linkMap[nameof(I_MavSDK)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_MavSDK)].Add(nameof(I_BatteryMonitor), nameof(I_BatteryMonitor));
            PModule.linkMap[nameof(I_MavSDK)].Add(nameof(I_MissionMonitor), nameof(I_MissionMonitor));
            PModule.linkMap[nameof(I_MavSDK)].Add(nameof(I_SystemMonitor), nameof(I_SystemMonitor));
            PModule.linkMap[nameof(I_MavSDK)].Add(nameof(I_TelemetryMonitor), nameof(I_TelemetryMonitor));
            PModule.linkMap[nameof(I_BatteryMonitor)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_TelemetryMonitor)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_MissionMonitor)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_SystemMonitor)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_FailureInjector)] = new Dictionary<string, string>();
        }
        
        public static void InitializeInterfaceDefMap() {
            PModule.interfaceDefinitionMap.Clear();
            PModule.interfaceDefinitionMap.Add(nameof(I_FailureDrone), typeof(FailureDrone));
            PModule.interfaceDefinitionMap.Add(nameof(I_FlightController), typeof(FlightController));
            PModule.interfaceDefinitionMap.Add(nameof(I_MavSDK), typeof(MavSDK));
            PModule.interfaceDefinitionMap.Add(nameof(I_BatteryMonitor), typeof(BatteryMonitor));
            PModule.interfaceDefinitionMap.Add(nameof(I_TelemetryMonitor), typeof(TelemetryMonitor));
            PModule.interfaceDefinitionMap.Add(nameof(I_MissionMonitor), typeof(MissionMonitor));
            PModule.interfaceDefinitionMap.Add(nameof(I_SystemMonitor), typeof(SystemMonitor));
            PModule.interfaceDefinitionMap.Add(nameof(I_FailureInjector), typeof(FailureInjector));
        }
        
        public static void InitializeMonitorObserves() {
            PModule.monitorObserves.Clear();
            PModule.monitorObserves[nameof(DroneModesOfOperation)] = new List<string>();
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eArm));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eDisarmed));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eError));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eHold));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eInAir));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eLanding));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eReturnToLaunch));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eShutdownSystem));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eSpec_PreFlight));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eTakeoff));
            PModule.monitorObserves[nameof(LivenessMonitor)] = new List<string>();
            PModule.monitorObserves[nameof(LivenessMonitor)].Add(nameof(eMavSDKReq));
            PModule.monitorObserves[nameof(LivenessMonitor)].Add(nameof(eMavSDKResp));
        }
        
        public static void InitializeMonitorMap(IActorRuntime runtime) {
            PModule.monitorMap.Clear();
            PModule.monitorMap[nameof(I_FailureDrone)] = new List<Type>();
            PModule.monitorMap[nameof(I_FailureDrone)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_FailureDrone)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_FlightController)] = new List<Type>();
            PModule.monitorMap[nameof(I_FlightController)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_FlightController)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_MavSDK)] = new List<Type>();
            PModule.monitorMap[nameof(I_MavSDK)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_MavSDK)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_BatteryMonitor)] = new List<Type>();
            PModule.monitorMap[nameof(I_BatteryMonitor)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_BatteryMonitor)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_TelemetryMonitor)] = new List<Type>();
            PModule.monitorMap[nameof(I_TelemetryMonitor)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_TelemetryMonitor)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_MissionMonitor)] = new List<Type>();
            PModule.monitorMap[nameof(I_MissionMonitor)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_MissionMonitor)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_SystemMonitor)] = new List<Type>();
            PModule.monitorMap[nameof(I_SystemMonitor)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_SystemMonitor)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_FailureInjector)] = new List<Type>();
            PModule.monitorMap[nameof(I_FailureInjector)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_FailureInjector)].Add(typeof(LivenessMonitor));
            runtime.RegisterMonitor<DroneModesOfOperation>();
            runtime.RegisterMonitor<LivenessMonitor>();
        }
        
        
        [PChecker.SystematicTesting.Test]
        public static void Execute(IActorRuntime runtime) {
            runtime.RegisterLog(new PLogFormatter());
            runtime.RegisterLog(new PJsonFormatter());
            PModule.runtime = runtime;
            PHelper.InitializeInterfaces();
            PHelper.InitializeEnums();
            InitializeLinkMap();
            InitializeInterfaceDefMap();
            InitializeMonitorMap(runtime);
            InitializeMonitorObserves();
            runtime.CreateActor(typeof(_GodMachine), new _GodMachine.Config(typeof(FailureDrone)));
        }
    }
}
namespace PImplementation
{
    public class FailDroneStateGPT {
        public static void InitializeLinkMap() {
            PModule.linkMap.Clear();
            PModule.linkMap[nameof(I_FailureDroneGPT)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_FailureDroneGPT)].Add(nameof(I_FailureInjectorGPT), nameof(I_FailureInjectorGPT));
            PModule.linkMap[nameof(I_FailureDroneGPT)].Add(nameof(I_FlightController), nameof(I_FlightController));
            PModule.linkMap[nameof(I_FlightController)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_FlightController)].Add(nameof(I_MavSDK), nameof(I_MavSDK));
            PModule.linkMap[nameof(I_MavSDK)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_MavSDK)].Add(nameof(I_BatteryMonitor), nameof(I_BatteryMonitor));
            PModule.linkMap[nameof(I_MavSDK)].Add(nameof(I_MissionMonitor), nameof(I_MissionMonitor));
            PModule.linkMap[nameof(I_MavSDK)].Add(nameof(I_SystemMonitor), nameof(I_SystemMonitor));
            PModule.linkMap[nameof(I_MavSDK)].Add(nameof(I_TelemetryMonitor), nameof(I_TelemetryMonitor));
            PModule.linkMap[nameof(I_BatteryMonitor)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_TelemetryMonitor)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_MissionMonitor)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_SystemMonitor)] = new Dictionary<string, string>();
            PModule.linkMap[nameof(I_FailureInjectorGPT)] = new Dictionary<string, string>();
        }
        
        public static void InitializeInterfaceDefMap() {
            PModule.interfaceDefinitionMap.Clear();
            PModule.interfaceDefinitionMap.Add(nameof(I_FailureDroneGPT), typeof(FailureDroneGPT));
            PModule.interfaceDefinitionMap.Add(nameof(I_FlightController), typeof(FlightController));
            PModule.interfaceDefinitionMap.Add(nameof(I_MavSDK), typeof(MavSDK));
            PModule.interfaceDefinitionMap.Add(nameof(I_BatteryMonitor), typeof(BatteryMonitor));
            PModule.interfaceDefinitionMap.Add(nameof(I_TelemetryMonitor), typeof(TelemetryMonitor));
            PModule.interfaceDefinitionMap.Add(nameof(I_MissionMonitor), typeof(MissionMonitor));
            PModule.interfaceDefinitionMap.Add(nameof(I_SystemMonitor), typeof(SystemMonitor));
            PModule.interfaceDefinitionMap.Add(nameof(I_FailureInjectorGPT), typeof(FailureInjectorGPT));
        }
        
        public static void InitializeMonitorObserves() {
            PModule.monitorObserves.Clear();
            PModule.monitorObserves[nameof(DroneModesOfOperation)] = new List<string>();
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eArm));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eDisarmed));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eError));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eHold));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eInAir));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eLanding));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eReturnToLaunch));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eShutdownSystem));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eSpec_PreFlight));
            PModule.monitorObserves[nameof(DroneModesOfOperation)].Add(nameof(eTakeoff));
            PModule.monitorObserves[nameof(LivenessMonitor)] = new List<string>();
            PModule.monitorObserves[nameof(LivenessMonitor)].Add(nameof(eMavSDKReq));
            PModule.monitorObserves[nameof(LivenessMonitor)].Add(nameof(eMavSDKResp));
        }
        
        public static void InitializeMonitorMap(IActorRuntime runtime) {
            PModule.monitorMap.Clear();
            PModule.monitorMap[nameof(I_FailureDroneGPT)] = new List<Type>();
            PModule.monitorMap[nameof(I_FailureDroneGPT)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_FailureDroneGPT)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_FlightController)] = new List<Type>();
            PModule.monitorMap[nameof(I_FlightController)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_FlightController)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_MavSDK)] = new List<Type>();
            PModule.monitorMap[nameof(I_MavSDK)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_MavSDK)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_BatteryMonitor)] = new List<Type>();
            PModule.monitorMap[nameof(I_BatteryMonitor)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_BatteryMonitor)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_TelemetryMonitor)] = new List<Type>();
            PModule.monitorMap[nameof(I_TelemetryMonitor)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_TelemetryMonitor)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_MissionMonitor)] = new List<Type>();
            PModule.monitorMap[nameof(I_MissionMonitor)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_MissionMonitor)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_SystemMonitor)] = new List<Type>();
            PModule.monitorMap[nameof(I_SystemMonitor)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_SystemMonitor)].Add(typeof(LivenessMonitor));
            PModule.monitorMap[nameof(I_FailureInjectorGPT)] = new List<Type>();
            PModule.monitorMap[nameof(I_FailureInjectorGPT)].Add(typeof(DroneModesOfOperation));
            PModule.monitorMap[nameof(I_FailureInjectorGPT)].Add(typeof(LivenessMonitor));
            runtime.RegisterMonitor<DroneModesOfOperation>();
            runtime.RegisterMonitor<LivenessMonitor>();
        }
        
        
        [PChecker.SystematicTesting.Test]
        public static void Execute(IActorRuntime runtime) {
            runtime.RegisterLog(new PLogFormatter());
            runtime.RegisterLog(new PJsonFormatter());
            PModule.runtime = runtime;
            PHelper.InitializeInterfaces();
            PHelper.InitializeEnums();
            InitializeLinkMap();
            InitializeInterfaceDefMap();
            InitializeMonitorMap(runtime);
            InitializeMonitorObserves();
            runtime.CreateActor(typeof(_GodMachine), new _GodMachine.Config(typeof(FailureDroneGPT)));
        }
    }
}
// TODO: NamedModule FlightController_1
// TODO: NamedModule Communication
// TODO: NamedModule FailureInjector_1
// TODO: NamedModule FailureInjectorGPT_1
namespace PImplementation
{
    public class I_FailureInjectorGPT : PMachineValue {
        public I_FailureInjectorGPT (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public class I_FlightController : PMachineValue {
        public I_FlightController (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public class I_MavSDK : PMachineValue {
        public I_MavSDK (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public class I_FailureInjector : PMachineValue {
        public I_FailureInjector (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public class I_BatteryMonitor : PMachineValue {
        public I_BatteryMonitor (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public class I_SystemMonitor : PMachineValue {
        public I_SystemMonitor (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public class I_MissionMonitor : PMachineValue {
        public I_MissionMonitor (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public class I_TelemetryMonitor : PMachineValue {
        public I_TelemetryMonitor (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public class I_Drone : PMachineValue {
        public I_Drone (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public class I_FailureDrone : PMachineValue {
        public I_FailureDrone (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public class I_FailureDroneGPT : PMachineValue {
        public I_FailureDroneGPT (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public partial class PHelper {
        public static void InitializeInterfaces() {
            PInterfaces.Clear();
            PInterfaces.AddInterface(nameof(I_FailureInjectorGPT), nameof(eArm), nameof(eBatteryRemaining), nameof(eDisarmed), nameof(eError), nameof(eHold), nameof(eInAir), nameof(eInAirStatus), nameof(eLanding), nameof(eLinkInitialized), nameof(eMavSDKReq), nameof(eMavSDKResp), nameof(eMissionCleared), nameof(eMissionStarted), nameof(eMissionUploaded), nameof(eRaiseError), nameof(eReqArm), nameof(eReqAtTakeoffAlt), nameof(eReqBatteryRemaining), nameof(eReqClearMission), nameof(eReqDisarm), nameof(eReqHold), nameof(eReqInAirStatus), nameof(eReqLand), nameof(eReqLandingState), nameof(eReqMissionFinished), nameof(eReqMissionStart), nameof(eReqMissionUpload), nameof(eReqReturnToLaunch), nameof(eReqSystemStatus), nameof(eReqTakeoff), nameof(eReqTelemetryHealth), nameof(eReqWaitForDisarmed), nameof(eRespArm), nameof(eRespAtTakeoffAlt), nameof(eRespBatteryRemaining), nameof(eRespClearMission), nameof(eRespDisarm), nameof(eRespHold), nameof(eRespInAirStatus), nameof(eRespLand), nameof(eRespLandingState), nameof(eRespMissionFinished), nameof(eRespMissionStart), nameof(eRespMissionUpload), nameof(eRespReturnToLaunch), nameof(eRespSystemStatus), nameof(eRespTakeoff), nameof(eRespTelemetryHealth), nameof(eRespWaitForDisarmed), nameof(eReturnToLaunch), nameof(eShutdownSystem), nameof(eSpec_PreFlight), nameof(eSystemConnected), nameof(eTakeoff), nameof(eTakeoffReached), nameof(eTelemetryHealthAllOK), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_FlightController), nameof(eArm), nameof(eBatteryRemaining), nameof(eDisarmed), nameof(eError), nameof(eHold), nameof(eInAir), nameof(eInAirStatus), nameof(eLanding), nameof(eLinkInitialized), nameof(eMavSDKReq), nameof(eMavSDKResp), nameof(eMissionCleared), nameof(eMissionStarted), nameof(eMissionUploaded), nameof(eRaiseError), nameof(eReqArm), nameof(eReqAtTakeoffAlt), nameof(eReqBatteryRemaining), nameof(eReqClearMission), nameof(eReqDisarm), nameof(eReqHold), nameof(eReqInAirStatus), nameof(eReqLand), nameof(eReqLandingState), nameof(eReqMissionFinished), nameof(eReqMissionStart), nameof(eReqMissionUpload), nameof(eReqReturnToLaunch), nameof(eReqSystemStatus), nameof(eReqTakeoff), nameof(eReqTelemetryHealth), nameof(eReqWaitForDisarmed), nameof(eRespArm), nameof(eRespAtTakeoffAlt), nameof(eRespBatteryRemaining), nameof(eRespClearMission), nameof(eRespDisarm), nameof(eRespHold), nameof(eRespInAirStatus), nameof(eRespLand), nameof(eRespLandingState), nameof(eRespMissionFinished), nameof(eRespMissionStart), nameof(eRespMissionUpload), nameof(eRespReturnToLaunch), nameof(eRespSystemStatus), nameof(eRespTakeoff), nameof(eRespTelemetryHealth), nameof(eRespWaitForDisarmed), nameof(eReturnToLaunch), nameof(eShutdownSystem), nameof(eSpec_PreFlight), nameof(eSystemConnected), nameof(eTakeoff), nameof(eTakeoffReached), nameof(eTelemetryHealthAllOK), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_MavSDK), nameof(eArm), nameof(eBatteryRemaining), nameof(eDisarmed), nameof(eError), nameof(eHold), nameof(eInAir), nameof(eInAirStatus), nameof(eLanding), nameof(eLinkInitialized), nameof(eMavSDKReq), nameof(eMavSDKResp), nameof(eMissionCleared), nameof(eMissionStarted), nameof(eMissionUploaded), nameof(eRaiseError), nameof(eReqArm), nameof(eReqAtTakeoffAlt), nameof(eReqBatteryRemaining), nameof(eReqClearMission), nameof(eReqDisarm), nameof(eReqHold), nameof(eReqInAirStatus), nameof(eReqLand), nameof(eReqLandingState), nameof(eReqMissionFinished), nameof(eReqMissionStart), nameof(eReqMissionUpload), nameof(eReqReturnToLaunch), nameof(eReqSystemStatus), nameof(eReqTakeoff), nameof(eReqTelemetryHealth), nameof(eReqWaitForDisarmed), nameof(eRespArm), nameof(eRespAtTakeoffAlt), nameof(eRespBatteryRemaining), nameof(eRespClearMission), nameof(eRespDisarm), nameof(eRespHold), nameof(eRespInAirStatus), nameof(eRespLand), nameof(eRespLandingState), nameof(eRespMissionFinished), nameof(eRespMissionStart), nameof(eRespMissionUpload), nameof(eRespReturnToLaunch), nameof(eRespSystemStatus), nameof(eRespTakeoff), nameof(eRespTelemetryHealth), nameof(eRespWaitForDisarmed), nameof(eReturnToLaunch), nameof(eShutdownSystem), nameof(eSpec_PreFlight), nameof(eSystemConnected), nameof(eTakeoff), nameof(eTakeoffReached), nameof(eTelemetryHealthAllOK), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_FailureInjector), nameof(eArm), nameof(eBatteryRemaining), nameof(eDisarmed), nameof(eError), nameof(eHold), nameof(eInAir), nameof(eInAirStatus), nameof(eLanding), nameof(eLinkInitialized), nameof(eMavSDKReq), nameof(eMavSDKResp), nameof(eMissionCleared), nameof(eMissionStarted), nameof(eMissionUploaded), nameof(eRaiseError), nameof(eReqArm), nameof(eReqAtTakeoffAlt), nameof(eReqBatteryRemaining), nameof(eReqClearMission), nameof(eReqDisarm), nameof(eReqHold), nameof(eReqInAirStatus), nameof(eReqLand), nameof(eReqLandingState), nameof(eReqMissionFinished), nameof(eReqMissionStart), nameof(eReqMissionUpload), nameof(eReqReturnToLaunch), nameof(eReqSystemStatus), nameof(eReqTakeoff), nameof(eReqTelemetryHealth), nameof(eReqWaitForDisarmed), nameof(eRespArm), nameof(eRespAtTakeoffAlt), nameof(eRespBatteryRemaining), nameof(eRespClearMission), nameof(eRespDisarm), nameof(eRespHold), nameof(eRespInAirStatus), nameof(eRespLand), nameof(eRespLandingState), nameof(eRespMissionFinished), nameof(eRespMissionStart), nameof(eRespMissionUpload), nameof(eRespReturnToLaunch), nameof(eRespSystemStatus), nameof(eRespTakeoff), nameof(eRespTelemetryHealth), nameof(eRespWaitForDisarmed), nameof(eReturnToLaunch), nameof(eShutdownSystem), nameof(eSpec_PreFlight), nameof(eSystemConnected), nameof(eTakeoff), nameof(eTakeoffReached), nameof(eTelemetryHealthAllOK), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_BatteryMonitor), nameof(eArm), nameof(eBatteryRemaining), nameof(eDisarmed), nameof(eError), nameof(eHold), nameof(eInAir), nameof(eInAirStatus), nameof(eLanding), nameof(eLinkInitialized), nameof(eMavSDKReq), nameof(eMavSDKResp), nameof(eMissionCleared), nameof(eMissionStarted), nameof(eMissionUploaded), nameof(eRaiseError), nameof(eReqArm), nameof(eReqAtTakeoffAlt), nameof(eReqBatteryRemaining), nameof(eReqClearMission), nameof(eReqDisarm), nameof(eReqHold), nameof(eReqInAirStatus), nameof(eReqLand), nameof(eReqLandingState), nameof(eReqMissionFinished), nameof(eReqMissionStart), nameof(eReqMissionUpload), nameof(eReqReturnToLaunch), nameof(eReqSystemStatus), nameof(eReqTakeoff), nameof(eReqTelemetryHealth), nameof(eReqWaitForDisarmed), nameof(eRespArm), nameof(eRespAtTakeoffAlt), nameof(eRespBatteryRemaining), nameof(eRespClearMission), nameof(eRespDisarm), nameof(eRespHold), nameof(eRespInAirStatus), nameof(eRespLand), nameof(eRespLandingState), nameof(eRespMissionFinished), nameof(eRespMissionStart), nameof(eRespMissionUpload), nameof(eRespReturnToLaunch), nameof(eRespSystemStatus), nameof(eRespTakeoff), nameof(eRespTelemetryHealth), nameof(eRespWaitForDisarmed), nameof(eReturnToLaunch), nameof(eShutdownSystem), nameof(eSpec_PreFlight), nameof(eSystemConnected), nameof(eTakeoff), nameof(eTakeoffReached), nameof(eTelemetryHealthAllOK), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_SystemMonitor), nameof(eArm), nameof(eBatteryRemaining), nameof(eDisarmed), nameof(eError), nameof(eHold), nameof(eInAir), nameof(eInAirStatus), nameof(eLanding), nameof(eLinkInitialized), nameof(eMavSDKReq), nameof(eMavSDKResp), nameof(eMissionCleared), nameof(eMissionStarted), nameof(eMissionUploaded), nameof(eRaiseError), nameof(eReqArm), nameof(eReqAtTakeoffAlt), nameof(eReqBatteryRemaining), nameof(eReqClearMission), nameof(eReqDisarm), nameof(eReqHold), nameof(eReqInAirStatus), nameof(eReqLand), nameof(eReqLandingState), nameof(eReqMissionFinished), nameof(eReqMissionStart), nameof(eReqMissionUpload), nameof(eReqReturnToLaunch), nameof(eReqSystemStatus), nameof(eReqTakeoff), nameof(eReqTelemetryHealth), nameof(eReqWaitForDisarmed), nameof(eRespArm), nameof(eRespAtTakeoffAlt), nameof(eRespBatteryRemaining), nameof(eRespClearMission), nameof(eRespDisarm), nameof(eRespHold), nameof(eRespInAirStatus), nameof(eRespLand), nameof(eRespLandingState), nameof(eRespMissionFinished), nameof(eRespMissionStart), nameof(eRespMissionUpload), nameof(eRespReturnToLaunch), nameof(eRespSystemStatus), nameof(eRespTakeoff), nameof(eRespTelemetryHealth), nameof(eRespWaitForDisarmed), nameof(eReturnToLaunch), nameof(eShutdownSystem), nameof(eSpec_PreFlight), nameof(eSystemConnected), nameof(eTakeoff), nameof(eTakeoffReached), nameof(eTelemetryHealthAllOK), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_MissionMonitor), nameof(eArm), nameof(eBatteryRemaining), nameof(eDisarmed), nameof(eError), nameof(eHold), nameof(eInAir), nameof(eInAirStatus), nameof(eLanding), nameof(eLinkInitialized), nameof(eMavSDKReq), nameof(eMavSDKResp), nameof(eMissionCleared), nameof(eMissionStarted), nameof(eMissionUploaded), nameof(eRaiseError), nameof(eReqArm), nameof(eReqAtTakeoffAlt), nameof(eReqBatteryRemaining), nameof(eReqClearMission), nameof(eReqDisarm), nameof(eReqHold), nameof(eReqInAirStatus), nameof(eReqLand), nameof(eReqLandingState), nameof(eReqMissionFinished), nameof(eReqMissionStart), nameof(eReqMissionUpload), nameof(eReqReturnToLaunch), nameof(eReqSystemStatus), nameof(eReqTakeoff), nameof(eReqTelemetryHealth), nameof(eReqWaitForDisarmed), nameof(eRespArm), nameof(eRespAtTakeoffAlt), nameof(eRespBatteryRemaining), nameof(eRespClearMission), nameof(eRespDisarm), nameof(eRespHold), nameof(eRespInAirStatus), nameof(eRespLand), nameof(eRespLandingState), nameof(eRespMissionFinished), nameof(eRespMissionStart), nameof(eRespMissionUpload), nameof(eRespReturnToLaunch), nameof(eRespSystemStatus), nameof(eRespTakeoff), nameof(eRespTelemetryHealth), nameof(eRespWaitForDisarmed), nameof(eReturnToLaunch), nameof(eShutdownSystem), nameof(eSpec_PreFlight), nameof(eSystemConnected), nameof(eTakeoff), nameof(eTakeoffReached), nameof(eTelemetryHealthAllOK), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_TelemetryMonitor), nameof(eArm), nameof(eBatteryRemaining), nameof(eDisarmed), nameof(eError), nameof(eHold), nameof(eInAir), nameof(eInAirStatus), nameof(eLanding), nameof(eLinkInitialized), nameof(eMavSDKReq), nameof(eMavSDKResp), nameof(eMissionCleared), nameof(eMissionStarted), nameof(eMissionUploaded), nameof(eRaiseError), nameof(eReqArm), nameof(eReqAtTakeoffAlt), nameof(eReqBatteryRemaining), nameof(eReqClearMission), nameof(eReqDisarm), nameof(eReqHold), nameof(eReqInAirStatus), nameof(eReqLand), nameof(eReqLandingState), nameof(eReqMissionFinished), nameof(eReqMissionStart), nameof(eReqMissionUpload), nameof(eReqReturnToLaunch), nameof(eReqSystemStatus), nameof(eReqTakeoff), nameof(eReqTelemetryHealth), nameof(eReqWaitForDisarmed), nameof(eRespArm), nameof(eRespAtTakeoffAlt), nameof(eRespBatteryRemaining), nameof(eRespClearMission), nameof(eRespDisarm), nameof(eRespHold), nameof(eRespInAirStatus), nameof(eRespLand), nameof(eRespLandingState), nameof(eRespMissionFinished), nameof(eRespMissionStart), nameof(eRespMissionUpload), nameof(eRespReturnToLaunch), nameof(eRespSystemStatus), nameof(eRespTakeoff), nameof(eRespTelemetryHealth), nameof(eRespWaitForDisarmed), nameof(eReturnToLaunch), nameof(eShutdownSystem), nameof(eSpec_PreFlight), nameof(eSystemConnected), nameof(eTakeoff), nameof(eTakeoffReached), nameof(eTelemetryHealthAllOK), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_Drone), nameof(eArm), nameof(eBatteryRemaining), nameof(eDisarmed), nameof(eError), nameof(eHold), nameof(eInAir), nameof(eInAirStatus), nameof(eLanding), nameof(eLinkInitialized), nameof(eMavSDKReq), nameof(eMavSDKResp), nameof(eMissionCleared), nameof(eMissionStarted), nameof(eMissionUploaded), nameof(eRaiseError), nameof(eReqArm), nameof(eReqAtTakeoffAlt), nameof(eReqBatteryRemaining), nameof(eReqClearMission), nameof(eReqDisarm), nameof(eReqHold), nameof(eReqInAirStatus), nameof(eReqLand), nameof(eReqLandingState), nameof(eReqMissionFinished), nameof(eReqMissionStart), nameof(eReqMissionUpload), nameof(eReqReturnToLaunch), nameof(eReqSystemStatus), nameof(eReqTakeoff), nameof(eReqTelemetryHealth), nameof(eReqWaitForDisarmed), nameof(eRespArm), nameof(eRespAtTakeoffAlt), nameof(eRespBatteryRemaining), nameof(eRespClearMission), nameof(eRespDisarm), nameof(eRespHold), nameof(eRespInAirStatus), nameof(eRespLand), nameof(eRespLandingState), nameof(eRespMissionFinished), nameof(eRespMissionStart), nameof(eRespMissionUpload), nameof(eRespReturnToLaunch), nameof(eRespSystemStatus), nameof(eRespTakeoff), nameof(eRespTelemetryHealth), nameof(eRespWaitForDisarmed), nameof(eReturnToLaunch), nameof(eShutdownSystem), nameof(eSpec_PreFlight), nameof(eSystemConnected), nameof(eTakeoff), nameof(eTakeoffReached), nameof(eTelemetryHealthAllOK), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_FailureDrone), nameof(eArm), nameof(eBatteryRemaining), nameof(eDisarmed), nameof(eError), nameof(eHold), nameof(eInAir), nameof(eInAirStatus), nameof(eLanding), nameof(eLinkInitialized), nameof(eMavSDKReq), nameof(eMavSDKResp), nameof(eMissionCleared), nameof(eMissionStarted), nameof(eMissionUploaded), nameof(eRaiseError), nameof(eReqArm), nameof(eReqAtTakeoffAlt), nameof(eReqBatteryRemaining), nameof(eReqClearMission), nameof(eReqDisarm), nameof(eReqHold), nameof(eReqInAirStatus), nameof(eReqLand), nameof(eReqLandingState), nameof(eReqMissionFinished), nameof(eReqMissionStart), nameof(eReqMissionUpload), nameof(eReqReturnToLaunch), nameof(eReqSystemStatus), nameof(eReqTakeoff), nameof(eReqTelemetryHealth), nameof(eReqWaitForDisarmed), nameof(eRespArm), nameof(eRespAtTakeoffAlt), nameof(eRespBatteryRemaining), nameof(eRespClearMission), nameof(eRespDisarm), nameof(eRespHold), nameof(eRespInAirStatus), nameof(eRespLand), nameof(eRespLandingState), nameof(eRespMissionFinished), nameof(eRespMissionStart), nameof(eRespMissionUpload), nameof(eRespReturnToLaunch), nameof(eRespSystemStatus), nameof(eRespTakeoff), nameof(eRespTelemetryHealth), nameof(eRespWaitForDisarmed), nameof(eReturnToLaunch), nameof(eShutdownSystem), nameof(eSpec_PreFlight), nameof(eSystemConnected), nameof(eTakeoff), nameof(eTakeoffReached), nameof(eTelemetryHealthAllOK), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_FailureDroneGPT), nameof(eArm), nameof(eBatteryRemaining), nameof(eDisarmed), nameof(eError), nameof(eHold), nameof(eInAir), nameof(eInAirStatus), nameof(eLanding), nameof(eLinkInitialized), nameof(eMavSDKReq), nameof(eMavSDKResp), nameof(eMissionCleared), nameof(eMissionStarted), nameof(eMissionUploaded), nameof(eRaiseError), nameof(eReqArm), nameof(eReqAtTakeoffAlt), nameof(eReqBatteryRemaining), nameof(eReqClearMission), nameof(eReqDisarm), nameof(eReqHold), nameof(eReqInAirStatus), nameof(eReqLand), nameof(eReqLandingState), nameof(eReqMissionFinished), nameof(eReqMissionStart), nameof(eReqMissionUpload), nameof(eReqReturnToLaunch), nameof(eReqSystemStatus), nameof(eReqTakeoff), nameof(eReqTelemetryHealth), nameof(eReqWaitForDisarmed), nameof(eRespArm), nameof(eRespAtTakeoffAlt), nameof(eRespBatteryRemaining), nameof(eRespClearMission), nameof(eRespDisarm), nameof(eRespHold), nameof(eRespInAirStatus), nameof(eRespLand), nameof(eRespLandingState), nameof(eRespMissionFinished), nameof(eRespMissionStart), nameof(eRespMissionUpload), nameof(eRespReturnToLaunch), nameof(eRespSystemStatus), nameof(eRespTakeoff), nameof(eRespTelemetryHealth), nameof(eRespWaitForDisarmed), nameof(eReturnToLaunch), nameof(eShutdownSystem), nameof(eSpec_PreFlight), nameof(eSystemConnected), nameof(eTakeoff), nameof(eTakeoffReached), nameof(eTelemetryHealthAllOK), nameof(PHalt));
        }
    }
    
}
namespace PImplementation
{
    public partial class PHelper {
        public static void InitializeEnums() {
            PrtEnum.Clear();
            PrtEnum.AddEnumElements(new [] {"CRITICAL","WARNING","LOW","NORMAL"}, new [] {0,1,2,3});
        }
    }
    
}
#pragma warning restore 162, 219, 414
