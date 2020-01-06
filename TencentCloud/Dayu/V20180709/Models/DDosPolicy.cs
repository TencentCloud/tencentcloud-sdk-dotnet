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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDosPolicy : AbstractModel
    {
        
        /// <summary>
        /// 策略绑定的资源
        /// </summary>
        [JsonProperty("Resources")]
        public ResourceIp[] Resources{ get; set; }

        /// <summary>
        /// 禁用协议
        /// </summary>
        [JsonProperty("DropOptions")]
        public DDoSPolicyDropOption DropOptions{ get; set; }

        /// <summary>
        /// 禁用端口
        /// </summary>
        [JsonProperty("PortLimits")]
        public DDoSPolicyPortLimit[] PortLimits{ get; set; }

        /// <summary>
        /// 报文过滤
        /// </summary>
        [JsonProperty("PacketFilters")]
        public DDoSPolicyPacketFilter[] PacketFilters{ get; set; }

        /// <summary>
        /// 黑白IP名单
        /// </summary>
        [JsonProperty("IpBlackWhiteLists")]
        public IpBlackWhite[] IpBlackWhiteLists{ get; set; }

        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 策略创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 水印策略参数，最多只有一个，当没有水印策略时数组为空
        /// </summary>
        [JsonProperty("WaterPrint")]
        public WaterPrintPolicy[] WaterPrint{ get; set; }

        /// <summary>
        /// 水印密钥，最多只有2个，当没有水印策略时数组为空
        /// </summary>
        [JsonProperty("WaterKey")]
        public WaterPrintKey[] WaterKey{ get; set; }

        /// <summary>
        /// 策略绑定的资源实例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BoundResources")]
        public string[] BoundResources{ get; set; }

        /// <summary>
        /// 策略所属的策略场景
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SceneId")]
        public string SceneId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
            this.SetParamObj(map, prefix + "DropOptions.", this.DropOptions);
            this.SetParamArrayObj(map, prefix + "PortLimits.", this.PortLimits);
            this.SetParamArrayObj(map, prefix + "PacketFilters.", this.PacketFilters);
            this.SetParamArrayObj(map, prefix + "IpBlackWhiteLists.", this.IpBlackWhiteLists);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "WaterPrint.", this.WaterPrint);
            this.SetParamArrayObj(map, prefix + "WaterKey.", this.WaterKey);
            this.SetParamArraySimple(map, prefix + "BoundResources.", this.BoundResources);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
        }
    }
}

