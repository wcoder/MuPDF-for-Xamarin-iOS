
# download CocoaPod library
sharpie pod init ios MuPDF

# build
cd Pods
./Pods/xcodebuild
cd ..

# copy framework
cp -R build/Release-iphoneos/MuPDF/mupdf.framework Binding/
