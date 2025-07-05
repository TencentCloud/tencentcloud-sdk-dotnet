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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyReadOnlyGroupDetailsRequest : AbstractModel
    {
        
        /// <summary>
        /// 主实例ID，格式如：mssql-3l3fgqn7
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 只读组ID
        /// </summary>
        [JsonProperty("ReadOnlyGroupId")]
        public string ReadOnlyGroupId{ get; set; }

        /// <summary>
        /// 只读组名称，不填此参数，则不修改
        /// </summary>
        [JsonProperty("ReadOnlyGroupName")]
        public string ReadOnlyGroupName{ get; set; }

        /// <summary>
        /// 是否启动超时剔除功能,0-不开启剔除功能，1-开启剔除功能，不填此参数，则不修改
        /// </summary>
        [JsonProperty("IsOfflineDelay")]
        public long? IsOfflineDelay{ get; set; }

        /// <summary>
        /// 启动超时剔除功能后，使用的超时阈值，不填此参数，则不修改
        /// </summary>
        [JsonProperty("ReadOnlyMaxDelayTime")]
        public long? ReadOnlyMaxDelayTime{ get; set; }

        /// <summary>
        /// 启动超时剔除功能后，只读组至少保留的只读副本数，不填此参数，则不修改
        /// </summary>
        [JsonProperty("MinReadOnlyInGroup")]
        public long? MinReadOnlyInGroup{ get; set; }

        /// <summary>
        /// 只读组实例权重修改集合，不填此参数，则不修改
        /// </summary>
        [JsonProperty("WeightPairs")]
        public ReadOnlyInstanceWeightPair[] WeightPairs{ get; set; }

        /// <summary>
        /// 0-用户自定义权重（根据WeightPairs调整）,1-系统自动分配权重(WeightPairs无效)， 默认为0
        /// </summary>
        [JsonProperty("AutoWeight")]
        public long? AutoWeight{ get; set; }

        /// <summary>
        /// 0-不重新均衡负载，1-重新均衡负载，默认为0
        /// </summary>
        [JsonProperty("BalanceWeight")]
        public long? BalanceWeight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupId", this.ReadOnlyGroupId);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupName", this.ReadOnlyGroupName);
            this.SetParamSimple(map, prefix + "IsOfflineDelay", this.IsOfflineDelay);
            this.SetParamSimple(map, prefix + "ReadOnlyMaxDelayTime", this.ReadOnlyMaxDelayTime);
            this.SetParamSimple(map, prefix + "MinReadOnlyInGroup", this.MinReadOnlyInGroup);
            this.SetParamArrayObj(map, prefix + "WeightPairs.", this.WeightPairs);
            this.SetParamSimple(map, prefix + "AutoWeight", this.AutoWeight);
            this.SetParamSimple(map, prefix + "BalanceWeight", this.BalanceWeight);
        }
    }
}

