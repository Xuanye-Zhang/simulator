using UnityEngine.Rendering;

namespace UnityEngine.Rendering.HighDefinition
{
    internal enum HDProfileId
    {
        PushGlobalParameters,
        CopyDepthBuffer,
        CopyDepthInTargetTexture,
        CoarseStencilGeneration,
        HTileForSSS,
        RenderSSAO,
        ResolveStencilBuffer,
        AmbientOcclusion,
        HorizonSSAO,
        DenoiseSSAO,
        UpSampleSSAO,
        ScreenSpaceShadows,
        ScreenSpaceShadowsDebug,
        BuildLightList,
        GenerateLightAABBs,
        ContactShadows,
        BlitToFinalRTDevBuildOnly,
        Distortion,
        AccumulateDistortion,
        ApplyDistortion,
        DepthPrepass,
        TransparentDepthPrepass,
        GBuffer,
        GBufferDebug,
        DBufferRender,
        DBufferPrepareDrawData,
        DBufferNormal,
        DisplayDebugDecalsAtlas,
        DisplayDebugViewMaterial,
        DebugViewMaterialGBuffer,
        SubsurfaceScattering,
        SsrTracing,
        SsrReprojection,
        SsrAccumulate,
        PrepareForTransparentSsr,

        // SSGI
        SSGIPass,
        SSGITrace,
        SSGIDenoise,
        SSGIUpscale,
        SSGIConvert,

        ForwardEmissive,
        ForwardOpaque,
        ForwardOpaqueDebug,
        ForwardTransparent,
        ForwardTransparentDebug,
        ForwardPreRefraction,
        ForwardPreRefractionDebug,
        ForwardTransparentDepthPrepass,
        RenderForwardError,
        TransparentDepthPostpass,
        ObjectsMotionVector,
        CameraMotionVectors,
        ColorPyramid,
        DepthPyramid,
        PostProcessing,
        AfterPostProcessing,
        RenderFullScreenDebug,
        RenderDebug,
        DisplayLightVolume,
        ClearBuffers,
        ClearDepthStencil,
        ClearStencil,
        ClearSssLightingBuffer,
        ClearSSSFilteringTarget,
        ClearAndCopyStencilTexture,
        ClearHDRTarget,
        ClearDecalBuffer,
        ClearGBuffer,
        ClearSsrBuffers,
        HDRenderPipelineRenderCamera,
        HDRenderPipelineRenderAOV,
        HDRenderPipelineAllRenderRequest,
        CullResultsCull,
        CustomPassCullResultsCull,
        UpdateStencilCopyForSSRExclusion,
        GizmosPrePostprocess,
        Gizmos,
        DisplayCookieAtlas,
        RenderWireFrame,
        PushToColorPicker,
        ResolveMSAAColor,
        ResolveMSAAMotionVector,
        ResolveMSAADepth,
        ConvolveReflectionProbe,
        ConvolvePlanarReflectionProbe,
        PreIntegradeWardCookTorrance,
        FilterCubemapCharlie,
        FilterCubemapGGX,
        DisplayPointLightCookieArray,
        DisplayPlanarReflectionProbeAtlas,
        BlitTextureInPotAtlas,
        AreaLightCookieConvolution,

        UpdateSkyEnvironmentConvolution,
        RenderSkyToCubemap,
        UpdateSkyEnvironment,
        UpdateSkyAmbientProbe,
        PreRenderSky,
        RenderSky,
        OpaqueAtmosphericScattering,
        InScatteredRadiancePrecomputation,

        VolumeVoxelization,
        VolumetricLighting,
        VolumetricLightingFiltering,
        PrepareVisibleDensityVolumeList,

