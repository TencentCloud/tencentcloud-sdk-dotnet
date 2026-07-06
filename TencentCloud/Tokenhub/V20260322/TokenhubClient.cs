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

namespace TencentCloud.Tokenhub.V20260322
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tokenhub.V20260322.Models;

   public class TokenhubClient : AbstractClient{

       private const string endpoint = "tokenhub.tencentcloudapi.com";
       private const string version = "2026-03-22";
       private const string sdkVersion = "SDK_NET_3.0.1458";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TokenhubClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TokenhubClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建术语库。
        /// 
        /// 在当前应用下创建一个新的翻译术语库，用于自定义源语言到目标语言的术语映射。创建成功后返回术语库 ID，可通过该 ID 进一步管理术语条目。
        /// </summary>
        /// <param name="req"><see cref="CreateGlossaryRequest"/></param>
        /// <returns><see cref="CreateGlossaryResponse"/></returns>
        public Task<CreateGlossaryResponse> CreateGlossary(CreateGlossaryRequest req)
        {
            return InternalRequestAsync<CreateGlossaryResponse>(req, "CreateGlossary");
        }

        /// <summary>
        /// 创建术语库。
        /// 
        /// 在当前应用下创建一个新的翻译术语库，用于自定义源语言到目标语言的术语映射。创建成功后返回术语库 ID，可通过该 ID 进一步管理术语条目。
        /// </summary>
        /// <param name="req"><see cref="CreateGlossaryRequest"/></param>
        /// <returns><see cref="CreateGlossaryResponse"/></returns>
        public CreateGlossaryResponse CreateGlossarySync(CreateGlossaryRequest req)
        {
            return InternalRequestAsync<CreateGlossaryResponse>(req, "CreateGlossary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量创建术语条目。
        /// 
        /// 在指定术语库下批量创建术语条目。单次最多创建 100 条。
        /// </summary>
        /// <param name="req"><see cref="CreateGlossaryEntriesRequest"/></param>
        /// <returns><see cref="CreateGlossaryEntriesResponse"/></returns>
        public Task<CreateGlossaryEntriesResponse> CreateGlossaryEntries(CreateGlossaryEntriesRequest req)
        {
            return InternalRequestAsync<CreateGlossaryEntriesResponse>(req, "CreateGlossaryEntries");
        }

        /// <summary>
        /// 批量创建术语条目。
        /// 
        /// 在指定术语库下批量创建术语条目。单次最多创建 100 条。
        /// </summary>
        /// <param name="req"><see cref="CreateGlossaryEntriesRequest"/></param>
        /// <returns><see cref="CreateGlossaryEntriesResponse"/></returns>
        public CreateGlossaryEntriesResponse CreateGlossaryEntriesSync(CreateGlossaryEntriesRequest req)
        {
            return InternalRequestAsync<CreateGlossaryEntriesResponse>(req, "CreateGlossaryEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量创建 TokenPlan APIKey。
        /// 
        /// 传入名称前缀和数量，自动按 {ApiKeyName}-{序号} 格式生成名称（如 aaa-1, aaa-2）。允许同名。支持部分成功，最多 100 条。
        /// </summary>
        /// <param name="req"><see cref="CreateTokenPlanApiKeysRequest"/></param>
        /// <returns><see cref="CreateTokenPlanApiKeysResponse"/></returns>
        public Task<CreateTokenPlanApiKeysResponse> CreateTokenPlanApiKeys(CreateTokenPlanApiKeysRequest req)
        {
            return InternalRequestAsync<CreateTokenPlanApiKeysResponse>(req, "CreateTokenPlanApiKeys");
        }

        /// <summary>
        /// 批量创建 TokenPlan APIKey。
        /// 
        /// 传入名称前缀和数量，自动按 {ApiKeyName}-{序号} 格式生成名称（如 aaa-1, aaa-2）。允许同名。支持部分成功，最多 100 条。
        /// </summary>
        /// <param name="req"><see cref="CreateTokenPlanApiKeysRequest"/></param>
        /// <returns><see cref="CreateTokenPlanApiKeysResponse"/></returns>
        public CreateTokenPlanApiKeysResponse CreateTokenPlanApiKeysSync(CreateTokenPlanApiKeysRequest req)
        {
            return InternalRequestAsync<CreateTokenPlanApiKeysResponse>(req, "CreateTokenPlanApiKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 购买套餐。
        /// 
        /// 发起 TokenPlan 套餐下单并完成支付，成功后返回大订单 ID 及关联的子订单、资源信息。
        /// </summary>
        /// <param name="req"><see cref="CreateTokenPlanTeamOrderAndBuyRequest"/></param>
        /// <returns><see cref="CreateTokenPlanTeamOrderAndBuyResponse"/></returns>
        public Task<CreateTokenPlanTeamOrderAndBuyResponse> CreateTokenPlanTeamOrderAndBuy(CreateTokenPlanTeamOrderAndBuyRequest req)
        {
            return InternalRequestAsync<CreateTokenPlanTeamOrderAndBuyResponse>(req, "CreateTokenPlanTeamOrderAndBuy");
        }

        /// <summary>
        /// 购买套餐。
        /// 
        /// 发起 TokenPlan 套餐下单并完成支付，成功后返回大订单 ID 及关联的子订单、资源信息。
        /// </summary>
        /// <param name="req"><see cref="CreateTokenPlanTeamOrderAndBuyRequest"/></param>
        /// <returns><see cref="CreateTokenPlanTeamOrderAndBuyResponse"/></returns>
        public CreateTokenPlanTeamOrderAndBuyResponse CreateTokenPlanTeamOrderAndBuySync(CreateTokenPlanTeamOrderAndBuyRequest req)
        {
            return InternalRequestAsync<CreateTokenPlanTeamOrderAndBuyResponse>(req, "CreateTokenPlanTeamOrderAndBuy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除术语库。
        /// 
        /// 删除指定的术语库及其下所有术语条目。删除操作幂等，对不存在的术语库返回成功。调用接口后，若通过 DescribeGlossaries 接口查询不到对应术语库，则表示删除成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteGlossaryRequest"/></param>
        /// <returns><see cref="DeleteGlossaryResponse"/></returns>
        public Task<DeleteGlossaryResponse> DeleteGlossary(DeleteGlossaryRequest req)
        {
            return InternalRequestAsync<DeleteGlossaryResponse>(req, "DeleteGlossary");
        }

        /// <summary>
        /// 删除术语库。
        /// 
        /// 删除指定的术语库及其下所有术语条目。删除操作幂等，对不存在的术语库返回成功。调用接口后，若通过 DescribeGlossaries 接口查询不到对应术语库，则表示删除成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteGlossaryRequest"/></param>
        /// <returns><see cref="DeleteGlossaryResponse"/></returns>
        public DeleteGlossaryResponse DeleteGlossarySync(DeleteGlossaryRequest req)
        {
            return InternalRequestAsync<DeleteGlossaryResponse>(req, "DeleteGlossary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除术语条目。
        /// 
        /// 在指定术语库下批量删除术语条目。单次最多删除 200 条。若术语库不存在或不属于当前应用，返回 ResourceNotFound 错误。
        /// </summary>
        /// <param name="req"><see cref="DeleteGlossaryEntriesRequest"/></param>
        /// <returns><see cref="DeleteGlossaryEntriesResponse"/></returns>
        public Task<DeleteGlossaryEntriesResponse> DeleteGlossaryEntries(DeleteGlossaryEntriesRequest req)
        {
            return InternalRequestAsync<DeleteGlossaryEntriesResponse>(req, "DeleteGlossaryEntries");
        }

        /// <summary>
        /// 批量删除术语条目。
        /// 
        /// 在指定术语库下批量删除术语条目。单次最多删除 200 条。若术语库不存在或不属于当前应用，返回 ResourceNotFound 错误。
        /// </summary>
        /// <param name="req"><see cref="DeleteGlossaryEntriesRequest"/></param>
        /// <returns><see cref="DeleteGlossaryEntriesResponse"/></returns>
        public DeleteGlossaryEntriesResponse DeleteGlossaryEntriesSync(DeleteGlossaryEntriesRequest req)
        {
            return InternalRequestAsync<DeleteGlossaryEntriesResponse>(req, "DeleteGlossaryEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 TokenPlan APIKey。
        /// 
        /// 同时删除额度中心子额度包并通知网关清除缓存。
        /// </summary>
        /// <param name="req"><see cref="DeleteTokenPlanApiKeyRequest"/></param>
        /// <returns><see cref="DeleteTokenPlanApiKeyResponse"/></returns>
        public Task<DeleteTokenPlanApiKeyResponse> DeleteTokenPlanApiKey(DeleteTokenPlanApiKeyRequest req)
        {
            return InternalRequestAsync<DeleteTokenPlanApiKeyResponse>(req, "DeleteTokenPlanApiKey");
        }

        /// <summary>
        /// 删除 TokenPlan APIKey。
        /// 
        /// 同时删除额度中心子额度包并通知网关清除缓存。
        /// </summary>
        /// <param name="req"><see cref="DeleteTokenPlanApiKeyRequest"/></param>
        /// <returns><see cref="DeleteTokenPlanApiKeyResponse"/></returns>
        public DeleteTokenPlanApiKeyResponse DeleteTokenPlanApiKeySync(DeleteTokenPlanApiKeyRequest req)
        {
            return InternalRequestAsync<DeleteTokenPlanApiKeyResponse>(req, "DeleteTokenPlanApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据 API 密钥 ID 或密钥值查询 API 密钥详情，返回明文密钥。ApiKeyId 和 ApiKey 至少需传入其一，优先使用 ApiKeyId。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeyRequest"/></param>
        /// <returns><see cref="DescribeApiKeyResponse"/></returns>
        public Task<DescribeApiKeyResponse> DescribeApiKey(DescribeApiKeyRequest req)
        {
            return InternalRequestAsync<DescribeApiKeyResponse>(req, "DescribeApiKey");
        }

        /// <summary>
        /// 根据 API 密钥 ID 或密钥值查询 API 密钥详情，返回明文密钥。ApiKeyId 和 ApiKey 至少需传入其一，优先使用 ApiKeyId。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeyRequest"/></param>
        /// <returns><see cref="DescribeApiKeyResponse"/></returns>
        public DescribeApiKeyResponse DescribeApiKeySync(DescribeApiKeyRequest req)
        {
            return InternalRequestAsync<DescribeApiKeyResponse>(req, "DescribeApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 API 密钥列表。
        /// 
        /// 查询当前用户的 API 密钥列表，密钥值脱敏展示。支持分页、过滤和排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeyListRequest"/></param>
        /// <returns><see cref="DescribeApiKeyListResponse"/></returns>
        public Task<DescribeApiKeyListResponse> DescribeApiKeyList(DescribeApiKeyListRequest req)
        {
            return InternalRequestAsync<DescribeApiKeyListResponse>(req, "DescribeApiKeyList");
        }

        /// <summary>
        /// 查询 API 密钥列表。
        /// 
        /// 查询当前用户的 API 密钥列表，密钥值脱敏展示。支持分页、过滤和排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeyListRequest"/></param>
        /// <returns><see cref="DescribeApiKeyListResponse"/></returns>
        public DescribeApiKeyListResponse DescribeApiKeyListSync(DescribeApiKeyListRequest req)
        {
            return InternalRequestAsync<DescribeApiKeyListResponse>(req, "DescribeApiKeyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询术语库列表。
        /// 
        /// 查询当前应用下的术语库列表。支持分页、过滤和排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeGlossariesRequest"/></param>
        /// <returns><see cref="DescribeGlossariesResponse"/></returns>
        public Task<DescribeGlossariesResponse> DescribeGlossaries(DescribeGlossariesRequest req)
        {
            return InternalRequestAsync<DescribeGlossariesResponse>(req, "DescribeGlossaries");
        }

        /// <summary>
        /// 查询术语库列表。
        /// 
        /// 查询当前应用下的术语库列表。支持分页、过滤和排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeGlossariesRequest"/></param>
        /// <returns><see cref="DescribeGlossariesResponse"/></returns>
        public DescribeGlossariesResponse DescribeGlossariesSync(DescribeGlossariesRequest req)
        {
            return InternalRequestAsync<DescribeGlossariesResponse>(req, "DescribeGlossaries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询术语条目列表。
        /// 
        /// 查询指定术语库下的术语条目。支持分页。
        /// </summary>
        /// <param name="req"><see cref="DescribeGlossaryEntriesRequest"/></param>
        /// <returns><see cref="DescribeGlossaryEntriesResponse"/></returns>
        public Task<DescribeGlossaryEntriesResponse> DescribeGlossaryEntries(DescribeGlossaryEntriesRequest req)
        {
            return InternalRequestAsync<DescribeGlossaryEntriesResponse>(req, "DescribeGlossaryEntries");
        }

        /// <summary>
        /// 查询术语条目列表。
        /// 
        /// 查询指定术语库下的术语条目。支持分页。
        /// </summary>
        /// <param name="req"><see cref="DescribeGlossaryEntriesRequest"/></param>
        /// <returns><see cref="DescribeGlossaryEntriesResponse"/></returns>
        public DescribeGlossaryEntriesResponse DescribeGlossaryEntriesSync(DescribeGlossaryEntriesRequest req)
        {
            return InternalRequestAsync<DescribeGlossaryEntriesResponse>(req, "DescribeGlossaryEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询模型列表。
        /// 
        /// 支持按模型 ID、模型名称、模型能力等条件筛选，支持分页和排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeModelListRequest"/></param>
        /// <returns><see cref="DescribeModelListResponse"/></returns>
        public Task<DescribeModelListResponse> DescribeModelList(DescribeModelListRequest req)
        {
            return InternalRequestAsync<DescribeModelListResponse>(req, "DescribeModelList");
        }

        /// <summary>
        /// 查询模型列表。
        /// 
        /// 支持按模型 ID、模型名称、模型能力等条件筛选，支持分页和排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeModelListRequest"/></param>
        /// <returns><see cref="DescribeModelListResponse"/></returns>
        public DescribeModelListResponse DescribeModelListSync(DescribeModelListRequest req)
        {
            return InternalRequestAsync<DescribeModelListResponse>(req, "DescribeModelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 TokenPlan 套餐详情。
        /// 
        /// 返回套餐基本信息及额度中心主额度包余量。
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanResponse"/></returns>
        public Task<DescribeTokenPlanResponse> DescribeTokenPlan(DescribeTokenPlanRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanResponse>(req, "DescribeTokenPlan");
        }

        /// <summary>
        /// 查询 TokenPlan 套餐详情。
        /// 
        /// 返回套餐基本信息及额度中心主额度包余量。
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanResponse"/></returns>
        public DescribeTokenPlanResponse DescribeTokenPlanSync(DescribeTokenPlanRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanResponse>(req, "DescribeTokenPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 TokenPlan APIKey 详情。
        /// 
        /// 返回 APIKey 完整信息（含明文密钥）及子额度包余量。
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanApiKeyRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanApiKeyResponse"/></returns>
        public Task<DescribeTokenPlanApiKeyResponse> DescribeTokenPlanApiKey(DescribeTokenPlanApiKeyRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanApiKeyResponse>(req, "DescribeTokenPlanApiKey");
        }

        /// <summary>
        /// 查询 TokenPlan APIKey 详情。
        /// 
        /// 返回 APIKey 完整信息（含明文密钥）及子额度包余量。
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanApiKeyRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanApiKeyResponse"/></returns>
        public DescribeTokenPlanApiKeyResponse DescribeTokenPlanApiKeySync(DescribeTokenPlanApiKeyRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanApiKeyResponse>(req, "DescribeTokenPlanApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 TokenPlan APIKey 列表。
        /// 
        /// 返回指定套餐下的 APIKey 列表，密钥已脱敏。主账号可查看全部，子账号仅可查看自己创建的。
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanApiKeyListRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanApiKeyListResponse"/></returns>
        public Task<DescribeTokenPlanApiKeyListResponse> DescribeTokenPlanApiKeyList(DescribeTokenPlanApiKeyListRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanApiKeyListResponse>(req, "DescribeTokenPlanApiKeyList");
        }

        /// <summary>
        /// 查询 TokenPlan APIKey 列表。
        /// 
        /// 返回指定套餐下的 APIKey 列表，密钥已脱敏。主账号可查看全部，子账号仅可查看自己创建的。
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanApiKeyListRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanApiKeyListResponse"/></returns>
        public DescribeTokenPlanApiKeyListResponse DescribeTokenPlanApiKeyListSync(DescribeTokenPlanApiKeyListRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanApiKeyListResponse>(req, "DescribeTokenPlanApiKeyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 TokenPlan APIKey 密钥（明文）。
        /// 
        /// 返回指定 APIKey 的明文密钥值，请妥善保管。
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanApiKeySecretRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanApiKeySecretResponse"/></returns>
        public Task<DescribeTokenPlanApiKeySecretResponse> DescribeTokenPlanApiKeySecret(DescribeTokenPlanApiKeySecretRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanApiKeySecretResponse>(req, "DescribeTokenPlanApiKeySecret");
        }

        /// <summary>
        /// 查询 TokenPlan APIKey 密钥（明文）。
        /// 
        /// 返回指定 APIKey 的明文密钥值，请妥善保管。
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanApiKeySecretRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanApiKeySecretResponse"/></returns>
        public DescribeTokenPlanApiKeySecretResponse DescribeTokenPlanApiKeySecretSync(DescribeTokenPlanApiKeySecretRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanApiKeySecretResponse>(req, "DescribeTokenPlanApiKeySecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 TokenPlan APIKey 调用明细。
        /// 
        /// 从 CLS 日志服务查询套餐下的调用明细，按 pkg_id 过滤，支持游标分页。
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanApiKeyUsageDetailRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanApiKeyUsageDetailResponse"/></returns>
        public Task<DescribeTokenPlanApiKeyUsageDetailResponse> DescribeTokenPlanApiKeyUsageDetail(DescribeTokenPlanApiKeyUsageDetailRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanApiKeyUsageDetailResponse>(req, "DescribeTokenPlanApiKeyUsageDetail");
        }

        /// <summary>
        /// 查询 TokenPlan APIKey 调用明细。
        /// 
        /// 从 CLS 日志服务查询套餐下的调用明细，按 pkg_id 过滤，支持游标分页。
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanApiKeyUsageDetailRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanApiKeyUsageDetailResponse"/></returns>
        public DescribeTokenPlanApiKeyUsageDetailResponse DescribeTokenPlanApiKeyUsageDetailSync(DescribeTokenPlanApiKeyUsageDetailRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanApiKeyUsageDetailResponse>(req, "DescribeTokenPlanApiKeyUsageDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 TokenPlan 套餐列表。
        /// 
        /// 支持分页、过滤和排序。主账号可查看全部，子账号仅可查看自己创建的。返回结果包含每个套餐关联的额度中心主额度包详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanListRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanListResponse"/></returns>
        public Task<DescribeTokenPlanListResponse> DescribeTokenPlanList(DescribeTokenPlanListRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanListResponse>(req, "DescribeTokenPlanList");
        }

        /// <summary>
        /// 查询 TokenPlan 套餐列表。
        /// 
        /// 支持分页、过滤和排序。主账号可查看全部，子账号仅可查看自己创建的。返回结果包含每个套餐关联的额度中心主额度包详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenPlanListRequest"/></param>
        /// <returns><see cref="DescribeTokenPlanListResponse"/></returns>
        public DescribeTokenPlanListResponse DescribeTokenPlanListSync(DescribeTokenPlanListRequest req)
        {
            return InternalRequestAsync<DescribeTokenPlanListResponse>(req, "DescribeTokenPlanList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用量排行列表。
        /// 
        /// 指标族（MetricType）
        /// - `tokens`（默认）：Token 用量统计。支持 Dimension = apikey / endpoint / model。
        ///   返回指标：TotalToken（总）/ InputTotalToken（输入）/ OutputTotalToken（输出）/ CacheTotalToken（读缓存）。
        /// - `search`：【待上线】联网搜索用量统计。支持 Dimension = apikey / endpoint / model。
        ///   返回指标：SearchRequestCount（搜索请求数）/ SearchCount（搜索引擎调用次数）。
        /// 
        /// 响应内容
        /// - MetricType 字段用于切换指标族，响应回显 MetricType 与 MetricKeys。
        /// - TotalStats：时间窗内全部对象的整段聚合值。
        /// - PageStats：当前翻页内对象的整段聚合值。
        /// - TopList：按MetricKeys[0]降序的对象列表，含整段聚合值与逐时间点曲线。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageRankListRequest"/></param>
        /// <returns><see cref="DescribeUsageRankListResponse"/></returns>
        public Task<DescribeUsageRankListResponse> DescribeUsageRankList(DescribeUsageRankListRequest req)
        {
            return InternalRequestAsync<DescribeUsageRankListResponse>(req, "DescribeUsageRankList");
        }

        /// <summary>
        /// 查询用量排行列表。
        /// 
        /// 指标族（MetricType）
        /// - `tokens`（默认）：Token 用量统计。支持 Dimension = apikey / endpoint / model。
        ///   返回指标：TotalToken（总）/ InputTotalToken（输入）/ OutputTotalToken（输出）/ CacheTotalToken（读缓存）。
        /// - `search`：【待上线】联网搜索用量统计。支持 Dimension = apikey / endpoint / model。
        ///   返回指标：SearchRequestCount（搜索请求数）/ SearchCount（搜索引擎调用次数）。
        /// 
        /// 响应内容
        /// - MetricType 字段用于切换指标族，响应回显 MetricType 与 MetricKeys。
        /// - TotalStats：时间窗内全部对象的整段聚合值。
        /// - PageStats：当前翻页内对象的整段聚合值。
        /// - TopList：按MetricKeys[0]降序的对象列表，含整段聚合值与逐时间点曲线。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageRankListRequest"/></param>
        /// <returns><see cref="DescribeUsageRankListResponse"/></returns>
        public DescribeUsageRankListResponse DescribeUsageRankListSync(DescribeUsageRankListRequest req)
        {
            return InternalRequestAsync<DescribeUsageRankListResponse>(req, "DescribeUsageRankList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改术语条目。
        /// 
        /// 在指定术语库下批量修改术语条目。单次最多修改 200 条。
        /// </summary>
        /// <param name="req"><see cref="ModifyGlossaryEntriesRequest"/></param>
        /// <returns><see cref="ModifyGlossaryEntriesResponse"/></returns>
        public Task<ModifyGlossaryEntriesResponse> ModifyGlossaryEntries(ModifyGlossaryEntriesRequest req)
        {
            return InternalRequestAsync<ModifyGlossaryEntriesResponse>(req, "ModifyGlossaryEntries");
        }

        /// <summary>
        /// 批量修改术语条目。
        /// 
        /// 在指定术语库下批量修改术语条目。单次最多修改 200 条。
        /// </summary>
        /// <param name="req"><see cref="ModifyGlossaryEntriesRequest"/></param>
        /// <returns><see cref="ModifyGlossaryEntriesResponse"/></returns>
        public ModifyGlossaryEntriesResponse ModifyGlossaryEntriesSync(ModifyGlossaryEntriesRequest req)
        {
            return InternalRequestAsync<ModifyGlossaryEntriesResponse>(req, "ModifyGlossaryEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 TokenPlan APIKey 配置（网关关注字段）。
        /// 
        /// 修改后自动通知网关更新缓存并同步额度中心。
        /// </summary>
        /// <param name="req"><see cref="ModifyTokenPlanApiKeyRequest"/></param>
        /// <returns><see cref="ModifyTokenPlanApiKeyResponse"/></returns>
        public Task<ModifyTokenPlanApiKeyResponse> ModifyTokenPlanApiKey(ModifyTokenPlanApiKeyRequest req)
        {
            return InternalRequestAsync<ModifyTokenPlanApiKeyResponse>(req, "ModifyTokenPlanApiKey");
        }

        /// <summary>
        /// 修改 TokenPlan APIKey 配置（网关关注字段）。
        /// 
        /// 修改后自动通知网关更新缓存并同步额度中心。
        /// </summary>
        /// <param name="req"><see cref="ModifyTokenPlanApiKeyRequest"/></param>
        /// <returns><see cref="ModifyTokenPlanApiKeyResponse"/></returns>
        public ModifyTokenPlanApiKeyResponse ModifyTokenPlanApiKeySync(ModifyTokenPlanApiKeyRequest req)
        {
            return InternalRequestAsync<ModifyTokenPlanApiKeyResponse>(req, "ModifyTokenPlanApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置 TokenPlan APIKey 密钥。
        /// 
        /// 重新生成密钥值，密钥版本号递增，旧密钥立即失效。APIKey ID 不变。重置后需通过 DescribeTokenPlanApiKeySecret 查询新密钥。
        /// </summary>
        /// <param name="req"><see cref="ModifyTokenPlanApiKeySecretRequest"/></param>
        /// <returns><see cref="ModifyTokenPlanApiKeySecretResponse"/></returns>
        public Task<ModifyTokenPlanApiKeySecretResponse> ModifyTokenPlanApiKeySecret(ModifyTokenPlanApiKeySecretRequest req)
        {
            return InternalRequestAsync<ModifyTokenPlanApiKeySecretResponse>(req, "ModifyTokenPlanApiKeySecret");
        }

        /// <summary>
        /// 重置 TokenPlan APIKey 密钥。
        /// 
        /// 重新生成密钥值，密钥版本号递增，旧密钥立即失效。APIKey ID 不变。重置后需通过 DescribeTokenPlanApiKeySecret 查询新密钥。
        /// </summary>
        /// <param name="req"><see cref="ModifyTokenPlanApiKeySecretRequest"/></param>
        /// <returns><see cref="ModifyTokenPlanApiKeySecretResponse"/></returns>
        public ModifyTokenPlanApiKeySecretResponse ModifyTokenPlanApiKeySecretSync(ModifyTokenPlanApiKeySecretRequest req)
        {
            return InternalRequestAsync<ModifyTokenPlanApiKeySecretResponse>(req, "ModifyTokenPlanApiKeySecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 续费套餐。
        /// 
        /// 对已有的 TokenPlan 套餐发起续费下单并完成支付，成功后返回大订单 ID 及关联的子订单、资源信息。
        /// </summary>
        /// <param name="req"><see cref="RenewTokenPlanTeamOrderRequest"/></param>
        /// <returns><see cref="RenewTokenPlanTeamOrderResponse"/></returns>
        public Task<RenewTokenPlanTeamOrderResponse> RenewTokenPlanTeamOrder(RenewTokenPlanTeamOrderRequest req)
        {
            return InternalRequestAsync<RenewTokenPlanTeamOrderResponse>(req, "RenewTokenPlanTeamOrder");
        }

        /// <summary>
        /// 续费套餐。
        /// 
        /// 对已有的 TokenPlan 套餐发起续费下单并完成支付，成功后返回大订单 ID 及关联的子订单、资源信息。
        /// </summary>
        /// <param name="req"><see cref="RenewTokenPlanTeamOrderRequest"/></param>
        /// <returns><see cref="RenewTokenPlanTeamOrderResponse"/></returns>
        public RenewTokenPlanTeamOrderResponse RenewTokenPlanTeamOrderSync(RenewTokenPlanTeamOrderRequest req)
        {
            return InternalRequestAsync<RenewTokenPlanTeamOrderResponse>(req, "RenewTokenPlanTeamOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 升配套餐。
        /// 
        /// 对已有的 TokenPlan 套餐发起升配下单并完成支付，扩容积分或 Token 额度，成功后返回大订单 ID 及关联的子订单、资源信息。新额度必须大于当前额度。
        /// </summary>
        /// <param name="req"><see cref="UpgradeTokenPlanTeamOrderRequest"/></param>
        /// <returns><see cref="UpgradeTokenPlanTeamOrderResponse"/></returns>
        public Task<UpgradeTokenPlanTeamOrderResponse> UpgradeTokenPlanTeamOrder(UpgradeTokenPlanTeamOrderRequest req)
        {
            return InternalRequestAsync<UpgradeTokenPlanTeamOrderResponse>(req, "UpgradeTokenPlanTeamOrder");
        }

        /// <summary>
        /// 升配套餐。
        /// 
        /// 对已有的 TokenPlan 套餐发起升配下单并完成支付，扩容积分或 Token 额度，成功后返回大订单 ID 及关联的子订单、资源信息。新额度必须大于当前额度。
        /// </summary>
        /// <param name="req"><see cref="UpgradeTokenPlanTeamOrderRequest"/></param>
        /// <returns><see cref="UpgradeTokenPlanTeamOrderResponse"/></returns>
        public UpgradeTokenPlanTeamOrderResponse UpgradeTokenPlanTeamOrderSync(UpgradeTokenPlanTeamOrderRequest req)
        {
            return InternalRequestAsync<UpgradeTokenPlanTeamOrderResponse>(req, "UpgradeTokenPlanTeamOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
