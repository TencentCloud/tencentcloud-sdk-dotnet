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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NativeGatewayServerGroup : AbstractModel
    {
        
        /// <summary>
        /// 云原生网关分组唯一id
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 分组名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 节点规格、节点数信息
        /// </summary>
        [JsonProperty("NodeConfig")]
        public CloudNativeAPIGatewayNodeConfig NodeConfig{ get; set; }

        /// <summary>
        /// 网关分组状态。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 是否是默认分组。
        /// 0：否。
        /// 1：是。
        /// </summary>
        [JsonProperty("IsFirstGroup")]
        public long? IsFirstGroup{ get; set; }

        /// <summary>
        /// 关联策略信息
        /// </summary>
        [JsonProperty("BindingStrategy")]
        public CloudNativeAPIGatewayStrategy BindingStrategy{ get; set; }

        /// <summary>
        /// 网关实例 id
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 带宽
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 子网id
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string SubnetIds{ get; set; }

        /// <summary>
        /// 分组默认权重
        /// </summary>
        [JsonProperty("DefaultWeight")]
        public long? DefaultWeight{ get; set; }

        /// <summary>
        /// 弹性节点
        /// </summary>
        [JsonProperty("ElasticNumber")]
        public ulong? ElasticNumber{ get; set; }

        /// <summary>
        /// 是否支持TOA
        /// </summary>
        [JsonProperty("SupportTOA")]
        public bool? SupportTOA{ get; set; }

        /// <summary>
        /// 是否支持IPV6
        /// </summary>
        [JsonProperty("SupportIPV6")]
        public bool? SupportIPV6{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "NodeConfig.", this.NodeConfig);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IsFirstGroup", this.IsFirstGroup);
            this.SetParamObj(map, prefix + "BindingStrategy.", this.BindingStrategy);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "SubnetIds", this.SubnetIds);
            this.SetParamSimple(map, prefix + "DefaultWeight", this.DefaultWeight);
            this.SetParamSimple(map, prefix + "ElasticNumber", this.ElasticNumber);
            this.SetParamSimple(map, prefix + "SupportTOA", this.SupportTOA);
            this.SetParamSimple(map, prefix + "SupportIPV6", this.SupportIPV6);
        }
    }
}

