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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecipientComponentInfo : AbstractModel
    {
        
        /// <summary>
        /// 参与方的角色ID
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }

        /// <summary>
        /// 参与方填写状态
        /// 
        /// <ul><li> **0** : 还没有填写</li>
        /// <li> **1** : 已经填写</li></ul>
        /// </summary>
        [JsonProperty("RecipientFillStatus")]
        public string RecipientFillStatus{ get; set; }

        /// <summary>
        /// 此角色是否是发起方角色
        /// 
        /// <ul><li> **true** : 是发起方角色</li>
        /// <li> **false** : 不是发起方角色</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsPromoter")]
        public bool? IsPromoter{ get; set; }

        /// <summary>
        /// 此角色的填写控件列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Components")]
        public FilledComponent[] Components{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecipientId", this.RecipientId);
            this.SetParamSimple(map, prefix + "RecipientFillStatus", this.RecipientFillStatus);
            this.SetParamSimple(map, prefix + "IsPromoter", this.IsPromoter);
            this.SetParamArrayObj(map, prefix + "Components.", this.Components);
        }
    }
}

