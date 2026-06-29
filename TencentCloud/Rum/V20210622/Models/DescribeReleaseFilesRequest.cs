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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeReleaseFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>项目 id</p>
        /// </summary>
        [JsonProperty("ProjectID")]
        public long? ProjectID{ get; set; }

        /// <summary>
        /// <p>文件版本</p>
        /// </summary>
        [JsonProperty("FileVersion")]
        public string FileVersion{ get; set; }

        /// <summary>
        /// <p>查询过滤条件（根据sourcemap的文件名模糊匹配）</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>false/不传=保留「最近 3 个月」约束（旧行为）；true=绕过时间窗口</p>
        /// </summary>
        [JsonProperty("IgnoreDefaultTimeRange")]
        public bool? IgnoreDefaultTimeRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectID", this.ProjectID);
            this.SetParamSimple(map, prefix + "FileVersion", this.FileVersion);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "IgnoreDefaultTimeRange", this.IgnoreDefaultTimeRange);
        }
    }
}

