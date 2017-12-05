using System;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using mupdf;

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern int * ctx;
	[Field ("ctx", "__Internal")]
	unsafe int* ctx { get; }

	// extern dispatch_queue_t queue;
	[Field ("queue", "__Internal")]
	DispatchQueue queue { get; }

	// extern float screenScale;
	[Field ("screenScale", "__Internal")]
	float screenScale { get; }
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern fz_alloc_context fz_alloc_default;
	[Field ("fz_alloc_default", "__Internal")]
	fz_alloc_context fz_alloc_default { get; }

	// extern fz_locks_context fz_locks_default;
	[Field ("fz_locks_default", "__Internal")]
	fz_locks_context fz_locks_default { get; }
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const char * fz_draw_options_usage;
	[Field ("fz_draw_options_usage", "__Internal")]
	unsafe sbyte* fz_draw_options_usage { get; }
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern int fz_optind;
	[Field ("fz_optind", "__Internal")]
	int fz_optind { get; }

	// extern char * fz_optarg;
	[Field ("fz_optarg", "__Internal")]
	unsafe sbyte* fz_optarg { get; }
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const fz_rect fz_unit_rect;
	[Field ("fz_unit_rect", "__Internal")]
	fz_rect fz_unit_rect { get; }

	// extern const fz_rect fz_empty_rect;
	[Field ("fz_empty_rect", "__Internal")]
	fz_rect fz_empty_rect { get; }

	// extern const fz_irect fz_empty_irect;
	[Field ("fz_empty_irect", "__Internal")]
	fz_irect fz_empty_irect { get; }

	// extern const fz_rect fz_infinite_rect;
	[Field ("fz_infinite_rect", "__Internal")]
	fz_rect fz_infinite_rect { get; }

	// extern const fz_irect fz_infinite_irect;
	[Field ("fz_infinite_irect", "__Internal")]
	fz_irect fz_infinite_irect { get; }
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const fz_matrix fz_identity;
	[Field ("fz_identity", "__Internal")]
	fz_matrix fz_identity { get; }
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const fz_stroke_state fz_default_stroke_state;
	[Field ("fz_default_stroke_state", "__Internal")]
	fz_stroke_state fz_default_stroke_state { get; }
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const char * fz_stext_options_usage;
	[Field ("fz_stext_options_usage", "__Internal")]
	unsafe sbyte* fz_stext_options_usage { get; }
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const char * fz_cbz_write_options_usage;
	[Field ("fz_cbz_write_options_usage", "__Internal")]
	unsafe sbyte* fz_cbz_write_options_usage { get; }

	// extern const char * fz_png_write_options_usage;
	[Field ("fz_png_write_options_usage", "__Internal")]
	unsafe sbyte* fz_png_write_options_usage { get; }

	// extern const char * fz_pdf_write_options_usage;
	[Field ("fz_pdf_write_options_usage", "__Internal")]
	unsafe sbyte* fz_pdf_write_options_usage { get; }
}

// @interface MuAnnotation : NSObject
[BaseType (typeof(NSObject))]
interface MuAnnotation
{
	// -(instancetype)initFromAnnot:(fz_annot *)annot;
	[Export ("initFromAnnot:")]
	unsafe IntPtr Constructor (fz_annot* annot);

	// @property (readonly) int type;
	[Export ("type")]
	int Type { get; }

	// @property (readonly) CGRect rect;
	[Export ("rect")]
	CGRect Rect { get; }

	// +(MuAnnotation *)annotFromAnnot:(fz_annot *)annot;
	[Static]
	[Export ("annotFromAnnot:")]
	unsafe MuAnnotation AnnotFromAnnot (fz_annot* annot);
}

// @interface MuAnnotSelectView : UIView
[BaseType (typeof(UIView))]
interface MuAnnotSelectView
{
	// -(instancetype)initWithAnnot:(MuAnnotation *)_annot pageSize:(CGSize)_pageSize;
	[Export ("initWithAnnot:pageSize:")]
	IntPtr Constructor (MuAnnotation _annot, CGSize _pageSize);
}

// @interface MuDocRef : NSObject
[BaseType (typeof(NSObject))]
interface MuDocRef
{
	// -(instancetype)initWithFilename:(NSString *)aFilename;
	[Export ("initWithFilename:")]
	IntPtr Constructor (string aFilename);
}

