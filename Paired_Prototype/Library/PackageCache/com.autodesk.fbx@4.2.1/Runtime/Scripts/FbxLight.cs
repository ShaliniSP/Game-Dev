#if UNITY_EDITOR || FBXSDK_RUNTIME
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Autodesk.Fbx {

public class FbxLight : FbxNodeAttribute {
  internal FbxLight(global::System.IntPtr cPtr, bool ignored) : base(cPtr, ignored) { }

  // override void Dispose() {base.Dispose();}

  public new static FbxLight Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxLight_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxLight ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLight(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static FbxLight Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxLight_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxLight ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLight(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetShadowTexture(FbxTexture pTexture) {
    NativeMethods.FbxLight_SetShadowTexture(swigCPtr, FbxTexture.getCPtr(pTexture));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public FbxTexture GetShadowTexture() {
    global::System.IntPtr cPtr = NativeMethods.FbxLight_GetShadowTexture(swigCPtr);
    FbxTexture ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxTexture(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxPropertyELightType LightType {
    get {
      FbxPropertyELightType ret = new FbxPropertyELightType(NativeMethods.FbxLight_LightType_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool CastLight {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxLight_CastLight_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool DrawVolumetricLight {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxLight_DrawVolumetricLight_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool DrawGroundProjection {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxLight_DrawGroundProjection_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool DrawFrontFacingVolumetricLight {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxLight_DrawFrontFacingVolumetricLight_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public new FbxPropertyDouble3 Color {
    get {
      FbxPropertyDouble3 ret = new FbxPropertyDouble3(NativeMethods.FbxLight_Color_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble Intensity {
    get {
      FbxPropertyDouble ret = new FbxPropertyDouble(NativeMethods.FbxLight_Intensity_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble InnerAngle {
    get {
      FbxPropertyDouble ret = new FbxPropertyDouble(NativeMethods.FbxLight_InnerAngle_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble OuterAngle {
    get {
      FbxPropertyDouble ret = new FbxPropertyDouble(NativeMethods.FbxLight_OuterAngle_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble Fog {
    get {
      FbxPropertyDouble ret = new FbxPropertyDouble(NativeMethods.FbxLight_Fog_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyEDecayType DecayType {
    get {
      FbxPropertyEDecayType ret = new FbxPropertyEDecayType(NativeMethods.FbxLight_DecayType_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble DecayStart {
    get {
      FbxPropertyDouble ret = new FbxPropertyDouble(NativeMethods.FbxLight_DecayStart_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyString FileName {
    get {
      FbxPropertyString ret = new FbxPropertyString(NativeMethods.FbxLight_FileName_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool EnableNearAttenuation {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxLight_EnableNearAttenuation_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble NearAttenuationStart {
    get {
      FbxPropertyDouble ret = new FbxPropertyDouble(NativeMethods.FbxLight_NearAttenuationStart_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble NearAttenuationEnd {
    get {
      FbxPropertyDouble ret = new FbxPropertyDouble(NativeMethods.FbxLight_NearAttenuationEnd_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool EnableFarAttenuation {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxLight_EnableFarAttenuation_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble FarAttenuationStart {
    get {
      FbxPropertyDouble ret = new FbxPropertyDouble(NativeMethods.FbxLight_FarAttenuationStart_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble FarAttenuationEnd {
    get {
      FbxPropertyDouble ret = new FbxPropertyDouble(NativeMethods.FbxLight_FarAttenuationEnd_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool CastShadows {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxLight_CastShadows_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble3 ShadowColor {
    get {
      FbxPropertyDouble3 ret = new FbxPropertyDouble3(NativeMethods.FbxLight_ShadowColor_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyEAreaLightShape AreaLightShape {
    get {
      FbxPropertyEAreaLightShape ret = new FbxPropertyEAreaLightShape(NativeMethods.FbxLight_AreaLightShape_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyFloat LeftBarnDoor {
    get {
      FbxPropertyFloat ret = new FbxPropertyFloat(NativeMethods.FbxLight_LeftBarnDoor_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyFloat RightBarnDoor {
    get {
      FbxPropertyFloat ret = new FbxPropertyFloat(NativeMethods.FbxLight_RightBarnDoor_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyFloat TopBarnDoor {
    get {
      FbxPropertyFloat ret = new FbxPropertyFloat(NativeMethods.FbxLight_TopBarnDoor_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyFloat BottomBarnDoor {
    get {
      FbxPropertyFloat ret = new FbxPropertyFloat(NativeMethods.FbxLight_BottomBarnDoor_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool EnableBarnDoor {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxLight_EnableBarnDoor_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public override int GetHashCode(){
      return swigCPtr.Handle.GetHashCode();
  }

  public bool Equals(FbxLight other) {
    if (object.ReferenceEquals(other, null)) { return false; }
    return this.swigCPtr.Handle.Equals (other.swigCPtr.Handle);
  }

  public override bool Equals(object obj){
    if (object.ReferenceEquals(obj, null)) { return false; }
    /* is obj a subclass of this type; if so use our Equals */
    var typed = obj as FbxLight;
    if (!object.ReferenceEquals(typed, null)) {
      return this.Equals(typed);
    }
    /* are we a subclass of the other type; if so use their Equals */
    if (typeof(FbxLight).IsSubclassOf(obj.GetType())) {
      return obj.Equals(this);
    }
    /* types are unrelated; can't be a match */
    return false;
  }

  public static bool operator == (FbxLight a, FbxLight b) {
    if (object.ReferenceEquals(a, b)) { return true; }
    if (object.ReferenceEquals(a, null) || object.ReferenceEquals(b, null)) { return false; }
    return a.Equals(b);
  }

  public static bool operator != (FbxLight a, FbxLight b) {
    return !(a == b);
  }

  public new enum EType {
    ePoint,
    eDirectional,
    eSpot,
    eArea,
    eVolume
  }

  public enum EDecayType {
    eNone,
    eLinear,
    eQuadratic,
    eCubic
  }

  public enum EAreaLightShape {
    eRectangle,
    eSphere
  }

}

}

#endif // UNITY_EDITOR || FBXSDK_RUNTIME