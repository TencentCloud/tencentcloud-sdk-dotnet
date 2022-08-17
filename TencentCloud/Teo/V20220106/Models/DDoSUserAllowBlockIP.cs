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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSUserAllowBlockIP : AbstractModel
    {
        
        /// <summary>
        /// 客户端IP。
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 掩码。
        /// </summary>
        [JsonProperty("Mask")]
        public long? Mask{ get; set; }

        /// <summary>
        /// 类型，取值有：
        /// <li>block ：丢弃 ；</li>
        /// <li>allow ：允许。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 10位时间戳，例如1199116800。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// 客户端IP2，设置IP范围时使用，例如 1.1.1.1-1.1.1.2。
        /// </summary>
        [JsonProperty("Ip2")]
        public string Ip2{ get; set; }

        /// <summary>
        /// 掩码2，设置IP网段范围时使用，例如 1.1.1.0/24-1.1.2.0/24。
        /// </summary>
        [JsonProperty("Mask2")]
        public long? Mask2{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Mask", this.Mask);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Ip2", this.Ip2);
            this.SetParamSimple(map, prefix + "Mask2", this.Mask2);
        }
    }
}

