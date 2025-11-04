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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrivateNatDestinationIpPortTranslationNatRule : AbstractModel
    {
        
        /// <summary>
        /// 协议
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 映射前端口
        /// </summary>
        [JsonProperty("OriginalPort")]
        public long? OriginalPort{ get; set; }

        /// <summary>
        /// 映射前IP
        /// </summary>
        [JsonProperty("OriginalIp")]
        public string OriginalIp{ get; set; }

        /// <summary>
        /// 映射后端口
        /// </summary>
        [JsonProperty("TranslationPort")]
        public long? TranslationPort{ get; set; }

        /// <summary>
        /// 映射后IP
        /// </summary>
        [JsonProperty("TranslationIp")]
        public string TranslationIp{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


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
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

