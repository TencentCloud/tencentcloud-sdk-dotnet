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

    public class ModifyLaunchTemplateDefaultVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 启动模板ID。可通过 [DescribeLaunchTemplates](https://cloud.tencent.com/document/api/213/66322) 接口返回值中的`LaunchTemplateId `获取。
        /// </summary>
        [JsonProperty("LaunchTemplateId")]
        public string LaunchTemplateId{ get; set; }

        /// <summary>
        /// 待设置的默认版本号。可通过 [DescribeLaunchTemplateVersions](https://cloud.tencent.com/document/api/213/66323) 接口返回值中的`LaunchTemplateVersion`获取。
        /// </summary>
        [JsonProperty("DefaultVersion")]
        public long? DefaultVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LaunchTemplateId", this.LaunchTemplateId);
            this.SetParamSimple(map, prefix + "DefaultVersion", this.DefaultVersion);
        }
    }
}

