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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HaVip : AbstractModel
    {
        
        /// <summary>
        /// `HAVIP`的`ID`，是`HAVIP`的唯一标识。
        /// </summary>
        [JsonProperty("HaVipId")]
        public string HaVipId{ get; set; }

        /// <summary>
        /// `HAVIP`名称。
        /// </summary>
        [JsonProperty("HaVipName")]
        public string HaVipName{ get; set; }

        /// <summary>
        /// 虚拟IP地址。
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// `HAVIP`所在私有网络`ID`。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// `HAVIP`所在子网`ID`。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// `HAVIP`关联弹性网卡`ID`。
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// 被绑定的实例`ID`。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 绑定`EIP`。
        /// </summary>
        [JsonProperty("AddressIp")]
        public string AddressIp{ get; set; }

        /// <summary>
        /// 状态：
        /// <li>`AVAILABLE`：运行中</li>
        /// <li>`UNBIND`：未绑定</li>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 使用havip的业务标识。
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// `HAVIP`的飘移范围。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HaVipAssociationSet")]
        public HaVipAssociation[] HaVipAssociationSet{ get; set; }

        /// <summary>
        /// 是否开启`HAVIP`的飘移范围校验。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckAssociate")]
        public bool? CheckAssociate{ get; set; }

        /// <summary>
        /// HAVIP 刷新时间。该参数只作为出参数。以下场景会触发 FlushTime 被刷新：1）子机发出免费 ARP 触发 HAVIP 漂移；2）手动HAVIP解绑网卡; 没有更新时默认值：0000-00-00 00:00:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FlushedTime")]
        public string FlushedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HaVipId", this.HaVipId);
            this.SetParamSimple(map, prefix + "HaVipName", this.HaVipName);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AddressIp", this.AddressIp);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamArrayObj(map, prefix + "HaVipAssociationSet.", this.HaVipAssociationSet);
            this.SetParamSimple(map, prefix + "CheckAssociate", this.CheckAssociate);
            this.SetParamSimple(map, prefix + "FlushedTime", this.FlushedTime);
        }
    }
}

