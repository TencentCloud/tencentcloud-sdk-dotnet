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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowPackageInfo : AbstractModel
    {
        
        /// <summary>
        /// 流量包的唯一资源ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 流量包所属的用户AppId
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 流量包规格类型。可取值如下：
        /// DEVICE_1_FLOW_20G、DEVICE_2_FLOW_50G、
        /// DEVICE_3_FLOW_100G、
        /// DEVICE_5_FLOW_500G，分别代表20G、50G、100G、500G档位的流量包。
        /// 档位也影响流量包可绑定的设备数量上限：
        /// 20G：最多绑定1个设备
        /// 50G：最多绑定2个设备
        /// 100G：最多绑定3个设备
        /// 500G：最多绑定5个设备
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// 流量包状态，0：未生效，1：有效期内，2：已过期
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 购买时间，Unix时间戳格式，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 生效时间，Unix时间戳格式，单位：秒
        /// </summary>
        [JsonProperty("ActiveTime")]
        public long? ActiveTime{ get; set; }

        /// <summary>
        /// 过期时间，Unix时间戳格式，单位：秒
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// 流量包绑定的设备ID列表
        /// </summary>
        [JsonProperty("DeviceList")]
        public string[] DeviceList{ get; set; }

        /// <summary>
        /// 流量包总容量，单位：MB
        /// </summary>
        [JsonProperty("CapacitySize")]
        public ulong? CapacitySize{ get; set; }

        /// <summary>
        /// 流量包余量，单位：MB
        /// </summary>
        [JsonProperty("CapacityRemain")]
        public ulong? CapacityRemain{ get; set; }

        /// <summary>
        /// 自动续费标识。true代表自动续费，false代表不自动续费
        /// </summary>
        [JsonProperty("RenewFlag")]
        public bool? RenewFlag{ get; set; }

        /// <summary>
        /// 资源包变更状态，0：未发生变配；1：变配中；2：已变配或已续费
        /// </summary>
        [JsonProperty("ModifyStatus")]
        public long? ModifyStatus{ get; set; }

        /// <summary>
        /// 流量截断标识。true代表开启流量截断，false代表不开启流量截断
        /// </summary>
        [JsonProperty("TruncFlag")]
        public bool? TruncFlag{ get; set; }

        /// <summary>
        /// 流量包精确余量，单位：MB
        /// </summary>
        [JsonProperty("CapacityRemainPrecise")]
        public ulong? CapacityRemainPrecise{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ActiveTime", this.ActiveTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamArraySimple(map, prefix + "DeviceList.", this.DeviceList);
            this.SetParamSimple(map, prefix + "CapacitySize", this.CapacitySize);
            this.SetParamSimple(map, prefix + "CapacityRemain", this.CapacityRemain);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "ModifyStatus", this.ModifyStatus);
            this.SetParamSimple(map, prefix + "TruncFlag", this.TruncFlag);
            this.SetParamSimple(map, prefix + "CapacityRemainPrecise", this.CapacityRemainPrecise);
        }
    }
}

