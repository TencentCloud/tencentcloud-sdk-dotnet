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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCcDataResponse : AbstractModel
    {
        
        /// <summary>
        /// 指定执行动作的请求数数据，如果指定类型为空，表示所有类型的请求总数
        /// </summary>
        [JsonProperty("Data")]
        public TimestampData[] Data{ get; set; }

        /// <summary>
        /// 粒度
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// 执行动作为拦截类型QPS统计数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InterceptQpsData")]
        public TimestampData[] InterceptQpsData{ get; set; }

        /// <summary>
        /// 执行动作为重定向类型QPS统计数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RedirectQpsData")]
        public TimestampData[] RedirectQpsData{ get; set; }

        /// <summary>
        /// 执行动作为观察类型QPS统计数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObserveQpsData")]
        public TimestampData[] ObserveQpsData{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamArrayObj(map, prefix + "InterceptQpsData.", this.InterceptQpsData);
            this.SetParamArrayObj(map, prefix + "RedirectQpsData.", this.RedirectQpsData);
            this.SetParamArrayObj(map, prefix + "ObserveQpsData.", this.ObserveQpsData);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

