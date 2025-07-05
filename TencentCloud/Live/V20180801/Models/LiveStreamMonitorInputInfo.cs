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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveStreamMonitorInputInfo : AbstractModel
    {
        
        /// <summary>
        /// 待监播的输入流名称。256字节以内，只允许包含字母、数字、‘-’，‘_’，'.'字符。
        /// </summary>
        [JsonProperty("InputStreamName")]
        public string InputStreamName{ get; set; }

        /// <summary>
        /// 待监播的输入流推流域名。128字节以内，只允许填处于启用状态的推流域名。
        /// </summary>
        [JsonProperty("InputDomain")]
        public string InputDomain{ get; set; }

        /// <summary>
        /// 待监播的输入流推流路径。32字节以内，只允许包含字母、数字、‘-’，‘_’，'.'字符。
        /// </summary>
        [JsonProperty("InputApp")]
        public string InputApp{ get; set; }

        /// <summary>
        /// 待监播的输入流推流url。一般场景下，无需该参数。
        /// </summary>
        [JsonProperty("InputUrl")]
        public string InputUrl{ get; set; }

        /// <summary>
        /// 描述。256字节以内。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 导播台输入源索引（10000 pvw， 10001 pgm， 其余代表输入下标）
        /// </summary>
        [JsonProperty("CasterInputIndex")]
        public ulong? CasterInputIndex{ get; set; }

        /// <summary>
        /// 该输入源是否正在监播
        /// </summary>
        [JsonProperty("NeedMonitor")]
        public bool? NeedMonitor{ get; set; }

        /// <summary>
        /// 导播台pvw pgm的cdn流id
        /// </summary>
        [JsonProperty("CdnStreamId")]
        public string CdnStreamId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputStreamName", this.InputStreamName);
            this.SetParamSimple(map, prefix + "InputDomain", this.InputDomain);
            this.SetParamSimple(map, prefix + "InputApp", this.InputApp);
            this.SetParamSimple(map, prefix + "InputUrl", this.InputUrl);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CasterInputIndex", this.CasterInputIndex);
            this.SetParamSimple(map, prefix + "NeedMonitor", this.NeedMonitor);
            this.SetParamSimple(map, prefix + "CdnStreamId", this.CdnStreamId);
        }
    }
}

