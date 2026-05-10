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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRecordingRuleYamlTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>源指标主题id</p><p>取值参考：</p><ul><li><a href="https://cloud.tencent.com/document/api/614/56454">DescribeTopics</a></li><li><a href="https://console.cloud.tencent.com/cls/metric">指标主题</a></li></ul>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>目标指标主题id，可与 TopicId 相同</p>
        /// </summary>
        [JsonProperty("DstTopicId")]
        public string DstTopicId{ get; set; }

        /// <summary>
        /// <p>任务状态； 1:开启；2:关闭</p>
        /// </summary>
        [JsonProperty("EnableFlag")]
        public ulong? EnableFlag{ get; set; }

        /// <summary>
        /// <p>任务执行开始时间 ,Unix时间戳</p><p>单位：ms</p>
        /// </summary>
        [JsonProperty("ProcessStartTime")]
        public ulong? ProcessStartTime{ get; set; }

        /// <summary>
        /// <p>调度周期(分钟)，支持范围(0,1440]分钟。</p><p>单位：分钟</p><p>也可在YAML中使用 interval: duration 为每个group单独设置执行间隔</p>
        /// </summary>
        [JsonProperty("ProcessPeriod")]
        public long? ProcessPeriod{ get; set; }

        /// <summary>
        /// <p>执行延迟，建议设置为30秒，避免指标上报延迟导致预聚合任务计算结果不精确</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("ProcessDelay")]
        public long? ProcessDelay{ get; set; }

        /// <summary>
        /// <p>yaml配置名称</p>
        /// </summary>
        [JsonProperty("YamlConfigName")]
        public string YamlConfigName{ get; set; }

        /// <summary>
        /// <p>yaml配置内容</p><p>兼容 Prometheus Recording Rules 配置文件，API调用时请注意字符串中的换行与缩进。</p>
        /// </summary>
        [JsonProperty("YamlContent")]
        public string YamlContent{ get; set; }

        /// <summary>
        /// <p>是否开启投递服务日志。1：关闭，2：开启。</p>
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "DstTopicId", this.DstTopicId);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamSimple(map, prefix + "ProcessStartTime", this.ProcessStartTime);
            this.SetParamSimple(map, prefix + "ProcessPeriod", this.ProcessPeriod);
            this.SetParamSimple(map, prefix + "ProcessDelay", this.ProcessDelay);
            this.SetParamSimple(map, prefix + "YamlConfigName", this.YamlConfigName);
            this.SetParamSimple(map, prefix + "YamlContent", this.YamlContent);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
        }
    }
}

