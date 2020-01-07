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

namespace TencentCloud.Cis.V20180408
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cis.V20180408.Models;

   public class CisClient : AbstractClient{

       private const string endpoint = "cis.tencentcloudapi.com";
       private const string version = "2018-04-08";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 此接口（CreateContainerInstance）用于创建容器实例
        /// </summary>
        /// <param name="req"><see cref="CreateContainerInstanceRequest"/></param>
        /// <returns><see cref="CreateContainerInstanceResponse"/></returns>
        public async Task<CreateContainerInstanceResponse> CreateContainerInstance(CreateContainerInstanceRequest req)
        {
             JsonResponseModel<CreateContainerInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateContainerInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateContainerInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateContainerInstance接口的同步版本，此接口（CreateContainerInstance）用于创建容器实例
        /// </summary>
        /// <param name="req">参考<see cref="CreateContainerInstanceRequest"/></param>
        /// <returns>参考<see cref="CreateContainerInstanceResponse"/>实例</returns>
        public CreateContainerInstanceResponse CreateContainerInstanceSync(CreateContainerInstanceRequest req)
        {
             JsonResponseModel<CreateContainerInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateContainerInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateContainerInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DeleteContainerInstance）用于删除容器实例
        /// </summary>
        /// <param name="req"><see cref="DeleteContainerInstanceRequest"/></param>
        /// <returns><see cref="DeleteContainerInstanceResponse"/></returns>
        public async Task<DeleteContainerInstanceResponse> DeleteContainerInstance(DeleteContainerInstanceRequest req)
        {
             JsonResponseModel<DeleteContainerInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteContainerInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteContainerInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteContainerInstance接口的同步版本，此接口（DeleteContainerInstance）用于删除容器实例
        /// </summary>
        /// <param name="req">参考<see cref="DeleteContainerInstanceRequest"/></param>
        /// <returns>参考<see cref="DeleteContainerInstanceResponse"/>实例</returns>
        public DeleteContainerInstanceResponse DeleteContainerInstanceSync(DeleteContainerInstanceRequest req)
        {
             JsonResponseModel<DeleteContainerInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteContainerInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteContainerInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeContainerInstance）用于获取容器实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerInstanceRequest"/></param>
        /// <returns><see cref="DescribeContainerInstanceResponse"/></returns>
        public async Task<DescribeContainerInstanceResponse> DescribeContainerInstance(DescribeContainerInstanceRequest req)
        {
             JsonResponseModel<DescribeContainerInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContainerInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeContainerInstance接口的同步版本，此接口（DescribeContainerInstance）用于获取容器实例详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeContainerInstanceRequest"/></param>
        /// <returns>参考<see cref="DescribeContainerInstanceResponse"/>实例</returns>
        public DescribeContainerInstanceResponse DescribeContainerInstanceSync(DescribeContainerInstanceRequest req)
        {
             JsonResponseModel<DescribeContainerInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeContainerInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeContainerInstanceEvents）用于查询容器实例事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerInstanceEventsRequest"/></param>
        /// <returns><see cref="DescribeContainerInstanceEventsResponse"/></returns>
        public async Task<DescribeContainerInstanceEventsResponse> DescribeContainerInstanceEvents(DescribeContainerInstanceEventsRequest req)
        {
             JsonResponseModel<DescribeContainerInstanceEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContainerInstanceEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerInstanceEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeContainerInstanceEvents接口的同步版本，此接口（DescribeContainerInstanceEvents）用于查询容器实例事件列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeContainerInstanceEventsRequest"/></param>
        /// <returns>参考<see cref="DescribeContainerInstanceEventsResponse"/>实例</returns>
        public DescribeContainerInstanceEventsResponse DescribeContainerInstanceEventsSync(DescribeContainerInstanceEventsRequest req)
        {
             JsonResponseModel<DescribeContainerInstanceEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeContainerInstanceEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerInstanceEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeContainerInstances）查询容器实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerInstancesRequest"/></param>
        /// <returns><see cref="DescribeContainerInstancesResponse"/></returns>
        public async Task<DescribeContainerInstancesResponse> DescribeContainerInstances(DescribeContainerInstancesRequest req)
        {
             JsonResponseModel<DescribeContainerInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContainerInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeContainerInstances接口的同步版本，此接口（DescribeContainerInstances）查询容器实例列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeContainerInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeContainerInstancesResponse"/>实例</returns>
        public DescribeContainerInstancesResponse DescribeContainerInstancesSync(DescribeContainerInstancesRequest req)
        {
             JsonResponseModel<DescribeContainerInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeContainerInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeContainerLog）用于获取容器日志信息
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerLogRequest"/></param>
        /// <returns><see cref="DescribeContainerLogResponse"/></returns>
        public async Task<DescribeContainerLogResponse> DescribeContainerLog(DescribeContainerLogRequest req)
        {
             JsonResponseModel<DescribeContainerLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContainerLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeContainerLog接口的同步版本，此接口（DescribeContainerLog）用于获取容器日志信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeContainerLogRequest"/></param>
        /// <returns>参考<see cref="DescribeContainerLogResponse"/>实例</returns>
        public DescribeContainerLogResponse DescribeContainerLogSync(DescribeContainerLogRequest req)
        {
             JsonResponseModel<DescribeContainerLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeContainerLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（InquiryPriceCreateCis）用于查询容器实例价格
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateCisRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateCisResponse"/></returns>
        public async Task<InquiryPriceCreateCisResponse> InquiryPriceCreateCis(InquiryPriceCreateCisRequest req)
        {
             JsonResponseModel<InquiryPriceCreateCisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateCis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateCisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// InquiryPriceCreateCis接口的同步版本，此接口（InquiryPriceCreateCis）用于查询容器实例价格
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceCreateCisRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceCreateCisResponse"/>实例</returns>
        public InquiryPriceCreateCisResponse InquiryPriceCreateCisSync(InquiryPriceCreateCisRequest req)
        {
             JsonResponseModel<InquiryPriceCreateCisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceCreateCis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateCisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
