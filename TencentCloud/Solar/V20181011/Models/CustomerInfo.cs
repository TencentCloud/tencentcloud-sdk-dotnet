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

namespace TencentCloud.Solar.V20181011.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomerInfo : AbstractModel
    {
        
        /// <summary>
        /// 总活跃度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Activity")]
        public long? Activity{ get; set; }

        /// <summary>
        /// 客户ID
        /// </summary>
        [JsonProperty("AudienceUserId")]
        public string AudienceUserId{ get; set; }

        /// <summary>
        /// 头像
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Avatar")]
        public string Avatar{ get; set; }

        /// <summary>
        /// 最近记录城市
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 最活跃时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastActiveTime")]
        public string LastActiveTime{ get; set; }

        /// <summary>
        /// 是否星标客户
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MarkFlag")]
        public string MarkFlag{ get; set; }

        /// <summary>
        /// 30天活跃度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonthActive")]
        public long? MonthActive{ get; set; }

        /// <summary>
        /// 30天推荐度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonthRecommend")]
        public long? MonthRecommend{ get; set; }

        /// <summary>
        /// 手机号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 最近记录省份
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealName")]
        public string RealName{ get; set; }

        /// <summary>
        /// 员工标识 0 未关联 1 已关联
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelChannelFlag")]
        public long? RelChannelFlag{ get; set; }

        /// <summary>
        /// 性别 1男 2女
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sex")]
        public long? Sex{ get; set; }

        /// <summary>
        /// 传播力（好友数）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Spread")]
        public long? Spread{ get; set; }

        /// <summary>
        /// 7天活跃度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WeekActive")]
        public long? WeekActive{ get; set; }

        /// <summary>
        /// 7天推荐度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WeekRecommend")]
        public long? WeekRecommend{ get; set; }

        /// <summary>
        /// 微信城市
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WxCity")]
        public string WxCity{ get; set; }

        /// <summary>
        /// 微信国家或地区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WxCountry")]
        public string WxCountry{ get; set; }

        /// <summary>
        /// 微信呢称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WxNickname")]
        public string WxNickname{ get; set; }

        /// <summary>
        /// 微信省份
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WxProvince")]
        public string WxProvince{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Activity", this.Activity);
            this.SetParamSimple(map, prefix + "AudienceUserId", this.AudienceUserId);
            this.SetParamSimple(map, prefix + "Avatar", this.Avatar);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "LastActiveTime", this.LastActiveTime);
            this.SetParamSimple(map, prefix + "MarkFlag", this.MarkFlag);
            this.SetParamSimple(map, prefix + "MonthActive", this.MonthActive);
            this.SetParamSimple(map, prefix + "MonthRecommend", this.MonthRecommend);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "RealName", this.RealName);
            this.SetParamSimple(map, prefix + "RelChannelFlag", this.RelChannelFlag);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "Spread", this.Spread);
            this.SetParamSimple(map, prefix + "WeekActive", this.WeekActive);
            this.SetParamSimple(map, prefix + "WeekRecommend", this.WeekRecommend);
            this.SetParamSimple(map, prefix + "WxCity", this.WxCity);
            this.SetParamSimple(map, prefix + "WxCountry", this.WxCountry);
            this.SetParamSimple(map, prefix + "WxNickname", this.WxNickname);
            this.SetParamSimple(map, prefix + "WxProvince", this.WxProvince);
        }
    }
}

