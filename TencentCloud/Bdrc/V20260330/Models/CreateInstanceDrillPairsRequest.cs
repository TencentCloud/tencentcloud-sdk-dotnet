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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceDrillPairsRequest : AbstractModel
    {
        
        /// <summary>
        /// 所属容灾保护组
        /// </summary>
        [JsonProperty("ProtectGroupId")]
        public string ProtectGroupId{ get; set; }

        /// <summary>
        /// 演练组vpc
        /// </summary>
        [JsonProperty("DrillPairGroupVpc")]
        public string DrillPairGroupVpc{ get; set; }

        /// <summary>
        /// 文件系统复制对名称,不传则新名称为“未命名”
        /// </summary>
        [JsonProperty("DrillPairGroupName")]
        public string DrillPairGroupName{ get; set; }

        /// <summary>
        /// 用于保证请求幂等性的字符串。该字符串由客户生成，需保证不同请求之间唯一，最大值不超过64个ASCII字符。若不指定该参数，则无法保证请求的幂等性
        /// </summary>
        [JsonProperty("CreationToken")]
        public string CreationToken{ get; set; }

        /// <summary>
        /// 指定创建入哪个演练组
        /// </summary>
        [JsonProperty("DrillPairGroupId")]
        public string DrillPairGroupId{ get; set; }

        /// <summary>
        /// 创建目标演练实例的参数列表
        /// </summary>
        [JsonProperty("CreateTargetInstanceParameters")]
        public CreateInstanceModel[] CreateTargetInstanceParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProtectGroupId", this.ProtectGroupId);
            this.SetParamSimple(map, prefix + "DrillPairGroupVpc", this.DrillPairGroupVpc);
            this.SetParamSimple(map, prefix + "DrillPairGroupName", this.DrillPairGroupName);
            this.SetParamSimple(map, prefix + "CreationToken", this.CreationToken);
            this.SetParamSimple(map, prefix + "DrillPairGroupId", this.DrillPairGroupId);
            this.SetParamArrayObj(map, prefix + "CreateTargetInstanceParameters.", this.CreateTargetInstanceParameters);
        }
    }
}

