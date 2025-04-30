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

namespace TencentCloud.Vod.V20240718
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vod.V20240718.Models;

   public class VodClient : AbstractClient{

       private const string endpoint = "vod.tencentcloudapi.com";
       private const string version = "2024-07-18";
       private const string sdkVersion = "SDK_NET_3.0.1232";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VodClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public VodClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建增量迁移策略。
        /// </summary>
        /// <param name="req"><see cref="CreateIncrementalMigrationStrategyRequest"/></param>
        /// <returns><see cref="CreateIncrementalMigrationStrategyResponse"/></returns>
        public Task<CreateIncrementalMigrationStrategyResponse> CreateIncrementalMigrationStrategy(CreateIncrementalMigrationStrategyRequest req)
        {
            return InternalRequestAsync<CreateIncrementalMigrationStrategyResponse>(req, "CreateIncrementalMigrationStrategy");
        }

        /// <summary>
        /// 创建增量迁移策略。
        /// </summary>
        /// <param name="req"><see cref="CreateIncrementalMigrationStrategyRequest"/></param>
        /// <returns><see cref="CreateIncrementalMigrationStrategyResponse"/></returns>
        public CreateIncrementalMigrationStrategyResponse CreateIncrementalMigrationStrategySync(CreateIncrementalMigrationStrategyRequest req)
        {
            return InternalRequestAsync<CreateIncrementalMigrationStrategyResponse>(req, "CreateIncrementalMigrationStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于为专业版应用创建存储桶。
        /// 
        /// 注：
        /// - 本接口仅用于专业版应用；
        /// - 客户创建点播专业版应用时，系统默认为客户开通了部分地域的存储，用户如果需要开通其它地域的存储，可以通过该接口进行开通；
        /// - 通过 [DescribeStorageRegions](https://cloud.tencent.com/document/product/266/72480) 接口可以查询到所有存储地域及已经开通存储桶的地域。
        /// </summary>
        /// <param name="req"><see cref="CreateStorageRequest"/></param>
        /// <returns><see cref="CreateStorageResponse"/></returns>
        public Task<CreateStorageResponse> CreateStorage(CreateStorageRequest req)
        {
            return InternalRequestAsync<CreateStorageResponse>(req, "CreateStorage");
        }

        /// <summary>
        /// 该接口用于为专业版应用创建存储桶。
        /// 
        /// 注：
        /// - 本接口仅用于专业版应用；
        /// - 客户创建点播专业版应用时，系统默认为客户开通了部分地域的存储，用户如果需要开通其它地域的存储，可以通过该接口进行开通；
        /// - 通过 [DescribeStorageRegions](https://cloud.tencent.com/document/product/266/72480) 接口可以查询到所有存储地域及已经开通存储桶的地域。
        /// </summary>
        /// <param name="req"><see cref="CreateStorageRequest"/></param>
        /// <returns><see cref="CreateStorageResponse"/></returns>
        public CreateStorageResponse CreateStorageSync(CreateStorageRequest req)
        {
            return InternalRequestAsync<CreateStorageResponse>(req, "CreateStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于按指定策略，生成专业版应用的临时访问凭证，比如生成用于客户端上传的临时凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateStorageCredentialsRequest"/></param>
        /// <returns><see cref="CreateStorageCredentialsResponse"/></returns>
        public Task<CreateStorageCredentialsResponse> CreateStorageCredentials(CreateStorageCredentialsRequest req)
        {
            return InternalRequestAsync<CreateStorageCredentialsResponse>(req, "CreateStorageCredentials");
        }

        /// <summary>
        /// 用于按指定策略，生成专业版应用的临时访问凭证，比如生成用于客户端上传的临时凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateStorageCredentialsRequest"/></param>
        /// <returns><see cref="CreateStorageCredentialsResponse"/></returns>
        public CreateStorageCredentialsResponse CreateStorageCredentialsSync(CreateStorageCredentialsRequest req)
        {
            return InternalRequestAsync<CreateStorageCredentialsResponse>(req, "CreateStorageCredentials")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除增量迁移策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteIncrementalMigrationStrategyRequest"/></param>
        /// <returns><see cref="DeleteIncrementalMigrationStrategyResponse"/></returns>
        public Task<DeleteIncrementalMigrationStrategyResponse> DeleteIncrementalMigrationStrategy(DeleteIncrementalMigrationStrategyRequest req)
        {
            return InternalRequestAsync<DeleteIncrementalMigrationStrategyResponse>(req, "DeleteIncrementalMigrationStrategy");
        }

        /// <summary>
        /// 删除增量迁移策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteIncrementalMigrationStrategyRequest"/></param>
        /// <returns><see cref="DeleteIncrementalMigrationStrategyResponse"/></returns>
        public DeleteIncrementalMigrationStrategyResponse DeleteIncrementalMigrationStrategySync(DeleteIncrementalMigrationStrategyRequest req)
        {
            return InternalRequestAsync<DeleteIncrementalMigrationStrategyResponse>(req, "DeleteIncrementalMigrationStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询增量迁移策略信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeIncrementalMigrationStrategyInfosRequest"/></param>
        /// <returns><see cref="DescribeIncrementalMigrationStrategyInfosResponse"/></returns>
        public Task<DescribeIncrementalMigrationStrategyInfosResponse> DescribeIncrementalMigrationStrategyInfos(DescribeIncrementalMigrationStrategyInfosRequest req)
        {
            return InternalRequestAsync<DescribeIncrementalMigrationStrategyInfosResponse>(req, "DescribeIncrementalMigrationStrategyInfos");
        }

        /// <summary>
        /// 查询增量迁移策略信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeIncrementalMigrationStrategyInfosRequest"/></param>
        /// <returns><see cref="DescribeIncrementalMigrationStrategyInfosResponse"/></returns>
        public DescribeIncrementalMigrationStrategyInfosResponse DescribeIncrementalMigrationStrategyInfosSync(DescribeIncrementalMigrationStrategyInfosRequest req)
        {
            return InternalRequestAsync<DescribeIncrementalMigrationStrategyInfosResponse>(req, "DescribeIncrementalMigrationStrategyInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询专业版应用中的存储桶信息，同时支持分页查询。
        /// 
        /// 注：
        /// - 本接口仅用于专业版应用。
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageRequest"/></param>
        /// <returns><see cref="DescribeStorageResponse"/></returns>
        public Task<DescribeStorageResponse> DescribeStorage(DescribeStorageRequest req)
        {
            return InternalRequestAsync<DescribeStorageResponse>(req, "DescribeStorage");
        }

        /// <summary>
        /// 该接口用于查询专业版应用中的存储桶信息，同时支持分页查询。
        /// 
        /// 注：
        /// - 本接口仅用于专业版应用。
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageRequest"/></param>
        /// <returns><see cref="DescribeStorageResponse"/></returns>
        public DescribeStorageResponse DescribeStorageSync(DescribeStorageRequest req)
        {
            return InternalRequestAsync<DescribeStorageResponse>(req, "DescribeStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建增量迁移策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyIncrementalMigrationStrategyRequest"/></param>
        /// <returns><see cref="ModifyIncrementalMigrationStrategyResponse"/></returns>
        public Task<ModifyIncrementalMigrationStrategyResponse> ModifyIncrementalMigrationStrategy(ModifyIncrementalMigrationStrategyRequest req)
        {
            return InternalRequestAsync<ModifyIncrementalMigrationStrategyResponse>(req, "ModifyIncrementalMigrationStrategy");
        }

        /// <summary>
        /// 创建增量迁移策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyIncrementalMigrationStrategyRequest"/></param>
        /// <returns><see cref="ModifyIncrementalMigrationStrategyResponse"/></returns>
        public ModifyIncrementalMigrationStrategyResponse ModifyIncrementalMigrationStrategySync(ModifyIncrementalMigrationStrategyRequest req)
        {
            return InternalRequestAsync<ModifyIncrementalMigrationStrategyResponse>(req, "ModifyIncrementalMigrationStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
