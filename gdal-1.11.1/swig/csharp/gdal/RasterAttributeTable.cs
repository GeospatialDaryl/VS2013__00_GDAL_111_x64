/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace OSGeo.GDAL {

using System;
using System.Runtime.InteropServices;

public class RasterAttributeTable : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  protected object swigParentRef;
  
  protected static object ThisOwn_true() { return null; }
  protected object ThisOwn_false() { return this; }

  public RasterAttributeTable(IntPtr cPtr, bool cMemoryOwn, object parent) {
    swigCMemOwn = cMemoryOwn;
    swigParentRef = parent;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(RasterAttributeTable obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  public static HandleRef getCPtrAndDisown(RasterAttributeTable obj, object parent) {
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
  public static HandleRef getCPtrAndSetReference(RasterAttributeTable obj, object parent) {
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

  ~RasterAttributeTable() {
    Dispose();
  }

  public virtual void Dispose() {
  lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        GdalPINVOKE.delete_RasterAttributeTable(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      swigParentRef = null;
      GC.SuppressFinalize(this);
    }
  }

  public RasterAttributeTable() : this(GdalPINVOKE.new_RasterAttributeTable(), true, null) {
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
  }

  public RasterAttributeTable Clone() {
    IntPtr cPtr = GdalPINVOKE.RasterAttributeTable_Clone(swigCPtr);
    RasterAttributeTable ret = (cPtr == IntPtr.Zero) ? null : new RasterAttributeTable(cPtr, true, ThisOwn_true());
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetColumnCount() {
    int ret = GdalPINVOKE.RasterAttributeTable_GetColumnCount(swigCPtr);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetNameOfCol(int iCol) {
    string ret = GdalPINVOKE.RasterAttributeTable_GetNameOfCol(swigCPtr, iCol);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RATFieldUsage GetUsageOfCol(int iCol) {
    RATFieldUsage ret = (RATFieldUsage)GdalPINVOKE.RasterAttributeTable_GetUsageOfCol(swigCPtr, iCol);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RATFieldType GetTypeOfCol(int iCol) {
    RATFieldType ret = (RATFieldType)GdalPINVOKE.RasterAttributeTable_GetTypeOfCol(swigCPtr, iCol);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetColOfUsage(RATFieldUsage eUsage) {
    int ret = GdalPINVOKE.RasterAttributeTable_GetColOfUsage(swigCPtr, (int)eUsage);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetRowCount() {
    int ret = GdalPINVOKE.RasterAttributeTable_GetRowCount(swigCPtr);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetValueAsString(int iRow, int iCol) {
    string ret = GdalPINVOKE.RasterAttributeTable_GetValueAsString(swigCPtr, iRow, iCol);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetValueAsInt(int iRow, int iCol) {
    int ret = GdalPINVOKE.RasterAttributeTable_GetValueAsInt(swigCPtr, iRow, iCol);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetValueAsDouble(int iRow, int iCol) {
    double ret = GdalPINVOKE.RasterAttributeTable_GetValueAsDouble(swigCPtr, iRow, iCol);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetValueAsString(int iRow, int iCol, string pszValue) {
    GdalPINVOKE.RasterAttributeTable_SetValueAsString(swigCPtr, iRow, iCol, pszValue);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetValueAsInt(int iRow, int iCol, int nValue) {
    GdalPINVOKE.RasterAttributeTable_SetValueAsInt(swigCPtr, iRow, iCol, nValue);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetValueAsDouble(int iRow, int iCol, double dfValue) {
    GdalPINVOKE.RasterAttributeTable_SetValueAsDouble(swigCPtr, iRow, iCol, dfValue);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRowCount(int nCount) {
    GdalPINVOKE.RasterAttributeTable_SetRowCount(swigCPtr, nCount);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
  }

  public int CreateColumn(string pszName, RATFieldType eType, RATFieldUsage eUsage) {
    int ret = GdalPINVOKE.RasterAttributeTable_CreateColumn(swigCPtr, pszName, (int)eType, (int)eUsage);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetLinearBinning(out double pdfRow0Min, out double pdfBinSize) {
    bool ret = GdalPINVOKE.RasterAttributeTable_GetLinearBinning(swigCPtr, out pdfRow0Min, out pdfBinSize);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetLinearBinning(double dfRow0Min, double dfBinSize) {
    int ret = GdalPINVOKE.RasterAttributeTable_SetLinearBinning(swigCPtr, dfRow0Min, dfBinSize);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetRowOfValue(double dfValue) {
    int ret = GdalPINVOKE.RasterAttributeTable_GetRowOfValue(swigCPtr, dfValue);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int ChangesAreWrittenToFile() {
    int ret = GdalPINVOKE.RasterAttributeTable_ChangesAreWrittenToFile(swigCPtr);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
