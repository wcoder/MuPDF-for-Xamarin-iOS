using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using mupdf;

static class CFunctions
{
	// extern CGSize fitPageToScreen (CGSize page, CGSize screen);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern CGSize fitPageToScreen (CGSize page, CGSize screen);

	// extern int search_page (int *doc, int number, char *needle, int *cookie);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int search_page (int* doc, int number, sbyte* needle, int* cookie);

	// extern int search_result_bbox (int *doc, int i);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int search_result_bbox (int* doc, int i);

	// extern CGDataProviderRef CreateWrappedPixmap (int *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe CGDataProviderRef* CreateWrappedPixmap (int* pix);

	// extern CGImageRef CreateCGImageWithPixmap (int *pix, CGDataProviderRef cgdata);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe CGImageRef* CreateCGImageWithPixmap (int* pix, CGDataProviderRef* cgdata);

	// extern void * fz_new_annot (int *ctx, int size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_new_annot (int* ctx, int size);

	// extern int * fz_keep_annot (int *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_keep_annot (int* ctx, int* annot);

	// extern void fz_drop_annot (int *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_annot (int* ctx, int* annot);

	// extern int * fz_first_annot (int *ctx, int *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_first_annot (int* ctx, int* page);

	// extern int * fz_next_annot (int *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_next_annot (int* ctx, int* annot);

	// extern int * fz_bound_annot (int *ctx, int *annot, int *rect);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_bound_annot (int* ctx, int* annot, int* rect);

	// extern fz_archive * fz_new_archive_of_size (int *ctx, int *file, int size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_archive* fz_new_archive_of_size (int* ctx, int* file, int size);

	// extern fz_archive * fz_open_archive (int *ctx, const char *filename);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_archive* fz_open_archive (int* ctx, sbyte* filename);

	// extern fz_archive * fz_open_archive_with_stream (int *ctx, int *file);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_archive* fz_open_archive_with_stream (int* ctx, int* file);

	// extern fz_archive * fz_open_directory (int *ctx, const char *path);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_archive* fz_open_directory (int* ctx, sbyte* path);

	// extern void fz_drop_archive (int *ctx, fz_archive *arch);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_archive (int* ctx, fz_archive* arch);

	// extern const char * fz_archive_format (int *ctx, fz_archive *arch);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_archive_format (int* ctx, fz_archive* arch);

	// extern int fz_count_archive_entries (int *ctx, fz_archive *arch);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_count_archive_entries (int* ctx, fz_archive* arch);

	// extern const char * fz_list_archive_entry (int *ctx, fz_archive *arch, int idx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_list_archive_entry (int* ctx, fz_archive* arch, int idx);

	// extern int fz_has_archive_entry (int *ctx, fz_archive *arch, const char *name);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_has_archive_entry (int* ctx, fz_archive* arch, sbyte* name);

	// extern int * fz_open_archive_entry (int *ctx, fz_archive *arch, const char *name);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_archive_entry (int* ctx, fz_archive* arch, sbyte* name);

	// extern int * fz_read_archive_entry (int *ctx, fz_archive *arch, const char *name);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_read_archive_entry (int* ctx, fz_archive* arch, sbyte* name);

	// extern int fz_is_tar_archive (int *ctx, int *file);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_is_tar_archive (int* ctx, int* file);

	// extern fz_archive * fz_open_tar_archive (int *ctx, const char *filename);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_archive* fz_open_tar_archive (int* ctx, sbyte* filename);

	// extern fz_archive * fz_open_tar_archive_with_stream (int *ctx, int *file);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_archive* fz_open_tar_archive_with_stream (int* ctx, int* file);

	// extern int fz_is_zip_archive (int *ctx, int *file);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_is_zip_archive (int* ctx, int* file);

	// extern fz_archive * fz_open_zip_archive (int *ctx, const char *path);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_archive* fz_open_zip_archive (int* ctx, sbyte* path);

	// extern fz_archive * fz_open_zip_archive_with_stream (int *ctx, int *file);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_archive* fz_open_zip_archive_with_stream (int* ctx, int* file);

	// extern fz_zip_writer * fz_new_zip_writer (int *ctx, const char *filename);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_zip_writer* fz_new_zip_writer (int* ctx, sbyte* filename);

	// extern void fz_write_zip_entry (int *ctx, fz_zip_writer *zip, const char *name, int *buf, int compress);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_zip_entry (int* ctx, fz_zip_writer* zip, sbyte* name, int* buf, int compress);

	// extern void fz_close_zip_writer (int *ctx, fz_zip_writer *zip);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_close_zip_writer (int* ctx, fz_zip_writer* zip);

	// extern void fz_drop_zip_writer (int *ctx, fz_zip_writer *zip);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_zip_writer (int* ctx, fz_zip_writer* zip);

	// extern void fz_bidi_fragment_text (int *ctx, const uint32_t *text, size_t textlen, fz_bidi_direction *baseDir, fz_bidi_fragment_callback *callback, void *arg, int flags);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_bidi_fragment_text (int* ctx, uint* text, nuint textlen, fz_bidi_direction* baseDir, fz_bidi_fragment_callback* callback, void* arg, int flags);

	// extern fz_bitmap * fz_keep_bitmap (int *ctx, fz_bitmap *bit);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_bitmap* fz_keep_bitmap (int* ctx, fz_bitmap* bit);

	// extern void fz_drop_bitmap (int *ctx, fz_bitmap *bit);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_bitmap (int* ctx, fz_bitmap* bit);

	// extern fz_bitmap * fz_new_bitmap_from_pixmap (int *ctx, int *pix, fz_halftone *ht);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_bitmap* fz_new_bitmap_from_pixmap (int* ctx, int* pix, fz_halftone* ht);

	// extern fz_bitmap * fz_new_bitmap_from_pixmap_band (int *ctx, int *pix, fz_halftone *ht, int band_start);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_bitmap* fz_new_bitmap_from_pixmap_band (int* ctx, int* pix, fz_halftone* ht, int band_start);

	// extern fz_bitmap * fz_new_bitmap (int *ctx, int w, int h, int n, int xres, int yres);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_bitmap* fz_new_bitmap (int* ctx, int w, int h, int n, int xres, int yres);

	// extern void fz_bitmap_details (fz_bitmap *bitmap, int *w, int *h, int *n, int *stride);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_bitmap_details (fz_bitmap* bitmap, int* w, int* h, int* n, int* stride);

	// extern void fz_clear_bitmap (int *ctx, fz_bitmap *bit);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_clear_bitmap (int* ctx, fz_bitmap* bit);

	// extern fz_halftone * fz_default_halftone (int *ctx, int num_comps);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_halftone* fz_default_halftone (int* ctx, int num_comps);

	// extern fz_halftone * fz_keep_halftone (int *ctx, fz_halftone *half);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_halftone* fz_keep_halftone (int* ctx, fz_halftone* half);

	// extern void fz_drop_halftone (int *ctx, fz_halftone *ht);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_halftone (int* ctx, fz_halftone* ht);

	// extern fz_buffer * fz_keep_buffer (int *ctx, fz_buffer *buf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* fz_keep_buffer (int* ctx, fz_buffer* buf);

	// extern void fz_drop_buffer (int *ctx, fz_buffer *buf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_buffer (int* ctx, fz_buffer* buf);

	// extern size_t fz_buffer_storage (int *ctx, fz_buffer *buf, unsigned char **data);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint fz_buffer_storage (int* ctx, fz_buffer* buf, byte** data);

	// extern const char * fz_string_from_buffer (int *ctx, fz_buffer *buf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_string_from_buffer (int* ctx, fz_buffer* buf);

	// extern fz_buffer * fz_new_buffer (int *ctx, size_t capacity);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* fz_new_buffer (int* ctx, nuint capacity);

	// extern fz_buffer * fz_new_buffer_from_data (int *ctx, unsigned char *data, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* fz_new_buffer_from_data (int* ctx, byte* data, nuint size);

	// extern fz_buffer * fz_new_buffer_from_shared_data (int *ctx, const char *data, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* fz_new_buffer_from_shared_data (int* ctx, sbyte* data, nuint size);

	// extern fz_buffer * fz_new_buffer_from_base64 (int *ctx, const char *data, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* fz_new_buffer_from_base64 (int* ctx, sbyte* data, nuint size);

	// extern void fz_resize_buffer (int *ctx, fz_buffer *buf, size_t capacity);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_resize_buffer (int* ctx, fz_buffer* buf, nuint capacity);

	// extern void fz_grow_buffer (int *ctx, fz_buffer *buf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_grow_buffer (int* ctx, fz_buffer* buf);

	// extern void fz_trim_buffer (int *ctx, fz_buffer *buf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_trim_buffer (int* ctx, fz_buffer* buf);

	// extern void fz_append_buffer (int *ctx, fz_buffer *buf, fz_buffer *extra);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_append_buffer (int* ctx, fz_buffer* buf, fz_buffer* extra);

	// extern void fz_write_buffer (int *ctx, fz_buffer *buf, const void *data, size_t len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_buffer (int* ctx, fz_buffer* buf, void* data, nuint len);

	// extern void fz_write_buffer_byte (int *ctx, fz_buffer *buf, int val);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_buffer_byte (int* ctx, fz_buffer* buf, int val);

	// extern void fz_write_buffer_rune (int *ctx, fz_buffer *buf, int val);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_buffer_rune (int* ctx, fz_buffer* buf, int val);

	// extern void fz_write_buffer_int32_le (int *ctx, fz_buffer *buf, int x);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_buffer_int32_le (int* ctx, fz_buffer* buf, int x);

	// extern void fz_write_buffer_int16_le (int *ctx, fz_buffer *buf, int x);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_buffer_int16_le (int* ctx, fz_buffer* buf, int x);

	// extern void fz_write_buffer_bits (int *ctx, fz_buffer *buf, int val, int bits);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_buffer_bits (int* ctx, fz_buffer* buf, int val, int bits);

	// extern void fz_write_buffer_pad (int *ctx, fz_buffer *buf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_buffer_pad (int* ctx, fz_buffer* buf);

	// extern size_t fz_buffer_printf (int *ctx, fz_buffer *buffer, const char *fmt, ...);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint fz_buffer_printf (int* ctx, fz_buffer* buffer, sbyte* fmt, IntPtr varArgs);

	// extern size_t fz_buffer_vprintf (int *ctx, fz_buffer *buffer, const char *fmt, va_list args);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint fz_buffer_vprintf (int* ctx, fz_buffer* buffer, sbyte* fmt, sbyte* args);

	// extern void fz_buffer_print_pdf_string (int *ctx, fz_buffer *buffer, const char *text);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_buffer_print_pdf_string (int* ctx, fz_buffer* buffer, sbyte* text);

	// extern void fz_md5_buffer (int *ctx, fz_buffer *buffer, unsigned char *digest);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_md5_buffer (int* ctx, fz_buffer* buffer, byte[] digest);

	// extern size_t fz_buffer_extract (int *ctx, fz_buffer *buf, unsigned char **data);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint fz_buffer_extract (int* ctx, fz_buffer* buf, byte** data);

	// extern int fz_colorspace_is_indexed (int *ctx, fz_colorspace *cs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_colorspace_is_indexed (int* ctx, fz_colorspace* cs);

	// extern int fz_colorspace_is_lab (int *ctx, fz_colorspace *cs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_colorspace_is_lab (int* ctx, fz_colorspace* cs);

	// extern fz_colorspace * fz_device_gray (int *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_colorspace* fz_device_gray (int* ctx);

	// extern fz_colorspace * fz_device_rgb (int *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_colorspace* fz_device_rgb (int* ctx);

	// extern fz_colorspace * fz_device_bgr (int *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_colorspace* fz_device_bgr (int* ctx);

	// extern fz_colorspace * fz_device_cmyk (int *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_colorspace* fz_device_cmyk (int* ctx);

	// extern fz_colorspace * fz_device_lab (int *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_colorspace* fz_device_lab (int* ctx);

	// extern void fz_set_device_gray (int *ctx, fz_colorspace *cs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_device_gray (int* ctx, fz_colorspace* cs);

	// extern void fz_set_device_rgb (int *ctx, fz_colorspace *cs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_device_rgb (int* ctx, fz_colorspace* cs);

	// extern void fz_set_device_bgr (int *ctx, fz_colorspace *cs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_device_bgr (int* ctx, fz_colorspace* cs);

	// extern void fz_set_device_cmyk (int *ctx, fz_colorspace *cs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_device_cmyk (int* ctx, fz_colorspace* cs);

	// extern fz_colorspace * fz_new_colorspace (int *ctx, char *name, int n, fz_colorspace_convert_fn *to_rgb, fz_colorspace_convert_fn *from_rgb, fz_colorspace_destruct_fn *destruct, void *data, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_colorspace* fz_new_colorspace (int* ctx, sbyte* name, int n, fz_colorspace_convert_fn* to_rgb, fz_colorspace_convert_fn* from_rgb, fz_colorspace_destruct_fn* destruct, void* data, nuint size);

	// extern fz_colorspace * fz_new_indexed_colorspace (int *ctx, fz_colorspace *base, int high, unsigned char *lookup);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_colorspace* fz_new_indexed_colorspace (int* ctx, fz_colorspace* @base, int high, byte* lookup);

	// extern fz_colorspace * fz_keep_colorspace (int *ctx, fz_colorspace *colorspace);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_colorspace* fz_keep_colorspace (int* ctx, fz_colorspace* colorspace);

	// extern void fz_drop_colorspace (int *ctx, fz_colorspace *colorspace);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_colorspace (int* ctx, fz_colorspace* colorspace);

	// extern void fz_drop_colorspace_imp (int *ctx, int *colorspace);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_colorspace_imp (int* ctx, int* colorspace);

	// extern int fz_colorspace_is (int *ctx, const fz_colorspace *cs, fz_colorspace_convert_fn *to_rgb);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_colorspace_is (int* ctx, fz_colorspace* cs, fz_colorspace_convert_fn* to_rgb);

	// extern int fz_colorspace_n (int *ctx, const fz_colorspace *cs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_colorspace_n (int* ctx, fz_colorspace* cs);

	// extern const char * fz_colorspace_name (int *ctx, const fz_colorspace *cs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_colorspace_name (int* ctx, fz_colorspace* cs);

	// extern void fz_convert_color (int *ctx, fz_colorspace *dsts, float *dstv, fz_colorspace *srcs, const float *srcv);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_convert_color (int* ctx, fz_colorspace* dsts, float* dstv, fz_colorspace* srcs, float* srcv);

	// extern void fz_lookup_color_converter (int *ctx, fz_color_converter *cc, fz_colorspace *ds, fz_colorspace *ss);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_lookup_color_converter (int* ctx, fz_color_converter* cc, fz_colorspace* ds, fz_colorspace* ss);

	// extern void fz_init_cached_color_converter (int *ctx, fz_color_converter *cc, fz_colorspace *ds, fz_colorspace *ss);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_init_cached_color_converter (int* ctx, fz_color_converter* cc, fz_colorspace* ds, fz_colorspace* ss);

	// extern void fz_fin_cached_color_converter (int *ctx, fz_color_converter *cc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_fin_cached_color_converter (int* ctx, fz_color_converter* cc);

	// extern size_t fz_compressed_buffer_size (fz_compressed_buffer *buffer);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint fz_compressed_buffer_size (fz_compressed_buffer* buffer);

	// extern int * fz_open_compressed_buffer (int *ctx, fz_compressed_buffer *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_compressed_buffer (int* ctx, fz_compressed_buffer*);

	// extern int * fz_open_image_decomp_stream_from_buffer (int *ctx, fz_compressed_buffer *, int *l2factor);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_image_decomp_stream_from_buffer (int* ctx, fz_compressed_buffer*, int* l2factor);

	// extern int * fz_open_image_decomp_stream (int *ctx, int *, fz_compression_params *, int *l2factor);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_image_decomp_stream (int* ctx, int*, fz_compression_params*, int* l2factor);

	// extern void fz_drop_compressed_buffer (int *ctx, fz_compressed_buffer *buf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_compressed_buffer (int* ctx, fz_compressed_buffer* buf);

	// extern void fz_var_imp (void *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_var_imp (void*);

	// extern int fz_push_try (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_push_try (fz_context* ctx);

	// extern void fz_vwarn (fz_context *ctx, const char *fmt, va_list ap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_vwarn (fz_context* ctx, sbyte* fmt, sbyte* ap);

	// extern void fz_warn (fz_context *ctx, const char *fmt, ...) __attribute__((format(printf, 2, 3)));
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_warn (fz_context* ctx, sbyte* fmt, IntPtr varArgs);

	// extern const char * fz_caught_message (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_caught_message (fz_context* ctx);

	// extern int fz_caught (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_caught (fz_context* ctx);

	// extern void fz_rethrow_if (fz_context *ctx, int errcode);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_rethrow_if (fz_context* ctx, int errcode);

	// extern void fz_flush_warnings (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_flush_warnings (fz_context* ctx);

	// extern fz_context * fz_new_context_imp (const fz_alloc_context *alloc, const fz_locks_context *locks, size_t max_store, const char *version);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_context* fz_new_context_imp (fz_alloc_context* alloc, fz_locks_context* locks, nuint max_store, sbyte* version);

	// extern fz_context * fz_clone_context (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_context* fz_clone_context (fz_context* ctx);

	// extern void fz_drop_context (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_context (fz_context* ctx);

	// extern void fz_set_user_context (fz_context *ctx, void *user);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_user_context (fz_context* ctx, void* user);

	// extern void * fz_user_context (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_user_context (fz_context* ctx);

	// extern void fz_tune_image_decode (fz_context *ctx, fz_tune_image_decode_fn *image_decode, void *arg);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_tune_image_decode (fz_context* ctx, fz_tune_image_decode_fn* image_decode, void* arg);

	// extern void fz_tune_image_scale (fz_context *ctx, fz_tune_image_scale_fn *image_scale, void *arg);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_tune_image_scale (fz_context* ctx, fz_tune_image_scale_fn* image_scale, void* arg);

	// extern int fz_aa_level (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_aa_level (fz_context* ctx);

	// extern void fz_set_aa_level (fz_context *ctx, int bits);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_aa_level (fz_context* ctx, int bits);

	// extern int fz_text_aa_level (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_text_aa_level (fz_context* ctx);

	// extern void fz_set_text_aa_level (fz_context *ctx, int bits);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_text_aa_level (fz_context* ctx, int bits);

	// extern int fz_graphics_aa_level (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_graphics_aa_level (fz_context* ctx);

	// extern void fz_set_graphics_aa_level (fz_context *ctx, int bits);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_graphics_aa_level (fz_context* ctx, int bits);

	// extern float fz_graphics_min_line_width (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe float fz_graphics_min_line_width (fz_context* ctx);

	// extern void fz_set_graphics_min_line_width (fz_context *ctx, float min_line_width);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_graphics_min_line_width (fz_context* ctx, float min_line_width);

	// extern const char * fz_user_css (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_user_css (fz_context* ctx);

	// extern void fz_set_user_css (fz_context *ctx, const char *text);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_user_css (fz_context* ctx, sbyte* text);

	// extern void * fz_malloc (fz_context *ctx, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_malloc (fz_context* ctx, nuint size);

	// extern void * fz_calloc (fz_context *ctx, size_t count, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_calloc (fz_context* ctx, nuint count, nuint size);

	// extern void * fz_malloc_array (fz_context *ctx, size_t count, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_malloc_array (fz_context* ctx, nuint count, nuint size);

	// extern void * fz_resize_array (fz_context *ctx, void *p, size_t count, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_resize_array (fz_context* ctx, void* p, nuint count, nuint size);

	// extern char * fz_strdup (fz_context *ctx, const char *s);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_strdup (fz_context* ctx, sbyte* s);

	// extern void fz_free (fz_context *ctx, void *p);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_free (fz_context* ctx, void* p);

	// extern void * fz_malloc_no_throw (fz_context *ctx, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_malloc_no_throw (fz_context* ctx, nuint size);

	// extern void * fz_calloc_no_throw (fz_context *ctx, size_t count, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_calloc_no_throw (fz_context* ctx, nuint count, nuint size);

	// extern void * fz_malloc_array_no_throw (fz_context *ctx, size_t count, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_malloc_array_no_throw (fz_context* ctx, nuint count, nuint size);

	// extern void * fz_resize_array_no_throw (fz_context *ctx, void *p, size_t count, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_resize_array_no_throw (fz_context* ctx, void* p, nuint count, nuint size);

	// extern char * fz_strdup_no_throw (fz_context *ctx, const char *s);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_strdup_no_throw (fz_context* ctx, sbyte* s);

	// extern int fz_gen_id (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_gen_id (fz_context* ctx);

	// void fz_lock (fz_context *ctx, int lock);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_lock (fz_context* ctx, int @lock);

	// void fz_unlock (fz_context *ctx, int lock);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_unlock (fz_context* ctx, int @lock);

	// void * fz_keep_imp (fz_context *ctx, void *p, int *refs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_keep_imp (fz_context* ctx, void* p, int* refs);

	// extern int Memento_takeRef ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int Memento_takeRef ();

	// void * fz_keep_imp8 (fz_context *ctx, void *p, int8_t *refs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_keep_imp8 (fz_context* ctx, void* p, sbyte* refs);

	// void * fz_keep_imp16 (fz_context *ctx, void *p, int16_t *refs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_keep_imp16 (fz_context* ctx, void* p, short* refs);

	// int fz_drop_imp (fz_context *ctx, void *p, int *refs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_drop_imp (fz_context* ctx, void* p, int* refs);

	// extern int Memento_dropRef ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int Memento_dropRef ();

	// int fz_drop_imp8 (fz_context *ctx, void *p, int8_t *refs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_drop_imp8 (fz_context* ctx, void* p, sbyte* refs);

	// int fz_drop_imp16 (fz_context *ctx, void *p, int16_t *refs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_drop_imp16 (fz_context* ctx, void* p, short* refs);

	// extern void fz_md5_init (fz_md5 *state);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_md5_init (fz_md5* state);

	// extern void fz_md5_update (fz_md5 *state, const unsigned char *input, size_t inlen);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_md5_update (fz_md5* state, byte* input, nuint inlen);

	// extern void fz_md5_final (fz_md5 *state, unsigned char *digest);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_md5_final (fz_md5* state, byte[] digest);

	// extern void fz_sha256_init (fz_sha256 *state);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_sha256_init (fz_sha256* state);

	// extern void fz_sha256_update (fz_sha256 *state, const unsigned char *input, size_t inlen);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_sha256_update (fz_sha256* state, byte* input, nuint inlen);

	// extern void fz_sha256_final (fz_sha256 *state, unsigned char *digest);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_sha256_final (fz_sha256* state, byte[] digest);

	// extern void fz_sha512_init (fz_sha512 *state);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_sha512_init (fz_sha512* state);

	// extern void fz_sha512_update (fz_sha512 *state, const unsigned char *input, size_t inlen);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_sha512_update (fz_sha512* state, byte* input, nuint inlen);

	// extern void fz_sha512_final (fz_sha512 *state, unsigned char *digest);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_sha512_final (fz_sha512* state, byte[] digest);

	// extern void fz_sha384_init (fz_sha384 *state);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_sha384_init (fz_sha384* state);

	// extern void fz_sha384_update (fz_sha384 *state, const unsigned char *input, size_t inlen);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_sha384_update (fz_sha384* state, byte* input, nuint inlen);

	// extern void fz_sha384_final (fz_sha384 *state, unsigned char *digest);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_sha384_final (fz_sha384* state, byte[] digest);

	// extern void fz_arc4_init (fz_arc4 *state, const unsigned char *key, size_t len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_arc4_init (fz_arc4* state, byte* key, nuint len);

	// extern void fz_arc4_encrypt (fz_arc4 *state, unsigned char *dest, const unsigned char *src, size_t len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_arc4_encrypt (fz_arc4* state, byte* dest, byte* src, nuint len);

	// extern int aes_setkey_enc (fz_aes *ctx, const unsigned char *key, int keysize);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int aes_setkey_enc (fz_aes* ctx, byte* key, int keysize);

	// extern int aes_setkey_dec (fz_aes *ctx, const unsigned char *key, int keysize);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int aes_setkey_dec (fz_aes* ctx, byte* key, int keysize);

	// extern void aes_crypt_cbc (fz_aes *ctx, int mode, size_t length, unsigned char *iv, const unsigned char *input, unsigned char *output);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void aes_crypt_cbc (fz_aes* ctx, int mode, nuint length, byte[] iv, byte* input, byte* output);

	// extern int fz_lookup_blendmode (const char *name);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_lookup_blendmode (sbyte* name);

	// extern char * fz_blendmode_name (int blendmode);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_blendmode_name (int blendmode);

	// extern void fz_fill_path (fz_context *ctx, fz_device *dev, const int *path, int even_odd, const int *ctm, fz_colorspace *colorspace, const float *color, float alpha);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_fill_path (fz_context* ctx, fz_device* dev, int* path, int even_odd, int* ctm, fz_colorspace* colorspace, float* color, float alpha);

	// extern void fz_stroke_path (fz_context *ctx, fz_device *dev, const int *path, const int *stroke, const int *ctm, fz_colorspace *colorspace, const float *color, float alpha);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_stroke_path (fz_context* ctx, fz_device* dev, int* path, int* stroke, int* ctm, fz_colorspace* colorspace, float* color, float alpha);

	// extern void fz_clip_path (fz_context *ctx, fz_device *dev, const int *path, int even_odd, const int *ctm, const int *scissor);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_clip_path (fz_context* ctx, fz_device* dev, int* path, int even_odd, int* ctm, int* scissor);

	// extern void fz_clip_stroke_path (fz_context *ctx, fz_device *dev, const int *path, const int *stroke, const int *ctm, const int *scissor);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_clip_stroke_path (fz_context* ctx, fz_device* dev, int* path, int* stroke, int* ctm, int* scissor);

	// extern void fz_fill_text (fz_context *ctx, fz_device *dev, const int *text, const int *ctm, fz_colorspace *colorspace, const float *color, float alpha);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_fill_text (fz_context* ctx, fz_device* dev, int* text, int* ctm, fz_colorspace* colorspace, float* color, float alpha);

	// extern void fz_stroke_text (fz_context *ctx, fz_device *dev, const int *text, const int *stroke, const int *ctm, fz_colorspace *colorspace, const float *color, float alpha);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_stroke_text (fz_context* ctx, fz_device* dev, int* text, int* stroke, int* ctm, fz_colorspace* colorspace, float* color, float alpha);

	// extern void fz_clip_text (fz_context *ctx, fz_device *dev, const int *text, const int *ctm, const int *scissor);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_clip_text (fz_context* ctx, fz_device* dev, int* text, int* ctm, int* scissor);

	// extern void fz_clip_stroke_text (fz_context *ctx, fz_device *dev, const int *text, const int *stroke, const int *ctm, const int *scissor);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_clip_stroke_text (fz_context* ctx, fz_device* dev, int* text, int* stroke, int* ctm, int* scissor);

	// extern void fz_ignore_text (fz_context *ctx, fz_device *dev, const int *text, const int *ctm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_ignore_text (fz_context* ctx, fz_device* dev, int* text, int* ctm);

	// extern void fz_pop_clip (fz_context *ctx, fz_device *dev);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_pop_clip (fz_context* ctx, fz_device* dev);

	// extern void fz_fill_shade (fz_context *ctx, fz_device *dev, int *shade, const int *ctm, float alpha);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_fill_shade (fz_context* ctx, fz_device* dev, int* shade, int* ctm, float alpha);

	// extern void fz_fill_image (fz_context *ctx, fz_device *dev, int *image, const int *ctm, float alpha);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_fill_image (fz_context* ctx, fz_device* dev, int* image, int* ctm, float alpha);

	// extern void fz_fill_image_mask (fz_context *ctx, fz_device *dev, int *image, const int *ctm, fz_colorspace *colorspace, const float *color, float alpha);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_fill_image_mask (fz_context* ctx, fz_device* dev, int* image, int* ctm, fz_colorspace* colorspace, float* color, float alpha);

	// extern void fz_clip_image_mask (fz_context *ctx, fz_device *dev, int *image, const int *ctm, const int *scissor);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_clip_image_mask (fz_context* ctx, fz_device* dev, int* image, int* ctm, int* scissor);

	// extern void fz_begin_mask (fz_context *ctx, fz_device *dev, const int *area, int luminosity, fz_colorspace *colorspace, const float *bc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_begin_mask (fz_context* ctx, fz_device* dev, int* area, int luminosity, fz_colorspace* colorspace, float* bc);

	// extern void fz_end_mask (fz_context *ctx, fz_device *dev);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_end_mask (fz_context* ctx, fz_device* dev);

	// extern void fz_begin_group (fz_context *ctx, fz_device *dev, const int *area, int isolated, int knockout, int blendmode, float alpha);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_begin_group (fz_context* ctx, fz_device* dev, int* area, int isolated, int knockout, int blendmode, float alpha);

	// extern void fz_end_group (fz_context *ctx, fz_device *dev);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_end_group (fz_context* ctx, fz_device* dev);

	// extern void fz_begin_tile (fz_context *ctx, fz_device *dev, const int *area, const int *view, float xstep, float ystep, const int *ctm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_begin_tile (fz_context* ctx, fz_device* dev, int* area, int* view, float xstep, float ystep, int* ctm);

	// extern int fz_begin_tile_id (fz_context *ctx, fz_device *dev, const int *area, const int *view, float xstep, float ystep, const int *ctm, int id);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_begin_tile_id (fz_context* ctx, fz_device* dev, int* area, int* view, float xstep, float ystep, int* ctm, int id);

	// extern void fz_end_tile (fz_context *ctx, fz_device *dev);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_end_tile (fz_context* ctx, fz_device* dev);

	// extern void fz_render_flags (fz_context *ctx, fz_device *dev, int set, int clear);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_render_flags (fz_context* ctx, fz_device* dev, int set, int clear);

	// extern void * fz_new_device (fz_context *ctx, int size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_new_device (fz_context* ctx, int size);

	// extern void fz_close_device (fz_context *ctx, fz_device *dev);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_close_device (fz_context* ctx, fz_device* dev);

	// extern void fz_drop_device (fz_context *ctx, fz_device *dev);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_device (fz_context* ctx, fz_device* dev);

	// extern fz_device * fz_keep_device (fz_context *ctx, fz_device *dev);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_device* fz_keep_device (fz_context* ctx, fz_device* dev);

	// extern void fz_enable_device_hints (fz_context *ctx, fz_device *dev, int hints);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_enable_device_hints (fz_context* ctx, fz_device* dev, int hints);

	// extern void fz_disable_device_hints (fz_context *ctx, fz_device *dev, int hints);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_disable_device_hints (fz_context* ctx, fz_device* dev, int hints);

	// extern fz_device * fz_new_trace_device (fz_context *ctx, int *out);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_device* fz_new_trace_device (fz_context* ctx, int* @out);

	// extern fz_device * fz_new_bbox_device (fz_context *ctx, int *rectp);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_device* fz_new_bbox_device (fz_context* ctx, int* rectp);

	// extern fz_device * fz_new_test_device (fz_context *ctx, int *is_color, float threshold, int options, fz_device *passthrough);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_device* fz_new_test_device (fz_context* ctx, int* is_color, float threshold, int options, fz_device* passthrough);

	// extern fz_device * fz_new_draw_device (fz_context *ctx, const int *transform, int *dest);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_device* fz_new_draw_device (fz_context* ctx, int* transform, int* dest);

	// extern fz_device * fz_new_draw_device_with_bbox (fz_context *ctx, const int *transform, int *dest, const int *clip);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_device* fz_new_draw_device_with_bbox (fz_context* ctx, int* transform, int* dest, int* clip);

	// extern fz_device * fz_new_draw_device_type3 (fz_context *ctx, const int *transform, int *dest);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_device* fz_new_draw_device_type3 (fz_context* ctx, int* transform, int* dest);

	// extern fz_draw_options * fz_parse_draw_options (fz_context *ctx, fz_draw_options *options, const char *string);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_draw_options* fz_parse_draw_options (fz_context* ctx, fz_draw_options* options, sbyte* @string);

	// extern fz_device * fz_new_draw_device_with_options (fz_context *ctx, const fz_draw_options *options, const int *mediabox, int **pixmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_device* fz_new_draw_device_with_options (fz_context* ctx, fz_draw_options* options, int* mediabox, int** pixmap);

	// extern fz_display_list * fz_new_display_list (fz_context *ctx, const int *mediabox);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_display_list* fz_new_display_list (fz_context* ctx, int* mediabox);

	// extern fz_device * fz_new_list_device (fz_context *ctx, fz_display_list *list);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_device* fz_new_list_device (fz_context* ctx, fz_display_list* list);

	// extern void fz_run_display_list (fz_context *ctx, fz_display_list *list, fz_device *dev, const int *ctm, const int *area, fz_cookie *cookie);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_run_display_list (fz_context* ctx, fz_display_list* list, fz_device* dev, int* ctm, int* area, fz_cookie* cookie);

	// extern fz_display_list * fz_keep_display_list (fz_context *ctx, fz_display_list *list);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_display_list* fz_keep_display_list (fz_context* ctx, fz_display_list* list);

	// extern void fz_drop_display_list (fz_context *ctx, fz_display_list *list);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_display_list (fz_context* ctx, fz_display_list* list);

	// extern int * fz_bound_display_list (fz_context *ctx, fz_display_list *list, int *bounds);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_bound_display_list (fz_context* ctx, fz_display_list* list, int* bounds);

	// extern int * fz_new_image_from_display_list (fz_context *ctx, float w, float h, fz_display_list *list);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_new_image_from_display_list (fz_context* ctx, float w, float h, fz_display_list* list);

	// extern int fz_display_list_is_empty (fz_context *ctx, const fz_display_list *list);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_display_list_is_empty (fz_context* ctx, fz_display_list* list);

	// extern void fz_register_document_handler (fz_context *ctx, const fz_document_handler *handler);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_register_document_handler (fz_context* ctx, fz_document_handler* handler);

	// extern void fz_register_document_handlers (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_register_document_handlers (fz_context* ctx);

	// extern fz_document * fz_open_document (fz_context *ctx, const char *filename);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_document* fz_open_document (fz_context* ctx, sbyte* filename);

	// extern fz_document * fz_open_document_with_stream (fz_context *ctx, const char *magic, int *stream);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_document* fz_open_document_with_stream (fz_context* ctx, sbyte* magic, int* stream);

	// extern void * fz_new_document_of_size (fz_context *ctx, int size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_new_document_of_size (fz_context* ctx, int size);

	// extern fz_document * fz_keep_document (fz_context *ctx, fz_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_document* fz_keep_document (fz_context* ctx, fz_document* doc);

	// extern void fz_drop_document (fz_context *ctx, fz_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_document (fz_context* ctx, fz_document* doc);

	// extern int fz_needs_password (fz_context *ctx, fz_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_needs_password (fz_context* ctx, fz_document* doc);

	// extern int fz_authenticate_password (fz_context *ctx, fz_document *doc, const char *password);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_authenticate_password (fz_context* ctx, fz_document* doc, sbyte* password);

	// extern int * fz_load_outline (fz_context *ctx, fz_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_load_outline (fz_context* ctx, fz_document* doc);

