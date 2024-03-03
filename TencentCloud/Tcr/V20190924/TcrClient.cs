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
       private const string sdkVersion = "SDK_NET_3.0.956";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 用于在个人版镜像仓库中批量删除Tag
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteImagePersonalRequest"/></param>
        /// <returns><see cref="BatchDeleteImagePersonalResponse"/></returns>
        public Task<BatchDeleteImagePersonalResponse> BatchDeleteImagePersonal(BatchDeleteImagePersonalRequest req)
        {
            return InternalRequestAsync<BatchDeleteImagePersonalResponse>(req, "BatchDeleteImagePersonal");
        }

        /// <summary>
        /// 用于在个人版镜像仓库中批量删除Tag
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteImagePersonalRequest"/></param>
        /// <returns><see cref="BatchDeleteImagePersonalResponse"/></returns>
        public BatchDeleteImagePersonalResponse BatchDeleteImagePersonalSync(BatchDeleteImagePersonalRequest req)
        {
            return InternalRequestAsync<BatchDeleteImagePersonalResponse>(req, "BatchDeleteImagePersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于个人版镜像仓库中批量删除镜像仓库
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteRepositoryPersonalRequest"/></param>
        /// <returns><see cref="BatchDeleteRepositoryPersonalResponse"/></returns>
        public Task<BatchDeleteRepositoryPersonalResponse> BatchDeleteRepositoryPersonal(BatchDeleteRepositoryPersonalRequest req)
        {
            return InternalRequestAsync<BatchDeleteRepositoryPersonalResponse>(req, "BatchDeleteRepositoryPersonal");
        }

        /// <summary>
        /// 用于个人版镜像仓库中批量删除镜像仓库
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteRepositoryPersonalRequest"/></param>
        /// <returns><see cref="BatchDeleteRepositoryPersonalResponse"/></returns>
        public BatchDeleteRepositoryPersonalResponse BatchDeleteRepositoryPersonalSync(BatchDeleteRepositoryPersonalRequest req)
        {
            return InternalRequestAsync<BatchDeleteRepositoryPersonalResponse>(req, "BatchDeleteRepositoryPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于校验企业版实例信息
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceRequest"/></param>
        /// <returns><see cref="CheckInstanceResponse"/></returns>
        public Task<CheckInstanceResponse> CheckInstance(CheckInstanceRequest req)
        {
            return InternalRequestAsync<CheckInstanceResponse>(req, "CheckInstance");
        }

        /// <summary>
        /// 用于校验企业版实例信息
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceRequest"/></param>
        /// <returns><see cref="CheckInstanceResponse"/></returns>
        public CheckInstanceResponse CheckInstanceSync(CheckInstanceRequest req)
        {
            return InternalRequestAsync<CheckInstanceResponse>(req, "CheckInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检查待创建的实例名称是否符合规范
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceNameRequest"/></param>
        /// <returns><see cref="CheckInstanceNameResponse"/></returns>
        public Task<CheckInstanceNameResponse> CheckInstanceName(CheckInstanceNameRequest req)
        {
            return InternalRequestAsync<CheckInstanceNameResponse>(req, "CheckInstanceName");
        }

        /// <summary>
        /// 检查待创建的实例名称是否符合规范
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceNameRequest"/></param>
        /// <returns><see cref="CheckInstanceNameResponse"/></returns>
        public CheckInstanceNameResponse CheckInstanceNameSync(CheckInstanceNameRequest req)
        {
            return InternalRequestAsync<CheckInstanceNameResponse>(req, "CheckInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建应用更新触发器
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationTriggerPersonalRequest"/></param>
        /// <returns><see cref="CreateApplicationTriggerPersonalResponse"/></returns>
        public Task<CreateApplicationTriggerPersonalResponse> CreateApplicationTriggerPersonal(CreateApplicationTriggerPersonalRequest req)
        {
            return InternalRequestAsync<CreateApplicationTriggerPersonalResponse>(req, "CreateApplicationTriggerPersonal");
        }

        /// <summary>
        /// 用于创建应用更新触发器
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationTriggerPersonalRequest"/></param>
        /// <returns><see cref="CreateApplicationTriggerPersonalResponse"/></returns>
        public CreateApplicationTriggerPersonalResponse CreateApplicationTriggerPersonalSync(CreateApplicationTriggerPersonalRequest req)
        {
            return InternalRequestAsync<CreateApplicationTriggerPersonalResponse>(req, "CreateApplicationTriggerPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像加速服务
        /// </summary>
        /// <param name="req"><see cref="CreateImageAccelerationServiceRequest"/></param>
        /// <returns><see cref="CreateImageAccelerationServiceResponse"/></returns>
        public Task<CreateImageAccelerationServiceResponse> CreateImageAccelerationService(CreateImageAccelerationServiceRequest req)
        {
            return InternalRequestAsync<CreateImageAccelerationServiceResponse>(req, "CreateImageAccelerationService");
        }

        /// <summary>
        /// 创建镜像加速服务
        /// </summary>
        /// <param name="req"><see cref="CreateImageAccelerationServiceRequest"/></param>
        /// <returns><see cref="CreateImageAccelerationServiceResponse"/></returns>
        public CreateImageAccelerationServiceResponse CreateImageAccelerationServiceSync(CreateImageAccelerationServiceRequest req)
        {
            return InternalRequestAsync<CreateImageAccelerationServiceResponse>(req, "CreateImageAccelerationService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像不可变规则
        /// </summary>
        /// <param name="req"><see cref="CreateImmutableTagRulesRequest"/></param>
        /// <returns><see cref="CreateImmutableTagRulesResponse"/></returns>
        public Task<CreateImmutableTagRulesResponse> CreateImmutableTagRules(CreateImmutableTagRulesRequest req)
        {
            return InternalRequestAsync<CreateImmutableTagRulesResponse>(req, "CreateImmutableTagRules");
        }

        /// <summary>
        /// 创建镜像不可变规则
        /// </summary>
        /// <param name="req"><see cref="CreateImmutableTagRulesRequest"/></param>
        /// <returns><see cref="CreateImmutableTagRulesResponse"/></returns>
        public CreateImmutableTagRulesResponse CreateImmutableTagRulesSync(CreateImmutableTagRulesRequest req)
        {
            return InternalRequestAsync<CreateImmutableTagRulesResponse>(req, "CreateImmutableTagRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance");
        }

        /// <summary>
        /// 创建实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建自定义域名
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="CreateInstanceCustomizedDomainResponse"/></returns>
        public Task<CreateInstanceCustomizedDomainResponse> CreateInstanceCustomizedDomain(CreateInstanceCustomizedDomainRequest req)
        {
            return InternalRequestAsync<CreateInstanceCustomizedDomainResponse>(req, "CreateInstanceCustomizedDomain");
        }

        /// <summary>
        /// 创建自定义域名
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="CreateInstanceCustomizedDomainResponse"/></returns>
        public CreateInstanceCustomizedDomainResponse CreateInstanceCustomizedDomainSync(CreateInstanceCustomizedDomainRequest req)
        {
            return InternalRequestAsync<CreateInstanceCustomizedDomainResponse>(req, "CreateInstanceCustomizedDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建实例的临时或长期访问凭证
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceTokenRequest"/></param>
        /// <returns><see cref="CreateInstanceTokenResponse"/></returns>
        public Task<CreateInstanceTokenResponse> CreateInstanceToken(CreateInstanceTokenRequest req)
        {
            return InternalRequestAsync<CreateInstanceTokenResponse>(req, "CreateInstanceToken");
        }

        /// <summary>
        /// 创建实例的临时或长期访问凭证
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceTokenRequest"/></param>
        /// <returns><see cref="CreateInstanceTokenResponse"/></returns>
        public CreateInstanceTokenResponse CreateInstanceTokenSync(CreateInstanceTokenRequest req)
        {
            return InternalRequestAsync<CreateInstanceTokenResponse>(req, "CreateInstanceToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建tcr内网私有域名解析
        /// </summary>
        /// <param name="req"><see cref="CreateInternalEndpointDnsRequest"/></param>
        /// <returns><see cref="CreateInternalEndpointDnsResponse"/></returns>
        public Task<CreateInternalEndpointDnsResponse> CreateInternalEndpointDns(CreateInternalEndpointDnsRequest req)
        {
            return InternalRequestAsync<CreateInternalEndpointDnsResponse>(req, "CreateInternalEndpointDns");
        }

        /// <summary>
        /// 创建tcr内网私有域名解析
        /// </summary>
        /// <param name="req"><see cref="CreateInternalEndpointDnsRequest"/></param>
        /// <returns><see cref="CreateInternalEndpointDnsResponse"/></returns>
        public CreateInternalEndpointDnsResponse CreateInternalEndpointDnsSync(CreateInternalEndpointDnsRequest req)
        {
            return InternalRequestAsync<CreateInternalEndpointDnsResponse>(req, "CreateInternalEndpointDns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于在TCR实例中，创建多个白名单策略
        /// </summary>
        /// <param name="req"><see cref="CreateMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateMultipleSecurityPolicyResponse"/></returns>
        public Task<CreateMultipleSecurityPolicyResponse> CreateMultipleSecurityPolicy(CreateMultipleSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CreateMultipleSecurityPolicyResponse>(req, "CreateMultipleSecurityPolicy");
        }

        /// <summary>
        /// 用于在TCR实例中，创建多个白名单策略
        /// </summary>
        /// <param name="req"><see cref="CreateMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateMultipleSecurityPolicyResponse"/></returns>
        public CreateMultipleSecurityPolicyResponse CreateMultipleSecurityPolicySync(CreateMultipleSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CreateMultipleSecurityPolicyResponse>(req, "CreateMultipleSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于在企业版中创建命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public Task<CreateNamespaceResponse> CreateNamespace(CreateNamespaceRequest req)
        {
            return InternalRequestAsync<CreateNamespaceResponse>(req, "CreateNamespace");
        }

        /// <summary>
        /// 用于在企业版中创建命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public CreateNamespaceResponse CreateNamespaceSync(CreateNamespaceRequest req)
        {
            return InternalRequestAsync<CreateNamespaceResponse>(req, "CreateNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建个人版镜像仓库命名空间，此命名空间全局唯一
        /// </summary>
        /// <param name="req"><see cref="CreateNamespacePersonalRequest"/></param>
        /// <returns><see cref="CreateNamespacePersonalResponse"/></returns>
        public Task<CreateNamespacePersonalResponse> CreateNamespacePersonal(CreateNamespacePersonalRequest req)
        {
            return InternalRequestAsync<CreateNamespacePersonalResponse>(req, "CreateNamespacePersonal");
        }

        /// <summary>
        /// 创建个人版镜像仓库命名空间，此命名空间全局唯一
        /// </summary>
        /// <param name="req"><see cref="CreateNamespacePersonalRequest"/></param>
        /// <returns><see cref="CreateNamespacePersonalResponse"/></returns>
        public CreateNamespacePersonalResponse CreateNamespacePersonalSync(CreateNamespacePersonalRequest req)
        {
            return InternalRequestAsync<CreateNamespacePersonalResponse>(req, "CreateNamespacePersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建从实例
        /// </summary>
        /// <param name="req"><see cref="CreateReplicationInstanceRequest"/></param>
        /// <returns><see cref="CreateReplicationInstanceResponse"/></returns>
        public Task<CreateReplicationInstanceResponse> CreateReplicationInstance(CreateReplicationInstanceRequest req)
        {
            return InternalRequestAsync<CreateReplicationInstanceResponse>(req, "CreateReplicationInstance");
        }

        /// <summary>
        /// 创建从实例
        /// </summary>
        /// <param name="req"><see cref="CreateReplicationInstanceRequest"/></param>
        /// <returns><see cref="CreateReplicationInstanceResponse"/></returns>
        public CreateReplicationInstanceResponse CreateReplicationInstanceSync(CreateReplicationInstanceRequest req)
        {
            return InternalRequestAsync<CreateReplicationInstanceResponse>(req, "CreateReplicationInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于企业版创建镜像仓库
        /// </summary>
        /// <param name="req"><see cref="CreateRepositoryRequest"/></param>
        /// <returns><see cref="CreateRepositoryResponse"/></returns>
        public Task<CreateRepositoryResponse> CreateRepository(CreateRepositoryRequest req)
        {
            return InternalRequestAsync<CreateRepositoryResponse>(req, "CreateRepository");
        }

        /// <summary>
        /// 用于企业版创建镜像仓库
        /// </summary>
        /// <param name="req"><see cref="CreateRepositoryRequest"/></param>
        /// <returns><see cref="CreateRepositoryResponse"/></returns>
        public CreateRepositoryResponse CreateRepositorySync(CreateRepositoryRequest req)
        {
            return InternalRequestAsync<CreateRepositoryResponse>(req, "CreateRepository")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于在个人版仓库中创建镜像仓库
        /// </summary>
        /// <param name="req"><see cref="CreateRepositoryPersonalRequest"/></param>
        /// <returns><see cref="CreateRepositoryPersonalResponse"/></returns>
        public Task<CreateRepositoryPersonalResponse> CreateRepositoryPersonal(CreateRepositoryPersonalRequest req)
        {
            return InternalRequestAsync<CreateRepositoryPersonalResponse>(req, "CreateRepositoryPersonal");
        }

        /// <summary>
        /// 用于在个人版仓库中创建镜像仓库
        /// </summary>
        /// <param name="req"><see cref="CreateRepositoryPersonalRequest"/></param>
        /// <returns><see cref="CreateRepositoryPersonalResponse"/></returns>
        public CreateRepositoryPersonalResponse CreateRepositoryPersonalSync(CreateRepositoryPersonalRequest req)
        {
            return InternalRequestAsync<CreateRepositoryPersonalResponse>(req, "CreateRepositoryPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建实例公网访问白名单策略
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public Task<CreateSecurityPolicyResponse> CreateSecurityPolicy(CreateSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CreateSecurityPolicyResponse>(req, "CreateSecurityPolicy");
        }

        /// <summary>
        /// 创建实例公网访问白名单策略
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public CreateSecurityPolicyResponse CreateSecurityPolicySync(CreateSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CreateSecurityPolicyResponse>(req, "CreateSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建服务级账户
        /// </summary>
        /// <param name="req"><see cref="CreateServiceAccountRequest"/></param>
        /// <returns><see cref="CreateServiceAccountResponse"/></returns>
        public Task<CreateServiceAccountResponse> CreateServiceAccount(CreateServiceAccountRequest req)
        {
            return InternalRequestAsync<CreateServiceAccountResponse>(req, "CreateServiceAccount");
        }

        /// <summary>
        /// 创建服务级账户
        /// </summary>
        /// <param name="req"><see cref="CreateServiceAccountRequest"/></param>
        /// <returns><see cref="CreateServiceAccountResponse"/></returns>
        public CreateServiceAccountResponse CreateServiceAccountSync(CreateServiceAccountRequest req)
        {
            return InternalRequestAsync<CreateServiceAccountResponse>(req, "CreateServiceAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为一个镜像版本创建签名
        /// </summary>
        /// <param name="req"><see cref="CreateSignatureRequest"/></param>
        /// <returns><see cref="CreateSignatureResponse"/></returns>
        public Task<CreateSignatureResponse> CreateSignature(CreateSignatureRequest req)
        {
            return InternalRequestAsync<CreateSignatureResponse>(req, "CreateSignature");
        }

        /// <summary>
        /// 为一个镜像版本创建签名
        /// </summary>
        /// <param name="req"><see cref="CreateSignatureRequest"/></param>
        /// <returns><see cref="CreateSignatureResponse"/></returns>
        public CreateSignatureResponse CreateSignatureSync(CreateSignatureRequest req)
        {
            return InternalRequestAsync<CreateSignatureResponse>(req, "CreateSignature")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像签名策略
        /// </summary>
        /// <param name="req"><see cref="CreateSignaturePolicyRequest"/></param>
        /// <returns><see cref="CreateSignaturePolicyResponse"/></returns>
        public Task<CreateSignaturePolicyResponse> CreateSignaturePolicy(CreateSignaturePolicyRequest req)
        {
            return InternalRequestAsync<CreateSignaturePolicyResponse>(req, "CreateSignaturePolicy");
        }

        /// <summary>
        /// 创建镜像签名策略
        /// </summary>
        /// <param name="req"><see cref="CreateSignaturePolicyRequest"/></param>
        /// <returns><see cref="CreateSignaturePolicyResponse"/></returns>
        public CreateSignaturePolicyResponse CreateSignaturePolicySync(CreateSignaturePolicyRequest req)
        {
            return InternalRequestAsync<CreateSignaturePolicyResponse>(req, "CreateSignaturePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 手动执行版本保留
        /// </summary>
        /// <param name="req"><see cref="CreateTagRetentionExecutionRequest"/></param>
        /// <returns><see cref="CreateTagRetentionExecutionResponse"/></returns>
        public Task<CreateTagRetentionExecutionResponse> CreateTagRetentionExecution(CreateTagRetentionExecutionRequest req)
        {
            return InternalRequestAsync<CreateTagRetentionExecutionResponse>(req, "CreateTagRetentionExecution");
        }

        /// <summary>
        /// 手动执行版本保留
        /// </summary>
        /// <param name="req"><see cref="CreateTagRetentionExecutionRequest"/></param>
        /// <returns><see cref="CreateTagRetentionExecutionResponse"/></returns>
        public CreateTagRetentionExecutionResponse CreateTagRetentionExecutionSync(CreateTagRetentionExecutionRequest req)
        {
            return InternalRequestAsync<CreateTagRetentionExecutionResponse>(req, "CreateTagRetentionExecution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建版本保留规则
        /// </summary>
        /// <param name="req"><see cref="CreateTagRetentionRuleRequest"/></param>
        /// <returns><see cref="CreateTagRetentionRuleResponse"/></returns>
        public Task<CreateTagRetentionRuleResponse> CreateTagRetentionRule(CreateTagRetentionRuleRequest req)
        {
            return InternalRequestAsync<CreateTagRetentionRuleResponse>(req, "CreateTagRetentionRule");
        }

        /// <summary>
        /// 创建版本保留规则
        /// </summary>
        /// <param name="req"><see cref="CreateTagRetentionRuleRequest"/></param>
        /// <returns><see cref="CreateTagRetentionRuleResponse"/></returns>
        public CreateTagRetentionRuleResponse CreateTagRetentionRuleSync(CreateTagRetentionRuleRequest req)
        {
            return InternalRequestAsync<CreateTagRetentionRuleResponse>(req, "CreateTagRetentionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建个人用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserPersonalRequest"/></param>
        /// <returns><see cref="CreateUserPersonalResponse"/></returns>
        public Task<CreateUserPersonalResponse> CreateUserPersonal(CreateUserPersonalRequest req)
        {
            return InternalRequestAsync<CreateUserPersonalResponse>(req, "CreateUserPersonal");
        }

        /// <summary>
        /// 创建个人用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserPersonalRequest"/></param>
        /// <returns><see cref="CreateUserPersonalResponse"/></returns>
        public CreateUserPersonalResponse CreateUserPersonalSync(CreateUserPersonalRequest req)
        {
            return InternalRequestAsync<CreateUserPersonalResponse>(req, "CreateUserPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建触发器
        /// </summary>
        /// <param name="req"><see cref="CreateWebhookTriggerRequest"/></param>
        /// <returns><see cref="CreateWebhookTriggerResponse"/></returns>
        public Task<CreateWebhookTriggerResponse> CreateWebhookTrigger(CreateWebhookTriggerRequest req)
        {
            return InternalRequestAsync<CreateWebhookTriggerResponse>(req, "CreateWebhookTrigger");
        }

        /// <summary>
        /// 创建触发器
        /// </summary>
        /// <param name="req"><see cref="CreateWebhookTriggerRequest"/></param>
        /// <returns><see cref="CreateWebhookTriggerResponse"/></returns>
        public CreateWebhookTriggerResponse CreateWebhookTriggerSync(CreateWebhookTriggerRequest req)
        {
            return InternalRequestAsync<CreateWebhookTriggerResponse>(req, "CreateWebhookTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除应用更新触发器
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationTriggerPersonalRequest"/></param>
        /// <returns><see cref="DeleteApplicationTriggerPersonalResponse"/></returns>
        public Task<DeleteApplicationTriggerPersonalResponse> DeleteApplicationTriggerPersonal(DeleteApplicationTriggerPersonalRequest req)
        {
            return InternalRequestAsync<DeleteApplicationTriggerPersonalResponse>(req, "DeleteApplicationTriggerPersonal");
        }

        /// <summary>
        /// 用于删除应用更新触发器
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationTriggerPersonalRequest"/></param>
        /// <returns><see cref="DeleteApplicationTriggerPersonalResponse"/></returns>
        public DeleteApplicationTriggerPersonalResponse DeleteApplicationTriggerPersonalSync(DeleteApplicationTriggerPersonalRequest req)
        {
            return InternalRequestAsync<DeleteApplicationTriggerPersonalResponse>(req, "DeleteApplicationTriggerPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除指定镜像
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRequest"/></param>
        /// <returns><see cref="DeleteImageResponse"/></returns>
        public Task<DeleteImageResponse> DeleteImage(DeleteImageRequest req)
        {
            return InternalRequestAsync<DeleteImageResponse>(req, "DeleteImage");
        }

        /// <summary>
        /// 删除指定镜像
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRequest"/></param>
        /// <returns><see cref="DeleteImageResponse"/></returns>
        public DeleteImageResponse DeleteImageSync(DeleteImageRequest req)
        {
            return InternalRequestAsync<DeleteImageResponse>(req, "DeleteImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除镜像加速服务
        /// </summary>
        /// <param name="req"><see cref="DeleteImageAccelerateServiceRequest"/></param>
        /// <returns><see cref="DeleteImageAccelerateServiceResponse"/></returns>
        public Task<DeleteImageAccelerateServiceResponse> DeleteImageAccelerateService(DeleteImageAccelerateServiceRequest req)
        {
            return InternalRequestAsync<DeleteImageAccelerateServiceResponse>(req, "DeleteImageAccelerateService");
        }

        /// <summary>
        /// 删除镜像加速服务
        /// </summary>
        /// <param name="req"><see cref="DeleteImageAccelerateServiceRequest"/></param>
        /// <returns><see cref="DeleteImageAccelerateServiceResponse"/></returns>
        public DeleteImageAccelerateServiceResponse DeleteImageAccelerateServiceSync(DeleteImageAccelerateServiceRequest req)
        {
            return InternalRequestAsync<DeleteImageAccelerateServiceResponse>(req, "DeleteImageAccelerateService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除个人版全局镜像版本自动清理策略
        /// </summary>
        /// <param name="req"><see cref="DeleteImageLifecycleGlobalPersonalRequest"/></param>
        /// <returns><see cref="DeleteImageLifecycleGlobalPersonalResponse"/></returns>
        public Task<DeleteImageLifecycleGlobalPersonalResponse> DeleteImageLifecycleGlobalPersonal(DeleteImageLifecycleGlobalPersonalRequest req)
        {
            return InternalRequestAsync<DeleteImageLifecycleGlobalPersonalResponse>(req, "DeleteImageLifecycleGlobalPersonal");
        }

        /// <summary>
        /// 用于删除个人版全局镜像版本自动清理策略
        /// </summary>
        /// <param name="req"><see cref="DeleteImageLifecycleGlobalPersonalRequest"/></param>
        /// <returns><see cref="DeleteImageLifecycleGlobalPersonalResponse"/></returns>
        public DeleteImageLifecycleGlobalPersonalResponse DeleteImageLifecycleGlobalPersonalSync(DeleteImageLifecycleGlobalPersonalRequest req)
        {
            return InternalRequestAsync<DeleteImageLifecycleGlobalPersonalResponse>(req, "DeleteImageLifecycleGlobalPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于在个人版中删除tag
        /// </summary>
        /// <param name="req"><see cref="DeleteImagePersonalRequest"/></param>
        /// <returns><see cref="DeleteImagePersonalResponse"/></returns>
        public Task<DeleteImagePersonalResponse> DeleteImagePersonal(DeleteImagePersonalRequest req)
        {
            return InternalRequestAsync<DeleteImagePersonalResponse>(req, "DeleteImagePersonal");
        }

        /// <summary>
        /// 用于在个人版中删除tag
        /// </summary>
        /// <param name="req"><see cref="DeleteImagePersonalRequest"/></param>
        /// <returns><see cref="DeleteImagePersonalResponse"/></returns>
        public DeleteImagePersonalResponse DeleteImagePersonalSync(DeleteImagePersonalRequest req)
        {
            return InternalRequestAsync<DeleteImagePersonalResponse>(req, "DeleteImagePersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///  删除镜像不可变规则
        /// </summary>
        /// <param name="req"><see cref="DeleteImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DeleteImmutableTagRulesResponse"/></returns>
        public Task<DeleteImmutableTagRulesResponse> DeleteImmutableTagRules(DeleteImmutableTagRulesRequest req)
        {
            return InternalRequestAsync<DeleteImmutableTagRulesResponse>(req, "DeleteImmutableTagRules");
        }

        /// <summary>
        ///  删除镜像不可变规则
        /// </summary>
        /// <param name="req"><see cref="DeleteImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DeleteImmutableTagRulesResponse"/></returns>
        public DeleteImmutableTagRulesResponse DeleteImmutableTagRulesSync(DeleteImmutableTagRulesRequest req)
        {
            return InternalRequestAsync<DeleteImmutableTagRulesResponse>(req, "DeleteImmutableTagRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除镜像仓库企业版实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance");
        }

        /// <summary>
        /// 删除镜像仓库企业版实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除自定义域名
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="DeleteInstanceCustomizedDomainResponse"/></returns>
        public Task<DeleteInstanceCustomizedDomainResponse> DeleteInstanceCustomizedDomain(DeleteInstanceCustomizedDomainRequest req)
        {
            return InternalRequestAsync<DeleteInstanceCustomizedDomainResponse>(req, "DeleteInstanceCustomizedDomain");
        }

        /// <summary>
        /// 删除自定义域名
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="DeleteInstanceCustomizedDomainResponse"/></returns>
        public DeleteInstanceCustomizedDomainResponse DeleteInstanceCustomizedDomainSync(DeleteInstanceCustomizedDomainRequest req)
        {
            return InternalRequestAsync<DeleteInstanceCustomizedDomainResponse>(req, "DeleteInstanceCustomizedDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除长期访问凭证
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceTokenRequest"/></param>
        /// <returns><see cref="DeleteInstanceTokenResponse"/></returns>
        public Task<DeleteInstanceTokenResponse> DeleteInstanceToken(DeleteInstanceTokenRequest req)
        {
            return InternalRequestAsync<DeleteInstanceTokenResponse>(req, "DeleteInstanceToken");
        }

        /// <summary>
        /// 删除长期访问凭证
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceTokenRequest"/></param>
        /// <returns><see cref="DeleteInstanceTokenResponse"/></returns>
        public DeleteInstanceTokenResponse DeleteInstanceTokenSync(DeleteInstanceTokenRequest req)
        {
            return InternalRequestAsync<DeleteInstanceTokenResponse>(req, "DeleteInstanceToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除tcr内网私有域名解析
        /// </summary>
        /// <param name="req"><see cref="DeleteInternalEndpointDnsRequest"/></param>
        /// <returns><see cref="DeleteInternalEndpointDnsResponse"/></returns>
        public Task<DeleteInternalEndpointDnsResponse> DeleteInternalEndpointDns(DeleteInternalEndpointDnsRequest req)
        {
            return InternalRequestAsync<DeleteInternalEndpointDnsResponse>(req, "DeleteInternalEndpointDns");
        }

        /// <summary>
        /// 删除tcr内网私有域名解析
        /// </summary>
        /// <param name="req"><see cref="DeleteInternalEndpointDnsRequest"/></param>
        /// <returns><see cref="DeleteInternalEndpointDnsResponse"/></returns>
        public DeleteInternalEndpointDnsResponse DeleteInternalEndpointDnsSync(DeleteInternalEndpointDnsRequest req)
        {
            return InternalRequestAsync<DeleteInternalEndpointDnsResponse>(req, "DeleteInternalEndpointDns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除实例多个公网访问白名单策略
        /// </summary>
        /// <param name="req"><see cref="DeleteMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteMultipleSecurityPolicyResponse"/></returns>
        public Task<DeleteMultipleSecurityPolicyResponse> DeleteMultipleSecurityPolicy(DeleteMultipleSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DeleteMultipleSecurityPolicyResponse>(req, "DeleteMultipleSecurityPolicy");
        }

        /// <summary>
        /// 用于删除实例多个公网访问白名单策略
        /// </summary>
        /// <param name="req"><see cref="DeleteMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteMultipleSecurityPolicyResponse"/></returns>
        public DeleteMultipleSecurityPolicyResponse DeleteMultipleSecurityPolicySync(DeleteMultipleSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DeleteMultipleSecurityPolicyResponse>(req, "DeleteMultipleSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public Task<DeleteNamespaceResponse> DeleteNamespace(DeleteNamespaceRequest req)
        {
            return InternalRequestAsync<DeleteNamespaceResponse>(req, "DeleteNamespace");
        }

        /// <summary>
        /// 删除命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public DeleteNamespaceResponse DeleteNamespaceSync(DeleteNamespaceRequest req)
        {
            return InternalRequestAsync<DeleteNamespaceResponse>(req, "DeleteNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除共享版命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespacePersonalRequest"/></param>
        /// <returns><see cref="DeleteNamespacePersonalResponse"/></returns>
        public Task<DeleteNamespacePersonalResponse> DeleteNamespacePersonal(DeleteNamespacePersonalRequest req)
        {
            return InternalRequestAsync<DeleteNamespacePersonalResponse>(req, "DeleteNamespacePersonal");
        }

        /// <summary>
        /// 删除共享版命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespacePersonalRequest"/></param>
        /// <returns><see cref="DeleteNamespacePersonalResponse"/></returns>
        public DeleteNamespacePersonalResponse DeleteNamespacePersonalSync(DeleteNamespacePersonalRequest req)
        {
            return InternalRequestAsync<DeleteNamespacePersonalResponse>(req, "DeleteNamespacePersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除从实例
        /// </summary>
        /// <param name="req"><see cref="DeleteReplicationInstanceRequest"/></param>
        /// <returns><see cref="DeleteReplicationInstanceResponse"/></returns>
        public Task<DeleteReplicationInstanceResponse> DeleteReplicationInstance(DeleteReplicationInstanceRequest req)
        {
            return InternalRequestAsync<DeleteReplicationInstanceResponse>(req, "DeleteReplicationInstance");
        }

        /// <summary>
        /// 删除从实例
        /// </summary>
        /// <param name="req"><see cref="DeleteReplicationInstanceRequest"/></param>
        /// <returns><see cref="DeleteReplicationInstanceResponse"/></returns>
        public DeleteReplicationInstanceResponse DeleteReplicationInstanceSync(DeleteReplicationInstanceRequest req)
        {
            return InternalRequestAsync<DeleteReplicationInstanceResponse>(req, "DeleteReplicationInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除镜像仓库
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryRequest"/></param>
        /// <returns><see cref="DeleteRepositoryResponse"/></returns>
        public Task<DeleteRepositoryResponse> DeleteRepository(DeleteRepositoryRequest req)
        {
            return InternalRequestAsync<DeleteRepositoryResponse>(req, "DeleteRepository");
        }

        /// <summary>
        /// 删除镜像仓库
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryRequest"/></param>
        /// <returns><see cref="DeleteRepositoryResponse"/></returns>
        public DeleteRepositoryResponse DeleteRepositorySync(DeleteRepositoryRequest req)
        {
            return InternalRequestAsync<DeleteRepositoryResponse>(req, "DeleteRepository")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于个人版镜像仓库中删除
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryPersonalRequest"/></param>
        /// <returns><see cref="DeleteRepositoryPersonalResponse"/></returns>
        public Task<DeleteRepositoryPersonalResponse> DeleteRepositoryPersonal(DeleteRepositoryPersonalRequest req)
        {
            return InternalRequestAsync<DeleteRepositoryPersonalResponse>(req, "DeleteRepositoryPersonal");
        }

        /// <summary>
        /// 用于个人版镜像仓库中删除
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryPersonalRequest"/></param>
        /// <returns><see cref="DeleteRepositoryPersonalResponse"/></returns>
        public DeleteRepositoryPersonalResponse DeleteRepositoryPersonalSync(DeleteRepositoryPersonalRequest req)
        {
            return InternalRequestAsync<DeleteRepositoryPersonalResponse>(req, "DeleteRepositoryPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于企业版批量删除Repository Tag
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryTagsRequest"/></param>
        /// <returns><see cref="DeleteRepositoryTagsResponse"/></returns>
        public Task<DeleteRepositoryTagsResponse> DeleteRepositoryTags(DeleteRepositoryTagsRequest req)
        {
            return InternalRequestAsync<DeleteRepositoryTagsResponse>(req, "DeleteRepositoryTags");
        }

        /// <summary>
        /// 用于企业版批量删除Repository Tag
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryTagsRequest"/></param>
        /// <returns><see cref="DeleteRepositoryTagsResponse"/></returns>
        public DeleteRepositoryTagsResponse DeleteRepositoryTagsSync(DeleteRepositoryTagsRequest req)
        {
            return InternalRequestAsync<DeleteRepositoryTagsResponse>(req, "DeleteRepositoryTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除实例公网访问白名单策略
        /// 
        /// 注意：当PolicyIndex和CidrBlock同时存在时，CidrBlock优先级更高
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public Task<DeleteSecurityPolicyResponse> DeleteSecurityPolicy(DeleteSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DeleteSecurityPolicyResponse>(req, "DeleteSecurityPolicy");
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
            return InternalRequestAsync<DeleteSecurityPolicyResponse>(req, "DeleteSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除服务级账号
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceAccountRequest"/></param>
        /// <returns><see cref="DeleteServiceAccountResponse"/></returns>
        public Task<DeleteServiceAccountResponse> DeleteServiceAccount(DeleteServiceAccountRequest req)
        {
            return InternalRequestAsync<DeleteServiceAccountResponse>(req, "DeleteServiceAccount");
        }

        /// <summary>
        /// 删除服务级账号
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceAccountRequest"/></param>
        /// <returns><see cref="DeleteServiceAccountResponse"/></returns>
        public DeleteServiceAccountResponse DeleteServiceAccountSync(DeleteServiceAccountRequest req)
        {
            return InternalRequestAsync<DeleteServiceAccountResponse>(req, "DeleteServiceAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除命名空间加签策略
        /// </summary>
        /// <param name="req"><see cref="DeleteSignaturePolicyRequest"/></param>
        /// <returns><see cref="DeleteSignaturePolicyResponse"/></returns>
        public Task<DeleteSignaturePolicyResponse> DeleteSignaturePolicy(DeleteSignaturePolicyRequest req)
        {
            return InternalRequestAsync<DeleteSignaturePolicyResponse>(req, "DeleteSignaturePolicy");
        }

        /// <summary>
        /// 删除命名空间加签策略
        /// </summary>
        /// <param name="req"><see cref="DeleteSignaturePolicyRequest"/></param>
        /// <returns><see cref="DeleteSignaturePolicyResponse"/></returns>
        public DeleteSignaturePolicyResponse DeleteSignaturePolicySync(DeleteSignaturePolicyRequest req)
        {
            return InternalRequestAsync<DeleteSignaturePolicyResponse>(req, "DeleteSignaturePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除版本保留规则
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRetentionRuleRequest"/></param>
        /// <returns><see cref="DeleteTagRetentionRuleResponse"/></returns>
        public Task<DeleteTagRetentionRuleResponse> DeleteTagRetentionRule(DeleteTagRetentionRuleRequest req)
        {
            return InternalRequestAsync<DeleteTagRetentionRuleResponse>(req, "DeleteTagRetentionRule");
        }

        /// <summary>
        /// 删除版本保留规则
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRetentionRuleRequest"/></param>
        /// <returns><see cref="DeleteTagRetentionRuleResponse"/></returns>
        public DeleteTagRetentionRuleResponse DeleteTagRetentionRuleSync(DeleteTagRetentionRuleRequest req)
        {
            return InternalRequestAsync<DeleteTagRetentionRuleResponse>(req, "DeleteTagRetentionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除触发器
        /// </summary>
        /// <param name="req"><see cref="DeleteWebhookTriggerRequest"/></param>
        /// <returns><see cref="DeleteWebhookTriggerResponse"/></returns>
        public Task<DeleteWebhookTriggerResponse> DeleteWebhookTrigger(DeleteWebhookTriggerRequest req)
        {
            return InternalRequestAsync<DeleteWebhookTriggerResponse>(req, "DeleteWebhookTrigger");
        }

        /// <summary>
        /// 删除触发器
        /// </summary>
        /// <param name="req"><see cref="DeleteWebhookTriggerRequest"/></param>
        /// <returns><see cref="DeleteWebhookTriggerResponse"/></returns>
        public DeleteWebhookTriggerResponse DeleteWebhookTriggerSync(DeleteWebhookTriggerRequest req)
        {
            return InternalRequestAsync<DeleteWebhookTriggerResponse>(req, "DeleteWebhookTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询应用更新触发器触发日志
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationTriggerLogPersonalRequest"/></param>
        /// <returns><see cref="DescribeApplicationTriggerLogPersonalResponse"/></returns>
        public Task<DescribeApplicationTriggerLogPersonalResponse> DescribeApplicationTriggerLogPersonal(DescribeApplicationTriggerLogPersonalRequest req)
        {
            return InternalRequestAsync<DescribeApplicationTriggerLogPersonalResponse>(req, "DescribeApplicationTriggerLogPersonal");
        }

        /// <summary>
        /// 用于查询应用更新触发器触发日志
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationTriggerLogPersonalRequest"/></param>
        /// <returns><see cref="DescribeApplicationTriggerLogPersonalResponse"/></returns>
        public DescribeApplicationTriggerLogPersonalResponse DescribeApplicationTriggerLogPersonalSync(DescribeApplicationTriggerLogPersonalRequest req)
        {
            return InternalRequestAsync<DescribeApplicationTriggerLogPersonalResponse>(req, "DescribeApplicationTriggerLogPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询应用更新触发器
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationTriggerPersonalRequest"/></param>
        /// <returns><see cref="DescribeApplicationTriggerPersonalResponse"/></returns>
        public Task<DescribeApplicationTriggerPersonalResponse> DescribeApplicationTriggerPersonal(DescribeApplicationTriggerPersonalRequest req)
        {
            return InternalRequestAsync<DescribeApplicationTriggerPersonalResponse>(req, "DescribeApplicationTriggerPersonal");
        }

        /// <summary>
        /// 用于查询应用更新触发器
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationTriggerPersonalRequest"/></param>
        /// <returns><see cref="DescribeApplicationTriggerPersonalResponse"/></returns>
        public DescribeApplicationTriggerPersonalResponse DescribeApplicationTriggerPersonalSync(DescribeApplicationTriggerPersonalRequest req)
        {
            return InternalRequestAsync<DescribeApplicationTriggerPersonalResponse>(req, "DescribeApplicationTriggerPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于在企业版中返回Chart的下载信息
        /// </summary>
        /// <param name="req"><see cref="DescribeChartDownloadInfoRequest"/></param>
        /// <returns><see cref="DescribeChartDownloadInfoResponse"/></returns>
        public Task<DescribeChartDownloadInfoResponse> DescribeChartDownloadInfo(DescribeChartDownloadInfoRequest req)
        {
            return InternalRequestAsync<DescribeChartDownloadInfoResponse>(req, "DescribeChartDownloadInfo");
        }

        /// <summary>
        /// 用于在企业版中返回Chart的下载信息
        /// </summary>
        /// <param name="req"><see cref="DescribeChartDownloadInfoRequest"/></param>
        /// <returns><see cref="DescribeChartDownloadInfoResponse"/></returns>
        public DescribeChartDownloadInfoResponse DescribeChartDownloadInfoSync(DescribeChartDownloadInfoRequest req)
        {
            return InternalRequestAsync<DescribeChartDownloadInfoResponse>(req, "DescribeChartDownloadInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例公网访问入口状态
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeExternalEndpointStatusResponse"/></returns>
        public Task<DescribeExternalEndpointStatusResponse> DescribeExternalEndpointStatus(DescribeExternalEndpointStatusRequest req)
        {
            return InternalRequestAsync<DescribeExternalEndpointStatusResponse>(req, "DescribeExternalEndpointStatus");
        }

        /// <summary>
        /// 查询实例公网访问入口状态
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeExternalEndpointStatusResponse"/></returns>
        public DescribeExternalEndpointStatusResponse DescribeExternalEndpointStatusSync(DescribeExternalEndpointStatusRequest req)
        {
            return InternalRequestAsync<DescribeExternalEndpointStatusResponse>(req, "DescribeExternalEndpointStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询个人收藏仓库
        /// </summary>
        /// <param name="req"><see cref="DescribeFavorRepositoryPersonalRequest"/></param>
        /// <returns><see cref="DescribeFavorRepositoryPersonalResponse"/></returns>
        public Task<DescribeFavorRepositoryPersonalResponse> DescribeFavorRepositoryPersonal(DescribeFavorRepositoryPersonalRequest req)
        {
            return InternalRequestAsync<DescribeFavorRepositoryPersonalResponse>(req, "DescribeFavorRepositoryPersonal");
        }

        /// <summary>
        /// 查询个人收藏仓库
        /// </summary>
        /// <param name="req"><see cref="DescribeFavorRepositoryPersonalRequest"/></param>
        /// <returns><see cref="DescribeFavorRepositoryPersonalResponse"/></returns>
        public DescribeFavorRepositoryPersonalResponse DescribeFavorRepositoryPersonalSync(DescribeFavorRepositoryPersonalRequest req)
        {
            return InternalRequestAsync<DescribeFavorRepositoryPersonalResponse>(req, "DescribeFavorRepositoryPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// GC 最近10条历史
        /// </summary>
        /// <param name="req"><see cref="DescribeGCJobsRequest"/></param>
        /// <returns><see cref="DescribeGCJobsResponse"/></returns>
        public Task<DescribeGCJobsResponse> DescribeGCJobs(DescribeGCJobsRequest req)
        {
            return InternalRequestAsync<DescribeGCJobsResponse>(req, "DescribeGCJobs");
        }

        /// <summary>
        /// GC 最近10条历史
        /// </summary>
        /// <param name="req"><see cref="DescribeGCJobsRequest"/></param>
        /// <returns><see cref="DescribeGCJobsResponse"/></returns>
        public DescribeGCJobsResponse DescribeGCJobsSync(DescribeGCJobsRequest req)
        {
            return InternalRequestAsync<DescribeGCJobsResponse>(req, "DescribeGCJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像加速服务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAccelerateServiceRequest"/></param>
        /// <returns><see cref="DescribeImageAccelerateServiceResponse"/></returns>
        public Task<DescribeImageAccelerateServiceResponse> DescribeImageAccelerateService(DescribeImageAccelerateServiceRequest req)
        {
            return InternalRequestAsync<DescribeImageAccelerateServiceResponse>(req, "DescribeImageAccelerateService");
        }

        /// <summary>
        /// 查询镜像加速服务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAccelerateServiceRequest"/></param>
        /// <returns><see cref="DescribeImageAccelerateServiceResponse"/></returns>
        public DescribeImageAccelerateServiceResponse DescribeImageAccelerateServiceSync(DescribeImageAccelerateServiceRequest req)
        {
            return InternalRequestAsync<DescribeImageAccelerateServiceResponse>(req, "DescribeImageAccelerateService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于在个人版中查询与指定tag镜像内容相同的tag列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageFilterPersonalRequest"/></param>
        /// <returns><see cref="DescribeImageFilterPersonalResponse"/></returns>
        public Task<DescribeImageFilterPersonalResponse> DescribeImageFilterPersonal(DescribeImageFilterPersonalRequest req)
        {
            return InternalRequestAsync<DescribeImageFilterPersonalResponse>(req, "DescribeImageFilterPersonal");
        }

        /// <summary>
        /// 用于在个人版中查询与指定tag镜像内容相同的tag列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageFilterPersonalRequest"/></param>
        /// <returns><see cref="DescribeImageFilterPersonalResponse"/></returns>
        public DescribeImageFilterPersonalResponse DescribeImageFilterPersonalSync(DescribeImageFilterPersonalRequest req)
        {
            return InternalRequestAsync<DescribeImageFilterPersonalResponse>(req, "DescribeImageFilterPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取个人版全局镜像版本自动清理策略
        /// </summary>
        /// <param name="req"><see cref="DescribeImageLifecycleGlobalPersonalRequest"/></param>
        /// <returns><see cref="DescribeImageLifecycleGlobalPersonalResponse"/></returns>
        public Task<DescribeImageLifecycleGlobalPersonalResponse> DescribeImageLifecycleGlobalPersonal(DescribeImageLifecycleGlobalPersonalRequest req)
        {
            return InternalRequestAsync<DescribeImageLifecycleGlobalPersonalResponse>(req, "DescribeImageLifecycleGlobalPersonal");
        }

        /// <summary>
        /// 用于获取个人版全局镜像版本自动清理策略
        /// </summary>
        /// <param name="req"><see cref="DescribeImageLifecycleGlobalPersonalRequest"/></param>
        /// <returns><see cref="DescribeImageLifecycleGlobalPersonalResponse"/></returns>
        public DescribeImageLifecycleGlobalPersonalResponse DescribeImageLifecycleGlobalPersonalSync(DescribeImageLifecycleGlobalPersonalRequest req)
        {
            return InternalRequestAsync<DescribeImageLifecycleGlobalPersonalResponse>(req, "DescribeImageLifecycleGlobalPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取个人版仓库中自动清理策略
        /// </summary>
        /// <param name="req"><see cref="DescribeImageLifecyclePersonalRequest"/></param>
        /// <returns><see cref="DescribeImageLifecyclePersonalResponse"/></returns>
        public Task<DescribeImageLifecyclePersonalResponse> DescribeImageLifecyclePersonal(DescribeImageLifecyclePersonalRequest req)
        {
            return InternalRequestAsync<DescribeImageLifecyclePersonalResponse>(req, "DescribeImageLifecyclePersonal");
        }

        /// <summary>
        /// 用于获取个人版仓库中自动清理策略
        /// </summary>
        /// <param name="req"><see cref="DescribeImageLifecyclePersonalRequest"/></param>
        /// <returns><see cref="DescribeImageLifecyclePersonalResponse"/></returns>
        public DescribeImageLifecyclePersonalResponse DescribeImageLifecyclePersonalSync(DescribeImageLifecyclePersonalRequest req)
        {
            return InternalRequestAsync<DescribeImageLifecyclePersonalResponse>(req, "DescribeImageLifecyclePersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询容器镜像Manifest信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImageManifestsRequest"/></param>
        /// <returns><see cref="DescribeImageManifestsResponse"/></returns>
        public Task<DescribeImageManifestsResponse> DescribeImageManifests(DescribeImageManifestsRequest req)
        {
            return InternalRequestAsync<DescribeImageManifestsResponse>(req, "DescribeImageManifests");
        }

        /// <summary>
        /// 查询容器镜像Manifest信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImageManifestsRequest"/></param>
        /// <returns><see cref="DescribeImageManifestsResponse"/></returns>
        public DescribeImageManifestsResponse DescribeImageManifestsSync(DescribeImageManifestsRequest req)
        {
            return InternalRequestAsync<DescribeImageManifestsResponse>(req, "DescribeImageManifests")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取个人版镜像仓库tag列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImagePersonalRequest"/></param>
        /// <returns><see cref="DescribeImagePersonalResponse"/></returns>
        public Task<DescribeImagePersonalResponse> DescribeImagePersonal(DescribeImagePersonalRequest req)
        {
            return InternalRequestAsync<DescribeImagePersonalResponse>(req, "DescribeImagePersonal");
        }

        /// <summary>
        /// 用于获取个人版镜像仓库tag列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImagePersonalRequest"/></param>
        /// <returns><see cref="DescribeImagePersonalResponse"/></returns>
        public DescribeImagePersonalResponse DescribeImagePersonalSync(DescribeImagePersonalRequest req)
        {
            return InternalRequestAsync<DescribeImagePersonalResponse>(req, "DescribeImagePersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像版本列表或指定容器镜像信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest req)
        {
            return InternalRequestAsync<DescribeImagesResponse>(req, "DescribeImages");
        }

        /// <summary>
        /// 查询镜像版本列表或指定容器镜像信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public DescribeImagesResponse DescribeImagesSync(DescribeImagesRequest req)
        {
            return InternalRequestAsync<DescribeImagesResponse>(req, "DescribeImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出镜像不可变规则
        /// </summary>
        /// <param name="req"><see cref="DescribeImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DescribeImmutableTagRulesResponse"/></returns>
        public Task<DescribeImmutableTagRulesResponse> DescribeImmutableTagRules(DescribeImmutableTagRulesRequest req)
        {
            return InternalRequestAsync<DescribeImmutableTagRulesResponse>(req, "DescribeImmutableTagRules");
        }

        /// <summary>
        /// 列出镜像不可变规则
        /// </summary>
        /// <param name="req"><see cref="DescribeImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DescribeImmutableTagRulesResponse"/></returns>
        public DescribeImmutableTagRulesResponse DescribeImmutableTagRulesSync(DescribeImmutableTagRulesRequest req)
        {
            return InternalRequestAsync<DescribeImmutableTagRulesResponse>(req, "DescribeImmutableTagRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询所有实例命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeInstanceAllNamespacesResponse"/></returns>
        public Task<DescribeInstanceAllNamespacesResponse> DescribeInstanceAllNamespaces(DescribeInstanceAllNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceAllNamespacesResponse>(req, "DescribeInstanceAllNamespaces");
        }

        /// <summary>
        /// 查询所有实例命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeInstanceAllNamespacesResponse"/></returns>
        public DescribeInstanceAllNamespacesResponse DescribeInstanceAllNamespacesSync(DescribeInstanceAllNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceAllNamespacesResponse>(req, "DescribeInstanceAllNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例自定义域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="DescribeInstanceCustomizedDomainResponse"/></returns>
        public Task<DescribeInstanceCustomizedDomainResponse> DescribeInstanceCustomizedDomain(DescribeInstanceCustomizedDomainRequest req)
        {
            return InternalRequestAsync<DescribeInstanceCustomizedDomainResponse>(req, "DescribeInstanceCustomizedDomain");
        }

        /// <summary>
        /// 查询实例自定义域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCustomizedDomainRequest"/></param>
        /// <returns><see cref="DescribeInstanceCustomizedDomainResponse"/></returns>
        public DescribeInstanceCustomizedDomainResponse DescribeInstanceCustomizedDomainSync(DescribeInstanceCustomizedDomainRequest req)
        {
            return InternalRequestAsync<DescribeInstanceCustomizedDomainResponse>(req, "DescribeInstanceCustomizedDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例当前状态以及过程信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStatusRequest"/></param>
        /// <returns><see cref="DescribeInstanceStatusResponse"/></returns>
        public Task<DescribeInstanceStatusResponse> DescribeInstanceStatus(DescribeInstanceStatusRequest req)
        {
            return InternalRequestAsync<DescribeInstanceStatusResponse>(req, "DescribeInstanceStatus");
        }

        /// <summary>
        /// 查询实例当前状态以及过程信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStatusRequest"/></param>
        /// <returns><see cref="DescribeInstanceStatusResponse"/></returns>
        public DescribeInstanceStatusResponse DescribeInstanceStatusSync(DescribeInstanceStatusRequest req)
        {
            return InternalRequestAsync<DescribeInstanceStatusResponse>(req, "DescribeInstanceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询长期访问凭证信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTokenRequest"/></param>
        /// <returns><see cref="DescribeInstanceTokenResponse"/></returns>
        public Task<DescribeInstanceTokenResponse> DescribeInstanceToken(DescribeInstanceTokenRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTokenResponse>(req, "DescribeInstanceToken");
        }

        /// <summary>
        /// 查询长期访问凭证信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTokenRequest"/></param>
        /// <returns><see cref="DescribeInstanceTokenResponse"/></returns>
        public DescribeInstanceTokenResponse DescribeInstanceTokenSync(DescribeInstanceTokenRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTokenResponse>(req, "DescribeInstanceToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 查询实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量查询vpc是否已经添加私有域名解析
        /// </summary>
        /// <param name="req"><see cref="DescribeInternalEndpointDnsStatusRequest"/></param>
        /// <returns><see cref="DescribeInternalEndpointDnsStatusResponse"/></returns>
        public Task<DescribeInternalEndpointDnsStatusResponse> DescribeInternalEndpointDnsStatus(DescribeInternalEndpointDnsStatusRequest req)
        {
            return InternalRequestAsync<DescribeInternalEndpointDnsStatusResponse>(req, "DescribeInternalEndpointDnsStatus");
        }

        /// <summary>
        /// 批量查询vpc是否已经添加私有域名解析
        /// </summary>
        /// <param name="req"><see cref="DescribeInternalEndpointDnsStatusRequest"/></param>
        /// <returns><see cref="DescribeInternalEndpointDnsStatusResponse"/></returns>
        public DescribeInternalEndpointDnsStatusResponse DescribeInternalEndpointDnsStatusSync(DescribeInternalEndpointDnsStatusRequest req)
        {
            return InternalRequestAsync<DescribeInternalEndpointDnsStatusResponse>(req, "DescribeInternalEndpointDnsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例内网访问VPC链接
        /// </summary>
        /// <param name="req"><see cref="DescribeInternalEndpointsRequest"/></param>
        /// <returns><see cref="DescribeInternalEndpointsResponse"/></returns>
        public Task<DescribeInternalEndpointsResponse> DescribeInternalEndpoints(DescribeInternalEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeInternalEndpointsResponse>(req, "DescribeInternalEndpoints");
        }

        /// <summary>
        /// 查询实例内网访问VPC链接
        /// </summary>
        /// <param name="req"><see cref="DescribeInternalEndpointsRequest"/></param>
        /// <returns><see cref="DescribeInternalEndpointsResponse"/></returns>
        public DescribeInternalEndpointsResponse DescribeInternalEndpointsSync(DescribeInternalEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeInternalEndpointsResponse>(req, "DescribeInternalEndpoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询个人版命名空间信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacePersonalRequest"/></param>
        /// <returns><see cref="DescribeNamespacePersonalResponse"/></returns>
        public Task<DescribeNamespacePersonalResponse> DescribeNamespacePersonal(DescribeNamespacePersonalRequest req)
        {
            return InternalRequestAsync<DescribeNamespacePersonalResponse>(req, "DescribeNamespacePersonal");
        }

        /// <summary>
        /// 查询个人版命名空间信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacePersonalRequest"/></param>
        /// <returns><see cref="DescribeNamespacePersonalResponse"/></returns>
        public DescribeNamespacePersonalResponse DescribeNamespacePersonalSync(DescribeNamespacePersonalRequest req)
        {
            return InternalRequestAsync<DescribeNamespacePersonalResponse>(req, "DescribeNamespacePersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询命名空间列表或指定命名空间信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacesRequest"/></param>
        /// <returns><see cref="DescribeNamespacesResponse"/></returns>
        public Task<DescribeNamespacesResponse> DescribeNamespaces(DescribeNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeNamespacesResponse>(req, "DescribeNamespaces");
        }

        /// <summary>
        /// 查询命名空间列表或指定命名空间信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacesRequest"/></param>
        /// <returns><see cref="DescribeNamespacesResponse"/></returns>
        public DescribeNamespacesResponse DescribeNamespacesSync(DescribeNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeNamespacesResponse>(req, "DescribeNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于在TCR中获取可用区域
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// 用于在TCR中获取可用区域
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询创建从实例任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceCreateTasksRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceCreateTasksResponse"/></returns>
        public Task<DescribeReplicationInstanceCreateTasksResponse> DescribeReplicationInstanceCreateTasks(DescribeReplicationInstanceCreateTasksRequest req)
        {
            return InternalRequestAsync<DescribeReplicationInstanceCreateTasksResponse>(req, "DescribeReplicationInstanceCreateTasks");
        }

        /// <summary>
        /// 查询创建从实例任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceCreateTasksRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceCreateTasksResponse"/></returns>
        public DescribeReplicationInstanceCreateTasksResponse DescribeReplicationInstanceCreateTasksSync(DescribeReplicationInstanceCreateTasksRequest req)
        {
            return InternalRequestAsync<DescribeReplicationInstanceCreateTasksResponse>(req, "DescribeReplicationInstanceCreateTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询从实例同步状态
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceSyncStatusRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceSyncStatusResponse"/></returns>
        public Task<DescribeReplicationInstanceSyncStatusResponse> DescribeReplicationInstanceSyncStatus(DescribeReplicationInstanceSyncStatusRequest req)
        {
            return InternalRequestAsync<DescribeReplicationInstanceSyncStatusResponse>(req, "DescribeReplicationInstanceSyncStatus");
        }

        /// <summary>
        /// 查询从实例同步状态
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceSyncStatusRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceSyncStatusResponse"/></returns>
        public DescribeReplicationInstanceSyncStatusResponse DescribeReplicationInstanceSyncStatusSync(DescribeReplicationInstanceSyncStatusRequest req)
        {
            return InternalRequestAsync<DescribeReplicationInstanceSyncStatusResponse>(req, "DescribeReplicationInstanceSyncStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询从实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstancesRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstancesResponse"/></returns>
        public Task<DescribeReplicationInstancesResponse> DescribeReplicationInstances(DescribeReplicationInstancesRequest req)
        {
            return InternalRequestAsync<DescribeReplicationInstancesResponse>(req, "DescribeReplicationInstances");
        }

        /// <summary>
        /// 查询从实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstancesRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstancesResponse"/></returns>
        public DescribeReplicationInstancesResponse DescribeReplicationInstancesSync(DescribeReplicationInstancesRequest req)
        {
            return InternalRequestAsync<DescribeReplicationInstancesResponse>(req, "DescribeReplicationInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像仓库列表或指定镜像仓库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoriesRequest"/></param>
        /// <returns><see cref="DescribeRepositoriesResponse"/></returns>
        public Task<DescribeRepositoriesResponse> DescribeRepositories(DescribeRepositoriesRequest req)
        {
            return InternalRequestAsync<DescribeRepositoriesResponse>(req, "DescribeRepositories");
        }

        /// <summary>
        /// 查询镜像仓库列表或指定镜像仓库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoriesRequest"/></param>
        /// <returns><see cref="DescribeRepositoriesResponse"/></returns>
        public DescribeRepositoriesResponse DescribeRepositoriesSync(DescribeRepositoriesRequest req)
        {
            return InternalRequestAsync<DescribeRepositoriesResponse>(req, "DescribeRepositories")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于在个人版镜像仓库中，获取满足输入搜索条件的用户镜像仓库
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryFilterPersonalRequest"/></param>
        /// <returns><see cref="DescribeRepositoryFilterPersonalResponse"/></returns>
        public Task<DescribeRepositoryFilterPersonalResponse> DescribeRepositoryFilterPersonal(DescribeRepositoryFilterPersonalRequest req)
        {
            return InternalRequestAsync<DescribeRepositoryFilterPersonalResponse>(req, "DescribeRepositoryFilterPersonal");
        }

        /// <summary>
        /// 用于在个人版镜像仓库中，获取满足输入搜索条件的用户镜像仓库
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryFilterPersonalRequest"/></param>
        /// <returns><see cref="DescribeRepositoryFilterPersonalResponse"/></returns>
        public DescribeRepositoryFilterPersonalResponse DescribeRepositoryFilterPersonalSync(DescribeRepositoryFilterPersonalRequest req)
        {
            return InternalRequestAsync<DescribeRepositoryFilterPersonalResponse>(req, "DescribeRepositoryFilterPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于在个人版中获取用户全部的镜像仓库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryOwnerPersonalRequest"/></param>
        /// <returns><see cref="DescribeRepositoryOwnerPersonalResponse"/></returns>
        public Task<DescribeRepositoryOwnerPersonalResponse> DescribeRepositoryOwnerPersonal(DescribeRepositoryOwnerPersonalRequest req)
        {
            return InternalRequestAsync<DescribeRepositoryOwnerPersonalResponse>(req, "DescribeRepositoryOwnerPersonal");
        }

        /// <summary>
        /// 用于在个人版中获取用户全部的镜像仓库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryOwnerPersonalRequest"/></param>
        /// <returns><see cref="DescribeRepositoryOwnerPersonalResponse"/></returns>
        public DescribeRepositoryOwnerPersonalResponse DescribeRepositoryOwnerPersonalSync(DescribeRepositoryOwnerPersonalRequest req)
        {
            return InternalRequestAsync<DescribeRepositoryOwnerPersonalResponse>(req, "DescribeRepositoryOwnerPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询个人版仓库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryPersonalRequest"/></param>
        /// <returns><see cref="DescribeRepositoryPersonalResponse"/></returns>
        public Task<DescribeRepositoryPersonalResponse> DescribeRepositoryPersonal(DescribeRepositoryPersonalRequest req)
        {
            return InternalRequestAsync<DescribeRepositoryPersonalResponse>(req, "DescribeRepositoryPersonal");
        }

        /// <summary>
        /// 查询个人版仓库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryPersonalRequest"/></param>
        /// <returns><see cref="DescribeRepositoryPersonalResponse"/></returns>
        public DescribeRepositoryPersonalResponse DescribeRepositoryPersonalSync(DescribeRepositoryPersonalRequest req)
        {
            return InternalRequestAsync<DescribeRepositoryPersonalResponse>(req, "DescribeRepositoryPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例公网访问白名单策略
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPoliciesResponse"/></returns>
        public Task<DescribeSecurityPoliciesResponse> DescribeSecurityPolicies(DescribeSecurityPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPoliciesResponse>(req, "DescribeSecurityPolicies");
        }

        /// <summary>
        /// 查询实例公网访问白名单策略
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPoliciesResponse"/></returns>
        public DescribeSecurityPoliciesResponse DescribeSecurityPoliciesSync(DescribeSecurityPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPoliciesResponse>(req, "DescribeSecurityPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询服务级账号
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceAccountsRequest"/></param>
        /// <returns><see cref="DescribeServiceAccountsResponse"/></returns>
        public Task<DescribeServiceAccountsResponse> DescribeServiceAccounts(DescribeServiceAccountsRequest req)
        {
            return InternalRequestAsync<DescribeServiceAccountsResponse>(req, "DescribeServiceAccounts");
        }

        /// <summary>
        /// 查询服务级账号
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceAccountsRequest"/></param>
        /// <returns><see cref="DescribeServiceAccountsResponse"/></returns>
        public DescribeServiceAccountsResponse DescribeServiceAccountsSync(DescribeServiceAccountsRequest req)
        {
            return InternalRequestAsync<DescribeServiceAccountsResponse>(req, "DescribeServiceAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询版本保留执行记录
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionExecutionRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionExecutionResponse"/></returns>
        public Task<DescribeTagRetentionExecutionResponse> DescribeTagRetentionExecution(DescribeTagRetentionExecutionRequest req)
        {
            return InternalRequestAsync<DescribeTagRetentionExecutionResponse>(req, "DescribeTagRetentionExecution");
        }

        /// <summary>
        /// 查询版本保留执行记录
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionExecutionRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionExecutionResponse"/></returns>
        public DescribeTagRetentionExecutionResponse DescribeTagRetentionExecutionSync(DescribeTagRetentionExecutionRequest req)
        {
            return InternalRequestAsync<DescribeTagRetentionExecutionResponse>(req, "DescribeTagRetentionExecution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询版本保留执行任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionExecutionTaskRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionExecutionTaskResponse"/></returns>
        public Task<DescribeTagRetentionExecutionTaskResponse> DescribeTagRetentionExecutionTask(DescribeTagRetentionExecutionTaskRequest req)
        {
            return InternalRequestAsync<DescribeTagRetentionExecutionTaskResponse>(req, "DescribeTagRetentionExecutionTask");
        }

        /// <summary>
        /// 查询版本保留执行任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionExecutionTaskRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionExecutionTaskResponse"/></returns>
        public DescribeTagRetentionExecutionTaskResponse DescribeTagRetentionExecutionTaskSync(DescribeTagRetentionExecutionTaskRequest req)
        {
            return InternalRequestAsync<DescribeTagRetentionExecutionTaskResponse>(req, "DescribeTagRetentionExecutionTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询版本保留规则
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionRulesRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionRulesResponse"/></returns>
        public Task<DescribeTagRetentionRulesResponse> DescribeTagRetentionRules(DescribeTagRetentionRulesRequest req)
        {
            return InternalRequestAsync<DescribeTagRetentionRulesResponse>(req, "DescribeTagRetentionRules");
        }

        /// <summary>
        /// 查询版本保留规则
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRetentionRulesRequest"/></param>
        /// <returns><see cref="DescribeTagRetentionRulesResponse"/></returns>
        public DescribeTagRetentionRulesResponse DescribeTagRetentionRulesSync(DescribeTagRetentionRulesRequest req)
        {
            return InternalRequestAsync<DescribeTagRetentionRulesResponse>(req, "DescribeTagRetentionRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询个人用户配额
        /// </summary>
        /// <param name="req"><see cref="DescribeUserQuotaPersonalRequest"/></param>
        /// <returns><see cref="DescribeUserQuotaPersonalResponse"/></returns>
        public Task<DescribeUserQuotaPersonalResponse> DescribeUserQuotaPersonal(DescribeUserQuotaPersonalRequest req)
        {
            return InternalRequestAsync<DescribeUserQuotaPersonalResponse>(req, "DescribeUserQuotaPersonal");
        }

        /// <summary>
        /// 查询个人用户配额
        /// </summary>
        /// <param name="req"><see cref="DescribeUserQuotaPersonalRequest"/></param>
        /// <returns><see cref="DescribeUserQuotaPersonalResponse"/></returns>
        public DescribeUserQuotaPersonalResponse DescribeUserQuotaPersonalSync(DescribeUserQuotaPersonalRequest req)
        {
            return InternalRequestAsync<DescribeUserQuotaPersonalResponse>(req, "DescribeUserQuotaPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询触发器
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookTriggerRequest"/></param>
        /// <returns><see cref="DescribeWebhookTriggerResponse"/></returns>
        public Task<DescribeWebhookTriggerResponse> DescribeWebhookTrigger(DescribeWebhookTriggerRequest req)
        {
            return InternalRequestAsync<DescribeWebhookTriggerResponse>(req, "DescribeWebhookTrigger");
        }

        /// <summary>
        /// 查询触发器
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookTriggerRequest"/></param>
        /// <returns><see cref="DescribeWebhookTriggerResponse"/></returns>
        public DescribeWebhookTriggerResponse DescribeWebhookTriggerSync(DescribeWebhookTriggerRequest req)
        {
            return InternalRequestAsync<DescribeWebhookTriggerResponse>(req, "DescribeWebhookTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取触发器日志
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookTriggerLogRequest"/></param>
        /// <returns><see cref="DescribeWebhookTriggerLogResponse"/></returns>
        public Task<DescribeWebhookTriggerLogResponse> DescribeWebhookTriggerLog(DescribeWebhookTriggerLogRequest req)
        {
            return InternalRequestAsync<DescribeWebhookTriggerLogResponse>(req, "DescribeWebhookTriggerLog");
        }

        /// <summary>
        /// 获取触发器日志
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookTriggerLogRequest"/></param>
        /// <returns><see cref="DescribeWebhookTriggerLogResponse"/></returns>
        public DescribeWebhookTriggerLogResponse DescribeWebhookTriggerLogSync(DescribeWebhookTriggerLogRequest req)
        {
            return InternalRequestAsync<DescribeWebhookTriggerLogResponse>(req, "DescribeWebhookTriggerLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于在TCR中下载helm chart
        /// </summary>
        /// <param name="req"><see cref="DownloadHelmChartRequest"/></param>
        /// <returns><see cref="DownloadHelmChartResponse"/></returns>
        public Task<DownloadHelmChartResponse> DownloadHelmChart(DownloadHelmChartRequest req)
        {
            return InternalRequestAsync<DownloadHelmChartResponse>(req, "DownloadHelmChart");
        }

        /// <summary>
        /// 用于在TCR中下载helm chart
        /// </summary>
        /// <param name="req"><see cref="DownloadHelmChartRequest"/></param>
        /// <returns><see cref="DownloadHelmChartResponse"/></returns>
        public DownloadHelmChartResponse DownloadHelmChartSync(DownloadHelmChartRequest req)
        {
            return InternalRequestAsync<DownloadHelmChartResponse>(req, "DownloadHelmChart")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于在企业版镜像仓库中复制镜像版本
        /// </summary>
        /// <param name="req"><see cref="DuplicateImageRequest"/></param>
        /// <returns><see cref="DuplicateImageResponse"/></returns>
        public Task<DuplicateImageResponse> DuplicateImage(DuplicateImageRequest req)
        {
            return InternalRequestAsync<DuplicateImageResponse>(req, "DuplicateImage");
        }

        /// <summary>
        /// 用于在企业版镜像仓库中复制镜像版本
        /// </summary>
        /// <param name="req"><see cref="DuplicateImageRequest"/></param>
        /// <returns><see cref="DuplicateImageResponse"/></returns>
        public DuplicateImageResponse DuplicateImageSync(DuplicateImageRequest req)
        {
            return InternalRequestAsync<DuplicateImageResponse>(req, "DuplicateImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于在个人版镜像仓库中复制镜像版本
        /// </summary>
        /// <param name="req"><see cref="DuplicateImagePersonalRequest"/></param>
        /// <returns><see cref="DuplicateImagePersonalResponse"/></returns>
        public Task<DuplicateImagePersonalResponse> DuplicateImagePersonal(DuplicateImagePersonalRequest req)
        {
            return InternalRequestAsync<DuplicateImagePersonalResponse>(req, "DuplicateImagePersonal");
        }

        /// <summary>
        /// 用于在个人版镜像仓库中复制镜像版本
        /// </summary>
        /// <param name="req"><see cref="DuplicateImagePersonalRequest"/></param>
        /// <returns><see cref="DuplicateImagePersonalResponse"/></returns>
        public DuplicateImagePersonalResponse DuplicateImagePersonalSync(DuplicateImagePersonalRequest req)
        {
            return InternalRequestAsync<DuplicateImagePersonalResponse>(req, "DuplicateImagePersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 管理实例公网访问
        /// </summary>
        /// <param name="req"><see cref="ManageExternalEndpointRequest"/></param>
        /// <returns><see cref="ManageExternalEndpointResponse"/></returns>
        public Task<ManageExternalEndpointResponse> ManageExternalEndpoint(ManageExternalEndpointRequest req)
        {
            return InternalRequestAsync<ManageExternalEndpointResponse>(req, "ManageExternalEndpoint");
        }

        /// <summary>
        /// 管理实例公网访问
        /// </summary>
        /// <param name="req"><see cref="ManageExternalEndpointRequest"/></param>
        /// <returns><see cref="ManageExternalEndpointResponse"/></returns>
        public ManageExternalEndpointResponse ManageExternalEndpointSync(ManageExternalEndpointRequest req)
        {
            return InternalRequestAsync<ManageExternalEndpointResponse>(req, "ManageExternalEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于设置个人版全局镜像版本自动清理策略
        /// </summary>
        /// <param name="req"><see cref="ManageImageLifecycleGlobalPersonalRequest"/></param>
        /// <returns><see cref="ManageImageLifecycleGlobalPersonalResponse"/></returns>
        public Task<ManageImageLifecycleGlobalPersonalResponse> ManageImageLifecycleGlobalPersonal(ManageImageLifecycleGlobalPersonalRequest req)
        {
            return InternalRequestAsync<ManageImageLifecycleGlobalPersonalResponse>(req, "ManageImageLifecycleGlobalPersonal");
        }

        /// <summary>
        /// 用于设置个人版全局镜像版本自动清理策略
        /// </summary>
        /// <param name="req"><see cref="ManageImageLifecycleGlobalPersonalRequest"/></param>
        /// <returns><see cref="ManageImageLifecycleGlobalPersonalResponse"/></returns>
        public ManageImageLifecycleGlobalPersonalResponse ManageImageLifecycleGlobalPersonalSync(ManageImageLifecycleGlobalPersonalRequest req)
        {
            return InternalRequestAsync<ManageImageLifecycleGlobalPersonalResponse>(req, "ManageImageLifecycleGlobalPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 管理实例内网访问VPC链接
        /// </summary>
        /// <param name="req"><see cref="ManageInternalEndpointRequest"/></param>
        /// <returns><see cref="ManageInternalEndpointResponse"/></returns>
        public Task<ManageInternalEndpointResponse> ManageInternalEndpoint(ManageInternalEndpointRequest req)
        {
            return InternalRequestAsync<ManageInternalEndpointResponse>(req, "ManageInternalEndpoint");
        }

        /// <summary>
        /// 管理实例内网访问VPC链接
        /// </summary>
        /// <param name="req"><see cref="ManageInternalEndpointRequest"/></param>
        /// <returns><see cref="ManageInternalEndpointResponse"/></returns>
        public ManageInternalEndpointResponse ManageInternalEndpointSync(ManageInternalEndpointRequest req)
        {
            return InternalRequestAsync<ManageInternalEndpointResponse>(req, "ManageInternalEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 管理实例同步
        /// </summary>
        /// <param name="req"><see cref="ManageReplicationRequest"/></param>
        /// <returns><see cref="ManageReplicationResponse"/></returns>
        public Task<ManageReplicationResponse> ManageReplication(ManageReplicationRequest req)
        {
            return InternalRequestAsync<ManageReplicationResponse>(req, "ManageReplication");
        }

        /// <summary>
        /// 管理实例同步
        /// </summary>
        /// <param name="req"><see cref="ManageReplicationRequest"/></param>
        /// <returns><see cref="ManageReplicationResponse"/></returns>
        public ManageReplicationResponse ManageReplicationSync(ManageReplicationRequest req)
        {
            return InternalRequestAsync<ManageReplicationResponse>(req, "ManageReplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改应用更新触发器
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationTriggerPersonalRequest"/></param>
        /// <returns><see cref="ModifyApplicationTriggerPersonalResponse"/></returns>
        public Task<ModifyApplicationTriggerPersonalResponse> ModifyApplicationTriggerPersonal(ModifyApplicationTriggerPersonalRequest req)
        {
            return InternalRequestAsync<ModifyApplicationTriggerPersonalResponse>(req, "ModifyApplicationTriggerPersonal");
        }

        /// <summary>
        /// 用于修改应用更新触发器
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationTriggerPersonalRequest"/></param>
        /// <returns><see cref="ModifyApplicationTriggerPersonalResponse"/></returns>
        public ModifyApplicationTriggerPersonalResponse ModifyApplicationTriggerPersonalSync(ModifyApplicationTriggerPersonalRequest req)
        {
            return InternalRequestAsync<ModifyApplicationTriggerPersonalResponse>(req, "ModifyApplicationTriggerPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新镜像不可变规则
        /// </summary>
        /// <param name="req"><see cref="ModifyImmutableTagRulesRequest"/></param>
        /// <returns><see cref="ModifyImmutableTagRulesResponse"/></returns>
        public Task<ModifyImmutableTagRulesResponse> ModifyImmutableTagRules(ModifyImmutableTagRulesRequest req)
        {
            return InternalRequestAsync<ModifyImmutableTagRulesResponse>(req, "ModifyImmutableTagRules");
        }

        /// <summary>
        /// 更新镜像不可变规则
        /// </summary>
        /// <param name="req"><see cref="ModifyImmutableTagRulesRequest"/></param>
        /// <returns><see cref="ModifyImmutableTagRulesResponse"/></returns>
        public ModifyImmutableTagRulesResponse ModifyImmutableTagRulesSync(ModifyImmutableTagRulesRequest req)
        {
            return InternalRequestAsync<ModifyImmutableTagRulesResponse>(req, "ModifyImmutableTagRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新实例信息
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// 更新实例信息
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新实例内指定长期访问凭证的启用状态
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceTokenRequest"/></param>
        /// <returns><see cref="ModifyInstanceTokenResponse"/></returns>
        public Task<ModifyInstanceTokenResponse> ModifyInstanceToken(ModifyInstanceTokenRequest req)
        {
            return InternalRequestAsync<ModifyInstanceTokenResponse>(req, "ModifyInstanceToken");
        }

        /// <summary>
        /// 更新实例内指定长期访问凭证的启用状态
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceTokenRequest"/></param>
        /// <returns><see cref="ModifyInstanceTokenResponse"/></returns>
        public ModifyInstanceTokenResponse ModifyInstanceTokenSync(ModifyInstanceTokenRequest req)
        {
            return InternalRequestAsync<ModifyInstanceTokenResponse>(req, "ModifyInstanceToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新命名空间信息
        /// </summary>
        /// <param name="req"><see cref="ModifyNamespaceRequest"/></param>
        /// <returns><see cref="ModifyNamespaceResponse"/></returns>
        public Task<ModifyNamespaceResponse> ModifyNamespace(ModifyNamespaceRequest req)
        {
            return InternalRequestAsync<ModifyNamespaceResponse>(req, "ModifyNamespace");
        }

        /// <summary>
        /// 更新命名空间信息
        /// </summary>
        /// <param name="req"><see cref="ModifyNamespaceRequest"/></param>
        /// <returns><see cref="ModifyNamespaceResponse"/></returns>
        public ModifyNamespaceResponse ModifyNamespaceSync(ModifyNamespaceRequest req)
        {
            return InternalRequestAsync<ModifyNamespaceResponse>(req, "ModifyNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新镜像仓库信息，可修改仓库描述信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRepositoryRequest"/></param>
        /// <returns><see cref="ModifyRepositoryResponse"/></returns>
        public Task<ModifyRepositoryResponse> ModifyRepository(ModifyRepositoryRequest req)
        {
            return InternalRequestAsync<ModifyRepositoryResponse>(req, "ModifyRepository");
        }

        /// <summary>
        /// 更新镜像仓库信息，可修改仓库描述信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRepositoryRequest"/></param>
        /// <returns><see cref="ModifyRepositoryResponse"/></returns>
        public ModifyRepositoryResponse ModifyRepositorySync(ModifyRepositoryRequest req)
        {
            return InternalRequestAsync<ModifyRepositoryResponse>(req, "ModifyRepository")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于更新个人版镜像仓库的访问属性
        /// </summary>
        /// <param name="req"><see cref="ModifyRepositoryAccessPersonalRequest"/></param>
        /// <returns><see cref="ModifyRepositoryAccessPersonalResponse"/></returns>
        public Task<ModifyRepositoryAccessPersonalResponse> ModifyRepositoryAccessPersonal(ModifyRepositoryAccessPersonalRequest req)
        {
            return InternalRequestAsync<ModifyRepositoryAccessPersonalResponse>(req, "ModifyRepositoryAccessPersonal");
        }

        /// <summary>
        /// 用于更新个人版镜像仓库的访问属性
        /// </summary>
        /// <param name="req"><see cref="ModifyRepositoryAccessPersonalRequest"/></param>
        /// <returns><see cref="ModifyRepositoryAccessPersonalResponse"/></returns>
        public ModifyRepositoryAccessPersonalResponse ModifyRepositoryAccessPersonalSync(ModifyRepositoryAccessPersonalRequest req)
        {
            return InternalRequestAsync<ModifyRepositoryAccessPersonalResponse>(req, "ModifyRepositoryAccessPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于在个人版镜像仓库中更新容器镜像描述
        /// </summary>
        /// <param name="req"><see cref="ModifyRepositoryInfoPersonalRequest"/></param>
        /// <returns><see cref="ModifyRepositoryInfoPersonalResponse"/></returns>
        public Task<ModifyRepositoryInfoPersonalResponse> ModifyRepositoryInfoPersonal(ModifyRepositoryInfoPersonalRequest req)
        {
            return InternalRequestAsync<ModifyRepositoryInfoPersonalResponse>(req, "ModifyRepositoryInfoPersonal");
        }

        /// <summary>
        /// 用于在个人版镜像仓库中更新容器镜像描述
        /// </summary>
        /// <param name="req"><see cref="ModifyRepositoryInfoPersonalRequest"/></param>
        /// <returns><see cref="ModifyRepositoryInfoPersonalResponse"/></returns>
        public ModifyRepositoryInfoPersonalResponse ModifyRepositoryInfoPersonalSync(ModifyRepositoryInfoPersonalRequest req)
        {
            return InternalRequestAsync<ModifyRepositoryInfoPersonalResponse>(req, "ModifyRepositoryInfoPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新实例公网访问白名单
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public Task<ModifySecurityPolicyResponse> ModifySecurityPolicy(ModifySecurityPolicyRequest req)
        {
            return InternalRequestAsync<ModifySecurityPolicyResponse>(req, "ModifySecurityPolicy");
        }

        /// <summary>
        /// 更新实例公网访问白名单
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public ModifySecurityPolicyResponse ModifySecurityPolicySync(ModifySecurityPolicyRequest req)
        {
            return InternalRequestAsync<ModifySecurityPolicyResponse>(req, "ModifySecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新服务级账号
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceAccountRequest"/></param>
        /// <returns><see cref="ModifyServiceAccountResponse"/></returns>
        public Task<ModifyServiceAccountResponse> ModifyServiceAccount(ModifyServiceAccountRequest req)
        {
            return InternalRequestAsync<ModifyServiceAccountResponse>(req, "ModifyServiceAccount");
        }

        /// <summary>
        /// 更新服务级账号
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceAccountRequest"/></param>
        /// <returns><see cref="ModifyServiceAccountResponse"/></returns>
        public ModifyServiceAccountResponse ModifyServiceAccountSync(ModifyServiceAccountRequest req)
        {
            return InternalRequestAsync<ModifyServiceAccountResponse>(req, "ModifyServiceAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新服务级账号密码
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceAccountPasswordRequest"/></param>
        /// <returns><see cref="ModifyServiceAccountPasswordResponse"/></returns>
        public Task<ModifyServiceAccountPasswordResponse> ModifyServiceAccountPassword(ModifyServiceAccountPasswordRequest req)
        {
            return InternalRequestAsync<ModifyServiceAccountPasswordResponse>(req, "ModifyServiceAccountPassword");
        }

        /// <summary>
        /// 更新服务级账号密码
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceAccountPasswordRequest"/></param>
        /// <returns><see cref="ModifyServiceAccountPasswordResponse"/></returns>
        public ModifyServiceAccountPasswordResponse ModifyServiceAccountPasswordSync(ModifyServiceAccountPasswordRequest req)
        {
            return InternalRequestAsync<ModifyServiceAccountPasswordResponse>(req, "ModifyServiceAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新版本保留规则
        /// </summary>
        /// <param name="req"><see cref="ModifyTagRetentionRuleRequest"/></param>
        /// <returns><see cref="ModifyTagRetentionRuleResponse"/></returns>
        public Task<ModifyTagRetentionRuleResponse> ModifyTagRetentionRule(ModifyTagRetentionRuleRequest req)
        {
            return InternalRequestAsync<ModifyTagRetentionRuleResponse>(req, "ModifyTagRetentionRule");
        }

        /// <summary>
        /// 更新版本保留规则
        /// </summary>
        /// <param name="req"><see cref="ModifyTagRetentionRuleRequest"/></param>
        /// <returns><see cref="ModifyTagRetentionRuleResponse"/></returns>
        public ModifyTagRetentionRuleResponse ModifyTagRetentionRuleSync(ModifyTagRetentionRuleRequest req)
        {
            return InternalRequestAsync<ModifyTagRetentionRuleResponse>(req, "ModifyTagRetentionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改个人用户登录密码
        /// </summary>
        /// <param name="req"><see cref="ModifyUserPasswordPersonalRequest"/></param>
        /// <returns><see cref="ModifyUserPasswordPersonalResponse"/></returns>
        public Task<ModifyUserPasswordPersonalResponse> ModifyUserPasswordPersonal(ModifyUserPasswordPersonalRequest req)
        {
            return InternalRequestAsync<ModifyUserPasswordPersonalResponse>(req, "ModifyUserPasswordPersonal");
        }

        /// <summary>
        /// 修改个人用户登录密码
        /// </summary>
        /// <param name="req"><see cref="ModifyUserPasswordPersonalRequest"/></param>
        /// <returns><see cref="ModifyUserPasswordPersonalResponse"/></returns>
        public ModifyUserPasswordPersonalResponse ModifyUserPasswordPersonalSync(ModifyUserPasswordPersonalRequest req)
        {
            return InternalRequestAsync<ModifyUserPasswordPersonalResponse>(req, "ModifyUserPasswordPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新触发器
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookTriggerRequest"/></param>
        /// <returns><see cref="ModifyWebhookTriggerResponse"/></returns>
        public Task<ModifyWebhookTriggerResponse> ModifyWebhookTrigger(ModifyWebhookTriggerRequest req)
        {
            return InternalRequestAsync<ModifyWebhookTriggerResponse>(req, "ModifyWebhookTrigger");
        }

        /// <summary>
        /// 更新触发器
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookTriggerRequest"/></param>
        /// <returns><see cref="ModifyWebhookTriggerResponse"/></returns>
        public ModifyWebhookTriggerResponse ModifyWebhookTriggerSync(ModifyWebhookTriggerRequest req)
        {
            return InternalRequestAsync<ModifyWebhookTriggerResponse>(req, "ModifyWebhookTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 预付费实例续费，同时支持按量计费转包年包月
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public Task<RenewInstanceResponse> RenewInstance(RenewInstanceRequest req)
        {
            return InternalRequestAsync<RenewInstanceResponse>(req, "RenewInstance");
        }

        /// <summary>
        /// 预付费实例续费，同时支持按量计费转包年包月
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public RenewInstanceResponse RenewInstanceSync(RenewInstanceRequest req)
        {
            return InternalRequestAsync<RenewInstanceResponse>(req, "RenewInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询个人版用户命名空间是否存在
        /// </summary>
        /// <param name="req"><see cref="ValidateNamespaceExistPersonalRequest"/></param>
        /// <returns><see cref="ValidateNamespaceExistPersonalResponse"/></returns>
        public Task<ValidateNamespaceExistPersonalResponse> ValidateNamespaceExistPersonal(ValidateNamespaceExistPersonalRequest req)
        {
            return InternalRequestAsync<ValidateNamespaceExistPersonalResponse>(req, "ValidateNamespaceExistPersonal");
        }

        /// <summary>
        /// 查询个人版用户命名空间是否存在
        /// </summary>
        /// <param name="req"><see cref="ValidateNamespaceExistPersonalRequest"/></param>
        /// <returns><see cref="ValidateNamespaceExistPersonalResponse"/></returns>
        public ValidateNamespaceExistPersonalResponse ValidateNamespaceExistPersonalSync(ValidateNamespaceExistPersonalRequest req)
        {
            return InternalRequestAsync<ValidateNamespaceExistPersonalResponse>(req, "ValidateNamespaceExistPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于判断个人版仓库是否存在
        /// </summary>
        /// <param name="req"><see cref="ValidateRepositoryExistPersonalRequest"/></param>
        /// <returns><see cref="ValidateRepositoryExistPersonalResponse"/></returns>
        public Task<ValidateRepositoryExistPersonalResponse> ValidateRepositoryExistPersonal(ValidateRepositoryExistPersonalRequest req)
        {
            return InternalRequestAsync<ValidateRepositoryExistPersonalResponse>(req, "ValidateRepositoryExistPersonal");
        }

        /// <summary>
        /// 用于判断个人版仓库是否存在
        /// </summary>
        /// <param name="req"><see cref="ValidateRepositoryExistPersonalRequest"/></param>
        /// <returns><see cref="ValidateRepositoryExistPersonalResponse"/></returns>
        public ValidateRepositoryExistPersonalResponse ValidateRepositoryExistPersonalSync(ValidateRepositoryExistPersonalRequest req)
        {
            return InternalRequestAsync<ValidateRepositoryExistPersonalResponse>(req, "ValidateRepositoryExistPersonal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
