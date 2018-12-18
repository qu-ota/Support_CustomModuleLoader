function serverCmdToggleVowelChat(%cl)
{
	if(%cl.isSuperAdmin)
	{
		if($Pref::VowelChat::Enabled == 0)
		{
			messageAll('MsgAdminForce',"\c6" @ %cl.name SPC "\c7has enabled VowelChat. Oh gOd whOt hOvO thOy dOnO.");
			activatePackage(vowelChat);
			$Pref::VowelChat::Enabled = 1;
			return;
		}
		else
		{
			%thing = strReplace(%cl.name, "a", "O");
			%thing = strReplace(%cl.name, "e", "O");
			%thing = strReplace(%cl.name, "i", "O");
			%thing = strReplace(%cl.name, "o", "O");
			%thing = strReplace(%cl.name, "u", "O");
			messageAll('MsgAdminForce',"\c6" @ %thing SPC "\c7 hOs dOsOblOd VOwOlChOt. We're safe, for now.");
			deactivatePackage(vowelChat);
			return;
		}
	}
	else
	{
		messageClient(%cl,'',"\c7Looks like you're unable to use this command. Consult your local \c6Super Admin \c7for help.");
		return;
	}
}

package vowelchat
{
	function serverCmdMessageSent(%cl, %msg)
	{
		%msg = strReplace(%msg, "a", "O");
		%msg = strReplace(%msg, "e", "O");
		%msg = strReplace(%msg, "i", "O");
		%msg = strReplace(%msg, "o", "O");
		%msg = strReplace(%msg, "u", "O");
		return parent::serverCmdMessageSent(%cl, %msg);
		
	}
};
