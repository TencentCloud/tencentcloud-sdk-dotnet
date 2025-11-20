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

    public class ContractReviewWebUrlOption : AbstractModel
    {
        
        /// <summary>
        /// 禁用暂存。 默认 false，设置为 true 会隐藏界面上的临时保存按钮
        /// </summary>
        [JsonProperty("DisableTemporaryStore")]
        public bool? DisableTemporaryStore{ get; set; }

        /// <summary>
        /// 禁用导出。默认 false，设置为 true 会隐藏界面上的导出按钮
        /// </summary>
        [JsonProperty("DisableExport")]
        public bool? DisableExport{ get; set; }

        /// <summary>
        /// 禁用重新审查。默认 false，设置为 true 会隐藏界面上的重新审查按钮
        /// </summary>
        [JsonProperty("DisableReviewAgain")]
        public bool? DisableReviewAgain{ get; set; }

        /// <summary>
        /// 禁用二维码分享。默认 false，设置为 true 会隐藏界面上的分享二维码
        /// </summary>
        [JsonProperty("DisableWxQrcode")]
        public bool? DisableWxQrcode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DisableTemporaryStore", this.DisableTemporaryStore);
            this.SetParamSimple(map, prefix + "DisableExport", this.DisableExport);
            this.SetParamSimple(map, prefix + "DisableReviewAgain", this.DisableReviewAgain);
            this.SetParamSimple(map, prefix + "DisableWxQrcode", this.DisableWxQrcode);
        }
    }
}

