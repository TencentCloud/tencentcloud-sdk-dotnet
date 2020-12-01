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

    public class AdvancedAuthentication : AbstractModel
    {
        
        /// <summary>
        /// 防盗链配置开关，on或off，开启时必须且只能配置一种模式，其余模式为null。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 时间戳防盗链高级版模式A配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TypeA")]
        public AdvancedAuthenticationTypeA TypeA{ get; set; }

        /// <summary>
        /// 时间戳防盗链高级版模式B配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TypeB")]
        public AdvancedAuthenticationTypeB TypeB{ get; set; }

        /// <summary>
        /// 时间戳防盗链高级版模式C配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TypeC")]
        public AdvancedAuthenticationTypeC TypeC{ get; set; }

        /// <summary>
        /// 时间戳防盗链高级版模式D配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TypeD")]
        public AdvancedAuthenticationTypeD TypeD{ get; set; }

        /// <summary>
        /// 时间戳防盗链高级版模式E配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TypeE")]
        public AdvancedAuthenticationTypeE TypeE{ get; set; }

        /// <summary>
        /// 时间戳防盗链高级版模式F配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TypeF")]
        public AdvancedAuthenticationTypeF TypeF{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamObj(map, prefix + "TypeA.", this.TypeA);
            this.SetParamObj(map, prefix + "TypeB.", this.TypeB);
            this.SetParamObj(map, prefix + "TypeC.", this.TypeC);
            this.SetParamObj(map, prefix + "TypeD.", this.TypeD);
            this.SetParamObj(map, prefix + "TypeE.", this.TypeE);
            this.SetParamObj(map, prefix + "TypeF.", this.TypeF);
        }
    }
}