	// extern int fz_is_document_reflowable (fz_context *ctx, fz_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_is_document_reflowable (fz_context* ctx, fz_document* doc);

	// extern void fz_layout_document (fz_context *ctx, fz_document *doc, float w, float h, float em);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_layout_document (fz_context* ctx, fz_document* doc, float w, float h, float em);

	// extern int fz_count_pages (fz_context *ctx, fz_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_count_pages (fz_context* ctx, fz_document* doc);

	// extern int fz_resolve_link (fz_context *ctx, fz_document *doc, const char *uri, float *xp, float *yp);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_resolve_link (fz_context* ctx, fz_document* doc, sbyte* uri, float* xp, float* yp);

	// extern fz_page * fz_load_page (fz_context *ctx, fz_document *doc, int number);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_page* fz_load_page (fz_context* ctx, fz_document* doc, int number);

	// extern int * fz_load_links (fz_context *ctx, fz_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_load_links (fz_context* ctx, fz_page* page);

	// extern void * fz_new_page (fz_context *ctx, int size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_new_page (fz_context* ctx, int size);

	// extern int * fz_bound_page (fz_context *ctx, fz_page *page, int *rect);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_bound_page (fz_context* ctx, fz_page* page, int* rect);

	// extern void fz_run_page (fz_context *ctx, fz_page *page, fz_device *dev, const int *transform, fz_cookie *cookie);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_run_page (fz_context* ctx, fz_page* page, fz_device* dev, int* transform, fz_cookie* cookie);

	// extern void fz_run_page_contents (fz_context *ctx, fz_page *page, fz_device *dev, const int *transform, fz_cookie *cookie);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_run_page_contents (fz_context* ctx, fz_page* page, fz_device* dev, int* transform, fz_cookie* cookie);

	// extern void fz_run_annot (fz_context *ctx, fz_annot *annot, fz_device *dev, const int *transform, fz_cookie *cookie);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_run_annot (fz_context* ctx, fz_annot* annot, fz_device* dev, int* transform, fz_cookie* cookie);

	// extern fz_page * fz_keep_page (fz_context *ctx, fz_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_page* fz_keep_page (fz_context* ctx, fz_page* page);

	// extern void fz_drop_page (fz_context *ctx, fz_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_page (fz_context* ctx, fz_page* page);

	// extern void * fz_new_annot (fz_context *ctx, int size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_new_annot (fz_context* ctx, int size);

	// extern int * fz_page_presentation (fz_context *ctx, fz_page *page, int *transition, float *duration);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_page_presentation (fz_context* ctx, fz_page* page, int* transition, float* duration);

	// extern int fz_has_permission (fz_context *ctx, fz_document *doc, fz_permission p);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_has_permission (fz_context* ctx, fz_document* doc, fz_permission p);

	// extern int fz_lookup_metadata (fz_context *ctx, fz_document *doc, const char *key, char *buf, int size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_lookup_metadata (fz_context* ctx, fz_document* doc, sbyte* key, sbyte* buf, int size);

	// extern int fz_count_separations_on_page (fz_context *ctx, fz_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_count_separations_on_page (fz_context* ctx, fz_page* page);

	// extern void fz_control_separation_on_page (fz_context *ctx, fz_page *page, int sep, int disable);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_control_separation_on_page (fz_context* ctx, fz_page* page, int sep, int disable);

	// extern int fz_separation_disabled_on_page (fz_context *ctx, fz_page *, int sep);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_separation_disabled_on_page (fz_context* ctx, fz_page*, int sep);

	// extern const char * fz_get_separation_on_page (fz_context *ctx, fz_page *page, int sep, uint32_t *rgba, uint32_t *cmyk);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_get_separation_on_page (fz_context* ctx, fz_page* page, int sep, uint* rgba, uint* cmyk);

	// extern void fz_save_gproof (fz_context *ctx, const char *doc_filename, fz_document *doc, const char *filename, int res, const char *print_profile, const char *display_profile);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_save_gproof (fz_context* ctx, sbyte* doc_filename, fz_document* doc, sbyte* filename, int res, sbyte* print_profile, sbyte* display_profile);

	// extern int * fz_open_copy (fz_context *ctx, int *chain);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_copy (fz_context* ctx, int* chain);

	// extern int * fz_open_null (fz_context *ctx, int *chain, int len, int offset);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_null (fz_context* ctx, int* chain, int len, int offset);

	// extern int * fz_open_concat (fz_context *ctx, int max, int pad);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_concat (fz_context* ctx, int max, int pad);

	// extern void fz_concat_push (fz_context *ctx, int *concat, int *chain);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_concat_push (fz_context* ctx, int* concat, int* chain);

	// extern int * fz_open_arc4 (fz_context *ctx, int *chain, unsigned char *key, unsigned int keylen);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_arc4 (fz_context* ctx, int* chain, byte* key, uint keylen);

	// extern int * fz_open_aesd (fz_context *ctx, int *chain, unsigned char *key, unsigned int keylen);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_aesd (fz_context* ctx, int* chain, byte* key, uint keylen);

	// extern int * fz_open_a85d (fz_context *ctx, int *chain);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_a85d (fz_context* ctx, int* chain);

	// extern int * fz_open_ahxd (fz_context *ctx, int *chain);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_ahxd (fz_context* ctx, int* chain);

	// extern int * fz_open_rld (fz_context *ctx, int *chain);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_rld (fz_context* ctx, int* chain);

	// extern int * fz_open_dctd (fz_context *ctx, int *chain, int color_transform, int l2factor, int *jpegtables);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_dctd (fz_context* ctx, int* chain, int color_transform, int l2factor, int* jpegtables);

	// extern int * fz_open_faxd (fz_context *ctx, int *chain, int k, int end_of_line, int encoded_byte_align, int columns, int rows, int end_of_block, int black_is_1);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_faxd (fz_context* ctx, int* chain, int k, int end_of_line, int encoded_byte_align, int columns, int rows, int end_of_block, int black_is_1);

	// extern int * fz_open_flated (fz_context *ctx, int *chain, int window_bits);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_flated (fz_context* ctx, int* chain, int window_bits);

	// extern int * fz_open_lzwd (fz_context *ctx, int *chain, int early_change, int min_bits, int reverse_bits, int old_tiff);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_lzwd (fz_context* ctx, int* chain, int early_change, int min_bits, int reverse_bits, int old_tiff);

	// extern int * fz_open_predict (fz_context *ctx, int *chain, int predictor, int columns, int colors, int bpc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_predict (fz_context* ctx, int* chain, int predictor, int columns, int colors, int bpc);

	// extern int * fz_open_jbig2d (fz_context *ctx, int *chain, fz_jbig2_globals *globals);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_jbig2d (fz_context* ctx, int* chain, fz_jbig2_globals* globals);

	// extern fz_jbig2_globals * fz_load_jbig2_globals (fz_context *ctx, fz_buffer *buf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_jbig2_globals* fz_load_jbig2_globals (fz_context* ctx, fz_buffer* buf);

	// extern void fz_drop_jbig2_globals_imp (fz_context *ctx, int *globals);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_jbig2_globals_imp (fz_context* ctx, int* globals);

	// extern int * fz_open_sgilog16 (fz_context *ctx, int *chain, int w);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_sgilog16 (fz_context* ctx, int* chain, int w);

	// extern int * fz_open_sgilog24 (fz_context *ctx, int *chain, int w);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_sgilog24 (fz_context* ctx, int* chain, int w);

	// extern int * fz_open_sgilog32 (fz_context *ctx, int *chain, int w);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_sgilog32 (fz_context* ctx, int* chain, int w);

	// extern int * fz_open_thunder (fz_context *ctx, int *chain, int w);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_open_thunder (fz_context* ctx, int* chain, int w);

	// extern void * fz_font_ft_face (fz_context *ctx, fz_font *font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_font_ft_face (fz_context* ctx, fz_font* font);

	// extern fz_buffer ** fz_font_t3_procs (fz_context *ctx, fz_font *font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer** fz_font_t3_procs (fz_context* ctx, fz_font* font);

	// extern const char * ft_error_string (int err);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* ft_error_string (int err);

	// extern fz_font_flags_t * fz_font_flags (fz_font *font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_font_flags_t* fz_font_flags (fz_font* font);

	// extern fz_shaper_data_t * fz_font_shaper_data (fz_context *ctx, fz_font *font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_shaper_data_t* fz_font_shaper_data (fz_context* ctx, fz_font* font);

	// extern const char * fz_font_name (fz_context *ctx, fz_font *font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_font_name (fz_context* ctx, fz_font* font);

	// extern int * fz_font_bbox (fz_context *ctx, fz_font *font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_font_bbox (fz_context* ctx, fz_font* font);

	// extern void fz_install_load_system_font_funcs (fz_context *ctx, fz_load_system_font_func f, fz_load_system_cjk_font_func f_cjk);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_install_load_system_font_funcs (fz_context* ctx, fz_load_system_font_func* f, fz_load_system_cjk_font_func* f_cjk);

	// extern fz_font * fz_load_system_font (fz_context *ctx, const char *name, int bold, int italic, int needs_exact_metrics);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_font* fz_load_system_font (fz_context* ctx, sbyte* name, int bold, int italic, int needs_exact_metrics);

	// extern fz_font * fz_load_system_cjk_font (fz_context *ctx, const char *name, int ros, int serif);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_font* fz_load_system_cjk_font (fz_context* ctx, sbyte* name, int ros, int serif);

	// extern const char * fz_lookup_builtin_font (fz_context *ctx, const char *name, int bold, int italic, int *len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_lookup_builtin_font (fz_context* ctx, sbyte* name, int bold, int italic, int* len);

	// extern const char * fz_lookup_base14_font (fz_context *ctx, const char *name, int *len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_lookup_base14_font (fz_context* ctx, sbyte* name, int* len);

	// extern const char * fz_lookup_cjk_font (fz_context *ctx, int registry, int serif, int wmode, int *len, int *index);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_lookup_cjk_font (fz_context* ctx, int registry, int serif, int wmode, int* len, int* index);

	// extern const char * fz_lookup_noto_font (fz_context *ctx, int script, int lang, int serif, int *len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_lookup_noto_font (fz_context* ctx, int script, int lang, int serif, int* len);

	// extern const char * fz_lookup_noto_symbol_font (fz_context *ctx, int *len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_lookup_noto_symbol_font (fz_context* ctx, int* len);

	// extern const char * fz_lookup_noto_emoji_font (fz_context *ctx, int *len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_lookup_noto_emoji_font (fz_context* ctx, int* len);

	// extern fz_font * fz_load_fallback_font (fz_context *ctx, int script, int language, int serif, int bold, int italic);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_font* fz_load_fallback_font (fz_context* ctx, int script, int language, int serif, int bold, int italic);

	// extern fz_font * fz_load_fallback_symbol_font (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_font* fz_load_fallback_symbol_font (fz_context* ctx);

	// extern fz_font * fz_load_fallback_emoji_font (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_font* fz_load_fallback_emoji_font (fz_context* ctx);

	// extern fz_font * fz_new_type3_font (fz_context *ctx, const char *name, const int *matrix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_font* fz_new_type3_font (fz_context* ctx, sbyte* name, int* matrix);

	// extern fz_font * fz_new_font_from_memory (fz_context *ctx, const char *name, const char *data, int len, int index, int use_glyph_bbox);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_font* fz_new_font_from_memory (fz_context* ctx, sbyte* name, sbyte* data, int len, int index, int use_glyph_bbox);

	// extern fz_font * fz_new_font_from_buffer (fz_context *ctx, const char *name, fz_buffer *buffer, int index, int use_glyph_bbox);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_font* fz_new_font_from_buffer (fz_context* ctx, sbyte* name, fz_buffer* buffer, int index, int use_glyph_bbox);

	// extern fz_font * fz_new_font_from_file (fz_context *ctx, const char *name, const char *path, int index, int use_glyph_bbox);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_font* fz_new_font_from_file (fz_context* ctx, sbyte* name, sbyte* path, int index, int use_glyph_bbox);

	// extern fz_font * fz_keep_font (fz_context *ctx, fz_font *font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_font* fz_keep_font (fz_context* ctx, fz_font* font);

	// extern void fz_drop_font (fz_context *ctx, fz_font *font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_font (fz_context* ctx, fz_font* font);

	// extern void fz_set_font_bbox (fz_context *ctx, fz_font *font, float xmin, float ymin, float xmax, float ymax);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_font_bbox (fz_context* ctx, fz_font* font, float xmin, float ymin, float xmax, float ymax);

	// extern int * fz_bound_glyph (fz_context *ctx, fz_font *font, int gid, const int *trm, int *r);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_bound_glyph (fz_context* ctx, fz_font* font, int gid, int* trm, int* r);

	// extern int fz_glyph_cacheable (fz_context *ctx, fz_font *font, int gid);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_glyph_cacheable (fz_context* ctx, fz_font* font, int gid);

	// extern void fz_run_t3_glyph (fz_context *ctx, fz_font *font, int gid, const int *trm, struct fz_device_s *dev);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_run_t3_glyph (fz_context* ctx, fz_font* font, int gid, int* trm, fz_device_s* dev);

	// extern void fz_decouple_type3_font (fz_context *ctx, fz_font *font, void *t3doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_decouple_type3_font (fz_context* ctx, fz_font* font, void* t3doc);

	// extern float fz_advance_glyph (fz_context *ctx, fz_font *font, int glyph, int wmode);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe float fz_advance_glyph (fz_context* ctx, fz_font* font, int glyph, int wmode);

	// extern int fz_encode_character (fz_context *ctx, fz_font *font, int unicode);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_encode_character (fz_context* ctx, fz_font* font, int unicode);

	// extern int fz_encode_character_with_fallback (fz_context *ctx, fz_font *font, int unicode, int script, int language, fz_font **out_font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_encode_character_with_fallback (fz_context* ctx, fz_font* font, int unicode, int script, int language, fz_font** out_font);

	// extern void fz_get_glyph_name (fz_context *ctx, fz_font *font, int glyph, char *buf, int size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_get_glyph_name (fz_context* ctx, fz_font* font, int glyph, sbyte* buf, int size);

	// extern void fz_print_font (fz_context *ctx, int *out, fz_font *font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_print_font (fz_context* ctx, int* @out, fz_font* font);

	// extern void hb_lock (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void hb_lock (fz_context* ctx);

	// extern void hb_unlock (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void hb_unlock (fz_context* ctx);

	// extern void fz_eval_function (fz_context *ctx, fz_function *func, const float *in, int inlen, float *out, int outlen);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_eval_function (fz_context* ctx, fz_function* func, float* @in, int inlen, float* @out, int outlen);

	// extern fz_function * fz_keep_function (fz_context *ctx, fz_function *func);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_function* fz_keep_function (fz_context* ctx, fz_function* func);

	// extern void fz_drop_function (fz_context *ctx, fz_function *func);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_function (fz_context* ctx, fz_function* func);

	// extern size_t fz_function_size (fz_context *ctx, fz_function *func);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint fz_function_size (fz_context* ctx, fz_function* func);

	// extern void fz_print_function (fz_context *ctx, int *out, fz_function *func);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_print_function (fz_context* ctx, int* @out, fz_function* func);

	// extern int fz_getopt (int nargc, char *const *nargv, const char *ostr);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_getopt (int nargc, sbyte** nargv, sbyte* ostr);

	// extern void fz_purge_glyph_cache (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_purge_glyph_cache (fz_context* ctx);

	// extern int * fz_render_glyph_pixmap (fz_context *ctx, fz_font *, int, int *, const int *scissor);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_render_glyph_pixmap (fz_context* ctx, fz_font*, int, int*, int* scissor);

	// extern void fz_render_t3_glyph_direct (fz_context *ctx, fz_device *dev, fz_font *font, int gid, const int *trm, void *gstate, int nestedDepth);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_render_t3_glyph_direct (fz_context* ctx, fz_device* dev, fz_font* font, int gid, int* trm, void* gstate, int nestedDepth);

	// extern void fz_prepare_t3_glyph (fz_context *ctx, fz_font *font, int gid, int nestedDepth);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_prepare_t3_glyph (fz_context* ctx, fz_font* font, int gid, int nestedDepth);

	// extern void fz_dump_glyph_cache_stats (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_dump_glyph_cache_stats (fz_context* ctx);

	// extern float fz_subpixel_adjust (fz_context *ctx, int *ctm, int *subpix_ctm, unsigned char *qe, unsigned char *qf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe float fz_subpixel_adjust (fz_context* ctx, int* ctm, int* subpix_ctm, byte* qe, byte* qf);

	// extern int * fz_glyph_bbox (fz_context *ctx, fz_glyph *glyph, int *bbox);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_glyph_bbox (fz_context* ctx, fz_glyph* glyph, int* bbox);

	// extern int fz_glyph_width (fz_context *ctx, fz_glyph *glyph);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_glyph_width (fz_context* ctx, fz_glyph* glyph);

	// extern int fz_glyph_height (fz_context *ctx, fz_glyph *glyph);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_glyph_height (fz_context* ctx, fz_glyph* glyph);

	// extern fz_glyph * fz_new_glyph_from_pixmap (fz_context *ctx, int *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_glyph* fz_new_glyph_from_pixmap (fz_context* ctx, int* pix);

	// extern fz_glyph * fz_new_glyph_from_8bpp_data (fz_context *ctx, int x, int y, int w, int h, unsigned char *sp, int span);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_glyph* fz_new_glyph_from_8bpp_data (fz_context* ctx, int x, int y, int w, int h, byte* sp, int span);

	// extern fz_glyph * fz_new_glyph_from_1bpp_data (fz_context *ctx, int x, int y, int w, int h, unsigned char *sp, int span);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_glyph* fz_new_glyph_from_1bpp_data (fz_context* ctx, int x, int y, int w, int h, byte* sp, int span);

	// extern fz_glyph * fz_keep_glyph (fz_context *ctx, fz_glyph *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_glyph* fz_keep_glyph (fz_context* ctx, fz_glyph* pix);

	// extern void fz_drop_glyph (fz_context *ctx, fz_glyph *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_glyph (fz_context* ctx, fz_glyph* pix);

	// extern int * fz_glyph_bbox_no_ctx (fz_glyph *src, int *bbox);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_glyph_bbox_no_ctx (fz_glyph* src, int* bbox);

	// size_t fz_glyph_size (fz_context *ctx, fz_glyph *glyph);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint fz_glyph_size (fz_context* ctx, fz_glyph* glyph);

	// extern int fz_pixmap_size ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int fz_pixmap_size ();

	// extern fz_hash_table * fz_new_hash_table (fz_context *ctx, int initialsize, int keylen, int lock);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_hash_table* fz_new_hash_table (fz_context* ctx, int initialsize, int keylen, int @lock);

	// extern void fz_empty_hash (fz_context *ctx, fz_hash_table *table);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_empty_hash (fz_context* ctx, fz_hash_table* table);

	// extern void fz_drop_hash (fz_context *ctx, fz_hash_table *table);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_hash (fz_context* ctx, fz_hash_table* table);

	// extern void * fz_hash_find (fz_context *ctx, fz_hash_table *table, const void *key);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_hash_find (fz_context* ctx, fz_hash_table* table, void* key);

	// extern void * fz_hash_insert (fz_context *ctx, fz_hash_table *table, const void *key, void *val);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_hash_insert (fz_context* ctx, fz_hash_table* table, void* key, void* val);

	// extern void * fz_hash_insert_with_pos (fz_context *ctx, fz_hash_table *table, const void *key, void *val, unsigned int *pos);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_hash_insert_with_pos (fz_context* ctx, fz_hash_table* table, void* key, void* val, uint* pos);

	// extern void fz_hash_remove (fz_context *ctx, fz_hash_table *table, const void *key);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_hash_remove (fz_context* ctx, fz_hash_table* table, void* key);

	// extern void fz_hash_remove_fast (fz_context *ctx, fz_hash_table *table, const void *key, unsigned int pos);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_hash_remove_fast (fz_context* ctx, fz_hash_table* table, void* key, uint pos);

	// extern int fz_hash_len (fz_context *ctx, fz_hash_table *table);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_hash_len (fz_context* ctx, fz_hash_table* table);

	// extern void * fz_hash_get_key (fz_context *ctx, fz_hash_table *table, int idx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_hash_get_key (fz_context* ctx, fz_hash_table* table, int idx);

	// extern void * fz_hash_get_val (fz_context *ctx, fz_hash_table *table, int idx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_hash_get_val (fz_context* ctx, fz_hash_table* table, int idx);

	// extern void fz_print_hash (fz_context *ctx, int *out, fz_hash_table *table);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_print_hash (fz_context* ctx, int* @out, fz_hash_table* table);

	// extern void fz_print_hash_details (fz_context *ctx, int *out, fz_hash_table *table, void (* details)(fz_context *, int *, void *), int compact);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_print_hash_details (fz_context* ctx, int* @out, fz_hash_table* table, Action<mupdf.fz_context*, int*, void*>* details, int compact);

	// extern int * fz_get_pixmap_from_image (fz_context *ctx, fz_image *image, const int *subarea, int *trans, int *w, int *h);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_get_pixmap_from_image (fz_context* ctx, fz_image* image, int* subarea, int* trans, int* w, int* h);

	// extern void fz_drop_image (fz_context *ctx, fz_image *image);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_image (fz_context* ctx, fz_image* image);

	// extern void fz_drop_image_base (fz_context *ctx, fz_image *image);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_image_base (fz_context* ctx, fz_image* image);

	// extern fz_image * fz_keep_image (fz_context *ctx, fz_image *image);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_image* fz_keep_image (fz_context* ctx, fz_image* image);

	// extern fz_image * fz_keep_image_store_key (fz_context *ctx, fz_image *image);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_image* fz_keep_image_store_key (fz_context* ctx, fz_image* image);

	// extern void fz_drop_image_store_key (fz_context *ctx, fz_image *image);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_image_store_key (fz_context* ctx, fz_image* image);

	// extern fz_image * fz_new_image (fz_context *ctx, int w, int h, int bpc, fz_colorspace *colorspace, int xres, int yres, int interpolate, int imagemask, float *decode, int *colorkey, fz_image *mask, int size, fz_image_get_pixmap_fn *get, fz_image_get_size_fn *get_size, fz_drop_image_fn *drop);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_image* fz_new_image (fz_context* ctx, int w, int h, int bpc, fz_colorspace* colorspace, int xres, int yres, int interpolate, int imagemask, float* decode, int* colorkey, fz_image* mask, int size, fz_image_get_pixmap_fn* get, fz_image_get_size_fn* get_size, fz_drop_image_fn* drop);

	// extern fz_image * fz_new_image_from_compressed_buffer (fz_context *ctx, int w, int h, int bpc, fz_colorspace *colorspace, int xres, int yres, int interpolate, int imagemask, float *decode, int *colorkey, fz_compressed_buffer *buffer, fz_image *mask);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_image* fz_new_image_from_compressed_buffer (fz_context* ctx, int w, int h, int bpc, fz_colorspace* colorspace, int xres, int yres, int interpolate, int imagemask, float* decode, int* colorkey, fz_compressed_buffer* buffer, fz_image* mask);

	// extern fz_image * fz_new_image_from_pixmap (fz_context *ctx, int *pixmap, fz_image *mask);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_image* fz_new_image_from_pixmap (fz_context* ctx, int* pixmap, fz_image* mask);

	// extern fz_image * fz_new_image_from_data (fz_context *ctx, unsigned char *data, size_t len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_image* fz_new_image_from_data (fz_context* ctx, byte* data, nuint len);

	// extern fz_image * fz_new_image_from_buffer (fz_context *ctx, fz_buffer *buffer);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_image* fz_new_image_from_buffer (fz_context* ctx, fz_buffer* buffer);

	// extern fz_image * fz_new_image_from_file (fz_context *ctx, const char *path);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_image* fz_new_image_from_file (fz_context* ctx, sbyte* path);

	// extern void fz_drop_image_imp (fz_context *ctx, int *image);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_image_imp (fz_context* ctx, int* image);

	// extern int * fz_decomp_image_from_stream (fz_context *ctx, int *stm, fz_compressed_image *image, int *subarea, int indexed, int l2factor);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_decomp_image_from_stream (fz_context* ctx, int* stm, fz_compressed_image* image, int* subarea, int indexed, int l2factor);

	// extern int * fz_expand_indexed_pixmap (fz_context *ctx, const int *src, int alpha);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_expand_indexed_pixmap (fz_context* ctx, int* src, int alpha);

	// extern size_t fz_image_size (fz_context *ctx, fz_image *im);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint fz_image_size (fz_context* ctx, fz_image* im);

	// extern int * fz_load_jpeg (fz_context *ctx, unsigned char *data, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_load_jpeg (fz_context* ctx, byte* data, nuint size);

	// extern int * fz_load_jpx (fz_context *ctx, unsigned char *data, size_t size, fz_colorspace *cs, int indexed);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_load_jpx (fz_context* ctx, byte* data, nuint size, fz_colorspace* cs, int indexed);

	// extern int * fz_load_png (fz_context *ctx, unsigned char *data, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_load_png (fz_context* ctx, byte* data, nuint size);

	// extern int * fz_load_tiff (fz_context *ctx, unsigned char *data, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_load_tiff (fz_context* ctx, byte* data, nuint size);

	// extern int * fz_load_jxr (fz_context *ctx, unsigned char *data, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_load_jxr (fz_context* ctx, byte* data, nuint size);

	// extern int * fz_load_gif (fz_context *ctx, unsigned char *data, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_load_gif (fz_context* ctx, byte* data, nuint size);

	// extern int * fz_load_bmp (fz_context *ctx, unsigned char *data, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_load_bmp (fz_context* ctx, byte* data, nuint size);

	// extern int * fz_load_pnm (fz_context *ctx, unsigned char *data, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_load_pnm (fz_context* ctx, byte* data, nuint size);

	// extern void fz_load_jpeg_info (fz_context *ctx, unsigned char *data, size_t size, int *w, int *h, int *xres, int *yres, fz_colorspace **cspace);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_load_jpeg_info (fz_context* ctx, byte* data, nuint size, int* w, int* h, int* xres, int* yres, fz_colorspace** cspace);

	// extern void fz_load_jpx_info (fz_context *ctx, unsigned char *data, size_t size, int *w, int *h, int *xres, int *yres, fz_colorspace **cspace);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_load_jpx_info (fz_context* ctx, byte* data, nuint size, int* w, int* h, int* xres, int* yres, fz_colorspace** cspace);

	// extern void fz_load_png_info (fz_context *ctx, unsigned char *data, size_t size, int *w, int *h, int *xres, int *yres, fz_colorspace **cspace);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_load_png_info (fz_context* ctx, byte* data, nuint size, int* w, int* h, int* xres, int* yres, fz_colorspace** cspace);

	// extern void fz_load_tiff_info (fz_context *ctx, unsigned char *data, size_t size, int *w, int *h, int *xres, int *yres, fz_colorspace **cspace);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_load_tiff_info (fz_context* ctx, byte* data, nuint size, int* w, int* h, int* xres, int* yres, fz_colorspace** cspace);

	// extern void fz_load_jxr_info (fz_context *ctx, unsigned char *data, size_t size, int *w, int *h, int *xres, int *yres, fz_colorspace **cspace);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_load_jxr_info (fz_context* ctx, byte* data, nuint size, int* w, int* h, int* xres, int* yres, fz_colorspace** cspace);

	// extern void fz_load_gif_info (fz_context *ctx, unsigned char *data, size_t size, int *w, int *h, int *xres, int *yres, fz_colorspace **cspace);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_load_gif_info (fz_context* ctx, byte* data, nuint size, int* w, int* h, int* xres, int* yres, fz_colorspace** cspace);

	// extern void fz_load_bmp_info (fz_context *ctx, unsigned char *data, size_t size, int *w, int *h, int *xres, int *yres, fz_colorspace **cspace);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_load_bmp_info (fz_context* ctx, byte* data, nuint size, int* w, int* h, int* xres, int* yres, fz_colorspace** cspace);

	// extern void fz_load_pnm_info (fz_context *ctx, unsigned char *data, size_t size, int *w, int *h, int *xres, int *yres, fz_colorspace **cspace);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_load_pnm_info (fz_context* ctx, byte* data, nuint size, int* w, int* h, int* xres, int* yres, fz_colorspace** cspace);

	// extern int fz_load_tiff_subimage_count (fz_context *ctx, unsigned char *buf, size_t len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_load_tiff_subimage_count (fz_context* ctx, byte* buf, nuint len);

	// extern int * fz_load_tiff_subimage (fz_context *ctx, unsigned char *buf, size_t len, int subimage);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_load_tiff_subimage (fz_context* ctx, byte* buf, nuint len, int subimage);

	// extern void fz_image_resolution (fz_image *image, int *xres, int *yres);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_image_resolution (fz_image* image, int* xres, int* yres);

	// extern int * fz_compressed_image_tile (fz_context *ctx, fz_compressed_image *cimg);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_compressed_image_tile (fz_context* ctx, fz_compressed_image* cimg);

	// extern void fz_set_compressed_image_tile (fz_context *ctx, fz_compressed_image *cimg, int *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_compressed_image_tile (fz_context* ctx, fz_compressed_image* cimg, int* pix);

	// extern fz_compressed_buffer * fz_compressed_image_buffer (fz_context *ctx, fz_image *image);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_compressed_buffer* fz_compressed_image_buffer (fz_context* ctx, fz_image* image);

	// extern void fz_set_compressed_image_buffer (fz_context *ctx, fz_compressed_image *cimg, fz_compressed_buffer *buf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_compressed_image_buffer (fz_context* ctx, fz_compressed_image* cimg, fz_compressed_buffer* buf);

	// extern int * fz_pixmap_image_tile (fz_context *ctx, fz_pixmap_image *cimg);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_pixmap_image_tile (fz_context* ctx, fz_pixmap_image* cimg);

	// extern void fz_set_pixmap_image_tile (fz_context *ctx, fz_pixmap_image *cimg, int *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_pixmap_image_tile (fz_context* ctx, fz_pixmap_image* cimg, int* pix);

	// extern fz_link * fz_new_link (fz_context *ctx, const int *bbox, void *doc, const char *uri);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_link* fz_new_link (fz_context* ctx, int* bbox, void* doc, sbyte* uri);

	// extern fz_link * fz_keep_link (fz_context *ctx, fz_link *link);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_link* fz_keep_link (fz_context* ctx, fz_link* link);

	// extern int fz_is_external_link (fz_context *ctx, const char *uri);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_is_external_link (fz_context* ctx, sbyte* uri);

	// extern void fz_drop_link (fz_context *ctx, fz_link *link);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_link (fz_context* ctx, fz_link* link);

	// int fz_mul255 (int a, int b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int fz_mul255 (int a, int b);

	// extern float fz_atof (const char *s);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe float fz_atof (sbyte* s);

	// extern int fz_atoi (const char *s);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_atoi (sbyte* s);

	// extern int fz_atoo (const char *s);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_atoo (sbyte* s);

	// float fz_abs (float f);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern float fz_abs (float f);

	// int fz_absi (int i);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int fz_absi (int i);

	// float fz_min (float a, float b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern float fz_min (float a, float b);

	// int fz_mini (int a, int b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int fz_mini (int a, int b);

	// size_t fz_minz (size_t a, size_t b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern nuint fz_minz (nuint a, nuint b);

	// float fz_max (float a, float b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern float fz_max (float a, float b);

	// int fz_maxi (int a, int b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int fz_maxi (int a, int b);

	// int fz_maxo (int a, int b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int fz_maxo (int a, int b);

	// float fz_clamp (float f, float min, float max);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern float fz_clamp (float f, float min, float max);

	// int fz_clampi (int i, int min, int max);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int fz_clampi (int i, int min, int max);

	// double fz_clampd (double d, double min, double max);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern double fz_clampd (double d, double min, double max);

	// void * fz_clampp (void *p, void *min, void *max);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_clampp (void* p, void* min, void* max);

	// fz_point * fz_rect_min (fz_rect *f);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_point* fz_rect_min (fz_rect* f);

	// fz_point * fz_rect_max (fz_rect *f);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_point* fz_rect_max (fz_rect* f);

	// int fz_is_empty_rect (const fz_rect *r);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_is_empty_rect (fz_rect* r);

	// int fz_is_empty_irect (const fz_irect *r);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_is_empty_irect (fz_irect* r);

	// int fz_is_infinite_rect (const fz_rect *r);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_is_infinite_rect (fz_rect* r);

	// int fz_is_infinite_irect (const fz_irect *r);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_is_infinite_irect (fz_irect* r);

	// fz_matrix * fz_copy_matrix (fz_matrix *__restrict m, const fz_matrix *__restrict s);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_matrix* fz_copy_matrix (fz_matrix* m, fz_matrix* s);

	// extern fz_matrix * fz_concat (fz_matrix *result, const fz_matrix *left, const fz_matrix *right);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_matrix* fz_concat (fz_matrix* result, fz_matrix* left, fz_matrix* right);

	// extern fz_matrix * fz_scale (fz_matrix *m, float sx, float sy);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_matrix* fz_scale (fz_matrix* m, float sx, float sy);

	// extern fz_matrix * fz_pre_scale (fz_matrix *m, float sx, float sy);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_matrix* fz_pre_scale (fz_matrix* m, float sx, float sy);

	// extern fz_matrix * fz_post_scale (fz_matrix *m, float sx, float sy);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_matrix* fz_post_scale (fz_matrix* m, float sx, float sy);

	// extern fz_matrix * fz_shear (fz_matrix *m, float sx, float sy);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_matrix* fz_shear (fz_matrix* m, float sx, float sy);

	// extern fz_matrix * fz_pre_shear (fz_matrix *m, float sx, float sy);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_matrix* fz_pre_shear (fz_matrix* m, float sx, float sy);

	// extern fz_matrix * fz_rotate (fz_matrix *m, float degrees);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_matrix* fz_rotate (fz_matrix* m, float degrees);

	// extern fz_matrix * fz_pre_rotate (fz_matrix *m, float degrees);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_matrix* fz_pre_rotate (fz_matrix* m, float degrees);

	// extern fz_matrix * fz_translate (fz_matrix *m, float tx, float ty);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_matrix* fz_translate (fz_matrix* m, float tx, float ty);

	// extern fz_matrix * fz_pre_translate (fz_matrix *m, float tx, float ty);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_matrix* fz_pre_translate (fz_matrix* m, float tx, float ty);

	// extern fz_matrix * fz_invert_matrix (fz_matrix *inverse, const fz_matrix *matrix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_matrix* fz_invert_matrix (fz_matrix* inverse, fz_matrix* matrix);

	// extern int fz_try_invert_matrix (fz_matrix *inverse, const fz_matrix *matrix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_try_invert_matrix (fz_matrix* inverse, fz_matrix* matrix);

	// extern int fz_is_rectilinear (const fz_matrix *m);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_is_rectilinear (fz_matrix* m);

	// extern float fz_matrix_expansion (const fz_matrix *m);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe float fz_matrix_expansion (fz_matrix* m);

	// extern fz_rect * fz_intersect_rect (fz_rect *__restrict a, const fz_rect *__restrict b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* fz_intersect_rect (fz_rect* a, fz_rect* b);

