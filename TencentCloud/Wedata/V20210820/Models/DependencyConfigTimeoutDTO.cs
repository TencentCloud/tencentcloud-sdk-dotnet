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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DependencyConfigTimeoutDTO : AbstractModel
    {
        
        /// <summary>
        /// 超时类型
        /// WAIT_TOTAL_TIMEOUT 等待总时长
        /// 
        /// RUNNING_TIMEOUT 运行时长
        /// 
        /// WAIT_TIME_POINT_TIMEOUT 等待超过配置时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeoutType")]
        public string TimeoutType{ get; set; }

        /// <summary>
        /// 超时时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeoutValue")]
        public long? TimeoutValue{ get; set; }

        /// <summary>
        /// 固定时间点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeoutPoint")]
        public string TimeoutPoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeoutType", this.TimeoutType);
            this.SetParamSimple(map, prefix + "TimeoutValue", this.TimeoutValue);
            this.SetParamSimple(map, prefix + "TimeoutPoint", this.TimeoutPoint);
        }
    }
}

