
# react-native-vocation-feb-tour

## Getting started

`$ npm install react-native-vocation-feb-tour --save`

### Mostly automatic installation

`$ react-native link react-native-vocation-feb-tour`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-vocation-feb-tour` and add `RNVocationFebTour.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNVocationFebTour.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNVocationFebTourPackage;` to the imports at the top of the file
  - Add `new RNVocationFebTourPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-vocation-feb-tour'
  	project(':react-native-vocation-feb-tour').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-vocation-feb-tour/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-vocation-feb-tour')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNVocationFebTour.sln` in `node_modules/react-native-vocation-feb-tour/windows/RNVocationFebTour.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Vocation.Feb.Tour.RNVocationFebTour;` to the usings at the top of the file
  - Add `new RNVocationFebTourPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNVocationFebTour from 'react-native-vocation-feb-tour';

// TODO: What to do with the module?
RNVocationFebTour;
```
  