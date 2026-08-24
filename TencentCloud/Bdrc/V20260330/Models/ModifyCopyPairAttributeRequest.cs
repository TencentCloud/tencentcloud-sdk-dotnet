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

    public class ModifyCopyPairAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 要修改属性的复制对id
        /// </summary>
        [JsonProperty("CopyPairId")]
        public string CopyPairId{ get; set; }

        /// <summary>
        /// 要修改的复制对类型，可选值：DISK、INSTANCE、CFS，默认 INSTANCE
        /// </summary>
        [JsonProperty("CopyPairType")]
        public string CopyPairType{ get; set; }

        /// <summary>
        /// 修改复制对名称（长度最大支持 64 个字符）
        /// </summary>
        [JsonProperty("CopyPairName")]
        public string CopyPairName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CopyPairId", this.CopyPairId);
            this.SetParamSimple(map, prefix + "CopyPairType", this.CopyPairType);
            this.SetParamSimple(map, prefix + "CopyPairName", this.CopyPairName);
        }
    }
}

