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

    public class ResponseSpeedLimitParameters : AbstractModel
    {
        
        /// <summary>
        /// 下载限速模式，取值有：
        /// <li>LimitUponDownload：全过程下载限速；</li>
        /// <li>LimitAfterSpecificBytesDownloaded：全速下载特定字节后开始限速；</li>
        /// <li>LimitAfterSpecificSecondsDownloaded：全速下载特定时间后开始限速。</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 限速值，指定限速大小，填写含单位的数值或变量。当前支持单位有：KB/s。
        /// </summary>
        [JsonProperty("MaxSpeed")]
        public string MaxSpeed{ get; set; }

        /// <summary>
        /// 限速开始值，可以为下载大小或指定时长，填写含单位的数值或变量，指定下载大小或指定时长。
        /// 
        /// - 当Mode 取值为 LimitAfterSpecificBytesDownloaded 时，单位取值有： KB；
        /// 
        /// - 当Mode 取值为 LimitAfterSpecificSecondsDownloaded 时，单位取值有： s。
        /// </summary>
        [JsonProperty("StartAt")]
        public string StartAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "MaxSpeed", this.MaxSpeed);
            this.SetParamSimple(map, prefix + "StartAt", this.StartAt);
        }
    }
}

