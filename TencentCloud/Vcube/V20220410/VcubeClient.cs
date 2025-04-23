/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Vcube.V20220410
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vcube.V20220410.Models;

   public class VcubeClient : AbstractClient{

       private const string endpoint = "vcube.tencentcloudapi.com";
       private const string version = "2022-04-10";
       private const string sdkVersion = "SDK_NET_3.0.1226";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VcubeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public VcubeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建活动license
        /// </summary>
        /// <param name="req"><see cref="CreateActivityLicenseRequest"/></param>
        /// <returns><see cref="CreateActivityLicenseResponse"/></returns>
        public Task<CreateActivityLicenseResponse> CreateActivityLicense(CreateActivityLicenseRequest req)
        {
            return InternalRequestAsync<CreateActivityLicenseResponse>(req, "CreateActivityLicense");
        }

        /// <summary>
        /// 创建活动license
        /// </summary>
        /// <param name="req"><see cref="CreateActivityLicenseRequest"/></param>
        /// <returns><see cref="CreateActivityLicenseResponse"/></returns>
        public CreateActivityLicenseResponse CreateActivityLicenseSync(CreateActivityLicenseRequest req)
        {
            return InternalRequestAsync<CreateActivityLicenseResponse>(req, "CreateActivityLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建应用并绑定license或者XMagic
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationAndBindLicenseRequest"/></param>
        /// <returns><see cref="CreateApplicationAndBindLicenseResponse"/></returns>
        public Task<CreateApplicationAndBindLicenseResponse> CreateApplicationAndBindLicense(CreateApplicationAndBindLicenseRequest req)
        {
            return InternalRequestAsync<CreateApplicationAndBindLicenseResponse>(req, "CreateApplicationAndBindLicense");
        }

        /// <summary>
        /// 创建应用并绑定license或者XMagic
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationAndBindLicenseRequest"/></param>
        /// <returns><see cref="CreateApplicationAndBindLicenseResponse"/></returns>
        public CreateApplicationAndBindLicenseResponse CreateApplicationAndBindLicenseSync(CreateApplicationAndBindLicenseRequest req)
        {
            return InternalRequestAsync<CreateApplicationAndBindLicenseResponse>(req, "CreateApplicationAndBindLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建应用和视频播放license 目前只有国际站可以用
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationAndVideoRequest"/></param>
        /// <returns><see cref="CreateApplicationAndVideoResponse"/></returns>
        public Task<CreateApplicationAndVideoResponse> CreateApplicationAndVideo(CreateApplicationAndVideoRequest req)
        {
            return InternalRequestAsync<CreateApplicationAndVideoResponse>(req, "CreateApplicationAndVideo");
        }

        /// <summary>
        /// 创建应用和视频播放license 目前只有国际站可以用
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationAndVideoRequest"/></param>
        /// <returns><see cref="CreateApplicationAndVideoResponse"/></returns>
        public CreateApplicationAndVideoResponse CreateApplicationAndVideoSync(CreateApplicationAndVideoRequest req)
        {
            return InternalRequestAsync<CreateApplicationAndVideoResponse>(req, "CreateApplicationAndVideo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 web 播放器基础版
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationAndWebPlayerLicenseRequest"/></param>
        /// <returns><see cref="CreateApplicationAndWebPlayerLicenseResponse"/></returns>
        public Task<CreateApplicationAndWebPlayerLicenseResponse> CreateApplicationAndWebPlayerLicense(CreateApplicationAndWebPlayerLicenseRequest req)
        {
            return InternalRequestAsync<CreateApplicationAndWebPlayerLicenseResponse>(req, "CreateApplicationAndWebPlayerLicense");
        }

        /// <summary>
        /// 创建 web 播放器基础版
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationAndWebPlayerLicenseRequest"/></param>
        /// <returns><see cref="CreateApplicationAndWebPlayerLicenseResponse"/></returns>
        public CreateApplicationAndWebPlayerLicenseResponse CreateApplicationAndWebPlayerLicenseSync(CreateApplicationAndWebPlayerLicenseRequest req)
        {
            return InternalRequestAsync<CreateApplicationAndWebPlayerLicenseResponse>(req, "CreateApplicationAndWebPlayerLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定license
        /// </summary>
        /// <param name="req"><see cref="CreateLicenseRequest"/></param>
        /// <returns><see cref="CreateLicenseResponse"/></returns>
        public Task<CreateLicenseResponse> CreateLicense(CreateLicenseRequest req)
        {
            return InternalRequestAsync<CreateLicenseResponse>(req, "CreateLicense");
        }

        /// <summary>
        /// 绑定license
        /// </summary>
        /// <param name="req"><see cref="CreateLicenseRequest"/></param>
        /// <returns><see cref="CreateLicenseResponse"/></returns>
        public CreateLicenseResponse CreateLicenseSync(CreateLicenseRequest req)
        {
            return InternalRequestAsync<CreateLicenseResponse>(req, "CreateLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 申请开通测试版腾讯特效
        /// </summary>
        /// <param name="req"><see cref="CreateTestXMagicRequest"/></param>
        /// <returns><see cref="CreateTestXMagicResponse"/></returns>
        public Task<CreateTestXMagicResponse> CreateTestXMagic(CreateTestXMagicRequest req)
        {
            return InternalRequestAsync<CreateTestXMagicResponse>(req, "CreateTestXMagic");
        }

        /// <summary>
        /// 申请开通测试版腾讯特效
        /// </summary>
        /// <param name="req"><see cref="CreateTestXMagicRequest"/></param>
        /// <returns><see cref="CreateTestXMagicResponse"/></returns>
        public CreateTestXMagicResponse CreateTestXMagicSync(CreateTestXMagicRequest req)
        {
            return InternalRequestAsync<CreateTestXMagicResponse>(req, "CreateTestXMagic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建测试应用并开通测试 license
        /// </summary>
        /// <param name="req"><see cref="CreateTrialApplicationAndLicenseRequest"/></param>
        /// <returns><see cref="CreateTrialApplicationAndLicenseResponse"/></returns>
        public Task<CreateTrialApplicationAndLicenseResponse> CreateTrialApplicationAndLicense(CreateTrialApplicationAndLicenseRequest req)
        {
            return InternalRequestAsync<CreateTrialApplicationAndLicenseResponse>(req, "CreateTrialApplicationAndLicense");
        }

        /// <summary>
        /// 创建测试应用并开通测试 license
        /// </summary>
        /// <param name="req"><see cref="CreateTrialApplicationAndLicenseRequest"/></param>
        /// <returns><see cref="CreateTrialApplicationAndLicenseResponse"/></returns>
        public CreateTrialApplicationAndLicenseResponse CreateTrialApplicationAndLicenseSync(CreateTrialApplicationAndLicenseRequest req)
        {
            return InternalRequestAsync<CreateTrialApplicationAndLicenseResponse>(req, "CreateTrialApplicationAndLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开通测试license
        /// </summary>
        /// <param name="req"><see cref="CreateTrialLicenseRequest"/></param>
        /// <returns><see cref="CreateTrialLicenseResponse"/></returns>
        public Task<CreateTrialLicenseResponse> CreateTrialLicense(CreateTrialLicenseRequest req)
        {
            return InternalRequestAsync<CreateTrialLicenseResponse>(req, "CreateTrialLicense");
        }

        /// <summary>
        /// 开通测试license
        /// </summary>
        /// <param name="req"><see cref="CreateTrialLicenseRequest"/></param>
        /// <returns><see cref="CreateTrialLicenseResponse"/></returns>
        public CreateTrialLicenseResponse CreateTrialLicenseSync(CreateTrialLicenseRequest req)
        {
            return InternalRequestAsync<CreateTrialLicenseResponse>(req, "CreateTrialLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// x08开通正式版优图美视功能，针对已经有Application的情况
        /// </summary>
        /// <param name="req"><see cref="CreateXMagicRequest"/></param>
        /// <returns><see cref="CreateXMagicResponse"/></returns>
        public Task<CreateXMagicResponse> CreateXMagic(CreateXMagicRequest req)
        {
            return InternalRequestAsync<CreateXMagicResponse>(req, "CreateXMagic");
        }

        /// <summary>
        /// x08开通正式版优图美视功能，针对已经有Application的情况
        /// </summary>
        /// <param name="req"><see cref="CreateXMagicRequest"/></param>
        /// <returns><see cref="CreateXMagicResponse"/></returns>
        public CreateXMagicResponse CreateXMagicSync(CreateXMagicRequest req)
        {
            return InternalRequestAsync<CreateXMagicResponse>(req, "CreateXMagic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询功能列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFeatureListRequest"/></param>
        /// <returns><see cref="DescribeFeatureListResponse"/></returns>
        public Task<DescribeFeatureListResponse> DescribeFeatureList(DescribeFeatureListRequest req)
        {
            return InternalRequestAsync<DescribeFeatureListResponse>(req, "DescribeFeatureList");
        }

        /// <summary>
        /// 查询功能列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFeatureListRequest"/></param>
        /// <returns><see cref="DescribeFeatureListResponse"/></returns>
        public DescribeFeatureListResponse DescribeFeatureListSync(DescribeFeatureListRequest req)
        {
            return InternalRequestAsync<DescribeFeatureListResponse>(req, "DescribeFeatureList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 总览页查询临期License列表，和统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseListRequest"/></param>
        /// <returns><see cref="DescribeLicenseListResponse"/></returns>
        public Task<DescribeLicenseListResponse> DescribeLicenseList(DescribeLicenseListRequest req)
        {
            return InternalRequestAsync<DescribeLicenseListResponse>(req, "DescribeLicenseList");
        }

        /// <summary>
        /// 总览页查询临期License列表，和统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseListRequest"/></param>
        /// <returns><see cref="DescribeLicenseListResponse"/></returns>
        public DescribeLicenseListResponse DescribeLicenseListSync(DescribeLicenseListRequest req)
        {
            return InternalRequestAsync<DescribeLicenseListResponse>(req, "DescribeLicenseList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询产品动态
        /// </summary>
        /// <param name="req"><see cref="DescribeNewsRequest"/></param>
        /// <returns><see cref="DescribeNewsResponse"/></returns>
        public Task<DescribeNewsResponse> DescribeNews(DescribeNewsRequest req)
        {
            return InternalRequestAsync<DescribeNewsResponse>(req, "DescribeNews");
        }

        /// <summary>
        /// 查询产品动态
        /// </summary>
        /// <param name="req"><see cref="DescribeNewsRequest"/></param>
        /// <returns><see cref="DescribeNewsResponse"/></returns>
        public DescribeNewsResponse DescribeNewsSync(DescribeNewsRequest req)
        {
            return InternalRequestAsync<DescribeNewsResponse>(req, "DescribeNews")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取临时秘钥，用于图片，特效包上传
        /// </summary>
        /// <param name="req"><see cref="DescribeSTSRequest"/></param>
        /// <returns><see cref="DescribeSTSResponse"/></returns>
        public Task<DescribeSTSResponse> DescribeSTS(DescribeSTSRequest req)
        {
            return InternalRequestAsync<DescribeSTSResponse>(req, "DescribeSTS");
        }

        /// <summary>
        /// 获取临时秘钥，用于图片，特效包上传
        /// </summary>
        /// <param name="req"><see cref="DescribeSTSRequest"/></param>
        /// <returns><see cref="DescribeSTSResponse"/></returns>
        public DescribeSTSResponse DescribeSTSSync(DescribeSTSRequest req)
        {
            return InternalRequestAsync<DescribeSTSResponse>(req, "DescribeSTS")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询测试应用可以开通的功能
        /// </summary>
        /// <param name="req"><see cref="DescribeTrialFeatureRequest"/></param>
        /// <returns><see cref="DescribeTrialFeatureResponse"/></returns>
        public Task<DescribeTrialFeatureResponse> DescribeTrialFeature(DescribeTrialFeatureRequest req)
        {
            return InternalRequestAsync<DescribeTrialFeatureResponse>(req, "DescribeTrialFeature");
        }

        /// <summary>
        /// 查询测试应用可以开通的功能
        /// </summary>
        /// <param name="req"><see cref="DescribeTrialFeatureRequest"/></param>
        /// <returns><see cref="DescribeTrialFeatureResponse"/></returns>
        public DescribeTrialFeatureResponse DescribeTrialFeatureSync(DescribeTrialFeatureRequest req)
        {
            return InternalRequestAsync<DescribeTrialFeatureResponse>(req, "DescribeTrialFeature")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户个性配置
        /// </summary>
        /// <param name="req"><see cref="DescribeUserConfigRequest"/></param>
        /// <returns><see cref="DescribeUserConfigResponse"/></returns>
        public Task<DescribeUserConfigResponse> DescribeUserConfig(DescribeUserConfigRequest req)
        {
            return InternalRequestAsync<DescribeUserConfigResponse>(req, "DescribeUserConfig");
        }

        /// <summary>
        /// 查询用户个性配置
        /// </summary>
        /// <param name="req"><see cref="DescribeUserConfigRequest"/></param>
        /// <returns><see cref="DescribeUserConfigResponse"/></returns>
        public DescribeUserConfigResponse DescribeUserConfigSync(DescribeUserConfigRequest req)
        {
            return InternalRequestAsync<DescribeUserConfigResponse>(req, "DescribeUserConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户license， 按照应用分类
        /// </summary>
        /// <param name="req"><see cref="DescribeVcubeApplicationAndLicenseRequest"/></param>
        /// <returns><see cref="DescribeVcubeApplicationAndLicenseResponse"/></returns>
        public Task<DescribeVcubeApplicationAndLicenseResponse> DescribeVcubeApplicationAndLicense(DescribeVcubeApplicationAndLicenseRequest req)
        {
            return InternalRequestAsync<DescribeVcubeApplicationAndLicenseResponse>(req, "DescribeVcubeApplicationAndLicense");
        }

        /// <summary>
        /// 查询用户license， 按照应用分类
        /// </summary>
        /// <param name="req"><see cref="DescribeVcubeApplicationAndLicenseRequest"/></param>
        /// <returns><see cref="DescribeVcubeApplicationAndLicenseResponse"/></returns>
        public DescribeVcubeApplicationAndLicenseResponse DescribeVcubeApplicationAndLicenseSync(DescribeVcubeApplicationAndLicenseRequest req)
        {
            return InternalRequestAsync<DescribeVcubeApplicationAndLicenseResponse>(req, "DescribeVcubeApplicationAndLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户点播直播等license， 按照应用分类,国际站专用
        /// </summary>
        /// <param name="req"><see cref="DescribeVcubeApplicationAndPlayListRequest"/></param>
        /// <returns><see cref="DescribeVcubeApplicationAndPlayListResponse"/></returns>
        public Task<DescribeVcubeApplicationAndPlayListResponse> DescribeVcubeApplicationAndPlayList(DescribeVcubeApplicationAndPlayListRequest req)
        {
            return InternalRequestAsync<DescribeVcubeApplicationAndPlayListResponse>(req, "DescribeVcubeApplicationAndPlayList");
        }

        /// <summary>
        /// 查询用户点播直播等license， 按照应用分类,国际站专用
        /// </summary>
        /// <param name="req"><see cref="DescribeVcubeApplicationAndPlayListRequest"/></param>
        /// <returns><see cref="DescribeVcubeApplicationAndPlayListResponse"/></returns>
        public DescribeVcubeApplicationAndPlayListResponse DescribeVcubeApplicationAndPlayListSync(DescribeVcubeApplicationAndPlayListRequest req)
        {
            return InternalRequestAsync<DescribeVcubeApplicationAndPlayListResponse>(req, "DescribeVcubeApplicationAndPlayList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户优图license， 按照应用分类
        /// </summary>
        /// <param name="req"><see cref="DescribeVcubeApplicationAndXMagicListRequest"/></param>
        /// <returns><see cref="DescribeVcubeApplicationAndXMagicListResponse"/></returns>
        public Task<DescribeVcubeApplicationAndXMagicListResponse> DescribeVcubeApplicationAndXMagicList(DescribeVcubeApplicationAndXMagicListRequest req)
        {
            return InternalRequestAsync<DescribeVcubeApplicationAndXMagicListResponse>(req, "DescribeVcubeApplicationAndXMagicList");
        }

        /// <summary>
        /// 查询用户优图license， 按照应用分类
        /// </summary>
        /// <param name="req"><see cref="DescribeVcubeApplicationAndXMagicListRequest"/></param>
        /// <returns><see cref="DescribeVcubeApplicationAndXMagicListResponse"/></returns>
        public DescribeVcubeApplicationAndXMagicListResponse DescribeVcubeApplicationAndXMagicListSync(DescribeVcubeApplicationAndXMagicListRequest req)
        {
            return InternalRequestAsync<DescribeVcubeApplicationAndXMagicListResponse>(req, "DescribeVcubeApplicationAndXMagicList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询视立方 license 资源，所有的资源包
        /// </summary>
        /// <param name="req"><see cref="DescribeVcubeResourcesRequest"/></param>
        /// <returns><see cref="DescribeVcubeResourcesResponse"/></returns>
        public Task<DescribeVcubeResourcesResponse> DescribeVcubeResources(DescribeVcubeResourcesRequest req)
        {
            return InternalRequestAsync<DescribeVcubeResourcesResponse>(req, "DescribeVcubeResources");
        }

        /// <summary>
        /// 查询视立方 license 资源，所有的资源包
        /// </summary>
        /// <param name="req"><see cref="DescribeVcubeResourcesRequest"/></param>
        /// <returns><see cref="DescribeVcubeResourcesResponse"/></returns>
        public DescribeVcubeResourcesResponse DescribeVcubeResourcesSync(DescribeVcubeResourcesRequest req)
        {
            return InternalRequestAsync<DescribeVcubeResourcesResponse>(req, "DescribeVcubeResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询视立方 license 资源，包括资源包赠送和直接购买的资源
        /// </summary>
        /// <param name="req"><see cref="DescribeVcubeResourcesListRequest"/></param>
        /// <returns><see cref="DescribeVcubeResourcesListResponse"/></returns>
        public Task<DescribeVcubeResourcesListResponse> DescribeVcubeResourcesList(DescribeVcubeResourcesListRequest req)
        {
            return InternalRequestAsync<DescribeVcubeResourcesListResponse>(req, "DescribeVcubeResourcesList");
        }

        /// <summary>
        /// 查询视立方 license 资源，包括资源包赠送和直接购买的资源
        /// </summary>
        /// <param name="req"><see cref="DescribeVcubeResourcesListRequest"/></param>
        /// <returns><see cref="DescribeVcubeResourcesListResponse"/></returns>
        public DescribeVcubeResourcesListResponse DescribeVcubeResourcesListSync(DescribeVcubeResourcesListRequest req)
        {
            return InternalRequestAsync<DescribeVcubeResourcesListResponse>(req, "DescribeVcubeResourcesList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用途美视资源包用于开通正式优图美视
        /// </summary>
        /// <param name="req"><see cref="DescribeXMagicResourceRequest"/></param>
        /// <returns><see cref="DescribeXMagicResourceResponse"/></returns>
        public Task<DescribeXMagicResourceResponse> DescribeXMagicResource(DescribeXMagicResourceRequest req)
        {
            return InternalRequestAsync<DescribeXMagicResourceResponse>(req, "DescribeXMagicResource");
        }

        /// <summary>
        /// 用途美视资源包用于开通正式优图美视
        /// </summary>
        /// <param name="req"><see cref="DescribeXMagicResourceRequest"/></param>
        /// <returns><see cref="DescribeXMagicResourceResponse"/></returns>
        public DescribeXMagicResourceResponse DescribeXMagicResourceSync(DescribeXMagicResourceRequest req)
        {
            return InternalRequestAsync<DescribeXMagicResourceResponse>(req, "DescribeXMagicResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于优图美视资源列表展示
        /// </summary>
        /// <param name="req"><see cref="DescribeXMagicResourceListRequest"/></param>
        /// <returns><see cref="DescribeXMagicResourceListResponse"/></returns>
        public Task<DescribeXMagicResourceListResponse> DescribeXMagicResourceList(DescribeXMagicResourceListRequest req)
        {
            return InternalRequestAsync<DescribeXMagicResourceListResponse>(req, "DescribeXMagicResourceList");
        }

        /// <summary>
        /// 用于优图美视资源列表展示
        /// </summary>
        /// <param name="req"><see cref="DescribeXMagicResourceListRequest"/></param>
        /// <returns><see cref="DescribeXMagicResourceListResponse"/></returns>
        public DescribeXMagicResourceListResponse DescribeXMagicResourceListSync(DescribeXMagicResourceListRequest req)
        {
            return InternalRequestAsync<DescribeXMagicResourceListResponse>(req, "DescribeXMagicResourceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更改测试包名信息
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public Task<ModifyApplicationResponse> ModifyApplication(ModifyApplicationRequest req)
        {
            return InternalRequestAsync<ModifyApplicationResponse>(req, "ModifyApplication");
        }

        /// <summary>
        /// 更改测试包名信息
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public ModifyApplicationResponse ModifyApplicationSync(ModifyApplicationRequest req)
        {
            return InternalRequestAsync<ModifyApplicationResponse>(req, "ModifyApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改正式应用的包名称
        /// </summary>
        /// <param name="req"><see cref="ModifyFormalApplicationRequest"/></param>
        /// <returns><see cref="ModifyFormalApplicationResponse"/></returns>
        public Task<ModifyFormalApplicationResponse> ModifyFormalApplication(ModifyFormalApplicationRequest req)
        {
            return InternalRequestAsync<ModifyFormalApplicationResponse>(req, "ModifyFormalApplication");
        }

        /// <summary>
        /// 修改正式应用的包名称
        /// </summary>
        /// <param name="req"><see cref="ModifyFormalApplicationRequest"/></param>
        /// <returns><see cref="ModifyFormalApplicationResponse"/></returns>
        public ModifyFormalApplicationResponse ModifyFormalApplicationSync(ModifyFormalApplicationRequest req)
        {
            return InternalRequestAsync<ModifyFormalApplicationResponse>(req, "ModifyFormalApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 正式license 升降配，点播精简版、基础版
        /// </summary>
        /// <param name="req"><see cref="ModifyLicenseRequest"/></param>
        /// <returns><see cref="ModifyLicenseResponse"/></returns>
        public Task<ModifyLicenseResponse> ModifyLicense(ModifyLicenseRequest req)
        {
            return InternalRequestAsync<ModifyLicenseResponse>(req, "ModifyLicense");
        }

        /// <summary>
        /// 正式license 升降配，点播精简版、基础版
        /// </summary>
        /// <param name="req"><see cref="ModifyLicenseRequest"/></param>
        /// <returns><see cref="ModifyLicenseResponse"/></returns>
        public ModifyLicenseResponse ModifyLicenseSync(ModifyLicenseRequest req)
        {
            return InternalRequestAsync<ModifyLicenseResponse>(req, "ModifyLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改内置应用包名
        /// </summary>
        /// <param name="req"><see cref="ModifyPresetApplicationRequest"/></param>
        /// <returns><see cref="ModifyPresetApplicationResponse"/></returns>
        public Task<ModifyPresetApplicationResponse> ModifyPresetApplication(ModifyPresetApplicationRequest req)
        {
            return InternalRequestAsync<ModifyPresetApplicationResponse>(req, "ModifyPresetApplication");
        }

        /// <summary>
        /// 修改内置应用包名
        /// </summary>
        /// <param name="req"><see cref="ModifyPresetApplicationRequest"/></param>
        /// <returns><see cref="ModifyPresetApplicationResponse"/></returns>
        public ModifyPresetApplicationResponse ModifyPresetApplicationSync(ModifyPresetApplicationRequest req)
        {
            return InternalRequestAsync<ModifyPresetApplicationResponse>(req, "ModifyPresetApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 续期测试license
        /// </summary>
        /// <param name="req"><see cref="ModifyTrialLicenseRequest"/></param>
        /// <returns><see cref="ModifyTrialLicenseResponse"/></returns>
        public Task<ModifyTrialLicenseResponse> ModifyTrialLicense(ModifyTrialLicenseRequest req)
        {
            return InternalRequestAsync<ModifyTrialLicenseResponse>(req, "ModifyTrialLicense");
        }

        /// <summary>
        /// 续期测试license
        /// </summary>
        /// <param name="req"><see cref="ModifyTrialLicenseRequest"/></param>
        /// <returns><see cref="ModifyTrialLicenseResponse"/></returns>
        public ModifyTrialLicenseResponse ModifyTrialLicenseSync(ModifyTrialLicenseRequest req)
        {
            return InternalRequestAsync<ModifyTrialLicenseResponse>(req, "ModifyTrialLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用一个腾讯特效资源，更新现在的腾讯特效license，license功能和到期时间会以新的资源为准，老资源会被替换下来
        /// </summary>
        /// <param name="req"><see cref="ModifyXMagicRequest"/></param>
        /// <returns><see cref="ModifyXMagicResponse"/></returns>
        public Task<ModifyXMagicResponse> ModifyXMagic(ModifyXMagicRequest req)
        {
            return InternalRequestAsync<ModifyXMagicResponse>(req, "ModifyXMagic");
        }

        /// <summary>
        /// 使用一个腾讯特效资源，更新现在的腾讯特效license，license功能和到期时间会以新的资源为准，老资源会被替换下来
        /// </summary>
        /// <param name="req"><see cref="ModifyXMagicRequest"/></param>
        /// <returns><see cref="ModifyXMagicResponse"/></returns>
        public ModifyXMagicResponse ModifyXMagicSync(ModifyXMagicRequest req)
        {
            return InternalRequestAsync<ModifyXMagicResponse>(req, "ModifyXMagic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 正式license 续期与变更有效期
        /// </summary>
        /// <param name="req"><see cref="RenewLicenseRequest"/></param>
        /// <returns><see cref="RenewLicenseResponse"/></returns>
        public Task<RenewLicenseResponse> RenewLicense(RenewLicenseRequest req)
        {
            return InternalRequestAsync<RenewLicenseResponse>(req, "RenewLicense");
        }

        /// <summary>
        /// 正式license 续期与变更有效期
        /// </summary>
        /// <param name="req"><see cref="RenewLicenseRequest"/></param>
        /// <returns><see cref="RenewLicenseResponse"/></returns>
        public RenewLicenseResponse RenewLicenseSync(RenewLicenseRequest req)
        {
            return InternalRequestAsync<RenewLicenseResponse>(req, "RenewLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 续期测试版优图美视
        /// </summary>
        /// <param name="req"><see cref="RenewTestXMagicRequest"/></param>
        /// <returns><see cref="RenewTestXMagicResponse"/></returns>
        public Task<RenewTestXMagicResponse> RenewTestXMagic(RenewTestXMagicRequest req)
        {
            return InternalRequestAsync<RenewTestXMagicResponse>(req, "RenewTestXMagic");
        }

        /// <summary>
        /// 续期测试版优图美视
        /// </summary>
        /// <param name="req"><see cref="RenewTestXMagicRequest"/></param>
        /// <returns><see cref="RenewTestXMagicResponse"/></returns>
        public RenewTestXMagicResponse RenewTestXMagicSync(RenewTestXMagicRequest req)
        {
            return InternalRequestAsync<RenewTestXMagicResponse>(req, "RenewTestXMagic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 续期国际站视频播放功能和中国站web基础版
        /// </summary>
        /// <param name="req"><see cref="RenewVideoRequest"/></param>
        /// <returns><see cref="RenewVideoResponse"/></returns>
        public Task<RenewVideoResponse> RenewVideo(RenewVideoRequest req)
        {
            return InternalRequestAsync<RenewVideoResponse>(req, "RenewVideo");
        }

        /// <summary>
        /// 续期国际站视频播放功能和中国站web基础版
        /// </summary>
        /// <param name="req"><see cref="RenewVideoRequest"/></param>
        /// <returns><see cref="RenewVideoResponse"/></returns>
        public RenewVideoResponse RenewVideoSync(RenewVideoRequest req)
        {
            return InternalRequestAsync<RenewVideoResponse>(req, "RenewVideo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将测试xmagic升级到正式版
        /// </summary>
        /// <param name="req"><see cref="UpdateTestXMagicRequest"/></param>
        /// <returns><see cref="UpdateTestXMagicResponse"/></returns>
        public Task<UpdateTestXMagicResponse> UpdateTestXMagic(UpdateTestXMagicRequest req)
        {
            return InternalRequestAsync<UpdateTestXMagicResponse>(req, "UpdateTestXMagic");
        }

        /// <summary>
        /// 将测试xmagic升级到正式版
        /// </summary>
        /// <param name="req"><see cref="UpdateTestXMagicRequest"/></param>
        /// <returns><see cref="UpdateTestXMagicResponse"/></returns>
        public UpdateTestXMagicResponse UpdateTestXMagicSync(UpdateTestXMagicRequest req)
        {
            return InternalRequestAsync<UpdateTestXMagicResponse>(req, "UpdateTestXMagic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 测试 license 升级为正式 license
        /// </summary>
        /// <param name="req"><see cref="UpdateTrialLicenseRequest"/></param>
        /// <returns><see cref="UpdateTrialLicenseResponse"/></returns>
        public Task<UpdateTrialLicenseResponse> UpdateTrialLicense(UpdateTrialLicenseRequest req)
        {
            return InternalRequestAsync<UpdateTrialLicenseResponse>(req, "UpdateTrialLicense");
        }

        /// <summary>
        /// 测试 license 升级为正式 license
        /// </summary>
        /// <param name="req"><see cref="UpdateTrialLicenseRequest"/></param>
        /// <returns><see cref="UpdateTrialLicenseResponse"/></returns>
        public UpdateTrialLicenseResponse UpdateTrialLicenseSync(UpdateTrialLicenseRequest req)
        {
            return InternalRequestAsync<UpdateTrialLicenseResponse>(req, "UpdateTrialLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新优图美视的申请信息 Status 为2，3的时候可用
        /// </summary>
        /// <param name="req"><see cref="UpdateXMagicRequest"/></param>
        /// <returns><see cref="UpdateXMagicResponse"/></returns>
        public Task<UpdateXMagicResponse> UpdateXMagic(UpdateXMagicRequest req)
        {
            return InternalRequestAsync<UpdateXMagicResponse>(req, "UpdateXMagic");
        }

        /// <summary>
        /// 更新优图美视的申请信息 Status 为2，3的时候可用
        /// </summary>
        /// <param name="req"><see cref="UpdateXMagicRequest"/></param>
        /// <returns><see cref="UpdateXMagicResponse"/></returns>
        public UpdateXMagicResponse UpdateXMagicSync(UpdateXMagicRequest req)
        {
            return InternalRequestAsync<UpdateXMagicResponse>(req, "UpdateXMagic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
