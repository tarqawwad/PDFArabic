# PDFArabic
Export PDF with Language Arabic by Rotativa plugin

- Use JS,Html,CSS,C#
- Use Rotativa Plugin in NuGet 1.7.2v
- Simple theme , easy to use.
- Prepare Data in Controller 
- Download File From Controller

# Rotativa Options 

- PageMargins : Margins(int top, int right, int bottom, int left) . 
- PageOrientation : LandScape 0 , Portrait 1 .
- PageSize :
 A0 = 0,A1 = 1,A2 = 2,A3 = 3,A4 = 4,A5 = 5,A6 = 6,A7 = 7,A8 = 8,A9 = 9,
 B0 = 10,B1 = 11,B2 = 12,B3 = 13,B4 = 14,B5 = 15,B6 = 16,B7 = 17,B8 = 18,B9 = 19,B10 = 20,
 C5E = 21,Comm10E = 22,Dle = 23,Executive = 24,Folio = 25,Ledger = 26,Legal = 27,Letter = 28,Tabloid = 29
- PageWidth (double) .
- PageHeight (double) .
- IsLowQuality (bool) 
- IsJavaScriptDisabled (bool) 
- MinimumFontSize(int)
- CustomHeaders ( Dictionary<string, string> )
- CustomSwitches (string)
- SaveOnServerPath (string)

# How to use 

- Add Rotativa Plugin from NuGet .
- Add Files from code (Rotativa) to your project .
- Prepare Data in Controller .
- Create View without layout and import css or fonts if need it .
- Create Action Result in Controller for Download and set options .

# ScreenShot PDF Arabic
![Screenshot_1](https://user-images.githubusercontent.com/63288936/152765211-e17254fa-76c8-47d3-86e8-7630234bc2a6.png)
![Screenshot_2](https://user-images.githubusercontent.com/63288936/152765218-a40ebd7d-3818-4fee-9374-b3cc17009c52.png)


