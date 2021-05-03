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
        /// 创建命名空间
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
        /// 创建命名空间
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
        /// 获取租户命名空间列表
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
        /// 获取租户命名空间列表
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
        /// 编辑命名空间
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
        /// 编辑命名空间
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

    }
}
