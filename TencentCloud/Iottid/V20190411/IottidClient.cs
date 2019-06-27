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

namespace TencentCloud.Iottid.V20190411
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iottid.V20190411.Models;

   public class IottidClient : AbstractClient{

       private const string endpoint = "iottid.tencentcloudapi.com";
       private const string version = "2019-04-11";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public IottidClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public IottidClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 安全芯片TID烧录回执
        /// </summary>
        /// <param name="req">参考<see cref="BurnTidNotifyRequest"/></param>
        /// <returns>参考<see cref="BurnTidNotifyResponse"/>实例</returns>
        public async Task<BurnTidNotifyResponse> BurnTidNotify(BurnTidNotifyRequest req)
        {
             JsonResponseModel<BurnTidNotifyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BurnTidNotify");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BurnTidNotifyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全芯片为载体的TID空发回执，绑定TID与订单号。
        /// </summary>
        /// <param name="req">参考<see cref="DeliverTidNotifyRequest"/></param>
        /// <returns>参考<see cref="DeliverTidNotifyResponse"/>实例</returns>
        public async Task<DeliverTidNotifyResponse> DeliverTidNotify(DeliverTidNotifyRequest req)
        {
             JsonResponseModel<DeliverTidNotifyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeliverTidNotify");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeliverTidNotifyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设备服务商请求空发产品订单的TID信息
        /// </summary>
        /// <param name="req">参考<see cref="DeliverTidsRequest"/></param>
        /// <returns>参考<see cref="DeliverTidsResponse"/>实例</returns>
        public async Task<DeliverTidsResponse> DeliverTids(DeliverTidsRequest req)
        {
             JsonResponseModel<DeliverTidsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeliverTids");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeliverTidsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询企业用户TID平台控制台权限
        /// </summary>
        /// <param name="req">参考<see cref="DescribePermissionRequest"/></param>
        /// <returns>参考<see cref="DescribePermissionResponse"/>实例</returns>
        public async Task<DescribePermissionResponse> DescribePermission(DescribePermissionRequest req)
        {
             JsonResponseModel<DescribePermissionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePermission");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePermissionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下载芯片订单的TID
        /// </summary>
        /// <param name="req">参考<see cref="DownloadTidsRequest"/></param>
        /// <returns>参考<see cref="DownloadTidsResponse"/>实例</returns>
        public async Task<DownloadTidsResponse> DownloadTids(DownloadTidsRequest req)
        {
             JsonResponseModel<DownloadTidsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadTids");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadTidsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
