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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecoverBackUpJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("BackUpJobId")]
        public long? BackUpJobId{ get; set; }

        /// <summary>
        /// 恢复出来的新表副本数
        /// </summary>
        [JsonProperty("ReplicationNum")]
        public long? ReplicationNum{ get; set; }

        /// <summary>
        /// 恢复是否保持源表中的配置，1时表示保留源表中的配置
        /// </summary>
        [JsonProperty("ReserveSourceConfig")]
        public long? ReserveSourceConfig{ get; set; }

        /// <summary>
        /// 0默认 1cos恢复
        /// </summary>
        [JsonProperty("RecoverType")]
        public long? RecoverType{ get; set; }

        /// <summary>
        /// CosSourceInfo对象
        /// </summary>
        [JsonProperty("CosSourceInfo")]
        public CosSourceInfo CosSourceInfo{ get; set; }

        /// <summary>
        /// 0默认 1定期执行
        /// </summary>
        [JsonProperty("ScheduleType")]
        public long? ScheduleType{ get; set; }

        /// <summary>
        /// 年-月-日 时:分:秒
        /// </summary>
        [JsonProperty("NextTime")]
        public string NextTime{ get; set; }

        /// <summary>
        /// 调度名称
        /// </summary>
        [JsonProperty("ScheduleName")]
        public string ScheduleName{ get; set; }

        /// <summary>
        /// create update
        /// </summary>
        [JsonProperty("OperationType")]
        public string OperationType{ get; set; }

        /// <summary>
        /// 恢复粒度：All全量、Database按库、Table按表
        /// </summary>
        [JsonProperty("RecoverScope")]
        public string RecoverScope{ get; set; }

        /// <summary>
        /// 恢复库：如果是按库备份，则需要该字段，库之间用","分割
        /// </summary>
        [JsonProperty("RecoverDatabase")]
        public string RecoverDatabase{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackUpJobId", this.BackUpJobId);
            this.SetParamSimple(map, prefix + "ReplicationNum", this.ReplicationNum);
            this.SetParamSimple(map, prefix + "ReserveSourceConfig", this.ReserveSourceConfig);
            this.SetParamSimple(map, prefix + "RecoverType", this.RecoverType);
            this.SetParamObj(map, prefix + "CosSourceInfo.", this.CosSourceInfo);
            this.SetParamSimple(map, prefix + "ScheduleType", this.ScheduleType);
            this.SetParamSimple(map, prefix + "NextTime", this.NextTime);
            this.SetParamSimple(map, prefix + "ScheduleName", this.ScheduleName);
            this.SetParamSimple(map, prefix + "OperationType", this.OperationType);
            this.SetParamSimple(map, prefix + "RecoverScope", this.RecoverScope);
            this.SetParamSimple(map, prefix + "RecoverDatabase", this.RecoverDatabase);
        }
    }
}

