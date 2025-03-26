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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RocketMQVipInstance : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例版本
        /// </summary>
        [JsonProperty("InstanceVersion")]
        public string InstanceVersion{ get; set; }

        /// <summary>
        /// 实例状态，0表示创建中，1表示正常，2表示隔离中，3表示已销毁，4 - 异常, 5 - 发货失败，6 - 变配中，7 - 变配失败
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 节点数量
        /// </summary>
        [JsonProperty("NodeCount")]
        public ulong? NodeCount{ get; set; }

        /// <summary>
        /// 实例配置规格名称
        /// </summary>
        [JsonProperty("ConfigDisplay")]
        public string ConfigDisplay{ get; set; }

        /// <summary>
        /// 峰值TPS
        /// </summary>
        [JsonProperty("MaxTps")]
        public ulong? MaxTps{ get; set; }

        /// <summary>
        /// 峰值带宽，Mbps为单位
        /// </summary>
        [JsonProperty("MaxBandWidth")]
        public ulong? MaxBandWidth{ get; set; }

        /// <summary>
        /// 存储容量，GB为单位
        /// </summary>
        [JsonProperty("MaxStorage")]
        public ulong? MaxStorage{ get; set; }

        /// <summary>
        /// 实例到期时间，毫秒为单位
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// 自动续费标记，0表示默认状态(用户未设置，即初始状态即手动续费)， 1表示自动续费，2表示明确不自动续费(用户设置)
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 0-后付费，1-预付费
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// 备注信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 实例配置ID
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// 最大可设置消息保留时间，小时为单位
        /// </summary>
        [JsonProperty("MaxRetention")]
        public long? MaxRetention{ get; set; }

        /// <summary>
        /// 最小可设置消息保留时间，小时为单位
        /// </summary>
        [JsonProperty("MinRetention")]
        public long? MinRetention{ get; set; }

        /// <summary>
        /// 实例消息保留时间，小时为单位
        /// </summary>
        [JsonProperty("Retention")]
        public long? Retention{ get; set; }

        /// <summary>
        /// 是否开启ACL鉴权
        /// </summary>
        [JsonProperty("AclEnabled")]
        public bool? AclEnabled{ get; set; }

        /// <summary>
        /// 销毁时间
        /// </summary>
        [JsonProperty("DestroyTime")]
        public ulong? DestroyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceVersion", this.InstanceVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "ConfigDisplay", this.ConfigDisplay);
            this.SetParamSimple(map, prefix + "MaxTps", this.MaxTps);
            this.SetParamSimple(map, prefix + "MaxBandWidth", this.MaxBandWidth);
            this.SetParamSimple(map, prefix + "MaxStorage", this.MaxStorage);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "MaxRetention", this.MaxRetention);
            this.SetParamSimple(map, prefix + "MinRetention", this.MinRetention);
            this.SetParamSimple(map, prefix + "Retention", this.Retention);
            this.SetParamSimple(map, prefix + "AclEnabled", this.AclEnabled);
            this.SetParamSimple(map, prefix + "DestroyTime", this.DestroyTime);
        }
    }
}

