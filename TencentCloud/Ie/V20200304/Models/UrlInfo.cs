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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UrlInfo : AbstractModel
    {
        
        /// <summary>
        /// 视频 URL。
        /// 注意：编辑理解仅支持mp4、flv等格式的点播文件，不支持hls；
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 视频地址格式，可选值： 
        /// 0：音视频 ;
        /// 1：直播流。 
        /// 默认为0。其他非0非1值默认为0。画质重生任务只支持0。
        /// </summary>
        [JsonProperty("Format")]
        public long? Format{ get; set; }

        /// <summary>
        /// 【不再支持】指定请求资源时，HTTP头部host的值。
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Host", this.Host);
        }
    }
}

