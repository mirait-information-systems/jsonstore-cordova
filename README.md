# Cordova Plugin for JSONStore SDK


## Before you begin

Make sure you install the following tools and libraries.

* You should already have Node.js/npm and the Cordova package installed. If you don't, you can download and install Node from [https://nodejs.org/en/download/](https://nodejs.org/en/download/).

* The Cordova CLI tool is also required to use this plugin. You can find instructions to install Cordova and set up your Cordova app at [https://cordova.apache.org/#getstarted](https://cordova.apache.org/#getstarted).

To create a Cordova application, use the Cordova Plugin for JSONStore SDK:

1. Create a Cordova application
1. Add Cordova platforms
1. Add Cordova plugin
1. Configure your platform 


## Installing the Cordova Plugin for JSONStore SDK

### 1. Creating a Cordova application

1. Run the following commands to create a new Cordova application. Alternatively you can use an existing application as well. 

	```
	$ cordova create {appName}
	$ cd {appName}
	```
	
1. Edit `config.xml` file and set the desired application name in the `<name>` element instead of a default HelloCordova.

1. Continue editing `config.xml`. 
##### iOS
  For iOS, update the `<platform name="ios">` element with a deployment target declaration as shown in the code snippet below.

	```XML
	<platform name="ios">
		<preference name="deployment-target" value="8.0" />
		<!-- add deployment target declaration -->
	</platform>
	```
##### Android
  For Android, update the `<platform name="android">` element with a minimum and target SDK versions as shown in the code snippet below.

	```XML
	<platform name="android">
		<preference name="android-minSdkVersion" value="15" />
		<preference name="android-targetSdkVersion" value="23" />
		<!-- add minimum and target Android API level declaration -->
	</platform>
	```

	> The minSdkVersion should be above 14.
	
	> The targetSdkVersion should always reflect the latest Android SDK available from Google.

### 2. Adding Cordova platforms

Run the following commands for the platforms that you want to add to your Cordova application

```Bash
cordova platform add ios

cordova platform add android
```

### 3. Adding Cordova plugin

Run the following command from your Cordova application's root directory to add the ibm-mfp-core plugin:

```Bash
cordova plugin add cordova-plugin-jsonstore
```

You can check if the plugin installed successfully by running the following command, which lists your installed Cordova plugins:

```Bash
cordova plugin list
```



### 4. Configuring your platform
#### Configuring Your iOS Environment 

1. Build your Android project by running the following command:

```Bash
cordova build android
```