	// extern fz_irect * fz_intersect_irect (fz_irect *__restrict a, const fz_irect *__restrict b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_irect* fz_intersect_irect (fz_irect* a, fz_irect* b);

	// extern fz_rect * fz_union_rect (fz_rect *__restrict a, const fz_rect *__restrict b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* fz_union_rect (fz_rect* a, fz_rect* b);

	// extern fz_irect * fz_irect_from_rect (fz_irect *__restrict bbox, const fz_rect *__restrict rect);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_irect* fz_irect_from_rect (fz_irect* bbox, fz_rect* rect);

	// extern fz_irect * fz_round_rect (fz_irect *__restrict bbox, const fz_rect *__restrict rect);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_irect* fz_round_rect (fz_irect* bbox, fz_rect* rect);

	// extern fz_rect * fz_rect_from_irect (fz_rect *__restrict rect, const fz_irect *__restrict bbox);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* fz_rect_from_irect (fz_rect* rect, fz_irect* bbox);

	// extern fz_rect * fz_expand_rect (fz_rect *b, float expand);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* fz_expand_rect (fz_rect* b, float expand);

	// extern fz_rect * fz_include_point_in_rect (fz_rect *r, const fz_point *p);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* fz_include_point_in_rect (fz_rect* r, fz_point* p);

	// extern fz_irect * fz_translate_irect (fz_irect *a, int xoff, int yoff);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_irect* fz_translate_irect (fz_irect* a, int xoff, int yoff);

	// extern int fz_contains_rect (const fz_rect *a, const fz_rect *b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_contains_rect (fz_rect* a, fz_rect* b);

	// extern fz_point * fz_transform_point (fz_point *__restrict point, const fz_matrix *__restrict transform);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_point* fz_transform_point (fz_point* point, fz_matrix* transform);

	// extern fz_point * fz_transform_point_xy (fz_point *__restrict point, const fz_matrix *__restrict transform, float x, float y);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_point* fz_transform_point_xy (fz_point* point, fz_matrix* transform, float x, float y);

	// extern fz_point * fz_transform_vector (fz_point *__restrict vector, const fz_matrix *__restrict transform);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_point* fz_transform_vector (fz_point* vector, fz_matrix* transform);

	// extern fz_rect * fz_transform_rect (fz_rect *__restrict rect, const fz_matrix *__restrict transform);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* fz_transform_rect (fz_rect* rect, fz_matrix* transform);

	// extern void fz_normalize_vector (fz_point *p);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_normalize_vector (fz_point* p);

	// extern void fz_gridfit_matrix (int as_tiled, fz_matrix *m);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_gridfit_matrix (int as_tiled, fz_matrix* m);

	// extern float fz_matrix_max_expansion (const fz_matrix *m);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe float fz_matrix_max_expansion (fz_matrix* m);

	// extern void fz_print_outline_xml (fz_context *ctx, int *out, fz_outline *outline);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_print_outline_xml (fz_context* ctx, int* @out, fz_outline* outline);

	// extern void fz_print_outline (fz_context *ctx, int *out, fz_outline *outline);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_print_outline (fz_context* ctx, int* @out, fz_outline* outline);

	// extern fz_outline * fz_new_outline (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_outline* fz_new_outline (fz_context* ctx);

	// extern fz_outline * fz_keep_outline (fz_context *ctx, fz_outline *outline);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_outline* fz_keep_outline (fz_context* ctx, fz_outline* outline);

	// extern void fz_drop_outline (fz_context *ctx, fz_outline *outline);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_outline (fz_context* ctx, fz_outline* outline);

	// extern void fz_pcl_preset (fz_context *ctx, fz_pcl_options *opts, const char *preset);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_pcl_preset (fz_context* ctx, fz_pcl_options* opts, sbyte* preset);

	// extern void fz_pcl_option (fz_context *ctx, fz_pcl_options *opts, const char *option, int val);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_pcl_option (fz_context* ctx, fz_pcl_options* opts, sbyte* option, int val);

	// extern int * fz_new_mono_pcl_band_writer (fz_context *ctx, int *out, const fz_pcl_options *options);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_new_mono_pcl_band_writer (fz_context* ctx, int* @out, fz_pcl_options* options);

	// extern void fz_write_bitmap_as_pcl (fz_context *ctx, int *out, const fz_bitmap *bitmap, const fz_pcl_options *pcl);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_bitmap_as_pcl (fz_context* ctx, int* @out, fz_bitmap* bitmap, fz_pcl_options* pcl);

	// extern void fz_save_bitmap_as_pcl (fz_context *ctx, fz_bitmap *bitmap, char *filename, int append, const fz_pcl_options *pcl);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_save_bitmap_as_pcl (fz_context* ctx, fz_bitmap* bitmap, sbyte* filename, int append, fz_pcl_options* pcl);

	// extern int * fz_new_color_pcl_band_writer (fz_context *ctx, int *out, const fz_pcl_options *options);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_new_color_pcl_band_writer (fz_context* ctx, int* @out, fz_pcl_options* options);

	// extern void fz_write_pixmap_as_pcl (fz_context *ctx, int *out, const int *pixmap, const fz_pcl_options *pcl);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_pixmap_as_pcl (fz_context* ctx, int* @out, int* pixmap, fz_pcl_options* pcl);

	// extern void fz_save_pixmap_as_pcl (fz_context *ctx, int *pixmap, char *filename, int append, const fz_pcl_options *pcl);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_save_pixmap_as_pcl (fz_context* ctx, int* pixmap, sbyte* filename, int append, fz_pcl_options* pcl);

	// extern void fz_save_pixmap_as_png (fz_context *ctx, int *pixmap, const char *filename);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_save_pixmap_as_png (fz_context* ctx, int* pixmap, sbyte* filename);

	// extern void fz_write_pixmap_as_png (fz_context *ctx, int *out, const int *pixmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_pixmap_as_png (fz_context* ctx, int* @out, int* pixmap);

	// extern int * fz_new_png_band_writer (fz_context *ctx, int *out);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_new_png_band_writer (fz_context* ctx, int* @out);

	// extern fz_buffer * fz_new_buffer_from_image_as_png (fz_context *ctx, fz_image *image);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* fz_new_buffer_from_image_as_png (fz_context* ctx, fz_image* image);

	// extern fz_buffer * fz_new_buffer_from_pixmap_as_png (fz_context *ctx, int *pixmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* fz_new_buffer_from_pixmap_as_png (fz_context* ctx, int* pixmap);

	// extern void fz_save_pixmap_as_pnm (fz_context *ctx, int *pixmap, char *filename);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_save_pixmap_as_pnm (fz_context* ctx, int* pixmap, sbyte* filename);

	// extern void fz_write_pixmap_as_pnm (fz_context *ctx, int *out, int *pixmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_pixmap_as_pnm (fz_context* ctx, int* @out, int* pixmap);

	// extern int * fz_new_pnm_band_writer (fz_context *ctx, int *out);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_new_pnm_band_writer (fz_context* ctx, int* @out);

	// extern void fz_save_pixmap_as_pam (fz_context *ctx, int *pixmap, char *filename);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_save_pixmap_as_pam (fz_context* ctx, int* pixmap, sbyte* filename);

	// extern void fz_write_pixmap_as_pam (fz_context *ctx, int *out, int *pixmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_pixmap_as_pam (fz_context* ctx, int* @out, int* pixmap);

	// extern int * fz_new_pam_band_writer (fz_context *ctx, int *out);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_new_pam_band_writer (fz_context* ctx, int* @out);

	// extern void fz_save_bitmap_as_pbm (fz_context *ctx, fz_bitmap *bitmap, char *filename);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_save_bitmap_as_pbm (fz_context* ctx, fz_bitmap* bitmap, sbyte* filename);

	// extern void fz_write_bitmap_as_pbm (fz_context *ctx, int *out, fz_bitmap *bitmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_bitmap_as_pbm (fz_context* ctx, int* @out, fz_bitmap* bitmap);

	// extern int * fz_new_pbm_band_writer (fz_context *ctx, int *out);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_new_pbm_band_writer (fz_context* ctx, int* @out);

	// extern void fz_save_bitmap_as_pkm (fz_context *ctx, fz_bitmap *bitmap, char *filename);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_save_bitmap_as_pkm (fz_context* ctx, fz_bitmap* bitmap, sbyte* filename);

	// extern void fz_write_bitmap_as_pkm (fz_context *ctx, int *out, fz_bitmap *bitmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_bitmap_as_pkm (fz_context* ctx, int* @out, fz_bitmap* bitmap);

	// extern int * fz_new_pkm_band_writer (fz_context *ctx, int *out);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_new_pkm_band_writer (fz_context* ctx, int* @out);

	// extern void fz_write_pixmap_as_ps (fz_context *ctx, int *out, const int *pixmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_pixmap_as_ps (fz_context* ctx, int* @out, int* pixmap);

	// extern void fz_save_pixmap_as_ps (fz_context *ctx, int *pixmap, char *filename, int append);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_save_pixmap_as_ps (fz_context* ctx, int* pixmap, sbyte* filename, int append);

	// extern void fz_write_ps_file_header (fz_context *ctx, int *out);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_ps_file_header (fz_context* ctx, int* @out);

	// extern int * fz_new_ps_band_writer (fz_context *ctx, int *out);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* fz_new_ps_band_writer (fz_context* ctx, int* @out);

	// extern void fz_write_ps_file_trailer (fz_context *ctx, int *out, int pages);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_ps_file_trailer (fz_context* ctx, int* @out, int pages);

	// extern void fz_save_pixmap_as_pwg (fz_context *ctx, int *pixmap, char *filename, int append, const fz_pwg_options *pwg);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_save_pixmap_as_pwg (fz_context* ctx, int* pixmap, sbyte* filename, int append, fz_pwg_options* pwg);

	// extern void fz_save_bitmap_as_pwg (fz_context *ctx, fz_bitmap *bitmap, char *filename, int append, const fz_pwg_options *pwg);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_save_bitmap_as_pwg (fz_context* ctx, fz_bitmap* bitmap, sbyte* filename, int append, fz_pwg_options* pwg);

	// extern void fz_write_pixmap_as_pwg (fz_context *ctx, int *out, const int *pixmap, const fz_pwg_options *pwg);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_pixmap_as_pwg (fz_context* ctx, int* @out, int* pixmap, fz_pwg_options* pwg);

	// extern void fz_write_bitmap_as_pwg (fz_context *ctx, int *out, const fz_bitmap *bitmap, const fz_pwg_options *pwg);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_bitmap_as_pwg (fz_context* ctx, int* @out, fz_bitmap* bitmap, fz_pwg_options* pwg);

	// extern void fz_write_pwg_header (fz_context *ctx, int *out);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_pwg_header (fz_context* ctx, int* @out);

	// extern void fz_write_pixmap_as_pwg_page (fz_context *ctx, int *out, const int *pixmap, const fz_pwg_options *pwg);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_pixmap_as_pwg_page (fz_context* ctx, int* @out, int* pixmap, fz_pwg_options* pwg);

	// extern void fz_write_bitmap_as_pwg_page (fz_context *ctx, int *out, const fz_bitmap *bitmap, const fz_pwg_options *pwg);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_bitmap_as_pwg_page (fz_context* ctx, int* @out, fz_bitmap* bitmap, fz_pwg_options* pwg);

	// extern fz_device * fz_new_svg_device (fz_context *ctx, int *out, float page_width, float page_height);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_device* fz_new_svg_device (fz_context* ctx, int* @out, float page_width, float page_height);

	// extern void fz_save_pixmap_as_tga (fz_context *ctx, int *pixmap, const char *filename);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_save_pixmap_as_tga (fz_context* ctx, int* pixmap, sbyte* filename);

	// extern void fz_write_pixmap_as_tga (fz_context *ctx, int *out, int *pixmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_pixmap_as_tga (fz_context* ctx, int* @out, int* pixmap);

	// extern fz_output * fz_new_output_with_file_ptr (fz_context *, FILE *, int close);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_output* fz_new_output_with_file_ptr (fz_context*, FILE*, int close);

	// extern fz_output * fz_new_output_with_path (fz_context *, const char *filename, int append);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_output* fz_new_output_with_path (fz_context*, sbyte* filename, int append);

	// extern fz_output * fz_new_output_with_buffer (fz_context *, fz_buffer *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_output* fz_new_output_with_buffer (fz_context*, fz_buffer*);

	// extern fz_output * fz_stdout (fz_context *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_output* fz_stdout (fz_context*);

	// extern fz_output * fz_stderr (fz_context *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_output* fz_stderr (fz_context*);

	// extern void fz_set_stdout (fz_context *ctx, fz_output *out);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_stdout (fz_context* ctx, fz_output* @out);

	// extern void fz_set_stderr (fz_context *ctx, fz_output *err);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_stderr (fz_context* ctx, fz_output* err);

	// extern void fz_printf (fz_context *ctx, fz_output *out, const char *fmt, ...);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_printf (fz_context* ctx, fz_output* @out, sbyte* fmt, IntPtr varArgs);

	// extern void fz_vprintf (fz_context *ctx, fz_output *out, const char *fmt, va_list ap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_vprintf (fz_context* ctx, fz_output* @out, sbyte* fmt, sbyte* ap);

	// extern void fz_seek_output (fz_context *ctx, fz_output *out, int off, int whence);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_seek_output (fz_context* ctx, fz_output* @out, int off, int whence);

	// extern int fz_tell_output (fz_context *ctx, fz_output *out);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_tell_output (fz_context* ctx, fz_output* @out);

	// extern void fz_drop_output (fz_context *, fz_output *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_output (fz_context*, fz_output*);

	// void fz_write (fz_context *ctx, fz_output *out, const void *data, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write (fz_context* ctx, fz_output* @out, void* data, nuint size);

	// void fz_write_int32_be (fz_context *ctx, fz_output *out, int x);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_int32_be (fz_context* ctx, fz_output* @out, int x);

	// void fz_write_int32_le (fz_context *ctx, fz_output *out, int x);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_int32_le (fz_context* ctx, fz_output* @out, int x);

	// void fz_write_int16_le (fz_context *ctx, fz_output *out, int x);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_int16_le (fz_context* ctx, fz_output* @out, int x);

	// void fz_write_byte (fz_context *ctx, fz_output *out, unsigned char x);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_byte (fz_context* ctx, fz_output* @out, byte x);

	// void fz_write_rune (fz_context *ctx, fz_output *out, int rune);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_rune (fz_context* ctx, fz_output* @out, int rune);

	// extern int fz_runetochar ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int fz_runetochar ();

	// extern size_t fz_vsnprintf (char *buffer, size_t space, const char *fmt, va_list args);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint fz_vsnprintf (sbyte* buffer, nuint space, sbyte* fmt, sbyte* args);

	// extern size_t fz_snprintf (char *buffer, size_t space, const char *fmt, ...);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint fz_snprintf (sbyte* buffer, nuint space, sbyte* fmt, IntPtr varArgs);

	// extern char * fz_tempfilename (fz_context *ctx, const char *base, const char *hint);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_tempfilename (fz_context* ctx, sbyte* @base, sbyte* hint);

	// extern void fz_save_buffer (fz_context *ctx, fz_buffer *buf, const char *filename);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_save_buffer (fz_context* ctx, fz_buffer* buf, sbyte* filename);

	// extern fz_band_writer * fz_new_band_writer_of_size (fz_context *ctx, size_t size, fz_output *out);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_band_writer* fz_new_band_writer_of_size (fz_context* ctx, nuint size, fz_output* @out);

	// extern void fz_write_header (fz_context *ctx, fz_band_writer *writer, int w, int h, int n, int alpha, int xres, int yres, int pagenum);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_header (fz_context* ctx, fz_band_writer* writer, int w, int h, int n, int alpha, int xres, int yres, int pagenum);

	// extern void fz_write_band (fz_context *ctx, fz_band_writer *writer, int stride, int band_start, int band_height, const unsigned char *samples);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_band (fz_context* ctx, fz_band_writer* writer, int stride, int band_start, int band_height, byte* samples);

	// extern void fz_write_trailer (fz_context *ctx, fz_band_writer *writer);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_write_trailer (fz_context* ctx, fz_band_writer* writer);

	// extern void fz_drop_band_writer (fz_context *ctx, fz_band_writer *writer);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_band_writer (fz_context* ctx, fz_band_writer* writer);

	// extern void fz_walk_path (fz_context *ctx, const fz_path *path, const fz_path_walker *walker, void *arg);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_walk_path (fz_context* ctx, fz_path* path, fz_path_walker* walker, void* arg);

	// extern fz_path * fz_new_path (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_path* fz_new_path (fz_context* ctx);

	// extern fz_path * fz_keep_path (fz_context *ctx, const fz_path *path);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_path* fz_keep_path (fz_context* ctx, fz_path* path);

	// extern void fz_drop_path (fz_context *ctx, const fz_path *path);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_path (fz_context* ctx, fz_path* path);

	// extern void fz_trim_path (fz_context *ctx, fz_path *path);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_trim_path (fz_context* ctx, fz_path* path);

	// extern int fz_packed_path_size (const fz_path *path);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_packed_path_size (fz_path* path);

	// extern int fz_pack_path (fz_context *ctx, uint8_t *pack, int max, const fz_path *path);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_pack_path (fz_context* ctx, byte* pack, int max, fz_path* path);

	// extern fz_path * fz_clone_path (fz_context *ctx, fz_path *path);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_path* fz_clone_path (fz_context* ctx, fz_path* path);

	// extern fz_point fz_currentpoint (fz_context *ctx, fz_path *path);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_point fz_currentpoint (fz_context* ctx, fz_path* path);

	// extern void fz_moveto (fz_context *ctx, fz_path *path, float x, float y);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_moveto (fz_context* ctx, fz_path* path, float x, float y);

	// extern void fz_lineto (fz_context *ctx, fz_path *path, float x, float y);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_lineto (fz_context* ctx, fz_path* path, float x, float y);

	// extern void fz_rectto (fz_context *ctx, fz_path *path, float x0, float y0, float x1, float y1);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_rectto (fz_context* ctx, fz_path* path, float x0, float y0, float x1, float y1);

	// extern void fz_quadto (fz_context *ctx, fz_path *path, float x0, float y0, float x1, float y1);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_quadto (fz_context* ctx, fz_path* path, float x0, float y0, float x1, float y1);

	// extern void fz_curveto (fz_context *ctx, fz_path *path, float x0, float y0, float x1, float y1, float x2, float y2);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_curveto (fz_context* ctx, fz_path* path, float x0, float y0, float x1, float y1, float x2, float y2);

	// extern void fz_curvetov (fz_context *ctx, fz_path *path, float x1, float y1, float x2, float y2);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_curvetov (fz_context* ctx, fz_path* path, float x1, float y1, float x2, float y2);

	// extern void fz_curvetoy (fz_context *ctx, fz_path *path, float x0, float y0, float x2, float y2);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_curvetoy (fz_context* ctx, fz_path* path, float x0, float y0, float x2, float y2);

	// extern void fz_closepath (fz_context *ctx, fz_path *path);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_closepath (fz_context* ctx, fz_path* path);

	// extern void fz_transform_path (fz_context *ctx, fz_path *path, const fz_matrix *transform);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_transform_path (fz_context* ctx, fz_path* path, fz_matrix* transform);

	// extern fz_rect * fz_bound_path (fz_context *ctx, const fz_path *path, const fz_stroke_state *stroke, const fz_matrix *ctm, fz_rect *r);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* fz_bound_path (fz_context* ctx, fz_path* path, fz_stroke_state* stroke, fz_matrix* ctm, fz_rect* r);

	// extern fz_rect * fz_adjust_rect_for_stroke (fz_context *ctx, fz_rect *r, const fz_stroke_state *stroke, const fz_matrix *ctm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* fz_adjust_rect_for_stroke (fz_context* ctx, fz_rect* r, fz_stroke_state* stroke, fz_matrix* ctm);

	// extern fz_stroke_state * fz_new_stroke_state (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stroke_state* fz_new_stroke_state (fz_context* ctx);

	// extern fz_stroke_state * fz_new_stroke_state_with_dash_len (fz_context *ctx, int len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stroke_state* fz_new_stroke_state_with_dash_len (fz_context* ctx, int len);

	// extern fz_stroke_state * fz_keep_stroke_state (fz_context *ctx, const fz_stroke_state *stroke);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stroke_state* fz_keep_stroke_state (fz_context* ctx, fz_stroke_state* stroke);

	// extern void fz_drop_stroke_state (fz_context *ctx, const fz_stroke_state *stroke);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_stroke_state (fz_context* ctx, fz_stroke_state* stroke);

	// extern fz_stroke_state * fz_unshare_stroke_state (fz_context *ctx, fz_stroke_state *shared);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stroke_state* fz_unshare_stroke_state (fz_context* ctx, fz_stroke_state* shared);

	// extern fz_stroke_state * fz_unshare_stroke_state_with_dash_len (fz_context *ctx, fz_stroke_state *shared, int len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stroke_state* fz_unshare_stroke_state_with_dash_len (fz_context* ctx, fz_stroke_state* shared, int len);

	// extern fz_stroke_state * fz_clone_stroke_state (fz_context *ctx, fz_stroke_state *stroke);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stroke_state* fz_clone_stroke_state (fz_context* ctx, fz_stroke_state* stroke);

	// extern void fz_print_path (fz_context *ctx, fz_output *out, fz_path *, int indent);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_print_path (fz_context* ctx, fz_output* @out, fz_path*, int indent);

	// extern fz_irect * fz_pixmap_bbox (fz_context *ctx, const fz_pixmap *pix, fz_irect *bbox);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_irect* fz_pixmap_bbox (fz_context* ctx, fz_pixmap* pix, fz_irect* bbox);

	// extern int fz_pixmap_width (fz_context *ctx, fz_pixmap *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_pixmap_width (fz_context* ctx, fz_pixmap* pix);

	// extern int fz_pixmap_height (fz_context *ctx, fz_pixmap *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_pixmap_height (fz_context* ctx, fz_pixmap* pix);

	// extern int fz_pixmap_x (fz_context *ctx, fz_pixmap *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_pixmap_x (fz_context* ctx, fz_pixmap* pix);

	// extern int fz_pixmap_y (fz_context *ctx, fz_pixmap *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_pixmap_y (fz_context* ctx, fz_pixmap* pix);

	// extern fz_pixmap * fz_new_pixmap (fz_context *ctx, fz_colorspace *cs, int w, int h, int alpha);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_pixmap* fz_new_pixmap (fz_context* ctx, fz_colorspace* cs, int w, int h, int alpha);

	// extern fz_pixmap * fz_new_pixmap_with_bbox (fz_context *ctx, fz_colorspace *colorspace, const fz_irect *bbox, int alpha);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_pixmap* fz_new_pixmap_with_bbox (fz_context* ctx, fz_colorspace* colorspace, fz_irect* bbox, int alpha);

	// extern fz_pixmap * fz_new_pixmap_with_data (fz_context *ctx, fz_colorspace *colorspace, int w, int h, int alpha, int stride, unsigned char *samples);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_pixmap* fz_new_pixmap_with_data (fz_context* ctx, fz_colorspace* colorspace, int w, int h, int alpha, int stride, byte* samples);

	// extern fz_pixmap * fz_new_pixmap_with_bbox_and_data (fz_context *ctx, fz_colorspace *colorspace, const fz_irect *rect, int alpha, unsigned char *samples);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_pixmap* fz_new_pixmap_with_bbox_and_data (fz_context* ctx, fz_colorspace* colorspace, fz_irect* rect, int alpha, byte* samples);

	// extern fz_pixmap * fz_keep_pixmap (fz_context *ctx, fz_pixmap *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_pixmap* fz_keep_pixmap (fz_context* ctx, fz_pixmap* pix);

	// extern void fz_drop_pixmap (fz_context *ctx, fz_pixmap *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_pixmap (fz_context* ctx, fz_pixmap* pix);

	// extern fz_colorspace * fz_pixmap_colorspace (fz_context *ctx, fz_pixmap *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_colorspace* fz_pixmap_colorspace (fz_context* ctx, fz_pixmap* pix);

	// extern int fz_pixmap_components (fz_context *ctx, fz_pixmap *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_pixmap_components (fz_context* ctx, fz_pixmap* pix);

	// extern int fz_pixmap_colorants (fz_context *ctx, fz_pixmap *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_pixmap_colorants (fz_context* ctx, fz_pixmap* pix);

	// extern unsigned char * fz_pixmap_samples (fz_context *ctx, fz_pixmap *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe byte* fz_pixmap_samples (fz_context* ctx, fz_pixmap* pix);

	// extern int fz_pixmap_stride (fz_context *ctx, fz_pixmap *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_pixmap_stride (fz_context* ctx, fz_pixmap* pix);

	// extern void fz_set_pixmap_resolution (fz_context *ctx, fz_pixmap *pix, int xres, int yres);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_set_pixmap_resolution (fz_context* ctx, fz_pixmap* pix, int xres, int yres);

	// extern void fz_clear_pixmap_with_value (fz_context *ctx, fz_pixmap *pix, int value);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_clear_pixmap_with_value (fz_context* ctx, fz_pixmap* pix, int value);

	// extern void fz_clear_pixmap_rect_with_value (fz_context *ctx, fz_pixmap *pix, int value, const fz_irect *r);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_clear_pixmap_rect_with_value (fz_context* ctx, fz_pixmap* pix, int value, fz_irect* r);

	// extern void fz_clear_pixmap (fz_context *ctx, fz_pixmap *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_clear_pixmap (fz_context* ctx, fz_pixmap* pix);

	// extern void fz_invert_pixmap (fz_context *ctx, fz_pixmap *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_invert_pixmap (fz_context* ctx, fz_pixmap* pix);

	// extern void fz_tint_pixmap (fz_context *ctx, fz_pixmap *pix, int r, int g, int b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_tint_pixmap (fz_context* ctx, fz_pixmap* pix, int r, int g, int b);

	// extern void fz_invert_pixmap_rect (fz_context *ctx, fz_pixmap *image, const fz_irect *rect);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_invert_pixmap_rect (fz_context* ctx, fz_pixmap* image, fz_irect* rect);

	// extern void fz_gamma_pixmap (fz_context *ctx, fz_pixmap *pix, float gamma);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_gamma_pixmap (fz_context* ctx, fz_pixmap* pix, float gamma);

	// extern void fz_unmultiply_pixmap (fz_context *ctx, fz_pixmap *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_unmultiply_pixmap (fz_context* ctx, fz_pixmap* pix);

	// extern void fz_convert_pixmap (fz_context *ctx, fz_pixmap *dst, fz_pixmap *src);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_convert_pixmap (fz_context* ctx, fz_pixmap* dst, fz_pixmap* src);

	// extern void fz_drop_pixmap_imp (fz_context *ctx, int *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_pixmap_imp (fz_context* ctx, int* pix);

	// extern void fz_copy_pixmap_rect (fz_context *ctx, fz_pixmap *dest, fz_pixmap *src, const fz_irect *r);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_copy_pixmap_rect (fz_context* ctx, fz_pixmap* dest, fz_pixmap* src, fz_irect* r);

	// extern void fz_premultiply_pixmap (fz_context *ctx, fz_pixmap *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_premultiply_pixmap (fz_context* ctx, fz_pixmap* pix);

	// extern fz_pixmap * fz_alpha_from_gray (fz_context *ctx, fz_pixmap *gray);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_pixmap* fz_alpha_from_gray (fz_context* ctx, fz_pixmap* gray);

	// extern size_t fz_pixmap_size (fz_context *ctx, fz_pixmap *pix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint fz_pixmap_size (fz_context* ctx, fz_pixmap* pix);

	// extern fz_pixmap * fz_scale_pixmap (fz_context *ctx, fz_pixmap *src, float x, float y, float w, float h, fz_irect *clip);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_pixmap* fz_scale_pixmap (fz_context* ctx, fz_pixmap* src, float x, float y, float w, float h, fz_irect* clip);

	// extern fz_scale_cache * fz_new_scale_cache (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_scale_cache* fz_new_scale_cache (fz_context* ctx);

	// extern void fz_drop_scale_cache (fz_context *ctx, fz_scale_cache *cache);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_scale_cache (fz_context* ctx, fz_scale_cache* cache);

	// extern fz_pixmap * fz_scale_pixmap_cached (fz_context *ctx, const fz_pixmap *src, float x, float y, float w, float h, const fz_irect *clip, fz_scale_cache *cache_x, fz_scale_cache *cache_y);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_pixmap* fz_scale_pixmap_cached (fz_context* ctx, fz_pixmap* src, float x, float y, float w, float h, fz_irect* clip, fz_scale_cache* cache_x, fz_scale_cache* cache_y);

	// extern void fz_subsample_pixmap (fz_context *ctx, fz_pixmap *tile, int factor);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_subsample_pixmap (fz_context* ctx, fz_pixmap* tile, int factor);

	// extern fz_irect * fz_pixmap_bbox_no_ctx (const fz_pixmap *src, fz_irect *bbox);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_irect* fz_pixmap_bbox_no_ctx (fz_pixmap* src, fz_irect* bbox);

	// extern void fz_decode_tile (fz_context *ctx, fz_pixmap *pix, const float *decode);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_decode_tile (fz_context* ctx, fz_pixmap* pix, float* decode);

	// extern void fz_decode_indexed_tile (fz_context *ctx, fz_pixmap *pix, const float *decode, int maxval);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_decode_indexed_tile (fz_context* ctx, fz_pixmap* pix, float* decode, int maxval);

	// extern void fz_unpack_tile (fz_context *ctx, fz_pixmap *dst, unsigned char *__restrict src, int n, int depth, size_t stride, int scale);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_unpack_tile (fz_context* ctx, fz_pixmap* dst, byte* src, int n, int depth, nuint stride, int scale);

	// extern void fz_md5_pixmap (fz_context *ctx, fz_pixmap *pixmap, unsigned char *digest);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_md5_pixmap (fz_context* ctx, fz_pixmap* pixmap, byte[] digest);

	// extern fz_pixmap * fz_new_pixmap_from_8bpp_data (fz_context *ctx, int x, int y, int w, int h, unsigned char *sp, int span);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_pixmap* fz_new_pixmap_from_8bpp_data (fz_context* ctx, int x, int y, int w, int h, byte* sp, int span);

	// extern fz_pixmap * fz_new_pixmap_from_1bpp_data (fz_context *ctx, int x, int y, int w, int h, unsigned char *sp, int span);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_pixmap* fz_new_pixmap_from_1bpp_data (fz_context* ctx, int x, int y, int w, int h, byte* sp, int span);

	// extern fz_pool * fz_new_pool (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_pool* fz_new_pool (fz_context* ctx);

	// extern void * fz_pool_alloc (fz_context *ctx, fz_pool *pool, size_t size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_pool_alloc (fz_context* ctx, fz_pool* pool, nuint size);

	// extern char * fz_pool_strdup (fz_context *ctx, fz_pool *pool, const char *s);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_pool_strdup (fz_context* ctx, fz_pool* pool, sbyte* s);

	// extern void fz_drop_pool (fz_context *ctx, fz_pool *pool);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_pool (fz_context* ctx, fz_pool* pool);

	// extern fz_separations * fz_new_separations (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_separations* fz_new_separations (fz_context* ctx);

	// extern fz_separations * fz_keep_separations (fz_context *ctx, fz_separations *sep);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_separations* fz_keep_separations (fz_context* ctx, fz_separations* sep);

	// extern void fz_drop_separations (fz_context *ctx, fz_separations *sep);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_separations (fz_context* ctx, fz_separations* sep);

	// extern void fz_add_separation (fz_context *ctx, fz_separations *sep, uint32_t rgba, uint32_t cmyk, char *name);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_add_separation (fz_context* ctx, fz_separations* sep, uint rgba, uint cmyk, sbyte* name);

	// extern void fz_control_separation (fz_context *ctx, fz_separations *sep, int separation, int disable);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_control_separation (fz_context* ctx, fz_separations* sep, int separation, int disable);

	// extern int fz_separation_disabled (fz_context *ctx, fz_separations *sep, int separation);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_separation_disabled (fz_context* ctx, fz_separations* sep, int separation);

	// extern int fz_separations_all_enabled (fz_context *ctx, fz_separations *sep);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_separations_all_enabled (fz_context* ctx, fz_separations* sep);

	// extern const char * fz_get_separation (fz_context *ctx, fz_separations *sep, int separation, uint32_t *rgb, uint32_t *cmyk);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_get_separation (fz_context* ctx, fz_separations* sep, int separation, uint* rgb, uint* cmyk);

	// extern int fz_count_separations (fz_context *ctx, fz_separations *sep);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_count_separations (fz_context* ctx, fz_separations* sep);

	// extern fz_shade * fz_keep_shade (fz_context *ctx, fz_shade *shade);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_shade* fz_keep_shade (fz_context* ctx, fz_shade* shade);

	// extern void fz_drop_shade (fz_context *ctx, fz_shade *shade);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_shade (fz_context* ctx, fz_shade* shade);

	// extern void fz_drop_shade_imp (fz_context *ctx, int *shade);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_shade_imp (fz_context* ctx, int* shade);

	// extern fz_rect * fz_bound_shade (fz_context *ctx, fz_shade *shade, const fz_matrix *ctm, fz_rect *r);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* fz_bound_shade (fz_context* ctx, fz_shade* shade, fz_matrix* ctm, fz_rect* r);

	// extern void fz_paint_shade (fz_context *ctx, fz_shade *shade, const fz_matrix *ctm, fz_pixmap *dest, const fz_irect *bbox);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_paint_shade (fz_context* ctx, fz_shade* shade, fz_matrix* ctm, fz_pixmap* dest, fz_irect* bbox);

	// extern void fz_process_shade (fz_context *ctx, fz_shade *shade, const fz_matrix *ctm, fz_shade_prepare_fn *prepare, fz_shade_process_fn *process, void *process_arg);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_process_shade (fz_context* ctx, fz_shade* shade, fz_matrix* ctm, fz_shade_prepare_fn* prepare, fz_shade_process_fn* process, void* process_arg);

	// extern void fz_print_shade (fz_context *ctx, fz_output *out, fz_shade *shade);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_print_shade (fz_context* ctx, fz_output* @out, fz_shade* shade);

	// extern void * fz_keep_storable (fz_context *, const fz_storable *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_keep_storable (fz_context*, fz_storable*);

	// extern void fz_drop_storable (fz_context *, const fz_storable *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_storable (fz_context*, fz_storable*);

	// extern void * fz_keep_key_storable (fz_context *, const fz_key_storable *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_keep_key_storable (fz_context*, fz_key_storable*);

	// extern void fz_drop_key_storable (fz_context *, const fz_key_storable *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_key_storable (fz_context*, fz_key_storable*);

	// extern void * fz_keep_key_storable_key (fz_context *, const fz_key_storable *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_keep_key_storable_key (fz_context*, fz_key_storable*);

	// extern void fz_drop_key_storable_key (fz_context *, const fz_key_storable *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_key_storable_key (fz_context*, fz_key_storable*);

	// extern void fz_new_store_context (fz_context *ctx, size_t max);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_new_store_context (fz_context* ctx, nuint max);

