Select 		'Echo Off' + char(10) + 
		+ 'echo =========================' + NOME 
		'wsdl.exe  http://localhost/WebServiceMSA/' + 
		rtrim(nome) + 
		 '.asmx /namespace:MSAClass.' + nome 
		+ ' /urlkey:url_asmxAcumulador ' + char(10)
		
from msaclasses
