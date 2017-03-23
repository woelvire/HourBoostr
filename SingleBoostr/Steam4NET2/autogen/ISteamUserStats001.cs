// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamUserStats001VTable
	{
		public IntPtr GetNumStats0;
		public IntPtr GetStatName1;
		public IntPtr GetStatType2;
		public IntPtr GetNumAchievements3;
		public IntPtr GetAchievementName4;
		public IntPtr GetNumGroupAchievements5;
		public IntPtr GetGroupAchievementName6;
		public IntPtr RequestCurrentStats7;
		public IntPtr GetStat8;
		public IntPtr GetStat9;
		public IntPtr SetStat10;
		public IntPtr SetStat11;
		public IntPtr UpdateAvgRateStat12;
		public IntPtr GetAchievement13;
		public IntPtr GetGroupAchievement14;
		public IntPtr SetAchievement15;
		public IntPtr SetGroupAchievement16;
		public IntPtr StoreStats17;
		public IntPtr ClearAchievement18;
		public IntPtr ClearGroupAchievement19;
		public IntPtr GetAchievementIcon20;
		public IntPtr GetAchievementDisplayAttribute21;
		private IntPtr DTorISteamUserStats00122;
	};
	
	[InteropHelp.InterfaceVersion("STEAMUSERSTATS_INTERFACE_VERSION001")]
	public class ISteamUserStats001 : InteropHelp.NativeWrapper<ISteamUserStats001VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetNumStatsC( IntPtr thisptr, UInt64 nGameID );
		public UInt32 GetNumStats( CGameID nGameID ) 
		{
			return this.GetFunction<NativeGetNumStatsC>( this.Functions.GetNumStats0 )( this.ObjectAddress, nGameID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetStatNameCU( IntPtr thisptr, UInt64 nGameID, UInt32 iStat );
		public string GetStatName( CGameID nGameID, UInt32 iStat ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetStatNameCU>( this.Functions.GetStatName1 )( this.ObjectAddress, nGameID.ConvertToUint64(), iStat ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ESteamUserStatType NativeGetStatTypeCS( IntPtr thisptr, UInt64 nGameID, string pchName );
		public ESteamUserStatType GetStatType( CGameID nGameID, string pchName ) 
		{
			return this.GetFunction<NativeGetStatTypeCS>( this.Functions.GetStatType2 )( this.ObjectAddress, nGameID.ConvertToUint64(), pchName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetNumAchievementsC( IntPtr thisptr, UInt64 nGameID );
		public UInt32 GetNumAchievements( CGameID nGameID ) 
		{
			return this.GetFunction<NativeGetNumAchievementsC>( this.Functions.GetNumAchievements3 )( this.ObjectAddress, nGameID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetAchievementNameCU( IntPtr thisptr, UInt64 nGameID, UInt32 iAchievement );
		public string GetAchievementName( CGameID nGameID, UInt32 iAchievement ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetAchievementNameCU>( this.Functions.GetAchievementName4 )( this.ObjectAddress, nGameID.ConvertToUint64(), iAchievement ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetNumGroupAchievementsC( IntPtr thisptr, UInt64 arg0 );
		public UInt32 GetNumGroupAchievements( CGameID arg0 ) 
		{
			return this.GetFunction<NativeGetNumGroupAchievementsC>( this.Functions.GetNumGroupAchievements5 )( this.ObjectAddress, arg0.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetGroupAchievementNameCU( IntPtr thisptr, UInt64 arg0, UInt32 iAchievement );
		public string GetGroupAchievementName( CGameID arg0, UInt32 iAchievement ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetGroupAchievementNameCU>( this.Functions.GetGroupAchievementName6 )( this.ObjectAddress, arg0.ConvertToUint64(), iAchievement ) ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestCurrentStatsC( IntPtr thisptr, UInt64 nGameID );
		public bool RequestCurrentStats( CGameID nGameID ) 
		{
			return this.GetFunction<NativeRequestCurrentStatsC>( this.Functions.RequestCurrentStats7 )( this.ObjectAddress, nGameID.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetStatCSF( IntPtr thisptr, UInt64 nGameID, string pchName, ref float pData );
		public bool GetStat( CGameID nGameID, string pchName, ref float pData ) 
		{
			return this.GetFunction<NativeGetStatCSF>( this.Functions.GetStat8 )( this.ObjectAddress, nGameID.ConvertToUint64(), pchName, ref pData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetStatCSI( IntPtr thisptr, UInt64 nGameID, string pchName, ref Int32 pData );
		public bool GetStat( CGameID nGameID, string pchName, ref Int32 pData ) 
		{
			return this.GetFunction<NativeGetStatCSI>( this.Functions.GetStat9 )( this.ObjectAddress, nGameID.ConvertToUint64(), pchName, ref pData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetStatCSF( IntPtr thisptr, UInt64 nGameID, string pchName, float fData );
		public bool SetStat( CGameID nGameID, string pchName, float fData ) 
		{
			return this.GetFunction<NativeSetStatCSF>( this.Functions.SetStat10 )( this.ObjectAddress, nGameID.ConvertToUint64(), pchName, fData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetStatCSI( IntPtr thisptr, UInt64 nGameID, string pchName, Int32 nData );
		public bool SetStat( CGameID nGameID, string pchName, Int32 nData ) 
		{
			return this.GetFunction<NativeSetStatCSI>( this.Functions.SetStat11 )( this.ObjectAddress, nGameID.ConvertToUint64(), pchName, nData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdateAvgRateStatCSFD( IntPtr thisptr, UInt64 nGameID, string pchName, float arg2, double dSessionLength );
		public bool UpdateAvgRateStat( CGameID nGameID, string pchName, float arg2, double dSessionLength ) 
		{
			return this.GetFunction<NativeUpdateAvgRateStatCSFD>( this.Functions.UpdateAvgRateStat12 )( this.ObjectAddress, nGameID.ConvertToUint64(), pchName, arg2, dSessionLength ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAchievementCSB( IntPtr thisptr, UInt64 nGameID, string pchName, ref bool pbAchieved );
		public bool GetAchievement( CGameID nGameID, string pchName, ref bool pbAchieved ) 
		{
			return this.GetFunction<NativeGetAchievementCSB>( this.Functions.GetAchievement13 )( this.ObjectAddress, nGameID.ConvertToUint64(), pchName, ref pbAchieved ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetGroupAchievementCSB( IntPtr thisptr, UInt64 nGameID, string pchName, ref bool pbAchieved );
		public bool GetGroupAchievement( CGameID nGameID, string pchName, ref bool pbAchieved ) 
		{
			return this.GetFunction<NativeGetGroupAchievementCSB>( this.Functions.GetGroupAchievement14 )( this.ObjectAddress, nGameID.ConvertToUint64(), pchName, ref pbAchieved ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetAchievementCS( IntPtr thisptr, UInt64 nGameID, string pchName );
		public bool SetAchievement( CGameID nGameID, string pchName ) 
		{
			return this.GetFunction<NativeSetAchievementCS>( this.Functions.SetAchievement15 )( this.ObjectAddress, nGameID.ConvertToUint64(), pchName ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetGroupAchievementCS( IntPtr thisptr, UInt64 nGameID, string pchName );
		public bool SetGroupAchievement( CGameID nGameID, string pchName ) 
		{
			return this.GetFunction<NativeSetGroupAchievementCS>( this.Functions.SetGroupAchievement16 )( this.ObjectAddress, nGameID.ConvertToUint64(), pchName ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeStoreStatsC( IntPtr thisptr, UInt64 nGameID );
		public bool StoreStats( CGameID nGameID ) 
		{
			return this.GetFunction<NativeStoreStatsC>( this.Functions.StoreStats17 )( this.ObjectAddress, nGameID.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeClearAchievementCS( IntPtr thisptr, UInt64 nGameID, string pchName );
		public bool ClearAchievement( CGameID nGameID, string pchName ) 
		{
			return this.GetFunction<NativeClearAchievementCS>( this.Functions.ClearAchievement18 )( this.ObjectAddress, nGameID.ConvertToUint64(), pchName ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeClearGroupAchievementCS( IntPtr thisptr, UInt64 nGameID, string pchName );
		public bool ClearGroupAchievement( CGameID nGameID, string pchName ) 
		{
			return this.GetFunction<NativeClearGroupAchievementCS>( this.Functions.ClearGroupAchievement19 )( this.ObjectAddress, nGameID.ConvertToUint64(), pchName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetAchievementIconCS( IntPtr thisptr, UInt64 nGameID, string pchName );
		public Int32 GetAchievementIcon( CGameID nGameID, string pchName ) 
		{
			return this.GetFunction<NativeGetAchievementIconCS>( this.Functions.GetAchievementIcon20 )( this.ObjectAddress, nGameID.ConvertToUint64(), pchName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetAchievementDisplayAttributeCSS( IntPtr thisptr, UInt64 nGameID, string pchName, string pchKey );
		public string GetAchievementDisplayAttribute( CGameID nGameID, string pchName, string pchKey ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetAchievementDisplayAttributeCSS>( this.Functions.GetAchievementDisplayAttribute21 )( this.ObjectAddress, nGameID.ConvertToUint64(), pchName, pchKey ) ) ); 
		}
		
	};
}