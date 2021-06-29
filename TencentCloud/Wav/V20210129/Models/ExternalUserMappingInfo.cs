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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExternalUserMappingInfo : AbstractModel
    {
        
        /// <summary>
        /// 企业主体对应的外部联系人userId
        /// </summary>
        [JsonProperty("CorpExternalUserId")]
        public string CorpExternalUserId{ get; set; }

        /// <summary>
        /// 乐销车应用主体对应的外部联系人, 当不存在好友关系时，该字段值为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalUserId")]
        public string ExternalUserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CorpExternalUserId", this.CorpExternalUserId);
            this.SetParamSimple(map, prefix + "ExternalUserId", this.ExternalUserId);
        }
    }
}

