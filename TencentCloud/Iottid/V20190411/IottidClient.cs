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
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IottidClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IottidClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 单向认证测试TID 
        /// </summary>
        /// <param name="req"><see cref="AuthTestTidRequest"/></param>
        /// <returns><see cref="AuthTestTidResponse"/></returns>
        public async Task<AuthTestTidResponse> AuthTestTid(AuthTestTidRequest req)
        {
             JsonResponseModel<AuthTestTidResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AuthTestTid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AuthTestTidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全芯片TID烧录回执 
        /// </summary>
        /// <param name="req"><see cref="BurnTidNotifyRequest"/></param>
        /// <returns><see cref="BurnTidNotifyResponse"/></returns>
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
        /// <param name="req"><see cref="DeliverTidNotifyRequest"/></param>
        /// <returns><see cref="DeliverTidNotifyResponse"/></returns>
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
        /// <param name="req"><see cref="DeliverTidsRequest"/></param>
        /// <returns><see cref="DeliverTidsResponse"/></returns>
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
        /// 查询指定订单的可空发的白盒密钥数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableLibCountRequest"/></param>
        /// <returns><see cref="DescribeAvailableLibCountResponse"/></returns>
        public async Task<DescribeAvailableLibCountResponse> DescribeAvailableLibCount(DescribeAvailableLibCountRequest req)
        {
             JsonResponseModel<DescribeAvailableLibCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAvailableLibCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableLibCountResponse>>(strResp);
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
        /// <param name="req"><see cref="DescribePermissionRequest"/></param>
        /// <returns><see cref="DescribePermissionResponse"/></returns>
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
        /// <param name="req"><see cref="DownloadTidsRequest"/></param>
        /// <returns><see cref="DownloadTidsResponse"/></returns>
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

        /// <summary>
        /// 上传硬件唯一标识码，是软加固设备身份参数。本接口如遇到错误数据，则所有当次上传数据失效。
        /// </summary>
        /// <param name="req"><see cref="UploadDeviceUniqueCodeRequest"/></param>
        /// <returns><see cref="UploadDeviceUniqueCodeResponse"/></returns>
        public async Task<UploadDeviceUniqueCodeResponse> UploadDeviceUniqueCode(UploadDeviceUniqueCodeRequest req)
        {
             JsonResponseModel<UploadDeviceUniqueCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadDeviceUniqueCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadDeviceUniqueCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下载控制台验证芯片烧录信息，保证TID与中心信息一致 
        /// </summary>
        /// <param name="req"><see cref="VerifyChipBurnInfoRequest"/></param>
        /// <returns><see cref="VerifyChipBurnInfoResponse"/></returns>
        public async Task<VerifyChipBurnInfoResponse> VerifyChipBurnInfo(VerifyChipBurnInfoRequest req)
        {
             JsonResponseModel<VerifyChipBurnInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyChipBurnInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyChipBurnInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
