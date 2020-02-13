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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Authentication : AbstractModel
    {
        
        /// <summary>
        /// 防盗链配置开关
        /// on：开启
        /// off：关闭
        /// 开启时必须且只配置一种模式，其余模式需要设置为 null
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 时间戳防盗链模式 A 配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TypeA")]
        public AuthenticationTypeA TypeA{ get; set; }

        /// <summary>
        /// 时间戳防盗链模式 B 配置（模式 B 后台升级中，暂时不支持配置）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TypeB")]
        public AuthenticationTypeB TypeB{ get; set; }

        /// <summary>
        /// 时间戳防盗链模式 C 配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TypeC")]
        public AuthenticationTypeC TypeC{ get; set; }

        /// <summary>
        /// 时间戳防盗链模式 D 配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TypeD")]
        public AuthenticationTypeD TypeD{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamObj(map, prefix + "TypeA.", this.TypeA);
            this.SetParamObj(map, prefix + "TypeB.", this.TypeB);
            this.SetParamObj(map, prefix + "TypeC.", this.TypeC);
            this.SetParamObj(map, prefix + "TypeD.", this.TypeD);
        }
    }
}

