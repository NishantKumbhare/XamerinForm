Build IPA file.

- Select FormSample.ios and set as a startup project.
- Select Asset.xcassets and add all required image in case publish image to app store.
- open Info.Plist file
 	- Identity:- 
		- Check your application name.
		- bundle identifier will be like com.companyname.appname here “com.globallogic.formsample”
  	- configuration:-
        - Deployment Target:- minimum iOS version to be supported
		- Device Family:- iOS/ipad or universal

- FormSample.ios option pannel 
  		- Select build-> iOS bundle signing add team in case of not login with developer account
  		- Select identity for team developer name
  		- Select provision profile for respective project bundle identifier

- Inside project window fromSample.ios->Release->Generic Device 
- Select Build->Archive For Publishing.
- In Archive window select build form sample and select Signing and Distribute -> App store
- Select sign in identity and Provision Profile in provision profile window select next->publish and save spa file.
- This IPA file can publish using Xcode->Application loader to the app store.



Build APK file.

Select FormSample.Droid and set as a startup project.
Open project options window.
Android Application:-
	- Set Application icon for app icon shows when app install in device and for app store publish.
	- Set Version number/name
	- Set minimum android targets version.
Android Build:-
	- Linker window 
	- Set linker Behaviour to Link SDK assemblies only to reduce APK size.
Select package.config
	- set Build Action->ProguardConfiguration
	- It reduce the size of library and remove unused java bytecode.
Select FormSampl.Droid->Release
Build->Archive and Publishing to create apk
Archive window -> Sign and Distribute -> Select Addhoc and Generate key if not then next and save Apk


Add On Points for ios/android

1. Android app should target just armabi-v7a (or the precise ABI on the device this app is being run on)
FormSample.Droid->Option->Android Build->Advance Tab -> Check for armeabi-v7a

2. AOT the android application to reduce startup time
FormSample.Droid->Option->Android Build-> Enable AOT(Experimental)/Enable LLVM Optimising compiler 

3. Reduce the size of the apk or ipa generated (explain what you did to achieve this) and 
4. Compute the reduction of size of the generated apk/ipa
For IPA
- FormSample.ios->Option->ios Build->Linker Behaviour -> (Link Framework SDK only/Dont Link)
- If linker Behaviour set to Don’t Link size of IPA would be 35.7MB
- If linker Behaviour set to Link SDK assemblies only size of IPA would be 12.1 MB 
For APK
- FormSample.Droid->Option->Android Build->Linker Tab -> Linker Behaviour -> (Link SDK assemblies only/Dont Link)
- If linker Behaviour set to Don’t Link size of APK would be 45.6MB
- If linker Behaviour set to Link SDK assemblies only size of APK would be 17.8 MB  


