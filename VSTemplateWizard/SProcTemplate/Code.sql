/*
    Database            Object Name											Object Type					Rollback Required?			Action			Bug/Story
    ----------------    ------------------------------------				-----------------------		------------------------	------------	------------------------
    $databasename$      $sprocname$											Stored Procedure			$rollbackrequired$			$action$		$itemnumber$
*/
USE [$databasename$]
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

PRINT 'Compile stored procedure [dbo].[$sprocname$]'
GO

IF OBJECT_ID('[dbo].[$sprocname$]') IS NULL
    EXEC ('CREATE PROCEDURE [dbo].[$sprocname$] AS RAISERROR(N''Not Implemented'', 16, 1);');
GO
/***************************************************************************************************************************************************************
*   dbo.$sprocname$
*
*    Purpose: ??
*
*    Author: ??
*
*    Origination Date: ??
*
*    History:
*    Revision		By				Date			US/Bug			Task			Change
*	 $revision$		$editorname$	$date$			$itemnumber$	$tasknumber$	$changecomments$
*
**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[$sprocname$]     
	@param1 int = 0,
	@param2 int
AS
	SELECT @param1, @param2
RETURN 0
