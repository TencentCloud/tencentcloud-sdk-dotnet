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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReplayInstanceAuditLogRequest : AbstractModel
    {
        
        /// <summary>
        /// 源集群id
        /// </summary>
        [JsonProperty("SourceClusterId")]
        public string SourceClusterId{ get; set; }

        /// <summary>
        /// 源实例id
        /// </summary>
        [JsonProperty("SourceInstanceId")]
        public string SourceInstanceId{ get; set; }

        /// <summary>
        /// 目标集群id
        /// 目标集群必须为原始集群三天内克隆出的集群。
        /// </summary>
        [JsonProperty("TargetClusterId")]
        public string TargetClusterId{ get; set; }

        /// <summary>
        /// 目标实例id
        /// </summary>
        [JsonProperty("TargetInstanceId")]
        public string TargetInstanceId{ get; set; }

        /// <summary>
        /// 用户名.需要host为%的用户名
        /// </summary>
        [JsonProperty("TargetUserName")]
        public string TargetUserName{ get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [JsonProperty("TargetPassword")]
        public string TargetPassword{ get; set; }

        /// <summary>
        /// 开始时间。时间格式为：yyyy-DD-mm hh:mm:ss
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间。时间格式为：yyyy-DD-mm hh:mm:ss
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceClusterId", this.SourceClusterId);
            this.SetParamSimple(map, prefix + "SourceInstanceId", this.SourceInstanceId);
            this.SetParamSimple(map, prefix + "TargetClusterId", this.TargetClusterId);
            this.SetParamSimple(map, prefix + "TargetInstanceId", this.TargetInstanceId);
            this.SetParamSimple(map, prefix + "TargetUserName", this.TargetUserName);
            this.SetParamSimple(map, prefix + "TargetPassword", this.TargetPassword);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

