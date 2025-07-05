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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GridInfo : AbstractModel
    {
        
        /// <summary>
        /// DeployGridId
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Key
        /// </summary>
        [JsonProperty("GridUniqKey")]
        public string GridUniqKey{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 工作负载类型
        /// </summary>
        [JsonProperty("WorkloadKind")]
        public string WorkloadKind{ get; set; }

        /// <summary>
        /// 启动时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 副本数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("Publisher")]
        public string Publisher{ get; set; }

        /// <summary>
        /// 版本信息
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "GridUniqKey", this.GridUniqKey);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "WorkloadKind", this.WorkloadKind);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamSimple(map, prefix + "Publisher", this.Publisher);
            this.SetParamSimple(map, prefix + "Version", this.Version);
        }
    }
}

