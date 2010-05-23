BASE_PATH := $(call my-dir)

# Build mono
include $(CLEAR_VARS)
LOCAL_MODULE := monodriver
LOCAL_PATH := $(BASE_PATH)/PlatformPatches
LOCAL_SRC_FILES := main.c
LOCAL_LDLIBS := -L$(SYSROOT)/usr/lib -llog -ldl -lm -lc

include $(BUILD_EXECUTABLE)

# Disable all warnings
# NOTE/WARNING: At one point, this needed to be -O0 or floating point errors ensued
MONO_CFLAGS := -O3 -w
# Eglib stuff
MONO_CFLAGS += -DHAVE_PWD_H -DHAVE_UNISTD_H
# Libgc stuff
MONO_CFLAGS +=	-DGC_LINUX_THREADS=1 -D_REENTRANT=1 -DSTDC_HEADERS=1 -DHAVE_SYS_TYPES_H=1 -DHAVE_SYS_STAT_H=1 -DHAVE_STDLIB_H=1 -DHAVE_STRING_H=1 -DHAVE_MEMORY_H=1 -DHAVE_STRINGS_H=1 -DHAVE_INTTYPES_H=1 -DHAVE_STDINT_H=1 -DHAVE_UNISTD_H=1 -DHAVE_DLFCN_H=1 -DSILENT=1 -DNO_SIGNALS=1 -DNO_EXECUTE_PERMISSION=1 -DJAVA_FINALIZATION=1 -DGC_GCJ_SUPPORT=1 -DATOMIC_UNCOLLECTABLE=1 -D_IN_LIBGC=1  -DGC_LINUX_THREADS -D_GNU_SOURCE -D_REENTRANT -DUSE_MMAP -DUSE_MUNMAP -D_FILE_OFFSET_BITS=64 -DNO_UNALIGNED_ACCESS
# Mono specific defines
MONO_CFLAGS += -DGC_GCJ_SUPPORT=1 -DHAVE_CONFIG_H -DARM_FPU_VFP -DPLATFORM_ANDROID -DMONO_ASSEMBLIES=\"/data/data/com.koushikdutta.mono/assets/lib/\" -DMONO_BINDIR=\"/data/data/com.koushikdutta.mono/assets/bin/\" -DMONO_CFG_DIR=\"/data/data/com.koushikdutta.mono/assets/bin/\"
# libc holes
MONO_CFLAGS += -DS_IWRITE=0200 -D__linux__

MONO_CFLAGS += \
	-I $(BASE_PATH)/PlatformPatches/ \
	-I $(BASE_PATH)/mono/ \
	-I $(BASE_PATH)/mono/mono/ \
	-I $(BASE_PATH)/mono/eglib/src/ \
	-I $(BASE_PATH)/mono/mono/mini/ \
	-I $(BASE_PATH)/mono/libgc/include/ \
	-I $(JNI_H_INCLUDE)


# Build libeglib
include $(CLEAR_VARS)
LOCAL_MODULE := eglib
LOCAL_PATH := $(BASE_PATH)/mono/eglib/src/
# ../config.h and eglib-config.h are both generated by configure
LOCAL_SRC_FILES := 	garray.c gerror.c ghashtable.c gmem.c goutput.c \
	gstr.c gslist.c gstring.c gptrarray.c glist.c gqueue.c gpath.c \
	gshell.c gspawn.c gfile.c gfile-posix.c gpattern.c gmarkup.c \
	gutf8.c gunicode.c gdate-unix.c gdir-unix.c gfile-unix.c \
	gmisc-unix.c gmodule-unix.c gtimer-unix.c 
LOCAL_CFLAGS += $(MONO_CFLAGS)
include $(BUILD_STATIC_LIBRARY)



# Build libmonoutils
include $(CLEAR_VARS)
LOCAL_MODULE := monoutils
LOCAL_PATH := $(BASE_PATH)//mono/mono/utils/
LOCAL_SRC_FILES := mono-ehash.c mono-md5.c \
	mono-sha1.c mono-logger.c mono-codeman.c dlmalloc.h dlmalloc.c \
	mono-counters.c mono-compiler.h mono-dl.c mono-dl.h \
	mono-internal-hash.c mono-internal-hash.h \
	mono-io-portability.c mono-io-portability.h monobitset.c \
	mono-math.c mono-mmap.c mono-mmap.h mono-proclib.c \
	mono-proclib.h mono-time.c mono-time.h strtod.h strtod.c \
	strenc.h strenc.c mono-uri.c mono-poll.c mono-path.c \
	mono-stdlib.c mono-property-hash.h mono-property-hash.c \
	mono-value-hash.h mono-value-hash.c freebsd-elf_common.h \
	freebsd-elf32.h freebsd-elf64.h freebsd-dwarf.h dtrace.h \
	mono-filemap.c mono-networkinterfaces.c mono-error.c \
	mono-semaphore.c
