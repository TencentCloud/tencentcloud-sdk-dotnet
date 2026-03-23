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

namespace TencentCloud.Apis.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentCredentialContentDTO : AbstractModel
    {
        
        /// <summary>
        /// 如果认证类型为sts时，该项必填
        /// </summary>
        [JsonProperty("STSSystem")]
        public string STSSystem{ get; set; }

        /// <summary>
        /// 如果认证类型为sts时，该项必填
        /// </summary>
        [JsonProperty("STSService")]
        public string STSService{ get; set; }

        /// <summary>
        /// 如果认证类型为reqKey时，该项必填
        /// </summary>
        [JsonProperty("Headers")]
        public AgentCredentialContentHeaderDTO[] Headers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "STSSystem", this.STSSystem);
            this.SetParamSimple(map, prefix + "STSService", this.STSService);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
        }
    }
}

