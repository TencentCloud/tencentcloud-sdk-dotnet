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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeClusterInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// create 表示开始一次升级任务
        /// pause 表示停止任务
        /// resume表示继续任务
        /// abort表示终止任务
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 升级类型，只有Operation是create需要设置
        /// reset 大版本重装升级
        /// hot 小版本热升级
        /// major 大版本原地升级
        /// </summary>
        [JsonProperty("UpgradeType")]
        public string UpgradeType{ get; set; }

        /// <summary>
        /// 需要升级的节点列表
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 当节点重新加入集群时候所使用的参数，参考添加已有节点接口
        /// </summary>
        [JsonProperty("ResetParam")]
        public UpgradeNodeResetParam ResetParam{ get; set; }

        /// <summary>
        /// 是否忽略节点升级前检查
        /// </summary>
        [JsonProperty("SkipPreCheck")]
        public bool? SkipPreCheck{ get; set; }

        /// <summary>
        /// 最大可容忍的不可用Pod比例
        /// </summary>
        [JsonProperty("MaxNotReadyPercent")]
        public float? MaxNotReadyPercent{ get; set; }

        /// <summary>
        /// 是否升级节点运行时，默认false不升级
        /// </summary>
        [JsonProperty("UpgradeRunTime")]
        public bool? UpgradeRunTime{ get; set; }


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
        }
    }
}

