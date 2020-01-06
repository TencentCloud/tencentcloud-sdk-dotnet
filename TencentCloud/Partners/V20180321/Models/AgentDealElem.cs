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

namespace TencentCloud.Partners.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentDealElem : AbstractModel
    {
        
        /// <summary>
        /// 订单自增 ID
        /// </summary>
        [JsonProperty("DealId")]
        public string DealId{ get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("DealName")]
        public string DealName{ get; set; }

        /// <summary>
        /// 商品类型 ID
        /// </summary>
        [JsonProperty("GoodsCategoryId")]
        public string GoodsCategoryId{ get; set; }

        /// <summary>
        /// 订单所有者
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 订单所有者对应 appId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 商品数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GoodsNum")]
        public string GoodsNum{ get; set; }

        /// <summary>
        /// 价格详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GoodsPrice")]
        public DealGoodsPriceElem GoodsPrice{ get; set; }

        /// <summary>
        /// 下单人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Creater")]
        public string Creater{ get; set; }

        /// <summary>
        /// 下单时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatTime")]
        public string CreatTime{ get; set; }

        /// <summary>
        /// 支付结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayEndTime")]
        public string PayEndTime{ get; set; }

        /// <summary>
        /// 扣费流水号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillId")]
        public string BillId{ get; set; }

        /// <summary>
        /// 支付人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Payer")]
        public string Payer{ get; set; }

        /// <summary>
        /// 订单状态，中文描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DealStatus")]
        public string DealStatus{ get; set; }

        /// <summary>
        /// 订单的状态(1：未支付;2：已支付;3：发货中;4：已发货;5：发货失败;6：已退款;7：已关单;8：订单过期;9：订单已失效;10：产品已失效;11：代付拒绝;12：支付中)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 产品名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GoodsName")]
        public string GoodsName{ get; set; }

        /// <summary>
        /// 客户备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientRemark")]
        public string ClientRemark{ get; set; }

        /// <summary>
        /// 订单操作类型，purchase（新购），renew（续费），modify（配置变更）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// 代金券抵扣金额，单位分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VoucherDecline")]
        public string VoucherDecline{ get; set; }

        /// <summary>
        /// 大订单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BigDealId")]
        public string BigDealId{ get; set; }

        /// <summary>
        /// 客户类型（new：新拓；old：存量；assign：指派）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientType")]
        public string ClientType{ get; set; }

        /// <summary>
        /// 项目类型（self：自拓；repeat：直销；platform：官网合作）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectType")]
        public string ProjectType{ get; set; }

        /// <summary>
        /// 业务员账号ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SalesUin")]
        public string SalesUin{ get; set; }

        /// <summary>
        /// 支付方式，0：自付；1：代付
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayerMode")]
        public string PayerMode{ get; set; }

        /// <summary>
        /// 活动ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivityId")]
        public string ActivityId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DealId", this.DealId);
            this.SetParamSimple(map, prefix + "DealName", this.DealName);
            this.SetParamSimple(map, prefix + "GoodsCategoryId", this.GoodsCategoryId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamObj(map, prefix + "GoodsPrice.", this.GoodsPrice);
            this.SetParamSimple(map, prefix + "Creater", this.Creater);
            this.SetParamSimple(map, prefix + "CreatTime", this.CreatTime);
            this.SetParamSimple(map, prefix + "PayEndTime", this.PayEndTime);
            this.SetParamSimple(map, prefix + "BillId", this.BillId);
            this.SetParamSimple(map, prefix + "Payer", this.Payer);
            this.SetParamSimple(map, prefix + "DealStatus", this.DealStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "GoodsName", this.GoodsName);
            this.SetParamSimple(map, prefix + "ClientRemark", this.ClientRemark);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "VoucherDecline", this.VoucherDecline);
            this.SetParamSimple(map, prefix + "BigDealId", this.BigDealId);
            this.SetParamSimple(map, prefix + "ClientType", this.ClientType);
            this.SetParamSimple(map, prefix + "ProjectType", this.ProjectType);
            this.SetParamSimple(map, prefix + "SalesUin", this.SalesUin);
            this.SetParamSimple(map, prefix + "PayerMode", this.PayerMode);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
        }
    }
}

