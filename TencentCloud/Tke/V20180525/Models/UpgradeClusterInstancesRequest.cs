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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeClusterInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群ID（请登录 <a href="https://console.cloud.tencent.com/tke2">TKE 控制台</a> 获取集群 ID ）</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>create 表示开始一次升级任务<br>pause 表示停止任务<br>resume表示继续任务<br>abort表示终止任务</p>
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// <p>升级类型，只有Operation是create需要设置<br>reset 大版本重装升级<br>hot 小版本热升级<br>major 大版本原地升级</p>
        /// </summary>
        [JsonProperty("UpgradeType")]
        public string UpgradeType{ get; set; }

        /// <summary>
        /// <p>需要升级的节点列表，可以通过控制台或 <a href="https://cloud.tencent.com/document/api/457/50366">查询待升级节点接口</a> 获取</p>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// <p>当节点重新加入集群时候所使用的参数，参考添加已有节点接口</p>
        /// </summary>
        [JsonProperty("ResetParam")]
        public UpgradeNodeResetParam ResetParam{ get; set; }

        /// <summary>
        /// <p>是否忽略节点升级前检查，默认值 false</p>
        /// </summary>
        [JsonProperty("SkipPreCheck")]
        public bool? SkipPreCheck{ get; set; }

        /// <summary>
        /// <p>最大可容忍的不可用Pod百分比，如果设置 0 表示不做校验</p><p>取值范围：[0, 100]</p><p>默认值：20</p>
        /// </summary>
        [JsonProperty("MaxNotReadyPercent")]
        public float? MaxNotReadyPercent{ get; set; }

        /// <summary>
        /// <p>是否升级节点运行时，默认false不升级</p>
        /// </summary>
        [JsonProperty("UpgradeRunTime")]
        public bool? UpgradeRunTime{ get; set; }

        /// <summary>
        /// <p>支持多个节点并行升级，默认值为 1，最大并行数为15</p>
        /// </summary>
        [JsonProperty("Concurrent")]
        public long? Concurrent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "UpgradeType", this.UpgradeType);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamObj(map, prefix + "ResetParam.", this.ResetParam);
            this.SetParamSimple(map, prefix + "SkipPreCheck", this.SkipPreCheck);
            this.SetParamSimple(map, prefix + "MaxNotReadyPercent", this.MaxNotReadyPercent);
            this.SetParamSimple(map, prefix + "UpgradeRunTime", this.UpgradeRunTime);
            this.SetParamSimple(map, prefix + "Concurrent", this.Concurrent);
        }
    }
}

