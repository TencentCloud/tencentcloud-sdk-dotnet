/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVideoDownloadUrlData : AbstractModel
    {
        
        /// <summary>
        /// 录像文件下载 URL
        /// 注意：
        /// URL 有效期是10分钟，过期后将拒绝访问，若需再用请重新获取 
        /// 录像文件下载采用分块传输编码，响应头Transfer-Encoding:chunked 
        /// 下载文件命名格式为{ChannelId}-{BeginTime}-{EndTime}.{FileType} 
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 实际下载录像的开始时间
        /// 注意：当请求中指定IsRespActualTime参数为true时，才有该字段
        /// </summary>
        [JsonProperty("ActualBeginTime")]
        public string ActualBeginTime{ get; set; }

        /// <summary>
        /// 实际下载录像的结束时间
        /// 注意：当请求中指定IsRespActualTime参数为true时，才有该字段
        /// </summary>
        [JsonProperty("ActualEndTime")]
        public string ActualEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "ActualBeginTime", this.ActualBeginTime);
            this.SetParamSimple(map, prefix + "ActualEndTime", this.ActualEndTime);
        }
    }
}