	// extern void fz_drop_store_context (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_store_context (fz_context* ctx);

	// extern fz_store * fz_keep_store_context (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_store* fz_keep_store_context (fz_context* ctx);

	// extern void * fz_store_item (fz_context *ctx, void *key, void *val, size_t itemsize, fz_store_type *type);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_store_item (fz_context* ctx, void* key, void* val, nuint itemsize, fz_store_type* type);

	// extern void * fz_find_item (fz_context *ctx, fz_store_drop_fn *drop, void *key, fz_store_type *type);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_find_item (fz_context* ctx, fz_store_drop_fn* drop, void* key, fz_store_type* type);

	// extern void fz_remove_item (fz_context *ctx, fz_store_drop_fn *drop, void *key, fz_store_type *type);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_remove_item (fz_context* ctx, fz_store_drop_fn* drop, void* key, fz_store_type* type);

	// extern void fz_empty_store (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_empty_store (fz_context* ctx);

	// extern int fz_store_scavenge (fz_context *ctx, size_t size, int *phase);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_store_scavenge (fz_context* ctx, nuint size, int* phase);

	// extern int fz_shrink_store (fz_context *ctx, unsigned int percent);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_shrink_store (fz_context* ctx, uint percent);

	// extern void fz_filter_store (fz_context *ctx, fz_store_filter_fn *fn, void *arg, fz_store_type *type);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_filter_store (fz_context* ctx, fz_store_filter_fn* fn, void* arg, fz_store_type* type);

	// extern void fz_print_store (fz_context *ctx, fz_output *out);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_print_store (fz_context* ctx, fz_output* @out);

	// extern void fz_print_store_locked (fz_context *ctx, fz_output *out);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_print_store_locked (fz_context* ctx, fz_output* @out);

	// extern void fz_defer_reap_start (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_defer_reap_start (fz_context* ctx);

	// extern void fz_defer_reap_end (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_defer_reap_end (fz_context* ctx);

	// extern int fz_file_exists (fz_context *ctx, const char *path);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_file_exists (fz_context* ctx, sbyte* path);

	// extern fz_stream * fz_open_file (fz_context *ctx, const char *filename);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* fz_open_file (fz_context* ctx, sbyte* filename);

	// extern fz_stream * fz_open_file_ptr_progressive (fz_context *ctx, FILE *file, int bps);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* fz_open_file_ptr_progressive (fz_context* ctx, FILE* file, int bps);

	// extern fz_stream * fz_open_file_progressive (fz_context *ctx, const char *filename, int bps);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* fz_open_file_progressive (fz_context* ctx, sbyte* filename, int bps);

	// extern fz_stream * fz_open_file_w (fz_context *ctx, const wchar_t *filename);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* fz_open_file_w (fz_context* ctx, int* filename);

	// extern fz_stream * fz_open_file_ptr (fz_context *ctx, FILE *file);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* fz_open_file_ptr (fz_context* ctx, FILE* file);

	// extern fz_stream * fz_open_memory (fz_context *ctx, unsigned char *data, size_t len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* fz_open_memory (fz_context* ctx, byte* data, nuint len);

	// extern fz_stream * fz_open_buffer (fz_context *ctx, fz_buffer *buf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* fz_open_buffer (fz_context* ctx, fz_buffer* buf);

	// extern fz_stream * fz_open_leecher (fz_context *ctx, fz_stream *chain, fz_buffer *buf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* fz_open_leecher (fz_context* ctx, fz_stream* chain, fz_buffer* buf);

	// extern void fz_drop_stream (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_stream (fz_context* ctx, fz_stream* stm);

	// extern int fz_tell (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_tell (fz_context* ctx, fz_stream* stm);

	// extern void fz_seek (fz_context *ctx, fz_stream *stm, int offset, int whence);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_seek (fz_context* ctx, fz_stream* stm, int offset, int whence);

	// extern size_t fz_read (fz_context *ctx, fz_stream *stm, unsigned char *data, size_t len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint fz_read (fz_context* ctx, fz_stream* stm, byte* data, nuint len);

	// extern size_t fz_skip (fz_context *ctx, fz_stream *stm, size_t len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint fz_skip (fz_context* ctx, fz_stream* stm, nuint len);

	// extern fz_buffer * fz_read_all (fz_context *ctx, fz_stream *stm, size_t initial);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* fz_read_all (fz_context* ctx, fz_stream* stm, nuint initial);

	// extern fz_buffer * fz_read_file (fz_context *ctx, const char *filename);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* fz_read_file (fz_context* ctx, sbyte* filename);

	// extern uint16_t fz_read_uint16 (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe ushort fz_read_uint16 (fz_context* ctx, fz_stream* stm);

	// extern uint32_t fz_read_uint24 (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe uint fz_read_uint24 (fz_context* ctx, fz_stream* stm);

	// extern uint32_t fz_read_uint32 (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe uint fz_read_uint32 (fz_context* ctx, fz_stream* stm);

	// extern uint64_t fz_read_uint64 (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe ulong fz_read_uint64 (fz_context* ctx, fz_stream* stm);

	// extern uint16_t fz_read_uint16_le (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe ushort fz_read_uint16_le (fz_context* ctx, fz_stream* stm);

	// extern uint32_t fz_read_uint24_le (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe uint fz_read_uint24_le (fz_context* ctx, fz_stream* stm);

	// extern uint32_t fz_read_uint32_le (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe uint fz_read_uint32_le (fz_context* ctx, fz_stream* stm);

	// extern uint64_t fz_read_uint64_le (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe ulong fz_read_uint64_le (fz_context* ctx, fz_stream* stm);

	// extern int16_t fz_read_int16 (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe short fz_read_int16 (fz_context* ctx, fz_stream* stm);

	// extern int32_t fz_read_int32 (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_read_int32 (fz_context* ctx, fz_stream* stm);

	// extern int64_t fz_read_int64 (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe long fz_read_int64 (fz_context* ctx, fz_stream* stm);

	// extern int16_t fz_read_int16_le (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe short fz_read_int16_le (fz_context* ctx, fz_stream* stm);

	// extern int32_t fz_read_int32_le (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_read_int32_le (fz_context* ctx, fz_stream* stm);

	// extern int64_t fz_read_int64_le (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe long fz_read_int64_le (fz_context* ctx, fz_stream* stm);

	// extern void fz_read_string (fz_context *ctx, fz_stream *stm, char *buffer, int len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_read_string (fz_context* ctx, fz_stream* stm, sbyte* buffer, int len);

	// extern int fz_stream_meta (fz_context *ctx, fz_stream *stm, int key, int size, void *ptr);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_stream_meta (fz_context* ctx, fz_stream* stm, int key, int size, void* ptr);

	// extern fz_stream * fz_new_stream (fz_context *ctx, void *state, fz_stream_next_fn *next, fz_stream_close_fn *close);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* fz_new_stream (fz_context* ctx, void* state, fz_stream_next_fn* next, fz_stream_close_fn* close);

	// extern fz_stream * fz_keep_stream (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* fz_keep_stream (fz_context* ctx, fz_stream* stm);

	// extern fz_buffer * fz_read_best (fz_context *ctx, fz_stream *stm, size_t initial, int *truncated);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* fz_read_best (fz_context* ctx, fz_stream* stm, nuint initial, int* truncated);

	// extern char * fz_read_line (fz_context *ctx, fz_stream *stm, char *buf, size_t max);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_read_line (fz_context* ctx, fz_stream* stm, sbyte* buf, nuint max);

	// size_t fz_available (fz_context *ctx, fz_stream *stm, size_t max);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint fz_available (fz_context* ctx, fz_stream* stm, nuint max);

	// extern int fz_setjmp ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int fz_setjmp ();

	// int fz_read_byte (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_read_byte (fz_context* ctx, fz_stream* stm);

	// int fz_peek_byte (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_peek_byte (fz_context* ctx, fz_stream* stm);

	// void fz_unread_byte (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_unread_byte (fz_context* ctx);

	// int fz_is_eof (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_is_eof (fz_context* ctx, fz_stream* stm);

	// unsigned int fz_read_bits (fz_context *ctx, fz_stream *stm, int n);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe uint fz_read_bits (fz_context* ctx, fz_stream* stm, int n);

	// unsigned int fz_read_rbits (fz_context *ctx, fz_stream *stm, int n);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe uint fz_read_rbits (fz_context* ctx, fz_stream* stm, int n);

	// void fz_sync_bits (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_sync_bits (fz_context* ctx);

	// int fz_is_eof_bits (fz_context *ctx, fz_stream *stm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_is_eof_bits (fz_context* ctx, fz_stream* stm);

	// extern char * fz_strsep (char **stringp, const char *delim);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_strsep (sbyte** stringp, sbyte* delim);

	// extern size_t fz_strlcpy (char *dst, const char *src, size_t n);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint fz_strlcpy (sbyte* dst, sbyte* src, nuint n);

	// extern size_t fz_strlcat (char *dst, const char *src, size_t n);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint fz_strlcat (sbyte* dst, sbyte* src, nuint n);

	// extern void fz_dirname (char *dir, const char *path, size_t dirsize);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_dirname (sbyte* dir, sbyte* path, nuint dirsize);

	// extern char * fz_urldecode (char *url);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_urldecode (sbyte* url);

	// extern void fz_format_output_path (fz_context *ctx, char *path, size_t size, const char *fmt, int page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_format_output_path (fz_context* ctx, sbyte* path, nuint size, sbyte* fmt, int page);

	// extern char * fz_cleanname (char *name);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_cleanname (sbyte* name);

	// extern int fz_chartorune (int *rune, const char *str);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_chartorune (int* rune, sbyte* str);

	// extern int fz_runetochar (char *str, int rune);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_runetochar (sbyte* str, int rune);

	// extern int fz_runelen (int rune);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int fz_runelen (int rune);

	// extern int fz_utflen (const char *s);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_utflen (sbyte* s);

	// extern double fz_strtod (const char *s, char **es);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe double fz_strtod (sbyte* s, sbyte** es);

	// extern float fz_strtof (const char *s, char **es);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe float fz_strtof (sbyte* s, sbyte** es);

	// extern float fz_strtof_no_exp (const char *string, char **tailptr);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe float fz_strtof_no_exp (sbyte* @string, sbyte** tailptr);

	// extern int fz_grisu (float f, char *s, int *exp);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_grisu (float f, sbyte* s, int* exp);

	// extern int fz_is_page_range (fz_context *ctx, const char *s);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_is_page_range (fz_context* ctx, sbyte* s);

	// extern const char * fz_parse_page_range (fz_context *ctx, const char *s, int *a, int *b, int n);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_parse_page_range (fz_context* ctx, sbyte* s, int* a, int* b, int n);

	// extern fz_char_and_box * fz_stext_char_at (fz_context *ctx, fz_char_and_box *cab, fz_stext_page *page, int idx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_char_and_box* fz_stext_char_at (fz_context* ctx, fz_char_and_box* cab, fz_stext_page* page, int idx);

	// extern fz_rect * fz_stext_char_bbox (fz_context *ctx, fz_rect *bbox, fz_stext_span *span, int idx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* fz_stext_char_bbox (fz_context* ctx, fz_rect* bbox, fz_stext_span* span, int idx);

	// extern fz_stext_sheet * fz_new_stext_sheet (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stext_sheet* fz_new_stext_sheet (fz_context* ctx);

	// extern void fz_drop_stext_sheet (fz_context *ctx, fz_stext_sheet *sheet);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_stext_sheet (fz_context* ctx, fz_stext_sheet* sheet);

	// extern fz_stext_page * fz_new_stext_page (fz_context *ctx, const fz_rect *mediabox);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stext_page* fz_new_stext_page (fz_context* ctx, fz_rect* mediabox);

	// extern void fz_drop_stext_page (fz_context *ctx, fz_stext_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_stext_page (fz_context* ctx, fz_stext_page* page);

	// extern void fz_analyze_text (fz_context *ctx, fz_stext_sheet *sheet, fz_stext_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_analyze_text (fz_context* ctx, fz_stext_sheet* sheet, fz_stext_page* page);

	// extern void fz_print_stext_sheet (fz_context *ctx, fz_output *out, fz_stext_sheet *sheet);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_print_stext_sheet (fz_context* ctx, fz_output* @out, fz_stext_sheet* sheet);

	// extern void fz_print_stext_page_html (fz_context *ctx, fz_output *out, fz_stext_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_print_stext_page_html (fz_context* ctx, fz_output* @out, fz_stext_page* page);

	// extern void fz_print_stext_page_xml (fz_context *ctx, fz_output *out, fz_stext_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_print_stext_page_xml (fz_context* ctx, fz_output* @out, fz_stext_page* page);

	// extern void fz_print_stext_page (fz_context *ctx, fz_output *out, fz_stext_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_print_stext_page (fz_context* ctx, fz_output* @out, fz_stext_page* page);

	// extern int fz_search_stext_page (fz_context *ctx, fz_stext_page *text, const char *needle, fz_rect *hit_bbox, int hit_max);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_search_stext_page (fz_context* ctx, fz_stext_page* text, sbyte* needle, fz_rect* hit_bbox, int hit_max);

	// extern int fz_highlight_selection (fz_context *ctx, fz_stext_page *page, fz_rect rect, fz_rect *hit_bbox, int hit_max);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_highlight_selection (fz_context* ctx, fz_stext_page* page, fz_rect rect, fz_rect* hit_bbox, int hit_max);

	// extern char * fz_copy_selection (fz_context *ctx, fz_stext_page *page, fz_rect rect);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_copy_selection (fz_context* ctx, fz_stext_page* page, fz_rect rect);

	// extern fz_stext_options * fz_parse_stext_options (fz_context *ctx, fz_stext_options *opts, const char *string);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stext_options* fz_parse_stext_options (fz_context* ctx, fz_stext_options* opts, sbyte* @string);

	// extern fz_device * fz_new_stext_device (fz_context *ctx, fz_stext_sheet *sheet, fz_stext_page *page, const fz_stext_options *options);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_device* fz_new_stext_device (fz_context* ctx, fz_stext_sheet* sheet, fz_stext_page* page, fz_stext_options* options);

	// extern int fz_strcasecmp (const char *a, const char *b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_strcasecmp (sbyte* a, sbyte* b);

	// extern fz_text * fz_new_text (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_text* fz_new_text (fz_context* ctx);

	// extern fz_text * fz_keep_text (fz_context *ctx, const fz_text *text);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_text* fz_keep_text (fz_context* ctx, fz_text* text);

	// extern void fz_drop_text (fz_context *ctx, const fz_text *text);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_text (fz_context* ctx, fz_text* text);

	// extern void fz_show_glyph (fz_context *ctx, fz_text *text, fz_font *font, const fz_matrix *trm, int glyph, int unicode, int wmode, int bidi_level, fz_bidi_direction markup_dir, fz_text_language language);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_show_glyph (fz_context* ctx, fz_text* text, fz_font* font, fz_matrix* trm, int glyph, int unicode, int wmode, int bidi_level, fz_bidi_direction markup_dir, fz_text_language language);

	// extern void fz_show_string (fz_context *ctx, fz_text *text, fz_font *font, fz_matrix *trm, const char *s, int wmode, int bidi_level, fz_bidi_direction markup_dir, fz_text_language language);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_show_string (fz_context* ctx, fz_text* text, fz_font* font, fz_matrix* trm, sbyte* s, int wmode, int bidi_level, fz_bidi_direction markup_dir, fz_text_language language);

	// extern fz_rect * fz_bound_text (fz_context *ctx, const fz_text *text, const fz_stroke_state *stroke, const fz_matrix *ctm, fz_rect *r);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* fz_bound_text (fz_context* ctx, fz_text* text, fz_stroke_state* stroke, fz_matrix* ctm, fz_rect* r);

	// extern fz_text * fz_clone_text (fz_context *ctx, const fz_text *text);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_text* fz_clone_text (fz_context* ctx, fz_text* text);

	// extern fz_text_language fz_text_language_from_string (const char *str);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_text_language fz_text_language_from_string (sbyte* str);

	// extern char * fz_string_from_text_language (char *str, fz_text_language lang);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_string_from_text_language (sbyte[] str, fz_text_language lang);

	// extern int fz_generate_transition (fz_context *ctx, fz_pixmap *tpix, fz_pixmap *opix, fz_pixmap *npix, int time, fz_transition *trans);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_generate_transition (fz_context* ctx, fz_pixmap* tpix, fz_pixmap* opix, fz_pixmap* npix, int time, fz_transition* trans);

	// extern void * fz_tree_lookup (fz_context *ctx, fz_tree *node, const char *key);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* fz_tree_lookup (fz_context* ctx, fz_tree* node, sbyte* key);

	// extern fz_tree * fz_tree_insert (fz_context *ctx, fz_tree *root, const char *key, void *value);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_tree* fz_tree_insert (fz_context* ctx, fz_tree* root, sbyte* key, void* value);

	// extern void fz_drop_tree (fz_context *ctx, fz_tree *node, void (* dropfunc)(fz_context *, void *));
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_tree (fz_context* ctx, fz_tree* node, Action<mupdf.fz_context*, void*>* dropfunc);

	// extern void fz_debug_tree (fz_context *ctx, fz_tree *root);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_debug_tree (fz_context* ctx, fz_tree* root);

	// extern const char * ucdn_get_unicode_version ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* ucdn_get_unicode_version ();

	// extern int ucdn_get_combining_class (uint32_t code);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int ucdn_get_combining_class (uint code);

	// extern int ucdn_get_east_asian_width (uint32_t code);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int ucdn_get_east_asian_width (uint code);

	// extern int ucdn_get_general_category (uint32_t code);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int ucdn_get_general_category (uint code);

	// extern int ucdn_get_bidi_class (uint32_t code);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int ucdn_get_bidi_class (uint code);

	// extern int ucdn_get_script (uint32_t code);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int ucdn_get_script (uint code);

	// extern int ucdn_get_linebreak_class (uint32_t code);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int ucdn_get_linebreak_class (uint code);

	// extern int ucdn_get_resolved_linebreak_class (uint32_t code);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int ucdn_get_resolved_linebreak_class (uint code);

	// extern int ucdn_get_mirrored (uint32_t code);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int ucdn_get_mirrored (uint code);

	// extern uint32_t ucdn_mirror (uint32_t code);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern uint ucdn_mirror (uint code);

	// extern int ucdn_decompose (uint32_t code, uint32_t *a, uint32_t *b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int ucdn_decompose (uint code, uint* a, uint* b);

	// extern int ucdn_compat_decompose (uint32_t code, uint32_t *decomposed);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int ucdn_compat_decompose (uint code, uint* decomposed);

	// extern int ucdn_compose (uint32_t *code, uint32_t a, uint32_t b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int ucdn_compose (uint* code, uint a, uint b);

	// extern fz_display_list * fz_new_display_list_from_page (fz_context *ctx, fz_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_display_list* fz_new_display_list_from_page (fz_context* ctx, fz_page* page);

	// extern fz_display_list * fz_new_display_list_from_page_number (fz_context *ctx, fz_document *doc, int number);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_display_list* fz_new_display_list_from_page_number (fz_context* ctx, fz_document* doc, int number);

	// extern fz_display_list * fz_new_display_list_from_page_contents (fz_context *ctx, fz_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_display_list* fz_new_display_list_from_page_contents (fz_context* ctx, fz_page* page);

	// extern fz_display_list * fz_new_display_list_from_annot (fz_context *ctx, fz_annot *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_display_list* fz_new_display_list_from_annot (fz_context* ctx, fz_annot* annot);

	// extern fz_pixmap * fz_new_pixmap_from_display_list (fz_context *ctx, fz_display_list *list, const fz_matrix *ctm, fz_colorspace *cs, int alpha);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_pixmap* fz_new_pixmap_from_display_list (fz_context* ctx, fz_display_list* list, fz_matrix* ctm, fz_colorspace* cs, int alpha);

	// extern fz_pixmap * fz_new_pixmap_from_page (fz_context *ctx, fz_page *page, const fz_matrix *ctm, fz_colorspace *cs, int alpha);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_pixmap* fz_new_pixmap_from_page (fz_context* ctx, fz_page* page, fz_matrix* ctm, fz_colorspace* cs, int alpha);

	// extern fz_pixmap * fz_new_pixmap_from_page_number (fz_context *ctx, fz_document *doc, int number, const fz_matrix *ctm, fz_colorspace *cs, int alpha);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_pixmap* fz_new_pixmap_from_page_number (fz_context* ctx, fz_document* doc, int number, fz_matrix* ctm, fz_colorspace* cs, int alpha);

	// extern fz_pixmap * fz_new_pixmap_from_page_contents (fz_context *ctx, fz_page *page, const fz_matrix *ctm, fz_colorspace *cs, int alpha);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_pixmap* fz_new_pixmap_from_page_contents (fz_context* ctx, fz_page* page, fz_matrix* ctm, fz_colorspace* cs, int alpha);

	// extern fz_pixmap * fz_new_pixmap_from_annot (fz_context *ctx, fz_annot *annot, const fz_matrix *ctm, fz_colorspace *cs, int alpha);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_pixmap* fz_new_pixmap_from_annot (fz_context* ctx, fz_annot* annot, fz_matrix* ctm, fz_colorspace* cs, int alpha);

	// extern fz_stext_page * fz_new_stext_page_from_page (fz_context *ctx, fz_page *page, fz_stext_sheet *sheet, const fz_stext_options *options);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stext_page* fz_new_stext_page_from_page (fz_context* ctx, fz_page* page, fz_stext_sheet* sheet, fz_stext_options* options);

	// extern fz_stext_page * fz_new_stext_page_from_page_number (fz_context *ctx, fz_document *doc, int number, fz_stext_sheet *sheet, const fz_stext_options *options);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stext_page* fz_new_stext_page_from_page_number (fz_context* ctx, fz_document* doc, int number, fz_stext_sheet* sheet, fz_stext_options* options);

	// extern fz_stext_page * fz_new_stext_page_from_display_list (fz_context *ctx, fz_display_list *list, fz_stext_sheet *sheet, const fz_stext_options *options);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stext_page* fz_new_stext_page_from_display_list (fz_context* ctx, fz_display_list* list, fz_stext_sheet* sheet, fz_stext_options* options);

	// extern fz_buffer * fz_new_buffer_from_stext_page (fz_context *ctx, fz_stext_page *text, const fz_rect *sel, int crlf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* fz_new_buffer_from_stext_page (fz_context* ctx, fz_stext_page* text, fz_rect* sel, int crlf);

	// extern fz_buffer * fz_new_buffer_from_page (fz_context *ctx, fz_page *page, const fz_rect *sel, int crlf, const fz_stext_options *options);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* fz_new_buffer_from_page (fz_context* ctx, fz_page* page, fz_rect* sel, int crlf, fz_stext_options* options);

	// extern fz_buffer * fz_new_buffer_from_page_number (fz_context *ctx, fz_document *doc, int number, const fz_rect *sel, int crlf, const fz_stext_options *options);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* fz_new_buffer_from_page_number (fz_context* ctx, fz_document* doc, int number, fz_rect* sel, int crlf, fz_stext_options* options);

	// extern fz_buffer * fz_new_buffer_from_display_list (fz_context *ctx, fz_display_list *list, const fz_rect *sel, int crlf, const fz_stext_options *options);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* fz_new_buffer_from_display_list (fz_context* ctx, fz_display_list* list, fz_rect* sel, int crlf, fz_stext_options* options);

	// extern int fz_search_page (fz_context *ctx, fz_page *page, const char *needle, fz_rect *hit_bbox, int hit_max);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_search_page (fz_context* ctx, fz_page* page, sbyte* needle, fz_rect* hit_bbox, int hit_max);

	// extern int fz_search_page_number (fz_context *ctx, fz_document *doc, int number, const char *needle, fz_rect *hit_bbox, int hit_max);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_search_page_number (fz_context* ctx, fz_document* doc, int number, sbyte* needle, fz_rect* hit_bbox, int hit_max);

	// extern int fz_search_display_list (fz_context *ctx, fz_display_list *list, const char *needle, fz_rect *hit_bbox, int hit_max);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_search_display_list (fz_context* ctx, fz_display_list* list, sbyte* needle, fz_rect* hit_bbox, int hit_max);

	// extern int fz_has_option (fz_context *ctx, const char *opts, const char *key, const char **val);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_has_option (fz_context* ctx, sbyte* opts, sbyte* key, sbyte** val);

	// extern int fz_option_eq (const char *a, const char *b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_option_eq (sbyte* a, sbyte* b);

	// extern fz_document_writer * fz_new_document_writer (fz_context *ctx, const char *path, const char *format, const char *options);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_document_writer* fz_new_document_writer (fz_context* ctx, sbyte* path, sbyte* format, sbyte* options);

	// extern fz_device * fz_begin_page (fz_context *ctx, fz_document_writer *wri, const fz_rect *mediabox);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_device* fz_begin_page (fz_context* ctx, fz_document_writer* wri, fz_rect* mediabox);

	// extern void fz_end_page (fz_context *ctx, fz_document_writer *wri, fz_device *dev);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_end_page (fz_context* ctx, fz_document_writer* wri, fz_device* dev);

	// extern void fz_close_document_writer (fz_context *ctx, fz_document_writer *wri);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_close_document_writer (fz_context* ctx, fz_document_writer* wri);

	// extern void fz_drop_document_writer (fz_context *ctx, fz_document_writer *wri);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_document_writer (fz_context* ctx, fz_document_writer* wri);

	// extern fz_document_writer * fz_new_cbz_writer (fz_context *ctx, const char *path, const char *options);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_document_writer* fz_new_cbz_writer (fz_context* ctx, sbyte* path, sbyte* options);

	// extern fz_document_writer * fz_new_png_writer (fz_context *ctx, const char *path, const char *options);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_document_writer* fz_new_png_writer (fz_context* ctx, sbyte* path, sbyte* options);

	// extern fz_document_writer * fz_new_pdf_writer (fz_context *ctx, const char *path, const char *options);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_document_writer* fz_new_pdf_writer (fz_context* ctx, sbyte* path, sbyte* options);

	// extern fz_xml * fz_parse_xml (fz_context *ctx, unsigned char *buf, size_t len, int preserve_white);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_xml* fz_parse_xml (fz_context* ctx, byte* buf, nuint len, int preserve_white);

	// extern fz_xml * fz_xml_prev (fz_xml *item);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_xml* fz_xml_prev (fz_xml* item);

	// extern fz_xml * fz_xml_next (fz_xml *item);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_xml* fz_xml_next (fz_xml* item);

	// extern fz_xml * fz_xml_up (fz_xml *item);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_xml* fz_xml_up (fz_xml* item);

	// extern fz_xml * fz_xml_down (fz_xml *item);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_xml* fz_xml_down (fz_xml* item);

	// extern int fz_xml_is_tag (fz_xml *item, const char *name);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_xml_is_tag (fz_xml* item, sbyte* name);

	// extern char * fz_xml_tag (fz_xml *item);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_xml_tag (fz_xml* item);

	// extern char * fz_xml_att (fz_xml *item, const char *att);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_xml_att (fz_xml* item, sbyte* att);

	// extern char * fz_xml_text (fz_xml *item);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* fz_xml_text (fz_xml* item);

	// extern void fz_drop_xml (fz_context *doc, fz_xml *item);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_xml (fz_context* doc, fz_xml* item);

	// extern void fz_detach_xml (fz_xml *node);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_detach_xml (fz_xml* node);

	// extern void fz_debug_xml (fz_xml *item, int level);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_debug_xml (fz_xml* item, int level);

	// extern fz_xml * fz_xml_find (fz_xml *item, const char *tag);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_xml* fz_xml_find (fz_xml* item, sbyte* tag);

	// extern fz_xml * fz_xml_find_next (fz_xml *item, const char *tag);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_xml* fz_xml_find_next (fz_xml* item, sbyte* tag);

	// extern fz_xml * fz_xml_find_down (fz_xml *item, const char *tag);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_xml* fz_xml_find_down (fz_xml* item, sbyte* tag);

	// extern fz_css * fz_new_css (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_css* fz_new_css (fz_context* ctx);

	// extern void fz_parse_css (fz_context *ctx, fz_css *css, const char *source, const char *file);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_parse_css (fz_context* ctx, fz_css* css, sbyte* source, sbyte* file);

	// extern fz_css_property * fz_parse_css_properties (fz_context *ctx, fz_pool *pool, const char *source);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_css_property* fz_parse_css_properties (fz_context* ctx, fz_pool* pool, sbyte* source);

	// extern void fz_drop_css (fz_context *ctx, fz_css *css);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_css (fz_context* ctx, fz_css* css);

	// extern void fz_match_css (fz_context *ctx, fz_css_match *match, fz_css *css, fz_xml *node);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_match_css (fz_context* ctx, fz_css_match* match, fz_css* css, fz_xml* node);

	// extern void fz_match_css_at_page (fz_context *ctx, fz_css_match *match, fz_css *css);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_match_css_at_page (fz_context* ctx, fz_css_match* match, fz_css* css);

	// extern int fz_get_css_match_display (fz_css_match *node);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int fz_get_css_match_display (fz_css_match* node);

	// extern void fz_default_css_style (fz_context *ctx, fz_css_style *style);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_default_css_style (fz_context* ctx, fz_css_style* style);

	// extern void fz_apply_css_style (fz_context *ctx, fz_html_font_set *set, fz_css_style *style, fz_css_match *match);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_apply_css_style (fz_context* ctx, fz_html_font_set* set, fz_css_style* style, fz_css_match* match);

	// extern float fz_from_css_number (fz_css_number, float em, float width);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern float fz_from_css_number (fz_css_number, float em, float width);

	// extern float fz_from_css_number_scale (fz_css_number number, float scale, float em, float width);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern float fz_from_css_number_scale (fz_css_number number, float scale, float em, float width);

	// extern fz_html_font_set * fz_new_html_font_set (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_html_font_set* fz_new_html_font_set (fz_context* ctx);

	// extern void fz_add_html_font_face (fz_context *ctx, fz_html_font_set *set, const char *family, int is_bold, int is_italic, const char *src, fz_font *font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_add_html_font_face (fz_context* ctx, fz_html_font_set* set, sbyte* family, int is_bold, int is_italic, sbyte* src, fz_font* font);

	// extern fz_font * fz_load_html_font (fz_context *ctx, fz_html_font_set *set, const char *family, int is_bold, int is_italic);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_font* fz_load_html_font (fz_context* ctx, fz_html_font_set* set, sbyte* family, int is_bold, int is_italic);

	// extern void fz_drop_html_font_set (fz_context *ctx, fz_html_font_set *htx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_html_font_set (fz_context* ctx, fz_html_font_set* htx);

	// extern void fz_add_css_font_faces (fz_context *ctx, fz_html_font_set *set, fz_archive *zip, const char *base_uri, fz_css *css);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_add_css_font_faces (fz_context* ctx, fz_html_font_set* set, fz_archive* zip, sbyte* base_uri, fz_css* css);

	// extern fz_html * fz_parse_html (fz_context *ctx, fz_html_font_set *htx, fz_archive *zip, const char *base_uri, fz_buffer *buf, const char *user_css);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_html* fz_parse_html (fz_context* ctx, fz_html_font_set* htx, fz_archive* zip, sbyte* base_uri, fz_buffer* buf, sbyte* user_css);

	// extern void fz_layout_html (fz_context *ctx, fz_html *html, float w, float h, float em);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_layout_html (fz_context* ctx, fz_html* html, float w, float h, float em);

	// extern void fz_draw_html (fz_context *ctx, fz_device *dev, const fz_matrix *ctm, fz_html *html, float page_top, float page_bot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_draw_html (fz_context* ctx, fz_device* dev, fz_matrix* ctm, fz_html* html, float page_top, float page_bot);

	// extern float fz_find_html_target (fz_context *ctx, fz_html *html, const char *id);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe float fz_find_html_target (fz_context* ctx, fz_html* html, sbyte* id);

	// extern fz_link * fz_load_html_links (fz_context *ctx, fz_html *html, int page, int page_h, const char *base_uri);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_link* fz_load_html_links (fz_context* ctx, fz_html* html, int page, int page_h, sbyte* base_uri);

	// extern void fz_drop_html (fz_context *ctx, fz_html *html);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void fz_drop_html (fz_context* ctx, fz_html* html);

	// extern int Memento_checkBlock (void *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int Memento_checkBlock (void*);

	// extern int Memento_checkAllMemory ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int Memento_checkAllMemory ();

	// extern int Memento_check ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int Memento_check ();

	// extern int Memento_setParanoia (int);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int Memento_setParanoia (int);

	// extern int Memento_paranoidAt (int);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int Memento_paranoidAt (int);

	// extern int Memento_breakAt (int);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int Memento_breakAt (int);

	// extern void Memento_breakOnFree (void *a);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void Memento_breakOnFree (void* a);

	// extern void Memento_breakOnRealloc (void *a);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void Memento_breakOnRealloc (void* a);

	// extern int Memento_getBlockNum (void *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int Memento_getBlockNum (void*);

	// extern int Memento_find (void *a);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int Memento_find (void* a);

	// extern void Memento_breakpoint ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void Memento_breakpoint ();

	// extern int Memento_failAt (int);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int Memento_failAt (int);

	// extern int Memento_failThisEvent ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int Memento_failThisEvent ();

	// extern void Memento_listBlocks ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void Memento_listBlocks ();

	// extern void Memento_listNewBlocks ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void Memento_listNewBlocks ();

	// extern size_t Memento_setMax (size_t);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern nuint Memento_setMax (nuint);

	// extern void Memento_stats ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void Memento_stats ();

	// extern void * Memento_label (void *, const char *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* Memento_label (void*, sbyte*);

	// extern void Memento_tick ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void Memento_tick ();

	// extern void * Memento_malloc (size_t s);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* Memento_malloc (nuint s);

	// extern void * Memento_realloc (void *, size_t s);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* Memento_realloc (void*, nuint s);

	// extern void Memento_free (void *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void Memento_free (void*);

	// extern void * Memento_calloc (size_t, size_t);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* Memento_calloc (nuint, nuint);

	// extern void Memento_info (void *addr);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void Memento_info (void* addr);

	// extern void Memento_listBlockInfo ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void Memento_listBlockInfo ();

	// extern void * Memento_takeRef (void *blk);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* Memento_takeRef (void* blk);

	// extern void * Memento_dropRef (void *blk);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* Memento_dropRef (void* blk);

	// extern void * Memento_adjustRef (void *blk, int adjust);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* Memento_adjustRef (void* blk, int adjust);

	// extern void * Memento_reference (void *blk);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* Memento_reference (void* blk);

	// extern void Memento_startLeaking ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void Memento_startLeaking ();

	// extern void Memento_stopLeaking ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void Memento_stopLeaking ();

	// extern void Memento_fin ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void Memento_fin ();

	// extern int pdfclean_main (int argc, char **argv);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdfclean_main (int argc, sbyte** argv);

	// extern const char * pdf_string_from_annot_type (fz_annot_type type);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_string_from_annot_type (fz_annot_type type);

	// extern int pdf_annot_type_from_string (const char *subtype);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_annot_type_from_string (sbyte* subtype);

	// extern int * pdf_first_annot (fz_context *ctx, int *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_first_annot (fz_context* ctx, int* page);

