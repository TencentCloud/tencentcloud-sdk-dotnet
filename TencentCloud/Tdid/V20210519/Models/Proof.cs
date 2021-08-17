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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Proof : AbstractModel
    {
        
        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("Created")]
        public long? Created{ get; set; }

        /// <summary>
        /// 创建着did
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// salt值
        /// </summary>
        [JsonProperty("SaltJson")]
        public string SaltJson{ get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("SignatureValue")]
        public string SignatureValue{ get; set; }

        /// <summary>
        /// type类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Created", this.Created);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "SaltJson", this.SaltJson);
            this.SetParamSimple(map, prefix + "SignatureValue", this.SignatureValue);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

