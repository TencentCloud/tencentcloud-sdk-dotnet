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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WebUrlOption : AbstractModel
    {
        
        /// <summary>
        /// 禁用链接预览
        /// </summary>
        [JsonProperty("DisableLinkPreview")]
        public bool? DisableLinkPreview{ get; set; }

        /// <summary>
        /// 禁用任务编辑
        /// </summary>
        [JsonProperty("DisableTaskEditing")]
        public bool? DisableTaskEditing{ get; set; }

        /// <summary>
        /// 禁用任务结果编辑
        /// </summary>
        [JsonProperty("DisableTaskResultEditing")]
        public bool? DisableTaskResultEditing{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DisableLinkPreview", this.DisableLinkPreview);
            this.SetParamSimple(map, prefix + "DisableTaskEditing", this.DisableTaskEditing);
            this.SetParamSimple(map, prefix + "DisableTaskResultEditing", this.DisableTaskResultEditing);
        }
    }
}

