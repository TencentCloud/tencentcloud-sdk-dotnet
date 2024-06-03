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

    public class BGPInstance : AbstractModel
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
        public BGPInstanceSpecification SpecificationLimit{ get; set; }

        /// <summary>
        /// 资产实例的使用统计信息
        /// </summary>
        [JsonProperty("Usage")]
        public BGPInstanceUsages Usage{ get; set; }

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
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

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
        /// 高防包绑定的EIP属于的云产品信息
        /// </summary>
        [JsonProperty("EipProductInfos")]
        public EipProductInfo[] EipProductInfos{ get; set; }

        /// <summary>
        /// 高防包绑定状态，取值[
        /// "idle"：绑定已完成
        ///  "bounding"：正在绑定中
        /// "failed"：绑定失败
        /// ]
        /// </summary>
        [JsonProperty("BoundStatus")]
        public string BoundStatus{ get; set; }

        /// <summary>
        /// 四层防护严格级别
        /// </summary>
        [JsonProperty("DDoSLevel")]
        public string DDoSLevel{ get; set; }

        /// <summary>
        /// CC防护开关
        /// </summary>
        [JsonProperty("CCEnable")]
        public long? CCEnable{ get; set; }

        /// <summary>
        /// 资源关联标签
        /// </summary>
        [JsonProperty("TagInfoList")]
        public TagInfo[] TagInfoList{ get; set; }

        /// <summary>
        /// 新版本1ip高防包
        /// </summary>
        [JsonProperty("IpCountNewFlag")]
        public ulong? IpCountNewFlag{ get; set; }

        /// <summary>
        /// 攻击封堵套餐标记
        /// </summary>
        [JsonProperty("VitalityVersion")]
        public ulong? VitalityVersion{ get; set; }

        /// <summary>
        /// 网络线路
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Line")]
        public ulong? Line{ get; set; }

        /// <summary>
        /// 不计费的业务带宽
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FreeServiceBandwidth")]
        public ulong? FreeServiceBandwidth{ get; set; }

        /// <summary>
        /// 弹性业务带宽开关
        /// </summary>
        [JsonProperty("ElasticServiceBandwidth")]
        public ulong? ElasticServiceBandwidth{ get; set; }

        /// <summary>
        /// 赠送的业务带宽
        /// </summary>
        [JsonProperty("GiftServiceBandWidth")]
        public long? GiftServiceBandWidth{ get; set; }

        /// <summary>
        /// 修改时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 是否是基础防护加强版 0: 不是 1: 是
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BasicPlusFlag")]
        public ulong? BasicPlusFlag{ get; set; }

        /// <summary>
        /// 是否是商业模式优化-普惠版
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlanCntFlag")]
        public ulong? PlanCntFlag{ get; set; }

        /// <summary>
        /// 是否跨区域产品 0: 不包含跨区域产品 1: 中国大陆跨区域产品 2: 非中国大陆跨区域产品
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransRegionFlag")]
        public ulong? TransRegionFlag{ get; set; }

        /// <summary>
        /// 是否为超级高防包
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuperPackFlag")]
        public ulong? SuperPackFlag{ get; set; }

        /// <summary>
        /// 所属ZoneId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }


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
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "PackInfo.", this.PackInfo);
            this.SetParamArrayObj(map, prefix + "EipProductInfos.", this.EipProductInfos);
            this.SetParamSimple(map, prefix + "BoundStatus", this.BoundStatus);
            this.SetParamSimple(map, prefix + "DDoSLevel", this.DDoSLevel);
            this.SetParamSimple(map, prefix + "CCEnable", this.CCEnable);
            this.SetParamArrayObj(map, prefix + "TagInfoList.", this.TagInfoList);
            this.SetParamSimple(map, prefix + "IpCountNewFlag", this.IpCountNewFlag);
            this.SetParamSimple(map, prefix + "VitalityVersion", this.VitalityVersion);
            this.SetParamSimple(map, prefix + "Line", this.Line);
            this.SetParamSimple(map, prefix + "FreeServiceBandwidth", this.FreeServiceBandwidth);
            this.SetParamSimple(map, prefix + "ElasticServiceBandwidth", this.ElasticServiceBandwidth);
            this.SetParamSimple(map, prefix + "GiftServiceBandWidth", this.GiftServiceBandWidth);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "BasicPlusFlag", this.BasicPlusFlag);
            this.SetParamSimple(map, prefix + "PlanCntFlag", this.PlanCntFlag);
            this.SetParamSimple(map, prefix + "TransRegionFlag", this.TransRegionFlag);
            this.SetParamSimple(map, prefix + "SuperPackFlag", this.SuperPackFlag);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
        }
    }
}

