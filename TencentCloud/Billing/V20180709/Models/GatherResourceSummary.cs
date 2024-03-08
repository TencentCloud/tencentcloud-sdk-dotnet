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

    public class GatherResourceSummary : AbstractModel
    {
        
        /// <summary>
        /// 支付者 UIN：支付者的账号 ID，账号 ID 是用户在腾讯云的唯一账号标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayerUin")]
        public string PayerUin{ get; set; }

        /// <summary>
        /// 使用者 UIN：实际使用资源的账号 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 操作者 UIN：操作者账号 ID（预付费资源下单或后付费操作开通资源账号的ID或者角色 ID）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperateUin")]
        public string OperateUin{ get; set; }

        /// <summary>
        /// 实例类型编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 实例类型：购买的产品服务对应的实例类型，包括资源包、RI、SP、竞价实例。常规实例默认展示“-”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceTypeName")]
        public string InstanceTypeName{ get; set; }

        /// <summary>
        /// 资源ID：账单中出账对象 ID，不同产品因资源形态不同，资源内容不完全相同，如云服务器 CVM 为对应的实例 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 实例名称：用户在控制台为资源设置的名称，如未设置默认为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 分账单元唯一标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TreeNodeUniqKey")]
        public string TreeNodeUniqKey{ get; set; }

        /// <summary>
        /// 分账单元名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TreeNodeUniqKeyName")]
        public string TreeNodeUniqKeyName{ get; set; }

        /// <summary>
        /// 资源命中公摊规则ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// 资源命中公摊规则名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 产品编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// 产品名称：用户所采购的各类云产品
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessCodeName")]
        public string BusinessCodeName{ get; set; }

        /// <summary>
        /// 组件名称编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ItemCode")]
        public string ItemCode{ get; set; }

        /// <summary>
        /// 组件名称：用户购买的产品或服务，所包含的具体组件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ItemCodeName")]
        public string ItemCodeName{ get; set; }

        /// <summary>
        /// 地域ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// 地域名称：资源所属地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// 分账标签：资源绑定的标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tag")]
        public BillTag[] Tag{ get; set; }

        /// <summary>
        /// 优惠后总价：优惠后总价 =（原价 - 预留实例抵扣原价 - 节省计划抵扣原价）* 折扣率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public string RealTotalCost{ get; set; }

        /// <summary>
        /// 现金账户支出(元)：通过现金账户支付的金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CashPayAmount")]
        public string CashPayAmount{ get; set; }

        /// <summary>
        /// 代金券支出(元)：使用各类优惠券（如代金券、现金券等）支付的金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VoucherPayAmount")]
        public string VoucherPayAmount{ get; set; }

        /// <summary>
        /// 赠送账户支出(元)：使用赠送金支付的金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncentivePayAmount")]
        public string IncentivePayAmount{ get; set; }

        /// <summary>
        /// 分成账户支出(元)：通过分成金账户支付的金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransferPayAmount")]
        public string TransferPayAmount{ get; set; }

        /// <summary>
        /// 费用归集类型：费用来源类型，分摊、归集、未分配
        /// 0 - 分摊
        /// 1 - 归集
        /// -1 - 未分配
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllocationType")]
        public long? AllocationType{ get; set; }

        /// <summary>
        /// 当前归属单元信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BelongTreeNodeUniqKey")]
        public AllocationTreeNode BelongTreeNodeUniqKey{ get; set; }

        /// <summary>
        /// 当前资源命中公摊规则信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BelongRule")]
        public AllocationRule BelongRule{ get; set; }

        /// <summary>
        /// 其它归属单元信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherTreeNodeUniqKeys")]
        public AllocationTreeNode[] OtherTreeNodeUniqKeys{ get; set; }

        /// <summary>
        /// 其他命中规则信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherRules")]
        public AllocationRule[] OtherRules{ get; set; }

        /// <summary>
        /// 项目ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 项目名称：资源归属的项目，用户在控制台给资源自主分配项目，未分配则是默认项目
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 子产品编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// 子产品名称：用户采购的具体产品细分类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductCodeName")]
        public string ProductCodeName{ get; set; }

        /// <summary>
        /// 计费模式编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 计费模式：资源的计费模式，区分为包年包月和按量计费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayModeName")]
        public string PayModeName{ get; set; }

        /// <summary>
        /// 交易类型编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// 交易类型：明细交易类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionTypeName")]
        public string ActionTypeName{ get; set; }

        /// <summary>
        /// 分拆项 ID：涉及分拆产品的分拆后的分拆项 ID，如 COS 桶 ID，CDN 域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SplitItemId")]
        public string SplitItemId{ get; set; }

        /// <summary>
        /// 分拆项名称：涉及分拆产品的分拆后的分拆项
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SplitItemName")]
        public string SplitItemName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "OperateUin", this.OperateUin);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceTypeName", this.InstanceTypeName);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "TreeNodeUniqKey", this.TreeNodeUniqKey);
            this.SetParamSimple(map, prefix + "TreeNodeUniqKeyName", this.TreeNodeUniqKeyName);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "BusinessCodeName", this.BusinessCodeName);
            this.SetParamSimple(map, prefix + "ItemCode", this.ItemCode);
            this.SetParamSimple(map, prefix + "ItemCodeName", this.ItemCodeName);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
            this.SetParamSimple(map, prefix + "CashPayAmount", this.CashPayAmount);
            this.SetParamSimple(map, prefix + "VoucherPayAmount", this.VoucherPayAmount);
            this.SetParamSimple(map, prefix + "IncentivePayAmount", this.IncentivePayAmount);
            this.SetParamSimple(map, prefix + "TransferPayAmount", this.TransferPayAmount);
            this.SetParamSimple(map, prefix + "AllocationType", this.AllocationType);
            this.SetParamObj(map, prefix + "BelongTreeNodeUniqKey.", this.BelongTreeNodeUniqKey);
            this.SetParamObj(map, prefix + "BelongRule.", this.BelongRule);
            this.SetParamArrayObj(map, prefix + "OtherTreeNodeUniqKeys.", this.OtherTreeNodeUniqKeys);
            this.SetParamArrayObj(map, prefix + "OtherRules.", this.OtherRules);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "ProductCodeName", this.ProductCodeName);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "PayModeName", this.PayModeName);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "ActionTypeName", this.ActionTypeName);
            this.SetParamSimple(map, prefix + "SplitItemId", this.SplitItemId);
            this.SetParamSimple(map, prefix + "SplitItemName", this.SplitItemName);
        }
    }
}

