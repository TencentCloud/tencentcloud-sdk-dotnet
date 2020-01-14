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

namespace TencentCloud.Cvm.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cvm.V20170312.Models;

   public class CvmClient : AbstractClient{

       private const string endpoint = "cvm.tencentcloudapi.com";
       private const string version = "2017-03-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CvmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CvmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口 (AllocateHosts) 用于创建一个或多个指定配置的CDH实例。
        /// * 当HostChargeType为PREPAID时，必须指定HostChargePrepaid参数。
        /// </summary>
        /// <param name="req"><see cref="AllocateHostsRequest"/></param>
        /// <returns><see cref="AllocateHostsResponse"/></returns>
        public async Task<AllocateHostsResponse> AllocateHosts(AllocateHostsRequest req)
        {
             JsonResponseModel<AllocateHostsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AllocateHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AllocateHosts接口的同步版本，本接口 (AllocateHosts) 用于创建一个或多个指定配置的CDH实例。
        /// * 当HostChargeType为PREPAID时，必须指定HostChargePrepaid参数。
        /// </summary>
        /// <param name="req">参考<see cref="AllocateHostsRequest"/></param>
        /// <returns>参考<see cref="AllocateHostsResponse"/>实例</returns>
        public AllocateHostsResponse AllocateHostsSync(AllocateHostsRequest req)
        {
             JsonResponseModel<AllocateHostsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AllocateHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (AssociateInstancesKeyPairs) 用于将密钥绑定到实例上。
        /// 
        /// * 将密钥的公钥写入到实例的`SSH`配置当中，用户就可以通过该密钥的私钥来登录实例。
        /// * 如果实例原来绑定过密钥，那么原来的密钥将失效。
        /// * 如果实例原来是通过密码登录，绑定密钥后无法使用密码登录。
        /// * 支持批量操作。每次请求批量实例的上限为100。如果批量实例存在不允许操作的实例，操作会以特定错误码返回。
        /// </summary>
        /// <param name="req"><see cref="AssociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="AssociateInstancesKeyPairsResponse"/></returns>
        public async Task<AssociateInstancesKeyPairsResponse> AssociateInstancesKeyPairs(AssociateInstancesKeyPairsRequest req)
        {
             JsonResponseModel<AssociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AssociateInstancesKeyPairs接口的同步版本，本接口 (AssociateInstancesKeyPairs) 用于将密钥绑定到实例上。
        /// 
        /// * 将密钥的公钥写入到实例的`SSH`配置当中，用户就可以通过该密钥的私钥来登录实例。
        /// * 如果实例原来绑定过密钥，那么原来的密钥将失效。
        /// * 如果实例原来是通过密码登录，绑定密钥后无法使用密码登录。
        /// * 支持批量操作。每次请求批量实例的上限为100。如果批量实例存在不允许操作的实例，操作会以特定错误码返回。
        /// </summary>
        /// <param name="req">参考<see cref="AssociateInstancesKeyPairsRequest"/></param>
        /// <returns>参考<see cref="AssociateInstancesKeyPairsResponse"/>实例</returns>
        public AssociateInstancesKeyPairsResponse AssociateInstancesKeyPairsSync(AssociateInstancesKeyPairsRequest req)
        {
             JsonResponseModel<AssociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (AssociateSecurityGroups) 用于绑定安全组到指定实例。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public async Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AssociateSecurityGroups接口的同步版本，本接口 (AssociateSecurityGroups) 用于绑定安全组到指定实例。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req">参考<see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns>参考<see cref="AssociateSecurityGroupsResponse"/>实例</returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateDisasterRecoverGroup)用于创建[分散置放群组](https://cloud.tencent.com/document/product/213/15486)。创建好的置放群组，可在[创建实例](https://cloud.tencent.com/document/api/213/15730)时指定。
        /// </summary>
        /// <param name="req"><see cref="CreateDisasterRecoverGroupRequest"/></param>
        /// <returns><see cref="CreateDisasterRecoverGroupResponse"/></returns>
        public async Task<CreateDisasterRecoverGroupResponse> CreateDisasterRecoverGroup(CreateDisasterRecoverGroupRequest req)
        {
             JsonResponseModel<CreateDisasterRecoverGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDisasterRecoverGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDisasterRecoverGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateDisasterRecoverGroup接口的同步版本，本接口 (CreateDisasterRecoverGroup)用于创建[分散置放群组](https://cloud.tencent.com/document/product/213/15486)。创建好的置放群组，可在[创建实例](https://cloud.tencent.com/document/api/213/15730)时指定。
        /// </summary>
        /// <param name="req">参考<see cref="CreateDisasterRecoverGroupRequest"/></param>
        /// <returns>参考<see cref="CreateDisasterRecoverGroupResponse"/>实例</returns>
        public CreateDisasterRecoverGroupResponse CreateDisasterRecoverGroupSync(CreateDisasterRecoverGroupRequest req)
        {
             JsonResponseModel<CreateDisasterRecoverGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDisasterRecoverGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDisasterRecoverGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateImage)用于将实例的系统盘制作为新镜像，创建后的镜像可以用于创建实例。
        /// </summary>
        /// <param name="req"><see cref="CreateImageRequest"/></param>
        /// <returns><see cref="CreateImageResponse"/></returns>
        public async Task<CreateImageResponse> CreateImage(CreateImageRequest req)
        {
             JsonResponseModel<CreateImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateImage接口的同步版本，本接口(CreateImage)用于将实例的系统盘制作为新镜像，创建后的镜像可以用于创建实例。
        /// </summary>
        /// <param name="req">参考<see cref="CreateImageRequest"/></param>
        /// <returns>参考<see cref="CreateImageResponse"/>实例</returns>
        public CreateImageResponse CreateImageSync(CreateImageRequest req)
        {
             JsonResponseModel<CreateImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateKeyPair) 用于创建一个 `OpenSSH RSA` 密钥对，可以用于登录 `Linux` 实例。
        /// 
        /// * 开发者只需指定密钥对名称，即可由系统自动创建密钥对，并返回所生成的密钥对的 `ID` 及其公钥、私钥的内容。
        /// * 密钥对名称不能和已经存在的密钥对的名称重复。
        /// * 私钥的内容可以保存到文件中作为 `SSH` 的一种认证方式。
        /// * 腾讯云不会保存用户的私钥，请妥善保管。
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public async Task<CreateKeyPairResponse> CreateKeyPair(CreateKeyPairRequest req)
        {
             JsonResponseModel<CreateKeyPairResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateKeyPair接口的同步版本，本接口 (CreateKeyPair) 用于创建一个 `OpenSSH RSA` 密钥对，可以用于登录 `Linux` 实例。
        /// 
        /// * 开发者只需指定密钥对名称，即可由系统自动创建密钥对，并返回所生成的密钥对的 `ID` 及其公钥、私钥的内容。
        /// * 密钥对名称不能和已经存在的密钥对的名称重复。
        /// * 私钥的内容可以保存到文件中作为 `SSH` 的一种认证方式。
        /// * 腾讯云不会保存用户的私钥，请妥善保管。
        /// </summary>
        /// <param name="req">参考<see cref="CreateKeyPairRequest"/></param>
        /// <returns>参考<see cref="CreateKeyPairResponse"/>实例</returns>
        public CreateKeyPairResponse CreateKeyPairSync(CreateKeyPairRequest req)
        {
             JsonResponseModel<CreateKeyPairResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteDisasterRecoverGroups)用于删除[分散置放群组](https://cloud.tencent.com/document/product/213/15486)。只有空的置放群组才能被删除，非空的群组需要先销毁组内所有云服务器，才能执行删除操作，不然会产生删除置放群组失败的错误。
        /// </summary>
        /// <param name="req"><see cref="DeleteDisasterRecoverGroupsRequest"/></param>
        /// <returns><see cref="DeleteDisasterRecoverGroupsResponse"/></returns>
        public async Task<DeleteDisasterRecoverGroupsResponse> DeleteDisasterRecoverGroups(DeleteDisasterRecoverGroupsRequest req)
        {
             JsonResponseModel<DeleteDisasterRecoverGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDisasterRecoverGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDisasterRecoverGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteDisasterRecoverGroups接口的同步版本，本接口 (DeleteDisasterRecoverGroups)用于删除[分散置放群组](https://cloud.tencent.com/document/product/213/15486)。只有空的置放群组才能被删除，非空的群组需要先销毁组内所有云服务器，才能执行删除操作，不然会产生删除置放群组失败的错误。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteDisasterRecoverGroupsRequest"/></param>
        /// <returns>参考<see cref="DeleteDisasterRecoverGroupsResponse"/>实例</returns>
        public DeleteDisasterRecoverGroupsResponse DeleteDisasterRecoverGroupsSync(DeleteDisasterRecoverGroupsRequest req)
        {
             JsonResponseModel<DeleteDisasterRecoverGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDisasterRecoverGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDisasterRecoverGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteImages）用于删除一个或多个镜像。
        /// 
        /// * 当[镜像状态](https://cloud.tencent.com/document/product/213/15753#Image)为`创建中`和`使用中`时, 不允许删除。镜像状态可以通过[DescribeImages](https://cloud.tencent.com/document/api/213/9418)获取。
        /// * 每个地域最多只支持创建10个自定义镜像，删除镜像可以释放账户的配额。
        /// * 当镜像正在被其它账户分享时，不允许删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteImagesRequest"/></param>
        /// <returns><see cref="DeleteImagesResponse"/></returns>
        public async Task<DeleteImagesResponse> DeleteImages(DeleteImagesRequest req)
        {
             JsonResponseModel<DeleteImagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteImages接口的同步版本，本接口（DeleteImages）用于删除一个或多个镜像。
        /// 
        /// * 当[镜像状态](https://cloud.tencent.com/document/product/213/15753#Image)为`创建中`和`使用中`时, 不允许删除。镜像状态可以通过[DescribeImages](https://cloud.tencent.com/document/api/213/9418)获取。
        /// * 每个地域最多只支持创建10个自定义镜像，删除镜像可以释放账户的配额。
        /// * 当镜像正在被其它账户分享时，不允许删除。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteImagesRequest"/></param>
        /// <returns>参考<see cref="DeleteImagesResponse"/>实例</returns>
        public DeleteImagesResponse DeleteImagesSync(DeleteImagesRequest req)
        {
             JsonResponseModel<DeleteImagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteKeyPairs) 用于删除已在腾讯云托管的密钥对。
        /// 
        /// * 可以同时删除多个密钥对。
        /// * 不能删除已被实例或镜像引用的密钥对，所以需要独立判断是否所有密钥对都被成功删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteKeyPairsRequest"/></param>
        /// <returns><see cref="DeleteKeyPairsResponse"/></returns>
        public async Task<DeleteKeyPairsResponse> DeleteKeyPairs(DeleteKeyPairsRequest req)
        {
             JsonResponseModel<DeleteKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteKeyPairs接口的同步版本，本接口 (DeleteKeyPairs) 用于删除已在腾讯云托管的密钥对。
        /// 
        /// * 可以同时删除多个密钥对。
        /// * 不能删除已被实例或镜像引用的密钥对，所以需要独立判断是否所有密钥对都被成功删除。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteKeyPairsRequest"/></param>
        /// <returns>参考<see cref="DeleteKeyPairsResponse"/>实例</returns>
        public DeleteKeyPairsResponse DeleteKeyPairsSync(DeleteKeyPairsRequest req)
        {
             JsonResponseModel<DeleteKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeDisasterRecoverGroupQuota)用于查询[分散置放群组](https://cloud.tencent.com/document/product/213/15486)配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoverGroupQuotaRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoverGroupQuotaResponse"/></returns>
        public async Task<DescribeDisasterRecoverGroupQuotaResponse> DescribeDisasterRecoverGroupQuota(DescribeDisasterRecoverGroupQuotaRequest req)
        {
             JsonResponseModel<DescribeDisasterRecoverGroupQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDisasterRecoverGroupQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisasterRecoverGroupQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDisasterRecoverGroupQuota接口的同步版本，本接口 (DescribeDisasterRecoverGroupQuota)用于查询[分散置放群组](https://cloud.tencent.com/document/product/213/15486)配额。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDisasterRecoverGroupQuotaRequest"/></param>
        /// <returns>参考<see cref="DescribeDisasterRecoverGroupQuotaResponse"/>实例</returns>
        public DescribeDisasterRecoverGroupQuotaResponse DescribeDisasterRecoverGroupQuotaSync(DescribeDisasterRecoverGroupQuotaRequest req)
        {
             JsonResponseModel<DescribeDisasterRecoverGroupQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDisasterRecoverGroupQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisasterRecoverGroupQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeDisasterRecoverGroups)用于查询[分散置放群组](https://cloud.tencent.com/document/product/213/15486)信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoverGroupsRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoverGroupsResponse"/></returns>
        public async Task<DescribeDisasterRecoverGroupsResponse> DescribeDisasterRecoverGroups(DescribeDisasterRecoverGroupsRequest req)
        {
             JsonResponseModel<DescribeDisasterRecoverGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDisasterRecoverGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisasterRecoverGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDisasterRecoverGroups接口的同步版本，本接口 (DescribeDisasterRecoverGroups)用于查询[分散置放群组](https://cloud.tencent.com/document/product/213/15486)信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDisasterRecoverGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeDisasterRecoverGroupsResponse"/>实例</returns>
        public DescribeDisasterRecoverGroupsResponse DescribeDisasterRecoverGroupsSync(DescribeDisasterRecoverGroupsRequest req)
        {
             JsonResponseModel<DescribeDisasterRecoverGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDisasterRecoverGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisasterRecoverGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeHosts) 用于获取一个或多个CDH实例的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsRequest"/></param>
        /// <returns><see cref="DescribeHostsResponse"/></returns>
        public async Task<DescribeHostsResponse> DescribeHosts(DescribeHostsRequest req)
        {
             JsonResponseModel<DescribeHostsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeHosts接口的同步版本，本接口 (DescribeHosts) 用于获取一个或多个CDH实例的详细信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeHostsRequest"/></param>
        /// <returns>参考<see cref="DescribeHostsResponse"/>实例</returns>
        public DescribeHostsResponse DescribeHostsSync(DescribeHostsRequest req)
        {
             JsonResponseModel<DescribeHostsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeImageQuota)用于查询用户帐号的镜像配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeImageQuotaRequest"/></param>
        /// <returns><see cref="DescribeImageQuotaResponse"/></returns>
        public async Task<DescribeImageQuotaResponse> DescribeImageQuota(DescribeImageQuotaRequest req)
        {
             JsonResponseModel<DescribeImageQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeImageQuota接口的同步版本，本接口(DescribeImageQuota)用于查询用户帐号的镜像配额。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeImageQuotaRequest"/></param>
        /// <returns>参考<see cref="DescribeImageQuotaResponse"/>实例</returns>
        public DescribeImageQuotaResponse DescribeImageQuotaSync(DescribeImageQuotaRequest req)
        {
             JsonResponseModel<DescribeImageQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeImageSharePermission）用于查询镜像分享信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSharePermissionRequest"/></param>
        /// <returns><see cref="DescribeImageSharePermissionResponse"/></returns>
        public async Task<DescribeImageSharePermissionResponse> DescribeImageSharePermission(DescribeImageSharePermissionRequest req)
        {
             JsonResponseModel<DescribeImageSharePermissionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageSharePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageSharePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeImageSharePermission接口的同步版本，本接口（DescribeImageSharePermission）用于查询镜像分享信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeImageSharePermissionRequest"/></param>
        /// <returns>参考<see cref="DescribeImageSharePermissionResponse"/>实例</returns>
        public DescribeImageSharePermissionResponse DescribeImageSharePermissionSync(DescribeImageSharePermissionRequest req)
        {
             JsonResponseModel<DescribeImageSharePermissionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageSharePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageSharePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeImages) 用于查看镜像列表。
        /// 
        /// * 可以通过指定镜像ID来查询指定镜像的详细信息，或通过设定过滤器来查询满足过滤条件的镜像的详细信息。
        /// * 指定偏移(Offset)和限制(Limit)来选择结果中的一部分，默认返回满足条件的前20个镜像信息。
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
        /// DescribeImages接口的同步版本，本接口(DescribeImages) 用于查看镜像列表。
        /// 
        /// * 可以通过指定镜像ID来查询指定镜像的详细信息，或通过设定过滤器来查询满足过滤条件的镜像的详细信息。
        /// * 指定偏移(Offset)和限制(Limit)来选择结果中的一部分，默认返回满足条件的前20个镜像信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeImagesRequest"/></param>
        /// <returns>参考<see cref="DescribeImagesResponse"/>实例</returns>
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
        /// 查看可以导入的镜像操作系统信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeImportImageOsRequest"/></param>
        /// <returns><see cref="DescribeImportImageOsResponse"/></returns>
        public async Task<DescribeImportImageOsResponse> DescribeImportImageOs(DescribeImportImageOsRequest req)
        {
             JsonResponseModel<DescribeImportImageOsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImportImageOs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImportImageOsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeImportImageOs接口的同步版本，查看可以导入的镜像操作系统信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeImportImageOsRequest"/></param>
        /// <returns>参考<see cref="DescribeImportImageOsResponse"/>实例</returns>
        public DescribeImportImageOsResponse DescribeImportImageOsSync(DescribeImportImageOsRequest req)
        {
             JsonResponseModel<DescribeImportImageOsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImportImageOs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImportImageOsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceFamilyConfigs）查询当前用户和地域所支持的机型族列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceFamilyConfigsRequest"/></param>
        /// <returns><see cref="DescribeInstanceFamilyConfigsResponse"/></returns>
        public async Task<DescribeInstanceFamilyConfigsResponse> DescribeInstanceFamilyConfigs(DescribeInstanceFamilyConfigsRequest req)
        {
             JsonResponseModel<DescribeInstanceFamilyConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceFamilyConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceFamilyConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceFamilyConfigs接口的同步版本，本接口（DescribeInstanceFamilyConfigs）查询当前用户和地域所支持的机型族列表信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceFamilyConfigsRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceFamilyConfigsResponse"/>实例</returns>
        public DescribeInstanceFamilyConfigsResponse DescribeInstanceFamilyConfigsSync(DescribeInstanceFamilyConfigsRequest req)
        {
             JsonResponseModel<DescribeInstanceFamilyConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceFamilyConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceFamilyConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeInstanceInternetBandwidthConfigs) 用于查询实例带宽配置。
        /// 
        /// * 只支持查询`BANDWIDTH_PREPAID`计费模式的带宽配置。
        /// * 接口返回实例的所有带宽配置信息（包含历史的带宽配置信息）。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceInternetBandwidthConfigsRequest"/></param>
        /// <returns><see cref="DescribeInstanceInternetBandwidthConfigsResponse"/></returns>
        public async Task<DescribeInstanceInternetBandwidthConfigsResponse> DescribeInstanceInternetBandwidthConfigs(DescribeInstanceInternetBandwidthConfigsRequest req)
        {
             JsonResponseModel<DescribeInstanceInternetBandwidthConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceInternetBandwidthConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceInternetBandwidthConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceInternetBandwidthConfigs接口的同步版本，本接口 (DescribeInstanceInternetBandwidthConfigs) 用于查询实例带宽配置。
        /// 
        /// * 只支持查询`BANDWIDTH_PREPAID`计费模式的带宽配置。
        /// * 接口返回实例的所有带宽配置信息（包含历史的带宽配置信息）。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceInternetBandwidthConfigsRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceInternetBandwidthConfigsResponse"/>实例</returns>
        public DescribeInstanceInternetBandwidthConfigsResponse DescribeInstanceInternetBandwidthConfigsSync(DescribeInstanceInternetBandwidthConfigsRequest req)
        {
             JsonResponseModel<DescribeInstanceInternetBandwidthConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceInternetBandwidthConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceInternetBandwidthConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeInstanceTypeConfigs) 用于查询实例机型配置。
        /// 
        /// * 可以根据`zone`、`instance-family`来查询实例机型配置。过滤条件详见过滤器`Filter`。
        /// * 如果参数为空，返回指定地域的所有实例机型配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypeConfigsRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypeConfigsResponse"/></returns>
        public async Task<DescribeInstanceTypeConfigsResponse> DescribeInstanceTypeConfigs(DescribeInstanceTypeConfigsRequest req)
        {
             JsonResponseModel<DescribeInstanceTypeConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceTypeConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceTypeConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceTypeConfigs接口的同步版本，本接口 (DescribeInstanceTypeConfigs) 用于查询实例机型配置。
        /// 
        /// * 可以根据`zone`、`instance-family`来查询实例机型配置。过滤条件详见过滤器`Filter`。
        /// * 如果参数为空，返回指定地域的所有实例机型配置。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceTypeConfigsRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceTypeConfigsResponse"/>实例</returns>
        public DescribeInstanceTypeConfigsResponse DescribeInstanceTypeConfigsSync(DescribeInstanceTypeConfigsRequest req)
        {
             JsonResponseModel<DescribeInstanceTypeConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceTypeConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceTypeConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( DescribeInstanceVncUrl ) 用于查询实例管理终端地址。
        /// 
        /// * 处于 `STOPPED` 状态的机器无法使用此功能。
        /// * 管理终端地址的有效期为 15 秒，调用接口成功后如果 15 秒内不使用该链接进行访问，管理终端地址自动失效，您需要重新查询。
        /// * 管理终端地址一旦被访问，将自动失效，您需要重新查询。
        /// * 如果连接断开，每分钟内重新连接的次数不能超过 30 次。
        /// * 获取到 `InstanceVncUrl` 后，您需要在链接 <https://img.qcloud.com/qcloud/app/active_vnc/index.html?> 末尾加上参数 `InstanceVncUrl=xxxx`  。
        ///   - 参数 `InstanceVncUrl` ：调用接口成功后会返回的 `InstanceVncUrl` 的值。
        /// 
        ///     最后组成的 URL 格式如下：
        /// 
        /// ```
        /// https://img.qcloud.com/qcloud/app/active_vnc/index.html?InstanceVncUrl=wss%3A%2F%2Fbjvnc.qcloud.com%3A26789%2Fvnc%3Fs%3DaHpjWnRVMFNhYmxKdDM5MjRHNlVTSVQwajNUSW0wb2tBbmFtREFCTmFrcy8vUUNPMG0wSHZNOUUxRm5PMmUzWmFDcWlOdDJIbUJxSTZDL0RXcHZxYnZZMmRkWWZWcEZia2lyb09XMzdKNmM9
        /// ```
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public async Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrl(DescribeInstanceVncUrlRequest req)
        {
             JsonResponseModel<DescribeInstanceVncUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceVncUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceVncUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceVncUrl接口的同步版本，本接口 ( DescribeInstanceVncUrl ) 用于查询实例管理终端地址。
        /// 
        /// * 处于 `STOPPED` 状态的机器无法使用此功能。
        /// * 管理终端地址的有效期为 15 秒，调用接口成功后如果 15 秒内不使用该链接进行访问，管理终端地址自动失效，您需要重新查询。
        /// * 管理终端地址一旦被访问，将自动失效，您需要重新查询。
        /// * 如果连接断开，每分钟内重新连接的次数不能超过 30 次。
        /// * 获取到 `InstanceVncUrl` 后，您需要在链接 <https://img.qcloud.com/qcloud/app/active_vnc/index.html?> 末尾加上参数 `InstanceVncUrl=xxxx`  。
        ///   - 参数 `InstanceVncUrl` ：调用接口成功后会返回的 `InstanceVncUrl` 的值。
        /// 
        ///     最后组成的 URL 格式如下：
        /// 
        /// ```
        /// https://img.qcloud.com/qcloud/app/active_vnc/index.html?InstanceVncUrl=wss%3A%2F%2Fbjvnc.qcloud.com%3A26789%2Fvnc%3Fs%3DaHpjWnRVMFNhYmxKdDM5MjRHNlVTSVQwajNUSW0wb2tBbmFtREFCTmFrcy8vUUNPMG0wSHZNOUUxRm5PMmUzWmFDcWlOdDJIbUJxSTZDL0RXcHZxYnZZMmRkWWZWcEZia2lyb09XMzdKNmM9
        /// ```
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceVncUrlResponse"/>实例</returns>
        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrlSync(DescribeInstanceVncUrlRequest req)
        {
             JsonResponseModel<DescribeInstanceVncUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceVncUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceVncUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeInstances) 用于查询一个或多个实例的详细信息。
        /// 
        /// * 可以根据实例`ID`、实例名称或者实例计费模式等信息来查询实例的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的实例。
        /// * 支持查询实例的最新操作（LatestOperation）以及最新操作状态(LatestOperationState)。
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
        /// DescribeInstances接口的同步版本，本接口 (DescribeInstances) 用于查询一个或多个实例的详细信息。
        /// 
        /// * 可以根据实例`ID`、实例名称或者实例计费模式等信息来查询实例的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的实例。
        /// * 支持查询实例的最新操作（LatestOperation）以及最新操作状态(LatestOperationState)。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeInstancesResponse"/>实例</returns>
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
        /// 本接口（DescribeInstancesOperationLimit）用于查询实例操作限制。
        /// 
        /// * 目前支持调整配置操作限制次数查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesOperationLimitRequest"/></param>
        /// <returns><see cref="DescribeInstancesOperationLimitResponse"/></returns>
        public async Task<DescribeInstancesOperationLimitResponse> DescribeInstancesOperationLimit(DescribeInstancesOperationLimitRequest req)
        {
             JsonResponseModel<DescribeInstancesOperationLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesOperationLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesOperationLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstancesOperationLimit接口的同步版本，本接口（DescribeInstancesOperationLimit）用于查询实例操作限制。
        /// 
        /// * 目前支持调整配置操作限制次数查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstancesOperationLimitRequest"/></param>
        /// <returns>参考<see cref="DescribeInstancesOperationLimitResponse"/>实例</returns>
        public DescribeInstancesOperationLimitResponse DescribeInstancesOperationLimitSync(DescribeInstancesOperationLimitRequest req)
        {
             JsonResponseModel<DescribeInstancesOperationLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesOperationLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesOperationLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeInstancesStatus) 用于查询一个或多个实例的状态。
        /// 
        /// * 可以根据实例`ID`来查询实例的状态。
        /// * 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的实例状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesStatusRequest"/></param>
        /// <returns><see cref="DescribeInstancesStatusResponse"/></returns>
        public async Task<DescribeInstancesStatusResponse> DescribeInstancesStatus(DescribeInstancesStatusRequest req)
        {
             JsonResponseModel<DescribeInstancesStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstancesStatus接口的同步版本，本接口 (DescribeInstancesStatus) 用于查询一个或多个实例的状态。
        /// 
        /// * 可以根据实例`ID`来查询实例的状态。
        /// * 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的实例状态。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstancesStatusRequest"/></param>
        /// <returns>参考<see cref="DescribeInstancesStatusResponse"/>实例</returns>
        public DescribeInstancesStatusResponse DescribeInstancesStatusSync(DescribeInstancesStatusRequest req)
        {
             JsonResponseModel<DescribeInstancesStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInternetChargeTypeConfigs）用于查询网络的计费类型。
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetChargeTypeConfigsRequest"/></param>
        /// <returns><see cref="DescribeInternetChargeTypeConfigsResponse"/></returns>
        public async Task<DescribeInternetChargeTypeConfigsResponse> DescribeInternetChargeTypeConfigs(DescribeInternetChargeTypeConfigsRequest req)
        {
             JsonResponseModel<DescribeInternetChargeTypeConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInternetChargeTypeConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInternetChargeTypeConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInternetChargeTypeConfigs接口的同步版本，本接口（DescribeInternetChargeTypeConfigs）用于查询网络的计费类型。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInternetChargeTypeConfigsRequest"/></param>
        /// <returns>参考<see cref="DescribeInternetChargeTypeConfigsResponse"/>实例</returns>
        public DescribeInternetChargeTypeConfigsResponse DescribeInternetChargeTypeConfigsSync(DescribeInternetChargeTypeConfigsRequest req)
        {
             JsonResponseModel<DescribeInternetChargeTypeConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInternetChargeTypeConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInternetChargeTypeConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeKeyPairs) 用于查询密钥对信息。
        /// 
        /// * 密钥对是通过一种算法生成的一对密钥，在生成的密钥对中，一个向外界公开，称为公钥；另一个用户自己保留，称为私钥。密钥对的公钥内容可以通过这个接口查询，但私钥内容系统不保留。
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyPairsRequest"/></param>
        /// <returns><see cref="DescribeKeyPairsResponse"/></returns>
        public async Task<DescribeKeyPairsResponse> DescribeKeyPairs(DescribeKeyPairsRequest req)
        {
             JsonResponseModel<DescribeKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeKeyPairs接口的同步版本，本接口 (DescribeKeyPairs) 用于查询密钥对信息。
        /// 
        /// * 密钥对是通过一种算法生成的一对密钥，在生成的密钥对中，一个向外界公开，称为公钥；另一个用户自己保留，称为私钥。密钥对的公钥内容可以通过这个接口查询，但私钥内容系统不保留。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeKeyPairsRequest"/></param>
        /// <returns>参考<see cref="DescribeKeyPairsResponse"/>实例</returns>
        public DescribeKeyPairsResponse DescribeKeyPairsSync(DescribeKeyPairsRequest req)
        {
             JsonResponseModel<DescribeKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeRegions)用于查询地域信息。
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
        /// DescribeRegions接口的同步版本，本接口(DescribeRegions)用于查询地域信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRegionsRequest"/></param>
        /// <returns>参考<see cref="DescribeRegionsResponse"/>实例</returns>
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
        /// 本接口(DescribeReservedInstances)可提供列出用户已购买的预留实例
        /// </summary>
        /// <param name="req"><see cref="DescribeReservedInstancesRequest"/></param>
        /// <returns><see cref="DescribeReservedInstancesResponse"/></returns>
        public async Task<DescribeReservedInstancesResponse> DescribeReservedInstances(DescribeReservedInstancesRequest req)
        {
             JsonResponseModel<DescribeReservedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReservedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReservedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeReservedInstances接口的同步版本，本接口(DescribeReservedInstances)可提供列出用户已购买的预留实例
        /// </summary>
        /// <param name="req">参考<see cref="DescribeReservedInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeReservedInstancesResponse"/>实例</returns>
        public DescribeReservedInstancesResponse DescribeReservedInstancesSync(DescribeReservedInstancesRequest req)
        {
             JsonResponseModel<DescribeReservedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReservedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReservedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeReservedInstancesOfferings)供用户列出可购买的预留实例配置
        /// </summary>
        /// <param name="req"><see cref="DescribeReservedInstancesOfferingsRequest"/></param>
        /// <returns><see cref="DescribeReservedInstancesOfferingsResponse"/></returns>
        public async Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest req)
        {
             JsonResponseModel<DescribeReservedInstancesOfferingsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReservedInstancesOfferings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReservedInstancesOfferingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeReservedInstancesOfferings接口的同步版本，本接口(DescribeReservedInstancesOfferings)供用户列出可购买的预留实例配置
        /// </summary>
        /// <param name="req">参考<see cref="DescribeReservedInstancesOfferingsRequest"/></param>
        /// <returns>参考<see cref="DescribeReservedInstancesOfferingsResponse"/>实例</returns>
        public DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferingsSync(DescribeReservedInstancesOfferingsRequest req)
        {
             JsonResponseModel<DescribeReservedInstancesOfferingsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReservedInstancesOfferings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReservedInstancesOfferingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeZoneInstanceConfigInfos) 获取可用区的机型信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneInstanceConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeZoneInstanceConfigInfosResponse"/></returns>
        public async Task<DescribeZoneInstanceConfigInfosResponse> DescribeZoneInstanceConfigInfos(DescribeZoneInstanceConfigInfosRequest req)
        {
             JsonResponseModel<DescribeZoneInstanceConfigInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZoneInstanceConfigInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneInstanceConfigInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeZoneInstanceConfigInfos接口的同步版本，本接口(DescribeZoneInstanceConfigInfos) 获取可用区的机型信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZoneInstanceConfigInfosRequest"/></param>
        /// <returns>参考<see cref="DescribeZoneInstanceConfigInfosResponse"/>实例</returns>
        public DescribeZoneInstanceConfigInfosResponse DescribeZoneInstanceConfigInfosSync(DescribeZoneInstanceConfigInfosRequest req)
        {
             JsonResponseModel<DescribeZoneInstanceConfigInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZoneInstanceConfigInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneInstanceConfigInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeZones)用于查询可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public async Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeZones接口的同步版本，本接口(DescribeZones)用于查询可用区信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZonesRequest"/></param>
        /// <returns>参考<see cref="DescribeZonesResponse"/>实例</returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DisassociateInstancesKeyPairs) 用于解除实例的密钥绑定关系。
        /// 
        /// * 只支持[`STOPPED`](https://cloud.tencent.com/document/product/213/15753#InstanceStatus)状态的`Linux`操作系统的实例。
        /// * 解绑密钥后，实例可以通过原来设置的密码登录。
        /// * 如果原来没有设置密码，解绑后将无法使用 `SSH` 登录。可以调用 [ResetInstancesPassword](https://cloud.tencent.com/document/api/213/15736) 接口来设置登录密码。
        /// * 支持批量操作。每次请求批量实例的上限为100。如果批量实例存在不允许操作的实例，操作会以特定错误码返回。
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public async Task<DisassociateInstancesKeyPairsResponse> DisassociateInstancesKeyPairs(DisassociateInstancesKeyPairsRequest req)
        {
             JsonResponseModel<DisassociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DisassociateInstancesKeyPairs接口的同步版本，本接口 (DisassociateInstancesKeyPairs) 用于解除实例的密钥绑定关系。
        /// 
        /// * 只支持[`STOPPED`](https://cloud.tencent.com/document/product/213/15753#InstanceStatus)状态的`Linux`操作系统的实例。
        /// * 解绑密钥后，实例可以通过原来设置的密码登录。
        /// * 如果原来没有设置密码，解绑后将无法使用 `SSH` 登录。可以调用 [ResetInstancesPassword](https://cloud.tencent.com/document/api/213/15736) 接口来设置登录密码。
        /// * 支持批量操作。每次请求批量实例的上限为100。如果批量实例存在不允许操作的实例，操作会以特定错误码返回。
        /// </summary>
        /// <param name="req">参考<see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns>参考<see cref="DisassociateInstancesKeyPairsResponse"/>实例</returns>
        public DisassociateInstancesKeyPairsResponse DisassociateInstancesKeyPairsSync(DisassociateInstancesKeyPairsRequest req)
        {
             JsonResponseModel<DisassociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DisassociateSecurityGroups) 用于解绑实例的指定安全组。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public async Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DisassociateSecurityGroups接口的同步版本，本接口 (DisassociateSecurityGroups) 用于解绑实例的指定安全组。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req">参考<see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns>参考<see cref="DisassociateSecurityGroupsResponse"/>实例</returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ImportImage)用于导入镜像，导入后的镜像可用于创建实例。 
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
        /// ImportImage接口的同步版本，本接口(ImportImage)用于导入镜像，导入后的镜像可用于创建实例。 
        /// </summary>
        /// <param name="req">参考<see cref="ImportImageRequest"/></param>
        /// <returns>参考<see cref="ImportImageResponse"/>实例</returns>
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
        /// 本接口 (ImportKeyPair) 用于导入密钥对。
        /// 
        /// * 本接口的功能是将密钥对导入到用户账户，并不会自动绑定到实例。如需绑定可以使用[AssociasteInstancesKeyPair](https://cloud.tencent.com/document/api/213/9404)接口。
        /// * 需指定密钥对名称以及该密钥对的公钥文本。
        /// * 如果用户只有私钥，可以通过 `SSL` 工具将私钥转换成公钥后再导入。
        /// </summary>
        /// <param name="req"><see cref="ImportKeyPairRequest"/></param>
        /// <returns><see cref="ImportKeyPairResponse"/></returns>
        public async Task<ImportKeyPairResponse> ImportKeyPair(ImportKeyPairRequest req)
        {
             JsonResponseModel<ImportKeyPairResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ImportKeyPair接口的同步版本，本接口 (ImportKeyPair) 用于导入密钥对。
        /// 
        /// * 本接口的功能是将密钥对导入到用户账户，并不会自动绑定到实例。如需绑定可以使用[AssociasteInstancesKeyPair](https://cloud.tencent.com/document/api/213/9404)接口。
        /// * 需指定密钥对名称以及该密钥对的公钥文本。
        /// * 如果用户只有私钥，可以通过 `SSL` 工具将私钥转换成公钥后再导入。
        /// </summary>
        /// <param name="req">参考<see cref="ImportKeyPairRequest"/></param>
        /// <returns>参考<see cref="ImportKeyPairResponse"/>实例</returns>
        public ImportKeyPairResponse ImportKeyPairSync(ImportKeyPairRequest req)
        {
             JsonResponseModel<ImportKeyPairResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquiryPriceModifyInstancesChargeType) 用于切换实例的计费模式询价。
        /// 
        /// * 只支持从 `POSTPAID_BY_HOUR` 计费模式切换为`PREPAID`计费模式。
        /// * 关机不收费的实例、`BC1`和`BS1`机型族的实例、设置定时销毁的实例不支持该操作。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceModifyInstancesChargeTypeRequest"/></param>
        /// <returns><see cref="InquiryPriceModifyInstancesChargeTypeResponse"/></returns>
        public async Task<InquiryPriceModifyInstancesChargeTypeResponse> InquiryPriceModifyInstancesChargeType(InquiryPriceModifyInstancesChargeTypeRequest req)
        {
             JsonResponseModel<InquiryPriceModifyInstancesChargeTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceModifyInstancesChargeType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceModifyInstancesChargeTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// InquiryPriceModifyInstancesChargeType接口的同步版本，本接口 (InquiryPriceModifyInstancesChargeType) 用于切换实例的计费模式询价。
        /// 
        /// * 只支持从 `POSTPAID_BY_HOUR` 计费模式切换为`PREPAID`计费模式。
        /// * 关机不收费的实例、`BC1`和`BS1`机型族的实例、设置定时销毁的实例不支持该操作。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceModifyInstancesChargeTypeRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceModifyInstancesChargeTypeResponse"/>实例</returns>
        public InquiryPriceModifyInstancesChargeTypeResponse InquiryPriceModifyInstancesChargeTypeSync(InquiryPriceModifyInstancesChargeTypeRequest req)
        {
             JsonResponseModel<InquiryPriceModifyInstancesChargeTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceModifyInstancesChargeType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceModifyInstancesChargeTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquiryPriceRenewInstances) 用于续费包年包月实例询价。
        /// 
        /// * 只支持查询包年包月实例的续费价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewInstancesResponse"/></returns>
        public async Task<InquiryPriceRenewInstancesResponse> InquiryPriceRenewInstances(InquiryPriceRenewInstancesRequest req)
        {
             JsonResponseModel<InquiryPriceRenewInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceRenewInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// InquiryPriceRenewInstances接口的同步版本，本接口 (InquiryPriceRenewInstances) 用于续费包年包月实例询价。
        /// 
        /// * 只支持查询包年包月实例的续费价格。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceRenewInstancesRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceRenewInstancesResponse"/>实例</returns>
        public InquiryPriceRenewInstancesResponse InquiryPriceRenewInstancesSync(InquiryPriceRenewInstancesRequest req)
        {
             JsonResponseModel<InquiryPriceRenewInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceRenewInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquiryPriceResetInstance) 用于重装实例询价。
        /// 
        /// * 如果指定了`ImageId`参数，则使用指定的镜像进行重装询价；否则按照当前实例使用的镜像进行重装询价。
        /// * 目前只支持[系统盘类型](https://cloud.tencent.com/document/api/213/15753#SystemDisk)是`CLOUD_BASIC`、`CLOUD_PREMIUM`、`CLOUD_SSD`类型的实例使用该接口实现`Linux`和`Windows`操作系统切换的重装询价。
        /// * 目前不支持境外地域的实例使用该接口实现`Linux`和`Windows`操作系统切换的重装询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceResetInstanceResponse"/></returns>
        public async Task<InquiryPriceResetInstanceResponse> InquiryPriceResetInstance(InquiryPriceResetInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceResetInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceResetInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// InquiryPriceResetInstance接口的同步版本，本接口 (InquiryPriceResetInstance) 用于重装实例询价。
        /// 
        /// * 如果指定了`ImageId`参数，则使用指定的镜像进行重装询价；否则按照当前实例使用的镜像进行重装询价。
        /// * 目前只支持[系统盘类型](https://cloud.tencent.com/document/api/213/15753#SystemDisk)是`CLOUD_BASIC`、`CLOUD_PREMIUM`、`CLOUD_SSD`类型的实例使用该接口实现`Linux`和`Windows`操作系统切换的重装询价。
        /// * 目前不支持境外地域的实例使用该接口实现`Linux`和`Windows`操作系统切换的重装询价。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceResetInstanceRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceResetInstanceResponse"/>实例</returns>
        public InquiryPriceResetInstanceResponse InquiryPriceResetInstanceSync(InquiryPriceResetInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceResetInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceResetInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquiryPriceResetInstancesInternetMaxBandwidth) 用于调整实例公网带宽上限询价。
        /// 
        /// * 不同机型带宽上限范围不一致，具体限制详见[公网带宽上限](https://cloud.tencent.com/document/product/213/12523)。
        /// * 对于`BANDWIDTH_PREPAID`计费方式的带宽，需要输入参数`StartTime`和`EndTime`，指定调整后的带宽的生效时间段。在这种场景下目前不支持调小带宽，会涉及扣费，请确保账户余额充足。可通过[`DescribeAccountBalance`](https://cloud.tencent.com/document/product/555/20253)接口查询账户余额。
        /// * 对于 `TRAFFIC_POSTPAID_BY_HOUR`、 `BANDWIDTH_POSTPAID_BY_HOUR` 和 `BANDWIDTH_PACKAGE` 计费方式的带宽，使用该接口调整带宽上限是实时生效的，可以在带宽允许的范围内调大或者调小带宽，不支持输入参数 `StartTime` 和 `EndTime` 。
        /// * 接口不支持调整`BANDWIDTH_POSTPAID_BY_MONTH`计费方式的带宽。
        /// * 接口不支持批量调整 `BANDWIDTH_PREPAID` 和 `BANDWIDTH_POSTPAID_BY_HOUR` 计费方式的带宽。
        /// * 接口不支持批量调整混合计费方式的带宽。例如不支持同时调整`TRAFFIC_POSTPAID_BY_HOUR`和`BANDWIDTH_PACKAGE`计费方式的带宽。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetInstancesInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="InquiryPriceResetInstancesInternetMaxBandwidthResponse"/></returns>
        public async Task<InquiryPriceResetInstancesInternetMaxBandwidthResponse> InquiryPriceResetInstancesInternetMaxBandwidth(InquiryPriceResetInstancesInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<InquiryPriceResetInstancesInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceResetInstancesInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetInstancesInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// InquiryPriceResetInstancesInternetMaxBandwidth接口的同步版本，本接口 (InquiryPriceResetInstancesInternetMaxBandwidth) 用于调整实例公网带宽上限询价。
        /// 
        /// * 不同机型带宽上限范围不一致，具体限制详见[公网带宽上限](https://cloud.tencent.com/document/product/213/12523)。
        /// * 对于`BANDWIDTH_PREPAID`计费方式的带宽，需要输入参数`StartTime`和`EndTime`，指定调整后的带宽的生效时间段。在这种场景下目前不支持调小带宽，会涉及扣费，请确保账户余额充足。可通过[`DescribeAccountBalance`](https://cloud.tencent.com/document/product/555/20253)接口查询账户余额。
        /// * 对于 `TRAFFIC_POSTPAID_BY_HOUR`、 `BANDWIDTH_POSTPAID_BY_HOUR` 和 `BANDWIDTH_PACKAGE` 计费方式的带宽，使用该接口调整带宽上限是实时生效的，可以在带宽允许的范围内调大或者调小带宽，不支持输入参数 `StartTime` 和 `EndTime` 。
        /// * 接口不支持调整`BANDWIDTH_POSTPAID_BY_MONTH`计费方式的带宽。
        /// * 接口不支持批量调整 `BANDWIDTH_PREPAID` 和 `BANDWIDTH_POSTPAID_BY_HOUR` 计费方式的带宽。
        /// * 接口不支持批量调整混合计费方式的带宽。例如不支持同时调整`TRAFFIC_POSTPAID_BY_HOUR`和`BANDWIDTH_PACKAGE`计费方式的带宽。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceResetInstancesInternetMaxBandwidthRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceResetInstancesInternetMaxBandwidthResponse"/>实例</returns>
        public InquiryPriceResetInstancesInternetMaxBandwidthResponse InquiryPriceResetInstancesInternetMaxBandwidthSync(InquiryPriceResetInstancesInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<InquiryPriceResetInstancesInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceResetInstancesInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetInstancesInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquiryPriceResetInstancesType) 用于调整实例的机型询价。
        /// 
        /// * 目前只支持[系统盘类型](https://cloud.tencent.com/document/product/213/15753#SystemDisk)是`CLOUD_BASIC`、`CLOUD_PREMIUM`、`CLOUD_SSD`类型的实例使用该接口进行调整机型询价。
        /// * 目前不支持[CDH](https://cloud.tencent.com/document/product/416)实例使用该接口调整机型询价。
        /// * 对于包年包月实例，使用该接口会涉及扣费，请确保账户余额充足。可通过[`DescribeAccountBalance`](https://cloud.tencent.com/document/product/555/20253)接口查询账户余额。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetInstancesTypeRequest"/></param>
        /// <returns><see cref="InquiryPriceResetInstancesTypeResponse"/></returns>
        public async Task<InquiryPriceResetInstancesTypeResponse> InquiryPriceResetInstancesType(InquiryPriceResetInstancesTypeRequest req)
        {
             JsonResponseModel<InquiryPriceResetInstancesTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceResetInstancesType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetInstancesTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// InquiryPriceResetInstancesType接口的同步版本，本接口 (InquiryPriceResetInstancesType) 用于调整实例的机型询价。
        /// 
        /// * 目前只支持[系统盘类型](https://cloud.tencent.com/document/product/213/15753#SystemDisk)是`CLOUD_BASIC`、`CLOUD_PREMIUM`、`CLOUD_SSD`类型的实例使用该接口进行调整机型询价。
        /// * 目前不支持[CDH](https://cloud.tencent.com/document/product/416)实例使用该接口调整机型询价。
        /// * 对于包年包月实例，使用该接口会涉及扣费，请确保账户余额充足。可通过[`DescribeAccountBalance`](https://cloud.tencent.com/document/product/555/20253)接口查询账户余额。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceResetInstancesTypeRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceResetInstancesTypeResponse"/>实例</returns>
        public InquiryPriceResetInstancesTypeResponse InquiryPriceResetInstancesTypeSync(InquiryPriceResetInstancesTypeRequest req)
        {
             JsonResponseModel<InquiryPriceResetInstancesTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceResetInstancesType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetInstancesTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquiryPriceResizeInstanceDisks) 用于扩容实例的数据盘询价。
        /// 
        /// * 目前只支持扩容非弹性数据盘（[`DescribeDisks`](https://cloud.tencent.com/document/api/362/16315)接口返回值中的`Portable`为`false`表示非弹性）询价，且[数据盘类型](https://cloud.tencent.com/document/product/213/15753#DataDisk)为：`CLOUD_BASIC`、`CLOUD_PREMIUM`、`CLOUD_SSD`。
        /// * 目前不支持[CDH](https://cloud.tencent.com/document/product/416)实例使用该接口扩容数据盘询价。* 仅支持包年包月实例随机器购买的数据盘。* 目前只支持扩容一块数据盘询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResizeInstanceDisksRequest"/></param>
        /// <returns><see cref="InquiryPriceResizeInstanceDisksResponse"/></returns>
        public async Task<InquiryPriceResizeInstanceDisksResponse> InquiryPriceResizeInstanceDisks(InquiryPriceResizeInstanceDisksRequest req)
        {
             JsonResponseModel<InquiryPriceResizeInstanceDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceResizeInstanceDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResizeInstanceDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// InquiryPriceResizeInstanceDisks接口的同步版本，本接口 (InquiryPriceResizeInstanceDisks) 用于扩容实例的数据盘询价。
        /// 
        /// * 目前只支持扩容非弹性数据盘（[`DescribeDisks`](https://cloud.tencent.com/document/api/362/16315)接口返回值中的`Portable`为`false`表示非弹性）询价，且[数据盘类型](https://cloud.tencent.com/document/product/213/15753#DataDisk)为：`CLOUD_BASIC`、`CLOUD_PREMIUM`、`CLOUD_SSD`。
        /// * 目前不支持[CDH](https://cloud.tencent.com/document/product/416)实例使用该接口扩容数据盘询价。* 仅支持包年包月实例随机器购买的数据盘。* 目前只支持扩容一块数据盘询价。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceResizeInstanceDisksRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceResizeInstanceDisksResponse"/>实例</returns>
        public InquiryPriceResizeInstanceDisksResponse InquiryPriceResizeInstanceDisksSync(InquiryPriceResizeInstanceDisksRequest req)
        {
             JsonResponseModel<InquiryPriceResizeInstanceDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceResizeInstanceDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResizeInstanceDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(InquiryPriceRunInstances)用于创建实例询价。本接口仅允许针对购买限制范围内的实例配置进行询价, 详见：[创建实例](https://cloud.tencent.com/document/api/213/15730)。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRunInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceRunInstancesResponse"/></returns>
        public async Task<InquiryPriceRunInstancesResponse> InquiryPriceRunInstances(InquiryPriceRunInstancesRequest req)
        {
             JsonResponseModel<InquiryPriceRunInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceRunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// InquiryPriceRunInstances接口的同步版本，本接口(InquiryPriceRunInstances)用于创建实例询价。本接口仅允许针对购买限制范围内的实例配置进行询价, 详见：[创建实例](https://cloud.tencent.com/document/api/213/15730)。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceRunInstancesRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceRunInstancesResponse"/>实例</returns>
        public InquiryPriceRunInstancesResponse InquiryPriceRunInstancesSync(InquiryPriceRunInstancesRequest req)
        {
             JsonResponseModel<InquiryPriceRunInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceRunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyDisasterRecoverGroupAttribute)用于修改[分散置放群组](https://cloud.tencent.com/document/product/213/15486)属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyDisasterRecoverGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyDisasterRecoverGroupAttributeResponse"/></returns>
        public async Task<ModifyDisasterRecoverGroupAttributeResponse> ModifyDisasterRecoverGroupAttribute(ModifyDisasterRecoverGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyDisasterRecoverGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDisasterRecoverGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDisasterRecoverGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDisasterRecoverGroupAttribute接口的同步版本，本接口 (ModifyDisasterRecoverGroupAttribute)用于修改[分散置放群组](https://cloud.tencent.com/document/product/213/15486)属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDisasterRecoverGroupAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyDisasterRecoverGroupAttributeResponse"/>实例</returns>
        public ModifyDisasterRecoverGroupAttributeResponse ModifyDisasterRecoverGroupAttributeSync(ModifyDisasterRecoverGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyDisasterRecoverGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDisasterRecoverGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDisasterRecoverGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyHostsAttribute）用于修改CDH实例的属性，如实例名称和续费标记等。参数HostName和RenewFlag必须设置其中一个，但不能同时设置。
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsAttributeRequest"/></param>
        /// <returns><see cref="ModifyHostsAttributeResponse"/></returns>
        public async Task<ModifyHostsAttributeResponse> ModifyHostsAttribute(ModifyHostsAttributeRequest req)
        {
             JsonResponseModel<ModifyHostsAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyHostsAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHostsAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyHostsAttribute接口的同步版本，本接口（ModifyHostsAttribute）用于修改CDH实例的属性，如实例名称和续费标记等。参数HostName和RenewFlag必须设置其中一个，但不能同时设置。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyHostsAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyHostsAttributeResponse"/>实例</returns>
        public ModifyHostsAttributeResponse ModifyHostsAttributeSync(ModifyHostsAttributeRequest req)
        {
             JsonResponseModel<ModifyHostsAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyHostsAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHostsAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyImageAttribute）用于修改镜像属性。
        /// 
        /// * 已分享的镜像无法修改属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAttributeRequest"/></param>
        /// <returns><see cref="ModifyImageAttributeResponse"/></returns>
        public async Task<ModifyImageAttributeResponse> ModifyImageAttribute(ModifyImageAttributeRequest req)
        {
             JsonResponseModel<ModifyImageAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyImageAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyImageAttribute接口的同步版本，本接口（ModifyImageAttribute）用于修改镜像属性。
        /// 
        /// * 已分享的镜像无法修改属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyImageAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyImageAttributeResponse"/>实例</returns>
        public ModifyImageAttributeResponse ModifyImageAttributeSync(ModifyImageAttributeRequest req)
        {
             JsonResponseModel<ModifyImageAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyImageAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyImageSharePermission）用于修改镜像分享信息。
        /// 
        /// * 分享镜像后，被分享账户可以通过该镜像创建实例。
        /// * 每个自定义镜像最多可共享给50个账户。
        /// * 分享镜像无法更改名称，描述，仅可用于创建实例。
        /// * 只支持分享到对方账户相同地域。
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSharePermissionRequest"/></param>
        /// <returns><see cref="ModifyImageSharePermissionResponse"/></returns>
        public async Task<ModifyImageSharePermissionResponse> ModifyImageSharePermission(ModifyImageSharePermissionRequest req)
        {
             JsonResponseModel<ModifyImageSharePermissionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyImageSharePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageSharePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyImageSharePermission接口的同步版本，本接口（ModifyImageSharePermission）用于修改镜像分享信息。
        /// 
        /// * 分享镜像后，被分享账户可以通过该镜像创建实例。
        /// * 每个自定义镜像最多可共享给50个账户。
        /// * 分享镜像无法更改名称，描述，仅可用于创建实例。
        /// * 只支持分享到对方账户相同地域。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyImageSharePermissionRequest"/></param>
        /// <returns>参考<see cref="ModifyImageSharePermissionResponse"/>实例</returns>
        public ModifyImageSharePermissionResponse ModifyImageSharePermissionSync(ModifyImageSharePermissionRequest req)
        {
             JsonResponseModel<ModifyImageSharePermissionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyImageSharePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageSharePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyInstancesAttribute) 用于修改实例的属性（目前只支持修改实例的名称和关联的安全组）。
        /// 
        /// * “实例名称”仅为方便用户自己管理之用，腾讯云并不以此名称作为提交工单或是进行实例管理操作的依据。
        /// * 支持批量操作。每次请求批量实例的上限为100。
        /// * 修改关联安全组时，子机原来关联的安全组会被解绑。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
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
        /// ModifyInstancesAttribute接口的同步版本，本接口 (ModifyInstancesAttribute) 用于修改实例的属性（目前只支持修改实例的名称和关联的安全组）。
        /// 
        /// * “实例名称”仅为方便用户自己管理之用，腾讯云并不以此名称作为提交工单或是进行实例管理操作的依据。
        /// * 支持批量操作。每次请求批量实例的上限为100。
        /// * 修改关联安全组时，子机原来关联的安全组会被解绑。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyInstancesAttributeResponse"/>实例</returns>
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
        /// 本接口 (ModifyInstancesChargeType) 用于切换实例的计费模式。
        /// 
        /// * 只支持从 `POSTPAID_BY_HOUR` 计费模式切换为`PREPAID`计费模式。
        /// * 关机不收费的实例、`BC1`和`BS1`机型族的实例、设置定时销毁的实例不支持该操作。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyInstancesChargeTypeResponse"/></returns>
        public async Task<ModifyInstancesChargeTypeResponse> ModifyInstancesChargeType(ModifyInstancesChargeTypeRequest req)
        {
             JsonResponseModel<ModifyInstancesChargeTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancesChargeType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesChargeTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyInstancesChargeType接口的同步版本，本接口 (ModifyInstancesChargeType) 用于切换实例的计费模式。
        /// 
        /// * 只支持从 `POSTPAID_BY_HOUR` 计费模式切换为`PREPAID`计费模式。
        /// * 关机不收费的实例、`BC1`和`BS1`机型族的实例、设置定时销毁的实例不支持该操作。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyInstancesChargeTypeRequest"/></param>
        /// <returns>参考<see cref="ModifyInstancesChargeTypeResponse"/>实例</returns>
        public ModifyInstancesChargeTypeResponse ModifyInstancesChargeTypeSync(ModifyInstancesChargeTypeRequest req)
        {
             JsonResponseModel<ModifyInstancesChargeTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancesChargeType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesChargeTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyInstancesProject) 用于修改实例所属项目。
        /// 
        /// * 项目为一个虚拟概念，用户可以在一个账户下面建立多个项目，每个项目中管理不同的资源；将多个不同实例分属到不同项目中，后续使用 [`DescribeInstances`](https://cloud.tencent.com/document/api/213/9388)接口查询实例，项目ID可用于过滤结果。
        /// * 绑定负载均衡的实例不支持修改实例所属项目，请先使用[`DeregisterInstancesFromLoadBalancer`](https://cloud.tencent.com/document/api/214/1258)接口解绑负载均衡。
        /// * 修改实例所属项目会自动解关联实例原来关联的安全组，修改完成后可能使用[`ModifySecurityGroupsOfInstance`](https://cloud.tencent.com/document/api/213/1367)接口关联安全组。
        /// * 支持批量操作。每次请求批量实例的上限为100。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyInstancesProjectResponse"/></returns>
        public async Task<ModifyInstancesProjectResponse> ModifyInstancesProject(ModifyInstancesProjectRequest req)
        {
             JsonResponseModel<ModifyInstancesProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancesProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyInstancesProject接口的同步版本，本接口 (ModifyInstancesProject) 用于修改实例所属项目。
        /// 
        /// * 项目为一个虚拟概念，用户可以在一个账户下面建立多个项目，每个项目中管理不同的资源；将多个不同实例分属到不同项目中，后续使用 [`DescribeInstances`](https://cloud.tencent.com/document/api/213/9388)接口查询实例，项目ID可用于过滤结果。
        /// * 绑定负载均衡的实例不支持修改实例所属项目，请先使用[`DeregisterInstancesFromLoadBalancer`](https://cloud.tencent.com/document/api/214/1258)接口解绑负载均衡。
        /// * 修改实例所属项目会自动解关联实例原来关联的安全组，修改完成后可能使用[`ModifySecurityGroupsOfInstance`](https://cloud.tencent.com/document/api/213/1367)接口关联安全组。
        /// * 支持批量操作。每次请求批量实例的上限为100。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyInstancesProjectRequest"/></param>
        /// <returns>参考<see cref="ModifyInstancesProjectResponse"/>实例</returns>
        public ModifyInstancesProjectResponse ModifyInstancesProjectSync(ModifyInstancesProjectRequest req)
        {
             JsonResponseModel<ModifyInstancesProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancesProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyInstancesRenewFlag) 用于修改包年包月实例续费标识。
        /// 
        /// * 实例被标识为自动续费后，每次在实例到期时，会自动续费一个月。
        /// * 支持批量操作。每次请求批量实例的上限为100。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstancesRenewFlagResponse"/></returns>
        public async Task<ModifyInstancesRenewFlagResponse> ModifyInstancesRenewFlag(ModifyInstancesRenewFlagRequest req)
        {
             JsonResponseModel<ModifyInstancesRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancesRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyInstancesRenewFlag接口的同步版本，本接口 (ModifyInstancesRenewFlag) 用于修改包年包月实例续费标识。
        /// 
        /// * 实例被标识为自动续费后，每次在实例到期时，会自动续费一个月。
        /// * 支持批量操作。每次请求批量实例的上限为100。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyInstancesRenewFlagRequest"/></param>
        /// <returns>参考<see cref="ModifyInstancesRenewFlagResponse"/>实例</returns>
        public ModifyInstancesRenewFlagResponse ModifyInstancesRenewFlagSync(ModifyInstancesRenewFlagRequest req)
        {
             JsonResponseModel<ModifyInstancesRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancesRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyInstancesVpcAttribute)用于修改实例vpc属性，如私有网络ip。
        /// * 此操作默认会关闭实例，完成后再启动。
        /// * 当指定私有网络ID和子网ID（子网必须在实例所在的可用区）与指定实例所在私有网络不一致时，会将实例迁移至指定的私有网络的子网下。执行此操作前请确保指定的实例上没有绑定[弹性网卡](https://cloud.tencent.com/document/product/576)和[负载均衡](https://cloud.tencent.com/document/product/214)。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesVpcAttributeResponse"/></returns>
        public async Task<ModifyInstancesVpcAttributeResponse> ModifyInstancesVpcAttribute(ModifyInstancesVpcAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesVpcAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancesVpcAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesVpcAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyInstancesVpcAttribute接口的同步版本，本接口(ModifyInstancesVpcAttribute)用于修改实例vpc属性，如私有网络ip。
        /// * 此操作默认会关闭实例，完成后再启动。
        /// * 当指定私有网络ID和子网ID（子网必须在实例所在的可用区）与指定实例所在私有网络不一致时，会将实例迁移至指定的私有网络的子网下。执行此操作前请确保指定的实例上没有绑定[弹性网卡](https://cloud.tencent.com/document/product/576)和[负载均衡](https://cloud.tencent.com/document/product/214)。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyInstancesVpcAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyInstancesVpcAttributeResponse"/>实例</returns>
        public ModifyInstancesVpcAttributeResponse ModifyInstancesVpcAttributeSync(ModifyInstancesVpcAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesVpcAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancesVpcAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesVpcAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyKeyPairAttribute) 用于修改密钥对属性。
        /// 
        /// * 修改密钥对ID所指定的密钥对的名称和描述信息。
        /// * 密钥对名称不能和已经存在的密钥对的名称重复。
        /// * 密钥对ID是密钥对的唯一标识，不可修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyKeyPairAttributeRequest"/></param>
        /// <returns><see cref="ModifyKeyPairAttributeResponse"/></returns>
        public async Task<ModifyKeyPairAttributeResponse> ModifyKeyPairAttribute(ModifyKeyPairAttributeRequest req)
        {
             JsonResponseModel<ModifyKeyPairAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyKeyPairAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyKeyPairAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyKeyPairAttribute接口的同步版本，本接口 (ModifyKeyPairAttribute) 用于修改密钥对属性。
        /// 
        /// * 修改密钥对ID所指定的密钥对的名称和描述信息。
        /// * 密钥对名称不能和已经存在的密钥对的名称重复。
        /// * 密钥对ID是密钥对的唯一标识，不可修改。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyKeyPairAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyKeyPairAttributeResponse"/>实例</returns>
        public ModifyKeyPairAttributeResponse ModifyKeyPairAttributeSync(ModifyKeyPairAttributeRequest req)
        {
             JsonResponseModel<ModifyKeyPairAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyKeyPairAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyKeyPairAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(PurchaseReservedInstancesOffering)用于用户购买一个或者多个指定配置的预留实例
        /// </summary>
        /// <param name="req"><see cref="PurchaseReservedInstancesOfferingRequest"/></param>
        /// <returns><see cref="PurchaseReservedInstancesOfferingResponse"/></returns>
        public async Task<PurchaseReservedInstancesOfferingResponse> PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest req)
        {
             JsonResponseModel<PurchaseReservedInstancesOfferingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PurchaseReservedInstancesOffering");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PurchaseReservedInstancesOfferingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PurchaseReservedInstancesOffering接口的同步版本，本接口(PurchaseReservedInstancesOffering)用于用户购买一个或者多个指定配置的预留实例
        /// </summary>
        /// <param name="req">参考<see cref="PurchaseReservedInstancesOfferingRequest"/></param>
        /// <returns>参考<see cref="PurchaseReservedInstancesOfferingResponse"/>实例</returns>
        public PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOfferingSync(PurchaseReservedInstancesOfferingRequest req)
        {
             JsonResponseModel<PurchaseReservedInstancesOfferingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PurchaseReservedInstancesOffering");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PurchaseReservedInstancesOfferingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (RebootInstances) 用于重启实例。
        /// 
        /// * 只有状态为`RUNNING`的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入`REBOOTING`状态；重启实例成功时，实例会进入`RUNNING`状态。
        /// * 支持强制重启。强制重启的效果等同于关闭物理计算机的电源开关再重新启动。强制重启可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常重启时使用。
        /// * 支持批量操作，每次请求批量实例的上限为100。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
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
        /// RebootInstances接口的同步版本，本接口 (RebootInstances) 用于重启实例。
        /// 
        /// * 只有状态为`RUNNING`的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入`REBOOTING`状态；重启实例成功时，实例会进入`RUNNING`状态。
        /// * 支持强制重启。强制重启的效果等同于关闭物理计算机的电源开关再重新启动。强制重启可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常重启时使用。
        /// * 支持批量操作，每次请求批量实例的上限为100。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req">参考<see cref="RebootInstancesRequest"/></param>
        /// <returns>参考<see cref="RebootInstancesResponse"/>实例</returns>
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
        /// 本接口 (RenewHosts) 用于续费包年包月CDH实例。
        /// 
        /// * 只支持操作包年包月实例，否则操作会以特定[错误码](#4.-.E9.94.99.E8.AF.AF.E7.A0.81)返回。
        /// * 续费时请确保账户余额充足。可通过[`DescribeAccountBalance`](https://cloud.tencent.com/document/product/555/20253)接口查询账户余额。
        /// </summary>
        /// <param name="req"><see cref="RenewHostsRequest"/></param>
        /// <returns><see cref="RenewHostsResponse"/></returns>
        public async Task<RenewHostsResponse> RenewHosts(RenewHostsRequest req)
        {
             JsonResponseModel<RenewHostsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RenewHosts接口的同步版本，本接口 (RenewHosts) 用于续费包年包月CDH实例。
        /// 
        /// * 只支持操作包年包月实例，否则操作会以特定[错误码](#4.-.E9.94.99.E8.AF.AF.E7.A0.81)返回。
        /// * 续费时请确保账户余额充足。可通过[`DescribeAccountBalance`](https://cloud.tencent.com/document/product/555/20253)接口查询账户余额。
        /// </summary>
        /// <param name="req">参考<see cref="RenewHostsRequest"/></param>
        /// <returns>参考<see cref="RenewHostsResponse"/>实例</returns>
        public RenewHostsResponse RenewHostsSync(RenewHostsRequest req)
        {
             JsonResponseModel<RenewHostsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (RenewInstances) 用于续费包年包月实例。
        /// 
        /// * 只支持操作包年包月实例。
        /// * 续费时请确保账户余额充足。可通过[`DescribeAccountBalance`](https://cloud.tencent.com/document/product/555/20253)接口查询账户余额。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="RenewInstancesRequest"/></param>
        /// <returns><see cref="RenewInstancesResponse"/></returns>
        public async Task<RenewInstancesResponse> RenewInstances(RenewInstancesRequest req)
        {
             JsonResponseModel<RenewInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RenewInstances接口的同步版本，本接口 (RenewInstances) 用于续费包年包月实例。
        /// 
        /// * 只支持操作包年包月实例。
        /// * 续费时请确保账户余额充足。可通过[`DescribeAccountBalance`](https://cloud.tencent.com/document/product/555/20253)接口查询账户余额。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req">参考<see cref="RenewInstancesRequest"/></param>
        /// <returns>参考<see cref="RenewInstancesResponse"/>实例</returns>
        public RenewInstancesResponse RenewInstancesSync(RenewInstancesRequest req)
        {
             JsonResponseModel<RenewInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ResetInstance) 用于重装指定实例上的操作系统。
        /// 
        /// * 如果指定了`ImageId`参数，则使用指定的镜像重装；否则按照当前实例使用的镜像进行重装。
        /// * 系统盘将会被格式化，并重置；请确保系统盘中无重要文件。
        /// * `Linux`和`Windows`系统互相切换时，该实例系统盘`ID`将发生变化，系统盘关联快照将无法回滚、恢复数据。
        /// * 密码不指定将会通过站内信下发随机密码。
        /// * 目前只支持[系统盘类型](https://cloud.tencent.com/document/api/213/9452#SystemDisk)是`CLOUD_BASIC`、`CLOUD_PREMIUM`、`CLOUD_SSD`类型的实例使用该接口实现`Linux`和`Windows`操作系统切换。
        /// * 目前不支持境外地域的实例使用该接口实现`Linux`和`Windows`操作系统切换。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="ResetInstanceRequest"/></param>
        /// <returns><see cref="ResetInstanceResponse"/></returns>
        public async Task<ResetInstanceResponse> ResetInstance(ResetInstanceRequest req)
        {
             JsonResponseModel<ResetInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ResetInstance接口的同步版本，本接口 (ResetInstance) 用于重装指定实例上的操作系统。
        /// 
        /// * 如果指定了`ImageId`参数，则使用指定的镜像重装；否则按照当前实例使用的镜像进行重装。
        /// * 系统盘将会被格式化，并重置；请确保系统盘中无重要文件。
        /// * `Linux`和`Windows`系统互相切换时，该实例系统盘`ID`将发生变化，系统盘关联快照将无法回滚、恢复数据。
        /// * 密码不指定将会通过站内信下发随机密码。
        /// * 目前只支持[系统盘类型](https://cloud.tencent.com/document/api/213/9452#SystemDisk)是`CLOUD_BASIC`、`CLOUD_PREMIUM`、`CLOUD_SSD`类型的实例使用该接口实现`Linux`和`Windows`操作系统切换。
        /// * 目前不支持境外地域的实例使用该接口实现`Linux`和`Windows`操作系统切换。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req">参考<see cref="ResetInstanceRequest"/></param>
        /// <returns>参考<see cref="ResetInstanceResponse"/>实例</returns>
        public ResetInstanceResponse ResetInstanceSync(ResetInstanceRequest req)
        {
             JsonResponseModel<ResetInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ResetInstancesInternetMaxBandwidth) 用于调整实例公网带宽上限。
        /// 
        /// * 不同机型带宽上限范围不一致，具体限制详见[公网带宽上限](https://cloud.tencent.com/document/product/213/12523)。
        /// * 对于 `BANDWIDTH_PREPAID` 计费方式的带宽，需要输入参数 `StartTime` 和 `EndTime` ，指定调整后的带宽的生效时间段。在这种场景下目前不支持调小带宽，会涉及扣费，请确保账户余额充足。可通过 [`DescribeAccountBalance`](https://cloud.tencent.com/document/product/555/20253) 接口查询账户余额。
        /// * 对于 `TRAFFIC_POSTPAID_BY_HOUR` 、 `BANDWIDTH_POSTPAID_BY_HOUR` 和 `BANDWIDTH_PACKAGE` 计费方式的带宽，使用该接口调整带宽上限是实时生效的，可以在带宽允许的范围内调大或者调小带宽，不支持输入参数 `StartTime` 和 `EndTime` 。
        /// * 接口不支持调整 `BANDWIDTH_POSTPAID_BY_MONTH` 计费方式的带宽。
        /// * 接口不支持批量调整 `BANDWIDTH_PREPAID` 和 `BANDWIDTH_POSTPAID_BY_HOUR` 计费方式的带宽。
        /// * 接口不支持批量调整混合计费方式的带宽。例如不支持同时调整 `TRAFFIC_POSTPAID_BY_HOUR` 和 `BANDWIDTH_PACKAGE` 计费方式的带宽。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetInstancesInternetMaxBandwidthResponse"/></returns>
        public async Task<ResetInstancesInternetMaxBandwidthResponse> ResetInstancesInternetMaxBandwidth(ResetInstancesInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<ResetInstancesInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstancesInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ResetInstancesInternetMaxBandwidth接口的同步版本，本接口 (ResetInstancesInternetMaxBandwidth) 用于调整实例公网带宽上限。
        /// 
        /// * 不同机型带宽上限范围不一致，具体限制详见[公网带宽上限](https://cloud.tencent.com/document/product/213/12523)。
        /// * 对于 `BANDWIDTH_PREPAID` 计费方式的带宽，需要输入参数 `StartTime` 和 `EndTime` ，指定调整后的带宽的生效时间段。在这种场景下目前不支持调小带宽，会涉及扣费，请确保账户余额充足。可通过 [`DescribeAccountBalance`](https://cloud.tencent.com/document/product/555/20253) 接口查询账户余额。
        /// * 对于 `TRAFFIC_POSTPAID_BY_HOUR` 、 `BANDWIDTH_POSTPAID_BY_HOUR` 和 `BANDWIDTH_PACKAGE` 计费方式的带宽，使用该接口调整带宽上限是实时生效的，可以在带宽允许的范围内调大或者调小带宽，不支持输入参数 `StartTime` 和 `EndTime` 。
        /// * 接口不支持调整 `BANDWIDTH_POSTPAID_BY_MONTH` 计费方式的带宽。
        /// * 接口不支持批量调整 `BANDWIDTH_PREPAID` 和 `BANDWIDTH_POSTPAID_BY_HOUR` 计费方式的带宽。
        /// * 接口不支持批量调整混合计费方式的带宽。例如不支持同时调整 `TRAFFIC_POSTPAID_BY_HOUR` 和 `BANDWIDTH_PACKAGE` 计费方式的带宽。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req">参考<see cref="ResetInstancesInternetMaxBandwidthRequest"/></param>
        /// <returns>参考<see cref="ResetInstancesInternetMaxBandwidthResponse"/>实例</returns>
        public ResetInstancesInternetMaxBandwidthResponse ResetInstancesInternetMaxBandwidthSync(ResetInstancesInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<ResetInstancesInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstancesInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ResetInstancesPassword) 用于将实例操作系统的密码重置为用户指定的密码。
        /// 
        /// * 只修改管理员帐号的密码。实例的操作系统不同，管理员帐号也会不一样(`Windows`为`Administrator`，`Ubuntu`为`ubuntu`，其它系统为`root`)。
        /// * 重置处于运行中状态的实例，需要显式指定强制关机参数`ForceStop`。如果没有显式指定强制关机参数，则只有处于关机状态的实例才允许执行重置密码操作。
        /// * 支持批量操作。将多个实例操作系统的密码重置为相同的密码。每次请求批量实例的上限为100。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public async Task<ResetInstancesPasswordResponse> ResetInstancesPassword(ResetInstancesPasswordRequest req)
        {
             JsonResponseModel<ResetInstancesPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstancesPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ResetInstancesPassword接口的同步版本，本接口 (ResetInstancesPassword) 用于将实例操作系统的密码重置为用户指定的密码。
        /// 
        /// * 只修改管理员帐号的密码。实例的操作系统不同，管理员帐号也会不一样(`Windows`为`Administrator`，`Ubuntu`为`ubuntu`，其它系统为`root`)。
        /// * 重置处于运行中状态的实例，需要显式指定强制关机参数`ForceStop`。如果没有显式指定强制关机参数，则只有处于关机状态的实例才允许执行重置密码操作。
        /// * 支持批量操作。将多个实例操作系统的密码重置为相同的密码。每次请求批量实例的上限为100。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req">参考<see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns>参考<see cref="ResetInstancesPasswordResponse"/>实例</returns>
        public ResetInstancesPasswordResponse ResetInstancesPasswordSync(ResetInstancesPasswordRequest req)
        {
             JsonResponseModel<ResetInstancesPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstancesPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ResetInstancesType) 用于调整实例的机型。
        /// * 目前只支持[系统盘类型](/document/api/213/9452#block_device)是`CLOUD_BASIC`、`CLOUD_PREMIUM`、`CLOUD_SSD`类型的实例使用该接口进行机型调整。
        /// * 目前不支持[CDH](https://cloud.tencent.com/document/product/416)实例使用该接口调整机型。对于包年包月实例，使用该接口会涉及扣费，请确保账户余额充足。可通过[`DescribeAccountBalance`](https://cloud.tencent.com/document/product/555/20253)接口查询账户余额。
        /// * 本接口为异步接口，调整实例配置请求发送成功后会返回一个RequestId，此时操作并未立即完成。实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表调整实例配置操作成功。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesTypeRequest"/></param>
        /// <returns><see cref="ResetInstancesTypeResponse"/></returns>
        public async Task<ResetInstancesTypeResponse> ResetInstancesType(ResetInstancesTypeRequest req)
        {
             JsonResponseModel<ResetInstancesTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstancesType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ResetInstancesType接口的同步版本，本接口 (ResetInstancesType) 用于调整实例的机型。
        /// * 目前只支持[系统盘类型](/document/api/213/9452#block_device)是`CLOUD_BASIC`、`CLOUD_PREMIUM`、`CLOUD_SSD`类型的实例使用该接口进行机型调整。
        /// * 目前不支持[CDH](https://cloud.tencent.com/document/product/416)实例使用该接口调整机型。对于包年包月实例，使用该接口会涉及扣费，请确保账户余额充足。可通过[`DescribeAccountBalance`](https://cloud.tencent.com/document/product/555/20253)接口查询账户余额。
        /// * 本接口为异步接口，调整实例配置请求发送成功后会返回一个RequestId，此时操作并未立即完成。实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表调整实例配置操作成功。
        /// </summary>
        /// <param name="req">参考<see cref="ResetInstancesTypeRequest"/></param>
        /// <returns>参考<see cref="ResetInstancesTypeResponse"/>实例</returns>
        public ResetInstancesTypeResponse ResetInstancesTypeSync(ResetInstancesTypeRequest req)
        {
             JsonResponseModel<ResetInstancesTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstancesType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ResizeInstanceDisks) 用于扩容实例的数据盘。
        /// 
        /// * 目前只支持扩容非弹性数据盘（[`DescribeDisks`](https://cloud.tencent.com/document/api/362/16315)接口返回值中的`Portable`为`false`表示非弹性），且[数据盘类型](https://cloud.tencent.com/document/api/213/15753#DataDisk)为：`CLOUD_BASIC`、`CLOUD_PREMIUM`、`CLOUD_SSD`。
        /// * 目前不支持[CDH](https://cloud.tencent.com/document/product/416)实例使用该接口扩容数据盘。
        /// * 对于包年包月实例，使用该接口会涉及扣费，请确保账户余额充足。可通过[`DescribeAccountBalance`](https://cloud.tencent.com/document/product/555/20253)接口查询账户余额。
        /// * 目前只支持扩容一块数据盘。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="ResizeInstanceDisksRequest"/></param>
        /// <returns><see cref="ResizeInstanceDisksResponse"/></returns>
        public async Task<ResizeInstanceDisksResponse> ResizeInstanceDisks(ResizeInstanceDisksRequest req)
        {
             JsonResponseModel<ResizeInstanceDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResizeInstanceDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResizeInstanceDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ResizeInstanceDisks接口的同步版本，本接口 (ResizeInstanceDisks) 用于扩容实例的数据盘。
        /// 
        /// * 目前只支持扩容非弹性数据盘（[`DescribeDisks`](https://cloud.tencent.com/document/api/362/16315)接口返回值中的`Portable`为`false`表示非弹性），且[数据盘类型](https://cloud.tencent.com/document/api/213/15753#DataDisk)为：`CLOUD_BASIC`、`CLOUD_PREMIUM`、`CLOUD_SSD`。
        /// * 目前不支持[CDH](https://cloud.tencent.com/document/product/416)实例使用该接口扩容数据盘。
        /// * 对于包年包月实例，使用该接口会涉及扣费，请确保账户余额充足。可通过[`DescribeAccountBalance`](https://cloud.tencent.com/document/product/555/20253)接口查询账户余额。
        /// * 目前只支持扩容一块数据盘。
        /// * 实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req">参考<see cref="ResizeInstanceDisksRequest"/></param>
        /// <returns>参考<see cref="ResizeInstanceDisksResponse"/>实例</returns>
        public ResizeInstanceDisksResponse ResizeInstanceDisksSync(ResizeInstanceDisksRequest req)
        {
             JsonResponseModel<ResizeInstanceDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResizeInstanceDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResizeInstanceDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (RunInstances) 用于创建一个或多个指定配置的实例。
        /// 
        /// * 实例创建成功后将自动开机启动，[实例状态](https://cloud.tencent.com/document/product/213/15753#InstanceStatus)变为“运行中”。
        /// * 预付费实例的购买会预先扣除本次实例购买所需金额，按小时后付费实例购买会预先冻结本次实例购买一小时内所需金额，在调用本接口前请确保账户余额充足。
        /// * 本接口允许购买的实例数量遵循[CVM实例购买限制](https://cloud.tencent.com/document/product/213/2664)，所创建的实例和官网入口创建的实例共用配额。
        /// * 本接口为异步接口，当创建请求下发成功后会返回一个实例`ID`列表，此时实例的创建并立即未完成。在此期间实例的状态将会处于“准备中”，可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728) 接口查询对应实例的状态，来判断创建有没有最终成功。如果实例的状态由“准备中”变为“运行中”，则为创建成功。
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public async Task<RunInstancesResponse> RunInstances(RunInstancesRequest req)
        {
             JsonResponseModel<RunInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RunInstances接口的同步版本，本接口 (RunInstances) 用于创建一个或多个指定配置的实例。
        /// 
        /// * 实例创建成功后将自动开机启动，[实例状态](https://cloud.tencent.com/document/product/213/15753#InstanceStatus)变为“运行中”。
        /// * 预付费实例的购买会预先扣除本次实例购买所需金额，按小时后付费实例购买会预先冻结本次实例购买一小时内所需金额，在调用本接口前请确保账户余额充足。
        /// * 本接口允许购买的实例数量遵循[CVM实例购买限制](https://cloud.tencent.com/document/product/213/2664)，所创建的实例和官网入口创建的实例共用配额。
        /// * 本接口为异步接口，当创建请求下发成功后会返回一个实例`ID`列表，此时实例的创建并立即未完成。在此期间实例的状态将会处于“准备中”，可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728) 接口查询对应实例的状态，来判断创建有没有最终成功。如果实例的状态由“准备中”变为“运行中”，则为创建成功。
        /// </summary>
        /// <param name="req">参考<see cref="RunInstancesRequest"/></param>
        /// <returns>参考<see cref="RunInstancesResponse"/>实例</returns>
        public RunInstancesResponse RunInstancesSync(RunInstancesRequest req)
        {
             JsonResponseModel<RunInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (StartInstances) 用于启动一个或多个实例。
        /// 
        /// * 只有状态为`STOPPED`的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入`STARTING`状态；启动实例成功时，实例会进入`RUNNING`状态。
        /// * 支持批量操作。每次请求批量实例的上限为100。
        /// * 本接口为异步接口，启动实例请求发送成功后会返回一个RequestId，此时操作并未立即完成。实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表启动实例操作成功。
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public async Task<StartInstancesResponse> StartInstances(StartInstancesRequest req)
        {
             JsonResponseModel<StartInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StartInstances接口的同步版本，本接口 (StartInstances) 用于启动一个或多个实例。
        /// 
        /// * 只有状态为`STOPPED`的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入`STARTING`状态；启动实例成功时，实例会进入`RUNNING`状态。
        /// * 支持批量操作。每次请求批量实例的上限为100。
        /// * 本接口为异步接口，启动实例请求发送成功后会返回一个RequestId，此时操作并未立即完成。实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表启动实例操作成功。
        /// </summary>
        /// <param name="req">参考<see cref="StartInstancesRequest"/></param>
        /// <returns>参考<see cref="StartInstancesResponse"/>实例</returns>
        public StartInstancesResponse StartInstancesSync(StartInstancesRequest req)
        {
             JsonResponseModel<StartInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (StopInstances) 用于关闭一个或多个实例。
        /// 
        /// * 只有状态为`RUNNING`的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入`STOPPING`状态；关闭实例成功时，实例会进入`STOPPED`状态。
        /// * 支持强制关闭。强制关机的效果等同于关闭物理计算机的电源开关。强制关机可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常关机时使用。
        /// * 支持批量操作。每次请求批量实例的上限为100。
        /// * 本接口为异步接口，关闭实例请求发送成功后会返回一个RequestId，此时操作并未立即完成。实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表关闭实例操作成功。
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public async Task<StopInstancesResponse> StopInstances(StopInstancesRequest req)
        {
             JsonResponseModel<StopInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StopInstances接口的同步版本，本接口 (StopInstances) 用于关闭一个或多个实例。
        /// 
        /// * 只有状态为`RUNNING`的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入`STOPPING`状态；关闭实例成功时，实例会进入`STOPPED`状态。
        /// * 支持强制关闭。强制关机的效果等同于关闭物理计算机的电源开关。强制关机可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常关机时使用。
        /// * 支持批量操作。每次请求批量实例的上限为100。
        /// * 本接口为异步接口，关闭实例请求发送成功后会返回一个RequestId，此时操作并未立即完成。实例操作结果可以通过调用 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728#.E7.A4.BA.E4.BE.8B3-.E6.9F.A5.E8.AF.A2.E5.AE.9E.E4.BE.8B.E7.9A.84.E6.9C.80.E6.96.B0.E6.93.8D.E4.BD.9C.E6.83.85.E5.86.B5) 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表关闭实例操作成功。
        /// </summary>
        /// <param name="req">参考<see cref="StopInstancesRequest"/></param>
        /// <returns>参考<see cref="StopInstancesResponse"/>实例</returns>
        public StopInstancesResponse StopInstancesSync(StopInstancesRequest req)
        {
             JsonResponseModel<StopInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SyncImages）用于将自定义镜像同步到其它地区。
        /// 
        /// * 该接口每次调用只支持同步一个镜像。
        /// * 该接口支持多个同步地域。
        /// * 单个帐号在每个地域最多支持存在10个自定义镜像。
        /// </summary>
        /// <param name="req"><see cref="SyncImagesRequest"/></param>
        /// <returns><see cref="SyncImagesResponse"/></returns>
        public async Task<SyncImagesResponse> SyncImages(SyncImagesRequest req)
        {
             JsonResponseModel<SyncImagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SyncImages接口的同步版本，本接口（SyncImages）用于将自定义镜像同步到其它地区。
        /// 
        /// * 该接口每次调用只支持同步一个镜像。
        /// * 该接口支持多个同步地域。
        /// * 单个帐号在每个地域最多支持存在10个自定义镜像。
        /// </summary>
        /// <param name="req">参考<see cref="SyncImagesRequest"/></param>
        /// <returns>参考<see cref="SyncImagesResponse"/>实例</returns>
        public SyncImagesResponse SyncImagesSync(SyncImagesRequest req)
        {
             JsonResponseModel<SyncImagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (TerminateInstances) 用于主动退还实例。
        /// 
        /// * 不再使用的实例，可通过本接口主动退还。
        /// * 按量计费的实例通过本接口可直接退还；包年包月实例如符合[退还规则](https://cloud.tencent.com/document/product/213/9711)，也可通过本接口主动退还。
        /// * 首次调用本接口，实例将被移至回收站，再次调用本接口，实例将被销毁，且不可恢复。
        /// * 支持批量操作，每次请求批量实例的上限为100。
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
        /// TerminateInstances接口的同步版本，本接口 (TerminateInstances) 用于主动退还实例。
        /// 
        /// * 不再使用的实例，可通过本接口主动退还。
        /// * 按量计费的实例通过本接口可直接退还；包年包月实例如符合[退还规则](https://cloud.tencent.com/document/product/213/9711)，也可通过本接口主动退还。
        /// * 首次调用本接口，实例将被移至回收站，再次调用本接口，实例将被销毁，且不可恢复。
        /// * 支持批量操作，每次请求批量实例的上限为100。
        /// </summary>
        /// <param name="req">参考<see cref="TerminateInstancesRequest"/></param>
        /// <returns>参考<see cref="TerminateInstancesResponse"/>实例</returns>
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
