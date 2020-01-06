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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCcnAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// CCN实例ID。形如：ccn-f49l6u0z。
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// CCN名称，最大长度不能超过60个字节。
        /// </summary>
        [JsonProperty("CcnName")]
        public string CcnName{ get; set; }

        /// <summary>
        /// CCN描述信息，最大长度不能超过100个字节。
        /// </summary>
        [JsonProperty("CcnDescription")]
        public string CcnDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "CcnName", this.CcnName);
            this.SetParamSimple(map, prefix + "CcnDescription", this.CcnDescription);
        }
    }
}

