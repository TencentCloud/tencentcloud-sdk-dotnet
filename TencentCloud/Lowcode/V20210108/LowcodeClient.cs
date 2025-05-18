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

namespace TencentCloud.Lowcode.V20210108
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Lowcode.V20210108.Models;

   public class LowcodeClient : AbstractClient{

       private const string endpoint = "lowcode.tencentcloudapi.com";
       private const string version = "2021-01-08";
       private const string sdkVersion = "SDK_NET_3.0.1241";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LowcodeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public LowcodeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建知识库
        /// </summary>
        /// <param name="req"><see cref="CreateKnowledgeSetRequest"/></param>
        /// <returns><see cref="CreateKnowledgeSetResponse"/></returns>
        public Task<CreateKnowledgeSetResponse> CreateKnowledgeSet(CreateKnowledgeSetRequest req)
        {
            return InternalRequestAsync<CreateKnowledgeSetResponse>(req, "CreateKnowledgeSet");
        }

        /// <summary>
        /// 创建知识库
        /// </summary>
        /// <param name="req"><see cref="CreateKnowledgeSetRequest"/></param>
        /// <returns><see cref="CreateKnowledgeSetResponse"/></returns>
        public CreateKnowledgeSetResponse CreateKnowledgeSetSync(CreateKnowledgeSetRequest req)
        {
            return InternalRequestAsync<CreateKnowledgeSetResponse>(req, "CreateKnowledgeSet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除知识库下文档
        /// </summary>
        /// <param name="req"><see cref="DeleteKnowledgeDocumentSetRequest"/></param>
        /// <returns><see cref="DeleteKnowledgeDocumentSetResponse"/></returns>
        public Task<DeleteKnowledgeDocumentSetResponse> DeleteKnowledgeDocumentSet(DeleteKnowledgeDocumentSetRequest req)
        {
            return InternalRequestAsync<DeleteKnowledgeDocumentSetResponse>(req, "DeleteKnowledgeDocumentSet");
        }

        /// <summary>
        /// 删除知识库下文档
        /// </summary>
        /// <param name="req"><see cref="DeleteKnowledgeDocumentSetRequest"/></param>
        /// <returns><see cref="DeleteKnowledgeDocumentSetResponse"/></returns>
        public DeleteKnowledgeDocumentSetResponse DeleteKnowledgeDocumentSetSync(DeleteKnowledgeDocumentSetRequest req)
        {
            return InternalRequestAsync<DeleteKnowledgeDocumentSetResponse>(req, "DeleteKnowledgeDocumentSet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除知识库
        /// </summary>
        /// <param name="req"><see cref="DeleteKnowledgeSetRequest"/></param>
        /// <returns><see cref="DeleteKnowledgeSetResponse"/></returns>
        public Task<DeleteKnowledgeSetResponse> DeleteKnowledgeSet(DeleteKnowledgeSetRequest req)
        {
            return InternalRequestAsync<DeleteKnowledgeSetResponse>(req, "DeleteKnowledgeSet");
        }

        /// <summary>
        /// 删除知识库
        /// </summary>
        /// <param name="req"><see cref="DeleteKnowledgeSetRequest"/></param>
        /// <returns><see cref="DeleteKnowledgeSetResponse"/></returns>
        public DeleteKnowledgeSetResponse DeleteKnowledgeSetSync(DeleteKnowledgeSetRequest req)
        {
            return InternalRequestAsync<DeleteKnowledgeSetResponse>(req, "DeleteKnowledgeSet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据源详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceListResponse"/></returns>
        public Task<DescribeDataSourceListResponse> DescribeDataSourceList(DescribeDataSourceListRequest req)
        {
            return InternalRequestAsync<DescribeDataSourceListResponse>(req, "DescribeDataSourceList");
        }

        /// <summary>
        /// 获取数据源详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceListResponse"/></returns>
        public DescribeDataSourceListResponse DescribeDataSourceListSync(DescribeDataSourceListRequest req)
        {
            return InternalRequestAsync<DescribeDataSourceListResponse>(req, "DescribeDataSourceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取知识库下文档详情
        /// </summary>
        /// <param name="req"><see cref="DescribeKnowledgeDocumentSetDetailRequest"/></param>
        /// <returns><see cref="DescribeKnowledgeDocumentSetDetailResponse"/></returns>
        public Task<DescribeKnowledgeDocumentSetDetailResponse> DescribeKnowledgeDocumentSetDetail(DescribeKnowledgeDocumentSetDetailRequest req)
        {
            return InternalRequestAsync<DescribeKnowledgeDocumentSetDetailResponse>(req, "DescribeKnowledgeDocumentSetDetail");
        }

        /// <summary>
        /// 获取知识库下文档详情
        /// </summary>
        /// <param name="req"><see cref="DescribeKnowledgeDocumentSetDetailRequest"/></param>
        /// <returns><see cref="DescribeKnowledgeDocumentSetDetailResponse"/></returns>
        public DescribeKnowledgeDocumentSetDetailResponse DescribeKnowledgeDocumentSetDetailSync(DescribeKnowledgeDocumentSetDetailRequest req)
        {
            return InternalRequestAsync<DescribeKnowledgeDocumentSetDetailResponse>(req, "DescribeKnowledgeDocumentSetDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询知识库下文件集合
        /// </summary>
        /// <param name="req"><see cref="DescribeKnowledgeDocumentSetListRequest"/></param>
        /// <returns><see cref="DescribeKnowledgeDocumentSetListResponse"/></returns>
        public Task<DescribeKnowledgeDocumentSetListResponse> DescribeKnowledgeDocumentSetList(DescribeKnowledgeDocumentSetListRequest req)
        {
            return InternalRequestAsync<DescribeKnowledgeDocumentSetListResponse>(req, "DescribeKnowledgeDocumentSetList");
        }

        /// <summary>
        /// 查询知识库下文件集合
        /// </summary>
        /// <param name="req"><see cref="DescribeKnowledgeDocumentSetListRequest"/></param>
        /// <returns><see cref="DescribeKnowledgeDocumentSetListResponse"/></returns>
        public DescribeKnowledgeDocumentSetListResponse DescribeKnowledgeDocumentSetListSync(DescribeKnowledgeDocumentSetListRequest req)
        {
            return InternalRequestAsync<DescribeKnowledgeDocumentSetListResponse>(req, "DescribeKnowledgeDocumentSetList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询知识库
        /// </summary>
        /// <param name="req"><see cref="DescribeKnowledgeSetListRequest"/></param>
        /// <returns><see cref="DescribeKnowledgeSetListResponse"/></returns>
        public Task<DescribeKnowledgeSetListResponse> DescribeKnowledgeSetList(DescribeKnowledgeSetListRequest req)
        {
            return InternalRequestAsync<DescribeKnowledgeSetListResponse>(req, "DescribeKnowledgeSetList");
        }

        /// <summary>
        /// 查询知识库
        /// </summary>
        /// <param name="req"><see cref="DescribeKnowledgeSetListRequest"/></param>
        /// <returns><see cref="DescribeKnowledgeSetListResponse"/></returns>
        public DescribeKnowledgeSetListResponse DescribeKnowledgeSetListSync(DescribeKnowledgeSetListRequest req)
        {
            return InternalRequestAsync<DescribeKnowledgeSetListResponse>(req, "DescribeKnowledgeSetList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 知识库文档搜索接口
        /// </summary>
        /// <param name="req"><see cref="SearchDocListRequest"/></param>
        /// <returns><see cref="SearchDocListResponse"/></returns>
        public Task<SearchDocListResponse> SearchDocList(SearchDocListRequest req)
        {
            return InternalRequestAsync<SearchDocListResponse>(req, "SearchDocList");
        }

        /// <summary>
        /// 知识库文档搜索接口
        /// </summary>
        /// <param name="req"><see cref="SearchDocListRequest"/></param>
        /// <returns><see cref="SearchDocListResponse"/></returns>
        public SearchDocListResponse SearchDocListSync(SearchDocListRequest req)
        {
            return InternalRequestAsync<SearchDocListResponse>(req, "SearchDocList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新知识库
        /// </summary>
        /// <param name="req"><see cref="UpdateKnowledgeSetRequest"/></param>
        /// <returns><see cref="UpdateKnowledgeSetResponse"/></returns>
        public Task<UpdateKnowledgeSetResponse> UpdateKnowledgeSet(UpdateKnowledgeSetRequest req)
        {
            return InternalRequestAsync<UpdateKnowledgeSetResponse>(req, "UpdateKnowledgeSet");
        }

        /// <summary>
        /// 更新知识库
        /// </summary>
        /// <param name="req"><see cref="UpdateKnowledgeSetRequest"/></param>
        /// <returns><see cref="UpdateKnowledgeSetResponse"/></returns>
        public UpdateKnowledgeSetResponse UpdateKnowledgeSetSync(UpdateKnowledgeSetRequest req)
        {
            return InternalRequestAsync<UpdateKnowledgeSetResponse>(req, "UpdateKnowledgeSet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新知识库
        /// </summary>
        /// <param name="req"><see cref="UploadKnowledgeDocumentSetRequest"/></param>
        /// <returns><see cref="UploadKnowledgeDocumentSetResponse"/></returns>
        public Task<UploadKnowledgeDocumentSetResponse> UploadKnowledgeDocumentSet(UploadKnowledgeDocumentSetRequest req)
        {
            return InternalRequestAsync<UploadKnowledgeDocumentSetResponse>(req, "UploadKnowledgeDocumentSet");
        }

        /// <summary>
        /// 更新知识库
        /// </summary>
        /// <param name="req"><see cref="UploadKnowledgeDocumentSetRequest"/></param>
        /// <returns><see cref="UploadKnowledgeDocumentSetResponse"/></returns>
        public UploadKnowledgeDocumentSetResponse UploadKnowledgeDocumentSetSync(UploadKnowledgeDocumentSetRequest req)
        {
            return InternalRequestAsync<UploadKnowledgeDocumentSetResponse>(req, "UploadKnowledgeDocumentSet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
