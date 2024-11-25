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

namespace TencentCloud.Rce.V20201103
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Rce.V20201103.Models;

   public class RceClient : AbstractClient{

       private const string endpoint = "rce.tencentcloudapi.com";
       private const string version = "2020-11-03";
       private const string sdkVersion = "SDK_NET_3.0.1129";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RceClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RceClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建黑白名单，黑白名单数量上限为100
        /// </summary>
        /// <param name="req"><see cref="CreateNameListRequest"/></param>
        /// <returns><see cref="CreateNameListResponse"/></returns>
        public Task<CreateNameListResponse> CreateNameList(CreateNameListRequest req)
        {
            return InternalRequestAsync<CreateNameListResponse>(req, "CreateNameList");
        }

        /// <summary>
        /// 创建黑白名单，黑白名单数量上限为100
        /// </summary>
        /// <param name="req"><see cref="CreateNameListRequest"/></param>
        /// <returns><see cref="CreateNameListResponse"/></returns>
        public CreateNameListResponse CreateNameListSync(CreateNameListRequest req)
        {
            return InternalRequestAsync<CreateNameListResponse>(req, "CreateNameList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改黑白名单状态 关闭 开启 删除
        /// </summary>
        /// <param name="req"><see cref="DeleteNameListRequest"/></param>
        /// <returns><see cref="DeleteNameListResponse"/></returns>
        public Task<DeleteNameListResponse> DeleteNameList(DeleteNameListRequest req)
        {
            return InternalRequestAsync<DeleteNameListResponse>(req, "DeleteNameList");
        }

        /// <summary>
        /// 修改黑白名单状态 关闭 开启 删除
        /// </summary>
        /// <param name="req"><see cref="DeleteNameListRequest"/></param>
        /// <returns><see cref="DeleteNameListResponse"/></returns>
        public DeleteNameListResponse DeleteNameListSync(DeleteNameListRequest req)
        {
            return InternalRequestAsync<DeleteNameListResponse>(req, "DeleteNameList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除黑白名单数据
        /// </summary>
        /// <param name="req"><see cref="DeleteNameListDataRequest"/></param>
        /// <returns><see cref="DeleteNameListDataResponse"/></returns>
        public Task<DeleteNameListDataResponse> DeleteNameListData(DeleteNameListDataRequest req)
        {
            return InternalRequestAsync<DeleteNameListDataResponse>(req, "DeleteNameListData");
        }

        /// <summary>
        /// 删除黑白名单数据
        /// </summary>
        /// <param name="req"><see cref="DeleteNameListDataRequest"/></param>
        /// <returns><see cref="DeleteNameListDataResponse"/></returns>
        public DeleteNameListDataResponse DeleteNameListDataSync(DeleteNameListDataRequest req)
        {
            return InternalRequestAsync<DeleteNameListDataResponse>(req, "DeleteNameListData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列表展示黑白名单列表数据, 包含列表名称, 名单类型, 数据类型, 数据来源, 描述, 状态等
        /// </summary>
        /// <param name="req"><see cref="DescribeNameListRequest"/></param>
        /// <returns><see cref="DescribeNameListResponse"/></returns>
        public Task<DescribeNameListResponse> DescribeNameList(DescribeNameListRequest req)
        {
            return InternalRequestAsync<DescribeNameListResponse>(req, "DescribeNameList");
        }

        /// <summary>
        /// 列表展示黑白名单列表数据, 包含列表名称, 名单类型, 数据类型, 数据来源, 描述, 状态等
        /// </summary>
        /// <param name="req"><see cref="DescribeNameListRequest"/></param>
        /// <returns><see cref="DescribeNameListResponse"/></returns>
        public DescribeNameListResponse DescribeNameListSync(DescribeNameListRequest req)
        {
            return InternalRequestAsync<DescribeNameListResponse>(req, "DescribeNameList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 黑白名单详情数据展示 名单id 客户appid uin 数据内容 开始时间和结束时间 状态 描述
        /// </summary>
        /// <param name="req"><see cref="DescribeNameListDataListRequest"/></param>
        /// <returns><see cref="DescribeNameListDataListResponse"/></returns>
        public Task<DescribeNameListDataListResponse> DescribeNameListDataList(DescribeNameListDataListRequest req)
        {
            return InternalRequestAsync<DescribeNameListDataListResponse>(req, "DescribeNameListDataList");
        }

        /// <summary>
        /// 黑白名单详情数据展示 名单id 客户appid uin 数据内容 开始时间和结束时间 状态 描述
        /// </summary>
        /// <param name="req"><see cref="DescribeNameListDataListRequest"/></param>
        /// <returns><see cref="DescribeNameListDataListResponse"/></returns>
        public DescribeNameListDataListResponse DescribeNameListDataListSync(DescribeNameListDataListRequest req)
        {
            return InternalRequestAsync<DescribeNameListDataListResponse>(req, "DescribeNameListDataList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询黑白名单列表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNameListDetailRequest"/></param>
        /// <returns><see cref="DescribeNameListDetailResponse"/></returns>
        public Task<DescribeNameListDetailResponse> DescribeNameListDetail(DescribeNameListDetailRequest req)
        {
            return InternalRequestAsync<DescribeNameListDetailResponse>(req, "DescribeNameListDetail");
        }

        /// <summary>
        /// 查询黑白名单列表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNameListDetailRequest"/></param>
        /// <returns><see cref="DescribeNameListDetailResponse"/></returns>
        public DescribeNameListDetailResponse DescribeNameListDetailSync(DescribeNameListDetailRequest req)
        {
            return InternalRequestAsync<DescribeNameListDetailResponse>(req, "DescribeNameListDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// RCE控制台预付费和后付费次数展示
        /// </summary>
        /// <param name="req"><see cref="DescribeUserUsageCntRequest"/></param>
        /// <returns><see cref="DescribeUserUsageCntResponse"/></returns>
        public Task<DescribeUserUsageCntResponse> DescribeUserUsageCnt(DescribeUserUsageCntRequest req)
        {
            return InternalRequestAsync<DescribeUserUsageCntResponse>(req, "DescribeUserUsageCnt");
        }

        /// <summary>
        /// RCE控制台预付费和后付费次数展示
        /// </summary>
        /// <param name="req"><see cref="DescribeUserUsageCntRequest"/></param>
        /// <returns><see cref="DescribeUserUsageCntResponse"/></returns>
        public DescribeUserUsageCntResponse DescribeUserUsageCntSync(DescribeUserUsageCntRequest req)
        {
            return InternalRequestAsync<DescribeUserUsageCntResponse>(req, "DescribeUserUsageCnt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增黑白名单数据，所有黑白名单数据总量上限为10000
        /// </summary>
        /// <param name="req"><see cref="ImportNameListDataRequest"/></param>
        /// <returns><see cref="ImportNameListDataResponse"/></returns>
        public Task<ImportNameListDataResponse> ImportNameListData(ImportNameListDataRequest req)
        {
            return InternalRequestAsync<ImportNameListDataResponse>(req, "ImportNameListData");
        }

        /// <summary>
        /// 新增黑白名单数据，所有黑白名单数据总量上限为10000
        /// </summary>
        /// <param name="req"><see cref="ImportNameListDataRequest"/></param>
        /// <returns><see cref="ImportNameListDataResponse"/></returns>
        public ImportNameListDataResponse ImportNameListDataSync(ImportNameListDataRequest req)
        {
            return InternalRequestAsync<ImportNameListDataResponse>(req, "ImportNameListData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 全栈式风控引擎（RiskControlEngine，RCE）是基于人工智能技术和腾讯20年风控实战沉淀，依托腾讯海量业务构建的风控引擎，以轻量级的 SaaS 服务方式接入，帮助您快速解决注册、登录、营销活动等关键场景遇到的欺诈问题，实时防御黑灰产作恶。
        /// </summary>
        /// <param name="req"><see cref="ManageMarketingRiskRequest"/></param>
        /// <returns><see cref="ManageMarketingRiskResponse"/></returns>
        public Task<ManageMarketingRiskResponse> ManageMarketingRisk(ManageMarketingRiskRequest req)
        {
            return InternalRequestAsync<ManageMarketingRiskResponse>(req, "ManageMarketingRisk");
        }

        /// <summary>
        /// 全栈式风控引擎（RiskControlEngine，RCE）是基于人工智能技术和腾讯20年风控实战沉淀，依托腾讯海量业务构建的风控引擎，以轻量级的 SaaS 服务方式接入，帮助您快速解决注册、登录、营销活动等关键场景遇到的欺诈问题，实时防御黑灰产作恶。
        /// </summary>
        /// <param name="req"><see cref="ManageMarketingRiskRequest"/></param>
        /// <returns><see cref="ManageMarketingRiskResponse"/></returns>
        public ManageMarketingRiskResponse ManageMarketingRiskSync(ManageMarketingRiskRequest req)
        {
            return InternalRequestAsync<ManageMarketingRiskResponse>(req, "ManageMarketingRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改列表数据 列表名称 列表类型 数据类型 状态 备注
        /// </summary>
        /// <param name="req"><see cref="ModifyNameListRequest"/></param>
        /// <returns><see cref="ModifyNameListResponse"/></returns>
        public Task<ModifyNameListResponse> ModifyNameList(ModifyNameListRequest req)
        {
            return InternalRequestAsync<ModifyNameListResponse>(req, "ModifyNameList");
        }

        /// <summary>
        /// 修改列表数据 列表名称 列表类型 数据类型 状态 备注
        /// </summary>
        /// <param name="req"><see cref="ModifyNameListRequest"/></param>
        /// <returns><see cref="ModifyNameListResponse"/></returns>
        public ModifyNameListResponse ModifyNameListSync(ModifyNameListRequest req)
        {
            return InternalRequestAsync<ModifyNameListResponse>(req, "ModifyNameList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改黑白名单列表详情 详情内容 开始和结束时间 状态 备注等
        /// </summary>
        /// <param name="req"><see cref="ModifyNameListDataRequest"/></param>
        /// <returns><see cref="ModifyNameListDataResponse"/></returns>
        public Task<ModifyNameListDataResponse> ModifyNameListData(ModifyNameListDataRequest req)
        {
            return InternalRequestAsync<ModifyNameListDataResponse>(req, "ModifyNameListData");
        }

        /// <summary>
        /// 修改黑白名单列表详情 详情内容 开始和结束时间 状态 备注等
        /// </summary>
        /// <param name="req"><see cref="ModifyNameListDataRequest"/></param>
        /// <returns><see cref="ModifyNameListDataResponse"/></returns>
        public ModifyNameListDataResponse ModifyNameListDataSync(ModifyNameListDataRequest req)
        {
            return InternalRequestAsync<ModifyNameListDataResponse>(req, "ModifyNameListData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
