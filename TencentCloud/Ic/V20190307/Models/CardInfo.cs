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

namespace TencentCloud.Ic.V20190307.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CardInfo : AbstractModel
    {
        
        /// <summary>
        /// 卡片ID
        /// </summary>
        [JsonProperty("Iccid")]
        public string Iccid{ get; set; }

        /// <summary>
        /// 卡电话号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Msisdn")]
        public string Msisdn{ get; set; }

        /// <summary>
        /// 卡imsi
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Imsi")]
        public string Imsi{ get; set; }

        /// <summary>
        /// 卡imei
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Imei")]
        public string Imei{ get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("Sdkappid")]
        public string Sdkappid{ get; set; }

        /// <summary>
        /// 运营商编号
        /// </summary>
        [JsonProperty("Teleoperator")]
        public long? Teleoperator{ get; set; }

        /// <summary>
        /// 卡片状态 1:未激活 2：激活 3：停卡 5：销卡
        /// </summary>
        [JsonProperty("CardStatus")]
        public long? CardStatus{ get; set; }

        /// <summary>
        /// 网络状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkStatus")]
        public long? NetworkStatus{ get; set; }

        /// <summary>
        /// 激活时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivitedTime")]
        public string ActivitedTime{ get; set; }

        /// <summary>
        /// 资费类型，1 单卡，2 流量池
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 套餐类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 流量池ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PoolId")]
        public string PoolId{ get; set; }

        /// <summary>
        /// 周期套餐流量使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataUsedInPeriod")]
        public float? DataUsedInPeriod{ get; set; }

        /// <summary>
        /// 周期套餐总量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataTotalInPeriod")]
        public float? DataTotalInPeriod{ get; set; }

        /// <summary>
        /// 过期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductExpiredTime")]
        public string ProductExpiredTime{ get; set; }

        /// <summary>
        /// 描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// 套餐周期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PreorderCnt")]
        public long? PreorderCnt{ get; set; }

        /// <summary>
        /// 激活被回调标志
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsActivated")]
        public long? IsActivated{ get; set; }

        /// <summary>
        /// 订单ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 是否自动续费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long? AutoRenew{ get; set; }

        /// <summary>
        /// 备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 0 不需要开通达量不停卡 1 需要开通达量不停卡
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllowArrears")]
        public long? AllowArrears{ get; set; }

        /// <summary>
        /// 是否开通短信0:未开短信 1:开通短信
        /// </summary>
        [JsonProperty("NeedSms")]
        public long? NeedSms{ get; set; }

        /// <summary>
        /// 服务
        /// </summary>
        [JsonProperty("Provider")]
        public long? Provider{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Iccid", this.Iccid);
            this.SetParamSimple(map, prefix + "Msisdn", this.Msisdn);
            this.SetParamSimple(map, prefix + "Imsi", this.Imsi);
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
            this.SetParamSimple(map, prefix + "Sdkappid", this.Sdkappid);
            this.SetParamSimple(map, prefix + "Teleoperator", this.Teleoperator);
            this.SetParamSimple(map, prefix + "CardStatus", this.CardStatus);
            this.SetParamSimple(map, prefix + "NetworkStatus", this.NetworkStatus);
            this.SetParamSimple(map, prefix + "ActivitedTime", this.ActivitedTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "PoolId", this.PoolId);
            this.SetParamSimple(map, prefix + "DataUsedInPeriod", this.DataUsedInPeriod);
            this.SetParamSimple(map, prefix + "DataTotalInPeriod", this.DataTotalInPeriod);
            this.SetParamSimple(map, prefix + "ProductExpiredTime", this.ProductExpiredTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "PreorderCnt", this.PreorderCnt);
            this.SetParamSimple(map, prefix + "IsActivated", this.IsActivated);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AllowArrears", this.AllowArrears);
            this.SetParamSimple(map, prefix + "NeedSms", this.NeedSms);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
        }
    }
}

