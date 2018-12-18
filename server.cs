//Custom Module Loader by Dominoes
//Put all scripts into the "modules" folder, then use reloadCMLmodules(); in console to refresh the scripts loaded.

function loadYAMAModules() //function for finding & loading modules
{
	%search = "Add-Ons/Support_CustomModuleLoader/modules/*.cs";

	for(%file = findFirstFile(%search); isFile(%file); %file = findNextFile(%search))
	{
		echo("=== Module Loader | Loading module:" SPC %file SPC "===");
		exec(%file);
	}
}
echo("=== Module Loader Initiated ===");
echo("=== Module Loader | Looking for modules ===");
loadYAMAModules();
echo("=== Module Loader | Finished loading ===");
