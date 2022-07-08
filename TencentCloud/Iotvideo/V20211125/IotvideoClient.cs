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

namespace TencentCloud.Iotvideo.V20211125
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iotvideo.V20211125.Models;

   public class IotvideoClient : AbstractClient{

       private const string endpoint = "iotvideo.tencentcloudapi.com";
       private const string version = "2021-11-25";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IotvideoClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IotvideoClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 异步调用设备行为
        /// </summary>
        /// <param name="req"><see cref="CallDeviceActionAsyncRequest"/></param>
        /// <returns><see cref="CallDeviceActionAsyncResponse"/></returns>
        public async Task<CallDeviceActionAsyncResponse> CallDeviceActionAsync(CallDeviceActionAsyncRequest req)
        {
             JsonResponseModel<CallDeviceActionAsyncResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CallDeviceActionAsync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CallDeviceActionAsyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 异步调用设备行为
        /// </summary>
        /// <param name="req"><see cref="CallDeviceActionAsyncRequest"/></param>
        /// <returns><see cref="CallDeviceActionAsyncResponse"/></returns>
        public CallDeviceActionAsyncResponse CallDeviceActionAsyncSync(CallDeviceActionAsyncRequest req)
        {
             JsonResponseModel<CallDeviceActionAsyncResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CallDeviceActionAsync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CallDeviceActionAsyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步调用设备行为
        /// </summary>
        /// <param name="req"><see cref="CallDeviceActionSyncRequest"/></param>
        /// <returns><see cref="CallDeviceActionSyncResponse"/></returns>
        public async Task<CallDeviceActionSyncResponse> CallDeviceActionSync(CallDeviceActionSyncRequest req)
        {
             JsonResponseModel<CallDeviceActionSyncResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CallDeviceActionSync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CallDeviceActionSyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步调用设备行为
        /// </summary>
        /// <param name="req"><see cref="CallDeviceActionSyncRequest"/></param>
        /// <returns><see cref="CallDeviceActionSyncResponse"/></returns>
        public CallDeviceActionSyncResponse CallDeviceActionSyncSync(CallDeviceActionSyncRequest req)
        {
             JsonResponseModel<CallDeviceActionSyncResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CallDeviceActionSync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CallDeviceActionSyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备数据统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceDataStatsRequest"/></param>
        /// <returns><see cref="DescribeDeviceDataStatsResponse"/></returns>
        public async Task<DescribeDeviceDataStatsResponse> DescribeDeviceDataStats(DescribeDeviceDataStatsRequest req)
        {
             JsonResponseModel<DescribeDeviceDataStatsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceDataStats");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceDataStatsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备数据统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceDataStatsRequest"/></param>
        /// <returns><see cref="DescribeDeviceDataStatsResponse"/></returns>
        public DescribeDeviceDataStatsResponse DescribeDeviceDataStatsSync(DescribeDeviceDataStatsRequest req)
        {
             JsonResponseModel<DescribeDeviceDataStatsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceDataStats");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceDataStatsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备消息数量统计
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageDataStatsRequest"/></param>
        /// <returns><see cref="DescribeMessageDataStatsResponse"/></returns>
        public async Task<DescribeMessageDataStatsResponse> DescribeMessageDataStats(DescribeMessageDataStatsRequest req)
        {
             JsonResponseModel<DescribeMessageDataStatsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMessageDataStats");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMessageDataStatsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备消息数量统计
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageDataStatsRequest"/></param>
        /// <returns><see cref="DescribeMessageDataStatsResponse"/></returns>
        public DescribeMessageDataStatsResponse DescribeMessageDataStatsSync(DescribeMessageDataStatsRequest req)
        {
             JsonResponseModel<DescribeMessageDataStatsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMessageDataStats");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMessageDataStatsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
