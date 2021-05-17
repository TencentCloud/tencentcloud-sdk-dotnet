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

namespace TencentCloud.Mna.V20210119
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mna.V20210119.Models;

   public class MnaClient : AbstractClient{

       private const string endpoint = "mna.tencentcloudapi.com";
       private const string version = "2021-01-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MnaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MnaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 移动网络发起Qos加速过程
        /// </summary>
        /// <param name="req"><see cref="CreateQosRequest"/></param>
        /// <returns><see cref="CreateQosResponse"/></returns>
        public async Task<CreateQosResponse> CreateQos(CreateQosRequest req)
        {
             JsonResponseModel<CreateQosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动网络发起Qos加速过程
        /// </summary>
        /// <param name="req"><see cref="CreateQosRequest"/></param>
        /// <returns><see cref="CreateQosResponse"/></returns>
        public CreateQosResponse CreateQosSync(CreateQosRequest req)
        {
             JsonResponseModel<CreateQosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动网络停止Qos加速过程
        /// </summary>
        /// <param name="req"><see cref="DeleteQosRequest"/></param>
        /// <returns><see cref="DeleteQosResponse"/></returns>
        public async Task<DeleteQosResponse> DeleteQos(DeleteQosRequest req)
        {
             JsonResponseModel<DeleteQosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动网络停止Qos加速过程
        /// </summary>
        /// <param name="req"><see cref="DeleteQosRequest"/></param>
        /// <returns><see cref="DeleteQosResponse"/></returns>
        public DeleteQosResponse DeleteQosSync(DeleteQosRequest req)
        {
             JsonResponseModel<DeleteQosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
