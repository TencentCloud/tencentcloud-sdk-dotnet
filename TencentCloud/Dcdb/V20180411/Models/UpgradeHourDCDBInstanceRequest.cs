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

    public class UpgradeHourDCDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>待升级的实例ID。形如：dcdbt-ow728lmc，可以通过 DescribeDCDBInstances 查询实例详情获得。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>升级类型，取值范围: </p><li> ADD: 新增分片 </li>  <li> EXPAND: 升级实例中的已有分片 </li>  <li> SPLIT: 将已有分片中的数据切分到新增分片上</li>
        /// </summary>
        [JsonProperty("UpgradeType")]
        public string UpgradeType{ get; set; }

        /// <summary>
        /// <p>新增分片配置，当UpgradeType为ADD时生效。</p>
        /// </summary>
        [JsonProperty("AddShardConfig")]
        public AddShardConfig AddShardConfig{ get; set; }

        /// <summary>
        /// <p>扩容分片配置，当UpgradeType为EXPAND时生效。</p>
        /// </summary>
        [JsonProperty("ExpandShardConfig")]
        public ExpandShardConfig ExpandShardConfig{ get; set; }

        /// <summary>
        /// <p>切分分片配置，当UpgradeType为SPLIT时生效。</p>
        /// </summary>
        [JsonProperty("SplitShardConfig")]
        public SplitShardConfig SplitShardConfig{ get; set; }

        /// <summary>
        /// <p>切换开始时间，格式如: &quot;2019-12-12 07:00:00&quot;。开始时间必须在当前时间一个小时以后，3天以内。</p>
        /// </summary>
        [JsonProperty("SwitchStartTime")]
        public string SwitchStartTime{ get; set; }

        /// <summary>
        /// <p>切换结束时间,  格式如: &quot;2019-12-12 07:15:00&quot;，结束时间必须大于开始时间。</p>
        /// </summary>
        [JsonProperty("SwitchEndTime")]
        public string SwitchEndTime{ get; set; }

        /// <summary>
        /// <p>是否自动重试。 0：不自动重试  1：自动重试</p>
        /// </summary>
        [JsonProperty("SwitchAutoRetry")]
        public long? SwitchAutoRetry{ get; set; }

        /// <summary>
        /// <p>变更部署时指定的新可用区列表，第1个为主可用区，其余为从可用区</p>
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// <p>多个分片同时发起扩容，并发切换中的切换时间间隔，即当前分片切换开始时间和下一个分片的切换开始时间间隔，不传默认为1。</p><p>取值范围：[1, 180]</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("SwitchInterval")]
        public long? SwitchInterval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UpgradeType", this.UpgradeType);
            this.SetParamObj(map, prefix + "AddShardConfig.", this.AddShardConfig);
            this.SetParamObj(map, prefix + "ExpandShardConfig.", this.ExpandShardConfig);
            this.SetParamObj(map, prefix + "SplitShardConfig.", this.SplitShardConfig);
            this.SetParamSimple(map, prefix + "SwitchStartTime", this.SwitchStartTime);
            this.SetParamSimple(map, prefix + "SwitchEndTime", this.SwitchEndTime);
            this.SetParamSimple(map, prefix + "SwitchAutoRetry", this.SwitchAutoRetry);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "SwitchInterval", this.SwitchInterval);
        }
    }
}

