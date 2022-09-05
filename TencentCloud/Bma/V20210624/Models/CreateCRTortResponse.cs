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

    public class CreateCRTortResponse : AbstractModel
    {
        
        /// <summary>
        /// xx
        /// </summary>
        [JsonProperty("WorkId")]
        public long? WorkId{ get; set; }

        /// <summary>
        /// xx
        /// </summary>
        [JsonProperty("TortId")]
        public long? TortId{ get; set; }

        /// <summary>
        /// xx
        /// </summary>
        [JsonProperty("TortTitle")]
        public string TortTitle{ get; set; }

        /// <summary>
        /// xx
        /// </summary>
        [JsonProperty("TortPlat")]
        public string TortPlat{ get; set; }

        /// <summary>
        /// xx
        /// </summary>
        [JsonProperty("TortURL")]
        public string TortURL{ get; set; }

        /// <summary>
        /// xx
        /// </summary>
        [JsonProperty("TortDomain")]
        public string TortDomain{ get; set; }

        /// <summary>
        /// xx
        /// </summary>
        [JsonProperty("TortBodyName")]
        public string TortBodyName{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkId", this.WorkId);
            this.SetParamSimple(map, prefix + "TortId", this.TortId);
            this.SetParamSimple(map, prefix + "TortTitle", this.TortTitle);
            this.SetParamSimple(map, prefix + "TortPlat", this.TortPlat);
            this.SetParamSimple(map, prefix + "TortURL", this.TortURL);
            this.SetParamSimple(map, prefix + "TortDomain", this.TortDomain);
            this.SetParamSimple(map, prefix + "TortBodyName", this.TortBodyName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