// @interface MuLibraryController : UITableViewController <UIActionSheetDelegate>
[BaseType (typeof(UITableViewController))]
interface MuLibraryController : IUIActionSheetDelegate
{
	// -(void)openDocument:(NSString *)filename;
	[Export ("openDocument:")]
	void OpenDocument (string filename);

	// -(void)askForPassword:(NSString *)prompt;
	[Export ("askForPassword:")]
	void AskForPassword (string prompt);

	// -(void)onPasswordOkay;
	[Export ("onPasswordOkay")]
	void OnPasswordOkay ();

	// -(void)onPasswordCancel;
	[Export ("onPasswordCancel")]
	void OnPasswordCancel ();

	// -(void)reload;
	[Export ("reload")]
	void Reload ();
}

// @interface MuAppDelegate : NSObject <UIApplicationDelegate>
[BaseType (typeof(NSObject))]
interface MuAppDelegate : IUIApplicationDelegate
{
}

// @interface MuChoiceFieldController : UIViewController <UIPickerViewDataSource, UIPickerViewDelegate>
[BaseType (typeof(UIViewController))]
interface MuChoiceFieldController : IUIPickerViewDataSource, IUIPickerViewDelegate
{
	// -(instancetype)initWithChoices:(NSArray *)choices okayAction:(void (^)(NSArray *))block;
	[Export ("initWithChoices:okayAction:")]
	[Verify (StronglyTypedNSArray)]
	IntPtr Constructor (NSObject[] choices, Action<NSArray> block);
}

// @protocol MuDialogCreator <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MuDialogCreator
{
	// @required -(void)invokeTextDialog:(NSString *)aString okayAction:(void (^)(NSString *))block;
	[Abstract]
	[Export ("invokeTextDialog:okayAction:")]
	void InvokeTextDialog (string aString, Action<NSString> block);

	// @required -(void)invokeChoiceDialog:(NSArray *)anArray okayAction:(void (^)(NSArray *))block;
	[Abstract]
	[Export ("invokeChoiceDialog:okayAction:")]
	[Verify (StronglyTypedNSArray)]
	void InvokeChoiceDialog (NSObject[] anArray, Action<NSArray> block);
}

// @interface MuOutlineController : UITableViewController
[BaseType (typeof(UITableViewController))]
interface MuOutlineController
{
	// -(instancetype)initWithTarget:(id)aTarget titles:(NSMutableArray *)aTitles pages:(NSMutableArray *)aPages;
	[Export ("initWithTarget:titles:pages:")]
	IntPtr Constructor (NSObject aTarget, NSMutableArray aTitles, NSMutableArray aPages);
}

// @protocol MuUpdater <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MuUpdater
{
	// @required -(void)update;
	[Abstract]
	[Export ("update")]
	void Update ();
}

// @interface MuDocumentController : UIViewController <UIScrollViewDelegate, UIGestureRecognizerDelegate, UISearchBarDelegate, MuDialogCreator, MuUpdater>
[BaseType (typeof(UIViewController))]
interface MuDocumentController : IUIScrollViewDelegate, IUIGestureRecognizerDelegate, IUISearchBarDelegate, IMuDialogCreator, IMuUpdater
{
	// -(instancetype)initWithFilename:(NSString *)nsfilename path:(NSString *)path document:(MuDocRef *)aDoc;
	[Export ("initWithFilename:path:document:")]
	IntPtr Constructor (string nsfilename, string path, MuDocRef aDoc);

	// -(void)createPageView:(int)number;
	[Export ("createPageView:")]
	void CreatePageView (int number);

	// -(void)gotoPage:(int)number animated:(BOOL)animated;
	[Export ("gotoPage:animated:")]
	void GotoPage (int number, bool animated);

	// -(void)onShowOutline:(id)sender;
	[Export ("onShowOutline:")]
	void OnShowOutline (NSObject sender);

	// -(void)onShowSearch:(id)sender;
	[Export ("onShowSearch:")]
	void OnShowSearch (NSObject sender);

	// -(void)onCancel:(id)sender;
	[Export ("onCancel:")]
	void OnCancel (NSObject sender);

	// -(void)resetSearch;
	[Export ("resetSearch")]
	void ResetSearch ();

	// -(void)showSearchResults:(int)count forPage:(int)number;
	[Export ("showSearchResults:forPage:")]
	void ShowSearchResults (int count, int number);

