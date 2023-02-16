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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BmaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 添加品牌
        /// </summary>
        /// <param name="req"><see cref="CreateBPBrandRequest"/></param>
        /// <returns><see cref="CreateBPBrandResponse"/></returns>
        public async Task<CreateBPBrandResponse> CreateBPBrand(CreateBPBrandRequest req)
        {
             JsonResponseModel<CreateBPBrandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBPBrand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPBrandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加品牌
        /// </summary>
        /// <param name="req"><see cref="CreateBPBrandRequest"/></param>
        /// <returns><see cref="CreateBPBrandResponse"/></returns>
        public CreateBPBrandResponse CreateBPBrandSync(CreateBPBrandRequest req)
        {
             JsonResponseModel<CreateBPBrandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBPBrand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPBrandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 仿冒应用举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeAPPRequest"/></param>
        /// <returns><see cref="CreateBPFakeAPPResponse"/></returns>
        public async Task<CreateBPFakeAPPResponse> CreateBPFakeAPP(CreateBPFakeAPPRequest req)
        {
             JsonResponseModel<CreateBPFakeAPPResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBPFakeAPP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeAPPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 仿冒应用举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeAPPRequest"/></param>
        /// <returns><see cref="CreateBPFakeAPPResponse"/></returns>
        public CreateBPFakeAPPResponse CreateBPFakeAPPSync(CreateBPFakeAPPRequest req)
        {
             JsonResponseModel<CreateBPFakeAPPResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBPFakeAPP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeAPPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量仿冒应用举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeAPPListRequest"/></param>
        /// <returns><see cref="CreateBPFakeAPPListResponse"/></returns>
        public async Task<CreateBPFakeAPPListResponse> CreateBPFakeAPPList(CreateBPFakeAPPListRequest req)
        {
             JsonResponseModel<CreateBPFakeAPPListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBPFakeAPPList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeAPPListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量仿冒应用举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeAPPListRequest"/></param>
        /// <returns><see cref="CreateBPFakeAPPListResponse"/></returns>
        public CreateBPFakeAPPListResponse CreateBPFakeAPPListSync(CreateBPFakeAPPListRequest req)
        {
             JsonResponseModel<CreateBPFakeAPPListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBPFakeAPPList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeAPPListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 仿冒网址举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeURLRequest"/></param>
        /// <returns><see cref="CreateBPFakeURLResponse"/></returns>
        public async Task<CreateBPFakeURLResponse> CreateBPFakeURL(CreateBPFakeURLRequest req)
        {
             JsonResponseModel<CreateBPFakeURLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBPFakeURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 仿冒网址举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeURLRequest"/></param>
        /// <returns><see cref="CreateBPFakeURLResponse"/></returns>
        public CreateBPFakeURLResponse CreateBPFakeURLSync(CreateBPFakeURLRequest req)
        {
             JsonResponseModel<CreateBPFakeURLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBPFakeURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量仿冒网址举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeURLsRequest"/></param>
        /// <returns><see cref="CreateBPFakeURLsResponse"/></returns>
        public async Task<CreateBPFakeURLsResponse> CreateBPFakeURLs(CreateBPFakeURLsRequest req)
        {
             JsonResponseModel<CreateBPFakeURLsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBPFakeURLs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeURLsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量仿冒网址举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeURLsRequest"/></param>
        /// <returns><see cref="CreateBPFakeURLsResponse"/></returns>
        public CreateBPFakeURLsResponse CreateBPFakeURLsSync(CreateBPFakeURLsRequest req)
        {
             JsonResponseModel<CreateBPFakeURLsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBPFakeURLs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeURLsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加白名单
        /// </summary>
        /// <param name="req"><see cref="CreateBPWhiteListRequest"/></param>
        /// <returns><see cref="CreateBPWhiteListResponse"/></returns>
        public async Task<CreateBPWhiteListResponse> CreateBPWhiteList(CreateBPWhiteListRequest req)
        {
             JsonResponseModel<CreateBPWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBPWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加白名单
        /// </summary>
        /// <param name="req"><see cref="CreateBPWhiteListRequest"/></param>
        /// <returns><see cref="CreateBPWhiteListResponse"/></returns>
        public CreateBPWhiteListResponse CreateBPWhiteListSync(CreateBPWhiteListRequest req)
        {
             JsonResponseModel<CreateBPWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBPWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteBPWhiteListRequest"/></param>
        /// <returns><see cref="DeleteBPWhiteListResponse"/></returns>
        public async Task<DeleteBPWhiteListResponse> DeleteBPWhiteList(DeleteBPWhiteListRequest req)
        {
             JsonResponseModel<DeleteBPWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBPWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBPWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteBPWhiteListRequest"/></param>
        /// <returns><see cref="DeleteBPWhiteListResponse"/></returns>
        public DeleteBPWhiteListResponse DeleteBPWhiteListSync(DeleteBPWhiteListRequest req)
        {
             JsonResponseModel<DeleteBPWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBPWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBPWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询品牌列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPBrandsRequest"/></param>
        /// <returns><see cref="DescribeBPBrandsResponse"/></returns>
        public async Task<DescribeBPBrandsResponse> DescribeBPBrands(DescribeBPBrandsRequest req)
        {
             JsonResponseModel<DescribeBPBrandsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBPBrands");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBPBrandsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询品牌列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPBrandsRequest"/></param>
        /// <returns><see cref="DescribeBPBrandsResponse"/></returns>
        public DescribeBPBrandsResponse DescribeBPBrandsSync(DescribeBPBrandsRequest req)
        {
             JsonResponseModel<DescribeBPBrandsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBPBrands");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBPBrandsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询仿冒应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPFakeAPPListRequest"/></param>
        /// <returns><see cref="DescribeBPFakeAPPListResponse"/></returns>
        public async Task<DescribeBPFakeAPPListResponse> DescribeBPFakeAPPList(DescribeBPFakeAPPListRequest req)
        {
             JsonResponseModel<DescribeBPFakeAPPListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBPFakeAPPList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBPFakeAPPListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询仿冒应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPFakeAPPListRequest"/></param>
        /// <returns><see cref="DescribeBPFakeAPPListResponse"/></returns>
        public DescribeBPFakeAPPListResponse DescribeBPFakeAPPListSync(DescribeBPFakeAPPListRequest req)
        {
             JsonResponseModel<DescribeBPFakeAPPListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBPFakeAPPList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBPFakeAPPListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询仿冒网址列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPFakeURLsRequest"/></param>
        /// <returns><see cref="DescribeBPFakeURLsResponse"/></returns>
        public async Task<DescribeBPFakeURLsResponse> DescribeBPFakeURLs(DescribeBPFakeURLsRequest req)
        {
             JsonResponseModel<DescribeBPFakeURLsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBPFakeURLs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBPFakeURLsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询仿冒网址列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPFakeURLsRequest"/></param>
        /// <returns><see cref="DescribeBPFakeURLsResponse"/></returns>
        public DescribeBPFakeURLsResponse DescribeBPFakeURLsSync(DescribeBPFakeURLsRequest req)
        {
             JsonResponseModel<DescribeBPFakeURLsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBPFakeURLs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBPFakeURLsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPWhiteListsRequest"/></param>
        /// <returns><see cref="DescribeBPWhiteListsResponse"/></returns>
        public async Task<DescribeBPWhiteListsResponse> DescribeBPWhiteLists(DescribeBPWhiteListsRequest req)
        {
             JsonResponseModel<DescribeBPWhiteListsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBPWhiteLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBPWhiteListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPWhiteListsRequest"/></param>
        /// <returns><see cref="DescribeBPWhiteListsResponse"/></returns>
        public DescribeBPWhiteListsResponse DescribeBPWhiteListsSync(DescribeBPWhiteListsRequest req)
        {
             JsonResponseModel<DescribeBPWhiteListsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBPWhiteLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBPWhiteListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
