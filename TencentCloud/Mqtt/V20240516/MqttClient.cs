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

namespace TencentCloud.Mqtt.V20240516
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mqtt.V20240516.Models;

   public class MqttClient : AbstractClient{

       private const string endpoint = "mqtt.tencentcloudapi.com";
       private const string version = "2024-05-16";
       private const string sdkVersion = "SDK_NET_3.0.1119";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MqttClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MqttClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建MQTT实例的性能测试任务
        /// </summary>
        /// <param name="req"><see cref="CreateAuthorizationPolicyRequest"/></param>
        /// <returns><see cref="CreateAuthorizationPolicyResponse"/></returns>
        public Task<CreateAuthorizationPolicyResponse> CreateAuthorizationPolicy(CreateAuthorizationPolicyRequest req)
        {
            return InternalRequestAsync<CreateAuthorizationPolicyResponse>(req, "CreateAuthorizationPolicy");
        }

        /// <summary>
        /// 创建MQTT实例的性能测试任务
        /// </summary>
        /// <param name="req"><see cref="CreateAuthorizationPolicyRequest"/></param>
        /// <returns><see cref="CreateAuthorizationPolicyResponse"/></returns>
        public CreateAuthorizationPolicyResponse CreateAuthorizationPolicySync(CreateAuthorizationPolicyRequest req)
        {
            return InternalRequestAsync<CreateAuthorizationPolicyResponse>(req, "CreateAuthorizationPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一个jwks的认证
        /// </summary>
        /// <param name="req"><see cref="CreateJWKSAuthenticatorRequest"/></param>
        /// <returns><see cref="CreateJWKSAuthenticatorResponse"/></returns>
        public Task<CreateJWKSAuthenticatorResponse> CreateJWKSAuthenticator(CreateJWKSAuthenticatorRequest req)
        {
            return InternalRequestAsync<CreateJWKSAuthenticatorResponse>(req, "CreateJWKSAuthenticator");
        }

        /// <summary>
        /// 创建一个jwks的认证
        /// </summary>
        /// <param name="req"><see cref="CreateJWKSAuthenticatorRequest"/></param>
        /// <returns><see cref="CreateJWKSAuthenticatorResponse"/></returns>
        public CreateJWKSAuthenticatorResponse CreateJWKSAuthenticatorSync(CreateJWKSAuthenticatorRequest req)
        {
            return InternalRequestAsync<CreateJWKSAuthenticatorResponse>(req, "CreateJWKSAuthenticator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一个jwks的认证
        /// </summary>
        /// <param name="req"><see cref="CreateJWTAuthenticatorRequest"/></param>
        /// <returns><see cref="CreateJWTAuthenticatorResponse"/></returns>
        public Task<CreateJWTAuthenticatorResponse> CreateJWTAuthenticator(CreateJWTAuthenticatorRequest req)
        {
            return InternalRequestAsync<CreateJWTAuthenticatorResponse>(req, "CreateJWTAuthenticator");
        }

        /// <summary>
        /// 创建一个jwks的认证
        /// </summary>
        /// <param name="req"><see cref="CreateJWTAuthenticatorRequest"/></param>
        /// <returns><see cref="CreateJWTAuthenticatorResponse"/></returns>
        public CreateJWTAuthenticatorResponse CreateJWTAuthenticatorSync(CreateJWTAuthenticatorRequest req)
        {
            return InternalRequestAsync<CreateJWTAuthenticatorResponse>(req, "CreateJWTAuthenticator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建主题
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic");
        }

        /// <summary>
        /// 创建主题
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据认证器类型删除一个MQTT认证器
        /// </summary>
        /// <param name="req"><see cref="DeleteAuthenticatorRequest"/></param>
        /// <returns><see cref="DeleteAuthenticatorResponse"/></returns>
        public Task<DeleteAuthenticatorResponse> DeleteAuthenticator(DeleteAuthenticatorRequest req)
        {
            return InternalRequestAsync<DeleteAuthenticatorResponse>(req, "DeleteAuthenticator");
        }

        /// <summary>
        /// 根据认证器类型删除一个MQTT认证器
        /// </summary>
        /// <param name="req"><see cref="DeleteAuthenticatorRequest"/></param>
        /// <returns><see cref="DeleteAuthenticatorResponse"/></returns>
        public DeleteAuthenticatorResponse DeleteAuthenticatorSync(DeleteAuthenticatorRequest req)
        {
            return InternalRequestAsync<DeleteAuthenticatorResponse>(req, "DeleteAuthenticator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除策略规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAuthorizationPolicyRequest"/></param>
        /// <returns><see cref="DeleteAuthorizationPolicyResponse"/></returns>
        public Task<DeleteAuthorizationPolicyResponse> DeleteAuthorizationPolicy(DeleteAuthorizationPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAuthorizationPolicyResponse>(req, "DeleteAuthorizationPolicy");
        }

        /// <summary>
        /// 删除策略规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAuthorizationPolicyRequest"/></param>
        /// <returns><see cref="DeleteAuthorizationPolicyResponse"/></returns>
        public DeleteAuthorizationPolicyResponse DeleteAuthorizationPolicySync(DeleteAuthorizationPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAuthorizationPolicyResponse>(req, "DeleteAuthorizationPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除MQTT主题
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public Task<DeleteTopicResponse> DeleteTopic(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic");
        }

        /// <summary>
        /// 删除MQTT主题
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public DeleteTopicResponse DeleteTopicSync(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询MQTT认证器
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthenticatorRequest"/></param>
        /// <returns><see cref="DescribeAuthenticatorResponse"/></returns>
        public Task<DescribeAuthenticatorResponse> DescribeAuthenticator(DescribeAuthenticatorRequest req)
        {
            return InternalRequestAsync<DescribeAuthenticatorResponse>(req, "DescribeAuthenticator");
        }

        /// <summary>
        /// 查询MQTT认证器
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthenticatorRequest"/></param>
        /// <returns><see cref="DescribeAuthenticatorResponse"/></returns>
        public DescribeAuthenticatorResponse DescribeAuthenticatorSync(DescribeAuthenticatorRequest req)
        {
            return InternalRequestAsync<DescribeAuthenticatorResponse>(req, "DescribeAuthenticator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询授权规则
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthorizationPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAuthorizationPoliciesResponse"/></returns>
        public Task<DescribeAuthorizationPoliciesResponse> DescribeAuthorizationPolicies(DescribeAuthorizationPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAuthorizationPoliciesResponse>(req, "DescribeAuthorizationPolicies");
        }

        /// <summary>
        /// 查询授权规则
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthorizationPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAuthorizationPoliciesResponse"/></returns>
        public DescribeAuthorizationPoliciesResponse DescribeAuthorizationPoliciesSync(DescribeAuthorizationPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAuthorizationPoliciesResponse>(req, "DescribeAuthorizationPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance");
        }

        /// <summary>
        /// 查询实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public DescribeInstanceResponse DescribeInstanceSync(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例列表，Filters参数使用说明如下：
        /// 1. InstanceName, 名称模糊查询
        /// 2. InstanceId，实例ID查询
        /// 3. InstanceType, 实例类型查询，支持多选
        /// 3. InstanceStatus，实例状态查询，支持多选
        /// 
        /// 当使用TagFilters查询时，Filters参数失效。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public Task<DescribeInstanceListResponse> DescribeInstanceList(DescribeInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceListResponse>(req, "DescribeInstanceList");
        }

        /// <summary>
        /// 获取实例列表，Filters参数使用说明如下：
        /// 1. InstanceName, 名称模糊查询
        /// 2. InstanceId，实例ID查询
        /// 3. InstanceType, 实例类型查询，支持多选
        /// 3. InstanceStatus，实例状态查询，支持多选
        /// 
        /// 当使用TagFilters查询时，Filters参数失效。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public DescribeInstanceListResponse DescribeInstanceListSync(DescribeInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceListResponse>(req, "DescribeInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询mqtt主题详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRequest"/></param>
        /// <returns><see cref="DescribeTopicResponse"/></returns>
        public Task<DescribeTopicResponse> DescribeTopic(DescribeTopicRequest req)
        {
            return InternalRequestAsync<DescribeTopicResponse>(req, "DescribeTopic");
        }

        /// <summary>
        /// 查询mqtt主题详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRequest"/></param>
        /// <returns><see cref="DescribeTopicResponse"/></returns>
        public DescribeTopicResponse DescribeTopicSync(DescribeTopicRequest req)
        {
            return InternalRequestAsync<DescribeTopicResponse>(req, "DescribeTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取主题列表，Filter参数使用说明如下：
        /// 
        /// 1. TopicName，主题名称模糊搜索
        /// 2. TopicType，主题类型查询，支持多选，可选值：Normal,Order,Transaction,DelayScheduled
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicListRequest"/></param>
        /// <returns><see cref="DescribeTopicListResponse"/></returns>
        public Task<DescribeTopicListResponse> DescribeTopicList(DescribeTopicListRequest req)
        {
            return InternalRequestAsync<DescribeTopicListResponse>(req, "DescribeTopicList");
        }

        /// <summary>
        /// 获取主题列表，Filter参数使用说明如下：
        /// 
        /// 1. TopicName，主题名称模糊搜索
        /// 2. TopicType，主题类型查询，支持多选，可选值：Normal,Order,Transaction,DelayScheduled
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicListRequest"/></param>
        /// <returns><see cref="DescribeTopicListResponse"/></returns>
        public DescribeTopicListResponse DescribeTopicListSync(DescribeTopicListRequest req)
        {
            return InternalRequestAsync<DescribeTopicListResponse>(req, "DescribeTopicList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改策略规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAuthorizationPolicyRequest"/></param>
        /// <returns><see cref="ModifyAuthorizationPolicyResponse"/></returns>
        public Task<ModifyAuthorizationPolicyResponse> ModifyAuthorizationPolicy(ModifyAuthorizationPolicyRequest req)
        {
            return InternalRequestAsync<ModifyAuthorizationPolicyResponse>(req, "ModifyAuthorizationPolicy");
        }

        /// <summary>
        /// 修改策略规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAuthorizationPolicyRequest"/></param>
        /// <returns><see cref="ModifyAuthorizationPolicyResponse"/></returns>
        public ModifyAuthorizationPolicyResponse ModifyAuthorizationPolicySync(ModifyAuthorizationPolicyRequest req)
        {
            return InternalRequestAsync<ModifyAuthorizationPolicyResponse>(req, "ModifyAuthorizationPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改MQTT JWKS 认证器
        /// </summary>
        /// <param name="req"><see cref="ModifyJWKSAuthenticatorRequest"/></param>
        /// <returns><see cref="ModifyJWKSAuthenticatorResponse"/></returns>
        public Task<ModifyJWKSAuthenticatorResponse> ModifyJWKSAuthenticator(ModifyJWKSAuthenticatorRequest req)
        {
            return InternalRequestAsync<ModifyJWKSAuthenticatorResponse>(req, "ModifyJWKSAuthenticator");
        }

        /// <summary>
        /// 修改MQTT JWKS 认证器
        /// </summary>
        /// <param name="req"><see cref="ModifyJWKSAuthenticatorRequest"/></param>
        /// <returns><see cref="ModifyJWKSAuthenticatorResponse"/></returns>
        public ModifyJWKSAuthenticatorResponse ModifyJWKSAuthenticatorSync(ModifyJWKSAuthenticatorRequest req)
        {
            return InternalRequestAsync<ModifyJWKSAuthenticatorResponse>(req, "ModifyJWKSAuthenticator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改MQTT JWKS 认证器
        /// </summary>
        /// <param name="req"><see cref="ModifyJWTAuthenticatorRequest"/></param>
        /// <returns><see cref="ModifyJWTAuthenticatorResponse"/></returns>
        public Task<ModifyJWTAuthenticatorResponse> ModifyJWTAuthenticator(ModifyJWTAuthenticatorRequest req)
        {
            return InternalRequestAsync<ModifyJWTAuthenticatorResponse>(req, "ModifyJWTAuthenticator");
        }

        /// <summary>
        /// 修改MQTT JWKS 认证器
        /// </summary>
        /// <param name="req"><see cref="ModifyJWTAuthenticatorRequest"/></param>
        /// <returns><see cref="ModifyJWTAuthenticatorResponse"/></returns>
        public ModifyJWTAuthenticatorResponse ModifyJWTAuthenticatorSync(ModifyJWTAuthenticatorRequest req)
        {
            return InternalRequestAsync<ModifyJWTAuthenticatorResponse>(req, "ModifyJWTAuthenticator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改主题属性
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public Task<ModifyTopicResponse> ModifyTopic(ModifyTopicRequest req)
        {
            return InternalRequestAsync<ModifyTopicResponse>(req, "ModifyTopic");
        }

        /// <summary>
        /// 修改主题属性
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public ModifyTopicResponse ModifyTopicSync(ModifyTopicRequest req)
        {
            return InternalRequestAsync<ModifyTopicResponse>(req, "ModifyTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 注册设备证书
        /// </summary>
        /// <param name="req"><see cref="RegisterDeviceCertificateRequest"/></param>
        /// <returns><see cref="RegisterDeviceCertificateResponse"/></returns>
        public Task<RegisterDeviceCertificateResponse> RegisterDeviceCertificate(RegisterDeviceCertificateRequest req)
        {
            return InternalRequestAsync<RegisterDeviceCertificateResponse>(req, "RegisterDeviceCertificate");
        }

        /// <summary>
        /// 注册设备证书
        /// </summary>
        /// <param name="req"><see cref="RegisterDeviceCertificateRequest"/></param>
        /// <returns><see cref="RegisterDeviceCertificateResponse"/></returns>
        public RegisterDeviceCertificateResponse RegisterDeviceCertificateSync(RegisterDeviceCertificateRequest req)
        {
            return InternalRequestAsync<RegisterDeviceCertificateResponse>(req, "RegisterDeviceCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改策略规则优先级
        /// </summary>
        /// <param name="req"><see cref="UpdateAuthorizationPolicyPriorityRequest"/></param>
        /// <returns><see cref="UpdateAuthorizationPolicyPriorityResponse"/></returns>
        public Task<UpdateAuthorizationPolicyPriorityResponse> UpdateAuthorizationPolicyPriority(UpdateAuthorizationPolicyPriorityRequest req)
        {
            return InternalRequestAsync<UpdateAuthorizationPolicyPriorityResponse>(req, "UpdateAuthorizationPolicyPriority");
        }

        /// <summary>
        /// 修改策略规则优先级
        /// </summary>
        /// <param name="req"><see cref="UpdateAuthorizationPolicyPriorityRequest"/></param>
        /// <returns><see cref="UpdateAuthorizationPolicyPriorityResponse"/></returns>
        public UpdateAuthorizationPolicyPriorityResponse UpdateAuthorizationPolicyPrioritySync(UpdateAuthorizationPolicyPriorityRequest req)
        {
            return InternalRequestAsync<UpdateAuthorizationPolicyPriorityResponse>(req, "UpdateAuthorizationPolicyPriority")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
