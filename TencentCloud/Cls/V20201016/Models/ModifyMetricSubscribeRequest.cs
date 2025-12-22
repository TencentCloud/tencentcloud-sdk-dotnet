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

    public class ModifyMetricSubscribeRequest : AbstractModel
    {
        
        /// <summary>
        /// 指标采集任务的日志主题id。必填字段
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 指标采集任务id。必填字段
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 名称：长度不超过64字符，以字母开头，接受0-9,a-z,A-Z, _,-,中文字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 云产品命名空间。
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 指标配置信息。
        /// </summary>
        [JsonProperty("Metrics")]
        public MetricConfig[] Metrics{ get; set; }

        /// <summary>
        /// 实例配置信息。
        /// </summary>
        [JsonProperty("InstanceInfo")]
        public InstanceConfig InstanceInfo{ get; set; }

        /// <summary>
        /// 任务状态。
        /// 
        /// 1： 未启用
        /// 
        /// 2： 启用
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamArrayObj(map, prefix + "Metrics.", this.Metrics);
            this.SetParamObj(map, prefix + "InstanceInfo.", this.InstanceInfo);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
        }
    }
}

