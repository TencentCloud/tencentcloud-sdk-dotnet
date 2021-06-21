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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BGPIPInstance : AbstractModel
    {
        
        /// <summary>
        /// 资产实例的详细信息
        /// </summary>
        [JsonProperty("InstanceDetail")]
        public InstanceRelation InstanceDetail{ get; set; }

        /// <summary>
        /// 资产实例的规格信息
        /// </summary>
        [JsonProperty("SpecificationLimit")]
        public BGPIPInstanceSpecification SpecificationLimit{ get; set; }

        /// <summary>
        /// 资产实例的使用统计信息
        /// </summary>
        [JsonProperty("Usage")]
        public BGPIPInstanceUsages Usage{ get; set; }

        /// <summary>
        /// 资产实例所在的地域
        /// </summary>
        [JsonProperty("Region")]
        public RegionInfo Region{ get; set; }

        /// <summary>
        /// 资产实例的防护状态，状态码如下：
        /// "idle"：正常状态(无攻击)
        /// "attacking"：攻击中
        /// "blocking"：封堵中
        /// "creating"：创建中
        /// "deblocking"：解封中
        /// "isolate"：回收隔离中
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 购买时间
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 资产实例的名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 资产实例所属的套餐包信息，
        /// 注意：当资产实例不是套餐包的实例时，此字段为null
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackInfo")]
        public PackInfo PackInfo{ get; set; }

        /// <summary>
        /// 资产实例所属的三网套餐包详情，
        /// 注意：当资产实例不是三网套餐包的实例时，此字段为null
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StaticPackRelation")]
        public StaticPackRelation StaticPackRelation{ get; set; }

        /// <summary>
        /// 区分高防IP海外线路
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// 区分集群
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tgw")]
        public ulong? Tgw{ get; set; }

        /// <summary>
        /// 高防弹性公网IP状态，包含'CREATING'(创建中),'BINDING'(绑定中),'BIND'(已绑定),'UNBINDING'(解绑中),'UNBIND'(已解绑),'OFFLINING'(释放中),'BIND_ENI'(绑定悬空弹性网卡)。只对高防弹性公网IP实例有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EipAddressStatus")]
        public string EipAddressStatus{ get; set; }

        /// <summary>
        /// 是否高防弹性公网IP实例，是为1，否为0。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EipFlag")]
        public long? EipFlag{ get; set; }

        /// <summary>
        /// 资产实例所属的高防弹性公网IP套餐包详情，
        /// 注意：当资产实例不是高防弹性公网IP套餐包的实例时，此字段为null
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EipAddressPackRelation")]
        public EipAddressPackRelation EipAddressPackRelation{ get; set; }

        /// <summary>
        /// 高防弹性公网IP关联的实例信息。
        /// 注意：当资产实例不是高防弹性公网IP实例时，此字段为null
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EipAddressInfo")]
        public EipAddressRelation EipAddressInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "InstanceDetail.", this.InstanceDetail);
            this.SetParamObj(map, prefix + "SpecificationLimit.", this.SpecificationLimit);
            this.SetParamObj(map, prefix + "Usage.", this.Usage);
            this.SetParamObj(map, prefix + "Region.", this.Region);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "PackInfo.", this.PackInfo);
            this.SetParamObj(map, prefix + "StaticPackRelation.", this.StaticPackRelation);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Tgw", this.Tgw);
            this.SetParamSimple(map, prefix + "EipAddressStatus", this.EipAddressStatus);
            this.SetParamSimple(map, prefix + "EipFlag", this.EipFlag);
            this.SetParamObj(map, prefix + "EipAddressPackRelation.", this.EipAddressPackRelation);
            this.SetParamObj(map, prefix + "EipAddressInfo.", this.EipAddressInfo);
        }
    }
}

