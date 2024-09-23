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
       private const string sdkVersion = "SDK_NET_3.0.1093";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IottidClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 单向认证测试TID 
        /// </summary>
        /// <param name="req"><see cref="AuthTestTidRequest"/></param>
        /// <returns><see cref="AuthTestTidResponse"/></returns>
        public Task<AuthTestTidResponse> AuthTestTid(AuthTestTidRequest req)
        {
            return InternalRequestAsync<AuthTestTidResponse>(req, "AuthTestTid");
        }

        /// <summary>
        /// 单向认证测试TID 
        /// </summary>
        /// <param name="req"><see cref="AuthTestTidRequest"/></param>
        /// <returns><see cref="AuthTestTidResponse"/></returns>
        public AuthTestTidResponse AuthTestTidSync(AuthTestTidRequest req)
        {
            return InternalRequestAsync<AuthTestTidResponse>(req, "AuthTestTid")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安全芯片TID烧录回执 
        /// </summary>
        /// <param name="req"><see cref="BurnTidNotifyRequest"/></param>
        /// <returns><see cref="BurnTidNotifyResponse"/></returns>
        public Task<BurnTidNotifyResponse> BurnTidNotify(BurnTidNotifyRequest req)
        {
            return InternalRequestAsync<BurnTidNotifyResponse>(req, "BurnTidNotify");
        }

        /// <summary>
        /// 安全芯片TID烧录回执 
        /// </summary>
        /// <param name="req"><see cref="BurnTidNotifyRequest"/></param>
        /// <returns><see cref="BurnTidNotifyResponse"/></returns>
        public BurnTidNotifyResponse BurnTidNotifySync(BurnTidNotifyRequest req)
        {
            return InternalRequestAsync<BurnTidNotifyResponse>(req, "BurnTidNotify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安全芯片为载体的TID空发回执，绑定TID与订单号。 
        /// </summary>
        /// <param name="req"><see cref="DeliverTidNotifyRequest"/></param>
        /// <returns><see cref="DeliverTidNotifyResponse"/></returns>
        public Task<DeliverTidNotifyResponse> DeliverTidNotify(DeliverTidNotifyRequest req)
        {
            return InternalRequestAsync<DeliverTidNotifyResponse>(req, "DeliverTidNotify");
        }

        /// <summary>
        /// 安全芯片为载体的TID空发回执，绑定TID与订单号。 
        /// </summary>
        /// <param name="req"><see cref="DeliverTidNotifyRequest"/></param>
        /// <returns><see cref="DeliverTidNotifyResponse"/></returns>
        public DeliverTidNotifyResponse DeliverTidNotifySync(DeliverTidNotifyRequest req)
        {
            return InternalRequestAsync<DeliverTidNotifyResponse>(req, "DeliverTidNotify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设备服务商请求空发产品订单的TID信息 
        /// </summary>
        /// <param name="req"><see cref="DeliverTidsRequest"/></param>
        /// <returns><see cref="DeliverTidsResponse"/></returns>
        public Task<DeliverTidsResponse> DeliverTids(DeliverTidsRequest req)
        {
            return InternalRequestAsync<DeliverTidsResponse>(req, "DeliverTids");
        }

        /// <summary>
        /// 设备服务商请求空发产品订单的TID信息 
        /// </summary>
        /// <param name="req"><see cref="DeliverTidsRequest"/></param>
        /// <returns><see cref="DeliverTidsResponse"/></returns>
        public DeliverTidsResponse DeliverTidsSync(DeliverTidsRequest req)
        {
            return InternalRequestAsync<DeliverTidsResponse>(req, "DeliverTids")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定订单的可空发的白盒密钥数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableLibCountRequest"/></param>
        /// <returns><see cref="DescribeAvailableLibCountResponse"/></returns>
        public Task<DescribeAvailableLibCountResponse> DescribeAvailableLibCount(DescribeAvailableLibCountRequest req)
        {
            return InternalRequestAsync<DescribeAvailableLibCountResponse>(req, "DescribeAvailableLibCount");
        }

        /// <summary>
        /// 查询指定订单的可空发的白盒密钥数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableLibCountRequest"/></param>
        /// <returns><see cref="DescribeAvailableLibCountResponse"/></returns>
        public DescribeAvailableLibCountResponse DescribeAvailableLibCountSync(DescribeAvailableLibCountRequest req)
        {
            return InternalRequestAsync<DescribeAvailableLibCountResponse>(req, "DescribeAvailableLibCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询企业用户TID平台控制台权限 
        /// </summary>
        /// <param name="req"><see cref="DescribePermissionRequest"/></param>
        /// <returns><see cref="DescribePermissionResponse"/></returns>
        public Task<DescribePermissionResponse> DescribePermission(DescribePermissionRequest req)
        {
            return InternalRequestAsync<DescribePermissionResponse>(req, "DescribePermission");
        }

        /// <summary>
        /// 查询企业用户TID平台控制台权限 
        /// </summary>
        /// <param name="req"><see cref="DescribePermissionRequest"/></param>
        /// <returns><see cref="DescribePermissionResponse"/></returns>
        public DescribePermissionResponse DescribePermissionSync(DescribePermissionRequest req)
        {
            return InternalRequestAsync<DescribePermissionResponse>(req, "DescribePermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下载芯片订单的TID 
        /// </summary>
        /// <param name="req"><see cref="DownloadTidsRequest"/></param>
        /// <returns><see cref="DownloadTidsResponse"/></returns>
        public Task<DownloadTidsResponse> DownloadTids(DownloadTidsRequest req)
        {
            return InternalRequestAsync<DownloadTidsResponse>(req, "DownloadTids");
        }

        /// <summary>
        /// 下载芯片订单的TID 
        /// </summary>
        /// <param name="req"><see cref="DownloadTidsRequest"/></param>
        /// <returns><see cref="DownloadTidsResponse"/></returns>
        public DownloadTidsResponse DownloadTidsSync(DownloadTidsRequest req)
        {
            return InternalRequestAsync<DownloadTidsResponse>(req, "DownloadTids")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传硬件唯一标识码，是软加固设备身份参数。本接口如遇到错误数据，则所有当次上传数据失效。
        /// </summary>
        /// <param name="req"><see cref="UploadDeviceUniqueCodeRequest"/></param>
        /// <returns><see cref="UploadDeviceUniqueCodeResponse"/></returns>
        public Task<UploadDeviceUniqueCodeResponse> UploadDeviceUniqueCode(UploadDeviceUniqueCodeRequest req)
        {
            return InternalRequestAsync<UploadDeviceUniqueCodeResponse>(req, "UploadDeviceUniqueCode");
        }

        /// <summary>
        /// 上传硬件唯一标识码，是软加固设备身份参数。本接口如遇到错误数据，则所有当次上传数据失效。
        /// </summary>
        /// <param name="req"><see cref="UploadDeviceUniqueCodeRequest"/></param>
        /// <returns><see cref="UploadDeviceUniqueCodeResponse"/></returns>
        public UploadDeviceUniqueCodeResponse UploadDeviceUniqueCodeSync(UploadDeviceUniqueCodeRequest req)
        {
            return InternalRequestAsync<UploadDeviceUniqueCodeResponse>(req, "UploadDeviceUniqueCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下载控制台验证芯片烧录信息，保证TID与中心信息一致 
        /// </summary>
        /// <param name="req"><see cref="VerifyChipBurnInfoRequest"/></param>
        /// <returns><see cref="VerifyChipBurnInfoResponse"/></returns>
        public Task<VerifyChipBurnInfoResponse> VerifyChipBurnInfo(VerifyChipBurnInfoRequest req)
        {
            return InternalRequestAsync<VerifyChipBurnInfoResponse>(req, "VerifyChipBurnInfo");
        }

        /// <summary>
        /// 下载控制台验证芯片烧录信息，保证TID与中心信息一致 
        /// </summary>
        /// <param name="req"><see cref="VerifyChipBurnInfoRequest"/></param>
        /// <returns><see cref="VerifyChipBurnInfoResponse"/></returns>
        public VerifyChipBurnInfoResponse VerifyChipBurnInfoSync(VerifyChipBurnInfoRequest req)
        {
            return InternalRequestAsync<VerifyChipBurnInfoResponse>(req, "VerifyChipBurnInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
