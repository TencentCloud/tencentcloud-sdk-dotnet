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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PatchInfoDetail : AbstractModel
    {
        
        /// <summary>
        /// KB编号
        /// </summary>
        [JsonProperty("KBNo")]
        public string KBNo{ get; set; }

        /// <summary>
        /// KB名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 2025-05
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// KB影响的漏洞
        /// </summary>
        [JsonProperty("RelatedCveId")]
        public string[] RelatedCveId{ get; set; }

        /// <summary>
        /// KB说明文档
        /// </summary>
        [JsonProperty("KbDocUrl")]
        public string KbDocUrl{ get; set; }

        /// <summary>
        /// KB id编号
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KBNo", this.KBNo);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamArraySimple(map, prefix + "RelatedCveId.", this.RelatedCveId);
            this.SetParamSimple(map, prefix + "KbDocUrl", this.KbDocUrl);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

