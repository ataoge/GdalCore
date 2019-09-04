//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace OSGeo.OGR {

using global::System;
using global::System.Runtime.InteropServices;

public class Envelope3D : global::System.IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  protected object swigParentRef;

  protected static object ThisOwn_true() { return null; }
  protected object ThisOwn_false() { return this; }

  public Envelope3D(IntPtr cPtr, bool cMemoryOwn, object parent) {
    swigCMemOwn = cMemoryOwn;
    swigParentRef = parent;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(Envelope3D obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  public static HandleRef getCPtrAndDisown(Envelope3D obj, object parent) {
    if (obj != null)
    {
      obj.swigCMemOwn = false;
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }
  public static HandleRef getCPtrAndSetReference(Envelope3D obj, object parent) {
    if (obj != null)
    {
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }

  ~Envelope3D() {
    Dispose();
  }

  public virtual void Dispose() {
  lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        OgrPINVOKE.delete_Envelope3D(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      swigParentRef = null;
      GC.SuppressFinalize(this);
    }
  }

  public double MinX {
    set {
      OgrPINVOKE.Envelope3D_MinX_set(swigCPtr, value);
      if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = OgrPINVOKE.Envelope3D_MinX_get(swigCPtr);
      if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double MaxX {
    set {
      OgrPINVOKE.Envelope3D_MaxX_set(swigCPtr, value);
      if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = OgrPINVOKE.Envelope3D_MaxX_get(swigCPtr);
      if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double MinY {
    set {
      OgrPINVOKE.Envelope3D_MinY_set(swigCPtr, value);
      if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = OgrPINVOKE.Envelope3D_MinY_get(swigCPtr);
      if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double MaxY {
    set {
      OgrPINVOKE.Envelope3D_MaxY_set(swigCPtr, value);
      if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = OgrPINVOKE.Envelope3D_MaxY_get(swigCPtr);
      if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double MinZ {
    set {
      OgrPINVOKE.Envelope3D_MinZ_set(swigCPtr, value);
      if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = OgrPINVOKE.Envelope3D_MinZ_get(swigCPtr);
      if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double MaxZ {
    set {
      OgrPINVOKE.Envelope3D_MaxZ_set(swigCPtr, value);
      if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = OgrPINVOKE.Envelope3D_MaxZ_get(swigCPtr);
      if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Envelope3D() : this(OgrPINVOKE.new_Envelope3D(), true, null) {
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
