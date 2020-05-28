rem https://social.technet.microsoft.com/wiki/contents/articles/40155.visual-studio-how-to-create-a-non-expiring-certificate.aspx 
MakeCert /n "CN=OutlookTfsConnector" /r /h 0 /eku "1.3.6.1.5.5.7.3.3,1.3.6.1.4.1.311.10.3.13" /e "01/01/2174" /sv OutlookTfsConnector.pvk OutlookTfsConnector.cer 
pvk2pfx -pvk OutlookTfsConnector.pvk -spc OutlookTfsConnector.cer -pfx OutlookTfsConnector.pfx -f -po P@ssw0rd
