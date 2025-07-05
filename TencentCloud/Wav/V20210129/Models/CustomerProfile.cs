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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomerProfile : AbstractModel
    {
        
        /// <summary>
        /// 客户档案id，客户唯一识别编码
        /// </summary>
        [JsonProperty("CustomerId")]
        public ulong? CustomerId{ get; set; }

        /// <summary>
        /// 所属经销商id
        /// </summary>
        [JsonProperty("DealerCode")]
        public string DealerCode{ get; set; }

        /// <summary>
        /// 客户在微信生态中唯一识别码
        /// </summary>
        [JsonProperty("UnionId")]
        public string UnionId{ get; set; }

        /// <summary>
        /// 档案创建时间戳，单位：秒
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 客户姓名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 0未知，1：男，2：女
        /// </summary>
        [JsonProperty("Gender")]
        public long? Gender{ get; set; }

        /// <summary>
        /// 客户联系手机号
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 客户年龄段名称
        /// </summary>
        [JsonProperty("AgeRangeName")]
        public string AgeRangeName{ get; set; }

        /// <summary>
        /// 客户行业类型名称信息，如教师、医生
        /// </summary>
        [JsonProperty("JobTypeName")]
        public string JobTypeName{ get; set; }

        /// <summary>
        /// 客户居住地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 客户所处状态
        ///  0:已分配 1:未分配 1 待建档, 2 已建档， 3 已到店 4 已经试驾 5 战败申请中 6 已战败 7 已成交 
        /// </summary>
        [JsonProperty("LeadsProcessStatus")]
        public long? LeadsProcessStatus{ get; set; }

        /// <summary>
        /// 客户来源类型，1：线上，2：线下
        /// </summary>
        [JsonProperty("LeadType")]
        public long? LeadType{ get; set; }

        /// <summary>
        /// 与客户来源类型对应的渠道名称
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// 客户购车的意向等级
        /// </summary>
        [JsonProperty("LeadsLevelCode")]
        public string LeadsLevelCode{ get; set; }

        /// <summary>
        /// 客户意向品牌编号
        /// </summary>
        [JsonProperty("VehicleBrandCode")]
        public string VehicleBrandCode{ get; set; }

        /// <summary>
        /// 客户意向车系编号
        /// </summary>
        [JsonProperty("VehicleSeriesCode")]
        public string VehicleSeriesCode{ get; set; }

        /// <summary>
        /// 客户意向车型编号
        /// </summary>
        [JsonProperty("VehicleTypeCode")]
        public string VehicleTypeCode{ get; set; }

        /// <summary>
        /// 购车用途信息
        /// </summary>
        [JsonProperty("VehiclePurpose")]
        public VehiclePurpose VehiclePurpose{ get; set; }

        /// <summary>
        /// 购车关注点信息
        /// </summary>
        [JsonProperty("PurchaseConcern")]
        public PurchaseConcern[] PurchaseConcern{ get; set; }

        /// <summary>
        /// 客户所属顾问姓名
        /// </summary>
        [JsonProperty("SalesName")]
        public string SalesName{ get; set; }

        /// <summary>
        /// 客户所属顾问手机号
        /// </summary>
        [JsonProperty("SalesPhone")]
        public string SalesPhone{ get; set; }

        /// <summary>
        /// 客户实际到店时间戳，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealArrivalTime")]
        public ulong? RealArrivalTime{ get; set; }

        /// <summary>
        /// 客户到店完成试乘试驾时间戳，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompleteTestDriveTime")]
        public string CompleteTestDriveTime{ get; set; }

        /// <summary>
        /// 客户完成下订的时间戳，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderTime")]
        public ulong? OrderTime{ get; set; }

        /// <summary>
        /// 客户成交的时间戳，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeliveryTime")]
        public ulong? DeliveryTime{ get; set; }

        /// <summary>
        /// 开票时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvoiceTime")]
        public ulong? InvoiceTime{ get; set; }

        /// <summary>
        /// 完成对此客户战败审批的时间戳，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoseTime")]
        public ulong? LoseTime{ get; set; }

        /// <summary>
        /// 线索成功获取的时间戳，单位：秒
        /// </summary>
        [JsonProperty("CreatedAtTime")]
        public ulong? CreatedAtTime{ get; set; }

        /// <summary>
        /// 线索成功导入的时间戳，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImportAtTime")]
        public ulong? ImportAtTime{ get; set; }

        /// <summary>
        /// 完成线索分配的时间戳，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DistributeTime")]
        public ulong? DistributeTime{ get; set; }

        /// <summary>
        /// 线索成功创建的时间戳，单位：秒
        /// </summary>
        [JsonProperty("LeadCreateTime")]
        public ulong? LeadCreateTime{ get; set; }

        /// <summary>
        /// 线索关联微信昵称
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 线索归属部门节点
        /// </summary>
        [JsonProperty("OrgIdList")]
        public string[] OrgIdList{ get; set; }

        /// <summary>
        /// 客户的介绍人姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Introducer")]
        public string Introducer{ get; set; }

        /// <summary>
        /// 客户的介绍人手机号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntroducerPhone")]
        public string IntroducerPhone{ get; set; }

        /// <summary>
        /// 最近一次完成跟进的时间戳，单位：秒
        /// </summary>
        [JsonProperty("FollowTime")]
        public ulong? FollowTime{ get; set; }

        /// <summary>
        /// 最近一次计划跟进的时间戳，单位：秒
        /// </summary>
        [JsonProperty("NextFollowTime")]
        public ulong? NextFollowTime{ get; set; }

        /// <summary>
        /// 已为该客户添加的企业标签信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnterpriseTags")]
        public EnterpriseTag[] EnterpriseTags{ get; set; }

        /// <summary>
        /// 已为该客户添加的渠道标签信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelTags")]
        public ChannelTag[] ChannelTags{ get; set; }

        /// <summary>
        /// 关联线索id
        /// </summary>
        [JsonProperty("LeadId")]
        public ulong? LeadId{ get; set; }

        /// <summary>
        /// 客户微信id
        /// </summary>
        [JsonProperty("WxId")]
        public string WxId{ get; set; }

        /// <summary>
        /// 顾问职位
        /// </summary>
        [JsonProperty("Position")]
        public string Position{ get; set; }

        /// <summary>
        /// 是否关联微信 1 是 0 否
        /// </summary>
        [JsonProperty("IsBindWx")]
        public long? IsBindWx{ get; set; }

        /// <summary>
        /// 是否无效
        /// </summary>
        [JsonProperty("IsInvalid")]
        public long? IsInvalid{ get; set; }

        /// <summary>
        /// 无效类型
        /// </summary>
        [JsonProperty("InvalidType")]
        public string InvalidType{ get; set; }

        /// <summary>
        /// 无效类型名称
        /// </summary>
        [JsonProperty("InvalidTypeName")]
        public string InvalidTypeName{ get; set; }

        /// <summary>
        /// 无效时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvalidTime")]
        public ulong? InvalidTime{ get; set; }

        /// <summary>
        /// 由顾问手动输入的无效原因文字
        /// </summary>
        [JsonProperty("InvalidRemark")]
        public string InvalidRemark{ get; set; }

        /// <summary>
        /// 线索是否战败
        /// </summary>
        [JsonProperty("IsLose")]
        public long? IsLose{ get; set; }

        /// <summary>
        /// 战败类型
        /// </summary>
        [JsonProperty("LoseType")]
        public string LoseType{ get; set; }

        /// <summary>
        /// 战败类型名称
        /// </summary>
        [JsonProperty("LoseTypeName")]
        public string LoseTypeName{ get; set; }

        /// <summary>
        /// 战败申请原因
        /// </summary>
        [JsonProperty("LoseRemark")]
        public string LoseRemark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerId", this.CustomerId);
            this.SetParamSimple(map, prefix + "DealerCode", this.DealerCode);
            this.SetParamSimple(map, prefix + "UnionId", this.UnionId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "AgeRangeName", this.AgeRangeName);
            this.SetParamSimple(map, prefix + "JobTypeName", this.JobTypeName);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "LeadsProcessStatus", this.LeadsProcessStatus);
            this.SetParamSimple(map, prefix + "LeadType", this.LeadType);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "LeadsLevelCode", this.LeadsLevelCode);
            this.SetParamSimple(map, prefix + "VehicleBrandCode", this.VehicleBrandCode);
            this.SetParamSimple(map, prefix + "VehicleSeriesCode", this.VehicleSeriesCode);
            this.SetParamSimple(map, prefix + "VehicleTypeCode", this.VehicleTypeCode);
            this.SetParamObj(map, prefix + "VehiclePurpose.", this.VehiclePurpose);
            this.SetParamArrayObj(map, prefix + "PurchaseConcern.", this.PurchaseConcern);
            this.SetParamSimple(map, prefix + "SalesName", this.SalesName);
            this.SetParamSimple(map, prefix + "SalesPhone", this.SalesPhone);
            this.SetParamSimple(map, prefix + "RealArrivalTime", this.RealArrivalTime);
            this.SetParamSimple(map, prefix + "CompleteTestDriveTime", this.CompleteTestDriveTime);
            this.SetParamSimple(map, prefix + "OrderTime", this.OrderTime);
            this.SetParamSimple(map, prefix + "DeliveryTime", this.DeliveryTime);
            this.SetParamSimple(map, prefix + "InvoiceTime", this.InvoiceTime);
            this.SetParamSimple(map, prefix + "LoseTime", this.LoseTime);
            this.SetParamSimple(map, prefix + "CreatedAtTime", this.CreatedAtTime);
            this.SetParamSimple(map, prefix + "ImportAtTime", this.ImportAtTime);
            this.SetParamSimple(map, prefix + "DistributeTime", this.DistributeTime);
            this.SetParamSimple(map, prefix + "LeadCreateTime", this.LeadCreateTime);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamArraySimple(map, prefix + "OrgIdList.", this.OrgIdList);
            this.SetParamSimple(map, prefix + "Introducer", this.Introducer);
            this.SetParamSimple(map, prefix + "IntroducerPhone", this.IntroducerPhone);
            this.SetParamSimple(map, prefix + "FollowTime", this.FollowTime);
            this.SetParamSimple(map, prefix + "NextFollowTime", this.NextFollowTime);
            this.SetParamArrayObj(map, prefix + "EnterpriseTags.", this.EnterpriseTags);
            this.SetParamArrayObj(map, prefix + "ChannelTags.", this.ChannelTags);
            this.SetParamSimple(map, prefix + "LeadId", this.LeadId);
            this.SetParamSimple(map, prefix + "WxId", this.WxId);
            this.SetParamSimple(map, prefix + "Position", this.Position);
            this.SetParamSimple(map, prefix + "IsBindWx", this.IsBindWx);
            this.SetParamSimple(map, prefix + "IsInvalid", this.IsInvalid);
            this.SetParamSimple(map, prefix + "InvalidType", this.InvalidType);
            this.SetParamSimple(map, prefix + "InvalidTypeName", this.InvalidTypeName);
            this.SetParamSimple(map, prefix + "InvalidTime", this.InvalidTime);
            this.SetParamSimple(map, prefix + "InvalidRemark", this.InvalidRemark);
            this.SetParamSimple(map, prefix + "IsLose", this.IsLose);
            this.SetParamSimple(map, prefix + "LoseType", this.LoseType);
            this.SetParamSimple(map, prefix + "LoseTypeName", this.LoseTypeName);
            this.SetParamSimple(map, prefix + "LoseRemark", this.LoseRemark);
        }
    }
}