	// extern int * pdf_next_annot (fz_context *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_next_annot (fz_context* ctx, int* annot);

	// extern fz_rect * pdf_bound_annot (fz_context *ctx, int *annot, fz_rect *rect);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* pdf_bound_annot (fz_context* ctx, int* annot, fz_rect* rect);

	// extern int pdf_annot_type (fz_context *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_annot_type (fz_context* ctx, int* annot);

	// extern void pdf_run_annot (fz_context *ctx, int *annot, fz_device *dev, const fz_matrix *ctm, fz_cookie *cookie);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_run_annot (fz_context* ctx, int* annot, fz_device* dev, fz_matrix* ctm, fz_cookie* cookie);

	// extern char * pdf_parse_file_spec (fz_context *ctx, int *doc, int *file_spec, int *dest);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_parse_file_spec (fz_context* ctx, int* doc, int* file_spec, int* dest);

	// extern char * pdf_parse_link_dest (fz_context *ctx, int *doc, int *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_parse_link_dest (fz_context* ctx, int* doc, int* obj);

	// extern char * pdf_parse_link_action (fz_context *ctx, int *doc, int *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_parse_link_action (fz_context* ctx, int* doc, int* obj);

	// extern int * pdf_lookup_dest (fz_context *ctx, int *doc, int *needle);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_lookup_dest (fz_context* ctx, int* doc, int* needle);

	// extern int * pdf_lookup_name (fz_context *ctx, int *doc, int *which, int *needle);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_lookup_name (fz_context* ctx, int* doc, int* which, int* needle);

	// extern int * pdf_load_name_tree (fz_context *ctx, int *doc, int *which);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_load_name_tree (fz_context* ctx, int* doc, int* which);

	// extern int pdf_resolve_link (fz_context *ctx, int *doc, const char *uri, float *xp, float *yp);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_resolve_link (fz_context* ctx, int* doc, sbyte* uri, float* xp, float* yp);

	// extern fz_link * pdf_load_link_annots (fz_context *ctx, int *, int *annots, const fz_matrix *page_ctm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_link* pdf_load_link_annots (fz_context* ctx, int*, int* annots, fz_matrix* page_ctm);

	// extern void pdf_annot_transform (fz_context *ctx, int *annot, fz_matrix *annot_ctm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_annot_transform (fz_context* ctx, int* annot, fz_matrix* annot_ctm);

	// extern void pdf_load_annots (fz_context *ctx, int *page, int *annots);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_load_annots (fz_context* ctx, int* page, int* annots);

	// extern void pdf_update_annot (fz_context *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_update_annot (fz_context* ctx, int* annot);

	// extern void pdf_drop_annots (fz_context *ctx, int *annot_list);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_drop_annots (fz_context* ctx, int* annot_list);

	// extern int * pdf_create_annot (fz_context *ctx, int *page, fz_annot_type type);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_create_annot (fz_context* ctx, int* page, fz_annot_type type);

	// extern void pdf_delete_annot (fz_context *ctx, int *page, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_delete_annot (fz_context* ctx, int* page, int* annot);

	// extern int pdf_annot_flags (fz_context *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_annot_flags (fz_context* ctx, int* annot);

	// extern void pdf_annot_rect (fz_context *ctx, int *annot, fz_rect *rect);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_annot_rect (fz_context* ctx, int* annot, fz_rect* rect);

	// extern float pdf_annot_border (fz_context *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe float pdf_annot_border (fz_context* ctx, int* annot);

	// extern void pdf_annot_color (fz_context *ctx, int *annot, int *n, float *color);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_annot_color (fz_context* ctx, int* annot, int* n, float[] color);

	// extern void pdf_annot_interior_color (fz_context *ctx, int *annot, int *n, float *color);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_annot_interior_color (fz_context* ctx, int* annot, int* n, float[] color);

	// extern int pdf_annot_quad_point_count (fz_context *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_annot_quad_point_count (fz_context* ctx, int* annot);

	// extern void pdf_annot_quad_point (fz_context *ctx, int *annot, int i, float *qp);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_annot_quad_point (fz_context* ctx, int* annot, int i, float[] qp);

	// extern int pdf_annot_ink_list_count (fz_context *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_annot_ink_list_count (fz_context* ctx, int* annot);

	// extern int pdf_annot_ink_list_stroke_count (fz_context *ctx, int *annot, int i);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_annot_ink_list_stroke_count (fz_context* ctx, int* annot, int i);

	// extern void pdf_annot_ink_list_stroke_vertex (fz_context *ctx, int *annot, int i, int k, float *v);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_annot_ink_list_stroke_vertex (fz_context* ctx, int* annot, int i, int k, float[] v);

	// extern void pdf_set_annot_flags (fz_context *ctx, int *annot, int flags);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_annot_flags (fz_context* ctx, int* annot, int flags);

	// extern void pdf_set_annot_rect (fz_context *ctx, int *annot, const fz_rect *rect);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_annot_rect (fz_context* ctx, int* annot, fz_rect* rect);

	// extern void pdf_set_annot_border (fz_context *ctx, int *annot, float width);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_annot_border (fz_context* ctx, int* annot, float width);

	// extern void pdf_set_annot_color (fz_context *ctx, int *annot, int n, const float *color);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_annot_color (fz_context* ctx, int* annot, int n, float[] color);

	// extern void pdf_set_annot_interior_color (fz_context *ctx, int *annot, int n, const float *color);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_annot_interior_color (fz_context* ctx, int* annot, int n, float[] color);

	// extern void pdf_set_annot_quad_points (fz_context *ctx, int *annot, int n, const float *v);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_annot_quad_points (fz_context* ctx, int* annot, int n, float* v);

	// extern void pdf_set_annot_ink_list (fz_context *ctx, int *annot, int n, const int *count, const float *v);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_annot_ink_list (fz_context* ctx, int* annot, int n, int* count, float* v);

	// extern void pdf_set_annot_line_ending_styles (fz_context *ctx, int *annot, int start_style, int end_style);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_annot_line_ending_styles (fz_context* ctx, int* annot, int start_style, int end_style);

	// extern void pdf_set_annot_vertices (fz_context *ctx, int *annot, int n, const float *v);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_annot_vertices (fz_context* ctx, int* annot, int n, float* v);

	// extern void pdf_set_annot_icon_name (fz_context *ctx, int *annot, const char *name);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_annot_icon_name (fz_context* ctx, int* annot, sbyte* name);

	// extern void pdf_set_annot_is_open (fz_context *ctx, int *annot, int is_open);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_annot_is_open (fz_context* ctx, int* annot, int is_open);

	// extern void pdf_annot_line_ending_styles (fz_context *ctx, int *annot, int *start_style, int *end_style);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_annot_line_ending_styles (fz_context* ctx, int* annot, int* start_style, int* end_style);

	// extern const char * pdf_annot_icon_name (fz_context *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_annot_icon_name (fz_context* ctx, int* annot);

	// extern int pdf_annot_is_open (fz_context *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_annot_is_open (fz_context* ctx, int* annot);

	// extern int pdf_annot_vertex_count (fz_context *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_annot_vertex_count (fz_context* ctx, int* annot);

	// extern void pdf_annot_vertex (fz_context *ctx, int *annot, int i, float *v);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_annot_vertex (fz_context* ctx, int* annot, int i, float[] v);

	// extern void pdf_set_text_annot_position (fz_context *ctx, int *annot, fz_point pt);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_text_annot_position (fz_context* ctx, int* annot, fz_point pt);

	// extern void pdf_set_annot_contents (fz_context *ctx, int *annot, const char *text);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_annot_contents (fz_context* ctx, int* annot, sbyte* text);

	// extern const char * pdf_annot_contents (fz_context *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_annot_contents (fz_context* ctx, int* annot);

	// extern const char * pdf_annot_author (fz_context *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_annot_author (fz_context* ctx, int* annot);

	// extern const char * pdf_annot_date (fz_context *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_annot_date (fz_context* ctx, int* annot);

	// extern int * pdf_annot_irt (fz_context *ctx, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_annot_irt (fz_context* ctx, int* annot);

	// extern void pdf_set_free_text_details (fz_context *ctx, int *annot, fz_point *pos, char *text, char *font_name, float font_size, float *color);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_free_text_details (fz_context* ctx, int* annot, fz_point* pos, sbyte* text, sbyte* font_name, float font_size, float[] color);

	// extern int * pdf_new_annot (fz_context *ctx, int *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_new_annot (fz_context* ctx, int* page);

	// extern void pdf_da_info_fin (fz_context *ctx, pdf_da_info *di);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_da_info_fin (fz_context* ctx, pdf_da_info* di);

	// extern void pdf_parse_da (fz_context *ctx, char *da, pdf_da_info *di);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_parse_da (fz_context* ctx, sbyte* da, pdf_da_info* di);

	// extern void pdf_fzbuf_print_da (fz_context *ctx, fz_buffer *fzbuf, pdf_da_info *di);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_fzbuf_print_da (fz_context* ctx, fz_buffer* fzbuf, pdf_da_info* di);

	// extern void pdf_update_text_appearance (fz_context *ctx, int *doc, int *obj, char *eventValue);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_update_text_appearance (fz_context* ctx, int* doc, int* obj, sbyte* eventValue);

	// extern void pdf_update_combobox_appearance (fz_context *ctx, int *doc, int *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_update_combobox_appearance (fz_context* ctx, int* doc, int* obj);

	// extern void pdf_update_listbox_appearance (fz_context *ctx, int *doc, int *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_update_listbox_appearance (fz_context* ctx, int* doc, int* obj);

	// extern void pdf_update_pushbutton_appearance (fz_context *ctx, int *doc, int *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_update_pushbutton_appearance (fz_context* ctx, int* doc, int* obj);

	// extern void pdf_update_text_markup_appearance (fz_context *ctx, int *doc, int *annot, fz_annot_type type);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_update_text_markup_appearance (fz_context* ctx, int* doc, int* annot, fz_annot_type type);

	// extern void pdf_update_ink_appearance (fz_context *ctx, int *doc, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_update_ink_appearance (fz_context* ctx, int* doc, int* annot);

	// extern void pdf_update_text_annot_appearance (fz_context *ctx, int *doc, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_update_text_annot_appearance (fz_context* ctx, int* doc, int* annot);

	// extern void pdf_update_free_text_annot_appearance (fz_context *ctx, int *doc, int *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_update_free_text_annot_appearance (fz_context* ctx, int* doc, int* annot);

	// extern void pdf_set_annot_appearance (fz_context *ctx, int *doc, int *annot, fz_rect *rect, fz_display_list *disp_list);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_annot_appearance (fz_context* ctx, int* doc, int* annot, fz_rect* rect, fz_display_list* disp_list);

	// extern void pdf_set_markup_appearance (fz_context *ctx, int *doc, int *annot, float *color, float alpha, float line_thickness, float line_height);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_markup_appearance (fz_context* ctx, int* doc, int* annot, float[] color, float alpha, float line_thickness, float line_height);

	// extern void pdf_set_signature_appearance (fz_context *ctx, int *doc, int *annot, char *name, char *dn, char *date);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_signature_appearance (fz_context* ctx, int* doc, int* annot, sbyte* name, sbyte* dn, sbyte* date);

	// extern void pdf_clean_file (fz_context *ctx, char *infile, char *outfile, char *password, int *opts, char **retainlist, int retainlen);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_clean_file (fz_context* ctx, sbyte* infile, sbyte* outfile, sbyte* password, int* opts, sbyte*[] retainlist, int retainlen);

	// extern pdf_cmap * pdf_new_cmap (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_cmap* pdf_new_cmap (fz_context* ctx);

	// extern pdf_cmap * pdf_keep_cmap (fz_context *ctx, pdf_cmap *cmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_cmap* pdf_keep_cmap (fz_context* ctx, pdf_cmap* cmap);

	// extern void pdf_drop_cmap (fz_context *ctx, pdf_cmap *cmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_drop_cmap (fz_context* ctx, pdf_cmap* cmap);

	// extern void pdf_drop_cmap_imp (fz_context *ctx, fz_storable *cmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_drop_cmap_imp (fz_context* ctx, fz_storable* cmap);

	// extern size_t pdf_cmap_size (fz_context *ctx, pdf_cmap *cmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe nuint pdf_cmap_size (fz_context* ctx, pdf_cmap* cmap);

	// extern int pdf_cmap_wmode (fz_context *ctx, pdf_cmap *cmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_cmap_wmode (fz_context* ctx, pdf_cmap* cmap);

	// extern void pdf_set_cmap_wmode (fz_context *ctx, pdf_cmap *cmap, int wmode);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_cmap_wmode (fz_context* ctx, pdf_cmap* cmap, int wmode);

	// extern void pdf_set_usecmap (fz_context *ctx, pdf_cmap *cmap, pdf_cmap *usecmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_usecmap (fz_context* ctx, pdf_cmap* cmap, pdf_cmap* usecmap);

	// extern void pdf_add_codespace (fz_context *ctx, pdf_cmap *cmap, unsigned int low, unsigned int high, int n);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_add_codespace (fz_context* ctx, pdf_cmap* cmap, uint low, uint high, int n);

	// extern void pdf_map_range_to_table (fz_context *ctx, pdf_cmap *cmap, unsigned int low, int *map, int len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_map_range_to_table (fz_context* ctx, pdf_cmap* cmap, uint low, int* map, int len);

	// extern void pdf_map_range_to_range (fz_context *ctx, pdf_cmap *cmap, unsigned int srclo, unsigned int srchi, int dstlo);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_map_range_to_range (fz_context* ctx, pdf_cmap* cmap, uint srclo, uint srchi, int dstlo);

	// extern void pdf_map_one_to_many (fz_context *ctx, pdf_cmap *cmap, unsigned int one, int *many, int len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_map_one_to_many (fz_context* ctx, pdf_cmap* cmap, uint one, int* many, int len);

	// extern void pdf_sort_cmap (fz_context *ctx, pdf_cmap *cmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_sort_cmap (fz_context* ctx, pdf_cmap* cmap);

	// extern int pdf_lookup_cmap (pdf_cmap *cmap, unsigned int cpt);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_lookup_cmap (pdf_cmap* cmap, uint cpt);

	// extern int pdf_lookup_cmap_full (pdf_cmap *cmap, unsigned int cpt, int *out);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_lookup_cmap_full (pdf_cmap* cmap, uint cpt, int* @out);

	// extern int pdf_decode_cmap (pdf_cmap *cmap, unsigned char *s, unsigned char *e, unsigned int *cpt);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_decode_cmap (pdf_cmap* cmap, byte* s, byte* e, uint* cpt);

	// extern pdf_cmap * pdf_new_identity_cmap (fz_context *ctx, int wmode, int bytes);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_cmap* pdf_new_identity_cmap (fz_context* ctx, int wmode, int bytes);

	// extern pdf_cmap * pdf_load_cmap (fz_context *ctx, fz_stream *file);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_cmap* pdf_load_cmap (fz_context* ctx, fz_stream* file);

	// extern pdf_cmap * pdf_load_system_cmap (fz_context *ctx, const char *name);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_cmap* pdf_load_system_cmap (fz_context* ctx, sbyte* name);

	// extern pdf_cmap * pdf_load_builtin_cmap (fz_context *ctx, const char *name);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_cmap* pdf_load_builtin_cmap (fz_context* ctx, sbyte* name);

	// extern pdf_cmap * pdf_load_embedded_cmap (fz_context *ctx, int *doc, int *ref);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_cmap* pdf_load_embedded_cmap (fz_context* ctx, int* doc, int* @ref);

	// extern void pdf_print_cmap (fz_context *ctx, fz_output *out, pdf_cmap *cmap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_print_cmap (fz_context* ctx, fz_output* @out, pdf_cmap* cmap);

	// extern int * pdf_new_crypt (fz_context *ctx, int *enc, int *id);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_new_crypt (fz_context* ctx, int* enc, int* id);

	// extern void pdf_drop_crypt (fz_context *ctx, int *crypt);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_drop_crypt (fz_context* ctx, int* crypt);

	// extern void pdf_crypt_obj (fz_context *ctx, int *crypt, int *obj, int num, int gen);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_crypt_obj (fz_context* ctx, int* crypt, int* obj, int num, int gen);

	// extern void pdf_crypt_buffer (fz_context *ctx, int *crypt, fz_buffer *buf, int num, int gen);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_crypt_buffer (fz_context* ctx, int* crypt, fz_buffer* buf, int num, int gen);

	// extern fz_stream * pdf_open_crypt (fz_context *ctx, fz_stream *chain, int *crypt, int num, int gen);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* pdf_open_crypt (fz_context* ctx, fz_stream* chain, int* crypt, int num, int gen);

	// extern fz_stream * pdf_open_crypt_with_filter (fz_context *ctx, fz_stream *chain, int *crypt, int *name, int num, int gen);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* pdf_open_crypt_with_filter (fz_context* ctx, fz_stream* chain, int* crypt, int* name, int num, int gen);

	// extern int pdf_crypt_version (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_crypt_version (fz_context* ctx, int* doc);

	// extern int pdf_crypt_revision (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_crypt_revision (fz_context* ctx, int* doc);

	// extern char * pdf_crypt_method (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_crypt_method (fz_context* ctx, int* doc);

	// extern int pdf_crypt_length (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_crypt_length (fz_context* ctx, int* doc);

	// extern unsigned char * pdf_crypt_key (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe byte* pdf_crypt_key (fz_context* ctx, int* doc);

	// extern void pdf_print_crypt (fz_context *ctx, fz_output *out, int *crypt);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_print_crypt (fz_context* ctx, fz_output* @out, int* crypt);

	// extern void pdf_drop_designated_name (fz_context *ctx, pdf_designated_name *dn);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_drop_designated_name (fz_context* ctx, pdf_designated_name* dn);

	// extern int * pdf_read_pfx (fz_context *ctx, const char *sigfile, const char *password);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_read_pfx (fz_context* ctx, sbyte* sigfile, sbyte* password);

	// extern int * pdf_keep_signer (fz_context *ctx, int *signer);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_keep_signer (fz_context* ctx, int* signer);

	// extern void pdf_drop_signer (fz_context *ctx, int *signer);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_drop_signer (fz_context* ctx, int* signer);

	// extern pdf_designated_name * pdf_signer_designated_name (fz_context *ctx, int *signer);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_designated_name* pdf_signer_designated_name (fz_context* ctx, int* signer);

	// extern void pdf_write_digest (fz_context *ctx, int *doc, const char *filename, int *byte_range, int digest_offset, int digest_length, int *signer);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_write_digest (fz_context* ctx, int* doc, sbyte* filename, int* byte_range, int digest_offset, int digest_length, int* signer);

	// extern int pdf_signature_widget_byte_range (fz_context *ctx, int *doc, int *widget, int (*)[2] byte_range);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_signature_widget_byte_range (fz_context* ctx, int* doc, int* widget, int[]* byte_range);

	// extern int pdf_signature_widget_contents (fz_context *ctx, int *doc, int *widget, char **contents);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_signature_widget_contents (fz_context* ctx, int* doc, int* widget, sbyte** contents);

	// extern int pdf_check_signature (fz_context *ctx, int *doc, int *widget, char *file, char *ebuf, int ebufsize);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_check_signature (fz_context* ctx, int* doc, int* widget, sbyte* file, sbyte* ebuf, int ebufsize);

	// extern void pdf_sign_signature (fz_context *ctx, int *doc, int *widget, const char *sigfile, const char *password);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_sign_signature (fz_context* ctx, int* doc, int* widget, sbyte* sigfile, sbyte* password);

	// extern int * pdf_open_document (fz_context *ctx, const char *filename);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_open_document (fz_context* ctx, sbyte* filename);

	// extern int * pdf_open_document_with_stream (fz_context *ctx, fz_stream *file);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_open_document_with_stream (fz_context* ctx, fz_stream* file);

	// extern void pdf_drop_document (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_drop_document (fz_context* ctx, int* doc);

	// extern int * pdf_specifics (fz_context *ctx, fz_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_specifics (fz_context* ctx, fz_document* doc);

	// extern int * pdf_document_from_fz_document (fz_context *ctx, fz_document *ptr);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_document_from_fz_document (fz_context* ctx, fz_document* ptr);

	// extern pdf_page * pdf_page_from_fz_page (fz_context *ctx, fz_page *ptr);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_page* pdf_page_from_fz_page (fz_context* ctx, fz_page* ptr);

	// extern pdf_annot * pdf_annot_from_fz_annot (fz_context *ctx, fz_annot *ptr);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_annot* pdf_annot_from_fz_annot (fz_context* ctx, fz_annot* ptr);

	// extern int pdf_needs_password (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_needs_password (fz_context* ctx, int* doc);

	// extern int pdf_authenticate_password (fz_context *ctx, int *doc, const char *pw);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_authenticate_password (fz_context* ctx, int* doc, sbyte* pw);

	// extern int pdf_has_permission (fz_context *ctx, int *doc, fz_permission p);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_has_permission (fz_context* ctx, int* doc, fz_permission p);

	// extern int pdf_lookup_metadata (fz_context *ctx, int *doc, const char *key, char *ptr, int size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_lookup_metadata (fz_context* ctx, int* doc, sbyte* key, sbyte* ptr, int size);

	// extern fz_outline * pdf_load_outline (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_outline* pdf_load_outline (fz_context* ctx, int* doc);

	// extern int pdf_count_layer_configs (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_count_layer_configs (fz_context* ctx, int* doc);

	// extern void pdf_layer_config_info (fz_context *ctx, int *doc, int config_num, pdf_layer_config *info);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_layer_config_info (fz_context* ctx, int* doc, int config_num, pdf_layer_config* info);

	// extern void pdf_select_layer_config (fz_context *ctx, int *doc, int config_num);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_select_layer_config (fz_context* ctx, int* doc, int config_num);

	// extern int pdf_count_layer_config_ui (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_count_layer_config_ui (fz_context* ctx, int* doc);

	// extern void pdf_select_layer_config_ui (fz_context *ctx, int *doc, int ui);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_select_layer_config_ui (fz_context* ctx, int* doc, int ui);

	// extern void pdf_deselect_layer_config_ui (fz_context *ctx, int *doc, int ui);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_deselect_layer_config_ui (fz_context* ctx, int* doc, int ui);

	// extern void pdf_toggle_layer_config_ui (fz_context *ctx, int *doc, int ui);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_toggle_layer_config_ui (fz_context* ctx, int* doc, int ui);

	// extern void pdf_layer_config_ui_info (fz_context *ctx, int *doc, int ui, pdf_layer_config_ui *info);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_layer_config_ui_info (fz_context* ctx, int* doc, int ui, pdf_layer_config_ui* info);

	// extern void pdf_set_layer_config_as_default (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_layer_config_as_default (fz_context* ctx, int* doc);

	// extern void pdf_update_page (fz_context *ctx, pdf_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_update_page (fz_context* ctx, pdf_page* page);

	// extern int pdf_has_unsaved_changes (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_has_unsaved_changes (fz_context* ctx, int* doc);

	// extern int * pdf_create_document (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_create_document (fz_context* ctx);

	// extern pdf_graft_map * pdf_new_graft_map (fz_context *ctx, int *src);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_graft_map* pdf_new_graft_map (fz_context* ctx, int* src);

	// extern void pdf_drop_graft_map (fz_context *ctx, pdf_graft_map *map);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_drop_graft_map (fz_context* ctx, pdf_graft_map* map);

	// extern int * pdf_graft_object (fz_context *ctx, int *dst, int *src, int *obj, pdf_graft_map *map);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_graft_object (fz_context* ctx, int* dst, int* src, int* obj, pdf_graft_map* map);

	// extern fz_device * pdf_page_write (fz_context *ctx, int *doc, const fz_rect *mediabox, int **presources, fz_buffer **pcontents);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_device* pdf_page_write (fz_context* ctx, int* doc, fz_rect* mediabox, int** presources, fz_buffer** pcontents);

	// extern int * pdf_add_page (fz_context *ctx, int *doc, const fz_rect *mediabox, int rotate, int *resources, fz_buffer *contents);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_add_page (fz_context* ctx, int* doc, fz_rect* mediabox, int rotate, int* resources, fz_buffer* contents);

	// extern void pdf_insert_page (fz_context *ctx, int *doc, int at, int *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_insert_page (fz_context* ctx, int* doc, int at, int* page);

	// extern void pdf_delete_page (fz_context *ctx, int *doc, int number);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_delete_page (fz_context* ctx, int* doc, int number);

	// extern void pdf_delete_page_range (fz_context *ctx, int *doc, int start, int end);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_delete_page_range (fz_context* ctx, int* doc, int start, int end);

	// extern void pdf_finish_edit (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_finish_edit (fz_context* ctx, int* doc);

	// extern int pdf_recognize (fz_context *doc, const char *magic);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_recognize (fz_context* doc, sbyte* magic);

	// extern pdf_write_options * pdf_parse_write_options (fz_context *ctx, pdf_write_options *opts, const char *args);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_write_options* pdf_parse_write_options (fz_context* ctx, pdf_write_options* opts, sbyte* args);

	// extern int pdf_has_unsaved_sigs (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_has_unsaved_sigs (fz_context* ctx, int* doc);

	// extern void pdf_write_document (fz_context *ctx, int *doc, fz_output *out, pdf_write_options *opts);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_write_document (fz_context* ctx, int* doc, fz_output* @out, pdf_write_options* opts);

	// extern void pdf_save_document (fz_context *ctx, int *doc, const char *filename, pdf_write_options *opts);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_save_document (fz_context* ctx, int* doc, sbyte* filename, pdf_write_options* opts);

	// extern int pdf_can_be_saved_incrementally (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_can_be_saved_incrementally (fz_context* ctx, int* doc);

	// extern void pdf_init_ui_pointer_event (pdf_ui_event *event, int type, float x, float y);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_init_ui_pointer_event (pdf_ui_event* @event, int type, float x, float y);

	// extern int pdf_pass_event (fz_context *ctx, int *doc, pdf_page *page, pdf_ui_event *ui_event);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_pass_event (fz_context* ctx, int* doc, pdf_page* page, pdf_ui_event* ui_event);

	// extern void pdf_set_doc_event_callback (fz_context *ctx, int *doc, pdf_doc_event_cb *event_cb, void *data);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_doc_event_callback (fz_context* ctx, int* doc, pdf_doc_event_cb* event_cb, void* data);

	// extern pdf_alert_event * pdf_access_alert_event (fz_context *ctx, pdf_doc_event *event);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_alert_event* pdf_access_alert_event (fz_context* ctx, pdf_doc_event* @event);

	// extern const char * pdf_access_exec_menu_item_event (fz_context *ctx, pdf_doc_event *event);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_access_exec_menu_item_event (fz_context* ctx, pdf_doc_event* @event);

	// extern pdf_submit_event * pdf_access_submit_event (fz_context *ctx, pdf_doc_event *event);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_submit_event* pdf_access_submit_event (fz_context* ctx, pdf_doc_event* @event);

	// extern pdf_launch_url_event * pdf_access_launch_url_event (fz_context *ctx, pdf_doc_event *event);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_launch_url_event* pdf_access_launch_url_event (fz_context* ctx, pdf_doc_event* @event);

	// extern pdf_mail_doc_event * pdf_access_mail_doc_event (fz_context *ctx, pdf_doc_event *event);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_mail_doc_event* pdf_access_mail_doc_event (fz_context* ctx, pdf_doc_event* @event);

	// extern void pdf_event_issue_alert (fz_context *ctx, int *doc, pdf_alert_event *event);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_event_issue_alert (fz_context* ctx, int* doc, pdf_alert_event* @event);

	// extern void pdf_event_issue_print (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_event_issue_print (fz_context* ctx, int* doc);

	// extern void pdf_event_issue_exec_menu_item (fz_context *ctx, int *doc, const char *item);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_event_issue_exec_menu_item (fz_context* ctx, int* doc, sbyte* item);

	// extern void pdf_event_issue_exec_dialog (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_event_issue_exec_dialog (fz_context* ctx, int* doc);

	// extern void pdf_event_issue_launch_url (fz_context *ctx, int *doc, const char *url, int new_frame);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_event_issue_launch_url (fz_context* ctx, int* doc, sbyte* url, int new_frame);

	// extern void pdf_event_issue_mail_doc (fz_context *ctx, int *doc, pdf_mail_doc_event *event);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_event_issue_mail_doc (fz_context* ctx, int* doc, pdf_mail_doc_event* @event);

	// extern char * pdf_get_string_or_stream (fz_context *ctx, int *doc, int *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_get_string_or_stream (fz_context* ctx, int* doc, int* obj);

	// extern int * pdf_get_inheritable (fz_context *ctx, int *doc, int *obj, int *key);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_get_inheritable (fz_context* ctx, int* doc, int* obj, int* key);

	// extern int pdf_get_field_flags (fz_context *ctx, int *doc, int *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_get_field_flags (fz_context* ctx, int* doc, int* obj);

	// extern int pdf_field_type (fz_context *ctx, int *doc, int *field);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_field_type (fz_context* ctx, int* doc, int* field);

	// extern void pdf_set_field_type (fz_context *ctx, int *doc, int *obj, int type);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_field_type (fz_context* ctx, int* doc, int* obj, int type);

	// extern char * pdf_field_value (fz_context *ctx, int *doc, int *field);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_field_value (fz_context* ctx, int* doc, int* field);

	// extern int pdf_field_set_value (fz_context *ctx, int *doc, int *field, const char *text);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_field_set_value (fz_context* ctx, int* doc, int* field, sbyte* text);

	// extern char * pdf_field_border_style (fz_context *ctx, int *doc, int *field);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_field_border_style (fz_context* ctx, int* doc, int* field);

	// extern void pdf_field_set_border_style (fz_context *ctx, int *doc, int *field, const char *text);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_field_set_border_style (fz_context* ctx, int* doc, int* field, sbyte* text);

	// extern void pdf_field_set_button_caption (fz_context *ctx, int *doc, int *field, const char *text);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_field_set_button_caption (fz_context* ctx, int* doc, int* field, sbyte* text);

	// extern void pdf_field_set_fill_color (fz_context *ctx, int *doc, int *field, int *col);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_field_set_fill_color (fz_context* ctx, int* doc, int* field, int* col);

	// extern void pdf_field_set_text_color (fz_context *ctx, int *doc, int *field, int *col);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_field_set_text_color (fz_context* ctx, int* doc, int* field, int* col);

	// extern void pdf_signature_set_value (fz_context *ctx, int *doc, int *field, pdf_signer *signer);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_signature_set_value (fz_context* ctx, int* doc, int* field, pdf_signer* signer);

	// extern int pdf_field_display (fz_context *ctx, int *doc, int *field);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_field_display (fz_context* ctx, int* doc, int* field);

	// extern char * pdf_field_name (fz_context *ctx, int *doc, int *field);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_field_name (fz_context* ctx, int* doc, int* field);

	// extern void pdf_field_set_display (fz_context *ctx, int *doc, int *field, int d);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_field_set_display (fz_context* ctx, int* doc, int* field, int d);

	// extern int * pdf_lookup_field (fz_context *ctx, int *form, char *name);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_lookup_field (fz_context* ctx, int* form, sbyte* name);

	// extern void pdf_field_reset (fz_context *ctx, int *doc, int *field);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_field_reset (fz_context* ctx, int* doc, int* field);

	// extern int pdf_signatures_supported (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_signatures_supported (fz_context* ctx);

	// extern void pdf_load_encoding (char **estrings, char *encoding);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_load_encoding (sbyte** estrings, sbyte* encoding);

	// extern int pdf_lookup_agl (char *name);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_lookup_agl (sbyte* name);

	// extern const char ** pdf_lookup_agl_duplicates (int ucs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte** pdf_lookup_agl_duplicates (int ucs);

	// extern void pdf_set_font_wmode (fz_context *ctx, pdf_font_desc *font, int wmode);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_font_wmode (fz_context* ctx, pdf_font_desc* font, int wmode);

	// extern void pdf_set_default_hmtx (fz_context *ctx, pdf_font_desc *font, int w);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_default_hmtx (fz_context* ctx, pdf_font_desc* font, int w);

	// extern void pdf_set_default_vmtx (fz_context *ctx, pdf_font_desc *font, int y, int w);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_default_vmtx (fz_context* ctx, pdf_font_desc* font, int y, int w);

	// extern void pdf_add_hmtx (fz_context *ctx, pdf_font_desc *font, int lo, int hi, int w);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_add_hmtx (fz_context* ctx, pdf_font_desc* font, int lo, int hi, int w);

	// extern void pdf_add_vmtx (fz_context *ctx, pdf_font_desc *font, int lo, int hi, int x, int y, int w);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_add_vmtx (fz_context* ctx, pdf_font_desc* font, int lo, int hi, int x, int y, int w);

	// extern void pdf_end_hmtx (fz_context *ctx, pdf_font_desc *font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_end_hmtx (fz_context* ctx, pdf_font_desc* font);

	// extern void pdf_end_vmtx (fz_context *ctx, pdf_font_desc *font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_end_vmtx (fz_context* ctx, pdf_font_desc* font);

	// extern pdf_hmtx pdf_lookup_hmtx (fz_context *ctx, pdf_font_desc *font, int cid);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_hmtx pdf_lookup_hmtx (fz_context* ctx, pdf_font_desc* font, int cid);

	// extern pdf_vmtx pdf_lookup_vmtx (fz_context *ctx, pdf_font_desc *font, int cid);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_vmtx pdf_lookup_vmtx (fz_context* ctx, pdf_font_desc* font, int cid);

	// extern void pdf_load_to_unicode (fz_context *ctx, int *doc, pdf_font_desc *font, char **strings, char *collection, int *cmapstm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_load_to_unicode (fz_context* ctx, int* doc, pdf_font_desc* font, sbyte** strings, sbyte* collection, int* cmapstm);

	// extern int pdf_font_cid_to_gid (fz_context *ctx, pdf_font_desc *fontdesc, int cid);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_font_cid_to_gid (fz_context* ctx, pdf_font_desc* fontdesc, int cid);

	// extern const char * pdf_lookup_substitute_font (fz_context *ctx, int mono, int serif, int bold, int italic, int *len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_lookup_substitute_font (fz_context* ctx, int mono, int serif, int bold, int italic, int* len);

	// extern pdf_font_desc * pdf_load_type3_font (fz_context *ctx, int *doc, int *rdb, int *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_font_desc* pdf_load_type3_font (fz_context* ctx, int* doc, int* rdb, int* obj);

	// extern void pdf_load_type3_glyphs (fz_context *ctx, int *doc, pdf_font_desc *fontdesc, int nestedDepth);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_load_type3_glyphs (fz_context* ctx, int* doc, pdf_font_desc* fontdesc, int nestedDepth);

	// extern pdf_font_desc * pdf_load_font (fz_context *ctx, int *doc, int *rdb, int *obj, int nestedDepth);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_font_desc* pdf_load_font (fz_context* ctx, int* doc, int* rdb, int* obj, int nestedDepth);

	// extern pdf_font_desc * pdf_load_hail_mary_font (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_font_desc* pdf_load_hail_mary_font (fz_context* ctx, int* doc);

