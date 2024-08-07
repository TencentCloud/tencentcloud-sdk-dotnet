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

namespace TencentCloud.Tav.V20190118
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tav.V20190118.Models;

   public class TavClient : AbstractClient{

       private const string endpoint = "tav.tencentcloudapi.com";
       private const string version = "2019-01-18";
       private const string sdkVersion = "SDK_NET_3.0.1064";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TavClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TavClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 获取TAV本地引擎
        /// </summary>
        /// <param name="req"><see cref="GetLocalEngineRequest"/></param>
        /// <returns><see cref="GetLocalEngineResponse"/></returns>
        public Task<GetLocalEngineResponse> GetLocalEngine(GetLocalEngineRequest req)
        {
            return InternalRequestAsync<GetLocalEngineResponse>(req, "GetLocalEngine");
        }

        /// <summary>
        /// 获取TAV本地引擎
        /// </summary>
        /// <param name="req"><see cref="GetLocalEngineRequest"/></param>
        /// <returns><see cref="GetLocalEngineResponse"/></returns>
        public GetLocalEngineResponse GetLocalEngineSync(GetLocalEngineRequest req)
        {
            return InternalRequestAsync<GetLocalEngineResponse>(req, "GetLocalEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// tav文件上传扫描结果查询
        /// </summary>
        /// <param name="req"><see cref="GetScanResultRequest"/></param>
        /// <returns><see cref="GetScanResultResponse"/></returns>
        public Task<GetScanResultResponse> GetScanResult(GetScanResultRequest req)
        {
            return InternalRequestAsync<GetScanResultResponse>(req, "GetScanResult");
        }

        /// <summary>
        /// tav文件上传扫描结果查询
        /// </summary>
        /// <param name="req"><see cref="GetScanResultRequest"/></param>
        /// <returns><see cref="GetScanResultResponse"/></returns>
        public GetScanResultResponse GetScanResultSync(GetScanResultRequest req)
        {
            return InternalRequestAsync<GetScanResultResponse>(req, "GetScanResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// tav文件上传扫描
        /// </summary>
        /// <param name="req"><see cref="ScanFileRequest"/></param>
        /// <returns><see cref="ScanFileResponse"/></returns>
        public Task<ScanFileResponse> ScanFile(ScanFileRequest req)
        {
            return InternalRequestAsync<ScanFileResponse>(req, "ScanFile");
        }

        /// <summary>
        /// tav文件上传扫描
        /// </summary>
        /// <param name="req"><see cref="ScanFileRequest"/></param>
        /// <returns><see cref="ScanFileResponse"/></returns>
        public ScanFileResponse ScanFileSync(ScanFileRequest req)
        {
            return InternalRequestAsync<ScanFileResponse>(req, "ScanFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过文件哈希值获取文件黑白属性
        /// </summary>
        /// <param name="req"><see cref="ScanFileHashRequest"/></param>
        /// <returns><see cref="ScanFileHashResponse"/></returns>
        public Task<ScanFileHashResponse> ScanFileHash(ScanFileHashRequest req)
        {
            return InternalRequestAsync<ScanFileHashResponse>(req, "ScanFileHash");
        }

        /// <summary>
        /// 通过文件哈希值获取文件黑白属性
        /// </summary>
        /// <param name="req"><see cref="ScanFileHashRequest"/></param>
        /// <returns><see cref="ScanFileHashResponse"/></returns>
        public ScanFileHashResponse ScanFileHashSync(ScanFileHashRequest req)
        {
            return InternalRequestAsync<ScanFileHashResponse>(req, "ScanFileHash")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