LOCAL_CFLAGS += $(MONO_CFLAGS)
include $(BUILD_STATIC_LIBRARY)


# Build libmonoruntime
include $(CLEAR_VARS)
LOCAL_MODULE := monoruntime
LOCAL_PATH := $(BASE_PATH)/mono/mono/metadata/
LOCAL_SRC_FILES := \
	reflection.c	\
	object.c	\
	object-internals.h	\
	icall.c		\
	icall-def.h		\
	char-conversions.h \
	decimal.c	\
	decimal.h	\
	boehm-gc.c	\
	sgen-gc.c	\
	sgen-gc.h	\
	gc.c		\
	gc-internal.h	\
	method-builder.h \
	method-builder.c \
	mono-mlist.c	\
	mono-mlist.h	\
	tabledefs.h \
	threads-types.h	\
	threadpool-internals.h	\
	file-io.c	\
	file-io.h	\
	socket-io.c	\
	socket-io.h	\
	exception.c	\
	exception.h	\
	debug-mono-symfile.h	\
	debug-mono-symfile.c	\
	mono-debug.h		\
	mono-debug.c		\
	mono-debug-debugger.h	\
	mono-debug-debugger.c	\
	profiler-private.h	\
	attach.h	\
	attach.c	\
	rand.h		\
	rand.c		\
	security.c	\
	security.h	\
	security-core-clr.c	\
	security-core-clr.h	\
	string-icalls.c \
	string-icalls.h \
	sysmath.h	\
	sysmath.c	\
	process.c	\
	process.h	\
	environment.c	\
	environment.h	\
	locales.c	\
	locales.h	\
	normalization-tables.h	\
	filewatcher.c	\
	filewatcher.h	\
	culture-info.h  \
	culture-info-tables.h	\
	security-manager.c	\
	security-manager.h	\
	console-io.h	\
	console-unix.c \
	coree.c \
	coree.h \
	domain.c	\
	domain-internals.h	\
	opcodes.c	\
	cil-coff.h	\
	metadata.c	\
	metadata-internals.h	\
	number-formatter.h	\
	verify.c	\
	verify-internals.h	\
	mono-endian.c	\
	mono-endian.h	\
	mono-config.c	\
	loader.c	\
	class.c		\
	class-internals.h		\
	wrapper-types.h		\
	mempool.c	\
	mono-perfcounters.c	\
	mono-perfcounters.h	\
	mono-perfcounters-def.h	\
	debug-helpers.c	\
	generic-sharing.c	\
	mempool-internals.h \
	metadata-verify.c \
	mono-basic-block.c
LOCAL_CFLAGS += $(MONO_CFLAGS)
include $(BUILD_STATIC_LIBRARY)

# Build libmonoruntimearm
include $(CLEAR_VARS)
LOCAL_ARM_MODE := arm
LOCAL_MODULE := monoruntimearm
LOCAL_PATH := $(BASE_PATH)/mono/mono/metadata/
LOCAL_SRC_FILES := monitor.c \
  marshal.c \
  threadpool.c \
  threads.c \
  appdomain.c \
  profiler.c \
  cominterop.c \
  assembly.c \
  image.c \
	null-gc.c
LOCAL_CFLAGS += $(MONO_CFLAGS)
include $(BUILD_STATIC_LIBRARY)

# Build libwapi
include $(CLEAR_VARS)
LOCAL_MODULE := wapi
LOCAL_PATH := $(BASE_PATH)/mono/mono/io-layer/
LOCAL_SRC_FILES := access.h atomic.c atomic.h \
	collection.h context.c context.h critical-sections.c \
	critical-sections.h critical-section-private.h error.c error.h \
	events.c events.h event-private.h handles.h \
	handles-private.h io.h io-portability.c io-portability.h \
	io-private.h io-layer.h macros.h messages.c messages.h misc.c \
	misc-private.h mutexes.c mutexes.h mutex-private.h \
	mono-mutex.c mono-mutex.h mono-spinlock.h processes.c \
	processes.h process-private.h security.c security.h \
	semaphores.c semaphores.h semaphore-private.h shared.c \
	shared.h sockets.c sockets.h socket-private.h \
	socket-wrappers.h status.h system.c system.h \
	threads.h thread-private.h timefuncs.c timefuncs.h \
	timefuncs-private.h types.h uglify.h versioninfo.c \
	versioninfo.h wait.c wait.h wapi_glob.h wapi_glob.c locking.c posix.c
LOCAL_CFLAGS += $(MONO_CFLAGS)
include $(BUILD_STATIC_LIBRARY)

