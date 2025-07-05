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

namespace TencentCloud.Bma.V20210624.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCRTortResponse : AbstractModel
    {
        
        /// <summary>
        /// 作品ID
        /// </summary>
        [JsonProperty("WorkId")]
        public long? WorkId{ get; set; }

        /// <summary>
        /// 侵权ID
        /// </summary>
        [JsonProperty("TortId")]
        public long? TortId{ get; set; }

        /// <summary>
        /// 侵权标题
        /// </summary>
        [JsonProperty("TortTitle")]
        public string TortTitle{ get; set; }

        /// <summary>
        /// 侵权平台
        /// </summary>
        [JsonProperty("TortPlat")]
        public string TortPlat{ get; set; }

        /// <summary>
        /// 侵权网址
        /// </summary>
        [JsonProperty("TortURL")]
        public string TortURL{ get; set; }

        /// <summary>
        /// 侵权域名
        /// </summary>
        [JsonProperty("TortDomain")]
        public string TortDomain{ get; set; }

        /// <summary>
        /// 侵权主体
        /// </summary>
        [JsonProperty("TortBodyName")]
        public string TortBodyName{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
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

