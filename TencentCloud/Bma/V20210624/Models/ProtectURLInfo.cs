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

namespace TencentCloud.Bma.V20210624.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProtectURLInfo : AbstractModel
    {
        
        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("ProtectURLId")]
        public long? ProtectURLId{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("ProtectURL")]
        public string ProtectURL{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("ProtectWeb")]
        public string ProtectWeb{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("ProtectURLStatus")]
        public long? ProtectURLStatus{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("ProtectURLNote")]
        public string ProtectURLNote{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProtectURLId", this.ProtectURLId);
            this.SetParamSimple(map, prefix + "ProtectURL", this.ProtectURL);
            this.SetParamSimple(map, prefix + "ProtectWeb", this.ProtectWeb);
            this.SetParamSimple(map, prefix + "ProtectURLStatus", this.ProtectURLStatus);
            this.SetParamSimple(map, prefix + "ProtectURLNote", this.ProtectURLNote);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

