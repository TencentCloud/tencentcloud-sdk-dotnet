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

namespace TencentCloud.Yunsou.V20180504
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Yunsou.V20180504.Models;

   public class YunsouClient : AbstractClient{

       private const string endpoint = "yunsou.tencentcloudapi.com";
       private const string version = "2018-05-04";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public YunsouClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public YunsouClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 上传云搜数据的API接口
        /// </summary>
        /// <param name="req"><see cref="DataManipulationRequest"/></param>
        /// <returns><see cref="DataManipulationResponse"/></returns>
        public async Task<DataManipulationResponse> DataManipulation(DataManipulationRequest req)
        {
             JsonResponseModel<DataManipulationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DataManipulation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DataManipulationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DataManipulation接口的同步版本，上传云搜数据的API接口
        /// </summary>
        /// <param name="req">参考<see cref="DataManipulationRequest"/></param>
        /// <returns>参考<see cref="DataManipulationResponse"/>实例</returns>
        public DataManipulationResponse DataManipulationSync(DataManipulationRequest req)
        {
             JsonResponseModel<DataManipulationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DataManipulation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DataManipulationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于检索云搜中的数据
        /// </summary>
        /// <param name="req"><see cref="DataSearchRequest"/></param>
        /// <returns><see cref="DataSearchResponse"/></returns>
        public async Task<DataSearchResponse> DataSearch(DataSearchRequest req)
        {
             JsonResponseModel<DataSearchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DataSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DataSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DataSearch接口的同步版本，用于检索云搜中的数据
        /// </summary>
        /// <param name="req">参考<see cref="DataSearchRequest"/></param>
        /// <returns>参考<see cref="DataSearchResponse"/>实例</returns>
        public DataSearchResponse DataSearchSync(DataSearchRequest req)
        {
             JsonResponseModel<DataSearchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DataSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DataSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