# Build libwapi
include $(CLEAR_VARS)
LOCAL_MODULE := wapiarm
LOCAL_ARM_MODE := arm
LOCAL_PATH := $(BASE_PATH)/mono/mono/io-layer/
LOCAL_SRC_FILES := collection.c io.c wthreads.c handles.c 
LOCAL_CFLAGS += $(MONO_CFLAGS)
include $(BUILD_STATIC_LIBRARY)

# Build libgc
include $(CLEAR_VARS)
LOCAL_MODULE := gc
LOCAL_PATH := $(BASE_PATH)/mono/libgc/
LOCAL_SRC_FILES := allchblk.c blacklst.c \
	checksums.c dyn_load.c \
	headers.c mark.c \
	new_hblk.c pcr_interface.c \
	ptr_chck.c real_malloc.c solaris_pthreads.c \
	solaris_threads.c specific.c stubborn.c backgraph.c \
	win32_threads.c pthread_stop_world.c \
	darwin_stop_world.c mach_dep.c
LOCAL_CFLAGS += $(MONO_CFLAGS)
include $(BUILD_STATIC_LIBRARY)

# Build libgc
include $(CLEAR_VARS)
LOCAL_MODULE := gcarm
LOCAL_ARM_MODE := arm
LOCAL_PATH := $(BASE_PATH)/mono/libgc/
LOCAL_SRC_FILES := alloc.c dbg_mlc.c finalize.c gc_dlopen.c gcj_mlc.c malloc.c \
  mallocx.c  mark_rts.c obj_map.c os_dep.c misc.c reclaim.c pthread_support.c typd_mlc.c
LOCAL_CFLAGS += $(MONO_CFLAGS)
include $(BUILD_STATIC_LIBRARY)

# Build libmono
include $(CLEAR_VARS)
LOCAL_MODULE := miniarm
LOCAL_ARM_MODE := arm
LOCAL_PATH := $(BASE_PATH)/mono/mono/mini/
# ../config.h, arm_dpimacros.h, version.h and cpu-arm.h are generated by configure
LOCAL_SRC_FILES := aot-compiler.c debugger-agent.c
LOCAL_CFLAGS += $(MONO_CFLAGS)
include $(BUILD_STATIC_LIBRARY)

# Build libmono
include $(CLEAR_VARS)
LOCAL_MODULE := mini
LOCAL_PATH := $(BASE_PATH)/mono/mono/mini/
# ../config.h, arm_dpimacros.h, version.h and cpu-arm.h are generated by configure
LOCAL_SRC_FILES := mini.c method-to-ir.c \
	decompose.c \
	jit-icalls.c trace.c \
	mini-arch.h dominators.c cfold.c regalloc.c \
	helpers.c liveness.c ssa.c abcremoval.c ssapre.c \
	local-propagation.c driver.c debug-mini.c \
	linear-scan.c aot-runtime.c \
	graph.c mini-exceptions.c mini-codegen.c mini-trampolines.c \
	declsec.c wapihandles.c branch-opts.c \
	mini-generic-sharing.c regalloc2.c simd-intrinsics.c \
	unwind.h unwind.c mini-posix.c \
	mini-arm.c exceptions-arm.c tramp-arm.c image-writer.c \
	dwarfwriter.c mini-gc.c
LOCAL_CFLAGS += $(MONO_CFLAGS)
include $(BUILD_STATIC_LIBRARY)



include $(CLEAR_VARS)
LOCAL_MODULE := mono
LOCAL_PATH := $(BASE_PATH)
LOCAL_SRC_FILES := PlatformPatches/missing.c MonoJavaBridge/MonoJavaInterop/MonoJavaInterop.c
LOCAL_PRELINK_MODULE := false
LOCAL_CFLAGS += $(MONO_CFLAGS)
LOCAL_STATIC_LIBRARIES := monoutils eglib monoruntime gc wapi monoruntimearm monoarm gcarm wapiarm interop mini miniarm
LOCAL_LDFLAGS := -Wall -L$(TARGET_OUT) -lwapiarm -lgcarm -lmonoruntimearm -lmonoutils -leglib -lmonoruntime -lgc -lwapi -lmini -lminiarm
LOCAL_LDLIBS := -L$(SYSROOT)/usr/lib -llog -ldl -lm -lc
include $(BUILD_SHARED_LIBRARY)

include $(CLEAR_VARS)
LOCAL_PATH := $(BASE_PATH)
LOCAL_MODULE := fwdstdin
LOCAL_SRC_FILES := fwdstdin/main.c
LOCAL_LDLIBS := -L$(SYSROOT)/usr/lib -ldl -lm -lc
include $(BUILD_EXECUTABLE)

include $(CLEAR_VARS)
LOCAL_PATH := $(BASE_PATH)/aot
LOCAL_SRC_FILES := mscorlib.dll.S
LOCAL_MODULE := mscorlib.dll
LOCAL_LDLIBS := -L$(SYSROOT)/usr/lib -llog -ldl -lm -lc
include $(BUILD_SHARED_LIBRARY)
