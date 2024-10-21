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
       private const string sdkVersion = "SDK_NET_3.0.1110";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BmeipClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 此接口用于为某个 EIP 关联 ACL。
        /// </summary>
        /// <param name="req"><see cref="BindEipAclsRequest"/></param>
        /// <returns><see cref="BindEipAclsResponse"/></returns>
        public Task<BindEipAclsResponse> BindEipAcls(BindEipAclsRequest req)
        {
            return InternalRequestAsync<BindEipAclsResponse>(req, "BindEipAcls");
        }

        /// <summary>
        /// 此接口用于为某个 EIP 关联 ACL。
        /// </summary>
        /// <param name="req"><see cref="BindEipAclsRequest"/></param>
        /// <returns><see cref="BindEipAclsResponse"/></returns>
        public BindEipAclsResponse BindEipAclsSync(BindEipAclsRequest req)
        {
            return InternalRequestAsync<BindEipAclsResponse>(req, "BindEipAcls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// BindHosted接口用于绑定黑石弹性公网IP到黑石托管机器上
        /// </summary>
        /// <param name="req"><see cref="BindHostedRequest"/></param>
        /// <returns><see cref="BindHostedResponse"/></returns>
        public Task<BindHostedResponse> BindHosted(BindHostedRequest req)
        {
            return InternalRequestAsync<BindHostedResponse>(req, "BindHosted");
        }

        /// <summary>
        /// BindHosted接口用于绑定黑石弹性公网IP到黑石托管机器上
        /// </summary>
        /// <param name="req"><see cref="BindHostedRequest"/></param>
        /// <returns><see cref="BindHostedResponse"/></returns>
        public BindHostedResponse BindHostedSync(BindHostedRequest req)
        {
            return InternalRequestAsync<BindHostedResponse>(req, "BindHosted")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定黑石EIP
        /// </summary>
        /// <param name="req"><see cref="BindRsRequest"/></param>
        /// <returns><see cref="BindRsResponse"/></returns>
        public Task<BindRsResponse> BindRs(BindRsRequest req)
        {
            return InternalRequestAsync<BindRsResponse>(req, "BindRs");
        }

        /// <summary>
        /// 绑定黑石EIP
        /// </summary>
        /// <param name="req"><see cref="BindRsRequest"/></param>
        /// <returns><see cref="BindRsResponse"/></returns>
        public BindRsResponse BindRsSync(BindRsRequest req)
        {
            return InternalRequestAsync<BindRsResponse>(req, "BindRs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 黑石EIP绑定VPC IP
        /// </summary>
        /// <param name="req"><see cref="BindVpcIpRequest"/></param>
        /// <returns><see cref="BindVpcIpResponse"/></returns>
        public Task<BindVpcIpResponse> BindVpcIp(BindVpcIpRequest req)
        {
            return InternalRequestAsync<BindVpcIpResponse>(req, "BindVpcIp");
        }

        /// <summary>
        /// 黑石EIP绑定VPC IP
        /// </summary>
        /// <param name="req"><see cref="BindVpcIpRequest"/></param>
        /// <returns><see cref="BindVpcIpResponse"/></returns>
        public BindVpcIpResponse BindVpcIpSync(BindVpcIpRequest req)
        {
            return InternalRequestAsync<BindVpcIpResponse>(req, "BindVpcIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建黑石弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="CreateEipRequest"/></param>
        /// <returns><see cref="CreateEipResponse"/></returns>
        public Task<CreateEipResponse> CreateEip(CreateEipRequest req)
        {
            return InternalRequestAsync<CreateEipResponse>(req, "CreateEip");
        }

        /// <summary>
        /// 创建黑石弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="CreateEipRequest"/></param>
        /// <returns><see cref="CreateEipResponse"/></returns>
        public CreateEipResponse CreateEipSync(CreateEipRequest req)
        {
            return InternalRequestAsync<CreateEipResponse>(req, "CreateEip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建黑石弹性公网 EIP ACL
        /// </summary>
        /// <param name="req"><see cref="CreateEipAclRequest"/></param>
        /// <returns><see cref="CreateEipAclResponse"/></returns>
        public Task<CreateEipAclResponse> CreateEipAcl(CreateEipAclRequest req)
        {
            return InternalRequestAsync<CreateEipAclResponse>(req, "CreateEipAcl");
        }

        /// <summary>
        /// 创建黑石弹性公网 EIP ACL
        /// </summary>
        /// <param name="req"><see cref="CreateEipAclRequest"/></param>
        /// <returns><see cref="CreateEipAclResponse"/></returns>
        public CreateEipAclResponse CreateEipAclSync(CreateEipAclRequest req)
        {
            return InternalRequestAsync<CreateEipAclResponse>(req, "CreateEipAcl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 释放黑石弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="DeleteEipRequest"/></param>
        /// <returns><see cref="DeleteEipResponse"/></returns>
        public Task<DeleteEipResponse> DeleteEip(DeleteEipRequest req)
        {
            return InternalRequestAsync<DeleteEipResponse>(req, "DeleteEip");
        }

        /// <summary>
        /// 释放黑石弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="DeleteEipRequest"/></param>
        /// <returns><see cref="DeleteEipResponse"/></returns>
        public DeleteEipResponse DeleteEipSync(DeleteEipRequest req)
        {
            return InternalRequestAsync<DeleteEipResponse>(req, "DeleteEip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除弹性公网IP ACL
        /// </summary>
        /// <param name="req"><see cref="DeleteEipAclRequest"/></param>
        /// <returns><see cref="DeleteEipAclResponse"/></returns>
        public Task<DeleteEipAclResponse> DeleteEipAcl(DeleteEipAclRequest req)
        {
            return InternalRequestAsync<DeleteEipAclResponse>(req, "DeleteEipAcl");
        }

        /// <summary>
        /// 删除弹性公网IP ACL
        /// </summary>
        /// <param name="req"><see cref="DeleteEipAclRequest"/></param>
        /// <returns><see cref="DeleteEipAclResponse"/></returns>
        public DeleteEipAclResponse DeleteEipAclSync(DeleteEipAclRequest req)
        {
            return InternalRequestAsync<DeleteEipAclResponse>(req, "DeleteEipAcl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询弹性公网IP ACL
        /// </summary>
        /// <param name="req"><see cref="DescribeEipAclsRequest"/></param>
        /// <returns><see cref="DescribeEipAclsResponse"/></returns>
        public Task<DescribeEipAclsResponse> DescribeEipAcls(DescribeEipAclsRequest req)
        {
            return InternalRequestAsync<DescribeEipAclsResponse>(req, "DescribeEipAcls");
        }

        /// <summary>
        /// 查询弹性公网IP ACL
        /// </summary>
        /// <param name="req"><see cref="DescribeEipAclsRequest"/></param>
        /// <returns><see cref="DescribeEipAclsResponse"/></returns>
        public DescribeEipAclsResponse DescribeEipAclsSync(DescribeEipAclsRequest req)
        {
            return InternalRequestAsync<DescribeEipAclsResponse>(req, "DescribeEipAcls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询黑石EIP 限额
        /// </summary>
        /// <param name="req"><see cref="DescribeEipQuotaRequest"/></param>
        /// <returns><see cref="DescribeEipQuotaResponse"/></returns>
        public Task<DescribeEipQuotaResponse> DescribeEipQuota(DescribeEipQuotaRequest req)
        {
            return InternalRequestAsync<DescribeEipQuotaResponse>(req, "DescribeEipQuota");
        }

        /// <summary>
        /// 查询黑石EIP 限额
        /// </summary>
        /// <param name="req"><see cref="DescribeEipQuotaRequest"/></param>
        /// <returns><see cref="DescribeEipQuotaResponse"/></returns>
        public DescribeEipQuotaResponse DescribeEipQuotaSync(DescribeEipQuotaRequest req)
        {
            return InternalRequestAsync<DescribeEipQuotaResponse>(req, "DescribeEipQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 黑石EIP查询任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEipTaskRequest"/></param>
        /// <returns><see cref="DescribeEipTaskResponse"/></returns>
        public Task<DescribeEipTaskResponse> DescribeEipTask(DescribeEipTaskRequest req)
        {
            return InternalRequestAsync<DescribeEipTaskResponse>(req, "DescribeEipTask");
        }

        /// <summary>
        /// 黑石EIP查询任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEipTaskRequest"/></param>
        /// <returns><see cref="DescribeEipTaskResponse"/></returns>
        public DescribeEipTaskResponse DescribeEipTaskSync(DescribeEipTaskRequest req)
        {
            return InternalRequestAsync<DescribeEipTaskResponse>(req, "DescribeEipTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 黑石EIP查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeEipsRequest"/></param>
        /// <returns><see cref="DescribeEipsResponse"/></returns>
        public Task<DescribeEipsResponse> DescribeEips(DescribeEipsRequest req)
        {
            return InternalRequestAsync<DescribeEipsResponse>(req, "DescribeEips");
        }

        /// <summary>
        /// 黑石EIP查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeEipsRequest"/></param>
        /// <returns><see cref="DescribeEipsResponse"/></returns>
        public DescribeEipsResponse DescribeEipsSync(DescribeEipsRequest req)
        {
            return InternalRequestAsync<DescribeEipsResponse>(req, "DescribeEips")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改弹性公网IP ACL
        /// </summary>
        /// <param name="req"><see cref="ModifyEipAclRequest"/></param>
        /// <returns><see cref="ModifyEipAclResponse"/></returns>
        public Task<ModifyEipAclResponse> ModifyEipAcl(ModifyEipAclRequest req)
        {
            return InternalRequestAsync<ModifyEipAclResponse>(req, "ModifyEipAcl");
        }

        /// <summary>
        /// 修改弹性公网IP ACL
        /// </summary>
        /// <param name="req"><see cref="ModifyEipAclRequest"/></param>
        /// <returns><see cref="ModifyEipAclResponse"/></returns>
        public ModifyEipAclResponse ModifyEipAclSync(ModifyEipAclRequest req)
        {
            return InternalRequestAsync<ModifyEipAclResponse>(req, "ModifyEipAcl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 黑石EIP修改计费方式
        /// </summary>
        /// <param name="req"><see cref="ModifyEipChargeRequest"/></param>
        /// <returns><see cref="ModifyEipChargeResponse"/></returns>
        public Task<ModifyEipChargeResponse> ModifyEipCharge(ModifyEipChargeRequest req)
        {
            return InternalRequestAsync<ModifyEipChargeResponse>(req, "ModifyEipCharge");
        }

        /// <summary>
        /// 黑石EIP修改计费方式
        /// </summary>
        /// <param name="req"><see cref="ModifyEipChargeRequest"/></param>
        /// <returns><see cref="ModifyEipChargeResponse"/></returns>
        public ModifyEipChargeResponse ModifyEipChargeSync(ModifyEipChargeRequest req)
        {
            return InternalRequestAsync<ModifyEipChargeResponse>(req, "ModifyEipCharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新黑石EIP名称
        /// </summary>
        /// <param name="req"><see cref="ModifyEipNameRequest"/></param>
        /// <returns><see cref="ModifyEipNameResponse"/></returns>
        public Task<ModifyEipNameResponse> ModifyEipName(ModifyEipNameRequest req)
        {
            return InternalRequestAsync<ModifyEipNameResponse>(req, "ModifyEipName");
        }

        /// <summary>
        /// 更新黑石EIP名称
        /// </summary>
        /// <param name="req"><see cref="ModifyEipNameRequest"/></param>
        /// <returns><see cref="ModifyEipNameResponse"/></returns>
        public ModifyEipNameResponse ModifyEipNameSync(ModifyEipNameRequest req)
        {
            return InternalRequestAsync<ModifyEipNameResponse>(req, "ModifyEipName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑弹性公网IP ACL
        /// </summary>
        /// <param name="req"><see cref="UnbindEipAclsRequest"/></param>
        /// <returns><see cref="UnbindEipAclsResponse"/></returns>
        public Task<UnbindEipAclsResponse> UnbindEipAcls(UnbindEipAclsRequest req)
        {
            return InternalRequestAsync<UnbindEipAclsResponse>(req, "UnbindEipAcls");
        }

        /// <summary>
        /// 解绑弹性公网IP ACL
        /// </summary>
        /// <param name="req"><see cref="UnbindEipAclsRequest"/></param>
        /// <returns><see cref="UnbindEipAclsResponse"/></returns>
        public UnbindEipAclsResponse UnbindEipAclsSync(UnbindEipAclsRequest req)
        {
            return InternalRequestAsync<UnbindEipAclsResponse>(req, "UnbindEipAcls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// UnbindHosted接口用于解绑托管机器上的EIP
        /// </summary>
        /// <param name="req"><see cref="UnbindHostedRequest"/></param>
        /// <returns><see cref="UnbindHostedResponse"/></returns>
        public Task<UnbindHostedResponse> UnbindHosted(UnbindHostedRequest req)
        {
            return InternalRequestAsync<UnbindHostedResponse>(req, "UnbindHosted");
        }

        /// <summary>
        /// UnbindHosted接口用于解绑托管机器上的EIP
        /// </summary>
        /// <param name="req"><see cref="UnbindHostedRequest"/></param>
        /// <returns><see cref="UnbindHostedResponse"/></returns>
        public UnbindHostedResponse UnbindHostedSync(UnbindHostedRequest req)
        {
            return InternalRequestAsync<UnbindHostedResponse>(req, "UnbindHosted")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑黑石EIP
        /// </summary>
        /// <param name="req"><see cref="UnbindRsRequest"/></param>
        /// <returns><see cref="UnbindRsResponse"/></returns>
        public Task<UnbindRsResponse> UnbindRs(UnbindRsRequest req)
        {
            return InternalRequestAsync<UnbindRsResponse>(req, "UnbindRs");
        }

        /// <summary>
        /// 解绑黑石EIP
        /// </summary>
        /// <param name="req"><see cref="UnbindRsRequest"/></param>
        /// <returns><see cref="UnbindRsResponse"/></returns>
        public UnbindRsResponse UnbindRsSync(UnbindRsRequest req)
        {
            return InternalRequestAsync<UnbindRsResponse>(req, "UnbindRs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量解绑物理机弹性公网IP接口
        /// </summary>
        /// <param name="req"><see cref="UnbindRsListRequest"/></param>
        /// <returns><see cref="UnbindRsListResponse"/></returns>
        public Task<UnbindRsListResponse> UnbindRsList(UnbindRsListRequest req)
        {
            return InternalRequestAsync<UnbindRsListResponse>(req, "UnbindRsList");
        }

        /// <summary>
        /// 批量解绑物理机弹性公网IP接口
        /// </summary>
        /// <param name="req"><see cref="UnbindRsListRequest"/></param>
        /// <returns><see cref="UnbindRsListResponse"/></returns>
        public UnbindRsListResponse UnbindRsListSync(UnbindRsListRequest req)
        {
            return InternalRequestAsync<UnbindRsListResponse>(req, "UnbindRsList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 黑石EIP解绑VPCIP
        /// </summary>
        /// <param name="req"><see cref="UnbindVpcIpRequest"/></param>
        /// <returns><see cref="UnbindVpcIpResponse"/></returns>
        public Task<UnbindVpcIpResponse> UnbindVpcIp(UnbindVpcIpRequest req)
        {
            return InternalRequestAsync<UnbindVpcIpResponse>(req, "UnbindVpcIp");
        }

        /// <summary>
        /// 黑石EIP解绑VPCIP
        /// </summary>
        /// <param name="req"><see cref="UnbindVpcIpRequest"/></param>
        /// <returns><see cref="UnbindVpcIpResponse"/></returns>
        public UnbindVpcIpResponse UnbindVpcIpSync(UnbindVpcIpRequest req)
        {
            return InternalRequestAsync<UnbindVpcIpResponse>(req, "UnbindVpcIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
