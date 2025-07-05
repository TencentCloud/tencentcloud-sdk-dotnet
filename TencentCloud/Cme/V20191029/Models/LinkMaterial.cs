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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LinkMaterial : AbstractModel
    {
        
        /// <summary>
        /// 链接类型取值:
        /// <li>CLASS: 分类链接;</li>
        /// <li> MATERIAL：素材链接。</li>
        /// </summary>
        [JsonProperty("LinkType")]
        public string LinkType{ get; set; }

        /// <summary>
        /// 链接状态取值：
        /// <li> Normal：正常 ；</li>
        /// <li>NotFound：链接目标不存在；</li> <li>Forbidden：无权限。</li>
        /// </summary>
        [JsonProperty("LinkStatus")]
        public string LinkStatus{ get; set; }

        /// <summary>
        /// 素材链接详细信息，当LinkType="MATERIAL"时有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LinkMaterialInfo")]
        public LinkMaterialInfo LinkMaterialInfo{ get; set; }

        /// <summary>
        /// 分类链接目标信息，当LinkType=“CLASS”时有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LinkClassInfo")]
        public ClassInfo LinkClassInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LinkType", this.LinkType);
            this.SetParamSimple(map, prefix + "LinkStatus", this.LinkStatus);
            this.SetParamObj(map, prefix + "LinkMaterialInfo.", this.LinkMaterialInfo);
            this.SetParamObj(map, prefix + "LinkClassInfo.", this.LinkClassInfo);
        }
    }
}

