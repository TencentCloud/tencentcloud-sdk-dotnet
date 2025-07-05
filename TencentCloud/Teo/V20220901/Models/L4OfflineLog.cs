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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class L4OfflineLog : AbstractModel
    {
        
        /// <summary>
        /// 四层代理实例 ID。
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 日志所属区域，取值有：
        /// <li>mainland：中国大陆境内;</li>
        /// <li>overseas：全球（不含中国大陆）。</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 离线日志数据包名。
        /// </summary>
        [JsonProperty("LogPacketName")]
        public string LogPacketName{ get; set; }

        /// <summary>
        /// 离线日志下载地址。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 日志打包时间，此参数已经废弃。
        /// </summary>
        [JsonProperty("LogTime")]
        public long? LogTime{ get; set; }

        /// <summary>
        /// 日志打包开始时间。
        /// </summary>
        [JsonProperty("LogStartTime")]
        public string LogStartTime{ get; set; }

        /// <summary>
        /// 日志打包结束时间。
        /// </summary>
        [JsonProperty("LogEndTime")]
        public string LogEndTime{ get; set; }

        /// <summary>
        /// 日志大小，单位为 Byte。
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "LogPacketName", this.LogPacketName);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "LogTime", this.LogTime);
            this.SetParamSimple(map, prefix + "LogStartTime", this.LogStartTime);
            this.SetParamSimple(map, prefix + "LogEndTime", this.LogEndTime);
            this.SetParamSimple(map, prefix + "Size", this.Size);
        }
    }
}

