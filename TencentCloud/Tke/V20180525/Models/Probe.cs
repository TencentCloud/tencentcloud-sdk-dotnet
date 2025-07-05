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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Probe : AbstractModel
    {
        
        /// <summary>
        /// Minimum consecutive failures for the probe to be considered failed after having succeeded.Defaults to 3. Minimum value is 1.
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailureThreshold")]
        public long? FailureThreshold{ get; set; }

        /// <summary>
        /// Number of seconds after the container has started before liveness probes are initiated.
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InitialDelaySeconds")]
        public long? InitialDelaySeconds{ get; set; }

        /// <summary>
        /// How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PeriodSeconds")]
        public long? PeriodSeconds{ get; set; }

        /// <summary>
        /// Minimum consecutive successes for the probe to be considered successful after having failed.Defaults to 1. Must be 1 for liveness. Minimum value is 1.
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessThreshold")]
        public long? SuccessThreshold{ get; set; }

        /// <summary>
        /// Number of seconds after which the probe times out.
        /// Defaults to 1 second. Minimum value is 1.
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeoutSeconds")]
        public long? TimeoutSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FailureThreshold", this.FailureThreshold);
            this.SetParamSimple(map, prefix + "InitialDelaySeconds", this.InitialDelaySeconds);
            this.SetParamSimple(map, prefix + "PeriodSeconds", this.PeriodSeconds);
            this.SetParamSimple(map, prefix + "SuccessThreshold", this.SuccessThreshold);
            this.SetParamSimple(map, prefix + "TimeoutSeconds", this.TimeoutSeconds);
        }
    }
}

