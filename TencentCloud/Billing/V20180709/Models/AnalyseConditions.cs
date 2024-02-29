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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AnalyseConditions : AbstractModel
    {
        
        /// <summary>
        /// 产品名称代码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessCodes")]
        public string BusinessCodes{ get; set; }

        /// <summary>
        /// 子产品名称代码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductCodes")]
        public string ProductCodes{ get; set; }

        /// <summary>
        /// 组件类型代码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComponentCode")]
        public string ComponentCode{ get; set; }

        /// <summary>
        /// 可用区ID：资源所属可用区ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string ZoneIds{ get; set; }

        /// <summary>
        /// 地域ID:资源所属地域ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegionIds")]
        public string RegionIds{ get; set; }

        /// <summary>
        /// 项目ID:资源所属项目ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectIds")]
        public string ProjectIds{ get; set; }

        /// <summary>
        /// 计费模式 prePay(表示包年包月)/postPay(表示按量计费)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayModes")]
        public string PayModes{ get; set; }

        /// <summary>
        /// 交易类型，查询交易类型（请使用交易类型code入参）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionTypes")]
        public string ActionTypes{ get; set; }

        /// <summary>
        /// 分账标签键
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }

        /// <summary>
        /// 费用类型，查询费用类型（请使用费用类型code入参)入参枚举如下：
        /// cashPayAmount:现金 
        /// incentivePayAmount:赠送金 
        /// voucherPayAmount:优惠券 
        /// tax:税金 
        /// costBeforeTax:税前价
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FeeType")]
        public string FeeType{ get; set; }

        /// <summary>
        /// 查询成本分析数据的用户UIN
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayerUins")]
        public string PayerUins{ get; set; }

        /// <summary>
        /// 使用资源的用户UIN
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerUins")]
        public string OwnerUins{ get; set; }

        /// <summary>
        /// 消耗类型，查询消耗类型（请使用消耗类型code入参）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsumptionTypes")]
        public string ConsumptionTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BusinessCodes", this.BusinessCodes);
            this.SetParamSimple(map, prefix + "ProductCodes", this.ProductCodes);
            this.SetParamSimple(map, prefix + "ComponentCode", this.ComponentCode);
            this.SetParamSimple(map, prefix + "ZoneIds", this.ZoneIds);
            this.SetParamSimple(map, prefix + "RegionIds", this.RegionIds);
            this.SetParamSimple(map, prefix + "ProjectIds", this.ProjectIds);
            this.SetParamSimple(map, prefix + "PayModes", this.PayModes);
            this.SetParamSimple(map, prefix + "ActionTypes", this.ActionTypes);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
            this.SetParamSimple(map, prefix + "FeeType", this.FeeType);
            this.SetParamSimple(map, prefix + "PayerUins", this.PayerUins);
            this.SetParamSimple(map, prefix + "OwnerUins", this.OwnerUins);
            this.SetParamSimple(map, prefix + "ConsumptionTypes", this.ConsumptionTypes);
        }
    }
}

