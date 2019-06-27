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

namespace TencentCloud.Gme.V20180711
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gme.V20180711.Models;

   public class GmeClient : AbstractClient{

       private const string endpoint = "gme.tencentcloudapi.com";
       private const string version = "2018-07-11";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public GmeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public GmeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 根据日期查询识别结果列表，按分页反回
        /// </summary>
        /// <param name="req">参考<see cref="DescribeFilterResultListRequest"/></param>
        /// <returns>参考<see cref="DescribeFilterResultListResponse"/>实例</returns>
        public async Task<DescribeFilterResultListResponse> DescribeFilterResultList(DescribeFilterResultListRequest req)
        {
             JsonResponseModel<DescribeFilterResultListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFilterResultList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFilterResultListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于识别涉黄、涉政、涉恐等违规音频，成功会回调配置在应用的回调地址。回调示例如下：
        /// {"BizId":0,"FileId":"test_file_id","FileName":"test_file_name","TimeStamp":"0000-00-00 00:00:00","Data":[{"Type":1,"Word":"xx"}]}
        /// </summary>
        /// <param name="req">参考<see cref="VoiceFilterRequest"/></param>
        /// <returns>参考<see cref="VoiceFilterResponse"/>实例</returns>
        public async Task<VoiceFilterResponse> VoiceFilter(VoiceFilterRequest req)
        {
             JsonResponseModel<VoiceFilterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VoiceFilter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VoiceFilterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
