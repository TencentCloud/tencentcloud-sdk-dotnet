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

namespace TencentCloud.Ecm.V20190719
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ecm.V20190719.Models;

   public class EcmClient : AbstractClient{

       private const string endpoint = "ecm.tencentcloudapi.com";
       private const string version = "2019-07-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EcmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EcmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建模块
        /// </summary>
        /// <param name="req"><see cref="CreateModuleRequest"/></param>
        /// <returns><see cref="CreateModuleResponse"/></returns>
        public async Task<CreateModuleResponse> CreateModule(CreateModuleRequest req)
        {
             JsonResponseModel<CreateModuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建模块
        /// </summary>
        /// <param name="req"><see cref="CreateModuleRequest"/></param>
        /// <returns><see cref="CreateModuleResponse"/></returns>
        public CreateModuleResponse CreateModuleSync(CreateModuleRequest req)
        {
             JsonResponseModel<CreateModuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除镜像
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRequest"/></param>
        /// <returns><see cref="DeleteImageResponse"/></returns>
        public async Task<DeleteImageResponse> DeleteImage(DeleteImageRequest req)
        {
             JsonResponseModel<DeleteImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除镜像
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRequest"/></param>
        /// <returns><see cref="DeleteImageResponse"/></returns>
        public DeleteImageResponse DeleteImageSync(DeleteImageRequest req)
        {
             JsonResponseModel<DeleteImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除业务模块
        /// </summary>
        /// <param name="req"><see cref="DeleteModuleRequest"/></param>
        /// <returns><see cref="DeleteModuleResponse"/></returns>
        public async Task<DeleteModuleResponse> DeleteModule(DeleteModuleRequest req)
        {
             JsonResponseModel<DeleteModuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除业务模块
        /// </summary>
        /// <param name="req"><see cref="DeleteModuleRequest"/></param>
        /// <returns><see cref="DeleteModuleResponse"/></returns>
        public DeleteModuleResponse DeleteModuleSync(DeleteModuleRequest req)
        {
             JsonResponseModel<DeleteModuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取概览页统计的基本数据
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribeBaseOverviewResponse"/></returns>
        public async Task<DescribeBaseOverviewResponse> DescribeBaseOverview(DescribeBaseOverviewRequest req)
        {
             JsonResponseModel<DescribeBaseOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaseOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取概览页统计的基本数据
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribeBaseOverviewResponse"/></returns>
        public DescribeBaseOverviewResponse DescribeBaseOverviewSync(DescribeBaseOverviewRequest req)
        {
             JsonResponseModel<DescribeBaseOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaseOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取带宽硬盘等数据的限制
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public async Task<DescribeConfigResponse> DescribeConfig(DescribeConfigRequest req)
        {
             JsonResponseModel<DescribeConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取带宽硬盘等数据的限制
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public DescribeConfigResponse DescribeConfigSync(DescribeConfigRequest req)
        {
             JsonResponseModel<DescribeConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 展示镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public async Task<DescribeImageResponse> DescribeImage(DescribeImageRequest req)
        {
             JsonResponseModel<DescribeImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 展示镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public DescribeImageResponse DescribeImageSync(DescribeImageRequest req)
        {
             JsonResponseModel<DescribeImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取机型配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypeConfigRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypeConfigResponse"/></returns>
        public async Task<DescribeInstanceTypeConfigResponse> DescribeInstanceTypeConfig(DescribeInstanceTypeConfigRequest req)
        {
             JsonResponseModel<DescribeInstanceTypeConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceTypeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceTypeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取机型配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypeConfigRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypeConfigResponse"/></returns>
        public DescribeInstanceTypeConfigResponse DescribeInstanceTypeConfigSync(DescribeInstanceTypeConfigRequest req)
        {
             JsonResponseModel<DescribeInstanceTypeConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceTypeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceTypeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例的相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例的相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过实例id获取当前禁止的操作
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public async Task<DescribeInstancesDeniedActionsResponse> DescribeInstancesDeniedActions(DescribeInstancesDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeInstancesDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过实例id获取当前禁止的操作
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public DescribeInstancesDeniedActionsResponse DescribeInstancesDeniedActionsSync(DescribeInstancesDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeInstancesDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取模块列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleRequest"/></param>
        /// <returns><see cref="DescribeModuleResponse"/></returns>
        public async Task<DescribeModuleResponse> DescribeModule(DescribeModuleRequest req)
        {
             JsonResponseModel<DescribeModuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取模块列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleRequest"/></param>
        /// <returns><see cref="DescribeModuleResponse"/></returns>
        public DescribeModuleResponse DescribeModuleSync(DescribeModuleRequest req)
        {
             JsonResponseModel<DescribeModuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 展示模块详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleDetailRequest"/></param>
        /// <returns><see cref="DescribeModuleDetailResponse"/></returns>
        public async Task<DescribeModuleDetailResponse> DescribeModuleDetail(DescribeModuleDetailRequest req)
        {
             JsonResponseModel<DescribeModuleDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 展示模块详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleDetailRequest"/></param>
        /// <returns><see cref="DescribeModuleDetailResponse"/></returns>
        public DescribeModuleDetailResponse DescribeModuleDetailSync(DescribeModuleDetailRequest req)
        {
             JsonResponseModel<DescribeModuleDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeRequest"/></param>
        /// <returns><see cref="DescribeNodeResponse"/></returns>
        public async Task<DescribeNodeResponse> DescribeNode(DescribeNodeRequest req)
        {
             JsonResponseModel<DescribeNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeRequest"/></param>
        /// <returns><see cref="DescribeNodeResponse"/></returns>
        public DescribeNodeResponse DescribeNodeSync(DescribeNodeRequest req)
        {
             JsonResponseModel<DescribeNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CPU 内存 硬盘等基础信息峰值数据
        /// </summary>
        /// <param name="req"><see cref="DescribePeakBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakBaseOverviewResponse"/></returns>
        public async Task<DescribePeakBaseOverviewResponse> DescribePeakBaseOverview(DescribePeakBaseOverviewRequest req)
        {
             JsonResponseModel<DescribePeakBaseOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePeakBaseOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePeakBaseOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CPU 内存 硬盘等基础信息峰值数据
        /// </summary>
        /// <param name="req"><see cref="DescribePeakBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakBaseOverviewResponse"/></returns>
        public DescribePeakBaseOverviewResponse DescribePeakBaseOverviewSync(DescribePeakBaseOverviewRequest req)
        {
             JsonResponseModel<DescribePeakBaseOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePeakBaseOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePeakBaseOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取网络峰值数据
        /// </summary>
        /// <param name="req"><see cref="DescribePeakNetworkOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakNetworkOverviewResponse"/></returns>
        public async Task<DescribePeakNetworkOverviewResponse> DescribePeakNetworkOverview(DescribePeakNetworkOverviewRequest req)
        {
             JsonResponseModel<DescribePeakNetworkOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePeakNetworkOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePeakNetworkOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取网络峰值数据
        /// </summary>
        /// <param name="req"><see cref="DescribePeakNetworkOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakNetworkOverviewResponse"/></returns>
        public DescribePeakNetworkOverviewResponse DescribePeakNetworkOverviewSync(DescribePeakNetworkOverviewRequest req)
        {
             JsonResponseModel<DescribePeakNetworkOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePeakNetworkOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePeakNetworkOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从CVM产品导入镜像到ECM
        /// </summary>
        /// <param name="req"><see cref="ImportImageRequest"/></param>
        /// <returns><see cref="ImportImageResponse"/></returns>
        public async Task<ImportImageResponse> ImportImage(ImportImageRequest req)
        {
             JsonResponseModel<ImportImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从CVM产品导入镜像到ECM
        /// </summary>
        /// <param name="req"><see cref="ImportImageRequest"/></param>
        /// <returns><see cref="ImportImageResponse"/></returns>
        public ImportImageResponse ImportImageSync(ImportImageRequest req)
        {
             JsonResponseModel<ImportImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public async Task<ModifyInstancesAttributeResponse> ModifyInstancesAttribute(ModifyInstancesAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public ModifyInstancesAttributeResponse ModifyInstancesAttributeSync(ModifyInstancesAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyModuleImage
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleImageRequest"/></param>
        /// <returns><see cref="ModifyModuleImageResponse"/></returns>
        public async Task<ModifyModuleImageResponse> ModifyModuleImage(ModifyModuleImageRequest req)
        {
             JsonResponseModel<ModifyModuleImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyModuleImage
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleImageRequest"/></param>
        /// <returns><see cref="ModifyModuleImageResponse"/></returns>
        public ModifyModuleImageResponse ModifyModuleImageSync(ModifyModuleImageRequest req)
        {
             JsonResponseModel<ModifyModuleImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块名称
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNameRequest"/></param>
        /// <returns><see cref="ModifyModuleNameResponse"/></returns>
        public async Task<ModifyModuleNameResponse> ModifyModuleName(ModifyModuleNameRequest req)
        {
             JsonResponseModel<ModifyModuleNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块名称
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNameRequest"/></param>
        /// <returns><see cref="ModifyModuleNameResponse"/></returns>
        public ModifyModuleNameResponse ModifyModuleNameSync(ModifyModuleNameRequest req)
        {
             JsonResponseModel<ModifyModuleNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块默认带宽上限
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNetworkRequest"/></param>
        /// <returns><see cref="ModifyModuleNetworkResponse"/></returns>
        public async Task<ModifyModuleNetworkResponse> ModifyModuleNetwork(ModifyModuleNetworkRequest req)
        {
             JsonResponseModel<ModifyModuleNetworkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleNetwork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleNetworkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块默认带宽上限
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNetworkRequest"/></param>
        /// <returns><see cref="ModifyModuleNetworkResponse"/></returns>
        public ModifyModuleNetworkResponse ModifyModuleNetworkSync(ModifyModuleNetworkRequest req)
        {
             JsonResponseModel<ModifyModuleNetworkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleNetwork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleNetworkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 只有状态为RUNNING的实例才可以进行此操作；接口调用成功时，实例会进入REBOOTING状态；重启实例成功时，实例会进入RUNNING状态；支持强制重启，强制重启的效果等同于关闭物理计算机的电源开关再重新启动。强制重启可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常重启时使用。
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public async Task<RebootInstancesResponse> RebootInstances(RebootInstancesRequest req)
        {
             JsonResponseModel<RebootInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RebootInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebootInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 只有状态为RUNNING的实例才可以进行此操作；接口调用成功时，实例会进入REBOOTING状态；重启实例成功时，实例会进入RUNNING状态；支持强制重启，强制重启的效果等同于关闭物理计算机的电源开关再重新启动。强制重启可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常重启时使用。
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public RebootInstancesResponse RebootInstancesSync(RebootInstancesRequest req)
        {
             JsonResponseModel<RebootInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RebootInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebootInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重装实例，若指定了ImageId参数，则使用指定的镜像重装；否则按照当前实例使用的镜像进行重装；若未指定密码，则密码通过站内信形式随后发送。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesRequest"/></param>
        /// <returns><see cref="ResetInstancesResponse"/></returns>
        public async Task<ResetInstancesResponse> ResetInstances(ResetInstancesRequest req)
        {
             JsonResponseModel<ResetInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重装实例，若指定了ImageId参数，则使用指定的镜像重装；否则按照当前实例使用的镜像进行重装；若未指定密码，则密码通过站内信形式随后发送。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesRequest"/></param>
        /// <returns><see cref="ResetInstancesResponse"/></returns>
        public ResetInstancesResponse ResetInstancesSync(ResetInstancesRequest req)
        {
             JsonResponseModel<ResetInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置实例的最大带宽上限。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetInstancesMaxBandwidthResponse"/></returns>
        public async Task<ResetInstancesMaxBandwidthResponse> ResetInstancesMaxBandwidth(ResetInstancesMaxBandwidthRequest req)
        {
             JsonResponseModel<ResetInstancesMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstancesMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置实例的最大带宽上限。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetInstancesMaxBandwidthResponse"/></returns>
        public ResetInstancesMaxBandwidthResponse ResetInstancesMaxBandwidthSync(ResetInstancesMaxBandwidthRequest req)
        {
             JsonResponseModel<ResetInstancesMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstancesMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁实例
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public async Task<TerminateInstancesResponse> TerminateInstances(TerminateInstancesRequest req)
        {
             JsonResponseModel<TerminateInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁实例
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public TerminateInstancesResponse TerminateInstancesSync(TerminateInstancesRequest req)
        {
             JsonResponseModel<TerminateInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
