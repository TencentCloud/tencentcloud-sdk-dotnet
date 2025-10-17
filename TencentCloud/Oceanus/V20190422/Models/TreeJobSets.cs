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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TreeJobSets : AbstractModel
    {
        
        /// <summary>
        /// 作业Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 作业名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 作业类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobType")]
        public long? JobType{ get; set; }

        /// <summary>
        /// 作业占用资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunningCu")]
        public float? RunningCu{ get; set; }

        /// <summary>
        /// 作业状态 启动或者停止或者暂停
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 0:代表没开启调优任务，1:开启智能调优，2:代表定时调优
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScalingType")]
        public long? ScalingType{ get; set; }

        /// <summary>
        /// RunningCpu
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunningCpu")]
        public float? RunningCpu{ get; set; }

        /// <summary>
        /// RunningMem
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunningMem")]
        public float? RunningMem{ get; set; }

        /// <summary>
        /// sql
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DecodeSqlCode")]
        public string DecodeSqlCode{ get; set; }

        /// <summary>
        /// 发布版本配置id
        /// </summary>
        [JsonProperty("PublishedJobConfigId")]
        public long? PublishedJobConfigId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamSimple(map, prefix + "RunningCu", this.RunningCu);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ScalingType", this.ScalingType);
            this.SetParamSimple(map, prefix + "RunningCpu", this.RunningCpu);
            this.SetParamSimple(map, prefix + "RunningMem", this.RunningMem);
            this.SetParamSimple(map, prefix + "DecodeSqlCode", this.DecodeSqlCode);
            this.SetParamSimple(map, prefix + "PublishedJobConfigId", this.PublishedJobConfigId);
        }
    }
}

