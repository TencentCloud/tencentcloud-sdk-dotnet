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

namespace TencentCloud.Anicloud.V20220923
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Anicloud.V20220923.Models;

   public class AnicloudClient : AbstractClient{

       private const string endpoint = "anicloud.tencentcloudapi.com";
       private const string version = "2022-09-23";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AnicloudClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AnicloudClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 查看appid是否存在
        /// </summary>
        /// <param name="req"><see cref="CheckAppidExistRequest"/></param>
        /// <returns><see cref="CheckAppidExistResponse"/></returns>
        public async Task<CheckAppidExistResponse> CheckAppidExist(CheckAppidExistRequest req)
        {
             JsonResponseModel<CheckAppidExistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckAppidExist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckAppidExistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看appid是否存在
        /// </summary>
        /// <param name="req"><see cref="CheckAppidExistRequest"/></param>
        /// <returns><see cref="CheckAppidExistResponse"/></returns>
        public CheckAppidExistResponse CheckAppidExistSync(CheckAppidExistRequest req)
        {
             JsonResponseModel<CheckAppidExistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckAppidExist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckAppidExistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询购买资源
        /// </summary>
        /// <param name="req"><see cref="QueryResourceRequest"/></param>
        /// <returns><see cref="QueryResourceResponse"/></returns>
        public async Task<QueryResourceResponse> QueryResource(QueryResourceRequest req)
        {
             JsonResponseModel<QueryResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询购买资源
        /// </summary>
        /// <param name="req"><see cref="QueryResourceRequest"/></param>
        /// <returns><see cref="QueryResourceResponse"/></returns>
        public QueryResourceResponse QueryResourceSync(QueryResourceRequest req)
        {
             JsonResponseModel<QueryResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资源信息
        /// </summary>
        /// <param name="req"><see cref="QueryResourceInfoRequest"/></param>
        /// <returns><see cref="QueryResourceInfoResponse"/></returns>
        public async Task<QueryResourceInfoResponse> QueryResourceInfo(QueryResourceInfoRequest req)
        {
             JsonResponseModel<QueryResourceInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryResourceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryResourceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资源信息
        /// </summary>
        /// <param name="req"><see cref="QueryResourceInfoRequest"/></param>
        /// <returns><see cref="QueryResourceInfoResponse"/></returns>
        public QueryResourceInfoResponse QueryResourceInfoSync(QueryResourceInfoRequest req)
        {
             JsonResponseModel<QueryResourceInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryResourceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryResourceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