        // RT Cluster
        RaytracingBuildCluster,
        RaytracingCullLights,
        RaytracingDebugCluster,
        // RTR
        RaytracingReflectionDirectionGeneration,
        RaytracingReflectionEvaluation,
        RaytracingReflectionUpscaleGeneration,
        RaytracingFilterReflection,
        // RTAO
        RaytracingAmbientOcclusion,
        RaytracingFilterAmbientOcclusion,
        RaytracingComposeAmbientOcclusion,
        // RT Shadows
        RaytracingDirectionalLightShadow,
        RaytracingLightShadow,
        RaytracingSphereLightShadow,
        RaytracingAreaLightShadow,
        // RTGI
        RaytracingIndirectDiffuseDirectionGeneration,
        RaytracingIndirectDiffuseEvaluation,
        RaytracingIndirectDiffuseUpscale,
        RaytracingFilterIndirectDiffuse,
        RaytracingIndirectDiffuseAdjustWeight,

        // RTSSS
        RaytracingSSS,
        RaytracingSSSTrace,
        RaytracingSSSCompose,
        // RTShadow
        RaytracingWriteShadow,
        // Other ray tracing
        RaytracingDebugOverlay,
        RayTracingRecursiveRendering,
        RayTracingPrepass,
        // RT Deferred Lighting
        RaytracingDeferredLighting,
        // Denoisers
        TemporalFilter,
        DiffuseFilter,

        // Profile sampler for prepare light for GPU
        PrepareLightsForGPU,

        // Profile sampler for shadow
        RenderShadowMaps,
        RenderMomentShadowMaps,
        RenderPunctualShadowMaps,
        RenderCachedPunctualShadowMaps,
        RenderDirectionalShadowMaps,
        RenderAreaShadowMaps,
        RenderCachedAreaShadowMaps,
        RenderEVSMShadowMaps,
        RenderEVSMShadowMapsBlur,
        RenderEVSMShadowMapsCopyToAtlas,
        BlitPunctualMixedCachedShadowMaps,
        BlitAreaMixedCachedShadowMaps,

        // Profile sampler for tile pass
        LightLoopPushGlobalParameters,
        TileClusterLightingDebug,
        DisplayShadows,

        RenderDeferredLightingCompute,
        RenderDeferredLightingComputeAsPixel,
        RenderDeferredLightingSinglePass,
        RenderDeferredLightingSinglePassMRT,

        // Misc
        VolumeUpdate,
        CustomPassVolumeUpdate,

        // XR
        XROcclusionMesh,
        XRMirrorView,
        XRCustomMirrorView,
        XRDepthCopy,

        // Low res transparency
        DownsampleDepth,
        LowResTransparent,
        UpsampleLowResTransparent,

        // Post-processing
        AlphaCopy,
        StopNaNs,
        FixedExposure,
        DynamicExposure,
        ApplyExposure,
        TemporalAntialiasing,
        DepthOfField,
        DepthOfFieldKernel,
        DepthOfFieldCoC,
        DepthOfFieldPrefilter,
        DepthOfFieldPyramid,
        DepthOfFieldDilate,
        DepthOfFieldTileMax,
        DepthOfFieldGatherFar,
        DepthOfFieldGatherNear,
        DepthOfFieldPreCombine,
        DepthOfFieldCombine,
        MotionBlur,
        MotionBlurMotionVecPrep,
        MotionBlurTileMinMax,
        MotionBlurTileNeighbourhood,
        MotionBlurTileScattering,
        MotionBlurKernel,
        PaniniProjection,
        Bloom,
        ColorGradingLUTBuilder,
        UberPost,
        FXAA,
        SMAA,
        FinalPost,
        FinalImageHistogram,
        CustomPostProcessBeforeTAA,
        CustomPostProcessBeforePP,
        CustomPostProcessAfterPP,
        CustomPostProcessAfterOpaqueAndSky,
        ContrastAdaptiveSharpen,
        PrepareProbeVolumeList,
        ProbeVolumeDebug,
        BuildGPULightListProbeVolumes,
        PushProbeVolumeLightListGlobalParameters,

        AOVExecute,
        // Enum AOVBuffers
        AOVOutput,
        AOVColor,
        AOVDepthStencil,
        AOVNormals,
        AOVMotionVectors,

#if ENABLE_VIRTUALTEXTURES
        VTFeedbackClear,
        VTFeedbackDownsample,
#endif
    }
}
