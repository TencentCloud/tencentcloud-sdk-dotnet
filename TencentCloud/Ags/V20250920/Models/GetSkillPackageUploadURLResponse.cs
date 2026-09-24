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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetSkillPackageUploadURLResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>Version 详情（Revision 不变）。</p>
        /// </summary>
        [JsonProperty("Version")]
        public CloudRecordVersion Version{ get; set; }

        /// <summary>
        /// <p>新的 COS PUT 预签名 URL。</p>
        /// </summary>
        [JsonProperty("UploadURL")]
        public string UploadURL{ get; set; }

        /// <summary>
        /// <p>重试后的内容状态。</p>
        /// </summary>
        [JsonProperty("ContentStatus")]
        public string ContentStatus{ get; set; }

        /// <summary>
        /// <p>UploadURL 过期时间。</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

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
            this.SetParamObj(map, prefix + "Version.", this.Version);
            this.SetParamSimple(map, prefix + "UploadURL", this.UploadURL);
            this.SetParamSimple(map, prefix + "ContentStatus", this.ContentStatus);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

