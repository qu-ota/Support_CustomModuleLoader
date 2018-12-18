package owochat
{
	function serverCmdMessageSent(%cl, %msg)
	{
		%msg = strReplace(%msg, "o", "owo");
		%msg = strReplace(%msg, "O", "OWO");
		return parent::serverCmdMessageSent(%cl, %msg);
	}
};
activatePackage(owoChat);

package uwuchat
{
	function serverCmdMessageSent(%cl, %msg)
	{
		%msg = strReplace(%msg, "u", "uwu");
		%msg = strReplace(%msg, "U", "UWU");
		return parent::serverCmdMessageSent(%cl, %msg);
	}
};
activatePackage(uwuChat);