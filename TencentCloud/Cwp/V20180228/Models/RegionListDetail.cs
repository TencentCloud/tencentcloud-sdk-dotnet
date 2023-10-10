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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegionListDetail : AbstractModel
    {
        
        /// <summary>
        /// 机器类型
        /// CVM 腾讯云云服务器
        /// LH 腾讯云轻量服务器
        /// ECM 腾讯云边缘计算服务器
        /// BM 腾讯云黑石1.0 服务器
        /// Other  其他服务器(非腾讯云)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// 0 腾讯云
        /// 1 IDC机房
        /// 2 阿里云
        /// 3 华为云
        /// 4 亚马逊
        /// 5 微软
        /// 6 Google
        /// 7 Oracle
        /// 8 Digital Ocean
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloudFrom")]
        public ulong? CloudFrom{ get; set; }

        /// <summary>
        /// 地域列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegionList")]
        public RegionInfo[] RegionList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "CloudFrom", this.CloudFrom);
            this.SetParamArrayObj(map, prefix + "RegionList.", this.RegionList);
        }
    }
}

