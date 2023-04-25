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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegionDetail : AbstractModel
    {
        
        /// <summary>
        /// 区域ID
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// 区域英文名或中文名
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// 机房所属大区
        /// </summary>
        [JsonProperty("RegionArea")]
        public string RegionArea{ get; set; }

        /// <summary>
        /// 机房所属大区名
        /// </summary>
        [JsonProperty("RegionAreaName")]
        public string RegionAreaName{ get; set; }

        /// <summary>
        /// 机房类型, dc表示DataCenter数据中心, ec表示EdgeComputing边缘节点
        /// </summary>
        [JsonProperty("IDCType")]
        public string IDCType{ get; set; }

        /// <summary>
        /// 特性位图，每个bit位代表一种特性，其中：
        /// 0，表示不支持该特性；
        /// 1，表示支持该特性。
        /// 特性位图含义如下（从右往左）：
        /// 第1个bit，支持4层加速；
        /// 第2个bit，支持7层加速；
        /// 第3个bit，支持Http3接入；
        /// 第4个bit，支持IPv6；
        /// 第5个bit，支持精品BGP接入；
        /// 第6个bit，支持三网接入；
        /// 第7个bit，支持接入段Qos加速。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FeatureBitmap")]
        public ulong? FeatureBitmap{ get; set; }

        /// <summary>
        /// 接入区域支持的能力
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportFeature")]
        public SupportFeature SupportFeature{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "RegionArea", this.RegionArea);
            this.SetParamSimple(map, prefix + "RegionAreaName", this.RegionAreaName);
            this.SetParamSimple(map, prefix + "IDCType", this.IDCType);
            this.SetParamSimple(map, prefix + "FeatureBitmap", this.FeatureBitmap);
            this.SetParamObj(map, prefix + "SupportFeature.", this.SupportFeature);
        }
    }
}

