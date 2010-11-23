update ToolCategory set code = replace(code, 'G9', '99') 
update ToolCategory set code = replace(code, 'G', '0') 

update Tool set code = replace(code, 'G9', '99') 
update Tool set code = replace(code, 'G', '0') 
