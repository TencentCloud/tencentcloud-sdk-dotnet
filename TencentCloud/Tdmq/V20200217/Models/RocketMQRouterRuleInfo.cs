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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RocketMQRouterRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>源类型。<br>OPEN_SOURCE_ROCKETMQ：开源rocketmq<br>ALI_ROCKETMQ：阿里云rocketmq<br>TENCENT_ROCKETMQ：腾讯云rocketmq<br>TENCENT_MQTT：腾讯云MQTT<br>ALI_MNS：阿里云mns</p>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// <p>目标类型。<br>枚举和SourceType字段一样</p>
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// <p>规则备注，创建后任务后可以修改</p>
        /// </summary>
        [JsonProperty("RemarkName")]
        public string RemarkName{ get; set; }

        /// <summary>
        /// <p>阿里云rocketmq源信息</p>
        /// </summary>
        [JsonProperty("AliRocketMQSource")]
        public RouterRocketMQSource AliRocketMQSource{ get; set; }

        /// <summary>
        /// <p>阿里云rocketmq目标信息</p>
        /// </summary>
        [JsonProperty("AliRocketMQTarget")]
        public RouterRocketMQTarget AliRocketMQTarget{ get; set; }

        /// <summary>
        /// <p>阿里云mns源信息</p>
        /// </summary>
        [JsonProperty("AliMessageServiceSource")]
        public RouterMessageServiceSource AliMessageServiceSource{ get; set; }

        /// <summary>
        /// <p>阿里云mns目标信息</p>
        /// </summary>
        [JsonProperty("AliMessageServiceTarget")]
        public RouterMessageServiceTarget AliMessageServiceTarget{ get; set; }

        /// <summary>
        /// <p>腾讯云rocketmq源信息</p>
        /// </summary>
        [JsonProperty("TenRocketMQSource")]
        public RouterTencentRocketMQSource TenRocketMQSource{ get; set; }

        /// <summary>
        /// <p>腾讯云rocketmq目标信息</p>
        /// </summary>
        [JsonProperty("TenRocketMQTarget")]
        public RouterTencentRocketMQTarget TenRocketMQTarget{ get; set; }

        /// <summary>
        /// <p>任务别名</p>
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }

        /// <summary>
        /// <p>腾讯云 MQTT 源集群信息</p>
        /// </summary>
        [JsonProperty("TenMQTTSource")]
        public RouterTencentMQTTSource TenMQTTSource{ get; set; }

        /// <summary>
        /// <p>腾讯云 MQTT 目标集群信息</p>
        /// </summary>
        [JsonProperty("TenMQTTTarget")]
        public RouterTencentMQTTTarget TenMQTTTarget{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "RemarkName", this.RemarkName);
            this.SetParamObj(map, prefix + "AliRocketMQSource.", this.AliRocketMQSource);
            this.SetParamObj(map, prefix + "AliRocketMQTarget.", this.AliRocketMQTarget);
            this.SetParamObj(map, prefix + "AliMessageServiceSource.", this.AliMessageServiceSource);
            this.SetParamObj(map, prefix + "AliMessageServiceTarget.", this.AliMessageServiceTarget);
            this.SetParamObj(map, prefix + "TenRocketMQSource.", this.TenRocketMQSource);
            this.SetParamObj(map, prefix + "TenRocketMQTarget.", this.TenRocketMQTarget);
            this.SetParamSimple(map, prefix + "AliasName", this.AliasName);
            this.SetParamObj(map, prefix + "TenMQTTSource.", this.TenMQTTSource);
            this.SetParamObj(map, prefix + "TenMQTTTarget.", this.TenMQTTTarget);
        }
    }
}

