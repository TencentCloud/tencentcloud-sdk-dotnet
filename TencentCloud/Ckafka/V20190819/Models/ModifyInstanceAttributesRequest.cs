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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// ckafka集群实例Id,可通过DescribeInstances接口获取
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例日志的最长保留时间，单位分钟，最大90天，最小为1min
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
        /// 用于修改升级版本或升配定时任务的执行时间，Unix时间戳，精确到秒
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
        /// 是否允许未同步的副本选为 leader: 1 开启  0 关闭
        /// </summary>
        [JsonProperty("UncleanLeaderElectionEnable")]
        public long? UncleanLeaderElectionEnable{ get; set; }

        /// <summary>
        /// 实例删除保护开关: 1 开启  0 关闭
        /// </summary>
        [JsonProperty("DeleteProtectionEnable")]
        public long? DeleteProtectionEnable{ get; set; }


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
            this.SetParamSimple(map, prefix + "UncleanLeaderElectionEnable", this.UncleanLeaderElectionEnable);
            this.SetParamSimple(map, prefix + "DeleteProtectionEnable", this.DeleteProtectionEnable);
        }
    }
}

