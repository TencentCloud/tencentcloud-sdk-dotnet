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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceParamRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 集群参数列表，例如 [{           "CurrentValue":"2",        "ParamName":"innodb_stats_transient_sample_pages"}]
        /// </summary>
        [JsonProperty("ClusterParamList")]
        public ModifyParamItem[] ClusterParamList{ get; set; }

        /// <summary>
        /// 实例参数列表，例如[{           "CurrentValue":"2",        "ParamName":"innodb_stats_transient_sample_pages"}]
        /// </summary>
        [JsonProperty("InstanceParamList")]
        public ModifyParamItem[] InstanceParamList{ get; set; }

        /// <summary>
        /// yes：在运维时间窗内修改，no：立即执行（默认值）
        /// </summary>
        [JsonProperty("IsInMaintainPeriod")]
        public string IsInMaintainPeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArrayObj(map, prefix + "ClusterParamList.", this.ClusterParamList);
            this.SetParamArrayObj(map, prefix + "InstanceParamList.", this.InstanceParamList);
            this.SetParamSimple(map, prefix + "IsInMaintainPeriod", this.IsInMaintainPeriod);
        }
    }
}