	// extern pdf_font_desc * pdf_new_font_desc (fz_context *ctx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_font_desc* pdf_new_font_desc (fz_context* ctx);

	// extern pdf_font_desc * pdf_keep_font (fz_context *ctx, pdf_font_desc *fontdesc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_font_desc* pdf_keep_font (fz_context* ctx, pdf_font_desc* fontdesc);

	// extern void pdf_drop_font (fz_context *ctx, pdf_font_desc *font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_drop_font (fz_context* ctx, pdf_font_desc* font);

	// extern void pdf_print_font (fz_context *ctx, fz_output *out, pdf_font_desc *fontdesc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_print_font (fz_context* ctx, fz_output* @out, pdf_font_desc* fontdesc);

	// extern fz_rect * pdf_measure_text (fz_context *ctx, pdf_font_desc *fontdesc, unsigned char *buf, size_t len, fz_rect *rect);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* pdf_measure_text (fz_context* ctx, pdf_font_desc* fontdesc, byte* buf, nuint len, fz_rect* rect);

	// extern float pdf_text_stride (fz_context *ctx, pdf_font_desc *fontdesc, float fontsize, unsigned char *buf, size_t len, float room, size_t *count);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe float pdf_text_stride (fz_context* ctx, pdf_font_desc* fontdesc, float fontsize, byte* buf, nuint len, float room, nuint* count);

	// extern void pdf_run_glyph (fz_context *ctx, int *doc, int *resources, fz_buffer *contents, fz_device *dev, const fz_matrix *ctm, void *gstate, int nestedDepth);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_run_glyph (fz_context* ctx, int* doc, int* resources, fz_buffer* contents, fz_device* dev, fz_matrix* ctm, void* gstate, int nestedDepth);

	// extern int * pdf_add_simple_font (fz_context *ctx, int *doc, fz_font *font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_add_simple_font (fz_context* ctx, int* doc, fz_font* font);

	// extern int * pdf_add_cid_font (fz_context *ctx, int *doc, fz_font *font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int* pdf_add_cid_font (fz_context* ctx, int* doc, fz_font* font);

	// extern int pdf_font_writing_supported (fz_font *font);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_font_writing_supported (fz_font* font);

	// extern void * pdf_new_processor (fz_context *ctx, int size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* pdf_new_processor (fz_context* ctx, int size);

	// extern void pdf_close_processor (fz_context *ctx, pdf_processor *proc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_close_processor (fz_context* ctx, pdf_processor* proc);

	// extern void pdf_drop_processor (fz_context *ctx, pdf_processor *proc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_drop_processor (fz_context* ctx, pdf_processor* proc);

	// extern pdf_processor * pdf_new_run_processor (fz_context *ctx, fz_device *dev, const fz_matrix *ctm, const char *usage, pdf_gstate *gstate, int nested);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_processor* pdf_new_run_processor (fz_context* ctx, fz_device* dev, fz_matrix* ctm, sbyte* usage, pdf_gstate* gstate, int nested);

	// extern pdf_processor * pdf_new_buffer_processor (fz_context *ctx, fz_buffer *buffer, int ahxencode);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_processor* pdf_new_buffer_processor (fz_context* ctx, fz_buffer* buffer, int ahxencode);

	// extern pdf_processor * pdf_new_filter_processor (fz_context *ctx, pdf_processor *chain, int *doc, int *old_res, int *new_res);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_processor* pdf_new_filter_processor (fz_context* ctx, pdf_processor* chain, int* doc, int* old_res, int* new_res);

	// extern void pdf_process_contents (fz_context *ctx, pdf_processor *proc, int *doc, int *obj, int *res, fz_cookie *cookie);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_process_contents (fz_context* ctx, pdf_processor* proc, int* doc, int* obj, int* res, fz_cookie* cookie);

	// extern void pdf_process_annot (fz_context *ctx, pdf_processor *proc, int *doc, pdf_page *page, pdf_annot *annot, fz_cookie *cookie);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_process_annot (fz_context* ctx, pdf_processor* proc, int* doc, pdf_page* page, pdf_annot* annot, fz_cookie* cookie);

	// extern void pdf_process_glyph (fz_context *ctx, pdf_processor *proc, int *doc, int *resources, fz_buffer *contents);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_process_glyph (fz_context* ctx, pdf_processor* proc, int* doc, int* resources, fz_buffer* contents);

	// extern void pdf_enable_js (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_enable_js (fz_context* ctx, int* doc);

	// extern void pdf_disable_js (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_disable_js (fz_context* ctx, int* doc);

	// extern int pdf_js_supported (fz_context *ctx, int *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_js_supported (fz_context* ctx, int* doc);

	// extern void pdf_drop_js (fz_context *ctx, pdf_js *js);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_drop_js (fz_context* ctx, pdf_js* js);

	// extern void pdf_js_setup_event (pdf_js *js, pdf_js_event *e);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_js_setup_event (pdf_js* js, pdf_js_event* e);

	// extern pdf_js_event * pdf_js_get_event (pdf_js *js);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_js_event* pdf_js_get_event (pdf_js* js);

	// extern void pdf_js_execute (pdf_js *js, char *code);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_js_execute (pdf_js* js, sbyte* code);

	// extern pdf_obj * pdf_new_null (fz_context *ctx, pdf_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_new_null (fz_context* ctx, pdf_document* doc);

	// extern pdf_obj * pdf_new_bool (fz_context *ctx, pdf_document *doc, int b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_new_bool (fz_context* ctx, pdf_document* doc, int b);

	// extern pdf_obj * pdf_new_int (fz_context *ctx, pdf_document *doc, int i);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_new_int (fz_context* ctx, pdf_document* doc, int i);

	// extern pdf_obj * pdf_new_int_offset (fz_context *ctx, pdf_document *doc, fz_off_t off);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_new_int_offset (fz_context* ctx, pdf_document* doc, int off);

	// extern pdf_obj * pdf_new_real (fz_context *ctx, pdf_document *doc, float f);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_new_real (fz_context* ctx, pdf_document* doc, float f);

	// extern pdf_obj * pdf_new_name (fz_context *ctx, pdf_document *doc, const char *str);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_new_name (fz_context* ctx, pdf_document* doc, sbyte* str);

	// extern pdf_obj * pdf_new_string (fz_context *ctx, pdf_document *doc, const char *str, size_t len);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_new_string (fz_context* ctx, pdf_document* doc, sbyte* str, nuint len);

	// extern pdf_obj * pdf_new_indirect (fz_context *ctx, pdf_document *doc, int num, int gen);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_new_indirect (fz_context* ctx, pdf_document* doc, int num, int gen);

	// extern pdf_obj * pdf_new_array (fz_context *ctx, pdf_document *doc, int initialcap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_new_array (fz_context* ctx, pdf_document* doc, int initialcap);

	// extern pdf_obj * pdf_new_dict (fz_context *ctx, pdf_document *doc, int initialcap);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_new_dict (fz_context* ctx, pdf_document* doc, int initialcap);

	// extern pdf_obj * pdf_new_rect (fz_context *ctx, pdf_document *doc, const fz_rect *rect);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_new_rect (fz_context* ctx, pdf_document* doc, fz_rect* rect);

	// extern pdf_obj * pdf_new_matrix (fz_context *ctx, pdf_document *doc, const fz_matrix *mtx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_new_matrix (fz_context* ctx, pdf_document* doc, fz_matrix* mtx);

	// extern pdf_obj * pdf_copy_array (fz_context *ctx, pdf_obj *array);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_copy_array (fz_context* ctx, pdf_obj* array);

	// extern pdf_obj * pdf_copy_dict (fz_context *ctx, pdf_obj *dict);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_copy_dict (fz_context* ctx, pdf_obj* dict);

	// extern pdf_obj * pdf_deep_copy_obj (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_deep_copy_obj (fz_context* ctx, pdf_obj* obj);

	// extern pdf_obj * pdf_new_obj_from_str (fz_context *ctx, pdf_document *doc, const char *src);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_new_obj_from_str (fz_context* ctx, pdf_document* doc, sbyte* src);

	// extern pdf_obj * pdf_keep_obj (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_keep_obj (fz_context* ctx, pdf_obj* obj);

	// extern void pdf_drop_obj (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_drop_obj (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_is_null (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_is_null (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_is_bool (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_is_bool (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_is_int (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_is_int (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_is_real (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_is_real (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_is_number (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_is_number (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_is_name (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_is_name (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_is_string (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_is_string (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_is_array (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_is_array (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_is_dict (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_is_dict (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_is_indirect (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_is_indirect (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_obj_num_is_stream (fz_context *ctx, pdf_document *doc, int num);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_obj_num_is_stream (fz_context* ctx, pdf_document* doc, int num);

	// extern int pdf_is_stream (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_is_stream (fz_context* ctx, pdf_obj* obj);

	// extern pdf_obj * pdf_resolve_obj (fz_context *ctx, pdf_obj *a);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_resolve_obj (fz_context* ctx, pdf_obj* a);

	// extern int pdf_objcmp (fz_context *ctx, pdf_obj *a, pdf_obj *b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_objcmp (fz_context* ctx, pdf_obj* a, pdf_obj* b);

	// extern int pdf_objcmp_resolve (fz_context *ctx, pdf_obj *a, pdf_obj *b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_objcmp_resolve (fz_context* ctx, pdf_obj* a, pdf_obj* b);

	// int pdf_name_eq (fz_context *ctx, pdf_obj *a, pdf_obj *b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_name_eq (fz_context* ctx, pdf_obj* a, pdf_obj* b);

	// extern int pdf_obj_marked (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_obj_marked (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_mark_obj (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_mark_obj (fz_context* ctx, pdf_obj* obj);

	// extern void pdf_unmark_obj (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_unmark_obj (fz_context* ctx, pdf_obj* obj);

	// extern void pdf_set_obj_memo (fz_context *ctx, pdf_obj *obj, int memo);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_obj_memo (fz_context* ctx, pdf_obj* obj, int memo);

	// extern int pdf_obj_memo (fz_context *ctx, pdf_obj *obj, int *memo);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_obj_memo (fz_context* ctx, pdf_obj* obj, int* memo);

	// extern int pdf_obj_is_dirty (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_obj_is_dirty (fz_context* ctx, pdf_obj* obj);

	// extern void pdf_dirty_obj (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_dirty_obj (fz_context* ctx, pdf_obj* obj);

	// extern void pdf_clean_obj (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_clean_obj (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_to_bool (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_to_bool (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_to_int (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_to_int (fz_context* ctx, pdf_obj* obj);

	// extern fz_off_t pdf_to_offset (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_to_offset (fz_context* ctx, pdf_obj* obj);

	// extern float pdf_to_real (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe float pdf_to_real (fz_context* ctx, pdf_obj* obj);

	// extern char * pdf_to_name (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_to_name (fz_context* ctx, pdf_obj* obj);

	// extern char * pdf_to_str_buf (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_to_str_buf (fz_context* ctx, pdf_obj* obj);

	// extern pdf_obj * pdf_to_dict (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_to_dict (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_to_str_len (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_to_str_len (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_to_num (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_to_num (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_to_gen (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_to_gen (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_array_len (fz_context *ctx, pdf_obj *array);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_array_len (fz_context* ctx, pdf_obj* array);

	// extern pdf_obj * pdf_array_get (fz_context *ctx, pdf_obj *array, int i);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_array_get (fz_context* ctx, pdf_obj* array, int i);

	// extern void pdf_array_put (fz_context *ctx, pdf_obj *array, int i, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_array_put (fz_context* ctx, pdf_obj* array, int i, pdf_obj* obj);

	// extern void pdf_array_put_drop (fz_context *ctx, pdf_obj *array, int i, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_array_put_drop (fz_context* ctx, pdf_obj* array, int i, pdf_obj* obj);

	// extern void pdf_array_push (fz_context *ctx, pdf_obj *array, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_array_push (fz_context* ctx, pdf_obj* array, pdf_obj* obj);

	// extern void pdf_array_push_drop (fz_context *ctx, pdf_obj *array, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_array_push_drop (fz_context* ctx, pdf_obj* array, pdf_obj* obj);

	// extern void pdf_array_insert (fz_context *ctx, pdf_obj *array, pdf_obj *obj, int index);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_array_insert (fz_context* ctx, pdf_obj* array, pdf_obj* obj, int index);

	// extern void pdf_array_insert_drop (fz_context *ctx, pdf_obj *array, pdf_obj *obj, int index);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_array_insert_drop (fz_context* ctx, pdf_obj* array, pdf_obj* obj, int index);

	// extern void pdf_array_delete (fz_context *ctx, pdf_obj *array, int index);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_array_delete (fz_context* ctx, pdf_obj* array, int index);

	// extern int pdf_array_find (fz_context *ctx, pdf_obj *array, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_array_find (fz_context* ctx, pdf_obj* array, pdf_obj* obj);

	// extern int pdf_array_contains (fz_context *ctx, pdf_obj *array, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_array_contains (fz_context* ctx, pdf_obj* array, pdf_obj* obj);

	// extern int pdf_dict_len (fz_context *ctx, pdf_obj *dict);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_dict_len (fz_context* ctx, pdf_obj* dict);

	// extern pdf_obj * pdf_dict_get_key (fz_context *ctx, pdf_obj *dict, int idx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_dict_get_key (fz_context* ctx, pdf_obj* dict, int idx);

	// extern pdf_obj * pdf_dict_get_val (fz_context *ctx, pdf_obj *dict, int idx);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_dict_get_val (fz_context* ctx, pdf_obj* dict, int idx);

	// extern void pdf_dict_put_val_drop (fz_context *ctx, pdf_obj *obj, int i, pdf_obj *new_obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_dict_put_val_drop (fz_context* ctx, pdf_obj* obj, int i, pdf_obj* new_obj);

	// extern pdf_obj * pdf_dict_get (fz_context *ctx, pdf_obj *dict, pdf_obj *key);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_dict_get (fz_context* ctx, pdf_obj* dict, pdf_obj* key);

	// extern pdf_obj * pdf_dict_getp (fz_context *ctx, pdf_obj *dict, const char *path);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_dict_getp (fz_context* ctx, pdf_obj* dict, sbyte* path);

	// extern pdf_obj * pdf_dict_getl (fz_context *ctx, pdf_obj *dict, ...);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_dict_getl (fz_context* ctx, pdf_obj* dict, IntPtr varArgs);

	// extern pdf_obj * pdf_dict_geta (fz_context *ctx, pdf_obj *dict, pdf_obj *key, pdf_obj *abbrev);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_dict_geta (fz_context* ctx, pdf_obj* dict, pdf_obj* key, pdf_obj* abbrev);

	// extern pdf_obj * pdf_dict_gets (fz_context *ctx, pdf_obj *dict, const char *key);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_dict_gets (fz_context* ctx, pdf_obj* dict, sbyte* key);

	// extern pdf_obj * pdf_dict_getsa (fz_context *ctx, pdf_obj *dict, const char *key, const char *abbrev);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_dict_getsa (fz_context* ctx, pdf_obj* dict, sbyte* key, sbyte* abbrev);

	// extern void pdf_dict_put (fz_context *ctx, pdf_obj *dict, pdf_obj *key, pdf_obj *val);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_dict_put (fz_context* ctx, pdf_obj* dict, pdf_obj* key, pdf_obj* val);

	// extern void pdf_dict_put_drop (fz_context *ctx, pdf_obj *dict, pdf_obj *key, pdf_obj *val);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_dict_put_drop (fz_context* ctx, pdf_obj* dict, pdf_obj* key, pdf_obj* val);

	// extern void pdf_dict_get_put_drop (fz_context *ctx, pdf_obj *dict, pdf_obj *key, pdf_obj *val, pdf_obj **old_val);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_dict_get_put_drop (fz_context* ctx, pdf_obj* dict, pdf_obj* key, pdf_obj* val, pdf_obj** old_val);

	// extern void pdf_dict_puts (fz_context *ctx, pdf_obj *dict, const char *key, pdf_obj *val);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_dict_puts (fz_context* ctx, pdf_obj* dict, sbyte* key, pdf_obj* val);

	// extern void pdf_dict_puts_drop (fz_context *ctx, pdf_obj *dict, const char *key, pdf_obj *val);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_dict_puts_drop (fz_context* ctx, pdf_obj* dict, sbyte* key, pdf_obj* val);

	// extern void pdf_dict_putp (fz_context *ctx, pdf_obj *dict, const char *path, pdf_obj *val);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_dict_putp (fz_context* ctx, pdf_obj* dict, sbyte* path, pdf_obj* val);

	// extern void pdf_dict_putp_drop (fz_context *ctx, pdf_obj *dict, const char *path, pdf_obj *val);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_dict_putp_drop (fz_context* ctx, pdf_obj* dict, sbyte* path, pdf_obj* val);

	// extern void pdf_dict_putl (fz_context *ctx, pdf_obj *dict, pdf_obj *val, ...);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_dict_putl (fz_context* ctx, pdf_obj* dict, pdf_obj* val, IntPtr varArgs);

	// extern void pdf_dict_putl_drop (fz_context *ctx, pdf_obj *dict, pdf_obj *val, ...);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_dict_putl_drop (fz_context* ctx, pdf_obj* dict, pdf_obj* val, IntPtr varArgs);

	// extern void pdf_dict_del (fz_context *ctx, pdf_obj *dict, pdf_obj *key);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_dict_del (fz_context* ctx, pdf_obj* dict, pdf_obj* key);

	// extern void pdf_dict_dels (fz_context *ctx, pdf_obj *dict, const char *key);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_dict_dels (fz_context* ctx, pdf_obj* dict, sbyte* key);

	// extern void pdf_sort_dict (fz_context *ctx, pdf_obj *dict);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_sort_dict (fz_context* ctx, pdf_obj* dict);

	// extern void pdf_set_obj_parent (fz_context *ctx, pdf_obj *obj, int num);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_obj_parent (fz_context* ctx, pdf_obj* obj, int num);

	// extern int pdf_obj_refs (fz_context *ctx, pdf_obj *ref);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_obj_refs (fz_context* ctx, pdf_obj* @ref);

	// extern int pdf_obj_parent_num (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_obj_parent_num (fz_context* ctx, pdf_obj* obj);

	// extern int pdf_sprint_obj (fz_context *ctx, char *s, int n, pdf_obj *obj, int tight);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_sprint_obj (fz_context* ctx, sbyte* s, int n, pdf_obj* obj, int tight);

	// extern int pdf_print_obj (fz_context *ctx, fz_output *out, pdf_obj *obj, int tight);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_print_obj (fz_context* ctx, fz_output* @out, pdf_obj* obj, int tight);

	// extern char * pdf_to_utf8 (fz_context *ctx, pdf_obj *src);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_to_utf8 (fz_context* ctx, pdf_obj* src);

	// extern char * pdf_load_stream_as_utf8 (fz_context *ctx, pdf_obj *src);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_load_stream_as_utf8 (fz_context* ctx, pdf_obj* src);

	// extern char * pdf_load_stream_or_string_as_utf8 (fz_context *ctx, pdf_obj *src);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_load_stream_or_string_as_utf8 (fz_context* ctx, pdf_obj* src);

	// extern unsigned short * pdf_to_ucs2 (fz_context *ctx, pdf_obj *src);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe ushort* pdf_to_ucs2 (fz_context* ctx, pdf_obj* src);

	// extern pdf_obj * pdf_to_utf8_name (fz_context *ctx, pdf_document *doc, pdf_obj *src);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_to_utf8_name (fz_context* ctx, pdf_document* doc, pdf_obj* src);

	// extern char * pdf_from_ucs2 (fz_context *ctx, unsigned short *str);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_from_ucs2 (fz_context* ctx, ushort* str);

	// extern void pdf_to_ucs2_buf (fz_context *ctx, unsigned short *buffer, pdf_obj *src);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_to_ucs2_buf (fz_context* ctx, ushort* buffer, pdf_obj* src);

	// extern fz_rect * pdf_to_rect (fz_context *ctx, pdf_obj *array, fz_rect *rect);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* pdf_to_rect (fz_context* ctx, pdf_obj* array, fz_rect* rect);

	// extern fz_matrix * pdf_to_matrix (fz_context *ctx, pdf_obj *array, fz_matrix *mat);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_matrix* pdf_to_matrix (fz_context* ctx, pdf_obj* array, fz_matrix* mat);

	// extern pdf_document * pdf_get_indirect_document (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_document* pdf_get_indirect_document (fz_context* ctx, pdf_obj* obj);

	// extern pdf_document * pdf_get_bound_document (fz_context *ctx, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_document* pdf_get_bound_document (fz_context* ctx, pdf_obj* obj);

	// extern void pdf_set_str_len (fz_context *ctx, pdf_obj *obj, int newlen);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_str_len (fz_context* ctx, pdf_obj* obj, int newlen);

	// extern void pdf_set_int (fz_context *ctx, pdf_obj *obj, int i);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_int (fz_context* ctx, pdf_obj* obj, int i);

	// extern void pdf_set_int_offset (fz_context *ctx, pdf_obj *obj, fz_off_t i);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_int_offset (fz_context* ctx, pdf_obj* obj, int i);

	// extern fz_device * pdf_new_pdf_device (fz_context *ctx, pdf_document *doc, const fz_matrix *topctm, const fz_rect *mediabox, pdf_obj *resources, fz_buffer *contents);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_device* pdf_new_pdf_device (fz_context* ctx, pdf_document* doc, fz_matrix* topctm, fz_rect* mediabox, pdf_obj* resources, fz_buffer* contents);

	// extern void pdf_localise_page_resources (fz_context *ctx, pdf_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_localise_page_resources (fz_context* ctx, pdf_document* doc);

	// extern int pdf_lookup_page_number (fz_context *ctx, pdf_document *doc, pdf_obj *pageobj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_lookup_page_number (fz_context* ctx, pdf_document* doc, pdf_obj* pageobj);

	// extern int pdf_count_pages (fz_context *ctx, pdf_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_count_pages (fz_context* ctx, pdf_document* doc);

	// extern pdf_obj * pdf_lookup_page_obj (fz_context *ctx, pdf_document *doc, int needle);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_lookup_page_obj (fz_context* ctx, pdf_document* doc, int needle);

	// extern int pdf_lookup_anchor (fz_context *ctx, pdf_document *doc, const char *name, float *xp, float *yp);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_lookup_anchor (fz_context* ctx, pdf_document* doc, sbyte* name, float* xp, float* yp);

	// extern void pdf_flatten_inheritable_page_items (fz_context *ctx, pdf_obj *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_flatten_inheritable_page_items (fz_context* ctx, pdf_obj* page);

	// extern pdf_page * pdf_load_page (fz_context *ctx, pdf_document *doc, int number);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_page* pdf_load_page (fz_context* ctx, pdf_document* doc, int number);

	// extern void pdf_drop_page (fz_context *ctx, pdf_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_drop_page (fz_context* ctx, pdf_page* page);

	// extern void pdf_page_obj_transform (fz_context *ctx, pdf_obj *pageobj, fz_rect *page_mediabox, fz_matrix *page_ctm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_page_obj_transform (fz_context* ctx, pdf_obj* pageobj, fz_rect* page_mediabox, fz_matrix* page_ctm);

	// extern void pdf_page_transform (fz_context *ctx, pdf_page *page, fz_rect *mediabox, fz_matrix *ctm);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_page_transform (fz_context* ctx, pdf_page* page, fz_rect* mediabox, fz_matrix* ctm);

	// extern pdf_obj * pdf_page_resources (fz_context *ctx, pdf_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_page_resources (fz_context* ctx, pdf_page* page);

	// extern pdf_obj * pdf_page_contents (fz_context *ctx, pdf_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_page_contents (fz_context* ctx, pdf_page* page);

	// extern fz_link * pdf_load_links (fz_context *ctx, pdf_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_link* pdf_load_links (fz_context* ctx, pdf_page* page);

	// extern fz_rect * pdf_bound_page (fz_context *ctx, pdf_page *page, fz_rect *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* pdf_bound_page (fz_context* ctx, pdf_page* page, fz_rect*);

	// extern void pdf_run_page (fz_context *ctx, pdf_page *page, fz_device *dev, const fz_matrix *ctm, fz_cookie *cookie);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_run_page (fz_context* ctx, pdf_page* page, fz_device* dev, fz_matrix* ctm, fz_cookie* cookie);

	// extern void pdf_run_page_with_usage (fz_context *ctx, pdf_document *doc, pdf_page *page, fz_device *dev, const fz_matrix *ctm, const char *usage, fz_cookie *cookie);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_run_page_with_usage (fz_context* ctx, pdf_document* doc, pdf_page* page, fz_device* dev, fz_matrix* ctm, sbyte* usage, fz_cookie* cookie);

	// extern void pdf_run_page_contents (fz_context *ctx, pdf_page *page, fz_device *dev, const fz_matrix *ctm, fz_cookie *cookie);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_run_page_contents (fz_context* ctx, pdf_page* page, fz_device* dev, fz_matrix* ctm, fz_cookie* cookie);

	// extern void pdf_clean_page_contents (fz_context *ctx, pdf_document *doc, pdf_page *page, fz_cookie *cookie, pdf_page_contents_process_fn *proc, void *proc_arg, int ascii);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_clean_page_contents (fz_context* ctx, pdf_document* doc, pdf_page* page, fz_cookie* cookie, pdf_page_contents_process_fn* proc, void* proc_arg, int ascii);

	// extern void pdf_clean_annot_contents (fz_context *ctx, pdf_document *doc, pdf_annot *annot, fz_cookie *cookie, pdf_page_contents_process_fn *proc, void *proc_arg, int ascii);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_clean_annot_contents (fz_context* ctx, pdf_document* doc, pdf_annot* annot, fz_cookie* cookie, pdf_page_contents_process_fn* proc, void* proc_arg, int ascii);

	// extern fz_transition * pdf_page_presentation (fz_context *ctx, pdf_page *page, fz_transition *transition, float *duration);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_transition* pdf_page_presentation (fz_context* ctx, pdf_page* page, fz_transition* transition, float* duration);

	// extern void pdf_lexbuf_init (fz_context *ctx, pdf_lexbuf *lexbuf, int size);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_lexbuf_init (fz_context* ctx, pdf_lexbuf* lexbuf, int size);

	// extern void pdf_lexbuf_fin (fz_context *ctx, pdf_lexbuf *lexbuf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_lexbuf_fin (fz_context* ctx, pdf_lexbuf* lexbuf);

	// extern ptrdiff_t pdf_lexbuf_grow (fz_context *ctx, pdf_lexbuf *lexbuf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe IntPtr pdf_lexbuf_grow (fz_context* ctx, pdf_lexbuf* lexbuf);

	// extern pdf_token pdf_lex (fz_context *ctx, fz_stream *f, pdf_lexbuf *lexbuf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_token pdf_lex (fz_context* ctx, fz_stream* f, pdf_lexbuf* lexbuf);

	// extern pdf_token pdf_lex_no_string (fz_context *ctx, fz_stream *f, pdf_lexbuf *lexbuf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_token pdf_lex_no_string (fz_context* ctx, fz_stream* f, pdf_lexbuf* lexbuf);

	// extern pdf_obj * pdf_parse_array (fz_context *ctx, pdf_document *doc, fz_stream *f, pdf_lexbuf *buf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_parse_array (fz_context* ctx, pdf_document* doc, fz_stream* f, pdf_lexbuf* buf);

	// extern pdf_obj * pdf_parse_dict (fz_context *ctx, pdf_document *doc, fz_stream *f, pdf_lexbuf *buf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_parse_dict (fz_context* ctx, pdf_document* doc, fz_stream* f, pdf_lexbuf* buf);

	// extern pdf_obj * pdf_parse_stm_obj (fz_context *ctx, pdf_document *doc, fz_stream *f, pdf_lexbuf *buf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_parse_stm_obj (fz_context* ctx, pdf_document* doc, fz_stream* f, pdf_lexbuf* buf);

	// extern pdf_obj * pdf_parse_ind_obj (fz_context *ctx, pdf_document *doc, fz_stream *f, pdf_lexbuf *buf, int *num, int *gen, fz_off_t *stm_ofs, int *try_repair);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_parse_ind_obj (fz_context* ctx, pdf_document* doc, fz_stream* f, pdf_lexbuf* buf, int* num, int* gen, int* stm_ofs, int* try_repair);

	// extern void pdf_print_token (fz_context *ctx, fz_buffer *buf, int tok, pdf_lexbuf *lex);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_print_token (fz_context* ctx, fz_buffer* buf, int tok, pdf_lexbuf* lex);

	// extern void pdf_store_item (fz_context *ctx, pdf_obj *key, void *val, size_t itemsize);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_store_item (fz_context* ctx, pdf_obj* key, void* val, nuint itemsize);

	// extern void * pdf_find_item (fz_context *ctx, fz_store_drop_fn *drop, pdf_obj *key);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void* pdf_find_item (fz_context* ctx, fz_store_drop_fn* drop, pdf_obj* key);

	// extern void pdf_remove_item (fz_context *ctx, fz_store_drop_fn *drop, pdf_obj *key);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_remove_item (fz_context* ctx, fz_store_drop_fn* drop, pdf_obj* key);

	// extern void pdf_empty_store (fz_context *ctx, pdf_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_empty_store (fz_context* ctx, pdf_document* doc);

	// extern pdf_obj * pdf_find_font_resource (fz_context *ctx, pdf_document *doc, fz_buffer *item, unsigned char *md5);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_find_font_resource (fz_context* ctx, pdf_document* doc, fz_buffer* item, byte[] md5);

	// extern pdf_obj * pdf_insert_font_resource (fz_context *ctx, pdf_document *doc, unsigned char *md5, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_insert_font_resource (fz_context* ctx, pdf_document* doc, byte[] md5, pdf_obj* obj);

	// extern pdf_obj * pdf_find_image_resource (fz_context *ctx, pdf_document *doc, fz_image *item, unsigned char *md5);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_find_image_resource (fz_context* ctx, pdf_document* doc, fz_image* item, byte[] md5);

	// extern pdf_obj * pdf_insert_image_resource (fz_context *ctx, pdf_document *doc, unsigned char *md5, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_insert_image_resource (fz_context* ctx, pdf_document* doc, byte[] md5, pdf_obj* obj);

	// extern void pdf_drop_resource_tables (fz_context *ctx, pdf_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_drop_resource_tables (fz_context* ctx, pdf_document* doc);

	// extern fz_function * pdf_load_function (fz_context *ctx, pdf_document *doc, pdf_obj *ref, int in, int out);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_function* pdf_load_function (fz_context* ctx, pdf_document* doc, pdf_obj* @ref, int @in, int @out);

	// extern fz_colorspace * pdf_load_colorspace (fz_context *ctx, pdf_document *doc, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_colorspace* pdf_load_colorspace (fz_context* ctx, pdf_document* doc, pdf_obj* obj);

	// extern int pdf_is_tint_colorspace (fz_context *ctx, fz_colorspace *cs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_is_tint_colorspace (fz_context* ctx, fz_colorspace* cs);

	// extern fz_shade * pdf_load_shading (fz_context *ctx, pdf_document *doc, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_shade* pdf_load_shading (fz_context* ctx, pdf_document* doc, pdf_obj* obj);

	// extern fz_image * pdf_load_inline_image (fz_context *ctx, pdf_document *doc, pdf_obj *rdb, pdf_obj *dict, fz_stream *file);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_image* pdf_load_inline_image (fz_context* ctx, pdf_document* doc, pdf_obj* rdb, pdf_obj* dict, fz_stream* file);

	// extern int pdf_is_jpx_image (fz_context *ctx, pdf_obj *dict);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_is_jpx_image (fz_context* ctx, pdf_obj* dict);

	// extern fz_image * pdf_load_image (fz_context *ctx, pdf_document *doc, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_image* pdf_load_image (fz_context* ctx, pdf_document* doc, pdf_obj* obj);

	// extern pdf_obj * pdf_add_image (fz_context *ctx, pdf_document *doc, fz_image *image, int mask);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_add_image (fz_context* ctx, pdf_document* doc, fz_image* image, int mask);

	// extern pdf_pattern * pdf_load_pattern (fz_context *ctx, pdf_document *doc, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_pattern* pdf_load_pattern (fz_context* ctx, pdf_document* doc, pdf_obj* obj);

	// extern pdf_pattern * pdf_keep_pattern (fz_context *ctx, pdf_pattern *pat);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_pattern* pdf_keep_pattern (fz_context* ctx, pdf_pattern* pat);

	// extern void pdf_drop_pattern (fz_context *ctx, pdf_pattern *pat);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_drop_pattern (fz_context* ctx, pdf_pattern* pat);

	// extern pdf_xobject * pdf_load_xobject (fz_context *ctx, pdf_document *doc, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_xobject* pdf_load_xobject (fz_context* ctx, pdf_document* doc, pdf_obj* obj);

	// extern pdf_obj * pdf_new_xobject (fz_context *ctx, pdf_document *doc, const fz_rect *bbox, const fz_matrix *mat);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_new_xobject (fz_context* ctx, pdf_document* doc, fz_rect* bbox, fz_matrix* mat);

	// extern pdf_xobject * pdf_keep_xobject (fz_context *ctx, pdf_xobject *xobj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_xobject* pdf_keep_xobject (fz_context* ctx, pdf_xobject* xobj);

	// extern void pdf_drop_xobject (fz_context *ctx, pdf_xobject *xobj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_drop_xobject (fz_context* ctx, pdf_xobject* xobj);

	// extern void pdf_update_xobject_contents (fz_context *ctx, pdf_document *doc, pdf_xobject *form, fz_buffer *buffer);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_update_xobject_contents (fz_context* ctx, pdf_document* doc, pdf_xobject* form, fz_buffer* buffer);

	// extern void pdf_update_appearance (fz_context *ctx, pdf_document *doc, pdf_annot *annot);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_update_appearance (fz_context* ctx, pdf_document* doc, pdf_annot* annot);

	// extern pdf_obj * pdf_xobject_resources (fz_context *ctx, pdf_xobject *xobj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_xobject_resources (fz_context* ctx, pdf_xobject* xobj);

	// extern fz_rect * pdf_xobject_bbox (fz_context *ctx, pdf_xobject *xobj, fz_rect *bbox);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* pdf_xobject_bbox (fz_context* ctx, pdf_xobject* xobj, fz_rect* bbox);

	// extern fz_matrix * pdf_xobject_matrix (fz_context *ctx, pdf_xobject *xobj, fz_matrix *matrix);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_matrix* pdf_xobject_matrix (fz_context* ctx, pdf_xobject* xobj, fz_matrix* matrix);

	// extern int pdf_xobject_isolated (fz_context *ctx, pdf_xobject *xobj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_xobject_isolated (fz_context* ctx, pdf_xobject* xobj);

	// extern int pdf_xobject_knockout (fz_context *ctx, pdf_xobject *xobj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_xobject_knockout (fz_context* ctx, pdf_xobject* xobj);

	// extern int pdf_xobject_transparency (fz_context *ctx, pdf_xobject *xobj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_xobject_transparency (fz_context* ctx, pdf_xobject* xobj);

	// extern fz_colorspace * pdf_xobject_colorspace (fz_context *ctx, pdf_xobject *xobj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_colorspace* pdf_xobject_colorspace (fz_context* ctx, pdf_xobject* xobj);

