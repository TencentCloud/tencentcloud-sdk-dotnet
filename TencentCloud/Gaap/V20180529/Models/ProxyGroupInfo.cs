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

    public class ProxyGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 通道组id
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 通道组域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 通道组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 目标地域
        /// </summary>
        [JsonProperty("RealServerRegionInfo")]
        public RegionDetail RealServerRegionInfo{ get; set; }

        /// <summary>
        /// 通道组状态。
        /// 其中，
        /// RUNNING表示运行中；
        /// CREATING表示创建中；
        /// DESTROYING表示销毁中；
        /// MOVING表示通道迁移中；
        /// CLOSED表示已关闭；
        /// CHANGING表示部分部署中。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 标签列表。
        /// </summary>
        [JsonProperty("TagSet")]
        public TagPair[] TagSet{ get; set; }

        /// <summary>
        /// 通道组版本
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 通道组是否包含微软通道
        /// </summary>
        [JsonProperty("ProxyType")]
        public ulong? ProxyType{ get; set; }

        /// <summary>
        /// 支持Http3特性的标识，其中：
        /// 0表示关闭；
        /// 1表示启用。
        /// </summary>
        [JsonProperty("Http3Supported")]
        public long? Http3Supported{ get; set; }

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
        public long? FeatureBitmap{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamObj(map, prefix + "RealServerRegionInfo.", this.RealServerRegionInfo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ProxyType", this.ProxyType);
            this.SetParamSimple(map, prefix + "Http3Supported", this.Http3Supported);
            this.SetParamSimple(map, prefix + "FeatureBitmap", this.FeatureBitmap);
        }
    }
}

