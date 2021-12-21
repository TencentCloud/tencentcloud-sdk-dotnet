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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LaunchTemplateVersionInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例启动模板版本号。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LaunchTemplateVersion")]
        public ulong? LaunchTemplateVersion{ get; set; }

        /// <summary>
        /// 实例启动模板版本数据详情。
        /// </summary>
        [JsonProperty("LaunchTemplateVersionData")]
        public LaunchTemplateVersionData LaunchTemplateVersionData{ get; set; }

        /// <summary>
        /// 实例启动模板版本创建时间。
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 实例启动模板ID。
        /// </summary>
        [JsonProperty("LaunchTemplateId")]
        public string LaunchTemplateId{ get; set; }

        /// <summary>
        /// 是否为默认启动模板版本。
        /// </summary>
        [JsonProperty("IsDefaultVersion")]
        public bool? IsDefaultVersion{ get; set; }

        /// <summary>
        /// 实例启动模板版本描述信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LaunchTemplateVersionDescription")]
        public string LaunchTemplateVersionDescription{ get; set; }

        /// <summary>
        /// 创建者。
        /// </summary>
        [JsonProperty("CreatedBy")]
        public string CreatedBy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LaunchTemplateVersion", this.LaunchTemplateVersion);
            this.SetParamObj(map, prefix + "LaunchTemplateVersionData.", this.LaunchTemplateVersionData);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "LaunchTemplateId", this.LaunchTemplateId);
            this.SetParamSimple(map, prefix + "IsDefaultVersion", this.IsDefaultVersion);
            this.SetParamSimple(map, prefix + "LaunchTemplateVersionDescription", this.LaunchTemplateVersionDescription);
            this.SetParamSimple(map, prefix + "CreatedBy", this.CreatedBy);
        }
    }
}

