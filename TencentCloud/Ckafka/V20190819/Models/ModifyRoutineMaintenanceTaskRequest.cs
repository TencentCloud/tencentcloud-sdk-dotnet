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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRoutineMaintenanceTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 自动化运维类别
        /// </summary>
        [JsonProperty("MaintenanceType")]
        public string MaintenanceType{ get; set; }

        /// <summary>
        /// INSTANCE_STORAGE_CAPACITY(磁盘自动扩容)/MESSAGE_RETENTION_PERIOD(磁盘动态消息保留策略)
        /// </summary>
        [JsonProperty("MaintenanceSubtype")]
        public string MaintenanceSubtype{ get; set; }

        /// <summary>
        /// 主题名
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 任务触发阈值
        /// </summary>
        [JsonProperty("ConfigureThreshold")]
        public long? ConfigureThreshold{ get; set; }

        /// <summary>
        /// 任务调整步长
        /// </summary>
        [JsonProperty("ConfigureStepSize")]
        public long? ConfigureStepSize{ get; set; }

        /// <summary>
        /// 任务调整上限
        /// </summary>
        [JsonProperty("ConfigureLimit")]
        public long? ConfigureLimit{ get; set; }

        /// <summary>
        /// 任务预期触发时间，存储从当日 0AM 开始偏移的秒数
        /// </summary>
        [JsonProperty("PlannedTime")]
        public long? PlannedTime{ get; set; }

        /// <summary>
        /// 任务额外信息
        /// </summary>
        [JsonProperty("ExtraConfig")]
        public string ExtraConfig{ get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 执行week day
        /// </summary>
        [JsonProperty("Week")]
        public string Week{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MaintenanceType", this.MaintenanceType);
            this.SetParamSimple(map, prefix + "MaintenanceSubtype", this.MaintenanceSubtype);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "ConfigureThreshold", this.ConfigureThreshold);
            this.SetParamSimple(map, prefix + "ConfigureStepSize", this.ConfigureStepSize);
            this.SetParamSimple(map, prefix + "ConfigureLimit", this.ConfigureLimit);
            this.SetParamSimple(map, prefix + "PlannedTime", this.PlannedTime);
            this.SetParamSimple(map, prefix + "ExtraConfig", this.ExtraConfig);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Week", this.Week);
        }
    }
}

