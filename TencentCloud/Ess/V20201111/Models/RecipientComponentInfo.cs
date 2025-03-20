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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecipientComponentInfo : AbstractModel
    {
        
        /// <summary>
        /// 签署方经办人在合同流程中的参与方ID，与控件绑定，是控件的归属方
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }

        /// <summary>
        /// 参与方填写状态
        /// <ul>
        /// <li>**空值** : 此参与方没有填写控件</li>
        /// <li>**0**:  未填写, 表示此参与方还没有填写合同的填写控件</li>
        /// <li>**1**:  已填写, 表示此参与方已经填写所有的填写控件</li></ul>
        /// </summary>
        [JsonProperty("RecipientFillStatus")]
        public string RecipientFillStatus{ get; set; }

        /// <summary>
        /// 是否为发起方
        /// <ul><li>true-发起方</li>
        /// <li>false-参与方</li></ul>
        /// </summary>
        [JsonProperty("IsPromoter")]
        public bool? IsPromoter{ get; set; }

        /// <summary>
        /// 改参与方填写控件信息列表
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

