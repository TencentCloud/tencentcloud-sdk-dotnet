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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TargetGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 目标组ID
        /// </summary>
        [JsonProperty("TargetGroupId")]
        public string TargetGroupId{ get; set; }

        /// <summary>
        /// 目标组的vpcid
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 目标组的名字
        /// </summary>
        [JsonProperty("TargetGroupName")]
        public string TargetGroupName{ get; set; }

        /// <summary>
        /// 目标组的默认端口，全监听目标组此字段返回0，表示无效端口。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 目标组的创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 目标组的修改时间
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// 关联到的规则数组。在DescribeTargetGroupList接口调用时无法获取到该参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssociatedRule")]
        public AssociationItem[] AssociatedRule{ get; set; }

        /// <summary>
        /// 后端转发协议类型，支持类型TCP， UDP。仅V2新版目标组支持返回该参数。
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 目标组类型，当前支持v1(旧版目标组), v2(新版目标组), gwlb(全局负载均衡目标组)。
        /// </summary>
        [JsonProperty("TargetGroupType")]
        public string TargetGroupType{ get; set; }

        /// <summary>
        /// 目标组已关联的规则数。
        /// </summary>
        [JsonProperty("AssociatedRuleCount")]
        public long? AssociatedRuleCount{ get; set; }

        /// <summary>
        /// 目标组内的实例数量。
        /// </summary>
        [JsonProperty("RegisteredInstancesCount")]
        public long? RegisteredInstancesCount{ get; set; }

        /// <summary>
        /// 标签。
        /// </summary>
        [JsonProperty("Tag")]
        public TagInfo[] Tag{ get; set; }

        /// <summary>
        /// 默认权重。只有v2类型目标组返回该字段。当返回为NULL时， 表示未设置默认权重。
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// 是否全监听目标组
        /// </summary>
        [JsonProperty("FullListenSwitch")]
        public bool? FullListenSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetGroupId", this.TargetGroupId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "TargetGroupName", this.TargetGroupName);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamArrayObj(map, prefix + "AssociatedRule.", this.AssociatedRule);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "TargetGroupType", this.TargetGroupType);
            this.SetParamSimple(map, prefix + "AssociatedRuleCount", this.AssociatedRuleCount);
            this.SetParamSimple(map, prefix + "RegisteredInstancesCount", this.RegisteredInstancesCount);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "FullListenSwitch", this.FullListenSwitch);
        }
    }
}