	// extern pdf_widget * pdf_focused_widget (fz_context *ctx, pdf_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_widget* pdf_focused_widget (fz_context* ctx, pdf_document* doc);

	// extern pdf_widget * pdf_first_widget (fz_context *ctx, pdf_document *doc, pdf_page *page);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_widget* pdf_first_widget (fz_context* ctx, pdf_document* doc, pdf_page* page);

	// extern pdf_widget * pdf_next_widget (fz_context *ctx, pdf_widget *previous);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_widget* pdf_next_widget (fz_context* ctx, pdf_widget* previous);

	// extern pdf_widget * pdf_create_widget (fz_context *ctx, pdf_document *doc, pdf_page *page, int type, char *fieldname);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_widget* pdf_create_widget (fz_context* ctx, pdf_document* doc, pdf_page* page, int type, sbyte* fieldname);

	// extern int pdf_widget_type (fz_context *ctx, pdf_widget *widget);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_widget_type (fz_context* ctx, pdf_widget* widget);

	// extern fz_rect * pdf_bound_widget (fz_context *ctx, pdf_widget *widget, fz_rect *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_rect* pdf_bound_widget (fz_context* ctx, pdf_widget* widget, fz_rect*);

	// extern char * pdf_text_widget_text (fz_context *ctx, pdf_document *doc, pdf_widget *tw);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe sbyte* pdf_text_widget_text (fz_context* ctx, pdf_document* doc, pdf_widget* tw);

	// extern int pdf_text_widget_max_len (fz_context *ctx, pdf_document *doc, pdf_widget *tw);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_text_widget_max_len (fz_context* ctx, pdf_document* doc, pdf_widget* tw);

	// extern int pdf_text_widget_content_type (fz_context *ctx, pdf_document *doc, pdf_widget *tw);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_text_widget_content_type (fz_context* ctx, pdf_document* doc, pdf_widget* tw);

	// extern int pdf_text_widget_set_text (fz_context *ctx, pdf_document *doc, pdf_widget *tw, char *text);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_text_widget_set_text (fz_context* ctx, pdf_document* doc, pdf_widget* tw, sbyte* text);

	// extern int pdf_choice_widget_options (fz_context *ctx, pdf_document *doc, pdf_widget *tw, int exportval, char **opts);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_choice_widget_options (fz_context* ctx, pdf_document* doc, pdf_widget* tw, int exportval, sbyte*[] opts);

	// extern int pdf_choice_widget_is_multiselect (fz_context *ctx, pdf_document *doc, pdf_widget *tw);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_choice_widget_is_multiselect (fz_context* ctx, pdf_document* doc, pdf_widget* tw);

	// extern int pdf_choice_widget_value (fz_context *ctx, pdf_document *doc, pdf_widget *tw, char **opts);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_choice_widget_value (fz_context* ctx, pdf_document* doc, pdf_widget* tw, sbyte*[] opts);

	// extern void pdf_choice_widget_set_value (fz_context *ctx, pdf_document *doc, pdf_widget *tw, int n, char **opts);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_choice_widget_set_value (fz_context* ctx, pdf_document* doc, pdf_widget* tw, int n, sbyte*[] opts);

	// extern int pdf_create_object (fz_context *ctx, pdf_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_create_object (fz_context* ctx, pdf_document* doc);

	// extern void pdf_delete_object (fz_context *ctx, pdf_document *doc, int num);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_delete_object (fz_context* ctx, pdf_document* doc, int num);

	// extern void pdf_update_object (fz_context *ctx, pdf_document *doc, int num, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_update_object (fz_context* ctx, pdf_document* doc, int num, pdf_obj* obj);

	// extern void pdf_update_stream (fz_context *ctx, pdf_document *doc, pdf_obj *ref, fz_buffer *buf, int compressed);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_update_stream (fz_context* ctx, pdf_document* doc, pdf_obj* @ref, fz_buffer* buf, int compressed);

	// extern pdf_obj * pdf_add_object (fz_context *ctx, pdf_document *doc, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_add_object (fz_context* ctx, pdf_document* doc, pdf_obj* obj);

	// extern pdf_obj * pdf_add_object_drop (fz_context *ctx, pdf_document *doc, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_add_object_drop (fz_context* ctx, pdf_document* doc, pdf_obj* obj);

	// extern pdf_obj * pdf_add_stream (fz_context *ctx, pdf_document *doc, fz_buffer *buf, pdf_obj *obj, int compressed);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_add_stream (fz_context* ctx, pdf_document* doc, fz_buffer* buf, pdf_obj* obj, int compressed);

	// extern pdf_xref_entry * pdf_cache_object (fz_context *ctx, pdf_document *doc, int num);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_xref_entry* pdf_cache_object (fz_context* ctx, pdf_document* doc, int num);

	// extern int pdf_count_objects (fz_context *ctx, pdf_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_count_objects (fz_context* ctx, pdf_document* doc);

	// extern pdf_obj * pdf_resolve_indirect (fz_context *ctx, pdf_obj *ref);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_resolve_indirect (fz_context* ctx, pdf_obj* @ref);

	// extern pdf_obj * pdf_resolve_indirect_chain (fz_context *ctx, pdf_obj *ref);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_resolve_indirect_chain (fz_context* ctx, pdf_obj* @ref);

	// extern pdf_obj * pdf_load_object (fz_context *ctx, pdf_document *doc, int num);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_load_object (fz_context* ctx, pdf_document* doc, int num);

	// extern fz_buffer * pdf_load_raw_stream_number (fz_context *ctx, pdf_document *doc, int num);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* pdf_load_raw_stream_number (fz_context* ctx, pdf_document* doc, int num);

	// extern fz_buffer * pdf_load_raw_stream (fz_context *ctx, pdf_obj *ref);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* pdf_load_raw_stream (fz_context* ctx, pdf_obj* @ref);

	// extern fz_buffer * pdf_load_stream_number (fz_context *ctx, pdf_document *doc, int num);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* pdf_load_stream_number (fz_context* ctx, pdf_document* doc, int num);

	// extern fz_buffer * pdf_load_stream (fz_context *ctx, pdf_obj *ref);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* pdf_load_stream (fz_context* ctx, pdf_obj* @ref);

	// extern fz_stream * pdf_open_raw_stream_number (fz_context *ctx, pdf_document *doc, int num);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* pdf_open_raw_stream_number (fz_context* ctx, pdf_document* doc, int num);

	// extern fz_stream * pdf_open_raw_stream (fz_context *ctx, pdf_obj *ref);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* pdf_open_raw_stream (fz_context* ctx, pdf_obj* @ref);

	// extern fz_stream * pdf_open_stream_number (fz_context *ctx, pdf_document *doc, int num);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* pdf_open_stream_number (fz_context* ctx, pdf_document* doc, int num);

	// extern fz_stream * pdf_open_stream (fz_context *ctx, pdf_obj *ref);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* pdf_open_stream (fz_context* ctx, pdf_obj* @ref);

	// extern fz_stream * pdf_open_inline_stream (fz_context *ctx, pdf_document *doc, pdf_obj *stmobj, int length, fz_stream *chain, fz_compression_params *params);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* pdf_open_inline_stream (fz_context* ctx, pdf_document* doc, pdf_obj* stmobj, int length, fz_stream* chain, fz_compression_params* @params);

	// extern fz_compressed_buffer * pdf_load_compressed_stream (fz_context *ctx, pdf_document *doc, int num);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_compressed_buffer* pdf_load_compressed_stream (fz_context* ctx, pdf_document* doc, int num);

	// extern void pdf_load_compressed_inline_image (fz_context *ctx, pdf_document *doc, pdf_obj *dict, int length, fz_stream *cstm, int indexed, fz_compressed_image *image);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_load_compressed_inline_image (fz_context* ctx, pdf_document* doc, pdf_obj* dict, int length, fz_stream* cstm, int indexed, fz_compressed_image* image);

	// extern fz_stream * pdf_open_stream_with_offset (fz_context *ctx, pdf_document *doc, int num, pdf_obj *dict, fz_off_t stm_ofs);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* pdf_open_stream_with_offset (fz_context* ctx, pdf_document* doc, int num, pdf_obj* dict, int stm_ofs);

	// extern fz_stream * pdf_open_compressed_stream (fz_context *ctx, fz_compressed_buffer *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* pdf_open_compressed_stream (fz_context* ctx, fz_compressed_buffer*);

	// extern fz_stream * pdf_open_contents_stream (fz_context *ctx, pdf_document *doc, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_stream* pdf_open_contents_stream (fz_context* ctx, pdf_document* doc, pdf_obj* obj);

	// extern fz_buffer * pdf_load_stream_truncated (fz_context *ctx, pdf_document *doc, int num, int *truncated);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_buffer* pdf_load_stream_truncated (fz_context* ctx, pdf_document* doc, int num, int* truncated);

	// extern pdf_obj * pdf_trailer (fz_context *ctx, pdf_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_trailer (fz_context* ctx, pdf_document* doc);

	// extern void pdf_set_populating_xref_trailer (fz_context *ctx, pdf_document *doc, pdf_obj *trailer);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_set_populating_xref_trailer (fz_context* ctx, pdf_document* doc, pdf_obj* trailer);

	// extern int pdf_xref_len (fz_context *ctx, pdf_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_xref_len (fz_context* ctx, pdf_document* doc);

	// extern pdf_xref_entry * pdf_get_populating_xref_entry (fz_context *ctx, pdf_document *doc, int i);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_xref_entry* pdf_get_populating_xref_entry (fz_context* ctx, pdf_document* doc, int i);

	// extern pdf_xref_entry * pdf_get_xref_entry (fz_context *ctx, pdf_document *doc, int i);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_xref_entry* pdf_get_xref_entry (fz_context* ctx, pdf_document* doc, int i);

	// extern void pdf_replace_xref (fz_context *ctx, pdf_document *doc, pdf_xref_entry *entries, int n);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_replace_xref (fz_context* ctx, pdf_document* doc, pdf_xref_entry* entries, int n);

	// extern void pdf_xref_ensure_incremental_object (fz_context *ctx, pdf_document *doc, int num);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_xref_ensure_incremental_object (fz_context* ctx, pdf_document* doc, int num);

	// extern int pdf_xref_is_incremental (fz_context *ctx, pdf_document *doc, int num);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_xref_is_incremental (fz_context* ctx, pdf_document* doc, int num);

	// extern void pdf_xref_store_unsaved_signature (fz_context *ctx, pdf_document *doc, pdf_obj *field, pdf_signer *signer);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_xref_store_unsaved_signature (fz_context* ctx, pdf_document* doc, pdf_obj* field, pdf_signer* signer);

	// extern int pdf_xref_obj_is_unsaved_signature (pdf_document *doc, pdf_obj *obj);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_xref_obj_is_unsaved_signature (pdf_document* doc, pdf_obj* obj);

	// extern void pdf_repair_xref (fz_context *ctx, pdf_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_repair_xref (fz_context* ctx, pdf_document* doc);

	// extern void pdf_repair_obj_stms (fz_context *ctx, pdf_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_repair_obj_stms (fz_context* ctx, pdf_document* doc);

	// extern void pdf_ensure_solid_xref (fz_context *ctx, pdf_document *doc, int num);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_ensure_solid_xref (fz_context* ctx, pdf_document* doc, int num);

	// extern void pdf_mark_xref (fz_context *ctx, pdf_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_mark_xref (fz_context* ctx, pdf_document* doc);

	// extern void pdf_clear_xref (fz_context *ctx, pdf_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_clear_xref (fz_context* ctx, pdf_document* doc);

	// extern void pdf_clear_xref_to_mark (fz_context *ctx, pdf_document *doc);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_clear_xref_to_mark (fz_context* ctx, pdf_document* doc);

	// extern int pdf_repair_obj (fz_context *ctx, pdf_document *doc, pdf_lexbuf *buf, fz_off_t *stmofsp, int *stmlenp, pdf_obj **encrypt, pdf_obj **id, pdf_obj **page, fz_off_t *tmpofs, pdf_obj **root);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe int pdf_repair_obj (fz_context* ctx, pdf_document* doc, pdf_lexbuf* buf, int* stmofsp, int* stmlenp, pdf_obj** encrypt, pdf_obj** id, pdf_obj** page, int* tmpofs, pdf_obj** root);

	// extern pdf_obj * pdf_progressive_advance (fz_context *ctx, pdf_document *doc, int pagenum);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe pdf_obj* pdf_progressive_advance (fz_context* ctx, pdf_document* doc, int pagenum);

	// extern void pdf_print_xref (fz_context *ctx, pdf_document *);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe void pdf_print_xref (fz_context* ctx, pdf_document*);

	// extern fz_display_list * fz_new_display_list_from_svg (fz_context *ctx, fz_buffer *buf, float *w, float *h);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_display_list* fz_new_display_list_from_svg (fz_context* ctx, fz_buffer* buf, float* w, float* h);

