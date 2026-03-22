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

    public class OpenClawServiceResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>日志集id</p><p><a href="https://cloud.tencent.com/document/product/614/41034">日志集文档</a></p>
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// <p>日志集名称</p>
        /// </summary>
        [JsonProperty("LogsetName")]
        public string LogsetName{ get; set; }

        /// <summary>
        /// <p>日志主题id</p><p><a href="https://cloud.tencent.com/document/product/614/41035">日志主题文档</a></p>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>日志主题名称</p>
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// <p>指标主题id</p><p><a href="https://cloud.tencent.com/document/product/614/90328">指标主题文档</a></p>
        /// </summary>
        [JsonProperty("MetricTopicId")]
        public string MetricTopicId{ get; set; }

        /// <summary>
        /// <p>指标主题名称</p>
        /// </summary>
        [JsonProperty("MetricTopicName")]
        public string MetricTopicName{ get; set; }

        /// <summary>
        /// <p>机器组id</p><p><a href="https://cloud.tencent.com/document/product/614/17412">机器组文档</a></p>
        /// </summary>
        [JsonProperty("MachineGroupId")]
        public string MachineGroupId{ get; set; }

        /// <summary>
        /// <p>机器组名称</p>
        /// </summary>
        [JsonProperty("MachineGroupName")]
        public string MachineGroupName{ get; set; }

        /// <summary>
        /// <p>采集配置id。应用日志</p><p><a href="https://cloud.tencent.com/document/product/614/33494">采集概述文档</a> - <a href="https://cloud.tencent.com/document/product/614/57497">LogListener 采集配置导入</a></p>
        /// </summary>
        [JsonProperty("AppLogConfigId")]
        public string AppLogConfigId{ get; set; }

        /// <summary>
        /// <p>采集配置名称。应用日志</p>
        /// </summary>
        [JsonProperty("AppLogConfigName")]
        public string AppLogConfigName{ get; set; }

        /// <summary>
        /// <p>采集配置id。会话日志</p><p><a href="https://cloud.tencent.com/document/product/614/33494">采集概述文档</a> - <a href="https://cloud.tencent.com/document/product/614/57497">LogListener 采集配置导入</a></p>
        /// </summary>
        [JsonProperty("SessionLogConfigId")]
        public string SessionLogConfigId{ get; set; }

        /// <summary>
        /// <p>采集配置名称。会话日志</p>
        /// </summary>
        [JsonProperty("SessionLogConfigName")]
        public string SessionLogConfigName{ get; set; }

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
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "LogsetName", this.LogsetName);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "MetricTopicId", this.MetricTopicId);
            this.SetParamSimple(map, prefix + "MetricTopicName", this.MetricTopicName);
            this.SetParamSimple(map, prefix + "MachineGroupId", this.MachineGroupId);
            this.SetParamSimple(map, prefix + "MachineGroupName", this.MachineGroupName);
            this.SetParamSimple(map, prefix + "AppLogConfigId", this.AppLogConfigId);
            this.SetParamSimple(map, prefix + "AppLogConfigName", this.AppLogConfigName);
            this.SetParamSimple(map, prefix + "SessionLogConfigId", this.SessionLogConfigId);
            this.SetParamSimple(map, prefix + "SessionLogConfigName", this.SessionLogConfigName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

