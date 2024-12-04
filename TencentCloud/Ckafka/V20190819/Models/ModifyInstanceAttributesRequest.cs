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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// ckafka集群实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例日志的最长保留时间，单位分钟，最大90天，0代表不开启日志保留时间回收策略
        /// </summary>
        [JsonProperty("MsgRetentionTime")]
        public long? MsgRetentionTime{ get; set; }

        /// <summary>
        /// ckafka集群实例Name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例配置
        /// </summary>
        [JsonProperty("Config")]
        public ModifyInstanceAttributesConfig Config{ get; set; }

        /// <summary>
        /// 动态消息保留策略配置
        /// </summary>
        [JsonProperty("DynamicRetentionConfig")]
        public DynamicRetentionTime DynamicRetentionConfig{ get; set; }

        /// <summary>
        /// 升配Rebalance时间 参数已废弃,忽略不填!!!
        /// </summary>
        [JsonProperty("RebalanceTime")]
        public long? RebalanceTime{ get; set; }

        /// <summary>
        /// 公网带宽 最小3Mbps  最大999Mbps 仅专业版支持填写
        /// </summary>
        [JsonProperty("PublicNetwork")]
        public long? PublicNetwork{ get; set; }

        /// <summary>
        /// 动态硬盘扩容策略配置
        /// </summary>
        [JsonProperty("DynamicDiskConfig")]
        [System.Obsolete]
        public DynamicDiskConfig DynamicDiskConfig{ get; set; }

        /// <summary>
        /// 实例级别单条消息大小（单位byte)  最大 12582912(不包含)  最小1024(不包含)
        /// </summary>
        [JsonProperty("MaxMessageByte")]
        public ulong? MaxMessageByte{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MsgRetentionTime", this.MsgRetentionTime);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamObj(map, prefix + "DynamicRetentionConfig.", this.DynamicRetentionConfig);
            this.SetParamSimple(map, prefix + "RebalanceTime", this.RebalanceTime);
            this.SetParamSimple(map, prefix + "PublicNetwork", this.PublicNetwork);
            this.SetParamObj(map, prefix + "DynamicDiskConfig.", this.DynamicDiskConfig);
            this.SetParamSimple(map, prefix + "MaxMessageByte", this.MaxMessageByte);
        }
    }
}

