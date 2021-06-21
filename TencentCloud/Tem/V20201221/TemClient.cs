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

namespace TencentCloud.Tem.V20201221
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tem.V20201221.Models;

   public class TemClient : AbstractClient{

       private const string endpoint = "tem.tencentcloudapi.com";
       private const string version = "2020-12-21";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TemClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TemClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 生成Cos临时秘钥
        /// </summary>
        /// <param name="req"><see cref="CreateCosTokenRequest"/></param>
        /// <returns><see cref="CreateCosTokenResponse"/></returns>
        public async Task<CreateCosTokenResponse> CreateCosToken(CreateCosTokenRequest req)
        {
             JsonResponseModel<CreateCosTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCosToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCosTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成Cos临时秘钥
        /// </summary>
        /// <param name="req"><see cref="CreateCosTokenRequest"/></param>
        /// <returns><see cref="CreateCosTokenResponse"/></returns>
        public CreateCosTokenResponse CreateCosTokenSync(CreateCosTokenRequest req)
        {
             JsonResponseModel<CreateCosTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCosToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCosTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成Cos临时秘钥
        /// </summary>
        /// <param name="req"><see cref="CreateCosTokenV2Request"/></param>
        /// <returns><see cref="CreateCosTokenV2Response"/></returns>
        public async Task<CreateCosTokenV2Response> CreateCosTokenV2(CreateCosTokenV2Request req)
        {
             JsonResponseModel<CreateCosTokenV2Response> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCosTokenV2");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCosTokenV2Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成Cos临时秘钥
        /// </summary>
        /// <param name="req"><see cref="CreateCosTokenV2Request"/></param>
        /// <returns><see cref="CreateCosTokenV2Response"/></returns>
        public CreateCosTokenV2Response CreateCosTokenV2Sync(CreateCosTokenV2Request req)
        {
             JsonResponseModel<CreateCosTokenV2Response> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCosTokenV2");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCosTokenV2Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建环境
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public async Task<CreateNamespaceResponse> CreateNamespace(CreateNamespaceRequest req)
        {
             JsonResponseModel<CreateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建环境
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public CreateNamespaceResponse CreateNamespaceSync(CreateNamespaceRequest req)
        {
             JsonResponseModel<CreateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定云资源
        /// </summary>
        /// <param name="req"><see cref="CreateResourceRequest"/></param>
        /// <returns><see cref="CreateResourceResponse"/></returns>
        public async Task<CreateResourceResponse> CreateResource(CreateResourceRequest req)
        {
             JsonResponseModel<CreateResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定云资源
        /// </summary>
        /// <param name="req"><see cref="CreateResourceRequest"/></param>
        /// <returns><see cref="CreateResourceResponse"/></returns>
        public CreateResourceResponse CreateResourceSync(CreateResourceRequest req)
        {
             JsonResponseModel<CreateResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建服务
        /// </summary>
        /// <param name="req"><see cref="CreateServiceV2Request"/></param>
        /// <returns><see cref="CreateServiceV2Response"/></returns>
        public async Task<CreateServiceV2Response> CreateServiceV2(CreateServiceV2Request req)
        {
             JsonResponseModel<CreateServiceV2Response> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServiceV2");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceV2Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建服务
        /// </summary>
        /// <param name="req"><see cref="CreateServiceV2Request"/></param>
        /// <returns><see cref="CreateServiceV2Response"/></returns>
        public CreateServiceV2Response CreateServiceV2Sync(CreateServiceV2Request req)
        {
             JsonResponseModel<CreateServiceV2Response> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateServiceV2");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceV2Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除 Ingress 规则
        /// </summary>
        /// <param name="req"><see cref="DeleteIngressRequest"/></param>
        /// <returns><see cref="DeleteIngressResponse"/></returns>
        public async Task<DeleteIngressResponse> DeleteIngress(DeleteIngressRequest req)
        {
             JsonResponseModel<DeleteIngressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIngress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIngressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除 Ingress 规则
        /// </summary>
        /// <param name="req"><see cref="DeleteIngressRequest"/></param>
        /// <returns><see cref="DeleteIngressResponse"/></returns>
        public DeleteIngressResponse DeleteIngressSync(DeleteIngressRequest req)
        {
             JsonResponseModel<DeleteIngressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIngress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIngressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 服务部署
        /// </summary>
        /// <param name="req"><see cref="DeployServiceV2Request"/></param>
        /// <returns><see cref="DeployServiceV2Response"/></returns>
        public async Task<DeployServiceV2Response> DeployServiceV2(DeployServiceV2Request req)
        {
             JsonResponseModel<DeployServiceV2Response> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeployServiceV2");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployServiceV2Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 服务部署
        /// </summary>
        /// <param name="req"><see cref="DeployServiceV2Request"/></param>
        /// <returns><see cref="DeployServiceV2Response"/></returns>
        public DeployServiceV2Response DeployServiceV2Sync(DeployServiceV2Request req)
        {
             JsonResponseModel<DeployServiceV2Response> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeployServiceV2");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployServiceV2Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询 Ingress 规则
        /// </summary>
        /// <param name="req"><see cref="DescribeIngressRequest"/></param>
        /// <returns><see cref="DescribeIngressResponse"/></returns>
        public async Task<DescribeIngressResponse> DescribeIngress(DescribeIngressRequest req)
        {
             JsonResponseModel<DescribeIngressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIngress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIngressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询 Ingress 规则
        /// </summary>
        /// <param name="req"><see cref="DescribeIngressRequest"/></param>
        /// <returns><see cref="DescribeIngressResponse"/></returns>
        public DescribeIngressResponse DescribeIngressSync(DescribeIngressRequest req)
        {
             JsonResponseModel<DescribeIngressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIngress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIngressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询 Ingress 规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIngressesRequest"/></param>
        /// <returns><see cref="DescribeIngressesResponse"/></returns>
        public async Task<DescribeIngressesResponse> DescribeIngresses(DescribeIngressesRequest req)
        {
             JsonResponseModel<DescribeIngressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIngresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIngressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询 Ingress 规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIngressesRequest"/></param>
        /// <returns><see cref="DescribeIngressesResponse"/></returns>
        public DescribeIngressesResponse DescribeIngressesSync(DescribeIngressesRequest req)
        {
             JsonResponseModel<DescribeIngressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIngresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIngressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取租户环境列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacesRequest"/></param>
        /// <returns><see cref="DescribeNamespacesResponse"/></returns>
        public async Task<DescribeNamespacesResponse> DescribeNamespaces(DescribeNamespacesRequest req)
        {
             JsonResponseModel<DescribeNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取租户环境列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacesRequest"/></param>
        /// <returns><see cref="DescribeNamespacesResponse"/></returns>
        public DescribeNamespacesResponse DescribeNamespacesSync(DescribeNamespacesRequest req)
        {
             JsonResponseModel<DescribeNamespacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务关联的 Ingress 规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedIngressesRequest"/></param>
        /// <returns><see cref="DescribeRelatedIngressesResponse"/></returns>
        public async Task<DescribeRelatedIngressesResponse> DescribeRelatedIngresses(DescribeRelatedIngressesRequest req)
        {
             JsonResponseModel<DescribeRelatedIngressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRelatedIngresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRelatedIngressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务关联的 Ingress 规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedIngressesRequest"/></param>
        /// <returns><see cref="DescribeRelatedIngressesResponse"/></returns>
        public DescribeRelatedIngressesResponse DescribeRelatedIngressesSync(DescribeRelatedIngressesRequest req)
        {
             JsonResponseModel<DescribeRelatedIngressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRelatedIngresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRelatedIngressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取服务下面运行pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceRunPodListV2Request"/></param>
        /// <returns><see cref="DescribeServiceRunPodListV2Response"/></returns>
        public async Task<DescribeServiceRunPodListV2Response> DescribeServiceRunPodListV2(DescribeServiceRunPodListV2Request req)
        {
             JsonResponseModel<DescribeServiceRunPodListV2Response> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceRunPodListV2");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceRunPodListV2Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取服务下面运行pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceRunPodListV2Request"/></param>
        /// <returns><see cref="DescribeServiceRunPodListV2Response"/></returns>
        public DescribeServiceRunPodListV2Response DescribeServiceRunPodListV2Sync(DescribeServiceRunPodListV2Request req)
        {
             JsonResponseModel<DescribeServiceRunPodListV2Response> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceRunPodListV2");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceRunPodListV2Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成包预签名下载链接
        /// </summary>
        /// <param name="req"><see cref="GenerateDownloadUrlRequest"/></param>
        /// <returns><see cref="GenerateDownloadUrlResponse"/></returns>
        public async Task<GenerateDownloadUrlResponse> GenerateDownloadUrl(GenerateDownloadUrlRequest req)
        {
             JsonResponseModel<GenerateDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成包预签名下载链接
        /// </summary>
        /// <param name="req"><see cref="GenerateDownloadUrlRequest"/></param>
        /// <returns><see cref="GenerateDownloadUrlResponse"/></returns>
        public GenerateDownloadUrlResponse GenerateDownloadUrlSync(GenerateDownloadUrlRequest req)
        {
             JsonResponseModel<GenerateDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建或者更新 Ingress 规则
        /// </summary>
        /// <param name="req"><see cref="ModifyIngressRequest"/></param>
        /// <returns><see cref="ModifyIngressResponse"/></returns>
        public async Task<ModifyIngressResponse> ModifyIngress(ModifyIngressRequest req)
        {
             JsonResponseModel<ModifyIngressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIngress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIngressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建或者更新 Ingress 规则
        /// </summary>
        /// <param name="req"><see cref="ModifyIngressRequest"/></param>
        /// <returns><see cref="ModifyIngressResponse"/></returns>
        public ModifyIngressResponse ModifyIngressSync(ModifyIngressRequest req)
        {
             JsonResponseModel<ModifyIngressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyIngress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIngressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑环境
        /// </summary>
        /// <param name="req"><see cref="ModifyNamespaceRequest"/></param>
        /// <returns><see cref="ModifyNamespaceResponse"/></returns>
        public async Task<ModifyNamespaceResponse> ModifyNamespace(ModifyNamespaceRequest req)
        {
             JsonResponseModel<ModifyNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑环境
        /// </summary>
        /// <param name="req"><see cref="ModifyNamespaceRequest"/></param>
        /// <returns><see cref="ModifyNamespaceResponse"/></returns>
        public ModifyNamespaceResponse ModifyNamespaceSync(ModifyNamespaceRequest req)
        {
             JsonResponseModel<ModifyNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改服务基本信息
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceInfoRequest"/></param>
        /// <returns><see cref="ModifyServiceInfoResponse"/></returns>
        public async Task<ModifyServiceInfoResponse> ModifyServiceInfo(ModifyServiceInfoRequest req)
        {
             JsonResponseModel<ModifyServiceInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyServiceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改服务基本信息
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceInfoRequest"/></param>
        /// <returns><see cref="ModifyServiceInfoResponse"/></returns>
        public ModifyServiceInfoResponse ModifyServiceInfoSync(ModifyServiceInfoRequest req)
        {
             JsonResponseModel<ModifyServiceInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyServiceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启实例
        /// </summary>
        /// <param name="req"><see cref="RestartServiceRunPodRequest"/></param>
        /// <returns><see cref="RestartServiceRunPodResponse"/></returns>
        public async Task<RestartServiceRunPodResponse> RestartServiceRunPod(RestartServiceRunPodRequest req)
        {
             JsonResponseModel<RestartServiceRunPodResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartServiceRunPod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartServiceRunPodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启实例
        /// </summary>
        /// <param name="req"><see cref="RestartServiceRunPodRequest"/></param>
        /// <returns><see cref="RestartServiceRunPodResponse"/></returns>
        public RestartServiceRunPodResponse RestartServiceRunPodSync(RestartServiceRunPodRequest req)
        {
             JsonResponseModel<RestartServiceRunPodResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartServiceRunPod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartServiceRunPodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
