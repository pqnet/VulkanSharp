/* Please note that this file is generated by the VulkanSharp's generator. Do not edit directly.

   Licensed under the MIT license.

   Copyright 2016 Xamarin Inc

   This notice may not be removed from any source distribution.
   See LICENSE file for licensing details.
*/

using System;

namespace Vulkan.Interop
{
	internal struct Offset2D
	{
		internal Int32 X;
		internal Int32 Y;
	}

	internal struct Offset3D
	{
		internal Int32 X;
		internal Int32 Y;
		internal Int32 Z;
	}

	internal struct Extent2D
	{
		internal UInt32 Width;
		internal UInt32 Height;
	}

	internal struct Extent3D
	{
		internal UInt32 Width;
		internal UInt32 Height;
		internal UInt32 Depth;
	}

	internal struct Viewport
	{
		internal float X;
		internal float Y;
		internal float Width;
		internal float Height;
		internal float MinDepth;
		internal float MaxDepth;
	}

	internal struct Rect2D
	{
		internal IntPtr Offset;
		internal IntPtr Extent;
	}

	internal struct Rect3D
	{
		internal IntPtr Offset;
		internal IntPtr Extent;
	}

	internal struct ClearRect
	{
		internal IntPtr Rect;
		internal UInt32 BaseArrayLayer;
		internal UInt32 LayerCount;
	}

	internal struct ComponentMapping
	{
		internal ComponentSwizzle R;
		internal ComponentSwizzle G;
		internal ComponentSwizzle B;
		internal ComponentSwizzle A;
	}

	internal struct PhysicalDeviceProperties
	{
		internal UInt32 ApiVersion;
		internal UInt32 DriverVersion;
		internal UInt32 VendorID;
		internal UInt32 DeviceID;
		internal PhysicalDeviceType DeviceType;
		internal char DeviceName;
		internal Byte PipelineCacheUUID;
		internal IntPtr Limits;
		internal IntPtr SparseProperties;
	}

	internal struct ExtensionProperties
	{
		internal char ExtensionName;
		internal UInt32 SpecVersion;
	}

	internal struct LayerProperties
	{
		internal char LayerName;
		internal UInt32 SpecVersion;
		internal UInt32 ImplementationVersion;
		internal char Description;
	}

