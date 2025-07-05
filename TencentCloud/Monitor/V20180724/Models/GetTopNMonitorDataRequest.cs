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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetTopNMonitorDataRequest : AbstractModel
    {
        
        /// <summary>
        /// topN
        /// </summary>
        [JsonProperty("N")]
        public ulong? N{ get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 实例对象的维度组合，格式为key-value键值对形式的集合。不同类型的实例字段完全不同，如CVM为[{"Name":"InstanceId","Value":"ins-j0hk02zo"}]，Ckafka为[{"Name":"instanceId","Value":"ckafka-l49k54dd"}]，COS为[{"Name":"appid","Value":"1258344699"},{"Name":"bucket","Value":"rig-1258344699"}]。各个云产品的维度请参阅各个产品监控指标文档，对应的维度列即为维度组合的key，value为key对应的值。单请求最多支持批量拉取50个实例的监控数据。
        /// </summary>
        [JsonProperty("Instances")]
        public Instance[] Instances{ get; set; }

        /// <summary>
        /// 指标名称，如Bwpresourcebandwidthin，仅支持单指标拉取。各个云产品的详细指标说明请参阅各个产品监控指标文档，对应的指标英文名即为MetricName
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 命名空间，如QCE/CVM。各个云产品的详细命名空间说明请参阅各个产品监控指标文档
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 监控统计周期，如60。默认为取值为60，单位为s。每个指标支持的统计周期不一定相同，各个云产品支持的统计周期请参阅各个产品监控指标文档，对应的统计周期列即为支持的统计周期。
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "N", this.N);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "Instances.", this.Instances);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Period", this.Period);
        }
    }
}