	// -(void)onSlide:(id)sender;
	[Export ("onSlide:")]
	void OnSlide (NSObject sender);

	// -(void)onTap:(UITapGestureRecognizer *)sender;
	[Export ("onTap:")]
	void OnTap (UITapGestureRecognizer sender);

	// -(void)showNavigationBar;
	[Export ("showNavigationBar")]
	void ShowNavigationBar ();

	// -(void)hideNavigationBar;
	[Export ("hideNavigationBar")]
	void HideNavigationBar ();
}

// @interface MuTapResult : NSObject
[BaseType (typeof(NSObject))]
interface MuTapResult
{
	// -(void)switchCaseInternal:(void (^)(MuTapResultInternalLink *))internalLinkBlock caseExternal:(void (^)(MuTapResultExternalLink *))externalLinkBlock caseRemote:(void (^)(MuTapResultRemoteLink *))remoteLinkBlock caseWidget:(void (^)(MuTapResultWidget *))widgetBlock caseAnnotation:(void (^)(MuTapResultAnnotation *))annotationBlock;
	[Export ("switchCaseInternal:caseExternal:caseRemote:caseWidget:caseAnnotation:")]
	void SwitchCaseInternal (Action<MuTapResultInternalLink> internalLinkBlock, Action<MuTapResultExternalLink> externalLinkBlock, Action<MuTapResultRemoteLink> remoteLinkBlock, Action<MuTapResultWidget> widgetBlock, Action<MuTapResultAnnotation> annotationBlock);
}

// @interface MuTapResultInternalLink : MuTapResult
[BaseType (typeof(MuTapResult))]
interface MuTapResultInternalLink
{
	// @property (readonly) int pageNumber;
	[Export ("pageNumber")]
	int PageNumber { get; }

	// -(instancetype)initWithPageNumber:(int)aNumber;
	[Export ("initWithPageNumber:")]
	IntPtr Constructor (int aNumber);
}

// @interface MuTapResultExternalLink : MuTapResult
[BaseType (typeof(MuTapResult))]
interface MuTapResultExternalLink
{
	// @property (readonly) NSString * url;
	[Export ("url")]
	string Url { get; }

	// -(instancetype)initWithUrl:(NSString *)aString;
	[Export ("initWithUrl:")]
	IntPtr Constructor (string aString);
}

// @interface MuTapResultRemoteLink : MuTapResult
[BaseType (typeof(MuTapResult))]
interface MuTapResultRemoteLink
{
	// @property (readonly) NSString * fileSpec;
	[Export ("fileSpec")]
	string FileSpec { get; }

	// @property (readonly) int pageNumber;
	[Export ("pageNumber")]
	int PageNumber { get; }

	// @property (readonly) BOOL newWindow;
	[Export ("newWindow")]
	bool NewWindow { get; }

	// -(instancetype)initWithFileSpec:(NSString *)aString pageNumber:(int)aNumber newWindow:(BOOL)aBool;
	[Export ("initWithFileSpec:pageNumber:newWindow:")]
	IntPtr Constructor (string aString, int aNumber, bool aBool);
}

// @interface MuTapResultWidget : MuTapResult
[BaseType (typeof(MuTapResult))]
interface MuTapResultWidget
{
}

// @interface MuTapResultAnnotation : MuTapResult
[BaseType (typeof(MuTapResult))]
interface MuTapResultAnnotation
{
	// @property (readonly) MuAnnotation * annot;
	[Export ("annot")]
	MuAnnotation Annot { get; }

	// -(instancetype)initWithAnnotation:(MuAnnotation *)aAnnot;
	[Export ("initWithAnnotation:")]
	IntPtr Constructor (MuAnnotation aAnnot);
}

// @interface MuHitView : UIView
[BaseType (typeof(UIView))]
interface MuHitView
{
	// -(instancetype)initWithSearchResults:(int)n forDocument:(fz_document *)doc;
	[Export ("initWithSearchResults:forDocument:")]
	unsafe IntPtr Constructor (int n, fz_document* doc);

	// -(instancetype)initWithLinks:(fz_link *)links forDocument:(fz_document *)doc;
	[Export ("initWithLinks:forDocument:")]
	unsafe IntPtr Constructor (fz_link* links, fz_document* doc);

	// -(void)setPageSize:(CGSize)s;
	[Export ("setPageSize:")]
	void SetPageSize (CGSize s);

