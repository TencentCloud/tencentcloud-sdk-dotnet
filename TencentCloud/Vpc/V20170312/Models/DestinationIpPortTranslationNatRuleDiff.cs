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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DestinationIpPortTranslationNatRuleDiff : AbstractModel
    {
        
        /// <summary>
        /// 协议
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 源端口
        /// </summary>
        [JsonProperty("OriginalPort")]
        public long? OriginalPort{ get; set; }

        /// <summary>
        /// 源IP
        /// </summary>
        [JsonProperty("OriginalIp")]
        public string OriginalIp{ get; set; }

        /// <summary>
        /// 目的端口
        /// </summary>
        [JsonProperty("TranslationPort")]
        public long? TranslationPort{ get; set; }

        /// <summary>
        /// 目的IP
        /// </summary>
        [JsonProperty("TranslationIp")]
        public string TranslationIp{ get; set; }

        /// <summary>
        /// 旧协议。
        /// </summary>
        [JsonProperty("OldProtocol")]
        public string OldProtocol{ get; set; }

        /// <summary>
        /// 旧源端口
        /// </summary>
        [JsonProperty("OldOriginalPort")]
        public long? OldOriginalPort{ get; set; }

        /// <summary>
        /// 旧源IP
        /// </summary>
        [JsonProperty("OldOriginalIp")]
        public string OldOriginalIp{ get; set; }

        /// <summary>
        /// 旧目的端口
        /// </summary>
        [JsonProperty("OldTranslationPort")]
        public long? OldTranslationPort{ get; set; }

        /// <summary>
        /// 旧目的IP
        /// </summary>
        [JsonProperty("OldTranslationIp")]
        public string OldTranslationIp{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "OriginalPort", this.OriginalPort);
            this.SetParamSimple(map, prefix + "OriginalIp", this.OriginalIp);
            this.SetParamSimple(map, prefix + "TranslationPort", this.TranslationPort);
            this.SetParamSimple(map, prefix + "TranslationIp", this.TranslationIp);
            this.SetParamSimple(map, prefix + "OldProtocol", this.OldProtocol);
            this.SetParamSimple(map, prefix + "OldOriginalPort", this.OldOriginalPort);
            this.SetParamSimple(map, prefix + "OldOriginalIp", this.OldOriginalIp);
            this.SetParamSimple(map, prefix + "OldTranslationPort", this.OldTranslationPort);
            this.SetParamSimple(map, prefix + "OldTranslationIp", this.OldTranslationIp);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

