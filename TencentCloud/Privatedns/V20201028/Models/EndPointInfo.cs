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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EndPointInfo : AbstractModel
    {
        
        /// <summary>
        /// 终端节点ID
        /// </summary>
        [JsonProperty("EndPointId")]
        public string EndPointId{ get; set; }

        /// <summary>
        /// 终端节点名称
        /// </summary>
        [JsonProperty("EndPointName")]
        public string EndPointName{ get; set; }

        /// <summary>
        /// 终端节点服务ID
        /// </summary>
        [JsonProperty("EndPointServiceId")]
        public string EndPointServiceId{ get; set; }

        /// <summary>
        /// 终端节点VIP列表
        /// </summary>
        [JsonProperty("EndPointVipSet")]
        public string[] EndPointVipSet{ get; set; }

        /// <summary>
        /// ap-guangzhou
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegionCode")]
        public string RegionCode{ get; set; }

        /// <summary>
        /// 标签键值对集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndPointId", this.EndPointId);
            this.SetParamSimple(map, prefix + "EndPointName", this.EndPointName);
            this.SetParamSimple(map, prefix + "EndPointServiceId", this.EndPointServiceId);
            this.SetParamArraySimple(map, prefix + "EndPointVipSet.", this.EndPointVipSet);
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

