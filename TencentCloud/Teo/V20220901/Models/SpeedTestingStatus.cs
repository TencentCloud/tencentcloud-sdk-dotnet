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

    public class SpeedTestingStatus : AbstractModel
    {
        
        /// <summary>
        /// 拨测 url。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 拨测 url 是否使用 https。
        /// </summary>
        [JsonProperty("Tls")]
        public bool? Tls{ get; set; }

        /// <summary>
        /// 任务创建时间。
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 任务状态，取值有：
        /// <li> 200：任务完成;</li>
        /// <li> 100：任务进行中。</li>
        /// <li> 503: 任务失败。</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// 拨测 UA。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UA")]
        public string UA{ get; set; }

        /// <summary>
        /// 网络环境。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Connectivity")]
        public string Connectivity{ get; set; }

        /// <summary>
        /// 是否可达，取值：
        /// <li> true：可达；</li>
        /// <li> false：不可达。</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Reachable")]
        public bool? Reachable{ get; set; }

        /// <summary>
        /// 是否超时，取值：
        /// <li> true：超时；</li>
        /// <li> false：不超时。</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimedOut")]
        public bool? TimedOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Tls", this.Tls);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "UA", this.UA);
            this.SetParamSimple(map, prefix + "Connectivity", this.Connectivity);
            this.SetParamSimple(map, prefix + "Reachable", this.Reachable);
            this.SetParamSimple(map, prefix + "TimedOut", this.TimedOut);
        }
    }
}

