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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeDedicatedDCDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 升级类型，取值为ADD，SPLIT和EXPAND。ADD-添加分片；SPLIT-切分某个分片；EXPAND-垂直扩容某个分片
        /// </summary>
        [JsonProperty("UpgradeType")]
        public string UpgradeType{ get; set; }

        /// <summary>
        /// 实例ID，形如 dcdbt-mlfjm74h
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 当UpgradeType取值为ADD时，添加分片的配置参数
        /// </summary>
        [JsonProperty("AddShardConfig")]
        public AddShardConfig AddShardConfig{ get; set; }

        /// <summary>
        /// 当UpgradeType取值为EXPAND时，垂直扩容分片的配置参数
        /// </summary>
        [JsonProperty("ExpandShardConfig")]
        public ExpandShardConfig ExpandShardConfig{ get; set; }

        /// <summary>
        /// 当UpgradeType取值为SPLIT时，切分分片的配置参数
        /// </summary>
        [JsonProperty("SplitShardConfig")]
        public SplitShardConfig SplitShardConfig{ get; set; }

        /// <summary>
        /// 错过切换时间窗口时，是否自动重试一次，0-否，1-是
        /// </summary>
        [JsonProperty("SwitchAutoRetry")]
        public long? SwitchAutoRetry{ get; set; }

        /// <summary>
        /// 切换时间窗口开始时间
        /// </summary>
        [JsonProperty("SwitchStartTime")]
        public string SwitchStartTime{ get; set; }

        /// <summary>
        /// 切换时间窗口结束时间
        /// </summary>
        [JsonProperty("SwitchEndTime")]
        public string SwitchEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UpgradeType", this.UpgradeType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamObj(map, prefix + "AddShardConfig.", this.AddShardConfig);
            this.SetParamObj(map, prefix + "ExpandShardConfig.", this.ExpandShardConfig);
            this.SetParamObj(map, prefix + "SplitShardConfig.", this.SplitShardConfig);
            this.SetParamSimple(map, prefix + "SwitchAutoRetry", this.SwitchAutoRetry);
            this.SetParamSimple(map, prefix + "SwitchStartTime", this.SwitchStartTime);
            this.SetParamSimple(map, prefix + "SwitchEndTime", this.SwitchEndTime);
        }
    }
}

