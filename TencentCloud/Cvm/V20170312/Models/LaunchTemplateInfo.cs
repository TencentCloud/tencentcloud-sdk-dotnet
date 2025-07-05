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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LaunchTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例启动模版本号。
        /// </summary>
        [JsonProperty("LatestVersionNumber")]
        public ulong? LatestVersionNumber{ get; set; }

        /// <summary>
        /// 实例启动模板ID。
        /// </summary>
        [JsonProperty("LaunchTemplateId")]
        public string LaunchTemplateId{ get; set; }

        /// <summary>
        /// 实例启动模板名。
        /// </summary>
        [JsonProperty("LaunchTemplateName")]
        public string LaunchTemplateName{ get; set; }

        /// <summary>
        /// 实例启动模板默认版本号。
        /// </summary>
        [JsonProperty("DefaultVersionNumber")]
        public ulong? DefaultVersionNumber{ get; set; }

        /// <summary>
        /// 实例启动模板包含的版本总数量。
        /// </summary>
        [JsonProperty("LaunchTemplateVersionCount")]
        public ulong? LaunchTemplateVersionCount{ get; set; }

        /// <summary>
        /// 创建该模板的用户UIN。
        /// </summary>
        [JsonProperty("CreatedBy")]
        public string CreatedBy{ get; set; }

        /// <summary>
        /// 创建该模板的时间。
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LatestVersionNumber", this.LatestVersionNumber);
            this.SetParamSimple(map, prefix + "LaunchTemplateId", this.LaunchTemplateId);
            this.SetParamSimple(map, prefix + "LaunchTemplateName", this.LaunchTemplateName);
            this.SetParamSimple(map, prefix + "DefaultVersionNumber", this.DefaultVersionNumber);
            this.SetParamSimple(map, prefix + "LaunchTemplateVersionCount", this.LaunchTemplateVersionCount);
            this.SetParamSimple(map, prefix + "CreatedBy", this.CreatedBy);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
        }
    }
}

