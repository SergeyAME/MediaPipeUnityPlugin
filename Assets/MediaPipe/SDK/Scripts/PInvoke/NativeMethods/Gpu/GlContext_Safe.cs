using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace Mediapipe {
  internal static partial class SafeNativeMethods {
    #region GlContext
    [Pure, DllImport (MediaPipeLibrary, ExactSpelling = true)]
    public static extern IntPtr mp_SharedGlContext__get(IntPtr sharedGlContext);

    [Pure, DllImport (MediaPipeLibrary, ExactSpelling = true)]
    public static extern IntPtr mp_GlContext__egl_display(IntPtr GlContext);

    [Pure, DllImport (MediaPipeLibrary, ExactSpelling = true)]
    public static extern IntPtr mp_GlContext__egl_config(IntPtr GlContext);

    [Pure, DllImport (MediaPipeLibrary, ExactSpelling = true)]
    public static extern IntPtr mp_GlContext__egl_context(IntPtr GlContext);

    [Pure, DllImport (MediaPipeLibrary, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool mp_GlContext__IsCurrent(IntPtr GlContext);

    [Pure, DllImport (MediaPipeLibrary, ExactSpelling = true)]
    public static extern int mp_GlContext__gl_major_version(IntPtr GlContext);

    [Pure, DllImport (MediaPipeLibrary, ExactSpelling = true)]
    public static extern int mp_GlContext__gl_minor_version(IntPtr GlContext);

    [Pure, DllImport (MediaPipeLibrary, ExactSpelling = true)]
    public static extern long mp_GlContext__gl_finish_count(IntPtr GlContext);
    #endregion

    #region GlSyncToken
    [Pure, DllImport (MediaPipeLibrary, ExactSpelling = true)]
    public static extern IntPtr mp_GlSyncToken__get(IntPtr glSyncToken);
    #endregion
  }
}
