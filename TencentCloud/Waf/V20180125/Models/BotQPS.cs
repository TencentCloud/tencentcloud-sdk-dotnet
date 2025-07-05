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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BotQPS : AbstractModel
    {
        
        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("ResourceIds")]
        public string ResourceIds{ get; set; }

        /// <summary>
        /// 有效时间
        /// </summary>
        [JsonProperty("ValidTime")]
        public string ValidTime{ get; set; }

        /// <summary>
        /// 资源数量
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 资源所在地区
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 使用qps的最大值
        /// </summary>
        [JsonProperty("MaxBotQPS")]
        public ulong? MaxBotQPS{ get; set; }

        /// <summary>
        /// 续费标志
        /// </summary>
        [JsonProperty("RenewFlag")]
        public ulong? RenewFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceIds", this.ResourceIds);
            this.SetParamSimple(map, prefix + "ValidTime", this.ValidTime);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "MaxBotQPS", this.MaxBotQPS);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
        }
    }
}

