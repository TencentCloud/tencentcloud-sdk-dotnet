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
        /// 限速值，单位为：KB/s，填写数值，指定限速大小。
        /// </summary>
        [JsonProperty("MaxSpeed")]
        public string MaxSpeed{ get; set; }

        /// <summary>
        /// 限速开始值，可以为下载大小或指定时长，单位为：KB或s，当 Mode 取值为 LimitAfterSpecificBytesDownloaded 或 LimitAfterSpecificSecondsDownloaded 时，该参数必填。填写数值，指定下载大小或指定时长。
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

