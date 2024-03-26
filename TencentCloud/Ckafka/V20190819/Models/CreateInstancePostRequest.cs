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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstancePostRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例名称，是一个不超过 64 个字符的字符串，必须以字母为首字符，剩余部分可以包含字母、数字和横划线(-)
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 创建的实例默认接入点所在的 vpc 对应 vpcId。目前不支持创建基础网络实例，因此该参数必填
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网id。创建实例默认接入点所在的子网对应的子网 id
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 实例内网峰值带宽。单位 MB/s。标准版需传入当前实例规格所对应的峰值带宽。注意如果创建的实例为专业版实例，峰值带宽，分区数等参数配置需要满足专业版的计费规格。
        /// </summary>
        [JsonProperty("BandWidth")]
        public long? BandWidth{ get; set; }

        /// <summary>
        /// 国际站标准版实例规格。目前只有国际站标准版使用当前字段区分规格，国内站标准版使用峰值带宽区分规格。除了国际站标准版外的所有实例填写 1 即可。国际站标准版实例：入门型(general)]填写1；[标准型(standard)]填写2；[进阶型(advanced)]填写3；[容量型(capacity)]填写4；[高阶型1(specialized-1)]填写5；[高阶型2(specialized-2)]填写6；[高阶型3(specialized-3)]填写7；[高阶型4(specialized-4)]填写8。
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// 实例日志的默认最长保留时间，单位分钟。不传入该参数时默认为 1440 分钟（1天），最大30天。当 topic 显式设置消息保留时间时，以 topic 保留时间为准
        /// </summary>
        [JsonProperty("MsgRetentionTime")]
        public long? MsgRetentionTime{ get; set; }

        /// <summary>
        /// 创建实例时可以选择集群Id, 该入参表示集群Id。不指定实例所在集群则不传入该参数
        /// </summary>
        [JsonProperty("ClusterId")]
        public long? ClusterId{ get; set; }

        /// <summary>
        /// 实例版本。目前支持 "0.10.2","1.1.1","2.4.1","2.4.2","2.8.1"。"2.4.1" 与 "2.4.2" 属于同一个版本，传任意一个均可。
        /// </summary>
        [JsonProperty("KafkaVersion")]
        public string KafkaVersion{ get; set; }

        /// <summary>
        /// 实例类型。"standard"：标准版，"profession"：专业版
        /// </summary>
        [JsonProperty("SpecificationsType")]
        public string SpecificationsType{ get; set; }

        /// <summary>
        /// 专业版实例磁盘类型，标准版实例不需要填写。"CLOUD_SSD"：SSD云硬盘；"CLOUD_BASIC"：高性能云硬盘。不传默认值为 "CLOUD_BASIC"
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 实例硬盘大小，需要满足当前实例的计费规格
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 实例最大分区数量，需要满足当前实例的计费规格
        /// </summary>
        [JsonProperty("Partition")]
        public long? Partition{ get; set; }

        /// <summary>
        /// 实例最大 topic 数量，需要满足当前实例的计费规格
        /// </summary>
        [JsonProperty("TopicNum")]
        public long? TopicNum{ get; set; }

        /// <summary>
        /// 实例所在的可用区。当创建多可用区实例时，该参数为创建的默认接入点所在子网的可用区 id
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// 当前实例是否为多可用区实例。
        /// </summary>
        [JsonProperty("MultiZoneFlag")]
        public bool? MultiZoneFlag{ get; set; }

        /// <summary>
        /// 当实例为多可用区实例时，多可用区 id 列表。注意参数 ZoneId 对应的多可用区需要包含在该参数数组中
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// 购买实例数量。非必填，默认值为 1。当传入该参数时，会创建多个 instanceName 加后缀区分的实例
        /// </summary>
        [JsonProperty("InstanceNum")]
        public long? InstanceNum{ get; set; }

        /// <summary>
        /// 公网带宽大小，单位 Mbps。默认是没有加上免费 3Mbps 带宽。例如总共需要 3Mbps 公网带宽，此处传 0；总共需要 6Mbps 公网带宽，此处传 3。需要保证传入参数为 3 的整数倍
        /// </summary>
        [JsonProperty("PublicNetworkMonthly")]
        public long? PublicNetworkMonthly{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "BandWidth", this.BandWidth);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "MsgRetentionTime", this.MsgRetentionTime);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "KafkaVersion", this.KafkaVersion);
            this.SetParamSimple(map, prefix + "SpecificationsType", this.SpecificationsType);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
            this.SetParamSimple(map, prefix + "TopicNum", this.TopicNum);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "MultiZoneFlag", this.MultiZoneFlag);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
            this.SetParamSimple(map, prefix + "PublicNetworkMonthly", this.PublicNetworkMonthly);
        }
    }
}

