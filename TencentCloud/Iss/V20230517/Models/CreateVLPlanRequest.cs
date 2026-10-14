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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVLPlanRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>计划名称，仅支持中文/英文/数字/_/-，最长 32 个字符</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>关联的视觉理解模板 ID</p>
        /// </summary>
        [JsonProperty("VLTemplateId")]
        public string VLTemplateId{ get; set; }

        /// <summary>
        /// <p>计划描述，最长 256 个字符</p>
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// <p>截图文件存储天数，范围 [7, 1080]；图片模式必填，视频模式不传</p>
        /// </summary>
        [JsonProperty("FileExpires")]
        public long? FileExpires{ get; set; }

        /// <summary>
        /// <p>回调通知配置</p>
        /// </summary>
        [JsonProperty("Callback")]
        public CallbackURL Callback{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "VLTemplateId", this.VLTemplateId);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamSimple(map, prefix + "FileExpires", this.FileExpires);
            this.SetParamObj(map, prefix + "Callback.", this.Callback);
        }
    }
}