	// -(MuTapResult *)handleTap:(CGPoint)pt;
	[Export ("handleTap:")]
	MuTapResult HandleTap (CGPoint pt);
}

// @interface MuInkView : UIView
[BaseType (typeof(UIView))]
interface MuInkView
{
	// @property (readonly) NSArray * curves;
	[Export ("curves")]
	[Verify (StronglyTypedNSArray)]
	NSObject[] Curves { get; }

	// -(instancetype)initWithPageSize:(CGSize)pageSize;
	[Export ("initWithPageSize:")]
	IntPtr Constructor (CGSize pageSize);
}

// @protocol MuPageView
[Protocol, Model]
interface MuPageView
{
	// @required @property (readonly, nonatomic) int number;
	[Abstract]
	[Export ("number")]
	int Number { get; }

	// @required -(void)willRotate;
	[Abstract]
	[Export ("willRotate")]
	void WillRotate ();

	// @required -(void)showLinks;
	[Abstract]
	[Export ("showLinks")]
	void ShowLinks ();

	// @required -(void)hideLinks;
	[Abstract]
	[Export ("hideLinks")]
	void HideLinks ();

	// @required -(void)showSearchResults:(int)count;
	[Abstract]
	[Export ("showSearchResults:")]
	void ShowSearchResults (int count);

	// @required -(void)clearSearchResults;
	[Abstract]
	[Export ("clearSearchResults")]
	void ClearSearchResults ();

	// @required -(void)resetZoomAnimated:(BOOL)animated;
	[Abstract]
	[Export ("resetZoomAnimated:")]
	void ResetZoomAnimated (bool animated);

	// @required -(void)setScale:(float)scale;
	[Abstract]
	[Export ("setScale:")]
	void SetScale (float scale);

	// @required -(MuTapResult *)handleTap:(CGPoint)pt;
	[Abstract]
	[Export ("handleTap:")]
	MuTapResult HandleTap (CGPoint pt);

	// @required -(void)textSelectModeOn;
	[Abstract]
	[Export ("textSelectModeOn")]
	void TextSelectModeOn ();

	// @required -(void)textSelectModeOff;
	[Abstract]
	[Export ("textSelectModeOff")]
	void TextSelectModeOff ();

	// @required -(void)deselectAnnotation;
	[Abstract]
	[Export ("deselectAnnotation")]
	void DeselectAnnotation ();

	// @required -(void)deleteSelectedAnnotation;
	[Abstract]
	[Export ("deleteSelectedAnnotation")]
	void DeleteSelectedAnnotation ();

	// @required -(void)inkModeOn;
	[Abstract]
	[Export ("inkModeOn")]
	void InkModeOn ();

	// @required -(void)inkModeOff;
	[Abstract]
	[Export ("inkModeOff")]
	void InkModeOff ();

	// @required -(void)saveSelectionAsMarkup:(int)type;
	[Abstract]
	[Export ("saveSelectionAsMarkup:")]
	void SaveSelectionAsMarkup (int type);

	// @required -(void)saveInk;
	[Abstract]
	[Export ("saveInk")]
	void SaveInk ();

	// @required -(void)update;
	[Abstract]
	[Export ("update")]
	void Update ();
}

// @interface MuTextSelectView : UIView
[BaseType (typeof(UIView))]
interface MuTextSelectView
{
	// -(instancetype)initWithWords:(NSArray *)_words pageSize:(CGSize)_pageSize;
	[Export ("initWithWords:pageSize:")]
	[Verify (StronglyTypedNSArray)]
	IntPtr Constructor (NSObject[] _words, CGSize _pageSize);

	// @property (readonly, copy, nonatomic) NSArray * selectionRects;
	[Export ("selectionRects", ArgumentSemantic.Copy)]
	[Verify (StronglyTypedNSArray)]
	NSObject[] SelectionRects { get; }

	// @property (readonly, copy, nonatomic) NSString * selectedText;
	[Export ("selectedText")]
	string SelectedText { get; }
}

// @interface MuPageViewNormal : UIScrollView <UIScrollViewDelegate, MuPageView>
[BaseType (typeof(UIScrollView))]
interface MuPageViewNormal : IUIScrollViewDelegate, IMuPageView
{
	// -(instancetype)initWithFrame:(CGRect)frame dialogCreator:(id<MuDialogCreator>)dia updater:(id<MuUpdater>)upd document:(MuDocRef *)aDoc page:(int)aNumber;
	[Export ("initWithFrame:dialogCreator:updater:document:page:")]
	IntPtr Constructor (CGRect frame, MuDialogCreator dia, MuUpdater upd, MuDocRef aDoc, int aNumber);

