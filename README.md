안드로이드/데스크탑용 WebApp기반.

주의사항, 안드로이드의 경우 Http를 허용하지 않으므로 예외처리가 필요함.
1. AndroidManifest.xml에

   android:usesCleartextTraffic="true"
	 android:networkSecurityConfig="@xml/network_security_config"
내용추가.

2.Platform\Android\Resources\xml의 경로에 network_security_config.xml 추가하여, 접근하려는 http주소 혹은 ip 허용.
  <network-security-config>
	  <domain-config cleartextTrafficPermitted="true">
		  <domain includeSubdomains="true">192.168.0.48</domain>
	  </domain-config>
  </network-security-config>


이외에, 상단 내비바/탭바 Visible=false 처리.
AppShell.xmal에

Shell.NavBarIsVisible="False"
Shell.TabBarIsVisible="False"
처리.
