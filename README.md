# ALNX-1004-SLDSK
UAC-Bypass Exploiting DiskCleanup RegKeys

```yaml
TargetOS: Win10
TestedOn: Win10-2004 SO 19041.630
Payload: Bin/Dir-Payload/
Language: C#
Patch: n/a
Danger: 8
Classification: ALNX-1004-SLDSK
```

**_Explaination_**
```
Microsoft File "Microsoft\Windows\DiskCleanup\SilentCleanup\schtasks.exe" Runs ALWAYS
as Administrator, that said, we can exploit the Env by setting our Dir-Payload into windir ReKey
```

