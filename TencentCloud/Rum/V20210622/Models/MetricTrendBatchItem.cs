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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricTrendBatchItem : AbstractModel
    {
        
        /// <summary>
        /// <p>条目 Key</p>
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// <p>主窗时序</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Series")]
        public MetricTrendPoint[] Series{ get; set; }

        /// <summary>
        /// <p>对比窗时序</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompareSeries")]
        public MetricTrendPoint[] CompareSeries{ get; set; }

        /// <summary>
        /// <p>可能尚未采集，false 时省略</p>
        /// </summary>
        [JsonProperty("MaybeUncollected")]
        public bool? MaybeUncollected{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamArrayObj(map, prefix + "Series.", this.Series);
            this.SetParamArrayObj(map, prefix + "CompareSeries.", this.CompareSeries);
            this.SetParamSimple(map, prefix + "MaybeUncollected", this.MaybeUncollected);
        }
    }
}

