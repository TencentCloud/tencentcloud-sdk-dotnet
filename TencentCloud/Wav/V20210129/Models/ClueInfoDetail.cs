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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClueInfoDetail : AbstractModel
    {
        
        /// <summary>
        /// 线索id，线索唯一识别编码
        /// </summary>
        [JsonProperty("ClueId")]
        public string ClueId{ get; set; }

        /// <summary>
        /// 接待客户经销商顾问所属经销商code
        /// </summary>
        [JsonProperty("DealerId")]
        public string DealerId{ get; set; }

        /// <summary>
        /// 线索获取时间，用户添加企业微信时间，单位是秒
        /// </summary>
        [JsonProperty("EnquireTime")]
        public ulong? EnquireTime{ get; set; }

        /// <summary>
        /// 客户在微信生态中唯一识别码
        /// </summary>
        [JsonProperty("UnionId")]
        public string UnionId{ get; set; }

        /// <summary>
        /// 微信昵称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 车系编号
        /// </summary>
        [JsonProperty("SeriesCode")]
        public string SeriesCode{ get; set; }

        /// <summary>
        /// 车型编号
        /// </summary>
        [JsonProperty("ModelCode")]
        public string ModelCode{ get; set; }

        /// <summary>
        /// 省份编号
        /// </summary>
        [JsonProperty("ProvinceCode")]
        public string ProvinceCode{ get; set; }

        /// <summary>
        /// 城市编号
        /// </summary>
        [JsonProperty("CityCode")]
        public string CityCode{ get; set; }

        /// <summary>
        /// 顾问名称
        /// </summary>
        [JsonProperty("SalesName")]
        public string SalesName{ get; set; }

        /// <summary>
        /// 顾问电话
        /// </summary>
        [JsonProperty("SalesPhone")]
        public string SalesPhone{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("TagList")]
        public string[] TagList{ get; set; }

        /// <summary>
        /// 客户姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 线索属性，0：个人，1：企业
        /// </summary>
        [JsonProperty("LeadUserType")]
        public long? LeadUserType{ get; set; }

        /// <summary>
        /// 线索来源类型，1：线上，2：线下
        /// </summary>
        [JsonProperty("LeadType")]
        public long? LeadType{ get; set; }

        /// <summary>
        /// 线索渠道对应ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public ulong? ChannelId{ get; set; }

        /// <summary>
        /// 线索渠道类型，与线索来源对应的渠道名称
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 线索渠道名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceChannelName")]
        public string SourceChannelName{ get; set; }

        /// <summary>
        /// 0：未知，1：男，2：女
        /// </summary>
        [JsonProperty("Gender")]
        public long? Gender{ get; set; }

        /// <summary>
        /// 线索创建时间戳，单位：秒
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 线索所处状态，101-待分配 201-待建档 301-已建档 401-已邀约 501-跟进中 601-已下订单 701-已成交 801-战败申请中 901-已战败 1001-未知状态 1101-转移申请中 1201-已完成
        /// </summary>
        [JsonProperty("LeadStatus")]
        public long? LeadStatus{ get; set; }

        /// <summary>
        /// 线索意向等级
        /// </summary>
        [JsonProperty("LevelCode")]
        public string LevelCode{ get; set; }

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
        /// 获取线索的时间戳，单位：秒
        /// </summary>
        [JsonProperty("CreateAtTime")]
        public ulong? CreateAtTime{ get; set; }

        /// <summary>
        /// 客户微信id
        /// </summary>
        [JsonProperty("WxId")]
        public string WxId{ get; set; }

        /// <summary>
        /// 意向车型对应品牌code
        /// </summary>
        [JsonProperty("BrandCode")]
        public string BrandCode{ get; set; }

        /// <summary>
        /// 建档时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BuildTime")]
        public ulong? BuildTime{ get; set; }

        /// <summary>
        /// 下订时间，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderTime")]
        public ulong? OrderTime{ get; set; }

        /// <summary>
        /// 到店时间，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ArrivalTime")]
        public ulong? ArrivalTime{ get; set; }

        /// <summary>
        /// 交车时间，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeliveryTime")]
        public ulong? DeliveryTime{ get; set; }

        /// <summary>
        /// 上次跟进时间，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FollowTime")]
        public ulong? FollowTime{ get; set; }

        /// <summary>
        /// 下次跟进时间，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NextFollowTime")]
        public ulong? NextFollowTime{ get; set; }

        /// <summary>
        /// 线索所属组织id
        /// </summary>
        [JsonProperty("OrgId")]
        public ulong? OrgId{ get; set; }

        /// <summary>
        /// 线索所属组织名称
        /// </summary>
        [JsonProperty("OrgName")]
        public string OrgName{ get; set; }

        /// <summary>
        /// 介绍人姓名
        /// </summary>
        [JsonProperty("Introducer")]
        public string Introducer{ get; set; }

        /// <summary>
        /// 介绍人电话
        /// </summary>
        [JsonProperty("IntroducerPhone")]
        public string IntroducerPhone{ get; set; }

        /// <summary>
        /// 是否关联微信 1 是 0 否
        /// </summary>
        [JsonProperty("IsBindWx")]
        public long? IsBindWx{ get; set; }

        /// <summary>
        /// 是否经过合并 1 是 0 否
        /// </summary>
        [JsonProperty("IsMerge")]
        public long? IsMerge{ get; set; }

        /// <summary>
        /// 是否无效  1 是 0 否
        /// </summary>
        [JsonProperty("IsInvalid")]
        public long? IsInvalid{ get; set; }

        /// <summary>
        /// 无效类型
        /// </summary>
        [JsonProperty("InvalidType")]
        public string InvalidType{ get; set; }

        /// <summary>
        /// 无效类型枚举：
        /// 无意向购买、空错号、未接听、其他
        /// </summary>
        [JsonProperty("InvalidTypeName")]
        public string InvalidTypeName{ get; set; }

        /// <summary>
        /// 由顾问手动输入的无效原因文字
        /// </summary>
        [JsonProperty("InvalidRemark")]
        public string InvalidRemark{ get; set; }

        /// <summary>
        /// 无效时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvalidTime")]
        public ulong? InvalidTime{ get; set; }

        /// <summary>
        /// 经销商名称
        /// </summary>
        [JsonProperty("DealerName")]
        public string DealerName{ get; set; }

        /// <summary>
        /// 经销商下级门店ID
        /// </summary>
        [JsonProperty("ShopId")]
        public ulong? ShopId{ get; set; }

        /// <summary>
        /// 经销商下级门店名称
        /// </summary>
        [JsonProperty("ShopName")]
        public string ShopName{ get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        [JsonProperty("Position")]
        public string Position{ get; set; }

        /// <summary>
        /// 自定义的门店id
        /// </summary>
        [JsonProperty("CorpShopId")]
        public string CorpShopId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClueId", this.ClueId);
            this.SetParamSimple(map, prefix + "DealerId", this.DealerId);
            this.SetParamSimple(map, prefix + "EnquireTime", this.EnquireTime);
            this.SetParamSimple(map, prefix + "UnionId", this.UnionId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "SeriesCode", this.SeriesCode);
            this.SetParamSimple(map, prefix + "ModelCode", this.ModelCode);
            this.SetParamSimple(map, prefix + "ProvinceCode", this.ProvinceCode);
            this.SetParamSimple(map, prefix + "CityCode", this.CityCode);
            this.SetParamSimple(map, prefix + "SalesName", this.SalesName);
            this.SetParamSimple(map, prefix + "SalesPhone", this.SalesPhone);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArraySimple(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "LeadUserType", this.LeadUserType);
            this.SetParamSimple(map, prefix + "LeadType", this.LeadType);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "SourceChannelName", this.SourceChannelName);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LeadStatus", this.LeadStatus);
            this.SetParamSimple(map, prefix + "LevelCode", this.LevelCode);
            this.SetParamSimple(map, prefix + "ImportAtTime", this.ImportAtTime);
            this.SetParamSimple(map, prefix + "DistributeTime", this.DistributeTime);
            this.SetParamSimple(map, prefix + "CreateAtTime", this.CreateAtTime);
            this.SetParamSimple(map, prefix + "WxId", this.WxId);
            this.SetParamSimple(map, prefix + "BrandCode", this.BrandCode);
            this.SetParamSimple(map, prefix + "BuildTime", this.BuildTime);
            this.SetParamSimple(map, prefix + "OrderTime", this.OrderTime);
            this.SetParamSimple(map, prefix + "ArrivalTime", this.ArrivalTime);
            this.SetParamSimple(map, prefix + "DeliveryTime", this.DeliveryTime);
            this.SetParamSimple(map, prefix + "FollowTime", this.FollowTime);
            this.SetParamSimple(map, prefix + "NextFollowTime", this.NextFollowTime);
            this.SetParamSimple(map, prefix + "OrgId", this.OrgId);
            this.SetParamSimple(map, prefix + "OrgName", this.OrgName);
            this.SetParamSimple(map, prefix + "Introducer", this.Introducer);
            this.SetParamSimple(map, prefix + "IntroducerPhone", this.IntroducerPhone);
            this.SetParamSimple(map, prefix + "IsBindWx", this.IsBindWx);
            this.SetParamSimple(map, prefix + "IsMerge", this.IsMerge);
            this.SetParamSimple(map, prefix + "IsInvalid", this.IsInvalid);
            this.SetParamSimple(map, prefix + "InvalidType", this.InvalidType);
            this.SetParamSimple(map, prefix + "InvalidTypeName", this.InvalidTypeName);
            this.SetParamSimple(map, prefix + "InvalidRemark", this.InvalidRemark);
            this.SetParamSimple(map, prefix + "InvalidTime", this.InvalidTime);
            this.SetParamSimple(map, prefix + "DealerName", this.DealerName);
            this.SetParamSimple(map, prefix + "ShopId", this.ShopId);
            this.SetParamSimple(map, prefix + "ShopName", this.ShopName);
            this.SetParamSimple(map, prefix + "Position", this.Position);
            this.SetParamSimple(map, prefix + "CorpShopId", this.CorpShopId);
        }
    }
}

