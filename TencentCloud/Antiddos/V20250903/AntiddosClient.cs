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

namespace TencentCloud.Antiddos.V20250903
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Antiddos.V20250903.Models;

   public class AntiddosClient : AbstractClient{

       private const string endpoint = "antiddos.tencentcloudapi.com";
       private const string version = "2025-09-03";
       private const string sdkVersion = "SDK_NET_3.0.1545";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AntiddosClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AntiddosClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// <p>创建 DDoS 高防服务防护实例。</p>
        /// <p>防护实例是高防服务下承载防护策略与防护资源的基本单元。创建后，您可以在实例中配置防护策略，并绑定需要防护的云资源。</p>
        /// <p><strong>前提条件：</strong>当前腾讯云主账号已订阅 DDoS 高防套餐，具体操作请参见 <a href="https://cloud.tencent.com/document/product/297/137989">购买指引</a>。</p>
        /// </summary>
        /// <param name="req"><see cref="CreateProtectionRequest"/></param>
        /// <returns><see cref="CreateProtectionResponse"/></returns>
        public Task<CreateProtectionResponse> CreateProtection(CreateProtectionRequest req)
        {
            return InternalRequestAsync<CreateProtectionResponse>(req, "CreateProtection");
        }

        /// <summary>
        /// <p>创建 DDoS 高防服务防护实例。</p>
        /// <p>防护实例是高防服务下承载防护策略与防护资源的基本单元。创建后，您可以在实例中配置防护策略，并绑定需要防护的云资源。</p>
        /// <p><strong>前提条件：</strong>当前腾讯云主账号已订阅 DDoS 高防套餐，具体操作请参见 <a href="https://cloud.tencent.com/document/product/297/137989">购买指引</a>。</p>
        /// </summary>
        /// <param name="req"><see cref="CreateProtectionRequest"/></param>
        /// <returns><see cref="CreateProtectionResponse"/></returns>
        public CreateProtectionResponse CreateProtectionSync(CreateProtectionRequest req)
        {
            return InternalRequestAsync<CreateProtectionResponse>(req, "CreateProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p>删除防护实例。</p>
        /// <p>删除后，该实例及其绑定的防护策略将不再生效。请确保实例中没有正在使用的防护资源，或已提前将防护资源换绑至其他实例。</p>
        /// </summary>
        /// <param name="req"><see cref="DeleteProtectionRequest"/></param>
        /// <returns><see cref="DeleteProtectionResponse"/></returns>
        public Task<DeleteProtectionResponse> DeleteProtection(DeleteProtectionRequest req)
        {
            return InternalRequestAsync<DeleteProtectionResponse>(req, "DeleteProtection");
        }

        /// <summary>
        /// <p>删除防护实例。</p>
        /// <p>删除后，该实例及其绑定的防护策略将不再生效。请确保实例中没有正在使用的防护资源，或已提前将防护资源换绑至其他实例。</p>
        /// </summary>
        /// <param name="req"><see cref="DeleteProtectionRequest"/></param>
        /// <returns><see cref="DeleteProtectionResponse"/></returns>
        public DeleteProtectionResponse DeleteProtectionSync(DeleteProtectionRequest req)
        {
            return InternalRequestAsync<DeleteProtectionResponse>(req, "DeleteProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询封堵解封记录和解封配额信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSBlockRecordsRequest"/></param>
        /// <returns><see cref="DescribeDDoSBlockRecordsResponse"/></returns>
        public Task<DescribeDDoSBlockRecordsResponse> DescribeDDoSBlockRecords(DescribeDDoSBlockRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDDoSBlockRecordsResponse>(req, "DescribeDDoSBlockRecords");
        }

        /// <summary>
        /// 查询封堵解封记录和解封配额信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSBlockRecordsRequest"/></param>
        /// <returns><see cref="DescribeDDoSBlockRecordsResponse"/></returns>
        public DescribeDDoSBlockRecordsResponse DescribeDDoSBlockRecordsSync(DescribeDDoSBlockRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDDoSBlockRecordsResponse>(req, "DescribeDDoSBlockRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p>按防护实例 ID 查询该实例下的 L3/4 DDoS 防护策略详情。</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSProtectionPolicyRequest"/></param>
        /// <returns><see cref="DescribeDDoSProtectionPolicyResponse"/></returns>
        public Task<DescribeDDoSProtectionPolicyResponse> DescribeDDoSProtectionPolicy(DescribeDDoSProtectionPolicyRequest req)
        {
            return InternalRequestAsync<DescribeDDoSProtectionPolicyResponse>(req, "DescribeDDoSProtectionPolicy");
        }

        /// <summary>
        /// <p>按防护实例 ID 查询该实例下的 L3/4 DDoS 防护策略详情。</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSProtectionPolicyRequest"/></param>
        /// <returns><see cref="DescribeDDoSProtectionPolicyResponse"/></returns>
        public DescribeDDoSProtectionPolicyResponse DescribeDDoSProtectionPolicySync(DescribeDDoSProtectionPolicyRequest req)
        {
            return InternalRequestAsync<DescribeDDoSProtectionPolicyResponse>(req, "DescribeDDoSProtectionPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p>按防护实例 ID 查询该实例下绑定的防护资源，支持分页与按资源类型过滤。</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectionResourcesRequest"/></param>
        /// <returns><see cref="DescribeProtectionResourcesResponse"/></returns>
        public Task<DescribeProtectionResourcesResponse> DescribeProtectionResources(DescribeProtectionResourcesRequest req)
        {
            return InternalRequestAsync<DescribeProtectionResourcesResponse>(req, "DescribeProtectionResources");
        }

        /// <summary>
        /// <p>按防护实例 ID 查询该实例下绑定的防护资源，支持分页与按资源类型过滤。</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectionResourcesRequest"/></param>
        /// <returns><see cref="DescribeProtectionResourcesResponse"/></returns>
        public DescribeProtectionResourcesResponse DescribeProtectionResourcesSync(DescribeProtectionResourcesRequest req)
        {
            return InternalRequestAsync<DescribeProtectionResourcesResponse>(req, "DescribeProtectionResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p>按过滤条件查询当前账号下有权限访问的 DDoS 高防服务防护实例，支持分页返回。</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectionsRequest"/></param>
        /// <returns><see cref="DescribeProtectionsResponse"/></returns>
        public Task<DescribeProtectionsResponse> DescribeProtections(DescribeProtectionsRequest req)
        {
            return InternalRequestAsync<DescribeProtectionsResponse>(req, "DescribeProtections");
        }

        /// <summary>
        /// <p>按过滤条件查询当前账号下有权限访问的 DDoS 高防服务防护实例，支持分页返回。</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectionsRequest"/></param>
        /// <returns><see cref="DescribeProtectionsResponse"/></returns>
        public DescribeProtectionsResponse DescribeProtectionsSync(DescribeProtectionsRequest req)
        {
            return InternalRequestAsync<DescribeProtectionsResponse>(req, "DescribeProtections")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p>按资源六段式查询云资源当前绑定的 DDoS 高防服务防护实例。</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceProtectionsRequest"/></param>
        /// <returns><see cref="DescribeResourceProtectionsResponse"/></returns>
        public Task<DescribeResourceProtectionsResponse> DescribeResourceProtections(DescribeResourceProtectionsRequest req)
        {
            return InternalRequestAsync<DescribeResourceProtectionsResponse>(req, "DescribeResourceProtections");
        }

        /// <summary>
        /// <p>按资源六段式查询云资源当前绑定的 DDoS 高防服务防护实例。</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceProtectionsRequest"/></param>
        /// <returns><see cref="DescribeResourceProtectionsResponse"/></returns>
        public DescribeResourceProtectionsResponse DescribeResourceProtectionsSync(DescribeResourceProtectionsRequest req)
        {
            return InternalRequestAsync<DescribeResourceProtectionsResponse>(req, "DescribeResourceProtections")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p>按防护实例 ID 修改该实例下的 L3/4 DDoS 防护策略。</p>
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSProtectionPolicyRequest"/></param>
        /// <returns><see cref="ModifyDDoSProtectionPolicyResponse"/></returns>
        public Task<ModifyDDoSProtectionPolicyResponse> ModifyDDoSProtectionPolicy(ModifyDDoSProtectionPolicyRequest req)
        {
            return InternalRequestAsync<ModifyDDoSProtectionPolicyResponse>(req, "ModifyDDoSProtectionPolicy");
        }

        /// <summary>
        /// <p>按防护实例 ID 修改该实例下的 L3/4 DDoS 防护策略。</p>
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSProtectionPolicyRequest"/></param>
        /// <returns><see cref="ModifyDDoSProtectionPolicyResponse"/></returns>
        public ModifyDDoSProtectionPolicyResponse ModifyDDoSProtectionPolicySync(ModifyDDoSProtectionPolicyRequest req)
        {
            return InternalRequestAsync<ModifyDDoSProtectionPolicyResponse>(req, "ModifyDDoSProtectionPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改防护实例。支持修改防护实例的名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectionRequest"/></param>
        /// <returns><see cref="ModifyProtectionResponse"/></returns>
        public Task<ModifyProtectionResponse> ModifyProtection(ModifyProtectionRequest req)
        {
            return InternalRequestAsync<ModifyProtectionResponse>(req, "ModifyProtection");
        }

        /// <summary>
        /// 修改防护实例。支持修改防护实例的名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectionRequest"/></param>
        /// <returns><see cref="ModifyProtectionResponse"/></returns>
        public ModifyProtectionResponse ModifyProtectionSync(ModifyProtectionRequest req)
        {
            return InternalRequestAsync<ModifyProtectionResponse>(req, "ModifyProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p>修改防护实例的防护资源。</p>
        /// <p>向防护实例中添加、替换或移除防护对象（即绑定到该实例进行防护的云资源）。</p>
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectionResourceRequest"/></param>
        /// <returns><see cref="ModifyProtectionResourceResponse"/></returns>
        public Task<ModifyProtectionResourceResponse> ModifyProtectionResource(ModifyProtectionResourceRequest req)
        {
            return InternalRequestAsync<ModifyProtectionResourceResponse>(req, "ModifyProtectionResource");
        }

        /// <summary>
        /// <p>修改防护实例的防护资源。</p>
        /// <p>向防护实例中添加、替换或移除防护对象（即绑定到该实例进行防护的云资源）。</p>
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectionResourceRequest"/></param>
        /// <returns><see cref="ModifyProtectionResourceResponse"/></returns>
        public ModifyProtectionResourceResponse ModifyProtectionResourceSync(ModifyProtectionResourceRequest req)
        {
            return InternalRequestAsync<ModifyProtectionResourceResponse>(req, "ModifyProtectionResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 申请解封资源，可通过 DescribeDDoSBlockRecords 接口获取资源的封堵解封状态。
        /// </summary>
        /// <param name="req"><see cref="UnblockResourcesRequest"/></param>
        /// <returns><see cref="UnblockResourcesResponse"/></returns>
        public Task<UnblockResourcesResponse> UnblockResources(UnblockResourcesRequest req)
        {
            return InternalRequestAsync<UnblockResourcesResponse>(req, "UnblockResources");
        }

        /// <summary>
        /// 申请解封资源，可通过 DescribeDDoSBlockRecords 接口获取资源的封堵解封状态。
        /// </summary>
        /// <param name="req"><see cref="UnblockResourcesRequest"/></param>
        /// <returns><see cref="UnblockResourcesResponse"/></returns>
        public UnblockResourcesResponse UnblockResourcesSync(UnblockResourcesRequest req)
        {
            return InternalRequestAsync<UnblockResourcesResponse>(req, "UnblockResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
