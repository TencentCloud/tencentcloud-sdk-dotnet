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

namespace TencentCloud.Bma.V20221115
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bma.V20221115.Models;

   public class BmaClient : AbstractClient{

       private const string endpoint = "bma.tencentcloudapi.com";
       private const string version = "2022-11-15";
       private const string sdkVersion = "SDK_NET_3.0.1004";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BmaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BmaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 添加品牌
        /// </summary>
        /// <param name="req"><see cref="CreateBPBrandRequest"/></param>
        /// <returns><see cref="CreateBPBrandResponse"/></returns>
        public Task<CreateBPBrandResponse> CreateBPBrand(CreateBPBrandRequest req)
        {
            return InternalRequestAsync<CreateBPBrandResponse>(req, "CreateBPBrand");
        }

        /// <summary>
        /// 添加品牌
        /// </summary>
        /// <param name="req"><see cref="CreateBPBrandRequest"/></param>
        /// <returns><see cref="CreateBPBrandResponse"/></returns>
        public CreateBPBrandResponse CreateBPBrandSync(CreateBPBrandRequest req)
        {
            return InternalRequestAsync<CreateBPBrandResponse>(req, "CreateBPBrand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 仿冒应用举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeAPPRequest"/></param>
        /// <returns><see cref="CreateBPFakeAPPResponse"/></returns>
        public Task<CreateBPFakeAPPResponse> CreateBPFakeAPP(CreateBPFakeAPPRequest req)
        {
            return InternalRequestAsync<CreateBPFakeAPPResponse>(req, "CreateBPFakeAPP");
        }

        /// <summary>
        /// 仿冒应用举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeAPPRequest"/></param>
        /// <returns><see cref="CreateBPFakeAPPResponse"/></returns>
        public CreateBPFakeAPPResponse CreateBPFakeAPPSync(CreateBPFakeAPPRequest req)
        {
            return InternalRequestAsync<CreateBPFakeAPPResponse>(req, "CreateBPFakeAPP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量仿冒应用举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeAPPListRequest"/></param>
        /// <returns><see cref="CreateBPFakeAPPListResponse"/></returns>
        public Task<CreateBPFakeAPPListResponse> CreateBPFakeAPPList(CreateBPFakeAPPListRequest req)
        {
            return InternalRequestAsync<CreateBPFakeAPPListResponse>(req, "CreateBPFakeAPPList");
        }

        /// <summary>
        /// 批量仿冒应用举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeAPPListRequest"/></param>
        /// <returns><see cref="CreateBPFakeAPPListResponse"/></returns>
        public CreateBPFakeAPPListResponse CreateBPFakeAPPListSync(CreateBPFakeAPPListRequest req)
        {
            return InternalRequestAsync<CreateBPFakeAPPListResponse>(req, "CreateBPFakeAPPList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 仿冒网址举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeURLRequest"/></param>
        /// <returns><see cref="CreateBPFakeURLResponse"/></returns>
        public Task<CreateBPFakeURLResponse> CreateBPFakeURL(CreateBPFakeURLRequest req)
        {
            return InternalRequestAsync<CreateBPFakeURLResponse>(req, "CreateBPFakeURL");
        }

        /// <summary>
        /// 仿冒网址举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeURLRequest"/></param>
        /// <returns><see cref="CreateBPFakeURLResponse"/></returns>
        public CreateBPFakeURLResponse CreateBPFakeURLSync(CreateBPFakeURLRequest req)
        {
            return InternalRequestAsync<CreateBPFakeURLResponse>(req, "CreateBPFakeURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量仿冒网址举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeURLsRequest"/></param>
        /// <returns><see cref="CreateBPFakeURLsResponse"/></returns>
        public Task<CreateBPFakeURLsResponse> CreateBPFakeURLs(CreateBPFakeURLsRequest req)
        {
            return InternalRequestAsync<CreateBPFakeURLsResponse>(req, "CreateBPFakeURLs");
        }

        /// <summary>
        /// 批量仿冒网址举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeURLsRequest"/></param>
        /// <returns><see cref="CreateBPFakeURLsResponse"/></returns>
        public CreateBPFakeURLsResponse CreateBPFakeURLsSync(CreateBPFakeURLsRequest req)
        {
            return InternalRequestAsync<CreateBPFakeURLsResponse>(req, "CreateBPFakeURLs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加白名单
        /// </summary>
        /// <param name="req"><see cref="CreateBPWhiteListRequest"/></param>
        /// <returns><see cref="CreateBPWhiteListResponse"/></returns>
        public Task<CreateBPWhiteListResponse> CreateBPWhiteList(CreateBPWhiteListRequest req)
        {
            return InternalRequestAsync<CreateBPWhiteListResponse>(req, "CreateBPWhiteList");
        }

        /// <summary>
        /// 添加白名单
        /// </summary>
        /// <param name="req"><see cref="CreateBPWhiteListRequest"/></param>
        /// <returns><see cref="CreateBPWhiteListResponse"/></returns>
        public CreateBPWhiteListResponse CreateBPWhiteListSync(CreateBPWhiteListRequest req)
        {
            return InternalRequestAsync<CreateBPWhiteListResponse>(req, "CreateBPWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteBPWhiteListRequest"/></param>
        /// <returns><see cref="DeleteBPWhiteListResponse"/></returns>
        public Task<DeleteBPWhiteListResponse> DeleteBPWhiteList(DeleteBPWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteBPWhiteListResponse>(req, "DeleteBPWhiteList");
        }

        /// <summary>
        /// 删除白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteBPWhiteListRequest"/></param>
        /// <returns><see cref="DeleteBPWhiteListResponse"/></returns>
        public DeleteBPWhiteListResponse DeleteBPWhiteListSync(DeleteBPWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteBPWhiteListResponse>(req, "DeleteBPWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询品牌列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPBrandsRequest"/></param>
        /// <returns><see cref="DescribeBPBrandsResponse"/></returns>
        public Task<DescribeBPBrandsResponse> DescribeBPBrands(DescribeBPBrandsRequest req)
        {
            return InternalRequestAsync<DescribeBPBrandsResponse>(req, "DescribeBPBrands");
        }

        /// <summary>
        /// 查询品牌列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPBrandsRequest"/></param>
        /// <returns><see cref="DescribeBPBrandsResponse"/></returns>
        public DescribeBPBrandsResponse DescribeBPBrandsSync(DescribeBPBrandsRequest req)
        {
            return InternalRequestAsync<DescribeBPBrandsResponse>(req, "DescribeBPBrands")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询仿冒应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPFakeAPPListRequest"/></param>
        /// <returns><see cref="DescribeBPFakeAPPListResponse"/></returns>
        public Task<DescribeBPFakeAPPListResponse> DescribeBPFakeAPPList(DescribeBPFakeAPPListRequest req)
        {
            return InternalRequestAsync<DescribeBPFakeAPPListResponse>(req, "DescribeBPFakeAPPList");
        }

        /// <summary>
        /// 查询仿冒应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPFakeAPPListRequest"/></param>
        /// <returns><see cref="DescribeBPFakeAPPListResponse"/></returns>
        public DescribeBPFakeAPPListResponse DescribeBPFakeAPPListSync(DescribeBPFakeAPPListRequest req)
        {
            return InternalRequestAsync<DescribeBPFakeAPPListResponse>(req, "DescribeBPFakeAPPList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询仿冒网址列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPFakeURLsRequest"/></param>
        /// <returns><see cref="DescribeBPFakeURLsResponse"/></returns>
        public Task<DescribeBPFakeURLsResponse> DescribeBPFakeURLs(DescribeBPFakeURLsRequest req)
        {
            return InternalRequestAsync<DescribeBPFakeURLsResponse>(req, "DescribeBPFakeURLs");
        }

        /// <summary>
        /// 查询仿冒网址列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPFakeURLsRequest"/></param>
        /// <returns><see cref="DescribeBPFakeURLsResponse"/></returns>
        public DescribeBPFakeURLsResponse DescribeBPFakeURLsSync(DescribeBPFakeURLsRequest req)
        {
            return InternalRequestAsync<DescribeBPFakeURLsResponse>(req, "DescribeBPFakeURLs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPWhiteListsRequest"/></param>
        /// <returns><see cref="DescribeBPWhiteListsResponse"/></returns>
        public Task<DescribeBPWhiteListsResponse> DescribeBPWhiteLists(DescribeBPWhiteListsRequest req)
        {
            return InternalRequestAsync<DescribeBPWhiteListsResponse>(req, "DescribeBPWhiteLists");
        }

        /// <summary>
        /// 查询白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPWhiteListsRequest"/></param>
        /// <returns><see cref="DescribeBPWhiteListsResponse"/></returns>
        public DescribeBPWhiteListsResponse DescribeBPWhiteListsSync(DescribeBPWhiteListsRequest req)
        {
            return InternalRequestAsync<DescribeBPWhiteListsResponse>(req, "DescribeBPWhiteLists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
