$versions = ("v2.0", "v3.5", "v4.0", "v4.5")
foreach ($v in $versions) {
	"================="
	"Building for " + $v
	"================="
	msbuild /m ReadOnlyCollections.sln /p:TargetFrameworkVersion=$v /p:Configuration=Release
}