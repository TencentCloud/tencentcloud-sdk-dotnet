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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PutProvisionedConcurrencyConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要设置预置并发的函数的名称
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 函数的版本号，注：$LATEST版本不支持预置并发
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }

        /// <summary>
        /// 预置并发数量，注：所有版本的预置并发数总和存在上限限制，当前的上限是：函数最大并发配额 - 100
        /// </summary>
        [JsonProperty("VersionProvisionedConcurrencyNum")]
        public ulong? VersionProvisionedConcurrencyNum{ get; set; }

        /// <summary>
        /// 函数所属命名空间，默认为default
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 定时预置任务
        /// </summary>
        [JsonProperty("TriggerActions")]
        public TriggerAction[] TriggerActions{ get; set; }

        /// <summary>
        /// 预置类型，
        /// 静态预置：Default
        /// 动态追踪并发利用率指标预置：ConcurrencyUtilizationTracking
        /// 预置类型二选一，设置静态预置时可以设置VersionProvisionedConcurrencyNum。
        /// 
        /// 动态利用率预置可以设置TrackingTarget，MinCapacity，MaxCapacity，保持向后兼容性此时VersionProvisionedConcurrencyNum设置为0.
        /// </summary>
        [JsonProperty("ProvisionedType")]
        public string ProvisionedType{ get; set; }

        /// <summary>
        /// 指标追踪的并发利用率。设置范围(0,1)
        /// </summary>
        [JsonProperty("TrackingTarget")]
        public float? TrackingTarget{ get; set; }

        /// <summary>
        /// 缩容时的最小值, 最小值为1
        /// </summary>
        [JsonProperty("MinCapacity")]
        public ulong? MinCapacity{ get; set; }

        /// <summary>
        /// 扩容时的最大值
        /// </summary>
        [JsonProperty("MaxCapacity")]
        public ulong? MaxCapacity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "Qualifier", this.Qualifier);
            this.SetParamSimple(map, prefix + "VersionProvisionedConcurrencyNum", this.VersionProvisionedConcurrencyNum);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamArrayObj(map, prefix + "TriggerActions.", this.TriggerActions);
            this.SetParamSimple(map, prefix + "ProvisionedType", this.ProvisionedType);
            this.SetParamSimple(map, prefix + "TrackingTarget", this.TrackingTarget);
            this.SetParamSimple(map, prefix + "MinCapacity", this.MinCapacity);
            this.SetParamSimple(map, prefix + "MaxCapacity", this.MaxCapacity);
        }
    }
}

