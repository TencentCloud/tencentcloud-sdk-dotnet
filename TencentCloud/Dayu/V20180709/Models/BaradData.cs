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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaradData : AbstractModel
    {
        
        /// <summary>
        /// 指标名（connum表示TCP活跃连接数；
        /// new_conn表示新建TCP连接数；
        /// inactive_conn表示非活跃连接数;
        /// intraffic表示入流量；
        /// outtraffic表示出流量；
        /// alltraffic表示出流量和入流量之和；
        /// inpkg表示入包速率；
        /// outpkg表示出包速率；）
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 值数组
        /// </summary>
        [JsonProperty("Data")]
        public float?[] Data{ get; set; }

        /// <summary>
        /// 值数组的大小
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamArraySimple(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "Count", this.Count);
        }
    }
}

