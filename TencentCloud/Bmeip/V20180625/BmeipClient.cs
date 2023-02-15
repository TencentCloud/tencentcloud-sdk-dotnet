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

namespace TencentCloud.Bmeip.V20180625
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bmeip.V20180625.Models;

   public class BmeipClient : AbstractClient{

       private const string endpoint = "bmeip.tencentcloudapi.com";
       private const string version = "2018-06-25";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BmeipClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BmeipClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 此接口用于为某个 EIP 关联 ACL。
        /// </summary>
        /// <param name="req"><see cref="BindEipAclsRequest"/></param>
        /// <returns><see cref="BindEipAclsResponse"/></returns>
        public async Task<BindEipAclsResponse> BindEipAcls(BindEipAclsRequest req)
        {
             JsonResponseModel<BindEipAclsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindEipAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindEipAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于为某个 EIP 关联 ACL。
        /// </summary>
        /// <param name="req"><see cref="BindEipAclsRequest"/></param>
        /// <returns><see cref="BindEipAclsResponse"/></returns>
        public BindEipAclsResponse BindEipAclsSync(BindEipAclsRequest req)
        {
             JsonResponseModel<BindEipAclsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindEipAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindEipAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// BindHosted接口用于绑定黑石弹性公网IP到黑石托管机器上
        /// </summary>
        /// <param name="req"><see cref="BindHostedRequest"/></param>
        /// <returns><see cref="BindHostedResponse"/></returns>
        public async Task<BindHostedResponse> BindHosted(BindHostedRequest req)
        {
             JsonResponseModel<BindHostedResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindHosted");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindHostedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// BindHosted接口用于绑定黑石弹性公网IP到黑石托管机器上
        /// </summary>
        /// <param name="req"><see cref="BindHostedRequest"/></param>
        /// <returns><see cref="BindHostedResponse"/></returns>
        public BindHostedResponse BindHostedSync(BindHostedRequest req)
        {
             JsonResponseModel<BindHostedResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindHosted");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindHostedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定黑石EIP
        /// </summary>
        /// <param name="req"><see cref="BindRsRequest"/></param>
        /// <returns><see cref="BindRsResponse"/></returns>
        public async Task<BindRsResponse> BindRs(BindRsRequest req)
        {
             JsonResponseModel<BindRsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindRs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindRsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定黑石EIP
        /// </summary>
        /// <param name="req"><see cref="BindRsRequest"/></param>
        /// <returns><see cref="BindRsResponse"/></returns>
        public BindRsResponse BindRsSync(BindRsRequest req)
        {
             JsonResponseModel<BindRsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindRs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindRsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 黑石EIP绑定VPC IP
        /// </summary>
        /// <param name="req"><see cref="BindVpcIpRequest"/></param>
        /// <returns><see cref="BindVpcIpResponse"/></returns>
        public async Task<BindVpcIpResponse> BindVpcIp(BindVpcIpRequest req)
        {
             JsonResponseModel<BindVpcIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindVpcIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindVpcIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 黑石EIP绑定VPC IP
        /// </summary>
        /// <param name="req"><see cref="BindVpcIpRequest"/></param>
        /// <returns><see cref="BindVpcIpResponse"/></returns>
        public BindVpcIpResponse BindVpcIpSync(BindVpcIpRequest req)
        {
             JsonResponseModel<BindVpcIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindVpcIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindVpcIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建黑石弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="CreateEipRequest"/></param>
        /// <returns><see cref="CreateEipResponse"/></returns>
        public async Task<CreateEipResponse> CreateEip(CreateEipRequest req)
        {
             JsonResponseModel<CreateEipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建黑石弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="CreateEipRequest"/></param>
        /// <returns><see cref="CreateEipResponse"/></returns>
        public CreateEipResponse CreateEipSync(CreateEipRequest req)
        {
             JsonResponseModel<CreateEipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建黑石弹性公网 EIP ACL
        /// </summary>
        /// <param name="req"><see cref="CreateEipAclRequest"/></param>
        /// <returns><see cref="CreateEipAclResponse"/></returns>
        public async Task<CreateEipAclResponse> CreateEipAcl(CreateEipAclRequest req)
        {
             JsonResponseModel<CreateEipAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEipAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEipAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建黑石弹性公网 EIP ACL
        /// </summary>
        /// <param name="req"><see cref="CreateEipAclRequest"/></param>
        /// <returns><see cref="CreateEipAclResponse"/></returns>
        public CreateEipAclResponse CreateEipAclSync(CreateEipAclRequest req)
        {
             JsonResponseModel<CreateEipAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEipAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEipAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 释放黑石弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="DeleteEipRequest"/></param>
        /// <returns><see cref="DeleteEipResponse"/></returns>
        public async Task<DeleteEipResponse> DeleteEip(DeleteEipRequest req)
        {
             JsonResponseModel<DeleteEipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 释放黑石弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="DeleteEipRequest"/></param>
        /// <returns><see cref="DeleteEipResponse"/></returns>
        public DeleteEipResponse DeleteEipSync(DeleteEipRequest req)
        {
             JsonResponseModel<DeleteEipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除弹性公网IP ACL
        /// </summary>
        /// <param name="req"><see cref="DeleteEipAclRequest"/></param>
        /// <returns><see cref="DeleteEipAclResponse"/></returns>
        public async Task<DeleteEipAclResponse> DeleteEipAcl(DeleteEipAclRequest req)
        {
             JsonResponseModel<DeleteEipAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEipAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEipAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除弹性公网IP ACL
        /// </summary>
        /// <param name="req"><see cref="DeleteEipAclRequest"/></param>
        /// <returns><see cref="DeleteEipAclResponse"/></returns>
        public DeleteEipAclResponse DeleteEipAclSync(DeleteEipAclRequest req)
        {
             JsonResponseModel<DeleteEipAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEipAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEipAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询弹性公网IP ACL
        /// </summary>
        /// <param name="req"><see cref="DescribeEipAclsRequest"/></param>
        /// <returns><see cref="DescribeEipAclsResponse"/></returns>
        public async Task<DescribeEipAclsResponse> DescribeEipAcls(DescribeEipAclsRequest req)
        {
             JsonResponseModel<DescribeEipAclsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEipAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEipAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询弹性公网IP ACL
        /// </summary>
        /// <param name="req"><see cref="DescribeEipAclsRequest"/></param>
        /// <returns><see cref="DescribeEipAclsResponse"/></returns>
        public DescribeEipAclsResponse DescribeEipAclsSync(DescribeEipAclsRequest req)
        {
             JsonResponseModel<DescribeEipAclsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEipAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEipAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询黑石EIP 限额
        /// </summary>
        /// <param name="req"><see cref="DescribeEipQuotaRequest"/></param>
        /// <returns><see cref="DescribeEipQuotaResponse"/></returns>
        public async Task<DescribeEipQuotaResponse> DescribeEipQuota(DescribeEipQuotaRequest req)
        {
             JsonResponseModel<DescribeEipQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEipQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEipQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询黑石EIP 限额
        /// </summary>
        /// <param name="req"><see cref="DescribeEipQuotaRequest"/></param>
        /// <returns><see cref="DescribeEipQuotaResponse"/></returns>
        public DescribeEipQuotaResponse DescribeEipQuotaSync(DescribeEipQuotaRequest req)
        {
             JsonResponseModel<DescribeEipQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEipQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEipQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 黑石EIP查询任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEipTaskRequest"/></param>
        /// <returns><see cref="DescribeEipTaskResponse"/></returns>
        public async Task<DescribeEipTaskResponse> DescribeEipTask(DescribeEipTaskRequest req)
        {
             JsonResponseModel<DescribeEipTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEipTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEipTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 黑石EIP查询任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEipTaskRequest"/></param>
        /// <returns><see cref="DescribeEipTaskResponse"/></returns>
        public DescribeEipTaskResponse DescribeEipTaskSync(DescribeEipTaskRequest req)
        {
             JsonResponseModel<DescribeEipTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEipTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEipTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 黑石EIP查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeEipsRequest"/></param>
        /// <returns><see cref="DescribeEipsResponse"/></returns>
        public async Task<DescribeEipsResponse> DescribeEips(DescribeEipsRequest req)
        {
             JsonResponseModel<DescribeEipsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEips");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEipsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 黑石EIP查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeEipsRequest"/></param>
        /// <returns><see cref="DescribeEipsResponse"/></returns>
        public DescribeEipsResponse DescribeEipsSync(DescribeEipsRequest req)
        {
             JsonResponseModel<DescribeEipsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEips");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEipsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改弹性公网IP ACL
        /// </summary>
        /// <param name="req"><see cref="ModifyEipAclRequest"/></param>
        /// <returns><see cref="ModifyEipAclResponse"/></returns>
        public async Task<ModifyEipAclResponse> ModifyEipAcl(ModifyEipAclRequest req)
        {
             JsonResponseModel<ModifyEipAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEipAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEipAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改弹性公网IP ACL
        /// </summary>
        /// <param name="req"><see cref="ModifyEipAclRequest"/></param>
        /// <returns><see cref="ModifyEipAclResponse"/></returns>
        public ModifyEipAclResponse ModifyEipAclSync(ModifyEipAclRequest req)
        {
             JsonResponseModel<ModifyEipAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEipAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEipAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 黑石EIP修改计费方式
        /// </summary>
        /// <param name="req"><see cref="ModifyEipChargeRequest"/></param>
        /// <returns><see cref="ModifyEipChargeResponse"/></returns>
        public async Task<ModifyEipChargeResponse> ModifyEipCharge(ModifyEipChargeRequest req)
        {
             JsonResponseModel<ModifyEipChargeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEipCharge");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEipChargeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 黑石EIP修改计费方式
        /// </summary>
        /// <param name="req"><see cref="ModifyEipChargeRequest"/></param>
        /// <returns><see cref="ModifyEipChargeResponse"/></returns>
        public ModifyEipChargeResponse ModifyEipChargeSync(ModifyEipChargeRequest req)
        {
             JsonResponseModel<ModifyEipChargeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEipCharge");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEipChargeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新黑石EIP名称
        /// </summary>
        /// <param name="req"><see cref="ModifyEipNameRequest"/></param>
        /// <returns><see cref="ModifyEipNameResponse"/></returns>
        public async Task<ModifyEipNameResponse> ModifyEipName(ModifyEipNameRequest req)
        {
             JsonResponseModel<ModifyEipNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEipName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEipNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新黑石EIP名称
        /// </summary>
        /// <param name="req"><see cref="ModifyEipNameRequest"/></param>
        /// <returns><see cref="ModifyEipNameResponse"/></returns>
        public ModifyEipNameResponse ModifyEipNameSync(ModifyEipNameRequest req)
        {
             JsonResponseModel<ModifyEipNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEipName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEipNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑弹性公网IP ACL
        /// </summary>
        /// <param name="req"><see cref="UnbindEipAclsRequest"/></param>
        /// <returns><see cref="UnbindEipAclsResponse"/></returns>
        public async Task<UnbindEipAclsResponse> UnbindEipAcls(UnbindEipAclsRequest req)
        {
             JsonResponseModel<UnbindEipAclsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindEipAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindEipAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑弹性公网IP ACL
        /// </summary>
        /// <param name="req"><see cref="UnbindEipAclsRequest"/></param>
        /// <returns><see cref="UnbindEipAclsResponse"/></returns>
        public UnbindEipAclsResponse UnbindEipAclsSync(UnbindEipAclsRequest req)
        {
             JsonResponseModel<UnbindEipAclsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindEipAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindEipAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UnbindHosted接口用于解绑托管机器上的EIP
        /// </summary>
        /// <param name="req"><see cref="UnbindHostedRequest"/></param>
        /// <returns><see cref="UnbindHostedResponse"/></returns>
        public async Task<UnbindHostedResponse> UnbindHosted(UnbindHostedRequest req)
        {
             JsonResponseModel<UnbindHostedResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindHosted");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindHostedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UnbindHosted接口用于解绑托管机器上的EIP
        /// </summary>
        /// <param name="req"><see cref="UnbindHostedRequest"/></param>
        /// <returns><see cref="UnbindHostedResponse"/></returns>
        public UnbindHostedResponse UnbindHostedSync(UnbindHostedRequest req)
        {
             JsonResponseModel<UnbindHostedResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindHosted");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindHostedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑黑石EIP
        /// </summary>
        /// <param name="req"><see cref="UnbindRsRequest"/></param>
        /// <returns><see cref="UnbindRsResponse"/></returns>
        public async Task<UnbindRsResponse> UnbindRs(UnbindRsRequest req)
        {
             JsonResponseModel<UnbindRsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindRs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindRsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑黑石EIP
        /// </summary>
        /// <param name="req"><see cref="UnbindRsRequest"/></param>
        /// <returns><see cref="UnbindRsResponse"/></returns>
        public UnbindRsResponse UnbindRsSync(UnbindRsRequest req)
        {
             JsonResponseModel<UnbindRsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindRs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindRsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量解绑物理机弹性公网IP接口
        /// </summary>
        /// <param name="req"><see cref="UnbindRsListRequest"/></param>
        /// <returns><see cref="UnbindRsListResponse"/></returns>
        public async Task<UnbindRsListResponse> UnbindRsList(UnbindRsListRequest req)
        {
             JsonResponseModel<UnbindRsListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindRsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindRsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量解绑物理机弹性公网IP接口
        /// </summary>
        /// <param name="req"><see cref="UnbindRsListRequest"/></param>
        /// <returns><see cref="UnbindRsListResponse"/></returns>
        public UnbindRsListResponse UnbindRsListSync(UnbindRsListRequest req)
        {
             JsonResponseModel<UnbindRsListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindRsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindRsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 黑石EIP解绑VPCIP
        /// </summary>
        /// <param name="req"><see cref="UnbindVpcIpRequest"/></param>
        /// <returns><see cref="UnbindVpcIpResponse"/></returns>
        public async Task<UnbindVpcIpResponse> UnbindVpcIp(UnbindVpcIpRequest req)
        {
             JsonResponseModel<UnbindVpcIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindVpcIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindVpcIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 黑石EIP解绑VPCIP
        /// </summary>
        /// <param name="req"><see cref="UnbindVpcIpRequest"/></param>
        /// <returns><see cref="UnbindVpcIpResponse"/></returns>
        public UnbindVpcIpResponse UnbindVpcIpSync(UnbindVpcIpRequest req)
        {
             JsonResponseModel<UnbindVpcIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindVpcIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindVpcIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
