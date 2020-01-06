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

    public class ProxyInfo : AbstractModel
    {
        
        /// <summary>
        /// （旧参数，请使用ProxyId）通道实例ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 创建时间，采用Unix时间戳的方式，表示从1970年1月1日（UTC/GMT的午夜）开始所经过的秒数。
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 通道名称。
        /// </summary>
        [JsonProperty("ProxyName")]
        public string ProxyName{ get; set; }

        /// <summary>
        /// 接入地域。
        /// </summary>
        [JsonProperty("AccessRegion")]
        public string AccessRegion{ get; set; }

        /// <summary>
        /// 源站地域。
        /// </summary>
        [JsonProperty("RealServerRegion")]
        public string RealServerRegion{ get; set; }

        /// <summary>
        /// 带宽，单位：Mbps。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 并发，单位：个/秒。
        /// </summary>
        [JsonProperty("Concurrent")]
        public long? Concurrent{ get; set; }

        /// <summary>
        /// 通道状态。其中：
        /// RUNNING，运行中；
        /// CREATING，创建中；
        /// DESTROYING，销毁中；
        /// OPENING，开启中；
        /// CLOSING，关闭中；
        /// CLOSED，已关闭；
        /// ADJUSTING，配置变更中；
        /// ISOLATING，隔离中（欠费触发）；
        /// ISOLATED，已隔离（欠费触发）；
        /// CLONING，复制中；
        /// UNKNOWN，未知状态。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 接入域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 接入IP。
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// 通道版本号：1.0，2.0，3.0。
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// （新参数）通道实例ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 1，该通道可缩扩容；0，该通道无法缩扩容。
        /// </summary>
        [JsonProperty("Scalarable")]
        public long? Scalarable{ get; set; }

        /// <summary>
        /// 支持的协议类型。
        /// </summary>
        [JsonProperty("SupportProtocols")]
        public string[] SupportProtocols{ get; set; }

        /// <summary>
        /// 通道组ID，当通道归属于某一通道组时，存在该字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 安全策略ID，当设置了安全策略时，存在该字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// 接入地域详细信息，包括地域ID和地域名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessRegionInfo")]
        public RegionDetail AccessRegionInfo{ get; set; }

        /// <summary>
        /// 源站地域详细信息，包括地域ID和地域名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealServerRegionInfo")]
        public RegionDetail RealServerRegionInfo{ get; set; }

        /// <summary>
        /// 通道转发IP
        /// </summary>
        [JsonProperty("ForwardIP")]
        public string ForwardIP{ get; set; }

        /// <summary>
        /// 标签列表，不存在标签时，该字段为空列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagSet")]
        public TagPair[] TagSet{ get; set; }

        /// <summary>
        /// 是否支持安全组配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportSecurity")]
        public long? SupportSecurity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProxyName", this.ProxyName);
            this.SetParamSimple(map, prefix + "AccessRegion", this.AccessRegion);
            this.SetParamSimple(map, prefix + "RealServerRegion", this.RealServerRegion);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "Concurrent", this.Concurrent);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "Scalarable", this.Scalarable);
            this.SetParamArraySimple(map, prefix + "SupportProtocols.", this.SupportProtocols);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamObj(map, prefix + "AccessRegionInfo.", this.AccessRegionInfo);
            this.SetParamObj(map, prefix + "RealServerRegionInfo.", this.RealServerRegionInfo);
            this.SetParamSimple(map, prefix + "ForwardIP", this.ForwardIP);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "SupportSecurity", this.SupportSecurity);
        }
    }
}

