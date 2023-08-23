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

namespace TencentCloud.Dsgc.V20190723
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dsgc.V20190723.Models;

   public class DsgcClient : AbstractClient{

       private const string endpoint = "dsgc.tencentcloudapi.com";
       private const string version = "2019-07-23";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DsgcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DsgcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 添加用户云上数据库类型资源
        /// </summary>
        /// <param name="req"><see cref="CreateDSPADbMetaResourcesRequest"/></param>
        /// <returns><see cref="CreateDSPADbMetaResourcesResponse"/></returns>
        public async Task<CreateDSPADbMetaResourcesResponse> CreateDSPADbMetaResources(CreateDSPADbMetaResourcesRequest req)
        {
             JsonResponseModel<CreateDSPADbMetaResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDSPADbMetaResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPADbMetaResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加用户云上数据库类型资源
        /// </summary>
        /// <param name="req"><see cref="CreateDSPADbMetaResourcesRequest"/></param>
        /// <returns><see cref="CreateDSPADbMetaResourcesResponse"/></returns>
        public CreateDSPADbMetaResourcesResponse CreateDSPADbMetaResourcesSync(CreateDSPADbMetaResourcesRequest req)
        {
             JsonResponseModel<CreateDSPADbMetaResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDSPADbMetaResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPADbMetaResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
