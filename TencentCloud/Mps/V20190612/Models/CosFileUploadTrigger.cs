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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosFileUploadTrigger : AbstractModel
    {
        
        /// <summary>
        /// 工作流绑定的 COS Bucket 名，如 TopRankVideo-125xxx88。
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// 工作流绑定的 COS Bucket 所属园区，如 ap-chongiqng。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 工作流绑定的输入路径目录，如`/movie/201907/`，不填代表根目录`/`。
        /// </summary>
        [JsonProperty("Dir")]
        public string Dir{ get; set; }

        /// <summary>
        /// 工作流允许触发的文件格式列表，如 ["mp4", "flv", "mov"]。不填代表所有格式的文件都可以触发工作流。
        /// </summary>
        [JsonProperty("Formats")]
        public string[] Formats{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Dir", this.Dir);
            this.SetParamArraySimple(map, prefix + "Formats.", this.Formats);
        }
    }
}

