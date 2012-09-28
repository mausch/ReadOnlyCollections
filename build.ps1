$versions = ("v2.0", "v4.0", "v4.5")
foreach ($v in $versions) {
	msbuild /m ReadOnlyCollections.sln /p:TargetFrameworkVersion=$v /p:Configuration=Release
}