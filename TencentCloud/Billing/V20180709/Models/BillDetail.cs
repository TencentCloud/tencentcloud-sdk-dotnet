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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BillDetail : AbstractModel
    {
        
        /// <summary>
        /// 产品名称：用户所采购的各类云产品，例如：云服务器 CVM
        /// </summary>
        [JsonProperty("BusinessCodeName")]
        public string BusinessCodeName{ get; set; }

        /// <summary>
        /// 子产品名称：用户采购的具体产品细分类型，例如：云服务器 CVM-标准型 S1
        /// </summary>
        [JsonProperty("ProductCodeName")]
        public string ProductCodeName{ get; set; }

        /// <summary>
        /// 计费模式：资源的计费模式，区分为包年包月和按量计费
        /// </summary>
        [JsonProperty("PayModeName")]
        public string PayModeName{ get; set; }

        /// <summary>
        /// 项目名称：资源归属的项目，用户在控制台给资源自主分配项目，未分配则是默认项目
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 地域：资源所属地域，如华南地区（广州）
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// 可用区：资源所属可用区，如广州三区
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// 资源 ID：账单中出账对象 ID，不同产品因资源形态不同，资源内容不完全相同，如云服务器 CVM 为对应的实例 ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 资源别名：用户在控制台为资源设置的名称，如果未设置，则默认为空
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 交易类型，如包年包月新购、包年包月续费、按量计费扣费等类型
        /// </summary>
        [JsonProperty("ActionTypeName")]
        public string ActionTypeName{ get; set; }

        /// <summary>
        /// 订单ID：包年包月计费模式下对应子订单号。后付费计费模式下账单费用不存在订单概念，可忽略此参数。
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 交易ID：结算扣费单号
        /// </summary>
        [JsonProperty("BillId")]
        public string BillId{ get; set; }

        /// <summary>
        /// 扣费时间：结算扣费时间
        /// </summary>
        [JsonProperty("PayTime")]
        public string PayTime{ get; set; }

        /// <summary>
        /// 开始使用时间：产品服务开始使用时间
        /// </summary>
        [JsonProperty("FeeBeginTime")]
        public string FeeBeginTime{ get; set; }

        /// <summary>
        /// 结束使用时间：产品服务结束使用时间
        /// </summary>
        [JsonProperty("FeeEndTime")]
        public string FeeEndTime{ get; set; }

        /// <summary>
        /// 组件列表
        /// </summary>
        [JsonProperty("ComponentSet")]
        public BillDetailComponent[] ComponentSet{ get; set; }

        /// <summary>
        /// 支付者UIN：支付者的账号 ID，账号 ID 是用户在腾讯云的唯一账号标识
        /// </summary>
        [JsonProperty("PayerUin")]
        public string PayerUin{ get; set; }

        /// <summary>
        /// 使用者UIN：实际使用资源的账号 ID
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 操作者UIN：操作者账号 ID（预付费资源下单或后付费操作开通资源账号的 ID 或者角色 ID ）
        /// </summary>
        [JsonProperty("OperateUin")]
        public string OperateUin{ get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("Tags")]
        public BillTagInfo[] Tags{ get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// 子产品编码
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// 交易类型编码
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// 地域ID
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 价格属性：该组件除单价、时长外的其他影响折扣定价的属性信息
        /// </summary>
        [JsonProperty("PriceInfo")]
        public string[] PriceInfo{ get; set; }

        /// <summary>
        /// 关联交易单据ID：和本笔交易关联单据 ID，如，冲销订单，记录原订单、重结订单，退费单记录对应的原购买订单号
        /// </summary>
        [JsonProperty("AssociatedOrder")]
        public BillDetailAssociatedOrder AssociatedOrder{ get; set; }

        /// <summary>
        /// 计算说明：特殊交易类型计费结算的详细计算说明，如退费及变配
        /// </summary>
        [JsonProperty("Formula")]
        public string Formula{ get; set; }

        /// <summary>
        /// 计费规则：各产品详细的计费规则官网说明链接
        /// </summary>
        [JsonProperty("FormulaUrl")]
        public string FormulaUrl{ get; set; }

        /// <summary>
        /// 账单归属日
        /// </summary>
        [JsonProperty("BillDay")]
        public string BillDay{ get; set; }

        /// <summary>
        /// 账单归属月
        /// </summary>
        [JsonProperty("BillMonth")]
        public string BillMonth{ get; set; }

        /// <summary>
        /// 账单记录ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 国内国际编码
        /// </summary>
        [JsonProperty("RegionType")]
        public string RegionType{ get; set; }

        /// <summary>
        /// 国内国际：资源所属区域类型（国内、国际）
        /// </summary>
        [JsonProperty("RegionTypeName")]
        public string RegionTypeName{ get; set; }

        /// <summary>
        /// 备注属性（实例配置）：其他备注信息，如预留实例的预留实例类型和交易类型、CCN 产品的两端地域信息
        /// </summary>
        [JsonProperty("ReserveDetail")]
        public string ReserveDetail{ get; set; }

        /// <summary>
        /// 优惠对象
        /// </summary>
        [JsonProperty("DiscountObject")]
        public string DiscountObject{ get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        [JsonProperty("DiscountType")]
        public string DiscountType{ get; set; }

        /// <summary>
        /// 优惠内容
        /// </summary>
        [JsonProperty("DiscountContent")]
        public string DiscountContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BusinessCodeName", this.BusinessCodeName);
            this.SetParamSimple(map, prefix + "ProductCodeName", this.ProductCodeName);
            this.SetParamSimple(map, prefix + "PayModeName", this.PayModeName);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ActionTypeName", this.ActionTypeName);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "BillId", this.BillId);
            this.SetParamSimple(map, prefix + "PayTime", this.PayTime);
            this.SetParamSimple(map, prefix + "FeeBeginTime", this.FeeBeginTime);
            this.SetParamSimple(map, prefix + "FeeEndTime", this.FeeEndTime);
            this.SetParamArrayObj(map, prefix + "ComponentSet.", this.ComponentSet);
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "OperateUin", this.OperateUin);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "PriceInfo.", this.PriceInfo);
            this.SetParamObj(map, prefix + "AssociatedOrder.", this.AssociatedOrder);
            this.SetParamSimple(map, prefix + "Formula", this.Formula);
            this.SetParamSimple(map, prefix + "FormulaUrl", this.FormulaUrl);
            this.SetParamSimple(map, prefix + "BillDay", this.BillDay);
            this.SetParamSimple(map, prefix + "BillMonth", this.BillMonth);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "RegionType", this.RegionType);
            this.SetParamSimple(map, prefix + "RegionTypeName", this.RegionTypeName);
            this.SetParamSimple(map, prefix + "ReserveDetail", this.ReserveDetail);
            this.SetParamSimple(map, prefix + "DiscountObject", this.DiscountObject);
            this.SetParamSimple(map, prefix + "DiscountType", this.DiscountType);
            this.SetParamSimple(map, prefix + "DiscountContent", this.DiscountContent);
        }
    }
}

