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

namespace TencentCloud.Csxg.V20230303
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Csxg.V20230303.Models;

   public class CsxgClient : AbstractClient{

       private const string endpoint = "csxg.tencentcloudapi.com";
       private const string version = "2023-03-03";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CsxgClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CsxgClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建5G入云服务接口
        /// </summary>
        /// <param name="req"><see cref="Create5GInstanceRequest"/></param>
        /// <returns><see cref="Create5GInstanceResponse"/></returns>
        public async Task<Create5GInstanceResponse> Create5GInstance(Create5GInstanceRequest req)
        {
             JsonResponseModel<Create5GInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Create5GInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<Create5GInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建5G入云服务接口
        /// </summary>
        /// <param name="req"><see cref="Create5GInstanceRequest"/></param>
        /// <returns><see cref="Create5GInstanceResponse"/></returns>
        public Create5GInstanceResponse Create5GInstanceSync(Create5GInstanceRequest req)
        {
             JsonResponseModel<Create5GInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Create5GInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<Create5GInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除5G入云服务
        /// </summary>
        /// <param name="req"><see cref="Delete5GInstanceRequest"/></param>
        /// <returns><see cref="Delete5GInstanceResponse"/></returns>
        public async Task<Delete5GInstanceResponse> Delete5GInstance(Delete5GInstanceRequest req)
        {
             JsonResponseModel<Delete5GInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Delete5GInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<Delete5GInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除5G入云服务
        /// </summary>
        /// <param name="req"><see cref="Delete5GInstanceRequest"/></param>
        /// <returns><see cref="Delete5GInstanceResponse"/></returns>
        public Delete5GInstanceResponse Delete5GInstanceSync(Delete5GInstanceRequest req)
        {
             JsonResponseModel<Delete5GInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Delete5GInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<Delete5GInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询APN信息
        /// </summary>
        /// <param name="req"><see cref="Describe5GAPNsRequest"/></param>
        /// <returns><see cref="Describe5GAPNsResponse"/></returns>
        public async Task<Describe5GAPNsResponse> Describe5GAPNs(Describe5GAPNsRequest req)
        {
             JsonResponseModel<Describe5GAPNsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Describe5GAPNs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<Describe5GAPNsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询APN信息
        /// </summary>
        /// <param name="req"><see cref="Describe5GAPNsRequest"/></param>
        /// <returns><see cref="Describe5GAPNsResponse"/></returns>
        public Describe5GAPNsResponse Describe5GAPNsSync(Describe5GAPNsRequest req)
        {
             JsonResponseModel<Describe5GAPNsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Describe5GAPNs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<Describe5GAPNsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询5G入云服务
        /// </summary>
        /// <param name="req"><see cref="Describe5GInstancesRequest"/></param>
        /// <returns><see cref="Describe5GInstancesResponse"/></returns>
        public async Task<Describe5GInstancesResponse> Describe5GInstances(Describe5GInstancesRequest req)
        {
             JsonResponseModel<Describe5GInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Describe5GInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<Describe5GInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询5G入云服务
        /// </summary>
        /// <param name="req"><see cref="Describe5GInstancesRequest"/></param>
        /// <returns><see cref="Describe5GInstancesResponse"/></returns>
        public Describe5GInstancesResponse Describe5GInstancesSync(Describe5GInstancesRequest req)
        {
             JsonResponseModel<Describe5GInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Describe5GInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<Describe5GInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改5G入云服务
        /// </summary>
        /// <param name="req"><see cref="Modify5GInstanceAttributeRequest"/></param>
        /// <returns><see cref="Modify5GInstanceAttributeResponse"/></returns>
        public async Task<Modify5GInstanceAttributeResponse> Modify5GInstanceAttribute(Modify5GInstanceAttributeRequest req)
        {
             JsonResponseModel<Modify5GInstanceAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Modify5GInstanceAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<Modify5GInstanceAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改5G入云服务
        /// </summary>
        /// <param name="req"><see cref="Modify5GInstanceAttributeRequest"/></param>
        /// <returns><see cref="Modify5GInstanceAttributeResponse"/></returns>
        public Modify5GInstanceAttributeResponse Modify5GInstanceAttributeSync(Modify5GInstanceAttributeRequest req)
        {
             JsonResponseModel<Modify5GInstanceAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Modify5GInstanceAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<Modify5GInstanceAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