	// -(void)displayImage:(UIImage *)image;
	[Export ("displayImage:")]
	void DisplayImage (UIImage image);

	// -(void)resizeImage;
	[Export ("resizeImage")]
	void ResizeImage ();

	// -(void)loadPage;
	[Export ("loadPage")]
	void LoadPage ();

	// -(void)loadTile;
	[Export ("loadTile")]
	void LoadTile ();
}

// @interface MuPageViewReflow : UIWebView <UIWebViewDelegate, MuPageView>
[BaseType (typeof(UIWebView))]
interface MuPageViewReflow : IUIWebViewDelegate, IMuPageView
{
	// -(instancetype)initWithFrame:(CGRect)frame document:(MuDocRef *)aDoc page:(int)aNumber;
	[Export ("initWithFrame:document:page:")]
	IntPtr Constructor (CGRect frame, MuDocRef aDoc, int aNumber);
}

// @interface MuPrintPageRenderer : UIPrintPageRenderer
[BaseType (typeof(UIPrintPageRenderer))]
interface MuPrintPageRenderer
{
	// -(instancetype)initWithDocRef:(MuDocRef *)docRef;
	[Export ("initWithDocRef:")]
	IntPtr Constructor (MuDocRef docRef);
}

// @interface MuTextFieldController : UIViewController
[BaseType (typeof(UIViewController))]
interface MuTextFieldController
{
	// -(instancetype)initWithText:(NSString *)text okayAction:(void (^)(NSString *))block;
	[Export ("initWithText:okayAction:")]
	IntPtr Constructor (string text, Action<NSString> block);
}

// @interface MuWord : NSObject
[BaseType (typeof(NSObject))]
interface MuWord
{
	// @property (retain) NSString * string;
	[Export ("string", ArgumentSemantic.Retain)]
	string String { get; set; }

	// @property (assign) CGRect rect;
	[Export ("rect", ArgumentSemantic.Assign)]
	CGRect Rect { get; set; }

	// +(MuWord *)word;
	[Static]
	[Export ("word")]
	[Verify (MethodToProperty)]
	MuWord Word { get; }

	// -(void)appendChar:(unichar)c withRect:(CGRect)rect;
	[Export ("appendChar:withRect:")]
	void AppendChar (ushort c, CGRect rect);

	// +(void)selectFrom:(CGPoint)pt1 to:(CGPoint)pt2 fromWords:(NSArray *)words onStartLine:(void (^)(void))startBlock onWord:(void (^)(MuWord *))wordBlock onEndLine:(void (^)(void))endBLock;
	[Static]
	[Export ("selectFrom:to:fromWords:onStartLine:onWord:onEndLine:")]
	[Verify (StronglyTypedNSArray)]
	void SelectFrom (CGPoint pt1, CGPoint pt2, NSObject[] words, Action startBlock, Action<MuWord> wordBlock, Action endBLock);
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const unsigned short [256] pdf_doc_encoding;
	[Field ("pdf_doc_encoding", "__Internal")]
	ushort[] pdf_doc_encoding { get; }

	// extern const char *const [256] pdf_mac_roman;
	[Field ("pdf_mac_roman", "__Internal")]
	unsafe sbyte*[] pdf_mac_roman { get; }

	// extern const char *const [256] pdf_mac_expert;
	[Field ("pdf_mac_expert", "__Internal")]
	unsafe sbyte*[] pdf_mac_expert { get; }

	// extern const char *const [256] pdf_win_ansi;
	[Field ("pdf_win_ansi", "__Internal")]
	unsafe sbyte*[] pdf_win_ansi { get; }

	// extern const char *const [256] pdf_standard;
	[Field ("pdf_standard", "__Internal")]
	unsafe sbyte*[] pdf_standard { get; }
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern double mupdfVersionNumber;
	[Field ("mupdfVersionNumber", "__Internal")]
	double mupdfVersionNumber { get; }

	// extern const unsigned char [] mupdfVersionString;
	[Field ("mupdfVersionString", "__Internal")]
	byte[] mupdfVersionString { get; }
}