	internal struct ApplicationInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal IntPtr ApplicationName;
		internal UInt32 ApplicationVersion;
		internal IntPtr EngineName;
		internal UInt32 EngineVersion;
		internal UInt32 ApiVersion;
	}

	internal struct AllocationCallbacks
	{
		internal IntPtr UserData;
		internal IntPtr PfnAllocation;
		internal IntPtr PfnReallocation;
		internal IntPtr PfnFree;
		internal IntPtr PfnInternalAllocation;
		internal IntPtr PfnInternalFree;
	}

	internal struct DeviceQueueCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 QueueFamilyIndex;
		internal UInt32 QueueCount;
		internal float QueuePriorities;
	}

	internal struct DeviceCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 QueueCreateInfoCount;
		internal IntPtr QueueCreateInfos;
		internal UInt32 EnabledLayerCount;
		internal IntPtr EnabledLayerNames;
		internal UInt32 EnabledExtensionCount;
		internal IntPtr EnabledExtensionNames;
		internal IntPtr EnabledFeatures;
	}

	internal struct InstanceCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal IntPtr ApplicationInfo;
		internal UInt32 EnabledLayerCount;
		internal IntPtr EnabledLayerNames;
		internal UInt32 EnabledExtensionCount;
		internal IntPtr EnabledExtensionNames;
	}

	internal struct QueueFamilyProperties
	{
		internal UInt32 QueueFlags;
		internal UInt32 QueueCount;
		internal UInt32 TimestampValidBits;
		internal IntPtr MinImageTransferGranularity;
	}

	internal struct PhysicalDeviceMemoryProperties
	{
		internal UInt32 MemoryTypeCount;
		internal IntPtr MemoryTypes;
		internal UInt32 MemoryHeapCount;
		internal IntPtr MemoryHeaps;
	}

	internal struct MemoryAllocateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal DeviceSize AllocationSize;
		internal UInt32 MemoryTypeIndex;
	}

	internal struct MemoryRequirements
	{
		internal DeviceSize Size;
		internal DeviceSize Alignment;
		internal UInt32 MemoryTypeBits;
	}

	internal struct SparseImageFormatProperties
	{
		internal UInt32 AspectMask;
		internal IntPtr ImageGranularity;
		internal UInt32 Flags;
	}

	internal struct SparseImageMemoryRequirements
	{
		internal IntPtr FormatProperties;
		internal UInt32 ImageMipTailFirstLod;
		internal DeviceSize ImageMipTailSize;
		internal DeviceSize ImageMipTailOffset;
		internal DeviceSize ImageMipTailStride;
	}

	internal struct MemoryType
	{
		internal UInt32 PropertyFlags;
		internal UInt32 HeapIndex;
	}

	internal struct MemoryHeap
	{
		internal DeviceSize Size;
		internal UInt32 Flags;
	}

	internal struct MappedMemoryRange
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal IntPtr Memory;
		internal DeviceSize Offset;
		internal DeviceSize Size;
	}

	internal struct FormatProperties
	{
		internal UInt32 LinearTilingFeatures;
		internal UInt32 OptimalTilingFeatures;
		internal UInt32 BufferFeatures;
	}

	internal struct ImageFormatProperties
	{
		internal IntPtr MaxExtent;
		internal UInt32 MaxMipLevels;
		internal UInt32 MaxArrayLayers;
		internal UInt32 SampleCounts;
		internal DeviceSize MaxResourceSize;
	}

	internal struct DescriptorBufferInfo
	{
		internal IntPtr Buffer;
		internal DeviceSize Offset;
		internal DeviceSize Range;
	}

	internal struct DescriptorImageInfo
	{
		internal IntPtr Sampler;
		internal IntPtr ImageView;
		internal ImageLayout ImageLayout;
	}

	internal struct WriteDescriptorSet
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal IntPtr DstSet;
		internal UInt32 DstBinding;
		internal UInt32 DstArrayElement;
		internal UInt32 DescriptorCount;
		internal DescriptorType DescriptorType;
		internal IntPtr ImageInfo;
		internal IntPtr BufferInfo;
		internal IntPtr TexelBufferView;
	}

	internal struct CopyDescriptorSet
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal IntPtr SrcSet;
		internal UInt32 SrcBinding;
		internal UInt32 SrcArrayElement;
		internal IntPtr DstSet;
		internal UInt32 DstBinding;
		internal UInt32 DstArrayElement;
		internal UInt32 DescriptorCount;
	}

	internal struct BufferCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal DeviceSize Size;
		internal UInt32 Usage;
		internal SharingMode SharingMode;
		internal UInt32 QueueFamilyIndexCount;
		internal UInt32 QueueFamilyIndices;
	}

	internal struct BufferViewCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal IntPtr Buffer;
		internal Format Format;
		internal DeviceSize Offset;
		internal DeviceSize Range;
	}

	internal struct ImageSubresource
	{
		internal UInt32 AspectMask;
		internal UInt32 MipLevel;
		internal UInt32 ArrayLayer;
	}

	internal struct ImageSubresourceLayers
	{
		internal UInt32 AspectMask;
		internal UInt32 MipLevel;
		internal UInt32 BaseArrayLayer;
		internal UInt32 LayerCount;
	}

	internal struct ImageSubresourceRange
	{
		internal UInt32 AspectMask;
		internal UInt32 BaseMipLevel;
		internal UInt32 LevelCount;
		internal UInt32 BaseArrayLayer;
		internal UInt32 LayerCount;
	}

	internal struct MemoryBarrier
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 SrcAccessMask;
		internal UInt32 DstAccessMask;
	}

	internal struct BufferMemoryBarrier
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 SrcAccessMask;
		internal UInt32 DstAccessMask;
		internal UInt32 SrcQueueFamilyIndex;
		internal UInt32 DstQueueFamilyIndex;
		internal IntPtr Buffer;
		internal DeviceSize Offset;
		internal DeviceSize Size;
	}

	internal struct ImageMemoryBarrier
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 SrcAccessMask;
		internal UInt32 DstAccessMask;
		internal ImageLayout OldLayout;
		internal ImageLayout NewLayout;
		internal UInt32 SrcQueueFamilyIndex;
		internal UInt32 DstQueueFamilyIndex;
		internal IntPtr Image;
		internal IntPtr SubresourceRange;
	}

	internal struct ImageCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal ImageType ImageType;
		internal Format Format;
		internal IntPtr Extent;
		internal UInt32 MipLevels;
		internal UInt32 ArrayLayers;
		internal UInt32 Samples;
		internal ImageTiling Tiling;
		internal UInt32 Usage;
		internal SharingMode SharingMode;
		internal UInt32 QueueFamilyIndexCount;
		internal UInt32 QueueFamilyIndices;
		internal ImageLayout InitialLayout;
	}

	internal struct SubresourceLayout
	{
		internal DeviceSize Offset;
		internal DeviceSize Size;
		internal DeviceSize RowPitch;
		internal DeviceSize ArrayPitch;
		internal DeviceSize DepthPitch;
	}

	internal struct ImageViewCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal IntPtr Image;
		internal ImageViewType ViewType;
		internal Format Format;
		internal IntPtr Components;
		internal IntPtr SubresourceRange;
	}

	internal struct BufferCopy
	{
		internal DeviceSize SrcOffset;
		internal DeviceSize DstOffset;
		internal DeviceSize Size;
	}

	internal struct SparseMemoryBind
	{
		internal DeviceSize ResourceOffset;
		internal DeviceSize Size;
		internal IntPtr Memory;
		internal DeviceSize MemoryOffset;
		internal UInt32 Flags;
	}

	internal struct SparseImageMemoryBind
	{
		internal IntPtr Subresource;
		internal IntPtr Offset;
		internal IntPtr Extent;
		internal IntPtr Memory;
		internal DeviceSize MemoryOffset;
		internal UInt32 Flags;
	}

	internal struct SparseBufferMemoryBindInfo
	{
		internal IntPtr Buffer;
		internal UInt32 BindCount;
		internal IntPtr Binds;
	}

	internal struct SparseImageOpaqueMemoryBindInfo
	{
		internal IntPtr Image;
		internal UInt32 BindCount;
		internal IntPtr Binds;
	}

	internal struct SparseImageMemoryBindInfo
	{
		internal IntPtr Image;
		internal UInt32 BindCount;
		internal IntPtr Binds;
	}

	internal struct BindSparseInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 WaitSemaphoreCount;
		internal IntPtr WaitSemaphores;
		internal UInt32 BufferBindCount;
		internal IntPtr BufferBinds;
		internal UInt32 ImageOpaqueBindCount;
		internal IntPtr ImageOpaqueBinds;
		internal UInt32 ImageBindCount;
		internal IntPtr ImageBinds;
		internal UInt32 SignalSemaphoreCount;
		internal IntPtr SignalSemaphores;
	}

	internal struct ImageCopy
	{
		internal IntPtr SrcSubresource;
		internal IntPtr SrcOffset;
		internal IntPtr DstSubresource;
		internal IntPtr DstOffset;
		internal IntPtr Extent;
	}

	internal struct ImageBlit
	{
		internal IntPtr SrcSubresource;
		internal IntPtr SrcOffsets;
		internal IntPtr DstSubresource;
		internal IntPtr DstOffsets;
	}

	internal struct BufferImageCopy
	{
		internal DeviceSize BufferOffset;
		internal UInt32 BufferRowLength;
		internal UInt32 BufferImageHeight;
		internal IntPtr ImageSubresource;
		internal IntPtr ImageOffset;
		internal IntPtr ImageExtent;
	}

	internal struct ImageResolve
	{
		internal IntPtr SrcSubresource;
		internal IntPtr SrcOffset;
		internal IntPtr DstSubresource;
		internal IntPtr DstOffset;
		internal IntPtr Extent;
	}

	internal struct ShaderModuleCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UIntPtr CodeSize;
		internal UInt32 Code;
	}

	internal struct DescriptorSetLayoutBinding
	{
		internal UInt32 Binding;
		internal DescriptorType DescriptorType;
		internal UInt32 DescriptorCount;
		internal UInt32 StageFlags;
		internal IntPtr ImmutableSamplers;
	}

	internal struct DescriptorSetLayoutCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 BindingCount;
		internal IntPtr Bindings;
	}

	internal struct DescriptorPoolSize
	{
		internal DescriptorType Type;
		internal UInt32 DescriptorCount;
	}

	internal struct DescriptorPoolCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 MaxSets;
		internal UInt32 PoolSizeCount;
		internal IntPtr PoolSizes;
	}

	internal struct DescriptorSetAllocateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal IntPtr DescriptorPool;
		internal UInt32 DescriptorSetCount;
		internal IntPtr SetLayouts;
	}

	internal struct SpecializationMapEntry
	{
		internal UInt32 ConstantID;
		internal UInt32 Offset;
		internal UIntPtr Size;
	}

	internal struct SpecializationInfo
	{
		internal UInt32 MapEntryCount;
		internal IntPtr MapEntries;
		internal UIntPtr DataSize;
		internal IntPtr Data;
	}

	internal struct PipelineShaderStageCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 Stage;
		internal IntPtr Module;
		internal IntPtr Name;
		internal IntPtr SpecializationInfo;
	}

	internal struct ComputePipelineCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal IntPtr Stage;
		internal IntPtr Layout;
		internal IntPtr BasePipelineHandle;
		internal Int32 BasePipelineIndex;
	}

	internal struct VertexInputBindingDescription
	{
		internal UInt32 Binding;
		internal UInt32 Stride;
		internal VertexInputRate InputRate;
	}

	internal struct VertexInputAttributeDescription
	{
		internal UInt32 Location;
		internal UInt32 Binding;
		internal Format Format;
		internal UInt32 Offset;
	}

	internal struct PipelineVertexInputStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 VertexBindingDescriptionCount;
		internal IntPtr VertexBindingDescriptions;
		internal UInt32 VertexAttributeDescriptionCount;
		internal IntPtr VertexAttributeDescriptions;
	}

	internal struct PipelineInputAssemblyStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal PrimitiveTopology Topology;
		internal Bool32 PrimitiveRestartEnable;
	}

	internal struct PipelineTessellationStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 PatchControlPoints;
	}

	internal struct PipelineViewportStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 ViewportCount;
		internal IntPtr Viewports;
		internal UInt32 ScissorCount;
		internal IntPtr Scissors;
	}

	internal struct PipelineRasterizationStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal Bool32 DepthClampEnable;
		internal Bool32 RasterizerDiscardEnable;
		internal PolygonMode PolygonMode;
		internal UInt32 CullMode;
		internal FrontFace FrontFace;
		internal Bool32 DepthBiasEnable;
		internal float DepthBiasConstantFactor;
		internal float DepthBiasClamp;
		internal float DepthBiasSlopeFactor;
		internal float LineWidth;
	}

	internal struct PipelineMultisampleStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 RasterizationSamples;
		internal Bool32 SampleShadingEnable;
		internal float MinSampleShading;
		internal UInt32 SampleMask;
		internal Bool32 AlphaToCoverageEnable;
		internal Bool32 AlphaToOneEnable;
	}

	internal struct PipelineColorBlendAttachmentState
	{
		internal Bool32 BlendEnable;
		internal BlendFactor SrcColorBlendFactor;
		internal BlendFactor DstColorBlendFactor;
		internal BlendOp ColorBlendOp;
		internal BlendFactor SrcAlphaBlendFactor;
		internal BlendFactor DstAlphaBlendFactor;
		internal BlendOp AlphaBlendOp;
		internal UInt32 ColorWriteMask;
	}

	internal struct PipelineColorBlendStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal Bool32 LogicOpEnable;
		internal LogicOp LogicOp;
		internal UInt32 AttachmentCount;
		internal IntPtr Attachments;
		internal float BlendConstants;
	}

	internal struct PipelineDynamicStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 DynamicStateCount;
		internal DynamicState DynamicStates;
	}

	internal struct StencilOpState
	{
		internal StencilOp FailOp;
		internal StencilOp PassOp;
		internal StencilOp DepthFailOp;
		internal CompareOp CompareOp;
		internal UInt32 CompareMask;
		internal UInt32 WriteMask;
		internal UInt32 Reference;
	}

	internal struct PipelineDepthStencilStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal Bool32 DepthTestEnable;
		internal Bool32 DepthWriteEnable;
		internal CompareOp DepthCompareOp;
		internal Bool32 DepthBoundsTestEnable;
		internal Bool32 StencilTestEnable;
		internal IntPtr Front;
		internal IntPtr Back;
		internal float MinDepthBounds;
		internal float MaxDepthBounds;
	}

	internal struct GraphicsPipelineCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 StageCount;
		internal IntPtr Stages;
		internal IntPtr VertexInputState;
		internal IntPtr InputAssemblyState;
		internal IntPtr TessellationState;
		internal IntPtr ViewportState;
		internal IntPtr RasterizationState;
		internal IntPtr MultisampleState;
		internal IntPtr DepthStencilState;
		internal IntPtr ColorBlendState;
		internal IntPtr DynamicState;
		internal IntPtr Layout;
		internal IntPtr RenderPass;
		internal UInt32 Subpass;
		internal IntPtr BasePipelineHandle;
		internal Int32 BasePipelineIndex;
	}

	internal struct PipelineCacheCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UIntPtr InitialDataSize;
		internal IntPtr InitialData;
	}

	internal struct PushConstantRange
	{
		internal UInt32 StageFlags;
		internal UInt32 Offset;
		internal UInt32 Size;
	}

	internal struct PipelineLayoutCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 SetLayoutCount;
		internal IntPtr SetLayouts;
		internal UInt32 PushConstantRangeCount;
		internal IntPtr PushConstantRanges;
	}

	internal struct SamplerCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal Filter MagFilter;
		internal Filter MinFilter;
		internal SamplerMipmapMode MipmapMode;
		internal SamplerAddressMode AddressModeU;
		internal SamplerAddressMode AddressModeV;
		internal SamplerAddressMode AddressModeW;
		internal float MipLodBias;
		internal Bool32 AnisotropyEnable;
		internal float MaxAnisotropy;
		internal Bool32 CompareEnable;
		internal CompareOp CompareOp;
		internal float MinLod;
		internal float MaxLod;
		internal BorderColor BorderColor;
		internal Bool32 UnnormalizedCoordinates;
	}

	internal struct CommandPoolCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 QueueFamilyIndex;
	}

	internal struct CommandBufferAllocateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal IntPtr CommandPool;
		internal CommandBufferLevel Level;
		internal UInt32 CommandBufferCount;
	}

	internal struct CommandBufferInheritanceInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal IntPtr RenderPass;
		internal UInt32 Subpass;
		internal IntPtr Framebuffer;
		internal Bool32 OcclusionQueryEnable;
		internal UInt32 QueryFlags;
		internal UInt32 PipelineStatistics;
	}

	internal struct CommandBufferBeginInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal IntPtr InheritanceInfo;
	}

	internal struct RenderPassBeginInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal IntPtr RenderPass;
		internal IntPtr Framebuffer;
		internal IntPtr RenderArea;
		internal UInt32 ClearValueCount;
		internal IntPtr ClearValues;
	}

	internal struct ClearDepthStencilValue
	{
		internal float Depth;
		internal UInt32 Stencil;
	}

	internal struct ClearAttachment
	{
		internal UInt32 AspectMask;
		internal UInt32 ColorAttachment;
		internal IntPtr ClearValue;
	}

	internal struct AttachmentDescription
	{
		internal UInt32 Flags;
		internal Format Format;
		internal UInt32 Samples;
		internal AttachmentLoadOp LoadOp;
		internal AttachmentStoreOp StoreOp;
		internal AttachmentLoadOp StencilLoadOp;
		internal AttachmentStoreOp StencilStoreOp;
		internal ImageLayout InitialLayout;
		internal ImageLayout FinalLayout;
	}

	internal struct AttachmentReference
	{
		internal UInt32 Attachment;
		internal ImageLayout Layout;
	}

	internal struct SubpassDescription
	{
		internal UInt32 Flags;
		internal PipelineBindPoint PipelineBindPoint;
		internal UInt32 InputAttachmentCount;
		internal IntPtr InputAttachments;
		internal UInt32 ColorAttachmentCount;
		internal IntPtr ColorAttachments;
		internal IntPtr ResolveAttachments;
		internal IntPtr DepthStencilAttachment;
		internal UInt32 PreserveAttachmentCount;
		internal UInt32 PreserveAttachments;
	}

	internal struct SubpassDependency
	{
		internal UInt32 SrcSubpass;
		internal UInt32 DstSubpass;
		internal UInt32 SrcStageMask;
		internal UInt32 DstStageMask;
		internal UInt32 SrcAccessMask;
		internal UInt32 DstAccessMask;
		internal UInt32 DependencyFlags;
	}

	internal struct RenderPassCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 AttachmentCount;
		internal IntPtr Attachments;
		internal UInt32 SubpassCount;
		internal IntPtr Subpasses;
		internal UInt32 DependencyCount;
		internal IntPtr Dependencies;
	}

	internal struct EventCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
	}

	internal struct FenceCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
	}

	internal struct PhysicalDeviceFeatures
	{
		internal Bool32 RobustBufferAccess;
		internal Bool32 FullDrawIndexUint32;
		internal Bool32 ImageCubeArray;
		internal Bool32 IndependentBlend;
		internal Bool32 GeometryShader;
		internal Bool32 TessellationShader;
		internal Bool32 SampleRateShading;
		internal Bool32 DualSrcBlend;
		internal Bool32 LogicOp;
		internal Bool32 MultiDrawIndirect;
		internal Bool32 DrawIndirectFirstInstance;
		internal Bool32 DepthClamp;
		internal Bool32 DepthBiasClamp;
		internal Bool32 FillModeNonSolid;
		internal Bool32 DepthBounds;
		internal Bool32 WideLines;
		internal Bool32 LargePoints;
		internal Bool32 AlphaToOne;
		internal Bool32 MultiViewport;
		internal Bool32 SamplerAnisotropy;
		internal Bool32 TextureCompressionETC2;
		internal Bool32 TextureCompressionASTCLdr;
		internal Bool32 TextureCompressionBC;
		internal Bool32 OcclusionQueryPrecise;
		internal Bool32 PipelineStatisticsQuery;
		internal Bool32 VertexPipelineStoresAndAtomics;
		internal Bool32 FragmentStoresAndAtomics;
		internal Bool32 ShaderTessellationAndGeometryPointSize;
		internal Bool32 ShaderImageGatherExtended;
		internal Bool32 ShaderStorageImageExtendedFormats;
		internal Bool32 ShaderStorageImageMultisample;
		internal Bool32 ShaderStorageImageReadWithoutFormat;
		internal Bool32 ShaderStorageImageWriteWithoutFormat;
		internal Bool32 ShaderUniformBufferArrayDynamicIndexing;
		internal Bool32 ShaderSampledImageArrayDynamicIndexing;
		internal Bool32 ShaderStorageBufferArrayDynamicIndexing;
		internal Bool32 ShaderStorageImageArrayDynamicIndexing;
		internal Bool32 ShaderClipDistance;
		internal Bool32 ShaderCullDistance;
		internal Bool32 ShaderFloat64;
		internal Bool32 ShaderInt64;
		internal Bool32 ShaderInt16;
		internal Bool32 ShaderResourceResidency;
		internal Bool32 ShaderResourceMinLod;
		internal Bool32 SparseBinding;
		internal Bool32 SparseResidencyBuffer;
		internal Bool32 SparseResidencyImage2D;
		internal Bool32 SparseResidencyImage3D;
		internal Bool32 SparseResidency2Samples;
		internal Bool32 SparseResidency4Samples;
		internal Bool32 SparseResidency8Samples;
		internal Bool32 SparseResidency16Samples;
		internal Bool32 SparseResidencyAliased;
		internal Bool32 VariableMultisampleRate;
		internal Bool32 InheritedQueries;
	}

	internal struct PhysicalDeviceSparseProperties
	{
		internal Bool32 ResidencyStandard2DBlockShape;
		internal Bool32 ResidencyStandard2DMultisampleBlockShape;
		internal Bool32 ResidencyStandard3DBlockShape;
		internal Bool32 ResidencyAlignedMipSize;
		internal Bool32 ResidencyNonResidentStrict;
	}

	internal struct PhysicalDeviceLimits
	{
		internal UInt32 MaxImageDimension1D;
		internal UInt32 MaxImageDimension2D;
		internal UInt32 MaxImageDimension3D;
		internal UInt32 MaxImageDimensionCube;
		internal UInt32 MaxImageArrayLayers;
		internal UInt32 MaxTexelBufferElements;
		internal UInt32 MaxUniformBufferRange;
		internal UInt32 MaxStorageBufferRange;
		internal UInt32 MaxPushConstantsSize;
		internal UInt32 MaxMemoryAllocationCount;
		internal UInt32 MaxSamplerAllocationCount;
		internal DeviceSize BufferImageGranularity;
		internal DeviceSize SparseAddressSpaceSize;
		internal UInt32 MaxBoundDescriptorSets;
		internal UInt32 MaxPerStageDescriptorSamplers;
		internal UInt32 MaxPerStageDescriptorUniformBuffers;
		internal UInt32 MaxPerStageDescriptorStorageBuffers;
		internal UInt32 MaxPerStageDescriptorSampledImages;
		internal UInt32 MaxPerStageDescriptorStorageImages;
		internal UInt32 MaxPerStageDescriptorInputAttachments;
		internal UInt32 MaxPerStageResources;
		internal UInt32 MaxDescriptorSetSamplers;
		internal UInt32 MaxDescriptorSetUniformBuffers;
		internal UInt32 MaxDescriptorSetUniformBuffersDynamic;
		internal UInt32 MaxDescriptorSetStorageBuffers;
		internal UInt32 MaxDescriptorSetStorageBuffersDynamic;
		internal UInt32 MaxDescriptorSetSampledImages;
		internal UInt32 MaxDescriptorSetStorageImages;
		internal UInt32 MaxDescriptorSetInputAttachments;
		internal UInt32 MaxVertexInputAttributes;
		internal UInt32 MaxVertexInputBindings;
		internal UInt32 MaxVertexInputAttributeOffset;
		internal UInt32 MaxVertexInputBindingStride;
		internal UInt32 MaxVertexOutputComponents;
		internal UInt32 MaxTessellationGenerationLevel;
		internal UInt32 MaxTessellationPatchSize;
		internal UInt32 MaxTessellationControlPerVertexInputComponents;
		internal UInt32 MaxTessellationControlPerVertexOutputComponents;
		internal UInt32 MaxTessellationControlPerPatchOutputComponents;
		internal UInt32 MaxTessellationControlTotalOutputComponents;
		internal UInt32 MaxTessellationEvaluationInputComponents;
		internal UInt32 MaxTessellationEvaluationOutputComponents;
		internal UInt32 MaxGeometryShaderInvocations;
		internal UInt32 MaxGeometryInputComponents;
		internal UInt32 MaxGeometryOutputComponents;
		internal UInt32 MaxGeometryOutputVertices;
		internal UInt32 MaxGeometryTotalOutputComponents;
		internal UInt32 MaxFragmentInputComponents;
		internal UInt32 MaxFragmentOutputAttachments;
		internal UInt32 MaxFragmentDualSrcAttachments;
		internal UInt32 MaxFragmentCombinedOutputResources;
		internal UInt32 MaxComputeSharedMemorySize;
		internal UInt32 MaxComputeWorkGroupCount;
		internal UInt32 MaxComputeWorkGroupInvocations;
		internal UInt32 MaxComputeWorkGroupSize;
		internal UInt32 SubPixelPrecisionBits;
		internal UInt32 SubTexelPrecisionBits;
		internal UInt32 MipmapPrecisionBits;
		internal UInt32 MaxDrawIndexedIndexValue;
		internal UInt32 MaxDrawIndirectCount;
		internal float MaxSamplerLodBias;
		internal float MaxSamplerAnisotropy;
		internal UInt32 MaxViewports;
		internal UInt32 MaxViewportDimensions;
		internal float ViewportBoundsRange;
		internal UInt32 ViewportSubPixelBits;
		internal UIntPtr MinMemoryMapAlignment;
		internal DeviceSize MinTexelBufferOffsetAlignment;
		internal DeviceSize MinUniformBufferOffsetAlignment;
		internal DeviceSize MinStorageBufferOffsetAlignment;
		internal Int32 MinTexelOffset;
		internal UInt32 MaxTexelOffset;
		internal Int32 MinTexelGatherOffset;
		internal UInt32 MaxTexelGatherOffset;
		internal float MinInterpolationOffset;
		internal float MaxInterpolationOffset;
		internal UInt32 SubPixelInterpolationOffsetBits;
		internal UInt32 MaxFramebufferWidth;
		internal UInt32 MaxFramebufferHeight;
		internal UInt32 MaxFramebufferLayers;
		internal UInt32 FramebufferColorSampleCounts;
		internal UInt32 FramebufferDepthSampleCounts;
		internal UInt32 FramebufferStencilSampleCounts;
		internal UInt32 FramebufferNoAttachmentsSampleCounts;
		internal UInt32 MaxColorAttachments;
		internal UInt32 SampledImageColorSampleCounts;
		internal UInt32 SampledImageIntegerSampleCounts;
		internal UInt32 SampledImageDepthSampleCounts;
		internal UInt32 SampledImageStencilSampleCounts;
		internal UInt32 StorageImageSampleCounts;
		internal UInt32 MaxSampleMaskWords;
		internal Bool32 TimestampComputeAndGraphics;
		internal float TimestampPeriod;
		internal UInt32 MaxClipDistances;
		internal UInt32 MaxCullDistances;
		internal UInt32 MaxCombinedClipAndCullDistances;
		internal UInt32 DiscreteQueuePriorities;
		internal float PointSizeRange;
		internal float LineWidthRange;
		internal float PointSizeGranularity;
		internal float LineWidthGranularity;
		internal Bool32 StrictLines;
		internal Bool32 StandardSampleLocations;
		internal DeviceSize OptimalBufferCopyOffsetAlignment;
		internal DeviceSize OptimalBufferCopyRowPitchAlignment;
		internal DeviceSize NonCoherentAtomSize;
	}

	internal struct SemaphoreCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
	}

	internal struct QueryPoolCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal QueryType QueryType;
		internal UInt32 QueryCount;
		internal UInt32 PipelineStatistics;
	}

	internal struct FramebufferCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal IntPtr RenderPass;
		internal UInt32 AttachmentCount;
		internal IntPtr Attachments;
		internal UInt32 Width;
		internal UInt32 Height;
		internal UInt32 Layers;
	}

	internal struct DrawIndirectCommand
	{
		internal UInt32 VertexCount;
		internal UInt32 InstanceCount;
		internal UInt32 FirstVertex;
		internal UInt32 FirstInstance;
	}

	internal struct DrawIndexedIndirectCommand
	{
		internal UInt32 IndexCount;
		internal UInt32 InstanceCount;
		internal UInt32 FirstIndex;
		internal Int32 VertexOffset;
		internal UInt32 FirstInstance;
	}

	internal struct DispatchIndirectCommand
	{
		internal UInt32 X;
		internal UInt32 Y;
		internal UInt32 Z;
	}

	internal struct SubmitInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 WaitSemaphoreCount;
		internal IntPtr WaitSemaphores;
		internal UInt32 WaitDstStageMask;
		internal UInt32 CommandBufferCount;
		internal IntPtr CommandBuffers;
		internal UInt32 SignalSemaphoreCount;
		internal IntPtr SignalSemaphores;
	}

	internal struct DisplayPropertiesKhr
	{
		internal IntPtr Display;
		internal IntPtr DisplayName;
		internal IntPtr PhysicalDimensions;
		internal IntPtr PhysicalResolution;
		internal SurfaceTransformFlagsKhr SupportedTransforms;
		internal Bool32 PlaneReorderPossible;
		internal Bool32 PersistentContent;
	}

	internal struct DisplayPlanePropertiesKhr
	{
		internal IntPtr CurrentDisplay;
		internal UInt32 CurrentStackIndex;
	}

	internal struct DisplayModeParametersKhr
	{
		internal IntPtr VisibleRegion;
		internal UInt32 RefreshRate;
	}

	internal struct DisplayModePropertiesKhr
	{
		internal IntPtr DisplayMode;
		internal IntPtr Parameters;
	}

	internal struct DisplayModeCreateInfoKhr
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal IntPtr Parameters;
	}

	internal struct DisplayPlaneCapabilitiesKhr
	{
		internal DisplayPlaneAlphaFlagsKhr SupportedAlpha;
		internal IntPtr MinSrcPosition;
		internal IntPtr MaxSrcPosition;
		internal IntPtr MinSrcExtent;
		internal IntPtr MaxSrcExtent;
		internal IntPtr MinDstPosition;
		internal IntPtr MaxDstPosition;
		internal IntPtr MinDstExtent;
		internal IntPtr MaxDstExtent;
	}

	internal struct DisplaySurfaceCreateInfoKhr
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal IntPtr DisplayMode;
		internal UInt32 PlaneIndex;
		internal UInt32 PlaneStackIndex;
		internal SurfaceTransformFlagsKhr Transform;
		internal float GlobalAlpha;
		internal DisplayPlaneAlphaFlagsKhr AlphaMode;
		internal IntPtr ImageExtent;
	}

	internal struct DisplayPresentInfoKhr
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal IntPtr SrcRect;
		internal IntPtr DstRect;
		internal Bool32 Persistent;
	}

	internal struct SurfaceCapabilitiesKhr
	{
		internal UInt32 MinImageCount;
		internal UInt32 MaxImageCount;
		internal IntPtr CurrentExtent;
		internal IntPtr MinImageExtent;
		internal IntPtr MaxImageExtent;
		internal UInt32 MaxImageArrayLayers;
		internal SurfaceTransformFlagsKhr SupportedTransforms;
		internal SurfaceTransformFlagsKhr CurrentTransform;
		internal CompositeAlphaFlagsKhr SupportedCompositeAlpha;
		internal UInt32 SupportedUsageFlags;
	}

	internal struct SurfaceFormatKhr
	{
		internal Format Format;
		internal ColorSpaceKhr ColorSpace;
	}

	internal struct SwapchainCreateInfoKhr
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal IntPtr Surface;
		internal UInt32 MinImageCount;
		internal Format ImageFormat;
		internal ColorSpaceKhr ImageColorSpace;
		internal IntPtr ImageExtent;
		internal UInt32 ImageArrayLayers;
		internal UInt32 ImageUsage;
		internal SharingMode ImageSharingMode;
		internal UInt32 QueueFamilyIndexCount;
		internal UInt32 QueueFamilyIndices;
		internal SurfaceTransformFlagsKhr PreTransform;
		internal CompositeAlphaFlagsKhr CompositeAlpha;
		internal PresentModeKhr PresentMode;
		internal Bool32 Clipped;
		internal IntPtr OldSwapchain;
	}

	internal struct PresentInfoKhr
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 WaitSemaphoreCount;
		internal IntPtr WaitSemaphores;
		internal UInt32 SwapchainCount;
		internal IntPtr Swapchains;
		internal UInt32 ImageIndices;
		internal Result Results;
	}

	internal struct DebugReportCallbackCreateInfoExt
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal DebugReportFlagsExt Flags;
		internal IntPtr PfnCallback;
		internal IntPtr UserData;
	}
}
