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

namespace TencentCloud.Habo.V20181203
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Habo.V20181203.Models;

   public class HaboClient : AbstractClient{

       private const string endpoint = "habo.tencentcloudapi.com";
       private const string version = "2018-12-03";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public HaboClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public HaboClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 查询指定md5样本是否分析完成，并获取分析日志下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeStatusRequest"/></param>
        /// <returns><see cref="DescribeStatusResponse"/></returns>
        public async Task<DescribeStatusResponse> DescribeStatus(DescribeStatusRequest req)
        {
             JsonResponseModel<DescribeStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeStatus接口的同步版本，查询指定md5样本是否分析完成，并获取分析日志下载地址。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeStatusRequest"/></param>
        /// <returns>参考<see cref="DescribeStatusResponse"/>实例</returns>
        public DescribeStatusResponse DescribeStatusSync(DescribeStatusRequest req)
        {
             JsonResponseModel<DescribeStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传样本到哈勃进行分析，异步生成分析日志。
        /// </summary>
        /// <param name="req"><see cref="StartAnalyseRequest"/></param>
        /// <returns><see cref="StartAnalyseResponse"/></returns>
        public async Task<StartAnalyseResponse> StartAnalyse(StartAnalyseRequest req)
        {
             JsonResponseModel<StartAnalyseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartAnalyse");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartAnalyseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StartAnalyse接口的同步版本，上传样本到哈勃进行分析，异步生成分析日志。
        /// </summary>
        /// <param name="req">参考<see cref="StartAnalyseRequest"/></param>
        /// <returns>参考<see cref="StartAnalyseResponse"/>实例</returns>
        public StartAnalyseResponse StartAnalyseSync(StartAnalyseRequest req)
        {
             JsonResponseModel<StartAnalyseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartAnalyse");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartAnalyseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
