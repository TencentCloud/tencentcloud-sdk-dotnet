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

    public class CreateCloudNativeAPIGatewayRequest : AbstractModel
    {
        
        /// <summary>
        /// 云原生API网关名字, 最多支持60个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 云原生API网关类型, 目前只支持kong。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 云原生API网关版本。参考值：
        /// - 2.4.1
        /// - 2.5.1
        /// </summary>
        [JsonProperty("GatewayVersion")]
        public string GatewayVersion{ get; set; }

        /// <summary>
        /// 云原生API网关节点配置。
        /// </summary>
        [JsonProperty("NodeConfig")]
        public CloudNativeAPIGatewayNodeConfig NodeConfig{ get; set; }

        /// <summary>
        /// 云原生API网关vpc配置。
        /// </summary>
        [JsonProperty("VpcConfig")]
        public CloudNativeAPIGatewayVpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// 云原生API网关描述信息, 最多支持120个字符。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public InstanceTagInfo[] Tags{ get; set; }

        /// <summary>
        /// 是否开启 CLS 日志。默认值：fasle
        /// </summary>
        [JsonProperty("EnableCls")]
        public bool? EnableCls{ get; set; }

        /// <summary>
        /// 产品版本。参考值：
        /// - TRIAL：开发版
        /// - STANDARD：标准版 （默认值）
        /// - PROFESSIONAL：专业版
        /// </summary>
        [JsonProperty("FeatureVersion")]
        public string FeatureVersion{ get; set; }

        /// <summary>
        /// 公网出流量带宽，[1,2048]Mbps
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 实例实际的地域信息，默认值：ap-guangzhou
        /// </summary>
        [JsonProperty("EngineRegion")]
        public string EngineRegion{ get; set; }

        /// <summary>
        /// ingress Class名称
        /// </summary>
        [JsonProperty("IngressClassName")]
        public string IngressClassName{ get; set; }

        /// <summary>
        /// 付费类型。参考值：
        /// 0：后付费（默认值）
        /// 1：预付费（接口暂不支持创建预付费实例）
        /// </summary>
        [JsonProperty("TradeType")]
        public long? TradeType{ get; set; }

        /// <summary>
        /// 公网相关配置
        /// </summary>
        [JsonProperty("InternetConfig")]
        public InternetConfig InternetConfig{ get; set; }

        /// <summary>
        /// 关联的prometheus ID
        /// </summary>
        [JsonProperty("PromId")]
        public string PromId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "GatewayVersion", this.GatewayVersion);
            this.SetParamObj(map, prefix + "NodeConfig.", this.NodeConfig);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "EnableCls", this.EnableCls);
            this.SetParamSimple(map, prefix + "FeatureVersion", this.FeatureVersion);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "EngineRegion", this.EngineRegion);
            this.SetParamSimple(map, prefix + "IngressClassName", this.IngressClassName);
            this.SetParamSimple(map, prefix + "TradeType", this.TradeType);
            this.SetParamObj(map, prefix + "InternetConfig.", this.InternetConfig);
            this.SetParamSimple(map, prefix + "PromId", this.PromId);
        }
    }
}

