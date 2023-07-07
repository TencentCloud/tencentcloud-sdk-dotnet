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

namespace TencentCloud.Tcr.V20190924
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcr.V20190924.Models;

   public class TcrClient : AbstractClient{

       private const string endpoint = "tcr.tencentcloudapi.com";
       private const string version = "2019-09-24";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 用于在个人版镜像仓库中批量删除Tag
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteImagePersonalRequest"/></param>
        /// <returns><see cref="BatchDeleteImagePersonalResponse"/></returns>
        public async Task<BatchDeleteImagePersonalResponse> BatchDeleteImagePersonal(BatchDeleteImagePersonalRequest req)
        {
             JsonResponseModel<BatchDeleteImagePersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDeleteImagePersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteImagePersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在个人版镜像仓库中批量删除Tag
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteImagePersonalRequest"/></param>
        /// <returns><see cref="BatchDeleteImagePersonalResponse"/></returns>
        public BatchDeleteImagePersonalResponse BatchDeleteImagePersonalSync(BatchDeleteImagePersonalRequest req)
        {
             JsonResponseModel<BatchDeleteImagePersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDeleteImagePersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteImagePersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于个人版镜像仓库中批量删除镜像仓库
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteRepositoryPersonalRequest"/></param>
        /// <returns><see cref="BatchDeleteRepositoryPersonalResponse"/></returns>
        public async Task<BatchDeleteRepositoryPersonalResponse> BatchDeleteRepositoryPersonal(BatchDeleteRepositoryPersonalRequest req)
        {
             JsonResponseModel<BatchDeleteRepositoryPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDeleteRepositoryPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteRepositoryPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于个人版镜像仓库中批量删除镜像仓库
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteRepositoryPersonalRequest"/></param>
        /// <returns><see cref="BatchDeleteRepositoryPersonalResponse"/></returns>
        public BatchDeleteRepositoryPersonalResponse BatchDeleteRepositoryPersonalSync(BatchDeleteRepositoryPersonalRequest req)
        {
             JsonResponseModel<BatchDeleteRepositoryPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDeleteRepositoryPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteRepositoryPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于校验企业版实例信息
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceRequest"/></param>
        /// <returns><see cref="CheckInstanceResponse"/></returns>
        public async Task<CheckInstanceResponse> CheckInstance(CheckInstanceRequest req)
        {
             JsonResponseModel<CheckInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于校验企业版实例信息
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceRequest"/></param>
        /// <returns><see cref="CheckInstanceResponse"/></returns>
        public CheckInstanceResponse CheckInstanceSync(CheckInstanceRequest req)
        {
             JsonResponseModel<CheckInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查待创建的实例名称是否符合规范
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceNameRequest"/></param>
        /// <returns><see cref="CheckInstanceNameResponse"/></returns>
        public async Task<CheckInstanceNameResponse> CheckInstanceName(CheckInstanceNameRequest req)
        {
             JsonResponseModel<CheckInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查待创建的实例名称是否符合规范
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceNameRequest"/></param>
        /// <returns><see cref="CheckInstanceNameResponse"/></returns>
        public CheckInstanceNameResponse CheckInstanceNameSync(CheckInstanceNameRequest req)
        {
             JsonResponseModel<CheckInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建应用更新触发器
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationTriggerPersonalRequest"/></param>
        /// <returns><see cref="CreateApplicationTriggerPersonalResponse"/></returns>
        public async Task<CreateApplicationTriggerPersonalResponse> CreateApplicationTriggerPersonal(CreateApplicationTriggerPersonalRequest req)
        {
             JsonResponseModel<CreateApplicationTriggerPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApplicationTriggerPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationTriggerPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建应用更新触发器
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationTriggerPersonalRequest"/></param>
        /// <returns><see cref="CreateApplicationTriggerPersonalResponse"/></returns>
        public CreateApplicationTriggerPersonalResponse CreateApplicationTriggerPersonalSync(CreateApplicationTriggerPersonalRequest req)
        {
             JsonResponseModel<CreateApplicationTriggerPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApplicationTriggerPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationTriggerPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义账户
        /// </summary>
        /// <param name="req"><see cref="CreateCustomAccountRequest"/></param>
        /// <returns><see cref="CreateCustomAccountResponse"/></returns>
        public async Task<CreateCustomAccountResponse> CreateCustomAccount(CreateCustomAccountRequest req)
        {
             JsonResponseModel<CreateCustomAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义账户
        /// </summary>
        /// <param name="req"><see cref="CreateCustomAccountRequest"/></param>
        /// <returns><see cref="CreateCustomAccountResponse"/></returns>
        public CreateCustomAccountResponse CreateCustomAccountSync(CreateCustomAccountRequest req)
        {
             JsonResponseModel<CreateCustomAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustomAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建镜像加速服务
        /// </summary>
        /// <param name="req"><see cref="CreateImageAccelerationServiceRequest"/></param>
        /// <returns><see cref="CreateImageAccelerationServiceResponse"/></returns>
        public async Task<CreateImageAccelerationServiceResponse> CreateImageAccelerationService(CreateImageAccelerationServiceRequest req)
        {
             JsonResponseModel<CreateImageAccelerationServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImageAccelerationService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageAccelerationServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建镜像加速服务
        /// </summary>
        /// <param name="req"><see cref="CreateImageAccelerationServiceRequest"/></param>
        /// <returns><see cref="CreateImageAccelerationServiceResponse"/></returns>
        public CreateImageAccelerationServiceResponse CreateImageAccelerationServiceSync(CreateImageAccelerationServiceRequest req)
        {
             JsonResponseModel<CreateImageAccelerationServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImageAccelerationService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageAccelerationServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建镜像不可变规则
        /// </summary>
        /// <param name="req"><see cref="CreateImmutableTagRulesRequest"/></param>
        /// <returns><see cref="CreateImmutableTagRulesResponse"/></returns>
        public async Task<CreateImmutableTagRulesResponse> CreateImmutableTagRules(CreateImmutableTagRulesRequest req)
        {
             JsonResponseModel<CreateImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建镜像不可变规则
        /// </summary>
        /// <param name="req"><see cref="CreateImmutableTagRulesRequest"/></param>
        /// <returns><see cref="CreateImmutableTagRulesResponse"/></returns>
        public CreateImmutableTagRulesResponse CreateImmutableTagRulesSync(CreateImmutableTagRulesRequest req)
        {
             JsonResponseModel<CreateImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public async Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
             JsonResponseModel<CreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
             JsonResponseModel<CreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义域名
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="CreateInstanceCustomizedDomainResponse"/></returns>
        public async Task<CreateInstanceCustomizedDomainResponse> CreateInstanceCustomizedDomain(CreateInstanceCustomizedDomainRequest req)
        {
             JsonResponseModel<CreateInstanceCustomizedDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstanceCustomizedDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceCustomizedDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义域名
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="CreateInstanceCustomizedDomainResponse"/></returns>
        public CreateInstanceCustomizedDomainResponse CreateInstanceCustomizedDomainSync(CreateInstanceCustomizedDomainRequest req)
        {
             JsonResponseModel<CreateInstanceCustomizedDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstanceCustomizedDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceCustomizedDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建实例的临时或长期访问凭证
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceTokenRequest"/></param>
        /// <returns><see cref="CreateInstanceTokenResponse"/></returns>
        public async Task<CreateInstanceTokenResponse> CreateInstanceToken(CreateInstanceTokenRequest req)
        {
             JsonResponseModel<CreateInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建实例的临时或长期访问凭证
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceTokenRequest"/></param>
        /// <returns><see cref="CreateInstanceTokenResponse"/></returns>
        public CreateInstanceTokenResponse CreateInstanceTokenSync(CreateInstanceTokenRequest req)
        {
             JsonResponseModel<CreateInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建tcr内网私有域名解析
        /// </summary>
        /// <param name="req"><see cref="CreateInternalEndpointDnsRequest"/></param>
        /// <returns><see cref="CreateInternalEndpointDnsResponse"/></returns>
        public async Task<CreateInternalEndpointDnsResponse> CreateInternalEndpointDns(CreateInternalEndpointDnsRequest req)
        {
             JsonResponseModel<CreateInternalEndpointDnsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInternalEndpointDns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInternalEndpointDnsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建tcr内网私有域名解析
        /// </summary>
        /// <param name="req"><see cref="CreateInternalEndpointDnsRequest"/></param>
        /// <returns><see cref="CreateInternalEndpointDnsResponse"/></returns>
        public CreateInternalEndpointDnsResponse CreateInternalEndpointDnsSync(CreateInternalEndpointDnsRequest req)
        {
             JsonResponseModel<CreateInternalEndpointDnsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInternalEndpointDns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInternalEndpointDnsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在TCR实例中，创建多个白名单策略
        /// </summary>
        /// <param name="req"><see cref="CreateMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateMultipleSecurityPolicyResponse"/></returns>
        public async Task<CreateMultipleSecurityPolicyResponse> CreateMultipleSecurityPolicy(CreateMultipleSecurityPolicyRequest req)
        {
             JsonResponseModel<CreateMultipleSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMultipleSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMultipleSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在TCR实例中，创建多个白名单策略
        /// </summary>
        /// <param name="req"><see cref="CreateMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateMultipleSecurityPolicyResponse"/></returns>
        public CreateMultipleSecurityPolicyResponse CreateMultipleSecurityPolicySync(CreateMultipleSecurityPolicyRequest req)
        {
             JsonResponseModel<CreateMultipleSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMultipleSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMultipleSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在企业版中创建命名空间
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
        /// 用于在企业版中创建命名空间
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
        /// 创建个人版镜像仓库命名空间，此命名空间全局唯一
        /// </summary>
        /// <param name="req"><see cref="CreateNamespacePersonalRequest"/></param>
        /// <returns><see cref="CreateNamespacePersonalResponse"/></returns>
        public async Task<CreateNamespacePersonalResponse> CreateNamespacePersonal(CreateNamespacePersonalRequest req)
        {
             JsonResponseModel<CreateNamespacePersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNamespacePersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNamespacePersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建个人版镜像仓库命名空间，此命名空间全局唯一
        /// </summary>
        /// <param name="req"><see cref="CreateNamespacePersonalRequest"/></param>
        /// <returns><see cref="CreateNamespacePersonalResponse"/></returns>
        public CreateNamespacePersonalResponse CreateNamespacePersonalSync(CreateNamespacePersonalRequest req)
        {
             JsonResponseModel<CreateNamespacePersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNamespacePersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNamespacePersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建从实例
        /// </summary>
        /// <param name="req"><see cref="CreateReplicationInstanceRequest"/></param>
        /// <returns><see cref="CreateReplicationInstanceResponse"/></returns>
        public async Task<CreateReplicationInstanceResponse> CreateReplicationInstance(CreateReplicationInstanceRequest req)
        {
             JsonResponseModel<CreateReplicationInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReplicationInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReplicationInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建从实例
        /// </summary>
        /// <param name="req"><see cref="CreateReplicationInstanceRequest"/></param>
        /// <returns><see cref="CreateReplicationInstanceResponse"/></returns>
        public CreateReplicationInstanceResponse CreateReplicationInstanceSync(CreateReplicationInstanceRequest req)
        {
             JsonResponseModel<CreateReplicationInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReplicationInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReplicationInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于企业版创建镜像仓库
        /// </summary>
        /// <param name="req"><see cref="CreateRepositoryRequest"/></param>
        /// <returns><see cref="CreateRepositoryResponse"/></returns>
        public async Task<CreateRepositoryResponse> CreateRepository(CreateRepositoryRequest req)
        {
             JsonResponseModel<CreateRepositoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于企业版创建镜像仓库
        /// </summary>
        /// <param name="req"><see cref="CreateRepositoryRequest"/></param>
        /// <returns><see cref="CreateRepositoryResponse"/></returns>
        public CreateRepositoryResponse CreateRepositorySync(CreateRepositoryRequest req)
        {
             JsonResponseModel<CreateRepositoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在个人版仓库中创建镜像仓库
        /// </summary>
        /// <param name="req"><see cref="CreateRepositoryPersonalRequest"/></param>
        /// <returns><see cref="CreateRepositoryPersonalResponse"/></returns>
        public async Task<CreateRepositoryPersonalResponse> CreateRepositoryPersonal(CreateRepositoryPersonalRequest req)
        {
             JsonResponseModel<CreateRepositoryPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRepositoryPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRepositoryPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在个人版仓库中创建镜像仓库
        /// </summary>
        /// <param name="req"><see cref="CreateRepositoryPersonalRequest"/></param>
        /// <returns><see cref="CreateRepositoryPersonalResponse"/></returns>
        public CreateRepositoryPersonalResponse CreateRepositoryPersonalSync(CreateRepositoryPersonalRequest req)
        {
             JsonResponseModel<CreateRepositoryPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRepositoryPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRepositoryPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建实例公网访问白名单策略
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public async Task<CreateSecurityPolicyResponse> CreateSecurityPolicy(CreateSecurityPolicyRequest req)
        {
             JsonResponseModel<CreateSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建实例公网访问白名单策略
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public CreateSecurityPolicyResponse CreateSecurityPolicySync(CreateSecurityPolicyRequest req)
        {
             JsonResponseModel<CreateSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义账户
        /// </summary>
        /// <param name="req"><see cref="CreateServiceAccountRequest"/></param>
        /// <returns><see cref="CreateServiceAccountResponse"/></returns>
        public async Task<CreateServiceAccountResponse> CreateServiceAccount(CreateServiceAccountRequest req)
        {
             JsonResponseModel<CreateServiceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServiceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义账户
        /// </summary>
        /// <param name="req"><see cref="CreateServiceAccountRequest"/></param>
        /// <returns><see cref="CreateServiceAccountResponse"/></returns>
        public CreateServiceAccountResponse CreateServiceAccountSync(CreateServiceAccountRequest req)
        {
             JsonResponseModel<CreateServiceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateServiceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为一个镜像版本创建签名
        /// </summary>
        /// <param name="req"><see cref="CreateSignatureRequest"/></param>
        /// <returns><see cref="CreateSignatureResponse"/></returns>
        public async Task<CreateSignatureResponse> CreateSignature(CreateSignatureRequest req)
        {
             JsonResponseModel<CreateSignatureResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSignature");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSignatureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为一个镜像版本创建签名
        /// </summary>
        /// <param name="req"><see cref="CreateSignatureRequest"/></param>
        /// <returns><see cref="CreateSignatureResponse"/></returns>
        public CreateSignatureResponse CreateSignatureSync(CreateSignatureRequest req)
        {
             JsonResponseModel<CreateSignatureResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSignature");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSignatureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建镜像签名策略
        /// </summary>
        /// <param name="req"><see cref="CreateSignaturePolicyRequest"/></param>
        /// <returns><see cref="CreateSignaturePolicyResponse"/></returns>
        public async Task<CreateSignaturePolicyResponse> CreateSignaturePolicy(CreateSignaturePolicyRequest req)
        {
             JsonResponseModel<CreateSignaturePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSignaturePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSignaturePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建镜像签名策略
        /// </summary>
        /// <param name="req"><see cref="CreateSignaturePolicyRequest"/></param>
        /// <returns><see cref="CreateSignaturePolicyResponse"/></returns>
        public CreateSignaturePolicyResponse CreateSignaturePolicySync(CreateSignaturePolicyRequest req)
        {
             JsonResponseModel<CreateSignaturePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSignaturePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSignaturePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 手动执行版本保留
        /// </summary>
        /// <param name="req"><see cref="CreateTagRetentionExecutionRequest"/></param>
        /// <returns><see cref="CreateTagRetentionExecutionResponse"/></returns>
        public async Task<CreateTagRetentionExecutionResponse> CreateTagRetentionExecution(CreateTagRetentionExecutionRequest req)
        {
             JsonResponseModel<CreateTagRetentionExecutionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTagRetentionExecution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagRetentionExecutionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 手动执行版本保留
        /// </summary>
        /// <param name="req"><see cref="CreateTagRetentionExecutionRequest"/></param>
        /// <returns><see cref="CreateTagRetentionExecutionResponse"/></returns>
        public CreateTagRetentionExecutionResponse CreateTagRetentionExecutionSync(CreateTagRetentionExecutionRequest req)
        {
             JsonResponseModel<CreateTagRetentionExecutionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTagRetentionExecution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagRetentionExecutionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建版本保留规则
        /// </summary>
        /// <param name="req"><see cref="CreateTagRetentionRuleRequest"/></param>
        /// <returns><see cref="CreateTagRetentionRuleResponse"/></returns>
        public async Task<CreateTagRetentionRuleResponse> CreateTagRetentionRule(CreateTagRetentionRuleRequest req)
        {
             JsonResponseModel<CreateTagRetentionRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTagRetentionRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagRetentionRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建版本保留规则
        /// </summary>
        /// <param name="req"><see cref="CreateTagRetentionRuleRequest"/></param>
        /// <returns><see cref="CreateTagRetentionRuleResponse"/></returns>
        public CreateTagRetentionRuleResponse CreateTagRetentionRuleSync(CreateTagRetentionRuleRequest req)
        {
             JsonResponseModel<CreateTagRetentionRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTagRetentionRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagRetentionRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建个人用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserPersonalRequest"/></param>
        /// <returns><see cref="CreateUserPersonalResponse"/></returns>
        public async Task<CreateUserPersonalResponse> CreateUserPersonal(CreateUserPersonalRequest req)
        {
             JsonResponseModel<CreateUserPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUserPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建个人用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserPersonalRequest"/></param>
        /// <returns><see cref="CreateUserPersonalResponse"/></returns>
        public CreateUserPersonalResponse CreateUserPersonalSync(CreateUserPersonalRequest req)
        {
             JsonResponseModel<CreateUserPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUserPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建触发器
        /// </summary>
        /// <param name="req"><see cref="CreateWebhookTriggerRequest"/></param>
        /// <returns><see cref="CreateWebhookTriggerResponse"/></returns>
        public async Task<CreateWebhookTriggerResponse> CreateWebhookTrigger(CreateWebhookTriggerRequest req)
        {
             JsonResponseModel<CreateWebhookTriggerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWebhookTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWebhookTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建触发器
        /// </summary>
        /// <param name="req"><see cref="CreateWebhookTriggerRequest"/></param>
        /// <returns><see cref="CreateWebhookTriggerResponse"/></returns>
        public CreateWebhookTriggerResponse CreateWebhookTriggerSync(CreateWebhookTriggerRequest req)
        {
             JsonResponseModel<CreateWebhookTriggerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWebhookTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWebhookTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除应用更新触发器
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationTriggerPersonalRequest"/></param>
        /// <returns><see cref="DeleteApplicationTriggerPersonalResponse"/></returns>
        public async Task<DeleteApplicationTriggerPersonalResponse> DeleteApplicationTriggerPersonal(DeleteApplicationTriggerPersonalRequest req)
        {
             JsonResponseModel<DeleteApplicationTriggerPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApplicationTriggerPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationTriggerPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除应用更新触发器
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationTriggerPersonalRequest"/></param>
        /// <returns><see cref="DeleteApplicationTriggerPersonalResponse"/></returns>
        public DeleteApplicationTriggerPersonalResponse DeleteApplicationTriggerPersonalSync(DeleteApplicationTriggerPersonalRequest req)
        {
             JsonResponseModel<DeleteApplicationTriggerPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApplicationTriggerPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationTriggerPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义账号
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomAccountRequest"/></param>
        /// <returns><see cref="DeleteCustomAccountResponse"/></returns>
        public async Task<DeleteCustomAccountResponse> DeleteCustomAccount(DeleteCustomAccountRequest req)
        {
             JsonResponseModel<DeleteCustomAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCustomAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义账号
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomAccountRequest"/></param>
        /// <returns><see cref="DeleteCustomAccountResponse"/></returns>
        public DeleteCustomAccountResponse DeleteCustomAccountSync(DeleteCustomAccountRequest req)
        {
             JsonResponseModel<DeleteCustomAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCustomAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除指定镜像
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
        /// 删除指定镜像
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
        /// 删除镜像加速服务
        /// </summary>
        /// <param name="req"><see cref="DeleteImageAccelerateServiceRequest"/></param>
        /// <returns><see cref="DeleteImageAccelerateServiceResponse"/></returns>
        public async Task<DeleteImageAccelerateServiceResponse> DeleteImageAccelerateService(DeleteImageAccelerateServiceRequest req)
        {
             JsonResponseModel<DeleteImageAccelerateServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImageAccelerateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageAccelerateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除镜像加速服务
        /// </summary>
        /// <param name="req"><see cref="DeleteImageAccelerateServiceRequest"/></param>
        /// <returns><see cref="DeleteImageAccelerateServiceResponse"/></returns>
        public DeleteImageAccelerateServiceResponse DeleteImageAccelerateServiceSync(DeleteImageAccelerateServiceRequest req)
        {
             JsonResponseModel<DeleteImageAccelerateServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImageAccelerateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageAccelerateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除个人版全局镜像版本自动清理策略
        /// </summary>
        /// <param name="req"><see cref="DeleteImageLifecycleGlobalPersonalRequest"/></param>
        /// <returns><see cref="DeleteImageLifecycleGlobalPersonalResponse"/></returns>
        public async Task<DeleteImageLifecycleGlobalPersonalResponse> DeleteImageLifecycleGlobalPersonal(DeleteImageLifecycleGlobalPersonalRequest req)
        {
             JsonResponseModel<DeleteImageLifecycleGlobalPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImageLifecycleGlobalPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageLifecycleGlobalPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除个人版全局镜像版本自动清理策略
        /// </summary>
        /// <param name="req"><see cref="DeleteImageLifecycleGlobalPersonalRequest"/></param>
        /// <returns><see cref="DeleteImageLifecycleGlobalPersonalResponse"/></returns>
        public DeleteImageLifecycleGlobalPersonalResponse DeleteImageLifecycleGlobalPersonalSync(DeleteImageLifecycleGlobalPersonalRequest req)
        {
             JsonResponseModel<DeleteImageLifecycleGlobalPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImageLifecycleGlobalPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageLifecycleGlobalPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在个人版中删除tag
        /// </summary>
        /// <param name="req"><see cref="DeleteImagePersonalRequest"/></param>
        /// <returns><see cref="DeleteImagePersonalResponse"/></returns>
        public async Task<DeleteImagePersonalResponse> DeleteImagePersonal(DeleteImagePersonalRequest req)
        {
             JsonResponseModel<DeleteImagePersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImagePersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImagePersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在个人版中删除tag
        /// </summary>
        /// <param name="req"><see cref="DeleteImagePersonalRequest"/></param>
        /// <returns><see cref="DeleteImagePersonalResponse"/></returns>
        public DeleteImagePersonalResponse DeleteImagePersonalSync(DeleteImagePersonalRequest req)
        {
             JsonResponseModel<DeleteImagePersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImagePersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImagePersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  删除镜像不可变规则
        /// </summary>
        /// <param name="req"><see cref="DeleteImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DeleteImmutableTagRulesResponse"/></returns>
        public async Task<DeleteImmutableTagRulesResponse> DeleteImmutableTagRules(DeleteImmutableTagRulesRequest req)
        {
             JsonResponseModel<DeleteImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  删除镜像不可变规则
        /// </summary>
        /// <param name="req"><see cref="DeleteImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DeleteImmutableTagRulesResponse"/></returns>
        public DeleteImmutableTagRulesResponse DeleteImmutableTagRulesSync(DeleteImmutableTagRulesRequest req)
        {
             JsonResponseModel<DeleteImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除镜像仓库企业版实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public async Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
             JsonResponseModel<DeleteInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除镜像仓库企业版实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
             JsonResponseModel<DeleteInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义域名
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="DeleteInstanceCustomizedDomainResponse"/></returns>
        public async Task<DeleteInstanceCustomizedDomainResponse> DeleteInstanceCustomizedDomain(DeleteInstanceCustomizedDomainRequest req)
        {
             JsonResponseModel<DeleteInstanceCustomizedDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInstanceCustomizedDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceCustomizedDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义域名
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="DeleteInstanceCustomizedDomainResponse"/></returns>
        public DeleteInstanceCustomizedDomainResponse DeleteInstanceCustomizedDomainSync(DeleteInstanceCustomizedDomainRequest req)
        {
             JsonResponseModel<DeleteInstanceCustomizedDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInstanceCustomizedDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceCustomizedDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除长期访问凭证
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceTokenRequest"/></param>
        /// <returns><see cref="DeleteInstanceTokenResponse"/></returns>
        public async Task<DeleteInstanceTokenResponse> DeleteInstanceToken(DeleteInstanceTokenRequest req)
        {
             JsonResponseModel<DeleteInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除长期访问凭证
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceTokenRequest"/></param>
        /// <returns><see cref="DeleteInstanceTokenResponse"/></returns>
        public DeleteInstanceTokenResponse DeleteInstanceTokenSync(DeleteInstanceTokenRequest req)
        {
             JsonResponseModel<DeleteInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除tcr内网私有域名解析
        /// </summary>
        /// <param name="req"><see cref="DeleteInternalEndpointDnsRequest"/></param>
        /// <returns><see cref="DeleteInternalEndpointDnsResponse"/></returns>
        public async Task<DeleteInternalEndpointDnsResponse> DeleteInternalEndpointDns(DeleteInternalEndpointDnsRequest req)
        {
             JsonResponseModel<DeleteInternalEndpointDnsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInternalEndpointDns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInternalEndpointDnsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除tcr内网私有域名解析
        /// </summary>
        /// <param name="req"><see cref="DeleteInternalEndpointDnsRequest"/></param>
        /// <returns><see cref="DeleteInternalEndpointDnsResponse"/></returns>
        public DeleteInternalEndpointDnsResponse DeleteInternalEndpointDnsSync(DeleteInternalEndpointDnsRequest req)
        {
             JsonResponseModel<DeleteInternalEndpointDnsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInternalEndpointDns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInternalEndpointDnsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除实例多个公网访问白名单策略
        /// </summary>
        /// <param name="req"><see cref="DeleteMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteMultipleSecurityPolicyResponse"/></returns>
        public async Task<DeleteMultipleSecurityPolicyResponse> DeleteMultipleSecurityPolicy(DeleteMultipleSecurityPolicyRequest req)
        {
             JsonResponseModel<DeleteMultipleSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMultipleSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMultipleSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除实例多个公网访问白名单策略
        /// </summary>
        /// <param name="req"><see cref="DeleteMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteMultipleSecurityPolicyResponse"/></returns>
        public DeleteMultipleSecurityPolicyResponse DeleteMultipleSecurityPolicySync(DeleteMultipleSecurityPolicyRequest req)
        {
             JsonResponseModel<DeleteMultipleSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMultipleSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMultipleSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespace(DeleteNamespaceRequest req)
        {
             JsonResponseModel<DeleteNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public DeleteNamespaceResponse DeleteNamespaceSync(DeleteNamespaceRequest req)
        {
             JsonResponseModel<DeleteNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除共享版命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespacePersonalRequest"/></param>
        /// <returns><see cref="DeleteNamespacePersonalResponse"/></returns>
        public async Task<DeleteNamespacePersonalResponse> DeleteNamespacePersonal(DeleteNamespacePersonalRequest req)
        {
             JsonResponseModel<DeleteNamespacePersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNamespacePersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNamespacePersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除共享版命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespacePersonalRequest"/></param>
        /// <returns><see cref="DeleteNamespacePersonalResponse"/></returns>
        public DeleteNamespacePersonalResponse DeleteNamespacePersonalSync(DeleteNamespacePersonalRequest req)
        {
             JsonResponseModel<DeleteNamespacePersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNamespacePersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNamespacePersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除从实例
        /// </summary>
        /// <param name="req"><see cref="DeleteReplicationInstanceRequest"/></param>
        /// <returns><see cref="DeleteReplicationInstanceResponse"/></returns>
        public async Task<DeleteReplicationInstanceResponse> DeleteReplicationInstance(DeleteReplicationInstanceRequest req)
        {
             JsonResponseModel<DeleteReplicationInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteReplicationInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReplicationInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除从实例
        /// </summary>
        /// <param name="req"><see cref="DeleteReplicationInstanceRequest"/></param>
        /// <returns><see cref="DeleteReplicationInstanceResponse"/></returns>
        public DeleteReplicationInstanceResponse DeleteReplicationInstanceSync(DeleteReplicationInstanceRequest req)
        {
             JsonResponseModel<DeleteReplicationInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteReplicationInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReplicationInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除镜像仓库
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryRequest"/></param>
        /// <returns><see cref="DeleteRepositoryResponse"/></returns>
        public async Task<DeleteRepositoryResponse> DeleteRepository(DeleteRepositoryRequest req)
        {
             JsonResponseModel<DeleteRepositoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除镜像仓库
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryRequest"/></param>
        /// <returns><see cref="DeleteRepositoryResponse"/></returns>
        public DeleteRepositoryResponse DeleteRepositorySync(DeleteRepositoryRequest req)
        {
             JsonResponseModel<DeleteRepositoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于个人版镜像仓库中删除
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryPersonalRequest"/></param>
        /// <returns><see cref="DeleteRepositoryPersonalResponse"/></returns>
        public async Task<DeleteRepositoryPersonalResponse> DeleteRepositoryPersonal(DeleteRepositoryPersonalRequest req)
        {
             JsonResponseModel<DeleteRepositoryPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRepositoryPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRepositoryPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于个人版镜像仓库中删除
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryPersonalRequest"/></param>
        /// <returns><see cref="DeleteRepositoryPersonalResponse"/></returns>
        public DeleteRepositoryPersonalResponse DeleteRepositoryPersonalSync(DeleteRepositoryPersonalRequest req)
        {
             JsonResponseModel<DeleteRepositoryPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRepositoryPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRepositoryPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于企业版批量删除Repository Tag
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryTagsRequest"/></param>
        /// <returns><see cref="DeleteRepositoryTagsResponse"/></returns>
        public async Task<DeleteRepositoryTagsResponse> DeleteRepositoryTags(DeleteRepositoryTagsRequest req)
        {
             JsonResponseModel<DeleteRepositoryTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRepositoryTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRepositoryTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于企业版批量删除Repository Tag
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryTagsRequest"/></param>
        /// <returns><see cref="DeleteRepositoryTagsResponse"/></returns>
        public DeleteRepositoryTagsResponse DeleteRepositoryTagsSync(DeleteRepositoryTagsRequest req)
        {
             JsonResponseModel<DeleteRepositoryTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRepositoryTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRepositoryTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除实例公网访问白名单策略
        /// 
        /// 注意：当PolicyIndex和CidrBlock同时存在时，CidrBlock优先级更高
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public async Task<DeleteSecurityPolicyResponse> DeleteSecurityPolicy(DeleteSecurityPolicyRequest req)
        {
             JsonResponseModel<DeleteSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除实例公网访问白名单策略
        /// 
        /// 注意：当PolicyIndex和CidrBlock同时存在时，CidrBlock优先级更高
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public DeleteSecurityPolicyResponse DeleteSecurityPolicySync(DeleteSecurityPolicyRequest req)
        {
             JsonResponseModel<DeleteSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除服务级账号
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceAccountRequest"/></param>
        /// <returns><see cref="DeleteServiceAccountResponse"/></returns>
        public async Task<DeleteServiceAccountResponse> DeleteServiceAccount(DeleteServiceAccountRequest req)
        {
             JsonResponseModel<DeleteServiceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteServiceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除服务级账号
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceAccountRequest"/></param>
        /// <returns><see cref="DeleteServiceAccountResponse"/></returns>
        public DeleteServiceAccountResponse DeleteServiceAccountSync(DeleteServiceAccountRequest req)
        {
             JsonResponseModel<DeleteServiceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteServiceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除命名空间加签策略
        /// </summary>
        /// <param name="req"><see cref="DeleteSignaturePolicyRequest"/></param>
        /// <returns><see cref="DeleteSignaturePolicyResponse"/></returns>
        public async Task<DeleteSignaturePolicyResponse> DeleteSignaturePolicy(DeleteSignaturePolicyRequest req)
        {
             JsonResponseModel<DeleteSignaturePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSignaturePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSignaturePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除命名空间加签策略
        /// </summary>
        /// <param name="req"><see cref="DeleteSignaturePolicyRequest"/></param>
        /// <returns><see cref="DeleteSignaturePolicyResponse"/></returns>
        public DeleteSignaturePolicyResponse DeleteSignaturePolicySync(DeleteSignaturePolicyRequest req)
        {
             JsonResponseModel<DeleteSignaturePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSignaturePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSignaturePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除版本保留规则
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRetentionRuleRequest"/></param>
        /// <returns><see cref="DeleteTagRetentionRuleResponse"/></returns>
        public async Task<DeleteTagRetentionRuleResponse> DeleteTagRetentionRule(DeleteTagRetentionRuleRequest req)
        {
             JsonResponseModel<DeleteTagRetentionRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTagRetentionRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTagRetentionRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除版本保留规则
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRetentionRuleRequest"/></param>
        /// <returns><see cref="DeleteTagRetentionRuleResponse"/></returns>
        public DeleteTagRetentionRuleResponse DeleteTagRetentionRuleSync(DeleteTagRetentionRuleRequest req)
        {
             JsonResponseModel<DeleteTagRetentionRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTagRetentionRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTagRetentionRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除触发器
        /// </summary>
        /// <param name="req"><see cref="DeleteWebhookTriggerRequest"/></param>
        /// <returns><see cref="DeleteWebhookTriggerResponse"/></returns>
        public async Task<DeleteWebhookTriggerResponse> DeleteWebhookTrigger(DeleteWebhookTriggerRequest req)
        {
             JsonResponseModel<DeleteWebhookTriggerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWebhookTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWebhookTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除触发器
        /// </summary>
        /// <param name="req"><see cref="DeleteWebhookTriggerRequest"/></param>
        /// <returns><see cref="DeleteWebhookTriggerResponse"/></returns>
        public DeleteWebhookTriggerResponse DeleteWebhookTriggerSync(DeleteWebhookTriggerRequest req)
        {
             JsonResponseModel<DeleteWebhookTriggerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWebhookTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWebhookTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询应用更新触发器触发日志
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationTriggerLogPersonalRequest"/></param>
        /// <returns><see cref="DescribeApplicationTriggerLogPersonalResponse"/></returns>
        public async Task<DescribeApplicationTriggerLogPersonalResponse> DescribeApplicationTriggerLogPersonal(DescribeApplicationTriggerLogPersonalRequest req)
        {
             JsonResponseModel<DescribeApplicationTriggerLogPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationTriggerLogPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationTriggerLogPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询应用更新触发器触发日志
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationTriggerLogPersonalRequest"/></param>
        /// <returns><see cref="DescribeApplicationTriggerLogPersonalResponse"/></returns>
        public DescribeApplicationTriggerLogPersonalResponse DescribeApplicationTriggerLogPersonalSync(DescribeApplicationTriggerLogPersonalRequest req)
        {
             JsonResponseModel<DescribeApplicationTriggerLogPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationTriggerLogPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationTriggerLogPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询应用更新触发器
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationTriggerPersonalRequest"/></param>
        /// <returns><see cref="DescribeApplicationTriggerPersonalResponse"/></returns>
        public async Task<DescribeApplicationTriggerPersonalResponse> DescribeApplicationTriggerPersonal(DescribeApplicationTriggerPersonalRequest req)
        {
             JsonResponseModel<DescribeApplicationTriggerPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationTriggerPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationTriggerPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询应用更新触发器
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationTriggerPersonalRequest"/></param>
        /// <returns><see cref="DescribeApplicationTriggerPersonalResponse"/></returns>
        public DescribeApplicationTriggerPersonalResponse DescribeApplicationTriggerPersonalSync(DescribeApplicationTriggerPersonalRequest req)
        {
             JsonResponseModel<DescribeApplicationTriggerPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationTriggerPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationTriggerPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在企业版中返回Chart的下载信息
        /// </summary>
        /// <param name="req"><see cref="DescribeChartDownloadInfoRequest"/></param>
        /// <returns><see cref="DescribeChartDownloadInfoResponse"/></returns>
        public async Task<DescribeChartDownloadInfoResponse> DescribeChartDownloadInfo(DescribeChartDownloadInfoRequest req)
        {
             JsonResponseModel<DescribeChartDownloadInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeChartDownloadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChartDownloadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在企业版中返回Chart的下载信息
        /// </summary>
        /// <param name="req"><see cref="DescribeChartDownloadInfoRequest"/></param>
        /// <returns><see cref="DescribeChartDownloadInfoResponse"/></returns>
        public DescribeChartDownloadInfoResponse DescribeChartDownloadInfoSync(DescribeChartDownloadInfoRequest req)
        {
             JsonResponseModel<DescribeChartDownloadInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeChartDownloadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChartDownloadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询自定义账号
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomAccountsRequest"/></param>
        /// <returns><see cref="DescribeCustomAccountsResponse"/></returns>
        public async Task<DescribeCustomAccountsResponse> DescribeCustomAccounts(DescribeCustomAccountsRequest req)
        {
             JsonResponseModel<DescribeCustomAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询自定义账号
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomAccountsRequest"/></param>
        /// <returns><see cref="DescribeCustomAccountsResponse"/></returns>
        public DescribeCustomAccountsResponse DescribeCustomAccountsSync(DescribeCustomAccountsRequest req)
        {
             JsonResponseModel<DescribeCustomAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例公网访问入口状态
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeExternalEndpointStatusResponse"/></returns>
        public async Task<DescribeExternalEndpointStatusResponse> DescribeExternalEndpointStatus(DescribeExternalEndpointStatusRequest req)
        {
             JsonResponseModel<DescribeExternalEndpointStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExternalEndpointStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExternalEndpointStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例公网访问入口状态
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeExternalEndpointStatusResponse"/></returns>
        public DescribeExternalEndpointStatusResponse DescribeExternalEndpointStatusSync(DescribeExternalEndpointStatusRequest req)
        {
             JsonResponseModel<DescribeExternalEndpointStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExternalEndpointStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExternalEndpointStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询个人收藏仓库
        /// </summary>
        /// <param name="req"><see cref="DescribeFavorRepositoryPersonalRequest"/></param>
        /// <returns><see cref="DescribeFavorRepositoryPersonalResponse"/></returns>
        public async Task<DescribeFavorRepositoryPersonalResponse> DescribeFavorRepositoryPersonal(DescribeFavorRepositoryPersonalRequest req)
        {
             JsonResponseModel<DescribeFavorRepositoryPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFavorRepositoryPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFavorRepositoryPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询个人收藏仓库
        /// </summary>
        /// <param name="req"><see cref="DescribeFavorRepositoryPersonalRequest"/></param>
        /// <returns><see cref="DescribeFavorRepositoryPersonalResponse"/></returns>
        public DescribeFavorRepositoryPersonalResponse DescribeFavorRepositoryPersonalSync(DescribeFavorRepositoryPersonalRequest req)
        {
             JsonResponseModel<DescribeFavorRepositoryPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFavorRepositoryPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFavorRepositoryPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GC 最近10条历史
        /// </summary>
        /// <param name="req"><see cref="DescribeGCJobsRequest"/></param>
        /// <returns><see cref="DescribeGCJobsResponse"/></returns>
        public async Task<DescribeGCJobsResponse> DescribeGCJobs(DescribeGCJobsRequest req)
        {
             JsonResponseModel<DescribeGCJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGCJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGCJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GC 最近10条历史
        /// </summary>
        /// <param name="req"><see cref="DescribeGCJobsRequest"/></param>
        /// <returns><see cref="DescribeGCJobsResponse"/></returns>
        public DescribeGCJobsResponse DescribeGCJobsSync(DescribeGCJobsRequest req)
        {
             JsonResponseModel<DescribeGCJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGCJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGCJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询镜像加速服务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAccelerateServiceRequest"/></param>
        /// <returns><see cref="DescribeImageAccelerateServiceResponse"/></returns>
        public async Task<DescribeImageAccelerateServiceResponse> DescribeImageAccelerateService(DescribeImageAccelerateServiceRequest req)
        {
             JsonResponseModel<DescribeImageAccelerateServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageAccelerateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageAccelerateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询镜像加速服务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAccelerateServiceRequest"/></param>
        /// <returns><see cref="DescribeImageAccelerateServiceResponse"/></returns>
        public DescribeImageAccelerateServiceResponse DescribeImageAccelerateServiceSync(DescribeImageAccelerateServiceRequest req)
        {
             JsonResponseModel<DescribeImageAccelerateServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageAccelerateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageAccelerateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在个人版中查询与指定tag镜像内容相同的tag列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageFilterPersonalRequest"/></param>
        /// <returns><see cref="DescribeImageFilterPersonalResponse"/></returns>
        public async Task<DescribeImageFilterPersonalResponse> DescribeImageFilterPersonal(DescribeImageFilterPersonalRequest req)
        {
             JsonResponseModel<DescribeImageFilterPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageFilterPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageFilterPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在个人版中查询与指定tag镜像内容相同的tag列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageFilterPersonalRequest"/></param>
        /// <returns><see cref="DescribeImageFilterPersonalResponse"/></returns>
        public DescribeImageFilterPersonalResponse DescribeImageFilterPersonalSync(DescribeImageFilterPersonalRequest req)
        {
             JsonResponseModel<DescribeImageFilterPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageFilterPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageFilterPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取个人版全局镜像版本自动清理策略
        /// </summary>
        /// <param name="req"><see cref="DescribeImageLifecycleGlobalPersonalRequest"/></param>
        /// <returns><see cref="DescribeImageLifecycleGlobalPersonalResponse"/></returns>
        public async Task<DescribeImageLifecycleGlobalPersonalResponse> DescribeImageLifecycleGlobalPersonal(DescribeImageLifecycleGlobalPersonalRequest req)
        {
             JsonResponseModel<DescribeImageLifecycleGlobalPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageLifecycleGlobalPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageLifecycleGlobalPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取个人版全局镜像版本自动清理策略
        /// </summary>
        /// <param name="req"><see cref="DescribeImageLifecycleGlobalPersonalRequest"/></param>
        /// <returns><see cref="DescribeImageLifecycleGlobalPersonalResponse"/></returns>
        public DescribeImageLifecycleGlobalPersonalResponse DescribeImageLifecycleGlobalPersonalSync(DescribeImageLifecycleGlobalPersonalRequest req)
        {
             JsonResponseModel<DescribeImageLifecycleGlobalPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageLifecycleGlobalPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageLifecycleGlobalPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取个人版仓库中自动清理策略
        /// </summary>
        /// <param name="req"><see cref="DescribeImageLifecyclePersonalRequest"/></param>
        /// <returns><see cref="DescribeImageLifecyclePersonalResponse"/></returns>
        public async Task<DescribeImageLifecyclePersonalResponse> DescribeImageLifecyclePersonal(DescribeImageLifecyclePersonalRequest req)
        {
             JsonResponseModel<DescribeImageLifecyclePersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageLifecyclePersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageLifecyclePersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取个人版仓库中自动清理策略
        /// </summary>
        /// <param name="req"><see cref="DescribeImageLifecyclePersonalRequest"/></param>
        /// <returns><see cref="DescribeImageLifecyclePersonalResponse"/></returns>
        public DescribeImageLifecyclePersonalResponse DescribeImageLifecyclePersonalSync(DescribeImageLifecyclePersonalRequest req)
        {
             JsonResponseModel<DescribeImageLifecyclePersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageLifecyclePersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageLifecyclePersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器镜像Manifest信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImageManifestsRequest"/></param>
        /// <returns><see cref="DescribeImageManifestsResponse"/></returns>
        public async Task<DescribeImageManifestsResponse> DescribeImageManifests(DescribeImageManifestsRequest req)
        {
             JsonResponseModel<DescribeImageManifestsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageManifests");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageManifestsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器镜像Manifest信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImageManifestsRequest"/></param>
        /// <returns><see cref="DescribeImageManifestsResponse"/></returns>
        public DescribeImageManifestsResponse DescribeImageManifestsSync(DescribeImageManifestsRequest req)
        {
             JsonResponseModel<DescribeImageManifestsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageManifests");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageManifestsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取个人版镜像仓库tag列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImagePersonalRequest"/></param>
        /// <returns><see cref="DescribeImagePersonalResponse"/></returns>
        public async Task<DescribeImagePersonalResponse> DescribeImagePersonal(DescribeImagePersonalRequest req)
        {
             JsonResponseModel<DescribeImagePersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImagePersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImagePersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取个人版镜像仓库tag列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImagePersonalRequest"/></param>
        /// <returns><see cref="DescribeImagePersonalResponse"/></returns>
        public DescribeImagePersonalResponse DescribeImagePersonalSync(DescribeImagePersonalRequest req)
        {
             JsonResponseModel<DescribeImagePersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImagePersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImagePersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询镜像版本列表或指定容器镜像信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public async Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest req)
        {
             JsonResponseModel<DescribeImagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询镜像版本列表或指定容器镜像信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public DescribeImagesResponse DescribeImagesSync(DescribeImagesRequest req)
        {
             JsonResponseModel<DescribeImagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出镜像不可变规则
        /// </summary>
        /// <param name="req"><see cref="DescribeImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DescribeImmutableTagRulesResponse"/></returns>
        public async Task<DescribeImmutableTagRulesResponse> DescribeImmutableTagRules(DescribeImmutableTagRulesRequest req)
        {
             JsonResponseModel<DescribeImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出镜像不可变规则
        /// </summary>
        /// <param name="req"><see cref="DescribeImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DescribeImmutableTagRulesResponse"/></returns>
        public DescribeImmutableTagRulesResponse DescribeImmutableTagRulesSync(DescribeImmutableTagRulesRequest req)
        {
             JsonResponseModel<DescribeImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询所有实例命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeInstanceAllNamespacesResponse"/></returns>
        public async Task<DescribeInstanceAllNamespacesResponse> DescribeInstanceAllNamespaces(DescribeInstanceAllNamespacesRequest req)
        {
             JsonResponseModel<DescribeInstanceAllNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceAllNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAllNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询所有实例命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeInstanceAllNamespacesResponse"/></returns>
        public DescribeInstanceAllNamespacesResponse DescribeInstanceAllNamespacesSync(DescribeInstanceAllNamespacesRequest req)
        {
             JsonResponseModel<DescribeInstanceAllNamespacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceAllNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAllNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例自定义域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="DescribeInstanceCustomizedDomainResponse"/></returns>
        public async Task<DescribeInstanceCustomizedDomainResponse> DescribeInstanceCustomizedDomain(DescribeInstanceCustomizedDomainRequest req)
        {
             JsonResponseModel<DescribeInstanceCustomizedDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceCustomizedDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceCustomizedDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例自定义域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="DescribeInstanceCustomizedDomainResponse"/></returns>
        public DescribeInstanceCustomizedDomainResponse DescribeInstanceCustomizedDomainSync(DescribeInstanceCustomizedDomainRequest req)
        {
             JsonResponseModel<DescribeInstanceCustomizedDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceCustomizedDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceCustomizedDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例当前状态以及过程信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStatusRequest"/></param>
        /// <returns><see cref="DescribeInstanceStatusResponse"/></returns>
        public async Task<DescribeInstanceStatusResponse> DescribeInstanceStatus(DescribeInstanceStatusRequest req)
        {
             JsonResponseModel<DescribeInstanceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例当前状态以及过程信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStatusRequest"/></param>
        /// <returns><see cref="DescribeInstanceStatusResponse"/></returns>
        public DescribeInstanceStatusResponse DescribeInstanceStatusSync(DescribeInstanceStatusRequest req)
        {
             JsonResponseModel<DescribeInstanceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询长期访问凭证信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTokenRequest"/></param>
        /// <returns><see cref="DescribeInstanceTokenResponse"/></returns>
        public async Task<DescribeInstanceTokenResponse> DescribeInstanceToken(DescribeInstanceTokenRequest req)
        {
             JsonResponseModel<DescribeInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询长期访问凭证信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTokenRequest"/></param>
        /// <returns><see cref="DescribeInstanceTokenResponse"/></returns>
        public DescribeInstanceTokenResponse DescribeInstanceTokenSync(DescribeInstanceTokenRequest req)
        {
             JsonResponseModel<DescribeInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例信息
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
        /// 查询实例信息
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
        /// 批量查询vpc是否已经添加私有域名解析
        /// </summary>
        /// <param name="req"><see cref="DescribeInternalEndpointDnsStatusRequest"/></param>
        /// <returns><see cref="DescribeInternalEndpointDnsStatusResponse"/></returns>
        public async Task<DescribeInternalEndpointDnsStatusResponse> DescribeInternalEndpointDnsStatus(DescribeInternalEndpointDnsStatusRequest req)
        {
             JsonResponseModel<DescribeInternalEndpointDnsStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInternalEndpointDnsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInternalEndpointDnsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量查询vpc是否已经添加私有域名解析
        /// </summary>
        /// <param name="req"><see cref="DescribeInternalEndpointDnsStatusRequest"/></param>
        /// <returns><see cref="DescribeInternalEndpointDnsStatusResponse"/></returns>
        public DescribeInternalEndpointDnsStatusResponse DescribeInternalEndpointDnsStatusSync(DescribeInternalEndpointDnsStatusRequest req)
        {
             JsonResponseModel<DescribeInternalEndpointDnsStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInternalEndpointDnsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInternalEndpointDnsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例内网访问VPC链接
        /// </summary>
        /// <param name="req"><see cref="DescribeInternalEndpointsRequest"/></param>
        /// <returns><see cref="DescribeInternalEndpointsResponse"/></returns>
        public async Task<DescribeInternalEndpointsResponse> DescribeInternalEndpoints(DescribeInternalEndpointsRequest req)
        {
             JsonResponseModel<DescribeInternalEndpointsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInternalEndpoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInternalEndpointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例内网访问VPC链接
        /// </summary>
        /// <param name="req"><see cref="DescribeInternalEndpointsRequest"/></param>
        /// <returns><see cref="DescribeInternalEndpointsResponse"/></returns>
        public DescribeInternalEndpointsResponse DescribeInternalEndpointsSync(DescribeInternalEndpointsRequest req)
        {
             JsonResponseModel<DescribeInternalEndpointsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInternalEndpoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInternalEndpointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询个人版命名空间信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacePersonalRequest"/></param>
        /// <returns><see cref="DescribeNamespacePersonalResponse"/></returns>
        public async Task<DescribeNamespacePersonalResponse> DescribeNamespacePersonal(DescribeNamespacePersonalRequest req)
        {
             JsonResponseModel<DescribeNamespacePersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNamespacePersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNamespacePersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询个人版命名空间信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacePersonalRequest"/></param>
        /// <returns><see cref="DescribeNamespacePersonalResponse"/></returns>
        public DescribeNamespacePersonalResponse DescribeNamespacePersonalSync(DescribeNamespacePersonalRequest req)
        {
             JsonResponseModel<DescribeNamespacePersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNamespacePersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNamespacePersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询命名空间列表或指定命名空间信息
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
        /// 查询命名空间列表或指定命名空间信息
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
        /// 用于在TCR中获取可用区域
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public async Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在TCR中获取可用区域
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询创建从实例任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceCreateTasksRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceCreateTasksResponse"/></returns>
        public async Task<DescribeReplicationInstanceCreateTasksResponse> DescribeReplicationInstanceCreateTasks(DescribeReplicationInstanceCreateTasksRequest req)
        {
             JsonResponseModel<DescribeReplicationInstanceCreateTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReplicationInstanceCreateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstanceCreateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询创建从实例任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceCreateTasksRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceCreateTasksResponse"/></returns>
        public DescribeReplicationInstanceCreateTasksResponse DescribeReplicationInstanceCreateTasksSync(DescribeReplicationInstanceCreateTasksRequest req)
        {
             JsonResponseModel<DescribeReplicationInstanceCreateTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReplicationInstanceCreateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstanceCreateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询从实例同步状态
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceSyncStatusRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceSyncStatusResponse"/></returns>
        public async Task<DescribeReplicationInstanceSyncStatusResponse> DescribeReplicationInstanceSyncStatus(DescribeReplicationInstanceSyncStatusRequest req)
        {
             JsonResponseModel<DescribeReplicationInstanceSyncStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReplicationInstanceSyncStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstanceSyncStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询从实例同步状态
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceSyncStatusRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceSyncStatusResponse"/></returns>
        public DescribeReplicationInstanceSyncStatusResponse DescribeReplicationInstanceSyncStatusSync(DescribeReplicationInstanceSyncStatusRequest req)
        {
             JsonResponseModel<DescribeReplicationInstanceSyncStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReplicationInstanceSyncStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstanceSyncStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询从实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstancesRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstancesResponse"/></returns>
        public async Task<DescribeReplicationInstancesResponse> DescribeReplicationInstances(DescribeReplicationInstancesRequest req)
        {
             JsonResponseModel<DescribeReplicationInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReplicationInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询从实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstancesRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstancesResponse"/></returns>
        public DescribeReplicationInstancesResponse DescribeReplicationInstancesSync(DescribeReplicationInstancesRequest req)
        {
             JsonResponseModel<DescribeReplicationInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReplicationInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询镜像仓库列表或指定镜像仓库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoriesRequest"/></param>
        /// <returns><see cref="DescribeRepositoriesResponse"/></returns>
        public async Task<DescribeRepositoriesResponse> DescribeRepositories(DescribeRepositoriesRequest req)
        {
             JsonResponseModel<DescribeRepositoriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRepositories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepositoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询镜像仓库列表或指定镜像仓库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoriesRequest"/></param>
        /// <returns><see cref="DescribeRepositoriesResponse"/></returns>
        public DescribeRepositoriesResponse DescribeRepositoriesSync(DescribeRepositoriesRequest req)
        {
             JsonResponseModel<DescribeRepositoriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRepositories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepositoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在个人版镜像仓库中，获取满足输入搜索条件的用户镜像仓库
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryFilterPersonalRequest"/></param>
        /// <returns><see cref="DescribeRepositoryFilterPersonalResponse"/></returns>
        public async Task<DescribeRepositoryFilterPersonalResponse> DescribeRepositoryFilterPersonal(DescribeRepositoryFilterPersonalRequest req)
        {
             JsonResponseModel<DescribeRepositoryFilterPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRepositoryFilterPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepositoryFilterPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在个人版镜像仓库中，获取满足输入搜索条件的用户镜像仓库
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryFilterPersonalRequest"/></param>
        /// <returns><see cref="DescribeRepositoryFilterPersonalResponse"/></returns>
        public DescribeRepositoryFilterPersonalResponse DescribeRepositoryFilterPersonalSync(DescribeRepositoryFilterPersonalRequest req)
        {
             JsonResponseModel<DescribeRepositoryFilterPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRepositoryFilterPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepositoryFilterPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在个人版中获取用户全部的镜像仓库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryOwnerPersonalRequest"/></param>
        /// <returns><see cref="DescribeRepositoryOwnerPersonalResponse"/></returns>
        public async Task<DescribeRepositoryOwnerPersonalResponse> DescribeRepositoryOwnerPersonal(DescribeRepositoryOwnerPersonalRequest req)
        {
             JsonResponseModel<DescribeRepositoryOwnerPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRepositoryOwnerPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepositoryOwnerPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在个人版中获取用户全部的镜像仓库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryOwnerPersonalRequest"/></param>
        /// <returns><see cref="DescribeRepositoryOwnerPersonalResponse"/></returns>
        public DescribeRepositoryOwnerPersonalResponse DescribeRepositoryOwnerPersonalSync(DescribeRepositoryOwnerPersonalRequest req)
        {
             JsonResponseModel<DescribeRepositoryOwnerPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRepositoryOwnerPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepositoryOwnerPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询个人版仓库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryPersonalRequest"/></param>
        /// <returns><see cref="DescribeRepositoryPersonalResponse"/></returns>
        public async Task<DescribeRepositoryPersonalResponse> DescribeRepositoryPersonal(DescribeRepositoryPersonalRequest req)
        {
             JsonResponseModel<DescribeRepositoryPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRepositoryPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepositoryPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询个人版仓库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryPersonalRequest"/></param>
        /// <returns><see cref="DescribeRepositoryPersonalResponse"/></returns>
        public DescribeRepositoryPersonalResponse DescribeRepositoryPersonalSync(DescribeRepositoryPersonalRequest req)
        {
             JsonResponseModel<DescribeRepositoryPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRepositoryPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepositoryPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例公网访问白名单策略
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPoliciesResponse"/></returns>
        public async Task<DescribeSecurityPoliciesResponse> DescribeSecurityPolicies(DescribeSecurityPoliciesRequest req)
        {
             JsonResponseModel<DescribeSecurityPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例公网访问白名单策略
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPoliciesResponse"/></returns>
        public DescribeSecurityPoliciesResponse DescribeSecurityPoliciesSync(DescribeSecurityPoliciesRequest req)
        {
             JsonResponseModel<DescribeSecurityPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务级账号
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceAccountsRequest"/></param>
        /// <returns><see cref="DescribeServiceAccountsResponse"/></returns>
        public async Task<DescribeServiceAccountsResponse> DescribeServiceAccounts(DescribeServiceAccountsRequest req)
        {
             JsonResponseModel<DescribeServiceAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务级账号
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceAccountsRequest"/></param>
        /// <returns><see cref="DescribeServiceAccountsResponse"/></returns>
        public DescribeServiceAccountsResponse DescribeServiceAccountsSync(DescribeServiceAccountsRequest req)
        {
             JsonResponseModel<DescribeServiceAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询版本保留执行记录
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionExecutionRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionExecutionResponse"/></returns>
        public async Task<DescribeTagRetentionExecutionResponse> DescribeTagRetentionExecution(DescribeTagRetentionExecutionRequest req)
        {
             JsonResponseModel<DescribeTagRetentionExecutionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagRetentionExecution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagRetentionExecutionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询版本保留执行记录
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionExecutionRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionExecutionResponse"/></returns>
        public DescribeTagRetentionExecutionResponse DescribeTagRetentionExecutionSync(DescribeTagRetentionExecutionRequest req)
        {
             JsonResponseModel<DescribeTagRetentionExecutionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTagRetentionExecution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagRetentionExecutionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询版本保留执行任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionExecutionTaskRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionExecutionTaskResponse"/></returns>
        public async Task<DescribeTagRetentionExecutionTaskResponse> DescribeTagRetentionExecutionTask(DescribeTagRetentionExecutionTaskRequest req)
        {
             JsonResponseModel<DescribeTagRetentionExecutionTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagRetentionExecutionTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagRetentionExecutionTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询版本保留执行任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionExecutionTaskRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionExecutionTaskResponse"/></returns>
        public DescribeTagRetentionExecutionTaskResponse DescribeTagRetentionExecutionTaskSync(DescribeTagRetentionExecutionTaskRequest req)
        {
             JsonResponseModel<DescribeTagRetentionExecutionTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTagRetentionExecutionTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagRetentionExecutionTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询版本保留规则
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionRulesRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionRulesResponse"/></returns>
        public async Task<DescribeTagRetentionRulesResponse> DescribeTagRetentionRules(DescribeTagRetentionRulesRequest req)
        {
             JsonResponseModel<DescribeTagRetentionRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagRetentionRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagRetentionRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询版本保留规则
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionRulesRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionRulesResponse"/></returns>
        public DescribeTagRetentionRulesResponse DescribeTagRetentionRulesSync(DescribeTagRetentionRulesRequest req)
        {
             JsonResponseModel<DescribeTagRetentionRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTagRetentionRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagRetentionRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询个人用户配额
        /// </summary>
        /// <param name="req"><see cref="DescribeUserQuotaPersonalRequest"/></param>
        /// <returns><see cref="DescribeUserQuotaPersonalResponse"/></returns>
        public async Task<DescribeUserQuotaPersonalResponse> DescribeUserQuotaPersonal(DescribeUserQuotaPersonalRequest req)
        {
             JsonResponseModel<DescribeUserQuotaPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserQuotaPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserQuotaPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询个人用户配额
        /// </summary>
        /// <param name="req"><see cref="DescribeUserQuotaPersonalRequest"/></param>
        /// <returns><see cref="DescribeUserQuotaPersonalResponse"/></returns>
        public DescribeUserQuotaPersonalResponse DescribeUserQuotaPersonalSync(DescribeUserQuotaPersonalRequest req)
        {
             JsonResponseModel<DescribeUserQuotaPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserQuotaPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserQuotaPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询触发器
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookTriggerRequest"/></param>
        /// <returns><see cref="DescribeWebhookTriggerResponse"/></returns>
        public async Task<DescribeWebhookTriggerResponse> DescribeWebhookTrigger(DescribeWebhookTriggerRequest req)
        {
             JsonResponseModel<DescribeWebhookTriggerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebhookTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebhookTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询触发器
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookTriggerRequest"/></param>
        /// <returns><see cref="DescribeWebhookTriggerResponse"/></returns>
        public DescribeWebhookTriggerResponse DescribeWebhookTriggerSync(DescribeWebhookTriggerRequest req)
        {
             JsonResponseModel<DescribeWebhookTriggerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebhookTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebhookTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取触发器日志
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookTriggerLogRequest"/></param>
        /// <returns><see cref="DescribeWebhookTriggerLogResponse"/></returns>
        public async Task<DescribeWebhookTriggerLogResponse> DescribeWebhookTriggerLog(DescribeWebhookTriggerLogRequest req)
        {
             JsonResponseModel<DescribeWebhookTriggerLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebhookTriggerLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebhookTriggerLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取触发器日志
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookTriggerLogRequest"/></param>
        /// <returns><see cref="DescribeWebhookTriggerLogResponse"/></returns>
        public DescribeWebhookTriggerLogResponse DescribeWebhookTriggerLogSync(DescribeWebhookTriggerLogRequest req)
        {
             JsonResponseModel<DescribeWebhookTriggerLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebhookTriggerLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebhookTriggerLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在TCR中下载helm chart
        /// </summary>
        /// <param name="req"><see cref="DownloadHelmChartRequest"/></param>
        /// <returns><see cref="DownloadHelmChartResponse"/></returns>
        public async Task<DownloadHelmChartResponse> DownloadHelmChart(DownloadHelmChartRequest req)
        {
             JsonResponseModel<DownloadHelmChartResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadHelmChart");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadHelmChartResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在TCR中下载helm chart
        /// </summary>
        /// <param name="req"><see cref="DownloadHelmChartRequest"/></param>
        /// <returns><see cref="DownloadHelmChartResponse"/></returns>
        public DownloadHelmChartResponse DownloadHelmChartSync(DownloadHelmChartRequest req)
        {
             JsonResponseModel<DownloadHelmChartResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadHelmChart");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadHelmChartResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在个人版镜像仓库中复制镜像版本
        /// </summary>
        /// <param name="req"><see cref="DuplicateImagePersonalRequest"/></param>
        /// <returns><see cref="DuplicateImagePersonalResponse"/></returns>
        public async Task<DuplicateImagePersonalResponse> DuplicateImagePersonal(DuplicateImagePersonalRequest req)
        {
             JsonResponseModel<DuplicateImagePersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DuplicateImagePersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DuplicateImagePersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在个人版镜像仓库中复制镜像版本
        /// </summary>
        /// <param name="req"><see cref="DuplicateImagePersonalRequest"/></param>
        /// <returns><see cref="DuplicateImagePersonalResponse"/></returns>
        public DuplicateImagePersonalResponse DuplicateImagePersonalSync(DuplicateImagePersonalRequest req)
        {
             JsonResponseModel<DuplicateImagePersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DuplicateImagePersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DuplicateImagePersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 管理实例公网访问
        /// </summary>
        /// <param name="req"><see cref="ManageExternalEndpointRequest"/></param>
        /// <returns><see cref="ManageExternalEndpointResponse"/></returns>
        public async Task<ManageExternalEndpointResponse> ManageExternalEndpoint(ManageExternalEndpointRequest req)
        {
             JsonResponseModel<ManageExternalEndpointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManageExternalEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageExternalEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 管理实例公网访问
        /// </summary>
        /// <param name="req"><see cref="ManageExternalEndpointRequest"/></param>
        /// <returns><see cref="ManageExternalEndpointResponse"/></returns>
        public ManageExternalEndpointResponse ManageExternalEndpointSync(ManageExternalEndpointRequest req)
        {
             JsonResponseModel<ManageExternalEndpointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManageExternalEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageExternalEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于设置个人版全局镜像版本自动清理策略
        /// </summary>
        /// <param name="req"><see cref="ManageImageLifecycleGlobalPersonalRequest"/></param>
        /// <returns><see cref="ManageImageLifecycleGlobalPersonalResponse"/></returns>
        public async Task<ManageImageLifecycleGlobalPersonalResponse> ManageImageLifecycleGlobalPersonal(ManageImageLifecycleGlobalPersonalRequest req)
        {
             JsonResponseModel<ManageImageLifecycleGlobalPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManageImageLifecycleGlobalPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageImageLifecycleGlobalPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于设置个人版全局镜像版本自动清理策略
        /// </summary>
        /// <param name="req"><see cref="ManageImageLifecycleGlobalPersonalRequest"/></param>
        /// <returns><see cref="ManageImageLifecycleGlobalPersonalResponse"/></returns>
        public ManageImageLifecycleGlobalPersonalResponse ManageImageLifecycleGlobalPersonalSync(ManageImageLifecycleGlobalPersonalRequest req)
        {
             JsonResponseModel<ManageImageLifecycleGlobalPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManageImageLifecycleGlobalPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageImageLifecycleGlobalPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 管理实例内网访问VPC链接
        /// </summary>
        /// <param name="req"><see cref="ManageInternalEndpointRequest"/></param>
        /// <returns><see cref="ManageInternalEndpointResponse"/></returns>
        public async Task<ManageInternalEndpointResponse> ManageInternalEndpoint(ManageInternalEndpointRequest req)
        {
             JsonResponseModel<ManageInternalEndpointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManageInternalEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageInternalEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 管理实例内网访问VPC链接
        /// </summary>
        /// <param name="req"><see cref="ManageInternalEndpointRequest"/></param>
        /// <returns><see cref="ManageInternalEndpointResponse"/></returns>
        public ManageInternalEndpointResponse ManageInternalEndpointSync(ManageInternalEndpointRequest req)
        {
             JsonResponseModel<ManageInternalEndpointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManageInternalEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageInternalEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 管理实例同步
        /// </summary>
        /// <param name="req"><see cref="ManageReplicationRequest"/></param>
        /// <returns><see cref="ManageReplicationResponse"/></returns>
        public async Task<ManageReplicationResponse> ManageReplication(ManageReplicationRequest req)
        {
             JsonResponseModel<ManageReplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManageReplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageReplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 管理实例同步
        /// </summary>
        /// <param name="req"><see cref="ManageReplicationRequest"/></param>
        /// <returns><see cref="ManageReplicationResponse"/></returns>
        public ManageReplicationResponse ManageReplicationSync(ManageReplicationRequest req)
        {
             JsonResponseModel<ManageReplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManageReplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageReplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改应用更新触发器
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationTriggerPersonalRequest"/></param>
        /// <returns><see cref="ModifyApplicationTriggerPersonalResponse"/></returns>
        public async Task<ModifyApplicationTriggerPersonalResponse> ModifyApplicationTriggerPersonal(ModifyApplicationTriggerPersonalRequest req)
        {
             JsonResponseModel<ModifyApplicationTriggerPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplicationTriggerPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationTriggerPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改应用更新触发器
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationTriggerPersonalRequest"/></param>
        /// <returns><see cref="ModifyApplicationTriggerPersonalResponse"/></returns>
        public ModifyApplicationTriggerPersonalResponse ModifyApplicationTriggerPersonalSync(ModifyApplicationTriggerPersonalRequest req)
        {
             JsonResponseModel<ModifyApplicationTriggerPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplicationTriggerPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationTriggerPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新自定义账户
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomAccountRequest"/></param>
        /// <returns><see cref="ModifyCustomAccountResponse"/></returns>
        public async Task<ModifyCustomAccountResponse> ModifyCustomAccount(ModifyCustomAccountRequest req)
        {
             JsonResponseModel<ModifyCustomAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新自定义账户
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomAccountRequest"/></param>
        /// <returns><see cref="ModifyCustomAccountResponse"/></returns>
        public ModifyCustomAccountResponse ModifyCustomAccountSync(ModifyCustomAccountRequest req)
        {
             JsonResponseModel<ModifyCustomAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCustomAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新镜像不可变规则
        /// </summary>
        /// <param name="req"><see cref="ModifyImmutableTagRulesRequest"/></param>
        /// <returns><see cref="ModifyImmutableTagRulesResponse"/></returns>
        public async Task<ModifyImmutableTagRulesResponse> ModifyImmutableTagRules(ModifyImmutableTagRulesRequest req)
        {
             JsonResponseModel<ModifyImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新镜像不可变规则
        /// </summary>
        /// <param name="req"><see cref="ModifyImmutableTagRulesRequest"/></param>
        /// <returns><see cref="ModifyImmutableTagRulesResponse"/></returns>
        public ModifyImmutableTagRulesResponse ModifyImmutableTagRulesSync(ModifyImmutableTagRulesRequest req)
        {
             JsonResponseModel<ModifyImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新实例信息
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public async Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新实例信息
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新实例内指定长期访问凭证的启用状态
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceTokenRequest"/></param>
        /// <returns><see cref="ModifyInstanceTokenResponse"/></returns>
        public async Task<ModifyInstanceTokenResponse> ModifyInstanceToken(ModifyInstanceTokenRequest req)
        {
             JsonResponseModel<ModifyInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新实例内指定长期访问凭证的启用状态
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceTokenRequest"/></param>
        /// <returns><see cref="ModifyInstanceTokenResponse"/></returns>
        public ModifyInstanceTokenResponse ModifyInstanceTokenSync(ModifyInstanceTokenRequest req)
        {
             JsonResponseModel<ModifyInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新命名空间信息
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
        /// 更新命名空间信息
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
        /// 更新镜像仓库信息，可修改仓库描述信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRepositoryRequest"/></param>
        /// <returns><see cref="ModifyRepositoryResponse"/></returns>
        public async Task<ModifyRepositoryResponse> ModifyRepository(ModifyRepositoryRequest req)
        {
             JsonResponseModel<ModifyRepositoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新镜像仓库信息，可修改仓库描述信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRepositoryRequest"/></param>
        /// <returns><see cref="ModifyRepositoryResponse"/></returns>
        public ModifyRepositoryResponse ModifyRepositorySync(ModifyRepositoryRequest req)
        {
             JsonResponseModel<ModifyRepositoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于更新个人版镜像仓库的访问属性
        /// </summary>
        /// <param name="req"><see cref="ModifyRepositoryAccessPersonalRequest"/></param>
        /// <returns><see cref="ModifyRepositoryAccessPersonalResponse"/></returns>
        public async Task<ModifyRepositoryAccessPersonalResponse> ModifyRepositoryAccessPersonal(ModifyRepositoryAccessPersonalRequest req)
        {
             JsonResponseModel<ModifyRepositoryAccessPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRepositoryAccessPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRepositoryAccessPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于更新个人版镜像仓库的访问属性
        /// </summary>
        /// <param name="req"><see cref="ModifyRepositoryAccessPersonalRequest"/></param>
        /// <returns><see cref="ModifyRepositoryAccessPersonalResponse"/></returns>
        public ModifyRepositoryAccessPersonalResponse ModifyRepositoryAccessPersonalSync(ModifyRepositoryAccessPersonalRequest req)
        {
             JsonResponseModel<ModifyRepositoryAccessPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRepositoryAccessPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRepositoryAccessPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在个人版镜像仓库中更新容器镜像描述
        /// </summary>
        /// <param name="req"><see cref="ModifyRepositoryInfoPersonalRequest"/></param>
        /// <returns><see cref="ModifyRepositoryInfoPersonalResponse"/></returns>
        public async Task<ModifyRepositoryInfoPersonalResponse> ModifyRepositoryInfoPersonal(ModifyRepositoryInfoPersonalRequest req)
        {
             JsonResponseModel<ModifyRepositoryInfoPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRepositoryInfoPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRepositoryInfoPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在个人版镜像仓库中更新容器镜像描述
        /// </summary>
        /// <param name="req"><see cref="ModifyRepositoryInfoPersonalRequest"/></param>
        /// <returns><see cref="ModifyRepositoryInfoPersonalResponse"/></returns>
        public ModifyRepositoryInfoPersonalResponse ModifyRepositoryInfoPersonalSync(ModifyRepositoryInfoPersonalRequest req)
        {
             JsonResponseModel<ModifyRepositoryInfoPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRepositoryInfoPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRepositoryInfoPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新实例公网访问白名单
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public async Task<ModifySecurityPolicyResponse> ModifySecurityPolicy(ModifySecurityPolicyRequest req)
        {
             JsonResponseModel<ModifySecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新实例公网访问白名单
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public ModifySecurityPolicyResponse ModifySecurityPolicySync(ModifySecurityPolicyRequest req)
        {
             JsonResponseModel<ModifySecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新服务级账号
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceAccountRequest"/></param>
        /// <returns><see cref="ModifyServiceAccountResponse"/></returns>
        public async Task<ModifyServiceAccountResponse> ModifyServiceAccount(ModifyServiceAccountRequest req)
        {
             JsonResponseModel<ModifyServiceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyServiceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新服务级账号
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceAccountRequest"/></param>
        /// <returns><see cref="ModifyServiceAccountResponse"/></returns>
        public ModifyServiceAccountResponse ModifyServiceAccountSync(ModifyServiceAccountRequest req)
        {
             JsonResponseModel<ModifyServiceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyServiceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新版本保留规则
        /// </summary>
        /// <param name="req"><see cref="ModifyTagRetentionRuleRequest"/></param>
        /// <returns><see cref="ModifyTagRetentionRuleResponse"/></returns>
        public async Task<ModifyTagRetentionRuleResponse> ModifyTagRetentionRule(ModifyTagRetentionRuleRequest req)
        {
             JsonResponseModel<ModifyTagRetentionRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTagRetentionRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTagRetentionRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新版本保留规则
        /// </summary>
        /// <param name="req"><see cref="ModifyTagRetentionRuleRequest"/></param>
        /// <returns><see cref="ModifyTagRetentionRuleResponse"/></returns>
        public ModifyTagRetentionRuleResponse ModifyTagRetentionRuleSync(ModifyTagRetentionRuleRequest req)
        {
             JsonResponseModel<ModifyTagRetentionRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTagRetentionRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTagRetentionRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改个人用户登录密码
        /// </summary>
        /// <param name="req"><see cref="ModifyUserPasswordPersonalRequest"/></param>
        /// <returns><see cref="ModifyUserPasswordPersonalResponse"/></returns>
        public async Task<ModifyUserPasswordPersonalResponse> ModifyUserPasswordPersonal(ModifyUserPasswordPersonalRequest req)
        {
             JsonResponseModel<ModifyUserPasswordPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUserPasswordPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserPasswordPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改个人用户登录密码
        /// </summary>
        /// <param name="req"><see cref="ModifyUserPasswordPersonalRequest"/></param>
        /// <returns><see cref="ModifyUserPasswordPersonalResponse"/></returns>
        public ModifyUserPasswordPersonalResponse ModifyUserPasswordPersonalSync(ModifyUserPasswordPersonalRequest req)
        {
             JsonResponseModel<ModifyUserPasswordPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUserPasswordPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserPasswordPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新触发器
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookTriggerRequest"/></param>
        /// <returns><see cref="ModifyWebhookTriggerResponse"/></returns>
        public async Task<ModifyWebhookTriggerResponse> ModifyWebhookTrigger(ModifyWebhookTriggerRequest req)
        {
             JsonResponseModel<ModifyWebhookTriggerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWebhookTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebhookTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新触发器
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookTriggerRequest"/></param>
        /// <returns><see cref="ModifyWebhookTriggerResponse"/></returns>
        public ModifyWebhookTriggerResponse ModifyWebhookTriggerSync(ModifyWebhookTriggerRequest req)
        {
             JsonResponseModel<ModifyWebhookTriggerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWebhookTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebhookTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 预付费实例续费，同时支持按量计费转包年包月
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public async Task<RenewInstanceResponse> RenewInstance(RenewInstanceRequest req)
        {
             JsonResponseModel<RenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 预付费实例续费，同时支持按量计费转包年包月
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public RenewInstanceResponse RenewInstanceSync(RenewInstanceRequest req)
        {
             JsonResponseModel<RenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询个人版用户命名空间是否存在
        /// </summary>
        /// <param name="req"><see cref="ValidateNamespaceExistPersonalRequest"/></param>
        /// <returns><see cref="ValidateNamespaceExistPersonalResponse"/></returns>
        public async Task<ValidateNamespaceExistPersonalResponse> ValidateNamespaceExistPersonal(ValidateNamespaceExistPersonalRequest req)
        {
             JsonResponseModel<ValidateNamespaceExistPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ValidateNamespaceExistPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ValidateNamespaceExistPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询个人版用户命名空间是否存在
        /// </summary>
        /// <param name="req"><see cref="ValidateNamespaceExistPersonalRequest"/></param>
        /// <returns><see cref="ValidateNamespaceExistPersonalResponse"/></returns>
        public ValidateNamespaceExistPersonalResponse ValidateNamespaceExistPersonalSync(ValidateNamespaceExistPersonalRequest req)
        {
             JsonResponseModel<ValidateNamespaceExistPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ValidateNamespaceExistPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ValidateNamespaceExistPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于判断个人版仓库是否存在
        /// </summary>
        /// <param name="req"><see cref="ValidateRepositoryExistPersonalRequest"/></param>
        /// <returns><see cref="ValidateRepositoryExistPersonalResponse"/></returns>
        public async Task<ValidateRepositoryExistPersonalResponse> ValidateRepositoryExistPersonal(ValidateRepositoryExistPersonalRequest req)
        {
             JsonResponseModel<ValidateRepositoryExistPersonalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ValidateRepositoryExistPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ValidateRepositoryExistPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于判断个人版仓库是否存在
        /// </summary>
        /// <param name="req"><see cref="ValidateRepositoryExistPersonalRequest"/></param>
        /// <returns><see cref="ValidateRepositoryExistPersonalResponse"/></returns>
        public ValidateRepositoryExistPersonalResponse ValidateRepositoryExistPersonalSync(ValidateRepositoryExistPersonalRequest req)
        {
             JsonResponseModel<ValidateRepositoryExistPersonalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ValidateRepositoryExistPersonal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ValidateRepositoryExistPersonalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
