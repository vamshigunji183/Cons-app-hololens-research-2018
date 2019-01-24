<img src="External/ReadMeImages/MRTK_Logo_Rev.png">

# What is MixedRealityToolkit-Unity?
The Mixed Reality Toolkit is a collection of scripts and components intended to accelerate development of applications targeting Microsoft HoloLens and Windows Mixed Reality headsets.
The project is aimed at reducing barriers to entry to create mixed reality applications and contribute back to the community as we all grow.

MixedRealityToolkit-Unity uses code from the base [MixedRealityToolkit](https://github.com/Microsoft/MixedRealityToolkit) and makes it easier to consume in [Unity](https://unity3d.com/).

[![Mixed Reality Academy](External/ReadMeImages/MixedRealityStack-Apps.png)](https://developer.microsoft.com/en-us/windows/mixed-reality/academy)
[![View the Mixed Reality Companion Kit](External/ReadMeImages/MixedRealityStack-MRTK-Unity.png)](https://github.com/Microsoft/MixedRealityCompanionKit)
[![Mixed Reality Toolkit GitHub Repo](External/ReadMeImages/MixedRealityStack-MRTK.png)](https://github.com/Microsoft/MixedRealityToolkit)
[![Read the Mixed Reality Developer Guides](External/ReadMeImages/MixedRealityStack-UWP.png)](https://developer.microsoft.com/en-us/windows/mixed-reality)

> Learn more about [Windows Mixed Reality](https://www.microsoft.com/en-gb/windows/windows-mixed-reality) here.

_Note: The latest release should work for both HoloLens and Windows Mixed Reality development._

[github-rel]:                    https://github.com/Microsoft/MixedRealityToolkit-Unity/releases/latest
[mrtk-version-badge]:            https://img.shields.io/github/tag/microsoft/MixedRealityToolkit-unity.svg?label=Latest%20Master%20Branch%20Release&colorB=9acd32
[![Github Release][mrtk-version-badge]][github-rel]

[unity-download]:                 https://unity3d.com/unity/whats-new/unity-2017.2.1
[unity-version-badge]:            https://img.shields.io/badge/Current%20Unity%20Editor%20Version-2017.2.1f1-green.svg
[![Github Release][unity-version-badge]][unity-download]

> Check out the MRTK [Roadmap](/Roadmap.md) for Unity.
>
> Check out the updates from the [Fall Creators update](/FallCreatorsUpdate.md) for Windows Mixed Reality.
>
> Check out the [Breaking Changes](/BreakingChanges.md) from the previous release.

Looking to upgrade your projects to Windows Mixed Reality? [Follow the Upgrade Guide](/UpgradeGuide.md).

# Feature areas
The Mixed Reality Toolkit for Unity includes many APIs to accelerate the development of Mixed Reality projects for both HoloLens and the newer Immersive Headsets (IHMD)

| [![Input](External/ReadMeImages/MRTK170802_Short_03.png)](Assets/HoloToolkit/Input/README.md)  [Input](Assets/HoloToolkit/Input/README.md)                                               | [![Sharing](External/ReadMeImages/MRTK170802_Short_04.png)](Assets/HoloToolkit/Sharing/README.md) [Sharing](Assets/HoloToolkit/Sharing/README.md)   | [![Spatial Mapping](External/ReadMeImages/MRTK170802_Short_05.png)](Assets/HoloToolkit/SpatialMapping/README.md) [Spatial Mapping](Assets/HoloToolkit/SpatialMapping/README.md)| 
| :--- | :--- | :--- |
| Scripts that leverage inputs such as gaze, gesture, voice and motion controllers. Includes the Mixed Reality camera prefabs. | Sharing library enables collaboration across multiple devices. | Scripts that allow applications to bring the real world into the digital using HoloLens. | 
| [![Spatial Sound](External/ReadMeImages/MRTK170802_Short_09.png)](Assets/HoloToolkit/SpatialSound/README.md) [Spatial Sound](Assets/HoloToolkit/SpatialSound/README.md) | [![UX Controls](External/ReadMeImages/MRTK170802_Short_10.png)](Assets/HoloToolkit/UX/README.md) [UX Controls](Assets/HoloToolkit/UX/README.md)| [![Utilities](External/ReadMeImages/MRTK170802_Short_11.png)](Assets/HoloToolkit/Utilities/README.md) [Utilities](Assets/HoloToolkit/Utilities/README.md) | 
| Scripts to help plug spatial audio into your application. | Building blocks for creating good UX in your application like common controls. | Common helpers and tools that you can leverage in your application. |
| [![Spatial Understanding](External/ReadMeImages/MRTK170802_Short_06.png)](Assets/HoloToolkit/SpatialUnderstanding/README.md) [Spatial Understanding](Assets/HoloToolkit/SpatialUnderstanding/README.md)| [![Build](External/ReadMeImages/MRTK170802_Short_12.png)](Assets/HoloToolkit/BuildAndDeploy/README.md) [Build](Assets/HoloToolkit/BuildAndDeploy/README.md)| [![Boundary](External/ReadMeImages/MRTK170802_Short_07.png)](Assets/HoloToolkit/Boundary/README.md) [Boundary](Assets/HoloToolkit/Boundary/README.md)                       |
| Tailor experiences based on room semantics like couch, wall etc.                                                                                  | Build and deploy automation window for Unity Editor.                                                        | Scripts that help with rendering the floor and boundaries for Immersive Devices.

# Required Software
| [![Windows 10 Creators Update](External/ReadMeImages/MRTK170802_Short_17.png)](https://www.microsoft.com/software-download/windows10) [Windows 10 FCU](https://www.microsoft.com/software-download/windows10)| [![Unity](External/ReadMeImages/MRTK170802_Short_18.png)](https://unity3d.com/get-unity/download/archive) [Unity 3D](https://unity3d.com/get-unity/download/archive)| [![Visual Studio 2017](External/ReadMeImages/MRTK170802_Short_19.png)](http://dev.windows.com/downloads) [Visual Studio 2017](http://dev.windows.com/downloads)| [![Simulator (optional)](External/ReadMeImages/MRTK170802_Short_20.png)](https://go.microsoft.com/fwlink/?linkid=852626) [Simulator (optional)](https://go.microsoft.com/fwlink/?linkid=852626)|
| :--- | :--- | :--- | :--- |
| To develop apps for mixed reality headsets, you need the Windows 10 Fall Creators Update | The Unity 3D engine provides support for building mixed reality projects in Windows 10 | Visual Studio is used for code editing, deploying and building UWP app packages | The Emulators allow you test your app without the device in a simulated environment |

# Getting started with MRTK
To get up and going as quickly as possible, here are some guides to help you get started building Mixed Reality Projects

| [![Quick Start Guide](External/ReadMeImages/MRTK170802c_Short_22.png)](GettingStarted.md) [Quick start](GettingStarted.md) | [![Contributing to this project](External/ReadMeImages/MRTK170802c_Short_23.png)](CONTRIBUTING.md) [Contributing to this project](CONTRIBUTING.md) | [![Contributing to this project](External/ReadMeImages/MRTK170802c_Short_24.png)](FallCreatorsUpdate.md) [Fall Creators Update](FallCreatorsUpdate.md) |
|:--- | :--- | :--- |
| Please go over the [Getting started guide](GettingStarted.md) to learn more about getting off the ground quickly. | Please go over the [Contributing guidelines](CONTRIBUTING.md) to learn more about the process and thinking. | Check out the recent updates for Windows Mixed reality in the [Fall Creators update](/FallCreatorsUpdate.md) |

