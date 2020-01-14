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

namespace TencentCloud.Tics.V20181115
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tics.V20181115.Models;

   public class TicsClient : AbstractClient{

       private const string endpoint = "tics.tencentcloudapi.com";
       private const string version = "2018-11-15";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TicsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TicsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 提供域名相关的基础信息以及与攻击事件（团伙、家族）、恶意文件等相关联信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainInfoResponse"/></returns>
        public async Task<DescribeDomainInfoResponse> DescribeDomainInfo(DescribeDomainInfoRequest req)
        {
             JsonResponseModel<DescribeDomainInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDomainInfo接口的同步版本，提供域名相关的基础信息以及与攻击事件（团伙、家族）、恶意文件等相关联信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDomainInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeDomainInfoResponse"/>实例</returns>
        public DescribeDomainInfoResponse DescribeDomainInfoSync(DescribeDomainInfoRequest req)
        {
             JsonResponseModel<DescribeDomainInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供文件相关的基础信息以及与攻击事件（团伙、家族）、恶意文件等相关联信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileInfoRequest"/></param>
        /// <returns><see cref="DescribeFileInfoResponse"/></returns>
        public async Task<DescribeFileInfoResponse> DescribeFileInfo(DescribeFileInfoRequest req)
        {
             JsonResponseModel<DescribeFileInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeFileInfo接口的同步版本，提供文件相关的基础信息以及与攻击事件（团伙、家族）、恶意文件等相关联信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeFileInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeFileInfoResponse"/>实例</returns>
        public DescribeFileInfoResponse DescribeFileInfoSync(DescribeFileInfoRequest req)
        {
             JsonResponseModel<DescribeFileInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供IP相关的基础信息以及与攻击事件（团伙、家族）、恶意文件等相关联信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeIpInfoRequest"/></param>
        /// <returns><see cref="DescribeIpInfoResponse"/></returns>
        public async Task<DescribeIpInfoResponse> DescribeIpInfo(DescribeIpInfoRequest req)
        {
             JsonResponseModel<DescribeIpInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeIpInfo接口的同步版本，提供IP相关的基础信息以及与攻击事件（团伙、家族）、恶意文件等相关联信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeIpInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeIpInfoResponse"/>实例</returns>
        public DescribeIpInfoResponse DescribeIpInfoSync(DescribeIpInfoRequest req)
        {
             JsonResponseModel<DescribeIpInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供IP和域名相关威胁情报信息查询，这些信息可以辅助检测失陷主机、帮助SIEM/SOC等系统做研判决策、帮助运营团队对设备报警的编排处理。
        /// </summary>
        /// <param name="req"><see cref="DescribeThreatInfoRequest"/></param>
        /// <returns><see cref="DescribeThreatInfoResponse"/></returns>
        public async Task<DescribeThreatInfoResponse> DescribeThreatInfo(DescribeThreatInfoRequest req)
        {
             JsonResponseModel<DescribeThreatInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeThreatInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeThreatInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeThreatInfo接口的同步版本，提供IP和域名相关威胁情报信息查询，这些信息可以辅助检测失陷主机、帮助SIEM/SOC等系统做研判决策、帮助运营团队对设备报警的编排处理。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeThreatInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeThreatInfoResponse"/>实例</returns>
        public DescribeThreatInfoResponse DescribeThreatInfoSync(DescribeThreatInfoRequest req)
        {
             JsonResponseModel<DescribeThreatInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeThreatInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeThreatInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
