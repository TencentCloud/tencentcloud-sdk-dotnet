/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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
       private const string sdkVersion = "SDK_NET_3.0.1317";

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
        /// 激活Ca证书
        /// </summary>
        /// <param name="req"><see cref="ActivateCaCertificateRequest"/></param>
        /// <returns><see cref="ActivateCaCertificateResponse"/></returns>
        public Task<ActivateCaCertificateResponse> ActivateCaCertificate(ActivateCaCertificateRequest req)
        {
            return InternalRequestAsync<ActivateCaCertificateResponse>(req, "ActivateCaCertificate");
        }

        /// <summary>
        /// 激活Ca证书
        /// </summary>
        /// <param name="req"><see cref="ActivateCaCertificateRequest"/></param>
        /// <returns><see cref="ActivateCaCertificateResponse"/></returns>
        public ActivateCaCertificateResponse ActivateCaCertificateSync(ActivateCaCertificateRequest req)
        {
            return InternalRequestAsync<ActivateCaCertificateResponse>(req, "ActivateCaCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 生效设备证书
        /// </summary>
        /// <param name="req"><see cref="ActivateDeviceCertificateRequest"/></param>
        /// <returns><see cref="ActivateDeviceCertificateResponse"/></returns>
        public Task<ActivateDeviceCertificateResponse> ActivateDeviceCertificate(ActivateDeviceCertificateRequest req)
        {
            return InternalRequestAsync<ActivateDeviceCertificateResponse>(req, "ActivateDeviceCertificate");
        }

        /// <summary>
        /// 生效设备证书
        /// </summary>
        /// <param name="req"><see cref="ActivateDeviceCertificateRequest"/></param>
        /// <returns><see cref="ActivateDeviceCertificateResponse"/></returns>
        public ActivateDeviceCertificateResponse ActivateDeviceCertificateSync(ActivateDeviceCertificateRequest req)
        {
            return InternalRequestAsync<ActivateDeviceCertificateResponse>(req, "ActivateDeviceCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 申请ca注册码
        /// </summary>
        /// <param name="req"><see cref="ApplyRegistrationCodeRequest"/></param>
        /// <returns><see cref="ApplyRegistrationCodeResponse"/></returns>
        public Task<ApplyRegistrationCodeResponse> ApplyRegistrationCode(ApplyRegistrationCodeRequest req)
        {
            return InternalRequestAsync<ApplyRegistrationCodeResponse>(req, "ApplyRegistrationCode");
        }

        /// <summary>
        /// 申请ca注册码
        /// </summary>
        /// <param name="req"><see cref="ApplyRegistrationCodeRequest"/></param>
        /// <returns><see cref="ApplyRegistrationCodeResponse"/></returns>
        public ApplyRegistrationCodeResponse ApplyRegistrationCodeSync(ApplyRegistrationCodeRequest req)
        {
            return InternalRequestAsync<ApplyRegistrationCodeResponse>(req, "ApplyRegistrationCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        /// 创建一机一密设备签名
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceIdentityRequest"/></param>
        /// <returns><see cref="CreateDeviceIdentityResponse"/></returns>
        public Task<CreateDeviceIdentityResponse> CreateDeviceIdentity(CreateDeviceIdentityRequest req)
        {
            return InternalRequestAsync<CreateDeviceIdentityResponse>(req, "CreateDeviceIdentity");
        }

        /// <summary>
        /// 创建一机一密设备签名
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceIdentityRequest"/></param>
        /// <returns><see cref="CreateDeviceIdentityResponse"/></returns>
        public CreateDeviceIdentityResponse CreateDeviceIdentitySync(CreateDeviceIdentityRequest req)
        {
            return InternalRequestAsync<CreateDeviceIdentityResponse>(req, "CreateDeviceIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一个HTTP的认证器
        /// </summary>
        /// <param name="req"><see cref="CreateHttpAuthenticatorRequest"/></param>
        /// <returns><see cref="CreateHttpAuthenticatorResponse"/></returns>
        public Task<CreateHttpAuthenticatorResponse> CreateHttpAuthenticator(CreateHttpAuthenticatorRequest req)
        {
            return InternalRequestAsync<CreateHttpAuthenticatorResponse>(req, "CreateHttpAuthenticator");
        }

        /// <summary>
        /// 创建一个HTTP的认证器
        /// </summary>
        /// <param name="req"><see cref="CreateHttpAuthenticatorRequest"/></param>
        /// <returns><see cref="CreateHttpAuthenticatorResponse"/></returns>
        public CreateHttpAuthenticatorResponse CreateHttpAuthenticatorSync(CreateHttpAuthenticatorRequest req)
        {
            return InternalRequestAsync<CreateHttpAuthenticatorResponse>(req, "CreateHttpAuthenticator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为MQTT实例创建公网接入点，未开启公网的集群可调用。
        /// </summary>
        /// <param name="req"><see cref="CreateInsPublicEndpointRequest"/></param>
        /// <returns><see cref="CreateInsPublicEndpointResponse"/></returns>
        public Task<CreateInsPublicEndpointResponse> CreateInsPublicEndpoint(CreateInsPublicEndpointRequest req)
        {
            return InternalRequestAsync<CreateInsPublicEndpointResponse>(req, "CreateInsPublicEndpoint");
        }

        /// <summary>
        /// 为MQTT实例创建公网接入点，未开启公网的集群可调用。
        /// </summary>
        /// <param name="req"><see cref="CreateInsPublicEndpointRequest"/></param>
        /// <returns><see cref="CreateInsPublicEndpointResponse"/></returns>
        public CreateInsPublicEndpointResponse CreateInsPublicEndpointSync(CreateInsPublicEndpointRequest req)
        {
            return InternalRequestAsync<CreateInsPublicEndpointResponse>(req, "CreateInsPublicEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 购买新的MQTT实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance");
        }

        /// <summary>
        /// 购买新的MQTT实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance")
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
        /// 添加mqtt角色
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser");
        }

        /// <summary>
        /// 添加mqtt角色
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 失效Ca证书
        /// </summary>
        /// <param name="req"><see cref="DeactivateCaCertificateRequest"/></param>
        /// <returns><see cref="DeactivateCaCertificateResponse"/></returns>
        public Task<DeactivateCaCertificateResponse> DeactivateCaCertificate(DeactivateCaCertificateRequest req)
        {
            return InternalRequestAsync<DeactivateCaCertificateResponse>(req, "DeactivateCaCertificate");
        }

        /// <summary>
        /// 失效Ca证书
        /// </summary>
        /// <param name="req"><see cref="DeactivateCaCertificateRequest"/></param>
        /// <returns><see cref="DeactivateCaCertificateResponse"/></returns>
        public DeactivateCaCertificateResponse DeactivateCaCertificateSync(DeactivateCaCertificateRequest req)
        {
            return InternalRequestAsync<DeactivateCaCertificateResponse>(req, "DeactivateCaCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 失效Ca证书
        /// </summary>
        /// <param name="req"><see cref="DeactivateDeviceCertificateRequest"/></param>
        /// <returns><see cref="DeactivateDeviceCertificateResponse"/></returns>
        public Task<DeactivateDeviceCertificateResponse> DeactivateDeviceCertificate(DeactivateDeviceCertificateRequest req)
        {
            return InternalRequestAsync<DeactivateDeviceCertificateResponse>(req, "DeactivateDeviceCertificate");
        }

        /// <summary>
        /// 失效Ca证书
        /// </summary>
        /// <param name="req"><see cref="DeactivateDeviceCertificateRequest"/></param>
        /// <returns><see cref="DeactivateDeviceCertificateResponse"/></returns>
        public DeactivateDeviceCertificateResponse DeactivateDeviceCertificateSync(DeactivateDeviceCertificateRequest req)
        {
            return InternalRequestAsync<DeactivateDeviceCertificateResponse>(req, "DeactivateDeviceCertificate")
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
        /// 删除Ca证书
        /// </summary>
        /// <param name="req"><see cref="DeleteCaCertificateRequest"/></param>
        /// <returns><see cref="DeleteCaCertificateResponse"/></returns>
        public Task<DeleteCaCertificateResponse> DeleteCaCertificate(DeleteCaCertificateRequest req)
        {
            return InternalRequestAsync<DeleteCaCertificateResponse>(req, "DeleteCaCertificate");
        }

        /// <summary>
        /// 删除Ca证书
        /// </summary>
        /// <param name="req"><see cref="DeleteCaCertificateRequest"/></param>
        /// <returns><see cref="DeleteCaCertificateResponse"/></returns>
        public DeleteCaCertificateResponse DeleteCaCertificateSync(DeleteCaCertificateRequest req)
        {
            return InternalRequestAsync<DeleteCaCertificateResponse>(req, "DeleteCaCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除设备证书
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceCertificateRequest"/></param>
        /// <returns><see cref="DeleteDeviceCertificateResponse"/></returns>
        public Task<DeleteDeviceCertificateResponse> DeleteDeviceCertificate(DeleteDeviceCertificateRequest req)
        {
            return InternalRequestAsync<DeleteDeviceCertificateResponse>(req, "DeleteDeviceCertificate");
        }

        /// <summary>
        /// 删除设备证书
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceCertificateRequest"/></param>
        /// <returns><see cref="DeleteDeviceCertificateResponse"/></returns>
        public DeleteDeviceCertificateResponse DeleteDeviceCertificateSync(DeleteDeviceCertificateRequest req)
        {
            return InternalRequestAsync<DeleteDeviceCertificateResponse>(req, "DeleteDeviceCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除一机一密设备签名
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceIdentityRequest"/></param>
        /// <returns><see cref="DeleteDeviceIdentityResponse"/></returns>
        public Task<DeleteDeviceIdentityResponse> DeleteDeviceIdentity(DeleteDeviceIdentityRequest req)
        {
            return InternalRequestAsync<DeleteDeviceIdentityResponse>(req, "DeleteDeviceIdentity");
        }

        /// <summary>
        /// 删除一机一密设备签名
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceIdentityRequest"/></param>
        /// <returns><see cref="DeleteDeviceIdentityResponse"/></returns>
        public DeleteDeviceIdentityResponse DeleteDeviceIdentitySync(DeleteDeviceIdentityRequest req)
        {
            return InternalRequestAsync<DeleteDeviceIdentityResponse>(req, "DeleteDeviceIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除MQTT实例的公网接入点
        /// </summary>
        /// <param name="req"><see cref="DeleteInsPublicEndpointRequest"/></param>
        /// <returns><see cref="DeleteInsPublicEndpointResponse"/></returns>
        public Task<DeleteInsPublicEndpointResponse> DeleteInsPublicEndpoint(DeleteInsPublicEndpointRequest req)
        {
            return InternalRequestAsync<DeleteInsPublicEndpointResponse>(req, "DeleteInsPublicEndpoint");
        }

        /// <summary>
        /// 删除MQTT实例的公网接入点
        /// </summary>
        /// <param name="req"><see cref="DeleteInsPublicEndpointRequest"/></param>
        /// <returns><see cref="DeleteInsPublicEndpointResponse"/></returns>
        public DeleteInsPublicEndpointResponse DeleteInsPublicEndpointSync(DeleteInsPublicEndpointRequest req)
        {
            return InternalRequestAsync<DeleteInsPublicEndpointResponse>(req, "DeleteInsPublicEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除MQTT实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance");
        }

        /// <summary>
        /// 删除MQTT实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance")
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
        /// 删除MQTT访问用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser");
        }

        /// <summary>
        /// 删除MQTT访问用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser")
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
        /// 查询Ca证书详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCaCertificateRequest"/></param>
        /// <returns><see cref="DescribeCaCertificateResponse"/></returns>
        public Task<DescribeCaCertificateResponse> DescribeCaCertificate(DescribeCaCertificateRequest req)
        {
            return InternalRequestAsync<DescribeCaCertificateResponse>(req, "DescribeCaCertificate");
        }

        /// <summary>
        /// 查询Ca证书详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCaCertificateRequest"/></param>
        /// <returns><see cref="DescribeCaCertificateResponse"/></returns>
        public DescribeCaCertificateResponse DescribeCaCertificateSync(DescribeCaCertificateRequest req)
        {
            return InternalRequestAsync<DescribeCaCertificateResponse>(req, "DescribeCaCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群下的ca证书信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCaCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCaCertificatesResponse"/></returns>
        public Task<DescribeCaCertificatesResponse> DescribeCaCertificates(DescribeCaCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeCaCertificatesResponse>(req, "DescribeCaCertificates");
        }

        /// <summary>
        /// 查询集群下的ca证书信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCaCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCaCertificatesResponse"/></returns>
        public DescribeCaCertificatesResponse DescribeCaCertificatesSync(DescribeCaCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeCaCertificatesResponse>(req, "DescribeCaCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 MQTT 客户端详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClientListRequest"/></param>
        /// <returns><see cref="DescribeClientListResponse"/></returns>
        public Task<DescribeClientListResponse> DescribeClientList(DescribeClientListRequest req)
        {
            return InternalRequestAsync<DescribeClientListResponse>(req, "DescribeClientList");
        }

        /// <summary>
        /// 查询 MQTT 客户端详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClientListRequest"/></param>
        /// <returns><see cref="DescribeClientListResponse"/></returns>
        public DescribeClientListResponse DescribeClientListSync(DescribeClientListRequest req)
        {
            return InternalRequestAsync<DescribeClientListResponse>(req, "DescribeClientList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询设备证书详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceCertificateRequest"/></param>
        /// <returns><see cref="DescribeDeviceCertificateResponse"/></returns>
        public Task<DescribeDeviceCertificateResponse> DescribeDeviceCertificate(DescribeDeviceCertificateRequest req)
        {
            return InternalRequestAsync<DescribeDeviceCertificateResponse>(req, "DescribeDeviceCertificate");
        }

        /// <summary>
        /// 查询设备证书详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceCertificateRequest"/></param>
        /// <returns><see cref="DescribeDeviceCertificateResponse"/></returns>
        public DescribeDeviceCertificateResponse DescribeDeviceCertificateSync(DescribeDeviceCertificateRequest req)
        {
            return InternalRequestAsync<DescribeDeviceCertificateResponse>(req, "DescribeDeviceCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询设备证书
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceCertificatesRequest"/></param>
        /// <returns><see cref="DescribeDeviceCertificatesResponse"/></returns>
        public Task<DescribeDeviceCertificatesResponse> DescribeDeviceCertificates(DescribeDeviceCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeDeviceCertificatesResponse>(req, "DescribeDeviceCertificates");
        }

        /// <summary>
        /// 分页查询设备证书
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceCertificatesRequest"/></param>
        /// <returns><see cref="DescribeDeviceCertificatesResponse"/></returns>
        public DescribeDeviceCertificatesResponse DescribeDeviceCertificatesSync(DescribeDeviceCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeDeviceCertificatesResponse>(req, "DescribeDeviceCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群下设备标识列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceIdentitiesRequest"/></param>
        /// <returns><see cref="DescribeDeviceIdentitiesResponse"/></returns>
        public Task<DescribeDeviceIdentitiesResponse> DescribeDeviceIdentities(DescribeDeviceIdentitiesRequest req)
        {
            return InternalRequestAsync<DescribeDeviceIdentitiesResponse>(req, "DescribeDeviceIdentities");
        }

        /// <summary>
        /// 查询集群下设备标识列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceIdentitiesRequest"/></param>
        /// <returns><see cref="DescribeDeviceIdentitiesResponse"/></returns>
        public DescribeDeviceIdentitiesResponse DescribeDeviceIdentitiesSync(DescribeDeviceIdentitiesRequest req)
        {
            return InternalRequestAsync<DescribeDeviceIdentitiesResponse>(req, "DescribeDeviceIdentities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询设备一机一密标识
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceIdentityRequest"/></param>
        /// <returns><see cref="DescribeDeviceIdentityResponse"/></returns>
        public Task<DescribeDeviceIdentityResponse> DescribeDeviceIdentity(DescribeDeviceIdentityRequest req)
        {
            return InternalRequestAsync<DescribeDeviceIdentityResponse>(req, "DescribeDeviceIdentity");
        }

        /// <summary>
        /// 查询设备一机一密标识
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceIdentityRequest"/></param>
        /// <returns><see cref="DescribeDeviceIdentityResponse"/></returns>
        public DescribeDeviceIdentityResponse DescribeDeviceIdentitySync(DescribeDeviceIdentityRequest req)
        {
            return InternalRequestAsync<DescribeDeviceIdentityResponse>(req, "DescribeDeviceIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询MQTT实例公网接入点
        /// </summary>
        /// <param name="req"><see cref="DescribeInsPublicEndpointsRequest"/></param>
        /// <returns><see cref="DescribeInsPublicEndpointsResponse"/></returns>
        public Task<DescribeInsPublicEndpointsResponse> DescribeInsPublicEndpoints(DescribeInsPublicEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeInsPublicEndpointsResponse>(req, "DescribeInsPublicEndpoints");
        }

        /// <summary>
        /// 查询MQTT实例公网接入点
        /// </summary>
        /// <param name="req"><see cref="DescribeInsPublicEndpointsRequest"/></param>
        /// <returns><see cref="DescribeInsPublicEndpointsResponse"/></returns>
        public DescribeInsPublicEndpointsResponse DescribeInsPublicEndpointsSync(DescribeInsPublicEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeInsPublicEndpointsResponse>(req, "DescribeInsPublicEndpoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询MQTT实例公网接入点
        /// </summary>
        /// <param name="req"><see cref="DescribeInsVPCEndpointsRequest"/></param>
        /// <returns><see cref="DescribeInsVPCEndpointsResponse"/></returns>
        public Task<DescribeInsVPCEndpointsResponse> DescribeInsVPCEndpoints(DescribeInsVPCEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeInsVPCEndpointsResponse>(req, "DescribeInsVPCEndpoints");
        }

        /// <summary>
        /// 查询MQTT实例公网接入点
        /// </summary>
        /// <param name="req"><see cref="DescribeInsVPCEndpointsRequest"/></param>
        /// <returns><see cref="DescribeInsVPCEndpointsResponse"/></returns>
        public DescribeInsVPCEndpointsResponse DescribeInsVPCEndpointsSync(DescribeInsVPCEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeInsVPCEndpointsResponse>(req, "DescribeInsVPCEndpoints")
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
        /// 根据订阅查询消息
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageByTopicRequest"/></param>
        /// <returns><see cref="DescribeMessageByTopicResponse"/></returns>
        public Task<DescribeMessageByTopicResponse> DescribeMessageByTopic(DescribeMessageByTopicRequest req)
        {
            return InternalRequestAsync<DescribeMessageByTopicResponse>(req, "DescribeMessageByTopic");
        }

        /// <summary>
        /// 根据订阅查询消息
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageByTopicRequest"/></param>
        /// <returns><see cref="DescribeMessageByTopicResponse"/></returns>
        public DescribeMessageByTopicResponse DescribeMessageByTopicSync(DescribeMessageByTopicRequest req)
        {
            return InternalRequestAsync<DescribeMessageByTopicResponse>(req, "DescribeMessageByTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询MQTT消息详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageDetailsRequest"/></param>
        /// <returns><see cref="DescribeMessageDetailsResponse"/></returns>
        public Task<DescribeMessageDetailsResponse> DescribeMessageDetails(DescribeMessageDetailsRequest req)
        {
            return InternalRequestAsync<DescribeMessageDetailsResponse>(req, "DescribeMessageDetails");
        }

        /// <summary>
        /// 查询MQTT消息详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageDetailsRequest"/></param>
        /// <returns><see cref="DescribeMessageDetailsResponse"/></returns>
        public DescribeMessageDetailsResponse DescribeMessageDetailsSync(DescribeMessageDetailsRequest req)
        {
            return InternalRequestAsync<DescribeMessageDetailsResponse>(req, "DescribeMessageDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据一级Topic查询消息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageListRequest"/></param>
        /// <returns><see cref="DescribeMessageListResponse"/></returns>
        public Task<DescribeMessageListResponse> DescribeMessageList(DescribeMessageListRequest req)
        {
            return InternalRequestAsync<DescribeMessageListResponse>(req, "DescribeMessageList");
        }

        /// <summary>
        /// 根据一级Topic查询消息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageListRequest"/></param>
        /// <returns><see cref="DescribeMessageListResponse"/></returns>
        public DescribeMessageListResponse DescribeMessageListSync(DescribeMessageListRequest req)
        {
            return InternalRequestAsync<DescribeMessageListResponse>(req, "DescribeMessageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取产品售卖规格
        /// </summary>
        /// <param name="req"><see cref="DescribeProductSKUListRequest"/></param>
        /// <returns><see cref="DescribeProductSKUListResponse"/></returns>
        public Task<DescribeProductSKUListResponse> DescribeProductSKUList(DescribeProductSKUListRequest req)
        {
            return InternalRequestAsync<DescribeProductSKUListResponse>(req, "DescribeProductSKUList");
        }

        /// <summary>
        /// 获取产品售卖规格
        /// </summary>
        /// <param name="req"><see cref="DescribeProductSKUListRequest"/></param>
        /// <returns><see cref="DescribeProductSKUListResponse"/></returns>
        public DescribeProductSKUListResponse DescribeProductSKUListSync(DescribeProductSKUListRequest req)
        {
            return InternalRequestAsync<DescribeProductSKUListResponse>(req, "DescribeProductSKUList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询共享订阅消息堆积量
        /// </summary>
        /// <param name="req"><see cref="DescribeSharedSubscriptionLagRequest"/></param>
        /// <returns><see cref="DescribeSharedSubscriptionLagResponse"/></returns>
        public Task<DescribeSharedSubscriptionLagResponse> DescribeSharedSubscriptionLag(DescribeSharedSubscriptionLagRequest req)
        {
            return InternalRequestAsync<DescribeSharedSubscriptionLagResponse>(req, "DescribeSharedSubscriptionLag");
        }

        /// <summary>
        /// 查询共享订阅消息堆积量
        /// </summary>
        /// <param name="req"><see cref="DescribeSharedSubscriptionLagRequest"/></param>
        /// <returns><see cref="DescribeSharedSubscriptionLagResponse"/></returns>
        public DescribeSharedSubscriptionLagResponse DescribeSharedSubscriptionLagSync(DescribeSharedSubscriptionLagRequest req)
        {
            return InternalRequestAsync<DescribeSharedSubscriptionLagResponse>(req, "DescribeSharedSubscriptionLag")
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
        /// 查询用户列表，Filter参数使用说明如下：
        /// 
        /// 1. Username，用户名称模糊搜索
        /// </summary>
        /// <param name="req"><see cref="DescribeUserListRequest"/></param>
        /// <returns><see cref="DescribeUserListResponse"/></returns>
        public Task<DescribeUserListResponse> DescribeUserList(DescribeUserListRequest req)
        {
            return InternalRequestAsync<DescribeUserListResponse>(req, "DescribeUserList");
        }

        /// <summary>
        /// 查询用户列表，Filter参数使用说明如下：
        /// 
        /// 1. Username，用户名称模糊搜索
        /// </summary>
        /// <param name="req"><see cref="DescribeUserListRequest"/></param>
        /// <returns><see cref="DescribeUserListResponse"/></returns>
        public DescribeUserListResponse DescribeUserListSync(DescribeUserListRequest req)
        {
            return InternalRequestAsync<DescribeUserListResponse>(req, "DescribeUserList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改策略规则，可参考 [数据面授权策略说明](https://cloud.tencent.com/document/product/1778/109715)
        /// </summary>
        /// <param name="req"><see cref="ModifyAuthorizationPolicyRequest"/></param>
        /// <returns><see cref="ModifyAuthorizationPolicyResponse"/></returns>
        public Task<ModifyAuthorizationPolicyResponse> ModifyAuthorizationPolicy(ModifyAuthorizationPolicyRequest req)
        {
            return InternalRequestAsync<ModifyAuthorizationPolicyResponse>(req, "ModifyAuthorizationPolicy");
        }

        /// <summary>
        /// 修改策略规则，可参考 [数据面授权策略说明](https://cloud.tencent.com/document/product/1778/109715)
        /// </summary>
        /// <param name="req"><see cref="ModifyAuthorizationPolicyRequest"/></param>
        /// <returns><see cref="ModifyAuthorizationPolicyResponse"/></returns>
        public ModifyAuthorizationPolicyResponse ModifyAuthorizationPolicySync(ModifyAuthorizationPolicyRequest req)
        {
            return InternalRequestAsync<ModifyAuthorizationPolicyResponse>(req, "ModifyAuthorizationPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改一机一密设备签名
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceIdentityRequest"/></param>
        /// <returns><see cref="ModifyDeviceIdentityResponse"/></returns>
        public Task<ModifyDeviceIdentityResponse> ModifyDeviceIdentity(ModifyDeviceIdentityRequest req)
        {
            return InternalRequestAsync<ModifyDeviceIdentityResponse>(req, "ModifyDeviceIdentity");
        }

        /// <summary>
        /// 修改一机一密设备签名
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceIdentityRequest"/></param>
        /// <returns><see cref="ModifyDeviceIdentityResponse"/></returns>
        public ModifyDeviceIdentityResponse ModifyDeviceIdentitySync(ModifyDeviceIdentityRequest req)
        {
            return InternalRequestAsync<ModifyDeviceIdentityResponse>(req, "ModifyDeviceIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改MQTT HTTP 认证器
        /// </summary>
        /// <param name="req"><see cref="ModifyHttpAuthenticatorRequest"/></param>
        /// <returns><see cref="ModifyHttpAuthenticatorResponse"/></returns>
        public Task<ModifyHttpAuthenticatorResponse> ModifyHttpAuthenticator(ModifyHttpAuthenticatorRequest req)
        {
            return InternalRequestAsync<ModifyHttpAuthenticatorResponse>(req, "ModifyHttpAuthenticator");
        }

        /// <summary>
        /// 修改MQTT HTTP 认证器
        /// </summary>
        /// <param name="req"><see cref="ModifyHttpAuthenticatorRequest"/></param>
        /// <returns><see cref="ModifyHttpAuthenticatorResponse"/></returns>
        public ModifyHttpAuthenticatorResponse ModifyHttpAuthenticatorSync(ModifyHttpAuthenticatorRequest req)
        {
            return InternalRequestAsync<ModifyHttpAuthenticatorResponse>(req, "ModifyHttpAuthenticator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新MQTT实例公网接入点
        /// </summary>
        /// <param name="req"><see cref="ModifyInsPublicEndpointRequest"/></param>
        /// <returns><see cref="ModifyInsPublicEndpointResponse"/></returns>
        public Task<ModifyInsPublicEndpointResponse> ModifyInsPublicEndpoint(ModifyInsPublicEndpointRequest req)
        {
            return InternalRequestAsync<ModifyInsPublicEndpointResponse>(req, "ModifyInsPublicEndpoint");
        }

        /// <summary>
        /// 更新MQTT实例公网接入点
        /// </summary>
        /// <param name="req"><see cref="ModifyInsPublicEndpointRequest"/></param>
        /// <returns><see cref="ModifyInsPublicEndpointResponse"/></returns>
        public ModifyInsPublicEndpointResponse ModifyInsPublicEndpointSync(ModifyInsPublicEndpointRequest req)
        {
            return InternalRequestAsync<ModifyInsPublicEndpointResponse>(req, "ModifyInsPublicEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例属性，只有运行中的集群可以调用该接口进行变更配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// 修改实例属性，只有运行中的集群可以调用该接口进行变更配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新MQTT集群绑定证书
        /// 参数传空，则为删除证书
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceCertBindingRequest"/></param>
        /// <returns><see cref="ModifyInstanceCertBindingResponse"/></returns>
        public Task<ModifyInstanceCertBindingResponse> ModifyInstanceCertBinding(ModifyInstanceCertBindingRequest req)
        {
            return InternalRequestAsync<ModifyInstanceCertBindingResponse>(req, "ModifyInstanceCertBinding");
        }

        /// <summary>
        /// 更新MQTT集群绑定证书
        /// 参数传空，则为删除证书
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceCertBindingRequest"/></param>
        /// <returns><see cref="ModifyInstanceCertBindingResponse"/></returns>
        public ModifyInstanceCertBindingResponse ModifyInstanceCertBindingSync(ModifyInstanceCertBindingRequest req)
        {
            return InternalRequestAsync<ModifyInstanceCertBindingResponse>(req, "ModifyInstanceCertBinding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改MQTT JWKS 认证器，全量配置修改，需要提交完整的修改后配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyJWKSAuthenticatorRequest"/></param>
        /// <returns><see cref="ModifyJWKSAuthenticatorResponse"/></returns>
        public Task<ModifyJWKSAuthenticatorResponse> ModifyJWKSAuthenticator(ModifyJWKSAuthenticatorRequest req)
        {
            return InternalRequestAsync<ModifyJWKSAuthenticatorResponse>(req, "ModifyJWKSAuthenticator");
        }

        /// <summary>
        /// 修改MQTT JWKS 认证器，全量配置修改，需要提交完整的修改后配置。
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
        /// 修改MQTT角色
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public Task<ModifyUserResponse> ModifyUser(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser");
        }

        /// <summary>
        /// 修改MQTT角色
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public ModifyUserResponse ModifyUserSync(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布 MQTT 消息到消息主题或客户端
        /// </summary>
        /// <param name="req"><see cref="PublishMessageRequest"/></param>
        /// <returns><see cref="PublishMessageResponse"/></returns>
        public Task<PublishMessageResponse> PublishMessage(PublishMessageRequest req)
        {
            return InternalRequestAsync<PublishMessageResponse>(req, "PublishMessage");
        }

        /// <summary>
        /// 发布 MQTT 消息到消息主题或客户端
        /// </summary>
        /// <param name="req"><see cref="PublishMessageRequest"/></param>
        /// <returns><see cref="PublishMessageResponse"/></returns>
        public PublishMessageResponse PublishMessageSync(PublishMessageRequest req)
        {
            return InternalRequestAsync<PublishMessageResponse>(req, "PublishMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 注册CA证书（仅一机一证场景支持），可参考 [自定义 X.509 证书实现 “一机一证”](https://cloud.tencent.com/document/product/1778/114817)
        /// </summary>
        /// <param name="req"><see cref="RegisterCaCertificateRequest"/></param>
        /// <returns><see cref="RegisterCaCertificateResponse"/></returns>
        public Task<RegisterCaCertificateResponse> RegisterCaCertificate(RegisterCaCertificateRequest req)
        {
            return InternalRequestAsync<RegisterCaCertificateResponse>(req, "RegisterCaCertificate");
        }

        /// <summary>
        /// 注册CA证书（仅一机一证场景支持），可参考 [自定义 X.509 证书实现 “一机一证”](https://cloud.tencent.com/document/product/1778/114817)
        /// </summary>
        /// <param name="req"><see cref="RegisterCaCertificateRequest"/></param>
        /// <returns><see cref="RegisterCaCertificateResponse"/></returns>
        public RegisterCaCertificateResponse RegisterCaCertificateSync(RegisterCaCertificateRequest req)
        {
            return InternalRequestAsync<RegisterCaCertificateResponse>(req, "RegisterCaCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 注册设备证书（仅一机一证场景生效），可参考 [自定义 X.509 证书实现 “一机一证”](https://cloud.tencent.com/document/product/1778/114817#6cb39d46-efad-4220-8f11-2e7fab207bc8)
        /// </summary>
        /// <param name="req"><see cref="RegisterDeviceCertificateRequest"/></param>
        /// <returns><see cref="RegisterDeviceCertificateResponse"/></returns>
        public Task<RegisterDeviceCertificateResponse> RegisterDeviceCertificate(RegisterDeviceCertificateRequest req)
        {
            return InternalRequestAsync<RegisterDeviceCertificateResponse>(req, "RegisterDeviceCertificate");
        }

        /// <summary>
        /// 注册设备证书（仅一机一证场景生效），可参考 [自定义 X.509 证书实现 “一机一证”](https://cloud.tencent.com/document/product/1778/114817#6cb39d46-efad-4220-8f11-2e7fab207bc8)
        /// </summary>
        /// <param name="req"><see cref="RegisterDeviceCertificateRequest"/></param>
        /// <returns><see cref="RegisterDeviceCertificateResponse"/></returns>
        public RegisterDeviceCertificateResponse RegisterDeviceCertificateSync(RegisterDeviceCertificateRequest req)
        {
            return InternalRequestAsync<RegisterDeviceCertificateResponse>(req, "RegisterDeviceCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 吊销设备证书
        /// </summary>
        /// <param name="req"><see cref="RevokedDeviceCertificateRequest"/></param>
        /// <returns><see cref="RevokedDeviceCertificateResponse"/></returns>
        public Task<RevokedDeviceCertificateResponse> RevokedDeviceCertificate(RevokedDeviceCertificateRequest req)
        {
            return InternalRequestAsync<RevokedDeviceCertificateResponse>(req, "RevokedDeviceCertificate");
        }

        /// <summary>
        /// 吊销设备证书
        /// </summary>
        /// <param name="req"><see cref="RevokedDeviceCertificateRequest"/></param>
        /// <returns><see cref="RevokedDeviceCertificateResponse"/></returns>
        public RevokedDeviceCertificateResponse RevokedDeviceCertificateSync(RevokedDeviceCertificateRequest req)
        {
            return InternalRequestAsync<RevokedDeviceCertificateResponse>(req, "RevokedDeviceCertificate")
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
