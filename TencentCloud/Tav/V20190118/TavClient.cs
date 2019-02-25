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

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public TavClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public TavClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 获取TAV本地引擎
        /// </summary>
        /// <param name="req">参考<see cref="GetLocalEngineRequest"/></param>
        /// <returns>参考<see cref="GetLocalEngineResponse"/>实例</returns>
        public async Task<GetLocalEngineResponse> GetLocalEngine(GetLocalEngineRequest req)
        {
             JsonResponseModel<GetLocalEngineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetLocalEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLocalEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// tav文件上传扫描结果查询
        /// </summary>
        /// <param name="req">参考<see cref="GetScanResultRequest"/></param>
        /// <returns>参考<see cref="GetScanResultResponse"/>实例</returns>
        public async Task<GetScanResultResponse> GetScanResult(GetScanResultRequest req)
        {
             JsonResponseModel<GetScanResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetScanResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetScanResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// tav文件上传扫描
        /// </summary>
        /// <param name="req">参考<see cref="ScanFileRequest"/></param>
        /// <returns>参考<see cref="ScanFileResponse"/>实例</returns>
        public async Task<ScanFileResponse> ScanFile(ScanFileRequest req)
        {
             JsonResponseModel<ScanFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScanFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过文件哈希值获取文件黑白属性
        /// </summary>
        /// <param name="req">参考<see cref="ScanFileHashRequest"/></param>
        /// <returns>参考<see cref="ScanFileHashResponse"/>实例</returns>
        public async Task<ScanFileHashResponse> ScanFileHash(ScanFileHashRequest req)
        {
             JsonResponseModel<ScanFileHashResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScanFileHash");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanFileHashResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