	// extern fz_image * fz_new_image_from_svg (fz_context *ctx, fz_buffer *buf);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe fz_image* fz_new_image_from_svg (fz_context* ctx, fz_buffer* buf);
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_archive_s
{
	public unsafe int* file;

	public unsafe sbyte* format;

	public unsafe Action<int*, mupdf.fz_archive*>* drop_archive;

	public unsafe Func<int*, mupdf.fz_archive*, int>* count_entries;

	public unsafe Func<int*, mupdf.fz_archive*, int, sbyte*>* list_entry;

	public unsafe Func<int*, mupdf.fz_archive*, sbyte*, int>* has_entry;

	public unsafe Func<int*, mupdf.fz_archive*, sbyte*, int*>* read_entry;

	public unsafe Func<int*, mupdf.fz_archive*, sbyte*, int*>* open_entry;
}

public enum fz_bidi_direction : uint
{
	Ltr = 0,
	Rtl = 1,
	Neutral = 2
}

public enum fz_bidi_flags : uint
{
	ClassifyWhiteSpace = 1,
	ReplaceTab = 2
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_bitmap_s
{
	public int refs;

	public int w;

	public int h;

	public int stride;

	public int n;

	public int xres;

	public int yres;

	public unsafe byte* samples;
}

public enum  : uint
{
	FzMaxColors = 32
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_color_converter_s
{
	public unsafe Action<int*, mupdf.fz_color_converter*, float*, float*>* convert;

	public unsafe fz_colorspace* ds;

	public unsafe fz_colorspace* ss;

	public unsafe void* opaque;
}

[Verify (InferredFromMemberPrefix)]
public enum FzImage : uint
{
	Unknown = 0,
	Raw,
	Fax,
	Flate,
	Lzw,
	Rld,
	Bmp,
	Gif,
	Jpeg,
	Jpx,
	Jxr,
	Png,
	Pnm,
	Tiff
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_compression_params_s
{
	public int type;

	[StructLayout (LayoutKind.Explicit)]
	public struct U
	{
		[StructLayout (LayoutKind.Sequential)]
		public struct Jpeg
		{
			public int color_transform;
		}


		[FieldOffset (0)]
		public Jpeg jpeg;

		[StructLayout (LayoutKind.Sequential)]
		public struct Jpx
		{
			public int smask_in_data;
		}


		[FieldOffset (0)]
		public Jpx jpx;

		[StructLayout (LayoutKind.Sequential)]
		public struct Fax
		{
			public int columns;

			public int rows;

			public int k;

			public int end_of_line;

			public int encoded_byte_align;

			public int end_of_block;

			public int black_is_1;

			public int damaged_rows_before_error;
		}


		[FieldOffset (0)]
		public Fax fax;

		[StructLayout (LayoutKind.Sequential)]
		public struct Flate
		{
			public int columns;

			public int colors;

			public int predictor;

			public int bpc;
		}


		[FieldOffset (0)]
		public Flate flate;

		[StructLayout (LayoutKind.Sequential)]
		public struct Lzw
		{
			public int columns;

			public int colors;

			public int predictor;

			public int bpc;

			public int early_change;
		}


		[FieldOffset (0)]
		public Lzw lzw;
	}


	public U u;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_compressed_buffer_s
{
	public fz_compression_params @params;

	public unsafe fz_buffer* buffer;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_alloc_context_s
{
	public unsafe void* user;

	public unsafe Func<void*, nuint, void*>* malloc;

	public unsafe Func<void*, void*, nuint, void*>* realloc;

	public unsafe Action<void*, void*>* free;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_error_stack_slot_s
{
	public int code;

	public int buffer;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_error_context_s
{
	public unsafe fz_error_stack_slot* top;

	public fz_error_stack_slot[] stack;

	public int errcode;

	public sbyte[] message;
}

[Verify (InferredFromMemberPrefix)]
public enum FzError : uint
{
	None = 0,
	Oom = 1,
	Generic = 2,
	Syntax = 3,
	Trylater = 4,
	Abort = 5,
	Count
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_context_s
{
	public unsafe void* user;

	public unsafe fz_alloc_context* alloc;

	public unsafe fz_locks_context* locks;

	public unsafe fz_id_context* id;

	public unsafe fz_error_context* error;

	public unsafe fz_warn_context* warn;

	public unsafe fz_font_context* font;

	public unsafe fz_colorspace_context* colorspace;

	public unsafe fz_aa_context* aa;

	public unsafe fz_style_context* style;

	public unsafe fz_store* store;

	public unsafe fz_glyph_cache* glyph_cache;

	public unsafe fz_tuning_context* tuning;

	public unsafe fz_document_handler_context* handler;

	public unsafe fz_output_context* output;
}

[Verify (InferredFromMemberPrefix)]
public enum FzStore : uint
{
	Unlimited = 0,
	Default = 256 << 20
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_locks_context_s
{
	public unsafe void* user;

	public unsafe Action<void*, int>* @lock;

	public unsafe Action<void*, int>* unlock;
}

[Verify (InferredFromMemberPrefix)]
public enum FzLock : uint
{
	Reap = 0,
	Alloc,
	Freetype,
	Glyphcache,
	Max
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_warn_context_s
{
	public sbyte[] message;

	public int count;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_md5_s
{
	public uint[] state;

	public uint[] count;

	public byte[] buffer;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_sha256_s
{
	public uint[] state;

	public uint[] count;

	[StructLayout (LayoutKind.Explicit)]
	public struct Buffer
	{
		[FieldOffset (0)]
		public byte[] u8;

		[FieldOffset (0)]
		public uint[] u32;
	}


	public Buffer buffer;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_sha384
{
	public ulong[] state;

	public uint[] count;

	[StructLayout (LayoutKind.Explicit)]
	public struct Buffer
	{
		[FieldOffset (0)]
		public byte[] u8;

		[FieldOffset (0)]
		public ulong[] u64;
	}


	public Buffer buffer;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_arc4_s
{
	public uint x;

	public uint y;

	public byte[] state;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_aes_s
{
	public int nr;

	public unsafe nuint* rk;

	public nuint[] buf;
}

[Verify (InferredFromMemberPrefix)]
public enum FzDevflag : uint
{
	Mask = 1,
	Color = 2,
	Uncacheable = 4,
	FillcolorUndefined = 8,
	StrokecolorUndefined = 16,
	StartcapUndefined = 32,
	DashcapUndefined = 64,
	EndcapUndefined = 128,
	LinejoinUndefined = 256,
	MiterlimitUndefined = 512,
	LinewidthUndefined = 1024,
	BboxDefined = 2048,
	GridfitAsTiled = 4096
}

[Verify (InferredFromMemberPrefix)]
public enum FzBlend : uint
{
	Normal,
	Multiply,
	Screen,
	Overlay,
	Darken,
	Lighten,
	ColorDodge,
	ColorBurn,
	HardLight,
	SoftLight,
	Difference,
	Exclusion,
	Hue,
	Saturation,
	Color,
	Luminosity,
	Modemask = 15,
	Isolated = 16,
	Knockout = 32
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_device_s
{
	public int refs;

	public int hints;

	public int flags;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*>* close_device;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*>* drop_device;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*, int*, int, int*, mupdf.fz_colorspace*, float*, float>* fill_path;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*, int*, int*, int*, mupdf.fz_colorspace*, float*, float>* stroke_path;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*, int*, int, int*, int*>* clip_path;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*, int*, int*, int*, int*>* clip_stroke_path;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*, int*, int*, mupdf.fz_colorspace*, float*, float>* fill_text;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*, int*, int*, int*, mupdf.fz_colorspace*, float*, float>* stroke_text;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*, int*, int*, int*>* clip_text;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*, int*, int*, int*, int*>* clip_stroke_text;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*, int*, int*>* ignore_text;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*, int*, int*, float>* fill_shade;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*, int*, int*, float>* fill_image;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*, int*, int*, mupdf.fz_colorspace*, float*, float>* fill_image_mask;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*, int*, int*, int*>* clip_image_mask;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*>* pop_clip;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*, int*, int, mupdf.fz_colorspace*, float*>* begin_mask;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*>* end_mask;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*, int*, int, int, int, float>* begin_group;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*>* end_group;

	public unsafe Func<mupdf.fz_context*, mupdf.fz_device*, int*, int*, float, float, int*, int, int>* begin_tile;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*>* end_tile;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_device*, int, int>* render_flags;

	public int d1_rect;

	public int error_depth;

	public sbyte[] errmess;

	public int container_len;

	public int container_cap;

	public unsafe fz_device_container_stack* container;
}

[Verify (InferredFromMemberPrefix)]
public enum Fz : uint
{
	IgnoreImage = 1,
	IgnoreShade = 2,
	DontInterpolateImages = 4,
	MaintainContainerStack = 8,
	NoCache = 16
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_cookie_s
{
	public int abort;

	public int progress;

	public int progress_max;

	public int errors;

	public int incomplete_ok;

	public int incomplete;
}

[Verify (InferredFromMemberPrefix)]
public enum FzTestOpt : uint
{
	Images = 1,
	Shadings = 2
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_draw_options_s
{
	public int rotate;

	public int x_resolution;

	public int y_resolution;

	public int width;

	public int height;

	public unsafe fz_colorspace* colorspace;

	public int alpha;
}

public enum fz_permission : uint
{
	Print = 112,
	Copy = 99,
	Edit = 101,
	Annotate = 110
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_annot_s
{
	public int refs;

	public unsafe fz_annot_drop_fn* drop_annot;

	public unsafe fz_annot_bound_fn* bound_annot;

	public unsafe fz_annot_run_fn* run_annot;

	public unsafe fz_annot_next_fn* next_annot;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_page_s
{
	public int refs;

	public unsafe fz_page_drop_page_fn* drop_page;

	public unsafe fz_page_bound_page_fn* bound_page;

	public unsafe fz_page_run_page_contents_fn* run_page_contents;

	public unsafe fz_page_load_links_fn* load_links;

	public unsafe fz_page_first_annot_fn* first_annot;

	public unsafe fz_page_page_presentation_fn* page_presentation;

	public unsafe fz_page_control_separation_fn* control_separation;

	public unsafe fz_page_separation_disabled_fn* separation_disabled;

	public unsafe fz_page_count_separations_fn* count_separations;

	public unsafe fz_page_get_separation_fn* get_separation;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_document_s
{
	public int refs;

	public unsafe fz_document_drop_fn* drop_document;

	public unsafe fz_document_needs_password_fn* needs_password;

	public unsafe fz_document_authenticate_password_fn* authenticate_password;

	public unsafe fz_document_has_permission_fn* has_permission;

	public unsafe fz_document_load_outline_fn* load_outline;

	public unsafe fz_document_layout_fn* layout;

	public unsafe fz_document_resolve_link_fn* resolve_link;

	public unsafe fz_document_count_pages_fn* count_pages;

	public unsafe fz_document_load_page_fn* load_page;

	public unsafe fz_document_lookup_metadata_fn* lookup_metadata;

	public int did_layout;

	public int is_reflowable;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_document_handler_s
{
	public unsafe fz_document_recognize_fn* recognize;

	public unsafe fz_document_open_fn* open;

	public unsafe fz_document_open_with_stream_fn* open_with_stream;
}

[Verify (InferredFromMemberPrefix)]
public enum FzAdobe : uint
{
	Cns1,
	Gb1,
	Japan1,
	Korea1
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_font_flags_t
{
	public uint is_mono;

	public uint is_serif;

	public uint is_bold;

	public uint is_italic;

	public uint ft_substitute;

	public uint ft_stretch;

	public uint fake_bold;

	public uint fake_italic;

	public uint force_hinting;

	public uint has_opentype;

	public uint invalid_bbox;

	public uint use_glyph_bbox;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_shaper_data_t
{
	public unsafe void* shaper_handle;

	public unsafe Action<mupdf.fz_context*, void*>* destroy;
}

[Verify (InferredFromMemberPrefix)]
public enum FzFnMax : uint
{
	N = FZ_MAX_COLORS,
	M = FZ_MAX_COLORS
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_function_s
{
	public int storable;

	public nuint size;

	public int m;

	public int n;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_function*, float*, float*>* evaluate;

	public unsafe Action<mupdf.fz_context*, int*, mupdf.fz_function*>* print;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_glyph_s
{
	public int storable;

	public int x;

	public int y;

	public int w;

	public int h;

	public unsafe int* pixmap;

	public nuint size;

	public byte[] data;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_image_s
{
	public int key_storable;

	public int w;

	public int h;

	public byte n;

	public byte bpc;

	public uint imagemask;

	public uint interpolate;

	public uint use_colorkey;

	public uint use_decode;

	public uint invert_cmyk_jpeg;

	public uint decoded;

	public uint scalable;

	public unsafe fz_image* mask;

	public int xres;

	public int yres;

	public unsafe fz_colorspace* colorspace;

	public unsafe fz_drop_image_fn* drop_image;

	public unsafe fz_image_get_pixmap_fn* get_pixmap;

	public unsafe fz_image_get_size_fn* get_size;

	public int[] colorkey;

	public float[] decode;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_link_s
{
	public int refs;

	public unsafe fz_link* next;

	public int rect;

	public unsafe void* doc;

	public unsafe sbyte* uri;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_point_s
{
	public float x;

	public float y;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_rect_s
{
	public float x0;

	public float y0;

	public float x1;

	public float y1;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_irect_s
{
	public int x0;

	public int y0;

	public int x1;

	public int y1;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_matrix_s
{
	public float a;

	public float b;

	public float c;

	public float d;

	public float e;

	public float f;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_outline_s
{
	public int refs;

	public unsafe sbyte* title;

	public unsafe sbyte* uri;

	public int page;

	public unsafe fz_outline* next;

	public unsafe fz_outline* down;

	public int is_open;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_pcl_options_s
{
	public int features;

	public unsafe sbyte* odd_page_init;

	public unsafe sbyte* even_page_init;

	public int tumble;

	public int duplex_set;

	public int duplex;

	public int paper_size;

	public int manual_feed_set;

	public int manual_feed;

	public int media_position_set;

	public int media_position;

	public int orientation;

	public int page_count;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_pwg_options_s
{
	public sbyte[] media_class;

	public sbyte[] media_color;

	public sbyte[] media_type;

	public sbyte[] output_type;

	public uint advance_distance;

	public int advance_media;

	public int collate;

	public int cut_media;

	public int duplex;

	public int insert_sheet;

	public int jog;

	public int leading_edge;

	public int manual_feed;

	public uint media_position;

	public uint media_weight;

	public int mirror_print;

	public int negative_print;

	public uint num_copies;

	public int orientation;

	public int output_face_up;

	public uint[] PageSize;

	public int separations;

	public int tray_switch;

	public int tumble;

	public int media_type_num;

	public int compression;

	public uint row_count;

	public uint row_feed;

	public uint row_step;

	public sbyte[] rendering_intent;

	public sbyte[] page_size_name;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_output_s
{
	public unsafe void* opaque;

	public unsafe Action<mupdf.fz_context*, void*, void*, nuint>* write;

	public unsafe Action<mupdf.fz_context*, void*, int, int>* seek;

	public unsafe Func<int*, Func<mupdf.fz_context*, void*, int>> fz_off_t;

	public unsafe Action<mupdf.fz_context*, void*>* close;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_band_writer_s
{
	public unsafe fz_drop_band_writer_fn* drop;

	public unsafe fz_write_header_fn* header;

	public unsafe fz_write_band_fn* band;

	public unsafe fz_write_trailer_fn* trailer;

	public unsafe fz_output* @out;

	public int w;

	public int h;

	public int n;

	public int alpha;

	public int xres;

	public int yres;

	public int pagenum;
}

public enum fz_linecap : uint
{
	Butt = 0,
	Round = 1,
	Square = 2,
	Triangle = 3
}

public enum fz_linejoin : uint
{
	Miter = 0,
	Round = 1,
	Bevel = 2,
	MiterXps = 3
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_stroke_state_s
{
	public int refs;

	public fz_linecap start_cap;

	public fz_linecap dash_cap;

	public fz_linecap end_cap;

	public fz_linejoin linejoin;

	public float linewidth;

	public float miterlimit;

	public float dash_phase;

	public int dash_len;

	public float[] dash_list;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_path_walker
{
	public unsafe Action<mupdf.fz_context*, void*, float, float>* moveto;

	public unsafe Action<mupdf.fz_context*, void*, float, float>* lineto;

	public unsafe Action<mupdf.fz_context*, void*, float, float, float, float, float, float>* curveto;

	public unsafe Action<mupdf.fz_context*, void*>* closepath;

	public unsafe Action<mupdf.fz_context*, void*, float, float, float, float>* quadto;

	public unsafe Action<mupdf.fz_context*, void*, float, float, float, float>* curvetov;

	public unsafe Action<mupdf.fz_context*, void*, float, float, float, float>* curvetoy;

	public unsafe Action<mupdf.fz_context*, void*, float, float, float, float>* rectto;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_pixmap_s
{
	public int storable;

	public int x;

	public int y;

	public int w;

	public int h;

	public int n;

	public IntPtr stride;

	public int alpha;

	public int interpolate;

	public int xres;

	public int yres;

	public unsafe fz_colorspace* colorspace;

	public unsafe byte* samples;

	public int free_samples;
}

public enum  : uint
{
	FzMaxSeparations = 64
}

[Verify (InferredFromMemberPrefix)]
public enum Fz : uint
{
	FunctionBased = 1,
	Linear = 2,
	Radial = 3,
	MeshType4 = 4,
	MeshType5 = 5,
	MeshType6 = 6,
	MeshType7 = 7
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_shade
{
	public int storable;

	public fz_rect bbox;

	public unsafe fz_colorspace* colorspace;

	public fz_matrix matrix;

	public int use_background;

	public float[] background;

	public int use_function;

	public float[][] function;

	public int type;

	[StructLayout (LayoutKind.Explicit)]
	public struct U
	{
		[StructLayout (LayoutKind.Sequential)]
		public struct L_or_r
		{
			public int[] extend;

			public float[][] coords;
		}


		[FieldOffset (0)]
		public L_or_r l_or_r;

		[StructLayout (LayoutKind.Sequential)]
		public struct M
		{
			public int vprow;

			public int bpflag;

			public int bpcoord;

			public int bpcomp;

			public float x0;

			public float x1;

			public float y0;

			public float y1;

			public float[] c0;

			public float[] c1;
		}


		[FieldOffset (0)]
		public M m;

		[StructLayout (LayoutKind.Sequential)]
		public struct F
		{
			public fz_matrix matrix;

			public int xdivs;

			public int ydivs;

			public float[][] domain;

			public unsafe float* fn_vals;
		}


		[FieldOffset (0)]
		public F f;
	}


	public U u;

	public unsafe fz_compressed_buffer* buffer;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_vertex_s
{
	public fz_point p;

	public float[] c;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_storable_s
{
	public int refs;

	public unsafe fz_store_drop_fn* drop;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_key_storable_s
{
	public fz_storable storable;

	public short store_key_refs;

	public ushort needs_reaping;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_store_hash
{
	public unsafe fz_store_drop_fn* drop;

	[StructLayout (LayoutKind.Explicit)]
	public struct U
	{
		[StructLayout (LayoutKind.Sequential)]
		public struct Pi
		{
			public unsafe void* ptr;

			public int i;
		}


		[FieldOffset (0)]
		public Pi pi;

		[StructLayout (LayoutKind.Sequential)]
		public struct Pir
		{
			public unsafe void* ptr;

			public int i;

			public fz_irect r;
		}


		[FieldOffset (0)]
		public Pir pir;

		[StructLayout (LayoutKind.Sequential)]
		public struct Im
		{
			public int id;

			public float[] m;
		}


		[FieldOffset (0)]
		public Im im;
	}


	public U u;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_store_type
{
	public unsafe Func<mupdf.fz_context*, mupdf.fz_store_hash*, void*, int>* make_hash_key;

	public unsafe Func<mupdf.fz_context*, void*, void*>* keep_key;

	public unsafe Action<mupdf.fz_context*, void*>* drop_key;

	public unsafe Func<mupdf.fz_context*, void*, void*, int>* cmp_key;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_output*, void*>* print;

	public unsafe Func<mupdf.fz_context*, void*, int>* needs_reap;
}

[Verify (InferredFromMemberPrefix)]
public enum FzStreamMeta : uint
{
	Progressive = 1,
	Length = 2
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_stream_s
{
	public int refs;

	public int error;

	public int eof;

	public int pos;

	public int avail;

	public int bits;

	public unsafe byte* rp;

	public unsafe byte* wp;

	public unsafe void* state;

	public unsafe fz_stream_next_fn* next;

	public unsafe fz_stream_close_fn* close;

	public unsafe fz_stream_seek_fn* seek;

	public unsafe fz_stream_meta_fn* meta;
}

[Verify (InferredFromMemberPrefix)]
public enum FzStextPreserve : uint
{
	Ligatures = 1,
	Whitespace = 2
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_stext_sheet_s
{
	public int maxid;

	public unsafe fz_stext_style* style;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_stext_style_s
{
	public unsafe fz_stext_style* next;

	public int id;

	public unsafe fz_font* font;

	public float size;

	public int wmode;

	public int script;

	public float ascender;

	public float descender;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_stext_page_s
{
	public fz_rect mediabox;

	public int len;

	public int cap;

	public unsafe fz_page_block* blocks;

	public unsafe fz_stext_page* next;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_page_block_s
{
	public int type;

	[StructLayout (LayoutKind.Explicit)]
	public struct U
	{
		[FieldOffset (0)]
		public unsafe fz_stext_block* text;

		[FieldOffset (0)]
		public unsafe fz_image_block* image;
	}


	public U u;
}

[Verify (InferredFromMemberPrefix)]
public enum FzPageBlock : uint
{
	Text = 0,
	Image = 1
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_stext_block_s
{
	public fz_rect bbox;

	public int len;

	public int cap;

	public unsafe fz_stext_line* lines;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_image_block_s
{
	public fz_rect bbox;

	public fz_matrix mat;

	public unsafe fz_image* image;

	public unsafe fz_colorspace* cspace;

	public float[] colors;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_stext_line_s
{
	public unsafe fz_stext_span* first_span;

	public unsafe fz_stext_span* last_span;

	public float distance;

	public fz_rect bbox;

	public unsafe void* region;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_stext_span_s
{
	public int len;

	public int cap;

	public unsafe fz_stext_char* text;

	public fz_point min;

	public fz_point max;

	public int wmode;

	public fz_matrix transform;

	public float ascender_max;

	public float descender_min;

	public fz_rect bbox;

	public float base_offset;

	public float spacing;

	public int column;

	public float column_width;

	public int align;

	public float indent;

	public unsafe fz_stext_span* next;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_stext_char_s
{
	public fz_point p;

	public int c;

	public unsafe fz_stext_style* style;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_char_and_box_s
{
	public int c;

	public fz_rect bbox;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_stext_options_s
{
	public int flags;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_text_item_s
{
	public float x;

	public float y;

	public int gid;

	public int ucs;
}

public enum fz_text_language : uint
{
	Unset = 0,
	ur = ((117 - 97 + 1) + ((114 - 97 + 1) * 27)),
	urd = ((117 - 97 + 1) + ((114 - 97 + 1) * 27) + ((100 - 97 + 1) * 27 * 27)),
	ko = ((107 - 97 + 1) + ((111 - 97 + 1) * 27)),
	ja = ((106 - 97 + 1) + ((97 - 97 + 1) * 27)),
	zh = ((122 - 97 + 1) + ((104 - 97 + 1) * 27)),
	zh_Hans = ((122 - 97 + 1) + ((104 - 97 + 1) * 27) + ((115 - 97 + 1) * 27 * 27)),
	zh_Hant = ((122 - 97 + 1) + ((104 - 97 + 1) * 27) + ((116 - 97 + 1) * 27 * 27))
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_text_span_s
{
	public unsafe fz_font* font;

	public fz_matrix trm;

	public uint wmode;

	public uint bidi_level;

	public uint markup_dir;

	public uint language;

	public int len;

	public int cap;

	public unsafe fz_text_item* items;

	public unsafe fz_text_span* next;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_text_s
{
	public int refs;

	public unsafe fz_text_span* head;

	public unsafe fz_text_span* tail;
}

[Verify (InferredFromMemberPrefix)]
public enum FzTransition : uint
{
	None = 0,
	Split,
	Blinds,
	Box,
	Wipe,
	Dissolve,
	Glitter,
	Fly,
	Push,
	Cover,
	Uncover,
	Fade
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_transition_s
{
	public int type;

	public float duration;

	public int vertical;

	public int outwards;

	public int direction;

	public int state0;

	public int state1;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_document_writer_s
{
	public unsafe Func<mupdf.fz_context*, mupdf.fz_document_writer*, mupdf.fz_rect*, mupdf.fz_device*>* begin_page;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_document_writer*, mupdf.fz_device*>* end_page;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_document_writer*>* close_writer;

	public unsafe Action<mupdf.fz_context*, mupdf.fz_document_writer*>* drop_writer;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_html_font_face_s
{
	public unsafe sbyte* family;

	public int is_bold;

	public int is_italic;

	public unsafe fz_font* font;

	public unsafe sbyte* src;

	public unsafe fz_html_font_face* next;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_html_font_set_s
{
	public unsafe fz_font*[] fonts;

	public unsafe fz_html_font_face* custom;
}

[Verify (InferredFromMemberPrefix)]
public enum Css : uint
{
	Keyword = 256,
	Hash,
	String,
	Number,
	Length,
	Percent,
	Uri
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_css_s
{
	public unsafe fz_pool* pool;

	public unsafe fz_css_rule* rule;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_css_rule_s
{
	public unsafe fz_css_selector* selector;

	public unsafe fz_css_property* declaration;

	public unsafe fz_css_rule* next;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_css_selector_s
{
	public unsafe sbyte* name;

	public int combine;

	public unsafe fz_css_condition* cond;

	public unsafe fz_css_selector* left;

	public unsafe fz_css_selector* right;

	public unsafe fz_css_selector* next;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_css_condition_s
{
	public int type;

	public unsafe sbyte* key;

	public unsafe sbyte* val;

	public unsafe fz_css_condition* next;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_css_property_s
{
	public unsafe sbyte* name;

	public unsafe fz_css_value* value;

	public short spec;

	public short important;

	public unsafe fz_css_property* next;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_css_value_s
{
	public int type;

	public unsafe sbyte* data;

	public unsafe fz_css_value* args;

	public unsafe fz_css_value* next;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_css_match_prop_s
{
	public unsafe sbyte* name;

	public unsafe fz_css_value* value;

	public int spec;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_css_match_s
{
	public unsafe fz_css_match* up;

	public int count;

	public fz_css_match_prop[] prop;
}

[Verify (InferredFromMemberPrefix)]
public enum Dis : uint
{
	None,
	Block,
	Inline,
	ListItem,
	InlineBlock
}

[Verify (InferredFromMemberPrefix)]
public enum Pos : uint
{
	Static,
	Relative,
	Absolute,
	Fixed
}

[Verify (InferredFromMemberPrefix)]
public enum Ta : uint
{
	Left,
	Right,
	Center,
	Justify
}

[Verify (InferredFromMemberPrefix)]
public enum Va : uint
{
	Baseline,
	Sub,
	Super,
	Top,
	Bottom,
	TextTop,
	TextBottom
}

[Verify (InferredFromMemberPrefix)]
public enum Bs : uint
{
	None,
	Solid
}

[Verify (InferredFromMemberPrefix)]
public enum V : uint
{
	Visible,
	Hidden,
	Collapse
}

[Verify (InferredFromMemberPrefix)]
public enum Pb : uint
{
	Auto,
	Always,
	Avoid,
	Left,
	Right
}

[Verify (InferredFromMemberPrefix)]
public enum Ws : uint
{
	Collapse = 1,
	AllowBreakSpace = 2,
	ForceBreakNewline = 4,
	Normal = Collapse | AllowBreakSpace,
	Pre = ForceBreakNewline,
	Nowrap = Collapse,
	PreWrap = AllowBreakSpace | ForceBreakNewline,
	PreLine = Collapse | AllowBreakSpace | ForceBreakNewline
}

[Verify (InferredFromMemberPrefix)]
public enum Lst : uint
{
	None,
	Disc,
	Circle,
	Square,
	Decimal,
	DecimalZero,
	LcRoman,
	UcRoman,
	LcGreek,
	UcGreek,
	LcLatin,
	UcLatin,
	LcAlpha,
	UcAlpha,
	Armenian,
	Georgian
}

[Verify (InferredFromMemberPrefix)]
public enum N : uint
{
	Number = 117,
	Length = 112,
	Scale = 109,
	Percent = 37,
	Auto = 97
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_css_number_s
{
	public float value;

	public int unit;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_css_color_s
{
	public byte r;

	public byte g;

	public byte b;

	public byte a;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_css_style_s
{
	public fz_css_number font_size;

	public fz_css_number width;

	public fz_css_number height;

	public fz_css_number[] margin;

	public fz_css_number[] padding;

	public fz_css_number[] border_width;

	public fz_css_number text_indent;

	public uint visibility;

	public uint white_space;

	public uint text_align;

	public uint vertical_align;

	public uint list_style_type;

	public uint page_break_before;

	public uint page_break_after;

	public uint border_style_0;

	public uint border_style_1;

	public uint border_style_2;

	public uint border_style_3;

	public fz_css_number line_height;

	public fz_css_color background_color;

	public fz_css_color[] border_color;

	public fz_css_color color;

	public unsafe fz_font* font;
}

[Verify (InferredFromMemberPrefix)]
public enum Box : uint
{
	Block,
	Break,
	Flow,
	Inline
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_html_s
{
	public unsafe fz_pool* pool;

	public unsafe fz_html_box* root;
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_html_box_s
{
	public uint type;

	public uint is_first_flow;

	public uint markup_dir;

	public uint list_item;

	public float x;

	public float y;

	public float w;

	public float h;

	public float[] padding;

	public float[] margin;

	public float[] border;

	public float em;

	public unsafe fz_html_box* up;

	public unsafe fz_html_box* down;

	public unsafe fz_html_box* last;

	public unsafe fz_html_box* next;

	public unsafe fz_html_flow* flow_head;

	public unsafe fz_html_flow** flow_tail;

	public unsafe sbyte* id;

	public unsafe sbyte* href;

	public fz_css_style style;
}

[Verify (InferredFromMemberPrefix)]
public enum Flow : uint
{
	Word = 0,
	Space = 1,
	Break = 2,
	Image = 3,
	Sbreak = 4,
	Shyphen = 5,
	Anchor = 6
}

[StructLayout (LayoutKind.Sequential)]
public struct fz_html_flow_s
{
	public uint type;

	public uint expand;

	public uint breaks_line;

	public uint bidi_level;

	public uint script;

	public uint markup_lang;

	public float x;

	public float y;

	public float w;

	public float h;

	public unsafe fz_html_box* box;

	[StructLayout (LayoutKind.Explicit)]
	public struct Content
	{
		[FieldOffset (0)]
		public unsafe sbyte* text;

		[FieldOffset (0)]
		public unsafe fz_image* image;
	}


	public Content content;

	public unsafe fz_html_flow* next;
}

public enum  : uint
{
	ResourceCacheMaxSize = 128 << 20
}

[Verify (InferredFromMemberPrefix)]
public enum Barmode : uint
{
	Main,
	Search,
	More,
	Annotation,
	Highlight,
	Underline,
	Strike,
	Ink,
	Delete
}

public enum fz_annot_type : uint
{
	Text,
	Link,
	FreeText,
	Line,
	Square,
	Circle,
	Polygon,
	PolyLine,
	Highlight,
	Underline,
	Squiggly,
	StrikeOut,
	Stamp,
	Caret,
	Ink,
	Popup,
	FileAttachment,
	Sound,
	Movie,
	Widget,
	Screen,
	PrinterMark,
	TrapNet,
	Watermark,
	PdfAnnot3d
}

[Verify (InferredFromMemberPrefix)]
public enum PdfAnnotIs : uint
{
	Invisible = 1 << (1 - 1),
	Hidden = 1 << (2 - 1),
	Print = 1 << (3 - 1),
	NoZoom = 1 << (4 - 1),
	NoRotate = 1 << (5 - 1),
	NoView = 1 << (6 - 1),
	ReadOnly = 1 << (7 - 1),
	Locked = 1 << (8 - 1),
	ToggleNoView = 1 << (9 - 1),
	LockedContents = 1 << (10 - 1)
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_annot
{
	public fz_annot super;

	public unsafe int* page;

	public unsafe int* obj;

	public unsafe int* ap;

	public int ap_iteration;

	public int changed;

	public unsafe int* next;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_da_info
{
	public unsafe sbyte* font_name;

	public int font_size;

	public float[] col;

	public int col_size;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_range_s
{
	public ushort low;

	public ushort high;

	public ushort @out;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_xrange_s
{
	public uint low;

	public uint high;

	public uint @out;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_mrange_s
{
	public uint low;

	public uint len;

	public uint[] @out;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_cmap_s
{
	public fz_storable storable;

	public sbyte[] cmap_name;

	public sbyte[] usecmap_name;

	public unsafe pdf_cmap* usecmap;

	public int wmode;

	public int codespace_len;

	[StructLayout (LayoutKind.Sequential)]
	public struct 
	{
		public int n;

		public uint low;

		public uint high;
	}


	public [anonymous Record: struct pdf_cmap_s::(anonymous at /Users/yauhenipakala/Projects/MuPDF/Binding/mupdf.framework/Headers/mupdf/pdf/cmap.h:41:2)][] codespace;

	public int rlen;

	public int rcap;

	public unsafe pdf_range* ranges;

	public int xlen;

	public int xcap;

	public unsafe pdf_xrange* xranges;

	public int mlen;

	public int mcap;

	public unsafe pdf_mrange* mranges;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_designated_name
{
	public unsafe sbyte* cn;

	public unsafe sbyte* o;

	public unsafe sbyte* ou;

	public unsafe sbyte* email;

	public unsafe sbyte* c;
}

[Verify (InferredFromMemberPrefix)]
public enum PdfLexbuf : uint
{
	Small = 256,
	Large = 65536
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_lexbuf_s
{
	public int size;

	public int base_size;

	public int len;

	public int i;

	public float f;

	public unsafe sbyte* scratch;

	public sbyte[] buffer;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_lexbuf_large_s
{
	public pdf_lexbuf @base;

	public sbyte[] buffer;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_hotspot_s
{
	public int num;

	public int state;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_layer_config
{
	public unsafe sbyte* name;

	public unsafe sbyte* creator;
}

public enum pdf_layer_config_ui_type : uint
{
	Label = 0,
	Checkbox = 1,
	Radiobox = 2
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_layer_config_ui
{
	public unsafe sbyte* text;

	public int depth;

	public pdf_layer_config_ui_type type;

	public int selected;

	public int locked;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_unsaved_sig_s
{
	public unsafe int* field;

	public int byte_range_start;

	public int byte_range_end;

	public int contents_start;

	public int contents_end;

	public unsafe pdf_signer* signer;

	public unsafe pdf_unsaved_sig* next;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_document
{
	public fz_document super;

	public unsafe fz_stream* file;

	public int version;

	public int startxref;

	public int file_size;

	public unsafe pdf_crypt* crypt;

	public unsafe pdf_ocg_descriptor* ocg;

	public pdf_hotspot hotspot;

	public int max_xref_len;

	public int num_xref_sections;

	public int num_incremental_sections;

	public int xref_base;

	public int disallow_new_increments;

	public unsafe pdf_xref* xref_sections;

	public unsafe int* xref_index;

	public int freeze_updates;

	public int has_xref_streams;

	public int page_count;

	public int repair_attempted;

	public int file_reading_linearly;

	public int file_length;

	public unsafe int* linear_obj;

	public unsafe int** linear_page_refs;

	public int linear_page1_obj_num;

	public int linear_pos;

	public int linear_page_num;

	public int hint_object_offset;

	public int hint_object_length;

	public int hints_loaded;

	[StructLayout (LayoutKind.Sequential)]
	public struct 
	{
		public int number;

		public int offset;

		public int index;
	}


	public unsafe [anonymous Record: struct pdf_document_s::(anonymous at /Users/yauhenipakala/Projects/MuPDF/Binding/mupdf.framework/Headers/mupdf/pdf/document.h:341:2)]* hint_page;

	public unsafe int* hint_shared_ref;

	[StructLayout (LayoutKind.Sequential)]
	public struct 
	{
		public int number;

		public int offset;
	}


	public unsafe [anonymous Record: struct pdf_document_s::(anonymous at /Users/yauhenipakala/Projects/MuPDF/Binding/mupdf.framework/Headers/mupdf/pdf/document.h:348:2)]* hint_shared;

	public int hint_obj_offsets_max;

	public unsafe int* hint_obj_offsets;

	public int resources_localised;

	public pdf_lexbuf_large lexbuf;

	public unsafe pdf_annot* focus;

	public unsafe int* focus_obj;

	public unsafe pdf_js* js;

	public int recalculating;

	public int dirty;

	public unsafe Action<mupdf.fz_context*, int*, mupdf.pdf_annot*>* update_appearance;

	public unsafe pdf_doc_event_cb* event_cb;

	public unsafe void* event_cb_data;

	public int num_type3_fonts;

	public int max_type3_fonts;

	public unsafe fz_font** type3_fonts;

	[StructLayout (LayoutKind.Sequential)]
	public struct Resources
	{
		public unsafe fz_hash_table* images;

		public unsafe fz_hash_table* fonts;
	}


	public Resources resources;

	public int orphans_max;

	public int orphans_count;

	public unsafe int** orphans;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_write_options_s
{
	public int do_incremental;

	public int do_pretty;

	public int do_ascii;

	public int do_compress;

	public int do_compress_images;

	public int do_compress_fonts;

	public int do_decompress;

	public int do_garbage;

	public int do_linear;

	public int do_clean;

	public int continue_on_error;

	public unsafe int* errors;
}

[Verify (InferredFromMemberPrefix)]
public enum HotspotPointer : uint
{
	Down = 1,
	Over = 2
}

public enum  : uint
{
	PdfEventTypePointer
}

[Verify (InferredFromMemberPrefix)]
public enum PdfPointer : uint
{
	Down,
	Up
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_ui_event
{
	public int etype;

	[StructLayout (LayoutKind.Explicit)]
	public struct Event
	{
		[StructLayout (LayoutKind.Sequential)]
		public struct Pointer
		{
			public int ptype;

			public fz_point pt;
		}


		[FieldOffset (0)]
		public Pointer pointer;
	}


	public Event @event;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_doc_event_s
{
	public int type;
}

[Verify (InferredFromMemberPrefix)]
public enum PdfDocumentEvent : uint
{
	Alert,
	Print,
	LaunchUrl,
	MailDoc,
	Submit,
	ExecMenuItem,
	ExecDialog
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_alert_event
{
	public unsafe sbyte* message;

	public int icon_type;

	public int button_group_type;

	public unsafe sbyte* title;

	public unsafe sbyte* check_box_message;

	public int initially_checked;

	public int finally_checked;

	public int button_pressed;
}

[Verify (InferredFromMemberPrefix)]
public enum PdfAlertIcon : uint
{
	Error,
	Warning,
	Question,
	Status
}

[Verify (InferredFromMemberPrefix)]
public enum PdfAlertButtonGroup : uint
{
	Ok,
	OkCancel,
	YesNo,
	YesNoCancel
}

[Verify (InferredFromMemberPrefix)]
public enum PdfAlertButton : uint
{
	None,
	Ok,
	Cancel,
	No,
	Yes
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_submit_event
{
	public unsafe sbyte* url;

	public unsafe sbyte* data;

	public int data_len;

	public int get;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_launch_url_event
{
	public unsafe sbyte* url;

	public int new_frame;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_mail_doc_event
{
	public int ask_user;

	public unsafe sbyte* to;

	public unsafe sbyte* cc;

	public unsafe sbyte* bcc;

	public unsafe sbyte* subject;

	public unsafe sbyte* message;
}

[Verify (InferredFromMemberPrefix)]
public enum Ff_ : uint
{
	ReadOnly = 1 << (1 - 1),
	Required = 1 << (2 - 1),
	NoExport = 1 << (3 - 1),
	Multiline = 1 << (13 - 1),
	Password = 1 << (14 - 1),
	FileSelect = 1 << (21 - 1),
	DoNotSpellCheck = 1 << (23 - 1),
	DoNotScroll = 1 << (24 - 1),
	Comb = 1 << (25 - 1),
	RichText = 1 << (26 - 1),
	NoToggleToOff = 1 << (15 - 1),
	Radio = 1 << (16 - 1),
	Pushbutton = 1 << (17 - 1),
	RadioInUnison = 1 << (26 - 1),
	Combo = 1 << (18 - 1),
	Edit = 1 << (19 - 1),
	Sort = 1 << (20 - 1),
	MultiSelect = 1 << (22 - 1),
	CommitOnSelCHange = 1 << (27 - 1)
}

[Verify (InferredFromMemberPrefix)]
public enum PdfFd : uint
{
	FixedPitch = 1 << 0,
	Serif = 1 << 1,
	Symbolic = 1 << 2,
	Script = 1 << 3,
	Nonsymbolic = 1 << 5,
	Italic = 1 << 6,
	AllCap = 1 << 16,
	SmallCap = 1 << 17,
	ForceBold = 1 << 18
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_hmtx_s
{
	public ushort lo;

	public ushort hi;

	public int w;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_vmtx_s
{
	public ushort lo;

	public ushort hi;

	public short x;

	public short y;

	public short w;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_font_desc_s
{
	public fz_storable storable;

	public nuint size;

	public unsafe fz_font* font;

	public int flags;

	public float italic_angle;

	public float ascent;

	public float descent;

	public float cap_height;

	public float x_height;

	public float missing_width;

	public unsafe pdf_cmap* encoding;

	public unsafe pdf_cmap* to_ttf_cmap;

	public nuint cid_to_gid_len;

	public unsafe ushort* cid_to_gid;

	public unsafe pdf_cmap* to_unicode;

	public nuint cid_to_ucs_len;

	public unsafe ushort* cid_to_ucs;

	public int wmode;

	public int hmtx_len;

	public int hmtx_cap;

	public pdf_hmtx dhmtx;

	public unsafe pdf_hmtx* hmtx;

	public int vmtx_len;

	public int vmtx_cap;

	public pdf_vmtx dvmtx;

	public unsafe pdf_vmtx* vmtx;

	public int is_embedded;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_processor_s
{
	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* close_processor;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* drop_processor;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float>* op_w;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, int>* op_j;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, int>* op_J;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float>* op_M;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, int*, float>* op_d;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*>* op_ri;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float>* op_i;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*, int*>* op_gs_begin;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*>* op_gs_BM;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float>* op_gs_ca;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float>* op_gs_CA;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, int*, int*, float*, int>* op_gs_SMask;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_gs_end;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_q;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_Q;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float, float, float, float, float>* op_cm;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float>* op_m;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float>* op_l;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float, float, float, float, float>* op_c;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float, float, float>* op_v;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float, float, float>* op_y;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_h;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float, float, float>* op_re;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_S;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_s;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_F;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_f;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_fstar;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_B;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_Bstar;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_b;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_bstar;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_n;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_W;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_Wstar;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_BT;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_ET;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float>* op_Tc;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float>* op_Tw;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float>* op_Tz;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float>* op_TL;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*, mupdf.pdf_font_desc*, float>* op_Tf;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, int>* op_Tr;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float>* op_Ts;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float>* op_Td;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float>* op_TD;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float, float, float, float, float>* op_Tm;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_Tstar;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, int*>* op_TJ;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*, int>* op_Tj;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*, int>* op_squote;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float, sbyte*, int>* op_dquote;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float>* op_d0;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float, float, float, float, float>* op_d1;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*, mupdf.fz_colorspace*>* op_CS;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*, mupdf.fz_colorspace*>* op_cs;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*, int*, int, float*>* op_SC_pattern;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*, int*, int, float*>* op_sc_pattern;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*, mupdf.fz_shade*>* op_SC_shade;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*, mupdf.fz_shade*>* op_sc_shade;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, int, float*>* op_SC_color;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, int, float*>* op_sc_color;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float>* op_G;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float>* op_g;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float, float>* op_RG;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float, float>* op_rg;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float, float, float>* op_K;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, float, float, float, float>* op_k;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, mupdf.fz_image*>* op_BI;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*, mupdf.fz_shade*>* op_sh;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*, mupdf.fz_image*>* op_Do_image;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*, int*, int*>* op_Do_form;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*>* op_MP;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*, int*, int*>* op_DP;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*>* op_BMC;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*, sbyte*, int*, int*>* op_BDC;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_EMC;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_BX;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_EX;

	public unsafe Action<mupdf.fz_context*, mupdf.pdf_processor*>* op_END;

	public unsafe sbyte* usage;

	public int hidden;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_csi_s
{
	public unsafe int* doc;

	public unsafe int* rdb;

	public unsafe pdf_lexbuf* buf;

	public unsafe fz_cookie* cookie;

	public int gstate;

	public int xbalance;

	public int in_text;

	public fz_rect d1_rect;

	public unsafe int* obj;

	public sbyte[] name;

	public sbyte[] @string;

	public int string_len;

	public int top;

	public float[] stack;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_js_event
{
	public unsafe int* target;

	public unsafe sbyte* value;

	public int rc;
}

[Verify (InferredFromMemberPrefix)]
public enum PdfObjEnum : uint
{
	Dummy,
	Name3d,
	NameA,
	NameA85,
	NameAa,
	NameAesv2,
	NameAesv3,
	NAME_AHx,
	NameAp,
	NameAs,
	NAME_ASCII85Decode,
	NAME_ASCIIHexDecode,
	NAME_AcroForm,
	NAME_Adobe_PPKLite,
	NAME_All,
	NAME_AllOff,
	NAME_AllOn,
	NAME_Alpha,
	NAME_Alternate,
	NAME_Annot,
	NAME_Annots,
	NAME_AnyOff,
	NAME_ArtBox,
	NAME_Ascent,
	NameB,
	NAME_BBox,
	NameBc,
	NameBe,
	NameBg,
	NameBm,
	NameBpc,
	NameBs,
	NAME_Background,
	NAME_BaseEncoding,
	NAME_BaseFont,
	NAME_BaseState,
	NAME_BitsPerComponent,
	NAME_BitsPerCoordinate,
	NAME_BitsPerFlag,
	NAME_BitsPerSample,
	NAME_BlackIs1,
	NAME_BleedBox,
	NAME_Blinds,
	NAME_Border,
	NAME_Bounds,
	NAME_Box,
	NAME_Bt,
	NAME_Btn,
	NAME_ByteRange,
	NameC,
	NameC0,
	NameC1,
	NameCa,
	NameCcf,
	NAME_CCITTFaxDecode,
	NameCf,
	NameCfm,
	NAME_CIDFontType0,
	NAME_CIDFontType0C,
	NAME_CIDFontType2,
	NAME_CIDSystemInfo,
	NAME_CIDToGIDMap,
	NameCmyk,
	NameCs,
	NAME_CalCMYK,
	NAME_CalGray,
	NAME_CalRGB,
	NAME_CapHeight,
	NAME_Caret,
	NAME_Catalog,
	NAME_Ch,
	NAME_CharProcs,
	NAME_Circle,
	NAME_ColorSpace,
	NAME_ColorTransform,
	NAME_Colors,
	NAME_Columns,
	NAME_Configs,
	NAME_Contents,
	NAME_Coords,
	NAME_Count,
	NAME_Cover,
	NAME_CreationDate,
	NAME_Creator,
	NAME_CropBox,
	NAME_Crypt,
	NameD,
	NameDa,
	NameDc,
	NameDct,
	NAME_DCTDecode,
	NameDos,
	NameDp,
	NameDr,
	NameDv,
	NameDw,
	NameDw2,
	NAME_DamagedRowsBeforeError,
	NAME_Decode,
	NAME_DecodeParms,
	NAME_Default,
	NAME_DescendantFonts,
	NAME_Descent,
	NAME_Design,
	NAME_Dest,
	NAME_Dests,
	NAME_DeviceCMYK,
	NAME_DeviceGray,
	NAME_DeviceN,
	NAME_DeviceRGB,
	NAME_Di,
	NAME_Differences,
	NAME_Dissolve,
	NAME_Dm,
	NAME_Domain,
	NAME_Dur,
	NameE,
	NAME_EarlyChange,
	NAME_Encode,
	NAME_EncodedByteAlign,
	NAME_Encoding,
	NAME_Encrypt,
	NAME_EncryptMetadata,
	NAME_EndOfBlock,
	NAME_EndOfLine,
	NAME_Exclude,
	NAME_ExtGState,
	NAME_Extend,
	NameF,
	NameFl,
	NameFrm,
	NameFs,
	NameFt,
	NAME_Fade,
	NAME_Ff,
	NAME_Fields,
	NAME_FileAttachment,
	NAME_Filter,
	NAME_First,
	NAME_FirstChar,
	NAME_Fit,
	NAME_FitB,
	NAME_FitBH,
	NAME_FitBV,
	NAME_FitH,
	NAME_FitR,
	NAME_FitV,
	NAME_Fl,
	NAME_Flags,
	NAME_FlateDecode,
	NAME_Fly,
	NAME_Font,
	NAME_FontBBox,
	NAME_FontDescriptor,
	NAME_FontFile,
	NAME_FontFile2,
	NAME_FontFile3,
	NAME_FontMatrix,
	NAME_FontName,
	NAME_Form,
	NAME_FormType,
	NAME_FreeText,
	NAME_Function,
	NAME_FunctionType,
	NAME_Functions,
	NameG,
	NAME_Glitter,
	NAME_GoTo,
	NAME_GoToR,
	NAME_Group,
	NameH,
	NAME_Height,
	NAME_Highlight,
	NameI,
	NameIc,
	NAME_ICCBased,
	NameId,
	NameIm,
	NameIrt,
	NAME_Identity,
	NAME_Identity_H,
	NAME_Identity_V,
	NAME_Image,
	NAME_ImageMask,
	NAME_Index,
	NAME_Indexed,
	NAME_Info,
	NAME_Ink,
	NAME_InkList,
	NAME_Intent,
	NAME_Interpolate,
	NAME_IsMap,
	NAME_ItalicAngle,
	NAME_JBIG2Decode,
	NAME_JBIG2Globals,
	NAME_JPXDecode,
	NameJs,
	NAME_JavaScript,
	NameK,
	NAME_Kids,
	NameL,
	NameLc,
	NameLj,
	NameLw,
	NameLz,
	NameLzw,
	NAME_LZWDecode,
	NAME_Lab,
	NAME_Last,
	NAME_LastChar,
	NAME_Launch,
	NAME_Length,
	NAME_Length1,
	NAME_Length2,
	NAME_Length3,
	NAME_Limits,
	NAME_Line,
	NAME_Linearized,
	NAME_Link,
	NAME_Locked,
	NAME_Luminosity,
	NameM,
	NameMk,
	NameMl,
	NAME_MMType1,
	NAME_Mac,
	NAME_Mask,
	NAME_Matrix,
	NAME_Matte,
	NAME_MaxLen,
	NAME_MediaBox,
	NAME_MissingWidth,
	NAME_Movie,
	NameN,
	NAME_Name,
	NAME_Named,
	NAME_Names,
	NAME_NewWindow,
	NAME_Next,
	NAME_None,
	NAME_Normal,
	NameO,
	NameOc,
	NameOcg,
	NAME_OCGs,
	NameOcmd,
	NAME_OCProperties,
	NameOe,
	NameOff,
	NameOn,
	NAME_ObjStm,
	NAME_Of,
	NAME_Off,
	NAME_OpenType,
	NAME_Opt,
	NAME_Order,
	NAME_Ordering,
	NAME_Outlines,
	NameP,
	NamePdf,
	NamePs,
	NAME_Page,
	NAME_PageMode,
	NAME_Pages,
	NAME_PaintType,
	NAME_Parent,
	NAME_Pattern,
	NAME_PatternType,
	NAME_PolyLine,
	NAME_Polygon,
	NAME_Popup,
	NAME_Predictor,
	NAME_Prev,
	NAME_Print,
	NAME_PrinterMark,
	NAME_ProcSet,
	NAME_Producer,
	NAME_Properties,
	NAME_Push,
	NameQ,
	NAME_QuadPoints,
	NameR,
	NAME_RBGroups,
	NameRgb,
	NameRi,
	NameRl,
	NAME_Range,
	NAME_Rect,
	NAME_Ref,
	NAME_Registry,
	NAME_ResetForm,
	NAME_Resources,
	NAME_Root,
	NAME_Rotate,
	NAME_Rows,
	NAME_RunLengthDecode,
	NameS,
	NAME_SMask,
	NAME_SMaskInData,
	NAME_Screen,
	NAME_Separation,
	NAME_Shading,
	NAME_ShadingType,
	NAME_Si,
	NAME_Sig,
	NAME_SigFlags,
	NAME_Size,
	NAME_Sound,
	NAME_Split,
	NAME_Square,
	NAME_Squiggly,
	NAME_Stamp,
	NAME_Standard,
	NAME_StdCF,
	NAME_StemV,
	NAME_StmF,
	NAME_StrF,
	NAME_StrikeOut,
	NAME_SubFilter,
	NAME_Subtype,
	NAME_Subtype2,
	NAME_Supplement,
	NameT,
	NameTr,
	NameTr2,
	NAME_Text,
	NAME_TilingType,
	NAME_Title,
	NAME_ToUnicode,
	NAME_Trans,
	NAME_Transparency,
	NAME_TrapNet,
	NAME_TrimBox,
	NAME_TrueType,
	NAME_Tx,
	NAME_Type,
	NAME_Type0,
	NAME_Type1,
	NAME_Type1C,
	NAME_Type3,
	NameU,
	NameUe,
	NameUf,
	NameUri,
	NameUrl,
	NAME_Unchanged,
	NAME_Uncover,
	NAME_Underline,
	NAME_Unix,
	NAME_Usage,
	NAME_UseCMap,
	NAME_UseOutlines,
	NAME_UserUnit,
	NameV,
	NameV2,
	NameVe,
	NAME_Version,
	NAME_VerticesPerRow,
	NAME_View,
	NameW,
	NameW2,
	NAME_WMode,
	NAME_Watermark,
	NAME_Widget,
	NAME_Width,
	NAME_Widths,
	NAME_WinAnsiEncoding,
	NAME_Wipe,
	NAME_XHeight,
	NAME_XObject,
	NAME_XRef,
	NAME_XRefStm,
	NAME_XStep,
	NameXyz,
	NAME_YStep,
	NAME_adbe_pkcs7_detached,
	NAME_ca,
	NAME_n0,
	NAME_n1,
	NAME_n2,
	NameLimit,
	BoolFalse = NameLimit,
	BoolTrue,
	Null,
	Limit
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_page_s
{
	public fz_page super;

	public unsafe pdf_document* doc;

	public unsafe pdf_obj* obj;

	public int transparency;

	public int incomplete;

	public unsafe fz_link* links;

	public unsafe pdf_annot* annots;

	public unsafe pdf_annot** annot_tailp;
}

[Verify (InferredFromMemberPrefix)]
public enum PdfPageIncomplete : uint
{
	Contents = 1,
	Annots = 2
}

public enum pdf_token : uint
{
	TokError,
	TokEof,
	TokOpenArray,
	TokCloseArray,
	TokOpenDict,
	TokCloseDict,
	TokOpenBrace,
	TokCloseBrace,
	TokName,
	TokInt,
	TokReal,
	TokString,
	TokKeyword,
	TokR,
	TokTrue,
	TokFalse,
	TokNull,
	TokObj,
	TokEndobj,
	TokStream,
	TokEndstream,
	TokXref,
	TokTrailer,
	TokStartxref,
	NumTokens
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_pattern_s
{
	public fz_storable storable;

	public int ismask;

	public float xstep;

	public float ystep;

	public fz_matrix matrix;

	public fz_rect bbox;

	public unsafe pdf_document* document;

	public unsafe pdf_obj* resources;

	public unsafe pdf_obj* contents;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_xobject_s
{
	public fz_storable storable;

	public unsafe pdf_obj* obj;

	public int iteration;
}

[Verify (InferredFromMemberPrefix)]
public enum PdfWidgetType
{
	NotWidget = -1,
	Pushbutton,
	Checkbox,
	Radiobutton,
	Text,
	Listbox,
	Combobox,
	Signature
}

[Verify (InferredFromMemberPrefix)]
public enum PdfWidgetContent : uint
{
	Unrestrained,
	Number,
	Special,
	Date,
	Time
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_xref_entry_s
{
	public sbyte type;

	public byte flags;

	public ushort gen;

	public int num;

	public int ofs;

	public int stm_ofs;

	public unsafe fz_buffer* stm_buf;

	public unsafe pdf_obj* obj;
}

public enum  : uint
{
	PdfObjFlagMark = 1
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_xref_subsec_s
{
	public unsafe pdf_xref_subsec* next;

	public int len;

	public int start;

	public unsafe pdf_xref_entry* table;
}

[StructLayout (LayoutKind.Sequential)]
public struct pdf_xref_s
{
	public int num_objects;

	public unsafe pdf_xref_subsec* subsec;

	public unsafe pdf_obj* trailer;

	public unsafe pdf_obj* pre_repair_trailer;

	public unsafe pdf_unsaved_sig* unsaved_sigs;

	public unsafe pdf_unsaved_sig** unsaved_sigs_end;

	public int end_ofs;
}
