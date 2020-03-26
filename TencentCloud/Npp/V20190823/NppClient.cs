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

namespace TencentCloud.Npp.V20190823
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Npp.V20190823.Models;

   public class NppClient : AbstractClient{

       private const string endpoint = "npp.tencentcloudapi.com";
       private const string version = "2019-08-23";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public NppClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public NppClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 回拨呼叫请求
        /// </summary>
        /// <param name="req"><see cref="CreateCallBackRequest"/></param>
        /// <returns><see cref="CreateCallBackResponse"/></returns>
        public async Task<CreateCallBackResponse> CreateCallBack(CreateCallBackRequest req)
        {
             JsonResponseModel<CreateCallBackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCallBack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCallBackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回拨呼叫请求
        /// </summary>
        /// <param name="req"><see cref="CreateCallBackRequest"/></param>
        /// <returns><see cref="CreateCallBackResponse"/></returns>
        public CreateCallBackResponse CreateCallBackSync(CreateCallBackRequest req)
        {
             JsonResponseModel<CreateCallBackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCallBack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCallBackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直拨解绑中间号
        /// </summary>
        /// <param name="req"><see cref="DelVirtualNumRequest"/></param>
        /// <returns><see cref="DelVirtualNumResponse"/></returns>
        public async Task<DelVirtualNumResponse> DelVirtualNum(DelVirtualNumRequest req)
        {
             JsonResponseModel<DelVirtualNumResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DelVirtualNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DelVirtualNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直拨解绑中间号
        /// </summary>
        /// <param name="req"><see cref="DelVirtualNumRequest"/></param>
        /// <returns><see cref="DelVirtualNumResponse"/></returns>
        public DelVirtualNumResponse DelVirtualNumSync(DelVirtualNumRequest req)
        {
             JsonResponseModel<DelVirtualNumResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DelVirtualNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DelVirtualNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回拨呼叫取消
        /// </summary>
        /// <param name="req"><see cref="DeleteCallBackRequest"/></param>
        /// <returns><see cref="DeleteCallBackResponse"/></returns>
        public async Task<DeleteCallBackResponse> DeleteCallBack(DeleteCallBackRequest req)
        {
             JsonResponseModel<DeleteCallBackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCallBack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCallBackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回拨呼叫取消
        /// </summary>
        /// <param name="req"><see cref="DeleteCallBackRequest"/></param>
        /// <returns><see cref="DeleteCallBackResponse"/></returns>
        public DeleteCallBackResponse DeleteCallBackSync(DeleteCallBackRequest req)
        {
             JsonResponseModel<DeleteCallBackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCallBack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCallBackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回拨话单获取接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCallBackCdrRequest"/></param>
        /// <returns><see cref="DescribeCallBackCdrResponse"/></returns>
        public async Task<DescribeCallBackCdrResponse> DescribeCallBackCdr(DescribeCallBackCdrRequest req)
        {
             JsonResponseModel<DescribeCallBackCdrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCallBackCdr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCallBackCdrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回拨话单获取接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCallBackCdrRequest"/></param>
        /// <returns><see cref="DescribeCallBackCdrResponse"/></returns>
        public DescribeCallBackCdrResponse DescribeCallBackCdrSync(DescribeCallBackCdrRequest req)
        {
             JsonResponseModel<DescribeCallBackCdrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCallBackCdr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCallBackCdrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回拨通话状态获取
        /// </summary>
        /// <param name="req"><see cref="DescribeCallBackStatusRequest"/></param>
        /// <returns><see cref="DescribeCallBackStatusResponse"/></returns>
        public async Task<DescribeCallBackStatusResponse> DescribeCallBackStatus(DescribeCallBackStatusRequest req)
        {
             JsonResponseModel<DescribeCallBackStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCallBackStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCallBackStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回拨通话状态获取
        /// </summary>
        /// <param name="req"><see cref="DescribeCallBackStatusRequest"/></param>
        /// <returns><see cref="DescribeCallBackStatusResponse"/></returns>
        public DescribeCallBackStatusResponse DescribeCallBackStatusSync(DescribeCallBackStatusRequest req)
        {
             JsonResponseModel<DescribeCallBackStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCallBackStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCallBackStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回拨拉取主叫显号号码集合
        /// </summary>
        /// <param name="req"><see cref="DescribeCallerDisplayListRequest"/></param>
        /// <returns><see cref="DescribeCallerDisplayListResponse"/></returns>
        public async Task<DescribeCallerDisplayListResponse> DescribeCallerDisplayList(DescribeCallerDisplayListRequest req)
        {
             JsonResponseModel<DescribeCallerDisplayListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCallerDisplayList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCallerDisplayListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回拨拉取主叫显号号码集合
        /// </summary>
        /// <param name="req"><see cref="DescribeCallerDisplayListRequest"/></param>
        /// <returns><see cref="DescribeCallerDisplayListResponse"/></returns>
        public DescribeCallerDisplayListResponse DescribeCallerDisplayListSync(DescribeCallerDisplayListRequest req)
        {
             JsonResponseModel<DescribeCallerDisplayListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCallerDisplayList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCallerDisplayListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直拨话单获取接口
        /// </summary>
        /// <param name="req"><see cref="Get400CdrRequest"/></param>
        /// <returns><see cref="Get400CdrResponse"/></returns>
        public async Task<Get400CdrResponse> Get400Cdr(Get400CdrRequest req)
        {
             JsonResponseModel<Get400CdrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Get400Cdr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<Get400CdrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直拨话单获取接口
        /// </summary>
        /// <param name="req"><see cref="Get400CdrRequest"/></param>
        /// <returns><see cref="Get400CdrResponse"/></returns>
        public Get400CdrResponse Get400CdrSync(Get400CdrRequest req)
        {
             JsonResponseModel<Get400CdrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Get400Cdr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<Get400CdrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直拨获取中间号（App 使用方发起）
        /// </summary>
        /// <param name="req"><see cref="GetVirtualNumRequest"/></param>
        /// <returns><see cref="GetVirtualNumResponse"/></returns>
        public async Task<GetVirtualNumResponse> GetVirtualNum(GetVirtualNumRequest req)
        {
             JsonResponseModel<GetVirtualNumResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetVirtualNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetVirtualNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直拨获取中间号（App 使用方发起）
        /// </summary>
        /// <param name="req"><see cref="GetVirtualNumRequest"/></param>
        /// <returns><see cref="GetVirtualNumResponse"/></returns>
        public GetVirtualNumResponse GetVirtualNumSync(GetVirtualNumRequest req)
        {
             JsonResponseModel<GetVirtualNumResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetVirtualNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetVirtualNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
