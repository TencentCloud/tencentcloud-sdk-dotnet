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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnableScheduleOperationDuration : AbstractModel
    {
        
        /// <summary>
        /// 支持开启异步任务的日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Periods")]
        public string[] Periods{ get; set; }

        /// <summary>
        /// 支持开启异步的开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeStart")]
        public string TimeStart{ get; set; }

        /// <summary>
        /// 支持开启异步的结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeEnd")]
        public string TimeEnd{ get; set; }

        /// <summary>
        /// 支持开启异步的时区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Periods.", this.Periods);
            this.SetParamSimple(map, prefix + "TimeStart", this.TimeStart);
            this.SetParamSimple(map, prefix + "TimeEnd", this.TimeEnd);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
        }
    }
}

