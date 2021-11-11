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

namespace TencentCloud.Tcm.V20210413
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcm.V20210413.Models;

   public class TcmClient : AbstractClient{

       private const string endpoint = "tcm.tencentcloudapi.com";
       private const string version = "2021-04-13";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 查询网格详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMeshRequest"/></param>
        /// <returns><see cref="DescribeMeshResponse"/></returns>
        public async Task<DescribeMeshResponse> DescribeMesh(DescribeMeshRequest req)
        {
             JsonResponseModel<DescribeMeshResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMesh");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMeshResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网格详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMeshRequest"/></param>
        /// <returns><see cref="DescribeMeshResponse"/></returns>
        public DescribeMeshResponse DescribeMeshSync(DescribeMeshRequest req)
        {
             JsonResponseModel<DescribeMeshResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMesh");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMeshResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMeshListRequest"/></param>
        /// <returns><see cref="DescribeMeshListResponse"/></returns>
        public async Task<DescribeMeshListResponse> DescribeMeshList(DescribeMeshListRequest req)
        {
             JsonResponseModel<DescribeMeshListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMeshList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMeshListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMeshListRequest"/></param>
        /// <returns><see cref="DescribeMeshListResponse"/></returns>
        public DescribeMeshListResponse DescribeMeshListSync(DescribeMeshListRequest req)
        {
             JsonResponseModel<DescribeMeshListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMeshList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMeshListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
